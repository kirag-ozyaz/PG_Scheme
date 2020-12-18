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

    [Serializable, XmlRoot("dsFind"), ToolboxItem(true), DesignerCategory("code"), HelpKeyword("vs.data.DataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
    internal class DataSetFind : DataSet
    {
        private System.Data.SchemaSerializationMode _schemaSerializationMode;
        private tAbnDataTable tabletAbn;
        private vG_AbnObjCntDataTable tablevG_AbnObjCnt;
        private vG_AbnObjCnt1DataTable tablevG_AbnObjCnt1;
        private vG_AbnObjCntShortDataTable tablevG_AbnObjCntShort;
        private vG_FindDataTable tablevG_Find;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public DataSetFind()
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            base.BeginInit();
            this.method_2();
            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_8);
            base.Tables.CollectionChanged += handler;
            base.Relations.CollectionChanged += handler;
            base.EndInit();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected DataSetFind(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0, false)
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
            {
                this.method_1(false);
                CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.method_8);
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
                    if (dataSet.Tables["vG_Find"] != null)
                    {
                        base.Tables.Add(new vG_FindDataTable(dataSet.Tables["vG_Find"]));
                    }
                    if (dataSet.Tables["vG_AbnObjCntShort"] != null)
                    {
                        base.Tables.Add(new vG_AbnObjCntShortDataTable(dataSet.Tables["vG_AbnObjCntShort"]));
                    }
                    if (dataSet.Tables["tAbn"] != null)
                    {
                        base.Tables.Add(new tAbnDataTable(dataSet.Tables["tAbn"]));
                    }
                    if (dataSet.Tables["vG_AbnObjCnt"] != null)
                    {
                        base.Tables.Add(new vG_AbnObjCntDataTable(dataSet.Tables["vG_AbnObjCnt"]));
                    }
                    if (dataSet.Tables["vG_AbnObjCnt1"] != null)
                    {
                        base.Tables.Add(new vG_AbnObjCnt1DataTable(dataSet.Tables["vG_AbnObjCnt1"]));
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
                CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_8);
                base.Tables.CollectionChanged += handler;
                this.Relations.CollectionChanged += handler;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public override DataSet Clone()
        {
            DataSetFind find1 = (DataSetFind) base.Clone();
            find1.method_0();
            find1.SchemaSerializationMode = this.SchemaSerializationMode;
            return find1;
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        internal void method_0()
        {
            this.method_1(true);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void method_1(bool bool_0)
        {
            this.tablevG_Find = (vG_FindDataTable) base.Tables["vG_Find"];
            if (bool_0 && (this.tablevG_Find != null))
            {
                this.tablevG_Find.method_2();
            }
            this.tablevG_AbnObjCntShort = (vG_AbnObjCntShortDataTable) base.Tables["vG_AbnObjCntShort"];
            if (bool_0 && (this.tablevG_AbnObjCntShort != null))
            {
                this.tablevG_AbnObjCntShort.method_2();
            }
            this.tabletAbn = (tAbnDataTable) base.Tables["tAbn"];
            if (bool_0 && (this.tabletAbn != null))
            {
                this.tabletAbn.method_3();
            }
            this.tablevG_AbnObjCnt = (vG_AbnObjCntDataTable) base.Tables["vG_AbnObjCnt"];
            if (bool_0 && (this.tablevG_AbnObjCnt != null))
            {
                this.tablevG_AbnObjCnt.method_2();
            }
            this.tablevG_AbnObjCnt1 = (vG_AbnObjCnt1DataTable) base.Tables["vG_AbnObjCnt1"];
            if (bool_0 && (this.tablevG_AbnObjCnt1 != null))
            {
                this.tablevG_AbnObjCnt1.method_2();
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_2()
        {
            base.DataSetName = "dsFind";
            base.Prefix = "";
            base.Namespace = "http://tempuri.org/dsFind.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tablevG_Find = new vG_FindDataTable();
            base.Tables.Add(this.tablevG_Find);
            this.tablevG_AbnObjCntShort = new vG_AbnObjCntShortDataTable();
            base.Tables.Add(this.tablevG_AbnObjCntShort);
            this.tabletAbn = new tAbnDataTable();
            base.Tables.Add(this.tabletAbn);
            this.tablevG_AbnObjCnt = new vG_AbnObjCntDataTable();
            base.Tables.Add(this.tablevG_AbnObjCnt);
            this.tablevG_AbnObjCnt1 = new vG_AbnObjCnt1DataTable();
            base.Tables.Add(this.tablevG_AbnObjCnt1);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_3()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
        private void method_8(object sender, CollectionChangeEventArgs e)
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
                if (dataSet.Tables["vG_Find"] != null)
                {
                    base.Tables.Add(new vG_FindDataTable(dataSet.Tables["vG_Find"]));
                }
                if (dataSet.Tables["vG_AbnObjCntShort"] != null)
                {
                    base.Tables.Add(new vG_AbnObjCntShortDataTable(dataSet.Tables["vG_AbnObjCntShort"]));
                }
                if (dataSet.Tables["tAbn"] != null)
                {
                    base.Tables.Add(new tAbnDataTable(dataSet.Tables["tAbn"]));
                }
                if (dataSet.Tables["vG_AbnObjCnt"] != null)
                {
                    base.Tables.Add(new vG_AbnObjCntDataTable(dataSet.Tables["vG_AbnObjCnt"]));
                }
                if (dataSet.Tables["vG_AbnObjCnt1"] != null)
                {
                    base.Tables.Add(new vG_AbnObjCnt1DataTable(dataSet.Tables["vG_AbnObjCnt1"]));
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
        {
            DataSetFind find = new DataSetFind();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            XmlSchemaAny item = new XmlSchemaAny {
                Namespace = find.Namespace
            };
            sequence.Items.Add(item);
            type.Particle = sequence;
            XmlSchema schemaSerializable = find.GetSchemaSerializable();
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [Browsable(true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), DebuggerNonUserCode]
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

        [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tAbnDataTable tAbn
        {
            get
            {
                return this.tabletAbn;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public vG_AbnObjCntDataTable vG_AbnObjCnt
        {
            get
            {
                return this.tablevG_AbnObjCnt;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
        public vG_AbnObjCnt1DataTable vG_AbnObjCnt1
        {
            get
            {
                return this.tablevG_AbnObjCnt1;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public vG_AbnObjCntShortDataTable vG_AbnObjCntShort
        {
            get
            {
                return this.tablevG_AbnObjCntShort;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
        public vG_FindDataTable vG_Find
        {
            get
            {
                return this.tablevG_Find;
            }
        }

        public class Class405 : DataRow
        {
            private DataSetFind.vG_FindDataTable vG_FindDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class405(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vG_FindDataTable_0 = (DataSetFind.vG_FindDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vG_FindDataTable_0.CodeAbonentColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vG_FindDataTable_0.CodeAbonentColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.vG_FindDataTable_0.idAbnObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_11()
            {
                base[this.vG_FindDataTable_0.idAbnObjColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_FindDataTable_0.ObjNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ObjName' in table 'vG_Find' is DBNull.", exception);
                }
                return str;
            }

            public void method_3(string string_0)
            {
                base[this.vG_FindDataTable_0.ObjNameColumn] = string_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_FindDataTable_0.idAbnObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idAbnObj' in table 'vG_Find' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.vG_FindDataTable_0.idAbnObjColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.vG_FindDataTable_0.NameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.vG_FindDataTable_0.NameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.vG_FindDataTable_0.ObjNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_9()
            {
                base[this.vG_FindDataTable_0.ObjNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idAbn
            {
                get
                {
                    return (int) base[this.vG_FindDataTable_0.idAbnColumn];
                }
                set
                {
                    base[this.vG_FindDataTable_0.idAbnColumn] = value;
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
                        str = (string) base[this.vG_FindDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'vG_Find' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vG_FindDataTable_0.NameColumn] = value;
                }
            }
        }

        public class Class406 : DataRow
        {
            private DataSetFind.vG_AbnObjCntShortDataTable vG_AbnObjCntShortDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class406(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vG_AbnObjCntShortDataTable_0 = (DataSetFind.vG_AbnObjCntShortDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vG_AbnObjCntShortDataTable_0.CodeAbonentColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vG_AbnObjCntShortDataTable_0.CodeAbonentColumn] = int_0;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCntShortDataTable_0.AbnWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'AbnWorker' in table 'vG_AbnObjCntShort' is DBNull.", exception);
                }
                return str;
            }

            public void method_3(string string_0)
            {
                base[this.vG_AbnObjCntShortDataTable_0.AbnWorkerColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_4()
            {
                return base.IsNull(this.vG_AbnObjCntShortDataTable_0.NameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5()
            {
                base[this.vG_AbnObjCntShortDataTable_0.NameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.vG_AbnObjCntShortDataTable_0.AbnWorkerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_7()
            {
                base[this.vG_AbnObjCntShortDataTable_0.AbnWorkerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idAbn
            {
                get
                {
                    return (int) base[this.vG_AbnObjCntShortDataTable_0.idAbnColumn];
                }
                set
                {
                    base[this.vG_AbnObjCntShortDataTable_0.idAbnColumn] = value;
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
                        str = (string) base[this.vG_AbnObjCntShortDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'vG_AbnObjCntShort' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vG_AbnObjCntShortDataTable_0.NameColumn] = value;
                }
            }
        }

        public class Class407 : DataRow
        {
            private DataSetFind.tAbnDataTable tAbnDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class407(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tAbnDataTable_0 = (DataSetFind.tAbnDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tAbnDataTable_0.CodeAbonentColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tAbnDataTable_0.CodeAbonentColumn] = int_0;
            }

            public int method_2()
            {
                return (int) base[this.tAbnDataTable_0.TypeAbnColumn];
            }

            public void method_3(int int_0)
            {
                base[this.tAbnDataTable_0.TypeAbnColumn] = int_0;
            }

            public bool method_4()
            {
                return (bool) base[this.tAbnDataTable_0.DeletedColumn];
            }

            public void method_5(bool bool_0)
            {
                base[this.tAbnDataTable_0.DeletedColumn] = bool_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.tAbnDataTable_0.NameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.tAbnDataTable_0.NameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idWorker
            {
                get
                {
                    return (int) base[this.tAbnDataTable_0.idWorkerColumn];
                }
                set
                {
                    base[this.tAbnDataTable_0.idWorkerColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tAbnDataTable_0.idColumn];
                }
                set
                {
                    base[this.tAbnDataTable_0.idColumn] = value;
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
                        str = (string) base[this.tAbnDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'tAbn' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tAbnDataTable_0.NameColumn] = value;
                }
            }
        }

        public class Class408 : DataRow
        {
            private DataSetFind.vG_AbnObjCntDataTable vG_AbnObjCntDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class408(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vG_AbnObjCntDataTable_0 = (DataSetFind.vG_AbnObjCntDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vG_AbnObjCntDataTable_0.CodeAbonentColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vG_AbnObjCntDataTable_0.CodeAbonentColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCntDataTable_0.idAbnObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idAbnObj' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.vG_AbnObjCntDataTable_0.idAbnObjColumn] = int_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCntDataTable_0.NumberObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NumberObj' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.vG_AbnObjCntDataTable_0.NumberObjColumn] = int_0;
            }

            public int method_14()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCntDataTable_0.NumberSubObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NumberSubObj' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(int int_0)
            {
                base[this.vG_AbnObjCntDataTable_0.NumberSubObjColumn] = int_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCntDataTable_0.TypeAbnColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TypeAbn' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.vG_AbnObjCntDataTable_0.TypeAbnColumn] = string_0;
            }

            public int method_18()
            {
                return (int) base[this.vG_AbnObjCntDataTable_0.idTypeAbnColumn];
            }

            public void method_19(int int_0)
            {
                base[this.vG_AbnObjCntDataTable_0.idTypeAbnColumn] = int_0;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCntDataTable_0.ObjNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ObjName' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return str;
            }

            public int method_20()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCntDataTable_0.idNetColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idNet' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return num;
            }

            public void method_21(int int_0)
            {
                base[this.vG_AbnObjCntDataTable_0.idNetColumn] = int_0;
            }

            public int method_22()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCntDataTable_0.idSaleColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idSale' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return num;
            }

            public void method_23(int int_0)
            {
                base[this.vG_AbnObjCntDataTable_0.idSaleColumn] = int_0;
            }

            public int method_24()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCntDataTable_0.FlagColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Flag' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(int int_0)
            {
                base[this.vG_AbnObjCntDataTable_0.FlagColumn] = int_0;
            }

            public DateTime method_26()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vG_AbnObjCntDataTable_0.DateOnColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateOn' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return time;
            }

            public void method_27(DateTime dateTime_0)
            {
                base[this.vG_AbnObjCntDataTable_0.DateOnColumn] = dateTime_0;
            }

            public DateTime method_28()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vG_AbnObjCntDataTable_0.DateOffColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateOff' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return time;
            }

            public void method_29(DateTime dateTime_0)
            {
                base[this.vG_AbnObjCntDataTable_0.DateOffColumn] = dateTime_0;
            }

            public void method_3(string string_0)
            {
                base[this.vG_AbnObjCntDataTable_0.ObjNameColumn] = string_0;
            }

            public DateTime method_30()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vG_AbnObjCntDataTable_0.DateBeginColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateBegin' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return time;
            }

            public void method_31(DateTime dateTime_0)
            {
                base[this.vG_AbnObjCntDataTable_0.DateBeginColumn] = dateTime_0;
            }

            public DateTime method_32()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vG_AbnObjCntDataTable_0.DateEndColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateEnd' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return time;
            }

            public void method_33(DateTime dateTime_0)
            {
                base[this.vG_AbnObjCntDataTable_0.DateEndColumn] = dateTime_0;
            }

            public string method_34()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCntDataTable_0.CodeAbnStrColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CodeAbnStr' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return str;
            }

            public void method_35(string string_0)
            {
                base[this.vG_AbnObjCntDataTable_0.CodeAbnStrColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.NameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_37()
            {
                base[this.vG_AbnObjCntDataTable_0.NameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_38()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.ObjNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_39()
            {
                base[this.vG_AbnObjCntDataTable_0.ObjNameColumn] = Convert.DBNull;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCntDataTable_0.Name_GroupColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Name_Group' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return str;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_40()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.NumberColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_41()
            {
                base[this.vG_AbnObjCntDataTable_0.NumberColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.Name_GroupColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_43()
            {
                base[this.vG_AbnObjCntDataTable_0.Name_GroupColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_44()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.AbnWorkerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_45()
            {
                base[this.vG_AbnObjCntDataTable_0.AbnWorkerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_46()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.ObjWorkerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_47()
            {
                base[this.vG_AbnObjCntDataTable_0.ObjWorkerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_48()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.idAbnObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_49()
            {
                base[this.vG_AbnObjCntDataTable_0.idAbnObjColumn] = Convert.DBNull;
            }

            public void method_5(string string_0)
            {
                base[this.vG_AbnObjCntDataTable_0.Name_GroupColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.NumberObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.vG_AbnObjCntDataTable_0.NumberObjColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_52()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.NumberSubObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_53()
            {
                base[this.vG_AbnObjCntDataTable_0.NumberSubObjColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_54()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.TypeAbnColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.vG_AbnObjCntDataTable_0.TypeAbnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_56()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.idNetColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_57()
            {
                base[this.vG_AbnObjCntDataTable_0.idNetColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_58()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.idSaleColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_59()
            {
                base[this.vG_AbnObjCntDataTable_0.idSaleColumn] = Convert.DBNull;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCntDataTable_0.AbnWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'AbnWorker' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_60()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.FlagColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_61()
            {
                base[this.vG_AbnObjCntDataTable_0.FlagColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_62()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.DateOnColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_63()
            {
                base[this.vG_AbnObjCntDataTable_0.DateOnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_64()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.DateOffColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_65()
            {
                base[this.vG_AbnObjCntDataTable_0.DateOffColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_66()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.DateBeginColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_67()
            {
                base[this.vG_AbnObjCntDataTable_0.DateBeginColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_68()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.DateEndColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_69()
            {
                base[this.vG_AbnObjCntDataTable_0.DateEndColumn] = Convert.DBNull;
            }

            public void method_7(string string_0)
            {
                base[this.vG_AbnObjCntDataTable_0.AbnWorkerColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_70()
            {
                return base.IsNull(this.vG_AbnObjCntDataTable_0.CodeAbnStrColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_71()
            {
                base[this.vG_AbnObjCntDataTable_0.CodeAbnStrColumn] = Convert.DBNull;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCntDataTable_0.ObjWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ObjWorker' in table 'vG_AbnObjCnt' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.vG_AbnObjCntDataTable_0.ObjWorkerColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int idAbn
            {
                get
                {
                    return (int) base[this.vG_AbnObjCntDataTable_0.idAbnColumn];
                }
                set
                {
                    base[this.vG_AbnObjCntDataTable_0.idAbnColumn] = value;
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
                        str = (string) base[this.vG_AbnObjCntDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'vG_AbnObjCnt' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vG_AbnObjCntDataTable_0.NameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Number
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vG_AbnObjCntDataTable_0.NumberColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Number' in table 'vG_AbnObjCnt' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vG_AbnObjCntDataTable_0.NumberColumn] = value;
                }
            }
        }

        public class Class409 : DataRow
        {
            private DataSetFind.vG_AbnObjCnt1DataTable vG_AbnObjCnt1DataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class409(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vG_AbnObjCnt1DataTable_0 = (DataSetFind.vG_AbnObjCnt1DataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vG_AbnObjCnt1DataTable_0.CodeAbonentColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.CodeAbonentColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCnt1DataTable_0.idAbnObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idAbnObj' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.idAbnObjColumn] = int_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCnt1DataTable_0.NumberObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NumberObj' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.NumberObjColumn] = int_0;
            }

            public int method_14()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCnt1DataTable_0.NumberSubObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NumberSubObj' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(int int_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.NumberSubObjColumn] = int_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCnt1DataTable_0.TypeAbnColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TypeAbn' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.TypeAbnColumn] = string_0;
            }

            public int method_18()
            {
                return (int) base[this.vG_AbnObjCnt1DataTable_0.idTypeAbnColumn];
            }

            public void method_19(int int_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.idTypeAbnColumn] = int_0;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCnt1DataTable_0.ObjNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ObjName' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return str;
            }

            public int method_20()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCnt1DataTable_0.idNetColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idNet' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return num;
            }

            public void method_21(int int_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.idNetColumn] = int_0;
            }

            public int method_22()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCnt1DataTable_0.idSaleColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idSale' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return num;
            }

            public void method_23(int int_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.idSaleColumn] = int_0;
            }

            public int method_24()
            {
                int num;
                try
                {
                    num = (int) base[this.vG_AbnObjCnt1DataTable_0.FlagColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Flag' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(int int_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.FlagColumn] = int_0;
            }

            public DateTime method_26()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vG_AbnObjCnt1DataTable_0.DateOnColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateOn' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return time;
            }

            public void method_27(DateTime dateTime_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.DateOnColumn] = dateTime_0;
            }

            public DateTime method_28()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vG_AbnObjCnt1DataTable_0.DateOffColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateOff' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return time;
            }

            public void method_29(DateTime dateTime_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.DateOffColumn] = dateTime_0;
            }

            public void method_3(string string_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.ObjNameColumn] = string_0;
            }

            public DateTime method_30()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vG_AbnObjCnt1DataTable_0.DateBeginColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateBegin' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return time;
            }

            public void method_31(DateTime dateTime_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.DateBeginColumn] = dateTime_0;
            }

            public DateTime method_32()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vG_AbnObjCnt1DataTable_0.DateEndColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateEnd' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return time;
            }

            public void method_33(DateTime dateTime_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.DateEndColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_34()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.NameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_35()
            {
                base[this.vG_AbnObjCnt1DataTable_0.NameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_36()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.ObjNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_37()
            {
                base[this.vG_AbnObjCnt1DataTable_0.ObjNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.NumberColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_39()
            {
                base[this.vG_AbnObjCnt1DataTable_0.NumberColumn] = Convert.DBNull;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCnt1DataTable_0.Name_GroupColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Name_Group' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return str;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_40()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.Name_GroupColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_41()
            {
                base[this.vG_AbnObjCnt1DataTable_0.Name_GroupColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.AbnWorkerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_43()
            {
                base[this.vG_AbnObjCnt1DataTable_0.AbnWorkerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_44()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.ObjWorkerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.vG_AbnObjCnt1DataTable_0.ObjWorkerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_46()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.idAbnObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.vG_AbnObjCnt1DataTable_0.idAbnObjColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_48()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.NumberObjColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.vG_AbnObjCnt1DataTable_0.NumberObjColumn] = Convert.DBNull;
            }

            public void method_5(string string_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.Name_GroupColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.NumberSubObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.vG_AbnObjCnt1DataTable_0.NumberSubObjColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_52()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.TypeAbnColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_53()
            {
                base[this.vG_AbnObjCnt1DataTable_0.TypeAbnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_54()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.idNetColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.vG_AbnObjCnt1DataTable_0.idNetColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.idSaleColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_57()
            {
                base[this.vG_AbnObjCnt1DataTable_0.idSaleColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.FlagColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_59()
            {
                base[this.vG_AbnObjCnt1DataTable_0.FlagColumn] = Convert.DBNull;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCnt1DataTable_0.AbnWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'AbnWorker' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return str;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_60()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.DateOnColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_61()
            {
                base[this.vG_AbnObjCnt1DataTable_0.DateOnColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_62()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.DateOffColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_63()
            {
                base[this.vG_AbnObjCnt1DataTable_0.DateOffColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_64()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.DateBeginColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_65()
            {
                base[this.vG_AbnObjCnt1DataTable_0.DateBeginColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_66()
            {
                return base.IsNull(this.vG_AbnObjCnt1DataTable_0.DateEndColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_67()
            {
                base[this.vG_AbnObjCnt1DataTable_0.DateEndColumn] = Convert.DBNull;
            }

            public void method_7(string string_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.AbnWorkerColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vG_AbnObjCnt1DataTable_0.ObjWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ObjWorker' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.vG_AbnObjCnt1DataTable_0.ObjWorkerColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idAbn
            {
                get
                {
                    return (int) base[this.vG_AbnObjCnt1DataTable_0.idAbnColumn];
                }
                set
                {
                    base[this.vG_AbnObjCnt1DataTable_0.idAbnColumn] = value;
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
                        str = (string) base[this.vG_AbnObjCnt1DataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vG_AbnObjCnt1DataTable_0.NameColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Number
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vG_AbnObjCnt1DataTable_0.NumberColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Number' in table 'vG_AbnObjCnt1' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vG_AbnObjCnt1DataTable_0.NumberColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate256(object sender, DataSetFind.EventArgs252 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate257(object sender, DataSetFind.EventArgs253 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate258(object sender, DataSetFind.EventArgs254 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate259(object sender, DataSetFind.EventArgs255 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate260(object sender, DataSetFind.EventArgs256 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs252 : EventArgs
        {
            private DataSetFind.Class405 class405_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs252(DataSetFind.Class405 class405_1, DataRowAction dataRowAction_1)
            {
                this.class405_0 = class405_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetFind.Class405 method_0()
            {
                return this.class405_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs253 : EventArgs
        {
            private DataSetFind.Class406 class406_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs253(DataSetFind.Class406 class406_1, DataRowAction dataRowAction_1)
            {
                this.class406_0 = class406_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetFind.Class406 method_0()
            {
                return this.class406_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs254 : EventArgs
        {
            private DataSetFind.Class407 class407_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs254(DataSetFind.Class407 class407_1, DataRowAction dataRowAction_1)
            {
                this.class407_0 = class407_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetFind.Class407 method_0()
            {
                return this.class407_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs255 : EventArgs
        {
            private DataSetFind.Class408 class408_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs255(DataSetFind.Class408 class408_1, DataRowAction dataRowAction_1)
            {
                this.class408_0 = class408_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetFind.Class408 method_0()
            {
                return this.class408_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs256 : EventArgs
        {
            private DataSetFind.Class409 class409_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs256(DataSetFind.Class409 class409_1, DataRowAction dataRowAction_1)
            {
                this.class409_0 = class409_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetFind.Class409 method_0()
            {
                return this.class409_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tAbnDataTable : TypedTableBase<DataSetFind.Class407>
        {
            private DataColumn columnCodeAbonent;
            private DataColumn columnDeleted;
            private DataColumn columnid;
            private DataColumn columnidWorker;
            private DataColumn columnName;
            private DataColumn columnTypeAbn;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate258 tAbnRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate258 tAbnRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate258 tAbnRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate258 tAbnRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tAbnDataTable()
            {
                base.TableName = "tAbn";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tAbnDataTable(DataTable dataTable_0)
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
            protected tAbnDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetFind.tAbnDataTable table1 = (DataSetFind.tAbnDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetFind.tAbnDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetFind.Class407);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetFind.Class407 class407_0)
            {
                base.Rows.Add(class407_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFind.Class407 method_1(int int_0, string string_0, int int_1, int int_2, bool bool_0)
            {
                DataSetFind.Class407 row = (DataSetFind.Class407) base.NewRow();
                object[] objArray1 = new object[6];
                objArray1[1] = int_0;
                objArray1[2] = string_0;
                objArray1[3] = int_1;
                objArray1[4] = int_2;
                objArray1[5] = bool_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetFind.Class407 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetFind.Class407) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnCodeAbonent = base.Columns["CodeAbonent"];
                this.columnName = base.Columns["Name"];
                this.columnTypeAbn = base.Columns["TypeAbn"];
                this.columnidWorker = base.Columns["idWorker"];
                this.columnDeleted = base.Columns["Deleted"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnCodeAbonent = new DataColumn("CodeAbonent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCodeAbonent);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnTypeAbn = new DataColumn("TypeAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnTypeAbn);
                this.columnidWorker = new DataColumn("idWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidWorker);
                this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnDeleted);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnCodeAbonent.AllowDBNull = false;
                this.columnName.MaxLength = 100;
                this.columnTypeAbn.AllowDBNull = false;
                this.columnidWorker.AllowDBNull = false;
                this.columnDeleted.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFind.Class407 method_5()
            {
                return (DataSetFind.Class407) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetFind.Class407 class407_0)
            {
                base.Rows.Remove(class407_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetFind.Class407(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tAbnRowChanged != null)
                {
                    this.tAbnRowChanged(this, new DataSetFind.EventArgs254((DataSetFind.Class407) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tAbnRowChanging != null)
                {
                    this.tAbnRowChanging(this, new DataSetFind.EventArgs254((DataSetFind.Class407) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tAbnRowDeleted != null)
                {
                    this.tAbnRowDeleted(this, new DataSetFind.EventArgs254((DataSetFind.Class407) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tAbnRowDeleting != null)
                {
                    this.tAbnRowDeleting(this, new DataSetFind.EventArgs254((DataSetFind.Class407) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetFind find = new DataSetFind();
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
                    FixedValue = find.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tAbnDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = find.GetSchemaSerializable();
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
            public DataColumn DeletedColumn
            {
                get
                {
                    return this.columnDeleted;
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
            public DataColumn idWorkerColumn
            {
                get
                {
                    return this.columnidWorker;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFind.Class407 this[int int_0]
            {
                get
                {
                    return (DataSetFind.Class407) base.Rows[int_0];
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
            public DataColumn TypeAbnColumn
            {
                get
                {
                    return this.columnTypeAbn;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vG_AbnObjCnt1DataTable : TypedTableBase<DataSetFind.Class409>
        {
            private DataColumn columnAbnWorker;
            private DataColumn columnCodeAbonent;
            private DataColumn columnDateBegin;
            private DataColumn columnDateEnd;
            private DataColumn columnDateOff;
            private DataColumn columnDateOn;
            private DataColumn columnFlag;
            private DataColumn columnidAbn;
            private DataColumn columnidAbnObj;
            private DataColumn columnidNet;
            private DataColumn columnidSale;
            private DataColumn columnidTypeAbn;
            private DataColumn columnName;
            private DataColumn columnName_Group;
            private DataColumn columnNumber;
            private DataColumn columnNumberObj;
            private DataColumn columnNumberSubObj;
            private DataColumn columnObjName;
            private DataColumn columnObjWorker;
            private DataColumn columnTypeAbn;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate260 vG_AbnObjCnt1RowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate260 vG_AbnObjCnt1RowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate260 vG_AbnObjCnt1RowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate260 vG_AbnObjCnt1RowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vG_AbnObjCnt1DataTable()
            {
                base.TableName = "vG_AbnObjCnt1";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vG_AbnObjCnt1DataTable(DataTable dataTable_0)
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
            protected vG_AbnObjCnt1DataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetFind.vG_AbnObjCnt1DataTable table1 = (DataSetFind.vG_AbnObjCnt1DataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetFind.vG_AbnObjCnt1DataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetFind.Class409);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetFind.Class409 class409_0)
            {
                base.Rows.Add(class409_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFind.Class409 method_1(int int_0, string string_0, string string_1, string string_2, string string_3, int int_1, string string_4, string string_5, int int_2, int int_3, int int_4, string string_6, int int_5, int int_6, int int_7, int int_8, DateTime dateTime_0, DateTime dateTime_1, DateTime dateTime_2, DateTime dateTime_3)
            {
                DataSetFind.Class409 row = (DataSetFind.Class409) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, string_0, string_1, string_2, string_3, int_1, string_4, string_5, int_2, int_3, int_4, string_6, int_5, int_6, int_7, int_8,
                    dateTime_0, dateTime_1, dateTime_2, dateTime_3
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnCodeAbonent = base.Columns["CodeAbonent"];
                this.columnName = base.Columns["Name"];
                this.columnObjName = base.Columns["ObjName"];
                this.columnNumber = base.Columns["Number"];
                this.columnName_Group = base.Columns["Name_Group"];
                this.columnidAbn = base.Columns["idAbn"];
                this.columnAbnWorker = base.Columns["AbnWorker"];
                this.columnObjWorker = base.Columns["ObjWorker"];
                this.columnidAbnObj = base.Columns["idAbnObj"];
                this.columnNumberObj = base.Columns["NumberObj"];
                this.columnNumberSubObj = base.Columns["NumberSubObj"];
                this.columnTypeAbn = base.Columns["TypeAbn"];
                this.columnidTypeAbn = base.Columns["idTypeAbn"];
                this.columnidNet = base.Columns["idNet"];
                this.columnidSale = base.Columns["idSale"];
                this.columnFlag = base.Columns["Flag"];
                this.columnDateOn = base.Columns["DateOn"];
                this.columnDateOff = base.Columns["DateOff"];
                this.columnDateBegin = base.Columns["DateBegin"];
                this.columnDateEnd = base.Columns["DateEnd"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnCodeAbonent = new DataColumn("CodeAbonent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCodeAbonent);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnObjName = new DataColumn("ObjName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnObjName);
                this.columnNumber = new DataColumn("Number", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNumber);
                this.columnName_Group = new DataColumn("Name_Group", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName_Group);
                this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
                this.columnAbnWorker = new DataColumn("AbnWorker", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAbnWorker);
                this.columnObjWorker = new DataColumn("ObjWorker", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnObjWorker);
                this.columnidAbnObj = new DataColumn("idAbnObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbnObj);
                this.columnNumberObj = new DataColumn("NumberObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnNumberObj);
                this.columnNumberSubObj = new DataColumn("NumberSubObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnNumberSubObj);
                this.columnTypeAbn = new DataColumn("TypeAbn", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTypeAbn);
                this.columnidTypeAbn = new DataColumn("idTypeAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidTypeAbn);
                this.columnidNet = new DataColumn("idNet", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidNet);
                this.columnidSale = new DataColumn("idSale", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSale);
                this.columnFlag = new DataColumn("Flag", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnFlag);
                this.columnDateOn = new DataColumn("DateOn", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateOn);
                this.columnDateOff = new DataColumn("DateOff", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateOff);
                this.columnDateBegin = new DataColumn("DateBegin", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateBegin);
                this.columnDateEnd = new DataColumn("DateEnd", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateEnd);
                this.columnCodeAbonent.AllowDBNull = false;
                this.columnName.MaxLength = 100;
                this.columnObjName.MaxLength = 0xff;
                this.columnNumber.MaxLength = 50;
                this.columnName_Group.MaxLength = 50;
                this.columnidAbn.AllowDBNull = false;
                this.columnAbnWorker.MaxLength = 30;
                this.columnObjWorker.MaxLength = 30;
                this.columnTypeAbn.MaxLength = 100;
                this.columnidTypeAbn.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetFind.Class409 method_4()
            {
                return (DataSetFind.Class409) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetFind.Class409 class409_0)
            {
                base.Rows.Remove(class409_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetFind.Class409(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCnt1RowChanged != null)
                {
                    this.vG_AbnObjCnt1RowChanged(this, new DataSetFind.EventArgs256((DataSetFind.Class409) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCnt1RowChanging != null)
                {
                    this.vG_AbnObjCnt1RowChanging(this, new DataSetFind.EventArgs256((DataSetFind.Class409) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCnt1RowDeleted != null)
                {
                    this.vG_AbnObjCnt1RowDeleted(this, new DataSetFind.EventArgs256((DataSetFind.Class409) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCnt1RowDeleting != null)
                {
                    this.vG_AbnObjCnt1RowDeleting(this, new DataSetFind.EventArgs256((DataSetFind.Class409) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetFind find = new DataSetFind();
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
                    FixedValue = find.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vG_AbnObjCnt1DataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = find.GetSchemaSerializable();
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
            public DataColumn AbnWorkerColumn
            {
                get
                {
                    return this.columnAbnWorker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateOffColumn
            {
                get
                {
                    return this.columnDateOff;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateOnColumn
            {
                get
                {
                    return this.columnDateOn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FlagColumn
            {
                get
                {
                    return this.columnFlag;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idAbnColumn
            {
                get
                {
                    return this.columnidAbn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idAbnObjColumn
            {
                get
                {
                    return this.columnidAbnObj;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idNetColumn
            {
                get
                {
                    return this.columnidNet;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idSaleColumn
            {
                get
                {
                    return this.columnidSale;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idTypeAbnColumn
            {
                get
                {
                    return this.columnidTypeAbn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFind.Class409 this[int int_0]
            {
                get
                {
                    return (DataSetFind.Class409) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn Name_GroupColumn
            {
                get
                {
                    return this.columnName_Group;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NumberColumn
            {
                get
                {
                    return this.columnNumber;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NumberObjColumn
            {
                get
                {
                    return this.columnNumberObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NumberSubObjColumn
            {
                get
                {
                    return this.columnNumberSubObj;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ObjNameColumn
            {
                get
                {
                    return this.columnObjName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ObjWorkerColumn
            {
                get
                {
                    return this.columnObjWorker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeAbnColumn
            {
                get
                {
                    return this.columnTypeAbn;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vG_AbnObjCntDataTable : TypedTableBase<DataSetFind.Class408>
        {
            private DataColumn columnAbnWorker;
            private DataColumn columnCodeAbnStr;
            private DataColumn columnCodeAbonent;
            private DataColumn columnDateBegin;
            private DataColumn columnDateEnd;
            private DataColumn columnDateOff;
            private DataColumn columnDateOn;
            private DataColumn columnFlag;
            private DataColumn columnidAbn;
            private DataColumn columnidAbnObj;
            private DataColumn columnidNet;
            private DataColumn columnidSale;
            private DataColumn columnidTypeAbn;
            private DataColumn columnName;
            private DataColumn columnName_Group;
            private DataColumn columnNumber;
            private DataColumn columnNumberObj;
            private DataColumn columnNumberSubObj;
            private DataColumn columnObjName;
            private DataColumn columnObjWorker;
            private DataColumn columnTypeAbn;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate259 vG_AbnObjCntRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate259 vG_AbnObjCntRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate259 vG_AbnObjCntRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate259 vG_AbnObjCntRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vG_AbnObjCntDataTable()
            {
                base.TableName = "vG_AbnObjCnt";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vG_AbnObjCntDataTable(DataTable dataTable_0)
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
            protected vG_AbnObjCntDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetFind.vG_AbnObjCntDataTable table1 = (DataSetFind.vG_AbnObjCntDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetFind.vG_AbnObjCntDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetFind.Class408);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetFind.Class408 class408_0)
            {
                base.Rows.Add(class408_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetFind.Class408 method_1(int int_0, string string_0, string string_1, string string_2, string string_3, int int_1, string string_4, string string_5, int int_2, int int_3, int int_4, string string_6, int int_5, int int_6, int int_7, int int_8, DateTime dateTime_0, DateTime dateTime_1, DateTime dateTime_2, DateTime dateTime_3, string string_7)
            {
                DataSetFind.Class408 row = (DataSetFind.Class408) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, string_0, string_1, string_2, string_3, int_1, string_4, string_5, int_2, int_3, int_4, string_6, int_5, int_6, int_7, int_8,
                    dateTime_0, dateTime_1, dateTime_2, dateTime_3, string_7
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnCodeAbonent = base.Columns["CodeAbonent"];
                this.columnName = base.Columns["Name"];
                this.columnObjName = base.Columns["ObjName"];
                this.columnNumber = base.Columns["Number"];
                this.columnName_Group = base.Columns["Name_Group"];
                this.columnidAbn = base.Columns["idAbn"];
                this.columnAbnWorker = base.Columns["AbnWorker"];
                this.columnObjWorker = base.Columns["ObjWorker"];
                this.columnidAbnObj = base.Columns["idAbnObj"];
                this.columnNumberObj = base.Columns["NumberObj"];
                this.columnNumberSubObj = base.Columns["NumberSubObj"];
                this.columnTypeAbn = base.Columns["TypeAbn"];
                this.columnidTypeAbn = base.Columns["idTypeAbn"];
                this.columnidNet = base.Columns["idNet"];
                this.columnidSale = base.Columns["idSale"];
                this.columnFlag = base.Columns["Flag"];
                this.columnDateOn = base.Columns["DateOn"];
                this.columnDateOff = base.Columns["DateOff"];
                this.columnDateBegin = base.Columns["DateBegin"];
                this.columnDateEnd = base.Columns["DateEnd"];
                this.columnCodeAbnStr = base.Columns["CodeAbnStr"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnCodeAbonent = new DataColumn("CodeAbonent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCodeAbonent);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnObjName = new DataColumn("ObjName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnObjName);
                this.columnNumber = new DataColumn("Number", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNumber);
                this.columnName_Group = new DataColumn("Name_Group", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName_Group);
                this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
                this.columnAbnWorker = new DataColumn("AbnWorker", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAbnWorker);
                this.columnObjWorker = new DataColumn("ObjWorker", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnObjWorker);
                this.columnidAbnObj = new DataColumn("idAbnObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbnObj);
                this.columnNumberObj = new DataColumn("NumberObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnNumberObj);
                this.columnNumberSubObj = new DataColumn("NumberSubObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnNumberSubObj);
                this.columnTypeAbn = new DataColumn("TypeAbn", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTypeAbn);
                this.columnidTypeAbn = new DataColumn("idTypeAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidTypeAbn);
                this.columnidNet = new DataColumn("idNet", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidNet);
                this.columnidSale = new DataColumn("idSale", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSale);
                this.columnFlag = new DataColumn("Flag", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnFlag);
                this.columnDateOn = new DataColumn("DateOn", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateOn);
                this.columnDateOff = new DataColumn("DateOff", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateOff);
                this.columnDateBegin = new DataColumn("DateBegin", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateBegin);
                this.columnDateEnd = new DataColumn("DateEnd", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateEnd);
                this.columnCodeAbnStr = new DataColumn("CodeAbnStr", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnCodeAbnStr);
                this.columnCodeAbonent.AllowDBNull = false;
                this.columnName.MaxLength = 100;
                this.columnObjName.MaxLength = 0xff;
                this.columnNumber.MaxLength = 50;
                this.columnName_Group.MaxLength = 50;
                this.columnidAbn.AllowDBNull = false;
                this.columnAbnWorker.MaxLength = 30;
                this.columnObjWorker.MaxLength = 30;
                this.columnTypeAbn.MaxLength = 100;
                this.columnidTypeAbn.AllowDBNull = false;
                this.columnFlag.ReadOnly = true;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFind.Class408 method_4()
            {
                return (DataSetFind.Class408) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetFind.Class408 class408_0)
            {
                base.Rows.Remove(class408_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetFind.Class408(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCntRowChanged != null)
                {
                    this.vG_AbnObjCntRowChanged(this, new DataSetFind.EventArgs255((DataSetFind.Class408) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCntRowChanging != null)
                {
                    this.vG_AbnObjCntRowChanging(this, new DataSetFind.EventArgs255((DataSetFind.Class408) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCntRowDeleted != null)
                {
                    this.vG_AbnObjCntRowDeleted(this, new DataSetFind.EventArgs255((DataSetFind.Class408) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCntRowDeleting != null)
                {
                    this.vG_AbnObjCntRowDeleting(this, new DataSetFind.EventArgs255((DataSetFind.Class408) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetFind find = new DataSetFind();
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
                    FixedValue = find.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vG_AbnObjCntDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = find.GetSchemaSerializable();
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
            public DataColumn AbnWorkerColumn
            {
                get
                {
                    return this.columnAbnWorker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CodeAbnStrColumn
            {
                get
                {
                    return this.columnCodeAbnStr;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CodeAbonentColumn
            {
                get
                {
                    return this.columnCodeAbonent;
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
            public DataColumn DateOffColumn
            {
                get
                {
                    return this.columnDateOff;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateOnColumn
            {
                get
                {
                    return this.columnDateOn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FlagColumn
            {
                get
                {
                    return this.columnFlag;
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
            public DataColumn idNetColumn
            {
                get
                {
                    return this.columnidNet;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idSaleColumn
            {
                get
                {
                    return this.columnidSale;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idTypeAbnColumn
            {
                get
                {
                    return this.columnidTypeAbn;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetFind.Class408 this[int int_0]
            {
                get
                {
                    return (DataSetFind.Class408) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn Name_GroupColumn
            {
                get
                {
                    return this.columnName_Group;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NumberColumn
            {
                get
                {
                    return this.columnNumber;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NumberObjColumn
            {
                get
                {
                    return this.columnNumberObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NumberSubObjColumn
            {
                get
                {
                    return this.columnNumberSubObj;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ObjNameColumn
            {
                get
                {
                    return this.columnObjName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ObjWorkerColumn
            {
                get
                {
                    return this.columnObjWorker;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TypeAbnColumn
            {
                get
                {
                    return this.columnTypeAbn;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vG_AbnObjCntShortDataTable : TypedTableBase<DataSetFind.Class406>
        {
            private DataColumn columnAbnWorker;
            private DataColumn columnCodeAbonent;
            private DataColumn columnidAbn;
            private DataColumn columnName;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate257 vG_AbnObjCntShortRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate257 vG_AbnObjCntShortRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate257 vG_AbnObjCntShortRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate257 vG_AbnObjCntShortRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vG_AbnObjCntShortDataTable()
            {
                base.TableName = "vG_AbnObjCntShort";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal vG_AbnObjCntShortDataTable(DataTable dataTable_0)
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
            protected vG_AbnObjCntShortDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetFind.vG_AbnObjCntShortDataTable table1 = (DataSetFind.vG_AbnObjCntShortDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetFind.vG_AbnObjCntShortDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetFind.Class406);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetFind.Class406 class406_0)
            {
                base.Rows.Add(class406_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFind.Class406 method_1(int int_0, string string_0, string string_1, int int_1)
            {
                DataSetFind.Class406 row = (DataSetFind.Class406) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, string_1, int_1 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnCodeAbonent = base.Columns["CodeAbonent"];
                this.columnName = base.Columns["Name"];
                this.columnAbnWorker = base.Columns["AbnWorker"];
                this.columnidAbn = base.Columns["idAbn"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnCodeAbonent = new DataColumn("CodeAbonent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCodeAbonent);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnAbnWorker = new DataColumn("AbnWorker", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAbnWorker);
                this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
                this.columnCodeAbonent.AllowDBNull = false;
                this.columnName.MaxLength = 100;
                this.columnAbnWorker.MaxLength = 30;
                this.columnidAbn.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFind.Class406 method_4()
            {
                return (DataSetFind.Class406) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(DataSetFind.Class406 class406_0)
            {
                base.Rows.Remove(class406_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetFind.Class406(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCntShortRowChanged != null)
                {
                    this.vG_AbnObjCntShortRowChanged(this, new DataSetFind.EventArgs253((DataSetFind.Class406) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCntShortRowChanging != null)
                {
                    this.vG_AbnObjCntShortRowChanging(this, new DataSetFind.EventArgs253((DataSetFind.Class406) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCntShortRowDeleted != null)
                {
                    this.vG_AbnObjCntShortRowDeleted(this, new DataSetFind.EventArgs253((DataSetFind.Class406) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vG_AbnObjCntShortRowDeleting != null)
                {
                    this.vG_AbnObjCntShortRowDeleting(this, new DataSetFind.EventArgs253((DataSetFind.Class406) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetFind find = new DataSetFind();
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
                    FixedValue = find.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vG_AbnObjCntShortDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = find.GetSchemaSerializable();
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
            public DataColumn AbnWorkerColumn
            {
                get
                {
                    return this.columnAbnWorker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CodeAbonentColumn
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idAbnColumn
            {
                get
                {
                    return this.columnidAbn;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetFind.Class406 this[int int_0]
            {
                get
                {
                    return (DataSetFind.Class406) base.Rows[int_0];
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
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vG_FindDataTable : TypedTableBase<DataSetFind.Class405>
        {
            private DataColumn columnCodeAbonent;
            private DataColumn columnidAbn;
            private DataColumn columnidAbnObj;
            private DataColumn columnName;
            private DataColumn columnObjName;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate256 vG_FindRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate256 vG_FindRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate256 vG_FindRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFind.Delegate256 vG_FindRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vG_FindDataTable()
            {
                base.TableName = "vG_Find";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal vG_FindDataTable(DataTable dataTable_0)
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
            protected vG_FindDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetFind.vG_FindDataTable table1 = (DataSetFind.vG_FindDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetFind.vG_FindDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetFind.Class405);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetFind.Class405 class405_0)
            {
                base.Rows.Add(class405_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFind.Class405 method_1(int int_0, string string_0, string string_1, int int_1, int int_2)
            {
                DataSetFind.Class405 row = (DataSetFind.Class405) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, string_1, int_1, int_2 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnCodeAbonent = base.Columns["CodeAbonent"];
                this.columnName = base.Columns["Name"];
                this.columnObjName = base.Columns["ObjName"];
                this.columnidAbn = base.Columns["idAbn"];
                this.columnidAbnObj = base.Columns["idAbnObj"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnCodeAbonent = new DataColumn("CodeAbonent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCodeAbonent);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnObjName = new DataColumn("ObjName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnObjName);
                this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
                this.columnidAbnObj = new DataColumn("idAbnObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbnObj);
                this.columnCodeAbonent.AllowDBNull = false;
                this.columnName.MaxLength = 100;
                this.columnObjName.MaxLength = 0xff;
                this.columnidAbn.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetFind.Class405 method_4()
            {
                return (DataSetFind.Class405) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetFind.Class405 class405_0)
            {
                base.Rows.Remove(class405_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetFind.Class405(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vG_FindRowChanged != null)
                {
                    this.vG_FindRowChanged(this, new DataSetFind.EventArgs252((DataSetFind.Class405) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vG_FindRowChanging != null)
                {
                    this.vG_FindRowChanging(this, new DataSetFind.EventArgs252((DataSetFind.Class405) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vG_FindRowDeleted != null)
                {
                    this.vG_FindRowDeleted(this, new DataSetFind.EventArgs252((DataSetFind.Class405) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vG_FindRowDeleting != null)
                {
                    this.vG_FindRowDeleting(this, new DataSetFind.EventArgs252((DataSetFind.Class405) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetFind find = new DataSetFind();
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
                    FixedValue = find.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vG_FindDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = find.GetSchemaSerializable();
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
            public DataColumn CodeAbonentColumn
            {
                get
                {
                    return this.columnCodeAbonent;
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
            public DataColumn idAbnColumn
            {
                get
                {
                    return this.columnidAbn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idAbnObjColumn
            {
                get
                {
                    return this.columnidAbnObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetFind.Class405 this[int int_0]
            {
                get
                {
                    return (DataSetFind.Class405) base.Rows[int_0];
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ObjNameColumn
            {
                get
                {
                    return this.columnObjName;
                }
            }
        }
    }
}

