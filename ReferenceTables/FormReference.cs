using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using Reference;
using SchemeModelN;
using SchemeModelN.Calculations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reference
{

    public partial class FormReference : FormLbr.FormBase
    {
        public FormReference()
        {


            InitializeComponent();
            this.cmbVedomosty = new System.Windows.Forms.ComboBox();
            this.cmbVedomosty.Name = "cmbStatusSendME1";
            this.cmbVedomosty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVedomosty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVedomosty.Size = new System.Drawing.Size(121, 25);
            this.cmbVedomosty.FormattingEnabled = true;
            //this.cmbStatusSendME1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.toolStrip.Items.Insert(toolStrip.Items.Count, new ToolStripControlHost(this.cmbVedomosty));

            this.dateTimePeriodKWT = new DateTimePicker
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F),
                Width = 120,
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "MMMM yyyy",
                Value = DateTime.Now.AddMonths(-1)
            };

            int num = 0;
            foreach (var enumerator in this.toolStrip.Items)
            {
                {
                    if ((ToolStripItem)enumerator == this.toolLabelPeriodKWT)
                    {
                        break;
                    }
                    num++;
                }
            }
            this.toolStrip.Items.Insert(num + 1, new ToolStripControlHost(this.dateTimePeriodKWT));
            this.Activate();
        }

        private void toolBtnLoad_Click(object sender, EventArgs e)
        {
            if (this.tabGeneral.SelectedTab == this.tabVedomosty)
            {
                dgvResultat.Columns.Clear();
                DataTable tableResult = new DataTable();
                switch (this.cmbVedomosty.SelectedIndex)
                {
                    case (0) /*Абоненты*/:
                        {
                            tableResult.TableName ="vL_SchmAbnFull";
                            Reference.Tables.LoadTableSChmAbnFull_2019(tableResult, this.SqlSettings, DateTime.Now);
                            tableResult.Columns.Add("SubNameFull", System.Type.GetType("System.String"));
                            tableResult.Columns.Add("CPName", System.Type.GetType("System.String"));
                            tableResult.Columns.Add("CellCPName", System.Type.GetType("System.String"));

                            ElectricModel electricModel = new ElectricModel();
                            electricModel.SqlSettings = this.SqlSettings;
                            electricModel.LoadSchema(true);

                            int? idSchmObj = null;
                            foreach (DataRow row in tableResult.Rows)
                            //foreach (DataRow row in tableSchmAbnFull.Select("idSchmObj = 775394"))
                            {
                                try
                                {
                                    if (row["idSchmObj"] != DBNull.Value)
                                    {
                                        var SubStation = electricModel.GetParamsElectricObjectById((int)row["subid"]);
                                        row["SubNameFull"] = SubStation.ElectricSubName;

                                        idSchmObj = (int)row["idSchmObj"];
                                        var listSchmObj = electricModel.GetCellCP((int)idSchmObj);
                                        if (listSchmObj.Length > 0)
                                        {
                                            row["CPName"] = listSchmObj[0].ElectricSubName;
                                            row["CellCPName"] = listSchmObj[0].electricLine.ToString();
                                        }
                                    }
                                }
                                catch //(Exception ex)
                                {
                                    // MessageBox.Show(ex.ToString() + ": " + idSchmObj.ToString(), "Ошибка",MessageBoxButtons.OK);
                                }

                            }

                            break;
                        }
                    case 1:
                        {
                            References.SchemeTables.GetTransformerSchmObj(tableResult, SqlSettings);
                            break;
                        }
                    case 2:
                        {
                            References.SchemeTables.GetReferensTable(tableResult, "SqlScripts.SchmCellAll", SqlSettings);
                            break;
                        }
                    case 3:
                        {
                            References.SchemeTables.GetReferensTable(tableResult, "SqlScripts.SchmLineCellAll-2", SqlSettings);
                            break;
                        }
                    case 4:
                        {
                            tableResult.TableName = "tR_RequestForRepairClient";
                            base.SelectSqlData(tableResult, true, " ORDER BY Type, IsDefault DESC, Name", null, false, 0);
                            break;
                        }

                }
                //// заполним dgvResultat
                //// можно и без цикла обойтись, но это чтобы колонки с фильтром появились
                foreach (DataColumn col in tableResult.Columns)
                {
                    DataGridViewFilterTextBoxColumn columnDgv = new DataGridViewFilterTextBoxColumn();
                    columnDgv.Name = col.ColumnName;
                    columnDgv.HeaderText = col.ColumnName;
                    columnDgv.DataPropertyName = col.ColumnName;

                    dgvResultat.Columns.Add(columnDgv);

                }
                BindingSource bsResult = new BindingSource();
                bsResult.DataSource = tableResult;
                dgvResultat.DataSource = bsResult;
            }
        }
        private void FillComboBoxVedomocty()
        {
            this.cmbVedomosty.Items.Add("Абоненты (нормальная схема)"); // 0 
            this.cmbVedomosty.Items.Add("Журнал трансформаторов (полная схема)"); // 1
            this.cmbVedomosty.Items.Add("Список ячеек"); // 2
            this.cmbVedomosty.Items.Add("Справочник всех линий и ячеек схемы"); // 3
            this.cmbVedomosty.Items.Add("Справочник. Классификаторы РИЦ"); // 4
            //this.cmbVedomosty.Items.Add("Справочник. ТОК-5. Реестр точек измерения"); // 5
            this.cmbVedomosty.SelectedIndex = 0;
            //this.cmbVedomosty.SelectionLength = 0;

            Library.Controls.GetDropDownWidth(this, cmbVedomosty);

        }
        private void toolBtnExportExcel_Click(object sender, EventArgs e)
        {
            if (this.tabGeneral.SelectedTab == this.tabVedomosty)
                this.dgvResultat.ExportToExcel();

        }

        private void toolBtnRefresh_Click(object sender, EventArgs e)
        {
            //
        }

        private void FormCorrectiveStatements_Load(object sender, EventArgs e)
        {
            FillComboBoxVedomocty();
            Library.Controls.ControlSelectionLengthComboBox(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }

        private void dgvSendME_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                e.Cancel = true;
            }
        }

        private void toolBtnSend_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
