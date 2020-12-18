using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace Legal.Forms.Export
{
    public partial class FormImportODN : FormLbr.FormBase
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)] string path,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
            int shortPathLength);

        public FormImportODN()
        {
            InitializeComponent();
        }

        private void FormImportODN_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCalc1, dsCalc1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
            
            // каталог с файлом для импорта по умолчанию
            textBoxFile.Text = "";
        }
        
        // выберем файл Excel для импорта
        private void buttonFile_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.FileName = textBoxFile.Text;
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = saveFileDialogExport.FileName;
            }
        }

        // заливаем в базу из грида
        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectSqlData(dsCalc1, dsCalc1.tPassword, true, " where code = 1");
            string Password = dsCalc1.tPassword[0]["Password"].ToString();
            Legal.Forms.Calculat.FormPassword frm = new Legal.Forms.Calculat.FormPassword(Password);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.PasswordTrue == true)
                    if (CheckFor())
                    {
                        // зальем данные в tg_ODN
                        InsertSqlData(dsCalc1, dsCalc1.tG_ODN);
                        // запустим хранимую процедуру ImportODN 
                        DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                        try
                        {
                            con.OpenConnection(SqlSettings);

                            string strCmd = "";
                            strCmd = "ImportODN";
                            SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            SqlParameter p1 = new SqlParameter("@Year", dtBegin.Value.Year);
                            sqlCmd.Parameters.Add(p1);
                            SqlParameter p2 = new SqlParameter("@Month", dtBegin.Value.Month);
                            sqlCmd.Parameters.Add(p2);

                            sqlCmd.CommandTimeout = 0;
                            sqlCmd.ExecuteNonQuery();

                            dsCalc1.tG_ODN.Rows.Clear();
                            SelectSqlData(dsCalc1, dsCalc1.tG_ODN, true, " where dtYear = " + dtBegin.Value.Year + " and dtMonth = " + dtBegin.Value.Month);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.Source);
                        }
                        finally
                        {
                            con.CloseConnection();
                        }
                        MessageBox.Show("Загрузка данных завершена ..");
                    }
            }

        }

        // процедура импорта из файла в грид
        private void processExcel(string filename)
        {

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

            var missing = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(filename, false, true, missing, missing, missing, true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, '\t', false, false, 0, false, true, 0);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            Microsoft.Office.Interop.Excel.Range xlRange = xlWorkSheet.UsedRange;
            Array myValues = (Array)xlRange.Cells.Value2;

            int vertical = myValues.GetLength(0);
            int horizontal = myValues.GetLength(1);

            for (int a = 2; a <= vertical; a++)
            {
                DataRow row = dsCalc1.tG_ODN.NewRow();
                for (int b = 1; b <= horizontal; b++)
                {
                    switch (myValues.GetValue(1, b).ToString())
                    {
                        case "Договор":
                            row["Code"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b); 
                            break;
                        case "№ счетчика":
                            row["Meter"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "Объем, кВтч":
                            row["Volume"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "Объем ОДН, кВтч":
                            row["ODN"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                    }
                    row["dtYear"] = dtBegin.Value.Year;
                    row["dtMonth"] = dtBegin.Value.Month; 
                }

                dsCalc1.tG_ODN.Rows.Add(row);
            }

            xlWorkBook.Close(true, missing, missing);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        // чистим за собой после импорта
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        // загрузим данные в грид
        // если выбран файл Excel, то из него
        // иначе из tG_ODN
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (textBoxFile.Text != "")
            {
                if (CheckFor())
                {
                    if (textBoxFile.Text.EndsWith(".xls"))
                    {
                        processExcel(textBoxFile.Text);
                    }
                    else
                        MessageBox.Show("Выберите файл с расширением .xls для импорта ..");
                }
            }

            else
            {
                SelectSqlData(dsCalc1, dsCalc1.tG_ODN, true, " where dtYear = " + dtBegin.Value.Year + " and dtMonth = " + dtBegin.Value.Month);
            }

        }

        // проверим была ли заливка за этот период
        private bool CheckFor()
        {
            dsCalc1.tG_ODN1.Rows.Clear();
            SelectSqlDataTableOther(dsCalc1, dsCalc1.tG_ODN1, "tG_ODN", true, " where dtYear = " + dtBegin.Value.Year + " and dtMonth = " + dtBegin.Value.Month, 1);
            if (dsCalc1.tG_ODN1.Rows.Count > 0)
            {
                MessageBox.Show("Данные за этот период уже загружены в базу");
                return false;
            }
            dsCalc1.tG_ODN1.Rows.Clear();

            return true;
        }
    }
}
