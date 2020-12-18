namespace Documents.Forms.JournalExcavation
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

    [Serializable, HelpKeyword("vs.data.DataSet"), ToolboxItem(true), DesignerCategory("code"), XmlSchemaProvider("GetTypedDataSetSchema"), XmlRoot("DataSetExcavation")]
    internal class DataSetExcavation : DataSet
    {
        private System.Data.SchemaSerializationMode _schemaSerializationMode;
        private tAbnDataTable tabletAbn;
        private tAbnTypeDataTable tabletAbnType;
        private tJ_ExcavationDataTable tabletJ_Excavation;
        private tJ_ExcavationAddressDataTable tabletJ_ExcavationAddress;
        private tJ_ExcavationFileDataTable tabletJ_ExcavationFile;
        private tJ_ExcavationSchmObjDataTable tabletJ_ExcavationSchmObj;
        private tJ_ExcavationStatusDataTable tabletJ_ExcavationStatus;
        private tJ_ExcavationSurfaceDataTable tabletJ_ExcavationSurface;
        private tR_ClassifierDataTable tabletR_Classifier;
        private vAbnTypeDataTable tablevAbnType;
        private vJ_ExcavationDataTable tablevJ_Excavation;
        private vJ_ExcavationAddressDataTable tablevJ_ExcavationAddress;
        private vJ_ExcavationFileDataTable tablevJ_ExcavationFile;
        private vJ_ExcavationSchmObjDataTable tablevJ_ExcavationSchmObj;
        private vJ_ExcavationStatusDataTable tablevJ_ExcavationStatus;
        private vJ_ExcavationSurfaceDataTable tablevJ_ExcavationSurface;
        private vR_KladrStreetDataTable tablevR_KladrStreet;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public DataSetExcavation()
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            base.BeginInit();
            this.method_2();
            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_20);
            base.Tables.CollectionChanged += handler;
            base.Relations.CollectionChanged += handler;
            base.EndInit();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected DataSetExcavation(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0, false)
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
            {
                this.method_1(false);
                CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.method_20);
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
                    if (dataSet.Tables["tJ_ExcavationAddress"] != null)
                    {
                        base.Tables.Add(new tJ_ExcavationAddressDataTable(dataSet.Tables["tJ_ExcavationAddress"]));
                    }
                    if (dataSet.Tables["tJ_ExcavationSurface"] != null)
                    {
                        base.Tables.Add(new tJ_ExcavationSurfaceDataTable(dataSet.Tables["tJ_ExcavationSurface"]));
                    }
                    if (dataSet.Tables["tR_Classifier"] != null)
                    {
                        base.Tables.Add(new tR_ClassifierDataTable(dataSet.Tables["tR_Classifier"]));
                    }
                    if (dataSet.Tables["vJ_ExcavationAddress"] != null)
                    {
                        base.Tables.Add(new vJ_ExcavationAddressDataTable(dataSet.Tables["vJ_ExcavationAddress"]));
                    }
                    if (dataSet.Tables["tJ_Excavation"] != null)
                    {
                        base.Tables.Add(new tJ_ExcavationDataTable(dataSet.Tables["tJ_Excavation"]));
                    }
                    if (dataSet.Tables["tAbn"] != null)
                    {
                        base.Tables.Add(new tAbnDataTable(dataSet.Tables["tAbn"]));
                    }
                    if (dataSet.Tables["tAbnType"] != null)
                    {
                        base.Tables.Add(new tAbnTypeDataTable(dataSet.Tables["tAbnType"]));
                    }
                    if (dataSet.Tables["vJ_Excavation"] != null)
                    {
                        base.Tables.Add(new vJ_ExcavationDataTable(dataSet.Tables["vJ_Excavation"]));
                    }
                    if (dataSet.Tables["vJ_ExcavationSchmObj"] != null)
                    {
                        base.Tables.Add(new vJ_ExcavationSchmObjDataTable(dataSet.Tables["vJ_ExcavationSchmObj"]));
                    }
                    if (dataSet.Tables["tJ_ExcavationSchmObj"] != null)
                    {
                        base.Tables.Add(new tJ_ExcavationSchmObjDataTable(dataSet.Tables["tJ_ExcavationSchmObj"]));
                    }
                    if (dataSet.Tables["tJ_ExcavationStatus"] != null)
                    {
                        base.Tables.Add(new tJ_ExcavationStatusDataTable(dataSet.Tables["tJ_ExcavationStatus"]));
                    }
                    if (dataSet.Tables["vJ_ExcavationStatus"] != null)
                    {
                        base.Tables.Add(new vJ_ExcavationStatusDataTable(dataSet.Tables["vJ_ExcavationStatus"]));
                    }
                    if (dataSet.Tables["vJ_ExcavationSurface"] != null)
                    {
                        base.Tables.Add(new vJ_ExcavationSurfaceDataTable(dataSet.Tables["vJ_ExcavationSurface"]));
                    }
                    if (dataSet.Tables["tJ_ExcavationFile"] != null)
                    {
                        base.Tables.Add(new tJ_ExcavationFileDataTable(dataSet.Tables["tJ_ExcavationFile"]));
                    }
                    if (dataSet.Tables["vJ_ExcavationFile"] != null)
                    {
                        base.Tables.Add(new vJ_ExcavationFileDataTable(dataSet.Tables["vJ_ExcavationFile"]));
                    }
                    if (dataSet.Tables["vR_KladrStreet"] != null)
                    {
                        base.Tables.Add(new vR_KladrStreetDataTable(dataSet.Tables["vR_KladrStreet"]));
                    }
                    if (dataSet.Tables["vAbnType"] != null)
                    {
                        base.Tables.Add(new vAbnTypeDataTable(dataSet.Tables["vAbnType"]));
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
                CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_20);
                base.Tables.CollectionChanged += handler;
                this.Relations.CollectionChanged += handler;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override DataSet Clone()
        {
            DataSetExcavation excavation1 = (DataSetExcavation) base.Clone();
            excavation1.method_0();
            excavation1.SchemaSerializationMode = this.SchemaSerializationMode;
            return excavation1;
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        internal void method_0()
        {
            this.method_1(true);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        internal void method_1(bool bool_0)
        {
            this.tabletJ_ExcavationAddress = (tJ_ExcavationAddressDataTable) base.Tables["tJ_ExcavationAddress"];
            if (bool_0 && (this.tabletJ_ExcavationAddress != null))
            {
                this.tabletJ_ExcavationAddress.method_3();
            }
            this.tabletJ_ExcavationSurface = (tJ_ExcavationSurfaceDataTable) base.Tables["tJ_ExcavationSurface"];
            if (bool_0 && (this.tabletJ_ExcavationSurface != null))
            {
                this.tabletJ_ExcavationSurface.method_3();
            }
            this.tabletR_Classifier = (tR_ClassifierDataTable) base.Tables["tR_Classifier"];
            if (bool_0 && (this.tabletR_Classifier != null))
            {
                this.tabletR_Classifier.method_3();
            }
            this.tablevJ_ExcavationAddress = (vJ_ExcavationAddressDataTable) base.Tables["vJ_ExcavationAddress"];
            if (bool_0 && (this.tablevJ_ExcavationAddress != null))
            {
                this.tablevJ_ExcavationAddress.method_3();
            }
            this.tabletJ_Excavation = (tJ_ExcavationDataTable) base.Tables["tJ_Excavation"];
            if (bool_0 && (this.tabletJ_Excavation != null))
            {
                this.tabletJ_Excavation.method_3();
            }
            this.tabletAbn = (tAbnDataTable) base.Tables["tAbn"];
            if (bool_0 && (this.tabletAbn != null))
            {
                this.tabletAbn.method_3();
            }
            this.tabletAbnType = (tAbnTypeDataTable) base.Tables["tAbnType"];
            if (bool_0 && (this.tabletAbnType != null))
            {
                this.tabletAbnType.method_3();
            }
            this.tablevJ_Excavation = (vJ_ExcavationDataTable) base.Tables["vJ_Excavation"];
            if (bool_0 && (this.tablevJ_Excavation != null))
            {
                this.tablevJ_Excavation.method_2();
            }
            this.tablevJ_ExcavationSchmObj = (vJ_ExcavationSchmObjDataTable) base.Tables["vJ_ExcavationSchmObj"];
            if (bool_0 && (this.tablevJ_ExcavationSchmObj != null))
            {
                this.tablevJ_ExcavationSchmObj.method_3();
            }
            this.tabletJ_ExcavationSchmObj = (tJ_ExcavationSchmObjDataTable) base.Tables["tJ_ExcavationSchmObj"];
            if (bool_0 && (this.tabletJ_ExcavationSchmObj != null))
            {
                this.tabletJ_ExcavationSchmObj.method_3();
            }
            this.tabletJ_ExcavationStatus = (tJ_ExcavationStatusDataTable) base.Tables["tJ_ExcavationStatus"];
            if (bool_0 && (this.tabletJ_ExcavationStatus != null))
            {
                this.tabletJ_ExcavationStatus.method_3();
            }
            this.tablevJ_ExcavationStatus = (vJ_ExcavationStatusDataTable) base.Tables["vJ_ExcavationStatus"];
            if (bool_0 && (this.tablevJ_ExcavationStatus != null))
            {
                this.tablevJ_ExcavationStatus.method_3();
            }
            this.tablevJ_ExcavationSurface = (vJ_ExcavationSurfaceDataTable) base.Tables["vJ_ExcavationSurface"];
            if (bool_0 && (this.tablevJ_ExcavationSurface != null))
            {
                this.tablevJ_ExcavationSurface.method_3();
            }
            this.tabletJ_ExcavationFile = (tJ_ExcavationFileDataTable) base.Tables["tJ_ExcavationFile"];
            if (bool_0 && (this.tabletJ_ExcavationFile != null))
            {
                this.tabletJ_ExcavationFile.method_3();
            }
            this.tablevJ_ExcavationFile = (vJ_ExcavationFileDataTable) base.Tables["vJ_ExcavationFile"];
            if (bool_0 && (this.tablevJ_ExcavationFile != null))
            {
                this.tablevJ_ExcavationFile.method_3();
            }
            this.tablevR_KladrStreet = (vR_KladrStreetDataTable) base.Tables["vR_KladrStreet"];
            if (bool_0 && (this.tablevR_KladrStreet != null))
            {
                this.tablevR_KladrStreet.method_3();
            }
            this.tablevAbnType = (vAbnTypeDataTable) base.Tables["vAbnType"];
            if (bool_0 && (this.tablevAbnType != null))
            {
                this.tablevAbnType.method_2();
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_10()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
            base.DataSetName = "DataSetExcavation";
            base.Prefix = "";
            base.Namespace = "http://tempuri.org/DataSetExcavation.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tabletJ_ExcavationAddress = new tJ_ExcavationAddressDataTable();
            base.Tables.Add(this.tabletJ_ExcavationAddress);
            this.tabletJ_ExcavationSurface = new tJ_ExcavationSurfaceDataTable();
            base.Tables.Add(this.tabletJ_ExcavationSurface);
            this.tabletR_Classifier = new tR_ClassifierDataTable();
            base.Tables.Add(this.tabletR_Classifier);
            this.tablevJ_ExcavationAddress = new vJ_ExcavationAddressDataTable();
            base.Tables.Add(this.tablevJ_ExcavationAddress);
            this.tabletJ_Excavation = new tJ_ExcavationDataTable();
            base.Tables.Add(this.tabletJ_Excavation);
            this.tabletAbn = new tAbnDataTable();
            base.Tables.Add(this.tabletAbn);
            this.tabletAbnType = new tAbnTypeDataTable();
            base.Tables.Add(this.tabletAbnType);
            this.tablevJ_Excavation = new vJ_ExcavationDataTable();
            base.Tables.Add(this.tablevJ_Excavation);
            this.tablevJ_ExcavationSchmObj = new vJ_ExcavationSchmObjDataTable();
            base.Tables.Add(this.tablevJ_ExcavationSchmObj);
            this.tabletJ_ExcavationSchmObj = new tJ_ExcavationSchmObjDataTable();
            base.Tables.Add(this.tabletJ_ExcavationSchmObj);
            this.tabletJ_ExcavationStatus = new tJ_ExcavationStatusDataTable();
            base.Tables.Add(this.tabletJ_ExcavationStatus);
            this.tablevJ_ExcavationStatus = new vJ_ExcavationStatusDataTable();
            base.Tables.Add(this.tablevJ_ExcavationStatus);
            this.tablevJ_ExcavationSurface = new vJ_ExcavationSurfaceDataTable();
            base.Tables.Add(this.tablevJ_ExcavationSurface);
            this.tabletJ_ExcavationFile = new tJ_ExcavationFileDataTable();
            base.Tables.Add(this.tabletJ_ExcavationFile);
            this.tablevJ_ExcavationFile = new vJ_ExcavationFileDataTable();
            base.Tables.Add(this.tablevJ_ExcavationFile);
            this.tablevR_KladrStreet = new vR_KladrStreetDataTable();
            base.Tables.Add(this.tablevR_KladrStreet);
            this.tablevAbnType = new vAbnTypeDataTable();
            base.Tables.Add(this.tablevAbnType);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_20(object sender, CollectionChangeEventArgs e)
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
                if (dataSet.Tables["tJ_ExcavationAddress"] != null)
                {
                    base.Tables.Add(new tJ_ExcavationAddressDataTable(dataSet.Tables["tJ_ExcavationAddress"]));
                }
                if (dataSet.Tables["tJ_ExcavationSurface"] != null)
                {
                    base.Tables.Add(new tJ_ExcavationSurfaceDataTable(dataSet.Tables["tJ_ExcavationSurface"]));
                }
                if (dataSet.Tables["tR_Classifier"] != null)
                {
                    base.Tables.Add(new tR_ClassifierDataTable(dataSet.Tables["tR_Classifier"]));
                }
                if (dataSet.Tables["vJ_ExcavationAddress"] != null)
                {
                    base.Tables.Add(new vJ_ExcavationAddressDataTable(dataSet.Tables["vJ_ExcavationAddress"]));
                }
                if (dataSet.Tables["tJ_Excavation"] != null)
                {
                    base.Tables.Add(new tJ_ExcavationDataTable(dataSet.Tables["tJ_Excavation"]));
                }
                if (dataSet.Tables["tAbn"] != null)
                {
                    base.Tables.Add(new tAbnDataTable(dataSet.Tables["tAbn"]));
                }
                if (dataSet.Tables["tAbnType"] != null)
                {
                    base.Tables.Add(new tAbnTypeDataTable(dataSet.Tables["tAbnType"]));
                }
                if (dataSet.Tables["vJ_Excavation"] != null)
                {
                    base.Tables.Add(new vJ_ExcavationDataTable(dataSet.Tables["vJ_Excavation"]));
                }
                if (dataSet.Tables["vJ_ExcavationSchmObj"] != null)
                {
                    base.Tables.Add(new vJ_ExcavationSchmObjDataTable(dataSet.Tables["vJ_ExcavationSchmObj"]));
                }
                if (dataSet.Tables["tJ_ExcavationSchmObj"] != null)
                {
                    base.Tables.Add(new tJ_ExcavationSchmObjDataTable(dataSet.Tables["tJ_ExcavationSchmObj"]));
                }
                if (dataSet.Tables["tJ_ExcavationStatus"] != null)
                {
                    base.Tables.Add(new tJ_ExcavationStatusDataTable(dataSet.Tables["tJ_ExcavationStatus"]));
                }
                if (dataSet.Tables["vJ_ExcavationStatus"] != null)
                {
                    base.Tables.Add(new vJ_ExcavationStatusDataTable(dataSet.Tables["vJ_ExcavationStatus"]));
                }
                if (dataSet.Tables["vJ_ExcavationSurface"] != null)
                {
                    base.Tables.Add(new vJ_ExcavationSurfaceDataTable(dataSet.Tables["vJ_ExcavationSurface"]));
                }
                if (dataSet.Tables["tJ_ExcavationFile"] != null)
                {
                    base.Tables.Add(new tJ_ExcavationFileDataTable(dataSet.Tables["tJ_ExcavationFile"]));
                }
                if (dataSet.Tables["vJ_ExcavationFile"] != null)
                {
                    base.Tables.Add(new vJ_ExcavationFileDataTable(dataSet.Tables["vJ_ExcavationFile"]));
                }
                if (dataSet.Tables["vR_KladrStreet"] != null)
                {
                    base.Tables.Add(new vR_KladrStreetDataTable(dataSet.Tables["vR_KladrStreet"]));
                }
                if (dataSet.Tables["vAbnType"] != null)
                {
                    base.Tables.Add(new vAbnTypeDataTable(dataSet.Tables["vAbnType"]));
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
            DataSetExcavation excavation = new DataSetExcavation();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            XmlSchemaAny item = new XmlSchemaAny {
                Namespace = excavation.Namespace
            };
            sequence.Items.Add(item);
            type.Particle = sequence;
            XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(true)]
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tAbnTypeDataTable tAbnType
        {
            get
            {
                return this.tabletAbnType;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tJ_ExcavationDataTable tJ_Excavation
        {
            get
            {
                return this.tabletJ_Excavation;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public tJ_ExcavationAddressDataTable tJ_ExcavationAddress
        {
            get
            {
                return this.tabletJ_ExcavationAddress;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
        public tJ_ExcavationFileDataTable tJ_ExcavationFile
        {
            get
            {
                return this.tabletJ_ExcavationFile;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tJ_ExcavationSchmObjDataTable tJ_ExcavationSchmObj
        {
            get
            {
                return this.tabletJ_ExcavationSchmObj;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tJ_ExcavationStatusDataTable tJ_ExcavationStatus
        {
            get
            {
                return this.tabletJ_ExcavationStatus;
            }
        }

        [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tJ_ExcavationSurfaceDataTable tJ_ExcavationSurface
        {
            get
            {
                return this.tabletJ_ExcavationSurface;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tR_ClassifierDataTable tR_Classifier
        {
            get
            {
                return this.tabletR_Classifier;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
        public vAbnTypeDataTable vAbnType
        {
            get
            {
                return this.tablevAbnType;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
        public vJ_ExcavationDataTable vJ_Excavation
        {
            get
            {
                return this.tablevJ_Excavation;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
        public vJ_ExcavationAddressDataTable vJ_ExcavationAddress
        {
            get
            {
                return this.tablevJ_ExcavationAddress;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public vJ_ExcavationFileDataTable vJ_ExcavationFile
        {
            get
            {
                return this.tablevJ_ExcavationFile;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public vJ_ExcavationSchmObjDataTable vJ_ExcavationSchmObj
        {
            get
            {
                return this.tablevJ_ExcavationSchmObj;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public vJ_ExcavationStatusDataTable vJ_ExcavationStatus
        {
            get
            {
                return this.tablevJ_ExcavationStatus;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public vJ_ExcavationSurfaceDataTable vJ_ExcavationSurface
        {
            get
            {
                return this.tablevJ_ExcavationSurface;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public vR_KladrStreetDataTable vR_KladrStreet
        {
            get
            {
                return this.tablevR_KladrStreet;
            }
        }

        public class Class308 : DataRow
        {
            private DataSetExcavation.tJ_ExcavationAddressDataTable tJ_ExcavationAddressDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class308(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_ExcavationAddressDataTable_0 = (DataSetExcavation.tJ_ExcavationAddressDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_ExcavationAddressDataTable_0.idExcavationColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_ExcavationAddressDataTable_0.idExcavationColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.tJ_ExcavationAddressDataTable_0.idStreetColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.tJ_ExcavationAddressDataTable_0.idStreetColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.tJ_ExcavationAddressDataTable_0.HouseColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_13()
            {
                base[this.tJ_ExcavationAddressDataTable_0.HouseColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.tJ_ExcavationAddressDataTable_0.CommentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.tJ_ExcavationAddressDataTable_0.CommentColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_ExcavationAddressDataTable_0.idRegionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idRegion' in table 'tJ_ExcavationAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_3(int int_0)
            {
                base[this.tJ_ExcavationAddressDataTable_0.idRegionColumn] = int_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_ExcavationAddressDataTable_0.idStreetColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idStreet' in table 'tJ_ExcavationAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.tJ_ExcavationAddressDataTable_0.idStreetColumn] = int_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_ExcavationAddressDataTable_0.HouseColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'House' in table 'tJ_ExcavationAddress' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.tJ_ExcavationAddressDataTable_0.HouseColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_8()
            {
                return base.IsNull(this.tJ_ExcavationAddressDataTable_0.idRegionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.tJ_ExcavationAddressDataTable_0.idRegionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tJ_ExcavationAddressDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'tJ_ExcavationAddress' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tJ_ExcavationAddressDataTable_0.CommentColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_ExcavationAddressDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_ExcavationAddressDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class309 : DataRow
        {
            private DataSetExcavation.tJ_ExcavationSurfaceDataTable tJ_ExcavationSurfaceDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class309(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_ExcavationSurfaceDataTable_0 = (DataSetExcavation.tJ_ExcavationSurfaceDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_ExcavationSurfaceDataTable_0.idExcavationColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_ExcavationSurfaceDataTable_0.idExcavationColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_10()
            {
                return base.IsNull(this.tJ_ExcavationSurfaceDataTable_0.unitColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_11()
            {
                base[this.tJ_ExcavationSurfaceDataTable_0.unitColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.tJ_ExcavationSurfaceDataTable_0.commentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.tJ_ExcavationSurfaceDataTable_0.commentColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                return (int) base[this.tJ_ExcavationSurfaceDataTable_0.idTypeColumn];
            }

            public void method_3(int int_0)
            {
                base[this.tJ_ExcavationSurfaceDataTable_0.idTypeColumn] = int_0;
            }

            public int method_4()
            {
                return (int) base[this.tJ_ExcavationSurfaceDataTable_0.idSurfaceColumn];
            }

            public void method_5(int int_0)
            {
                base[this.tJ_ExcavationSurfaceDataTable_0.idSurfaceColumn] = int_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_ExcavationSurfaceDataTable_0.unitColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'unit' in table 'tJ_ExcavationSurface' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.tJ_ExcavationSurfaceDataTable_0.unitColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_8()
            {
                return base.IsNull(this.tJ_ExcavationSurfaceDataTable_0.ValueColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.tJ_ExcavationSurfaceDataTable_0.ValueColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tJ_ExcavationSurfaceDataTable_0.commentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'comment' in table 'tJ_ExcavationSurface' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tJ_ExcavationSurfaceDataTable_0.commentColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_ExcavationSurfaceDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_ExcavationSurfaceDataTable_0.idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double Value
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tJ_ExcavationSurfaceDataTable_0.ValueColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Value' in table 'tJ_ExcavationSurface' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_ExcavationSurfaceDataTable_0.ValueColumn] = value;
                }
            }
        }

        public class Class310 : DataRow
        {
            private DataSetExcavation.tR_ClassifierDataTable tR_ClassifierDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class310(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tR_ClassifierDataTable_0 = (DataSetExcavation.tR_ClassifierDataTable) base.Table;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.tR_ClassifierDataTable_0.ParentIdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

        public class Class311 : DataRow
        {
            private DataSetExcavation.vJ_ExcavationAddressDataTable vJ_ExcavationAddressDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class311(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vJ_ExcavationAddressDataTable_0 = (DataSetExcavation.vJ_ExcavationAddressDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vJ_ExcavationAddressDataTable_0.idExcavationColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vJ_ExcavationAddressDataTable_0.idExcavationColumn] = int_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationAddressDataTable_0.streetColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'street' in table 'vJ_ExcavationAddress' is DBNull.", exception);
                }
                return str;
            }

            public void method_11(string string_0)
            {
                base[this.vJ_ExcavationAddressDataTable_0.streetColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.vJ_ExcavationAddressDataTable_0.idRegionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.vJ_ExcavationAddressDataTable_0.idRegionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.vJ_ExcavationAddressDataTable_0.idStreetColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.vJ_ExcavationAddressDataTable_0.idStreetColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.vJ_ExcavationAddressDataTable_0.HouseColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_17()
            {
                base[this.vJ_ExcavationAddressDataTable_0.HouseColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.vJ_ExcavationAddressDataTable_0.CommentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.vJ_ExcavationAddressDataTable_0.CommentColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_ExcavationAddressDataTable_0.idRegionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idRegion' in table 'vJ_ExcavationAddress' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.vJ_ExcavationAddressDataTable_0.regionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.vJ_ExcavationAddressDataTable_0.regionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_22()
            {
                return base.IsNull(this.vJ_ExcavationAddressDataTable_0.streetColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.vJ_ExcavationAddressDataTable_0.streetColumn] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.vJ_ExcavationAddressDataTable_0.idRegionColumn] = int_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_ExcavationAddressDataTable_0.idStreetColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idStreet' in table 'vJ_ExcavationAddress' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.vJ_ExcavationAddressDataTable_0.idStreetColumn] = int_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationAddressDataTable_0.HouseColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'House' in table 'vJ_ExcavationAddress' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.vJ_ExcavationAddressDataTable_0.HouseColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationAddressDataTable_0.regionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'region' in table 'vJ_ExcavationAddress' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.vJ_ExcavationAddressDataTable_0.regionColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vJ_ExcavationAddressDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'vJ_ExcavationAddress' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vJ_ExcavationAddressDataTable_0.CommentColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vJ_ExcavationAddressDataTable_0.idColumn];
                }
                set
                {
                    base[this.vJ_ExcavationAddressDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class312 : DataRow
        {
            private DataSetExcavation.tJ_ExcavationDataTable tJ_ExcavationDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class312(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_ExcavationDataTable_0 = (DataSetExcavation.tJ_ExcavationDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_ExcavationDataTable_0.numColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'num' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tJ_ExcavationDataTable_0.numColumn] = int_0;
            }

            public DateTime method_10()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_ExcavationDataTable_0.dateEndOrderColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateEndOrder' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_11(DateTime dateTime_0)
            {
                base[this.tJ_ExcavationDataTable_0.dateEndOrderColumn] = dateTime_0;
            }

            public string method_12()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_ExcavationDataTable_0.NumPermissionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NumPermission' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_13(string string_0)
            {
                base[this.tJ_ExcavationDataTable_0.NumPermissionColumn] = string_0;
            }

            public DateTime method_14()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_ExcavationDataTable_0.DatePermissionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DatePermission' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_15(DateTime dateTime_0)
            {
                base[this.tJ_ExcavationDataTable_0.DatePermissionColumn] = dateTime_0;
            }

            public DateTime method_16()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_ExcavationDataTable_0.dateUnderAsphaltColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateUnderAsphalt' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_17(DateTime dateTime_0)
            {
                base[this.tJ_ExcavationDataTable_0.dateUnderAsphaltColumn] = dateTime_0;
            }

            public DateTime method_18()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_ExcavationDataTable_0.dateAsphaltColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateAsphalt' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_19(DateTime dateTime_0)
            {
                base[this.tJ_ExcavationDataTable_0.dateAsphaltColumn] = dateTime_0;
            }

            public DateTime method_2()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_ExcavationDataTable_0.dateBegColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateBeg' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public DateTime method_20()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_ExcavationDataTable_0.datePayColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'datePay' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_21(DateTime dateTime_0)
            {
                base[this.tJ_ExcavationDataTable_0.datePayColumn] = dateTime_0;
            }

            public bool method_22()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tJ_ExcavationDataTable_0.agreedColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'agreed' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return flag;
            }

            public void method_23(bool bool_0)
            {
                base[this.tJ_ExcavationDataTable_0.agreedColumn] = bool_0;
            }

            public DateTime method_24()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_ExcavationDataTable_0.dateagreedColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateagreed' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_25(DateTime dateTime_0)
            {
                base[this.tJ_ExcavationDataTable_0.dateagreedColumn] = dateTime_0;
            }

            public int method_26()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_ExcavationDataTable_0.workeragreedColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'workeragreed' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return num;
            }

            public void method_27(int int_0)
            {
                base[this.tJ_ExcavationDataTable_0.workeragreedColumn] = int_0;
            }

            public int method_28()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_ExcavationDataTable_0.idSRColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idSR' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return num;
            }

            public void method_29(int int_0)
            {
                base[this.tJ_ExcavationDataTable_0.idSRColumn] = int_0;
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.tJ_ExcavationDataTable_0.dateBegColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_30()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.numColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_31()
            {
                base[this.tJ_ExcavationDataTable_0.numColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_32()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.dateBegColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_33()
            {
                base[this.tJ_ExcavationDataTable_0.dateBegColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_34()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.idContractorColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.tJ_ExcavationDataTable_0.idContractorColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.TypeWorkColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_37()
            {
                base[this.tJ_ExcavationDataTable_0.TypeWorkColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_38()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.dateBegOrderColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_39()
            {
                base[this.tJ_ExcavationDataTable_0.dateBegOrderColumn] = Convert.DBNull;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_ExcavationDataTable_0.idContractorColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idContractor' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.dateEndOrderColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_41()
            {
                base[this.tJ_ExcavationDataTable_0.dateEndOrderColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_42()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.NumPermissionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_43()
            {
                base[this.tJ_ExcavationDataTable_0.NumPermissionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_44()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.DatePermissionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.tJ_ExcavationDataTable_0.DatePermissionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_46()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.dateUnderAsphaltColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.tJ_ExcavationDataTable_0.dateUnderAsphaltColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_48()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.dateAsphaltColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.tJ_ExcavationDataTable_0.dateAsphaltColumn] = Convert.DBNull;
            }

            public void method_5(int int_0)
            {
                base[this.tJ_ExcavationDataTable_0.idContractorColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.dateEndColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_51()
            {
                base[this.tJ_ExcavationDataTable_0.dateEndColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_52()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.datePayColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_53()
            {
                base[this.tJ_ExcavationDataTable_0.datePayColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_54()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.agreedColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_55()
            {
                base[this.tJ_ExcavationDataTable_0.agreedColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.dateagreedColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_57()
            {
                base[this.tJ_ExcavationDataTable_0.dateagreedColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.workeragreedColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_59()
            {
                base[this.tJ_ExcavationDataTable_0.workeragreedColumn] = Convert.DBNull;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_ExcavationDataTable_0.TypeWorkColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TypeWork' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_60()
            {
                return base.IsNull(this.tJ_ExcavationDataTable_0.idSRColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_61()
            {
                base[this.tJ_ExcavationDataTable_0.idSRColumn] = Convert.DBNull;
            }

            public void method_7(int int_0)
            {
                base[this.tJ_ExcavationDataTable_0.TypeWorkColumn] = int_0;
            }

            public DateTime method_8()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_ExcavationDataTable_0.dateBegOrderColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateBegOrder' in table 'tJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_9(DateTime dateTime_0)
            {
                base[this.tJ_ExcavationDataTable_0.dateBegOrderColumn] = dateTime_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime dateEnd
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tJ_ExcavationDataTable_0.dateEndColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'dateEnd' in table 'tJ_Excavation' is DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tJ_ExcavationDataTable_0.dateEndColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_ExcavationDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_ExcavationDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class313 : DataRow
        {
            private DataSetExcavation.tAbnDataTable tAbnDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class313(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tAbnDataTable_0 = (DataSetExcavation.tAbnDataTable) base.Table;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

        public class Class314 : DataRow
        {
            private DataSetExcavation.tAbnTypeDataTable tAbnTypeDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class314(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tAbnTypeDataTable_0 = (DataSetExcavation.tAbnTypeDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tAbnTypeDataTable_0.typeKontragentColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tAbnTypeDataTable_0.typeKontragentColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idAbn
            {
                get
                {
                    return (int) base[this.tAbnTypeDataTable_0.idAbnColumn];
                }
                set
                {
                    base[this.tAbnTypeDataTable_0.idAbnColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tAbnTypeDataTable_0.idColumn];
                }
                set
                {
                    base[this.tAbnTypeDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class315 : DataRow
        {
            private DataSetExcavation.vJ_ExcavationDataTable vJ_ExcavationDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class315(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vJ_ExcavationDataTable_0 = (DataSetExcavation.vJ_ExcavationDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_ExcavationDataTable_0.numColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'num' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.vJ_ExcavationDataTable_0.numColumn] = int_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.typeWorkscrColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeWorkscr' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_100()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.idSRColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_101()
            {
                base[this.vJ_ExcavationDataTable_0.idSRColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_102()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.SRColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_103()
            {
                base[this.vJ_ExcavationDataTable_0.SRColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_104()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.dateEndPlannedColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_105()
            {
                base[this.vJ_ExcavationDataTable_0.dateEndPlannedColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_106()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.workCommentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_107()
            {
                base[this.vJ_ExcavationDataTable_0.workCommentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_108()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.recoveryColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_109()
            {
                base[this.vJ_ExcavationDataTable_0.recoveryColumn] = Convert.DBNull;
            }

            public void method_11(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.typeWorkscrColumn] = string_0;
            }

            public string method_12()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.typeWorkNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeWorkName' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_13(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.typeWorkNameColumn] = string_0;
            }

            public string method_14()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.regionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'region' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_15(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.regionColumn] = string_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.addressColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'address' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.addressColumn] = string_0;
            }

            public string method_18()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.nameKLColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'nameKL' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_19(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.nameKLColumn] = string_0;
            }

            public DateTime method_2()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_ExcavationDataTable_0.datebegColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'datebeg' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public string method_20()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.statusOrderColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'statusOrder' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_21(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.statusOrderColumn] = string_0;
            }

            public DateTime method_22()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_ExcavationDataTable_0.dateBegOrderColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateBegOrder' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_23(DateTime dateTime_0)
            {
                base[this.vJ_ExcavationDataTable_0.dateBegOrderColumn] = dateTime_0;
            }

            public DateTime method_24()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_ExcavationDataTable_0.dateEndOrderColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateEndOrder' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_25(DateTime dateTime_0)
            {
                base[this.vJ_ExcavationDataTable_0.dateEndOrderColumn] = dateTime_0;
            }

            public string method_26()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.PermissionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Permission' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_27(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.PermissionColumn] = string_0;
            }

            public string method_28()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.StatusWorkColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'StatusWork' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_29(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.StatusWorkColumn] = string_0;
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.vJ_ExcavationDataTable_0.datebegColumn] = dateTime_0;
            }

            public DateTime method_30()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_ExcavationDataTable_0.dateUnderAsphaltColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateUnderAsphalt' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_31(DateTime dateTime_0)
            {
                base[this.vJ_ExcavationDataTable_0.dateUnderAsphaltColumn] = dateTime_0;
            }

            public DateTime method_32()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_ExcavationDataTable_0.dateAsphaltColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateAsphalt' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_33(DateTime dateTime_0)
            {
                base[this.vJ_ExcavationDataTable_0.dateAsphaltColumn] = dateTime_0;
            }

            public DateTime method_34()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_ExcavationDataTable_0.datePayColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'datePay' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_35(DateTime dateTime_0)
            {
                base[this.vJ_ExcavationDataTable_0.datePayColumn] = dateTime_0;
            }

            public DateTime method_36()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_ExcavationDataTable_0.dateagreedColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateagreed' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_37(DateTime dateTime_0)
            {
                base[this.vJ_ExcavationDataTable_0.dateagreedColumn] = dateTime_0;
            }

            public int method_38()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_ExcavationDataTable_0.workeragreedColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'workeragreed' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return num;
            }

            public void method_39(int int_0)
            {
                base[this.vJ_ExcavationDataTable_0.workeragreedColumn] = int_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_ExcavationDataTable_0.idcontractorColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idcontractor' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return num;
            }

            public bool method_40()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.vJ_ExcavationDataTable_0.agreedColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'agreed' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return flag;
            }

            public void method_41(bool bool_0)
            {
                base[this.vJ_ExcavationDataTable_0.agreedColumn] = bool_0;
            }

            public string method_42()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.DamageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Damage' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_43(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.DamageColumn] = string_0;
            }

            public int method_44()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_ExcavationDataTable_0.idSRColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idSR' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return num;
            }

            public void method_45(int int_0)
            {
                base[this.vJ_ExcavationDataTable_0.idSRColumn] = int_0;
            }

            public string method_46()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.SRColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'SR' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_47(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.SRColumn] = string_0;
            }

            public DateTime method_48()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_ExcavationDataTable_0.dateEndPlannedColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateEndPlanned' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return time;
            }

            public void method_49(DateTime dateTime_0)
            {
                base[this.vJ_ExcavationDataTable_0.dateEndPlannedColumn] = dateTime_0;
            }

            public void method_5(int int_0)
            {
                base[this.vJ_ExcavationDataTable_0.idcontractorColumn] = int_0;
            }

            public string method_50()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.workCommentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'workComment' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_51(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.workCommentColumn] = string_0;
            }

            public string method_52()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.recoveryColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'recovery' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            public void method_53(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.recoveryColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_54()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.numColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.vJ_ExcavationDataTable_0.numColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.datebegColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_57()
            {
                base[this.vJ_ExcavationDataTable_0.datebegColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.idcontractorColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_59()
            {
                base[this.vJ_ExcavationDataTable_0.idcontractorColumn] = Convert.DBNull;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationDataTable_0.nameContractorColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'nameContractor' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_60()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.nameContractorColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_61()
            {
                base[this.vJ_ExcavationDataTable_0.nameContractorColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_62()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.typeworkColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_63()
            {
                base[this.vJ_ExcavationDataTable_0.typeworkColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_64()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.typeWorkscrColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_65()
            {
                base[this.vJ_ExcavationDataTable_0.typeWorkscrColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_66()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.typeWorkNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_67()
            {
                base[this.vJ_ExcavationDataTable_0.typeWorkNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_68()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.regionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_69()
            {
                base[this.vJ_ExcavationDataTable_0.regionColumn] = Convert.DBNull;
            }

            public void method_7(string string_0)
            {
                base[this.vJ_ExcavationDataTable_0.nameContractorColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_70()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.addressColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_71()
            {
                base[this.vJ_ExcavationDataTable_0.addressColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_72()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.nameKLColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_73()
            {
                base[this.vJ_ExcavationDataTable_0.nameKLColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_74()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.statusOrderColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_75()
            {
                base[this.vJ_ExcavationDataTable_0.statusOrderColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_76()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.dateBegOrderColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_77()
            {
                base[this.vJ_ExcavationDataTable_0.dateBegOrderColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_78()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.dateEndOrderColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_79()
            {
                base[this.vJ_ExcavationDataTable_0.dateEndOrderColumn] = Convert.DBNull;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_ExcavationDataTable_0.typeworkColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typework' in table 'vJ_Excavation' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_80()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.PermissionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_81()
            {
                base[this.vJ_ExcavationDataTable_0.PermissionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_82()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.StatusWorkColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_83()
            {
                base[this.vJ_ExcavationDataTable_0.StatusWorkColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_84()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.dateUnderAsphaltColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_85()
            {
                base[this.vJ_ExcavationDataTable_0.dateUnderAsphaltColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_86()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.dateAsphaltColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_87()
            {
                base[this.vJ_ExcavationDataTable_0.dateAsphaltColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_88()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.dateEndColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_89()
            {
                base[this.vJ_ExcavationDataTable_0.dateEndColumn] = Convert.DBNull;
            }

            public void method_9(int int_0)
            {
                base[this.vJ_ExcavationDataTable_0.typeworkColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_90()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.datePayColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_91()
            {
                base[this.vJ_ExcavationDataTable_0.datePayColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_92()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.dateagreedColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_93()
            {
                base[this.vJ_ExcavationDataTable_0.dateagreedColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_94()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.workeragreedColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_95()
            {
                base[this.vJ_ExcavationDataTable_0.workeragreedColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_96()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.agreedColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_97()
            {
                base[this.vJ_ExcavationDataTable_0.agreedColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_98()
            {
                return base.IsNull(this.vJ_ExcavationDataTable_0.DamageColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_99()
            {
                base[this.vJ_ExcavationDataTable_0.DamageColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime dateEnd
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.vJ_ExcavationDataTable_0.dateEndColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'dateEnd' in table 'vJ_Excavation' is DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.vJ_ExcavationDataTable_0.dateEndColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vJ_ExcavationDataTable_0.idColumn];
                }
                set
                {
                    base[this.vJ_ExcavationDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class316 : DataRow
        {
            private DataSetExcavation.vJ_ExcavationSchmObjDataTable vJ_ExcavationSchmObjDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class316(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vJ_ExcavationSchmObjDataTable_0 = (DataSetExcavation.vJ_ExcavationSchmObjDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vJ_ExcavationSchmObjDataTable_0.idExcavationColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vJ_ExcavationSchmObjDataTable_0.idExcavationColumn] = int_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_ExcavationSchmObjDataTable_0.idKLColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idKL' in table 'vJ_ExcavationSchmObj' is DBNull.", exception);
                }
                return num;
            }

            public void method_3(int int_0)
            {
                base[this.vJ_ExcavationSchmObjDataTable_0.idKLColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_4()
            {
                return base.IsNull(this.vJ_ExcavationSchmObjDataTable_0.nameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5()
            {
                base[this.vJ_ExcavationSchmObjDataTable_0.nameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.vJ_ExcavationSchmObjDataTable_0.idKLColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_7()
            {
                base[this.vJ_ExcavationSchmObjDataTable_0.idKLColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vJ_ExcavationSchmObjDataTable_0.idColumn];
                }
                set
                {
                    base[this.vJ_ExcavationSchmObjDataTable_0.idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string name
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vJ_ExcavationSchmObjDataTable_0.nameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'name' in table 'vJ_ExcavationSchmObj' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vJ_ExcavationSchmObjDataTable_0.nameColumn] = value;
                }
            }
        }

        public class Class317 : DataRow
        {
            private DataSetExcavation.tJ_ExcavationSchmObjDataTable tJ_ExcavationSchmObjDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class317(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_ExcavationSchmObjDataTable_0 = (DataSetExcavation.tJ_ExcavationSchmObjDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_ExcavationSchmObjDataTable_0.idExcavationColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_ExcavationSchmObjDataTable_0.idExcavationColumn] = int_0;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_ExcavationSchmObjDataTable_0.NameKLColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NameKL' in table 'tJ_ExcavationSchmObj' is DBNull.", exception);
                }
                return str;
            }

            public void method_3(string string_0)
            {
                base[this.tJ_ExcavationSchmObjDataTable_0.NameKLColumn] = string_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_ExcavationSchmObjDataTable_0.idKLColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idKL' in table 'tJ_ExcavationSchmObj' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.tJ_ExcavationSchmObjDataTable_0.idKLColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.tJ_ExcavationSchmObjDataTable_0.NameKLColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.tJ_ExcavationSchmObjDataTable_0.NameKLColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tJ_ExcavationSchmObjDataTable_0.idKLColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_9()
            {
                base[this.tJ_ExcavationSchmObjDataTable_0.idKLColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_ExcavationSchmObjDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_ExcavationSchmObjDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class318 : DataRow
        {
            private DataSetExcavation.tJ_ExcavationStatusDataTable tJ_ExcavationStatusDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class318(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_ExcavationStatusDataTable_0 = (DataSetExcavation.tJ_ExcavationStatusDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_ExcavationStatusDataTable_0.idExcavationColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_ExcavationStatusDataTable_0.idExcavationColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.tJ_ExcavationStatusDataTable_0.dateChangeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.tJ_ExcavationStatusDataTable_0.dateChangeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.tJ_ExcavationStatusDataTable_0.dateElongationColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_13()
            {
                base[this.tJ_ExcavationStatusDataTable_0.dateElongationColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_14()
            {
                return base.IsNull(this.tJ_ExcavationStatusDataTable_0.CommentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_15()
            {
                base[this.tJ_ExcavationStatusDataTable_0.CommentColumn] = Convert.DBNull;
            }

            public short method_2()
            {
                return (short) base[this.tJ_ExcavationStatusDataTable_0.idTypeColumn];
            }

            public void method_3(short short_0)
            {
                base[this.tJ_ExcavationStatusDataTable_0.idTypeColumn] = short_0;
            }

            public int method_4()
            {
                return (int) base[this.tJ_ExcavationStatusDataTable_0.idStatusColumn];
            }

            public void method_5(int int_0)
            {
                base[this.tJ_ExcavationStatusDataTable_0.idStatusColumn] = int_0;
            }

            public DateTime method_6()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_ExcavationStatusDataTable_0.dateChangeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateChange' in table 'tJ_ExcavationStatus' is DBNull.", exception);
                }
                return time;
            }

            public void method_7(DateTime dateTime_0)
            {
                base[this.tJ_ExcavationStatusDataTable_0.dateChangeColumn] = dateTime_0;
            }

            public DateTime method_8()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_ExcavationStatusDataTable_0.dateElongationColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateElongation' in table 'tJ_ExcavationStatus' is DBNull.", exception);
                }
                return time;
            }

            public void method_9(DateTime dateTime_0)
            {
                base[this.tJ_ExcavationStatusDataTable_0.dateElongationColumn] = dateTime_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tJ_ExcavationStatusDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'tJ_ExcavationStatus' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tJ_ExcavationStatusDataTable_0.CommentColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_ExcavationStatusDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_ExcavationStatusDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class319 : DataRow
        {
            private DataSetExcavation.vJ_ExcavationStatusDataTable vJ_ExcavationStatusDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class319(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vJ_ExcavationStatusDataTable_0 = (DataSetExcavation.vJ_ExcavationStatusDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vJ_ExcavationStatusDataTable_0.idExcavationColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vJ_ExcavationStatusDataTable_0.idExcavationColumn] = int_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationStatusDataTable_0.statusnameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'statusname' in table 'vJ_ExcavationStatus' is DBNull.", exception);
                }
                return str;
            }

            public void method_11(string string_0)
            {
                base[this.vJ_ExcavationStatusDataTable_0.statusnameColumn] = string_0;
            }

            public decimal method_12()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.vJ_ExcavationStatusDataTable_0.statusvalueColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'statusvalue' in table 'vJ_ExcavationStatus' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(decimal decimal_0)
            {
                base[this.vJ_ExcavationStatusDataTable_0.statusvalueColumn] = decimal_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.vJ_ExcavationStatusDataTable_0.dateChangeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_15()
            {
                base[this.vJ_ExcavationStatusDataTable_0.dateChangeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.vJ_ExcavationStatusDataTable_0.dateElongationColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_17()
            {
                base[this.vJ_ExcavationStatusDataTable_0.dateElongationColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.vJ_ExcavationStatusDataTable_0.statusnameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.vJ_ExcavationStatusDataTable_0.statusnameColumn] = Convert.DBNull;
            }

            public short method_2()
            {
                return (short) base[this.vJ_ExcavationStatusDataTable_0.idTypeColumn];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.vJ_ExcavationStatusDataTable_0.statusvalueColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_21()
            {
                base[this.vJ_ExcavationStatusDataTable_0.statusvalueColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.vJ_ExcavationStatusDataTable_0.CommentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.vJ_ExcavationStatusDataTable_0.CommentColumn] = Convert.DBNull;
            }

            public void method_3(short short_0)
            {
                base[this.vJ_ExcavationStatusDataTable_0.idTypeColumn] = short_0;
            }

            public int method_4()
            {
                return (int) base[this.vJ_ExcavationStatusDataTable_0.idStatusColumn];
            }

            public void method_5(int int_0)
            {
                base[this.vJ_ExcavationStatusDataTable_0.idStatusColumn] = int_0;
            }

            public DateTime method_6()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_ExcavationStatusDataTable_0.dateChangeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateChange' in table 'vJ_ExcavationStatus' is DBNull.", exception);
                }
                return time;
            }

            public void method_7(DateTime dateTime_0)
            {
                base[this.vJ_ExcavationStatusDataTable_0.dateChangeColumn] = dateTime_0;
            }

            public DateTime method_8()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_ExcavationStatusDataTable_0.dateElongationColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateElongation' in table 'vJ_ExcavationStatus' is DBNull.", exception);
                }
                return time;
            }

            public void method_9(DateTime dateTime_0)
            {
                base[this.vJ_ExcavationStatusDataTable_0.dateElongationColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vJ_ExcavationStatusDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'vJ_ExcavationStatus' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vJ_ExcavationStatusDataTable_0.CommentColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vJ_ExcavationStatusDataTable_0.idColumn];
                }
                set
                {
                    base[this.vJ_ExcavationStatusDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class320 : DataRow
        {
            private DataSetExcavation.vJ_ExcavationSurfaceDataTable vJ_ExcavationSurfaceDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class320(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vJ_ExcavationSurfaceDataTable_0 = (DataSetExcavation.vJ_ExcavationSurfaceDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vJ_ExcavationSurfaceDataTable_0.idExcavationColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vJ_ExcavationSurfaceDataTable_0.idExcavationColumn] = int_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationSurfaceDataTable_0.surSocrNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'surSocrName' in table 'vJ_ExcavationSurface' is DBNull.", exception);
                }
                return str;
            }

            public void method_11(string string_0)
            {
                base[this.vJ_ExcavationSurfaceDataTable_0.surSocrNameColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.vJ_ExcavationSurfaceDataTable_0.ValueColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.vJ_ExcavationSurfaceDataTable_0.ValueColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_14()
            {
                return base.IsNull(this.vJ_ExcavationSurfaceDataTable_0.unitColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.vJ_ExcavationSurfaceDataTable_0.unitColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.vJ_ExcavationSurfaceDataTable_0.commentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.vJ_ExcavationSurfaceDataTable_0.commentColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.vJ_ExcavationSurfaceDataTable_0.surNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.vJ_ExcavationSurfaceDataTable_0.surNameColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                return (int) base[this.vJ_ExcavationSurfaceDataTable_0.idTypeColumn];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.vJ_ExcavationSurfaceDataTable_0.surSocrNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_21()
            {
                base[this.vJ_ExcavationSurfaceDataTable_0.surSocrNameColumn] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.vJ_ExcavationSurfaceDataTable_0.idTypeColumn] = int_0;
            }

            public int method_4()
            {
                return (int) base[this.vJ_ExcavationSurfaceDataTable_0.idSurfaceColumn];
            }

            public void method_5(int int_0)
            {
                base[this.vJ_ExcavationSurfaceDataTable_0.idSurfaceColumn] = int_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationSurfaceDataTable_0.unitColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'unit' in table 'vJ_ExcavationSurface' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.vJ_ExcavationSurfaceDataTable_0.unitColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationSurfaceDataTable_0.surNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'surName' in table 'vJ_ExcavationSurface' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.vJ_ExcavationSurfaceDataTable_0.surNameColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vJ_ExcavationSurfaceDataTable_0.commentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'comment' in table 'vJ_ExcavationSurface' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vJ_ExcavationSurfaceDataTable_0.commentColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vJ_ExcavationSurfaceDataTable_0.idColumn];
                }
                set
                {
                    base[this.vJ_ExcavationSurfaceDataTable_0.idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double Value
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.vJ_ExcavationSurfaceDataTable_0.ValueColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Value' in table 'vJ_ExcavationSurface' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vJ_ExcavationSurfaceDataTable_0.ValueColumn] = value;
                }
            }
        }

        public class Class321 : DataRow
        {
            private DataSetExcavation.tJ_ExcavationFileDataTable tJ_ExcavationFileDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class321(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_ExcavationFileDataTable_0 = (DataSetExcavation.tJ_ExcavationFileDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_ExcavationFileDataTable_0.idExcavationColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_ExcavationFileDataTable_0.idExcavationColumn] = int_0;
            }

            public int method_2()
            {
                return (int) base[this.tJ_ExcavationFileDataTable_0.typeFileColumn];
            }

            public void method_3(int int_0)
            {
                base[this.tJ_ExcavationFileDataTable_0.typeFileColumn] = int_0;
            }

            public string method_4()
            {
                return (string) base[this.tJ_ExcavationFileDataTable_0.FileNameColumn];
            }

            public void method_5(string string_0)
            {
                base[this.tJ_ExcavationFileDataTable_0.FileNameColumn] = string_0;
            }

            public byte[] method_6()
            {
                byte[] buffer;
                try
                {
                    buffer = (byte[]) base[this.tJ_ExcavationFileDataTable_0.FileColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'File' in table 'tJ_ExcavationFile' is DBNull.", exception);
                }
                return buffer;
            }

            public void method_7(byte[] byte_0)
            {
                base[this.tJ_ExcavationFileDataTable_0.FileColumn] = byte_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tJ_ExcavationFileDataTable_0.FileColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_9()
            {
                base[this.tJ_ExcavationFileDataTable_0.FileColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_ExcavationFileDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_ExcavationFileDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class322 : DataRow
        {
            private DataSetExcavation.vJ_ExcavationFileDataTable vJ_ExcavationFileDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class322(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vJ_ExcavationFileDataTable_0 = (DataSetExcavation.vJ_ExcavationFileDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vJ_ExcavationFileDataTable_0.idExcavationColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vJ_ExcavationFileDataTable_0.idExcavationColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.vJ_ExcavationFileDataTable_0.FileColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.vJ_ExcavationFileDataTable_0.FileColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.vJ_ExcavationFileDataTable_0.typeFileNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.vJ_ExcavationFileDataTable_0.typeFileNameColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                return (int) base[this.vJ_ExcavationFileDataTable_0.typeFileColumn];
            }

            public void method_3(int int_0)
            {
                base[this.vJ_ExcavationFileDataTable_0.typeFileColumn] = int_0;
            }

            public string method_4()
            {
                return (string) base[this.vJ_ExcavationFileDataTable_0.FileNameColumn];
            }

            public void method_5(string string_0)
            {
                base[this.vJ_ExcavationFileDataTable_0.FileNameColumn] = string_0;
            }

            public byte[] method_6()
            {
                byte[] buffer;
                try
                {
                    buffer = (byte[]) base[this.vJ_ExcavationFileDataTable_0.FileColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'File' in table 'vJ_ExcavationFile' is DBNull.", exception);
                }
                return buffer;
            }

            public void method_7(byte[] byte_0)
            {
                base[this.vJ_ExcavationFileDataTable_0.FileColumn] = byte_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_ExcavationFileDataTable_0.typeFileNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeFileName' in table 'vJ_ExcavationFile' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.vJ_ExcavationFileDataTable_0.typeFileNameColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vJ_ExcavationFileDataTable_0.idColumn];
                }
                set
                {
                    base[this.vJ_ExcavationFileDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class323 : DataRow
        {
            private DataSetExcavation.vR_KladrStreetDataTable vR_KladrStreetDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class323(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vR_KladrStreetDataTable_0 = (DataSetExcavation.vR_KladrStreetDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vR_KladrStreetDataTable_0.KladrObjIdColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vR_KladrStreetDataTable_0.KladrObjIdColumn] = int_0;
            }

            public bool method_10()
            {
                return (bool) base[this.vR_KladrStreetDataTable_0.DeletedColumn];
            }

            public void method_11(bool bool_0)
            {
                base[this.vR_KladrStreetDataTable_0.DeletedColumn] = bool_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.vR_KladrStreetDataTable_0.NameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.vR_KladrStreetDataTable_0.NameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_14()
            {
                return base.IsNull(this.vR_KladrStreetDataTable_0.SocrColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.vR_KladrStreetDataTable_0.SocrColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.vR_KladrStreetDataTable_0.KladrCodeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.vR_KladrStreetDataTable_0.KladrCodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.vR_KladrStreetDataTable_0.IndexColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.vR_KladrStreetDataTable_0.IndexColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.vR_KladrStreetDataTable_0.SocrColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Socr' in table 'vR_KladrStreet' is DBNull.", exception);
                }
                return str;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_20()
            {
                return base.IsNull(this.vR_KladrStreetDataTable_0.GNINMBColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.vR_KladrStreetDataTable_0.GNINMBColumn] = Convert.DBNull;
            }

            public void method_3(string string_0)
            {
                base[this.vR_KladrStreetDataTable_0.SocrColumn] = string_0;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.vR_KladrStreetDataTable_0.KladrCodeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'KladrCode' in table 'vR_KladrStreet' is DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.vR_KladrStreetDataTable_0.KladrCodeColumn] = string_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vR_KladrStreetDataTable_0.IndexColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Index' in table 'vR_KladrStreet' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.vR_KladrStreetDataTable_0.IndexColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vR_KladrStreetDataTable_0.GNINMBColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'GNINMB' in table 'vR_KladrStreet' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.vR_KladrStreetDataTable_0.GNINMBColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Id
            {
                get
                {
                    return (int) base[this.vR_KladrStreetDataTable_0.IdColumn];
                }
                set
                {
                    base[this.vR_KladrStreetDataTable_0.IdColumn] = value;
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
                        str = (string) base[this.vR_KladrStreetDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'vR_KladrStreet' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vR_KladrStreetDataTable_0.NameColumn] = value;
                }
            }
        }

        public class Class324 : DataRow
        {
            private DataSetExcavation.vAbnTypeDataTable vAbnTypeDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class324(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vAbnTypeDataTable_0 = (DataSetExcavation.vAbnTypeDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vAbnTypeDataTable_0.CodeAbonentColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vAbnTypeDataTable_0.CodeAbonentColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_10()
            {
                return base.IsNull(this.vAbnTypeDataTable_0.idColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_11()
            {
                base[this.vAbnTypeDataTable_0.idColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.vAbnTypeDataTable_0.NameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.vAbnTypeDataTable_0.NameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.vAbnTypeDataTable_0.typeKontragentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.vAbnTypeDataTable_0.typeKontragentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_16()
            {
                return base.IsNull(this.vAbnTypeDataTable_0.typeKontragentNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.vAbnTypeDataTable_0.typeKontragentNameColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                return (int) base[this.vAbnTypeDataTable_0.TypeAbnColumn];
            }

            public void method_3(int int_0)
            {
                base[this.vAbnTypeDataTable_0.TypeAbnColumn] = int_0;
            }

            public bool method_4()
            {
                return (bool) base[this.vAbnTypeDataTable_0.DeletedColumn];
            }

            public void method_5(bool bool_0)
            {
                base[this.vAbnTypeDataTable_0.DeletedColumn] = bool_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.vAbnTypeDataTable_0.typeKontragentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeKontragent' in table 'vAbnType' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.vAbnTypeDataTable_0.typeKontragentColumn] = int_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vAbnTypeDataTable_0.typeKontragentNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeKontragentName' in table 'vAbnType' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.vAbnTypeDataTable_0.typeKontragentNameColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idAbn
            {
                get
                {
                    return (int) base[this.vAbnTypeDataTable_0.idAbnColumn];
                }
                set
                {
                    base[this.vAbnTypeDataTable_0.idAbnColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int idWorker
            {
                get
                {
                    return (int) base[this.vAbnTypeDataTable_0.idWorkerColumn];
                }
                set
                {
                    base[this.vAbnTypeDataTable_0.idWorkerColumn] = value;
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
                        num = (int) base[this.vAbnTypeDataTable_0.idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'id' in table 'vAbnType' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vAbnTypeDataTable_0.idColumn] = value;
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
                        str = (string) base[this.vAbnTypeDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'vAbnType' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vAbnTypeDataTable_0.NameColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate169(object sender, DataSetExcavation.EventArgs167 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate170(object sender, DataSetExcavation.EventArgs168 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate171(object sender, DataSetExcavation.EventArgs169 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate172(object sender, DataSetExcavation.EventArgs170 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate173(object sender, DataSetExcavation.EventArgs171 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate174(object sender, DataSetExcavation.EventArgs172 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate175(object sender, DataSetExcavation.EventArgs173 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate176(object sender, DataSetExcavation.EventArgs174 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate177(object sender, DataSetExcavation.EventArgs175 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate178(object sender, DataSetExcavation.EventArgs176 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate179(object sender, DataSetExcavation.EventArgs177 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate180(object sender, DataSetExcavation.EventArgs178 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate181(object sender, DataSetExcavation.EventArgs179 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate182(object sender, DataSetExcavation.EventArgs180 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate183(object sender, DataSetExcavation.EventArgs181 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate184(object sender, DataSetExcavation.EventArgs182 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate185(object sender, DataSetExcavation.EventArgs183 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs167 : EventArgs
        {
            private DataSetExcavation.Class308 class308_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs167(DataSetExcavation.Class308 class308_1, DataRowAction dataRowAction_1)
            {
                this.class308_0 = class308_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class308 method_0()
            {
                return this.class308_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs168 : EventArgs
        {
            private DataSetExcavation.Class309 class309_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs168(DataSetExcavation.Class309 class309_1, DataRowAction dataRowAction_1)
            {
                this.class309_0 = class309_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class309 method_0()
            {
                return this.class309_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs169 : EventArgs
        {
            private DataSetExcavation.Class310 class310_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs169(DataSetExcavation.Class310 class310_1, DataRowAction dataRowAction_1)
            {
                this.class310_0 = class310_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class310 method_0()
            {
                return this.class310_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs170 : EventArgs
        {
            private DataSetExcavation.Class311 class311_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs170(DataSetExcavation.Class311 class311_1, DataRowAction dataRowAction_1)
            {
                this.class311_0 = class311_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class311 method_0()
            {
                return this.class311_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs171 : EventArgs
        {
            private DataSetExcavation.Class312 class312_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs171(DataSetExcavation.Class312 class312_1, DataRowAction dataRowAction_1)
            {
                this.class312_0 = class312_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class312 method_0()
            {
                return this.class312_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs172 : EventArgs
        {
            private DataSetExcavation.Class313 class313_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs172(DataSetExcavation.Class313 class313_1, DataRowAction dataRowAction_1)
            {
                this.class313_0 = class313_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class313 method_0()
            {
                return this.class313_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs173 : EventArgs
        {
            private DataSetExcavation.Class314 class314_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs173(DataSetExcavation.Class314 class314_1, DataRowAction dataRowAction_1)
            {
                this.class314_0 = class314_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class314 method_0()
            {
                return this.class314_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs174 : EventArgs
        {
            private DataSetExcavation.Class315 class315_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs174(DataSetExcavation.Class315 class315_1, DataRowAction dataRowAction_1)
            {
                this.class315_0 = class315_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class315 method_0()
            {
                return this.class315_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs175 : EventArgs
        {
            private DataSetExcavation.Class316 class316_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs175(DataSetExcavation.Class316 class316_1, DataRowAction dataRowAction_1)
            {
                this.class316_0 = class316_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class316 method_0()
            {
                return this.class316_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs176 : EventArgs
        {
            private DataSetExcavation.Class317 class317_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs176(DataSetExcavation.Class317 class317_1, DataRowAction dataRowAction_1)
            {
                this.class317_0 = class317_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class317 method_0()
            {
                return this.class317_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs177 : EventArgs
        {
            private DataSetExcavation.Class318 class318_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs177(DataSetExcavation.Class318 class318_1, DataRowAction dataRowAction_1)
            {
                this.class318_0 = class318_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class318 method_0()
            {
                return this.class318_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs178 : EventArgs
        {
            private DataSetExcavation.Class319 class319_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs178(DataSetExcavation.Class319 class319_1, DataRowAction dataRowAction_1)
            {
                this.class319_0 = class319_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class319 method_0()
            {
                return this.class319_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs179 : EventArgs
        {
            private DataSetExcavation.Class320 class320_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs179(DataSetExcavation.Class320 class320_1, DataRowAction dataRowAction_1)
            {
                this.class320_0 = class320_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class320 method_0()
            {
                return this.class320_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs180 : EventArgs
        {
            private DataSetExcavation.Class321 class321_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs180(DataSetExcavation.Class321 class321_1, DataRowAction dataRowAction_1)
            {
                this.class321_0 = class321_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class321 method_0()
            {
                return this.class321_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs181 : EventArgs
        {
            private DataSetExcavation.Class322 class322_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs181(DataSetExcavation.Class322 class322_1, DataRowAction dataRowAction_1)
            {
                this.class322_0 = class322_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class322 method_0()
            {
                return this.class322_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs182 : EventArgs
        {
            private DataSetExcavation.Class323 class323_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs182(DataSetExcavation.Class323 class323_1, DataRowAction dataRowAction_1)
            {
                this.class323_0 = class323_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class323 method_0()
            {
                return this.class323_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs183 : EventArgs
        {
            private DataSetExcavation.Class324 class324_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs183(DataSetExcavation.Class324 class324_1, DataRowAction dataRowAction_1)
            {
                this.class324_0 = class324_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetExcavation.Class324 method_0()
            {
                return this.class324_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tAbnDataTable : TypedTableBase<DataSetExcavation.Class313>
        {
            private DataColumn columnCodeAbonent;
            private DataColumn columnDeleted;
            private DataColumn columnid;
            private DataColumn columnidWorker;
            private DataColumn columnName;
            private DataColumn columnTypeAbn;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate174 tAbnRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate174 tAbnRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate174 tAbnRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate174 tAbnRowDeleting;

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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tAbnDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetExcavation.tAbnDataTable table1 = (DataSetExcavation.tAbnDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.tAbnDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class313);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetExcavation.Class313 class313_0)
            {
                base.Rows.Add(class313_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class313 method_1(int int_0, string string_0, int int_1, int int_2, bool bool_0)
            {
                DataSetExcavation.Class313 row = (DataSetExcavation.Class313) base.NewRow();
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
            public DataSetExcavation.Class313 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class313) base.Rows.Find(keys);
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
            public DataSetExcavation.Class313 method_5()
            {
                return (DataSetExcavation.Class313) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetExcavation.Class313 class313_0)
            {
                base.Rows.Remove(class313_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class313(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tAbnRowChanged != null)
                {
                    this.tAbnRowChanged(this, new DataSetExcavation.EventArgs172((DataSetExcavation.Class313) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tAbnRowChanging != null)
                {
                    this.tAbnRowChanging(this, new DataSetExcavation.EventArgs172((DataSetExcavation.Class313) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tAbnRowDeleted != null)
                {
                    this.tAbnRowDeleted(this, new DataSetExcavation.EventArgs172((DataSetExcavation.Class313) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tAbnRowDeleting != null)
                {
                    this.tAbnRowDeleting(this, new DataSetExcavation.EventArgs172((DataSetExcavation.Class313) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tAbnDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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
            public DataSetExcavation.Class313 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class313) base.Rows[int_0];
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
        public class tAbnTypeDataTable : TypedTableBase<DataSetExcavation.Class314>
        {
            private DataColumn columnid;
            private DataColumn columnidAbn;
            private DataColumn columntypeKontragent;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate175 tAbnTypeRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate175 tAbnTypeRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate175 tAbnTypeRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate175 tAbnTypeRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tAbnTypeDataTable()
            {
                base.TableName = "tAbnType";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tAbnTypeDataTable(DataTable dataTable_0)
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
            protected tAbnTypeDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetExcavation.tAbnTypeDataTable table1 = (DataSetExcavation.tAbnTypeDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.tAbnTypeDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class314);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetExcavation.Class314 class314_0)
            {
                base.Rows.Add(class314_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class314 method_1(int int_0, int int_1)
            {
                DataSetExcavation.Class314 row = (DataSetExcavation.Class314) base.NewRow();
                object[] objArray1 = new object[3];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class314 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class314) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidAbn = base.Columns["idAbn"];
                this.columntypeKontragent = base.Columns["typeKontragent"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
                this.columntypeKontragent = new DataColumn("typeKontragent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columntypeKontragent);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidAbn.AllowDBNull = false;
                this.columntypeKontragent.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class314 method_5()
            {
                return (DataSetExcavation.Class314) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetExcavation.Class314 class314_0)
            {
                base.Rows.Remove(class314_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class314(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tAbnTypeRowChanged != null)
                {
                    this.tAbnTypeRowChanged(this, new DataSetExcavation.EventArgs173((DataSetExcavation.Class314) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tAbnTypeRowChanging != null)
                {
                    this.tAbnTypeRowChanging(this, new DataSetExcavation.EventArgs173((DataSetExcavation.Class314) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tAbnTypeRowDeleted != null)
                {
                    this.tAbnTypeRowDeleted(this, new DataSetExcavation.EventArgs173((DataSetExcavation.Class314) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tAbnTypeRowDeleting != null)
                {
                    this.tAbnTypeRowDeleting(this, new DataSetExcavation.EventArgs173((DataSetExcavation.Class314) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tAbnTypeDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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
            public DataColumn idAbnColumn
            {
                get
                {
                    return this.columnidAbn;
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
            public DataSetExcavation.Class314 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class314) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeKontragentColumn
            {
                get
                {
                    return this.columntypeKontragent;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_ExcavationAddressDataTable : TypedTableBase<DataSetExcavation.Class308>
        {
            private DataColumn columnComment;
            private DataColumn columnHouse;
            private DataColumn columnid;
            private DataColumn columnidExcavation;
            private DataColumn columnidRegion;
            private DataColumn columnidStreet;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate169 tJ_ExcavationAddressRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate169 tJ_ExcavationAddressRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate169 tJ_ExcavationAddressRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate169 tJ_ExcavationAddressRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_ExcavationAddressDataTable()
            {
                base.TableName = "tJ_ExcavationAddress";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_ExcavationAddressDataTable(DataTable dataTable_0)
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
            protected tJ_ExcavationAddressDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetExcavation.tJ_ExcavationAddressDataTable table1 = (DataSetExcavation.tJ_ExcavationAddressDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.tJ_ExcavationAddressDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class308);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetExcavation.Class308 class308_0)
            {
                base.Rows.Add(class308_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class308 method_1(int int_0, int int_1, int int_2, string string_0, string string_1)
            {
                DataSetExcavation.Class308 row = (DataSetExcavation.Class308) base.NewRow();
                object[] objArray1 = new object[6];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = int_2;
                objArray1[4] = string_0;
                objArray1[5] = string_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class308 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class308) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidExcavation = base.Columns["idExcavation"];
                this.columnidRegion = base.Columns["idRegion"];
                this.columnidStreet = base.Columns["idStreet"];
                this.columnHouse = base.Columns["House"];
                this.columnComment = base.Columns["Comment"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidExcavation = new DataColumn("idExcavation", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidExcavation);
                this.columnidRegion = new DataColumn("idRegion", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidRegion);
                this.columnidStreet = new DataColumn("idStreet", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidStreet);
                this.columnHouse = new DataColumn("House", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnHouse);
                this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComment);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidExcavation.AllowDBNull = false;
                this.columnHouse.MaxLength = 50;
                this.columnComment.MaxLength = 0x100;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class308 method_5()
            {
                return (DataSetExcavation.Class308) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetExcavation.Class308 class308_0)
            {
                base.Rows.Remove(class308_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class308(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationAddressRowChanged != null)
                {
                    this.tJ_ExcavationAddressRowChanged(this, new DataSetExcavation.EventArgs167((DataSetExcavation.Class308) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationAddressRowChanging != null)
                {
                    this.tJ_ExcavationAddressRowChanging(this, new DataSetExcavation.EventArgs167((DataSetExcavation.Class308) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationAddressRowDeleted != null)
                {
                    this.tJ_ExcavationAddressRowDeleted(this, new DataSetExcavation.EventArgs167((DataSetExcavation.Class308) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationAddressRowDeleting != null)
                {
                    this.tJ_ExcavationAddressRowDeleting(this, new DataSetExcavation.EventArgs167((DataSetExcavation.Class308) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_ExcavationAddressDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn HouseColumn
            {
                get
                {
                    return this.columnHouse;
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
            public DataColumn idExcavationColumn
            {
                get
                {
                    return this.columnidExcavation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idRegionColumn
            {
                get
                {
                    return this.columnidRegion;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idStreetColumn
            {
                get
                {
                    return this.columnidStreet;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class308 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class308) base.Rows[int_0];
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_ExcavationDataTable : TypedTableBase<DataSetExcavation.Class312>
        {
            private DataColumn columnagreed;
            private DataColumn columndateagreed;
            private DataColumn columndateAsphalt;
            private DataColumn columndateBeg;
            private DataColumn columndateBegOrder;
            private DataColumn columndateEnd;
            private DataColumn columndateEndOrder;
            private DataColumn columndatePay;
            private DataColumn columnDatePermission;
            private DataColumn columndateUnderAsphalt;
            private DataColumn columnid;
            private DataColumn columnidContractor;
            private DataColumn columnidSR;
            private DataColumn columnnum;
            private DataColumn columnNumPermission;
            private DataColumn columnTypeWork;
            private DataColumn columnworkeragreed;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate173 tJ_ExcavationRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate173 tJ_ExcavationRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate173 tJ_ExcavationRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate173 tJ_ExcavationRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tJ_ExcavationDataTable()
            {
                base.TableName = "tJ_Excavation";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tJ_ExcavationDataTable(DataTable dataTable_0)
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
            protected tJ_ExcavationDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetExcavation.tJ_ExcavationDataTable table1 = (DataSetExcavation.tJ_ExcavationDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.tJ_ExcavationDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class312);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetExcavation.Class312 class312_0)
            {
                base.Rows.Add(class312_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class312 method_1(int int_0, DateTime dateTime_0, int int_1, int int_2, DateTime dateTime_1, DateTime dateTime_2, string string_0, DateTime dateTime_3, DateTime dateTime_4, DateTime dateTime_5, DateTime dateTime_6, DateTime dateTime_7, bool bool_0, DateTime dateTime_8, int int_3, int int_4)
            {
                DataSetExcavation.Class312 row = (DataSetExcavation.Class312) base.NewRow();
                object[] objArray1 = new object[0x11];
                objArray1[1] = int_0;
                objArray1[2] = dateTime_0;
                objArray1[3] = int_1;
                objArray1[4] = int_2;
                objArray1[5] = dateTime_1;
                objArray1[6] = dateTime_2;
                objArray1[7] = string_0;
                objArray1[8] = dateTime_3;
                objArray1[9] = dateTime_4;
                objArray1[10] = dateTime_5;
                objArray1[11] = dateTime_6;
                objArray1[12] = dateTime_7;
                objArray1[13] = bool_0;
                objArray1[14] = dateTime_8;
                objArray1[15] = int_3;
                objArray1[0x10] = int_4;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class312 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class312) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnnum = base.Columns["num"];
                this.columndateBeg = base.Columns["dateBeg"];
                this.columnidContractor = base.Columns["idContractor"];
                this.columnTypeWork = base.Columns["TypeWork"];
                this.columndateBegOrder = base.Columns["dateBegOrder"];
                this.columndateEndOrder = base.Columns["dateEndOrder"];
                this.columnNumPermission = base.Columns["NumPermission"];
                this.columnDatePermission = base.Columns["DatePermission"];
                this.columndateUnderAsphalt = base.Columns["dateUnderAsphalt"];
                this.columndateAsphalt = base.Columns["dateAsphalt"];
                this.columndateEnd = base.Columns["dateEnd"];
                this.columndatePay = base.Columns["datePay"];
                this.columnagreed = base.Columns["agreed"];
                this.columndateagreed = base.Columns["dateagreed"];
                this.columnworkeragreed = base.Columns["workeragreed"];
                this.columnidSR = base.Columns["idSR"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnum = new DataColumn("num", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnum);
                this.columndateBeg = new DataColumn("dateBeg", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateBeg);
                this.columnidContractor = new DataColumn("idContractor", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidContractor);
                this.columnTypeWork = new DataColumn("TypeWork", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnTypeWork);
                this.columndateBegOrder = new DataColumn("dateBegOrder", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateBegOrder);
                this.columndateEndOrder = new DataColumn("dateEndOrder", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateEndOrder);
                this.columnNumPermission = new DataColumn("NumPermission", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNumPermission);
                this.columnDatePermission = new DataColumn("DatePermission", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDatePermission);
                this.columndateUnderAsphalt = new DataColumn("dateUnderAsphalt", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateUnderAsphalt);
                this.columndateAsphalt = new DataColumn("dateAsphalt", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateAsphalt);
                this.columndateEnd = new DataColumn("dateEnd", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateEnd);
                this.columndatePay = new DataColumn("datePay", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndatePay);
                this.columnagreed = new DataColumn("agreed", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnagreed);
                this.columndateagreed = new DataColumn("dateagreed", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateagreed);
                this.columnworkeragreed = new DataColumn("workeragreed", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnworkeragreed);
                this.columnidSR = new DataColumn("idSR", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSR);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnNumPermission.MaxLength = 20;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class312 method_5()
            {
                return (DataSetExcavation.Class312) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetExcavation.Class312 class312_0)
            {
                base.Rows.Remove(class312_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class312(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationRowChanged != null)
                {
                    this.tJ_ExcavationRowChanged(this, new DataSetExcavation.EventArgs171((DataSetExcavation.Class312) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationRowChanging != null)
                {
                    this.tJ_ExcavationRowChanging(this, new DataSetExcavation.EventArgs171((DataSetExcavation.Class312) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationRowDeleted != null)
                {
                    this.tJ_ExcavationRowDeleted(this, new DataSetExcavation.EventArgs171((DataSetExcavation.Class312) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationRowDeleting != null)
                {
                    this.tJ_ExcavationRowDeleting(this, new DataSetExcavation.EventArgs171((DataSetExcavation.Class312) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_ExcavationDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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
            public DataColumn agreedColumn
            {
                get
                {
                    return this.columnagreed;
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
            public DataColumn dateagreedColumn
            {
                get
                {
                    return this.columndateagreed;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateAsphaltColumn
            {
                get
                {
                    return this.columndateAsphalt;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateBegColumn
            {
                get
                {
                    return this.columndateBeg;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateBegOrderColumn
            {
                get
                {
                    return this.columndateBegOrder;
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
            public DataColumn dateEndOrderColumn
            {
                get
                {
                    return this.columndateEndOrder;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn datePayColumn
            {
                get
                {
                    return this.columndatePay;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DatePermissionColumn
            {
                get
                {
                    return this.columnDatePermission;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateUnderAsphaltColumn
            {
                get
                {
                    return this.columndateUnderAsphalt;
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
            public DataColumn idContractorColumn
            {
                get
                {
                    return this.columnidContractor;
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
            public DataSetExcavation.Class312 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class312) base.Rows[int_0];
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
            public DataColumn NumPermissionColumn
            {
                get
                {
                    return this.columnNumPermission;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeWorkColumn
            {
                get
                {
                    return this.columnTypeWork;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn workeragreedColumn
            {
                get
                {
                    return this.columnworkeragreed;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_ExcavationFileDataTable : TypedTableBase<DataSetExcavation.Class321>
        {
            private DataColumn columnFile;
            private DataColumn columnFileName;
            private DataColumn columnid;
            private DataColumn columnidExcavation;
            private DataColumn columntypeFile;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate182 tJ_ExcavationFileRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate182 tJ_ExcavationFileRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate182 tJ_ExcavationFileRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate182 tJ_ExcavationFileRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_ExcavationFileDataTable()
            {
                base.TableName = "tJ_ExcavationFile";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tJ_ExcavationFileDataTable(DataTable dataTable_0)
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
            protected tJ_ExcavationFileDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetExcavation.tJ_ExcavationFileDataTable table1 = (DataSetExcavation.tJ_ExcavationFileDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.tJ_ExcavationFileDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class321);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetExcavation.Class321 class321_0)
            {
                base.Rows.Add(class321_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class321 method_1(int int_0, int int_1, string string_0, byte[] byte_0)
            {
                DataSetExcavation.Class321 row = (DataSetExcavation.Class321) base.NewRow();
                object[] objArray1 = new object[5];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = string_0;
                objArray1[4] = byte_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class321 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class321) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidExcavation = base.Columns["idExcavation"];
                this.columntypeFile = base.Columns["typeFile"];
                this.columnFileName = base.Columns["FileName"];
                this.columnFile = base.Columns["File"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidExcavation = new DataColumn("idExcavation", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidExcavation);
                this.columntypeFile = new DataColumn("typeFile", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columntypeFile);
                this.columnFileName = new DataColumn("FileName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFileName);
                this.columnFile = new DataColumn("File", typeof(byte[]), null, MappingType.Element);
                base.Columns.Add(this.columnFile);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidExcavation.AllowDBNull = false;
                this.columntypeFile.AllowDBNull = false;
                this.columnFileName.AllowDBNull = false;
                this.columnFileName.MaxLength = 0x400;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class321 method_5()
            {
                return (DataSetExcavation.Class321) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetExcavation.Class321 class321_0)
            {
                base.Rows.Remove(class321_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class321(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationFileRowChanged != null)
                {
                    this.tJ_ExcavationFileRowChanged(this, new DataSetExcavation.EventArgs180((DataSetExcavation.Class321) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationFileRowChanging != null)
                {
                    this.tJ_ExcavationFileRowChanging(this, new DataSetExcavation.EventArgs180((DataSetExcavation.Class321) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationFileRowDeleted != null)
                {
                    this.tJ_ExcavationFileRowDeleted(this, new DataSetExcavation.EventArgs180((DataSetExcavation.Class321) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationFileRowDeleting != null)
                {
                    this.tJ_ExcavationFileRowDeleting(this, new DataSetExcavation.EventArgs180((DataSetExcavation.Class321) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_ExcavationFileDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idExcavationColumn
            {
                get
                {
                    return this.columnidExcavation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class321 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class321) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn typeFileColumn
            {
                get
                {
                    return this.columntypeFile;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_ExcavationSchmObjDataTable : TypedTableBase<DataSetExcavation.Class317>
        {
            private DataColumn columnid;
            private DataColumn columnidExcavation;
            private DataColumn columnidKL;
            private DataColumn columnNameKL;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate178 tJ_ExcavationSchmObjRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate178 tJ_ExcavationSchmObjRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate178 tJ_ExcavationSchmObjRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate178 tJ_ExcavationSchmObjRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tJ_ExcavationSchmObjDataTable()
            {
                base.TableName = "tJ_ExcavationSchmObj";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tJ_ExcavationSchmObjDataTable(DataTable dataTable_0)
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
            protected tJ_ExcavationSchmObjDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetExcavation.tJ_ExcavationSchmObjDataTable table1 = (DataSetExcavation.tJ_ExcavationSchmObjDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.tJ_ExcavationSchmObjDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class317);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetExcavation.Class317 class317_0)
            {
                base.Rows.Add(class317_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class317 method_1(int int_0, string string_0, int int_1)
            {
                DataSetExcavation.Class317 row = (DataSetExcavation.Class317) base.NewRow();
                object[] objArray1 = new object[4];
                objArray1[1] = int_0;
                objArray1[2] = string_0;
                objArray1[3] = int_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class317 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class317) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidExcavation = base.Columns["idExcavation"];
                this.columnNameKL = base.Columns["NameKL"];
                this.columnidKL = base.Columns["idKL"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidExcavation = new DataColumn("idExcavation", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidExcavation);
                this.columnNameKL = new DataColumn("NameKL", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNameKL);
                this.columnidKL = new DataColumn("idKL", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidKL);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidExcavation.AllowDBNull = false;
                this.columnNameKL.MaxLength = 0x200;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class317 method_5()
            {
                return (DataSetExcavation.Class317) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetExcavation.Class317 class317_0)
            {
                base.Rows.Remove(class317_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class317(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationSchmObjRowChanged != null)
                {
                    this.tJ_ExcavationSchmObjRowChanged(this, new DataSetExcavation.EventArgs176((DataSetExcavation.Class317) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationSchmObjRowChanging != null)
                {
                    this.tJ_ExcavationSchmObjRowChanging(this, new DataSetExcavation.EventArgs176((DataSetExcavation.Class317) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationSchmObjRowDeleted != null)
                {
                    this.tJ_ExcavationSchmObjRowDeleted(this, new DataSetExcavation.EventArgs176((DataSetExcavation.Class317) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationSchmObjRowDeleting != null)
                {
                    this.tJ_ExcavationSchmObjRowDeleting(this, new DataSetExcavation.EventArgs176((DataSetExcavation.Class317) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_ExcavationSchmObjDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idExcavationColumn
            {
                get
                {
                    return this.columnidExcavation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idKLColumn
            {
                get
                {
                    return this.columnidKL;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class317 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class317) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NameKLColumn
            {
                get
                {
                    return this.columnNameKL;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_ExcavationStatusDataTable : TypedTableBase<DataSetExcavation.Class318>
        {
            private DataColumn columnComment;
            private DataColumn columndateChange;
            private DataColumn columndateElongation;
            private DataColumn columnid;
            private DataColumn columnidExcavation;
            private DataColumn columnidStatus;
            private DataColumn columnidType;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate179 tJ_ExcavationStatusRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate179 tJ_ExcavationStatusRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate179 tJ_ExcavationStatusRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate179 tJ_ExcavationStatusRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_ExcavationStatusDataTable()
            {
                base.TableName = "tJ_ExcavationStatus";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_ExcavationStatusDataTable(DataTable dataTable_0)
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
            protected tJ_ExcavationStatusDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetExcavation.tJ_ExcavationStatusDataTable table1 = (DataSetExcavation.tJ_ExcavationStatusDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.tJ_ExcavationStatusDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class318);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetExcavation.Class318 class318_0)
            {
                base.Rows.Add(class318_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class318 method_1(int int_0, short short_0, int int_1, DateTime dateTime_0, DateTime dateTime_1, string string_0)
            {
                DataSetExcavation.Class318 row = (DataSetExcavation.Class318) base.NewRow();
                object[] objArray1 = new object[7];
                objArray1[1] = int_0;
                objArray1[2] = short_0;
                objArray1[3] = int_1;
                objArray1[4] = dateTime_0;
                objArray1[5] = dateTime_1;
                objArray1[6] = string_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class318 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class318) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidExcavation = base.Columns["idExcavation"];
                this.columnidType = base.Columns["idType"];
                this.columnidStatus = base.Columns["idStatus"];
                this.columndateChange = base.Columns["dateChange"];
                this.columndateElongation = base.Columns["dateElongation"];
                this.columnComment = base.Columns["Comment"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidExcavation = new DataColumn("idExcavation", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidExcavation);
                this.columnidType = new DataColumn("idType", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnidType);
                this.columnidStatus = new DataColumn("idStatus", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidStatus);
                this.columndateChange = new DataColumn("dateChange", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateChange);
                this.columndateElongation = new DataColumn("dateElongation", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateElongation);
                this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComment);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidExcavation.AllowDBNull = false;
                this.columnidType.AllowDBNull = false;
                this.columnidStatus.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class318 method_5()
            {
                return (DataSetExcavation.Class318) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetExcavation.Class318 class318_0)
            {
                base.Rows.Remove(class318_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class318(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationStatusRowChanged != null)
                {
                    this.tJ_ExcavationStatusRowChanged(this, new DataSetExcavation.EventArgs177((DataSetExcavation.Class318) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationStatusRowChanging != null)
                {
                    this.tJ_ExcavationStatusRowChanging(this, new DataSetExcavation.EventArgs177((DataSetExcavation.Class318) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationStatusRowDeleted != null)
                {
                    this.tJ_ExcavationStatusRowDeleted(this, new DataSetExcavation.EventArgs177((DataSetExcavation.Class318) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationStatusRowDeleting != null)
                {
                    this.tJ_ExcavationStatusRowDeleting(this, new DataSetExcavation.EventArgs177((DataSetExcavation.Class318) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_ExcavationStatusDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateChangeColumn
            {
                get
                {
                    return this.columndateChange;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateElongationColumn
            {
                get
                {
                    return this.columndateElongation;
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
            public DataColumn idExcavationColumn
            {
                get
                {
                    return this.columnidExcavation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idStatusColumn
            {
                get
                {
                    return this.columnidStatus;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idTypeColumn
            {
                get
                {
                    return this.columnidType;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class318 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class318) base.Rows[int_0];
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_ExcavationSurfaceDataTable : TypedTableBase<DataSetExcavation.Class309>
        {
            private DataColumn columncomment;
            private DataColumn columnid;
            private DataColumn columnidExcavation;
            private DataColumn columnidSurface;
            private DataColumn columnidType;
            private DataColumn columnunit;
            private DataColumn columnValue;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate170 tJ_ExcavationSurfaceRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate170 tJ_ExcavationSurfaceRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate170 tJ_ExcavationSurfaceRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate170 tJ_ExcavationSurfaceRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_ExcavationSurfaceDataTable()
            {
                base.TableName = "tJ_ExcavationSurface";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tJ_ExcavationSurfaceDataTable(DataTable dataTable_0)
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
            protected tJ_ExcavationSurfaceDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetExcavation.tJ_ExcavationSurfaceDataTable table1 = (DataSetExcavation.tJ_ExcavationSurfaceDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.tJ_ExcavationSurfaceDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class309);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetExcavation.Class309 class309_0)
            {
                base.Rows.Add(class309_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class309 method_1(int int_0, int int_1, int int_2, double double_0, string string_0, string string_1)
            {
                DataSetExcavation.Class309 row = (DataSetExcavation.Class309) base.NewRow();
                object[] objArray1 = new object[7];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = int_2;
                objArray1[4] = double_0;
                objArray1[5] = string_0;
                objArray1[6] = string_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class309 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class309) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidExcavation = base.Columns["idExcavation"];
                this.columnidType = base.Columns["idType"];
                this.columnidSurface = base.Columns["idSurface"];
                this.columnValue = base.Columns["Value"];
                this.columnunit = base.Columns["unit"];
                this.columncomment = base.Columns["comment"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidExcavation = new DataColumn("idExcavation", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidExcavation);
                this.columnidType = new DataColumn("idType", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidType);
                this.columnidSurface = new DataColumn("idSurface", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSurface);
                this.columnValue = new DataColumn("Value", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnValue);
                this.columnunit = new DataColumn("unit", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnunit);
                this.columncomment = new DataColumn("comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomment);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidExcavation.AllowDBNull = false;
                this.columnidType.AllowDBNull = false;
                this.columnidSurface.AllowDBNull = false;
                this.columnunit.MaxLength = 10;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class309 method_5()
            {
                return (DataSetExcavation.Class309) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetExcavation.Class309 class309_0)
            {
                base.Rows.Remove(class309_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class309(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationSurfaceRowChanged != null)
                {
                    this.tJ_ExcavationSurfaceRowChanged(this, new DataSetExcavation.EventArgs168((DataSetExcavation.Class309) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationSurfaceRowChanging != null)
                {
                    this.tJ_ExcavationSurfaceRowChanging(this, new DataSetExcavation.EventArgs168((DataSetExcavation.Class309) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationSurfaceRowDeleted != null)
                {
                    this.tJ_ExcavationSurfaceRowDeleted(this, new DataSetExcavation.EventArgs168((DataSetExcavation.Class309) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_ExcavationSurfaceRowDeleting != null)
                {
                    this.tJ_ExcavationSurfaceRowDeleting(this, new DataSetExcavation.EventArgs168((DataSetExcavation.Class309) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_ExcavationSurfaceDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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
            public DataColumn commentColumn
            {
                get
                {
                    return this.columncomment;
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
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idExcavationColumn
            {
                get
                {
                    return this.columnidExcavation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idSurfaceColumn
            {
                get
                {
                    return this.columnidSurface;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idTypeColumn
            {
                get
                {
                    return this.columnidType;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class309 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class309) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn unitColumn
            {
                get
                {
                    return this.columnunit;
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
        public class tR_ClassifierDataTable : TypedTableBase<DataSetExcavation.Class310>
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
            public event DataSetExcavation.Delegate171 tR_ClassifierRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate171 tR_ClassifierRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate171 tR_ClassifierRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate171 tR_ClassifierRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tR_ClassifierDataTable()
            {
                base.TableName = "tR_Classifier";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetExcavation.tR_ClassifierDataTable table1 = (DataSetExcavation.tR_ClassifierDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.tR_ClassifierDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class310);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetExcavation.Class310 class310_0)
            {
                base.Rows.Add(class310_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class310 method_1(string string_0, string string_1, decimal decimal_0, string string_2, int int_0, string string_3, byte[] byte_0, bool bool_0, bool bool_1)
            {
                DataSetExcavation.Class310 row = (DataSetExcavation.Class310) base.NewRow();
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
            public DataSetExcavation.Class310 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class310) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class310 method_5()
            {
                return (DataSetExcavation.Class310) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetExcavation.Class310 class310_0)
            {
                base.Rows.Remove(class310_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class310(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowChanged != null)
                {
                    this.tR_ClassifierRowChanged(this, new DataSetExcavation.EventArgs169((DataSetExcavation.Class310) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowChanging != null)
                {
                    this.tR_ClassifierRowChanging(this, new DataSetExcavation.EventArgs169((DataSetExcavation.Class310) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowDeleted != null)
                {
                    this.tR_ClassifierRowDeleted(this, new DataSetExcavation.EventArgs169((DataSetExcavation.Class310) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowDeleting != null)
                {
                    this.tR_ClassifierRowDeleting(this, new DataSetExcavation.EventArgs169((DataSetExcavation.Class310) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tR_ClassifierDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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
            public DataSetExcavation.Class310 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class310) base.Rows[int_0];
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
        public class vAbnTypeDataTable : TypedTableBase<DataSetExcavation.Class324>
        {
            private DataColumn columnCodeAbonent;
            private DataColumn columnDeleted;
            private DataColumn columnid;
            private DataColumn columnidAbn;
            private DataColumn columnidWorker;
            private DataColumn columnName;
            private DataColumn columnTypeAbn;
            private DataColumn columntypeKontragent;
            private DataColumn columntypeKontragentName;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate185 vAbnTypeRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate185 vAbnTypeRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate185 vAbnTypeRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate185 vAbnTypeRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vAbnTypeDataTable()
            {
                base.TableName = "vAbnType";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal vAbnTypeDataTable(DataTable dataTable_0)
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
            protected vAbnTypeDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetExcavation.vAbnTypeDataTable table1 = (DataSetExcavation.vAbnTypeDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.vAbnTypeDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class324);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetExcavation.Class324 class324_0)
            {
                base.Rows.Add(class324_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class324 method_1(int int_0, int int_1, int int_2, string string_0, int int_3, int int_4, bool bool_0, int int_5, string string_1)
            {
                DataSetExcavation.Class324 row = (DataSetExcavation.Class324) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, int_2, string_0, int_3, int_4, bool_0, int_5, string_1 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnid = base.Columns["id"];
                this.columnidAbn = base.Columns["idAbn"];
                this.columnCodeAbonent = base.Columns["CodeAbonent"];
                this.columnName = base.Columns["Name"];
                this.columnTypeAbn = base.Columns["TypeAbn"];
                this.columnidWorker = base.Columns["idWorker"];
                this.columnDeleted = base.Columns["Deleted"];
                this.columntypeKontragent = base.Columns["typeKontragent"];
                this.columntypeKontragentName = base.Columns["typeKontragentName"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
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
                this.columntypeKontragent = new DataColumn("typeKontragent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columntypeKontragent);
                this.columntypeKontragentName = new DataColumn("typeKontragentName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntypeKontragentName);
                this.columnidAbn.AllowDBNull = false;
                this.columnCodeAbonent.AllowDBNull = false;
                this.columnName.MaxLength = 100;
                this.columnTypeAbn.AllowDBNull = false;
                this.columnidWorker.AllowDBNull = false;
                this.columnDeleted.AllowDBNull = false;
                this.columntypeKontragentName.MaxLength = 100;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class324 method_4()
            {
                return (DataSetExcavation.Class324) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(DataSetExcavation.Class324 class324_0)
            {
                base.Rows.Remove(class324_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class324(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vAbnTypeRowChanged != null)
                {
                    this.vAbnTypeRowChanged(this, new DataSetExcavation.EventArgs183((DataSetExcavation.Class324) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vAbnTypeRowChanging != null)
                {
                    this.vAbnTypeRowChanging(this, new DataSetExcavation.EventArgs183((DataSetExcavation.Class324) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vAbnTypeRowDeleted != null)
                {
                    this.vAbnTypeRowDeleted(this, new DataSetExcavation.EventArgs183((DataSetExcavation.Class324) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vAbnTypeRowDeleting != null)
                {
                    this.vAbnTypeRowDeleting(this, new DataSetExcavation.EventArgs183((DataSetExcavation.Class324) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vAbnTypeDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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
            public DataColumn idAbnColumn
            {
                get
                {
                    return this.columnidAbn;
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
            public DataColumn idWorkerColumn
            {
                get
                {
                    return this.columnidWorker;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class324 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class324) base.Rows[int_0];
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
            public DataColumn TypeAbnColumn
            {
                get
                {
                    return this.columnTypeAbn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn typeKontragentColumn
            {
                get
                {
                    return this.columntypeKontragent;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeKontragentNameColumn
            {
                get
                {
                    return this.columntypeKontragentName;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vJ_ExcavationAddressDataTable : TypedTableBase<DataSetExcavation.Class311>
        {
            private DataColumn columnComment;
            private DataColumn columnHouse;
            private DataColumn columnid;
            private DataColumn columnidExcavation;
            private DataColumn columnidRegion;
            private DataColumn columnidStreet;
            private DataColumn columnregion;
            private DataColumn columnstreet;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate172 vJ_ExcavationAddressRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate172 vJ_ExcavationAddressRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate172 vJ_ExcavationAddressRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate172 vJ_ExcavationAddressRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vJ_ExcavationAddressDataTable()
            {
                base.TableName = "vJ_ExcavationAddress";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal vJ_ExcavationAddressDataTable(DataTable dataTable_0)
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
            protected vJ_ExcavationAddressDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetExcavation.vJ_ExcavationAddressDataTable table1 = (DataSetExcavation.vJ_ExcavationAddressDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.vJ_ExcavationAddressDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class311);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetExcavation.Class311 class311_0)
            {
                base.Rows.Add(class311_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class311 method_1(int int_0, int int_1, int int_2, int int_3, string string_0, string string_1, string string_2, string string_3)
            {
                DataSetExcavation.Class311 row = (DataSetExcavation.Class311) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, int_2, int_3, string_0, string_1, string_2, string_3 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class311 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class311) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidExcavation = base.Columns["idExcavation"];
                this.columnidRegion = base.Columns["idRegion"];
                this.columnidStreet = base.Columns["idStreet"];
                this.columnHouse = base.Columns["House"];
                this.columnComment = base.Columns["Comment"];
                this.columnregion = base.Columns["region"];
                this.columnstreet = base.Columns["street"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidExcavation = new DataColumn("idExcavation", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidExcavation);
                this.columnidRegion = new DataColumn("idRegion", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidRegion);
                this.columnidStreet = new DataColumn("idStreet", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidStreet);
                this.columnHouse = new DataColumn("House", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnHouse);
                this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComment);
                this.columnregion = new DataColumn("region", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnregion);
                this.columnstreet = new DataColumn("street", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnstreet);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnidExcavation.AllowDBNull = false;
                this.columnHouse.MaxLength = 50;
                this.columnComment.MaxLength = 0x100;
                this.columnregion.MaxLength = 100;
                this.columnstreet.ReadOnly = true;
                this.columnstreet.MaxLength = 0x5b;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class311 method_5()
            {
                return (DataSetExcavation.Class311) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetExcavation.Class311 class311_0)
            {
                base.Rows.Remove(class311_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class311(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationAddressRowChanged != null)
                {
                    this.vJ_ExcavationAddressRowChanged(this, new DataSetExcavation.EventArgs170((DataSetExcavation.Class311) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationAddressRowChanging != null)
                {
                    this.vJ_ExcavationAddressRowChanging(this, new DataSetExcavation.EventArgs170((DataSetExcavation.Class311) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationAddressRowDeleted != null)
                {
                    this.vJ_ExcavationAddressRowDeleted(this, new DataSetExcavation.EventArgs170((DataSetExcavation.Class311) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationAddressRowDeleting != null)
                {
                    this.vJ_ExcavationAddressRowDeleting(this, new DataSetExcavation.EventArgs170((DataSetExcavation.Class311) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vJ_ExcavationAddressDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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

            [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idExcavationColumn
            {
                get
                {
                    return this.columnidExcavation;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idRegionColumn
            {
                get
                {
                    return this.columnidRegion;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idStreetColumn
            {
                get
                {
                    return this.columnidStreet;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class311 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class311) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn regionColumn
            {
                get
                {
                    return this.columnregion;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn streetColumn
            {
                get
                {
                    return this.columnstreet;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vJ_ExcavationDataTable : TypedTableBase<DataSetExcavation.Class315>
        {
            private DataColumn columnaddress;
            private DataColumn columnagreed;
            private DataColumn columnDamage;
            private DataColumn columndateagreed;
            private DataColumn columndateAsphalt;
            private DataColumn columndatebeg;
            private DataColumn columndateBegOrder;
            private DataColumn columndateEnd;
            private DataColumn columndateEndOrder;
            private DataColumn columndateEndPlanned;
            private DataColumn columndatePay;
            private DataColumn columndateUnderAsphalt;
            private DataColumn columnid;
            private DataColumn columnidcontractor;
            private DataColumn columnidSR;
            private DataColumn columnnameContractor;
            private DataColumn columnnameKL;
            private DataColumn columnnum;
            private DataColumn columnPermission;
            private DataColumn columnrecovery;
            private DataColumn columnregion;
            private DataColumn columnSR;
            private DataColumn columnstatusOrder;
            private DataColumn columnStatusWork;
            private DataColumn columntypework;
            private DataColumn columntypeWorkName;
            private DataColumn columntypeWorkscr;
            private DataColumn columnworkComment;
            private DataColumn columnworkeragreed;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate176 vJ_ExcavationRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate176 vJ_ExcavationRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate176 vJ_ExcavationRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate176 vJ_ExcavationRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vJ_ExcavationDataTable()
            {
                base.TableName = "vJ_Excavation";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vJ_ExcavationDataTable(DataTable dataTable_0)
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
            protected vJ_ExcavationDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetExcavation.vJ_ExcavationDataTable table1 = (DataSetExcavation.vJ_ExcavationDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.vJ_ExcavationDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class315);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetExcavation.Class315 class315_0)
            {
                base.Rows.Add(class315_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class315 method_1(int int_0, int int_1, DateTime dateTime_0, int int_2, string string_0, int int_3, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, DateTime dateTime_1, DateTime dateTime_2, string string_7, string string_8, DateTime dateTime_3, DateTime dateTime_4, DateTime dateTime_5, DateTime dateTime_6, DateTime dateTime_7, int int_4, bool bool_0, string string_9, int int_5, string string_10, DateTime dateTime_8, string string_11, string string_12)
            {
                DataSetExcavation.Class315 row = (DataSetExcavation.Class315) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, int_1, dateTime_0, int_2, string_0, int_3, string_1, string_2, string_3, string_4, string_5, string_6, dateTime_1, dateTime_2, string_7, string_8,
                    dateTime_3, dateTime_4, dateTime_5, dateTime_6, dateTime_7, int_4, bool_0, string_9, int_5, string_10, dateTime_8, string_11, string_12
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnid = base.Columns["id"];
                this.columnnum = base.Columns["num"];
                this.columndatebeg = base.Columns["datebeg"];
                this.columnidcontractor = base.Columns["idcontractor"];
                this.columnnameContractor = base.Columns["nameContractor"];
                this.columntypework = base.Columns["typework"];
                this.columntypeWorkscr = base.Columns["typeWorkscr"];
                this.columntypeWorkName = base.Columns["typeWorkName"];
                this.columnregion = base.Columns["region"];
                this.columnaddress = base.Columns["address"];
                this.columnnameKL = base.Columns["nameKL"];
                this.columnstatusOrder = base.Columns["statusOrder"];
                this.columndateBegOrder = base.Columns["dateBegOrder"];
                this.columndateEndOrder = base.Columns["dateEndOrder"];
                this.columnPermission = base.Columns["Permission"];
                this.columnStatusWork = base.Columns["StatusWork"];
                this.columndateUnderAsphalt = base.Columns["dateUnderAsphalt"];
                this.columndateAsphalt = base.Columns["dateAsphalt"];
                this.columndateEnd = base.Columns["dateEnd"];
                this.columndatePay = base.Columns["datePay"];
                this.columndateagreed = base.Columns["dateagreed"];
                this.columnworkeragreed = base.Columns["workeragreed"];
                this.columnagreed = base.Columns["agreed"];
                this.columnDamage = base.Columns["Damage"];
                this.columnidSR = base.Columns["idSR"];
                this.columnSR = base.Columns["SR"];
                this.columndateEndPlanned = base.Columns["dateEndPlanned"];
                this.columnworkComment = base.Columns["workComment"];
                this.columnrecovery = base.Columns["recovery"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnum = new DataColumn("num", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnum);
                this.columndatebeg = new DataColumn("datebeg", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndatebeg);
                this.columnidcontractor = new DataColumn("idcontractor", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidcontractor);
                this.columnnameContractor = new DataColumn("nameContractor", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnameContractor);
                this.columntypework = new DataColumn("typework", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columntypework);
                this.columntypeWorkscr = new DataColumn("typeWorkscr", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntypeWorkscr);
                this.columntypeWorkName = new DataColumn("typeWorkName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntypeWorkName);
                this.columnregion = new DataColumn("region", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnregion);
                this.columnaddress = new DataColumn("address", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnaddress);
                this.columnnameKL = new DataColumn("nameKL", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnameKL);
                this.columnstatusOrder = new DataColumn("statusOrder", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnstatusOrder);
                this.columndateBegOrder = new DataColumn("dateBegOrder", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateBegOrder);
                this.columndateEndOrder = new DataColumn("dateEndOrder", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateEndOrder);
                this.columnPermission = new DataColumn("Permission", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPermission);
                this.columnStatusWork = new DataColumn("StatusWork", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnStatusWork);
                this.columndateUnderAsphalt = new DataColumn("dateUnderAsphalt", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateUnderAsphalt);
                this.columndateAsphalt = new DataColumn("dateAsphalt", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateAsphalt);
                this.columndateEnd = new DataColumn("dateEnd", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateEnd);
                this.columndatePay = new DataColumn("datePay", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndatePay);
                this.columndateagreed = new DataColumn("dateagreed", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateagreed);
                this.columnworkeragreed = new DataColumn("workeragreed", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnworkeragreed);
                this.columnagreed = new DataColumn("agreed", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnagreed);
                this.columnDamage = new DataColumn("Damage", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDamage);
                this.columnidSR = new DataColumn("idSR", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSR);
                this.columnSR = new DataColumn("SR", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnSR);
                this.columndateEndPlanned = new DataColumn("dateEndPlanned", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateEndPlanned);
                this.columnworkComment = new DataColumn("workComment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnworkComment);
                this.columnrecovery = new DataColumn("recovery", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnrecovery);
                this.columnid.AllowDBNull = false;
                this.columnnameContractor.MaxLength = 100;
                this.columntypeWorkscr.MaxLength = 50;
                this.columntypeWorkName.MaxLength = 100;
                this.columnregion.MaxLength = 100;
                this.columnaddress.MaxLength = 0x7fffffff;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class315 method_4()
            {
                return (DataSetExcavation.Class315) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetExcavation.Class315 class315_0)
            {
                base.Rows.Remove(class315_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class315(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationRowChanged != null)
                {
                    this.vJ_ExcavationRowChanged(this, new DataSetExcavation.EventArgs174((DataSetExcavation.Class315) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationRowChanging != null)
                {
                    this.vJ_ExcavationRowChanging(this, new DataSetExcavation.EventArgs174((DataSetExcavation.Class315) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationRowDeleted != null)
                {
                    this.vJ_ExcavationRowDeleted(this, new DataSetExcavation.EventArgs174((DataSetExcavation.Class315) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationRowDeleting != null)
                {
                    this.vJ_ExcavationRowDeleting(this, new DataSetExcavation.EventArgs174((DataSetExcavation.Class315) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vJ_ExcavationDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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
            public DataColumn addressColumn
            {
                get
                {
                    return this.columnaddress;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn agreedColumn
            {
                get
                {
                    return this.columnagreed;
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
            public DataColumn DamageColumn
            {
                get
                {
                    return this.columnDamage;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateagreedColumn
            {
                get
                {
                    return this.columndateagreed;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateAsphaltColumn
            {
                get
                {
                    return this.columndateAsphalt;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn datebegColumn
            {
                get
                {
                    return this.columndatebeg;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateBegOrderColumn
            {
                get
                {
                    return this.columndateBegOrder;
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
            public DataColumn dateEndOrderColumn
            {
                get
                {
                    return this.columndateEndOrder;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateEndPlannedColumn
            {
                get
                {
                    return this.columndateEndPlanned;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn datePayColumn
            {
                get
                {
                    return this.columndatePay;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateUnderAsphaltColumn
            {
                get
                {
                    return this.columndateUnderAsphalt;
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
            public DataColumn idcontractorColumn
            {
                get
                {
                    return this.columnidcontractor;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idSRColumn
            {
                get
                {
                    return this.columnidSR;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class315 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class315) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn nameContractorColumn
            {
                get
                {
                    return this.columnnameContractor;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nameKLColumn
            {
                get
                {
                    return this.columnnameKL;
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
            public DataColumn PermissionColumn
            {
                get
                {
                    return this.columnPermission;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn recoveryColumn
            {
                get
                {
                    return this.columnrecovery;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn regionColumn
            {
                get
                {
                    return this.columnregion;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SRColumn
            {
                get
                {
                    return this.columnSR;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn statusOrderColumn
            {
                get
                {
                    return this.columnstatusOrder;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn StatusWorkColumn
            {
                get
                {
                    return this.columnStatusWork;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeworkColumn
            {
                get
                {
                    return this.columntypework;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn typeWorkNameColumn
            {
                get
                {
                    return this.columntypeWorkName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeWorkscrColumn
            {
                get
                {
                    return this.columntypeWorkscr;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn workCommentColumn
            {
                get
                {
                    return this.columnworkComment;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn workeragreedColumn
            {
                get
                {
                    return this.columnworkeragreed;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vJ_ExcavationFileDataTable : TypedTableBase<DataSetExcavation.Class322>
        {
            private DataColumn columnFile;
            private DataColumn columnFileName;
            private DataColumn columnid;
            private DataColumn columnidExcavation;
            private DataColumn columntypeFile;
            private DataColumn columntypeFileName;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate183 vJ_ExcavationFileRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate183 vJ_ExcavationFileRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate183 vJ_ExcavationFileRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate183 vJ_ExcavationFileRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vJ_ExcavationFileDataTable()
            {
                base.TableName = "vJ_ExcavationFile";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vJ_ExcavationFileDataTable(DataTable dataTable_0)
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
            protected vJ_ExcavationFileDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetExcavation.vJ_ExcavationFileDataTable table1 = (DataSetExcavation.vJ_ExcavationFileDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.vJ_ExcavationFileDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class322);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetExcavation.Class322 class322_0)
            {
                base.Rows.Add(class322_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class322 method_1(int int_0, int int_1, int int_2, string string_0, byte[] byte_0, string string_1)
            {
                DataSetExcavation.Class322 row = (DataSetExcavation.Class322) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, int_2, string_0, byte_0, string_1 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class322 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class322) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidExcavation = base.Columns["idExcavation"];
                this.columntypeFile = base.Columns["typeFile"];
                this.columnFileName = base.Columns["FileName"];
                this.columnFile = base.Columns["File"];
                this.columntypeFileName = base.Columns["typeFileName"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidExcavation = new DataColumn("idExcavation", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidExcavation);
                this.columntypeFile = new DataColumn("typeFile", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columntypeFile);
                this.columnFileName = new DataColumn("FileName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFileName);
                this.columnFile = new DataColumn("File", typeof(byte[]), null, MappingType.Element);
                base.Columns.Add(this.columnFile);
                this.columntypeFileName = new DataColumn("typeFileName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntypeFileName);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnidExcavation.AllowDBNull = false;
                this.columntypeFile.AllowDBNull = false;
                this.columnFileName.AllowDBNull = false;
                this.columnFileName.MaxLength = 0x400;
                this.columntypeFileName.MaxLength = 100;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class322 method_5()
            {
                return (DataSetExcavation.Class322) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetExcavation.Class322 class322_0)
            {
                base.Rows.Remove(class322_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class322(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationFileRowChanged != null)
                {
                    this.vJ_ExcavationFileRowChanged(this, new DataSetExcavation.EventArgs181((DataSetExcavation.Class322) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationFileRowChanging != null)
                {
                    this.vJ_ExcavationFileRowChanging(this, new DataSetExcavation.EventArgs181((DataSetExcavation.Class322) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationFileRowDeleted != null)
                {
                    this.vJ_ExcavationFileRowDeleted(this, new DataSetExcavation.EventArgs181((DataSetExcavation.Class322) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationFileRowDeleting != null)
                {
                    this.vJ_ExcavationFileRowDeleting(this, new DataSetExcavation.EventArgs181((DataSetExcavation.Class322) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vJ_ExcavationFileDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idExcavationColumn
            {
                get
                {
                    return this.columnidExcavation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class322 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class322) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeFileColumn
            {
                get
                {
                    return this.columntypeFile;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn typeFileNameColumn
            {
                get
                {
                    return this.columntypeFileName;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vJ_ExcavationSchmObjDataTable : TypedTableBase<DataSetExcavation.Class316>
        {
            private DataColumn columnid;
            private DataColumn columnidExcavation;
            private DataColumn columnidKL;
            private DataColumn columnname;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate177 vJ_ExcavationSchmObjRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate177 vJ_ExcavationSchmObjRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate177 vJ_ExcavationSchmObjRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate177 vJ_ExcavationSchmObjRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vJ_ExcavationSchmObjDataTable()
            {
                base.TableName = "vJ_ExcavationSchmObj";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal vJ_ExcavationSchmObjDataTable(DataTable dataTable_0)
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
            protected vJ_ExcavationSchmObjDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetExcavation.vJ_ExcavationSchmObjDataTable table1 = (DataSetExcavation.vJ_ExcavationSchmObjDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.vJ_ExcavationSchmObjDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class316);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetExcavation.Class316 class316_0)
            {
                base.Rows.Add(class316_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class316 method_1(int int_0, int int_1, string string_0, int int_2)
            {
                DataSetExcavation.Class316 row = (DataSetExcavation.Class316) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, string_0, int_2 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class316 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class316) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidExcavation = base.Columns["idExcavation"];
                this.columnname = base.Columns["name"];
                this.columnidKL = base.Columns["idKL"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidExcavation = new DataColumn("idExcavation", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidExcavation);
                this.columnname = new DataColumn("name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnname);
                this.columnidKL = new DataColumn("idKL", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidKL);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnidExcavation.AllowDBNull = false;
                this.columnname.ReadOnly = true;
                this.columnname.MaxLength = 0x200;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class316 method_5()
            {
                return (DataSetExcavation.Class316) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetExcavation.Class316 class316_0)
            {
                base.Rows.Remove(class316_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class316(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationSchmObjRowChanged != null)
                {
                    this.vJ_ExcavationSchmObjRowChanged(this, new DataSetExcavation.EventArgs175((DataSetExcavation.Class316) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationSchmObjRowChanging != null)
                {
                    this.vJ_ExcavationSchmObjRowChanging(this, new DataSetExcavation.EventArgs175((DataSetExcavation.Class316) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationSchmObjRowDeleted != null)
                {
                    this.vJ_ExcavationSchmObjRowDeleted(this, new DataSetExcavation.EventArgs175((DataSetExcavation.Class316) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationSchmObjRowDeleting != null)
                {
                    this.vJ_ExcavationSchmObjRowDeleting(this, new DataSetExcavation.EventArgs175((DataSetExcavation.Class316) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vJ_ExcavationSchmObjDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idExcavationColumn
            {
                get
                {
                    return this.columnidExcavation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idKLColumn
            {
                get
                {
                    return this.columnidKL;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class316 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class316) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nameColumn
            {
                get
                {
                    return this.columnname;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vJ_ExcavationStatusDataTable : TypedTableBase<DataSetExcavation.Class319>
        {
            private DataColumn columnComment;
            private DataColumn columndateChange;
            private DataColumn columndateElongation;
            private DataColumn columnid;
            private DataColumn columnidExcavation;
            private DataColumn columnidStatus;
            private DataColumn columnidType;
            private DataColumn columnstatusname;
            private DataColumn columnstatusvalue;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate180 vJ_ExcavationStatusRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate180 vJ_ExcavationStatusRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate180 vJ_ExcavationStatusRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate180 vJ_ExcavationStatusRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vJ_ExcavationStatusDataTable()
            {
                base.TableName = "vJ_ExcavationStatus";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vJ_ExcavationStatusDataTable(DataTable dataTable_0)
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
            protected vJ_ExcavationStatusDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetExcavation.vJ_ExcavationStatusDataTable table1 = (DataSetExcavation.vJ_ExcavationStatusDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.vJ_ExcavationStatusDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class319);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetExcavation.Class319 class319_0)
            {
                base.Rows.Add(class319_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class319 method_1(int int_0, int int_1, short short_0, int int_2, DateTime dateTime_0, DateTime dateTime_1, string string_0, decimal decimal_0, string string_1)
            {
                DataSetExcavation.Class319 row = (DataSetExcavation.Class319) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, short_0, int_2, dateTime_0, dateTime_1, string_0, decimal_0, string_1 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class319 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class319) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidExcavation = base.Columns["idExcavation"];
                this.columnidType = base.Columns["idType"];
                this.columnidStatus = base.Columns["idStatus"];
                this.columndateChange = base.Columns["dateChange"];
                this.columndateElongation = base.Columns["dateElongation"];
                this.columnstatusname = base.Columns["statusname"];
                this.columnstatusvalue = base.Columns["statusvalue"];
                this.columnComment = base.Columns["Comment"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidExcavation = new DataColumn("idExcavation", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidExcavation);
                this.columnidType = new DataColumn("idType", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnidType);
                this.columnidStatus = new DataColumn("idStatus", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidStatus);
                this.columndateChange = new DataColumn("dateChange", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateChange);
                this.columndateElongation = new DataColumn("dateElongation", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateElongation);
                this.columnstatusname = new DataColumn("statusname", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnstatusname);
                this.columnstatusvalue = new DataColumn("statusvalue", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnstatusvalue);
                this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComment);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnidExcavation.AllowDBNull = false;
                this.columnidType.AllowDBNull = false;
                this.columnidStatus.AllowDBNull = false;
                this.columnstatusname.MaxLength = 100;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class319 method_5()
            {
                return (DataSetExcavation.Class319) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetExcavation.Class319 class319_0)
            {
                base.Rows.Remove(class319_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class319(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationStatusRowChanged != null)
                {
                    this.vJ_ExcavationStatusRowChanged(this, new DataSetExcavation.EventArgs178((DataSetExcavation.Class319) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationStatusRowChanging != null)
                {
                    this.vJ_ExcavationStatusRowChanging(this, new DataSetExcavation.EventArgs178((DataSetExcavation.Class319) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationStatusRowDeleted != null)
                {
                    this.vJ_ExcavationStatusRowDeleted(this, new DataSetExcavation.EventArgs178((DataSetExcavation.Class319) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationStatusRowDeleting != null)
                {
                    this.vJ_ExcavationStatusRowDeleting(this, new DataSetExcavation.EventArgs178((DataSetExcavation.Class319) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vJ_ExcavationStatusDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
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
            public DataColumn dateElongationColumn
            {
                get
                {
                    return this.columndateElongation;
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
            public DataColumn idExcavationColumn
            {
                get
                {
                    return this.columnidExcavation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idStatusColumn
            {
                get
                {
                    return this.columnidStatus;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idTypeColumn
            {
                get
                {
                    return this.columnidType;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class319 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class319) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn statusnameColumn
            {
                get
                {
                    return this.columnstatusname;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn statusvalueColumn
            {
                get
                {
                    return this.columnstatusvalue;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vJ_ExcavationSurfaceDataTable : TypedTableBase<DataSetExcavation.Class320>
        {
            private DataColumn columncomment;
            private DataColumn columnid;
            private DataColumn columnidExcavation;
            private DataColumn columnidSurface;
            private DataColumn columnidType;
            private DataColumn columnsurName;
            private DataColumn columnsurSocrName;
            private DataColumn columnunit;
            private DataColumn columnValue;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate181 vJ_ExcavationSurfaceRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate181 vJ_ExcavationSurfaceRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate181 vJ_ExcavationSurfaceRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate181 vJ_ExcavationSurfaceRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vJ_ExcavationSurfaceDataTable()
            {
                base.TableName = "vJ_ExcavationSurface";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal vJ_ExcavationSurfaceDataTable(DataTable dataTable_0)
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
            protected vJ_ExcavationSurfaceDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetExcavation.vJ_ExcavationSurfaceDataTable table1 = (DataSetExcavation.vJ_ExcavationSurfaceDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.vJ_ExcavationSurfaceDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class320);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetExcavation.Class320 class320_0)
            {
                base.Rows.Add(class320_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class320 method_1(int int_0, int int_1, int int_2, int int_3, double double_0, string string_0, string string_1, string string_2, string string_3)
            {
                DataSetExcavation.Class320 row = (DataSetExcavation.Class320) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, int_2, int_3, double_0, string_0, string_1, string_2, string_3 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class320 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class320) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidExcavation = base.Columns["idExcavation"];
                this.columnidType = base.Columns["idType"];
                this.columnidSurface = base.Columns["idSurface"];
                this.columnValue = base.Columns["Value"];
                this.columnunit = base.Columns["unit"];
                this.columncomment = base.Columns["comment"];
                this.columnsurName = base.Columns["surName"];
                this.columnsurSocrName = base.Columns["surSocrName"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidExcavation = new DataColumn("idExcavation", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidExcavation);
                this.columnidType = new DataColumn("idType", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidType);
                this.columnidSurface = new DataColumn("idSurface", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSurface);
                this.columnValue = new DataColumn("Value", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnValue);
                this.columnunit = new DataColumn("unit", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnunit);
                this.columncomment = new DataColumn("comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomment);
                this.columnsurName = new DataColumn("surName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnsurName);
                this.columnsurSocrName = new DataColumn("surSocrName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnsurSocrName);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnidExcavation.AllowDBNull = false;
                this.columnidType.AllowDBNull = false;
                this.columnidType.Caption = "isType";
                this.columnidSurface.AllowDBNull = false;
                this.columnunit.MaxLength = 10;
                this.columnsurName.MaxLength = 100;
                this.columnsurSocrName.MaxLength = 50;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class320 method_5()
            {
                return (DataSetExcavation.Class320) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetExcavation.Class320 class320_0)
            {
                base.Rows.Remove(class320_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class320(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationSurfaceRowChanged != null)
                {
                    this.vJ_ExcavationSurfaceRowChanged(this, new DataSetExcavation.EventArgs179((DataSetExcavation.Class320) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationSurfaceRowChanging != null)
                {
                    this.vJ_ExcavationSurfaceRowChanging(this, new DataSetExcavation.EventArgs179((DataSetExcavation.Class320) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationSurfaceRowDeleted != null)
                {
                    this.vJ_ExcavationSurfaceRowDeleted(this, new DataSetExcavation.EventArgs179((DataSetExcavation.Class320) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vJ_ExcavationSurfaceRowDeleting != null)
                {
                    this.vJ_ExcavationSurfaceRowDeleting(this, new DataSetExcavation.EventArgs179((DataSetExcavation.Class320) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vJ_ExcavationSurfaceDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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
            public DataColumn commentColumn
            {
                get
                {
                    return this.columncomment;
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
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idExcavationColumn
            {
                get
                {
                    return this.columnidExcavation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idSurfaceColumn
            {
                get
                {
                    return this.columnidSurface;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idTypeColumn
            {
                get
                {
                    return this.columnidType;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class320 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class320) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn surNameColumn
            {
                get
                {
                    return this.columnsurName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn surSocrNameColumn
            {
                get
                {
                    return this.columnsurSocrName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn unitColumn
            {
                get
                {
                    return this.columnunit;
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
        public class vR_KladrStreetDataTable : TypedTableBase<DataSetExcavation.Class323>
        {
            private DataColumn columnDeleted;
            private DataColumn columnGNINMB;
            private DataColumn columnId;
            private DataColumn columnIndex;
            private DataColumn columnKladrCode;
            private DataColumn columnKladrObjId;
            private DataColumn columnName;
            private DataColumn columnSocr;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate184 vR_KladrStreetRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate184 vR_KladrStreetRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate184 vR_KladrStreetRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetExcavation.Delegate184 vR_KladrStreetRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vR_KladrStreetDataTable()
            {
                base.TableName = "vR_KladrStreet";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vR_KladrStreetDataTable(DataTable dataTable_0)
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
            protected vR_KladrStreetDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetExcavation.vR_KladrStreetDataTable table1 = (DataSetExcavation.vR_KladrStreetDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetExcavation.vR_KladrStreetDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetExcavation.Class323);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetExcavation.Class323 class323_0)
            {
                base.Rows.Add(class323_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class323 method_1(int int_0, string string_0, string string_1, string string_2, string string_3, string string_4, bool bool_0)
            {
                DataSetExcavation.Class323 row = (DataSetExcavation.Class323) base.NewRow();
                object[] objArray1 = new object[8];
                objArray1[1] = int_0;
                objArray1[2] = string_0;
                objArray1[3] = string_1;
                objArray1[4] = string_2;
                objArray1[5] = string_3;
                objArray1[6] = string_4;
                objArray1[7] = bool_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class323 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetExcavation.Class323) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnId = base.Columns["Id"];
                this.columnKladrObjId = base.Columns["KladrObjId"];
                this.columnName = base.Columns["Name"];
                this.columnSocr = base.Columns["Socr"];
                this.columnKladrCode = base.Columns["KladrCode"];
                this.columnIndex = base.Columns["Index"];
                this.columnGNINMB = base.Columns["GNINMB"];
                this.columnDeleted = base.Columns["Deleted"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnId);
                this.columnKladrObjId = new DataColumn("KladrObjId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnKladrObjId);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnSocr = new DataColumn("Socr", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnSocr);
                this.columnKladrCode = new DataColumn("KladrCode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnKladrCode);
                this.columnIndex = new DataColumn("Index", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnIndex);
                this.columnGNINMB = new DataColumn("GNINMB", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnGNINMB);
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
                this.columnKladrObjId.AllowDBNull = false;
                this.columnName.ReadOnly = true;
                this.columnName.MaxLength = 0x5b;
                this.columnSocr.MaxLength = 50;
                this.columnKladrCode.MaxLength = 0x11;
                this.columnIndex.MaxLength = 6;
                this.columnGNINMB.MaxLength = 4;
                this.columnDeleted.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetExcavation.Class323 method_5()
            {
                return (DataSetExcavation.Class323) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetExcavation.Class323 class323_0)
            {
                base.Rows.Remove(class323_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetExcavation.Class323(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vR_KladrStreetRowChanged != null)
                {
                    this.vR_KladrStreetRowChanged(this, new DataSetExcavation.EventArgs182((DataSetExcavation.Class323) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vR_KladrStreetRowChanging != null)
                {
                    this.vR_KladrStreetRowChanging(this, new DataSetExcavation.EventArgs182((DataSetExcavation.Class323) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vR_KladrStreetRowDeleted != null)
                {
                    this.vR_KladrStreetRowDeleted(this, new DataSetExcavation.EventArgs182((DataSetExcavation.Class323) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vR_KladrStreetRowDeleting != null)
                {
                    this.vR_KladrStreetRowDeleting(this, new DataSetExcavation.EventArgs182((DataSetExcavation.Class323) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetExcavation excavation = new DataSetExcavation();
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
                    FixedValue = excavation.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vR_KladrStreetDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = excavation.GetSchemaSerializable();
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn GNINMBColumn
            {
                get
                {
                    return this.columnGNINMB;
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
            public DataColumn IndexColumn
            {
                get
                {
                    return this.columnIndex;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetExcavation.Class323 this[int int_0]
            {
                get
                {
                    return (DataSetExcavation.Class323) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn KladrCodeColumn
            {
                get
                {
                    return this.columnKladrCode;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn KladrObjIdColumn
            {
                get
                {
                    return this.columnKladrObjId;
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
            public DataColumn SocrColumn
            {
                get
                {
                    return this.columnSocr;
                }
            }
        }
    }
}

