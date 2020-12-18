using Measurement.DataSets;
//using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using OfficeLB.Word;
using Passport.Classes;
using Passport.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
//using WeifenLuo.WinFormsUI.Docking;

namespace Documents.Measurement
{

    public partial class FormMeasurement : WinFormsUI.Docking.DockContentBase //WeifenLuo.WinFormsUI.Docking.
    {

        private bool isShown;

        //private DataSetGES dsJournal;
        private SelectedSubstation subSelected;
        private FormDockPassport.FillTree fillTree = FormDockPassport.FillTree.All;

        private int idSubstationTemp = -1;
        private int idObjList;
        public int IdObjList
        {
            get
            {
                if (this.objListPassport == null)
                {
                    return -1;
                }
                return this.objListPassport.Id;
            }
            set
            {
                this.fillTree = FormDockPassport.FillTree.One;
                this.idObjList = value;
            }
        }
        /// <summary>
        /// ??? идентификатор типа замера из классификатор
        /// </summary>
        private int idTypeDoc;
        private int IdBus;
        private int IdTransf;
        private int IdBusSchema;
        private int IdTransfSchema;
  
        private ObjList objListPassport;
        private ObjList objListOne;
        
        private FormDockPassport.Sort sort_0;
        //private const string string_0 = ";SCM;PS;";
        //private const string string_1 = ";SCM;BUS;BUSLV;";
        //private const string string_2 = ";SCM;BUS;BUSMV;";
        //private const string string_3 = "2,3,4";
        //private const string string_4 = "2,4,5";
        private string NameTransf;
        private string nameTransf;

        private FormMeasurement.TypeDoc typeDoc_0 = FormMeasurement.TypeDoc.None;
        /// <summary>
        /// тип документа (высокая (6-10кВ) или низкая (0,4кВ) сторона)
        /// </summary>
        private FormMeasurement.TypeDoc typeDoc_1;
        
        /// <summary>
        /// конструктор
        /// </summary>
        public FormMeasurement()
        {
            //this.fillTree = FormDockPassport.FillTree.All;
            //this.idSubstationTemp = -1;
            //this.typeDoc_0 = TypeDoc.None;

            this.InitializeComponent();
            this.bsBusesTransfs.DataSource = this.dsJournal;


            /* Зачем-то было удалено
             * в проете не используется
             
             ((System.ComponentModel.ISupportInitialize)(this.bsTransf)).BeginInit();
             
            // 
            // bsTransf
            // 
            this.bsTransf.DataMember = "vJ_Transfs";
            this.bsTransf.DataSource = this.dsJournal;
            this.bsTransf.Sort = "Name";
            this.bsTransf.CurrentChanged += new System.EventHandler(this.bsBusesTransfLV_CurrentChanged);

            ((System.ComponentModel.ISupportInitialize)(this.bsTransf)).EndInit();
             */

            // Строка сортировки содержит свойство, которое отсутствует в списке IBindingList.
            /* Ругался на сортировку
             this.bsCellByTransf.Sort = "Name";
             this.bsValueLists.Sort = "Name Desc";*/
             
        }

        /// <summary>
        /// конструктор по объекту
        /// </summary>
        public FormMeasurement(int idObjList)
        {
            //this.fillTree = FormDockPassport.FillTree.All;
            //this.idSubstationTemp = -1;
            //this.typeDoc_0 = TypeDoc.None;

            this.InitializeComponent();
            this.bsBusesTransfs.DataSource = this.dsJournal;
            this.fillTree = FormDockPassport.FillTree.One;
            this.idObjList = idObjList;
        }

        private void bsMeasYear_CurrentChanged(object sender, EventArgs e)
        {
            this.bsMeasurement.RaiseListChangedEvents = true;
            this.bsMeasurement.CurrentChanged -= new EventHandler(this.bsMeasurement_CurrentChanged);
            this.dsJournal.tJ_Measurement.Rows.Clear();
            if (this.bsMeasYear.Current != null)
            {
                string str = (this.bsMeasurement.Sort != null) ? this.bsMeasurement.Sort : "";
                if (((DataRowView)this.bsMeasYear.Current)["Year"] is int)
                {
                    base.SelectSqlData(this.dsJournal, this.dsJournal.tJ_Measurement, true, string.Format("WHERE idObjList = {0} AND TypeDoc = {1} AND Year = {2} AND Deleted = ((0))", this.GetIdSubstation(), this.idTypeDoc, (int)((DataRowView)this.bsMeasYear.Current)["Year"]));
                    this.bsMeasurement.Sort = str;
                }
            }
            this.bsMeasurement.CurrentChanged += new EventHandler(this.bsMeasurement_CurrentChanged);
            this.bsMeasurement.RaiseListChangedEvents = false;
            this.bsMeasurement_CurrentChanged(this.bsMeasurement, new EventArgs());
        }

        private void bsBusesTransfLV_CurrentChanged(object sender, EventArgs e)
        {
            this.IdTransf = ((this.bsBusesTransfs.Current == null) || !(((DataRowView)this.bsBusesTransfs.Current)["IdTransf"] is int)) ? -1 : ((int)((DataRowView)this.bsBusesTransfs.Current)["IdTransf"]);
            this.NameTransf = ((this.bsBusesTransfs.Current == null) || !(((DataRowView)this.bsBusesTransfs.Current)["IdTransf"] is string)) ? "" : ((DataRowView)this.bsBusesTransfs.Current)["IdTransf"].ToString();
            this.IdBus = ((this.bsBusesTransfs.Current == null) || !(((DataRowView)this.bsBusesTransfs.Current)["IdBus"] is int)) ? -1 : ((int)((DataRowView)this.bsBusesTransfs.Current)["IdBus"]);
            if (this.typeDoc_1 == TypeDoc.LowMeasurement)
            {
                this.dsJournal.fn_J_MeasTransfPassport.Rows.Clear();
                if (this.IdTransf != -1)
                {
                    string[] textArray1 = new string[] { this.IdTransf.ToString() };
                    base.CallSQLTableValuedFunction(this.dsJournal, this.dsJournal.fn_J_MeasTransfPassport, "", textArray1);
                }
                this.dsJournal.tJ_MeasVoltageTransf.Rows.Clear();
                if (this.bsMeasurement.Current != null)
                {
                    base.SelectSqlData(this.dsJournal, this.dsJournal.tJ_MeasVoltageTransf, true, string.Format("WHERE idMeasurement = {0} AND IdBus = {1} AND idObjList = {2} AND Deleted = ((0))", (int)((DataRowView)this.bsMeasurement.Current)["id"], this.IdBus, this.IdTransf));
                }
                this.bsMeasCable.RaiseListChangedEvents = true;
                this.bsMeasCable.CurrentChanged -= new EventHandler(this.bsMeasCable_CurrentChanged);
                this.dsJournal.vJ_MeasCable.Rows.Clear();
                this.dgvSumCable.Rows.Clear();
                if ((this.bsBusesTransfs.Current != null) && (this.bsMeasurement.Current != null))
                {
                    string str = (this.bsMeasCable.Sort != null) ? this.bsMeasCable.Sort : "";
                    base.SelectSqlData(this.dsJournal, this.dsJournal.vJ_MeasCable, true, string.Format("WHERE idMeasurement = {0} AND IdBus = {1} AND idTransf = {2} AND Deleted = ((0)) ORDER BY CONVERT(INT, CASE WHEN NameCell like '%[^0-9]%' THEN SUBSTRING(NameCell,1,PATINDEX('%[^0-9]%',NameCell)-1) ELSE NameCell END), OldCell", (int)((DataRowView)this.bsMeasurement.Current)["id"], this.IdBus, this.IdTransf));
                    this.bsMeasCable.Sort = str;
                }
                this.bsMeasCable.CurrentChanged += new EventHandler(this.bsMeasCable_CurrentChanged);
                this.bsMeasCable.RaiseListChangedEvents = false;
                this.bsMeasCable_CurrentChanged(this.bsMeasCable, new EventArgs());
            }
            if (this.typeDoc_1 == TypeDoc.HighMeasurement)
            {
                this.lbTransfName.Text = "";
                this.dsJournal.tJ_MeasAmperageTransf.Rows.Clear();
                this.dsJournal.fn_J_MeasTransfPassport.Rows.Clear();
                if (this.bsBusesTransfs.Current != null)
                {
                    if (this.IdTransf != -1)
                    {
                        string[] textArray2 = new string[] { this.IdTransf.ToString() };
                        base.CallSQLTableValuedFunction(this.dsJournal, this.dsJournal.fn_J_MeasTransfPassport, "", textArray2);
                        this.lbTransfName.Text = "Трансформатор № " + this.dsJournal.fn_J_MeasTransfPassport.Rows[0]["Name"].ToString();
                    }
                    if (this.bsMeasurement.Current != null)
                    {
                        base.SelectSqlData(this.dsJournal, this.dsJournal.tJ_MeasAmperageTransf, true, string.Format("WHERE idMeasurement = {0} AND idBus = {1} AND idObjList = {2} AND Deleted = ((0))", (int)((DataRowView)this.bsMeasurement.Current)["id"], this.IdBus, this.IdTransf));
                    }
                }
                this.bsMeasCell.RaiseListChangedEvents = true;
                this.bsMeasCell.CurrentChanged -= new EventHandler(this.bsMeasCell_CurrentChanged);
                this.dsJournal.vJ_MeasCell.Rows.Clear();
                this.dgvSumCell.Rows.Clear();
                if ((this.bsMeasurement.Current != null) && (this.bsBusesTransfs.Current != null))
                {
                    string str2 = (this.bsMeasCell.Sort != null) ? this.bsMeasCell.Sort : "";
                    base.SelectSqlData(this.dsJournal, this.dsJournal.vJ_MeasCell, true, string.Format("WHERE idMeasurement = {0} AND idBus = {1} AND idTransf = {2} AND Deleted = ((0)) ORDER BY CONVERT(INT, CASE WHEN NameCell like '%[^0-9]%' THEN SUBSTRING(NameCell,1,PATINDEX('%[^0-9]%',NameCell)-1) ELSE NameCell END)", (int)((DataRowView)this.bsMeasurement.Current)["id"], this.IdBus, this.IdTransf));
                    this.bsMeasCell.Sort = str2;
                }
                this.bsMeasCell.CurrentChanged += new EventHandler(this.bsMeasCell_CurrentChanged);
                this.bsMeasCell.RaiseListChangedEvents = false;
                this.bsMeasCell_CurrentChanged(this.bsMeasCell, new EventArgs());
            }
        }

        private void bsMeasCell_CurrentChanged(object sender, EventArgs e)
        {
            this.RefreshMeasCellRatio();
        }

        private void bsMeasCable_CurrentChanged(object sender, EventArgs e)
        {
            this.RefreshMeasCableRatio();
            if (this.tcMeasurement.SelectedTab == this.tpAddress)
            {
                this.dsJournal.vJ_MeasAbnObj.Rows.Clear();
                if ((this.bsMeasCable.Current != null) && (((DataRowView)this.bsMeasCable.Current)["idCell"] is int))
                {
                    base.SelectSqlData(this.dsJournal, this.dsJournal.vJ_MeasAbnObj, true, string.Format("WHERE idSchmObj = {0}", 
                        (int)((DataRowView)this.bsMeasCable.Current)["idCell"]));
                }
            }
        }

        private void bsMeasurement_CurrentChanged(object sender, EventArgs e)
        {
            this.bsBusesTransfs.RaiseListChangedEvents = true;
            this.bsBusesTransfs.CurrentChanged -= new EventHandler(this.bsBusesTransfLV_CurrentChanged);
            this.dsJournal.vJ_BusesTransfs.Rows.Clear();
            if (this.bsMeasurement.Current != null)
            {
                base.SelectSqlData(this.dsJournal, this.dsJournal.vJ_BusesTransfs, true, string.Format("WHERE idMeasurement = {0} AND TypeDoc = {1} ORDER BY Name", (int)((DataRowView)this.bsMeasurement.Current)["id"], this.idTypeDoc));
            }
            this.bsBusesTransfs.CurrentChanged += new EventHandler(this.bsBusesTransfLV_CurrentChanged);
            this.bsBusesTransfs.RaiseListChangedEvents = false;
            this.IdTransf = ((this.bsBusesTransfs.Current == null) || !(((DataRowView)this.bsBusesTransfs.Current)["IdTransf"] is int)) ? -1 : ((int)((DataRowView)this.bsBusesTransfs.Current)["IdTransf"]);
            this.NameTransf = ((this.bsBusesTransfs.Current == null) || !(((DataRowView)this.bsBusesTransfs.Current)["IdTransf"] is string)) ? "" : ((DataRowView)this.bsBusesTransfs.Current)["IdTransf"].ToString();
            this.IdBus = ((this.bsBusesTransfs.Current == null) || !(((DataRowView)this.bsBusesTransfs.Current)["IdBus"] is int)) ? -1 : ((int)((DataRowView)this.bsBusesTransfs.Current)["IdBus"]);
            if ((this.typeDoc_1 == TypeDoc.HighMeasurement) && (this.bsMeasurement.Current != null))
            {
                this.SelectBusTransfByMeasurement((int)((DataRowView)this.bsMeasurement.Current)["id"]);
            }
            if (this.fillTree == FormDockPassport.FillTree.One) //null
            {
                if (this.objListOne.GroupType == TypeObjListGroup.Buses)
                {
                    this.SelectExistElement("idBus", this.IdBus);
                }
                else if (this.objListOne.GroupType == TypeObjListGroup.Switches)
                {
                    this.SelectExistElement("idTransf", this.IdTransf);
                }
                else
                {
                    this.bsBusesTransfLV_CurrentChanged(this.bsBusesTransfs, new EventArgs());
                }
            }
            else
            {
                this.bsBusesTransfLV_CurrentChanged(this.bsBusesTransfs, new EventArgs());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void dgvMeasCable_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            this.ChangeSizeCableColumns(this.dgvMeasCable, this.dgvSumCable, e, 14, 24);
        }

        private void dgvMeasCable_Scroll(object sender, ScrollEventArgs e)
        {
            this.dgvSumCable.HorizontalScrollingOffset = this.dgvMeasCable.HorizontalScrollingOffset;
        }

        private void dgvMeasurement_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void dataGridView_5_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            this.ChangeSizeCellColumns(this.dgvMeasCell, this.dgvSumCell, e, 3, 11);
        }

        private void dataGridView_5_Scroll(object sender, ScrollEventArgs e)
        {
            this.dgvSumCell.HorizontalScrollingOffset = this.dgvMeasCell.HorizontalScrollingOffset;
        }

        private void FormMeasurement_Load(object sender, EventArgs e)
        {
            //Дополнительная информация : «Не удалось включить ограничения. Одна или несколько строк содержат значения, нарушающие непустые, уникальные или внешние ключи.
            // появляется ошибка "в столбце Company превышено ограничение, которое задает MaxLength"
            // один из вариантов проблемы это отсутствие связи между набором данных  программы и фактической базой данных.
            // изменение размера колонок в датасете не решило проблему
            this.dsJournal.EnforceConstraints = false;

            // Есть проблемы для сортировки для некоторых BindingSource
            ////tP_ValueLists
            //this.bsValueLists.Sort = "Name";
            //bsValueLists.IsSorted = true;



            this.IdBus = -1;
            this.IdTransf = -1;
            this.toolStripComboBoxtoolStripComboBoxMeasYear.ComboBox.DataSource = this.bsMeasYear;
            this.toolStripComboBoxtoolStripComboBoxMeasYear.ComboBox.DisplayMember = "Year";
            this.toolStripComboBoxtoolStripComboBoxMeasYear.ComboBox.ValueMember = "Year";
            this.FillMeasCableComboBoxes();
            this.FillSwitchComboBox();
            IList list = this.bsTypeDoc.List;
            this.tsmiMeasLow.Tag = 1;
            this.tsmiMeasHigh.Tag = 2;
            this.FillWorkerComboBox();
            if (this.fillTree ==  FormDockPassport.FillTree.All)
            {
                this.tsmiMeasLow.Checked = true;
                this.tableLayoutPanel_2.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, 212f);
            }
            else
            {
                this.objListOne = new ObjList(this.SqlSettings);
                this.objListOne.Id = this.idObjList;
                switch (this.objListOne.Type)
                {
                    case TypeObjList.Bus10: //40
                    case TypeObjList.Bus35: //42
                    case TypeObjList.Bus6://43
                        this.tsmiMeasHigh.Checked = true;
                        this.tssbMeasType.Enabled = false;
                        break;

                    default:
                        this.tsmiMeasLow.Checked = true;
                        this.tssbMeasType.Enabled = true;
                        break;
                }
                this.tableLayoutPanel_2.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, 0f);
                base.Width -= 210;
            }
        }

        private void FormMeasurement_Shown(object sender, EventArgs e)
        {
            this.isShown = true;
        }

        private void ChangeSizeCableColumns(DataGridView dgvData, DataGridView dgvSum, DataGridViewColumnEventArgs e, int startColumn, int endColumn)
        {
            if (this.isShown && (e.Column.Index < (startColumn + 1)))
            {
                int Width = 0;
                foreach (DataGridViewColumn column in this.dgvMeasCable.Columns)
                {
                    if ((column.Index < (startColumn + 1)) && column.Visible)
                    {
                        Width += column.Width;
                    }
                }
                dgvSum.Columns[0].Width = Width;
            }
            if ((this.isShown && (e.Column.Index > startColumn)) && (e.Column.Index < endColumn))
            {
                dgvSum.Columns[e.Column.Index - startColumn].Width = e.Column.Width;
            }
        }

        private void ChangeSizeCellColumns(DataGridView dgvData, DataGridView dgvSum, DataGridViewColumnEventArgs e, int startColumn, int endColumn)
        {
            if (this.isShown && (e.Column.Index < (startColumn + 1)))
            {
                int Width = 0;
                foreach (DataGridViewColumn column in this.dgvMeasCable.Columns)
                {
                    if ((column.Index < (startColumn + 1)) && column.Visible)
                    {
                        Width += column.Width;
                    }
                }
                dgvSum.Columns[0].Width = Width;
            }
            if ((this.isShown && (e.Column.Index > startColumn)) && (e.Column.Index < endColumn))
            {
                dgvSum.Columns[e.Column.Index - startColumn].Width = e.Column.Width;
            }
        }

        private bool SearchNoneNode(TreeNode treeNode)
        {
            return (treeNode.Nodes[0].Text == "None");
        }

        private void FillYearComboBox(int idTypeDoc)
        {
            this.FillYearComboBox(idTypeDoc, -1);
        }

        private void FillYearComboBox(int idTypeDoc, int year)
        {
            if (year == -1)
            {
                year = (this.toolStripComboBoxtoolStripComboBoxMeasYear.ComboBox.SelectedValue is int) ? ((int)this.toolStripComboBoxtoolStripComboBoxMeasYear.ComboBox.SelectedValue) : -1;
            }
            this.bsMeasYear.RaiseListChangedEvents = true;
            this.bsMeasYear.CurrentChanged -= new EventHandler(this.bsMeasYear_CurrentChanged);
            this.dsJournal.vJ_GetMeasYears.Clear();
            if (idTypeDoc != -1)
            {
                //base.SelectSqlData(this.dsJournal, this.dsJournal.vJ_GetMeasYears, true, string.Format("WHERE idObjList = {0} AND TypeDoc = {1}", this.GetIdSubstation(), idTypeDoc), true);
                base.SelectSqlData(this.dsJournal.vJ_GetMeasYears, true, string.Format("WHERE idObjList = {0} AND TypeDoc = {1}", 
                    this.GetIdSubstation(), idTypeDoc), new int?(0), true, 0);
                if (year != -1)
                {
                    this.bsMeasYear.Position = this.bsMeasYear.Find("Year", year);
                }
            }
            this.bsMeasYear.CurrentChanged += new EventHandler(this.bsMeasYear_CurrentChanged);
            this.bsMeasYear.RaiseListChangedEvents = false;
            this.bsMeasYear_CurrentChanged(this.bsMeasYear, new EventArgs());
        }

        private void FillMeasCableComboBoxes()
        {
            base.SelectSqlDataTableOther(this.dsJournal, this.dsJournal.tR_CableVoltage,
                "tR_Classifier", true, "WHERE ParentKey LIKE ';VoltageLevels;%' AND IsGroup = 0 AND Deleted = 0 ORDER BY Value");

            DataSetMeasurementN.tR_CableVoltageRow row = this.dsJournal.tR_CableVoltage.NewtR_CableVoltageRow();
            row.Id = -1;
            row.Name = "";
  
            this.dsJournal.tR_CableVoltage.AddtR_CableVoltageRow(row);
        }

        private void FillWorkerComboBox()
        {
            SelectSqlData(this.dsJournal, this.dsJournal.vP_Worker, true, string.Format
                ("WHERE ParentKey IN (';GroupWorker;Meas;', ';GroupWorker;MeasDispatchers;') AND DateEnd IS NULL", new object[0]));
            DataSetMeasurementN.vP_WorkerRow vP_WorkerRow = dsJournal.vP_Worker.NewvP_WorkerRow();
       
            vP_WorkerRow.Id = -1;
            vP_WorkerRow.F = "";
            vP_WorkerRow.FIO = "";
            vP_WorkerRow.ParentKey = "";
            vP_WorkerRow.idGroup = 1;
            vP_WorkerRow.isGroup = false;
       
            this.dsJournal.vP_Worker.AddvP_WorkerRow(vP_WorkerRow);
        }

        private void FillSwitchComboBox()
        {
            base.SelectSqlData(this.dsJournal, this.dsJournal.tR_Classifier, true, string.Format
                ("WHERE ParentKey IN (';Measurement;Switch;', ';Measurement;Type;') AND Deleted = ((0)) AND isGroup = ((0))", new object[0]));

            DataSetMeasurementN.tR_ClassifierRow tR_ClassifierRow = this.dsJournal.tR_Classifier.NewtR_ClassifierRow();
            tR_ClassifierRow.Id = -1;
            tR_ClassifierRow.Name = "";
            tR_ClassifierRow.ParentKey = ";Measurement;Switch;";
            tR_ClassifierRow.IsGroup = false;
            tR_ClassifierRow.Deleted = false;
   
            this.dsJournal.tR_Classifier.AddtR_ClassifierRow(tR_ClassifierRow);
            this.cbSwitchPosition.SelectedValue = -1;
        }

        private void RefreshMeasCableRatio()
        {
            this.dgvSumCable.Rows.Clear();
            decimal numIad = (from row in this.dsJournal.vJ_MeasCable
                           where row["Iad"] != DBNull.Value
                           select row).Sum((DataSetMeasurementN.vJ_MeasCableRow row) => row.Iad);
            decimal numIan = (from row in this.dsJournal.vJ_MeasCable
                            where row["Ian"] != DBNull.Value
                            select row).Sum((DataSetMeasurementN.vJ_MeasCableRow row) => row.Ian);
            decimal numIbd = (from row in this.dsJournal.vJ_MeasCable
                            where row["Ibd"] != DBNull.Value
                            select row).Sum((DataSetMeasurementN.vJ_MeasCableRow row) => row.Ibd);
            decimal numIbn = (from row in this.dsJournal.vJ_MeasCable
                            where row["Ibn"] != DBNull.Value
                            select row).Sum((DataSetMeasurementN.vJ_MeasCableRow row) => row.Ibn);
            decimal numIcd = (from row in this.dsJournal.vJ_MeasCable
                            where row["Icd"] != DBNull.Value
                            select row).Sum((DataSetMeasurementN.vJ_MeasCableRow row) => row.Icd);
            decimal numIcn = (from row in this.dsJournal.vJ_MeasCable
                            where row["Icn"] != DBNull.Value
                            select row).Sum((DataSetMeasurementN.vJ_MeasCableRow row) => row.Icn);
            decimal numIod = (from row in this.dsJournal.vJ_MeasCable
                            where row["Iod"] != DBNull.Value
                            select row).Sum((DataSetMeasurementN.vJ_MeasCableRow row) => row.Iod);
            decimal numIon = (from row in this.dsJournal.vJ_MeasCable
                            where row["Ion"] != DBNull.Value
                            select row).Sum((DataSetMeasurementN.vJ_MeasCableRow row) => row.Ion); decimal num9 = 0;
            decimal num10 = 0;

            object[] values = new object[] { "Суммарная нагрузка Iсум, A", numIad, numIan, numIbd, numIbn, numIcd, numIcn, numIod, numIon, "" };
            this.dgvSumCable.Rows.Add(values);

            if (this.tcMeasurement.SelectedTab == this.tpRatio)
            {
                decimal num11 = Math.Round((decimal)((numIad + numIbd + numIcd) / 3M), 0);
                decimal num12 = Math.Round((decimal)((numIan + numIbn + numIcn) / 3M), 0);
                decimal num13 = decimal.Parse((this.tbTransAmperage.Text.Length == 0) ? "0" : this.tbTransAmperage.Text);
                // Коэфиициенты
                this.tbIsrd.Text = num11.ToString();
                this.tbIsrn.Text = num12.ToString();
                this.tbKNTd.Text = (num13 == 0) ? "0" : Math.Round((decimal)(num11 / (num13 / 100M)), 1).ToString();
                this.tbKNTn.Text = (num13 == 0) ? "0" : Math.Round((decimal)(num12 / (num13 / 100M)), 1).ToString();
                decimal num14 = Math.Max(Math.Max(Math.Abs((decimal)(numIad - numIbd)), Math.Abs((decimal)(numIad - numIcd))), Math.Abs((decimal)(numIbd - numIcd)));
                if ((numIad + numIbd + numIcd) != 0)
                {
                    num9 = Math.Round((decimal)(num14 / ((numIad + numIbd + numIcd) / 100M)), 0);
                }
                decimal num15 = Math.Max(Math.Max(Math.Abs((decimal)(numIan - numIbn)), Math.Abs((decimal)(numIan - numIcn))), Math.Abs((decimal)(numIbn - numIcn)));
                if ((numIan + numIbn + numIcn) != 0)
                {
                    num10 = Math.Round((decimal)(num15 / (((numIan + numIbn) + numIcn) / 100M)));
                }
                this.tbKNKFd.Text = num9.ToString();
                this.tbKNKFn.Text = num10.ToString();
            }
            else
            {
                object[] objArray2 = new object[] { "Суммарная нагрузка Iсум, A", numIad, numIan, numIbd, numIbn, numIcd, numIcn, numIod, numIon, "" };
                this.dgvSumCable.Rows.Add(objArray2);
            }
        }

        private void RefreshMeasCellRatio()
        {
            if (this.dsJournal.vJ_MeasCell.Rows.Count > 0)
            {
                this.dgvSumCell.Rows.Clear();
                decimal numIad = (from row in this.dsJournal.vJ_MeasCell
                               where row["Iad"] != DBNull.Value
                               select row).Sum(row => row.Iad);
                decimal numIan = (from row in this.dsJournal.vJ_MeasCell
                                where row["Ian"] != DBNull.Value
                                select row).Sum( row => row.Ian);
                decimal numIbd = (from row in this.dsJournal.vJ_MeasCell
                                where row["Ibd"] != DBNull.Value
                                select row).Sum( row => row.Ibd);
                decimal numIbn = (from row in this.dsJournal.vJ_MeasCell
                                where row["Ibn"] != DBNull.Value
                                select row).Sum( row => row.Ibn);
                decimal numIcd = (from row in this.dsJournal.vJ_MeasCell
                                where row["Icd"] != DBNull.Value
                                select row).Sum( row => row.Icd);
                decimal numIcn = (from row in this.dsJournal.vJ_MeasCell
                                where row["Icn"] != DBNull.Value
                                select row).Sum(row => row.Icn);
       
                object[] values = new object[] { "Суммарная нагрузка Iсум, A", numIad, numIan, numIbd, numIbn, numIcd, numIcn, "" };
                this.dgvSumCell.Rows.Add(values);
            }
            else
            {
                object[] objArray2 = new object[] { "Суммарная нагрузка Iсум, A", 0, 0, 0, 0, 0, 0, "" };
                this.dgvSumCell.Rows.Add(objArray2);
            }
        }
        /// <summary>
        /// Обновление данных
        /// </summary>
        private void RefreshAll()
        {
            if (this.toolStripComboBoxtoolStripComboBoxMeasYear.ComboBox.SelectedValue is int)
            {
                int selectedValue = (int)this.toolStripComboBoxtoolStripComboBoxMeasYear.ComboBox.SelectedValue;
            }
            int key = ((this.dgvMeasurement.SelectedRows == null) || (this.dgvMeasurement.SelectedRows.Count <= 0)) ? -1 : ((int)this.dgvMeasurement.SelectedRows[0].Cells["idDataGridViewTextBoxColumn1"].Value);
            this.FillYearComboBox(this.idTypeDoc);
            this.bsMeasurement.RaiseListChangedEvents = true;
            this.bsMeasurement.CurrentChanged -= new EventHandler(this.bsMeasurement_CurrentChanged);
            this.bsMeasurement.Position = this.bsMeasurement.Find("Id", key);
            this.bsMeasurement.CurrentChanged += new EventHandler(this.bsMeasurement_CurrentChanged);
            this.bsMeasurement.RaiseListChangedEvents = false;
            if (this.typeDoc_1 == TypeDoc.LowMeasurement)
            {
                this.bsBusesTransfs.Position = this.bsBusesTransfs.Find("idBus", this.IdBus);
            }
            if (this.typeDoc_1 == TypeDoc.HighMeasurement)
            {
                this.bsBusesTransfs.Position = this.bsBusesTransfs.Find("idBus", this.IdBus);
            }
        }
        /// <summary>
        /// вернуть идентификатор подстанции из паспорта ПС
        /// </summary>
        /// <returns></returns>
        private int GetIdSubstation()
        {
            if (this.treeView.SelectedNode != null)
            {
                TreeObject tag = (TreeObject)this.treeView.SelectedNode.Tag;
                if (tag.TypeNode != TypeNode.Group)
                {
                    if (this.objListPassport.GroupType != TypeObjListGroup.Substations)
                    {
                        return this.objListPassport.IdParent;
                    }
                    return this.objListPassport.Id;
                }
            }
            return -1;
        }

        /// <summary>
        /// Обновляем дерево объектов
        /// </summary>
        private void RefreshTree(FormDockPassport.Sort sort, TypeDoc typeDoc)
        {
            treeView.BeginUpdate();
            treeView.Nodes.Clear();
            GroupNodeCreate(this.treeView);

            string str = (typeDoc == TypeDoc.LowMeasurement) ? ";SCM;BUS;BUSLV;" : ((typeDoc == TypeDoc.HighMeasurement) ? ";SCM;BUS;BUSMV;" : "");
            // шины
            DataTable dt1 = SelectSqlData("vP_ObjList", true, string.Format("WHERE ParentKey = '{0}' AND Tag IS NULL AND Deleted = (0)", str));
            // подстанции
            DataTable dt2 = SelectSqlData("vP_ObjList", true, string.Format("WHERE ParentKey = '{0}' AND Value IN ({1}) AND Deleted = (0)", ";SCM;PS;",
                (this.typeDoc_1 == TypeDoc.LowMeasurement) ? "2,3,4" : "2,4,5"));

            //////// версия 1
            //////var enumerator = dt2.AsEnumerable().OrderBy(r => r["Name"]);

            //////foreach (DataRow row in enumerator)
            //////{
            //////    //TreeNode treeNode = new TreeNode(row["Text"].ToString());
            //////    TreeNode treeNode = new TreeNode(row.Field<string>("Text"));
            //////    TreeObject treeObject = default(TreeObject);
            //////    treeObject.TypeNode = TypeNode.Substation;
            //////    // treeObject.idSub = (int)row["Id"];
            //////    treeObject.idSub = row.Field<int>("Id");
            //////    treeNode.Name = row["TypeCodeId"].ToString();
            //////    treeNode.Tag = treeObject;

            //////    var dt3 = dt1.AsEnumerable().Where(r => (int)r["IdParent"] == (int)row["Id"])/*.OrderBy(r => r["Name"])*/;
            //////    if (dt3.Count() > 0)
            //////    {
            //////        TreeNode node = new TreeNode("None");
            //////        treeNode.Nodes.Add(node);

            //////    }
            //////    this.treeView.Nodes[row["TypeCodeId"].ToString()].Nodes.Add(treeNode);
            //////}

            // версия 2
            var enumerator5 = dt2.AsEnumerable()
                .GroupJoin(
                   dt1.AsEnumerable(),
                   row1 => row1["Id"],
                   row2 => row2["IdParent"],
                   (row1, row2) => new
                   {
                       Id = (int)row1["Id"],
                       TypeCodeId = row1["TypeCodeId"].ToString(),
                       Text = (string)row1["Text"],
                       Count = row2.Count()
                   }
                   ).OrderBy(r => r.Text);

            foreach (var row in enumerator5)
            {
                TreeNode treeNode = new TreeNode(row.Text);
                TreeObject treeObject = default(TreeObject);
                treeObject.TypeNode = TypeNode.Substation;
                treeObject.idSub = row.Id;
                treeNode.Name = row.TypeCodeId;
                treeNode.Tag = treeObject;

                if (row.Count > 0)
                {
                    TreeNode node = new TreeNode("None");
                    treeNode.Nodes.Add(node);
                }
                this.treeView.Nodes[row.TypeCodeId].Nodes.Add(treeNode);
            }


            this.treeView.EndUpdate();

           
        }

        private string GetSubstationNameBySelectedNode(TreeNode treeNode)
        {
            TreeObject tag = (TreeObject)treeNode.Tag;
            if (tag.TypeNode == TypeNode.Bus)
            {
                return treeNode.Parent.Text;
            }
            //tag = (TreeObject)treeNode.Tag;
            if (tag.TypeNode == TypeNode.Substation)
            {
                return treeNode.Text;
            }
            return "";
        }
        /// <summary>
        /// Получение наименование текущего узла дерева
        /// </summary>
        /// <returns></returns>
        private string GetSubstationNameBySelectedNode()
        {
            return this.GetSubstationNameBySelectedNode(this.treeView.SelectedNode);
        }

        /// <summary>
        /// Вернуть идентификатор типа  замера из классификатора
        /// </summary>
        private int GetIdTypeDoc(TypeDoc typeDoc)
        {
            return (from row in this.dsJournal.tR_Classifier
                    where row.Value == (int)this.typeDoc_1 && row.ParentKey == ";Measurement;Type;"
                    select row.Id).First<int>();
        }

        private void TypeDocSwitches(TypeDoc typeDoc_2)
        {
            switch (typeDoc_2)
            {
                case TypeDoc.None:
                case ~TypeDoc.None: //case (FormMeasurement.TypeDoc)0:
                    break;

                case TypeDoc.LowMeasurement:
                    this.tableLayoutPanel_1.RowStyles[2] = new RowStyle(SizeType.Percent, 100f);
                    this.tableLayoutPanel_1.RowStyles[3] = new RowStyle(SizeType.Absolute, 0f);
                    this.dateNDataGridViewTextBoxColumn.Visible = true;
                    this.temperatureNDataGridViewTextBoxColumn.Visible = true;
                    this.idWorkerCheck.Visible = false;
                    return;

                case TypeDoc.HighMeasurement:
                    this.tableLayoutPanel_1.RowStyles[2] = new RowStyle(SizeType.Absolute, 0f);
                    this.tableLayoutPanel_1.RowStyles[3] = new RowStyle(SizeType.Percent, 100f);
                    this.dateNDataGridViewTextBoxColumn.Visible = false;
                    this.temperatureNDataGridViewTextBoxColumn.Visible = false;
                    this.idWorkerCheck.Visible = true;
                    break;

                default:
                    return;
            }
        }

        private void SelectExistElement(string nameColumn, object obj)
        {
            if (this.bsBusesTransfs.Count == 0)
            {
                this.bsBusesTransfLV_CurrentChanged(this.bsBusesTransfs, new EventArgs());
            }
            else
            {
                this.bsBusesTransfs.RaiseListChangedEvents = false;
                this.bsBusesTransfs.CurrentChanged -= new EventHandler(this.bsBusesTransfLV_CurrentChanged);
                int Position = this.bsBusesTransfs.Find(nameColumn, obj);
                if (Position != -1)
                {
                    this.bsBusesTransfs.Position = Position;
                }
                else
                {
                    this.dsJournal.vJ_BusesTransfs.Rows.Clear();
                }
                this.bsBusesTransfs.CurrentChanged += new EventHandler(this.bsBusesTransfLV_CurrentChanged);
                this.bsBusesTransfs.RaiseListChangedEvents = false;
                this.bsBusesTransfLV_CurrentChanged(this.bsBusesTransfs, new EventArgs());
            }
        }

        private int SelectBusTransfByMeasurement(int idMeasurement)
        {
            int Position = -1;
            DataTable source = base.SelectSqlData("tJ_MeasAmperageTransf", true, string.Format("WHERE idMeasurement = {0} AND Deleted = ((0))", idMeasurement));
            if (source.Rows.Count > 0)
            {
                DataRow row = source.AsEnumerable().First();
                //if (row.Field("idBus") != DBNull.Value)
                //{
                //    row.Field("idBus");
                //}
                if (row["idBus"] != DBNull.Value)
                {
                    row.Field<int>("idBus");
                }
                if (row["idObjList"] != DBNull.Value)
                {
                    row.Field<int>("idObjList");
                }
                if (this.bsBusesTransfs.Count == 0)
                {
                    return Position;
                }
                this.bsBusesTransfs.RaiseListChangedEvents = true;
                this.bsBusesTransfs.CurrentChanged -= new EventHandler(this.bsBusesTransfLV_CurrentChanged);
                if (this.IdTransf == -1)
                {
                    Position = this.bsBusesTransfs.Find("idBus", this.IdBus);
                }
                else
                {
                    Position = this.bsBusesTransfs.Find("IdTransf", this.IdTransf);
                    if (Position != -1)
                    {
                        Position = this.bsBusesTransfs.Find("idBus", this.IdBus);
                    }
                }
                if (Position != -1)
                {
                    this.bsBusesTransfs.Position = Position;
                }
                this.bsBusesTransfs.CurrentChanged += new EventHandler(this.bsBusesTransfLV_CurrentChanged);
                this.bsBusesTransfs.RaiseListChangedEvents = false;
            }
            return Position;
        }
        /// <summary>
        /// открытие формы от низкой стороны
        /// </summary>
        private FormBase frmLowMeasurement_ShowForm(object object_0, ShowFormEventArgs e)
        {
            return this.OnShowForm(e);
        }
        /// <summary>
        /// закрытие формы от низкой стороны
        /// </summary>
        private void frmLowMeasurement_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAddEditMeasLowVoltage form = (FormAddEditMeasLowVoltage)sender;
            if (form.DialogResult == DialogResult.OK)
            {
                this.RefreshAll();
                this.bsMeasurement.Position = this.bsMeasurement.Find("Id", form.IdMeasurement);
                this.bsBusesTransfs.Position = this.bsBusesTransfs.Find("idTransf", form.IdTransformer);
            }
        }
        /// <summary>
        /// закрытие формы от высокой стороны
        /// </summary>
        private void frmHighMeasurement_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAddEditMeasHighVoltage form = (FormAddEditMeasHighVoltage)sender;
            if (form.DialogResult == DialogResult.OK)
            {
                this.RefreshAll();
                this.bsMeasurement.Position = this.bsMeasurement.Find("Id", form.IdMeasurement);
                this.bsBusesTransfs.Position = this.bsBusesTransfs.Find("idBus", form.IdBus);
            }
        }

        /// <summary>
        /// Обновляем дерево объектов, с привязкой к объекту
        /// </summary>
        private void RefreshTree(FormDockPassport.Sort sort, int idObjList, TypeDoc typeDoc)
        {
    
            this.treeView.BeginUpdate();
            this.treeView.Nodes.Clear();


            int idSub = (this.objListOne.GroupType == TypeObjListGroup.Buses/* 6*/) ? this.objListOne.IdParent : ((this.objListOne.GroupType == TypeObjListGroup.Substations) ? this.objListOne.Id : ((this.objListOne.GroupType == TypeObjListGroup.Switches/*8*/) ? this.objListOne.IdParentAddl : -1));

            string str = (typeDoc == TypeDoc.LowMeasurement) ? ";SCM;BUS;BUSLV;" : ((typeDoc == TypeDoc.HighMeasurement) ? ";SCM;BUS;BUSMV;" : "");
            string where = string.Format("WHERE id = {0} OR idParent = {0} AND ParentKey = '{1}' AND Tag IS NULL AND Deleted = 0", idSub, str);
            DataTable source = base.SelectSqlData("vP_ObjList", true, where);

            foreach (DataRow row in from row in source.AsEnumerable()
                                    where row.Field<int>("Id") == idSub
                                    select row into r
                                    orderby r.Field<string>("Name")
                                    select r)
            {
                TreeNode treeNode = new TreeNode(row["Text"].ToString());
                TreeObject treeObject = default(TreeObject);
                treeObject.TypeNode = TypeNode.Substation;
                treeObject.idSub = (int)row["Id"];
                treeNode.Name = row["TypeCodeId"].ToString();
                treeNode.Tag = treeObject;
                if (source.AsEnumerable().Where((DataRow r) => (int)r["IdParent"] == (int)row["Id"]).OrderBy((DataRow r) => r.Field<string>("Name")).Count<DataRow>() > 0)
                {
                    TreeNode node = new TreeNode("None");
                    treeNode.Nodes.Add(node);
                }
                this.treeView.Nodes.Add(treeNode);
            }
            
            if (this.treeView.Nodes.Count > 0)
            {
                this.treeView.SelectedNode = this.treeView.Nodes[0];
            }
            this.treeView.EndUpdate();
        }

        /// <summary>
        /// Делаем дерево группы
        /// </summary>
        private void GroupNodeCreate(TreeView treeView_1)
        {
            DataTable dt = SelectSqlData("tR_Classifier", true, 
                string.Format("WHERE ParentKey = '{0}' AND Value IN ({1}) AND Deleted = ((0))", ";SCM;PS;", 
                (typeDoc_1 == TypeDoc.LowMeasurement) ? "2,3,4" : "2,4,5"));

            foreach (DataRow row in dt.Rows)
            {
                TreeNode node = new TreeNode(row["SocrName"].ToString());
                TreeObject obj2 = new TreeObject
                {
                    TypeNode = TypeNode.Group
                };
                node.Tag = obj2;
                node.Name = row["Id"].ToString();
                treeView_1.Nodes.Add(node);
            }
        }

        /// <summary>
        /// добавление элементов в дерево
        /// </summary>
        private List<TreeNode> AddNodeInList(TreeNodeCollection treeNodeCollection, List<TreeNode> list)
        {
            foreach (TreeNode node in treeNodeCollection)
            {
                list.Add(node);
                list = this.AddNodeInList(node.Nodes, list);
            }
            return list;
        }

        private List<TreeNode> AddExpandedNodeInList(TreeNodeCollection treeNodeCollection, List<TreeNode> list)
        {
            foreach (TreeNode node in treeNodeCollection)
            {
                if (node.IsExpanded)
                {
                    list.Add(node);
                }
                list = this.AddExpandedNodeInList(node.Nodes, list);
            }
            return list;
        }

        private TreeNode SearchNextNode(List<TreeNode> list, TreeNode treeNode, string str)
        {
            bool flag = false;
            foreach (TreeNode node in list)
            {
                if (flag && node.Text.ToUpper().Contains(str.ToUpper()))
                {
                    return node;
                }
                if (node == treeNode)
                {
                    flag = true;
                }
            }
            return null;
        }

        private TreeNode SearchNode(List<TreeNode> list, string str)
        {
            foreach (TreeNode node in list)
            {
                if (node.Text.ToUpper().Contains(str.ToUpper()))
                {
                    return node;
                }
            }
            return null;
        }

        /// <summary>
        /// поиск подстанции в дереве по идентификатору подстанции в паспорте
        /// </summary>
        private TreeNode SearchNode(List<TreeNode> list, int idSubstation)
        {
            foreach (TreeNode node in list)
            {
                if (node.Tag != null)
                {
                    TreeObject tag = (TreeObject)node.Tag;
                    if (tag.TypeNode == TypeNode.Substation)
                    {
                        tag = (TreeObject)node.Tag;
                        if (tag.idSub == idSubstation)
                        {
                            return node;
                        }
                    }
                }
            }
            return null;
        }

        private void tcMeasurement_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bsMeasCable_CurrentChanged(this.bsMeasCable, new EventArgs());
        }

        private void texBoxCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheck.OnlyDigit(sender, e);
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.AddNodeInList(this.treeView.Nodes, list);
            TreeNode node = this.SearchNode(list, this.toolStripTextBox_0.Text);
            if (node != null)
            {
                this.treeView.Focus();
                this.treeView.SelectedNode = node;
                this.treeView.SelectedNode.Expand();
            }
        }
        /// <summary>
        /// Найти далее
        /// </summary>
        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.AddNodeInList(this.treeView.Nodes, list);
            TreeNode node = this.SearchNextNode(list, this.treeView.SelectedNode, this.toolStripTextBox_0.Text);
            if (node != null)
            {
                this.treeView.Focus();
                this.treeView.SelectedNode = node;
                this.treeView.SelectedNode.Expand();
            }
        }
        /// <summary>
        /// сортировка
        /// </summary>
        private void tsbSortTree_Click(object sender, EventArgs e)
        {
            this.toolStripButton_2.Image = (this.sort_0 == FormDockPassport.Sort.Asc) ? global::Measurement.Properties.Resources.sortZA : global::Measurement.Properties.Resources.sortAZ;
            this.sort_0 = (this.sort_0 == FormDockPassport.Sort.Asc) ? (FormDockPassport.Sort.Desc) : (FormDockPassport.Sort.Asc);
            List<TreeNode> list = new List<TreeNode>();
            this.AddExpandedNodeInList(this.treeView.Nodes, list);
            this.RefreshTree(this.sort_0, this.typeDoc_1);
            List<TreeNode> list2 = new List<TreeNode>();
            this.AddNodeInList(this.treeView.Nodes, list2);
            foreach (TreeNode node in list)
            {
                IEnumerable<TreeNode> source = from n in list2
                                               where n.Text == node.Text || (n.Tag == node.Tag && n.Text == node.Text)
                                               select n;
                if (source.Count<TreeNode>() > 0)
                {
                    source.First<TreeNode>().Expand();
                }
            }
            
        }
        /// <summary>
        /// Добавить замер
        /// </summary>
        /// tssbMeasAdd_ButtonClick
        private void tsbMeasAdd_Click(object sender, EventArgs e)
        {
            int idSub = this.GetIdSubstation();
            if ((idSub != -1) && (((this.objListPassport.GroupType == TypeObjListGroup.Substations) && 
                (this.treeView.SelectedNode.Nodes.Count > 0)) || ((this.objListPassport.GroupType == TypeObjListGroup.Switches) || (this.objListPassport.GroupType == TypeObjListGroup.Buses))))
            {
                switch (this.typeDoc_1)
                {
                    case TypeDoc.None:
                    case ~TypeDoc.None:
                        return;
                    case TypeDoc.LowMeasurement:
                        {
                            FormAddEditMeasLowVoltage form1 = new FormAddEditMeasLowVoltage(this.SqlSettings, idSub, this.GetSubstationNameBySelectedNode(), this.IdBusSchema, this.IdTransfSchema, -1);
                            form1.ShowForm += (new ShowFormEventHandler(this.frmLowMeasurement_ShowForm));
                            form1.FormClosed += new FormClosedEventHandler(this.frmLowMeasurement_FormClosed);
                            form1.MdiParent = base.MdiParent;
                            form1.PermissionsSql = (false);
                            form1.Show();
                            return;
                        }
                    case TypeDoc.HighMeasurement:
                        {
                            FormAddEditMeasHighVoltage form2 = new FormAddEditMeasHighVoltage(this.SqlSettings, idSub, this.GetSubstationNameBySelectedNode(), this.IdBusSchema, this.IdTransfSchema);
                            form2.FormClosed += new FormClosedEventHandler(this.frmHighMeasurement_FormClosed);
                            form2.MdiParent = base.MdiParent;
                            form2.PermissionsSql = (false);
                            form2.Show();
                            return;
                        }
                }
            }
            else
            {
                MessageBox.Show("Не выбрана подстанция или отсутствует " + ((this.typeDoc_1 == TypeDoc.LowMeasurement) ? "шина(трансформатор)." : "шина."), "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
        /// <summary>
        /// Редактировать замер
        /// </summary>
        private void tsbMeasEdit_Click(object sender, EventArgs e)
        {
            if (this.bsTypeDoc.Current != null)
            {
                if (((decimal)((DataRowView)this.bsTypeDoc.Current)["Value"]) == 1)
                {
                    if (this.bsMeasurement.Current == null)
                    {
                        MessageBox.Show("Не выбран замер, либо в подстанции отсутствуют трансформаторы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    FormAddEditMeasLowVoltage form1 = new FormAddEditMeasLowVoltage(this.SqlSettings, this.GetIdSubstation(), this.GetSubstationNameBySelectedNode(), this.IdBus, this.IdTransf, (int)((DataRowView)this.bsMeasurement.Current)["id"]);
                    form1.ShowForm += new ShowFormEventHandler(this.frmLowMeasurement_ShowForm);
                    form1.FormClosed += new FormClosedEventHandler(this.frmLowMeasurement_FormClosed);
                    form1.MdiParent = base.MdiParent;
                    form1.PermissionsSql = (false);
                    form1.Show();
                }
                if (((decimal)((DataRowView)this.bsTypeDoc.Current)["Value"]) == 2)
                {
                    if (this.bsMeasurement.Current != null)
                    {
                        int num = ((this.bsMeasAmperageTransf.Current == null) || !(((DataRowView)this.bsMeasAmperageTransf.Current)["id"] is int)) ? -1 : ((int)((DataRowView)this.bsMeasAmperageTransf.Current)["id"]);
                        FormAddEditMeasHighVoltage form2 = new FormAddEditMeasHighVoltage(this.SqlSettings, this.GetIdSubstation(), this.GetSubstationNameBySelectedNode(), this.IdBus, this.IdTransf, this.NameTransf, (int)((DataRowView)this.bsMeasurement.Current)["id"], num);
                        form2.FormClosed += new FormClosedEventHandler(this.frmHighMeasurement_FormClosed);
                        form2.MdiParent = base.MdiParent;
                        form2.PermissionsSql =false;
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Не выбран замер.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран, либо отсутствуют тип замера!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Удалить замер
        /// </summary>
        private void tsbMeasDelete_Click(object sender, EventArgs e)
        {
            if (((this.bsMeasurement.Current != null) && (((DataRowView)this.bsMeasurement.Current)["id"] is int))
                && (MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
            {
                //this.dsJournal.tJ_Measurement.Single<DataSetGES.Class94>(new Func<DataSetGES.Class94, bool>(this.method_31)).Deleted = true;

                DataSetMeasurementN.tJ_MeasurementRow tJ_MeasurementRow = this.dsJournal.tJ_Measurement.Single((DataSetMeasurementN.tJ_MeasurementRow r) => r.id == (int)((DataRowView)this.bsMeasurement.Current)["id"]);
                tJ_MeasurementRow.Deleted = true;

                base.UpdateSqlData(this.dsJournal, this.dsJournal.tJ_Measurement);
                this.RefreshAll();
            }
        }
        /// <summary>
        /// Обновить форму
        /// </summary>
        private void tsbMeasRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshAll();
        }
        /// <summary>
        /// Печать листка замероа
        /// </summary>
        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (this.bsTypeDoc.Current != null)
            {
                if (((((decimal)((DataRowView)this.bsTypeDoc.Current)["Value"]) == decimal.One) && (this.bsMeasurement.Current != null)) && (this.bsBusesTransfs.Current != null))
                {
                    ObjList list1 = new ObjList(this.SqlSettings);
                    list1.Id = this.GetIdSubstation();
                    int idMeasurement = (((DataRowView)this.bsMeasurement.Current)["id"] is int) ? ((int)((DataRowView)this.bsMeasurement.Current)["id"]) : -1;
                    int IdMeasTransf = ((this.bindingSource_1.Current == null) || !(((DataRowView)this.bindingSource_1.Current)["id"] is int)) ? -1 : ((int)((DataRowView)this.bindingSource_1.Current)["id"]);
                    if (list1.Type == TypeObjList.SubstationConnecting) //  0x1c)
                    {
                        new FormMeasurementReports(this.SqlSettings, ReportType.MeasurementLowVoltageSP, idMeasurement, this.IdBus, -1, -1)
                        { MdiParent = base.MdiParent }.Show();
                    }
                    else
                    {
                        new FormMeasurementReports(this.SqlSettings, ReportType.MeasurementLowVoltage, idMeasurement, this.IdBus, this.IdTransf, IdMeasTransf)
                        { MdiParent = base.MdiParent }.Show();
                    }
                }
                if (((((decimal)((DataRowView)this.bsTypeDoc.Current)["Value"]) == 2M) && (this.bsMeasurement.Current != null)) && (this.bsBusesTransfs.Current != null))
                {
                    int idMeasurement = (((DataRowView)this.bsMeasurement.Current)["id"] is int) ? ((int)((DataRowView)this.bsMeasurement.Current)["id"]) : -1;
                    int IdMeasTransf = ((this.bsMeasAmperageTransf.Current == null) || !(((DataRowView)this.bsMeasAmperageTransf.Current)["id"] is int)) ? -1 : ((int)((DataRowView)this.bsMeasAmperageTransf.Current)["id"]);
                    new FormMeasurementReports(this.SqlSettings, ReportType.MeasurementHighVoltage, idMeasurement, this.IdBus, this.IdTransf, IdMeasTransf)
                    {
                        MdiParent = base.MdiParent
                    }.Show();
                }
            }
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            //byte[] buffer = Resources.FAQ_Measurement;
            byte[] buffer = global::Measurement.Properties.Resources.FAQ_Measurement;
            string path = Path.ChangeExtension(Path.GetTempFileName(), ".doc");
            using (FileStream stream = File.Create(path))
            {
                stream.Write(buffer, 0, buffer.Length);
            }
            EIS.WordLB.Application application1 = new EIS.WordLB.Application();
            application1.Visible=(true);
            application1.Documents.Add(path);
            try
            {
                File.Delete(path);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Отчет превышение нагрузки
        /// </summary>
        private void tsmiExcessLoad_Click(object sender, EventArgs e)
        {
            FormExcessLoadParam form1 = new FormExcessLoadParam();
            form1.SqlSettings = (this.SqlSettings);
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }
        /// <summary>
        /// отчет Коэфициент загрузки
        /// </summary>
        private void tsmiCoefficientLoading_Click(object sender, EventArgs e)
        {
            FormCoefficientLoadihgParam form1 = new FormCoefficientLoadihgParam();
            form1.SqlSettings = (this.SqlSettings);
            //form1.setReportType(ReportType.CoefficientLoading);
            form1.ReportType = ReportType.CoefficientLoading;
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }
        /// <summary>
        /// отчет Коэффициент неравномерности
        /// </summary>
        private void tsmiCoefficientIrregularity_Click(object sender, EventArgs e)
        {
            FormCoefficientLoadihgParam form1 = new FormCoefficientLoadihgParam();
            form1.SqlSettings = (this.SqlSettings);
            //form1.setReportType(ReportType.CoefficientIrregularity);
            form1.ReportType = ReportType.CoefficientIrregularity;
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }
        /// <summary>
        /// Развернуть ветку дерева  по элементно (подстанцию по ячейкам например)
        /// </summary>
        private void tsmiMeas_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            int tag = (int)item.Tag;
            ToolStripMenuItem item2 = (tag == 1) ? this.tsmiMeasHigh : ((tag == 2) ? this.tsmiMeasLow : null);
            if (item.Checked == item2.Checked)
            {
                item2.Checked = !item.Checked;
            }
            if ((item != null) && item.Checked)
            {
                this.bsTypeDoc.Position = this.bsTypeDoc.Find("Value", tag);
                this.tssbMeasType.Text = item.Checked ? item.Text : item2.Text;
                this.typeDoc_1 = (((decimal)((DataRowView)this.bsTypeDoc.Current)["Value"]) == decimal.One) 
                    ? TypeDoc.LowMeasurement : ((((decimal)((DataRowView)this.bsTypeDoc.Current)["Value"]) == 2M) 
                    ? TypeDoc.HighMeasurement : TypeDoc.None);
                // какая то хрень
                this.idTypeDoc = this.GetIdTypeDoc(this.typeDoc_1);
                this.TypeDocSwitches(this.typeDoc_1);
                if (this.fillTree == FormDockPassport.FillTree.All)
                {
                    int idSubstation = this.GetIdSubstation();
                    this.RefreshTree(this.sort_0, this.typeDoc_1);
                    if (idSubstation != -1)
                    {
                        List<TreeNode> list = new List<TreeNode>();
                        list = this.AddNodeInList(this.treeView.Nodes, list);
                        TreeNode node = this.SearchNode(list, idSubstation);
                        if (node != null)
                        {
                            this.treeView.Focus();
                            this.treeView.SelectedNode = node;
                            this.treeView.SelectedNode.Expand();
                        }
                    }
                }
                else
                {
                    this.RefreshTree(this.sort_0, this.idObjList, this.typeDoc_1);
                }
                this.FillYearComboBox(this.idTypeDoc);
                this.typeDoc_0 = this.typeDoc_1;
            }
        }
        /// <summary>
        /// Отчет Объем свободной мощности
        /// </summary>
        private void toolStripMenuItemVolumeFreeEnergy_Click(object sender, EventArgs e)
        {
            FormAmountFreeCapacity form1 = new FormAmountFreeCapacity
            {
                MdiParent = base.MdiParent
            };
            form1.SqlSettings = (this.SqlSettings);
            form1.Show();
        }
        /// <summary>
        /// отчет Наличие замеров
        /// </summary>
        private void toolStripMenuItemMeasExist_Click(object sender, EventArgs e)
        {
            int num = (this.toolStripComboBoxtoolStripComboBoxMeasYear.ComboBox.SelectedValue is int) ? ((int)this.toolStripComboBoxtoolStripComboBoxMeasYear.ComboBox.SelectedValue) : -1;
            new FormMeasurementExistYearForm(this.SqlSettings, num)
            {
                MdiParent = base.MdiParent
            }.Show();
        }

        private void toolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                List<TreeNode> list = new List<TreeNode>();
                list = this.AddNodeInList(this.treeView.Nodes, list);
                TreeNode node = this.SearchNode(list, this.toolStripTextBox_0.Text);
                if (node != null)
                {
                    this.treeView.SelectedNode = node;
                    this.treeView.SelectedNode.Expand();
                }
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.IdBusSchema = -1;
            this.IdTransfSchema = -1;
            TreeObject tag = (TreeObject)e.Node.Tag;
            if (tag.TypeNode == TypeNode.Substation)
            {
                //{
                //    goto Label_00B6;
                //}
                /*
                if (this.objListPassport != null)
                {
                    tag = (TreeObject)e.Node.Tag;
                    if (this.objListPassport.Id == tag.idSub)
                    {
                        goto Label_008D;
                    }
                }
                this.objListPassport = new ObjList(this.SqlSettings);
                tag = (TreeObject)e.Node.Tag;
                this.objListPassport.Id = (tag.idSub);

                Label_008D:
                this.subSelected = (this.objListPassport.Id == this.idSubstationTemp) ? SelectedSubstation.Current : SelectedSubstation.Other;
                this.FillYearComboBox(this.idTypeDoc);
                */
                if (this.objListPassport == null)
                {
                    this.objListPassport = new ObjList(this.SqlSettings);
                    this.objListPassport.Id = tag.idSub;
                }
                if (this.objListPassport.Id == tag.idSub)
                {
                    this.subSelected = (this.objListPassport.Id == this.idSubstationTemp) ? SelectedSubstation.Current : SelectedSubstation.Other;
                    this.FillYearComboBox(this.idTypeDoc);
                }
            }
            //Label_00B6:
            //tag = (TreeObject)e.Node.Tag;
            else
            if (tag.TypeNode == TypeNode.Bus)
            {
                /*tag = (TreeObject)e.Node.Tag; */    this.IdBusSchema = tag.idBus;
                /*tag = (TreeObject)e.Node.Tag; */    this.IdTransfSchema = tag.idTransf;
                /*tag = (TreeObject)e.Node.Tag; */    this.nameTransf = tag.NameTransf;

                if ((this.objListPassport == null) || (this.objListPassport.Id != this.IdBusSchema))
                {
                    this.objListPassport = new ObjList(this.SqlSettings);
                    this.objListPassport.Id = (this.IdBusSchema);
                }
                this.subSelected = (this.objListPassport.IdParent == this.idSubstationTemp) ? SelectedSubstation.Current : SelectedSubstation.Other;
                if (this.subSelected == SelectedSubstation.Other)
                {
                    this.FillYearComboBox(this.idTypeDoc);
                }
                if (this.bsBusesTransfs.Count == 0)
                {
                    this.bsBusesTransfLV_CurrentChanged(this.bsBusesTransfs, new EventArgs());
                }
                else
                {
                    int posBusTransf = -1;
                    this.bsBusesTransfs.RaiseListChangedEvents = false;
                    this.bsBusesTransfs.CurrentChanged -= new EventHandler(this.bsBusesTransfLV_CurrentChanged);
                    int posTransf = -1;
                    if (this.IdTransfSchema != -1)
                    {
                        posTransf = this.bsBusesTransfs.Find("idTransf", this.IdTransfSchema);
                        if (posTransf == -1)
                        {
                            DataTable table = base.SelectSqlData("vJ_MeasByBusTransf", true, string.Format("WHERE Year = {0} AND idBus = {1} AND idObjList = {2}", (int)((DataRowView)this.bsMeasYear.Current)["Year"], this.IdBusSchema, this.IdTransfSchema));
                            if (table.Rows.Count > 0)
                            {
                                posBusTransf = this.bsMeasurement.Find("id", (int)table.Rows[0]["id"]);
                                this.bsMeasurement.Position = posBusTransf;
                            }
                            if (posBusTransf == -1)
                            {
                                posTransf = this.bsBusesTransfs.Find("idBus", this.IdBusSchema);
                            }
                        }
                    }
                    else
                    {
                        posTransf = this.bsBusesTransfs.Find("idBus", this.IdBusSchema);
                    }
                    if (posTransf != -1)
                    {
                        this.bsBusesTransfs.Position = posTransf;
                    }
                    this.bsBusesTransfs.CurrentChanged += new EventHandler(this.bsBusesTransfLV_CurrentChanged);
                    this.bsBusesTransfs.RaiseListChangedEvents = false;
                    this.bsBusesTransfLV_CurrentChanged(this.bsBusesTransfs, new EventArgs());
                }
            }


        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeObject tag = (TreeObject)e.Node.Tag;
            if (tag.TypeNode == TypeNode.Substation)
            {
                this.treeView.BeginUpdate();
                e.Node.Nodes.Clear();
                string str = (this.typeDoc_1 == TypeDoc.LowMeasurement) ? ";SCM;BUS;BUSLV;" : ((this.typeDoc_1 == TypeDoc.HighMeasurement) ? ";SCM;BUS;BUSMV;" : "");
                tag = (TreeObject)e.Node.Tag;
                base.SelectSqlData(this.dsJournal, this.dsJournal.vJ_BusesTransfSchema, true, string.Format("WHERE idSub = {0} AND parentKeyBus = '{1}' ORDER By NameTransf", tag.idSub, str));
                // foreach (DataSetGES.Class121 class2 in this.dsJournal.vJ_BusesTransfSchema)
                foreach (DataSetMeasurementN.vJ_BusesTransfSchemaRow current in this.dsJournal.vJ_BusesTransfSchema)
                {
                    TreeNode node = new TreeNode();
                    TreeObject obj3 = new TreeObject
                    {
                        TypeNode = TypeNode.Bus,
                        idSub = current.idSub,
                        idBus = current.idBus,
                        idTransf = current.idTransf,
                        NameTransf = current.NameTransf
                    };
                    node.Text = current.nameBusTransf;
                    node.Tag = obj3;
                    e.Node.Nodes.Add(node);
                }
                this.treeView.EndUpdate();
            }
        }



    
        /// <summary>
        /// Статус выбора подстанции
        /// </summary>
        private enum SelectedSubstation
        {
            Current,
            Other
        }

        /// <summary>
        /// Тип документа
        /// </summary>
        public enum TypeDoc
        {
            /// <summary>
            /// по высокой стороне
            /// </summary>
            HighMeasurement = 2,
            /// <summary>
            /// по низкой стороне
            /// </summary>
            LowMeasurement = 1,  
            None = -1
        }
    }

    
}


