using Constants;
using ControlsLbr;
using DataSql;
//using Documents.Forms.Measurement;
//using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using Measurement.DataSets;
using Passport.Classes;
using Reference.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//using ClassLbr;

/// <summary>
/// Добавление данных по низкой стороне
/// </summary>
namespace Documents.Measurement
{
    public partial class FormAddEditMeasLowVoltage : FormBase
    {
        private bool isSortAscending;
        private IDictionary<string, DataSetMeasurementN.tJ_MeasVoltageTransfDataTable> TransfVoltageTables;
        private IDictionary<string, DataSetMeasurementN.tJ_MeasCableDataTable> MeasCableTables;
        private DataGridViewColumn sortColumn;

        //private int year;
        //internal int Year
        //{
        //    get
        //    {
        //        return this.year;
        //    }
        //    set
        //    {
        //        this.year = value;
        //    }
        //}
        public int Year
        {
            get;
            set;
        }
        //[CompilerGenerated]
        //private int IdSubstation;
        public int IdSubstation
        {
            get;
            set;
        }
        //[CompilerGenerated]
        //private int IdMeasurement;


        public int IdMeasurement
        {
            get;
            set;
        }

        //[CompilerGenerated]
        //private int IdTransformer;
        public int IdTransformer
        {
            get;
            set;
        }
        //[CompilerGenerated]
//        private int IdBus;
        public int IdBus
        {
            get;
            set;
        }

        //[CompilerGenerated]
        //private int int_5;
        private int typeDoc;

        public StateFormCreate StateCreate
        {
            get;
            set;
        }

        //[CompilerGenerated]
        //private StateFormCreate stateFormCreate;
        //[CompilerGenerated]
        //private string SubstationName;
        public string SubstationName
        {
            get;
            set;
        }
        private List<string> dictionaryKeys;
        private string dictionaryKey;

        internal FormAddEditMeasLowVoltage()
        {
            this.InitializeComponent();
        }

        internal FormAddEditMeasLowVoltage(SQLSettings sqlsettings, int idSubstation, string substationName, int idBus = -1, int idTransf = -1, int idMeasurement = -1)
        {
            this.InitializeComponent();
            this.SqlSettings = (sqlsettings);
            //this.method_1(idSubstation);
            //this.method_5(substationName);
            //this.method_3(idMeasurement);
            //this.method_9(idBus);
            //this.method_7(idTransf);

            this.IdSubstation = idSubstation;
            this.SubstationName = substationName;
            this.IdMeasurement = idMeasurement;
            this.IdBus = idBus;
            this.IdTransformer = idTransf;

            //this.method_13((idMeasurement == -1) ? (StateFormCreate.Add) : (StateFormCreate.Edit));
            this.StateCreate = ((idMeasurement == -1) ? StateFormCreate.Add : StateFormCreate.Edit);
        }
        //[CompilerGenerated]
        //private bool method_55(DataSetGES.Class118 class118_0)
        //{
        //    return this.dsMeasLowVoltage.vJ_TransfByCell.Select<DataSetGES.Class107, int>((C__1.<> 9__70_3 ?? (C__1.<> 9__70_3 = new Func<DataSetGES.Class107, int>(C__1.<> 9.method_27)))).Contains<int>(class118_0.Int32_0);
        //}
        private void bsBusesTransf_CurrentChanged(object sender, EventArgs e)
        {
            IdTransformer = (((this.bsBusesTransf.Current == null) || !(((DataRowView)this.bsBusesTransf.Current)["IdTransf"] is int)) ? -1 : ((int)((DataRowView)this.bsBusesTransf.Current)["IdTransf"]));
            IdBus = (((this.bsBusesTransf.Current == null) || !(((DataRowView)this.bsBusesTransf.Current)["IdBus"] is int)) ? -1 : ((int)((DataRowView)this.bsBusesTransf.Current)["IdBus"]));
            this.dictionaryKey = string.Format("{0}+{1}", this.IdBus, this.IdTransformer);
            if (this.dictionaryKeys == null)
            {
                this.dictionaryKeys = new List<string>();
            }
            if (!this.dictionaryKeys.Contains(this.dictionaryKey))
            {
                this.dictionaryKeys.Add(this.dictionaryKey);
            }
            if (this.IdTransformer != -1)
            {
                //string[] textArray1 = new string[] { this.IdTransformer.ToString() };
                base.CallSQLTableValuedFunction(this.dsMeasLowVoltage, this.dsMeasLowVoltage.fn_J_MeasTransfPassport, "", new string[]
                {
                    this.IdTransformer.ToString()
                });
                this.lbSerialNumber.Text = "Заводской № " + this.dsMeasLowVoltage.fn_J_MeasTransfPassport.Rows[0]["InvNumber"].ToString();
            }
            DataTable table = base.SelectSqlData("tSchm_ObjList", true, string.Format("WHERE id = {0}", this.IdBus));
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось найти шину по низкой стороне.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if ((bool)table.Rows[0]["Deleted"])
            {
                MessageBox.Show("Шина удалена со схемы.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                var source = base.SelectSqlData("tSchm_ObjList", true, string.Format("WHERE idParent = {0} AND Deleted = ((0)) AND (id = {1} OR Tag = {1})", this.IdSubstation, this.IdBus)).AsEnumerable();

                //string str = string.Join(",", source.Select<DataRow, string>((C__1.C9__70_0 ?? (C__1.C9__70_0 = new Func<DataRow, string>(C__1.method_25)))).ToArray<string>());
                string str = string.Join(",", (from r in source
                                                select r.Field<int>("Id").ToString()).ToArray<string>());

                if (string.IsNullOrEmpty(str))
                {
                    MessageBox.Show("Не удалось найти шину по низкой стороне.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.vJ_CellByBus, true, string.Format("WHERE idBus IN ({0}) AND idParent = {1} ORDER BY CONVERT(INT, CASE WHEN Name like '%[^0-9]%' THEN SUBSTRING(Name,1,PATINDEX('%[^0-9]%',Name)-1) ELSE Name END)", str, this.IdSubstation));
                    //string str2 = string.Join(",", this.dsMeasLowVoltage.vJ_CellByBus.Select<DataSetGES.Class118, string>((C__1.<> 9__70_1 ?? (C__1.<> 9__70_1 = new Func<DataSetGES.Class118, string>(C__1.<> 9.method_26)))).ToArray<string>());

                    string str2 = string.Join(",", (from i in this.dsMeasLowVoltage.vJ_CellByBus
                                                     select i.id.ToString()).ToArray<string>());

                    if (!string.IsNullOrEmpty(str2))
                    {
                        base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.vJ_TransfByCell, true, string.Format("WHERE idCell IN ({0})", str2));
                        if (this.dsMeasLowVoltage.vJ_TransfByCell.Count > 0)
                        {
                            //this.dsMeasLowVoltage.vJ_CellByBus.method_5(this.dsMeasLowVoltage.vJ_CellByBus.Where<DataSetGES.Class118>(new Func<DataSetGES.Class118, bool>(this.method_55)).First<DataSetGES.Class118>());
                            this.dsMeasLowVoltage.vJ_CellByBus.RemovevJ_CellByBusRow((from r in this.dsMeasLowVoltage.vJ_CellByBus
                                                                               where (from c in this.dsMeasLowVoltage.vJ_TransfByCell
                                                                                      select c.idCell).Contains(r.id)
                                                                               select r).First());
                        }
                        base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.vJ_CableByCell, true, string.Format("WHERE idCell IN ({0})", str2));
                    }
                    this.TransfSelectChanged();
                }
            }
        }

        private void bindingSource_3_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bsMeasCable.Current != null)
            {
                this.RefreshCellAddress();
            }
        }
        //[CompilerGenerated]
        //private bool method_59(DataSetGES.Class108 class108_0)
        //{
        //    return (class108_0.idCell == ((int)((DataRowView)this.bsCellByTransf.Current)["id"]));
        //}
        private void bsCellByTransf_CurrentChanged(object sender, EventArgs e)
        {
            Point currentCellAddress = this.dgvMeasCable.CurrentCellAddress;
            if ((currentCellAddress.X != -1) && (currentCellAddress.Y != -1))
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)this.dgvMeasCable.Rows[currentCellAddress.Y].Cells["dgvcIdCable"];
                if (this.bsCellByTransf.Current != null)
                {
                    //EnumerableRowCollection<DataSetGES.Class108> source = this.dsMeasLowVoltage.vJ_CableByCell.Where<DataSetGES.Class108>(new Func<DataSetGES.Class108, bool>(this.method_59)); //(* method_59 = (class108_0.idCell == ((int)((DataRowView)this.bsCellByTransf.Current)["id"]))*)

                    //EnumerableRowCollection<DataSetMeasurementN.vJ_CableByCellRow> ss = from r in this.dsMeasLowVoltage.vJ_CableByCell
                    var ss = from r in this.dsMeasLowVoltage.vJ_CableByCell
                             where r.idCell == (int)((DataRowView)this.bsCellByTransf.Current)["id"]
                             select r;

                    //cell.Value = (source.Count<DataSetGES.Class108>() > 0) ? ((source.First<DataSetGES.Class108>()["id"] == DBNull.Value) ? -1 : source.First<DataSetGES.Class108>().Int32_0) : -1;
                    cell.Value = ((ss.Count() > 0) ? ((ss.First()["id"] == DBNull.Value) ? -1 : ss.First().id) : -1);
                }
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (this.Check())
            {
                if (this.SaveData())
                {
                    MessageBox.Show("Данные успешно сохранены.", "Сохранение.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.DialogResult = DialogResult.Cancel;
                }
                base.Close();
            }
        }

        private void comboBox_3_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((this.cbYear.SelectedValue != null) && (this.cbYear.SelectedValue is int))
            {
                this.Year = (int)this.cbYear.SelectedValue;
            }
        }

        private void dataGridView_0_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dataGridView_0_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvMeasCable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Length == 0)
            {
                this.dgvMeasCable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
            }
            if ((this.dgvMeasCable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is int) && (((int)this.dgvMeasCable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == -1))
            {
                this.dgvMeasCable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
            }
        }

        private void dataGridView_0_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.DgvMeasCableSort(e.ColumnIndex);
        }

        private void dataGridView_0_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int num = (this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcIdCell"].Value is int) ? ((int)this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcIdCell"].Value) : 0;
            string str = (this.dgvMeasCable.Columns[e.ColumnIndex].DataPropertyName == "idCable") ? "Cable" : this.dgvMeasCable.Columns[e.ColumnIndex].DataPropertyName;
            string[] textArray1 = new string[] { "dt", str, "_", this.IdTransformer.ToString(), "_", e.RowIndex.ToString() };
            string name = string.Concat(textArray1);
            string str3 = (this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcCableMakeup"].Value is string) ? this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcCableMakeup"].Value.ToString() : "";
            int num2 = (this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcWires"].Value is int) ? ((int)this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcWires"].Value) : 0;
            double num3 = (this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcCrossSection"].Value is double) ? ((double)this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcCrossSection"].Value) : 0.0;
            if (this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcPermisAmperage"].Value is double)
            {
                double num1 = (double)this.dgvMeasCable.Rows[e.RowIndex].Cells["dgvcPermisAmperage"].Value;
            }
            if (this.dsMeasLowVoltage.Tables.Contains(name))
            {
                switch (this.dgvMeasCable.Columns[e.ColumnIndex].DataPropertyName)
                {
                    case "cable":
                        this.CreateTableCables(e.RowIndex, new DataTable(), num);
                        return;

                    case "makeup":
                        this.method_25(e.RowIndex, str3);
                        return;

                    case "Wires":
                        this.FillTableWires(e.RowIndex, str3);
                        return;

                    case "CrossSection":
                        this.FillTableCrossSections(e.RowIndex, str3, num2);
                        break;

                    case "PermisAmperage":
                        this.FillTableAmperage(e.RowIndex, str3, num2, num3);
                        break;
                }
            }
        }

        private void dataGridView_0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                Point currentCellAddress = this.dgvMeasCable.CurrentCellAddress;
                Point point = this.dgvMeasCable.CurrentCellAddress;
                if (this.dgvMeasCable.Columns[point.X].Name == "dgvcIdCell")
                {
                    this.dgvMeasCable.Rows[point.Y].Cells[point.X].Value = -1;
                }
            }
        }

        private void dataGridView_0_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = this.dgvMeasCable.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    this.dgvMeasCable.Rows[rowIndex].Selected = true;
                    ContextMenuStrip strip = new ContextMenuStrip();
                    ToolStripButton button = new ToolStripButton("Удалить адрес объекта");
                    button.Click += new EventHandler(this.tsmiMeasCableDelAddress_Click);
                    strip.Items.Add(button);
                    ToolStripButton button2 = new ToolStripButton("Удалить наименование объекта");
                    button2.Click += new EventHandler(this.toolStripMenuItem_1_Click);
                    strip.Items.Add(button2);
                    strip.Items.Add(new ToolStripSeparator());
                    ToolStripButton button3 = new ToolStripButton("Удалить строку");
                    button3.Click += new EventHandler(this.toolStripMenuItem_2_Click);
                    strip.Items.Add(button3);
                    if (this.dgvMeasCable.Rows[rowIndex].DefaultCellStyle.BackColor == Color.Yellow)
                    {
                        strip.Items.Add(new ToolStripSeparator());
                        ToolStripButton button4 = new ToolStripButton("Справочник кабелей");
                        strip.Items.Add(button4);
                        button4.Click += new EventHandler(this.OpenReferenceCable_Click);
                    }
                    strip.Show(this.dgvMeasCable, e.Location);
                }
            }
        }

        private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.FillDGVCBByRow(e.RowIndex);
        }

        private void dataGridView_0_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvMeasCable.SelectedRows != null)
            {
                int count = this.dgvMeasCable.SelectedRows.Count;
            }
        }

        private void dataGridView_0_Sorted(object sender, EventArgs e)
        {
        }

        private void dataGridView_1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex >= 0) && ((this.dgvAbnObj[this.typeDocDgvColumn.Name, e.RowIndex].Value == DBNull.Value) || (Convert.ToInt32(this.dgvAbnObj[this.typeDocDgvColumn.Name, e.RowIndex].Value) != 0x4a7)))
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
        }

        private void FormAddEditMeasLowVoltage_Load(object sender, EventArgs e)
        {
            // Выходит ошибка включения в список сортировки
            //this.bindingSource_8.Sort = "CableMakeup";
            //this.bindingSource_15.Sort = "Wires";
            //this.bindingSource_10.Sort = "CrossSection";
            //this.bindingSource_6.Sort = "Name";
            // Пример не сработал: this.bsMeasCable.Sort = string.Format("NameCell ASC, OldCell ASC", new object[0]);

            this.Text = (this.StateCreate == StateFormCreate.Add) ? "Добавление замера" : "Редактирование замера";
            this.Text += ((this.SubstationName.Length > 0) ? (": " + this.SubstationName) : "");
            this.dgvMeasCable.Columns["dgvcIdCell"].ReadOnly = (this.StateCreate == StateFormCreate.Add);
            this.dgvMeasCable.Columns["dgvcIdCable"].ReadOnly = (this.StateCreate == StateFormCreate.Add);
            // Заполняем список выбора года
            this.FillPeriod();
            // Справочник кабелей
            this.FillMeasCableComboBoxes();
            // Положение переключателя напряжения и тип замера из классификатора
            this.FillSwitchComboBox();
            // Список работников для замеров
            this.FillWorkerComboBox();
            // поучаем код докумета в классификаторе
            // = 1191 - это замеры 0,4
            this.typeDoc = this.GetTypeDoc();
            if (this.StateCreate == StateFormCreate.Add) // null
            {
                this.CreateNewMeasurementRow();
            }
            else
            {
                base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.tJ_Measurement, true, string.Format("WHERE id = {0} AND Deleted = ((0))", this.IdMeasurement));
            }

            //if (dsMeasLowVoltage.tJ_MeasVoltageTransf.PrimaryKey.Count() == 0)
            //    dsMeasLowVoltage.tJ_MeasVoltageTransf.PrimaryKey = new DataColumn[] { dsMeasLowVoltage.tJ_MeasVoltageTransf.Columns["id"] };

            this.FillBusesTransf();
            InputCheck.AddBindingNull(this.tbUabd);
            InputCheck.AddBindingNull(this.tbUabn);
            InputCheck.AddBindingNull(this.tbUaod);
            InputCheck.AddBindingNull(this.tbUaon);
            InputCheck.AddBindingNull(this.tbUbcd);
            InputCheck.AddBindingNull(this.tbUbcn);
            InputCheck.AddBindingNull(this.tbUbod);
            InputCheck.AddBindingNull(this.tbUbon);
            InputCheck.AddBindingNull(this.tbUcad);
            InputCheck.AddBindingNull(this.tbUcan);
            InputCheck.AddBindingNull(this.tbUcod);
            InputCheck.AddBindingNull(this.tbUcon);
        }

      
        private void FillBusesTransf()
        {
            this.bsBusesTransf.RaiseListChangedEvents = true;
            this.bsBusesTransf.CurrentChanged -= new EventHandler(this.bsBusesTransf_CurrentChanged);
            if (this.StateCreate == StateFormCreate.Edit) //1
            {
                base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.vJ_BusesTransfs, true, string.Format("WHERE idMeasurement = {0} ORDER By Name", this.IdMeasurement));
                base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.vJ_BusesTransfSchema, true, string.Format("WHERE idSub = {0} AND parentKeyBus = ';SCM;BUS;BUSLV;' ORDER By NameTransf", this.IdSubstation));
                this.dsMeasLowVoltage.dtBusesTransf.Rows.Clear();

                var enumerable = (from row in this.dsMeasLowVoltage.vJ_BusesTransfSchema
                                  select new
                                  {
                                      idBus = row.idBus,
                                      NameBus = row.nameBus,
                                      idTransf = ((row["idTransf"] == DBNull.Value) ? -1 : row.idTransf),
                                      NameTransf = ((row["NameTransf"] == DBNull.Value) ? "" : row.NameTransf),
                                      NameBusTransf = ((row["nameBusTransf"] == DBNull.Value) ? row.nameBus : row.nameBusTransf)
                                  }).Except(from row in this.dsMeasLowVoltage.vJ_BusesTransfs
                                            select new
                                            {
                                                idBus = ((row["IdBus"] == DBNull.Value) ? -1 : row.idBus),
                                                NameBus = ((row["nameBus"] == DBNull.Value) ? "" : row.nameBus),
                                                idTransf = ((row["idTransf"] == DBNull.Value) ? -1 : row.idTransf),
                                                NameTransf = ((row["nameTransf"] == DBNull.Value) ? "" : row.nameTransf),
                                                NameBusTransf = row.Name
                                            }).Union(from row in this.dsMeasLowVoltage.vJ_BusesTransfs
                                                     select new
                                                     {
                                                         idBus = ((row["IdBus"] == DBNull.Value) ? -1 : row.idBus),
                                                         NameBus = ((row["nameBus"] == DBNull.Value) ? "" : row.nameBus),
                                                         idTransf = ((row["idTransf"] == DBNull.Value) ? -1 : row.idTransf),
                                                         NameTransf = ((row["nameTransf"] == DBNull.Value) ? "" : row.nameTransf),
                                                         NameBusTransf = row.Name
                                                     });
                foreach (var current in enumerable)
                {
                    DataSetMeasurementN.dtBusesTransfRow row = this.dsMeasLowVoltage.dtBusesTransf.NewdtBusesTransfRow();// .method_4();
                    row.idBus = current.idBus;
                    row.NameBus = current.NameBus;
                    row.idTransf = current.idTransf;
                    row.NameTransf = current.NameTransf;
                    row.NameBusTransf = current.NameBusTransf;
                    this.dsMeasLowVoltage.dtBusesTransf.AdddtBusesTransfRow(row);
                }
            }
            if (this.StateCreate == StateFormCreate.Add)
            {
                base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.vJ_BusesTransfSchema, true, string.Format("WHERE idSub = {0} AND parentKeyBus = ';SCM;BUS;BUSLV;' ORDER By NameTransf", this.IdSubstation));
                this.dsMeasLowVoltage.dtBusesTransf.Rows.Clear();
                //foreach (DataSetGES.Class121 class4 in this.dsMeasLowVoltage.vJ_BusesTransfSchema)
                foreach (DataSetMeasurementN.vJ_BusesTransfSchemaRow current2 in this.dsMeasLowVoltage.vJ_BusesTransfSchema)
                    {
                    DataSetMeasurementN.dtBusesTransfRow row = this.dsMeasLowVoltage.dtBusesTransf.NewdtBusesTransfRow();
                    row.idBus = current2.idBus;
                    row.NameBus = current2.nameBus;
                    row.idTransf = current2.idTransf;
                    row.NameTransf = current2.NameTransf;
                    row.NameBusTransf = current2.nameBusTransf;
                    this.dsMeasLowVoltage.dtBusesTransf.AdddtBusesTransfRow(row);
                }
                DataTable dataTable = (from r in this.dsMeasLowVoltage.dtBusesTransf
                                       orderby r.NameBusTransf
                                       select r).CopyToDataTable();

                this.dsMeasLowVoltage.dtBusesTransf.Rows.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    this.dsMeasLowVoltage.dtBusesTransf.ImportRow(row);
                }
            }
            //this.IdTransformer;
            //if (this.IdTransformer != -1)
            //{
            //    this.IdTransformer;
            //}
            //else
            //{
            //    this.IdBus;
            //}
            if (this.IdTransformer == -1) // позиционирование на подстанции
            {
                int num = this.bsBusesTransf.Find("IdBus", this.IdBus);
                if (num != -1)
                {
                    this.bsBusesTransf.Position = num;
                }
            }
            else // позиционирование на трансформаторе конкретной подстанции
            {
               ////var source = from rows in dsMeasLowVoltage.dtBusesTransf
               ////              where rows.idBus == this.IdBus && rows.idTransf == this.IdTransformer
               ////              select rows;


               //// //EnumerableRowCollection<DataSetMeasurementN.dtBusesTransfRow> source = from rows in this.dsMeasLowVoltage.dtBusesTransf
               //// //                                                                       where rows.idBus == this.IdBus && rows.idTransf == this.IdTransformer
               //// //                                                                       select rows;
               //// if (source.Count() > 0)
               //// {
               ////     this.bsBusesTransf.Position = this.dsMeasLowVoltage.dtBusesTransf.Rows.IndexOf(source.First());
               //// }
               // не позиционировалось
                int num = bsBusesTransf.Find("idTransf", IdTransformer);
                if (num != -1)
                {
                    this.bsBusesTransf.Position = num;
                }
            }
            // старый код
            ////////object key = (this.IdTransformer == -1) ? this.IdBus : this.IdTransformer;
            ////////string propertyName = (this.IdTransformer == -1) ? "idBus" : "idTransf";
            ////////int num = this.bsBusesTransf.Find(propertyName, key);
            ////////if (num != -1) // нашли
            ////////{
            ////////    this.bsBusesTransf.Position = num;
            ////////}
            ////////else
            ////////{

            ////////}

            this.bsBusesTransf.CurrentChanged += new EventHandler(this.bsBusesTransf_CurrentChanged);
            this.bsBusesTransf.RaiseListChangedEvents = false;
            this.bsBusesTransf_CurrentChanged(this.bsBusesTransf, new EventArgs());
        }

        //[CompilerGenerated]
        //private bool method_54(DataSetGES.Class120 class120_0)
        //{
        //    return ((class120_0.idBus == this.method_8()) && (class120_0.idTransf == this.IdTransformer));
        //}

        private void CreateNewMeasurementRow()
        {
            DataSetMeasurementN.tJ_MeasurementRow row = this.dsMeasLowVoltage.tJ_Measurement.NewtJ_MeasurementRow();
            row.idObjList = this.IdSubstation; //this.IdSubstation;
            row.TypeDoc = this.typeDoc;
            try
            {
                SqlDataConnect connect = new SqlDataConnect();
                connect.OpenConnection(this.SqlSettings);
                SqlCommand command = new SqlCommand(string.Format("select dbo.fn_J_GetIdDefaultMounterWorker({0})", this.IdSubstation.ToString()), connect.Connection);
                row.idWorker = (int)command.ExecuteScalar();
            }
            catch
            {
                row.idWorker = -1;
            }
            row.Deleted = false;
            this.dsMeasLowVoltage.tJ_Measurement.AddtJ_MeasurementRow(row);
        }

        private int GetTypeDoc()
        {
            //   return this.dsMeasLowVoltage.tR_Classifier.Where<DataSetGES.Class50>((C__1.<> 9__43_0 ?? (C__1.<> 9__43_0 = new Func<DataSetGES.Class50, bool>(C__1.<> 9.method_4)))).Select<DataSetGES.Class50, int>((C__1.<> 9__43_1 ?? (C__1.<> 9__43_1 = new Func<DataSetGES.Class50, int>(C__1.<> 9.method_5)))).First<int>();
            return (from row in this.dsMeasLowVoltage.tR_Classifier
                    where row.ParentKey == ";Measurement;Type;" && row.Value == 1
                    select row.Id).First<int>();
        }

        private void FillPeriod()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Year");
            for (int i = DateTime.Now.Year - 10; i < (DateTime.Now.Year + 11); i++)
            {
                object[] values = new object[] { i };
                table.Rows.Add(values);
            }
            this.cbYear.DataSource = table;
            this.cbYear.DisplayMember = "Year";
            this.cbYear.ValueMember = "Year";
            this.cbYear.SelectedValue = DateTime.Now.Year;
        }

        private void FillWorkerComboBox()
        {
            base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.vP_Worker, true, string.Format("WHERE ParentKey = ';GroupWorker;Meas;' AND DateEnd IS NULL", new object[0]));
            //DataSetGES.Class63 class2 = this.dsMeasLowVoltage.vP_Worker.method_4();
            DataSetMeasurementN.vP_WorkerRow row = this.dsMeasLowVoltage.vP_Worker.NewvP_WorkerRow();
            row.Id = -1;
            row.F = ("");
            row.FIO = "";
            row.ParentKey = "";
            row.idGroup = (1);
            row.isGroup = (false);
            //this.dsMeasLowVoltage.vP_Worker.method_0(class2);
            this.dsMeasLowVoltage.vP_Worker.AddvP_WorkerRow(row);
        }

        private void FillSwitchComboBox()
        {
            base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.tR_Classifier, true, string.Format("WHERE ParentKey IN (';Measurement;Type;', ';Measurement;Switch;') AND Deleted = ((0)) AND isGroup = ((0))", new object[0]));
            DataSetMeasurementN.tR_ClassifierRow row = this.dsMeasLowVoltage.tR_Classifier.NewtR_ClassifierRow();
            row.Id = -1;
            row.Name = "";
            row.ParentKey = ";Measurement;Switch;";
            row.IsGroup = false;
            row.Deleted = false;
            this.dsMeasLowVoltage.tR_Classifier.AddtR_ClassifierRow(row);
        }

        //[CompilerGenerated]
        //internal int method_2()
        //{
        //    return this.IdMeasurement;
        //}

        private void FillMeasCableComboBoxes()
        {
            base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.vJ_CableReference, true);
        }

        //[CompilerGenerated]
        //private sealed class Class159
        //{
        //    public string string_0;

        //    internal bool method_0(DataRow dataRow_0)
        //    {
        //        return (dataRow_0.Field<string>("CableMakeup") == this.string_0);
        //    }
        //}

        private void FillDGVCBByRow(int index)
        {
            try
            {
                //Class159 class2 = new Class159();
                DataTable table = this.dsMeasLowVoltage.Tables["dtCable_" + this.IdTransformer.ToString() + "_" + index.ToString()];
                if (((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DataSource == null)
                {
                    if (table == null)
                    {
                        table = new DataTable("dtCable_" + this.IdTransformer.ToString() + "_" + index.ToString());
                        table.Columns.Add("Id", typeof(int));
                        table.Columns.Add("Name", typeof(string));
                        this.dsMeasLowVoltage.Tables.Add(table);
                    }
                    table.Rows.Clear();
                    //foreach (Class9<int, string> class3 in this.dsMeasLowVoltage.vJ_CableByCell.AsEnumerable<DataSetGES.Class108>().Where<DataSetGES.Class108>((C__1.<> 9__48_0 ?? (C__1.<> 9__48_0 = new Func<DataSetGES.Class108, bool>(C__1.<> 9.method_6)))).GroupBy<DataSetGES.Class108, Class8<int, string>>((C__1.<> 9__48_1 ?? (C__1.<> 9__48_1 = new Func<DataSetGES.Class108, Class8<int, string>>(C__1.<> 9.method_7)))).Select<IGrouping<Class8<int, string>, DataSetGES.Class108>, Class9<int, string>>(C__1.<> 9__48_2 ?? (C__1.<> 9__48_2 = new Func<IGrouping<Class8<int, string>, DataSetGES.Class108>, Class9<int, string>>(C__1.<> 9.method_8))))
                    //{
                    //    object[] values = new object[] { class3.IdCable, class3.NameCable };
                    //    table.Rows.Add(values);
                    //}
                    var enumerable = from row1 in this.dsMeasLowVoltage.vJ_CableByCell.AsEnumerable()
                                     where row1["id"] != DBNull.Value
                                     group row1 by new
                                     {
                                         row1.id,
                                         row1.Name
                                     } into g
                                     select new
                                     {
                                         IdCable = g.Key.id,
                                         NameCable = g.Key.Name
                                     };
                    foreach (var current in enumerable)
                    {
                        table.Rows.Add(new object[]
                        {
                            current.IdCable,
                            current.NameCable
                        });
                    }
                    

                    BindingSource source = new BindingSource
                    {
                        DataSource = table
                    };
                    ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DataSource = source;
                    ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DisplayMember = "Name";
                    ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).ValueMember = "Id";
                }
                string str = (this.dgvMeasCable.Rows[index].Cells["dgvcCableMakeup"].Value is string) ? this.dgvMeasCable.Rows[index].Cells["dgvcCableMakeup"].Value.ToString() : "";
                DataTable table2 = this.CreateTableCableMakeup(index, true);//смотри
                DataRow row = table2.NewRow();
                row["CableMakeup"] = "";
                table2.Rows.InsertAt(row, 0);
                //if (table2.AsEnumerable().Where<DataRow>(new Func<DataRow, bool>(class2.method_0)).Count<DataRow>() == 0)
                //{
                //    DataRow row2 = table2.NewRow();
                //    row2["CableMakeup"] = str;
                //    table2.Rows.InsertAt(row2, 1);
                //}
                if ((from r in table2.AsEnumerable()
                     where r.Field<string>("CableMakeup") == str
                     select r).Count() == 0)
                {
                    DataRow row2 = table2.NewRow();
                    row2["CableMakeup"] = str;
                    table2.Rows.InsertAt(row2, 1);
                }
                int? nullable = this.FillTableWires(index, str);// смотри
                double num = 0.0;
                if (nullable.HasValue)
                {
                    num = this.FillTableCrossSections(index, str, nullable.Value);//сморти
                //}
                //if (nullable.HasValue)
                //{
                    this.FillTableAmperage(index, str, nullable.Value, num);
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message, "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void RefreshCellAddress()
        {
            if ((this.bsMeasCable.Count > 0) && (((DataRowView)this.bsMeasCable.Current)["idCell"] is int))
            {
                //base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.vJ_MeasAbnObj.TableName, true, string.Format("WHERE idSchmObj = {0}", (int)((DataRowView)this.bsMeasCable.Current)["idCell"]), new TimeSpan(0, 2, 0));
                base.SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.vJ_MeasAbnObj, true, string.Format("WHERE idSchmObj = {0}", (int)((DataRowView)this.bsMeasCable.Current)["idCell"]));
            }
        }

        private void RefreshCellAddress(List<string> idNotRemoved)
        {
            this.RefreshCellAddress();
            if (idNotRemoved.Count > 0)
            {
                //using (IEnumerator enumerator = this.dgvAbnObj.SelectedRows.GetEnumerator())
                //{
                //    while (enumerator.MoveNext())
                //    {
                //        ((DataGridViewRow)enumerator.Current).Selected = false;
                //    }
                //}
                foreach (DataGridViewRow dataGridViewRow in this.dgvAbnObj.SelectedRows)
                {
                    dataGridViewRow.Selected = false;
                }
                foreach (string str in idNotRemoved)
                {
                    foreach (DataGridViewRow row in dgvAbnObj.Rows)
                    {
                        if (row.Cells["dgvcIds"].Value.ToString() == str)
                        {
                            row.Selected = true;
                        }
                    }
                }
                MessageBox.Show("Оставшиеся выделенные строки невозможно удалить.", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private DataTable FillTableCableMakeup(int rowIndex, DataTable dt)
        {
            dt = this.dsMeasLowVoltage.Tables["dtCableMakeup_" + this.IdTransformer.ToString() + "_" + rowIndex.ToString()];
            dt.Rows.Clear();
            //foreach (string str in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable<DataSetGES.Class78>().OrderBy<DataSetGES.Class78, string>((C__1.<> 9__51_0 ?? (C__1.<> 9__51_0 = new Func<DataSetGES.Class78, string>(C__1.<> 9.method_9)))).Select<DataSetGES.Class78, string>((C__1.<> 9__51_1 ?? (C__1.<> 9__51_1 = new Func<DataSetGES.Class78, string>(C__1.<> 9.method_10)))).Distinct<string>())
            //  IEnumerable<string> enumerable
            var enumerable = (from row in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable()
                                              orderby row.CableMakeup
                                              select row.CableMakeup).Distinct();
            foreach (string str in enumerable)
            {
                object[] values = new object[] { str };
                dt.Rows.Add(values);
            }
            return dt;
        }

        private void method_25(int index, string makeup)
        {
            //Class160 class2 = new Class160
            //{
            //    string_0 = makeup
            //};

            DataTable table = new DataTable();
            table = this.FillTableCableMakeup(index, table);

            DataRow row = table.NewRow();
            row["CableMakeup"] = "";
            table.Rows.InsertAt(row, 0);

            //if (table.AsEnumerable().Where<DataRow>(new Func<DataRow, bool>(class2.method_0)).Count<DataRow>() == 0)
            if ((from r in table.AsEnumerable()
                 where r["CableMakeup"] != DBNull.Value && r.Field<string>("CableMakeup").ToUpper().Trim() == makeup.ToUpper().Trim()
                 select r).Count() == 0)
            {
                DataRow row2 = table.NewRow();
                row2["CableMakeup"] = makeup;
                table.Rows.InsertAt(row2, 1);
            }
        }

        private DataTable FillTableWires(int index, DataTable dt, string str)
        {
            //Class161 class2 = new Class161
            //{
            //    string_0 = str
            //};
            dt = this.dsMeasLowVoltage.Tables["dtWires_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            dt.Rows.Clear();
            //foreach (int num2 in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable<DataSetGES.Class78>().Where<DataSetGES.Class78>(new Func<DataSetGES.Class78, bool>(class2.method_0)).OrderBy<DataSetGES.Class78, int>((C__1.<> 9__53_1 ?? (C__1.<> 9__53_1 = new Func<DataSetGES.Class78, int>(C__1.<> 9.method_11)))).Select<DataSetGES.Class78, int>((C__1.<> 9__53_2 ?? (C__1.<> 9__53_2 = new Func<DataSetGES.Class78, int>(C__1.<> 9.method_12)))).Distinct<int>())
            //{
            //    object[] values = new object[] { num2 };
            //    dt.Rows.Add(values);
            //}

            //Enumerable<int> enumerable
            var enumerable = (from row in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable()
                                           where row.CableMakeup.StartsWith(str) && row.CableMakeup.EndsWith(str)
                                           orderby row.Wires
                                           select row.Wires).Distinct();
            dt.Rows.Clear();
            foreach (int current in enumerable)
            {
                dt.Rows.Add(new object[]
                {
                    current
                });
            }

            return dt;
        }

        private DataTable CreateTableWires(int index, string str)
        {
            DataTable table;
            if (this.dsMeasLowVoltage.Tables.Contains("dtWires_" + this.IdTransformer.ToString() + "_" + index.ToString()))
            {
                table = this.dsMeasLowVoltage.Tables["dtWires_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            }
            else
            {
                table = new DataTable("dtWires_" + this.IdTransformer.ToString() + "_" + index.ToString());
                table.Columns.Add("Wires", typeof(int));
                this.dsMeasLowVoltage.Tables.Add(table);
            }
            BindingSource source = new BindingSource();
            source.CurrentChanged -= new EventHandler(this.bsWiresCell_CurrentChanged);
            source.DataSource = table;
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcWires"]).DataSource = source;
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcWires"]).DisplayMember = "Wires";
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcWires"]).ValueMember = "Wires";
            table = this.FillTableWires(index, table, str);
            source.CurrentChanged += new EventHandler(this.bsWiresCell_CurrentChanged);
            return table;
        }

        //private sealed class Class162
        //{
        //    public int? nullable_0;

        //    internal bool method_0(DataRow dataRow_0)
        //    {
        //        if (dataRow_0["Wires"] == DBNull.Value)
        //        {
        //            return false;
        //        }
        //        int? nullable = this.nullable_0;
        //        if (dataRow_0.Field<int>("Wires") != nullable.GetValueOrDefault())
        //        {
        //            return false;
        //        }
        //        return nullable.HasValue;
        //    }
        //}

        private int? FillTableWires(int index, string str)
        {
            //Class162 class2 = new Class162
            //{
            //    nullable_0 = null
            //};
            //if (this.dgvMeasCable.Rows[index].Cells["dgvcWires"].Value is int)
            //{
            //    class2.nullable_0 = new int?((int)this.dgvMeasCable.Rows[index].Cells["dgvcWires"].Value);
            //}
            int? nullable = (this.dgvMeasCable.Rows[index].Cells["dgvcWires"].Value is int) ? ((int)this.dgvMeasCable.Rows[index].Cells["dgvcWires"].Value) : 0;


            DataTable dt = this.CreateTableWires(index, str); //смотри


            DataRow row = dt.NewRow();
            row["Wires"] = DBNull.Value;
            dt.Rows.InsertAt(row, 0);
            //if (nullable.HasValue && (dt.AsEnumerable().Where<DataRow>(new Func<DataRow, bool>(class2.method_0)).Count<DataRow>() == 0))

            if (nullable.HasValue && (from r in dt.AsEnumerable()
                                      where r["Wires"] != DBNull.Value && r.Field<int>("Wires") == nullable
                                      select r).Count<DataRow>() == 0)
            {
                DataRow row2 = dt.NewRow();
                row2["Wires"] = nullable;
                dt.Rows.InsertAt(row2, 1);
            }
            return nullable;
        }

        private DataTable FillTableCrossSections(int index, DataTable dt)
        {
            dt = this.dsMeasLowVoltage.Tables["dtCrossSection_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            var enumerable = (from row in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable()
                                              where row.Voltage == 0.4m
                                              orderby row.CrossSection
                                              select row.CrossSection).Distinct();
            dt.Rows.Clear();

            //foreach (int num2 in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable<DataSetMeasurementN.Class78>().Where<DataSetMeasurementN.Class78>((C__1.<> 9__56_0 ?? (C__1.<> 9__56_0 = new Func<DataSetGES.Class78, bool>(C__1.<> 9.method_13)))).OrderBy<DataSetGES.Class78, double>((C__1.<> 9__56_1 ?? (C__1.<> 9__56_1 = new Func<DataSetGES.Class78, double>(C__1.<> 9.method_14)))).Select<DataSetGES.Class78, double>((C__1.<> 9__56_2 ?? (C__1.<> 9__56_2 = new Func<DataSetGES.Class78, double>(C__1.<> 9.method_15)))).Distinct<double>())
            //{
            //    object[] values = new object[] { num2 };
            //    dt.Rows.Add(values);
            //}
               foreach (var enumerator in enumerable)
            {
                dt.Rows.Add(new object[]
                {
                    (int)enumerator
                });
            }

            return dt;
        }

        //[CompilerGenerated]
        //internal void method_3(int int_7)
        //{
        //    this.IdMeasurement = int_7;
        //}

        private DataTable FillTableCrossSections(int index, DataTable dt, string makeup, int wires)
        {
            //Class163 class2 = new Class163
            //{
            //    string_0 = makeup,
            //    int_0 = wires
            //};
            dt = this.dsMeasLowVoltage.Tables["dtCrossSection_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            // IEnumerable<double>
            var enumerable = (from row in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable()
                                              where row.CableMakeup == makeup && row.Wires == wires && row.Voltage == 0.4m
                                              orderby row.CrossSection
                                              select row.CrossSection).Distinct();
            dt.Rows.Clear();
            //foreach (int num2 in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable<DataSetGES.Class78>().Where<DataSetGES.Class78>(new Func<DataSetGES.Class78, bool>(class2.method_0)).OrderBy<DataSetGES.Class78, double>((C__1.<> 9__57_1 ?? (C__1.<> 9__57_1 = new Func<DataSetGES.Class78, double>(C__1.<> 9.method_16)))).Select<DataSetGES.Class78, double>((C__1.<> 9__57_2 ?? (C__1.<> 9__57_2 = new Func<DataSetGES.Class78, double>(C__1.<> 9.method_17)))).Distinct<double>())
            //{
            //    object[] values = new object[] { num2 };
            //    dt.Rows.Add(values);
            //}

            foreach (var enumerator in enumerable)
            {
                dt.Rows.Add(new object[]
                {
                    (int)enumerator
                });
            }

            return dt;
        }

        private double FillTableCrossSections(int index, string makeup, int wires)
        {
            //Class164 class2 = new Class164
            //{
            double cross = (this.dgvMeasCable.Rows[index].Cells["dgvcCrossSection"].Value is double) ? ((double)this.dgvMeasCable.Rows[index].Cells["dgvcCrossSection"].Value) : 0.0;
            //};
            DataTable table = this.CreateTableCrossSections(index, false);
            table = this.FillTableCrossSections(index, table, makeup, wires);
            DataRow row = table.NewRow();
            row["CrossSection"] = DBNull.Value;
            table.Rows.InsertAt(row, 0);
            //if (table.AsEnumerable().Where<DataRow>(new Func<DataRow, bool>(class2.method_0)).Count<DataRow>() == 0)
            if ((from r in table.AsEnumerable()
                 where r["CrossSection"] != DBNull.Value && r.Field<double>("CrossSection") == cross
                 select r).Count<DataRow>() == 0)
            {
                DataRow row2 = table.NewRow();
                row2["CrossSection"] = cross;
                table.Rows.InsertAt(row2, 1);
            }
            return cross;
        }

        private DataTable FillTableAmperage(int index, DataTable dt)
        {
            dt = this.dsMeasLowVoltage.Tables["dtPermisAmperage_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            dt.Rows.Clear();

            var enumerable = (from row in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable()
                              where row.Voltage == 0.4m
                              orderby row.AmperageValue
                              select new
                              {
                                  row.AmperageValue,
                                  row.AmperageType
                              }).Distinct();
            foreach (var current in enumerable)
            {
                dt.Rows.Add(new object[]
                {
                    current.AmperageValue,
                    current.AmperageType
                });
            }


            //foreach (Class10<double, string> class2 in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable<DataSetGES.Class78>().Where<DataSetGES.Class78>((C__1.<> 9__59_0 ?? (C__1.<> 9__59_0 = new Func<DataSetGES.Class78, bool>(C__1.<> 9.method_18)))).OrderBy<DataSetGES.Class78, double>((C__1.<> 9__59_1 ?? (C__1.<> 9__59_1 = new Func<DataSetGES.Class78, double>(C__1.method_19)))).Select<DataSetGES.Class78, Class10<double, string>>((C__1.<> 9__59_2 ?? (C__1.<> 9__59_2 = new Func<DataSetGES.Class78, Class10<double, string>>(C__1.<> 9.method_20)))).Distinct<Class10<double, string>>())
            //{
            //    object[] objArray1 = new object[] 
            //    {
            //        class2.AmperageValue,
            //        class2.AmperageType
            //    };
            //    dt.Rows.Add(objArray1);
            //}



            object[] values = new object[] { 0 };
            dt.Rows.Add(values);
            return dt;
        }

        private DataTable FillTableAmperage(int index, DataTable dt, string str, int wires, double crossSection)
        {
            //Class165 class2 = new Class165
            //{
            //    string_0 = str,
            //    int_0 = wires,
            //    double_0 = crossSection
            //};
            dt = this.dsMeasLowVoltage.Tables["dtPermisAmperage_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            dt.Rows.Clear();
            //foreach (Class10<double, string> class3 in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable<DataSetGES.Class78>().Where<DataSetGES.Class78>(new Func<DataSetGES.Class78, bool>(class2.method_0)).OrderBy<DataSetGES.Class78, double>((C__1.<> 9__60_1 ?? (C__1.<> 9__60_1 = new Func<DataSetGES.Class78, double>(C__1.<> 9.method_21)))).Select<DataSetGES.Class78, Class10<double, string>>((C__1.<> 9__60_2 ?? (C__1.<> 9__60_2 = new Func<DataSetGES.Class78, Class10<double, string>>(C__1.<> 9.method_22)))).Distinct<Class10<double, string>>())
            //{
            //    object[] objArray1 = new object[] { class3.AmperageValue, class3.AmperageType };
            //    dt.Rows.Add(objArray1);
            //}
            var enumerable = (from row in this.dsMeasLowVoltage.vJ_CableReference.AsEnumerable()
                              where row.CableMakeup == str && row.Wires == wires && row.CrossSection == crossSection && row.Voltage == 0.4m
                              orderby row.AmperageValue
                              select new
                              {
                                  row.AmperageValue,
                                  row.AmperageType
                              }).Distinct();
            dt.Rows.Clear();
            foreach (var current in enumerable)
            {
                dt.Rows.Add(new object[]
                {
                    current.AmperageValue,
                    current.AmperageType
                });
            }


            object[] values = new object[] { 0 };
            dt.Rows.Add(values);
            return dt;
        }

        private void FillTableAmperage(int index, string makeup, int wires, double crossSection)
        {
            double num = (this.dgvMeasCable.Rows[index].Cells["dgvcPermisAmperage"].Value is double) ? ((double)this.dgvMeasCable.Rows[index].Cells["dgvcPermisAmperage"].Value) : 0.0;
            DataTable table = this.CreateTablePermisAmperage(index, false);
            table = this.FillTableAmperage(index, table, makeup, wires, crossSection);
            if (table.Select("AmperageValue = " + num.ToString().Replace(',', '.')).Length == 0)
            {
                DataRow row = table.NewRow();
                row["AmperageType"] = num;
                row["AmperageValue"] = num;
                table.Rows.InsertAt(row, 0);
            }
        }

        private DataTable CreateTableCableMakeup(int index, bool fill)
        {
            DataTable table;
            if (this.dsMeasLowVoltage.Tables.Contains("dtCableMakeup_" + this.IdTransformer.ToString() + "_" + index.ToString()))
            {
                table = this.dsMeasLowVoltage.Tables["dtCableMakeup_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            }
            else
            {
                table = new DataTable("dtCableMakeup_" + this.IdTransformer.ToString() + "_" + index.ToString());
                table.Columns.Add("CableMakeup", typeof(string));
                this.dsMeasLowVoltage.Tables.Add(table);
            }
            table = this.FillTableCableMakeup(index, table);
            BindingSource source = new BindingSource
            {
                RaiseListChangedEvents = true
            };
            source.CurrentChanged -= new EventHandler(this.bsCableMakeupCell_CurrentChanged);
            source.DataSource = table;
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCableMakeup"]).DataSource = source;
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCableMakeup"]).DisplayMember = "CableMakeup";
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCableMakeup"]).ValueMember = "CableMakeup";
            source.CurrentChanged += new EventHandler(this.bsCableMakeupCell_CurrentChanged);
            source.RaiseListChangedEvents = false;
            return table;
        }

        private void bsCableMakeupCell_CurrentChanged(object sender, EventArgs e)
        {
            Point currentCellAddress = this.dgvMeasCable.CurrentCellAddress;
            if ((currentCellAddress.X != -1) && (currentCellAddress.Y != -1))
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)this.dgvMeasCable.Rows[currentCellAddress.Y].Cells["dgvcWires"];
                if (((BindingSource)sender).Current != null)
                {
                    this.FillTableWires(cell.RowIndex, ((DataRowView)((BindingSource)sender).Current)["CableMakeup"].ToString());
                }
            }
        }

        private void bsWiresCell_CurrentChanged(object sender, EventArgs e)
        {
            Point currentCellAddress = this.dgvMeasCable.CurrentCellAddress;
            if ((currentCellAddress.X != -1) && (currentCellAddress.Y != -1))
            {
                DataGridViewCell dataGridViewCell = this.dgvMeasCable.Rows[currentCellAddress.Y].Cells["dgvcCableMakeup"];
                DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.dgvMeasCable.Rows[currentCellAddress.Y].Cells["dgvcCrossSection"];
                if (((BindingSource)sender).Current != null)
                {
                    int num = (((DataRowView)((BindingSource)sender).Current)["Wires"] is int) ? ((int)((DataRowView)((BindingSource)sender).Current)["Wires"]) : -1;
                    this.FillTableCrossSections(dataGridViewComboBoxCell.RowIndex, dataGridViewCell.Value.ToString(), num);
                }
            }
        }

        private void  bsCrossSectionCell_CurrentChanged(object sender, EventArgs e)
        {
            Point currentCellAddress = this.dgvMeasCable.CurrentCellAddress;
            if ((currentCellAddress.X != -1) && (currentCellAddress.Y != -1))
            {
                DataGridViewCell cell = this.dgvMeasCable.Rows[currentCellAddress.Y].Cells["dgvcCableMakeup"];
                DataGridViewCell cell2 = this.dgvMeasCable.Rows[currentCellAddress.Y].Cells["dgvcWires"];
                DataGridViewComboBoxCell cell3 = (DataGridViewComboBoxCell)this.dgvMeasCable.Rows[currentCellAddress.Y].Cells["dgvcCrossSection"];
                if (((BindingSource)sender).Current != null)
                {
                    double num = (((DataRowView)((BindingSource)sender).Current)["CrossSection"] is double) ? ((double)((DataRowView)((BindingSource)sender).Current)["CrossSection"]) : -1.0;
                    this.FillTableAmperage(cell3.RowIndex, cell.Value.ToString(), (cell2.Value is int) ? ((int)cell2.Value) : -1, num);
                }
            }
        }

        private DataTable CreateTablePermisAmperage(int rowIndex, bool fill)
        {
            DataTable table;
            if (this.dsMeasLowVoltage.Tables.Contains("dtPermisAmperage_" + this.IdTransformer.ToString() + "_" + rowIndex.ToString()))
            {
                table = this.dsMeasLowVoltage.Tables["dtPermisAmperage_" + this.IdTransformer.ToString() + "_" + rowIndex.ToString()];
            }
            else
            {
                table = new DataTable("dtPermisAmperage_" + this.IdTransformer.ToString() + "_" + rowIndex.ToString());
                table.Columns.Add("AmperageValue", typeof(double));
                table.Columns.Add("AmperageType", typeof(string));
                this.dsMeasLowVoltage.Tables.Add(table);
            }
            BindingSource source = new BindingSource
            {
                DataSource = table
            };
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[rowIndex].Cells["dgvcPermisAmperage"]).DataSource = source;
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[rowIndex].Cells["dgvcPermisAmperage"]).DisplayMember = "AmperageType";
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[rowIndex].Cells["dgvcPermisAmperage"]).ValueMember = "AmperageValue";
            return table;
        }

        //[CompilerGenerated]
        //internal string method_4()
        //{
        //    return this.SubstationName;
        //}

        private DataTable CreateTableCrossSections(int index, bool fill)
        {
            DataTable table;
            if (this.dsMeasLowVoltage.Tables.Contains("dtCrossSection_" + this.IdTransformer.ToString() + "_" + index.ToString()))
            {
                table = this.dsMeasLowVoltage.Tables["dtCrossSection_" + this.IdTransformer.ToString() + "_" + index.ToString()];
            }
            else
            {
                table = new DataTable("dtCrossSection_" + this.IdTransformer.ToString() + "_" + index.ToString());
                table.Columns.Add("CrossSection", typeof(double));
                this.dsMeasLowVoltage.Tables.Add(table);
            }
            BindingSource bs = new BindingSource
            {
                RaiseListChangedEvents = true
            };
            bs.CurrentChanged -= new EventHandler(this.bsCrossSectionCell_CurrentChanged);
            bs.DataSource = table;
            bs.CurrentChanged += new EventHandler(this.bsCrossSectionCell_CurrentChanged);
            bs.RaiseListChangedEvents = false;
            this.bsCrossSectionCell_CurrentChanged(bs, new EventArgs());
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCrossSection"]).DataSource = bs;
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCrossSection"]).DisplayMember = "CrossSection";
            ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcCrossSection"]).ValueMember = "CrossSection";
            return table;
        }

        private DataTable CreateTableCables(int index, DataTable dt, int idCell)
        {
            //Class166 class2 = new Class166
            //{
            //    int_0 = idCell
            //};
            if (((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DataSource == null)
            {
                dt = this.dsMeasLowVoltage.Tables["dtCable_" + this.IdTransformer.ToString() + "_" + index.ToString()];
                if (dt == null)
                {
                    dt = new DataTable("dtCable_" + this.IdTransformer.ToString() + "_" + index.ToString());
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Name", typeof(string));
                    this.dsMeasLowVoltage.Tables.Add(dt);
                }
                dt.Rows.Clear();
                //foreach (Class9<int, string> class3 in this.dsMeasLowVoltage.vJ_CableByCell.AsEnumerable<DataSetGES.Class108>().Where<DataSetGES.Class108>(new Func<DataSetGES.Class108, bool>(class2.method_0)).GroupBy<DataSetGES.Class108, Class8<int, string>>((C__1.C_9__68_1 ?? (C__1.C_9__68_1 = new Func<DataSetGES.Class108, Class8<int, string>>(C__1.<> 9.method_23)))).Select<IGrouping<Class8<int, string>, DataSetGES.Class108>, Class9<int, string>>(C__1.<> 9__68_2 ?? (C__1.<> 9__68_2 = new Func<IGrouping<Class8<int, string>, DataSetGES.Class108>, Class9<int, string>>(C__1.<> 9.method_24))))
                //{
                //    object[] values = new object[] { class3.IdCable, class3.NameCable };
                //    dt.Rows.Add(values);
                //}
                var enumerable = from row in this.dsMeasLowVoltage.vJ_CableByCell.AsEnumerable()
                                 where row.idCell == idCell && row["id"] != DBNull.Value
                                 group row by new
                                 {
                                     row.id,
                                     row.Name
                                 } into g
                                 select new
                                 {
                                     IdCable = g.Key.id,
                                     NameCable = g.Key.Name
                                 };
                foreach (var current in enumerable)
                {
                    dt.Rows.Add(new object[]
                    {
                        current.IdCable,
                        current.NameCable
                    });
                }
                BindingSource source = new BindingSource
                {
                    DataSource = dt
                };
                ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DataSource = source;
                ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).DisplayMember = "Name";
                ((DataGridViewComboBoxCell)this.dgvMeasCable.Rows[index].Cells["dgvcIdCable"]).ValueMember = "Id";
            }
            return dt;
        }
       // [CompilerGenerated]
       
        //private sealed class Class167
        //{
        //    public object object_0;
        //    public string string_0;

        //    internal bool method_0(DataRow dataRow_0)
        //    {
        //        return (dataRow_0.Field<object>(this.string_0) == this.object_0);
        //    }
        //}

        private void InsertMissingItem(int index, DataTable dt, string column1, object obj1, string column2, object obj2)
        {
            //Class167 class2 = new Class167
            //{
            //    string_0 = column1,
            //    object_0 = obj1
            //};
            //if (dt.AsEnumerable().Where<DataRow>(new Func<DataRow, bool>(class2.method_0)).Count<DataRow>() == 0)
            if ((from row in dt.AsEnumerable()
                 where row.Field<object>(column1) == obj1
                 select row).Count<DataRow>() == 0)
            {
                DataRow row = dt.NewRow();
                row[column1] = obj1;
                row[column2] = obj2;
                dt.Rows.InsertAt(row, 0);
            }
        }

        private void TransfSelectChanged()
        {
            //IEnumerator enumerator;
            if (this.TransfVoltageTables == null)
            {
                this.TransfVoltageTables = new Dictionary<string, DataSetMeasurementN.tJ_MeasVoltageTransfDataTable>();
            }
            this.bsMeasurement.EndEdit();
            if (this.MeasCableTables == null)
            {
                this.MeasCableTables = new Dictionary<string, DataSetMeasurementN.tJ_MeasCableDataTable>();
            }
            this.bsMeasCable.EndEdit();
            if (!this.TransfVoltageTables.ContainsKey(this.dictionaryKey))
            {
                DataSetMeasurementN.tJ_MeasVoltageTransfDataTable table = new DataSetMeasurementN.tJ_MeasVoltageTransfDataTable
                {
                    TableName = "tJ_MeasVoltageTransf"
                };
                // почему то не копируется примари кей
                //if (table.PrimaryKey.Count() == 0)
                //    table.PrimaryKey = new DataColumn[] { table.Columns["id"] };

                if (this.StateCreate == StateFormCreate.Add)
                {
                    //DataSetGES.Class124 class2 = table.method_5();
                    DataSetMeasurementN.tJ_MeasVoltageTransfRow row = table.NewtJ_MeasVoltageTransfRow();
                    row.idMeasurement = this.IdMeasurement;
                    row.idBus = this.IdBus;
                    row.idObjList = this.IdTransformer;
                    row.idSwitchPosition = -1;
                    row["idOldMeasurementTransf"] = DBNull.Value;
                    row.Deleted = false;
                    table.AddtJ_MeasVoltageTransfRow(row);
                }
                else
                {
                    base.SelectSqlData(table, true, string.Format("WHERE idMeasurement = {0} AND idBus = {1} AND idObjList = {2} AND Deleted = ((0))", this.IdMeasurement, this.IdBus, this.IdTransformer), null ,false);
                    if (table.Rows.Count == 0)
                    {
                        //DataSetGES.Class124 class3 = table.NewtJ_MeasVoltageTransfRow();
                        DataSetMeasurementN.tJ_MeasVoltageTransfRow row = table.NewtJ_MeasVoltageTransfRow();
                        row.idMeasurement = this.IdMeasurement;
                        row.idBus = this.IdBus;
                        row.idObjList = this.IdTransformer;
                        row.idSwitchPosition = -1;
                        row["idOldMeasurementTransf"] = DBNull.Value;
                        row.Deleted = false;
                        //table.method_0(row);
                        table.AddtJ_MeasVoltageTransfRow(row);
                    }
                }
                // this.TransfVoltageTables.Add(new KeyValuePair<string, DataSetGES.tJ_MeasVoltageTransfDataTable>(this.dictionaryKey, table));
                this.TransfVoltageTables.Add(new KeyValuePair<string, DataSetMeasurementN.tJ_MeasVoltageTransfDataTable>(this.dictionaryKey, table));
            }
            else
            {
                //using (enumerator = this.TransfVoltageTables[this.dictionaryKey].Rows.GetEnumerator())
                //{
                //    while (enumerator.MoveNext())
                //    {
                //        ((DataRow)enumerator.Current).EndEdit();
                //    }
                //}
                foreach (DataRow dataRow in this.TransfVoltageTables[this.dictionaryKey].Rows)
                {
                    dataRow.EndEdit();
                }
            }
            this.bindingSource_2.DataSource = this.TransfVoltageTables[this.dictionaryKey];

            if (!this.MeasCableTables.ContainsKey(this.dictionaryKey))
            {
                DataSetMeasurementN.tJ_MeasCableDataTable table2 = new DataSetMeasurementN.tJ_MeasCableDataTable();
                this.MeasCableTables.Add(new KeyValuePair<string, DataSetMeasurementN.tJ_MeasCableDataTable>(this.dictionaryKey, table2));
                this.bsMeasCable.DataSource = this.MeasCableTables[this.dictionaryKey];
                this.bsMeasCable.ResetBindings(false);
                int num = 0;
                table2.TableName = "tJ_MeasCable";
                if (this.StateCreate == StateFormCreate.Add)
                {
                    num = this.CreateNewCableRows(table2, num);
                }
                else
                {
                   // using (enumerator = base.SelectSqlData(table2.TableName, true, string.Format("WHERE idMeasurement = {0} AND idBus = {1} AND idTransf = {2} AND Deleted = ((0)) AND NOT EXISTS(SELECT * FROM tSchm_ObjList AS ol WHERE ol.id = idCell AND ol.Deleted = 1)", this.IdMeasurement, this.IdBus, this.IdTransformer)).Rows.GetEnumerator())
                        DataTable dataTable = base.SelectSqlData(table2.TableName, true, string.Format("WHERE idMeasurement = {0} AND idBus = {1} AND idTransf = {2} AND Deleted = ((0)) AND NOT EXISTS(SELECT * FROM tSchm_ObjList AS ol WHERE ol.id = idCell AND ol.Deleted = 1)", this.IdMeasurement, this.IdBus, this.IdTransformer));
                    ////using (enumerator = dataTable.Rows.GetEnumerator())
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        //////DataRow dataRow;
                        //////while (enumerator.MoveNext())
                        {
                            // Class168 class4 = new Class168
                            //{
                            /////dataRow = (DataRow)enumerator.Current;
                            //};
                            //DataSetGES.Class105 class5 = table2.method_5();
                            DataSetMeasurementN.tJ_MeasCableRow tJ_MeasCableRow = table2.NewtJ_MeasCableRow();
                            tJ_MeasCableRow["id"] = dataRow["id"];
                            tJ_MeasCableRow["idMeasurement"] = dataRow["idMeasurement"];
                            tJ_MeasCableRow["idBus"] = dataRow["idBus"];
                            tJ_MeasCableRow["idTransf"] = dataRow["idTransf"];
                            tJ_MeasCableRow["idCable"] = dataRow["idCable"];
                            tJ_MeasCableRow["idCell"] = dataRow["idCell"];
                            tJ_MeasCableRow["NameCell"] = "";
                            if (dataRow["idCell"] != DBNull.Value)
                            {
                                //EnumerableRowCollection<string> rows1 = this.dsMeasLowVoltage.vJ_CellByBus.Where<DataSetGES.Class118>(new Func<DataSetGES.Class118, bool>(class4.method_0)).Select<DataSetGES.Class118, string>(C__1.<> 9__71_1 ?? (C__1.<> 9__71_1 = new Func<DataSetGES.Class118, string>(C__1.<> 9.method_28)));

                                var rows1 = from r in this.dsMeasLowVoltage.vJ_CellByBus
                                                                         where r.id == (int)dataRow["idCell"]
                                                                         select r.Name;
                                if (rows1.Count<string>() > 0)
                                {
                                    tJ_MeasCableRow["NameCell"] = rows1.First();
                                }
                            }
                            tJ_MeasCableRow["NameCable"] = "";
                            if (dataRow["idCable"] != DBNull.Value)
                            {
                                //EnumerableRowCollection<string> rows2 = this.dsMeasLowVoltage.vJ_CableByCell.Where<DataSetGES.Class108>(new Func<DataSetGES.Class108, bool>(class4.method_1)).Select<DataSetGES.Class108, string>(C__1.<> 9__71_3 ?? (C__1.<> 9__71_3 = new Func<DataSetGES.Class108, string>(C__1.<> 9.method_29)));
                                var rows2 = from r in this.dsMeasLowVoltage.vJ_CableByCell
                                                                          where r.id == (int)dataRow["idCable"]
                                                                          select r.Name;
                                if (rows2.Count() > 0)
                                {
                                    tJ_MeasCableRow["NameCable"] = rows2.First();
                                }
                            }
                            tJ_MeasCableRow["OldCell"] = dataRow["OldCell"];
                            tJ_MeasCableRow["idSchmAbn"] = dataRow["idSchmAbn"];
                            tJ_MeasCableRow["Address"] = dataRow["Address"];
                            tJ_MeasCableRow["Company"] = dataRow["Company"];
                            tJ_MeasCableRow["Makeup"] = dataRow["Makeup"];
                            tJ_MeasCableRow["Voltage"] = dataRow["Voltage"];
                            tJ_MeasCableRow["Wires"] = dataRow["Wires"];
                            tJ_MeasCableRow["Voltage"] = dataRow["Voltage"];
                            tJ_MeasCableRow["CrossSection"] = dataRow["CrossSection"];
                            tJ_MeasCableRow["PermisAmperage"] = dataRow["PermisAmperage"];
                            tJ_MeasCableRow["Iad"] = dataRow["Iad"];
                            tJ_MeasCableRow["Ian"] = dataRow["Ian"];
                            tJ_MeasCableRow["Ibd"] = dataRow["Ibd"];
                            tJ_MeasCableRow["Ibn"] = dataRow["Ibn"];
                            tJ_MeasCableRow["Icd"] = dataRow["Icd"];
                            tJ_MeasCableRow["Icn"] = dataRow["Icn"];
                            tJ_MeasCableRow["Iod"] = dataRow["Iod"];
                            tJ_MeasCableRow["Ion"] = dataRow["Ion"];
                            tJ_MeasCableRow["Comment"] = dataRow["Comment"];
                           tJ_MeasCableRow["idOldMeasurementCable"] = dataRow["idOldMeasurementCable"];
                            tJ_MeasCableRow["Deleted"] = dataRow["Deleted"];
                            table2.AddtJ_MeasCableRow(tJ_MeasCableRow);
                            tJ_MeasCableRow.AcceptChanges();
                            tJ_MeasCableRow.SetModified();
                        }
                    }
                    if (table2.Rows.Count == 0)
                    {
                        num = this.CreateNewCableRows(table2, num);
                    }
                }
            }
            else
            {
                DataSetMeasurementN.tJ_MeasCableDataTable table3 = new DataSetMeasurementN.tJ_MeasCableDataTable();
                foreach (DataRow row in this.MeasCableTables[this.dictionaryKey])
                {
                    table3.ImportRow(row);
                }
                this.MeasCableTables[this.dictionaryKey].Rows.Clear();
                this.bsMeasCable.DataSource = this.MeasCableTables[this.dictionaryKey];
                this.bsMeasCable.ResetBindings(false);
                foreach (DataRow row2 in table3.Rows)
                {
                    this.MeasCableTables[this.dictionaryKey].ImportRow(row2);
                }
                //using (enumerator = this.MeasCableTables[this.dictionaryKey].Rows.GetEnumerator())
                //{
                //    while (enumerator.MoveNext())
                //    {
                //        ((DataRow)enumerator.Current).EndEdit();
                //    }
                //}
                foreach (DataRow dataRow2 in this.MeasCableTables[this.dictionaryKey].Rows)
                {
                    dataRow2.EndEdit();
                }
                this.bsMeasCable.Sort = string.Format("NameCell ASC, OldCell ASC", new object[0]);
                this.bsMeasCable.ResetBindings(true);
            }
        }
        //[CompilerGenerated]
        //private bool method_56(Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108> class12_0)
        //{
        //    Class169 class2 = new Class169
        //    {
        //        class12_0 = class12_0
        //    };
        //    return (this.dsMeasLowVoltage.vJ_TransfByCell.Where<DataSetGES.Class107>(new Func<DataSetGES.Class107, bool>(class2.method_0)).Count<DataSetGES.Class107>() == 0);
        //}
        //[CompilerGenerated]
        //private bool method_57(Class13<int, int, string, int, string> class13_0)
        //{
        //    return (!this.dsMeasLowVoltage.tJ_MeasCable.Cast<DataSetGES.Class105>().Where<DataSetGES.Class105>((C__1.<> 9__72_9 ?? (C__1.<> 9__72_9 = new Func<DataSetGES.Class105, bool>(C__1.<> 9.method_36)))).Select<DataSetGES.Class105, int>((C__1.<> 9__72_10 ?? (C__1.<> 9__72_10 = new Func<DataSetGES.Class105, int>(C__1.<> 9.method_37)))).ToArray<int>().Contains<int>(class13_0.idCell) || !this.dsMeasLowVoltage.tJ_MeasCable.Cast<DataSetGES.Class105>().Where<DataSetGES.Class105>((C__1.<> 9__72_11 ?? (C__1.<> 9__72_11 = new Func<DataSetGES.Class105, bool>(C__1.<> 9.method_38)))).Select<DataSetGES.Class105, int>((C__1.<> 9__72_12 ?? (C__1.<> 9__72_12 = new Func<DataSetGES.Class105, int>(C__1.<> 9.method_39)))).ToArray<int>().Contains<int>(class13_0.idCable));
        //}

        private int CreateNewCableRows(DataSetMeasurementN.tJ_MeasCableDataTable dt, int cell)
        {
            var source = from c in this.dsMeasLowVoltage.vJ_CellByBus
                         join cab in this.dsMeasLowVoltage.vJ_CableByCell on c.id equals cab.idCell into leftCab
                         from cab in leftCab.DefaultIfEmpty()
                         where (from t in this.dsMeasLowVoltage.vJ_TransfByCell
                                where t.idCell == c.id
                                select t).Count() == 0
                         select new
                         {
                             idBus = ((c["idBus"] != null) ? ((int)c["idBus"]) : -1),
                             idCell = ((c["id"] != null) ? ((int)c["id"]) : -1),
                             NameCell = ((c["Name"] != null) ? c["Name"].ToString() : ""),
                             idCable = ((cab != null) ? ((int)cab["id"]) : -1),
                             NameCable = ((cab != null) ? cab["Name"].ToString() : "")
                         };
            var orderedEnumerable = (from s in source.Where(row => //delegate(row)
            {
                if ((from DataSetMeasurementN.tJ_MeasCableRow rowCell in this.dsMeasLowVoltage.tJ_MeasCable
                     where rowCell["idCell"] != DBNull.Value
                     select rowCell.idCell).ToArray<int>().Contains(row.idCell))
                {
                    return !(from DataSetMeasurementN.tJ_MeasCableRow rowCable in this.dsMeasLowVoltage.tJ_MeasCable
                             where rowCable["idCable"] != DBNull.Value
                             select rowCable.idCable).ToArray<int>().Contains(row.idCable);
                }
                return true;
            })
                                     orderby Regex.Match(s.NameCell, "^\\D").Length == 0, Regex.Match(s.NameCell, "\\D*").Value
                                     select s).ThenBy(s => //delegate (s)
                                     {
                                         if (!int.TryParse(Regex.Match(s.NameCell, "\\d+").Value, out cell))
                                         {
                                             return 0;
                                         }
                                         return int.Parse(Regex.Match(s.NameCell, "\\d+").Value);
                                     });

            //Class170 class2 = new Class170
            //{
            //    int_0 = cell
            //};
            //foreach (Class13<int, int, string, int, string> class3 in this.dsMeasLowVoltage.vJ_CellByBus.GroupJoin<DataSetGES.Class118, DataSetGES.Class108, int, Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>>(this.dsMeasLowVoltage.vJ_CableByCell, (C__1.<> 9__72_0 ?? (C__1.<> 9__72_0 = new Func<DataSetGES.Class118, int>(C__1.<> 9.method_30))), (C__1.<> 9__72_1 ?? (C__1.<> 9__72_1 = new Func<DataSetGES.Class108, int>(C__1.<> 9.method_31))), (C__1.<> 9__72_2 ?? (C__1.<> 9__72_2 = new Func<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>, Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>>(C__1.<> 9.method_32)))).SelectMany<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108, Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108>>((C__1.<> 9__72_3 ?? (C__1.<> 9__72_3 = new Func<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, IEnumerable<DataSetGES.Class108>>(C__1.<> 9.method_33))), (C__1.<> 9__72_4 ?? (C__1.<> 9__72_4 = new Func<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108, Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108>>(C__1.<> 9.method_34)))).Where<Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108>>(new Func<Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108>, bool>(this.method_56)).Select<Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108>, Class13<int, int, string, int, string>>((C__1.<> 9__72_7 ?? (C__1.<> 9__72_7 = new Func<Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108>, Class13<int, int, string, int, string>>(C__1.<> 9.method_35)))).Where<Class13<int, int, string, int, string>>(new Func<Class13<int, int, string, int, string>, bool>(this.method_57)).OrderBy<Class13<int, int, string, int, string>, bool>((C__1.<> 9__72_13 ?? (C__1.<> 9__72_13 = new Func<Class13<int, int, string, int, string>, bool>(C__1.<> 9.method_40)))).ThenBy<Class13<int, int, string, int, string>, string>((C__1.<> 9__72_14 ?? (C__1.<> 9__72_14 = new Func<Class13<int, int, string, int, string>, string>(C__1.<> 9.method_41)))).ThenBy<Class13<int, int, string, int, string>, int>(new Func<Class13<int, int, string, int, string>, int>(class2.method_0)))
            foreach (var current in orderedEnumerable)
            {
                this.dsMeasLowVoltage.vJ_LastCableInfo.Rows.Clear();
                if (current.idCable != -1)
                {
                    //SelectSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.vJ_LastCableInfo, true, string.Format("WHERE idCable = {0} AND idSubstation = {1} AND idCell = {2} ORDER BY [Year] DESC", class3.idCable, this.IdSubstation, class3.idCell), 1);
                    SelectSqlData(this.dsMeasLowVoltage.vJ_LastCableInfo, true, string.Format("WHERE idCable = {0} AND idSubstation = {1} AND idCell = {2} ORDER BY [Year] DESC", current.idCable, this.IdSubstation, current.idCell), null, false, 1);
                }
                DataSetMeasurementN.tJ_MeasCableRow row = dt.NewtJ_MeasCableRow();
                //row.Int32_0 = (dt.Rows.Count > 0) ? (dt.Min<DataSetGES.Class105>((C__1.<> 9__72_16 ?? (C__1.<> 9__72_16 = new Func<DataSetGES.Class105, int>(C__1.method_42)))) - 1) : -1;
                row.id = (dt.Rows.Count > 0) ? dt.Min(r => r.id) - 1 : -1;
                row.idMeasurement = this.IdMeasurement;
                row.idBus = this.IdBus;
                row.idTransf = this.IdTransformer;
                row.idCable = current.idCable;
                row.idCell = current.idCell;
                if (this.dsMeasLowVoltage.vJ_LastCableInfo.Rows.Count > 0)
                {
                    row["Address"] = this.dsMeasLowVoltage.vJ_LastCableInfo.First()["Address"];
                    row["Company"] = this.dsMeasLowVoltage.vJ_LastCableInfo.First()["Company"];
                    row["Makeup"] = this.dsMeasLowVoltage.vJ_LastCableInfo.First()["Makeup"];
                    row["Voltage"] = this.dsMeasLowVoltage.vJ_LastCableInfo.First()["Voltage"];
                    row["Wires"] = this.dsMeasLowVoltage.vJ_LastCableInfo.First()["Wires"];
                    row["CrossSection"] = this.dsMeasLowVoltage.vJ_LastCableInfo.First()["CrossSection"];
                    row["PermisAmperage"] = this.dsMeasLowVoltage.vJ_LastCableInfo.First()["PermisAmperage"];
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
            return cell;
        }

        private bool IsExistsCableMakup(int rowIndex)
        {
            string str = (this.dgvMeasCable.Rows[rowIndex].Cells["dgvcCableMakeup"].Value is string) ? this.dgvMeasCable.Rows[rowIndex].Cells["dgvcCableMakeup"].Value.ToString() : "";
            int num = (this.dgvMeasCable.Rows[rowIndex].Cells["dgvcWires"].Value is int) ? ((int)this.dgvMeasCable.Rows[rowIndex].Cells["dgvcWires"].Value) : 0;
            double num2 = (this.dgvMeasCable.Rows[rowIndex].Cells["dgvcCrossSection"].Value is double) ? ((double)this.dgvMeasCable.Rows[rowIndex].Cells["dgvcCrossSection"].Value) : 0.0;

            return (base.SelectSqlData("tR_Cable", true, string.Format("WHERE CableMakeup = '{0}' AND Wires = {1} AND CrossSection = {2} AND Deleted = ((0))", str, num, num2.ToString().Replace(',', '.'))).Rows.Count > 0);
        }

        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefreshCellAddress();
        }

        //private void method_47(object sender, FormClosedEventArgs e)
        //{
        //    this.RefreshCellAddress();
        //}

        private bool SaveData()
        {
            if (this.StateCreate == StateFormCreate.Add)
            {
                //using (IEnumerator<DataSetGES.Class94> enumerator = this.dsMeasLowVoltage.tJ_Measurement.GetEnumerator())
                //{
                //    while (enumerator.MoveNext())
                //    {
                //        enumerator.Current.EndEdit();
                //    }
                //}
                foreach (var current in this.dsMeasLowVoltage.tJ_Measurement)
                {
                    current.EndEdit();
                }
                this.IdMeasurement=(base.InsertSqlDataOneRow(this.dsMeasLowVoltage, this.dsMeasLowVoltage.tJ_Measurement));
                if (this.IdMeasurement == -1)
                {
                    return false;
                }
                foreach (string str in this.dictionaryKeys)
                {
                    if ((MeasurementCheck.IsSaveTableValues(this.TransfVoltageTables[str]) || MeasurementCheck.IsSaveTableValues(this.MeasCableTables[str])) || (this.StateCreate == StateFormCreate.Edit))
                    {
                        foreach (var local1 in this.TransfVoltageTables[str])
                        {
                            local1.idMeasurement = this.IdMeasurement;
                            local1.EndEdit();
                        }
                        base.InsertSqlData(this.TransfVoltageTables[str]);
                        base.UpdateSqlData(this.TransfVoltageTables[str]);
                        base.DeleteSqlData(this.TransfVoltageTables[str]);
                        foreach (var local2 in this.MeasCableTables[str])
                        {
                            local2.idMeasurement = this.IdMeasurement;
                            local2.EndEdit();
                        }
                        this.MeasCableTables[str].Columns.Remove("NameCell");
                        this.MeasCableTables[str].Columns.Remove("NameCable");
                        SqlDataCommand cl = new SqlDataCommand();
                        cl.SqlSettings = this.SqlSettings;
                        cl.InsertSqlDataN(this.MeasCableTables[str]);
                        base.UpdateSqlData(this.MeasCableTables[str]);
                        base.DeleteSqlData(this.MeasCableTables[str]);
                    }
                }
            }
            else
            {
                foreach (DataRow dataRow in this.dsMeasLowVoltage.tJ_Measurement.Rows)
                {
                    dataRow.EndEdit();
                }
                base.UpdateSqlData(this.dsMeasLowVoltage, this.dsMeasLowVoltage.tJ_Measurement);
                foreach (string str2 in this.dictionaryKeys)
                {
                    if (this.TransfVoltageTables.ContainsKey(str2))
                    {
                        foreach (DataRow row in this.TransfVoltageTables[str2].Rows)
                        {
                            row.EndEdit();
                        }
                        SqlDataCommand cl = new SqlDataCommand();
                        cl.SqlSettings = this.SqlSettings;
                        cl.UpdateSqlDataN(this.TransfVoltageTables[str2]);
                        base.InsertSqlData(this.TransfVoltageTables[str2]);
                        //using (enumerator5 = this.MeasCableTables[str2].Rows.GetEnumerator())
                        //{
                        //    while (enumerator5.MoveNext())
                        //    {
                        //        ((DataRow)enumerator5.Current).EndEdit();
                        //    }
                        //}
                        //foreach (IEnumerator dataRow3 in this.MeasCableTables[str2].Rows)
                        foreach (DataRow row in MeasCableTables[str2].Rows)
                        {
                            row.EndEdit();
                        }
                        this.MeasCableTables[str2].Columns.Remove("NameCell");
                        this.MeasCableTables[str2].Columns.Remove("NameCable");
                        base.UpdateSqlData(this.MeasCableTables[str2]);
                        base.InsertSqlData(this.MeasCableTables[str2]);
                        base.DeleteSqlData(this.MeasCableTables[str2]);
                    }
                }
            }
            return true;
        }

        private bool Check()
        {
            if ((this.cbYear.SelectedValue != null) && ((this.cbYear.SelectedValue is int) || (int.Parse(this.cbYear.SelectedValue.ToString()) >= 1900)))
            {
                if (this.nudTemperatureD.Value == decimal.Zero)
                {
                    this.dsMeasLowVoltage.tJ_Measurement.First().TemperatureD = 0;
                    this.dsMeasLowVoltage.tJ_Measurement.First().EndEdit();
                }
                if (this.nudTemperatureN.Value == decimal.Zero)
                {
                    this.dsMeasLowVoltage.tJ_Measurement.First().TemperatureN = 0;
                    this.dsMeasLowVoltage.tJ_Measurement.First().EndEdit();
                }
                if (this.dtpDateD.Value == null)
                {
                    MessageBox.Show("Поле \"День\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
                if (this.dtpDateN.Value == null)
                {
                    MessageBox.Show("Поле \"Вечер\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
                if (((this.cbWorker.SelectedValue != null) && (this.cbWorker.SelectedValue is int)) && (int.Parse(this.cbWorker.SelectedValue.ToString()) >= 1))
                {
                    if (this.bsBusesTransf.Current == null)
                    {
                        MessageBox.Show("Поле \"Секция шин\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return false;
                    }
                    return true;
                }
                MessageBox.Show("Поле \"Замеры проводил\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            MessageBox.Show("Поле \"Период\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return false;
        }

        //[CompilerGenerated]
        //internal void method_5(string string_2)
        //{
        //    this.SubstationName = string_2;
        //}
        //[CompilerGenerated]
        //private void method_58(DataSetGES.Class108 class108_0)
        //{
        //    this.dsMeasLowVoltage.vJ_CableByCell.ImportRow(class108_0);
        //}
        private void frmAddCMeasCable_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAddMeasCable form = (FormAddMeasCable)sender;
            DataSetMeasurementN.tJ_MeasCableRow[] rows = form.Rows;
            form.TableCable.Except(this.dsMeasLowVoltage.vJ_CableByCell).ToList().ForEach(
                r =>
                {
                    this.dsMeasLowVoltage.vJ_CableByCell.ImportRow(r);
                });
            foreach (DataSetMeasurementN.tJ_MeasCableRow r in form.Rows)
            {
                this.MeasCableTables[form.DictionaryKey].ImportRow(r);
            }


            this.bsMeasCable.ResetBindings(false);
            for (int i = 0; i < this.dgvMeasCable.Rows.Count; i++)
            {
                for (int j = 0; j < this.dgvMeasCable.Columns.Count; j++)
                {
                    if ((this.dgvMeasCable.Rows[i].Cells[j] is DataGridViewComboBoxCell) && this.dgvMeasCable.Rows[i].Cells[j].Visible)
                    {
                        string name = this.dgvMeasCable.Columns[j].Name;
                        if ((j == this.dgvMeasCable.Rows[i].Cells["dgvcIdCable"].ColumnIndex) && (this.dgvMeasCable.Rows[i].Cells["dgvcIdCell"].Value is int))
                        {
                            int num4 = (int)this.dgvMeasCable.Rows[i].Cells[j].Value;
                            this.CreateTableCables(i, new DataTable(), num4);
                        }
                        DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)this.dgvMeasCable.Rows[i].Cells[j];
                        this.dgvMeasCable.CurrentCell = cell;
                        this.dgvMeasCable.BeginEdit(false);
                        this.dgvMeasCable.EndEdit();
                        this.dgvMeasCable.CurrentCell = null;
                    }
                }
            }
        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseReason closeReason = e.CloseReason;
        }

        private void DgvMeasCableSort(int index)
        {
            DataGridViewColumn column = this.dgvMeasCable.Columns[index];
            this.isSortAscending = (this.sortColumn == null) || !this.isSortAscending;
            ListSortDirection direction = this.isSortAscending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            string str = (column.Name == "dgvcIdCell") ? "dgvcNameCell" : column.Name;
            str = (column.Name == "dgvcIdCable") ? "dgvcNameCable" : column.Name;
            this.dgvMeasCable.Sort(this.dgvMeasCable.Columns[str], direction);
            this.bsMeasCable.ResetBindings(true);
            if (this.sortColumn != null)
            {
                this.sortColumn.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.None;
            }
            column.HeaderCell.SortGlyphDirection = this.isSortAscending ? System.Windows.Forms.SortOrder.Ascending : System.Windows.Forms.SortOrder.Descending;
            this.sortColumn = column;
        }




        //[CompilerGenerated]
        //internal int method_6()
        //{
        //    return this.IdTransformer;
        //}

        //[CompilerGenerated]
        //internal void method_7(int int_7)
        //{
        //    this.IdTransformer = int_7;
        //}

        //[CompilerGenerated]
        //internal int method_8()
        //{
        //    return this.IdBus;
        //}

        //[CompilerGenerated]
        //internal void method_9(int int_7)
        //{
        //    this.IdBus = int_7;
        //}

        private void textBox_11_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheck.OnlyDigit(sender, e);
        }

        private void tsbMeasAbnObjAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (((this.dgvMeasCable.Rows.Count > 0) && (this.dgvMeasCable.SelectedRows[0].Cells["dgvcIdCell"].Value != null)) && (this.dgvMeasCable.SelectedRows[0].Cells["dgvcIdCell"].Value is int))
                {
                    int num = (int)this.dgvMeasCable.SelectedRows[0].Cells["dgvcIdCell"].Value;
                    string[] textArray = new string[]
                    {
                        num.ToString()
                    };
                    object obj2 = base.CallSQLScalarFunction("dbo.fn_GetIdBusByCell", textArray);
                    int num2 = (obj2 != null) ? ((int)obj2) : -1;
                    ShowFormEventArgs args = new ShowFormEventArgs();
                    args.TypeForm=("Scheme.Forms.LinkSchmAbn.FormLinkSchmAbnAdd, Scheme");
                    args.FormMode = eFormMode.Mdi; //1
                    args.Param = (new object[4]);
                    args.Param[0] = this.typeDoc;
                    args.Param[1] = this.IdSubstation;
                    args.Param[2] = num2;
                    args.Param[3] = num;
                    args.SQLSettings = (this.SqlSettings);
                    this.OnShowForm(args).FormClosed += new FormClosedEventHandler(this.f_FormClosed);
                }
                else
                {
                    MessageBox.Show("Не выбран, либо отсутствует выключатель!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), exception.Message);
            }
        }

        private void tsbMeasAbnObjDelete_Click(object sender, EventArgs e)
        {
            if ((this.dgvAbnObj.Rows.Count != 0) && (this.dgvAbnObj.SelectedRows[0].Cells["idSchmObjDataGridViewTextBoxColumn"].Value is int))
            {
                List<string> list = new List<string>();
                if (MessageBox.Show("Вы действительно хотите удалить выделенные записи?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string str = "";
                    foreach (DataGridViewRow row in this.dgvAbnObj.SelectedRows)
                    {
                        if ((row.Cells["dgvcIds"].Value != DBNull.Value) && (row.Cells["dgvcIds"].Value.ToString().Length > 0))
                        {
                            if ((row.Cells["typeDocDgvColumn"].Value != DBNull.Value) && (((int)row.Cells["typeDocDgvColumn"].Value) == 0x4a7))
                            {
                                str = str + ((str != "") ? "," : "") + row.Cells["dgvcIds"].Value.ToString();
                            }
                            else
                            {
                                list.Add(row.Cells["dgvcIds"].Value.ToString());
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(str))
                    {
                        base.DeleteSqlDataWhere(this.dsMeasLowVoltage.tL_SchmAbn, string.Format("WHERE id IN ({0})", str));
                    }
                    this.RefreshCellAddress(list);
                }
            }
            else
            {
                MessageBox.Show("Не выбран адрес.", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsbMeasAbnObjRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshCellAddress();
        }

        private void tssbAddMissingCells_Click(object sender, EventArgs e)
        {
            //EnumerableRowCollection<DataSetGES.Class105> source = this.MeasCableTables[this.dictionaryKey].Where<DataSetGES.Class105>(C__1.<> 9__89_0 ?? (C__1.<> 9__89_0 = new Func<DataSetGES.Class105, bool>(C__1.<> 9.method_43)));
            // EnumerableRowCollection<DataSetMeasurementN.tJ_MeasCableRow> source
            var source = from r in this.MeasCableTables[this.dictionaryKey]
                         where r.RowState != DataRowState.Deleted && r.id < 0
                         select r;
            FormAddMeasCable form1 = new FormAddMeasCable();
            form1.SqlSettings = (this.SqlSettings);
            form1.IdBus = (this.IdBus);
            form1.IdMeasurement = (this.IdMeasurement);
            form1.IdSubstation = (this.IdSubstation);
            form1.IdTransformer = (this.IdTransformer);
            form1.DictionaryKey = (this.dictionaryKey);

            //form1.set_StartId((source.Count<DataSetGES.Class105>() > 0) ? (source.Min<DataSetGES.Class105>((C__1.<> 9__89_1 ?? (C__1.<> 9__89_1 = new Func<DataSetGES.Class105, int>(C__1.<> 9.method_44)))) - 1) : -1);
            form1.StartId = source.Count() > 0 ? source.Min(r => r.id) - 1 : -1;
            //form1.set_TypeDoc((FormMeasurement.TypeDoc)this.typeDoc);
            form1.TypeDoc = ((FormMeasurement.TypeDoc)this.typeDoc);
            form1.FormClosed += new FormClosedEventHandler(this.frmAddCMeasCable_FormClosed);
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }

        private void OpenReferenceCable_Click(object sender, EventArgs e)
        {
            FormCable form = new FormCable();
            form.SqlSettings=(this.SqlSettings);
            form.FormClosed += new FormClosedEventHandler(this.frm_FormClosed);
            form.MdiParent = base.MdiParent;
            form.Show();
        }

        private void toolBtnImportTemperature_Click(object sender, EventArgs e)
        {
            if ((this.dtpDateD.Value == null) && (this.dtpDateN.Value == null))
            {
                MessageBox.Show("Не указана дата");
            }
            else
            {
                DataTable table = new DataTable("tj_temperature");
                table.Columns.Add("NightDown", typeof(int));
                table.Columns.Add("DayDown", typeof(int));
                new DataSet().Tables.Add(table);
                if (this.dtpDateD.Value != null)
                {
                    base.SelectSqlData(table, true, "where dateTemp = '" + Convert.ToDateTime(this.dtpDateD.Value).ToString("yyyyMMdd") + "'", null, false, 0);
                    if ((table.Rows.Count > 0) && (table.Rows[0]["DayDown"] != DBNull.Value))
                    {
                        this.nudTemperatureD.Value = Convert.ToInt32(table.Rows[0]["DayDown"]);
                    }
                }
                if (this.dtpDateN.Value != null)
                {
                    base.SelectSqlData(table, true, "where dateTemp = '" + Convert.ToDateTime(this.dtpDateN.Value).ToString("yyyyMMdd") + "'", null, false, 0);
                    if ((table.Rows.Count > 0) && (table.Rows[0]["NightDown"] != DBNull.Value))
                    {
                        this.nudTemperatureN.Value = Convert.ToInt32(table.Rows[0]["NightDown"]);
                    }
                }
            }
        }

        private void tsmiMeasCableDelAddress_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить адрес объекта?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.dgvMeasCable.SelectedRows[0].Cells["Address"].Value = "";
            }
        }

        private void toolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить наименование объекта?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.dgvMeasCable.SelectedRows[0].Cells["Company"].Value = "";
            }
        }

        private void toolStripMenuItem_2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить строку?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (DataGridViewRow row in this.dgvMeasCable.SelectedRows)
                {
                    this.dgvMeasCable.Rows.Remove(row);
                }
                MessageBox.Show("Строка успешно удалена.");
            }
        }



//        [Serializable, CompilerGenerated]
//        private sealed class C__1
//    {
//        public static readonly FormAddEditMeasLowVoltage.<>c<>9 = new FormAddEditMeasLowVoltage.<>c();
//        public static Func<DataSetGES.Class121, Class6<int, string, int, string, string>> <>9__41_0;
//        public static Func<DataSetGES.Class122, Class6<int, string, int, string, string>> <>9__41_1;
//        public static Func<DataSetGES.Class122, Class6<int, string, int, string, string>> <>9__41_2;
//        public static Func<DataSetGES.Class120, string> <>9__41_3;
//        public static Func<DataSetGES.Class50, bool> <>9__43_0;
//        public static Func<DataSetGES.Class50, int> <>9__43_1;
//        public static Func<DataSetGES.Class108, bool> <>9__48_0;
//        public static Func<DataSetGES.Class108, Class8<int, string>> <>9__48_1;
//        public static Func<IGrouping<Class8<int, string>, DataSetGES.Class108>, Class9<int, string>> <>9__48_2;
//        public static Func<DataSetGES.Class78, string> <>9__51_0;
//        public static Func<DataSetGES.Class78, string> <>9__51_1;
//        public static Func<DataSetGES.Class78, int> <>9__53_1;
//        public static Func<DataSetGES.Class78, int> <>9__53_2;
//        public static Func<DataSetGES.Class78, bool> <>9__56_0;
//        public static Func<DataSetGES.Class78, double> <>9__56_1;
//        public static Func<DataSetGES.Class78, double> <>9__56_2;
//        public static Func<DataSetGES.Class78, double> <>9__57_1;
//        public static Func<DataSetGES.Class78, double> <>9__57_2;
//        public static Func<DataSetGES.Class78, bool> <>9__59_0;
//        public static Func<DataSetGES.Class78, double> <>9__59_1;
//        public static Func<DataSetGES.Class78, Class10<double, string>> <>9__59_2;
//        public static Func<DataSetGES.Class78, double> <>9__60_1;
//        public static Func<DataSetGES.Class78, Class10<double, string>> <>9__60_2;
//        public static Func<DataSetGES.Class108, Class8<int, string>>C_9__68_1;
//        public static Func<IGrouping<Class8<int, string>, DataSetGES.Class108>, Class9<int, string>> <>9__68_2;
//        public static Func<DataRow, string> C9__70_0;
//        public static Func<DataSetGES.Class118, string> <>9__70_1;
//        public static Func<DataSetGES.Class107, int> <>9__70_3;
//        public static Func<DataSetGES.Class118, string> <>9__71_1;
//        public static Func<DataSetGES.Class108, string> <>9__71_3;
//        public static Func<DataSetGES.Class118, int> <>9__72_0;
//        public static Func<DataSetGES.Class108, int> <>9__72_1;
//        public static Func<DataSetGES.Class105, int> <>9__72_10;
//        public static Func<DataSetGES.Class105, bool> <>9__72_11;
//        public static Func<DataSetGES.Class105, int> <>9__72_12;
//        public static Func<Class13<int, int, string, int, string>, bool> <>9__72_13;
//        public static Func<Class13<int, int, string, int, string>, string> <>9__72_14;
//        public static Func<DataSetGES.Class105, int> <>9__72_16;
//        public static Func<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>, Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>> <>9__72_2;
//        public static Func<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, IEnumerable<DataSetGES.Class108>> <>9__72_3;
//        public static Func<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108, Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108>> <>9__72_4;
//        public static Func<Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108>, Class13<int, int, string, int, string>> <>9__72_7;
//        public static Func<DataSetGES.Class105, bool> <>9__72_9;
//        public static Func<DataSetGES.Class105, bool> <>9__89_0;
//        public static Func<DataSetGES.Class105, int> <>9__89_1;

//        internal Class6<int, string, int, string, string> method_0(DataSetGES.Class121 class121_0)
//        {
//            return new Class6<int, string, int, string, string>(class121_0.idBus, class121_0.nameBus, (class121_0["idTransf"] == DBNull.Value) ? -1 : class121_0.idTransf, (class121_0["NameTransf"] == DBNull.Value) ? "" : class121_0.NameTransf, (class121_0["nameBusTransf"] == DBNull.Value) ? class121_0.nameBus : class121_0.nameBusTransf);
//        }

//        internal Class6<int, string, int, string, string> method_1(DataSetGES.Class122 class122_0)
//        {
//            return new Class6<int, string, int, string, string>((class122_0["IdBus"] == DBNull.Value) ? -1 : class122_0.idBus, (class122_0["nameBus"] == DBNull.Value) ? "" : class122_0.IdTransformer, (class122_0["idTransf"] == DBNull.Value) ? -1 : class122_0.idTransf, (class122_0["nameTransf"] == DBNull.Value) ? "" : class122_0.method_8(), class122_0.Name);
//        }

//        internal string method_10(DataSetGES.Class78 class78_0)
//        {
//            return class78_0.CableMakeup;
//        }

//        internal int method_11(DataSetGES.Class78 class78_0)
//        {
//            return class78_0.Wires;
//        }

//        internal int method_12(DataSetGES.Class78 class78_0)
//        {
//            return class78_0.Wires;
//        }

//        internal bool method_13(DataSetGES.Class78 class78_0)
//        {
//            return (class78_0.Voltage == 0.4M);
//        }

//        internal double method_14(DataSetGES.Class78 class78_0)
//        {
//            return class78_0.CrossSection;
//        }

//        internal double method_15(DataSetGES.Class78 class78_0)
//        {
//            return class78_0.CrossSection;
//        }

//        internal double method_16(DataSetGES.Class78 class78_0)
//        {
//            return class78_0.CrossSection;
//        }

//        internal double method_17(DataSetGES.Class78 class78_0)
//        {
//            return class78_0.CrossSection;
//        }

//        internal bool method_18(DataSetGES.Class78 class78_0)
//        {
//            return (class78_0.Voltage == 0.4M);
//        }

//        internal double method_19(DataSetGES.Class78 class78_0)
//        {
//            return class78_0.AmperageValue;
//        }

//        internal Class6<int, string, int, string, string> method_2(DataSetGES.Class122 class122_0)
//        {
//            return new Class6<int, string, int, string, string>(
//                (class122_0["IdBus"] == DBNull.Value) ? -1 : class122_0.idBus,
//                (class122_0["nameBus"] == DBNull.Value) ? "" : class122_0.Name, 
//                (class122_0["idTransf"] == DBNull.Value) ? -1 : class122_0.idTransf, 
//                (class122_0["nameTransf"] == DBNull.Value) ? "" : class122_0.method_8(), class122_0.Name);
//        }

//        internal Class10<double, string> method_20(DataSetGES.Class78 class78_0)
//        {
//            return new Class10<double, string>(class78_0.AmperageValue, class78_0.AmperageType);
//        }

//        internal double method_21(DataSetGES.Class78 class78_0)
//        {
//            return class78_0.AmperageValue;
//        }

//        internal Class10<double, string> method_22(DataSetGES.Class78 class78_0)
//        {
//            return new Class10<double, string>(class78_0.AmperageValue, class78_0.AmperageType);
//        }

//        internal Class8<int, string> method_23(DataSetGES.Class108 class108_0)
//        {
//            return new Class8<int, string>(class108_0.Int32_0, class108_0.Name);
//        }

//        internal Class9<int, string> method_24(IGrouping<Class8<int, string>, DataSetGES.Class108> igrouping_0)
//        {
//            return new Class9<int, string>(igrouping_0.Key.Prop_0, igrouping_0.Key.Name);
//        }

//        internal string method_25(DataRow dataRow_0)
//        {
//            return dataRow_0.Field<int>("Id").ToString();
//        }

//        internal string method_26(DataSetGES.Class118 class118_0)
//        {
//            return class118_0.Int32_0.ToString();
//        }

//        internal int method_27(DataSetGES.Class107 class107_0)
//        {
//            return class107_0.idCell;
//        }

//        internal string method_28(DataSetGES.Class118 class118_0)
//        {
//            return class118_0.Name;
//        }

//        internal string method_29(DataSetGES.Class108 class108_0)
//        {
//            return class108_0.Name;
//        }

//        internal string method_3(DataSetGES.Class120 class120_0)
//        {
//            return class120_0.NameBusTransf;
//        }

//        internal int method_30(DataSetGES.Class118 class118_0)
//        {
//            return class118_0.Int32_0;
//        }

//        internal int method_31(DataSetGES.Class108 class108_0)
//        {
//            return class108_0.idCell;
//        }

//        internal Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>> method_32(DataSetGES.Class118 class118_0, IEnumerable<DataSetGES.Class108> ienumerable_0)
//        {
//            return new Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>(class118_0, ienumerable_0);
//        }

//        internal IEnumerable<DataSetGES.Class108> method_33(Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>> class11_0)
//        {
//            return class11_0.leftCab.DefaultIfEmpty<DataSetGES.Class108>();
//        }

//        internal Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108> method_34(Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>> class11_0, DataSetGES.Class108 class108_0)
//        {
//            return new Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108>(class11_0, class108_0);
//        }

//        internal Class13<int, int, string, int, string> method_35(Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108> class12_0)
//        {
//            return new Class13<int, int, string, int, string>((class12_0.<> h__TransparentIdentifier0.Prop_0["idBus"] != null) ? ((int)class12_0.<> h__TransparentIdentifier0.Prop_0["idBus"]) : -1, (class12_0.<> h__TransparentIdentifier0.Prop_0["id"] != null) ? ((int)class12_0.<> h__TransparentIdentifier0.Prop_0["id"]) : -1, (class12_0.<> h__TransparentIdentifier0.Prop_0["Name"] != null) ? class12_0.<> h__TransparentIdentifier0.Prop_0["Name"].ToString() : "", (class12_0.Prop_0 != null) ? ((int)class12_0.Prop_0["id"]) : -1, (class12_0.Prop_0 != null) ? class12_0.Prop_0["Name"].ToString() : "");
//        }

//        internal bool method_36(DataSetGES.Class105 class105_0)
//        {
//            return (class105_0["idCell"] != DBNull.Value);
//        }

//        internal int method_37(DataSetGES.Class105 class105_0)
//        {
//            return class105_0.idCell;
//        }

//        internal bool method_38(DataSetGES.Class105 class105_0)
//        {
//            return (class105_0["idCable"] != DBNull.Value);
//        }

//        internal int method_39(DataSetGES.Class105 class105_0)
//        {
//            return class105_0.idCable;
//        }

//        internal bool method_4(DataSetGES.Class50 class50_0)
//        {
//            return ((class50_0.ParentKey == ";Measurement;Type;") && (class50_0.Value == decimal.One));
//        }

//        internal bool method_40(Class13<int, int, string, int, string> class13_0)
//        {
//            return (Regex.Match(class13_0.NameCell, @"^\D").Length == 0);
//        }

//        internal string method_41(Class13<int, int, string, int, string> class13_0)
//        {
//            return Regex.Match(class13_0.NameCell, @"\D*").Value;
//        }

//        internal int method_42(DataSetGES.Class105 class105_0)
//        {
//            return class105_0.Int32_0;
//        }

//        internal bool method_43(DataSetGES.Class105 class105_0)
//        {
//            return ((class105_0.RowState != DataRowState.Deleted) && (class105_0.Int32_0 < 0));
//        }

//        internal int method_44(DataSetGES.Class105 class105_0)
//        {
//            return class105_0.Int32_0;
//        }

//        internal int method_5(DataSetGES.Class50 class50_0)
//        {
//            return class50_0.Id;
//        }

//        internal bool method_6(DataSetGES.Class108 class108_0)
//        {
//            return (class108_0["id"] != DBNull.Value);
//        }

//        internal Class8<int, string> method_7(DataSetGES.Class108 class108_0)
//        {
//            return new Class8<int, string>(class108_0.Int32_0, class108_0.Name);
//        }

//        internal Class9<int, string> method_8(IGrouping<Class8<int, string>, DataSetGES.Class108> igrouping_0)
//        {
//            return new Class9<int, string>(igrouping_0.Key.Prop_0, igrouping_0.Key.Name);
//        }

//        internal string method_9(DataSetGES.Class78 class78_0)
//        {
//            return class78_0.CableMakeup;
//        }
//    }


//    //[CompilerGenerated]
//    //private sealed class Class160
//    //{
//    //    public string string_0;

//    //    internal bool method_0(DataRow dataRow_0)
//    //    {
//    //        return ((dataRow_0["CableMakeup"] != DBNull.Value) && (dataRow_0.Field<string>("CableMakeup").ToUpper().Trim() == this.string_0.ToUpper().Trim()));
//    //    }
//    //}

//    [CompilerGenerated]
//    private sealed class Class161
//    {
//        public string string_0;

//        internal bool method_0(DataSetGES.Class78 class78_0)
//        {
//            return (class78_0.CableMakeup.StartsWith(this.string_0) && class78_0.CableMakeup.EndsWith(this.string_0));
//        }
//    }

//    //[CompilerGenerated]
//    //private sealed class Class162
//    //{
//    //    public int? nullable_0;

//    //    internal bool method_0(DataRow dataRow_0)
//    //    {
//    //        if (dataRow_0["Wires"] == DBNull.Value)
//    //        {
//    //            return false;
//    //        }
//    //        int? nullable = this.nullable_0;
//    //        if (dataRow_0.Field<int>("Wires") != nullable.GetValueOrDefault())
//    //        {
//    //            return false;
//    //        }
//    //        return nullable.HasValue;
//    //    }
//    //}

//    //[CompilerGenerated]
//    //private sealed class Class163
//    //{
//    //    public int int_0;
//    //    public string string_0;

//    //    internal bool method_0(DataSetGES.Class78 class78_0)
//    //    {
//    //        return (((class78_0.CableMakeup == this.string_0) && (class78_0.Wires == this.int_0)) && (class78_0.Voltage == 0.4M));
//    //    }
//    //}

//    [CompilerGenerated]
//    private sealed class Class164
//    {
//        public double cross;

//        internal bool method_0(DataRow dataRow_0)
//        {
//            return ((dataRow_0["CrossSection"] != DBNull.Value) && (dataRow_0.Field<double>("CrossSection") == this.cross));
//        }
//    }

//    [CompilerGenerated]
//    private sealed class Class165
//    {
//        public double double_0;
//        public int int_0;
//        public string string_0;

//        internal bool method_0(DataSetGES.Class78 class78_0)
//        {
//            return ((((class78_0.CableMakeup == this.string_0) && (class78_0.Wires == this.int_0)) && (class78_0.CrossSection == this.double_0)) && (class78_0.Voltage == 0.4M));
//        }
//    }
//}
//    [CompilerGenerated]
//    private sealed class Class166
//    {
//        public int int_0;

//        internal bool method_0(DataSetGES.Class108 class108_0)
//        {
//            return ((class108_0.idCell == this.int_0) && (class108_0["id"] != DBNull.Value));
//        }
//    }



//    [CompilerGenerated]
//    private sealed class Class168
//    {
//        public DataRow dataRow_0;

//        internal bool method_0(DataSetGES.Class118 class118_0)
//        {
//            return (class118_0.Int32_0 == ((int)this.dataRow_0["idCell"]));
//        }

//        internal bool method_1(DataSetGES.Class108 class108_0)
//        {
//            return (class108_0.Int32_0 == ((int)this.dataRow_0["idCable"]));
//        }
//    }

//    [CompilerGenerated]
//    private sealed class Class169
//    {
//        public Class12<Class11<DataSetGES.Class118, IEnumerable<DataSetGES.Class108>>, DataSetGES.Class108> class12_0;

//        internal bool method_0(DataSetGES.Class107 class107_0)
//        {
//            return (class107_0.idCell == this.class12_0.<> h__TransparentIdentifier0.Prop_0.Int32_0);
//        }
//    }

//    [CompilerGenerated]
//    private sealed class Class170
//    {
//        public int int_0;

//        internal int method_0(Class13<int, int, string, int, string> class13_0)
//        {
//            if (!int.TryParse(Regex.Match(class13_0.NameCell, @"\d+").Value, out this.int_0))
//            {
//                return 0;
//            }
//            return int.Parse(Regex.Match(class13_0.NameCell, @"\d+").Value);
//        }
    }
}