//extern alias report12;
//using RP = report12::Microsoft.Reporting.WinForms;
using RP = Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataSql;
using DailyReportN.DataSet;
using System.ComponentModel;

namespace DailyReportN.JournalActDetection
{
    /// <summary>
    /// печать акта расследования
    /// </summary>
    public partial class FormReportActDetection : FormLbr.FormBase
    {

        FormActDetectionAddEdit frmOwner;
        internal FormActDetectionAddEdit FormParent { get; set; }
        internal DataTable TableResult { get; set; }

        public FormReportActDetection()
        {
            InitializeComponent();
        }

        private void FormReportActDetection_Load(object sender, EventArgs e)
        {
            if (this.FormParent.GetType() == typeof(FormActDetectionAddEdit))
            {
                frmOwner = (FormActDetectionAddEdit)this.FormParent;

                this.Text = "Акт расследования причин аварии, произошедшей №" + frmOwner.txtNumCrash.Text.ToString() + " от " + frmOwner.dtpDateOwner.Text.ToString();

                FillReport();
            }
            else
            {
                MessageBox.Show("Некорректная форма вызова для печатной формы!");
            }
        }

        private void FillReport()
        {
            RP.ReportViewer reportViewerRus = new RP.ReportViewer();
            //reportViewerRus.LocalReport.ReportEmbeddedResource = "DailyReportN.ActDetection.ReportActDetection.rdlc";
            reportViewerRus.LocalReport.ReportEmbeddedResource = "DailyReportN.ActDetection.ReportActDetectionN.rdlc";
            reportViewerRus.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewerRus);
            //this.tabPagePrint.Controls.Clear();
            //this.tabPagePrint.Controls.Add(reportViewerRus);
            reportViewerRus.ReportRefresh += new System.ComponentModel.CancelEventHandler(reportViewerRus_ReportRefresh) ;

            RP.ReportDataSource reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "dsDamage";
            reportDataSource.Value = frmOwner.bsDamage;
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);

            reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "dsActDetection";
            reportDataSource.Value = new BindingSource
            {
                DataSource = frmOwner.dataSetDamage.tJ_DamageActDetection
            };
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);


            List<RP.ReportParameter> list = new List<RP.ReportParameter>();
            List<RP.ReportParameter> listSpec = new List<RP.ReportParameter>(); //для осоого мнения комиссии 
            if (frmOwner.cmbOrg.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("Org", ((DataRowView)frmOwner.cmbOrg.SelectedItem).Row["name"].ToString()));
            }
            if (frmOwner.cmbOrgCrashEq.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("OrgCrashEq", ((DataRowView)frmOwner.cmbOrgCrashEq.SelectedItem).Row["name"].ToString()));
            }
            if (frmOwner.cmbOrgCrash.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("OrgCrash", ((DataRowView)frmOwner.cmbOrgCrash.SelectedItem).Row["name"].ToString()));
            }
            if (frmOwner.cmbSignCrash.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("signCrashCode", ((DataRowView)frmOwner.cmbSignCrash.SelectedItem).Row["name"].ToString()));
                list.Add(new RP.ReportParameter("signCrash", ((DataRowView)frmOwner.cmbSignCrash.SelectedItem).Row["comment"].ToString()));
            }
            if (frmOwner.cmbTypeEquipment.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("typeEquipmentCode", ((DataRowView)frmOwner.cmbTypeEquipment.SelectedItem).Row["name"].ToString()));
                list.Add(new RP.ReportParameter("typeEquipment", ((DataRowView)frmOwner.cmbTypeEquipment.SelectedItem).Row["comment"].ToString()));
            }
            if (frmOwner.cmbReasonCrashEquipment.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("reasonCrashEqCode", ((DataRowView)frmOwner.cmbReasonCrashEquipment.SelectedItem).Row["name"].ToString()));
                list.Add(new RP.ReportParameter("reasonCrashEq", ((DataRowView)frmOwner.cmbReasonCrashEquipment.SelectedItem).Row["comment"].ToString()));
            }
            if (frmOwner.cmbReasonCrash.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("reasonCrashCode", ((DataRowView)frmOwner.cmbReasonCrash.SelectedItem).Row["name"].ToString()));
                list.Add(new RP.ReportParameter("reasonCrash", ((DataRowView)frmOwner.cmbReasonCrash.SelectedItem).Row["comment"].ToString()));
            }
            list.Add(new RP.ReportParameter("schmObj", frmOwner.txtSchmObj.Text));
            //if (frmOwner.cmbStatusBeforeCrash.SelectedIndex >= 0)
            //{
            //    list.Add(new RP.ReportParameter("statusBeforeCrash", ((DataRowView)frmOwner.cmbStatusBeforeCrash.SelectedItem).Row["comment"].ToString()));
            //}
            if (!string.IsNullOrEmpty(frmOwner.txtStatusBeforeCrash.Text))
            {
                list.Add(new RP.ReportParameter("statusBeforeCrash", frmOwner.txtStatusBeforeCrash.Text));
            }
            else if (frmOwner.cmbStatusBeforeCrash.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("statusBeforeCrash", ((DataRowView)frmOwner.cmbStatusBeforeCrash.SelectedItem).Row["comment"].ToString()));
            }


            if (!string.IsNullOrEmpty(frmOwner.txtStatusCurrentCrash.Text))
            {
                list.Add(new RP.ReportParameter("statusCurrentCrash", frmOwner.txtStatusCurrentCrash.Text));
            }
            else if (frmOwner.cmbStatusCurrentCrash.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("statusCurrentCrash", ((DataRowView)frmOwner.cmbStatusCurrentCrash.SelectedItem).Row["comment"].ToString()));
            }
            //23
            reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "ds23";
            BindingSource bs23 = new BindingSource();
            bs23.DataSource = frmOwner.dataSetDamage.table23;
            frmOwner.dataSetDamage.table23.Clear();
            foreach (DataGridViewRow dataGridViewRow in frmOwner.dgvDefection.Rows)
            {
                DataRow dataRow = frmOwner.dataSetDamage.table23.NewRow();
                dataRow["Description"] = dataGridViewRow.Cells[frmOwner.idDefectionDataGridViewTextBoxColumn.Name].FormattedValue.ToString();
                dataRow["NPA"] = dataGridViewRow.Cells[frmOwner.idNPADgvColumn.Name].FormattedValue.ToString();
                if (dataGridViewRow.Cells[frmOwner.punctNPADataGridViewTextBoxColumn.Name].Value != null)
                {
                    dataRow["punktNPA"] = dataGridViewRow.Cells[frmOwner.punctNPADataGridViewTextBoxColumn.Name].Value.ToString();
                }
                dataRow["Org"] = dataGridViewRow.Cells[frmOwner.idOrgDefectionDgvColumn.Name].FormattedValue.ToString();
                frmOwner.dataSetDamage.table23.Rows.Add(dataRow);
            }
            if (frmOwner.dataSetDamage.table23.Rows.Count > 0)
            {
                frmOwner.dataSetDamage.table23.Rows.RemoveAt(frmOwner.dataSetDamage.table23.Rows.Count - 1);
            }
            reportDataSource.Value = bs23;
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
            if (!string.IsNullOrEmpty(frmOwner.txtReasonBeginCrash.Text))
            {
                list.Add(new RP.ReportParameter("reasonBeginCrash", frmOwner.txtReasonBeginCrash.Text));
            }
            else if (frmOwner.cmbReasonBeginCrash.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("reasonBeginCrashCode", ((DataRowView)frmOwner.cmbReasonBeginCrash.SelectedItem).Row["name"].ToString()));
                list.Add(new RP.ReportParameter("reasonBeginCrash", ((DataRowView)frmOwner.cmbReasonBeginCrash.SelectedItem).Row["comment"].ToString()));
            }
            //if (frmOwner.cmbClassifierDamage.SelectedIndex >= 0)
            //{
            //    list.Add(new RP.ReportParameter("classifierDamage", ((DataRowView)frmOwner.cmbClassifierDamage.SelectedItem).Row["name"].ToString()));
            //}
            //if (frmOwner.cmbFault.SelectedIndex >= 0)
            //{
            //    list.Add(new RP.ReportParameter("fault", ((DataRowView)frmOwner.cmbFault.SelectedItem).Row["name"].ToString()));
            //}
            if (!string.IsNullOrEmpty(frmOwner.txtClassifierDamage.Text))
            {
                list.Add(new RP.ReportParameter("classifierDamage", frmOwner.txtClassifierDamage.Text));
            }
            else if (frmOwner.cmbClassifierDamage.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("classifierDamage", ((DataRowView)frmOwner.cmbClassifierDamage.SelectedItem).Row["name"].ToString()));
            }
            if (!string.IsNullOrEmpty(frmOwner.txtFault.Text))
            {
                list.Add(new RP.ReportParameter("fault", frmOwner.txtFault.Text));
            }
            else if (frmOwner.cmbFault.SelectedIndex >= 0)
            {
                list.Add(new RP.ReportParameter("fault", ((DataRowView)frmOwner.cmbFault.SelectedItem).Row["name"].ToString()));
            }
            //31
            reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "ds31";
            BindingSource bs31 = new BindingSource();
            bs31.DataSource = frmOwner.dataSetDamage.table31;
            frmOwner.dataSetDamage.table31.Clear();
            foreach (DataGridViewRow dataGridViewRow2 in (frmOwner.dgvNoCrashMeasure.Rows))
            {
                DataRow dataRow2 = frmOwner.dataSetDamage.table31.NewRow();
                dataRow2["Measure"] = dataGridViewRow2.Cells[frmOwner.idNoCrashMeasureColumn.Name].FormattedValue.ToString();
                if (dataGridViewRow2.Cells[frmOwner.dateCompleteDataGridViewTextBoxColumn.Name].Value != null && dataGridViewRow2.Cells[frmOwner.dateCompleteDataGridViewTextBoxColumn.Name].Value != DBNull.Value)
                {
                    dataRow2["date"] = Convert.ToDateTime(dataGridViewRow2.Cells[frmOwner.dateCompleteDataGridViewTextBoxColumn.Name].Value).ToString("MMMM yyyy");
                }
                dataRow2["Org"] = dataGridViewRow2.Cells[frmOwner.idOrgColumn.Name].FormattedValue.ToString();
                frmOwner.dataSetDamage.table31.Rows.Add(dataRow2);
            }
            if (frmOwner.dataSetDamage.table31.Rows.Count > 0)
            {
                frmOwner.dataSetDamage.table31.Rows.RemoveAt(frmOwner.dataSetDamage.table31.Rows.Count - 1);
            }
            reportDataSource.Value = bs31;
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);

            //13 (начало) отказавшее оборудование в приложении
            frmOwner.dataSetDamage.table13.Clear();

            #region Отказавшее оборудование
            //4 отказавшее оборудование в акте
            reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "ds4";
            BindingSource bs4 = new BindingSource();
            bs4.DataSource = frmOwner.dataSetDamage.table4;
            frmOwner.dataSetDamage.table4.Clear();
            int num = 1;

            for (int i = 0; i < frmOwner.dataSetDamage.tJ_DamageCharacter.Rows.Count; i++)
            {
                DataRow dataRow3 = frmOwner.dataSetDamage.tJ_DamageCharacter.Rows[i];
                if (dataRow3.RowState != DataRowState.Deleted)
                {
                    DataRow dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    DataRow dataRow13 = frmOwner.dataSetDamage.table13.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Отказавшее оборудование: ";
                    dataRow4["Description"] += frmOwner.dgvEquipment[frmOwner.typeEquipmentDgvColumn.Name, i].FormattedValue.ToString();
                    dataRow13["Description"] = frmOwner.dgvEquipment[frmOwner.typeEquipmentDgvColumn.Name, i].FormattedValue.ToString();
                    if (frmOwner.dgvEquipment[frmOwner.schmObjDgvColumn.Name, i].Value != null)
                    {
                        dataRow4["Description"] += "   " + frmOwner.dgvEquipment[frmOwner.schmObjDgvColumn.Name, i].Value.ToString();
                        dataRow13["Description"] += "   " + frmOwner.dgvEquipment[frmOwner.schmObjDgvColumn.Name, i].Value.ToString();
                    }
                    if (frmOwner.dgvEquipment[frmOwner.schmObjNameDgvColumn.Name, i].Value != null)
                    {
                        dataRow4["Description"] += "   " + frmOwner.dgvEquipment[frmOwner.schmObjNameDgvColumn.Name, i].Value.ToString();
                        dataRow13["Description"] += "   " + frmOwner.dgvEquipment[frmOwner.schmObjNameDgvColumn.Name, i].Value.ToString();
                    }
                    //dataRow13["Description"] = dataRow4["Description"];
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    frmOwner.dataSetDamage.table13.Rows.Add(dataRow13);

                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Марка: ";
                    if (dataRow3["idMark"] != DBNull.Value && dataRow3["col1"] != DBNull.Value)
                    {
                        DataTable dataTable = Reference.Tables.TableClassifier(null);
                        base.SelectSqlData(dataTable, true, " where id = " + dataRow3["col1"].ToString(), null, false, 0);
                        if (dataTable.Rows.Count > 0)
                        {
                            string a = dataTable.Rows[0]["ParentKey"].ToString();
                            if (!(a == ";ReportDaily;NatureDamage;HV;AirLine;") && !(a == ";ReportDaily;NatureDamage;HV;CableLine;")
                                && !(a == ";ReportDaily;NatureDamage;LV;Code1;") && !(a == ";ReportDaily;NatureDamage;LV;Code4;"))
                            {
                                if (!(a == ";ReportDaily;NatureDamage;HV;Subs;")&& !(a == ";ReportDaily;NatureDamage;LV;Code2;"))
                                {
                                    if (a == ";ReportDaily;NatureDamage;HV;Transformer;")
                                    {
                                        DataTable dataTable2 = new SqlDataCommand(frmOwner.SqlSettings).SelectSqlData("select id, name + \r\n                                                                isnull('/' + convert(varchar(20), convert(float, highVoltage)), '') as name\r\n                                                                from tR_Transformer \r\n                                                                where id = " + dataRow3["idMark"].ToString() + " order by name, highvoltage");
                                        if (dataTable2.Rows.Count > 0)
                                        {
                                            dataRow4["Description"] = dataRow4["Description"].ToString() + dataTable2.Rows[0]["Name"].ToString();
                                        }
                                    }
                                }
                                else
                                {
                                    DataTable dataTable3 = new SqlDataCommand(frmOwner.SqlSettings).SelectSqlData("select id, Name\r\n                                                                from tP_ValueLists\r\n                                                                where ParentKey = ';SubstationType;' and isGRoup = 0 and deleted = 0\r\n                                                                    and id = " + dataRow3["idMark"].ToString() + " order by name");
                                    if (dataTable3.Rows.Count > 0)
                                    {
                                        dataRow4["Description"] = dataRow4["Description"].ToString() + dataTable3.Rows[0]["Name"].ToString();
                                    }
                                }
                            }
                            else
                            {
                                DataTable dataTable4 = new SqlDataCommand(frmOwner.SqlSettings).SelectSqlData("select id, CableMakeup + ' ' + cast(wires as varchar(8)) + 'x' + \r\n                                            convert(varchar(20), convert(float, CrossSection)) as name from tr_Cable \r\n                                            where id = " + dataRow3["idMark"].ToString() + " order by CableMakeup, wires, CrossSection");
                                if (dataTable4.Rows.Count > 0)
                                {
                                    dataRow4["Description"] = dataRow4["Description"].ToString() + dataTable4.Rows[0]["Name"].ToString();
                                }
                            }
                        }
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Параметры: ";
                    if (dataRow3["idParameters"] != DBNull.Value)
                    {
                        DataRow[] array = frmOwner.tblClassifier.Select("id = " + dataRow3["idParameters"].ToString());
                        if (array.Length != 0)
                        {
                            dataRow4["Description"] = dataRow4["Description"].ToString() + array[0]["Name"].ToString();
                        }
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Конструктивное напряжение: ";
                    if (dataRow3["idVoltage"] != DBNull.Value)
                    {
                        DataRow[] array2 = frmOwner.tblClassifier.Select("id = " + dataRow3["idVoltage"].ToString());
                        if (array2.Length != 0)
                        {
                            dataRow4["Description"] = dataRow4["Description"].ToString() + array2[0]["Name"].ToString();
                        }
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Узел, деталь: ";
                    if (dataRow3["NodeDetail"] != DBNull.Value)
                    {
                        DataRow[] array3 = frmOwner.tblClassifier.Select("id = " + dataRow3["NodeDetail"].ToString());
                        if (array3.Length != 0)
                        {
                            dataRow4["Description"] = dataRow4["Description"].ToString() + array3[0]["Name"].ToString();
                        }
                    }
                    if (dataRow3["NodeDetailTxt"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + " " + dataRow3["NodeDetailTxt"].ToString();
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Количество отказавшего оборудования, узлов: ";
                    if (dataRow3["CountDefectEquipment"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["CountDefectEquipment"].ToString();
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Напряжение сети: ";
                    if (dataRow3["idVoltageSeti"] != DBNull.Value)
                    {
                        DataRow[] array4 = frmOwner.tblClassifier.Select("id = " + dataRow3["idVoltageSEti"].ToString());
                        if (array4.Length != 0)
                        {
                            dataRow4["Description"] = dataRow4["Description"].ToString() + array4[0]["Name"].ToString();
                        }
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Изготовитель оборудования или повредившегося узла: ";
                    if (dataRow3["Manufacturer"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["Manufacturer"].ToString();
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Заводской номер: ";
                    if (dataRow3["FactoryNumber"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["FactoryNumber"].ToString();
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Год изготовления оборудования: ";
                    if (dataRow3["YearManufacture"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["YearManufacture"].ToString() + "г.";
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Состояние нейтрали: ";
                    if (dataRow3["idNeutralState"] != DBNull.Value)
                    {
                        DataRow[] array5 = frmOwner.tblClassifier.Select("id = " + dataRow3["idNeutralState"].ToString());
                        if (array5.Length != 0)
                        {
                            dataRow4["Description"] = dataRow4["Description"].ToString() + array5[0]["Name"].ToString();
                        }
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Условия отказа оборудования, % относительная нагрузка кабеля, число цепей ВЛ: ";
                    if (dataRow3["ClauseFail"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["ClauseFail"].ToString();
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Продолжительность работы оборудования с перегрузкой: ";
                    if (dataRow3["LengthOverload"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["LengthOverload"].ToString();
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Длина КЛ, ВЛ, м: ";
                    if (dataRow3["LengthLine"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["LengthLine"].ToString();
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Материал: ";
                    if (dataRow3["idMaterial"] != DBNull.Value)
                    {
                        DataRow[] array6 = frmOwner.tblClassifier.Select("id = " + dataRow3["idMaterial"].ToString());
                        if (array6.Length != 0)
                        {
                            dataRow4["Description"] = dataRow4["Description"].ToString() + array6[0]["Name"].ToString();
                        }
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Условия работы: ";
                    if (dataRow3["ClauseWork"] != DBNull.Value)
                    {
                        DataRow[] array7 = frmOwner.tblClassifier.Select("id = " + dataRow3["ClauseWork"].ToString());
                        if (array7.Length != 0)
                        {
                            dataRow4["Description"] = dataRow4["Description"].ToString() + array7[0]["Name"].ToString();
                        }
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Характер повреждения: ";
                    if (frmOwner.cmbClassifierDamage.SelectedIndex >= 0)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + ((DataRowView)frmOwner.cmbClassifierDamage.SelectedItem).Row["name"].ToString();
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Причина повреждения: ";
                    if (frmOwner.cmbReasonBeginCrash.SelectedIndex >= 0)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + ((DataRowView)frmOwner.cmbReasonBeginCrash.SelectedItem).Row["comment"].ToString().ToLower();
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Сопутствующие обстоятельства: ";
                    if (dataRow3["AssociatedFact"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["AssociatedFact"].ToString();
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Срок службы оборудования от последнего капительного ремонта:\r\n \t\t 1) Начало эксплуатации: ";
                    if (dataRow3["yearBegEquipment"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["yearBegEquipment"].ToString() + "г.";
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Срок службы поврежденного узла: ";
                    if (dataRow3["lenghtWorkEquipment"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["lenghtWorkEquipment"].ToString() + " " + CreateActDetection.GetDeclineYears(Convert.ToInt32(dataRow3["lenghtWorkEquipment"]));
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Последние эксплуатационные испытания: ";
                    if (dataRow3["LastDateTest"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + Convert.ToDateTime(dataRow3["LastDateTest"]).ToString("yyyy") + "г.";
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                    dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "4." + num.ToString() + ".";
                    dataRow4["Description"] = "Дата восстановления: ";
                    if (dataRow3["timeRecovery"] != DBNull.Value)
                    {
                        dataRow4["Description"] = dataRow4["Description"].ToString() + Convert.ToDateTime(dataRow3["timeRecovery"]).ToString("dd.MM.yyyy") + "г.";
                    }
                    frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
                    num++;
                }
            }
            // если оборудования нет
            if (this.dataSetDamage.table4.Rows.Count == 0)
            {
                DataRow dataRow4 = frmOwner.dataSetDamage.table4.NewRow();
                dataRow4["num"] = "";
                dataRow4["Description"] = "В сетях МУП \"Ульяновская городская электросеть\" отказавшее оборудование отсутствует ";
                frmOwner.dataSetDamage.table4.Rows.Add(dataRow4);
            }
            reportDataSource.Value = bs4;
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
            
            #endregion
            #region Комиссия - начало
            list.Add(new RP.ReportParameter("Order", frmOwner.txtOrder.Text));
            string isMembersSpecYes = "";
            if (frmOwner.cmbChairman.SelectedIndex >= 0)
            {
                string text = ((DataRowView)frmOwner.cmbChairman.SelectedItem).Row["fio"].ToString();
                if (!string.IsNullOrEmpty(frmOwner.txtPostChairman.Text))
                {
                    text = text + ", " + frmOwner.txtPostChairman.Text.ToLower();
                }
                list.Add(new RP.ReportParameter("Chairman", text));
                if (frmOwner.chkChairmanSpecial.Checked)
                {
                    RP.ReportParameter rp = new RP.ReportParameter("ChairmanSpec");
                    rp.Values.Add(((DataRowView)frmOwner.cmbChairman.SelectedItem).Row["fio"].ToString()); // fio
                    rp.Values.Add(frmOwner.txtPostChairman.Text.ToLower()); // должность
                    rp.Values.Add(frmOwner.txtChairmanSpecial.Text); // комментарии
                    listSpec.Add(rp);
                    //listSpec.Add(new RP.ReportParameter("ChairmanSpec", text));
                    isMembersSpecYes ="V";
                }
            }
            if (frmOwner.cmbMemberComission1.SelectedIndex >= 0)
            {
                string text2 = ((DataRowView)frmOwner.cmbMemberComission1.SelectedItem).Row["fio"].ToString();
                if (!string.IsNullOrEmpty(frmOwner.txtPostMemeber1.Text))
                {
                    text2 = text2 + ", " + frmOwner.txtPostMemeber1.Text.ToLower();
                }
                list.Add(new RP.ReportParameter("Comission1", text2));
                if (frmOwner.chkMemberComissionSpecial1.Checked)
                {
                    RP.ReportParameter rp = new RP.ReportParameter("ComissionSpec1");
                    rp.Values.Add(((DataRowView)frmOwner.cmbMemberComission1.SelectedItem).Row["fio"].ToString()); // fio
                    rp.Values.Add(frmOwner.txtPostMemeber1.Text.ToLower()); // должность
                    rp.Values.Add(frmOwner.txtMemberPostSpecial1.Text); // комментарии
                    listSpec.Add(rp);
                    //listSpec.Add(new RP.ReportParameter("ComissionSpec1", text2));
                    isMembersSpecYes = "V";
                }
            }
            if (frmOwner.cmbMemberComission2.SelectedIndex >= 0)
            {
                string text3 = ((DataRowView)frmOwner.cmbMemberComission2.SelectedItem).Row["fio"].ToString();
                if (!string.IsNullOrEmpty(frmOwner.txtPostMemeber2.Text))
                {
                    text3 = text3 + ", " + frmOwner.txtPostMemeber2.Text.ToLower();
                }
                list.Add(new RP.ReportParameter("Comission2", text3));
                if (frmOwner.chkMemberComissionSpecial2.Checked)
                {
                    RP.ReportParameter rp = new RP.ReportParameter("ComissionSpec2");
                    rp.Values.Add(((DataRowView)frmOwner.cmbMemberComission2.SelectedItem).Row["fio"].ToString()); // fio
                    rp.Values.Add(frmOwner.txtPostMemeber2.Text.ToLower()); // должность
                    rp.Values.Add(frmOwner.txtMemberPostSpecial2.Text); // комментарии
                    listSpec.Add(rp);
                    //listSpec.Add(new RP.ReportParameter("ComissionSpec2", text3));
                    isMembersSpecYes = "V";
                }
            }
            if (frmOwner.cmbMemberComission3.SelectedIndex >= 0)
            {
                string text4 = ((DataRowView)frmOwner.cmbMemberComission3.SelectedItem).Row["fio"].ToString();
                if (!string.IsNullOrEmpty(frmOwner.txtPostMemeber3.Text))
                {
                    text4 = text4 + ", " + frmOwner.txtPostMemeber3.Text.ToLower();
                }
                list.Add(new RP.ReportParameter("Comission3", text4));
                if (frmOwner.chkMemberComissionSpecial3.Checked)
                {
                    RP.ReportParameter rp = new RP.ReportParameter("ComissionSpec3");
                    rp.Values.Add(((DataRowView)frmOwner.cmbMemberComission3.SelectedItem).Row["fio"].ToString()); // fio
                    rp.Values.Add(frmOwner.txtPostMemeber3.Text.ToLower()); // должность
                    rp.Values.Add(frmOwner.txtMemberPostSpecial3.Text); // комментарии
                    listSpec.Add(rp);
                    //listSpec.Add(new RP.ReportParameter("ComissionSpec3", text4));
                    isMembersSpecYes = "V";
                }
            }
            if (frmOwner.cmbMemberComission4.SelectedIndex >= 0)
            {
                string text5 = ((DataRowView)frmOwner.cmbMemberComission4.SelectedItem).Row["fio"].ToString();
                if (!string.IsNullOrEmpty(frmOwner.txtPostMemeber4.Text))
                {
                    text5 = text5 + ", " + frmOwner.txtPostMemeber4.Text.ToLower();
                }
                list.Add(new RP.ReportParameter("Comission4", text5));
                if (frmOwner.chkMemberComissionSpecial4.Checked)
                {
                    RP.ReportParameter rp = new RP.ReportParameter("ComissionSpec4");
                    rp.Values.Add(((DataRowView)frmOwner.cmbMemberComission4.SelectedItem).Row["fio"].ToString()); // fio
                    rp.Values.Add(frmOwner.txtPostMemeber4.Text.ToLower()); // должность
                    rp.Values.Add(frmOwner.txtMemberPostSpecial4.Text); // комментарии
                    listSpec.Add(rp);
                    //listSpec.Add(new RP.ReportParameter("ComissionSpec4", text5));
                    isMembersSpecYes = "V";
                }
            }
            if (frmOwner.cmbMemberComission5.SelectedIndex >= 0)
            {
                string text6 = ((DataRowView)frmOwner.cmbMemberComission5.SelectedItem).Row["fio"].ToString();
                if (!string.IsNullOrEmpty(frmOwner.txtPostMemeber5.Text))
                {
                    text6 = text6 + ", " + frmOwner.txtPostMemeber5.Text.ToLower();
                }
                list.Add(new RP.ReportParameter("Comission5", text6));
                if (frmOwner.chkMemberComissionSpecial5.Checked)
                {
                    RP.ReportParameter rp = new RP.ReportParameter("ComissionSpec5");
                    rp.Values.Add(((DataRowView)frmOwner.cmbMemberComission5.SelectedItem).Row["fio"].ToString()); // fio
                    rp.Values.Add(frmOwner.txtPostMemeber5.Text.ToLower()); // должность
                    rp.Values.Add(frmOwner.txtMemberPostSpecial5.Text); // комментарии
                    listSpec.Add(rp);
                    isMembersSpecYes = "V";
                }
            }
            list.Add(new RP.ReportParameter("isMembersSpecYes", isMembersSpecYes));

            reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "dsMembersSpec";
            BindingSource bsMembersSpec = new BindingSource();
            bsMembersSpec.DataSource = frmOwner.dataSetDamage.tableMembersSpec;
            frmOwner.dataSetDamage.tableMembersSpec.Clear();
            foreach (RP.ReportParameter element in listSpec)
            {
                DataRow rowS = frmOwner.dataSetDamage.tableMembersSpec.NewRow();
                rowS["Description"] = element.Values[0] + ", " + element.Values[1];
                rowS["Value"] = element.Values[2];
                frmOwner.dataSetDamage.tableMembersSpec.Rows.Add(rowS);
            }
            reportDataSource.Value = bsMembersSpec;
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
            #endregion Комиссия - окончание

            if (frmOwner.cmbCompiler.SelectedIndex >= 0)
            {
                string text7 = ((DataRowView)frmOwner.cmbCompiler.SelectedItem).Row["fio"].ToString();
                if (frmOwner.cmbCompiler.SelectedIndex >= 0)
                {
                    DataTable dataTable5 = new SqlDataCommand(frmOwner.SqlSettings).SelectSqlData("select t.description from tR_JobTitle t \r\n\t                                                    inner join tR_Worker w on t.id = w.jobtitle\r\n                                                        where w.id = " + frmOwner.cmbCompiler.SelectedValue.ToString());
                    if (dataTable5.Rows.Count > 0 && dataTable5.Rows[0]["Description"] != DBNull.Value)
                    {
                        text7 = text7 + ", " + dataTable5.Rows[0]["Description"].ToString().ToLower();
                    }
                }
                list.Add(new RP.ReportParameter("Compiler", text7));
            }
            //reportViewerRus.LocalReport.SetParameters(list);
            //7 Описание действий оперативного персонала (п5)
            reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "ds7";
            BindingSource bs7 = new BindingSource();
            bs7.DataSource = frmOwner.dataSetDamage.table7;
            frmOwner.dataSetDamage.table7.Clear();
            num = 0;
            foreach (DataRow row in frmOwner.dataSetCrash.Tables["dataTablePersonal"].Rows)
            {
                DataRow dataRow7 = frmOwner.dataSetDamage.table7.NewRow();
                num++;  dataRow7["Description"] = "5." + num.ToString() + ". Место работы: " + row["PlaceWork"];
                frmOwner.dataSetDamage.table7.Rows.Add(dataRow7);
                dataRow7 = frmOwner.dataSetDamage.table7.NewRow();
                num++; dataRow7["Description"] = "5." + num.ToString() + ". Должность: " + row["Function"];
                frmOwner.dataSetDamage.table7.Rows.Add(dataRow7);
                dataRow7 = frmOwner.dataSetDamage.table7.NewRow();
                num++; dataRow7["Description"] = "5." + num.ToString() + ". Образование: " + row["Education"];
                frmOwner.dataSetDamage.table7.Rows.Add(dataRow7);
                dataRow7 = frmOwner.dataSetDamage.table7.NewRow();
                num++; dataRow7["Description"] = "5." + num.ToString() + ". Специальность: " + row["Specialty"];
                frmOwner.dataSetDamage.table7.Rows.Add(dataRow7);
                dataRow7 = frmOwner.dataSetDamage.table7.NewRow();
                num++; dataRow7["Description"] = "5." + num.ToString() + ". Обстоятельства ошибки: " + row["CircumstancesError"];
                frmOwner.dataSetDamage.table7.Rows.Add(dataRow7);
                dataRow7 = frmOwner.dataSetDamage.table7.NewRow();
                num++; dataRow7["Description"] = "5." + num.ToString() + ". Причины ошибки: " + row["ReasonError"];
                frmOwner.dataSetDamage.table7.Rows.Add(dataRow7);
                dataRow7 = frmOwner.dataSetDamage.table7.NewRow();
                num++; dataRow7["Description"] = "5." + num.ToString() + ". Стаж работы в данной должности: " + Library.Declension.GetYear(Convert.ToInt32(row["WorkExperience"]));
                frmOwner.dataSetDamage.table7.Rows.Add(dataRow7);
                dataRow7 = frmOwner.dataSetDamage.table7.NewRow();
                num++; dataRow7["Description"] = "5." + num.ToString() + ". Дата последней проверки знаний в объеме требований к занимаемой должности: " + Convert.ToDateTime(row["DateLastCheck"]).ToLongDateString();
                frmOwner.dataSetDamage.table7.Rows.Add(dataRow7);

                //dataRow7 = frmOwner.dataSetDamage.table7.NewRow();
                //frmOwner.dataSetDamage.table7.Rows.Add(dataRow7);
            }
            reportDataSource.Value = bs7;
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
            //10 список приложений
            reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "ds10";
            BindingSource bs10 = new BindingSource();
            bs10.DataSource = frmOwner.dataSetDamage.table10;
            frmOwner.dataSetDamage.table10.Clear();

            DataRow dataRow10 = frmOwner.dataSetDamage.table10.NewRow();
            dataRow10["num"] = "1. ";
            dataRow10["Description"] = "Данные о масштабе прекращения передачи электрической энергии";
            frmOwner.dataSetDamage.table10.Rows.Add(dataRow10);

            if (frmOwner.dataSetDamage.tJ_DamageActDetection.Rows.Count > 0)
            {
                //if (frmOwner.dataSetDamage.tJ_DamageActDetection[0]["TotalComission"].ToString().Length >0)
                if (frmOwner.dataSetDamage.tableMembersSpec.Rows.Count > 0)
                {
                    dataRow10 = frmOwner.dataSetDamage.table10.NewRow();
                    dataRow10["num"] = "2. ";
                    dataRow10["Description"] = "Особое мнение комиссии члена (членов) комиссии";
                    frmOwner.dataSetDamage.table10.Rows.Add(dataRow10);
                }
            }
            reportDataSource.Value = bs10;
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);

            //13 (конец)
            reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "ds13";
            BindingSource bs13 = new BindingSource();
            bs13.DataSource = frmOwner.dataSetDamage.table13;
            reportDataSource.Value = bs13;
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
            //14 напряжение по категориям 1.4
            reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "ds14";
            BindingSource bs14 = new BindingSource();
            bs14.DataSource = frmOwner.dataSetDamage.table14;
            frmOwner.dataSetDamage.table14.Clear();
            foreach (DataRow row in frmOwner.dataSetCrash.Tables["dataTableVoltagePowerPlantConsumer"].Rows)
            {
                DataRow dataRow7 = frmOwner.dataSetDamage.table14.NewRow();
                dataRow7["Description"] = row["Voltage"];
                dataRow7["Cat1"] = row["cat1"];
                dataRow7["Cat2"] = row["cat2"];
                dataRow7["Cat3"] = row["cat3"];
                frmOwner.dataSetDamage.table14.Rows.Add(dataRow7);
            }
            reportDataSource.Value = bs14;
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);

            // 15 характеристики числовые по категориям 1.4
            reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "ds15";
            BindingSource bs15 = new BindingSource();
            bs15.DataSource = frmOwner.dataSetDamage.table15;
            frmOwner.dataSetDamage.table15.Clear();
            //string PowerTotal = ""; //string TSONeighList = "";

            CreateTableAnnex(bs15, "txtCountDeEnergizedTP");
            CreateTableAnnex(bs15, "txtCountDeEnergizedRP35");
            CreateTableAnnex(bs15, "txtCountDeEnergizedRP110");
            CreateTableAnnex(bs15, "txtCountDeEnergizedSettlements");
            CreateTableAnnex(bs15, "txtCountDeEnergizedSocialObjects");
            CreateTableAnnex(bs15, "txtCountDeEnergizedPopulation");
            CreateTableAnnex(bs15, "txtFeedObjectsList");
            CreateTableAnnex(bs15, "txtConsumerFullDeenergized");
            CreateTableAnnex(bs15, "txtConsumerPartialDeenergized");

            reportDataSource.Value = bs15;
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
            //
            DataRow[] rowAnnex = frmOwner.dataSetCrash.Tables["dataTableAnnex"].Select("Name = 'txtPowerTotal'");
            string PowerTotal = (rowAnnex.Count() != 0) ? rowAnnex[0]["Value"].ToString() : "";

            list.Add(new RP.ReportParameter("PowerTotal", PowerTotal));
            ////// 16 данные о масштабе прекращении передачи по категориям 1.5
            reportDataSource = new RP.ReportDataSource();
            reportDataSource.Name = "ds16";
            BindingSource bs16 = new BindingSource();
            bs16.DataSource = frmOwner.dataSetDamage.table16;
            frmOwner.dataSetDamage.table16.Clear();

            DataRow dataRow9 = frmOwner.dataSetDamage.table16.NewRow();
            dataRow9["Description"] = "Перечень смежных сетевых организаций, затронутых прекращением передачи электрической энергии";
            rowAnnex = frmOwner.dataSetCrash.Tables["dataTableAnnex"].Select("Name = 'txtTSONeighList'");
            string TSONeighList = (rowAnnex.Count() != 0) ? rowAnnex[0]["Value"].ToString() : "";
            dataRow9["Value"] = TSONeighList;

            frmOwner.dataSetDamage.table16.Rows.Add(dataRow9);
            //CreateTableAnnex(bs16, "txtTSONeighList");

            reportDataSource.Value = bs16;
            reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
            //
            reportViewerRus.LocalReport.SetParameters(list);
            reportViewerRus.RefreshReport();
            int TotalPages = reportViewerRus.GetTotalPages();
            // list.Add(new RP.ReportParameter("TotalPages", TotalPages.ToString()));
            //list.Add(new RP.ReportParameter("TotalPages", "1"));

        }

        private void reportViewerRus_ReportRefresh(object sender, CancelEventArgs e)
        {
            FillReport();
        }

        private void CreateTableAnnex(BindingSource bs15, string Name)
        {
            DataTable tableIn = frmOwner.dataSetCrash.Tables["dataTableAnnex"];
            DataTable tableOut = frmOwner.dataSetDamage.table15;

            DataRow[] row = tableIn.Select("Name = '" + Name + "'");

            string Value = "";
            if (row.Count() != 0)
                Value = row[0]["Value"].ToString();

            string res = ""; int num4 = 0;
            switch (Name)
            {
                case "txtFeedObjectsList":
                    num4 = 7; res = "Перечень объектов электросетевого хозяйства, отключение которых привело к прекращению передачи электрической энергии потребителям услуг (ПС, ТП, РП, воздушные и кабельные линии электропередач (ВЛ и КЛ соответственно))"; break;
                case "txtConsumerPartialDeenergized": num4 = 9; res = "Перечень потребителей 1-й и 2-й категорий надёжности, в отношении которых произошло частичное ограничение режима потребления электрической энергии"; break;
                case "txtTSONeighList":
                    num4 = 0;
                    // TSONeighList = row["Value"].ToString();
                    //res = "Перечень смежных сетевых организаций, затронутых прекращением передачи электрической энергии";
                    break;
                case "txtPowerTotal": num4 = 0; //PowerTotal = row["Value"].ToString();
                    break;
                case "txtCountDeEnergizedRP35":
                    num4 = 2; res = "Количество обесточенных подстанций (далее - ПС), распределительных пунктов (далее - РП) (35 кВ)";
                    Value += " шт.";
                    break;
                case "txtCountDeEnergizedRP110":
                    num4 = 3; res = "Количество обесточенных ПС, РП (110 кВ и выше)";
                    Value += " шт.";
                    break;
                case "txtCountDeEnergizedSettlements":
                    num4 = 4; res = "Количество обесточенных населённых пунктов";
                    Value += " шт.";
                    break;
                    
                case "txtCountDeEnergizedTP":
                    num4 = 1; res = "Количество обесточенных трансформаторных подстанций (далее - ТП) (6-10 кВ)";
                    Value += " шт.";
                    break;
                case "txtCountDeEnergizedSocialObjects": num4 = 5; res = "Количество обесточенных социально значимых объектов";
                    Value += " шт."; break;
                case "txtCountDeEnergizedPopulation": num4 = 6; res = "Обесточенное население"; Value += " чел."; break;
                case "txtConsumerFullDeenergized": num4 = 8; res = "Перечень потребителей 1-й и 2-й категорий надежности, в отношении которых произошло полное ограничение режима потребления электрической энергии"; break;
                default:
                    break;

            }
            if (num4 != 0)
            {
                if (num4 != 7 && num4 != 9 && num4 != 8)
                {
                    DataRow dataRow7 = tableOut.NewRow();
                    dataRow7["num"] = num4;
                    dataRow7["Description"] = res;
                    dataRow7["Value"] = Value;
                    tableOut.Rows.Add(dataRow7);
                }
                else
                {
                    DataRow dataRow7 = tableOut.NewRow();
                    dataRow7["num"] = num4;
                    dataRow7["Description"] = res;
                    dataRow7["Value"] = "";
                    tableOut.Rows.Add(dataRow7);

                    dataRow7 = tableOut.NewRow();
                    dataRow7["num"] = num4;
                    dataRow7["Description"] = Value;
                    dataRow7["Value"] = "";
                    tableOut.Rows.Add(dataRow7);

                }
            }

        }
    }
}
