using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FormLbr.Classes;
using System.Linq;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using ControlsLbr;
using SchemeModelN;
using Library;
using Logger;

namespace Legal.Forms.Calculat
{
    public partial class FormReportObjLink : FormLbr.FormBase
    {
        private bool flag;

        public FormReportObjLink()
        {
            InitializeComponent();
        }

        private void FormReportObjLink_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsDop1, dsDop1.tG_PeriodCalc, true);
            //            dtBegin.Value = new DateTime((int)dsDop1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsDop1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            //            dtEnd.Value = new DateTime((int)dsDop1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsDop1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
            dtBegin.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtEnd.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month + 1, 1).AddDays(-1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FillReport();
            //this.tsbExcel.Enabled = false;
            //this.tsbExcel2.Enabled = false;
            //this.tsbPrint.Enabled = false;
            //this.dgv1.Enabled = false;
            //this.groupBox1.Enabled = false;
            //this.btnCancel.Enabled = false;
            //this.btnOK.Enabled = false;

            //this.flag = false;

            //StartBackGround();

        }
        private void StartBackGround()
        {
            this.backgroundWorker.RunWorkerAsync();
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FillReport();
            this.flag = true;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (flag)
            {
                this.tsbExcel.Enabled = true;
                this.tsbExcel2.Enabled = true;
                this.tsbPrint.Enabled = true;
                this.dgv1.Enabled = true;
                this.groupBox1.Enabled = true;
                this.btnCancel.Enabled = true;
                this.btnOK.Enabled = true;
            }
        }
        private void FillReport()
        {
            this.Cursor = Cursors.WaitCursor;
            

            dsDop1.tG_ReportMain_Link.Rows.Clear();
            // получаем данные по начислениям
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";

                strCmd = "select * from [fn_LegReportMain_Link-3](@DateBegin, @DateEnd) order by codeabonent";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsDop1, "tG_ReportMain_Link");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }

            // теперь получаем данные по привязкам объектов
            ElectricModel electricModel = new ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema(true);

            int? idSchmObj = null;
            int idAbnObj = 0;
            DateTime? dtPay = null;
            int row_number = 1;
            foreach (DataRow row in dsDop1.tG_ReportMain_Link.Rows)
            {
                //Application.DoEvents();
                if (idAbnObj == Convert.ToInt32(row["idAbnObj"]) && dtPay == Convert.ToDateTime(row["dtPay"]))
                {
                    row["Quantity"] = 0;
                    row_number = row_number + 1;
                }
                else
                {
                    idAbnObj = Convert.ToInt32(row["idAbnObj"]);
                    dtPay = Convert.ToDateTime(row["dtPay"]);
                    row_number = 1;
                }
                row["rowSubAbnObj"] = row_number;

                try
                {
                    if (row["idSchmObj"] != DBNull.Value)
                    {
                        idSchmObj = (int)row["idSchmObj"];

                        var ElectricObject = electricModel.GetParamsElectricObjectById((int)idSchmObj);
                        row["TP"] = ElectricObject.ElectricSubName;
                        if (ElectricObject.electricObject is SchemeModelN.ElectricLine)
                        {
                            row["TPCell"] = ElectricObject.electricLine.ToString();
                        }

                        //if (row["subid"] != DBNull.Value)
                        //{
                        //    var SubStation = electricModel.GetParamsElectricObjectById((int)row["subid"]);
                        //    row["TP"] = SubStation.ElectricSubName;
                        //}
                        // electricModel.GetParamsElectricObjectById(972609).electricObject is SchemeModelN.ElectricLine


                        var listSchmObj = electricModel.GetCellCP((int)idSchmObj);
                        if (listSchmObj != null)
                            if (listSchmObj.Length > 0)
                            {
                                if (listSchmObj[0].ElectricSubName != null)
                                    row["CPName"] = listSchmObj[0].ElectricSubName;
                                if (listSchmObj[0].electricLine != null)
                                    row["CellCPName"] = listSchmObj[0].electricLine.ToString();
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + ": " + idSchmObj.ToString(), "Ошибка", MessageBoxButtons.OK);
                }
            }
            //            dgv1.Refresh();
            this.Cursor = Cursors.Default;
        }

        // Экспорт в Excel
        private void cmdExcel_Click(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                // добавляем книгу и лист
                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlApp.Visible = false;


                //int ColCount = dataGridView1.Columns.Count;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:E").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:E").Font.Size = 10;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "H2").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "H2").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "H2").Font.Size = 12;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "H1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "H1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "H1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "H1").Value2 = "Ведомость по передаче электроэнергии по сетям МУП УльГЭС";

                xlWorkSheet.get_Range("A2", "H2").Merge(misValue);
                xlWorkSheet.get_Range("A2", "H2").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "H2").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "H2").Value2 = "за период с " + dtBegin.Value.Date.ToShortDateString() + " по " + dtEnd.Value.Date.ToShortDateString();

                int i = 0;
                int j = 0;
                int k = 4;

                k = k + 2;
                // заголовок таблицы

                xlWorkSheet.get_Range("A" + k, misValue).Value2 = "Код";
                xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Потребитель";
                xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Объект";
                xlWorkSheet.get_Range("D" + k, misValue).Value2 = "Пит.центр";
                xlWorkSheet.get_Range("E" + k, misValue).Value2 = "Ячейка";
                xlWorkSheet.get_Range("F" + k, misValue).Value2 = "Подстанция";

                int n = 7;

                int count_month = 0;
                if (dtEnd.Value.Month > dtBegin.Value.Month)
                    count_month = dtEnd.Value.Month - dtBegin.Value.Month + 1;
                else
                    count_month = 12 - dtBegin.Value.Month + dtEnd.Value.Month + 1;

                for (i = 1; i <= count_month; i++)
                {
                    xlWorkSheet.Cells[k, n] = dtBegin.Value.Date.AddMonths(i).AddDays(-1);
                    n += 1;
                }

                // установим ширину столбцов
                xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 8;
                xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 40;
                xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 40;
                xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 40;
                xlWorkSheet.get_Range("E:E", misValue).ColumnWidth = 10;
                xlWorkSheet.get_Range("F:F", misValue).ColumnWidth = 20;

                // вывод данных в ячейки
                int m = dgv1.RowCount;
                int idObj = 0;
 //               int idSub = 0;
 //               int idSchm = 0;
                int first_col = dtBegin.Value.Month;
                int ncol = 0;
                int nrowsheet = k + 1;
                int[] total_sum = new int[count_month + 7];

                for (i = 0; i < m - 1; i++)
                {
                    if ((Int32)dgv1[8, i].Value != idObj) 
                        //& (Int32)dgv1[9, i].Value != idSchm & (Int32)dgv1[10, i].Value != idSub)
                    {
                        nrowsheet += 1;
                        idObj = (Int32)dgv1[8, i].Value;
//                        idSchm = (Int32)dgv1[9, i].Value;
//                        idSub = (Int32)dgv1[10, i].Value;

                        xlWorkSheet.Cells[nrowsheet, 1] = dgv1[0, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 2] = dgv1[1, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 3] = dgv1[2, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 4] = dgv1[3, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 5] = dgv1[4, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 6] = dgv1[5, i].Value;
                    }
                    int mec = Convert.ToDateTime(dgv1[6, i].Value).Month;
                    if (mec < first_col)
                        ncol = (12 - first_col) + 7 + mec;
                    else
                        ncol = mec - first_col + 7;
                    xlWorkSheet.Cells[nrowsheet, ncol] = dgv1[7, i].Value;
                    //total_sum[ncol] = total_sum[ncol] + Convert.ToInt32(dgv1[7, i].Value);
                }

                //xlWorkSheet.Cells[nrowsheet + 1, 2] = "Итого";
                //for (i = 3; i < total_sum.Length; i++)
                //{
                //    xlWorkSheet.Cells[nrowsheet + 1, i] = total_sum[i];
                //}

                // форматирование данных
                xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "Общий";
                xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "Общий";
                //xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "### ##0";

                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[nrowsheet + 1, count_month + 3]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[nrowsheet + 1, count_month + 3]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                //k = nrowsheet + 3;
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).Merge(misValue);
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).VerticalAlignment = Excel.Constants.xlCenter;
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).HorizontalAlignment = Excel.Constants.xlCenter;
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).Value2 = "Начальник службы контроля и учета электрической энергии";

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                //xlWorkSheet.PageSetup.LeftMargin = 80;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;

                this.Cursor = Cursors.Default;
                xlApp.Visible = true;
            }
            else
                MessageBox.Show("Нет данных для отчета ..");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(1).AddDays(-1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(-1).AddDays(-1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            FormReportObjLinkPrint frm = new FormReportObjLinkPrint()
            {
                SqlSettings = this.SqlSettings,
                MdiParent = base.MdiParent,
                FormParent = this

            };
            frm.TableReport = dsDop1.tG_ReportMain_Link;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.dgv1.ExportToExcel();
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            int CodeAbn = Convert.ToInt32(dgv1.CurrentRow.Cells["codeAbonent"].Value);
            if (dgv1.CurrentRow.Cells["TypeAbn"].Value.ToString() == "Потребитель ФЛ")
            {
                int AbnType = (int)Constants.AbnType.Private;

                Prv.Forms.Abonent.FormAbonent frm = new Prv.Forms.Abonent.FormAbonent(CodeAbn, AbnType);
                frm.SqlSettings = this.SqlSettings;
                frm.MdiParent = this.MdiParent;

                frm.Show();
            }
            else
            {
                int idObj = Convert.ToInt32(dgv1.CurrentRow.Cells["idAbnObj1"].Value);
                FormAbn frm = new FormAbn(CodeAbn, idObj);
                frm.SqlSettings = this.SqlSettings;
                frm.MdiParent = this.MdiParent;

                frm.Show();
            }
        }


    }
}
