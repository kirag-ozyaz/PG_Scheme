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
using System.Runtime.InteropServices;
using System.Reflection; 


namespace Legal.Forms.Export
{
    public partial class FormExportDispatch : FormLbr.FormBase
    {

        public FormExportDispatch()
        {
            InitializeComponent();
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
                strCmd = "select * from fn_LegExportDispatch(@DateWinterBegin, @DateWinterEnd, @DateSummerBegin, @DateSummerEnd) order by [№дог], Объект";

                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                DateTime DateWinterBegin = dtWinterBegin.Value;
                SqlParameter p1 = new SqlParameter("@DateWinterBegin", DateWinterBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);
                DateTime DateWinterEnd = dtWinterEnd.Value;
                SqlParameter p2 = new SqlParameter("@DateWinterEnd", DateWinterEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                DateTime DateSummerBegin = dtSummerBegin.Value;
                SqlParameter p3 = new SqlParameter("@DateSummerBegin", DateSummerBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p3);
                DateTime DateSummerEnd = dtSummerEnd.Value;
                SqlParameter p4 = new SqlParameter("@DateSummerEnd", DateSummerEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p4);

                
                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                DataTable dt = new DataTable();
                dAdapt.Fill(dt);
 
                string[,] arrVal;
                arrVal = new string[dt.Rows.Count+1,  dt.Columns.Count];

                for (int j = 0; j <= dt.Columns.Count - 1; j++)
                {
                    arrVal[0, j] = dt.Columns[j].ColumnName;
                }

                for(int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= dt.Columns.Count - 1; j++)
                    {
                        arrVal[i+1,j] = dt.Rows[i][j].ToString(); 
                    }
                }

                string appProgID = "Excel.Application";

                // Получаем ссылку на интерфейс IDispatch
                Type excelType = Type.GetTypeFromProgID(appProgID);

                // Запускаем Excel
                object excel = Activator.CreateInstance(excelType);

                object workbooks = excel.GetType().InvokeMember("Workbooks", BindingFlags.GetProperty, null, excel, null);

                // Создаем новую книгу
                object workbook = workbooks.GetType().InvokeMember("Add", BindingFlags.InvokeMethod, null, workbooks, null);

                excelType.InvokeMember("Visible", BindingFlags.SetProperty, null, excel, new object[] { true });

                object oWorksheets = workbook.GetType().InvokeMember("Worksheets", BindingFlags.GetProperty, null, workbook, null);

                // Задаем порядковый номер страницы - 1
                object[] args = new object[1];
                args[0] = 1;

                // Получаем ссылку на эту страницу
                object worksheet = oWorksheets.GetType().InvokeMember("Item", BindingFlags.GetProperty, null, oWorksheets, args);

                // Получаем ссылку объект Range
                object range = worksheet.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, worksheet, new object[] { "A1", "Z" + dt.Rows.Count});
                range.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, range, new object[] { arrVal });
                
//                object range1 = worksheet.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, worksheet, new object[] { "A2"});
//                range.GetType().InvokeMember("AutoFormat", BindingFlags.SetProperty, null, range, new object[] { Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2 }); 


                this.Cursor = Cursors.Default;

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
