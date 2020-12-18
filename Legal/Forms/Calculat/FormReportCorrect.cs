using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Legal.Forms.Calculat
{
    public partial class FormReportCorrect : FormLbr.FormBase
    {
        public FormReportCorrect()
        {
            InitializeComponent();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string txtWhereDate = "";
            txtWhereDate += " (dtPay >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                " (dtPay <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";

            dsCalc1.vG_ReportCorrectFact.Rows.Clear();
            SelectSqlData(dsCalc1, dsCalc1.vG_ReportCorrectFact, true, "where " + txtWhereDate + " order by codeabonent");

            int kol1 = 0;
            decimal sum1 = 0;
            decimal nal1 = 0;
            decimal tot1 = 0;
            int kol2 = 0;
            decimal sum2 = 0;
            decimal nal2 = 0;
            decimal tot2 = 0;
            int dif_q = 0;
            decimal dif_s = 0;        

            for (int i = 0; i <= dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["q1"].Value != System.DBNull.Value)
                    kol1 = kol1 + Convert.ToInt32(dgv.Rows[i].Cells["q1"].Value);
                if (dgv.Rows[i].Cells["s1"].Value != System.DBNull.Value)
                    sum1 = sum1 + Convert.ToDecimal(dgv.Rows[i].Cells["s1"].Value);
                if (dgv.Rows[i].Cells["n1"].Value != System.DBNull.Value)
                    nal1 = nal1 + Convert.ToDecimal(dgv.Rows[i].Cells["n1"].Value);
                if (dgv.Rows[i].Cells["t1"].Value != System.DBNull.Value)
                    tot1 = tot1 + Convert.ToDecimal(dgv.Rows[i].Cells["t1"].Value);

                if (dgv.Rows[i].Cells["q2"].Value != System.DBNull.Value)
                    kol2 = kol2 + Convert.ToInt32(dgv.Rows[i].Cells["q2"].Value);
                if (dgv.Rows[i].Cells["s2"].Value != System.DBNull.Value)
                    sum2 = sum2 + Convert.ToDecimal(dgv.Rows[i].Cells["s2"].Value);
                if (dgv.Rows[i].Cells["n2"].Value != System.DBNull.Value)
                    nal2 = nal2 + Convert.ToDecimal(dgv.Rows[i].Cells["n2"].Value);
                if (dgv.Rows[i].Cells["t2"].Value != System.DBNull.Value)
                    tot2 = tot2 + Convert.ToDecimal(dgv.Rows[i].Cells["t2"].Value);

                if (dgv.Rows[i].Cells["dif1"].Value != System.DBNull.Value)
                    dif_q = dif_q + Convert.ToInt32(dgv.Rows[i].Cells["dif1"].Value);
                if (dgv.Rows[i].Cells["dif2"].Value != System.DBNull.Value)
                    dif_s = dif_s + Convert.ToDecimal(dgv.Rows[i].Cells["dif2"].Value);
            }
            int nn = dgv.Rows.Count;
            dsCalc1.vG_ReportCorrectFact.Rows.Add(new object[] { nn, "Итого", null, null, null, kol1, sum1, nal1, tot1, null, null, kol2, sum2, nal2, tot2, dif_q, dif_s });

        }

        private void FormReportCorrect_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCalc1, dsCalc1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                Excel.Application excelapp = new Excel.Application();

                excelapp.SheetsInNewWorkbook = 1;
                excelapp.Workbooks.Add(Type.Missing);

                Excel.Workbooks excelappworkbooks = excelapp.Workbooks;
                Excel.Workbook excelappworkbook = excelappworkbooks[1];

                Excel.Sheets excelsheets = excelappworkbook.Worksheets;
                Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);

                Excel.Range excelcells;

                // Заголовок
                excelcells = (Excel.Range)excelworksheet.Cells[1, 1];
                excelcells.Value2 = "Отчет по корректировкам за период с  " + dtBegin.Value.Date.ToString() + " по " + dtBegin.Value.Date.ToString();
                // Шапка
                for (int i = 1; i <= dsCalc1.vG_ReportCorrectFact.Columns.Count; i++)
                {
                    excelcells = (Excel.Range)excelworksheet.Cells[2, i];
                    excelcells.Value2 = dsCalc1.vG_ReportCorrectFact.Columns[i - 1].Caption;
                }
                // Данные
                int c = 1;
                foreach (DataRow row in dsCalc1.vG_ReportCorrectFact.Rows)
                {
                    c++;
                    foreach (DataColumn column in dsCalc1.vG_ReportCorrectFact.Columns)
                    {
                        excelcells = (Excel.Range)excelworksheet.Cells[c + 1, column.Ordinal + 1];
                        if (column.DataType == Type.GetType("System.String"))
                            excelcells.NumberFormat = "@";
                        if (column.DataType == Type.GetType("System.DateTime"))
                            excelcells.NumberFormat = @"ДД.ММ.ГГГГ";
                        if (column.DataType == Type.GetType("System.Boolean"))
                            excelcells.NumberFormat = "@";

                        excelcells.Value2 = row[column];
                    }
                }
                excelapp.Visible = true;
                return;


            }
        }
    }
}
