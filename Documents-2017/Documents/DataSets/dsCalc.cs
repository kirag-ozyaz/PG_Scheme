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

    [Serializable, DesignerCategory("code"), XmlSchemaProvider("GetTypedDataSetSchema"), ToolboxItem(true), XmlRoot("dsCalc"), HelpKeyword("vs.data.DataSet")]
    internal class dsCalc : DataSet
    {
        private System.Data.SchemaSerializationMode _schemaSerializationMode;
        private dtIsolationLossDataTable tabledtIsolationLoss;
        private dtSourceDataTable tabledtSource;
        private tAbnDataTable tabletAbn;
        private tblLockDataTable tabletblLock;
        private tDocCalcDataTable tabletDocCalc;
        private tJ_CalcLossDataTable tabletJ_CalcLoss;
        private tJ_CalcLossCableDataTable tabletJ_CalcLossCable;
        private tJ_CalcLossFileDataTable tabletJ_CalcLossFile;
        private tJ_CalcLossTransDataTable tabletJ_CalcLossTrans;
        private tJ_CalcLossTransHHDataTable tabletJ_CalcLossTransHH;
        private tMaterialDataTable tabletMaterial;
        private tR_ClassifierDataTable tabletR_Classifier;
        private tUserDataTable tabletUser;
        private vAbnDataTable tablevAbn;
        private vAbnObjAddressDataTable tablevAbnObjAddress;
        private vJ_CalcLossDataTable tablevJ_CalcLoss;
        private vL_SchmAbnDataTable tablevL_SchmAbn;
        private vR_CableDataTable tablevR_Cable;
        private vR_TransformerDataTable tablevR_Transformer;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public dsCalc()
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            base.BeginInit();
            this.method_2();
            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_22);
            base.Tables.CollectionChanged += handler;
            base.Relations.CollectionChanged += handler;
            base.EndInit();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected dsCalc(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0, false)
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
            {
                this.method_1(false);
                CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.method_22);
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
                    if (dataSet.Tables["tDocCalc"] != null)
                    {
                        base.Tables.Add(new tDocCalcDataTable(dataSet.Tables["tDocCalc"]));
                    }
                    if (dataSet.Tables["tUser"] != null)
                    {
                        base.Tables.Add(new tUserDataTable(dataSet.Tables["tUser"]));
                    }
                    if (dataSet.Tables["tR_Classifier"] != null)
                    {
                        base.Tables.Add(new tR_ClassifierDataTable(dataSet.Tables["tR_Classifier"]));
                    }
                    if (dataSet.Tables["tAbn"] != null)
                    {
                        base.Tables.Add(new tAbnDataTable(dataSet.Tables["tAbn"]));
                    }
                    if (dataSet.Tables["tMaterial"] != null)
                    {
                        base.Tables.Add(new tMaterialDataTable(dataSet.Tables["tMaterial"]));
                    }
                    if (dataSet.Tables["tblLock"] != null)
                    {
                        base.Tables.Add(new tblLockDataTable(dataSet.Tables["tblLock"]));
                    }
                    if (dataSet.Tables["tJ_CalcLoss"] != null)
                    {
                        base.Tables.Add(new tJ_CalcLossDataTable(dataSet.Tables["tJ_CalcLoss"]));
                    }
                    if (dataSet.Tables["vJ_CalcLoss"] != null)
                    {
                        base.Tables.Add(new vJ_CalcLossDataTable(dataSet.Tables["vJ_CalcLoss"]));
                    }
                    if (dataSet.Tables["vAbnObjAddress"] != null)
                    {
                        base.Tables.Add(new vAbnObjAddressDataTable(dataSet.Tables["vAbnObjAddress"]));
                    }
                    if (dataSet.Tables["vR_Cable"] != null)
                    {
                        base.Tables.Add(new vR_CableDataTable(dataSet.Tables["vR_Cable"]));
                    }
                    if (dataSet.Tables["tJ_CalcLossCable"] != null)
                    {
                        base.Tables.Add(new tJ_CalcLossCableDataTable(dataSet.Tables["tJ_CalcLossCable"]));
                    }
                    if (dataSet.Tables["vAbn"] != null)
                    {
                        base.Tables.Add(new vAbnDataTable(dataSet.Tables["vAbn"]));
                    }
                    if (dataSet.Tables["dtSource"] != null)
                    {
                        base.Tables.Add(new dtSourceDataTable(dataSet.Tables["dtSource"]));
                    }
                    if (dataSet.Tables["tJ_CalcLossFile"] != null)
                    {
                        base.Tables.Add(new tJ_CalcLossFileDataTable(dataSet.Tables["tJ_CalcLossFile"]));
                    }
                    if (dataSet.Tables["vL_SchmAbn"] != null)
                    {
                        base.Tables.Add(new vL_SchmAbnDataTable(dataSet.Tables["vL_SchmAbn"]));
                    }
                    if (dataSet.Tables["vR_Transformer"] != null)
                    {
                        base.Tables.Add(new vR_TransformerDataTable(dataSet.Tables["vR_Transformer"]));
                    }
                    if (dataSet.Tables["tJ_CalcLossTrans"] != null)
                    {
                        base.Tables.Add(new tJ_CalcLossTransDataTable(dataSet.Tables["tJ_CalcLossTrans"]));
                    }
                    if (dataSet.Tables["tJ_CalcLossTransHH"] != null)
                    {
                        base.Tables.Add(new tJ_CalcLossTransHHDataTable(dataSet.Tables["tJ_CalcLossTransHH"]));
                    }
                    if (dataSet.Tables["dtIsolationLoss"] != null)
                    {
                        base.Tables.Add(new dtIsolationLossDataTable(dataSet.Tables["dtIsolationLoss"]));
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
                CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_22);
                base.Tables.CollectionChanged += handler;
                this.Relations.CollectionChanged += handler;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override DataSet Clone()
        {
            dsCalc calc1 = (dsCalc) base.Clone();
            calc1.method_0();
            calc1.SchemaSerializationMode = this.SchemaSerializationMode;
            return calc1;
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void method_0()
        {
            this.method_1(true);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void method_1(bool bool_0)
        {
            this.tabletDocCalc = (tDocCalcDataTable) base.Tables["tDocCalc"];
            if (bool_0 && (this.tabletDocCalc != null))
            {
                this.tabletDocCalc.method_3();
            }
            this.tabletUser = (tUserDataTable) base.Tables["tUser"];
            if (bool_0 && (this.tabletUser != null))
            {
                this.tabletUser.method_3();
            }
            this.tabletR_Classifier = (tR_ClassifierDataTable) base.Tables["tR_Classifier"];
            if (bool_0 && (this.tabletR_Classifier != null))
            {
                this.tabletR_Classifier.method_3();
            }
            this.tabletAbn = (tAbnDataTable) base.Tables["tAbn"];
            if (bool_0 && (this.tabletAbn != null))
            {
                this.tabletAbn.method_3();
            }
            this.tabletMaterial = (tMaterialDataTable) base.Tables["tMaterial"];
            if (bool_0 && (this.tabletMaterial != null))
            {
                this.tabletMaterial.method_3();
            }
            this.tabletblLock = (tblLockDataTable) base.Tables["tblLock"];
            if (bool_0 && (this.tabletblLock != null))
            {
                this.tabletblLock.method_3();
            }
            this.tabletJ_CalcLoss = (tJ_CalcLossDataTable) base.Tables["tJ_CalcLoss"];
            if (bool_0 && (this.tabletJ_CalcLoss != null))
            {
                this.tabletJ_CalcLoss.method_3();
            }
            this.tablevJ_CalcLoss = (vJ_CalcLossDataTable) base.Tables["vJ_CalcLoss"];
            if (bool_0 && (this.tablevJ_CalcLoss != null))
            {
                this.tablevJ_CalcLoss.method_3();
            }
            this.tablevAbnObjAddress = (vAbnObjAddressDataTable) base.Tables["vAbnObjAddress"];
            if (bool_0 && (this.tablevAbnObjAddress != null))
            {
                this.tablevAbnObjAddress.method_2();
            }
            this.tablevR_Cable = (vR_CableDataTable) base.Tables["vR_Cable"];
            if (bool_0 && (this.tablevR_Cable != null))
            {
                this.tablevR_Cable.method_3();
            }
            this.tabletJ_CalcLossCable = (tJ_CalcLossCableDataTable) base.Tables["tJ_CalcLossCable"];
            if (bool_0 && (this.tabletJ_CalcLossCable != null))
            {
                this.tabletJ_CalcLossCable.method_3();
            }
            this.tablevAbn = (vAbnDataTable) base.Tables["vAbn"];
            if (bool_0 && (this.tablevAbn != null))
            {
                this.tablevAbn.method_3();
            }
            this.tabledtSource = (dtSourceDataTable) base.Tables["dtSource"];
            if (bool_0 && (this.tabledtSource != null))
            {
                this.tabledtSource.method_2();
            }
            this.tabletJ_CalcLossFile = (tJ_CalcLossFileDataTable) base.Tables["tJ_CalcLossFile"];
            if (bool_0 && (this.tabletJ_CalcLossFile != null))
            {
                this.tabletJ_CalcLossFile.method_3();
            }
            this.tablevL_SchmAbn = (vL_SchmAbnDataTable) base.Tables["vL_SchmAbn"];
            if (bool_0 && (this.tablevL_SchmAbn != null))
            {
                this.tablevL_SchmAbn.method_3();
            }
            this.tablevR_Transformer = (vR_TransformerDataTable) base.Tables["vR_Transformer"];
            if (bool_0 && (this.tablevR_Transformer != null))
            {
                this.tablevR_Transformer.method_3();
            }
            this.tabletJ_CalcLossTrans = (tJ_CalcLossTransDataTable) base.Tables["tJ_CalcLossTrans"];
            if (bool_0 && (this.tabletJ_CalcLossTrans != null))
            {
                this.tabletJ_CalcLossTrans.method_3();
            }
            this.tabletJ_CalcLossTransHH = (tJ_CalcLossTransHHDataTable) base.Tables["tJ_CalcLossTransHH"];
            if (bool_0 && (this.tabletJ_CalcLossTransHH != null))
            {
                this.tabletJ_CalcLossTransHH.method_3();
            }
            this.tabledtIsolationLoss = (dtIsolationLossDataTable) base.Tables["dtIsolationLoss"];
            if (bool_0 && (this.tabledtIsolationLoss != null))
            {
                this.tabledtIsolationLoss.method_2();
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void method_2()
        {
            base.DataSetName = "dsCalc";
            base.Prefix = "";
            base.Namespace = "http://tempuri.org/dsCalc.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tabletDocCalc = new tDocCalcDataTable();
            base.Tables.Add(this.tabletDocCalc);
            this.tabletUser = new tUserDataTable();
            base.Tables.Add(this.tabletUser);
            this.tabletR_Classifier = new tR_ClassifierDataTable();
            base.Tables.Add(this.tabletR_Classifier);
            this.tabletAbn = new tAbnDataTable();
            base.Tables.Add(this.tabletAbn);
            this.tabletMaterial = new tMaterialDataTable();
            base.Tables.Add(this.tabletMaterial);
            this.tabletblLock = new tblLockDataTable();
            base.Tables.Add(this.tabletblLock);
            this.tabletJ_CalcLoss = new tJ_CalcLossDataTable();
            base.Tables.Add(this.tabletJ_CalcLoss);
            this.tablevJ_CalcLoss = new vJ_CalcLossDataTable();
            base.Tables.Add(this.tablevJ_CalcLoss);
            this.tablevAbnObjAddress = new vAbnObjAddressDataTable();
            base.Tables.Add(this.tablevAbnObjAddress);
            this.tablevR_Cable = new vR_CableDataTable();
            base.Tables.Add(this.tablevR_Cable);
            this.tabletJ_CalcLossCable = new tJ_CalcLossCableDataTable();
            base.Tables.Add(this.tabletJ_CalcLossCable);
            this.tablevAbn = new vAbnDataTable();
            base.Tables.Add(this.tablevAbn);
            this.tabledtSource = new dtSourceDataTable();
            base.Tables.Add(this.tabledtSource);
            this.tabletJ_CalcLossFile = new tJ_CalcLossFileDataTable();
            base.Tables.Add(this.tabletJ_CalcLossFile);
            this.tablevL_SchmAbn = new vL_SchmAbnDataTable();
            base.Tables.Add(this.tablevL_SchmAbn);
            this.tablevR_Transformer = new vR_TransformerDataTable();
            base.Tables.Add(this.tablevR_Transformer);
            this.tabletJ_CalcLossTrans = new tJ_CalcLossTransDataTable();
            base.Tables.Add(this.tabletJ_CalcLossTrans);
            this.tabletJ_CalcLossTransHH = new tJ_CalcLossTransHHDataTable();
            base.Tables.Add(this.tabletJ_CalcLossTransHH);
            this.tabledtIsolationLoss = new dtIsolationLossDataTable();
            base.Tables.Add(this.tabledtIsolationLoss);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
        private void method_22(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)
            {
                this.method_0();
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_6()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_7()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_8()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
                if (dataSet.Tables["tDocCalc"] != null)
                {
                    base.Tables.Add(new tDocCalcDataTable(dataSet.Tables["tDocCalc"]));
                }
                if (dataSet.Tables["tUser"] != null)
                {
                    base.Tables.Add(new tUserDataTable(dataSet.Tables["tUser"]));
                }
                if (dataSet.Tables["tR_Classifier"] != null)
                {
                    base.Tables.Add(new tR_ClassifierDataTable(dataSet.Tables["tR_Classifier"]));
                }
                if (dataSet.Tables["tAbn"] != null)
                {
                    base.Tables.Add(new tAbnDataTable(dataSet.Tables["tAbn"]));
                }
                if (dataSet.Tables["tMaterial"] != null)
                {
                    base.Tables.Add(new tMaterialDataTable(dataSet.Tables["tMaterial"]));
                }
                if (dataSet.Tables["tblLock"] != null)
                {
                    base.Tables.Add(new tblLockDataTable(dataSet.Tables["tblLock"]));
                }
                if (dataSet.Tables["tJ_CalcLoss"] != null)
                {
                    base.Tables.Add(new tJ_CalcLossDataTable(dataSet.Tables["tJ_CalcLoss"]));
                }
                if (dataSet.Tables["vJ_CalcLoss"] != null)
                {
                    base.Tables.Add(new vJ_CalcLossDataTable(dataSet.Tables["vJ_CalcLoss"]));
                }
                if (dataSet.Tables["vAbnObjAddress"] != null)
                {
                    base.Tables.Add(new vAbnObjAddressDataTable(dataSet.Tables["vAbnObjAddress"]));
                }
                if (dataSet.Tables["vR_Cable"] != null)
                {
                    base.Tables.Add(new vR_CableDataTable(dataSet.Tables["vR_Cable"]));
                }
                if (dataSet.Tables["tJ_CalcLossCable"] != null)
                {
                    base.Tables.Add(new tJ_CalcLossCableDataTable(dataSet.Tables["tJ_CalcLossCable"]));
                }
                if (dataSet.Tables["vAbn"] != null)
                {
                    base.Tables.Add(new vAbnDataTable(dataSet.Tables["vAbn"]));
                }
                if (dataSet.Tables["dtSource"] != null)
                {
                    base.Tables.Add(new dtSourceDataTable(dataSet.Tables["dtSource"]));
                }
                if (dataSet.Tables["tJ_CalcLossFile"] != null)
                {
                    base.Tables.Add(new tJ_CalcLossFileDataTable(dataSet.Tables["tJ_CalcLossFile"]));
                }
                if (dataSet.Tables["vL_SchmAbn"] != null)
                {
                    base.Tables.Add(new vL_SchmAbnDataTable(dataSet.Tables["vL_SchmAbn"]));
                }
                if (dataSet.Tables["vR_Transformer"] != null)
                {
                    base.Tables.Add(new vR_TransformerDataTable(dataSet.Tables["vR_Transformer"]));
                }
                if (dataSet.Tables["tJ_CalcLossTrans"] != null)
                {
                    base.Tables.Add(new tJ_CalcLossTransDataTable(dataSet.Tables["tJ_CalcLossTrans"]));
                }
                if (dataSet.Tables["tJ_CalcLossTransHH"] != null)
                {
                    base.Tables.Add(new tJ_CalcLossTransHHDataTable(dataSet.Tables["tJ_CalcLossTransHH"]));
                }
                if (dataSet.Tables["dtIsolationLoss"] != null)
                {
                    base.Tables.Add(new dtIsolationLossDataTable(dataSet.Tables["dtIsolationLoss"]));
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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
            dsCalc calc = new dsCalc();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            XmlSchemaAny item = new XmlSchemaAny {
                Namespace = calc.Namespace
            };
            sequence.Items.Add(item);
            type.Particle = sequence;
            XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public dtIsolationLossDataTable dtIsolationLoss
        {
            get
            {
                return this.tabledtIsolationLoss;
            }
        }

        [Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public dtSourceDataTable dtSource
        {
            get
            {
                return this.tabledtSource;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public tAbnDataTable tAbn
        {
            get
            {
                return this.tabletAbn;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
        public tblLockDataTable tblLock
        {
            get
            {
                return this.tabletblLock;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
        public tDocCalcDataTable tDocCalc
        {
            get
            {
                return this.tabletDocCalc;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
        public tJ_CalcLossDataTable tJ_CalcLoss
        {
            get
            {
                return this.tabletJ_CalcLoss;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public tJ_CalcLossCableDataTable tJ_CalcLossCable
        {
            get
            {
                return this.tabletJ_CalcLossCable;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
        public tJ_CalcLossFileDataTable tJ_CalcLossFile
        {
            get
            {
                return this.tabletJ_CalcLossFile;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
        public tJ_CalcLossTransDataTable tJ_CalcLossTrans
        {
            get
            {
                return this.tabletJ_CalcLossTrans;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public tJ_CalcLossTransHHDataTable tJ_CalcLossTransHH
        {
            get
            {
                return this.tabletJ_CalcLossTransHH;
            }
        }

        [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tMaterialDataTable tMaterial
        {
            get
            {
                return this.tabletMaterial;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
        public tR_ClassifierDataTable tR_Classifier
        {
            get
            {
                return this.tabletR_Classifier;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tUserDataTable tUser
        {
            get
            {
                return this.tabletUser;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public vAbnDataTable vAbn
        {
            get
            {
                return this.tablevAbn;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public vAbnObjAddressDataTable vAbnObjAddress
        {
            get
            {
                return this.tablevAbnObjAddress;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public vJ_CalcLossDataTable vJ_CalcLoss
        {
            get
            {
                return this.tablevJ_CalcLoss;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public vL_SchmAbnDataTable vL_SchmAbn
        {
            get
            {
                return this.tablevL_SchmAbn;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public vR_CableDataTable vR_Cable
        {
            get
            {
                return this.tablevR_Cable;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
        public vR_TransformerDataTable vR_Transformer
        {
            get
            {
                return this.tablevR_Transformer;
            }
        }

        public class Class386 : DataRow
        {
            private dsCalc.tDocCalcDataTable tDocCalcDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class386(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tDocCalcDataTable_0 = (dsCalc.tDocCalcDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tDocCalcDataTable_0.idDocTypeColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tDocCalcDataTable_0.idDocTypeColumn] = int_0;
            }

            public DateTime method_10()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tDocCalcDataTable_0.DateActColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateAct' in table 'tDocCalc' is DBNull.", exception);
                }
                return time;
            }

            public void method_11(DateTime dateTime_0)
            {
                base[this.tDocCalcDataTable_0.DateActColumn] = dateTime_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tDocCalcDataTable_0.IdOwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'IdOwner' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.tDocCalcDataTable_0.IdOwnerColumn] = int_0;
            }

            public decimal method_14()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tDocCalcDataTable_0.LineLengthColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LineLength' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(decimal decimal_0)
            {
                base[this.tDocCalcDataTable_0.LineLengthColumn] = decimal_0;
            }

            public decimal method_16()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tDocCalcDataTable_0.ElectricalResistanceColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ElectricalResistance' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_17(decimal decimal_0)
            {
                base[this.tDocCalcDataTable_0.ElectricalResistanceColumn] = decimal_0;
            }

            public decimal method_18()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tDocCalcDataTable_0.AverageVoltageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'AverageVoltage' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_19(decimal decimal_0)
            {
                base[this.tDocCalcDataTable_0.AverageVoltageColumn] = decimal_0;
            }

            public int method_2()
            {
                return (int) base[this.tDocCalcDataTable_0.IdAbnColumn];
            }

            public int method_20()
            {
                int num;
                try
                {
                    num = (int) base[this.tDocCalcDataTable_0.ConsumptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Consumption' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_21(int int_0)
            {
                base[this.tDocCalcDataTable_0.ConsumptionColumn] = int_0;
            }

            public int method_22()
            {
                int num;
                try
                {
                    num = (int) base[this.tDocCalcDataTable_0.PeriodColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Period' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_23(int int_0)
            {
                base[this.tDocCalcDataTable_0.PeriodColumn] = int_0;
            }

            public decimal method_24()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tDocCalcDataTable_0.CoefficientPowerReactiveColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoefficientPowerReactive' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(decimal decimal_0)
            {
                base[this.tDocCalcDataTable_0.CoefficientPowerReactiveColumn] = decimal_0;
            }

            public decimal method_26()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tDocCalcDataTable_0.SquareCoefficientFormGraphicsColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'SquareCoefficientFormGraphics' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_27(decimal decimal_0)
            {
                base[this.tDocCalcDataTable_0.SquareCoefficientFormGraphicsColumn] = decimal_0;
            }

            public decimal method_28()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tDocCalcDataTable_0.CoefficientDifferencesColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoefficientDifferences' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_29(decimal decimal_0)
            {
                base[this.tDocCalcDataTable_0.CoefficientDifferencesColumn] = decimal_0;
            }

            public void method_3(int int_0)
            {
                base[this.tDocCalcDataTable_0.IdAbnColumn] = int_0;
            }

            public decimal method_30()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tDocCalcDataTable_0.ActiveResistanceColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ActiveResistance' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_31(decimal decimal_0)
            {
                base[this.tDocCalcDataTable_0.ActiveResistanceColumn] = decimal_0;
            }

            public decimal method_32()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tDocCalcDataTable_0.LoadPowerLossColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LoadPowerLoss' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_33(decimal decimal_0)
            {
                base[this.tDocCalcDataTable_0.LoadPowerLossColumn] = decimal_0;
            }

            public decimal method_34()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tDocCalcDataTable_0.LoadAverageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LoadAverage' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_35(decimal decimal_0)
            {
                base[this.tDocCalcDataTable_0.LoadAverageColumn] = decimal_0;
            }

            public decimal method_36()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tDocCalcDataTable_0.LoadLossesColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LoadLosses' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_37(decimal decimal_0)
            {
                base[this.tDocCalcDataTable_0.LoadLossesColumn] = decimal_0;
            }

            public decimal method_38()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tDocCalcDataTable_0.CoefficientLossColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoefficientLoss' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_39(decimal decimal_0)
            {
                base[this.tDocCalcDataTable_0.CoefficientLossColumn] = decimal_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tDocCalcDataTable_0.idMarkCableColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idMarkCable' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public bool method_40()
            {
                return (bool) base[this.tDocCalcDataTable_0.DeletedColumn];
            }

            public void method_41(bool bool_0)
            {
                base[this.tDocCalcDataTable_0.DeletedColumn] = bool_0;
            }

            public int method_42()
            {
                int num;
                try
                {
                    num = (int) base[this.tDocCalcDataTable_0.CountCepeyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CountCepey' in table 'tDocCalc' is DBNull.", exception);
                }
                return num;
            }

            public void method_43(int int_0)
            {
                base[this.tDocCalcDataTable_0.CountCepeyColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_44()
            {
                return base.IsNull(this.tDocCalcDataTable_0.idMarkCableColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_45()
            {
                base[this.tDocCalcDataTable_0.idMarkCableColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_46()
            {
                return base.IsNull(this.tDocCalcDataTable_0.RepresentativeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.tDocCalcDataTable_0.RepresentativeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_48()
            {
                return base.IsNull(this.tDocCalcDataTable_0.DateInColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.tDocCalcDataTable_0.DateInColumn] = Convert.DBNull;
            }

            public void method_5(int int_0)
            {
                base[this.tDocCalcDataTable_0.idMarkCableColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.tDocCalcDataTable_0.DateActColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.tDocCalcDataTable_0.DateActColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_52()
            {
                return base.IsNull(this.tDocCalcDataTable_0.IdOwnerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_53()
            {
                base[this.tDocCalcDataTable_0.IdOwnerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_54()
            {
                return base.IsNull(this.tDocCalcDataTable_0.CommentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_55()
            {
                base[this.tDocCalcDataTable_0.CommentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.tDocCalcDataTable_0.LineLengthColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_57()
            {
                base[this.tDocCalcDataTable_0.LineLengthColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.tDocCalcDataTable_0.ElectricalResistanceColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_59()
            {
                base[this.tDocCalcDataTable_0.ElectricalResistanceColumn] = Convert.DBNull;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.tDocCalcDataTable_0.RepresentativeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Representative' in table 'tDocCalc' is DBNull.", exception);
                }
                return str;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_60()
            {
                return base.IsNull(this.tDocCalcDataTable_0.AverageVoltageColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_61()
            {
                base[this.tDocCalcDataTable_0.AverageVoltageColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_62()
            {
                return base.IsNull(this.tDocCalcDataTable_0.ConsumptionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_63()
            {
                base[this.tDocCalcDataTable_0.ConsumptionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_64()
            {
                return base.IsNull(this.tDocCalcDataTable_0.PeriodColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_65()
            {
                base[this.tDocCalcDataTable_0.PeriodColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_66()
            {
                return base.IsNull(this.tDocCalcDataTable_0.CoefficientPowerReactiveColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_67()
            {
                base[this.tDocCalcDataTable_0.CoefficientPowerReactiveColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_68()
            {
                return base.IsNull(this.tDocCalcDataTable_0.SquareCoefficientFormGraphicsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_69()
            {
                base[this.tDocCalcDataTable_0.SquareCoefficientFormGraphicsColumn] = Convert.DBNull;
            }

            public void method_7(string string_0)
            {
                base[this.tDocCalcDataTable_0.RepresentativeColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_70()
            {
                return base.IsNull(this.tDocCalcDataTable_0.CoefficientDifferencesColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_71()
            {
                base[this.tDocCalcDataTable_0.CoefficientDifferencesColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_72()
            {
                return base.IsNull(this.tDocCalcDataTable_0.ActiveResistanceColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_73()
            {
                base[this.tDocCalcDataTable_0.ActiveResistanceColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_74()
            {
                return base.IsNull(this.tDocCalcDataTable_0.LoadPowerLossColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_75()
            {
                base[this.tDocCalcDataTable_0.LoadPowerLossColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_76()
            {
                return base.IsNull(this.tDocCalcDataTable_0.LoadAverageColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_77()
            {
                base[this.tDocCalcDataTable_0.LoadAverageColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_78()
            {
                return base.IsNull(this.tDocCalcDataTable_0.LoadLossesColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_79()
            {
                base[this.tDocCalcDataTable_0.LoadLossesColumn] = Convert.DBNull;
            }

            public DateTime method_8()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tDocCalcDataTable_0.DateInColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateIn' in table 'tDocCalc' is DBNull.", exception);
                }
                return time;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_80()
            {
                return base.IsNull(this.tDocCalcDataTable_0.CoefficientLossColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_81()
            {
                base[this.tDocCalcDataTable_0.CoefficientLossColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_82()
            {
                return base.IsNull(this.tDocCalcDataTable_0.CountCepeyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_83()
            {
                base[this.tDocCalcDataTable_0.CountCepeyColumn] = Convert.DBNull;
            }

            public void method_9(DateTime dateTime_0)
            {
                base[this.tDocCalcDataTable_0.DateInColumn] = dateTime_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tDocCalcDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'tDocCalc' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tDocCalcDataTable_0.CommentColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tDocCalcDataTable_0.idColumn];
                }
                set
                {
                    base[this.tDocCalcDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class387 : DataRow
        {
            private dsCalc.tUserDataTable tUserDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class387(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tUserDataTable_0 = (dsCalc.tUserDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tUserDataTable_0.IDUserColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tUserDataTable_0.IDUserColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.tUserDataTable_0.NameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_11()
            {
                base[this.tUserDataTable_0.NameColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tUserDataTable_0.IdWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'IdWorker' in table 'tUser' is DBNull.", exception);
                }
                return num;
            }

            public void method_3(int int_0)
            {
                base[this.tUserDataTable_0.IdWorkerColumn] = int_0;
            }

            public string method_4()
            {
                return (string) base[this.tUserDataTable_0.LoginColumn];
            }

            public void method_5(string string_0)
            {
                base[this.tUserDataTable_0.LoginColumn] = string_0;
            }

            public bool method_6()
            {
                return (bool) base[this.tUserDataTable_0.DeletedColumn];
            }

            public void method_7(bool bool_0)
            {
                base[this.tUserDataTable_0.DeletedColumn] = bool_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tUserDataTable_0.IdWorkerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.tUserDataTable_0.IdWorkerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Name
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tUserDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'tUser' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tUserDataTable_0.NameColumn] = value;
                }
            }
        }

        public class Class388 : DataRow
        {
            private dsCalc.tR_ClassifierDataTable tR_ClassifierDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class388(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tR_ClassifierDataTable_0 = (dsCalc.tR_ClassifierDataTable) base.Table;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_13()
            {
                base[this.tR_ClassifierDataTable_0.CommentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.tR_ClassifierDataTable_0.ParentKeyColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.tR_ClassifierDataTable_0.OtherIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.tR_ClassifierDataTable_0.SocrNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

        public class Class389 : DataRow
        {
            private dsCalc.tAbnDataTable tAbnDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class389(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tAbnDataTable_0 = (dsCalc.tAbnDataTable) base.Table;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

        public class Class390 : DataRow
        {
            private dsCalc.tMaterialDataTable tMaterialDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class390(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tMaterialDataTable_0 = (dsCalc.tMaterialDataTable) base.Table;
            }

            public bool method_0()
            {
                return (bool) base[this.tMaterialDataTable_0.DeletedColumn];
            }

            public void method_1(bool bool_0)
            {
                base[this.tMaterialDataTable_0.DeletedColumn] = bool_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tMaterialDataTable_0.ParentIDColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ParentID' in table 'tMaterial' is DBNull.", exception);
                }
                return num;
            }

            public void method_3(int int_0)
            {
                base[this.tMaterialDataTable_0.ParentIDColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_4()
            {
                return base.IsNull(this.tMaterialDataTable_0.ParentIDColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5()
            {
                base[this.tMaterialDataTable_0.ParentIDColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tMaterialDataTable_0.idColumn];
                }
                set
                {
                    base[this.tMaterialDataTable_0.idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Name
            {
                get
                {
                    return (string) base[this.tMaterialDataTable_0.NameColumn];
                }
                set
                {
                    base[this.tMaterialDataTable_0.NameColumn] = value;
                }
            }
        }

        public class Class391 : DataRow
        {
            private dsCalc.tblLockDataTable tblLockDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class391(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tblLockDataTable_0 = (dsCalc.tblLockDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tblLockDataTable_0.idLockColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tblLockDataTable_0.idLockColumn] = int_0;
            }

            public string method_2()
            {
                return (string) base[this.tblLockDataTable_0.TableColumn];
            }

            public void method_3(string string_0)
            {
                base[this.tblLockDataTable_0.TableColumn] = string_0;
            }
        }

        public class Class392 : DataRow
        {
            private dsCalc.tJ_CalcLossDataTable tJ_CalcLossDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class392(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_CalcLossDataTable_0 = (dsCalc.tJ_CalcLossDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossDataTable_0.numColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'num' in table 'tJ_CalcLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tJ_CalcLossDataTable_0.numColumn] = int_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_CalcLossDataTable_0.tpNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'tpName' in table 'tJ_CalcLoss' is DBNull.", exception);
                }
                return str;
            }

            public void method_11(string string_0)
            {
                base[this.tJ_CalcLossDataTable_0.tpNameColumn] = string_0;
            }

            public DateTime method_12()
            {
                return (DateTime) base[this.tJ_CalcLossDataTable_0.DateCalcColumn];
            }

            public void method_13(DateTime dateTime_0)
            {
                base[this.tJ_CalcLossDataTable_0.DateCalcColumn] = dateTime_0;
            }

            public int method_14()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossDataTable_0.idOwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idOwner' in table 'tJ_CalcLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(int int_0)
            {
                base[this.tJ_CalcLossDataTable_0.idOwnerColumn] = int_0;
            }

            public bool method_16()
            {
                return (bool) base[this.tJ_CalcLossDataTable_0.isActiveColumn];
            }

            public void method_17(bool bool_0)
            {
                base[this.tJ_CalcLossDataTable_0.isActiveColumn] = bool_0;
            }

            public bool method_18()
            {
                return (bool) base[this.tJ_CalcLossDataTable_0.deletedColumn];
            }

            public void method_19(bool bool_0)
            {
                base[this.tJ_CalcLossDataTable_0.deletedColumn] = bool_0;
            }

            public int method_2()
            {
                return (int) base[this.tJ_CalcLossDataTable_0.typeCalcColumn];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.tJ_CalcLossDataTable_0.numColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.tJ_CalcLossDataTable_0.numColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.tJ_CalcLossDataTable_0.nameCalcColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_23()
            {
                base[this.tJ_CalcLossDataTable_0.nameCalcColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.tJ_CalcLossDataTable_0.idAbnColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.tJ_CalcLossDataTable_0.idAbnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_26()
            {
                return base.IsNull(this.tJ_CalcLossDataTable_0.tpNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_27()
            {
                base[this.tJ_CalcLossDataTable_0.tpNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_28()
            {
                return base.IsNull(this.tJ_CalcLossDataTable_0.idOwnerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_29()
            {
                base[this.tJ_CalcLossDataTable_0.idOwnerColumn] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.tJ_CalcLossDataTable_0.typeCalcColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_30()
            {
                return base.IsNull(this.tJ_CalcLossDataTable_0.CommentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.tJ_CalcLossDataTable_0.CommentColumn] = Convert.DBNull;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_CalcLossDataTable_0.nameCalcColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'nameCalc' in table 'tJ_CalcLoss' is DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.tJ_CalcLossDataTable_0.nameCalcColumn] = string_0;
            }

            public int method_6()
            {
                return (int) base[this.tJ_CalcLossDataTable_0.idAbnObjColumn];
            }

            public void method_7(int int_0)
            {
                base[this.tJ_CalcLossDataTable_0.idAbnObjColumn] = int_0;
            }

            public int method_8()
            {
                return (int) base[this.tJ_CalcLossDataTable_0.idAbnBalanceColumn];
            }

            public void method_9(int int_0)
            {
                base[this.tJ_CalcLossDataTable_0.idAbnBalanceColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tJ_CalcLossDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'tJ_CalcLoss' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tJ_CalcLossDataTable_0.CommentColumn] = value;
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
                        num = (int) base[this.tJ_CalcLossDataTable_0.idAbnColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idAbn' in table 'tJ_CalcLoss' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_CalcLossDataTable_0.idAbnColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_CalcLossDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_CalcLossDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class393 : DataRow
        {
            private dsCalc.vJ_CalcLossDataTable vJ_CalcLossDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class393(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vJ_CalcLossDataTable_0 = (dsCalc.vJ_CalcLossDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_CalcLossDataTable_0.numColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'num' in table 'vJ_CalcLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.vJ_CalcLossDataTable_0.numColumn] = int_0;
            }

            public int method_10()
            {
                return (int) base[this.vJ_CalcLossDataTable_0.idAbnObjColumn];
            }

            public void method_11(int int_0)
            {
                base[this.vJ_CalcLossDataTable_0.idAbnObjColumn] = int_0;
            }

            public string method_12()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_CalcLossDataTable_0.nameObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'nameObj' in table 'vJ_CalcLoss' is DBNull.", exception);
                }
                return str;
            }

            public void method_13(string string_0)
            {
                base[this.vJ_CalcLossDataTable_0.nameObjColumn] = string_0;
            }

            public int method_14()
            {
                return (int) base[this.vJ_CalcLossDataTable_0.idAbnBalanceColumn];
            }

            public void method_15(int int_0)
            {
                base[this.vJ_CalcLossDataTable_0.idAbnBalanceColumn] = int_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_CalcLossDataTable_0.nameAbnBalanceColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'nameAbnBalance' in table 'vJ_CalcLoss' is DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.vJ_CalcLossDataTable_0.nameAbnBalanceColumn] = string_0;
            }

            public string method_18()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_CalcLossDataTable_0.tpNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'tpName' in table 'vJ_CalcLoss' is DBNull.", exception);
                }
                return str;
            }

            public void method_19(string string_0)
            {
                base[this.vJ_CalcLossDataTable_0.tpNameColumn] = string_0;
            }

            public int method_2()
            {
                return (int) base[this.vJ_CalcLossDataTable_0.idTypeCalcColumn];
            }

            public DateTime method_20()
            {
                return (DateTime) base[this.vJ_CalcLossDataTable_0.DateCalcColumn];
            }

            public void method_21(DateTime dateTime_0)
            {
                base[this.vJ_CalcLossDataTable_0.DateCalcColumn] = dateTime_0;
            }

            public int method_22()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_CalcLossDataTable_0.idOwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idOwner' in table 'vJ_CalcLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_23(int int_0)
            {
                base[this.vJ_CalcLossDataTable_0.idOwnerColumn] = int_0;
            }

            public string method_24()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_CalcLossDataTable_0.nameOwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'nameOwner' in table 'vJ_CalcLoss' is DBNull.", exception);
                }
                return str;
            }

            public void method_25(string string_0)
            {
                base[this.vJ_CalcLossDataTable_0.nameOwnerColumn] = string_0;
            }

            public bool method_26()
            {
                return (bool) base[this.vJ_CalcLossDataTable_0.isActiveColumn];
            }

            public void method_27(bool bool_0)
            {
                base[this.vJ_CalcLossDataTable_0.isActiveColumn] = bool_0;
            }

            public bool method_28()
            {
                return (bool) base[this.vJ_CalcLossDataTable_0.deletedColumn];
            }

            public void method_29(bool bool_0)
            {
                base[this.vJ_CalcLossDataTable_0.deletedColumn] = bool_0;
            }

            public void method_3(int int_0)
            {
                base[this.vJ_CalcLossDataTable_0.idTypeCalcColumn] = int_0;
            }

            public decimal method_30()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.vJ_CalcLossDataTable_0.CoeffLossesColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoeffLosses' in table 'vJ_CalcLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_31(decimal decimal_0)
            {
                base[this.vJ_CalcLossDataTable_0.CoeffLossesColumn] = decimal_0;
            }

            public int method_32()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_CalcLossDataTable_0.CodeAbonentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CodeAbonent' in table 'vJ_CalcLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_33(int int_0)
            {
                base[this.vJ_CalcLossDataTable_0.CodeAbonentColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_34()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.numColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_35()
            {
                base[this.vJ_CalcLossDataTable_0.numColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.typeCalcColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_37()
            {
                base[this.vJ_CalcLossDataTable_0.typeCalcColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.nameCalcColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_39()
            {
                base[this.vJ_CalcLossDataTable_0.nameCalcColumn] = Convert.DBNull;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_CalcLossDataTable_0.typeCalcColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeCalc' in table 'vJ_CalcLoss' is DBNull.", exception);
                }
                return str;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_40()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.idAbnColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_41()
            {
                base[this.vJ_CalcLossDataTable_0.idAbnColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_42()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.nameAbnColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_43()
            {
                base[this.vJ_CalcLossDataTable_0.nameAbnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_44()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.nameObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.vJ_CalcLossDataTable_0.nameObjColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_46()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.nameAbnBalanceColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.vJ_CalcLossDataTable_0.nameAbnBalanceColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_48()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.tpNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_49()
            {
                base[this.vJ_CalcLossDataTable_0.tpNameColumn] = Convert.DBNull;
            }

            public void method_5(string string_0)
            {
                base[this.vJ_CalcLossDataTable_0.typeCalcColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.idOwnerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.vJ_CalcLossDataTable_0.idOwnerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_52()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.nameOwnerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_53()
            {
                base[this.vJ_CalcLossDataTable_0.nameOwnerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_54()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.CommentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.vJ_CalcLossDataTable_0.CommentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.CoeffLossesColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_57()
            {
                base[this.vJ_CalcLossDataTable_0.CoeffLossesColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.vJ_CalcLossDataTable_0.CodeAbonentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_59()
            {
                base[this.vJ_CalcLossDataTable_0.CodeAbonentColumn] = Convert.DBNull;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_CalcLossDataTable_0.nameCalcColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'nameCalc' in table 'vJ_CalcLoss' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.vJ_CalcLossDataTable_0.nameCalcColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_CalcLossDataTable_0.nameAbnColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'nameAbn' in table 'vJ_CalcLoss' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.vJ_CalcLossDataTable_0.nameAbnColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vJ_CalcLossDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'vJ_CalcLoss' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vJ_CalcLossDataTable_0.CommentColumn] = value;
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
                        num = (int) base[this.vJ_CalcLossDataTable_0.idAbnColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idAbn' in table 'vJ_CalcLoss' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vJ_CalcLossDataTable_0.idAbnColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vJ_CalcLossDataTable_0.idColumn];
                }
                set
                {
                    base[this.vJ_CalcLossDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class394 : DataRow
        {
            private dsCalc.vAbnObjAddressDataTable vAbnObjAddressDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class394(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vAbnObjAddressDataTable_0 = (dsCalc.vAbnObjAddressDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.vAbnObjAddressDataTable_0.idMapColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idMap' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.vAbnObjAddressDataTable_0.idMapColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.vAbnObjAddressDataTable_0.idStreetColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idStreet' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.vAbnObjAddressDataTable_0.idStreetColumn] = int_0;
            }

            public string method_12()
            {
                string str;
                try
                {
                    str = (string) base[this.vAbnObjAddressDataTable_0.StreetColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Street' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return str;
            }

            public void method_13(string string_0)
            {
                base[this.vAbnObjAddressDataTable_0.StreetColumn] = string_0;
            }

            public int method_14()
            {
                int num;
                try
                {
                    num = (int) base[this.vAbnObjAddressDataTable_0.HouseColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'House' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(int int_0)
            {
                base[this.vAbnObjAddressDataTable_0.HouseColumn] = int_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.vAbnObjAddressDataTable_0.HousePrefixColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'HousePrefix' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.vAbnObjAddressDataTable_0.HousePrefixColumn] = string_0;
            }

            public string method_18()
            {
                string str;
                try
                {
                    str = (string) base[this.vAbnObjAddressDataTable_0.HouseAllColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'HouseAll' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return str;
            }

            public void method_19(string string_0)
            {
                base[this.vAbnObjAddressDataTable_0.HouseAllColumn] = string_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.vAbnObjAddressDataTable_0.idCityColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idCity' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return num;
            }

            public bool method_20()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.vAbnObjAddressDataTable_0.IsHouseColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'IsHouse' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return flag;
            }

            public void method_21(bool bool_0)
            {
                base[this.vAbnObjAddressDataTable_0.IsHouseColumn] = bool_0;
            }

            public string method_22()
            {
                string str;
                try
                {
                    str = (string) base[this.vAbnObjAddressDataTable_0.IndexColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Index' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return str;
            }

            public void method_23(string string_0)
            {
                base[this.vAbnObjAddressDataTable_0.IndexColumn] = string_0;
            }

            public double method_24()
            {
                double num;
                try
                {
                    num = (double) base[this.vAbnObjAddressDataTable_0.LatitudeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Latitude' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(double double_0)
            {
                base[this.vAbnObjAddressDataTable_0.LatitudeColumn] = double_0;
            }

            public double method_26()
            {
                double num;
                try
                {
                    num = (double) base[this.vAbnObjAddressDataTable_0.LongitudeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Longitude' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_27(double double_0)
            {
                base[this.vAbnObjAddressDataTable_0.LongitudeColumn] = double_0;
            }

            public int method_28()
            {
                int num;
                try
                {
                    num = (int) base[this.vAbnObjAddressDataTable_0.idObjParentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idObjParent' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_29(int int_0)
            {
                base[this.vAbnObjAddressDataTable_0.idObjParentColumn] = int_0;
            }

            public void method_3(int int_0)
            {
                base[this.vAbnObjAddressDataTable_0.idCityColumn] = int_0;
            }

            public int method_30()
            {
                int num;
                try
                {
                    num = (int) base[this.vAbnObjAddressDataTable_0.TypeObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TypeObj' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_31(int int_0)
            {
                base[this.vAbnObjAddressDataTable_0.TypeObjColumn] = int_0;
            }

            public string method_32()
            {
                string str;
                try
                {
                    str = (string) base[this.vAbnObjAddressDataTable_0.TypeObjNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TypeObjName' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return str;
            }

            public void method_33(string string_0)
            {
                base[this.vAbnObjAddressDataTable_0.TypeObjNameColumn] = string_0;
            }

            public int method_34()
            {
                int num;
                try
                {
                    num = (int) base[this.vAbnObjAddressDataTable_0.idObjRegColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idObjReg' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_35(int int_0)
            {
                base[this.vAbnObjAddressDataTable_0.idObjRegColumn] = int_0;
            }

            public int method_36()
            {
                int num;
                try
                {
                    num = (int) base[this.vAbnObjAddressDataTable_0.TypeObjNewColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TypeObjNew' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_37(int int_0)
            {
                base[this.vAbnObjAddressDataTable_0.TypeObjNewColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.idAbnColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_39()
            {
                base[this.vAbnObjAddressDataTable_0.idAbnColumn] = Convert.DBNull;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.vAbnObjAddressDataTable_0.CityColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'City' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.idMapColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_41()
            {
                base[this.vAbnObjAddressDataTable_0.idMapColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.NameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_43()
            {
                base[this.vAbnObjAddressDataTable_0.NameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_44()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.CommentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_45()
            {
                base[this.vAbnObjAddressDataTable_0.CommentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_46()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.idCityColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.vAbnObjAddressDataTable_0.idCityColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_48()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.CityColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_49()
            {
                base[this.vAbnObjAddressDataTable_0.CityColumn] = Convert.DBNull;
            }

            public void method_5(string string_0)
            {
                base[this.vAbnObjAddressDataTable_0.CityColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.idRaionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.vAbnObjAddressDataTable_0.idRaionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_52()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.RaionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_53()
            {
                base[this.vAbnObjAddressDataTable_0.RaionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_54()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.idStreetColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.vAbnObjAddressDataTable_0.idStreetColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_56()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.StreetColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_57()
            {
                base[this.vAbnObjAddressDataTable_0.StreetColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.HouseColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_59()
            {
                base[this.vAbnObjAddressDataTable_0.HouseColumn] = Convert.DBNull;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.vAbnObjAddressDataTable_0.idRaionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idRaion' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_60()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.HousePrefixColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_61()
            {
                base[this.vAbnObjAddressDataTable_0.HousePrefixColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_62()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.HouseAllColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_63()
            {
                base[this.vAbnObjAddressDataTable_0.HouseAllColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_64()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.IsHouseColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_65()
            {
                base[this.vAbnObjAddressDataTable_0.IsHouseColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_66()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.IndexColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_67()
            {
                base[this.vAbnObjAddressDataTable_0.IndexColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_68()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.LatitudeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_69()
            {
                base[this.vAbnObjAddressDataTable_0.LatitudeColumn] = Convert.DBNull;
            }

            public void method_7(int int_0)
            {
                base[this.vAbnObjAddressDataTable_0.idRaionColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_70()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.LongitudeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_71()
            {
                base[this.vAbnObjAddressDataTable_0.LongitudeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_72()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.idObjParentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_73()
            {
                base[this.vAbnObjAddressDataTable_0.idObjParentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_74()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.TypeObjColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_75()
            {
                base[this.vAbnObjAddressDataTable_0.TypeObjColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_76()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.TypeObjNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_77()
            {
                base[this.vAbnObjAddressDataTable_0.TypeObjNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_78()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.idObjRegColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_79()
            {
                base[this.vAbnObjAddressDataTable_0.idObjRegColumn] = Convert.DBNull;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vAbnObjAddressDataTable_0.RaionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Raion' in table 'vAbnObjAddress' is DBNull.", exception);
                }
                return str;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_80()
            {
                return base.IsNull(this.vAbnObjAddressDataTable_0.TypeObjNewColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_81()
            {
                base[this.vAbnObjAddressDataTable_0.TypeObjNewColumn] = Convert.DBNull;
            }

            public void method_9(string string_0)
            {
                base[this.vAbnObjAddressDataTable_0.RaionColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vAbnObjAddressDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'vAbnObjAddress' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vAbnObjAddressDataTable_0.CommentColumn] = value;
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
                        num = (int) base[this.vAbnObjAddressDataTable_0.idAbnColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idAbn' in table 'vAbnObjAddress' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vAbnObjAddressDataTable_0.idAbnColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vAbnObjAddressDataTable_0.idColumn];
                }
                set
                {
                    base[this.vAbnObjAddressDataTable_0.idColumn] = value;
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
                        str = (string) base[this.vAbnObjAddressDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'vAbnObjAddress' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vAbnObjAddressDataTable_0.NameColumn] = value;
                }
            }
        }

        public class Class395 : DataRow
        {
            private dsCalc.vR_CableDataTable vR_CableDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class395(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vR_CableDataTable_0 = (dsCalc.vR_CableDataTable) base.Table;
            }

            public float method_0()
            {
                float num;
                try
                {
                    num = (float) base[this.vR_CableDataTable_0.AmperageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Amperage' in table 'vR_Cable' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(float float_0)
            {
                base[this.vR_CableDataTable_0.AmperageColumn] = float_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.vR_CableDataTable_0.WiresAddlColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'WiresAddl' in table 'vR_Cable' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.vR_CableDataTable_0.WiresAddlColumn] = int_0;
            }

            public float method_12()
            {
                float num;
                try
                {
                    num = (float) base[this.vR_CableDataTable_0.CrossSectionAddlColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CrossSectionAddl' in table 'vR_Cable' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(float float_0)
            {
                base[this.vR_CableDataTable_0.CrossSectionAddlColumn] = float_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.vR_CableDataTable_0.FullNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.vR_CableDataTable_0.FullNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_16()
            {
                return base.IsNull(this.vR_CableDataTable_0.WiresColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.vR_CableDataTable_0.WiresColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.vR_CableDataTable_0.CrossSectionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.vR_CableDataTable_0.CrossSectionColumn] = Convert.DBNull;
            }

            public float method_2()
            {
                float num;
                try
                {
                    num = (float) base[this.vR_CableDataTable_0.ResistanceColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Resistance' in table 'vR_Cable' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.vR_CableDataTable_0.AmperageColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_21()
            {
                base[this.vR_CableDataTable_0.AmperageColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_22()
            {
                return base.IsNull(this.vR_CableDataTable_0.ResistanceColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_23()
            {
                base[this.vR_CableDataTable_0.ResistanceColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_24()
            {
                return base.IsNull(this.vR_CableDataTable_0.VoltageTypeNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.vR_CableDataTable_0.VoltageTypeNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_26()
            {
                return base.IsNull(this.vR_CableDataTable_0.VoltageValueColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_27()
            {
                base[this.vR_CableDataTable_0.VoltageValueColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_28()
            {
                return base.IsNull(this.vR_CableDataTable_0.WiresAddlColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_29()
            {
                base[this.vR_CableDataTable_0.WiresAddlColumn] = Convert.DBNull;
            }

            public void method_3(float float_0)
            {
                base[this.vR_CableDataTable_0.ResistanceColumn] = float_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_30()
            {
                return base.IsNull(this.vR_CableDataTable_0.CrossSectionAddlColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.vR_CableDataTable_0.CrossSectionAddlColumn] = Convert.DBNull;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.vR_CableDataTable_0.VoltageTypeNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'VoltageTypeName' in table 'vR_Cable' is DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.vR_CableDataTable_0.VoltageTypeNameColumn] = string_0;
            }

            public float method_6()
            {
                float num;
                try
                {
                    num = (float) base[this.vR_CableDataTable_0.VoltageValueColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'VoltageValue' in table 'vR_Cable' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(float float_0)
            {
                base[this.vR_CableDataTable_0.VoltageValueColumn] = float_0;
            }

            public bool method_8()
            {
                return (bool) base[this.vR_CableDataTable_0.DeletedColumn];
            }

            public void method_9(bool bool_0)
            {
                base[this.vR_CableDataTable_0.DeletedColumn] = bool_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CableMakeup
            {
                get
                {
                    return (string) base[this.vR_CableDataTable_0.CableMakeupColumn];
                }
                set
                {
                    base[this.vR_CableDataTable_0.CableMakeupColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public float CrossSection
            {
                get
                {
                    float num;
                    try
                    {
                        num = (float) base[this.vR_CableDataTable_0.CrossSectionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'CrossSection' in table 'vR_Cable' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vR_CableDataTable_0.CrossSectionColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string FullName
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vR_CableDataTable_0.FullNameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'FullName' in table 'vR_Cable' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vR_CableDataTable_0.FullNameColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vR_CableDataTable_0.idColumn];
                }
                set
                {
                    base[this.vR_CableDataTable_0.idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Wires
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vR_CableDataTable_0.WiresColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Wires' in table 'vR_Cable' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vR_CableDataTable_0.WiresColumn] = value;
                }
            }
        }

        public class Class396 : DataRow
        {
            private dsCalc.tJ_CalcLossCableDataTable tJ_CalcLossCableDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class396(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_CalcLossCableDataTable_0 = (dsCalc.tJ_CalcLossCableDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_CalcLossCableDataTable_0.idCalcColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.idCalcColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossCableDataTable_0.periodColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'period' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.periodColumn] = int_0;
            }

            public decimal method_12()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.CoeffPowerREactiveColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoeffPowerREactive' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.CoeffPowerREactiveColumn] = decimal_0;
            }

            public decimal method_14()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.SquareCoeffFromGraphColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'SquareCoeffFromGraph' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.SquareCoeffFromGraphColumn] = decimal_0;
            }

            public decimal method_16()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.CoeffDifferencesColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoeffDifferences' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_17(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.CoeffDifferencesColumn] = decimal_0;
            }

            public int method_18()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossCableDataTable_0.CountChainColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CountChain' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_19(int int_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.CountChainColumn] = int_0;
            }

            public int method_2()
            {
                return (int) base[this.tJ_CalcLossCableDataTable_0.makeupCableColumn];
            }

            public decimal method_20()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.ActiveResistanceColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ActiveResistance' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_21(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.ActiveResistanceColumn] = decimal_0;
            }

            public decimal method_22()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.LoadPowerLossColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LoadPowerLoss' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_23(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.LoadPowerLossColumn] = decimal_0;
            }

            public decimal method_24()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.LoadAverageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LoadAverage' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.LoadAverageColumn] = decimal_0;
            }

            public decimal method_26()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.LoadLossesColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LoadLosses' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_27(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.LoadLossesColumn] = decimal_0;
            }

            public decimal method_28()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.UnitYearLossColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'UnitYearLoss' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_29(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.UnitYearLossColumn] = decimal_0;
            }

            public void method_3(int int_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.makeupCableColumn] = int_0;
            }

            public decimal method_30()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.YearLossColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'YearLoss' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_31(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.YearLossColumn] = decimal_0;
            }

            public decimal method_32()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.SumLoadLossesColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'SumLoadLosses' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_33(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.SumLoadLossesColumn] = decimal_0;
            }

            public decimal method_34()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.CoeffLossesColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoeffLosses' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_35(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.CoeffLossesColumn] = decimal_0;
            }

            public bool method_36()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tJ_CalcLossCableDataTable_0.isIsolationColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isIsolation' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return flag;
            }

            public void method_37(bool bool_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.isIsolationColumn] = bool_0;
            }

            public decimal method_38()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.CoeffIsolationColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoeffIsolation' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_39(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.CoeffIsolationColumn] = decimal_0;
            }

            public decimal method_4()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.lenghtCableColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'lenghtCable' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public decimal method_40()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.IsolationLossesColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'IsolationLosses' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            public void method_41(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.IsolationLossesColumn] = decimal_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_42()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.lenghtCableColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_43()
            {
                base[this.tJ_CalcLossCableDataTable_0.lenghtCableColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_44()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.UdResistanceColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_45()
            {
                base[this.tJ_CalcLossCableDataTable_0.UdResistanceColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_46()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.VoltageColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.tJ_CalcLossCableDataTable_0.VoltageColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_48()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.consumptionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.tJ_CalcLossCableDataTable_0.consumptionColumn] = Convert.DBNull;
            }

            public void method_5(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.lenghtCableColumn] = decimal_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_50()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.periodColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_51()
            {
                base[this.tJ_CalcLossCableDataTable_0.periodColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_52()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.CoeffPowerREactiveColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_53()
            {
                base[this.tJ_CalcLossCableDataTable_0.CoeffPowerREactiveColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_54()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.SquareCoeffFromGraphColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.tJ_CalcLossCableDataTable_0.SquareCoeffFromGraphColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_56()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.CoeffDifferencesColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_57()
            {
                base[this.tJ_CalcLossCableDataTable_0.CoeffDifferencesColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.CountChainColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_59()
            {
                base[this.tJ_CalcLossCableDataTable_0.CountChainColumn] = Convert.DBNull;
            }

            public decimal method_6()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossCableDataTable_0.UdResistanceColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'UdResistance' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_60()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.ActiveResistanceColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_61()
            {
                base[this.tJ_CalcLossCableDataTable_0.ActiveResistanceColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_62()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.LoadPowerLossColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_63()
            {
                base[this.tJ_CalcLossCableDataTable_0.LoadPowerLossColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_64()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.LoadAverageColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_65()
            {
                base[this.tJ_CalcLossCableDataTable_0.LoadAverageColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_66()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.LoadLossesColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_67()
            {
                base[this.tJ_CalcLossCableDataTable_0.LoadLossesColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_68()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.UnitYearLossColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_69()
            {
                base[this.tJ_CalcLossCableDataTable_0.UnitYearLossColumn] = Convert.DBNull;
            }

            public void method_7(decimal decimal_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.UdResistanceColumn] = decimal_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_70()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.YearLossColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_71()
            {
                base[this.tJ_CalcLossCableDataTable_0.YearLossColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_72()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.SumLoadLossesColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_73()
            {
                base[this.tJ_CalcLossCableDataTable_0.SumLoadLossesColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_74()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.CoeffLossesColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_75()
            {
                base[this.tJ_CalcLossCableDataTable_0.CoeffLossesColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_76()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.isIsolationColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_77()
            {
                base[this.tJ_CalcLossCableDataTable_0.isIsolationColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_78()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.CoeffIsolationColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_79()
            {
                base[this.tJ_CalcLossCableDataTable_0.CoeffIsolationColumn] = Convert.DBNull;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossCableDataTable_0.consumptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'consumption' in table 'tJ_CalcLossCable' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_80()
            {
                return base.IsNull(this.tJ_CalcLossCableDataTable_0.IsolationLossesColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_81()
            {
                base[this.tJ_CalcLossCableDataTable_0.IsolationLossesColumn] = Convert.DBNull;
            }

            public void method_9(int int_0)
            {
                base[this.tJ_CalcLossCableDataTable_0.consumptionColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_CalcLossCableDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_CalcLossCableDataTable_0.idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Voltage
            {
                get
                {
                    decimal num;
                    try
                    {
                        num = (decimal) base[this.tJ_CalcLossCableDataTable_0.VoltageColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Voltage' in table 'tJ_CalcLossCable' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_CalcLossCableDataTable_0.VoltageColumn] = value;
                }
            }
        }

        public class Class397 : DataRow
        {
            private dsCalc.vAbnDataTable vAbnDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class397(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vAbnDataTable_0 = (dsCalc.vAbnDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vAbnDataTable_0.CodeAbonentColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vAbnDataTable_0.CodeAbonentColumn] = int_0;
            }

            public bool method_10()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.vAbnDataTable_0.isActiveColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isActive' in table 'vAbn' is DBNull.", exception);
                }
                return flag;
            }

            public void method_11(bool bool_0)
            {
                base[this.vAbnDataTable_0.isActiveColumn] = bool_0;
            }

            public DateTime method_12()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vAbnDataTable_0.datechangeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'datechange' in table 'vAbn' is DBNull.", exception);
                }
                return time;
            }

            public void method_13(DateTime dateTime_0)
            {
                base[this.vAbnDataTable_0.datechangeColumn] = dateTime_0;
            }

            public int method_14()
            {
                int num;
                try
                {
                    num = (int) base[this.vAbnDataTable_0.idReasonColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idReason' in table 'vAbn' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(int int_0)
            {
                base[this.vAbnDataTable_0.idReasonColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_16()
            {
                return base.IsNull(this.vAbnDataTable_0.NameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_17()
            {
                base[this.vAbnDataTable_0.NameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.vAbnDataTable_0.TypeNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.vAbnDataTable_0.TypeNameColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                return (int) base[this.vAbnDataTable_0.TypeAbnColumn];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.vAbnDataTable_0.TypeNameSocrColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_21()
            {
                base[this.vAbnDataTable_0.TypeNameSocrColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.vAbnDataTable_0.WorkerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.vAbnDataTable_0.WorkerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_24()
            {
                return base.IsNull(this.vAbnDataTable_0.isActiveColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.vAbnDataTable_0.isActiveColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_26()
            {
                return base.IsNull(this.vAbnDataTable_0.ReasonColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_27()
            {
                base[this.vAbnDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_28()
            {
                return base.IsNull(this.vAbnDataTable_0.datechangeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_29()
            {
                base[this.vAbnDataTable_0.datechangeColumn] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.vAbnDataTable_0.TypeAbnColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_30()
            {
                return base.IsNull(this.vAbnDataTable_0.idReasonColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.vAbnDataTable_0.idReasonColumn] = Convert.DBNull;
            }

            public bool method_4()
            {
                return (bool) base[this.vAbnDataTable_0.DeletedColumn];
            }

            public void method_5(bool bool_0)
            {
                base[this.vAbnDataTable_0.DeletedColumn] = bool_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vAbnDataTable_0.TypeNameSocrColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TypeNameSocr' in table 'vAbn' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.vAbnDataTable_0.TypeNameSocrColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vAbnDataTable_0.WorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Worker' in table 'vAbn' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.vAbnDataTable_0.WorkerColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int idWorker
            {
                get
                {
                    return (int) base[this.vAbnDataTable_0.idWorkerColumn];
                }
                set
                {
                    base[this.vAbnDataTable_0.idWorkerColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vAbnDataTable_0.idColumn];
                }
                set
                {
                    base[this.vAbnDataTable_0.idColumn] = value;
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
                        str = (string) base[this.vAbnDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'vAbn' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vAbnDataTable_0.NameColumn] = value;
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
                        str = (string) base[this.vAbnDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Reason' in table 'vAbn' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vAbnDataTable_0.ReasonColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string TypeName
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vAbnDataTable_0.TypeNameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'TypeName' in table 'vAbn' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vAbnDataTable_0.TypeNameColumn] = value;
                }
            }
        }

        public class Class398 : DataRow
        {
            private dsCalc.dtSourceDataTable dtSourceDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class398(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.dtSourceDataTable_0 = (dsCalc.dtSourceDataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.dtSourceDataTable_0.DesriptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Desription' in table 'dtSource' is DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.dtSourceDataTable_0.DesriptionColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.dtSourceDataTable_0.ValColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.dtSourceDataTable_0.ValColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.dtSourceDataTable_0.DimensionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Dimension' in table 'dtSource' is DBNull.", exception);
                }
                return str;
            }

            public void method_3(string string_0)
            {
                base[this.dtSourceDataTable_0.DimensionColumn] = string_0;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.dtSourceDataTable_0.ValColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Val' in table 'dtSource' is DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.dtSourceDataTable_0.ValColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_6()
            {
                return base.IsNull(this.dtSourceDataTable_0.DesriptionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_7()
            {
                base[this.dtSourceDataTable_0.DesriptionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.dtSourceDataTable_0.DimensionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_9()
            {
                base[this.dtSourceDataTable_0.DimensionColumn] = Convert.DBNull;
            }
        }

        public class Class399 : DataRow
        {
            private dsCalc.tJ_CalcLossFileDataTable tJ_CalcLossFileDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class399(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_CalcLossFileDataTable_0 = (dsCalc.tJ_CalcLossFileDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_CalcLossFileDataTable_0.idCalcColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_CalcLossFileDataTable_0.idCalcColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_10()
            {
                return base.IsNull(this.tJ_CalcLossFileDataTable_0.DateInColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.tJ_CalcLossFileDataTable_0.DateInColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                return (string) base[this.tJ_CalcLossFileDataTable_0.FileNameColumn];
            }

            public void method_3(string string_0)
            {
                base[this.tJ_CalcLossFileDataTable_0.FileNameColumn] = string_0;
            }

            public byte[] method_4()
            {
                byte[] buffer;
                try
                {
                    buffer = (byte[]) base[this.tJ_CalcLossFileDataTable_0.FileColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'File' in table 'tJ_CalcLossFile' is DBNull.", exception);
                }
                return buffer;
            }

            public void method_5(byte[] byte_0)
            {
                base[this.tJ_CalcLossFileDataTable_0.FileColumn] = byte_0;
            }

            public DateTime method_6()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_CalcLossFileDataTable_0.DateInColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateIn' in table 'tJ_CalcLossFile' is DBNull.", exception);
                }
                return time;
            }

            public void method_7(DateTime dateTime_0)
            {
                base[this.tJ_CalcLossFileDataTable_0.DateInColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tJ_CalcLossFileDataTable_0.FileColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.tJ_CalcLossFileDataTable_0.FileColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_CalcLossFileDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_CalcLossFileDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class400 : DataRow
        {
            private dsCalc.vL_SchmAbnDataTable vL_SchmAbnDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class400(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vL_SchmAbnDataTable_0 = (dsCalc.vL_SchmAbnDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vL_SchmAbnDataTable_0.idSchmObjColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vL_SchmAbnDataTable_0.idSchmObjColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.vL_SchmAbnDataTable_0.TypeDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TypeDoc' in table 'vL_SchmAbn' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.vL_SchmAbnDataTable_0.TypeDocColumn] = int_0;
            }

            public string method_12()
            {
                string str;
                try
                {
                    str = (string) base[this.vL_SchmAbnDataTable_0.typeDocNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeDocName' in table 'vL_SchmAbn' is DBNull.", exception);
                }
                return str;
            }

            public void method_13(string string_0)
            {
                base[this.vL_SchmAbnDataTable_0.typeDocNameColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.vL_SchmAbnDataTable_0.SchmObjNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_15()
            {
                base[this.vL_SchmAbnDataTable_0.SchmObjNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.vL_SchmAbnDataTable_0.idAbnColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.vL_SchmAbnDataTable_0.idAbnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.vL_SchmAbnDataTable_0.idAbnObjColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.vL_SchmAbnDataTable_0.idAbnObjColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.vL_SchmAbnDataTable_0.SchmObjNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'SchmObjName' in table 'vL_SchmAbn' is DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.vL_SchmAbnDataTable_0.idPointColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.vL_SchmAbnDataTable_0.idPointColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_22()
            {
                return base.IsNull(this.vL_SchmAbnDataTable_0.idDocColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.vL_SchmAbnDataTable_0.idDocColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.vL_SchmAbnDataTable_0.TypeDocColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_25()
            {
                base[this.vL_SchmAbnDataTable_0.TypeDocColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_26()
            {
                return base.IsNull(this.vL_SchmAbnDataTable_0.typeDocNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_27()
            {
                base[this.vL_SchmAbnDataTable_0.typeDocNameColumn] = Convert.DBNull;
            }

            public void method_3(string string_0)
            {
                base[this.vL_SchmAbnDataTable_0.SchmObjNameColumn] = string_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.vL_SchmAbnDataTable_0.idAbnObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idAbnObj' in table 'vL_SchmAbn' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.vL_SchmAbnDataTable_0.idAbnObjColumn] = int_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.vL_SchmAbnDataTable_0.idPointColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idPoint' in table 'vL_SchmAbn' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.vL_SchmAbnDataTable_0.idPointColumn] = int_0;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.vL_SchmAbnDataTable_0.idDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idDoc' in table 'vL_SchmAbn' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(int int_0)
            {
                base[this.vL_SchmAbnDataTable_0.idDocColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idAbn
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vL_SchmAbnDataTable_0.idAbnColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idAbn' in table 'vL_SchmAbn' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vL_SchmAbnDataTable_0.idAbnColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vL_SchmAbnDataTable_0.idColumn];
                }
                set
                {
                    base[this.vL_SchmAbnDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class401 : DataRow
        {
            private dsCalc.vR_TransformerDataTable vR_TransformerDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class401(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vR_TransformerDataTable_0 = (dsCalc.vR_TransformerDataTable) base.Table;
            }

            public decimal method_0()
            {
                return (decimal) base[this.vR_TransformerDataTable_0.HighVoltageColumn];
            }

            public void method_1(decimal decimal_0)
            {
                base[this.vR_TransformerDataTable_0.HighVoltageColumn] = decimal_0;
            }

            public decimal method_10()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.vR_TransformerDataTable_0.ShortCircuitVoltColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ShortCircuitVolt' in table 'vR_Transformer' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(decimal decimal_0)
            {
                base[this.vR_TransformerDataTable_0.ShortCircuitVoltColumn] = decimal_0;
            }

            public float method_12()
            {
                float num;
                try
                {
                    num = (float) base[this.vR_TransformerDataTable_0.ShortCircuitLossColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ShortCircuitLoss' in table 'vR_Transformer' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(float float_0)
            {
                base[this.vR_TransformerDataTable_0.ShortCircuitLossColumn] = float_0;
            }

            public float method_14()
            {
                float num;
                try
                {
                    num = (float) base[this.vR_TransformerDataTable_0.NoLoadLossColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NoLoadLoss' in table 'vR_Transformer' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(float float_0)
            {
                base[this.vR_TransformerDataTable_0.NoLoadLossColumn] = float_0;
            }

            public bool method_16()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.vR_TransformerDataTable_0.DeletedColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Deleted' in table 'vR_Transformer' is DBNull.", exception);
                }
                return flag;
            }

            public void method_17(bool bool_0)
            {
                base[this.vR_TransformerDataTable_0.DeletedColumn] = bool_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.vR_TransformerDataTable_0.FullNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.vR_TransformerDataTable_0.FullNameColumn] = Convert.DBNull;
            }

            public decimal method_2()
            {
                return (decimal) base[this.vR_TransformerDataTable_0.LowVoltageColumn];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.vR_TransformerDataTable_0.RatedAmperHVColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.vR_TransformerDataTable_0.RatedAmperHVColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_22()
            {
                return base.IsNull(this.vR_TransformerDataTable_0.RatedAmperLVColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.vR_TransformerDataTable_0.RatedAmperLVColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.vR_TransformerDataTable_0.GroupWindingsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_25()
            {
                base[this.vR_TransformerDataTable_0.GroupWindingsColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_26()
            {
                return base.IsNull(this.vR_TransformerDataTable_0.ShortCircuitVoltColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_27()
            {
                base[this.vR_TransformerDataTable_0.ShortCircuitVoltColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_28()
            {
                return base.IsNull(this.vR_TransformerDataTable_0.ShortCircuitLossColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_29()
            {
                base[this.vR_TransformerDataTable_0.ShortCircuitLossColumn] = Convert.DBNull;
            }

            public void method_3(decimal decimal_0)
            {
                base[this.vR_TransformerDataTable_0.LowVoltageColumn] = decimal_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_30()
            {
                return base.IsNull(this.vR_TransformerDataTable_0.NoLoadLossColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_31()
            {
                base[this.vR_TransformerDataTable_0.NoLoadLossColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_32()
            {
                return base.IsNull(this.vR_TransformerDataTable_0.DeletedColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_33()
            {
                base[this.vR_TransformerDataTable_0.DeletedColumn] = Convert.DBNull;
            }

            public decimal method_4()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.vR_TransformerDataTable_0.RatedAmperHVColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'RatedAmperHV' in table 'vR_Transformer' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(decimal decimal_0)
            {
                base[this.vR_TransformerDataTable_0.RatedAmperHVColumn] = decimal_0;
            }

            public decimal method_6()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.vR_TransformerDataTable_0.RatedAmperLVColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'RatedAmperLV' in table 'vR_Transformer' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(decimal decimal_0)
            {
                base[this.vR_TransformerDataTable_0.RatedAmperLVColumn] = decimal_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vR_TransformerDataTable_0.GroupWindingsColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'GroupWindings' in table 'vR_Transformer' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.vR_TransformerDataTable_0.GroupWindingsColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FullName
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vR_TransformerDataTable_0.FullNameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'FullName' in table 'vR_Transformer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vR_TransformerDataTable_0.FullNameColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vR_TransformerDataTable_0.idColumn];
                }
                set
                {
                    base[this.vR_TransformerDataTable_0.idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Name
            {
                get
                {
                    return (string) base[this.vR_TransformerDataTable_0.NameColumn];
                }
                set
                {
                    base[this.vR_TransformerDataTable_0.NameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Power
            {
                get
                {
                    return (int) base[this.vR_TransformerDataTable_0.PowerColumn];
                }
                set
                {
                    base[this.vR_TransformerDataTable_0.PowerColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Type
            {
                get
                {
                    return (string) base[this.vR_TransformerDataTable_0.TypeColumn];
                }
                set
                {
                    base[this.vR_TransformerDataTable_0.TypeColumn] = value;
                }
            }
        }

        public class Class402 : DataRow
        {
            private dsCalc.tJ_CalcLossTransDataTable tJ_CalcLossTransDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class402(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_CalcLossTransDataTable_0 = (dsCalc.tJ_CalcLossTransDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_CalcLossTransDataTable_0.idCalcColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.idCalcColumn] = int_0;
            }

            public decimal method_10()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.ShortCircuitLossColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ShortCircuitLoss' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.ShortCircuitLossColumn] = decimal_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransDataTable_0.ConsumptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Consumption' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.ConsumptionColumn] = int_0;
            }

            public decimal method_14()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.RatedVoltageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'RatedVoltage' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.RatedVoltageColumn] = decimal_0;
            }

            public int method_16()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransDataTable_0.PeriodColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Period' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_17(int int_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.PeriodColumn] = int_0;
            }

            public decimal method_18()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.MiddleVoltageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'MiddleVoltage' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_19(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.MiddleVoltageColumn] = decimal_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransDataTable_0.numTransColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'numTrans' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public decimal method_20()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.CoeffPowerReactiveColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoeffPowerReactive' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_21(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.CoeffPowerReactiveColumn] = decimal_0;
            }

            public decimal method_22()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.SquareCoeffFromGraphColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'SquareCoeffFromGraph' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_23(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.SquareCoeffFromGraphColumn] = decimal_0;
            }

            public decimal method_24()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.CoeffDifferenceColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoeffDifference' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.CoeffDifferenceColumn] = decimal_0;
            }

            public decimal method_26()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.LossElectrHHColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LossElectrHH' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_27(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.LossElectrHHColumn] = decimal_0;
            }

            public decimal method_28()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.ActiveResistanceColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ActiveResistance' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_29(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.ActiveResistanceColumn] = decimal_0;
            }

            public void method_3(int int_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.numTransColumn] = int_0;
            }

            public decimal method_30()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.LoadPowerLossColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LoadPowerLoss' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_31(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.LoadPowerLossColumn] = decimal_0;
            }

            public decimal method_32()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.LoadAverageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LoadAverage' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_33(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.LoadAverageColumn] = decimal_0;
            }

            public decimal method_34()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.LoadLossesColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LoadLosses' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_35(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.LoadLossesColumn] = decimal_0;
            }

            public decimal method_36()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.CoeffLossesColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoeffLosses' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_37(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.CoeffLossesColumn] = decimal_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.numTransColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_39()
            {
                base[this.tJ_CalcLossTransDataTable_0.numTransColumn] = Convert.DBNull;
            }

            public int method_4()
            {
                return (int) base[this.tJ_CalcLossTransDataTable_0.makeupTransColumn];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_40()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.RatedPowerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_41()
            {
                base[this.tJ_CalcLossTransDataTable_0.RatedPowerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_42()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.NoLoadLossColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_43()
            {
                base[this.tJ_CalcLossTransDataTable_0.NoLoadLossColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_44()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.ShortCircuitLossColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.tJ_CalcLossTransDataTable_0.ShortCircuitLossColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_46()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.ConsumptionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.tJ_CalcLossTransDataTable_0.ConsumptionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_48()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.RatedVoltageColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_49()
            {
                base[this.tJ_CalcLossTransDataTable_0.RatedVoltageColumn] = Convert.DBNull;
            }

            public void method_5(int int_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.makeupTransColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.PeriodColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_51()
            {
                base[this.tJ_CalcLossTransDataTable_0.PeriodColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_52()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.MiddleVoltageColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_53()
            {
                base[this.tJ_CalcLossTransDataTable_0.MiddleVoltageColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_54()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.CoeffPowerReactiveColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.tJ_CalcLossTransDataTable_0.CoeffPowerReactiveColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_56()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.SquareCoeffFromGraphColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_57()
            {
                base[this.tJ_CalcLossTransDataTable_0.SquareCoeffFromGraphColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_58()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.CoeffDifferenceColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_59()
            {
                base[this.tJ_CalcLossTransDataTable_0.CoeffDifferenceColumn] = Convert.DBNull;
            }

            public decimal method_6()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.RatedPowerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'RatedPower' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_60()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.LossElectrHHColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_61()
            {
                base[this.tJ_CalcLossTransDataTable_0.LossElectrHHColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_62()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.ActiveResistanceColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_63()
            {
                base[this.tJ_CalcLossTransDataTable_0.ActiveResistanceColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_64()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.LoadPowerLossColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_65()
            {
                base[this.tJ_CalcLossTransDataTable_0.LoadPowerLossColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_66()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.LoadAverageColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_67()
            {
                base[this.tJ_CalcLossTransDataTable_0.LoadAverageColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_68()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.LoadLossesColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_69()
            {
                base[this.tJ_CalcLossTransDataTable_0.LoadLossesColumn] = Convert.DBNull;
            }

            public void method_7(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.RatedPowerColumn] = decimal_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_70()
            {
                return base.IsNull(this.tJ_CalcLossTransDataTable_0.CoeffLossesColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_71()
            {
                base[this.tJ_CalcLossTransDataTable_0.CoeffLossesColumn] = Convert.DBNull;
            }

            public decimal method_8()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_CalcLossTransDataTable_0.NoLoadLossColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NoLoadLoss' in table 'tJ_CalcLossTrans' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(decimal decimal_0)
            {
                base[this.tJ_CalcLossTransDataTable_0.NoLoadLossColumn] = decimal_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_CalcLossTransDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_CalcLossTransDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class403 : DataRow
        {
            private dsCalc.tJ_CalcLossTransHHDataTable tJ_CalcLossTransHHDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class403(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_CalcLossTransHHDataTable_0 = (dsCalc.tJ_CalcLossTransHHDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_CalcLossTransHHDataTable_0.idCalcColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.idCalcColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month04Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month04' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month04Column] = int_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month05Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month05' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month05Column] = int_0;
            }

            public int method_14()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month06Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month06' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month06Column] = int_0;
            }

            public int method_16()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month07Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month07' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public void method_17(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month07Column] = int_0;
            }

            public int method_18()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month08Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month08' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public void method_19(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month08Column] = int_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.idTransColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idTrans' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public int method_20()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month09Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month09' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public void method_21(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month09Column] = int_0;
            }

            public int method_22()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month10Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month10' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public void method_23(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month10Column] = int_0;
            }

            public int method_24()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month11Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month11' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month11Column] = int_0;
            }

            public int method_26()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month12Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month12' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public void method_27(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month12Column] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_28()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.idTransColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_29()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.idTransColumn] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.idTransColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_30()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month01Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_31()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month01Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month02Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_33()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month02Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_34()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month03Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month03Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_36()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month04Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_37()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month04Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_38()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month05Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_39()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month05Column] = Convert.DBNull;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month01Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month01' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month06Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_41()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month06Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month07Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_43()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month07Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_44()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month08Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_45()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month08Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_46()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month09Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_47()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month09Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_48()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month10Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month10Column] = Convert.DBNull;
            }

            public void method_5(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month01Column] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month11Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month11Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_52()
            {
                return base.IsNull(this.tJ_CalcLossTransHHDataTable_0.month12Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_53()
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month12Column] = Convert.DBNull;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month02Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month02' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month02Column] = int_0;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_CalcLossTransHHDataTable_0.month03Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'month03' in table 'tJ_CalcLossTransHH' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(int int_0)
            {
                base[this.tJ_CalcLossTransHHDataTable_0.month03Column] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_CalcLossTransHHDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_CalcLossTransHHDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class404 : DataRow
        {
            private dsCalc.dtIsolationLossDataTable dtIsolationLossDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class404(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.dtIsolationLossDataTable_0 = (dsCalc.dtIsolationLossDataTable) base.Table;
            }

            public decimal method_0()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month1Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month1' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month1Column] = decimal_0;
            }

            public decimal method_10()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month6Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month6' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month6Column] = decimal_0;
            }

            public decimal method_12()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month7Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month7' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month7Column] = decimal_0;
            }

            public decimal method_14()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month8Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month8' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month8Column] = decimal_0;
            }

            public decimal method_16()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month9Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month9' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_17(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month9Column] = decimal_0;
            }

            public decimal method_18()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month10Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month10' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_19(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month10Column] = decimal_0;
            }

            public decimal method_2()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month2Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month2' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            public decimal method_20()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month11Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month11' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_21(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month11Column] = decimal_0;
            }

            public decimal method_22()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month12Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month12' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_23(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month12Column] = decimal_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month1Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_25()
            {
                base[this.dtIsolationLossDataTable_0.Month1Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_26()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month2Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_27()
            {
                base[this.dtIsolationLossDataTable_0.Month2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_28()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month3Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_29()
            {
                base[this.dtIsolationLossDataTable_0.Month3Column] = Convert.DBNull;
            }

            public void method_3(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month2Column] = decimal_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_30()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month4Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_31()
            {
                base[this.dtIsolationLossDataTable_0.Month4Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_32()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month5Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_33()
            {
                base[this.dtIsolationLossDataTable_0.Month5Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_34()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month6Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.dtIsolationLossDataTable_0.Month6Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month7Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_37()
            {
                base[this.dtIsolationLossDataTable_0.Month7Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month8Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_39()
            {
                base[this.dtIsolationLossDataTable_0.Month8Column] = Convert.DBNull;
            }

            public decimal method_4()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month3Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month3' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month9Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_41()
            {
                base[this.dtIsolationLossDataTable_0.Month9Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month10Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_43()
            {
                base[this.dtIsolationLossDataTable_0.Month10Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_44()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month11Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_45()
            {
                base[this.dtIsolationLossDataTable_0.Month11Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_46()
            {
                return base.IsNull(this.dtIsolationLossDataTable_0.Month12Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.dtIsolationLossDataTable_0.Month12Column] = Convert.DBNull;
            }

            public void method_5(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month3Column] = decimal_0;
            }

            public decimal method_6()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month4Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month4' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month4Column] = decimal_0;
            }

            public decimal method_8()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.dtIsolationLossDataTable_0.Month5Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month5' in table 'dtIsolationLoss' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(decimal decimal_0)
            {
                base[this.dtIsolationLossDataTable_0.Month5Column] = decimal_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate237(object sender, dsCalc.EventArgs233 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate238(object sender, dsCalc.EventArgs234 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate239(object sender, dsCalc.EventArgs235 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate240(object sender, dsCalc.EventArgs236 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate241(object sender, dsCalc.EventArgs237 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate242(object sender, dsCalc.EventArgs238 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate243(object sender, dsCalc.EventArgs239 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate244(object sender, dsCalc.EventArgs240 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate245(object sender, dsCalc.EventArgs241 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate246(object sender, dsCalc.EventArgs242 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate247(object sender, dsCalc.EventArgs243 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate248(object sender, dsCalc.EventArgs244 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate249(object sender, dsCalc.EventArgs245 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate250(object sender, dsCalc.EventArgs246 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate251(object sender, dsCalc.EventArgs247 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate252(object sender, dsCalc.EventArgs248 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate253(object sender, dsCalc.EventArgs249 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate254(object sender, dsCalc.EventArgs250 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate255(object sender, dsCalc.EventArgs251 e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class dtIsolationLossDataTable : TypedTableBase<dsCalc.Class404>
        {
            private DataColumn columnMonth1;
            private DataColumn columnMonth10;
            private DataColumn columnMonth11;
            private DataColumn columnMonth12;
            private DataColumn columnMonth2;
            private DataColumn columnMonth3;
            private DataColumn columnMonth4;
            private DataColumn columnMonth5;
            private DataColumn columnMonth6;
            private DataColumn columnMonth7;
            private DataColumn columnMonth8;
            private DataColumn columnMonth9;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate255 dtIsolationLossRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate255 dtIsolationLossRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate255 dtIsolationLossRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate255 dtIsolationLossRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dtIsolationLossDataTable()
            {
                base.TableName = "dtIsolationLoss";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal dtIsolationLossDataTable(DataTable dataTable_0)
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
            protected dtIsolationLossDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                dsCalc.dtIsolationLossDataTable table1 = (dsCalc.dtIsolationLossDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.dtIsolationLossDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class404);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class404 class404_0)
            {
                base.Rows.Add(class404_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class404 method_1(decimal decimal_0, decimal decimal_1, decimal decimal_2, decimal decimal_3, decimal decimal_4, decimal decimal_5, decimal decimal_6, decimal decimal_7, decimal decimal_8, decimal decimal_9, decimal decimal_10, decimal decimal_11)
            {
                dsCalc.Class404 row = (dsCalc.Class404) base.NewRow();
                object[] objArray = new object[] { decimal_0, decimal_1, decimal_2, decimal_3, decimal_4, decimal_5, decimal_6, decimal_7, decimal_8, decimal_9, decimal_10, decimal_11 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnMonth1 = base.Columns["Month1"];
                this.columnMonth2 = base.Columns["Month2"];
                this.columnMonth3 = base.Columns["Month3"];
                this.columnMonth4 = base.Columns["Month4"];
                this.columnMonth5 = base.Columns["Month5"];
                this.columnMonth6 = base.Columns["Month6"];
                this.columnMonth7 = base.Columns["Month7"];
                this.columnMonth8 = base.Columns["Month8"];
                this.columnMonth9 = base.Columns["Month9"];
                this.columnMonth10 = base.Columns["Month10"];
                this.columnMonth11 = base.Columns["Month11"];
                this.columnMonth12 = base.Columns["Month12"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnMonth1 = new DataColumn("Month1", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth1);
                this.columnMonth2 = new DataColumn("Month2", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth2);
                this.columnMonth3 = new DataColumn("Month3", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth3);
                this.columnMonth4 = new DataColumn("Month4", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth4);
                this.columnMonth5 = new DataColumn("Month5", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth5);
                this.columnMonth6 = new DataColumn("Month6", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth6);
                this.columnMonth7 = new DataColumn("Month7", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth7);
                this.columnMonth8 = new DataColumn("Month8", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth8);
                this.columnMonth9 = new DataColumn("Month9", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth9);
                this.columnMonth10 = new DataColumn("Month10", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth10);
                this.columnMonth11 = new DataColumn("Month11", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth11);
                this.columnMonth12 = new DataColumn("Month12", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMonth12);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class404 method_4()
            {
                return (dsCalc.Class404) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(dsCalc.Class404 class404_0)
            {
                base.Rows.Remove(class404_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class404(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.dtIsolationLossRowChanged != null)
                {
                    this.dtIsolationLossRowChanged(this, new dsCalc.EventArgs251((dsCalc.Class404) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.dtIsolationLossRowChanging != null)
                {
                    this.dtIsolationLossRowChanging(this, new dsCalc.EventArgs251((dsCalc.Class404) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.dtIsolationLossRowDeleted != null)
                {
                    this.dtIsolationLossRowDeleted(this, new dsCalc.EventArgs251((dsCalc.Class404) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.dtIsolationLossRowDeleting != null)
                {
                    this.dtIsolationLossRowDeleting(this, new dsCalc.EventArgs251((dsCalc.Class404) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "dtIsolationLossDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public dsCalc.Class404 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class404) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Month10Column
            {
                get
                {
                    return this.columnMonth10;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Month11Column
            {
                get
                {
                    return this.columnMonth11;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Month12Column
            {
                get
                {
                    return this.columnMonth12;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn Month1Column
            {
                get
                {
                    return this.columnMonth1;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Month2Column
            {
                get
                {
                    return this.columnMonth2;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Month3Column
            {
                get
                {
                    return this.columnMonth3;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn Month4Column
            {
                get
                {
                    return this.columnMonth4;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Month5Column
            {
                get
                {
                    return this.columnMonth5;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Month6Column
            {
                get
                {
                    return this.columnMonth6;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Month7Column
            {
                get
                {
                    return this.columnMonth7;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn Month8Column
            {
                get
                {
                    return this.columnMonth8;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn Month9Column
            {
                get
                {
                    return this.columnMonth9;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class dtSourceDataTable : TypedTableBase<dsCalc.Class398>
        {
            private DataColumn columnDesription;
            private DataColumn columnDimension;
            private DataColumn columnVal;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate249 dtSourceRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate249 dtSourceRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate249 dtSourceRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate249 dtSourceRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dtSourceDataTable()
            {
                base.TableName = "dtSource";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal dtSourceDataTable(DataTable dataTable_0)
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
            protected dtSourceDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                dsCalc.dtSourceDataTable table1 = (dsCalc.dtSourceDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.dtSourceDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class398);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(dsCalc.Class398 class398_0)
            {
                base.Rows.Add(class398_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class398 method_1(string string_0, string string_1, string string_2)
            {
                dsCalc.Class398 row = (dsCalc.Class398) base.NewRow();
                object[] objArray = new object[] { string_0, string_1, string_2 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnDesription = base.Columns["Desription"];
                this.columnDimension = base.Columns["Dimension"];
                this.columnVal = base.Columns["Val"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnDesription = new DataColumn("Desription", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDesription);
                this.columnDimension = new DataColumn("Dimension", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDimension);
                this.columnVal = new DataColumn("Val", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnVal);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class398 method_4()
            {
                return (dsCalc.Class398) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(dsCalc.Class398 class398_0)
            {
                base.Rows.Remove(class398_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class398(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.dtSourceRowChanged != null)
                {
                    this.dtSourceRowChanged(this, new dsCalc.EventArgs245((dsCalc.Class398) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.dtSourceRowChanging != null)
                {
                    this.dtSourceRowChanging(this, new dsCalc.EventArgs245((dsCalc.Class398) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.dtSourceRowDeleted != null)
                {
                    this.dtSourceRowDeleted(this, new dsCalc.EventArgs245((dsCalc.Class398) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.dtSourceRowDeleting != null)
                {
                    this.dtSourceRowDeleting(this, new dsCalc.EventArgs245((dsCalc.Class398) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "dtSourceDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn DesriptionColumn
            {
                get
                {
                    return this.columnDesription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DimensionColumn
            {
                get
                {
                    return this.columnDimension;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class398 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class398) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ValColumn
            {
                get
                {
                    return this.columnVal;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs233 : EventArgs
        {
            private dsCalc.Class386 class386_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs233(dsCalc.Class386 class386_1, DataRowAction dataRowAction_1)
            {
                this.class386_0 = class386_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class386 method_0()
            {
                return this.class386_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs234 : EventArgs
        {
            private dsCalc.Class387 class387_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs234(dsCalc.Class387 class387_1, DataRowAction dataRowAction_1)
            {
                this.class387_0 = class387_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class387 method_0()
            {
                return this.class387_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs235 : EventArgs
        {
            private dsCalc.Class388 class388_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs235(dsCalc.Class388 class388_1, DataRowAction dataRowAction_1)
            {
                this.class388_0 = class388_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class388 method_0()
            {
                return this.class388_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs236 : EventArgs
        {
            private dsCalc.Class389 class389_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs236(dsCalc.Class389 class389_1, DataRowAction dataRowAction_1)
            {
                this.class389_0 = class389_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class389 method_0()
            {
                return this.class389_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs237 : EventArgs
        {
            private dsCalc.Class390 class390_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs237(dsCalc.Class390 class390_1, DataRowAction dataRowAction_1)
            {
                this.class390_0 = class390_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class390 method_0()
            {
                return this.class390_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs238 : EventArgs
        {
            private dsCalc.Class391 class391_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs238(dsCalc.Class391 class391_1, DataRowAction dataRowAction_1)
            {
                this.class391_0 = class391_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class391 method_0()
            {
                return this.class391_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs239 : EventArgs
        {
            private dsCalc.Class392 class392_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs239(dsCalc.Class392 class392_1, DataRowAction dataRowAction_1)
            {
                this.class392_0 = class392_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class392 method_0()
            {
                return this.class392_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs240 : EventArgs
        {
            private dsCalc.Class393 class393_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs240(dsCalc.Class393 class393_1, DataRowAction dataRowAction_1)
            {
                this.class393_0 = class393_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class393 method_0()
            {
                return this.class393_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs241 : EventArgs
        {
            private dsCalc.Class394 class394_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs241(dsCalc.Class394 class394_1, DataRowAction dataRowAction_1)
            {
                this.class394_0 = class394_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class394 method_0()
            {
                return this.class394_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs242 : EventArgs
        {
            private dsCalc.Class395 class395_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs242(dsCalc.Class395 class395_1, DataRowAction dataRowAction_1)
            {
                this.class395_0 = class395_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class395 method_0()
            {
                return this.class395_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs243 : EventArgs
        {
            private dsCalc.Class396 class396_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs243(dsCalc.Class396 class396_1, DataRowAction dataRowAction_1)
            {
                this.class396_0 = class396_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class396 method_0()
            {
                return this.class396_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs244 : EventArgs
        {
            private dsCalc.Class397 class397_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs244(dsCalc.Class397 class397_1, DataRowAction dataRowAction_1)
            {
                this.class397_0 = class397_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class397 method_0()
            {
                return this.class397_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs245 : EventArgs
        {
            private dsCalc.Class398 class398_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs245(dsCalc.Class398 class398_1, DataRowAction dataRowAction_1)
            {
                this.class398_0 = class398_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class398 method_0()
            {
                return this.class398_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs246 : EventArgs
        {
            private dsCalc.Class399 class399_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs246(dsCalc.Class399 class399_1, DataRowAction dataRowAction_1)
            {
                this.class399_0 = class399_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class399 method_0()
            {
                return this.class399_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs247 : EventArgs
        {
            private dsCalc.Class400 class400_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs247(dsCalc.Class400 class400_1, DataRowAction dataRowAction_1)
            {
                this.class400_0 = class400_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class400 method_0()
            {
                return this.class400_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs248 : EventArgs
        {
            private dsCalc.Class401 class401_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs248(dsCalc.Class401 class401_1, DataRowAction dataRowAction_1)
            {
                this.class401_0 = class401_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class401 method_0()
            {
                return this.class401_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs249 : EventArgs
        {
            private dsCalc.Class402 class402_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs249(dsCalc.Class402 class402_1, DataRowAction dataRowAction_1)
            {
                this.class402_0 = class402_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class402 method_0()
            {
                return this.class402_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs250 : EventArgs
        {
            private dsCalc.Class403 class403_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs250(dsCalc.Class403 class403_1, DataRowAction dataRowAction_1)
            {
                this.class403_0 = class403_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class403 method_0()
            {
                return this.class403_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs251 : EventArgs
        {
            private dsCalc.Class404 class404_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs251(dsCalc.Class404 class404_1, DataRowAction dataRowAction_1)
            {
                this.class404_0 = class404_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public dsCalc.Class404 method_0()
            {
                return this.class404_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tAbnDataTable : TypedTableBase<dsCalc.Class389>
        {
            private DataColumn columnCodeAbonent;
            private DataColumn columnDeleted;
            private DataColumn columnid;
            private DataColumn columnidWorker;
            private DataColumn columnName;
            private DataColumn columnTypeAbn;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate240 tAbnRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate240 tAbnRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate240 tAbnRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate240 tAbnRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tAbnDataTable()
            {
                base.TableName = "tAbn";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tAbnDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                dsCalc.tAbnDataTable table1 = (dsCalc.tAbnDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.tAbnDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class389);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class389 class389_0)
            {
                base.Rows.Add(class389_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class389 method_1(int int_0, string string_0, int int_1, int int_2, bool bool_0)
            {
                dsCalc.Class389 row = (dsCalc.Class389) base.NewRow();
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
            public dsCalc.Class389 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class389) base.Rows.Find(keys);
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
            public dsCalc.Class389 method_5()
            {
                return (dsCalc.Class389) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(dsCalc.Class389 class389_0)
            {
                base.Rows.Remove(class389_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class389(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tAbnRowChanged != null)
                {
                    this.tAbnRowChanged(this, new dsCalc.EventArgs236((dsCalc.Class389) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tAbnRowChanging != null)
                {
                    this.tAbnRowChanging(this, new dsCalc.EventArgs236((dsCalc.Class389) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tAbnRowDeleted != null)
                {
                    this.tAbnRowDeleted(this, new dsCalc.EventArgs236((dsCalc.Class389) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tAbnRowDeleting != null)
                {
                    this.tAbnRowDeleting(this, new dsCalc.EventArgs236((dsCalc.Class389) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tAbnDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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

            [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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
            public dsCalc.Class389 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class389) base.Rows[int_0];
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
            public DataColumn TypeAbnColumn
            {
                get
                {
                    return this.columnTypeAbn;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblLockDataTable : TypedTableBase<dsCalc.Class391>
        {
            private DataColumn columnidLock;
            private DataColumn columnTable;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate242 tblLockRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate242 tblLockRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate242 tblLockRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate242 tblLockRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tblLockDataTable()
            {
                base.TableName = "tblLock";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tblLockDataTable(DataTable dataTable_0)
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
            protected tblLockDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                dsCalc.tblLockDataTable table1 = (dsCalc.tblLockDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.tblLockDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class391);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class391 class391_0)
            {
                base.Rows.Add(class391_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class391 method_1(int int_0, string string_0)
            {
                dsCalc.Class391 row = (dsCalc.Class391) base.NewRow();
                object[] objArray = new object[] { int_0, string_0 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class391 method_2(int int_0, string string_0)
            {
                object[] keys = new object[] { int_0, string_0 };
                return (dsCalc.Class391) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnidLock = base.Columns["idLock"];
                this.columnTable = base.Columns["Table"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnidLock = new DataColumn("idLock", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidLock);
                this.columnTable = new DataColumn("Table", typeof(string), null, MappingType.Element);
                this.columnTable.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "TableColumn");
                this.columnTable.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnTable");
                this.columnTable.ExtendedProperties.Add("Generator_UserColumnName", "Table");
                base.Columns.Add(this.columnTable);
                DataColumn[] columns = new DataColumn[] { this.columnidLock, this.columnTable };
                base.Constraints.Add(new UniqueConstraint("tblLockKey1", columns, true));
                this.columnidLock.AllowDBNull = false;
                this.columnTable.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class391 method_5()
            {
                return (dsCalc.Class391) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(dsCalc.Class391 class391_0)
            {
                base.Rows.Remove(class391_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class391(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tblLockRowChanged != null)
                {
                    this.tblLockRowChanged(this, new dsCalc.EventArgs238((dsCalc.Class391) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tblLockRowChanging != null)
                {
                    this.tblLockRowChanging(this, new dsCalc.EventArgs238((dsCalc.Class391) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tblLockRowDeleted != null)
                {
                    this.tblLockRowDeleted(this, new dsCalc.EventArgs238((dsCalc.Class391) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tblLockRowDeleting != null)
                {
                    this.tblLockRowDeleting(this, new dsCalc.EventArgs238((dsCalc.Class391) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tblLockDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn idLockColumn
            {
                get
                {
                    return this.columnidLock;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class391 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class391) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TableColumn
            {
                get
                {
                    return this.columnTable;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tDocCalcDataTable : TypedTableBase<dsCalc.Class386>
        {
            private DataColumn columnActiveResistance;
            private DataColumn columnAverageVoltage;
            private DataColumn columnCoefficientDifferences;
            private DataColumn columnCoefficientLoss;
            private DataColumn columnCoefficientPowerReactive;
            private DataColumn columnComment;
            private DataColumn columnConsumption;
            private DataColumn columnCountCepey;
            private DataColumn columnDateAct;
            private DataColumn columnDateIn;
            private DataColumn columnDeleted;
            private DataColumn columnElectricalResistance;
            private DataColumn columnid;
            private DataColumn columnIdAbn;
            private DataColumn columnidDocType;
            private DataColumn columnidMarkCable;
            private DataColumn columnIdOwner;
            private DataColumn columnLineLength;
            private DataColumn columnLoadAverage;
            private DataColumn columnLoadLosses;
            private DataColumn columnLoadPowerLoss;
            private DataColumn columnPeriod;
            private DataColumn columnRepresentative;
            private DataColumn columnSquareCoefficientFormGraphics;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate237 tDocCalcRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate237 tDocCalcRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate237 tDocCalcRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate237 tDocCalcRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tDocCalcDataTable()
            {
                base.TableName = "tDocCalc";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tDocCalcDataTable(DataTable dataTable_0)
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
            protected tDocCalcDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                dsCalc.tDocCalcDataTable table1 = (dsCalc.tDocCalcDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.tDocCalcDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class386);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(dsCalc.Class386 class386_0)
            {
                base.Rows.Add(class386_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class386 method_1(int int_0, int int_1, int int_2, string string_0, DateTime dateTime_0, DateTime dateTime_1, int int_3, string string_1, decimal decimal_0, decimal decimal_1, decimal decimal_2, int int_4, int int_5, decimal decimal_3, decimal decimal_4, decimal decimal_5, decimal decimal_6, decimal decimal_7, decimal decimal_8, decimal decimal_9, decimal decimal_10, bool bool_0, int int_6)
            {
                dsCalc.Class386 row = (dsCalc.Class386) base.NewRow();
                object[] objArray1 = new object[0x18];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = int_2;
                objArray1[4] = string_0;
                objArray1[5] = dateTime_0;
                objArray1[6] = dateTime_1;
                objArray1[7] = int_3;
                objArray1[8] = string_1;
                objArray1[9] = decimal_0;
                objArray1[10] = decimal_1;
                objArray1[11] = decimal_2;
                objArray1[12] = int_4;
                objArray1[13] = int_5;
                objArray1[14] = decimal_3;
                objArray1[15] = decimal_4;
                objArray1[0x10] = decimal_5;
                objArray1[0x11] = decimal_6;
                objArray1[0x12] = decimal_7;
                objArray1[0x13] = decimal_8;
                objArray1[20] = decimal_9;
                objArray1[0x15] = decimal_10;
                objArray1[0x16] = bool_0;
                objArray1[0x17] = int_6;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class386 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class386) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidDocType = base.Columns["idDocType"];
                this.columnIdAbn = base.Columns["IdAbn"];
                this.columnidMarkCable = base.Columns["idMarkCable"];
                this.columnRepresentative = base.Columns["Representative"];
                this.columnDateIn = base.Columns["DateIn"];
                this.columnDateAct = base.Columns["DateAct"];
                this.columnIdOwner = base.Columns["IdOwner"];
                this.columnComment = base.Columns["Comment"];
                this.columnLineLength = base.Columns["LineLength"];
                this.columnElectricalResistance = base.Columns["ElectricalResistance"];
                this.columnAverageVoltage = base.Columns["AverageVoltage"];
                this.columnConsumption = base.Columns["Consumption"];
                this.columnPeriod = base.Columns["Period"];
                this.columnCoefficientPowerReactive = base.Columns["CoefficientPowerReactive"];
                this.columnSquareCoefficientFormGraphics = base.Columns["SquareCoefficientFormGraphics"];
                this.columnCoefficientDifferences = base.Columns["CoefficientDifferences"];
                this.columnActiveResistance = base.Columns["ActiveResistance"];
                this.columnLoadPowerLoss = base.Columns["LoadPowerLoss"];
                this.columnLoadAverage = base.Columns["LoadAverage"];
                this.columnLoadLosses = base.Columns["LoadLosses"];
                this.columnCoefficientLoss = base.Columns["CoefficientLoss"];
                this.columnDeleted = base.Columns["Deleted"];
                this.columnCountCepey = base.Columns["CountCepey"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidDocType = new DataColumn("idDocType", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidDocType);
                this.columnIdAbn = new DataColumn("IdAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnIdAbn);
                this.columnidMarkCable = new DataColumn("idMarkCable", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidMarkCable);
                this.columnRepresentative = new DataColumn("Representative", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnRepresentative);
                this.columnDateIn = new DataColumn("DateIn", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateIn);
                this.columnDateAct = new DataColumn("DateAct", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateAct);
                this.columnIdOwner = new DataColumn("IdOwner", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnIdOwner);
                this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComment);
                this.columnLineLength = new DataColumn("LineLength", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLineLength);
                this.columnElectricalResistance = new DataColumn("ElectricalResistance", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnElectricalResistance);
                this.columnAverageVoltage = new DataColumn("AverageVoltage", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnAverageVoltage);
                this.columnConsumption = new DataColumn("Consumption", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnConsumption);
                this.columnPeriod = new DataColumn("Period", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnPeriod);
                this.columnCoefficientPowerReactive = new DataColumn("CoefficientPowerReactive", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnCoefficientPowerReactive);
                this.columnSquareCoefficientFormGraphics = new DataColumn("SquareCoefficientFormGraphics", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnSquareCoefficientFormGraphics);
                this.columnCoefficientDifferences = new DataColumn("CoefficientDifferences", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnCoefficientDifferences);
                this.columnActiveResistance = new DataColumn("ActiveResistance", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnActiveResistance);
                this.columnLoadPowerLoss = new DataColumn("LoadPowerLoss", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLoadPowerLoss);
                this.columnLoadAverage = new DataColumn("LoadAverage", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLoadAverage);
                this.columnLoadLosses = new DataColumn("LoadLosses", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLoadLosses);
                this.columnCoefficientLoss = new DataColumn("CoefficientLoss", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnCoefficientLoss);
                this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnDeleted);
                this.columnCountCepey = new DataColumn("CountCepey", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCountCepey);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidDocType.AllowDBNull = false;
                this.columnIdAbn.AllowDBNull = false;
                this.columnRepresentative.MaxLength = 150;
                this.columnComment.MaxLength = 0x200;
                this.columnDeleted.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class386 method_5()
            {
                return (dsCalc.Class386) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(dsCalc.Class386 class386_0)
            {
                base.Rows.Remove(class386_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class386(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tDocCalcRowChanged != null)
                {
                    this.tDocCalcRowChanged(this, new dsCalc.EventArgs233((dsCalc.Class386) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tDocCalcRowChanging != null)
                {
                    this.tDocCalcRowChanging(this, new dsCalc.EventArgs233((dsCalc.Class386) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tDocCalcRowDeleted != null)
                {
                    this.tDocCalcRowDeleted(this, new dsCalc.EventArgs233((dsCalc.Class386) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tDocCalcRowDeleting != null)
                {
                    this.tDocCalcRowDeleting(this, new dsCalc.EventArgs233((dsCalc.Class386) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tDocCalcDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn ActiveResistanceColumn
            {
                get
                {
                    return this.columnActiveResistance;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn AverageVoltageColumn
            {
                get
                {
                    return this.columnAverageVoltage;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CoefficientDifferencesColumn
            {
                get
                {
                    return this.columnCoefficientDifferences;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CoefficientLossColumn
            {
                get
                {
                    return this.columnCoefficientLoss;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CoefficientPowerReactiveColumn
            {
                get
                {
                    return this.columnCoefficientPowerReactive;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CommentColumn
            {
                get
                {
                    return this.columnComment;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ConsumptionColumn
            {
                get
                {
                    return this.columnConsumption;
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
            public DataColumn CountCepeyColumn
            {
                get
                {
                    return this.columnCountCepey;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateActColumn
            {
                get
                {
                    return this.columnDateAct;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateInColumn
            {
                get
                {
                    return this.columnDateIn;
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
            public DataColumn ElectricalResistanceColumn
            {
                get
                {
                    return this.columnElectricalResistance;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idMarkCableColumn
            {
                get
                {
                    return this.columnidMarkCable;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IdOwnerColumn
            {
                get
                {
                    return this.columnIdOwner;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class386 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class386) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn LineLengthColumn
            {
                get
                {
                    return this.columnLineLength;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LoadAverageColumn
            {
                get
                {
                    return this.columnLoadAverage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn LoadLossesColumn
            {
                get
                {
                    return this.columnLoadLosses;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LoadPowerLossColumn
            {
                get
                {
                    return this.columnLoadPowerLoss;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PeriodColumn
            {
                get
                {
                    return this.columnPeriod;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RepresentativeColumn
            {
                get
                {
                    return this.columnRepresentative;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SquareCoefficientFormGraphicsColumn
            {
                get
                {
                    return this.columnSquareCoefficientFormGraphics;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_CalcLossCableDataTable : TypedTableBase<dsCalc.Class396>
        {
            private DataColumn columnActiveResistance;
            private DataColumn columnCoeffDifferences;
            private DataColumn columnCoeffIsolation;
            private DataColumn columnCoeffLosses;
            private DataColumn columnCoeffPowerREactive;
            private DataColumn columnconsumption;
            private DataColumn columnCountChain;
            private DataColumn columnid;
            private DataColumn columnidCalc;
            private DataColumn columnisIsolation;
            private DataColumn columnIsolationLosses;
            private DataColumn columnlenghtCable;
            private DataColumn columnLoadAverage;
            private DataColumn columnLoadLosses;
            private DataColumn columnLoadPowerLoss;
            private DataColumn columnmakeupCable;
            private DataColumn columnperiod;
            private DataColumn columnSquareCoeffFromGraph;
            private DataColumn columnSumLoadLosses;
            private DataColumn columnUdResistance;
            private DataColumn columnUnitYearLoss;
            private DataColumn columnVoltage;
            private DataColumn columnYearLoss;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate247 tJ_CalcLossCableRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate247 tJ_CalcLossCableRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate247 tJ_CalcLossCableRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate247 tJ_CalcLossCableRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tJ_CalcLossCableDataTable()
            {
                base.TableName = "tJ_CalcLossCable";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_CalcLossCableDataTable(DataTable dataTable_0)
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
            protected tJ_CalcLossCableDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                dsCalc.tJ_CalcLossCableDataTable table1 = (dsCalc.tJ_CalcLossCableDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.tJ_CalcLossCableDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class396);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class396 class396_0)
            {
                base.Rows.Add(class396_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class396 method_1(int int_0, int int_1, decimal decimal_0, decimal decimal_1, decimal decimal_2, int int_2, int int_3, decimal decimal_3, decimal decimal_4, decimal decimal_5, int int_4, decimal decimal_6, decimal decimal_7, decimal decimal_8, decimal decimal_9, decimal decimal_10, decimal decimal_11, decimal decimal_12, decimal decimal_13, bool bool_0, decimal decimal_14, decimal decimal_15)
            {
                dsCalc.Class396 row = (dsCalc.Class396) base.NewRow();
                object[] objArray1 = new object[0x17];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = decimal_0;
                objArray1[4] = decimal_1;
                objArray1[5] = decimal_2;
                objArray1[6] = int_2;
                objArray1[7] = int_3;
                objArray1[8] = decimal_3;
                objArray1[9] = decimal_4;
                objArray1[10] = decimal_5;
                objArray1[11] = int_4;
                objArray1[12] = decimal_6;
                objArray1[13] = decimal_7;
                objArray1[14] = decimal_8;
                objArray1[15] = decimal_9;
                objArray1[0x10] = decimal_10;
                objArray1[0x11] = decimal_11;
                objArray1[0x12] = decimal_12;
                objArray1[0x13] = decimal_13;
                objArray1[20] = bool_0;
                objArray1[0x15] = decimal_14;
                objArray1[0x16] = decimal_15;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class396 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class396) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidCalc = base.Columns["idCalc"];
                this.columnmakeupCable = base.Columns["makeupCable"];
                this.columnlenghtCable = base.Columns["lenghtCable"];
                this.columnUdResistance = base.Columns["UdResistance"];
                this.columnVoltage = base.Columns["Voltage"];
                this.columnconsumption = base.Columns["consumption"];
                this.columnperiod = base.Columns["period"];
                this.columnCoeffPowerREactive = base.Columns["CoeffPowerREactive"];
                this.columnSquareCoeffFromGraph = base.Columns["SquareCoeffFromGraph"];
                this.columnCoeffDifferences = base.Columns["CoeffDifferences"];
                this.columnCountChain = base.Columns["CountChain"];
                this.columnActiveResistance = base.Columns["ActiveResistance"];
                this.columnLoadPowerLoss = base.Columns["LoadPowerLoss"];
                this.columnLoadAverage = base.Columns["LoadAverage"];
                this.columnLoadLosses = base.Columns["LoadLosses"];
                this.columnUnitYearLoss = base.Columns["UnitYearLoss"];
                this.columnYearLoss = base.Columns["YearLoss"];
                this.columnSumLoadLosses = base.Columns["SumLoadLosses"];
                this.columnCoeffLosses = base.Columns["CoeffLosses"];
                this.columnisIsolation = base.Columns["isIsolation"];
                this.columnCoeffIsolation = base.Columns["CoeffIsolation"];
                this.columnIsolationLosses = base.Columns["IsolationLosses"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidCalc = new DataColumn("idCalc", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidCalc);
                this.columnmakeupCable = new DataColumn("makeupCable", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmakeupCable);
                this.columnlenghtCable = new DataColumn("lenghtCable", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnlenghtCable);
                this.columnUdResistance = new DataColumn("UdResistance", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnUdResistance);
                this.columnVoltage = new DataColumn("Voltage", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnVoltage);
                this.columnconsumption = new DataColumn("consumption", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnconsumption);
                this.columnperiod = new DataColumn("period", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnperiod);
                this.columnCoeffPowerREactive = new DataColumn("CoeffPowerREactive", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnCoeffPowerREactive);
                this.columnSquareCoeffFromGraph = new DataColumn("SquareCoeffFromGraph", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnSquareCoeffFromGraph);
                this.columnCoeffDifferences = new DataColumn("CoeffDifferences", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnCoeffDifferences);
                this.columnCountChain = new DataColumn("CountChain", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCountChain);
                this.columnActiveResistance = new DataColumn("ActiveResistance", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnActiveResistance);
                this.columnLoadPowerLoss = new DataColumn("LoadPowerLoss", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLoadPowerLoss);
                this.columnLoadAverage = new DataColumn("LoadAverage", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLoadAverage);
                this.columnLoadLosses = new DataColumn("LoadLosses", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLoadLosses);
                this.columnUnitYearLoss = new DataColumn("UnitYearLoss", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnUnitYearLoss);
                this.columnYearLoss = new DataColumn("YearLoss", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnYearLoss);
                this.columnSumLoadLosses = new DataColumn("SumLoadLosses", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnSumLoadLosses);
                this.columnCoeffLosses = new DataColumn("CoeffLosses", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnCoeffLosses);
                this.columnisIsolation = new DataColumn("isIsolation", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisIsolation);
                this.columnCoeffIsolation = new DataColumn("CoeffIsolation", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnCoeffIsolation);
                this.columnIsolationLosses = new DataColumn("IsolationLosses", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnIsolationLosses);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidCalc.AllowDBNull = false;
                this.columnmakeupCable.AllowDBNull = false;
                this.columnisIsolation.DefaultValue = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class396 method_5()
            {
                return (dsCalc.Class396) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(dsCalc.Class396 class396_0)
            {
                base.Rows.Remove(class396_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class396(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossCableRowChanged != null)
                {
                    this.tJ_CalcLossCableRowChanged(this, new dsCalc.EventArgs243((dsCalc.Class396) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossCableRowChanging != null)
                {
                    this.tJ_CalcLossCableRowChanging(this, new dsCalc.EventArgs243((dsCalc.Class396) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossCableRowDeleted != null)
                {
                    this.tJ_CalcLossCableRowDeleted(this, new dsCalc.EventArgs243((dsCalc.Class396) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossCableRowDeleting != null)
                {
                    this.tJ_CalcLossCableRowDeleting(this, new dsCalc.EventArgs243((dsCalc.Class396) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_CalcLossCableDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn ActiveResistanceColumn
            {
                get
                {
                    return this.columnActiveResistance;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CoeffDifferencesColumn
            {
                get
                {
                    return this.columnCoeffDifferences;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CoeffIsolationColumn
            {
                get
                {
                    return this.columnCoeffIsolation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CoeffLossesColumn
            {
                get
                {
                    return this.columnCoeffLosses;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CoeffPowerREactiveColumn
            {
                get
                {
                    return this.columnCoeffPowerREactive;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn consumptionColumn
            {
                get
                {
                    return this.columnconsumption;
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
            public DataColumn CountChainColumn
            {
                get
                {
                    return this.columnCountChain;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idCalcColumn
            {
                get
                {
                    return this.columnidCalc;
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
            public DataColumn isIsolationColumn
            {
                get
                {
                    return this.columnisIsolation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IsolationLossesColumn
            {
                get
                {
                    return this.columnIsolationLosses;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class396 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class396) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn lenghtCableColumn
            {
                get
                {
                    return this.columnlenghtCable;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LoadAverageColumn
            {
                get
                {
                    return this.columnLoadAverage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn LoadLossesColumn
            {
                get
                {
                    return this.columnLoadLosses;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LoadPowerLossColumn
            {
                get
                {
                    return this.columnLoadPowerLoss;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn makeupCableColumn
            {
                get
                {
                    return this.columnmakeupCable;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn periodColumn
            {
                get
                {
                    return this.columnperiod;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SquareCoeffFromGraphColumn
            {
                get
                {
                    return this.columnSquareCoeffFromGraph;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SumLoadLossesColumn
            {
                get
                {
                    return this.columnSumLoadLosses;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn UdResistanceColumn
            {
                get
                {
                    return this.columnUdResistance;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn UnitYearLossColumn
            {
                get
                {
                    return this.columnUnitYearLoss;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn VoltageColumn
            {
                get
                {
                    return this.columnVoltage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn YearLossColumn
            {
                get
                {
                    return this.columnYearLoss;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_CalcLossDataTable : TypedTableBase<dsCalc.Class392>
        {
            private DataColumn columnComment;
            private DataColumn columnDateCalc;
            private DataColumn columndeleted;
            private DataColumn columnid;
            private DataColumn columnidAbn;
            private DataColumn columnidAbnBalance;
            private DataColumn columnidAbnObj;
            private DataColumn columnidOwner;
            private DataColumn columnisActive;
            private DataColumn columnnameCalc;
            private DataColumn columnnum;
            private DataColumn columntpName;
            private DataColumn columntypeCalc;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate243 tJ_CalcLossRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate243 tJ_CalcLossRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate243 tJ_CalcLossRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate243 tJ_CalcLossRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_CalcLossDataTable()
            {
                base.TableName = "tJ_CalcLoss";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_CalcLossDataTable(DataTable dataTable_0)
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
            protected tJ_CalcLossDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                dsCalc.tJ_CalcLossDataTable table1 = (dsCalc.tJ_CalcLossDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.tJ_CalcLossDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class392);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class392 class392_0)
            {
                base.Rows.Add(class392_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class392 method_1(int int_0, int int_1, string string_0, int int_2, int int_3, int int_4, string string_1, DateTime dateTime_0, int int_5, string string_2, bool bool_0, bool bool_1)
            {
                dsCalc.Class392 row = (dsCalc.Class392) base.NewRow();
                object[] objArray1 = new object[13];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = string_0;
                objArray1[4] = int_2;
                objArray1[5] = int_3;
                objArray1[6] = int_4;
                objArray1[7] = string_1;
                objArray1[8] = dateTime_0;
                objArray1[9] = int_5;
                objArray1[10] = string_2;
                objArray1[11] = bool_0;
                objArray1[12] = bool_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class392 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class392) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnnum = base.Columns["num"];
                this.columntypeCalc = base.Columns["typeCalc"];
                this.columnnameCalc = base.Columns["nameCalc"];
                this.columnidAbn = base.Columns["idAbn"];
                this.columnidAbnObj = base.Columns["idAbnObj"];
                this.columnidAbnBalance = base.Columns["idAbnBalance"];
                this.columntpName = base.Columns["tpName"];
                this.columnDateCalc = base.Columns["DateCalc"];
                this.columnidOwner = base.Columns["idOwner"];
                this.columnComment = base.Columns["Comment"];
                this.columnisActive = base.Columns["isActive"];
                this.columndeleted = base.Columns["deleted"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnum = new DataColumn("num", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnum);
                this.columntypeCalc = new DataColumn("typeCalc", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columntypeCalc);
                this.columnnameCalc = new DataColumn("nameCalc", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnameCalc);
                this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
                this.columnidAbnObj = new DataColumn("idAbnObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbnObj);
                this.columnidAbnBalance = new DataColumn("idAbnBalance", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbnBalance);
                this.columntpName = new DataColumn("tpName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntpName);
                this.columnDateCalc = new DataColumn("DateCalc", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateCalc);
                this.columnidOwner = new DataColumn("idOwner", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidOwner);
                this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComment);
                this.columnisActive = new DataColumn("isActive", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisActive);
                this.columndeleted = new DataColumn("deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columndeleted);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columntypeCalc.AllowDBNull = false;
                this.columnnameCalc.MaxLength = 0x200;
                this.columnidAbnObj.AllowDBNull = false;
                this.columnidAbnBalance.AllowDBNull = false;
                this.columnDateCalc.AllowDBNull = false;
                this.columnComment.MaxLength = 0x400;
                this.columnisActive.AllowDBNull = false;
                this.columndeleted.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class392 method_5()
            {
                return (dsCalc.Class392) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(dsCalc.Class392 class392_0)
            {
                base.Rows.Remove(class392_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class392(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossRowChanged != null)
                {
                    this.tJ_CalcLossRowChanged(this, new dsCalc.EventArgs239((dsCalc.Class392) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossRowChanging != null)
                {
                    this.tJ_CalcLossRowChanging(this, new dsCalc.EventArgs239((dsCalc.Class392) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossRowDeleted != null)
                {
                    this.tJ_CalcLossRowDeleted(this, new dsCalc.EventArgs239((dsCalc.Class392) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossRowDeleting != null)
                {
                    this.tJ_CalcLossRowDeleting(this, new dsCalc.EventArgs239((dsCalc.Class392) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_CalcLossDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateCalcColumn
            {
                get
                {
                    return this.columnDateCalc;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idAbnBalanceColumn
            {
                get
                {
                    return this.columnidAbnBalance;
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
            public DataColumn idAbnObjColumn
            {
                get
                {
                    return this.columnidAbnObj;
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
            public DataColumn idOwnerColumn
            {
                get
                {
                    return this.columnidOwner;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn isActiveColumn
            {
                get
                {
                    return this.columnisActive;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class392 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class392) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nameCalcColumn
            {
                get
                {
                    return this.columnnameCalc;
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
            public DataColumn tpNameColumn
            {
                get
                {
                    return this.columntpName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeCalcColumn
            {
                get
                {
                    return this.columntypeCalc;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_CalcLossFileDataTable : TypedTableBase<dsCalc.Class399>
        {
            private DataColumn columnDateIn;
            private DataColumn columnFile;
            private DataColumn columnFileName;
            private DataColumn columnid;
            private DataColumn columnidCalc;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate250 tJ_CalcLossFileRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate250 tJ_CalcLossFileRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate250 tJ_CalcLossFileRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate250 tJ_CalcLossFileRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tJ_CalcLossFileDataTable()
            {
                base.TableName = "tJ_CalcLossFile";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tJ_CalcLossFileDataTable(DataTable dataTable_0)
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
            protected tJ_CalcLossFileDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                dsCalc.tJ_CalcLossFileDataTable table1 = (dsCalc.tJ_CalcLossFileDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.tJ_CalcLossFileDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class399);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(dsCalc.Class399 class399_0)
            {
                base.Rows.Add(class399_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class399 method_1(int int_0, string string_0, byte[] byte_0, DateTime dateTime_0)
            {
                dsCalc.Class399 row = (dsCalc.Class399) base.NewRow();
                object[] objArray1 = new object[5];
                objArray1[1] = int_0;
                objArray1[2] = string_0;
                objArray1[3] = byte_0;
                objArray1[4] = dateTime_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class399 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class399) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidCalc = base.Columns["idCalc"];
                this.columnFileName = base.Columns["FileName"];
                this.columnFile = base.Columns["File"];
                this.columnDateIn = base.Columns["DateIn"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidCalc = new DataColumn("idCalc", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidCalc);
                this.columnFileName = new DataColumn("FileName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFileName);
                this.columnFile = new DataColumn("File", typeof(byte[]), null, MappingType.Element);
                base.Columns.Add(this.columnFile);
                this.columnDateIn = new DataColumn("DateIn", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateIn);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidCalc.AllowDBNull = false;
                this.columnFileName.AllowDBNull = false;
                this.columnFileName.MaxLength = 0x400;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class399 method_5()
            {
                return (dsCalc.Class399) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(dsCalc.Class399 class399_0)
            {
                base.Rows.Remove(class399_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class399(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossFileRowChanged != null)
                {
                    this.tJ_CalcLossFileRowChanged(this, new dsCalc.EventArgs246((dsCalc.Class399) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossFileRowChanging != null)
                {
                    this.tJ_CalcLossFileRowChanging(this, new dsCalc.EventArgs246((dsCalc.Class399) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossFileRowDeleted != null)
                {
                    this.tJ_CalcLossFileRowDeleted(this, new dsCalc.EventArgs246((dsCalc.Class399) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossFileRowDeleting != null)
                {
                    this.tJ_CalcLossFileRowDeleting(this, new dsCalc.EventArgs246((dsCalc.Class399) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_CalcLossFileDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn DateInColumn
            {
                get
                {
                    return this.columnDateIn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FileColumn
            {
                get
                {
                    return this.columnFile;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FileNameColumn
            {
                get
                {
                    return this.columnFileName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idCalcColumn
            {
                get
                {
                    return this.columnidCalc;
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
            public dsCalc.Class399 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class399) base.Rows[int_0];
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_CalcLossTransDataTable : TypedTableBase<dsCalc.Class402>
        {
            private DataColumn columnActiveResistance;
            private DataColumn columnCoeffDifference;
            private DataColumn columnCoeffLosses;
            private DataColumn columnCoeffPowerReactive;
            private DataColumn columnConsumption;
            private DataColumn columnid;
            private DataColumn columnidCalc;
            private DataColumn columnLoadAverage;
            private DataColumn columnLoadLosses;
            private DataColumn columnLoadPowerLoss;
            private DataColumn columnLossElectrHH;
            private DataColumn columnmakeupTrans;
            private DataColumn columnMiddleVoltage;
            private DataColumn columnNoLoadLoss;
            private DataColumn columnnumTrans;
            private DataColumn columnPeriod;
            private DataColumn columnRatedPower;
            private DataColumn columnRatedVoltage;
            private DataColumn columnShortCircuitLoss;
            private DataColumn columnSquareCoeffFromGraph;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate253 tJ_CalcLossTransRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate253 tJ_CalcLossTransRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate253 tJ_CalcLossTransRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate253 tJ_CalcLossTransRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_CalcLossTransDataTable()
            {
                base.TableName = "tJ_CalcLossTrans";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_CalcLossTransDataTable(DataTable dataTable_0)
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
            protected tJ_CalcLossTransDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                dsCalc.tJ_CalcLossTransDataTable table1 = (dsCalc.tJ_CalcLossTransDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.tJ_CalcLossTransDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class402);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class402 class402_0)
            {
                base.Rows.Add(class402_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class402 method_1(int int_0, int int_1, int int_2, decimal decimal_0, decimal decimal_1, decimal decimal_2, int int_3, decimal decimal_3, int int_4, decimal decimal_4, decimal decimal_5, decimal decimal_6, decimal decimal_7, decimal decimal_8, decimal decimal_9, decimal decimal_10, decimal decimal_11, decimal decimal_12, decimal decimal_13)
            {
                dsCalc.Class402 row = (dsCalc.Class402) base.NewRow();
                object[] objArray1 = new object[20];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = int_2;
                objArray1[4] = decimal_0;
                objArray1[5] = decimal_1;
                objArray1[6] = decimal_2;
                objArray1[7] = int_3;
                objArray1[8] = decimal_3;
                objArray1[9] = int_4;
                objArray1[10] = decimal_4;
                objArray1[11] = decimal_5;
                objArray1[12] = decimal_6;
                objArray1[13] = decimal_7;
                objArray1[14] = decimal_8;
                objArray1[15] = decimal_9;
                objArray1[0x10] = decimal_10;
                objArray1[0x11] = decimal_11;
                objArray1[0x12] = decimal_12;
                objArray1[0x13] = decimal_13;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class402 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class402) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidCalc = base.Columns["idCalc"];
                this.columnnumTrans = base.Columns["numTrans"];
                this.columnmakeupTrans = base.Columns["makeupTrans"];
                this.columnRatedPower = base.Columns["RatedPower"];
                this.columnNoLoadLoss = base.Columns["NoLoadLoss"];
                this.columnShortCircuitLoss = base.Columns["ShortCircuitLoss"];
                this.columnConsumption = base.Columns["Consumption"];
                this.columnRatedVoltage = base.Columns["RatedVoltage"];
                this.columnPeriod = base.Columns["Period"];
                this.columnMiddleVoltage = base.Columns["MiddleVoltage"];
                this.columnCoeffPowerReactive = base.Columns["CoeffPowerReactive"];
                this.columnSquareCoeffFromGraph = base.Columns["SquareCoeffFromGraph"];
                this.columnCoeffDifference = base.Columns["CoeffDifference"];
                this.columnLossElectrHH = base.Columns["LossElectrHH"];
                this.columnActiveResistance = base.Columns["ActiveResistance"];
                this.columnLoadPowerLoss = base.Columns["LoadPowerLoss"];
                this.columnLoadAverage = base.Columns["LoadAverage"];
                this.columnLoadLosses = base.Columns["LoadLosses"];
                this.columnCoeffLosses = base.Columns["CoeffLosses"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidCalc = new DataColumn("idCalc", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidCalc);
                this.columnnumTrans = new DataColumn("numTrans", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnumTrans);
                this.columnmakeupTrans = new DataColumn("makeupTrans", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmakeupTrans);
                this.columnRatedPower = new DataColumn("RatedPower", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnRatedPower);
                this.columnNoLoadLoss = new DataColumn("NoLoadLoss", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnNoLoadLoss);
                this.columnShortCircuitLoss = new DataColumn("ShortCircuitLoss", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnShortCircuitLoss);
                this.columnConsumption = new DataColumn("Consumption", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnConsumption);
                this.columnRatedVoltage = new DataColumn("RatedVoltage", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnRatedVoltage);
                this.columnPeriod = new DataColumn("Period", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnPeriod);
                this.columnMiddleVoltage = new DataColumn("MiddleVoltage", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnMiddleVoltage);
                this.columnCoeffPowerReactive = new DataColumn("CoeffPowerReactive", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnCoeffPowerReactive);
                this.columnSquareCoeffFromGraph = new DataColumn("SquareCoeffFromGraph", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnSquareCoeffFromGraph);
                this.columnCoeffDifference = new DataColumn("CoeffDifference", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnCoeffDifference);
                this.columnLossElectrHH = new DataColumn("LossElectrHH", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLossElectrHH);
                this.columnActiveResistance = new DataColumn("ActiveResistance", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnActiveResistance);
                this.columnLoadPowerLoss = new DataColumn("LoadPowerLoss", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLoadPowerLoss);
                this.columnLoadAverage = new DataColumn("LoadAverage", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLoadAverage);
                this.columnLoadLosses = new DataColumn("LoadLosses", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLoadLosses);
                this.columnCoeffLosses = new DataColumn("CoeffLosses", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnCoeffLosses);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidCalc.AllowDBNull = false;
                this.columnmakeupTrans.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class402 method_5()
            {
                return (dsCalc.Class402) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(dsCalc.Class402 class402_0)
            {
                base.Rows.Remove(class402_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class402(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossTransRowChanged != null)
                {
                    this.tJ_CalcLossTransRowChanged(this, new dsCalc.EventArgs249((dsCalc.Class402) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossTransRowChanging != null)
                {
                    this.tJ_CalcLossTransRowChanging(this, new dsCalc.EventArgs249((dsCalc.Class402) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossTransRowDeleted != null)
                {
                    this.tJ_CalcLossTransRowDeleted(this, new dsCalc.EventArgs249((dsCalc.Class402) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossTransRowDeleting != null)
                {
                    this.tJ_CalcLossTransRowDeleting(this, new dsCalc.EventArgs249((dsCalc.Class402) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_CalcLossTransDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn ActiveResistanceColumn
            {
                get
                {
                    return this.columnActiveResistance;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CoeffDifferenceColumn
            {
                get
                {
                    return this.columnCoeffDifference;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CoeffLossesColumn
            {
                get
                {
                    return this.columnCoeffLosses;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CoeffPowerReactiveColumn
            {
                get
                {
                    return this.columnCoeffPowerReactive;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ConsumptionColumn
            {
                get
                {
                    return this.columnConsumption;
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
            public DataColumn idCalcColumn
            {
                get
                {
                    return this.columnidCalc;
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
            public dsCalc.Class402 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class402) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn LoadAverageColumn
            {
                get
                {
                    return this.columnLoadAverage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn LoadLossesColumn
            {
                get
                {
                    return this.columnLoadLosses;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn LoadPowerLossColumn
            {
                get
                {
                    return this.columnLoadPowerLoss;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn LossElectrHHColumn
            {
                get
                {
                    return this.columnLossElectrHH;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn makeupTransColumn
            {
                get
                {
                    return this.columnmakeupTrans;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn MiddleVoltageColumn
            {
                get
                {
                    return this.columnMiddleVoltage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NoLoadLossColumn
            {
                get
                {
                    return this.columnNoLoadLoss;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn numTransColumn
            {
                get
                {
                    return this.columnnumTrans;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn PeriodColumn
            {
                get
                {
                    return this.columnPeriod;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn RatedPowerColumn
            {
                get
                {
                    return this.columnRatedPower;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RatedVoltageColumn
            {
                get
                {
                    return this.columnRatedVoltage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ShortCircuitLossColumn
            {
                get
                {
                    return this.columnShortCircuitLoss;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SquareCoeffFromGraphColumn
            {
                get
                {
                    return this.columnSquareCoeffFromGraph;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_CalcLossTransHHDataTable : TypedTableBase<dsCalc.Class403>
        {
            private DataColumn columnid;
            private DataColumn columnidCalc;
            private DataColumn columnidTrans;
            private DataColumn columnmonth01;
            private DataColumn columnmonth02;
            private DataColumn columnmonth03;
            private DataColumn columnmonth04;
            private DataColumn columnmonth05;
            private DataColumn columnmonth06;
            private DataColumn columnmonth07;
            private DataColumn columnmonth08;
            private DataColumn columnmonth09;
            private DataColumn columnmonth10;
            private DataColumn columnmonth11;
            private DataColumn columnmonth12;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate254 tJ_CalcLossTransHHRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate254 tJ_CalcLossTransHHRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate254 tJ_CalcLossTransHHRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate254 tJ_CalcLossTransHHRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_CalcLossTransHHDataTable()
            {
                base.TableName = "tJ_CalcLossTransHH";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tJ_CalcLossTransHHDataTable(DataTable dataTable_0)
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
            protected tJ_CalcLossTransHHDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                dsCalc.tJ_CalcLossTransHHDataTable table1 = (dsCalc.tJ_CalcLossTransHHDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.tJ_CalcLossTransHHDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class403);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(dsCalc.Class403 class403_0)
            {
                base.Rows.Add(class403_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class403 method_1(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, int int_12, int int_13)
            {
                dsCalc.Class403 row = (dsCalc.Class403) base.NewRow();
                object[] objArray1 = new object[15];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = int_2;
                objArray1[4] = int_3;
                objArray1[5] = int_4;
                objArray1[6] = int_5;
                objArray1[7] = int_6;
                objArray1[8] = int_7;
                objArray1[9] = int_8;
                objArray1[10] = int_9;
                objArray1[11] = int_10;
                objArray1[12] = int_11;
                objArray1[13] = int_12;
                objArray1[14] = int_13;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class403 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class403) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidCalc = base.Columns["idCalc"];
                this.columnidTrans = base.Columns["idTrans"];
                this.columnmonth01 = base.Columns["month01"];
                this.columnmonth02 = base.Columns["month02"];
                this.columnmonth03 = base.Columns["month03"];
                this.columnmonth04 = base.Columns["month04"];
                this.columnmonth05 = base.Columns["month05"];
                this.columnmonth06 = base.Columns["month06"];
                this.columnmonth07 = base.Columns["month07"];
                this.columnmonth08 = base.Columns["month08"];
                this.columnmonth09 = base.Columns["month09"];
                this.columnmonth10 = base.Columns["month10"];
                this.columnmonth11 = base.Columns["month11"];
                this.columnmonth12 = base.Columns["month12"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidCalc = new DataColumn("idCalc", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidCalc);
                this.columnidTrans = new DataColumn("idTrans", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidTrans);
                this.columnmonth01 = new DataColumn("month01", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth01);
                this.columnmonth02 = new DataColumn("month02", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth02);
                this.columnmonth03 = new DataColumn("month03", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth03);
                this.columnmonth04 = new DataColumn("month04", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth04);
                this.columnmonth05 = new DataColumn("month05", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth05);
                this.columnmonth06 = new DataColumn("month06", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth06);
                this.columnmonth07 = new DataColumn("month07", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth07);
                this.columnmonth08 = new DataColumn("month08", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth08);
                this.columnmonth09 = new DataColumn("month09", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth09);
                this.columnmonth10 = new DataColumn("month10", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth10);
                this.columnmonth11 = new DataColumn("month11", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth11);
                this.columnmonth12 = new DataColumn("month12", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmonth12);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidCalc.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class403 method_5()
            {
                return (dsCalc.Class403) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(dsCalc.Class403 class403_0)
            {
                base.Rows.Remove(class403_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class403(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossTransHHRowChanged != null)
                {
                    this.tJ_CalcLossTransHHRowChanged(this, new dsCalc.EventArgs250((dsCalc.Class403) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossTransHHRowChanging != null)
                {
                    this.tJ_CalcLossTransHHRowChanging(this, new dsCalc.EventArgs250((dsCalc.Class403) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossTransHHRowDeleted != null)
                {
                    this.tJ_CalcLossTransHHRowDeleted(this, new dsCalc.EventArgs250((dsCalc.Class403) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_CalcLossTransHHRowDeleting != null)
                {
                    this.tJ_CalcLossTransHHRowDeleting(this, new dsCalc.EventArgs250((dsCalc.Class403) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_CalcLossTransHHDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn idCalcColumn
            {
                get
                {
                    return this.columnidCalc;
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
            public DataColumn idTransColumn
            {
                get
                {
                    return this.columnidTrans;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class403 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class403) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn month01Column
            {
                get
                {
                    return this.columnmonth01;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn month02Column
            {
                get
                {
                    return this.columnmonth02;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn month03Column
            {
                get
                {
                    return this.columnmonth03;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn month04Column
            {
                get
                {
                    return this.columnmonth04;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn month05Column
            {
                get
                {
                    return this.columnmonth05;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn month06Column
            {
                get
                {
                    return this.columnmonth06;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn month07Column
            {
                get
                {
                    return this.columnmonth07;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn month08Column
            {
                get
                {
                    return this.columnmonth08;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn month09Column
            {
                get
                {
                    return this.columnmonth09;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn month10Column
            {
                get
                {
                    return this.columnmonth10;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn month11Column
            {
                get
                {
                    return this.columnmonth11;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn month12Column
            {
                get
                {
                    return this.columnmonth12;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tMaterialDataTable : TypedTableBase<dsCalc.Class390>
        {
            private DataColumn columnDeleted;
            private DataColumn columnid;
            private DataColumn columnName;
            private DataColumn columnParentID;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate241 tMaterialRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate241 tMaterialRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate241 tMaterialRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate241 tMaterialRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tMaterialDataTable()
            {
                base.TableName = "tMaterial";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tMaterialDataTable(DataTable dataTable_0)
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
            protected tMaterialDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                dsCalc.tMaterialDataTable table1 = (dsCalc.tMaterialDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.tMaterialDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class390);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class390 class390_0)
            {
                base.Rows.Add(class390_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class390 method_1(string string_0, bool bool_0, int int_0)
            {
                dsCalc.Class390 row = (dsCalc.Class390) base.NewRow();
                object[] objArray1 = new object[4];
                objArray1[1] = string_0;
                objArray1[2] = bool_0;
                objArray1[3] = int_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class390 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class390) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnName = base.Columns["Name"];
                this.columnDeleted = base.Columns["Deleted"];
                this.columnParentID = base.Columns["ParentID"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnDeleted);
                this.columnParentID = new DataColumn("ParentID", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnParentID);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnName.AllowDBNull = false;
                this.columnName.MaxLength = 50;
                this.columnDeleted.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class390 method_5()
            {
                return (dsCalc.Class390) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(dsCalc.Class390 class390_0)
            {
                base.Rows.Remove(class390_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class390(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tMaterialRowChanged != null)
                {
                    this.tMaterialRowChanged(this, new dsCalc.EventArgs237((dsCalc.Class390) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tMaterialRowChanging != null)
                {
                    this.tMaterialRowChanging(this, new dsCalc.EventArgs237((dsCalc.Class390) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tMaterialRowDeleted != null)
                {
                    this.tMaterialRowDeleted(this, new dsCalc.EventArgs237((dsCalc.Class390) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tMaterialRowDeleting != null)
                {
                    this.tMaterialRowDeleting(this, new dsCalc.EventArgs237((dsCalc.Class390) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tMaterialDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn DeletedColumn
            {
                get
                {
                    return this.columnDeleted;
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
            public dsCalc.Class390 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class390) base.Rows[int_0];
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
            public DataColumn ParentIDColumn
            {
                get
                {
                    return this.columnParentID;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tR_ClassifierDataTable : TypedTableBase<dsCalc.Class388>
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
            public event dsCalc.Delegate239 tR_ClassifierRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate239 tR_ClassifierRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate239 tR_ClassifierRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate239 tR_ClassifierRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tR_ClassifierDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                dsCalc.tR_ClassifierDataTable table1 = (dsCalc.tR_ClassifierDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.tR_ClassifierDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class388);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class388 class388_0)
            {
                base.Rows.Add(class388_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class388 method_1(string string_0, string string_1, decimal decimal_0, string string_2, int int_0, string string_3, byte[] byte_0, bool bool_0, bool bool_1)
            {
                dsCalc.Class388 row = (dsCalc.Class388) base.NewRow();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class388 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class388) base.Rows.Find(keys);
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
            public dsCalc.Class388 method_5()
            {
                return (dsCalc.Class388) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(dsCalc.Class388 class388_0)
            {
                base.Rows.Remove(class388_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class388(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowChanged != null)
                {
                    this.tR_ClassifierRowChanged(this, new dsCalc.EventArgs235((dsCalc.Class388) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowChanging != null)
                {
                    this.tR_ClassifierRowChanging(this, new dsCalc.EventArgs235((dsCalc.Class388) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowDeleted != null)
                {
                    this.tR_ClassifierRowDeleted(this, new dsCalc.EventArgs235((dsCalc.Class388) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowDeleting != null)
                {
                    this.tR_ClassifierRowDeleting(this, new dsCalc.EventArgs235((dsCalc.Class388) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tR_ClassifierDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class388 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class388) base.Rows[int_0];
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ParentKeyColumn
            {
                get
                {
                    return this.columnParentKey;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SocrNameColumn
            {
                get
                {
                    return this.columnSocrName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ValueColumn
            {
                get
                {
                    return this.columnValue;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tUserDataTable : TypedTableBase<dsCalc.Class387>
        {
            private DataColumn columnDeleted;
            private DataColumn columnIDUser;
            private DataColumn columnIdWorker;
            private DataColumn columnLogin;
            private DataColumn columnName;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate238 tUserRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate238 tUserRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate238 tUserRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate238 tUserRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tUserDataTable()
            {
                base.TableName = "tUser";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tUserDataTable(DataTable dataTable_0)
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
            protected tUserDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                dsCalc.tUserDataTable table1 = (dsCalc.tUserDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.tUserDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class387);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(dsCalc.Class387 class387_0)
            {
                base.Rows.Add(class387_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class387 method_1(int int_0, string string_0, string string_1, bool bool_0)
            {
                dsCalc.Class387 row = (dsCalc.Class387) base.NewRow();
                object[] objArray1 = new object[5];
                objArray1[1] = int_0;
                objArray1[2] = string_0;
                objArray1[3] = string_1;
                objArray1[4] = bool_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class387 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class387) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnIDUser = base.Columns["IDUser"];
                this.columnIdWorker = base.Columns["IdWorker"];
                this.columnLogin = base.Columns["Login"];
                this.columnName = base.Columns["Name"];
                this.columnDeleted = base.Columns["Deleted"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnIDUser = new DataColumn("IDUser", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnIDUser);
                this.columnIdWorker = new DataColumn("IdWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnIdWorker);
                this.columnLogin = new DataColumn("Login", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnLogin);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnDeleted);
                DataColumn[] columns = new DataColumn[] { this.columnIDUser };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnIDUser.AutoIncrement = true;
                this.columnIDUser.AutoIncrementSeed = -1L;
                this.columnIDUser.AutoIncrementStep = -1L;
                this.columnIDUser.AllowDBNull = false;
                this.columnIDUser.ReadOnly = true;
                this.columnIDUser.Unique = true;
                this.columnLogin.AllowDBNull = false;
                this.columnLogin.MaxLength = 50;
                this.columnName.MaxLength = 50;
                this.columnDeleted.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class387 method_5()
            {
                return (dsCalc.Class387) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(dsCalc.Class387 class387_0)
            {
                base.Rows.Remove(class387_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class387(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tUserRowChanged != null)
                {
                    this.tUserRowChanged(this, new dsCalc.EventArgs234((dsCalc.Class387) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tUserRowChanging != null)
                {
                    this.tUserRowChanging(this, new dsCalc.EventArgs234((dsCalc.Class387) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tUserRowDeleted != null)
                {
                    this.tUserRowDeleted(this, new dsCalc.EventArgs234((dsCalc.Class387) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tUserRowDeleting != null)
                {
                    this.tUserRowDeleting(this, new dsCalc.EventArgs234((dsCalc.Class387) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tUserDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn DeletedColumn
            {
                get
                {
                    return this.columnDeleted;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IDUserColumn
            {
                get
                {
                    return this.columnIDUser;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IdWorkerColumn
            {
                get
                {
                    return this.columnIdWorker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class387 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class387) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LoginColumn
            {
                get
                {
                    return this.columnLogin;
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
        public class vAbnDataTable : TypedTableBase<dsCalc.Class397>
        {
            private DataColumn columnCodeAbonent;
            private DataColumn columndatechange;
            private DataColumn columnDeleted;
            private DataColumn columnid;
            private DataColumn columnidReason;
            private DataColumn columnidWorker;
            private DataColumn columnisActive;
            private DataColumn columnName;
            private DataColumn columnReason;
            private DataColumn columnTypeAbn;
            private DataColumn columnTypeName;
            private DataColumn columnTypeNameSocr;
            private DataColumn columnWorker;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate248 vAbnRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate248 vAbnRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate248 vAbnRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate248 vAbnRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vAbnDataTable()
            {
                base.TableName = "vAbn";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vAbnDataTable(DataTable dataTable_0)
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
            protected vAbnDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                dsCalc.vAbnDataTable table1 = (dsCalc.vAbnDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.vAbnDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class397);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class397 class397_0)
            {
                base.Rows.Add(class397_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class397 method_1(int int_0, int int_1, string string_0, int int_2, int int_3, bool bool_0, string string_1, string string_2, string string_3, bool bool_1, string string_4, DateTime dateTime_0, int int_4)
            {
                dsCalc.Class397 row = (dsCalc.Class397) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, string_0, int_2, int_3, bool_0, string_1, string_2, string_3, bool_1, string_4, dateTime_0, int_4 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class397 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class397) base.Rows.Find(keys);
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
                this.columnTypeName = base.Columns["TypeName"];
                this.columnTypeNameSocr = base.Columns["TypeNameSocr"];
                this.columnWorker = base.Columns["Worker"];
                this.columnisActive = base.Columns["isActive"];
                this.columnReason = base.Columns["Reason"];
                this.columndatechange = base.Columns["datechange"];
                this.columnidReason = base.Columns["idReason"];
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
                this.columnTypeName = new DataColumn("TypeName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTypeName);
                this.columnTypeNameSocr = new DataColumn("TypeNameSocr", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTypeNameSocr);
                this.columnWorker = new DataColumn("Worker", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnWorker);
                this.columnisActive = new DataColumn("isActive", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisActive);
                this.columnReason = new DataColumn("Reason", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columndatechange = new DataColumn("datechange", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndatechange);
                this.columnidReason = new DataColumn("idReason", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidReason);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnCodeAbonent.AllowDBNull = false;
                this.columnName.MaxLength = 100;
                this.columnTypeAbn.AllowDBNull = false;
                this.columnidWorker.AllowDBNull = false;
                this.columnDeleted.AllowDBNull = false;
                this.columnTypeName.MaxLength = 100;
                this.columnTypeNameSocr.MaxLength = 50;
                this.columnWorker.ReadOnly = true;
                this.columnWorker.MaxLength = 0x23;
                this.columnReason.MaxLength = 100;
                this.columndatechange.ReadOnly = true;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class397 method_5()
            {
                return (dsCalc.Class397) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(dsCalc.Class397 class397_0)
            {
                base.Rows.Remove(class397_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class397(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vAbnRowChanged != null)
                {
                    this.vAbnRowChanged(this, new dsCalc.EventArgs244((dsCalc.Class397) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vAbnRowChanging != null)
                {
                    this.vAbnRowChanging(this, new dsCalc.EventArgs244((dsCalc.Class397) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vAbnRowDeleted != null)
                {
                    this.vAbnRowDeleted(this, new dsCalc.EventArgs244((dsCalc.Class397) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vAbnRowDeleting != null)
                {
                    this.vAbnRowDeleting(this, new dsCalc.EventArgs244((dsCalc.Class397) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vAbnDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn datechangeColumn
            {
                get
                {
                    return this.columndatechange;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idWorkerColumn
            {
                get
                {
                    return this.columnidWorker;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class397 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class397) base.Rows[int_0];
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
            public DataColumn ReasonColumn
            {
                get
                {
                    return this.columnReason;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeNameColumn
            {
                get
                {
                    return this.columnTypeName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeNameSocrColumn
            {
                get
                {
                    return this.columnTypeNameSocr;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn WorkerColumn
            {
                get
                {
                    return this.columnWorker;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vAbnObjAddressDataTable : TypedTableBase<dsCalc.Class394>
        {
            private DataColumn columnCity;
            private DataColumn columnComment;
            private DataColumn columnHouse;
            private DataColumn columnHouseAll;
            private DataColumn columnHousePrefix;
            private DataColumn columnid;
            private DataColumn columnidAbn;
            private DataColumn columnidCity;
            private DataColumn columnidMap;
            private DataColumn columnidObjParent;
            private DataColumn columnidObjReg;
            private DataColumn columnidRaion;
            private DataColumn columnidStreet;
            private DataColumn columnIndex;
            private DataColumn columnIsHouse;
            private DataColumn columnLatitude;
            private DataColumn columnLongitude;
            private DataColumn columnName;
            private DataColumn columnRaion;
            private DataColumn columnStreet;
            private DataColumn columnTypeObj;
            private DataColumn columnTypeObjName;
            private DataColumn columnTypeObjNew;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate245 vAbnObjAddressRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate245 vAbnObjAddressRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate245 vAbnObjAddressRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate245 vAbnObjAddressRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vAbnObjAddressDataTable()
            {
                base.TableName = "vAbnObjAddress";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vAbnObjAddressDataTable(DataTable dataTable_0)
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
            protected vAbnObjAddressDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                dsCalc.vAbnObjAddressDataTable table1 = (dsCalc.vAbnObjAddressDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.vAbnObjAddressDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class394);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class394 class394_0)
            {
                base.Rows.Add(class394_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class394 method_1(int int_0, int int_1, int int_2, string string_0, string string_1, int int_3, string string_2, int int_4, string string_3, int int_5, string string_4, int int_6, string string_5, string string_6, bool bool_0, string string_7, double double_0, double double_1, int int_7, int int_8, string string_8, int int_9, int int_10)
            {
                dsCalc.Class394 row = (dsCalc.Class394) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, int_1, int_2, string_0, string_1, int_3, string_2, int_4, string_3, int_5, string_4, int_6, string_5, string_6, bool_0, string_7,
                    double_0, double_1, int_7, int_8, string_8, int_9, int_10
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnid = base.Columns["id"];
                this.columnidAbn = base.Columns["idAbn"];
                this.columnidMap = base.Columns["idMap"];
                this.columnName = base.Columns["Name"];
                this.columnComment = base.Columns["Comment"];
                this.columnidCity = base.Columns["idCity"];
                this.columnCity = base.Columns["City"];
                this.columnidRaion = base.Columns["idRaion"];
                this.columnRaion = base.Columns["Raion"];
                this.columnidStreet = base.Columns["idStreet"];
                this.columnStreet = base.Columns["Street"];
                this.columnHouse = base.Columns["House"];
                this.columnHousePrefix = base.Columns["HousePrefix"];
                this.columnHouseAll = base.Columns["HouseAll"];
                this.columnIsHouse = base.Columns["IsHouse"];
                this.columnIndex = base.Columns["Index"];
                this.columnLatitude = base.Columns["Latitude"];
                this.columnLongitude = base.Columns["Longitude"];
                this.columnidObjParent = base.Columns["idObjParent"];
                this.columnTypeObj = base.Columns["TypeObj"];
                this.columnTypeObjName = base.Columns["TypeObjName"];
                this.columnidObjReg = base.Columns["idObjReg"];
                this.columnTypeObjNew = base.Columns["TypeObjNew"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
                this.columnidMap = new DataColumn("idMap", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidMap);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComment);
                this.columnidCity = new DataColumn("idCity", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidCity);
                this.columnCity = new DataColumn("City", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnCity);
                this.columnidRaion = new DataColumn("idRaion", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidRaion);
                this.columnRaion = new DataColumn("Raion", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnRaion);
                this.columnidStreet = new DataColumn("idStreet", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidStreet);
                this.columnStreet = new DataColumn("Street", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnStreet);
                this.columnHouse = new DataColumn("House", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnHouse);
                this.columnHousePrefix = new DataColumn("HousePrefix", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnHousePrefix);
                this.columnHouseAll = new DataColumn("HouseAll", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnHouseAll);
                this.columnIsHouse = new DataColumn("IsHouse", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnIsHouse);
                this.columnIndex = new DataColumn("Index", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnIndex);
                this.columnLatitude = new DataColumn("Latitude", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnLatitude);
                this.columnLongitude = new DataColumn("Longitude", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnLongitude);
                this.columnidObjParent = new DataColumn("idObjParent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidObjParent);
                this.columnTypeObj = new DataColumn("TypeObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnTypeObj);
                this.columnTypeObjName = new DataColumn("TypeObjName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTypeObjName);
                this.columnidObjReg = new DataColumn("idObjReg", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidObjReg);
                this.columnTypeObjNew = new DataColumn("TypeObjNew", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnTypeObjNew);
                this.columnid.AllowDBNull = false;
                this.columnName.MaxLength = 0xff;
                this.columnComment.MaxLength = 0x200;
                this.columnCity.ReadOnly = true;
                this.columnCity.MaxLength = 0x33;
                this.columnRaion.MaxLength = 100;
                this.columnStreet.ReadOnly = true;
                this.columnStreet.MaxLength = 0x5b;
                this.columnHousePrefix.MaxLength = 20;
                this.columnHouseAll.ReadOnly = true;
                this.columnHouseAll.MaxLength = 30;
                this.columnIndex.MaxLength = 6;
                this.columnTypeObjName.MaxLength = 100;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class394 method_4()
            {
                return (dsCalc.Class394) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(dsCalc.Class394 class394_0)
            {
                base.Rows.Remove(class394_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class394(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vAbnObjAddressRowChanged != null)
                {
                    this.vAbnObjAddressRowChanged(this, new dsCalc.EventArgs241((dsCalc.Class394) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vAbnObjAddressRowChanging != null)
                {
                    this.vAbnObjAddressRowChanging(this, new dsCalc.EventArgs241((dsCalc.Class394) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vAbnObjAddressRowDeleted != null)
                {
                    this.vAbnObjAddressRowDeleted(this, new dsCalc.EventArgs241((dsCalc.Class394) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vAbnObjAddressRowDeleting != null)
                {
                    this.vAbnObjAddressRowDeleting(this, new dsCalc.EventArgs241((dsCalc.Class394) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vAbnObjAddressDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn CityColumn
            {
                get
                {
                    return this.columnCity;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CommentColumn
            {
                get
                {
                    return this.columnComment;
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
            public DataColumn HouseAllColumn
            {
                get
                {
                    return this.columnHouseAll;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idAbnColumn
            {
                get
                {
                    return this.columnidAbn;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idCityColumn
            {
                get
                {
                    return this.columnidCity;
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
            public DataColumn idMapColumn
            {
                get
                {
                    return this.columnidMap;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idObjParentColumn
            {
                get
                {
                    return this.columnidObjParent;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idObjRegColumn
            {
                get
                {
                    return this.columnidObjReg;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idRaionColumn
            {
                get
                {
                    return this.columnidRaion;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idStreetColumn
            {
                get
                {
                    return this.columnidStreet;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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
            public dsCalc.Class394 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class394) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NameColumn
            {
                get
                {
                    return this.columnName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RaionColumn
            {
                get
                {
                    return this.columnRaion;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn StreetColumn
            {
                get
                {
                    return this.columnStreet;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeObjColumn
            {
                get
                {
                    return this.columnTypeObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeObjNameColumn
            {
                get
                {
                    return this.columnTypeObjName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeObjNewColumn
            {
                get
                {
                    return this.columnTypeObjNew;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vJ_CalcLossDataTable : TypedTableBase<dsCalc.Class393>
        {
            private DataColumn columnCodeAbonent;
            private DataColumn columnCoeffLosses;
            private DataColumn columnComment;
            private DataColumn columnDateCalc;
            private DataColumn columndeleted;
            private DataColumn columnid;
            private DataColumn columnidAbn;
            private DataColumn columnidAbnBalance;
            private DataColumn columnidAbnObj;
            private DataColumn columnidOwner;
            private DataColumn columnidTypeCalc;
            private DataColumn columnisActive;
            private DataColumn columnnameAbn;
            private DataColumn columnnameAbnBalance;
            private DataColumn columnnameCalc;
            private DataColumn columnnameObj;
            private DataColumn columnnameOwner;
            private DataColumn columnnum;
            private DataColumn columntpName;
            private DataColumn columntypeCalc;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate244 vJ_CalcLossRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate244 vJ_CalcLossRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate244 vJ_CalcLossRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate244 vJ_CalcLossRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vJ_CalcLossDataTable()
            {
                base.TableName = "vJ_CalcLoss";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vJ_CalcLossDataTable(DataTable dataTable_0)
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
            protected vJ_CalcLossDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                dsCalc.vJ_CalcLossDataTable table1 = (dsCalc.vJ_CalcLossDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.vJ_CalcLossDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class393);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class393 class393_0)
            {
                base.Rows.Add(class393_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class393 method_1(int int_0, int int_1, int int_2, string string_0, string string_1, int int_3, string string_2, int int_4, string string_3, int int_5, string string_4, string string_5, DateTime dateTime_0, int int_6, string string_6, string string_7, bool bool_0, bool bool_1, decimal decimal_0, int int_7)
            {
                dsCalc.Class393 row = (dsCalc.Class393) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, int_1, int_2, string_0, string_1, int_3, string_2, int_4, string_3, int_5, string_4, string_5, dateTime_0, int_6, string_6, string_7,
                    bool_0, bool_1, decimal_0, int_7
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class393 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class393) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnnum = base.Columns["num"];
                this.columnidTypeCalc = base.Columns["idTypeCalc"];
                this.columntypeCalc = base.Columns["typeCalc"];
                this.columnnameCalc = base.Columns["nameCalc"];
                this.columnidAbn = base.Columns["idAbn"];
                this.columnnameAbn = base.Columns["nameAbn"];
                this.columnidAbnObj = base.Columns["idAbnObj"];
                this.columnnameObj = base.Columns["nameObj"];
                this.columnidAbnBalance = base.Columns["idAbnBalance"];
                this.columnnameAbnBalance = base.Columns["nameAbnBalance"];
                this.columntpName = base.Columns["tpName"];
                this.columnDateCalc = base.Columns["DateCalc"];
                this.columnidOwner = base.Columns["idOwner"];
                this.columnnameOwner = base.Columns["nameOwner"];
                this.columnComment = base.Columns["Comment"];
                this.columnisActive = base.Columns["isActive"];
                this.columndeleted = base.Columns["deleted"];
                this.columnCoeffLosses = base.Columns["CoeffLosses"];
                this.columnCodeAbonent = base.Columns["CodeAbonent"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnum = new DataColumn("num", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnum);
                this.columnidTypeCalc = new DataColumn("idTypeCalc", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidTypeCalc);
                this.columntypeCalc = new DataColumn("typeCalc", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntypeCalc);
                this.columnnameCalc = new DataColumn("nameCalc", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnameCalc);
                this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
                this.columnnameAbn = new DataColumn("nameAbn", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnameAbn);
                this.columnidAbnObj = new DataColumn("idAbnObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbnObj);
                this.columnnameObj = new DataColumn("nameObj", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnameObj);
                this.columnidAbnBalance = new DataColumn("idAbnBalance", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbnBalance);
                this.columnnameAbnBalance = new DataColumn("nameAbnBalance", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnameAbnBalance);
                this.columntpName = new DataColumn("tpName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntpName);
                this.columnDateCalc = new DataColumn("DateCalc", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateCalc);
                this.columnidOwner = new DataColumn("idOwner", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidOwner);
                this.columnnameOwner = new DataColumn("nameOwner", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnameOwner);
                this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComment);
                this.columnisActive = new DataColumn("isActive", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisActive);
                this.columndeleted = new DataColumn("deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columndeleted);
                this.columnCoeffLosses = new DataColumn("CoeffLosses", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnCoeffLosses);
                this.columnCodeAbonent = new DataColumn("CodeAbonent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCodeAbonent);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnidTypeCalc.AllowDBNull = false;
                this.columntypeCalc.MaxLength = 100;
                this.columnnameCalc.MaxLength = 0x200;
                this.columnnameAbn.MaxLength = 100;
                this.columnidAbnObj.AllowDBNull = false;
                this.columnnameObj.ReadOnly = true;
                this.columnnameObj.MaxLength = 0x181;
                this.columnidAbnBalance.AllowDBNull = false;
                this.columnnameAbnBalance.MaxLength = 100;
                this.columnDateCalc.AllowDBNull = false;
                this.columnnameOwner.MaxLength = 50;
                this.columnComment.MaxLength = 0x400;
                this.columnisActive.AllowDBNull = false;
                this.columndeleted.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class393 method_5()
            {
                return (dsCalc.Class393) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(dsCalc.Class393 class393_0)
            {
                base.Rows.Remove(class393_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class393(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vJ_CalcLossRowChanged != null)
                {
                    this.vJ_CalcLossRowChanged(this, new dsCalc.EventArgs240((dsCalc.Class393) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vJ_CalcLossRowChanging != null)
                {
                    this.vJ_CalcLossRowChanging(this, new dsCalc.EventArgs240((dsCalc.Class393) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vJ_CalcLossRowDeleted != null)
                {
                    this.vJ_CalcLossRowDeleted(this, new dsCalc.EventArgs240((dsCalc.Class393) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vJ_CalcLossRowDeleting != null)
                {
                    this.vJ_CalcLossRowDeleting(this, new dsCalc.EventArgs240((dsCalc.Class393) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vJ_CalcLossDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CoeffLossesColumn
            {
                get
                {
                    return this.columnCoeffLosses;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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
            public DataColumn DateCalcColumn
            {
                get
                {
                    return this.columnDateCalc;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idAbnBalanceColumn
            {
                get
                {
                    return this.columnidAbnBalance;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
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
            public DataColumn idTypeCalcColumn
            {
                get
                {
                    return this.columnidTypeCalc;
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
            public dsCalc.Class393 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class393) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nameAbnBalanceColumn
            {
                get
                {
                    return this.columnnameAbnBalance;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nameAbnColumn
            {
                get
                {
                    return this.columnnameAbn;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nameCalcColumn
            {
                get
                {
                    return this.columnnameCalc;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn nameObjColumn
            {
                get
                {
                    return this.columnnameObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nameOwnerColumn
            {
                get
                {
                    return this.columnnameOwner;
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
            public DataColumn tpNameColumn
            {
                get
                {
                    return this.columntpName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeCalcColumn
            {
                get
                {
                    return this.columntypeCalc;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vL_SchmAbnDataTable : TypedTableBase<dsCalc.Class400>
        {
            private DataColumn columnid;
            private DataColumn columnidAbn;
            private DataColumn columnidAbnObj;
            private DataColumn columnidDoc;
            private DataColumn columnidPoint;
            private DataColumn columnidSchmObj;
            private DataColumn columnSchmObjName;
            private DataColumn columnTypeDoc;
            private DataColumn columntypeDocName;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate251 vL_SchmAbnRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate251 vL_SchmAbnRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate251 vL_SchmAbnRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate251 vL_SchmAbnRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vL_SchmAbnDataTable()
            {
                base.TableName = "vL_SchmAbn";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vL_SchmAbnDataTable(DataTable dataTable_0)
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
            protected vL_SchmAbnDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                dsCalc.vL_SchmAbnDataTable table1 = (dsCalc.vL_SchmAbnDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.vL_SchmAbnDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class400);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class400 class400_0)
            {
                base.Rows.Add(class400_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class400 method_1(int int_0, int int_1, string string_0, int int_2, int int_3, int int_4, int int_5, int int_6, string string_1)
            {
                dsCalc.Class400 row = (dsCalc.Class400) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, string_0, int_2, int_3, int_4, int_5, int_6, string_1 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class400 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class400) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidSchmObj = base.Columns["idSchmObj"];
                this.columnSchmObjName = base.Columns["SchmObjName"];
                this.columnidAbn = base.Columns["idAbn"];
                this.columnidAbnObj = base.Columns["idAbnObj"];
                this.columnidPoint = base.Columns["idPoint"];
                this.columnidDoc = base.Columns["idDoc"];
                this.columnTypeDoc = base.Columns["TypeDoc"];
                this.columntypeDocName = base.Columns["typeDocName"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidSchmObj = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSchmObj);
                this.columnSchmObjName = new DataColumn("SchmObjName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnSchmObjName);
                this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
                this.columnidAbnObj = new DataColumn("idAbnObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbnObj);
                this.columnidPoint = new DataColumn("idPoint", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidPoint);
                this.columnidDoc = new DataColumn("idDoc", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidDoc);
                this.columnTypeDoc = new DataColumn("TypeDoc", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnTypeDoc);
                this.columntypeDocName = new DataColumn("typeDocName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntypeDocName);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnidSchmObj.AllowDBNull = false;
                this.columnSchmObjName.ReadOnly = true;
                this.columnSchmObjName.MaxLength = 0x3e8;
                this.columntypeDocName.MaxLength = 100;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public dsCalc.Class400 method_5()
            {
                return (dsCalc.Class400) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(dsCalc.Class400 class400_0)
            {
                base.Rows.Remove(class400_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class400(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vL_SchmAbnRowChanged != null)
                {
                    this.vL_SchmAbnRowChanged(this, new dsCalc.EventArgs247((dsCalc.Class400) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vL_SchmAbnRowChanging != null)
                {
                    this.vL_SchmAbnRowChanging(this, new dsCalc.EventArgs247((dsCalc.Class400) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vL_SchmAbnRowDeleted != null)
                {
                    this.vL_SchmAbnRowDeleted(this, new dsCalc.EventArgs247((dsCalc.Class400) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vL_SchmAbnRowDeleting != null)
                {
                    this.vL_SchmAbnRowDeleting(this, new dsCalc.EventArgs247((dsCalc.Class400) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vL_SchmAbnDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idDocColumn
            {
                get
                {
                    return this.columnidDoc;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idPointColumn
            {
                get
                {
                    return this.columnidPoint;
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
            public dsCalc.Class400 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class400) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SchmObjNameColumn
            {
                get
                {
                    return this.columnSchmObjName;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeDocNameColumn
            {
                get
                {
                    return this.columntypeDocName;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vR_CableDataTable : TypedTableBase<dsCalc.Class395>
        {
            private DataColumn columnAmperage;
            private DataColumn columnCableMakeup;
            private DataColumn columnCrossSection;
            private DataColumn columnCrossSectionAddl;
            private DataColumn columnDeleted;
            private DataColumn columnFullName;
            private DataColumn columnid;
            private DataColumn columnResistance;
            private DataColumn columnVoltageTypeName;
            private DataColumn columnVoltageValue;
            private DataColumn columnWires;
            private DataColumn columnWiresAddl;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate246 vR_CableRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate246 vR_CableRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate246 vR_CableRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate246 vR_CableRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vR_CableDataTable()
            {
                base.TableName = "vR_Cable";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vR_CableDataTable(DataTable dataTable_0)
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
            protected vR_CableDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                dsCalc.vR_CableDataTable table1 = (dsCalc.vR_CableDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.vR_CableDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class395);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(dsCalc.Class395 class395_0)
            {
                base.Rows.Add(class395_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class395 method_1(int int_0, string string_0, string string_1, int int_1, float float_0, float float_1, float float_2, string string_2, float float_3, bool bool_0, int int_2, float float_4)
            {
                dsCalc.Class395 row = (dsCalc.Class395) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, string_1, int_1, float_0, float_1, float_2, string_2, float_3, bool_0, int_2, float_4 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class395 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class395) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnFullName = base.Columns["FullName"];
                this.columnCableMakeup = base.Columns["CableMakeup"];
                this.columnWires = base.Columns["Wires"];
                this.columnCrossSection = base.Columns["CrossSection"];
                this.columnAmperage = base.Columns["Amperage"];
                this.columnResistance = base.Columns["Resistance"];
                this.columnVoltageTypeName = base.Columns["VoltageTypeName"];
                this.columnVoltageValue = base.Columns["VoltageValue"];
                this.columnDeleted = base.Columns["Deleted"];
                this.columnWiresAddl = base.Columns["WiresAddl"];
                this.columnCrossSectionAddl = base.Columns["CrossSectionAddl"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnFullName = new DataColumn("FullName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFullName);
                this.columnCableMakeup = new DataColumn("CableMakeup", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnCableMakeup);
                this.columnWires = new DataColumn("Wires", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnWires);
                this.columnCrossSection = new DataColumn("CrossSection", typeof(float), null, MappingType.Element);
                base.Columns.Add(this.columnCrossSection);
                this.columnAmperage = new DataColumn("Amperage", typeof(float), null, MappingType.Element);
                base.Columns.Add(this.columnAmperage);
                this.columnResistance = new DataColumn("Resistance", typeof(float), null, MappingType.Element);
                base.Columns.Add(this.columnResistance);
                this.columnVoltageTypeName = new DataColumn("VoltageTypeName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnVoltageTypeName);
                this.columnVoltageValue = new DataColumn("VoltageValue", typeof(float), null, MappingType.Element);
                base.Columns.Add(this.columnVoltageValue);
                this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnDeleted);
                this.columnWiresAddl = new DataColumn("WiresAddl", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnWiresAddl);
                this.columnCrossSectionAddl = new DataColumn("CrossSectionAddl", typeof(float), null, MappingType.Element);
                base.Columns.Add(this.columnCrossSectionAddl);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnFullName.ReadOnly = true;
                this.columnFullName.MaxLength = 0xad;
                this.columnCableMakeup.AllowDBNull = false;
                this.columnCableMakeup.MaxLength = 50;
                this.columnVoltageTypeName.MaxLength = 100;
                this.columnDeleted.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class395 method_5()
            {
                return (dsCalc.Class395) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(dsCalc.Class395 class395_0)
            {
                base.Rows.Remove(class395_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class395(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vR_CableRowChanged != null)
                {
                    this.vR_CableRowChanged(this, new dsCalc.EventArgs242((dsCalc.Class395) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vR_CableRowChanging != null)
                {
                    this.vR_CableRowChanging(this, new dsCalc.EventArgs242((dsCalc.Class395) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vR_CableRowDeleted != null)
                {
                    this.vR_CableRowDeleted(this, new dsCalc.EventArgs242((dsCalc.Class395) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vR_CableRowDeleting != null)
                {
                    this.vR_CableRowDeleting(this, new dsCalc.EventArgs242((dsCalc.Class395) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vR_CableDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn AmperageColumn
            {
                get
                {
                    return this.columnAmperage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CableMakeupColumn
            {
                get
                {
                    return this.columnCableMakeup;
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
            public DataColumn CrossSectionAddlColumn
            {
                get
                {
                    return this.columnCrossSectionAddl;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CrossSectionColumn
            {
                get
                {
                    return this.columnCrossSection;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FullNameColumn
            {
                get
                {
                    return this.columnFullName;
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
            public dsCalc.Class395 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class395) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ResistanceColumn
            {
                get
                {
                    return this.columnResistance;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn VoltageTypeNameColumn
            {
                get
                {
                    return this.columnVoltageTypeName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn VoltageValueColumn
            {
                get
                {
                    return this.columnVoltageValue;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn WiresAddlColumn
            {
                get
                {
                    return this.columnWiresAddl;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn WiresColumn
            {
                get
                {
                    return this.columnWires;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vR_TransformerDataTable : TypedTableBase<dsCalc.Class401>
        {
            private DataColumn columnDeleted;
            private DataColumn columnFullName;
            private DataColumn columnGroupWindings;
            private DataColumn columnHighVoltage;
            private DataColumn columnid;
            private DataColumn columnLowVoltage;
            private DataColumn columnName;
            private DataColumn columnNoLoadLoss;
            private DataColumn columnPower;
            private DataColumn columnRatedAmperHV;
            private DataColumn columnRatedAmperLV;
            private DataColumn columnShortCircuitLoss;
            private DataColumn columnShortCircuitVolt;
            private DataColumn columnType;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate252 vR_TransformerRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate252 vR_TransformerRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate252 vR_TransformerRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event dsCalc.Delegate252 vR_TransformerRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vR_TransformerDataTable()
            {
                base.TableName = "vR_Transformer";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal vR_TransformerDataTable(DataTable dataTable_0)
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
            protected vR_TransformerDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                dsCalc.vR_TransformerDataTable table1 = (dsCalc.vR_TransformerDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new dsCalc.vR_TransformerDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(dsCalc.Class401);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(dsCalc.Class401 class401_0)
            {
                base.Rows.Add(class401_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class401 method_1(string string_0, string string_1, string string_2, int int_0, decimal decimal_0, decimal decimal_1, decimal decimal_2, decimal decimal_3, string string_3, decimal decimal_4, float float_0, float float_1, bool bool_0)
            {
                dsCalc.Class401 row = (dsCalc.Class401) base.NewRow();
                object[] objArray1 = new object[14];
                objArray1[1] = string_0;
                objArray1[2] = string_1;
                objArray1[3] = string_2;
                objArray1[4] = int_0;
                objArray1[5] = decimal_0;
                objArray1[6] = decimal_1;
                objArray1[7] = decimal_2;
                objArray1[8] = decimal_3;
                objArray1[9] = string_3;
                objArray1[10] = decimal_4;
                objArray1[11] = float_0;
                objArray1[12] = float_1;
                objArray1[13] = bool_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class401 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (dsCalc.Class401) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnFullName = base.Columns["FullName"];
                this.columnName = base.Columns["Name"];
                this.columnType = base.Columns["Type"];
                this.columnPower = base.Columns["Power"];
                this.columnHighVoltage = base.Columns["HighVoltage"];
                this.columnLowVoltage = base.Columns["LowVoltage"];
                this.columnRatedAmperHV = base.Columns["RatedAmperHV"];
                this.columnRatedAmperLV = base.Columns["RatedAmperLV"];
                this.columnGroupWindings = base.Columns["GroupWindings"];
                this.columnShortCircuitVolt = base.Columns["ShortCircuitVolt"];
                this.columnShortCircuitLoss = base.Columns["ShortCircuitLoss"];
                this.columnNoLoadLoss = base.Columns["NoLoadLoss"];
                this.columnDeleted = base.Columns["Deleted"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnFullName = new DataColumn("FullName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFullName);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnType = new DataColumn("Type", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnType);
                this.columnPower = new DataColumn("Power", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnPower);
                this.columnHighVoltage = new DataColumn("HighVoltage", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnHighVoltage);
                this.columnLowVoltage = new DataColumn("LowVoltage", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnLowVoltage);
                this.columnRatedAmperHV = new DataColumn("RatedAmperHV", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnRatedAmperHV);
                this.columnRatedAmperLV = new DataColumn("RatedAmperLV", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnRatedAmperLV);
                this.columnGroupWindings = new DataColumn("GroupWindings", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnGroupWindings);
                this.columnShortCircuitVolt = new DataColumn("ShortCircuitVolt", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnShortCircuitVolt);
                this.columnShortCircuitLoss = new DataColumn("ShortCircuitLoss", typeof(float), null, MappingType.Element);
                base.Columns.Add(this.columnShortCircuitLoss);
                this.columnNoLoadLoss = new DataColumn("NoLoadLoss", typeof(float), null, MappingType.Element);
                base.Columns.Add(this.columnNoLoadLoss);
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
                this.columnFullName.ReadOnly = true;
                this.columnFullName.MaxLength = 0x7b;
                this.columnName.AllowDBNull = false;
                this.columnName.MaxLength = 50;
                this.columnType.AllowDBNull = false;
                this.columnType.MaxLength = 50;
                this.columnPower.AllowDBNull = false;
                this.columnHighVoltage.AllowDBNull = false;
                this.columnLowVoltage.AllowDBNull = false;
                this.columnGroupWindings.MaxLength = 50;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public dsCalc.Class401 method_5()
            {
                return (dsCalc.Class401) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(dsCalc.Class401 class401_0)
            {
                base.Rows.Remove(class401_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new dsCalc.Class401(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vR_TransformerRowChanged != null)
                {
                    this.vR_TransformerRowChanged(this, new dsCalc.EventArgs248((dsCalc.Class401) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vR_TransformerRowChanging != null)
                {
                    this.vR_TransformerRowChanging(this, new dsCalc.EventArgs248((dsCalc.Class401) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vR_TransformerRowDeleted != null)
                {
                    this.vR_TransformerRowDeleted(this, new dsCalc.EventArgs248((dsCalc.Class401) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vR_TransformerRowDeleting != null)
                {
                    this.vR_TransformerRowDeleting(this, new dsCalc.EventArgs248((dsCalc.Class401) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsCalc calc = new dsCalc();
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
                    FixedValue = calc.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vR_TransformerDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = calc.GetSchemaSerializable();
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
            public DataColumn DeletedColumn
            {
                get
                {
                    return this.columnDeleted;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FullNameColumn
            {
                get
                {
                    return this.columnFullName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn GroupWindingsColumn
            {
                get
                {
                    return this.columnGroupWindings;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn HighVoltageColumn
            {
                get
                {
                    return this.columnHighVoltage;
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
            public dsCalc.Class401 this[int int_0]
            {
                get
                {
                    return (dsCalc.Class401) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LowVoltageColumn
            {
                get
                {
                    return this.columnLowVoltage;
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
            public DataColumn NoLoadLossColumn
            {
                get
                {
                    return this.columnNoLoadLoss;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn PowerColumn
            {
                get
                {
                    return this.columnPower;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn RatedAmperHVColumn
            {
                get
                {
                    return this.columnRatedAmperHV;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RatedAmperLVColumn
            {
                get
                {
                    return this.columnRatedAmperLV;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ShortCircuitLossColumn
            {
                get
                {
                    return this.columnShortCircuitLoss;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ShortCircuitVoltColumn
            {
                get
                {
                    return this.columnShortCircuitVolt;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TypeColumn
            {
                get
                {
                    return this.columnType;
                }
            }
        }
    }
}

