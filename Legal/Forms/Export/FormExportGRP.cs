using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace Legal.Forms.Export
{
    public partial class FormExportGRP : FormLbr.FormBase
    {
        public FormExportGRP()
        {
            InitializeComponent();
        }

        private void ExportExcel(int num, string NameBook)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";
                switch (num)
                {
                    case 1:
                        strCmd = "select * from fun_Abn_X1()";
                        break;
                    case 2:
                        strCmd = "Select * FROM fun_AbnObj_X7(@Date)";
                        break;
                    case 3:
                        strCmd = "Select * FROM fun_Abn_Value_X4(@DateBegin, @DateEnd)";
                        break;
                    case 4:
                        strCmd = "Select * FROM fun_AbnObj_Month_Value_X5(@DateBegin, @DateEnd)";
                        break;
                    case 5:
                        strCmd = "Select * FROM fun_Abn_X2(@Year)";
                        break;
                    case 6:
                        strCmd = "Select * FROM fun_AbnObj_X2(@Year)";
                        break;
                }

                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                switch (num)
                {
                    case 1:
                        break;
                    case 2:
                        DateTime Date = dtInfo.Value;
                        SqlParameter p1 = new SqlParameter("@Date", Date.ToString("yyyyMMdd"));
                        sqlCmd.Parameters.Add(p1);
                        break;
                    case 3:
                    case 4:
                        DateTime DateBegin = dtTransBegin.Value;
                        SqlParameter p2 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                        sqlCmd.Parameters.Add(p2);
                        DateTime DateEnd = dtTransEnd.Value;
                        SqlParameter p3 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                        sqlCmd.Parameters.Add(p3);
                        break;
                    case 5:
                    case 6:
                        Int32 Year = dtVolume.Value.Year;
                        SqlParameter p4 = new SqlParameter("@Year", Year);
                        sqlCmd.Parameters.Add(p4);
                        break;
                }

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                DataTable dt = new DataTable();
                dAdapt.Fill(dt);

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
                excelcells.Value2 = NameBook;
                // Шапка
                for (int i = 1; i <= dt.Columns.Count; i++)
                {
                    excelcells = (Excel.Range)excelworksheet.Cells[2, i];
                    excelcells.Value2 = dt.Columns[i - 1].ColumnName;
                }
                // Данные
                int c = 1;

                foreach (DataRow row in dt.Rows)
                {
                    c++;
                    foreach (DataColumn column in dt.Columns)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }


        }

        private void btnAbn_Click(object sender, EventArgs e)
        {
            ExportExcel(1, "Договорная информация по потребителям");
        }


        private void btnObj_Click(object sender, EventArgs e)
        {
            ExportExcel(2, "Договорная информация по объектам");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbnTrans_Click(object sender, EventArgs e)
        {
            ExportExcel(3, "Передача электроэнергии по абонентам");
        }

        private void btnObjTrans_Click(object sender, EventArgs e)
        {
            ExportExcel(4, "Передача электроэнергии по объектам");
        }

        private void btnAbnVolume_Click(object sender, EventArgs e)
        {
            ExportExcel(5, "Плановые объемы по потребителям");
        }

        private void btnObjVolume_Click(object sender, EventArgs e)
        {
            ExportExcel(6, "Плановые объемы по объектам потребителя");
        }
    }
}
