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
using Excel = Microsoft.Office.Interop.Excel;


namespace Legal.Forms.Export
{
    public partial class FormImportDNU : FormLbr.FormBase
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)] string path,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
            int shortPathLength);

        public FormImportDNU()
        {
            InitializeComponent();
        }

        private void FormImportDNU_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCalc1, dsCalc1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);

            // каталог с файлом для импорта по умолчанию
            textBoxFile.Text = "";

            // фильтр по сетям
            SelectSqlData(dsCalc1, dsCalc1.vG_DNUSeti, true, " order by Seti");
            for (int i = 0; i < dsCalc1.vG_DNUSeti.Rows.Count; i++)
            {
                listNet.Items.Add(dsCalc1.vG_DNUSeti[i]["Seti"].ToString());
            }
            // отметим нужные сети
            for (int i = 0; i < listNet.Items.Count; i++)
            {
                if (listNet.Items[i].ToString() == "МУП УльГЭС") 
                {
                    listNet.SetItemChecked(i, true);
                }
                if (listNet.Items[i].ToString() == "УльГЭС")
                {
                    listNet.SetItemChecked(i, true);
                }
            }
            listNet.SelectedIndex = 0;

            // фильтр по счетчикам
            SelectSqlData(dsCalc1, dsCalc1.vG_DNUMeter, true, " order by Pribor");
            for (int i = 0; i < dsCalc1.vG_DNUMeter.Rows.Count; i++)
            {
                listMeter.Items.Add(dsCalc1.vG_DNUMeter[i]["Pribor"].ToString());
            }

            for (int i = 0; i < listMeter.Items.Count; i++)
            {
                if (listMeter.Items[i].ToString().ToLower().IndexOf("вир") == -1 & listMeter.Items[i].ToString().ToLower().IndexOf("вит") == -1)  
                    listMeter.SetItemChecked(i, true);
                else
                    if (listMeter.Items[i].ToString().ToLower().IndexOf("норматив") > -1)
                        listMeter.SetItemChecked(i, true);
            }

            listMeter.SelectedIndex = 0;
        }


        // просмотр данных
        private void btnRun_Click(object sender, EventArgs e)
        {
            string txtWhere = "";

            // зальем данные в грид из таблицы tG_DNU
            string Period = "";
            if (dtBegin.Value.Month > 9)
                Period = dtBegin.Value.Year.ToString() + dtBegin.Value.Month.ToString();
            else
                Period = dtBegin.Value.Year.ToString() + "0" + dtBegin.Value.Month.ToString();

            // фильтр
            if (BuildWhereNet() != "")
            {
                if (txtWhere != "")
                    txtWhere += " and " + BuildWhereNet();
                else
                    txtWhere = BuildWhereNet();
            }

            if (BuildWhereMeter() != "")
            {
                if (txtWhere != "")
                    txtWhere += " and " + BuildWhereMeter();
                else
                    txtWhere = BuildWhereMeter();
            }

            SelectSqlData(dsCalc1, dsCalc1.tG_DNU, true, " where PERIOD = " + Period + " and " + txtWhere);

            //if (dataGridView1.RowCount > 0)
            //{
            //    int sumVolume = 0;
            //    for (int i = 0; i < dataGridView1.RowCount; i++)
            //    {
            //        if (dataGridView1.Rows[i].Cells["Quantity"].Value != System.DBNull.Value)
            //            sumVolume = sumVolume + Convert.ToInt32(dataGridView1.Rows[i].Cells["Quantity"].Value);
            //    }
            //    txtSumVolume.Text = sumVolume.ToString();
            //}

        }

        // зальем данные из грида в базу
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
                        InsertSqlData(dsCalc1, dsCalc1.tG_DNU);
                        MessageBox.Show("Загрузка данных завершена ..");
                        dsCalc1.tG_DNU.Rows.Clear();
                    }
            }

        }

        // выберем файл Excel для заливки
        private void buttonFile_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.FileName = textBoxFile.Text;
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = saveFileDialogExport.FileName;
            }
        }


        // проверим была ли заливка за этот период
        private bool CheckFor()
        {
            string Period = "";
            if (dtBegin.Value.Month > 9)
                Period = dtBegin.Value.Year.ToString() + dtBegin.Value.Month.ToString();
            else
                Period = dtBegin.Value.Year.ToString() + "0" + dtBegin.Value.Month.ToString();
            dsCalc1.tG_DNU1.Rows.Clear();
            SelectSqlDataTableOther(dsCalc1, dsCalc1.tG_DNU1, "tG_DNU", true, " where PERIOD = " + Period, 1);
            if (dsCalc1.tG_DNU1.Rows.Count > 0)
            {
                MessageBox.Show("Данные за этот период уже загружены в базу");
                return false;
            }
            dsCalc1.tG_DNU1.Rows.Clear();

            return true;
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
                DataRow row = dsCalc1.tG_DNU.NewRow();
                for (int b = 1; b <= horizontal; b++)
                {
                    switch (myValues.GetValue(1, b).ToString())
                    {
                        case "PERIOD":
                            row["PERIOD"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "UK":
                            row["UK"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "SETI":
                            row["SETI"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "SPECIALIST":
                            row["SPECIALIST"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "GORODOK":
                            row["GORODOK"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "ULICA":
                            row["ULICA"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "DOM":
                            row["DOM"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "KORP":
                            row["KORP"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "PRIBOR":
                            row["PRIBOR"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "NUM_PRIB":
                            row["NUM_PRIB"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "TIPUCHPU":
                            row["TIP_UCH_PU"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "TARIFF":
                            row["TARIFF"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "NOM":
                            row["NOM"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "POKAZN":
                            row["POKAZN"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "POKAZK":
                            row["POKAZK"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "RAZNPOK":
                            row["RAZNOSTPOK"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "KTR":
                            row["KTR"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "OBEMSKTR":
                            row["OBEMSKTR"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "OBEMDLYRAS":
                            row["OBEMDLYRAS"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "RASCHET":
                            row["RASCHET"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "OBEMPROV":
                            row["OBEMPROV"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "PROVAYDER":
                            row["PROVAYDER"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "OBEMURIKI":
                            row["OBEMURIKI"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "OBEMNASEL":
                            row["OBEMNASEL"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "OBEMFORUK":
                            row["OBEMFORUK"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "NORMATIV":
                            row["NORMATIV"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "S_MOP":
                            row["S_MOP"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "OBEMNORM":
                            row["OBEMNORM"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "OBEMMKD":
                            row["OBEMMKD"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                        case "CONST_CODE":
                            row["CONST_CODE"] = (myValues.GetValue(a, b) == null) ? DBNull.Value : myValues.GetValue(a, b);
                            break;
                    }
                }

                dsCalc1.tG_DNU.Rows.Add(row);
            }

            xlWorkBook.Close(true, missing, missing);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            if (textBoxFile.Text != "")
            {
                // проверим была ли заливка за этот период
                if (CheckFor())
                {
                    if (textBoxFile.Text.EndsWith(".xls"))
                    {
                        // процедура заливки из файла в грид
                        processExcel(textBoxFile.Text);
                    }
                    else
                        MessageBox.Show("Выберите файл с расширением .xls для импорта ..");
                }
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        public class myList
        {
            private string id, name;
            public string Id
            {
                get { return id; }
            }
            public myList(string id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public override string ToString()
            {
                return name;
            }
        }

        private string BuildWhereNet()
        {
            string whereNet = "";
            if ((listNet.CheckedItems.Count <= 0) || (listNet.CheckedItems.Count == listNet.Items.Count))
            {
                return whereNet;
            }
            else
            {
                for (int i = 0; i <= (listNet.CheckedItems.Count) - 1; i++)
                {
                    whereNet += "'" + listNet.CheckedItems[i] + "',";
                }
                whereNet = "(SETI in (" + whereNet.Remove(whereNet.Length - 1) + "))";
                return whereNet;
            }
        }

        private string BuildWhereMeter()
        {
            string whereMeter = "";
            if ((listNet.CheckedItems.Count <= 0) || (listNet.CheckedItems.Count == listNet.Items.Count))
            {
                return whereMeter;
            }
            else
            {
                for (int i = 0; i <= (listMeter.CheckedItems.Count) - 1; i++)
                {
                    whereMeter += "'" + listMeter.CheckedItems[i] + "',";
                }
                whereMeter = "(isnull(PRIBOR,'0') + ' ' + isnull(raschet,'') in (" + whereMeter.Remove(whereMeter.Length - 1) + "))";
                return whereMeter;
            }
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(1).AddDays(-1);
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(-1).AddDays(-1);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            SelectSqlData(dsCalc1, dsCalc1.tG_DNUCompareNew, true);
            dsCalc1.tG_DNUCompareNew.Clear();

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";

                strCmd = "select * from fn_LegGetDNUCompare(@dtBegin, @dtEnd, @dtPayBegin, @dtPayEnd)";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);


                string dt1 = "";
                if (dtBegin.Value.Date.Month > 9)
                    dt1 = dtBegin.Value.Date.Year.ToString() + dtBegin.Value.Date.Month.ToString();
                else
                    dt1 = dtBegin.Value.Date.Year.ToString() + "0" + dtBegin.Value.Date.Month.ToString();

                string dt2 = "";
                if (dtEnd.Value.Date.Month > 9)
                    dt2 = dtEnd.Value.Date.Year.ToString() + dtEnd.Value.Date.Month.ToString();
                else
                    dt2 = dtEnd.Value.Date.Year.ToString() + "0" + dtEnd.Value.Date.Month.ToString();

                DateTime dt3 = (DateTime)dtBegin.Value.Date;
                DateTime dt4 = (DateTime)dtEnd.Value.Date;

                SqlParameter p1 = new SqlParameter("@dtBegin", dt1);
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@dtEnd", dt2);
                sqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@dtPayBegin", dt3.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p3);

                SqlParameter p4 = new SqlParameter("@dtPayEnd", dt4.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p4);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCalc1, "tG_DNUCompareNew");

                // итоговые суммы
                //if (dgvCompare.Rows.Count > 0)
                //{
                //    double VFull = 0;
                //    double VDevice = 0;
                //    double VCalc = 0;
                //    double VLegal = 0;
                //    double VCompany = 0;
                //    int VUlges = 0;
                //    double VMore = 0;
                //    double VLess = 0;

                //    var cars = from car in dsCalc1.tG_DNUCompareNew.AsEnumerable() group car by car.Period;
                //    foreach (var item in cars)
                //    {
                //        foreach (DataRow r in item)
                //        {
                //            if (r["VolumeFull"] != DBNull.Value)
                //                VFull += r.Field<double>("VolumeFull");

                //            if (r["VolumeDevice"] != DBNull.Value)
                //                VDevice += r.Field<double>("VolumeDevice");

                //            if (r["VolumeCalc"] != DBNull.Value)
                //                VCalc += r.Field<double>("VolumeCalc");

                //            if (r["VolumeLegal"] != DBNull.Value)
                //                VLegal += r.Field<double>("VolumeLegal");

                //            if (r["VolumeCompany"] != DBNull.Value)
                //                VCompany += r.Field<double>("VolumeCompany");

                //            if (r["VolumeUlges"] != DBNull.Value)
                //                VUlges += r.Field<int>("VolumeULGES");

                //            if (r["VolumeMore"] != DBNull.Value)
                //                VMore += r.Field<double>("VolumeMore");

                //            if (r["VolumeLess"] != DBNull.Value)
                //                VLess += r.Field<double>("VolumeLess");

                //        }
                //    }
                //    dsCalc1.tG_DNUCompareNew.Rows.Add(new object[] { null, "Итого", null, null, VFull, VDevice, VCalc, VLegal, VCompany, VUlges, VMore, VLess});


                   // txtQuantityOur.Text = QuantityOur.ToString("# ### ### ###");
                   // txtQuantityTheir.Text = QuantityTheir.ToString("# ### ### ###");
                //}
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvCompare.Rows.Count > 0) 
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

                int ColCount = dataGridView1.Columns.Count;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:K").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:K").Font.Size = 10;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "K2").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "K2").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "K2").Font.Size = 12;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "K1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "K1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "K1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "K1").Value2 = "Анализ по ДНУ";

                xlWorkSheet.get_Range("A2", "K2").Merge(misValue);
                xlWorkSheet.get_Range("A2", "K2").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "K2").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "K2").Value2 = "за период с " + dtBegin.Value.Date.ToShortDateString() + " по " + dtEnd.Value.Date.ToShortDateString();

                int i = 0;
                int j = 0;
                int k = 4;

                // заголовок таблицы
                xlWorkSheet.get_Range("A" + k, misValue).Value2 = "Улица";
                xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Дом";
                xlWorkSheet.get_Range("C" + k, misValue).Value2 = "УЭ МКД";
                xlWorkSheet.get_Range("D" + k, misValue).Value2 = "УЭ провайдеры";
                xlWorkSheet.get_Range("E" + k, misValue).Value2 = "УЭ население";
                xlWorkSheet.get_Range("F" + k, misValue).Value2 = "УЭ ЮЛ";
                xlWorkSheet.get_Range("G" + k, misValue).Value2 = "УЭ УК";
                xlWorkSheet.get_Range("H" + k, misValue).Value2 = "УльГЭС полный";
                xlWorkSheet.get_Range("I" + k, misValue).Value2 = "УЭ больше УльГЭС";
                xlWorkSheet.get_Range("J" + k, misValue).Value2 = "Вид расчета";
                xlWorkSheet.get_Range("K" + k, misValue).Value2 = "УЭ меньше УльГЭС";

                // установим ширину столбцов
                xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 15;
                xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 8.5;
                xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 8.5;
                xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 8.5;
                xlWorkSheet.get_Range("E:E", misValue).ColumnWidth = 8.5;
                xlWorkSheet.get_Range("F:F", misValue).ColumnWidth = 8.5;
                xlWorkSheet.get_Range("G:G", misValue).ColumnWidth = 8.5;
                xlWorkSheet.get_Range("H:H", misValue).ColumnWidth = 8.5;
                xlWorkSheet.get_Range("I:I", misValue).ColumnWidth = 10.8;
                xlWorkSheet.get_Range("J:J", misValue).ColumnWidth = 10.8;
                xlWorkSheet.get_Range("K:K", misValue).ColumnWidth = 10.8;

                xlWorkSheet.get_Range("A" + k, "K" + k).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A" + k, "K" + k).HorizontalAlignment = Excel.Constants.xlLeft;

                // вывод данных в ячейки
                for (i = 0; i <= dgvCompare.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgvCompare.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvCompare[j, i];
                        if (j == 1)
                            xlWorkSheet.Cells[i + k + 1, j+1] = cell.Value.ToString().Replace("/", "//"); 
                        else
                            xlWorkSheet.Cells[i + k + 1, j+1] = cell.Value;
                    }
                }

                // форматирование данных
                xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "Общий";
                xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("D:D", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("E:E", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("F:F", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("G:G", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("H:H", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("I:I", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("J:J", misValue).NumberFormat = "Общий";
                xlWorkSheet.get_Range("K:K", misValue).NumberFormat = "### ##0";

                //
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k + dgvCompare.RowCount, ColCount]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k + dgvCompare.RowCount, ColCount]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

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

  



  

  


    }
}
