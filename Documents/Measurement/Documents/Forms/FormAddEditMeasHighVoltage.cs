using Constants;
using ControlsLbr;
using DataSql;
using Measurement.DataSets;
//using Measurement.Properties;
using FormLbr;
using Passport.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Documents.Measurement
{
    public partial class FormAddEditMeasHighVoltage : FormBase
    {
 
        private MeasCellData dictMeasCellData;
        private MeasAmperageTransfData dictMeasAmperageTransfData;
        private CellData dictCellData;

        private DataSetMeasurementN.tJ_MeasurementRow rowMeas;


        private int int_0;
        
 
        private List<string> dictionaryKeys;
      
        public StateFormCreate StateCreate
        {
            get;
            set;
        }
               
        private string dictionaryKey;

        internal FormAddEditMeasHighVoltage()
        {
            this.InitializeComponent();

        }

        internal FormAddEditMeasHighVoltage(SQLSettings sqlsettings, int idSub, string substationName, int idBus, int idTransf)
        {
            this.InitializeComponent();
            this.SqlSettings = sqlsettings;
            this.StateCreate = (StateFormCreate.Add);//0
            this.IdSubstation = (idSub);
            this.SubstationName = (substationName);
            this.IdBus = (idBus);
            this.IdTransf = (idTransf);
        }

        internal FormAddEditMeasHighVoltage(SQLSettings sqlsettings, int idSub, string substationName, int idBus, int idTransf, string nameTransf, int idMeasurement, int idMeasAmperageTransf)
        {
            this.InitializeComponent();
            this.SqlSettings = (sqlsettings);
            this.StateCreate = (StateFormCreate.Edit);//1
            this.IdSubstation = (idSub);
            this.SubstationName = (substationName);
            this.IdBus = (idBus);
            this.IdTransf = (idTransf);
            this.NameTransf=(nameTransf);
            this.IdMeasurement = (idMeasurement);
            this.IdMeasAmperageTransf=(idMeasAmperageTransf);
        }

        private void bsBusesTransfSchema_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bsBusesTransfSchema.Current != null)
            {
                this.IdTransf=(((this.bsBusesTransfSchema.Current == null) || !(((DataRowView)this.bsBusesTransfSchema.Current)["IdTransf"] is int)) ? -1 : ((int)((DataRowView)this.bsBusesTransfSchema.Current)["IdTransf"]));
                this.IdBus=(((this.bsBusesTransfSchema.Current == null) || !(((DataRowView)this.bsBusesTransfSchema.Current)["IdBus"] is int)) ? -1 : ((int)((DataRowView)this.bsBusesTransfSchema.Current)["IdBus"]));
                this.dictionaryKey = string.Format("{0}+{1}", this.IdBus, this.IdTransf);
                if (this.dictionaryKeys == null)
                {
                    this.dictionaryKeys = new List<string>();
                }
                if (!this.dictionaryKeys.Contains(this.dictionaryKey))
                {
                    this.dictionaryKeys.Add(this.dictionaryKey);
                }
                if (this.dictCellData == null)
                {
                    this.dictCellData = new CellData();
                }
                if (this.dictMeasCellData == null)
                {
                    this.dictMeasCellData = new MeasCellData();
                }
                if (this.dictMeasAmperageTransfData == null)
                {
                    this.dictMeasAmperageTransfData = new MeasAmperageTransfData();
                }
                if (!this.dictMeasAmperageTransfData.ContainsKey(this.dictionaryKey))
                {
                    this.dictMeasAmperageTransfData.Add(this.dictionaryKey, this.GetMeasAmperageTransfDataTable());
                }
                if (!this.dictCellData.ContainsKey(this.dictionaryKey))
                {
                    DataSetMeasurementN.dtCellsDataTable table = new DataSetMeasurementN.dtCellsDataTable();
                    base.SelectSqlData(this.dsMeasHighVoltage, this.dsMeasHighVoltage.vJ_CellByBus, true, string.Format("WHERE idBus = {0} AND idParent = {1}", this.IdBus, this.IdSubstation));
                    //string str = string.Join(",", this.dsMeasHighVoltage.vJ_CellByBus.Select<DataSetGES.Class118, string>((C__1.<> 9__63_0 ?? (C__1.<> 9__63_0 = new Func<DataSetGES.Class118, string>(C__1.<> 9.method_5)))).ToArray<string>());
                    string str = string.Join(",", (from i in this.dsMeasHighVoltage.vJ_CellByBus
                                                    select i.id.ToString()).ToArray<string>());
                    if (!string.IsNullOrEmpty(str))
                    {
                        base.SelectSqlData(this.dsMeasHighVoltage, this.dsMeasHighVoltage.vJ_TransfByCell, true, string.Format("WHERE idCell IN ({0})", str));
                        //foreach (Class7<int, string, int, string> class2 in this.dsMeasHighVoltage.vJ_CellByBus.Where<DataSetGES.Class118>(new Func<DataSetGES.Class118, bool>(this.method_33)).Select<DataSetGES.Class118, Class7<int, string, int, string>>(C__1.<> 9__63_3 ?? (C__1.<> 9__63_3 = new Func<DataSetGES.Class118, Class7<int, string, int, string>>(C__1.<> 9.method_6))))
                        //{
                        //    table.method_1(class2.method_1(), class2.method_2());
                        //}

                        var enumerableRowCollection = from c in this.dsMeasHighVoltage.vJ_CellByBus
                                                      where (from t in this.dsMeasHighVoltage.vJ_TransfByCell
                                                             where t.idCell == c.id
                                                             select t).Count() == 0
                                                      select new
                                                      {
                                                          idBus = ((c["idBus"] != null) ? ((int)c["idBus"]) : -1),
                                                          NameBus = ((c["NameBus"] != null) ? c["NameBus"].ToString() : ""),
                                                          idCell = ((c["id"] != null) ? ((int)c["id"]) : -1),
                                                          NameCell = ((c["Name"] != null) ? c["Name"].ToString() : "")
                                                      };
                        foreach (var current in enumerableRowCollection)
                        {
                            table.AdddtCellsRow(current.idCell, current.NameCell);
                        }
                        this.dictCellData.Add(this.dictionaryKey, table);
                    }
                }
                if (!this.dictMeasCellData.ContainsKey(this.dictionaryKey))
                {
                    DataSetMeasurementN.tJ_MeasCellDataTable table2 = new DataSetMeasurementN.tJ_MeasCellDataTable
                    {
                        TableName = "tJ_MeasCell"
                    };
                    if (this.StateCreate == StateFormCreate.Edit)
                    {
                        base.SelectSqlData(table2, true, string.Format("WHERE idMeasurement = {0} AND idBus = {1} AND idTransf = {2} AND Deleted = ((0))", IdMeasurement, this.IdBus, this.IdTransf), null, false, 0);
                        if (table2.Rows.Count == 0)
                        {
                            table2 = this.CreateMeasCellsRows();
                        }
                    }
                    else
                    {
                        table2 = this.CreateMeasCellsRows();
                    }
                    this.dictMeasCellData.Add(this.dictionaryKey, table2);
                }
                if ((from item in this.dictMeasAmperageTransfData
                    where item.Key == this.dictionaryKey
                    select item.Value).First().First().idObjList != -1)
                //if (this.dictMeasAmperageTransfData
                //    .Where<KeyValuePair<string, DataSetGES.tJ_MeasAmperageTransfDataTable>>(new Func<KeyValuePair<string, DataSetGES.tJ_MeasAmperageTransfDataTable>, bool>(this.method_34)) //(keyValuePair_0.Key == this.dictionaryKey)

                //    .Select<KeyValuePair<string, DataSetGES.tJ_MeasAmperageTransfDataTable>, DataSetGES.tJ_MeasAmperageTransfDataTable>((C__1.C_9__63_5 ?? (C__1.C_9__63_5 = new Func<KeyValuePair<string, DataSetGES.tJ_MeasAmperageTransfDataTable>, DataSetGES.tJ_MeasAmperageTransfDataTable>(C__1.method_7)))) // return keyValuePair_0.Value;

                //    .First<DataSetGES.tJ_MeasAmperageTransfDataTable>().First<DataSetGES.Class110>().idObjList != -1)
                {
                    string[] textArray = new string[] { this.IdTransf.ToString() };
                    base.CallSQLTableValuedFunction(this.dsMeasHighVoltage, this.dsMeasHighVoltage.fn_J_MeasTransfPassport, "", textArray);

                    this.EnableTransf(this.IdTransf, (this.dsMeasHighVoltage.fn_J_MeasTransfPassport.Rows.Count > 0) ? this.dsMeasHighVoltage.fn_J_MeasTransfPassport.Rows[0]["InvNumber"].ToString() : "");
                }
                else
                {
                    this.EnableTransf(-1, "");
                }
                if (this.dictMeasAmperageTransfData.ContainsKey(this.dictionaryKey))
                {
                    // using (IEnumerator<DataSetGES.Class110> enumerator2 = this.dictMeasAmperageTransfData[this.dictionaryKey].GetEnumerator())
                    //using (IEnumerator<DataSetMeasurementN.tJ_MeasAmperageTransfRow> enumerator2 = this.dictMeasAmperageTransfData[this.dictionaryKey].GetEnumerator())
                    using (var enumerator2 = this.dictMeasAmperageTransfData[this.dictionaryKey].GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        //foreach (DataSetMeasurementN.tJ_MeasAmperageTransfRow enumerator2 in this.dictMeasAmperageTransfData[this.dictionaryKey])
                        {
                            enumerator2.Current.EndEdit();
                        }
                    }
                    this.bsMeasAmperageTransf.DataSource = this.dictMeasAmperageTransfData[this.dictionaryKey];
                    this.bsMeasAmperageTransf.ResetBindings(false);
                }
                if (this.dictCellData.ContainsKey(this.dictionaryKey))
                {
                    this.bsCells.DataSource = this.dictCellData[this.dictionaryKey];
                    this.bsCells.ResetBindings(false);
                }

                if (this.dictMeasCellData.ContainsKey(this.dictionaryKey))
                {
                    // using (IEnumerator<DataSetMeasurementN.tJ_MeasCellRow> enumerator3 = this.dictMeasCellData[this.dictionaryKey].GetEnumerator())
                    using (var enumerator3 = this.dictMeasCellData[this.dictionaryKey].GetEnumerator())
                    {
                        while (enumerator3.MoveNext())
                        //foreach (DataSetMeasurementN.tJ_MeasCellRow enumerator3 in this.dictMeasCellData[this.dictionaryKey])
                        {
                            enumerator3.Current.EndEdit();
                        }
                    }
                    this.bsMeasCell.DataSource = this.dictMeasCellData[this.dictionaryKey];
                    this.bsMeasCell.ResetBindings(false);
                }
            }
            else
            {
                this.dsMeasHighVoltage.fn_J_MeasTransfPassport.Clear();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить замеры на выбранную шину?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (this.StateCreate == StateFormCreate.Add)
                {
                    this.dictMeasAmperageTransfData.Remove(this.dictionaryKey);
                    this.dictMeasCellData.Remove(this.dictionaryKey);
                }
                else
                {
                    for (int i = this.dictMeasAmperageTransfData[this.dictionaryKey].Rows.Count - 1; i >= 0; i--)
                    {
                        this.dictMeasAmperageTransfData[this.dictionaryKey].Rows[i]["Deleted"] = true;
                    }
                    for (int j = this.dictMeasCellData[this.dictionaryKey].Rows.Count - 1; j >= 0; j--)
                    {
                        this.dictMeasCellData[this.dictionaryKey].Rows[j]["Deleted"] = true;
                    }
                }
                //1
                //this.dsMeasHighVoltage.vJ_BusesTransfSchema.Where<DataSetGES.Class121>(new Func<DataSetGES.Class121, bool>(this.method_36)).First<DataSetGES.Class121>().Delete();
                //2 - 1 вариант
                //dsMeasHighVoltage.vJ_BusesTransfSchema.Where(new Func<DataSetMeasurementN.vJ_BusesTransfSchemaRow, bool>(
                //    r =>((r.idBus == IdBus) && (r.idTransf == IdTransf))
                //    )).First().Delete();
                //3 - 2 вариант
                //(from r in this.dsMeasHighVoltage.vJ_BusesTransfSchema
                // where r.idBus == this.IdBus && r.idTransf == this.IdTransf
                // select r).First().Delete();
                //4 - 3  вариант
                dsMeasHighVoltage.vJ_BusesTransfSchema
                    .Where(r => ((r.idBus == IdBus) && (r.idTransf == IdTransf)))
                    .First().Delete();


            }
        }

        private void cbYear_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((this.cbYear.SelectedValue != null) && (this.cbYear.SelectedValue is int))
            {
                this.Year = (int)this.cbYear.SelectedValue;
            }
        }

        private void dgvMeasCable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvMeasCable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Length == 0)
            {
                this.dgvMeasCable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
            }
        }

        private void dgvMeasCable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }



        private void FormAddEditMeasHighVoltage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                if ((this.cbYear.SelectedValue == null) || (!(this.cbYear.SelectedValue is int) && (int.Parse(this.cbYear.SelectedValue.ToString()) < 1900)))
                {
                    MessageBox.Show("Поле \"Период\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    e.Cancel = true;
                }
                else
                {
                    if (this.nudTemperatureD.Value == 0)
                    {
                        //this.dsMeasHighVoltage.tJ_Measurement.First<DataSetGES.Class94>().TemperatureD = 0;
                        //this.dsMeasHighVoltage.tJ_Measurement.First<DataSetGES.Class94>().EndEdit();
                        this.dsMeasHighVoltage.tJ_Measurement.First().TemperatureD = 0;
                        this.dsMeasHighVoltage.tJ_Measurement.First().EndEdit();
                    }
                    if (this.dtpDateD.Value == null)
                    {
                        MessageBox.Show("Поле \"Дата/Время\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        e.Cancel = true;
                    }
                    else if ((this.cbWorker.SelectedValue == null) || (!(this.cbWorker.SelectedValue is int) && (int.Parse(this.cbWorker.SelectedValue.ToString()) < 1)))
                    {
                        MessageBox.Show("Поле \"Замеры проводил\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        e.Cancel = true;
                    }
                    else if (this.bsBusesTransfSchema.Current == null)
                    {
                        MessageBox.Show("Поле \"Секция шин\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        e.Cancel = true;
                    }
                    else if (string.IsNullOrEmpty(this.tbUaod.Text))
                    {
                        MessageBox.Show("Поле \"Ток нагрузки А\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        e.Cancel = true;
                    }
                    else if (string.IsNullOrEmpty(this.tbUbcd.Text))
                    {
                        MessageBox.Show("Поле \"Ток нагрузки В\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        e.Cancel = true;
                    }
                    else if (string.IsNullOrEmpty(this.tbUcad.Text))
                    {
                        MessageBox.Show("Поле \"Ток нагрузки С\" не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        e.Cancel = true;
                    }
                    else if (!this.InsertOrUpdateData())
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void FormAddEditMeasHighVoltage_Load(object sender, EventArgs e)
        {
            //
            this.FillPeriod();
            this.FilltRClassifier();
            this.TypeDocId=(this.GetTypeDoc());
            this.FillWorkerComboBox();
            this.FillBuses();
            this.rowMeas = this.GetMeasurementRow();
            if (this.StateCreate == StateFormCreate.Add)
            {
                this.dtpDateD.Value = (null);
            }
            this.Text = (this.StateCreate == StateFormCreate.Add) ? "Добавление замера" : "Редактирование замера";
            this.Text = this.Text + ((this.SubstationName.Length > 0) ? (": " + this.SubstationName) : "");
            InputCheck.AddBindingNull(this.tbUaod);
            InputCheck.AddBindingNull(this.tbUbcd);
            InputCheck.AddBindingNull(this.tbUcad);
        }


  

        public int IdTransf
        {
            get;
            set;
        }
 

        public string NameTransf
        {
            get;
            set;
        }


        [DefaultValue(-1)]
        public int IdMeasurement
        {
            get;
            set;
        }
  
        public int IdMeasAmperageTransf
        {
            get;
            set;
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
        }

        private void FilltRClassifier()
        {
            base.SelectSqlData(this.dsMeasHighVoltage, this.dsMeasHighVoltage.tR_Classifier, true, string.Format("WHERE ParentKey = ';Measurement;Type;' AND Deleted = ((0)) AND isGroup = ((0))", new object[0]));
        }

        public int TypeDocId
        {
            get;
            set;
        }
        //internal int method_2()
        //{
        //    return this.TypeDocId;
        //}

        private int GetTypeDoc()
        {
            //return this.dsMeasHighVoltage.tR_Classifier.Where<DataSetGES.Class50>((C__1.<> 9__51_0 ?? (C__1.<> 9__51_0 = new Func<DataSetGES.Class50, bool>(C__1.<> 9.method_0)))).Select<DataSetGES.Class50, int>((C__1.<> 9__51_1 ?? (C__1.<> 9__51_1 = new Func<DataSetGES.Class50, int>(C__1.<> 9.method_1)))).First<int>();
            return (from row in this.dsMeasHighVoltage.tR_Classifier
                    where row.ParentKey == ";Measurement;Type;" && row.Value == 2m
                    select row.Id).First<int>();
        }

        private int GetWorkerCheck()
        {
            DataTable table = new DataTable("tUser");
            base.SelectSqlData(table, true, string.Format("where [login] = '{0}'", this.SqlSettings.SqlUserConnect), null, false, 0);
            if ((table.Rows.Count != 0) && (table.Rows[0]["idWorker"] is int))
            {
                return Convert.ToInt32(table.Rows[0]["idWorker"]);
            }
            return -1;
        }

        //private DataSetGES.Class94 method_22()
        private DataSetMeasurementN.tJ_MeasurementRow GetMeasurementRow()
        {
            if (this.StateCreate == StateFormCreate.Add)
            {
                // DataSetGES.Class94 class2 = this.dataSetGES_0.tJ_Measurement.method_5();
                DataSetMeasurementN.tJ_MeasurementRow row = dsMeasHighVoltage.tJ_Measurement.NewtJ_MeasurementRow();
                row.idObjList = this.IdSubstation;
                row.TypeDoc = this.TypeDocId;
                row["DateN"] = DBNull.Value;
                row["TemperatureN"] = DBNull.Value;
                row.Year = DateTime.Now.Year;
                row.idWorkerCheck = this.GetWorkerCheck();
                row.Deleted = false;
                this.dsMeasHighVoltage.tJ_Measurement.AddtJ_MeasurementRow(row);
                this.IdMeasurement=(-1);
                this.bsMeasurement.ResetBindings(false);
                return row;
            }
            base.SelectSqlData(this.dsMeasHighVoltage.tJ_Measurement, true, string.Format("WHERE id = {0} AND Deleted = ((0))", IdMeasurement), null, true,0);
            this.bsMeasurement.ResetBindings(false);
            if (this.dsMeasHighVoltage.tJ_Measurement.Rows.Count <= 0)
            {
                return null;
            }
            return (DataSetMeasurementN.tJ_MeasurementRow)this.dsMeasHighVoltage.tJ_Measurement.Rows[0];
        }

        private DataSetMeasurementN.tJ_MeasAmperageTransfDataTable GetMeasAmperageTransfDataTable()
        {
            DataSetMeasurementN.tJ_MeasAmperageTransfDataTable table = new DataSetMeasurementN.tJ_MeasAmperageTransfDataTable
            {
                TableName = "tJ_MeasAmperageTransf"
            };
            if (this.StateCreate == StateFormCreate.Add)
            {
                table = this.CreateMeasAmperageTransfRow(-1);
            }
            else { 
            base.SelectSqlData(table, true, string.Format("WHERE idMeasurement = {0} AND idBus = {1} AND idObjList = {2} AND Deleted = ((0))", IdMeasurement, this.IdBus, this.IdTransf), null, false, 0);
                table = ((table.Rows.Count > 0) ? table : this.CreateMeasAmperageTransfRow(IdMeasurement));
            }
            return table;
        }

        private DataSetMeasurementN.tJ_MeasAmperageTransfDataTable CreateMeasAmperageTransfRow(int id)
        {
            DataSetMeasurementN.tJ_MeasAmperageTransfDataTable tbl = new DataSetMeasurementN.tJ_MeasAmperageTransfDataTable
            {
                TableName = "tJ_MeasAmperageTransf"
            };
            DataSetMeasurementN.tJ_MeasAmperageTransfRow row = tbl.NewtJ_MeasAmperageTransfRow();
            row.IdBus = this.IdBus;
            row.idObjList = this.IdTransf;
            row.idMeasurement = id;
            row.Deleted = false;
            tbl.AddtJ_MeasAmperageTransfRow(row);
            return tbl;
        }

        private void FillBuses()
        {
            this.bsBusesTransfSchema.RaiseListChangedEvents = true;
            this.bsBusesTransfSchema.CurrentChanged -= new EventHandler(this.bsBusesTransfSchema_CurrentChanged);
            if (this.StateCreate == StateFormCreate.Add)
            {
                base.SelectSqlData(this.dsMeasHighVoltage, this.dsMeasHighVoltage.vJ_BusesTransfSchema, true, string.Format("WHERE idSub = {0}  AND parentKeyBus = ';SCM;BUS;BUSMV;' ORDER By NameTransf", this.IdSubstation));
            }
            else
            {
                base.SelectSqlData(this.dsMeasHighVoltage, this.dsMeasHighVoltage.vJ_BusesTransfs, true, string.Format("WHERE idMeasurement = {0} ORDER By Name", IdMeasurement));
                base.SelectSqlData(this.dsMeasHighVoltage, this.dsMeasHighVoltage.vJ_BusesTransfSchema, true, string.Format("WHERE idSub = {0} AND parentKeyBus = ';SCM;BUS;BUSMV; AND tagBus IS NULL' ORDER By NameTransf", this.IdSubstation));
                this.dsMeasHighVoltage.vJ_BusesTransfSchema.Rows.Clear();
                var enumerable = (from row in this.dsMeasHighVoltage.vJ_BusesTransfSchema
                                  select new
                                  {
                                      idBus = row.idBus,
                                      NameBus = row.nameBus,
                                      idTransf = ((row["idTransf"] == DBNull.Value) ? -1 : row.idTransf),
                                      NameTransf = ((row["NameTransf"] == DBNull.Value) ? "" : row.NameTransf),
                                      NameBusTransf = ((row["nameBusTransf"] == DBNull.Value) ? row.nameBus : row.nameBusTransf)
                                  }).Except(from row in this.dsMeasHighVoltage.vJ_BusesTransfs
                                            select new
                                            {
                                                idBus = row.idBus,
                                                NameBus = row.nameBus,
                                                idTransf = ((row["idTransf"] == DBNull.Value) ? -1 : row.idTransf),
                                                NameTransf = ((row["nameTransf"] == DBNull.Value) ? "" : row.nameTransf),
                                                NameBusTransf = row.Name
                                            }).Union(from row in this.dsMeasHighVoltage.vJ_BusesTransfs
                                                     select new
                                                     {
                                                         idBus = row.idBus,
                                                         NameBus = row.nameBus,
                                                         idTransf = ((row["idTransf"] == DBNull.Value) ? -1 : row.idTransf),
                                                         NameTransf = ((row["nameTransf"] == DBNull.Value) ? "" : row.nameTransf),
                                                         NameBusTransf = row.Name
                                                     });
                //foreach (Class6<int, string, int, string, string> class2 in this.dsMeasHighVoltage.vJ_BusesTransfSchema.Select<DataSetGES.Class121, Class6<int, string, int, string, string>>((C__1.<> 9__56_0 ?? (C__1.<> 9__56_0 = new Func<DataSetGES.Class121, Class6<int, string, int, string, string>>(C__1.<> 9.method_2)))).Except<Class6<int, string, int, string, string>>(this.dsMeasHighVoltage.vJ_BusesTransfs.Select<DataSetGES.Class122, Class6<int, string, int, string, string>>((C__1.<> 9__56_1 ?? (C__1.<> 9__56_1 = new Func<DataSetGES.Class122, Class6<int, string, int, string, string>>(C__1.<> 9.method_3))))).Union<Class6<int, string, int, string, string>>(this.dsMeasHighVoltage.vJ_BusesTransfs.Select<DataSetGES.Class122, Class6<int, string, int, string, string>>(C__1.<> 9__56_2 ?? (C__1.<> 9__56_2 = new Func<DataSetGES.Class122, Class6<int, string, int, string, string>>(C__1.<> 9.method_4)))))
                foreach (var current in enumerable)
                {
                    //DataSetGES.Class121 row = this.dsMeasHighVoltage.vJ_BusesTransfSchema.method_4();
                    DataSetMeasurementN.vJ_BusesTransfSchemaRow row = this.dsMeasHighVoltage.vJ_BusesTransfSchema.NewvJ_BusesTransfSchemaRow();
                    row.idSub = this.IdSubstation;
                    row.idBus = current.idBus;
                    row.nameBus = current.NameBus;
                    row.idTransf = current.idTransf;
                    row.NameTransf = current.NameTransf;
                    row.nameBusTransf = current.NameBusTransf;
                    //this.dsMeasHighVoltage.vJ_BusesTransfSchema.method_0(row);
                    this.dsMeasHighVoltage.vJ_BusesTransfSchema.AddvJ_BusesTransfSchemaRow(row);
                }
            }
            this.bsBusesTransfSchema.ResetBindings(false);
            if (this.bsBusesTransfSchema.Count == 0)
            {
                this.bsBusesTransfSchema_CurrentChanged(this.bsBusesTransfSchema, new EventArgs());
            }
            else
            {
                int num = -1;
                if (string.IsNullOrEmpty(this.NameTransf))
                {
                    num = this.bsBusesTransfSchema.Find("idBus", this.IdBus);
                }
                else
                {
                    num = this.bsBusesTransfSchema.Find("idTransf", this.IdTransf);
                    if (num != -1)
                    {
                        num = this.bsBusesTransfSchema.Find("idBus", this.IdBus);
                    }
                }
                if (num != -1)
                {
                    this.bsBusesTransfSchema.Position = num;
                }
                this.bsBusesTransfSchema.CurrentChanged += new EventHandler(this.bsBusesTransfSchema_CurrentChanged);
                this.bsBusesTransfSchema.RaiseListChangedEvents = false;
                this.bsBusesTransfSchema_CurrentChanged(this.bsBusesTransfSchema, new EventArgs());
            }
        }

        private void FillWorkerComboBox()
        {
            base.SelectSqlData(this.dsMeasHighVoltage, this.dsMeasHighVoltage.vP_Worker, true, string.Format("WHERE ParentKey IN (';GroupWorker;Meas;', ';GroupWorker;MeasDispatchers;')  AND DateEnd IS NULL", new object[0]));
            DataSetMeasurementN.vP_WorkerRow row = this.dsMeasHighVoltage.vP_Worker.NewvP_WorkerRow();
            row.Id = -1;
            row.F = ("");
            row.FIO = "";
            row.ParentKey = "";
            row.idGroup = (1);
            row.isGroup = (false);
            this.dsMeasHighVoltage.vP_Worker.AddvP_WorkerRow(row);
        }

        private bool InsertOrUpdateData()
        {
            if (((this.cbBuses.SelectedValue == null) || !(this.cbBuses.SelectedValue is int)) || (this.dsMeasHighVoltage.tJ_Measurement.Rows.Count <= 0))
            {
                return false;
            }
            //using (IEnumerator<DataSetMeasurementN.tJ_MeasurementRow> enumerator = this.dsMeasHighVoltage.tJ_Measurement.GetEnumerator())
            //{
            //    while (enumerator.MoveNext())
            //    {
            //        enumerator.Current.EndEdit();
            //    }
            //}
            foreach (DataSetMeasurementN.tJ_MeasurementRow current in this.dsMeasHighVoltage.tJ_Measurement)
            {
                current.EndEdit();
            }
            if (this.StateCreate == StateFormCreate.Add)
            {
                this.IdMeasurement=(base.InsertSqlDataOneRow(this.dsMeasHighVoltage, this.dsMeasHighVoltage.tJ_Measurement));
            }
            if (this.StateCreate == StateFormCreate.Edit)
            {
                this.bsMeasurement.EndEdit();
                base.UpdateSqlData(this.dsMeasHighVoltage, this.dsMeasHighVoltage.tJ_Measurement);
            }
            if (IdMeasurement == -1)
            {
                return false;
            }
            // pair --> KeyValuePair<string, DataSetMeasurementN.tJ_MeasAmperageTransfDataTable>
            foreach (var pair in this.dictMeasAmperageTransfData)
            {
                if ((MeasurementCheck.IsSaveTableValues(this.dictMeasAmperageTransfData[pair.Key]) || MeasurementCheck.IsSaveTableValues(this.dictMeasCellData[pair.Key])) || (this.StateCreate == StateFormCreate.Edit))
                {
                    //tJ_MeasAmperageTransfDataTable_0
                    foreach (DataSetMeasurementN.tJ_MeasAmperageTransfRow local1 in this.dictMeasAmperageTransfData[pair.Key])
                    {
                        local1.idMeasurement = IdMeasurement;
                        local1.EndEdit();
                    }
                    base.InsertSqlData(this.dictMeasAmperageTransfData[pair.Key]);
                    base.UpdateSqlData(this.dictMeasAmperageTransfData[pair.Key]);
                    base.DeleteSqlData(this.dictMeasAmperageTransfData[pair.Key]);
                    //foreach (DataSetGES.Class127 local2 in this.dictMeasCellData[pair.Key])
                    foreach (DataSetMeasurementN.tJ_MeasCellRow local2 in this.dictMeasCellData[pair.Key])
                    {
                        local2.idMeasurement = IdMeasurement;
                        local2.EndEdit();
                    }
                    base.InsertSqlData(this.dictMeasCellData[pair.Key]);
                    base.UpdateSqlData(this.dictMeasCellData[pair.Key]);
                    base.DeleteSqlData(this.dictMeasCellData[pair.Key]);
                }
            }
            MessageBox.Show("Данные успешно внесены.");
            return true;
        }

        private DataSetMeasurementN.tJ_MeasCellDataTable CreateMeasCellsRows()
        {
            DataSetMeasurementN.tJ_MeasCellDataTable table = new DataSetMeasurementN.tJ_MeasCellDataTable
            {
                TableName = "tJ_MeasCell"
            };

            var enumerableRowCollection = from c in this.dsMeasHighVoltage.vJ_CellByBus
                                          where (from t in this.dsMeasHighVoltage.vJ_TransfByCell
                                                 where t.idCell == c.id
                                                 select t).Count<DataSetMeasurementN.vJ_TransfByCellRow>() == 0
                                          select new
                                          {
                                              idBus = ((c["idBus"] != null) ? ((int)c["idBus"]) : -1),
                                              NameBus = ((c["NameBus"] != null) ? c["NameBus"].ToString() : ""),
                                              idCell = ((c["id"] != null) ? ((int)c["id"]) : -1),
                                              NameCell = ((c["Name"] != null) ? c["Name"].ToString() : "")
                                          };
            foreach (var current in enumerableRowCollection)

            //foreach (Class7<int, string, int, string> class2 in this.dsMeasHighVoltage.vJ_CellByBus.Where<DataSetGES.Class118>(new Func<DataSetGES.Class118, bool>(this.method_35)).Select<DataSetGES.Class118, Class7<int, string, int, string>>(C__1.<> 9__64_2 ?? (C__1.<> 9__64_2 = new Func<DataSetGES.Class118, Class7<int, string, int, string>>(C__1.<> 9.method_8))))
            {
                DataSetMeasurementN.tJ_MeasCellRow row = table.NewtJ_MeasCellRow();
                row.Deleted=(false);
                row.idBus = this.IdBus;
                row.idTransf = this.IdTransf;
                row.idCell = current.idCell;//(current.method_1());
                row.idMeasurement=(IdMeasurement);
                table.AddtJ_MeasCellRow(row);
            }
            return table;
        }

        private void EnableTransf(int id, string number)
        {
            this.lbSerialNumber.Text = "Заводской № " + number;
            if (id != -1)
            {
                this.RefreshTransfPassport(id);
            }
            else
            {
                this.dsMeasHighVoltage.fn_J_MeasTransfPassport.Clear();
            }
        }

        
        //internal void method_3(int id)
        //{
        //    this.TypeDocId = id;
        //}

        private void RefreshTransfPassport(int id)
        {
            this.dsMeasHighVoltage.fn_J_MeasTransfPassport.Rows.Clear();
            string[] textArray = new string[] { id.ToString() };
            base.CallSQLTableValuedFunction(this.dsMeasHighVoltage, this.dsMeasHighVoltage.fn_J_MeasTransfPassport, "", textArray);
        }

        private void GetTemperatureD()
        {
            if (this.dtpDateD.Value == null)
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
            }
        }

    
        
        //private bool method_33(DataSetGES.Class118 class118_0)
        //{
        //    Class41 class2 = new Class41
        //    {
        //        class118_0 = class118_0
        //    };
        //    return (this.dsMeasHighVoltage.vJ_TransfByCell.Where<DataSetGES.Class107>(new Func<DataSetGES.Class107, bool>(class2.method_0)).Count<DataSetGES.Class107>() == 0);
        //}

        
        //private bool method_34(KeyValuePair<string, DataSetGES.tJ_MeasAmperageTransfDataTable> keyValuePair_0)
        //{
        //    return (keyValuePair_0.Key == this.dictionaryKey);
        //}

        
        //private bool method_35(DataSetGES.Class118 class118_0)
        //{
        //    Class42 class2 = new Class42
        //    {
        //        class118_0 = class118_0
        //    };
        //    return (this.dsMeasHighVoltage.vJ_TransfByCell.Where<DataSetGES.Class107>(new Func<DataSetGES.Class107, bool>(class2.method_0)).Count<DataSetGES.Class107>() == 0);
        //}


        //private bool method_36(DataSetGES.Class121 class121_0)
        //{
        //    return ((class121_0.idBus == this.IdBus) && (class121_0.idTransf == this.IdTransf));
        //}

        public int IdSubstation
        {
            get;
            set;
        }
        //internal int get_IdSubstation()
        //{
        //    return this.IdSubstation;
        //}


        //internal void set_IdSubstation(int id)
        //{
        //    this.IdSubstation = id;
        //}

        public string SubstationName
        {
            get;
            set;
        }
        //internal string method_6()
        //{
        //    return this.SubstationName;
        //}

        
        //internal void method_7(string str)
        //{
        //    this.SubstationName = str;
        //}

        internal int IdBus
        {
            get;
            set;
        }
        //internal int method_8()
        //{
        //    return this.IdBus;
        //}

        
        //internal void method_9(int id)
        //{
        //    this.IdBus = id;
        //}

        private void nullableDateTimePicker_0_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpDateD.Value != null)
            {
                this.GetTemperatureD();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tssbAddMissingCells_Click(object sender, EventArgs e)
        {
        }

        private void tssbCellsDeleted_Click(object sender, EventArgs e)
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

        private void toolBtnImportTemperature_Click(object sender, EventArgs e)
        {
            this.GetTemperatureD();
        }

        internal int Year
        {
            
            get
            {
                return this.int_0;
            }
            
            set
            {
                this.int_0 = value;
            }
        }

     
}
}