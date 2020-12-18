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
    public partial class FormExportMRSK : FormLbr.FormBase
    {
        public FormExportMRSK()
        {
            InitializeComponent();
        }

        private void FormExportMRSK_Load(object sender, EventArgs e)
        {
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                        this.Cursor = Cursors.WaitCursor;

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";
                strCmd = "select * from fn_LegExportMRSK order by Договор, Потребитель";

                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

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
                excelcells.Value2 = "";
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
                this.Cursor = Cursors.Default;
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
    }
}
