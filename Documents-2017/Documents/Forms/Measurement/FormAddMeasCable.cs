using Documents.DataSets;
using Documents.Forms.Measurement;
using FormLbr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Documents.Forms.Measurement
{
    internal class FormAddMeasCable : FormBase
    {
        private BindingSource bsMeasCable;
        private BindingSource bsCellByTransf;
        private Button btnCancel;
        private Button btnAccept;
        //[CompilerGenerated]
        //private DataSetGES.Class105[] class105_0;
        private DataGridView dgvMeasCable;
        private DataGridViewCheckBoxColumn Selected;
        private DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private DataGridViewComboBoxColumn dgvcIdCell;
        private DataGridViewComboBoxColumn dgvcIdCable;
        private DataGridViewComboBoxColumn dgvcCableMakeup;
        private DataGridViewComboBoxColumn dgvcVoltage;
        private DataGridViewComboBoxColumn dgvcWires;
        private DataGridViewComboBoxColumn dgvcCrossSection;
        private DataGridViewComboBoxColumn dgvcPermisAmperage;
        private DataGridViewTextBoxColumn dgvcId;
        private DataGridViewTextBoxColumn idMeasTrans;
        private DataGridViewTextBoxColumn Icd;
        private DataGridViewTextBoxColumn Icn;
        private DataGridViewTextBoxColumn Iod;
        private DataGridViewTextBoxColumn Ion;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn OldCell;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn idSchmAbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Iad;
        private DataGridViewTextBoxColumn Ian;
        private DataGridViewTextBoxColumn Ibd;
        private DataGridViewTextBoxColumn Ibn;
        //private DataSetGES dsMeasurementN;
        private DataSetMeasurementN dsMeasurementN;
        private IContainer components = null;
        //[CompilerGenerated]
        //private int IdBus;
        //[CompilerGenerated]
        //private int IdMeasurement;
        //[CompilerGenerated]
        //private int IdSubstation;
        //[CompilerGenerated]
        //private int IdTransformer;
        //[CompilerGenerated]
        //private int StartId;
        //[CompilerGenerated]
        //private string DictionaryKey;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        //[CompilerGenerated]
        //private FormMeasurement.TypeDoc typeDoc_0;
        //[CompilerGenerated]
        //private DataSetGES.vJ_CableByCellDataTable vJ_CableByCellDataTable_0;
        public int IdMeasurement
        { get; set; }
        //internal void set_IdMeasurement(int id)
        //{
        //    this.IdMeasurement = id;
        //}
        //internal int get_IdMeasurement()
        //{
        //    return this.IdMeasurement;
        //}
        public int IdSubstation
        {
            get;
            set;
        }
        //internal int method_4()
        //{
        //    return this.IdSubstation;
        //}

        //internal void set_IdSubstation(int id)
        //{
        //    this.IdSubstation = id;
        //}

        public int IdTransformer
        {
            get;
            set;
        }
        //public int IdTransformer;
        //internal int get_IdTransformer()
        //{
        //    return this.IdTransformer;
        //}

        //internal void set_IdTransformer(int id)
        //{
        //    this.IdTransformer = id;
        //}
        /// ////////////////////////
        public string DictionaryKey
        {
            get;
            set;
        }
        //public string DictionaryKey;
        //internal string get_DictionaryKey()
        //{
        //    return this.DictionaryKey;
        //}
        //internal void set_DictionaryKey(string key)
        //{
        //    this.DictionaryKey = key;
        //}
        public int IdBus
        {
            get;
            set;
        }
        //internal int method_0()
        //{
        //    return this.IdBus;
        //}

        //internal void set_IdBus(int int_5)
        //{
        //    this.IdBus = int_5;
        //}
        /// 
        internal DataSetMeasurementN.tJ_MeasCableRow[] Rows
        {
            get;
            private set;
        }

        //internal DataSetMeasurementN.tJ_MeasCableRow[] Rows;
        //internal DataSetMeasurementN.tJ_MeasCableRow[] get_Rows()
        //{
        //    return this.Rows;
        //}
        //private void set_Rows(DataSetMeasurementN.tJ_MeasCableRow[] r)
        //{
        //    this.Rows = r;
        //}
        /// /////////////////////////////
        internal DataSetMeasurementN.vJ_CableByCellDataTable TableCable
        {
            get;
            private set;
        }
        //internal DataSetMeasurementN.vJ_CableByCellDataTable TableCable;
        //internal DataSetMeasurementN.vJ_CableByCellDataTable get_TableCable()
        //{
        //    return this.TableCable;
        //}
        //private void set_TableCable(DataSetMeasurementN.vJ_CableByCellDataTable tbl)
        //{
        //    this.TableCable = tbl;
        //}
        /// /////////////////////////////
        //public int StartId
        //{
        //    get;
        //    set;
        //}
        public int StartId
        {
            get;
            set;
        }
        //internal int get_StartId()
        //{
        //    return this.StartId;
        //}
        //internal void set_StartId(int id)
        //{
        //    this.StartId = id;
        //}

        public FormMeasurement.TypeDoc TypeDoc
        {
            get;
            set;
        }
        //public FormMeasurement.TypeDoc TypeDoc;
        //internal FormMeasurement.TypeDoc get_TypeDoc()
        //{
        //    return this.TypeDoc;
        //}
        //internal void set_TypeDoc(FormMeasurement.TypeDoc typeDoc)
        //{
        //    this.TypeDoc = typeDoc;
        //}
        internal FormAddMeasCable()
        {
            this.InitializeComponent();
        }

        internal FormAddMeasCable(int idBus, int idMeasurement, int idSubstation, int idTransformer, int startId, FormMeasurement.TypeDoc typeDoc)
        {
            this.InitializeComponent();
            this.IdBus = (idBus);
            this.IdMeasurement = (idMeasurement);
            this.IdSubstation = (idSubstation);
            this.IdTransformer = (idTransformer);
            this.StartId = (startId);
            this.TypeDoc = (typeDoc);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void dgvMeasCable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            new DataTable();
            string str = (this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcCableMakeup"].Value is string) ? this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcCableMakeup"].Value.ToString() : "";
            int num = (this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcWires"].Value is int) ? ((int)this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcWires"].Value) : 0;
            double num2 = (this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcCrossSection"].Value is double) ? ((double)this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcCrossSection"].Value) : 0.0;
            double num3 = (this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcPermisAmperage"].Value is double) ? ((double)this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcPermisAmperage"].Value) : 0.0;
            if (e.ColumnIndex == this.dgvMeasCable.Columns["dgvcCableMakeup"].Index)
            {
                DataTable table = this.CreateTableCableMakeup(e.RowIndex, true);
                int length = table.Select("CableMakeup = '" + str + "'").Length;
                if (table.Select("CableMakeup = '" + str + "'").Length == 0)
                {
                    DataRow row = table.NewRow();
                    row["CableMakeup"] = str;
                    table.Rows.InsertAt(row, 0);
                }
            }
            if (e.ColumnIndex == this.dgvMeasCable.Columns["dgvcWires"].Index)
            {
                DataTable table2 = this.CreateTableWires(e.RowIndex, false);
                table2 = this.FillTableWires(e.RowIndex, table2, str);
                if (table2.Select("Wires = " + num.ToString()).Length == 0)
                {
                    DataRow row2 = table2.NewRow();
                    row2["Wires"] = num;
                    table2.Rows.InsertAt(row2, 0);
                }
            }
            if (e.ColumnIndex == this.dgvMeasCable.Columns["dgvcCrossSection"].Index)
            {
                DataTable table3 = this.CreateTableCrossSections(e.RowIndex, false);
                table3 = this.FillTableCrossSections(e.RowIndex, table3, str, num);
                if (table3.Select("CrossSection = " + num2.ToString().Replace(',', '.')).Length == 0)
                {
                    DataRow row3 = table3.NewRow();
                    row3["CrossSection"] = num2;
                    table3.Rows.InsertAt(row3, 0);
                }
            }
            if (e.ColumnIndex == this.dgvMeasCable.Columns["dgvcPermisAmperage"].Index)
            {
                DataTable table4 = this.CreateTablePermisAmperage(e.RowIndex, false);
                table4 = this.FillTableAmperage(e.RowIndex, table4, str, num, num2);
                if (table4.Select("AmperageValue = " + num3.ToString().Replace(',', '.')).Length == 0)
                {
                    DataRow row4 = table4.NewRow();
                    row4["AmperageType"] = num3;
                    row4["AmperageValue"] = num3;
                    table4.Rows.InsertAt(row4, 0);
                }
            }
        }

        private void dgvMeasCable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvMeasCable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void dgvMeasCable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.FillDGVCBByRow(e.RowIndex);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormAddMeasCable_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Class178 class2 = new Class178();
            var source = this.dgvMeasCable.Rows.Cast<DataGridViewRow>()
                .Where(r => (r.Cells["Selected"].Value != null) && ((bool)r
                .Cells["Selected"].Value))
                .Select(r => (int)r.Cells["dgvcId"].Value);

            //var source = from DataGridViewRow row in this.dgvMeasCable.Rows
            //            where row.Cells["Selected"].Value != null && (bool)row.Cells["Selected"].Value
            //            select (int)row.Cells["dgvcId"].Value;

            if ((source.Count() == 0) && (base.DialogResult == DialogResult.OK))
            {
                MessageBox.Show("Не выбрано ни одной строки.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
            else
            {
                int[] ids = source.ToArray();
                //this.method_11(this.dsMeasurementN.tJ_MeasCable.Where(new Func<DataSetGES.Class105, bool>(class2.method_0)).ToArray());
                this.Rows = (this.dsMeasurementN.tJ_MeasCable.Where(r=> ids.Contains(r.id/*id*/)).ToArray());
                this.TableCable = (this.dsMeasurementN.vJ_CableByCell);
            }
        }

        private void FormAddMeasCable_Load(object sender, EventArgs e)
        {
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_CableReference, true);
            var source = base.SelectSqlData("tSchm_ObjList", true, string.Format("WHERE idParent = {0} AND Deleted = ((0)) AND (id = {1} OR Tag = {1})", this.IdSubstation, this.IdBus)).AsEnumerable();

            string str = string.Join(",", source.Select(r => r.Field<int>("Id").ToString()).ToArray());

            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_CellByBus, true, string.Format("WHERE idBus IN ({0}) AND idParent = {1}", str, this.IdSubstation));
            string str2 = string.Join(",", this.dsMeasurementN.vJ_CellByBus.Select(r=>r.id.ToString()).ToArray());

            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_TransfByCell, true, string.Format("WHERE idCell IN ({0})", str2));
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_CableByCell, true, string.Format("WHERE idCell IN ({0})", str2));
            this.CreateNewCableRows(this.dsMeasurementN.tJ_MeasCable, 0);

            //using (IEnumerator row = dsMeasurementN.tJ_MeasCable.Rows.GetEnumerator())
            //{
            //    while (row.MoveNext())
            //    {
            //        ((DataRow)row.Current).EndEdit();
            //    }
            //}
            foreach (DataRow dataRow in this.dsMeasurementN.tJ_MeasCable.Rows)
            {
                dataRow.EndEdit();
            }
        }

        //////[CompilerGenerated]
        //////private bool method_33(Class14<DataSetGES.Class118, DataSetGES.Class108> c1)
        //////private bool method_33(Class14<DataSetMeasurementN.vJ_CellByBusRow, DataSetMeasurementN.vJ_CableByCellRow> c1)
        //////{
        //////    Class172 class2 = new Class172
        //////    {
        //////        c2 = c1
        //////    };
        //////    return (this.dsMeasurementN.vJ_TransfByCell.Where(new Func<DataSetGES.Class107, bool>(class2.method_0)).Count() == 0);
        //////    return (this.dsMeasurementN.vJ_TransfByCell.Where(r => (class2.method_0(r))).Count() == 0);
        //////    return (this.dsMeasurementN.vJ_TransfByCell.Where(r => (r.idCell == c1.id)).Count() == 0);
        //////}
        //////[CompilerGenerated]
        //////private sealed class Class172
        //////{
        //////    public Class14<DataSetMeasurementN.vJ_CellByBusRow, DataSetMeasurementN.vJ_CableByCellRow> c2;//118 CellByBus 108 vJ_CableByCell

        //////    internal bool method_0(DataSetGES.Class107 r)//107 vJ_TransfByCel
        //////    internal bool method_0(DataSetMeasurementN.vJ_TransfByCellRow r)
        //////    {
        //////        return (r.idCell == this.c2.Prop_0.Int32_0);
        //////    }
        //////}

        //internal Class13<int, int, string, int, string> method_5(Class14<DataSetGES.Class118, DataSetGES.Class108> class14_0)
        //{
        //    return new Class13<int, int, string, int, string>
        //        (
        //        (class14_0.Prop_0["idBus"] != null) ? ((int)class14_0.Prop_0["idBus"]) : -1, 
        //        (class14_0.Prop_1["idCell"] != null) ? ((int)class14_0.Prop_1["idCell"]) : -1, 
        //        (class14_0.Prop_0["Name"] != null) ? class14_0.Prop_0["Name"].ToString() : "",
        //        (class14_0.Prop_1["id"] != null) ? ((int)class14_0.Prop_1["id"]) : -1, 
        //        (class14_0.Prop_1["Name"] != null) ? class14_0.Prop_1["Name"].ToString() : ""
        //        );
        //}

        private int CreateNewCableRows(DataSetMeasurementN.tJ_MeasCableDataTable dt, int NumNameCell)
        {
            //Class173 class2 = new Class173
            //{
            //    int_0 = NumNameCell
            //};
            // понятный вариант "0"
            /*
            var source = from c in this.dsMeasurementN.vJ_CellByBus
                         join cab in this.dsMeasurementN.vJ_CableByCell on c.id equals cab.idCell
                         where (from t in this.dsMeasurementN.vJ_TransfByCell
                                where t.idCell == c.id
                                select t).Count() == 0
                         select new
                         {
                             idBus = ((c["idBus"] != null) ? ((int)c["idBus"]) : -1),
                             idCell = ((cab["idCell"] != null) ? ((int)cab["idCell"]) : -1),
                             NameCell = ((c["Name"] != null) ? c["Name"].ToString() : ""),
                             idCable = ((cab["id"] != null) ? ((int)cab["id"]) : -1),
                             NameCable = ((cab["Name"] != null) ? cab["Name"].ToString() : "")
                         };
            var orderedEnumerable = (from s in source.Where(row =>
            {
                if ((from DataSetMeasurementN.tJ_MeasCableRow rowCell in this.dsMeasurementN.tJ_MeasCable
                     where rowCell["idCell"] != DBNull.Value
                     select rowCell.idCell).ToArray<int>().Contains(row.idCell))
                {
                    return !(from DataSetMeasurementN.tJ_MeasCableRow rowCable in this.dsMeasurementN.tJ_MeasCable
                             where rowCable["idCable"] != DBNull.Value
                             select rowCable.idCable).ToArray<int>().Contains(row.idCable);
                }
                return true;
            })
                                     orderby Regex.Match(s.NameCell, "^\\D").Length == 0, Regex.Match(s.NameCell, "\\D*").Value
                                     select s).ThenBy(s =>
                                     {
                                         if (!int.TryParse(Regex.Match(s.NameCell, "\\d+").Value, out NumNameCell))
                                         {
                                             return 0;
                                         }
                                         return int.Parse(Regex.Match(s.NameCell, "\\d+").Value);
                                     });

            */
            //// Оригинал
            //foreach (Class13<int, int, string, int, string> current in dsMeasurementN.vJ_CellByBus
            //    .Join
            //    (this.dsMeasurementN.vJ_CableByCell,
            //    (C_1.C_9__39_0 ?? (C_1.C_9__39_0 = new Func<DataSetGES.Class118, int>(C_1.C_9.method_2))),
            //    (C_1.C_9__39_1 ?? (C_1.C_9__39_1 = new Func<DataSetGES.Class108, int>(C_1.C_9.method_3))),
            //    (C_1.C_9__39_2 ?? (C_1.C_9__39_2 = new Func<DataSetGES.Class118, DataSetGES.Class108, Class14<DataSetGES.Class118, DataSetGES.Class108>>(C_1.C_9.method_4)))
            //    )
            //    .Where(new Func<Class14<DataSetGES.Class118, DataSetGES.Class108>, bool>(this.method_33))
            //    .Select((C_1.C_9__39_5 ?? (C_1.C_9__39_5 = new Func<Class14<DataSetGES.Class118, DataSetGES.Class108>, Class13<int, int, string, int, string>>(C_1.C_9.method_5))))
            //    .Where(new Func<Class13<int, int, string, int, string>, bool>(this.method_34))
            //    .OrderBy((C_1.C_9__39_11 ?? (C_1.C_9__39_11 = new Func<Class13<int, int, string, int, string>, bool>(C_1.C_9.method_10))))
            //    .ThenBy((C_1.C_9__39_12 ?? (C_1.C_9__39_12 = new Func<Class13<int, int, string, int, string>, string>(C_1.C_9.method_11))))
            //    .ThenBy(new Func<Class13<int, int, string, int, string>, int>(class2.method_0)))
            //{
            //    this.dsMeasurementN.vJ_LastCableInfo.Rows.Clear();
            //    if (current.idCable != -1)
            //    {
            //        base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_LastCableInfo, true, string.Format("WHERE idCable = {0} AND idCell = {1} ORDER BY [Year] DESC", current.idCable, current.idCell), null, false, 1);
            //    }
            //    DataSetMeasurementN.tJ_MeasCableRow row = dt.NewtJ_MeasCableRow();
            //    row.id = (dt.Rows.Count > 0) ? (dt.Min(r => r.id) - 1) : this.StartId;
            //    row.idMeasurement = this.IdMeasurement;
            //    row.idBus = this.IdBus;
            //    row.idTransf = this.IdTransformer;
            //    row["idCable"] = current.idCable;
            //    row.idCell = current.idCell;
            //    if (this.dsMeasurementN.vJ_LastCableInfo.Rows.Count > 0)
            //    {
            //        row["Address"] = this.dsMeasurementN.vJ_LastCableInfo.First()["Address"];
            //        row["Company"] = this.dsMeasurementN.vJ_LastCableInfo.First()["Company"];
            //        row["Makeup"] = this.dsMeasurementN.vJ_LastCableInfo.First()["Makeup"];
            //        row["Voltage"] = this.dsMeasurementN.vJ_LastCableInfo.First()["Voltage"];
            //        row["Wires"] = this.dsMeasurementN.vJ_LastCableInfo.First()["Wires"];
            //        row["CrossSection"] = this.dsMeasurementN.vJ_LastCableInfo.First()["CrossSection"];
            //        row["PermisAmperage"] = this.dsMeasurementN.vJ_LastCableInfo.First()["PermisAmperage"];
            //    }
            //    else
            //    {
            //        row.Makeup = "";
            //        row.Voltage = -1;
            //        row.PermisAmperage = 0.0;
            //    }
            //    row.Deleted = false;
            //    dt.AddtJ_MeasCableRow(row);
            //}
            //return class2.int_0;

            var current0 = dsMeasurementN.vJ_CellByBus
                    .Join(
                        dsMeasurementN.vJ_CableByCell,
                        c => c.id,
                        cab => cab.idCell,
                        (c, cab) => new
                        {
                            c,
                            cab
                        }
                        );

            var current1 = current0.Where(r => dsMeasurementN.vJ_TransfByCell.Where(t => (t.idCell == r.c.id)).Count() == 0);

            ////// /* r - должен быть типом DataSetMeasurementN.vJ_CellByBusRow*/

            var current2 = current1
            .Select(r => new
            {
                idBus = (r.c.idBus != 0 ? (int)r.c.idBus : -1),
                idCell = (r.cab.idCell != 0 ? (int)r.cab.idCell : -1),
                NameCell = (r.c.Name != null ? r.c.Name.ToString() : ""),
                idCable = (r.cab.id != 0 ? (int)r.cab.id : -1),
                NameCable = (r.cab.Name != null ? r.cab.Name.ToString() : "")
            });
            var currene3 = current2.Where(row => (!this.dsMeasurementN.tJ_MeasCable.Cast<DataSetMeasurementN.tJ_MeasCableRow>()
                   .Where(r => r["idCell"] != DBNull.Value)
                   .Select(r => r.idCell)
                   .ToArray()
                   .Contains<int>(row.idCell) ||
                   !this.dsMeasurementN.tJ_MeasCable.Cast<DataSetMeasurementN.tJ_MeasCableRow>()
                   .Where(s => s["idCable"] != DBNull.Value)
                   .Select(s => s.idCable)
                   .ToArray()
                   .Contains<int>(row.idCable)))

                   .OrderBy(s => Regex.Match(s.NameCell, @"^\D").Length == 0)

               .ThenBy(s => Regex.Match(s.NameCell, @"\D*").Value)

             .ThenBy(s =>
             {
                 if (!int.TryParse(Regex.Match(s.NameCell, @"\d+").Value, out NumNameCell))//int_0 = NumNameCell
                 {
                     return 0;
                 }
                 return int.Parse(Regex.Match(s.NameCell, @"\d+").Value);
             })
                  ;
            foreach (var current in currene3)
            {
                this.dsMeasurementN.vJ_LastCableInfo.Rows.Clear();
                if (current.idCable != -1)
                {
                    base.SelectSqlData(this.dsMeasurementN.vJ_LastCableInfo, true, string.Format("WHERE idCable = {0} AND idCell = {1} ORDER BY [Year] DESC", current.idCable, current.idCell), null, false, 1);
                }
                DataSetMeasurementN.tJ_MeasCableRow row = dt.NewtJ_MeasCableRow();
                row.id = (dt.Rows.Count > 0) ? (dt.Min(r => r.id) - 1) : this.StartId;
                row.idMeasurement = this.IdMeasurement;
                row.idBus = this.IdBus;
                row.idTransf = this.IdTransformer;
                row["idCable"] = current.idCable;
                row.idCell = current.idCell;
                if (this.dsMeasurementN.vJ_LastCableInfo.Rows.Count > 0)
                {
                    row["Address"] = this.dsMeasurementN.vJ_LastCableInfo.First()["Address"];
                    row["Company"] = this.dsMeasurementN.vJ_LastCableInfo.First()["Company"];
                    row["Makeup"] = this.dsMeasurementN.vJ_LastCableInfo.First()["Makeup"];
                    row["Voltage"] = this.dsMeasurementN.vJ_LastCableInfo.First()["Voltage"];
                    row["Wires"] = this.dsMeasurementN.vJ_LastCableInfo.First()["Wires"];
                    row["CrossSection"] = this.dsMeasurementN.vJ_LastCableInfo.First()["CrossSection"];
                    row["PermisAmperage"] = this.dsMeasurementN.vJ_LastCableInfo.First()["PermisAmperage"];
                }
                else
                {
                    row.Makeup = "";
                    row.Voltage = -1;
                    row.PermisAmperage = 0.0;
                }
                row.Deleted = false;
                dt.AddtJ_MeasCableRow(row);
            }
            return NumNameCell;
        }

        private void FillDGVCBByRow(int index)
        {
            try
            {
                DataTable table = this.dsMeasurementN.Tables["dtCable_" + this.IdTransformer.ToString() + "_" + index.ToString()];
                if (((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DataSource == null)
                {
                    if (table == null)
                    {
                        table = new DataTable("dtCable_" + this.IdTransformer.ToString() + "_" + index.ToString());
                        table.Columns.Add("Id", typeof(int));
                        table.Columns.Add("Name", typeof(string));
                        this.dsMeasurementN.Tables.Add(table);
                    }
                    table.Rows.Clear();
                    foreach (var current in this.dsMeasurementN.vJ_CableByCell.AsEnumerable()
                        .Where(r => r["id"] != DBNull.Value)
                        .GroupBy(r => new { r.id, r.Name })
                        .Select(r => new { IdCable = r.Key.id, NameCable = r.Key.Name }))
                    {
                        object[] values = new object[] { current.IdCable, current.NameCable };
                        table.Rows.Add(values);
                    }
                    ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DataSource = table;
                    ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DisplayMember = "Name";
                    ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).ValueMember = "Id";
                }
                string str = (this.dgvMeasCable.Rows[index].Cells["dgvcCableMakeup"].Value is string) ? this.dgvMeasCable.Rows[index].Cells["dgvcCableMakeup"].Value.ToString() : "";
                DataTable table2 = this.CreateTableCableMakeup(index, true);
                int length = table2.Select("CableMakeup = '" + str + "'").Length;
                if (table2.Select("CableMakeup = '" + str + "'").Length == 0)
                {
                    DataRow row = table2.NewRow();
                    row["CableMakeup"] = str;
                    table2.Rows.InsertAt(row, 0);
                }
                int num = (this.dgvMeasCable.Rows[index].Cells["dgvcWires"].Value is int) ? ((int)this.dgvMeasCable.Rows[index].Cells["dgvcWires"].Value) : 0;
                DataTable table3 = this.CreateTableWires(index, false);
                table3 = this.FillTableWires(index, table3, str);
                if (table3.Select("Wires = " + num.ToString()).Length == 0)
                {
                    DataRow row2 = table3.NewRow();
                    row2["Wires"] = num;
                    table3.Rows.InsertAt(row2, 0);
                }
                double num2 = (this.dgvMeasCable.Rows[index].Cells["dgvcCrossSection"].Value is double) ? ((double)this.dgvMeasCable.Rows[index].Cells["dgvcCrossSection"].Value) : 0.0;
                DataTable table4 = this.CreateTableCrossSections(index, false);
                table4 = this.FillTableCrossSections(index, table4, str, num);
                if (table4.Select("CrossSection = " + num2.ToString().Replace(',', '.')).Length == 0)
                {
                    DataRow row3 = table4.NewRow();
                    row3["CrossSection"] = num2;
                    table4.Rows.InsertAt(row3, 0);
                }
                double num3 = (this.dgvMeasCable.Rows[index].Cells["dgvcPermisAmperage"].Value is double) ? ((double)this.dgvMeasCable.Rows[index].Cells["dgvcPermisAmperage"].Value) : 0.0;
                DataTable table5 = this.CreateTablePermisAmperage(index, false);
                table5 = this.FillTableAmperage(index, table5, str, num, num2);
                if (table5.Select("AmperageValue = " + num3.ToString().Replace(',', '.')).Length == 0)
                {
                    DataRow row4 = table5.NewRow();
                    row4["AmperageType"] = num3;
                    row4["AmperageValue"] = num3;
                    table5.Rows.InsertAt(row4, 0);
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message, "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private DataTable FillTableCableMakeup(int index, DataTable dt)//          FillTableCableMakeup
        {
            dt = this.dsMeasurementN.Tables["dtCableMakeup_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            dt.Rows.Clear();
            var enumerable = this.dsMeasurementN.vJ_CableReference.AsEnumerable()
                .OrderBy(r => r.CableMakeup)
                .Select(r => r.CableMakeup)
                .Distinct();


            foreach (string str in enumerable)
            {
                object[] values = new object[] { str };
                dt.Rows.Add(values);
            }
            return dt;
        }

        private DataTable FillTableWires(int index, DataTable dt)
        {
            dt = this.dsMeasurementN.Tables["dtWires_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            dt.Rows.Clear();
            var enumerable = this.dsMeasurementN.vJ_CableReference.AsEnumerable()
                .OrderBy(r=> r.Wires)
                .Select(r => r.Wires)
                .Distinct();

            foreach (int num2 in enumerable)
            {
                object[] values = new object[] { num2 };
                dt.Rows.Add(values);
            }
            return dt;
        }

        private DataTable FillTableWires(int index, DataTable dt, string makeup)
        {
            dt = this.dsMeasurementN.Tables["dtWires_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            dt.Rows.Clear();
            foreach (int num2 in this.dsMeasurementN.vJ_CableReference.AsEnumerable()
                .Where(r => r.CableMakeup == makeup)
                .OrderBy(r => r.Wires)
                .Select(r => r.Wires)
                .Distinct())
            {
                object[] values = new object[] { num2 };
                dt.Rows.Add(values);
            }
            return dt;
        }

        private DataTable FillTableCrossSections(int index, DataTable dt)
        {
            dt = this.dsMeasurementN.Tables["dtCrossSection_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            dt.Rows.Clear();
            var enumerable = this.dsMeasurementN.vJ_CableReference.AsEnumerable()
                .Where(r => r.Voltage == 0.4M)
                .OrderBy(r => r.CrossSection)
                .Select(r => r.CrossSection)
                .Distinct();
            foreach (int num2 in enumerable)
            {
                object[] values = new object[] { num2 };
                dt.Rows.Add(values);
            }
            return dt;
        }

        private DataTable FillTableCrossSections(int index, DataTable dt, string makeup, int wires)
        {
     
            dt = this.dsMeasurementN.Tables["dtCrossSection_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            dt.Rows.Clear();
            var enumerable = this.dsMeasurementN.vJ_CableReference.AsEnumerable()
                .Where(r=> ((r.CableMakeup == makeup) && (r.Wires == wires)) && (r.Voltage == 0.4M))
                .OrderBy(r=> r.CrossSection)
                .Select(r => r.CrossSection)
                .Distinct();

            foreach (int num2 in enumerable)
            {
                object[] values = new object[] { num2 };
                dt.Rows.Add(values);
            }
            return dt;
        }

        private DataTable FillTableAmperage(int index, DataTable dt)
        {
            dt = this.dsMeasurementN.Tables["dtPermisAmperage_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            dt.Rows.Clear();
            var enumerable = this.dsMeasurementN.vJ_CableReference.AsEnumerable()
                .Where(r => r.Voltage == 0.4M)
                .OrderBy(r => r.AmperageValue)
                .Select(r => new { r.AmperageValue, r.AmperageType })
                .Distinct();

            foreach (var current in enumerable)
            {
                object[] objArray1 = new object[] { current.AmperageValue, current.AmperageType };
                dt.Rows.Add(objArray1);
            }
            object[] values = new object[] { 0 };
            dt.Rows.Add(values);
            return dt;
        }

        private DataTable FillTableAmperage(int index, DataTable dt, string makeup, int wires, double crossSection)
        {
            dt = this.dsMeasurementN.Tables["dtPermisAmperage_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            dt.Rows.Clear();
            var enumerable = this.dsMeasurementN.vJ_CableReference.AsEnumerable()
                .Where(r => (((r.CableMakeup == makeup) && (r.Wires == wires)) && (r.CrossSection == crossSection)) && (r.Voltage == 0.4M))
                .OrderBy(r => r.AmperageValue)
                .Distinct();

            foreach (var current in enumerable)
            {
                object[] objArray1 = new object[] { current.AmperageValue, current.AmperageType };
                dt.Rows.Add(objArray1);
            }
            object[] values = new object[] { 0 };
            dt.Rows.Add(values);
            return dt;
        }

        private DataTable CreateTableCableMakeup(int index, bool fill)
        {
            DataTable table;
            if (this.dsMeasurementN.Tables.Contains("dtCableMakeup_" + this.IdTransformer.ToString() + "_" + index.ToString()))
            {
                table = this.dsMeasurementN.Tables["dtCableMakeup_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            }
            else
            {
                table = new DataTable("dtCableMakeup_" + this.IdTransformer.ToString() + "_" + index.ToString());
                table.Columns.Add("CableMakeup", typeof(string));
                this.dsMeasurementN.Tables.Add(table);
            }
            table = this.FillTableCableMakeup(index, table);
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCableMakeup"]).DataSource = table;
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCableMakeup"]).DisplayMember = "CableMakeup";
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCableMakeup"]).ValueMember = "CableMakeup";
            return table;
        }

        private DataTable CreateTablePermisAmperage(int index, bool fill)
        {
            DataTable table;
            if (this.dsMeasurementN.Tables.Contains("dtPermisAmperage_" + this.IdTransformer.ToString() + "_" + index.ToString()))
            {
                table = this.dsMeasurementN.Tables["dtPermisAmperage_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            }
            else
            {
                table = new DataTable("dtPermisAmperage_" + this.IdTransformer.ToString() + "_" + index.ToString());
                table.Columns.Add("AmperageValue", typeof(double));
                table.Columns.Add("AmperageType", typeof(string));
                this.dsMeasurementN.Tables.Add(table);
            }
            this.FillTableAmperage(index, table);
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcPermisAmperage"]).DataSource = table;
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcPermisAmperage"]).DisplayMember = "AmperageType";
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcPermisAmperage"]).ValueMember = "AmperageValue";
            return table;
        }

        private DataTable CreateTableCrossSections(int index, bool fill)
        {
            DataTable table;
            if (this.dsMeasurementN.Tables.Contains("dtCrossSection_" + this.IdTransformer.ToString() + "_" + index.ToString()))
            {
                table = this.dsMeasurementN.Tables["dtCrossSection_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            }
            else
            {
                table = new DataTable("dtCrossSection_" + this.IdTransformer.ToString() + "_" + index.ToString());
                table.Columns.Add("CrossSection", typeof(double));
                this.dsMeasurementN.Tables.Add(table);
            }
            this.FillTableCrossSections(index, table);
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCrossSection"]).DataSource = table;
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCrossSection"]).DisplayMember = "CrossSection";
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCrossSection"]).ValueMember = "CrossSection";
            return table;
        }

        private DataTable CreateTableWires(int index, bool fill)
        {
            DataTable table;
            if (this.dsMeasurementN.Tables.Contains("dtWires_" + this.IdTransformer.ToString() + "_" + index.ToString()))
            {
                table = this.dsMeasurementN.Tables["dtWires_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            }
            else
            {
                table = new DataTable("dtWires_" + this.IdTransformer.ToString() + "_" + index.ToString());
                table.Columns.Add("Wires", typeof(int));
                this.dsMeasurementN.Tables.Add(table);
            }
            this.FillTableWires(index, table);
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcWires"]).DataSource = table;
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcWires"]).DisplayMember = "Wires";
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcWires"]).ValueMember = "Wires";
            return table;
        }

        private DataTable CreateTableCables(int index, DataTable dt, int id)
        {
            //Class177 class2 = new Class177
            //{
            //    int_0 = id
            //};
            if (((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DataSource == null)
            {
                dt = this.dsMeasurementN.Tables["dtCable_" + this.IdTransformer.ToString() + "_" + index.ToString()];
                if (dt == null)
                {
                    dt = new DataTable("dtCable_" + this.IdTransformer.ToString() + "_" + index.ToString());
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Name", typeof(string));
                    this.dsMeasurementN.Tables.Add(dt);
                }
                dt.Rows.Clear();

                var enumerable = this.dsMeasurementN.vJ_CableByCell.AsEnumerable()
                    .Where(r => (r.idCell == id) && (r["id"] != DBNull.Value))
                    .GroupBy(r => new { r.id, r.Name })
                    .Select(g => new { IdCable = g.Key.id, NameCable = g.Key.Name });

                foreach (var current in enumerable)
                    //(Class9<int, string> class3 in this.dsMeasurementN.vJ_CableByCell.AsEnumerable().Where(new Func<DataSetGES.Class108, bool>(class2.method_0)).GroupBy((C_1.C_9__56_1 ?? (C_1.C_9__56_1 = new Func<DataSetGES.Class108, Class8<int, string>>(C_1.C_9.method_31)))).Select(C_1.C_9__56_2 ?? (C_1.C_9__56_2 = new Func<IGrouping<Class8<int, string>, DataSetGES.Class108>, Class9<int, string>>(C_1.C_9.method_32))))
                {
                    object[] values = new object[] { current.IdCable, current.NameCable };
                    dt.Rows.Add(values);
                }
                ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DataSource = dt;
                ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DisplayMember = "Name";
                ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).ValueMember = "Id";
            }
            return dt;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMeasCable = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIdCell = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsCellByTransf = new System.Windows.Forms.BindingSource(this.components);
            this.dsMeasurementN = new Documents.DataSets.DataSetMeasurementN();
            this.OldCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIdCable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSchmAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCableMakeup = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcVoltage = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcWires = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcCrossSection = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcPermisAmperage = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Iad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ibd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ibn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsMeasCable = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasCable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCellByTransf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasurementN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasCable)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvMeasCable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 294);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvMeasCable
            // 
            this.dgvMeasCable.AllowUserToAddRows = false;
            this.dgvMeasCable.AllowUserToDeleteRows = false;
            this.dgvMeasCable.AllowUserToResizeRows = false;
            this.dgvMeasCable.AutoGenerateColumns = false;
            this.dgvMeasCable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasCable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMeasCable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasCable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.dgvcId,
            this.dgvcIdCell,
            this.OldCell,
            this.dgvcIdCable,
            this.Address,
            this.Company,
            this.idSchmAbnDataGridViewTextBoxColumn,
            this.dgvcCableMakeup,
            this.dgvcVoltage,
            this.dgvcWires,
            this.dgvcCrossSection,
            this.dgvcPermisAmperage,
            this.Iad,
            this.Ian,
            this.Ibd,
            this.Ibn,
            this.Icd,
            this.Icn,
            this.Iod,
            this.Ion,
            this.commentDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvMeasCable, 6);
            this.dgvMeasCable.DataSource = this.bsMeasCable;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeasCable.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMeasCable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeasCable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMeasCable.Location = new System.Drawing.Point(3, 3);
            this.dgvMeasCable.MultiSelect = false;
            this.dgvMeasCable.Name = "dgvMeasCable";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasCable.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMeasCable.RowHeadersVisible = false;
            this.dgvMeasCable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasCable.Size = new System.Drawing.Size(742, 249);
            this.dgvMeasCable.TabIndex = 21;
            this.dgvMeasCable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMeasCable_CellBeginEdit);
            this.dgvMeasCable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeasCable_CellEndEdit);
            this.dgvMeasCable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMeasCable_DataError);
            this.dgvMeasCable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMeasCable_RowsAdded);
            // 
            // Selected
            // 
            this.Selected.HeaderText = "";
            this.Selected.Name = "Selected";
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selected.Width = 30;
            // 
            // dgvcId
            // 
            this.dgvcId.DataPropertyName = "id";
            this.dgvcId.HeaderText = "id";
            this.dgvcId.Name = "dgvcId";
            this.dgvcId.ReadOnly = true;
            this.dgvcId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcId.Visible = false;
            this.dgvcId.Width = 40;
            // 
            // dgvcIdCell
            // 
            this.dgvcIdCell.DataPropertyName = "idCell";
            this.dgvcIdCell.DataSource = this.bsCellByTransf;
            this.dgvcIdCell.DisplayMember = "Name";
            this.dgvcIdCell.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgvcIdCell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvcIdCell.HeaderText = "№ руб.";
            this.dgvcIdCell.Name = "dgvcIdCell";
            this.dgvcIdCell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcIdCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcIdCell.ValueMember = "id";
            this.dgvcIdCell.Width = 30;
            // 
            // bsCellByTransf
            // 
            this.bsCellByTransf.DataMember = "vJ_CellByBus";
            this.bsCellByTransf.DataSource = this.dsMeasurementN;
            this.bsCellByTransf.Sort = "Name";
            // 
            // dsMeasurementN
            // 
            this.dsMeasurementN.DataSetName = "DataSetGES";
            this.dsMeasurementN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OldCell
            // 
            this.OldCell.DataPropertyName = "OldCell";
            this.OldCell.HeaderText = "№ ст. руб.";
            this.OldCell.Name = "OldCell";
            this.OldCell.ReadOnly = true;
            this.OldCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.OldCell.Visible = false;
            this.OldCell.Width = 50;
            // 
            // dgvcIdCable
            // 
            this.dgvcIdCable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcIdCable.DataPropertyName = "idCable";
            this.dgvcIdCable.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgvcIdCable.DropDownWidth = 200;
            this.dgvcIdCable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvcIdCable.HeaderText = "Кабель";
            this.dgvcIdCable.Name = "dgvcIdCable";
            this.dgvcIdCable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcIdCable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Адрес объекта";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Наименование объекта";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Visible = false;
            // 
            // idSchmAbnDataGridViewTextBoxColumn
            // 
            this.idSchmAbnDataGridViewTextBoxColumn.DataPropertyName = "idSchmAbn";
            this.idSchmAbnDataGridViewTextBoxColumn.HeaderText = "idSchmAbn";
            this.idSchmAbnDataGridViewTextBoxColumn.Name = "idSchmAbnDataGridViewTextBoxColumn";
            this.idSchmAbnDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idSchmAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // dgvcCableMakeup
            // 
            this.dgvcCableMakeup.DataPropertyName = "Makeup";
            this.dgvcCableMakeup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvcCableMakeup.HeaderText = "Марка кабеля";
            this.dgvcCableMakeup.Name = "dgvcCableMakeup";
            this.dgvcCableMakeup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcCableMakeup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcCableMakeup.Visible = false;
            this.dgvcCableMakeup.Width = 70;
            // 
            // dgvcVoltage
            // 
            this.dgvcVoltage.DataPropertyName = "Voltage";
            this.dgvcVoltage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvcVoltage.HeaderText = "Напр.";
            this.dgvcVoltage.Name = "dgvcVoltage";
            this.dgvcVoltage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcVoltage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcVoltage.Visible = false;
            this.dgvcVoltage.Width = 70;
            // 
            // dgvcWires
            // 
            this.dgvcWires.DataPropertyName = "Wires";
            dataGridViewCellStyle2.Format = "N0";
            this.dgvcWires.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcWires.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvcWires.HeaderText = "Кол-во жил";
            this.dgvcWires.Name = "dgvcWires";
            this.dgvcWires.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcWires.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcWires.Visible = false;
            this.dgvcWires.Width = 40;
            // 
            // dgvcCrossSection
            // 
            this.dgvcCrossSection.DataPropertyName = "CrossSection";
            this.dgvcCrossSection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvcCrossSection.HeaderText = "Сечение";
            this.dgvcCrossSection.Name = "dgvcCrossSection";
            this.dgvcCrossSection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcCrossSection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcCrossSection.Visible = false;
            this.dgvcCrossSection.Width = 50;
            // 
            // dgvcPermisAmperage
            // 
            this.dgvcPermisAmperage.DataPropertyName = "PermisAmperage";
            this.dgvcPermisAmperage.DropDownWidth = 90;
            this.dgvcPermisAmperage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvcPermisAmperage.HeaderText = "Допуст. нагр., А";
            this.dgvcPermisAmperage.Name = "dgvcPermisAmperage";
            this.dgvcPermisAmperage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcPermisAmperage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcPermisAmperage.Visible = false;
            this.dgvcPermisAmperage.Width = 60;
            // 
            // Iad
            // 
            this.Iad.DataPropertyName = "Iad";
            dataGridViewCellStyle3.Format = "N0";
            this.Iad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Iad.HeaderText = "А дн.";
            this.Iad.Name = "Iad";
            this.Iad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Iad.Visible = false;
            this.Iad.Width = 35;
            // 
            // Ian
            // 
            this.Ian.DataPropertyName = "Ian";
            dataGridViewCellStyle4.Format = "N0";
            this.Ian.DefaultCellStyle = dataGridViewCellStyle4;
            this.Ian.HeaderText = "А вч.";
            this.Ian.Name = "Ian";
            this.Ian.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Ian.Visible = false;
            this.Ian.Width = 35;
            // 
            // Ibd
            // 
            this.Ibd.DataPropertyName = "Ibd";
            dataGridViewCellStyle5.Format = "N0";
            this.Ibd.DefaultCellStyle = dataGridViewCellStyle5;
            this.Ibd.HeaderText = "В дн.";
            this.Ibd.Name = "Ibd";
            this.Ibd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Ibd.Visible = false;
            this.Ibd.Width = 35;
            // 
            // Ibn
            // 
            this.Ibn.DataPropertyName = "Ibn";
            dataGridViewCellStyle6.Format = "N0";
            this.Ibn.DefaultCellStyle = dataGridViewCellStyle6;
            this.Ibn.HeaderText = "В вч.";
            this.Ibn.Name = "Ibn";
            this.Ibn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Ibn.Visible = false;
            this.Ibn.Width = 35;
            // 
            // Icd
            // 
            this.Icd.DataPropertyName = "Icd";
            dataGridViewCellStyle7.Format = "N0";
            this.Icd.DefaultCellStyle = dataGridViewCellStyle7;
            this.Icd.HeaderText = "С дн.";
            this.Icd.Name = "Icd";
            this.Icd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Icd.Visible = false;
            this.Icd.Width = 35;
            // 
            // Icn
            // 
            this.Icn.DataPropertyName = "Icn";
            dataGridViewCellStyle8.Format = "N0";
            this.Icn.DefaultCellStyle = dataGridViewCellStyle8;
            this.Icn.HeaderText = "С вч.";
            this.Icn.Name = "Icn";
            this.Icn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Icn.Visible = false;
            this.Icn.Width = 35;
            // 
            // Iod
            // 
            this.Iod.DataPropertyName = "Iod";
            dataGridViewCellStyle9.Format = "N0";
            this.Iod.DefaultCellStyle = dataGridViewCellStyle9;
            this.Iod.HeaderText = "0 дн.";
            this.Iod.Name = "Iod";
            this.Iod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Iod.Visible = false;
            this.Iod.Width = 35;
            // 
            // Ion
            // 
            this.Ion.DataPropertyName = "Ion";
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.Ion.DefaultCellStyle = dataGridViewCellStyle10;
            this.Ion.HeaderText = "0 вч.";
            this.Ion.Name = "Ion";
            this.Ion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Ion.Visible = false;
            this.Ion.Width = 35;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.commentDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // bsMeasCable
            // 
            this.bsMeasCable.DataMember = "tJ_MeasCable";
            this.bsMeasCable.DataSource = this.dsMeasurementN;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAccept, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 258);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(742, 33);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(636, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAccept.Location = new System.Drawing.Point(517, 3);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(99, 27);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Применить";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btn_Click);
            // 
            // FormAddMeasCable
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(748, 294);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAddMeasCable";
            this.Text = "Добавление недостающих кабельных линий";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddMeasCable_FormClosing);
            this.Load += new System.EventHandler(this.FormAddMeasCable_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasCable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCellByTransf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasurementN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasCable)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        //[CompilerGenerated]
        //private bool method_34(Class13<int, int, string, int, string> row)
        //{
        //    return (!this.dsMeasurementN.tJ_MeasCable.Cast<DataSetGES.Class105>()
        //        .Where((C_1.C_9__39_7 ?? (C_1.C_9__39_7 = new Func<DataSetGES.Class105, bool>(C_1.C_9.method_6))))
        //        .Select((C_1.C_9__39_8 ?? (C_1.C_9__39_8 = new Func<DataSetGES.Class105, int>(C_1.C_9.method_7))))
        //        .ToArray()
        //        .Contains<int>(row.idCell) || !this.dsMeasurementN.tJ_MeasCable.Cast<DataSetGES.Class105>()
        //        .Where((C_1.C_9__39_9 ?? (C_1.C_9__39_9 = new Func<DataSetGES.Class105, bool>(C_1.C_9.method_8))))
        //        .Select((C_1.C_9__39_10 ?? (C_1.C_9__39_10 = new Func<DataSetGES.Class105, int>(C_1.C_9.method_9))))
        //        .ToArray().Contains<int>(row.idCable));
        //}
        // tJ_MeasCable = 105
        ////private bool method_34(Class13<int, int, string, int, string> row)
        ////{
        ////    return (!this.dsMeasurementN.tJ_MeasCable.Cast<DataSetGES.Class105>()
        ////        .Where(r => r["idCell"] != DBNull.Value)
        ////        .Select(r => r.idCell)
        ////        .ToArray()
        ////        .Contains<int>(row.idCell) || !this.dsMeasurementN.tJ_MeasCable.Cast<DataSetGES.Class105>()
        ////        .Where(s => s["idCable"] != DBNull.Value)
        ////        .Select(s => s.idCable)
        ////        .ToArray()
        ////        .Contains<int>(row.idCable));
        ////}

        /// ////////////////////
        //[Serializable, CompilerGenerated]
        //private sealed class C_1
        //{
        //    public static readonly FormAddMeasCable.C_1 C_9 = new FormAddMeasCable.C_1();
        //    public static Func<DataRow, string> C_9__38_0;
        //    public static Func<DataSetGES.Class118, string> C_9__38_1;
        //    public static Func<DataSetGES.Class118, int> C_9__39_0;
        //    public static Func<DataSetGES.Class108, int> C_9__39_1;
        //    public static Func<DataSetGES.Class105, int> C_9__39_10;
        //    public static Func<Class13<int, int, string, int, string>, bool> C_9__39_11;
        //    public static Func<Class13<int, int, string, int, string>, string> C_9__39_12;
        //    public static Func<DataSetGES.Class105, int> C_9__39_14;
        //    public static Func<DataSetGES.Class118, DataSetGES.Class108, Class14<DataSetGES.Class118, DataSetGES.Class108>> C_9__39_2;
        //    public static Func<Class14<DataSetGES.Class118, DataSetGES.Class108>, Class13<int, int, string, int, string>> C_9__39_5;
        //    public static Func<DataSetGES.Class105, bool> C_9__39_7;
        //    public static Func<DataSetGES.Class105, int> C_9__39_8;
        //    public static Func<DataSetGES.Class105, bool> C_9__39_9;
        //    public static Func<DataSetGES.Class108, bool> C_9__44_0;
        //    public static Func<DataSetGES.Class108, Class8<int, string>> C_9__44_1;
        //    public static Func<IGrouping<Class8<int, string>, DataSetGES.Class108>, Class9<int, string>> C_9__44_2;
        //    public static Func<DataSetGES.Class78, string> C_9__45_0;
        //    public static Func<DataSetGES.Class78, string> C_9__45_1;
        //    public static Func<DataSetGES.Class78, int> C_9__46_0;
        //    public static Func<DataSetGES.Class78, int> C_9__46_1;
        //    public static Func<DataSetGES.Class78, int> C_9__47_1;
        //    public static Func<DataSetGES.Class78, int> C_9__47_2;
        //    public static Func<DataSetGES.Class78, bool> C_9__48_0;
        //    public static Func<DataSetGES.Class78, double> C_9__48_1;
        //    public static Func<DataSetGES.Class78, double> C_9__48_2;
        //    public static Func<DataSetGES.Class78, double> C_9__49_1;
        //    public static Func<DataSetGES.Class78, double> C_9__49_2;
        //    public static Func<DataSetGES.Class78, bool> C_9__50_0;
        //    public static Func<DataSetGES.Class78, double> C_9__50_1;
        //    public static Func<DataSetGES.Class78, Class10<double, string>> C_9__50_2;
        //    public static Func<DataSetGES.Class78, double> C_9__51_1;
        //    public static Func<DataSetGES.Class108, Class8<int, string>> C_9__56_1;
        //    public static Func<IGrouping<Class8<int, string>, DataSetGES.Class108>, Class9<int, string>> C_9__56_2;
        //    public static Func<DataGridViewRow, bool> C_9__58_0;
        //    public static Func<DataGridViewRow, int> C_9__58_1;

        //    internal string method_0(DataRow r)
        //    {
        //        return r.Field<int>("Id").ToString();
        //    }

        //    internal string method_1(DataSetGES.Class118 r)
        //    {
        //        return r.Int32_0.ToString();
        //    }

        //    internal bool method_10(Class13<int, int, string, int, string> class13_0)
        //    {
        //        return (Regex.Match(class13_0.NameCell, @"^\D").Length == 0);
        //    }

        //    internal string method_11(Class13<int, int, string, int, string> class13_0)
        //    {
        //        return Regex.Match(class13_0.NameCell, @"\D*").Value;
        //    }

        //    internal int method_12(DataSetGES.Class105 r)
        //    {
        //        return r.Int32_0;
        //    }

        //    internal bool method_13(DataSetGES.Class108 r)
        //    {
        //        return (r["id"] != DBNull.Value);
        //    }

        //    internal Class8<int, string> method_14(DataSetGES.Class108 r)
        //    {
        //        return new Class8<int, string>(r.Int32_0, r.Name);
        //    }

        //    internal Class9<int, string> method_15(IGrouping<Class8<int, string>, DataSetGES.Class108> r)
        //    {
        //        return new Class9<int, string>(r.Key.Prop_0, r.Key.Name);
        //    }

        //    internal string method_16(DataSetGES.Class78 r)
        //    {
        //        return r.CableMakeup;
        //    }

        //    internal string method_17(DataSetGES.Class78 r)
        //    {
        //        return r.CableMakeup;
        //    }

        //    internal int method_18(DataSetGES.Class78 r)
        //    {
        //        return r.Wires;
        //    }

        //    internal int method_19(DataSetGES.Class78 r)
        //    {
        //        return r.Wires;
        //    }

        //    internal int method_2(DataSetGES.Class118 r)
        //    {
        //        return r.Int32_0;
        //    }

        //    internal int method_20(DataSetGES.Class78 r)
        //    {
        //        return r.Wires;
        //    }

        //    internal int method_21(DataSetGES.Class78 r)
        //    {
        //        return r.Wires;
        //    }

        //    internal bool method_22(DataSetGES.Class78 r)
        //    {
        //        return (r.Voltage == 0.4M);
        //    }

        //    internal double method_23(DataSetGES.Class78 r)
        //    {
        //        return r.CrossSection;
        //    }

        //    internal double method_24(DataSetGES.Class78 r)
        //    {
        //        return r.CrossSection;
        //    }

        //    internal double method_25(DataSetGES.Class78 r)
        //    {
        //        return r.CrossSection;
        //    }

        //    internal double method_26(DataSetGES.Class78 r)
        //    {
        //        return r.CrossSection;
        //    }

        //    internal bool method_27(DataSetGES.Class78 r)
        //    {
        //        return (r.Voltage == 0.4M);
        //    }

        //    internal double method_28(DataSetGES.Class78 r)
        //    {
        //        return r.AmperageValue;
        //    }

        //    internal Class10<double, string> method_29(DataSetGES.Class78 r)
        //    {
        //        return new Class10<double, string>(r.AmperageValue, r.AmperageType);
        //    }

        //    internal int method_3(DataSetGES.Class108 r)
        //    {
        //        return r.idCell;
        //    }

        //    internal double method_30(DataSetGES.Class78 r)
        //    {
        //        return r.AmperageValue;
        //    }

        //    internal Class8<int, string> method_31(DataSetGES.Class108 r)
        //    {
        //        return new Class8<int, string>(r.Int32_0, r.Name);
        //    }

        //    internal Class9<int, string> method_32(IGrouping<Class8<int, string>, DataSetGES.Class108> igrouping_0)
        //    {
        //        return new Class9<int, string>(igrouping_0.Key.Prop_0, igrouping_0.Key.Name);
        //    }

        //    internal bool method_33(DataGridViewRow r)
        //    {
        //        return ((r.Cells["Selected"].Value != null) && ((bool)r.Cells["Selected"].Value));
        //    }

        //    internal int method_34(DataGridViewRow dataGridViewRow_0)
        //    {
        //        return (int)dataGridViewRow_0.Cells["dgvcId"].Value;
        //    }

        //    //internal Class14<DataSetGES.Class118, DataSetGES.Class108> method_4(DataSetGES.Class118 r1, DataSetGES.Class108 r2)
        //    //{
        //    //    return new Class14<DataSetGES.Class118, DataSetGES.Class108>(r1, r2);
        //    //}

        //    //internal Class13<int, int, string, int, string> method_5(Class14<DataSetGES.Class118, DataSetGES.Class108> class14_0)
        //    //{
        //    //    return new Class13<int, int, string, int, string>((class14_0.Prop_0["idBus"] != null) ? ((int)class14_0.Prop_0["idBus"]) : -1, (class14_0.Prop_1["idCell"] != null) ? ((int)class14_0.Prop_1["idCell"]) : -1, (class14_0.Prop_0["Name"] != null) ? class14_0.Prop_0["Name"].ToString() : "", (class14_0.Prop_1["id"] != null) ? ((int)class14_0.Prop_1["id"]) : -1, (class14_0.Prop_1["Name"] != null) ? class14_0.Prop_1["Name"].ToString() : "");
        //    //}

        //    internal bool method_6(DataSetGES.Class105 r)
        //    {
        //        return (r["idCell"] != DBNull.Value);
        //    }

        //    internal int method_7(DataSetGES.Class105 r)
        //    {
        //        return r.idCell;
        //    }

        //    internal bool method_8(DataSetGES.Class105 r)
        //    {
        //        return (r["idCable"] != DBNull.Value);
        //    }

        //    internal int method_9(DataSetGES.Class105 r)
        //    {
        //        return r.idCable;
        //    }
        //}



        //[CompilerGenerated]
        //private sealed class Class173
        //{
        //    public int int_0;

        //    internal int method_0(Class13<int, int, string, int, string> class13_0)
        //    {
        //        if (!int.TryParse(Regex.Match(class13_0.NameCell, @"\d+").Value, out this.int_0))
        //        {
        //            return 0;
        //        }
        //        return int.Parse(Regex.Match(class13_0.NameCell, @"\d+").Value);
        //    }
        //}

        //[CompilerGenerated]
        //private sealed class Class174
        //{
        //    public string string_0;

        //    internal bool method_0(DataSetGES.Class78 r)
        //    {
        //        return (r.CableMakeup == this.string_0);
        //    }
        //}

        //[CompilerGenerated]
        //private sealed class Class175
        //{
        //    public int int_0;
        //    public string string_0;

        //    internal bool method_0(DataSetGES.Class78 r)
        //    {
        //        return (((r.CableMakeup == this.string_0) && (r.Wires == this.int_0)) && (r.Voltage == 0.4M));
        //    }
        //}

        //[CompilerGenerated]
        //private sealed class Class176
        //{
        //    public double double_0;
        //    public int int_0;
        //    public string string_0;

        //    internal bool method_0(DataSetGES.Class78 r)
        //    {
        //        return ((((r.CableMakeup == this.string_0) && (r.Wires == this.int_0)) && (r.CrossSection == this.double_0)) && (r.Voltage == 0.4M));
        //    }
        //}

        //[CompilerGenerated]
        //private sealed class Class177
        //{
        //    public int int_0;

        //    internal bool method_0(DataSetGES.Class108 r)
        //    {
        //        return ((r.idCell == this.int_0) && (r["id"] != DBNull.Value));
        //    }
        //}

        //[CompilerGenerated]
        //private sealed class Class178
        //{
        //    public int[] int_0;

        //    internal bool method_0(DataSetGES.Class105 r)
        //    {
        //        return this.int_0.Contains<int>(r.Int32_0);
        //    }
        //}

   }

}