using Documents.DataSets;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;

[ToolboxItem(true), HelpKeyword("vs.data.TableAdapterManager"), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), DesignerCategory("code")]
internal class Class217 : Component
{
    private bool bool_0;
    private Class202 class202_0;
    private Class203 class203_0;
    private Class204 class204_0;
    private Class207 class207_0;
    private Class211 class211_0;
    private Class215 class215_0;
    private Enum17 enum17_0;
    private IDbConnection idbConnection_0;

    public Enum17 method_0()
    {
        return this.enum17_0;
    }

    public void method_1(Enum17 enum17_1)
    {
        this.enum17_0 = enum17_1;
    }

    public Class211 method_10()
    {
        return this.class211_0;
    }

    public void method_11(Class211 class211_1)
    {
        this.class211_0 = class211_1;
    }

    public Class215 method_12()
    {
        return this.class215_0;
    }

    public void method_13(Class215 class215_1)
    {
        this.class215_0 = class215_1;
    }

    public bool method_14()
    {
        return this.bool_0;
    }

    public void method_15(bool bool_1)
    {
        this.bool_0 = bool_1;
    }

    public IDbConnection method_16()
    {
        if (this.idbConnection_0 != null)
        {
            return this.idbConnection_0;
        }
        if ((this.class202_0 != null) && (this.class202_0.method_1() != null))
        {
            return this.class202_0.method_1();
        }
        if ((this.class203_0 != null) && (this.class203_0.method_1() != null))
        {
            return this.class203_0.method_1();
        }
        if ((this.class204_0 != null) && (this.class204_0.method_1() != null))
        {
            return this.class204_0.method_1();
        }
        if ((this.class207_0 != null) && (this.class207_0.method_1() != null))
        {
            return this.class207_0.method_1();
        }
        if ((this.class211_0 != null) && (this.class211_0.method_1() != null))
        {
            return this.class211_0.method_1();
        }
        if ((this.class215_0 != null) && (this.class215_0.method_1() != null))
        {
            return this.class215_0.method_1();
        }
        return null;
    }

    public void method_17(IDbConnection idbConnection_1)
    {
        this.idbConnection_0 = idbConnection_1;
    }

    public int method_18()
    {
        int num = 0;
        if (this.class202_0 != null)
        {
            num++;
        }
        if (this.class203_0 != null)
        {
            num++;
        }
        if (this.class204_0 != null)
        {
            num++;
        }
        if (this.class207_0 != null)
        {
            num++;
        }
        if (this.class211_0 != null)
        {
            num++;
        }
        if (this.class215_0 != null)
        {
            num++;
        }
        return num;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private int method_19(OrgDataSet orgDataSet_0, List<DataRow> list_0, List<DataRow> list_1)
    {
        int num = 0;
        if (this.class211_0 != null)
        {
            DataRow[] rowArray = orgDataSet_0.tblAbnAplConnectPointForIndividualUsers.Select(null, null, DataViewRowState.ModifiedCurrent);
            rowArray = this.method_22(rowArray, list_1);
            if ((rowArray != null) && (rowArray.Length != 0))
            {
                num += this.class211_0.vmethod_5(rowArray);
                list_0.AddRange(rowArray);
            }
        }
        if (this.class215_0 != null)
        {
            DataRow[] rowArray2 = orgDataSet_0.tR_Worker.Select(null, null, DataViewRowState.ModifiedCurrent);
            rowArray2 = this.method_22(rowArray2, list_1);
            if ((rowArray2 != null) && (rowArray2.Length != 0))
            {
                num += this.class215_0.vmethod_7(rowArray2);
                list_0.AddRange(rowArray2);
            }
        }
        if (this.class204_0 != null)
        {
            DataRow[] rowArray3 = orgDataSet_0.tblAbnAplForDisconReason.Select(null, null, DataViewRowState.ModifiedCurrent);
            rowArray3 = this.method_22(rowArray3, list_1);
            if ((rowArray3 != null) && (rowArray3.Length != 0))
            {
                num += this.class204_0.vmethod_5(rowArray3);
                list_0.AddRange(rowArray3);
            }
        }
        if (this.class202_0 != null)
        {
            DataRow[] rowArray4 = orgDataSet_0.tblAbnAplForDiscon.Select(null, null, DataViewRowState.ModifiedCurrent);
            rowArray4 = this.method_22(rowArray4, list_1);
            if ((rowArray4 != null) && (rowArray4.Length != 0))
            {
                num += this.class202_0.vmethod_19(rowArray4);
                list_0.AddRange(rowArray4);
            }
        }
        if (this.class203_0 != null)
        {
            DataRow[] rowArray5 = orgDataSet_0.tblAbnAplForDisconObjects.Select(null, null, DataViewRowState.ModifiedCurrent);
            rowArray5 = this.method_22(rowArray5, list_1);
            if ((rowArray5 != null) && (rowArray5.Length != 0))
            {
                num += this.class203_0.vmethod_15(rowArray5);
                list_0.AddRange(rowArray5);
            }
        }
        if (this.class207_0 != null)
        {
            DataRow[] rowArray6 = orgDataSet_0.tblAbnAplForDisconIndividualUsers.Select(null, null, DataViewRowState.ModifiedCurrent);
            rowArray6 = this.method_22(rowArray6, list_1);
            if ((rowArray6 != null) && (rowArray6.Length != 0))
            {
                num += this.class207_0.vmethod_15(rowArray6);
                list_0.AddRange(rowArray6);
            }
        }
        return num;
    }

    public Class202 method_2()
    {
        return this.class202_0;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private int method_20(OrgDataSet orgDataSet_0, List<DataRow> list_0)
    {
        int num = 0;
        if (this.class211_0 != null)
        {
            DataRow[] rowArray = orgDataSet_0.tblAbnAplConnectPointForIndividualUsers.Select(null, null, DataViewRowState.Added);
            if ((rowArray != null) && (rowArray.Length != 0))
            {
                num += this.class211_0.vmethod_5(rowArray);
                list_0.AddRange(rowArray);
            }
        }
        if (this.class215_0 != null)
        {
            DataRow[] rowArray2 = orgDataSet_0.tR_Worker.Select(null, null, DataViewRowState.Added);
            if ((rowArray2 != null) && (rowArray2.Length != 0))
            {
                num += this.class215_0.vmethod_7(rowArray2);
                list_0.AddRange(rowArray2);
            }
        }
        if (this.class204_0 != null)
        {
            DataRow[] rowArray3 = orgDataSet_0.tblAbnAplForDisconReason.Select(null, null, DataViewRowState.Added);
            if ((rowArray3 != null) && (rowArray3.Length != 0))
            {
                num += this.class204_0.vmethod_5(rowArray3);
                list_0.AddRange(rowArray3);
            }
        }
        if (this.class202_0 != null)
        {
            DataRow[] rowArray4 = orgDataSet_0.tblAbnAplForDiscon.Select(null, null, DataViewRowState.Added);
            if ((rowArray4 != null) && (rowArray4.Length != 0))
            {
                num += this.class202_0.vmethod_19(rowArray4);
                list_0.AddRange(rowArray4);
            }
        }
        if (this.class203_0 != null)
        {
            DataRow[] rowArray5 = orgDataSet_0.tblAbnAplForDisconObjects.Select(null, null, DataViewRowState.Added);
            if ((rowArray5 != null) && (rowArray5.Length != 0))
            {
                num += this.class203_0.vmethod_15(rowArray5);
                list_0.AddRange(rowArray5);
            }
        }
        if (this.class207_0 != null)
        {
            DataRow[] rowArray6 = orgDataSet_0.tblAbnAplForDisconIndividualUsers.Select(null, null, DataViewRowState.Added);
            if ((rowArray6 != null) && (rowArray6.Length != 0))
            {
                num += this.class207_0.vmethod_15(rowArray6);
                list_0.AddRange(rowArray6);
            }
        }
        return num;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private int method_21(OrgDataSet orgDataSet_0, List<DataRow> list_0)
    {
        int num = 0;
        if (this.class207_0 != null)
        {
            DataRow[] rowArray = orgDataSet_0.tblAbnAplForDisconIndividualUsers.Select(null, null, DataViewRowState.Deleted);
            if ((rowArray != null) && (rowArray.Length != 0))
            {
                num += this.class207_0.vmethod_15(rowArray);
                list_0.AddRange(rowArray);
            }
        }
        if (this.class203_0 != null)
        {
            DataRow[] rowArray2 = orgDataSet_0.tblAbnAplForDisconObjects.Select(null, null, DataViewRowState.Deleted);
            if ((rowArray2 != null) && (rowArray2.Length != 0))
            {
                num += this.class203_0.vmethod_15(rowArray2);
                list_0.AddRange(rowArray2);
            }
        }
        if (this.class202_0 != null)
        {
            DataRow[] rowArray3 = orgDataSet_0.tblAbnAplForDiscon.Select(null, null, DataViewRowState.Deleted);
            if ((rowArray3 != null) && (rowArray3.Length != 0))
            {
                num += this.class202_0.vmethod_19(rowArray3);
                list_0.AddRange(rowArray3);
            }
        }
        if (this.class204_0 != null)
        {
            DataRow[] rowArray4 = orgDataSet_0.tblAbnAplForDisconReason.Select(null, null, DataViewRowState.Deleted);
            if ((rowArray4 != null) && (rowArray4.Length != 0))
            {
                num += this.class204_0.vmethod_5(rowArray4);
                list_0.AddRange(rowArray4);
            }
        }
        if (this.class215_0 != null)
        {
            DataRow[] rowArray5 = orgDataSet_0.tR_Worker.Select(null, null, DataViewRowState.Deleted);
            if ((rowArray5 != null) && (rowArray5.Length != 0))
            {
                num += this.class215_0.vmethod_7(rowArray5);
                list_0.AddRange(rowArray5);
            }
        }
        if (this.class211_0 != null)
        {
            DataRow[] rowArray6 = orgDataSet_0.tblAbnAplConnectPointForIndividualUsers.Select(null, null, DataViewRowState.Deleted);
            if ((rowArray6 != null) && (rowArray6.Length != 0))
            {
                num += this.class211_0.vmethod_5(rowArray6);
                list_0.AddRange(rowArray6);
            }
        }
        return num;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    private DataRow[] method_22(DataRow[] dataRow_0, List<DataRow> list_0)
    {
        if ((dataRow_0 == null) || (dataRow_0.Length < 1))
        {
            return dataRow_0;
        }
        if ((list_0 == null) || (list_0.Count < 1))
        {
            return dataRow_0;
        }
        List<DataRow> list = new List<DataRow>();
        for (int i = 0; i < dataRow_0.Length; i++)
        {
            DataRow item = dataRow_0[i];
            if (!list_0.Contains(item))
            {
                list.Add(item);
            }
        }
        return list.ToArray();
    }

    public void method_3(Class202 class202_1)
    {
        this.class202_0 = class202_1;
    }

    public Class203 method_4()
    {
        return this.class203_0;
    }

    public void method_5(Class203 class203_1)
    {
        this.class203_0 = class203_1;
    }

    public Class204 method_6()
    {
        return this.class204_0;
    }

    public void method_7(Class204 class204_1)
    {
        this.class204_0 = class204_1;
    }

    public Class207 method_8()
    {
        return this.class207_0;
    }

    public void method_9(Class207 class207_1)
    {
        this.class207_0 = class207_1;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_0(OrgDataSet orgDataSet_0)
    {
        if (orgDataSet_0 == null)
        {
            throw new ArgumentNullException("dataSet");
        }
        if (!orgDataSet_0.HasChanges())
        {
            return 0;
        }
        if ((this.class202_0 != null) && !this.vmethod_2(this.class202_0.method_1()))
        {
            throw new ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManager, должны использовать одинаковую строку подключения.");
        }
        if ((this.class203_0 != null) && !this.vmethod_2(this.class203_0.method_1()))
        {
            throw new ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManager, должны использовать одинаковую строку подключения.");
        }
        if ((this.class204_0 != null) && !this.vmethod_2(this.class204_0.method_1()))
        {
            throw new ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManager, должны использовать одинаковую строку подключения.");
        }
        if ((this.class207_0 != null) && !this.vmethod_2(this.class207_0.method_1()))
        {
            throw new ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManager, должны использовать одинаковую строку подключения.");
        }
        if ((this.class211_0 != null) && !this.vmethod_2(this.class211_0.method_1()))
        {
            throw new ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManager, должны использовать одинаковую строку подключения.");
        }
        if ((this.class215_0 != null) && !this.vmethod_2(this.class215_0.method_1()))
        {
            throw new ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManager, должны использовать одинаковую строку подключения.");
        }
        IDbConnection connection = this.method_16();
        if (connection == null)
        {
            throw new ApplicationException("TableAdapterManager не содержит сведений о подключении. Укажите для каждого адаптера таблицы TableAdapterManager допустимый экземпляр адаптера таблицы.");
        }
        bool flag = false;
        if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
        {
            connection.Close();
        }
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
            flag = true;
        }
        IDbTransaction transaction = connection.BeginTransaction();
        if (transaction == null)
        {
            throw new ApplicationException("Не удается начать транзакцию. Текущее соединение данных не поддерживает транзакции или текущее состояние не позволяет начать транзакцию.");
        }
        List<DataRow> list = new List<DataRow>();
        List<DataRow> list2 = new List<DataRow>();
        List<DataAdapter> list3 = new List<DataAdapter>();
        Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
        int num = 0;
        DataSet dataSet = null;
        if (this.method_14())
        {
            dataSet = new DataSet();
            dataSet.Merge(orgDataSet_0);
        }
        try
        {
            if (this.class202_0 != null)
            {
                dictionary.Add(this.class202_0, this.class202_0.method_1());
                this.class202_0.method_2((SqlConnection) connection);
                this.class202_0.method_4((SqlTransaction) transaction);
                if (this.class202_0.method_0().AcceptChangesDuringUpdate)
                {
                    this.class202_0.method_0().AcceptChangesDuringUpdate = false;
                    list3.Add(this.class202_0.method_0());
                }
            }
            if (this.class203_0 != null)
            {
                dictionary.Add(this.class203_0, this.class203_0.method_1());
                this.class203_0.method_2((SqlConnection) connection);
                this.class203_0.method_4((SqlTransaction) transaction);
                if (this.class203_0.method_0().AcceptChangesDuringUpdate)
                {
                    this.class203_0.method_0().AcceptChangesDuringUpdate = false;
                    list3.Add(this.class203_0.method_0());
                }
            }
            if (this.class204_0 != null)
            {
                dictionary.Add(this.class204_0, this.class204_0.method_1());
                this.class204_0.method_2((SqlConnection) connection);
                this.class204_0.method_4((SqlTransaction) transaction);
                if (this.class204_0.method_0().AcceptChangesDuringUpdate)
                {
                    this.class204_0.method_0().AcceptChangesDuringUpdate = false;
                    list3.Add(this.class204_0.method_0());
                }
            }
            if (this.class207_0 != null)
            {
                dictionary.Add(this.class207_0, this.class207_0.method_1());
                this.class207_0.method_2((SqlConnection) connection);
                this.class207_0.method_4((SqlTransaction) transaction);
                if (this.class207_0.method_0().AcceptChangesDuringUpdate)
                {
                    this.class207_0.method_0().AcceptChangesDuringUpdate = false;
                    list3.Add(this.class207_0.method_0());
                }
            }
            if (this.class211_0 != null)
            {
                dictionary.Add(this.class211_0, this.class211_0.method_1());
                this.class211_0.method_2((SqlConnection) connection);
                this.class211_0.method_4((SqlTransaction) transaction);
                if (this.class211_0.method_0().AcceptChangesDuringUpdate)
                {
                    this.class211_0.method_0().AcceptChangesDuringUpdate = false;
                    list3.Add(this.class211_0.method_0());
                }
            }
            if (this.class215_0 != null)
            {
                dictionary.Add(this.class215_0, this.class215_0.method_1());
                this.class215_0.method_2((SqlConnection) connection);
                this.class215_0.method_4((SqlTransaction) transaction);
                if (this.class215_0.method_0().AcceptChangesDuringUpdate)
                {
                    this.class215_0.method_0().AcceptChangesDuringUpdate = false;
                    list3.Add(this.class215_0.method_0());
                }
            }
            if (this.method_0() == Enum17.const_1)
            {
                num += this.method_19(orgDataSet_0, list, list2);
                num += this.method_20(orgDataSet_0, list2);
            }
            else
            {
                num += this.method_20(orgDataSet_0, list2);
                num += this.method_19(orgDataSet_0, list, list2);
            }
            num += this.method_21(orgDataSet_0, list);
            transaction.Commit();
            if (0 < list2.Count)
            {
                DataRow[] rowArray = new DataRow[list2.Count];
                list2.CopyTo(rowArray);
                for (int j = 0; j < rowArray.Length; j++)
                {
                    rowArray[j].AcceptChanges();
                }
            }
            if (0 >= list.Count)
            {
                return num;
            }
            DataRow[] array = new DataRow[list.Count];
            list.CopyTo(array);
            for (int i = 0; i < array.Length; i++)
            {
                array[i].AcceptChanges();
            }
        }
        catch (Exception exception)
        {
            transaction.Rollback();
            if (this.method_14())
            {
                orgDataSet_0.Clear();
                orgDataSet_0.Merge(dataSet);
            }
            else if (0 < list2.Count)
            {
                DataRow[] rowArray3 = new DataRow[list2.Count];
                list2.CopyTo(rowArray3);
                for (int k = 0; k < rowArray3.Length; k++)
                {
                    DataRow row1 = rowArray3[k];
                    row1.AcceptChanges();
                    row1.SetAdded();
                }
            }
            throw exception;
        }
        finally
        {
            if (flag)
            {
                connection.Close();
            }
            if (this.class202_0 != null)
            {
                this.class202_0.method_2((SqlConnection) dictionary[this.class202_0]);
                this.class202_0.method_4(null);
            }
            if (this.class203_0 != null)
            {
                this.class203_0.method_2((SqlConnection) dictionary[this.class203_0]);
                this.class203_0.method_4(null);
            }
            if (this.class204_0 != null)
            {
                this.class204_0.method_2((SqlConnection) dictionary[this.class204_0]);
                this.class204_0.method_4(null);
            }
            if (this.class207_0 != null)
            {
                this.class207_0.method_2((SqlConnection) dictionary[this.class207_0]);
                this.class207_0.method_4(null);
            }
            if (this.class211_0 != null)
            {
                this.class211_0.method_2((SqlConnection) dictionary[this.class211_0]);
                this.class211_0.method_4(null);
            }
            if (this.class215_0 != null)
            {
                this.class215_0.method_2((SqlConnection) dictionary[this.class215_0]);
                this.class215_0.method_4(null);
            }
            if (0 < list3.Count)
            {
                DataAdapter[] adapterArray = new DataAdapter[list3.Count];
                list3.CopyTo(adapterArray);
                for (int m = 0; m < adapterArray.Length; m++)
                {
                    adapterArray[m].AcceptChangesDuringUpdate = true;
                }
            }
        }
        return num;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    protected virtual void vmethod_1(DataRow[] dataRow_0, DataRelation dataRelation_0, bool bool_1)
    {
        Array.Sort<DataRow>(dataRow_0, new Class218(dataRelation_0, bool_1));
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected virtual bool vmethod_2(IDbConnection idbConnection_1)
    {
        return ((this.idbConnection_0 != null) || (((this.method_16() == null) || (idbConnection_1 == null)) || string.Equals(this.method_16().ConnectionString, idbConnection_1.ConnectionString, StringComparison.Ordinal)));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private class Class218 : IComparer<DataRow>
    {
        private DataRelation dataRelation_0;
        private int int_0;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        internal Class218(DataRelation dataRelation_1, bool bool_0)
        {
            this.dataRelation_0 = dataRelation_1;
            if (bool_0)
            {
                this.int_0 = -1;
            }
            else
            {
                this.int_0 = 1;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public int Compare(DataRow row1, DataRow row2)
        {
            if (row1 == row2)
            {
                return 0;
            }
            if (row1 == null)
            {
                return -1;
            }
            if (row2 != null)
            {
                int num = 0;
                DataRow row = this.method_0(row1, out num);
                int num2 = 0;
                DataRow row3 = this.method_0(row2, out num2);
                if (row == row3)
                {
                    return (this.int_0 * num.CompareTo(num2));
                }
                if (row.Table.Rows.IndexOf(row) < row3.Table.Rows.IndexOf(row3))
                {
                    return -1;
                }
            }
            return 1;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private DataRow method_0(DataRow dataRow_0, out int int_1)
        {
            DataRow row2;
            DataRow row = dataRow_0;
            int_1 = 0;
            IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
            dictionary[dataRow_0] = dataRow_0;
            for (row2 = dataRow_0.GetParentRow(this.dataRelation_0, DataRowVersion.Default); row2 != null; row2 = row2.GetParentRow(this.dataRelation_0, DataRowVersion.Default))
            {
                if (dictionary.ContainsKey(row2))
                {
                    break;
                }
                int_1++;
                row = row2;
                dictionary[row2] = row2;
            }
            if (int_1 == 0)
            {
                dictionary.Clear();
                dictionary[dataRow_0] = dataRow_0;
                for (row2 = dataRow_0.GetParentRow(this.dataRelation_0, DataRowVersion.Original); row2 != null; row2 = row2.GetParentRow(this.dataRelation_0, DataRowVersion.Original))
                {
                    if (dictionary.ContainsKey(row2))
                    {
                        return row;
                    }
                    int_1++;
                    row = row2;
                    dictionary[row2] = row2;
                }
            }
            return row;
        }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public enum Enum17
    {
        const_0,
        const_1
    }
}

