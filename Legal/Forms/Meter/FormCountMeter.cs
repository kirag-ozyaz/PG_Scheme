using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;


namespace Legal.Forms.Meter
{
    public partial class FormCountMeter : FormLbr.FormBase
    {
        public FormCountMeter()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    //private void btnOK_Click(object sender, EventArgs e)
    //{
    //    string txtWhere = "";
    //    txtWhere += " (Period >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
    //        " (Period <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";

    //    dsCalc1.vG_ReportCountMeter.Rows.Clear();

    //    DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
    //    try
    //    {
    //        con.OpenConnection(SqlSettings);
    //        string strCmd = "";

    //        strCmd = "select * from fn_LegGetCountMeter (@DateBegin, @DateEnd) order by Period, Voltage";
    //        SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

    //        DateTime DateBegin = (DateTime)dtBegin.Value.Date;
    //        DateTime DateEnd = (DateTime)dtEnd.Value.Date;

    //        SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
    //        sqlCmd.Parameters.Add(p1);

    //        SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
    //        sqlCmd.Parameters.Add(p2);

    //        sqlCmd.CommandTimeout = 0;

    //        SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

    //        dAdapt.Fill(dsCalc1, "tG_CountMeter");
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message, ex.Source);
    //    }
    //    finally
    //    {
    //        con.CloseConnection();
    //    }


    //}

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

                int ColCount = dgv.Columns.Count;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:D").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:D").Font.Size = 10;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "D2").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "D2").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "D2").Font.Size = 12;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "D1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "D1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "D1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "D1").Value2 = "Точки учета по уровням напряжения";

                xlWorkSheet.get_Range("A2", "D2").Merge(misValue);
                xlWorkSheet.get_Range("A2", "D2").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "D2").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "D2").Value2 = "за период с " + dtBegin.Value.Date.ToShortDateString() + " по " + dtEnd.Value.Date.ToShortDateString();

                int i = 0;
                int j = 0;
                int k = 4;

                // заголовок таблицы
                xlWorkSheet.get_Range("A" + k, misValue).Value2 = "Период";
                xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Напряжение";
                xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Юрлица";
                xlWorkSheet.get_Range("D" + k, misValue).Value2 = "Физлица";

                xlWorkSheet.get_Range("A" + k, "D" + k).HorizontalAlignment = Excel.Constants.xlCenter;

                // установим ширину столбцов
                xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 15;
                xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 15;
                xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 20;
                xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 20;

                xlWorkSheet.get_Range("A" + k, "D" + k).VerticalAlignment = Excel.Constants.xlCenter;
                
                // вывод данных в ячейки
                for (i = 0; i <= dgv.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgv.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgv[j, i];
                        if (j == 1)
                            xlWorkSheet.Cells[i + k + 1, j + 1] = cell.Value.ToString().Replace("/", "//");
                        else
                            xlWorkSheet.Cells[i + k + 1, j + 1] = cell.Value;
                    }
                }

                // форматирование данных
//                xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "Общий";
                xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "Общий";
                xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("D:D", misValue).NumberFormat = "### ##0";

                //
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k + dgv.RowCount, ColCount]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k + dgv.RowCount, ColCount]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait;

                xlWorkSheet.PageSetup.LeftMargin = 80;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;

                this.Cursor = Cursors.Default;
                xlApp.Visible = true;
            }
            else
                MessageBox.Show("Нет данных для отчета ..");

        }

        private void FormCountMeter_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCalc1, dsCalc1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
          //  SelectSqlData(dsCalc1, dsCalc1.tAbn, true, " where TypeAbn in (207, 230, 231)");

            //dtBegin.Value = new DateTime(DateTime.Now.Date.Year, 1, 1);
            //dtEnd.Value = new DateTime(DateTime.Now.Date.Year, 12, 31);
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(-1).AddDays(-1);
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(1).AddDays(-1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string txtWhere = "";
            txtWhere += " (Period >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                " (Period <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";

            SelectSqlData(dsCalc1, dsCalc1.tG_CountMeter, true, " where " + txtWhere);

            if (dsCalc1.tG_CountMeter.Rows.Count == 0)
            {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    strCmd = "LegSaveCountMeterNew";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                    DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                    SqlParameter p1 = new SqlParameter("@dt", DateBegin.ToString("yyyyMMdd"));
                    sqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("@dt2", DateEnd.ToString("yyyyMMdd"));
                    sqlCmd.Parameters.Add(p2);

                    sqlCmd.CommandTimeout = 0;

                    Cursor.Current = Cursors.WaitCursor;

                    sqlCmd.ExecuteNonQuery();

                    Cursor.Current = Cursors.Default;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }
                SelectSqlData(dsCalc1, dsCalc1.tG_CountMeter, true, " where " + txtWhere);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectSqlData(dsCalc1, dsCalc1.tPassword, true, " where code = 1");
            string Password = dsCalc1.tPassword[0]["Password"].ToString();
            Legal.Forms.Calculat.FormPassword frm = new Legal.Forms.Calculat.FormPassword(Password);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.PasswordTrue == true)
                {
                    DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                    try
                    {
                        con.OpenConnection(SqlSettings);

                        string strCmd = "";
                        strCmd = "LegDeleteCountMeter";
                        SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                        DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                        SqlParameter p1 = new SqlParameter("@dtBegin", DateBegin.ToString("yyyyMMdd"));
                        sqlCmd.Parameters.Add(p1);

                        SqlParameter p2 = new SqlParameter("@dtEnd", DateEnd.ToString("yyyyMMdd"));
                        sqlCmd.Parameters.Add(p2);

                        sqlCmd.CommandTimeout = 0;

                        Cursor.Current = Cursors.WaitCursor;

                        sqlCmd.ExecuteNonQuery();

                        Cursor.Current = Cursors.Default;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                    finally
                    {
                        con.CloseConnection();
                    }
                    string txtWhere = "";
                    txtWhere += " (Period >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                        " (Period <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";

                    SelectSqlData(dsCalc1, dsCalc1.tG_CountMeter, true, " where " + txtWhere);

                }
            }
        }

  
    }
}
