using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ControlsLbr;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Legal.Forms.ActCheck
{
    public partial class Form_Journal_MeterDemontag : FormLbr.FormBase
    {
        public Form_Journal_MeterDemontag()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddYears(1);
            dtEnd.Value = dtEnd.Value.AddYears(1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddYears(-1);
            dtEnd.Value = dtEnd.Value.AddYears(-1);
        }

        private void Form_Journal_MeterDemontag_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            int year = DateTime.Now.Date.Year;
            dtBegin.Value = new DateTime(year, 1, 1);
            dtEnd.Value = new DateTime(year, 12, 31);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dsAbnDocum1.tMeterDemontag.Rows.Clear();

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";
                strCmd = "select * from fn_Leg_Demontag(@DateBegin, @DateEnd)";

                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsAbnDocum1, "tMeterDemontag");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
            this.Cursor = Cursors.Default;

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
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

                Excel.Range excelcells;

                excelcells = (Excel.Range)xlWorkSheet.Cells[1, 1];
                excelcells.Value2 = "";

                int ColCount = dgv.Columns.Count;
                int RowCount = dgv.RowCount;

                // Шапка
                int numColExcel = 1;
                for (int i = 0; i < ColCount; i++)
                {
                    if (dgv.Columns[i].Visible == true)
                    {
                        excelcells = (Excel.Range)xlWorkSheet.Cells[1, numColExcel];
                        excelcells.Value2 = dgv.Columns[i].HeaderText;
                        numColExcel++;
                    }
                }

                // вывод данных в ячейки
                for (int j = 0; j < RowCount; j++)
                {
                    numColExcel = 1;
                    for (int i = 0; i < ColCount; i++)
                    {
                        if (dgv.Columns[i].Visible == true)
                        {
                            excelcells = (Excel.Range)xlWorkSheet.Cells[j+2, numColExcel];

                            if (dgv.Columns[i].ValueType == Type.GetType("System.DateTime"))
                                excelcells.NumberFormat = @"ДД.ММ.ГГГГ";

                            excelcells.Value2 = dgv[i, j].Value;
                            numColExcel++;
                        }
                    }

                }

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                xlWorkSheet.PageSetup.LeftMargin = 70;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;

                this.Cursor = Cursors.Default;

                xlApp.Visible = true;


            }
            else
                MessageBox.Show("Нет данных для отчета ..");

        }
    }
}
