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


namespace Legal.Forms.Calculat
{
    public partial class FormReportPeriod : FormLbr.FormBase
    {
        public FormReportPeriod()
        {
            InitializeComponent();
        }

        private string BuildWhereDate()
        {
            string txtWhereDate = "";
            txtWhereDate += " (dtPay >= '" + dtBegin.Value.Date.ToString("yyyyMM") + "') and " +
                " (dtPay <= '" + dtEnd.Value.Date.ToString("yyyyMM") + "') ";
            return txtWhereDate;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dsCnt1.vG_ReportVolume_Period.Rows.Clear();
            this.dgv.Columns.Clear();

            string txtWhere = "";
            txtWhere += BuildWhereDate();

            #region Запрос к серверу
                SelectSqlData(dsCnt1, dsCnt1.vG_ReportVolume_Period, true, "where " + txtWhere + " order by Worker, dtPay");
//                 SelectSqlData(dsCnt1, dsCnt1.vG_ReportVolume_Period, true);
            #endregion

            #region Cоздание временной таблицы и грида с месячными данными по горизонтали
            
            DataTable dt = new DataTable("dtReportMain");

            DataGridViewCellStyle IntStyle = new DataGridViewCellStyle();
            IntStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            IntStyle.Format = "N0";

            DataGridViewCellStyle StringStyle = new DataGridViewCellStyle();
            StringStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dt.Columns.Add(new DataColumn("Специалист", typeof(string)));

            DataGridViewColumn Title = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Title.Name = "Title";
            dgv.Columns.Add(Title);
             
            dgv.Columns["Title"].Width = 150;
            dgv.Columns["Title"].HeaderText = "Специалист";
            dgv.Columns["Title"].ValueType = typeof(string);
            dgv.Columns["Title"].DefaultCellStyle = StringStyle;
            dgv.Columns["Title"].DataPropertyName = "Специалист";

            int numMonth = ((dtEnd.Value.Year - dtBegin.Value.Year) * 12) + dtEnd.Value.Month - dtBegin.Value.Month;
            DateTime dtDate = new DateTime(dtBegin.Value.Year, dtBegin.Value.Month, dtBegin.Value.Day);

            string nameField = dtDate.Year.ToString() + dtDate.Month.ToString();
            string field1 = "Всего-";
            string field2 = "Нас-";
            string field3 = "Пр-";
            string field4 = "ДНУ-";
            string field5 = "Потр-";
            string field6 = "Об-";
            string field7 = "Сч-";

            DataGridViewTextBoxColumn[] col1 = new DataGridViewTextBoxColumn[numMonth+1];
            DataGridViewTextBoxColumn[] col2 = new DataGridViewTextBoxColumn[numMonth+1];
            DataGridViewTextBoxColumn[] col3 = new DataGridViewTextBoxColumn[numMonth+1];
            DataGridViewTextBoxColumn[] col4 = new DataGridViewTextBoxColumn[numMonth+1];
            DataGridViewTextBoxColumn[] col5 = new DataGridViewTextBoxColumn[numMonth+1];
            DataGridViewTextBoxColumn[] col6 = new DataGridViewTextBoxColumn[numMonth+1];
            DataGridViewTextBoxColumn[] col7 = new DataGridViewTextBoxColumn[numMonth+1];


            for (int i = 0; i <= numMonth; i++)
            {
                field1 = "Всего-";
                field2 = "Нас-";
                field3 = "Пр-";
                field4 = "ДНУ-";
                field5 = "Потр-";
                field6 = "Об-";
                field7 = "Сч-";

                field1 = field1 + nameField;
                field2 = field2 + nameField;
                field3 = field3 + nameField;
                field4 = field4 + nameField;
                field5 = field5 + nameField;
                field6 = field6 + nameField;
                field7 = field7 + nameField;

                dt.Columns.Add(new DataColumn(field1, typeof(int)));
                dt.Columns.Add(new DataColumn(field2, typeof(int)));
                dt.Columns.Add(new DataColumn(field3, typeof(int)));
                dt.Columns.Add(new DataColumn(field4, typeof(int)));
                dt.Columns.Add(new DataColumn(field5, typeof(int)));
                dt.Columns.Add(new DataColumn(field6, typeof(int)));
                dt.Columns.Add(new DataColumn(field7, typeof(int)));

                col1[i] = new DataGridViewTextBoxColumn();
                col1[i].Name = field1;
                col1[i].Width = 75;
                col1[i].HeaderText = field1;
                col1[i].ValueType = typeof(int);
                col1[i].DefaultCellStyle = IntStyle;
                col1[i].DataPropertyName = field1;

                col2[i] = new DataGridViewTextBoxColumn();
                col2[i].Name = field2;
                col2[i].Width = 75;
                col2[i].HeaderText = field2;
                col2[i].ValueType = typeof(int);
                col2[i].DefaultCellStyle = IntStyle;
                col2[i].DataPropertyName = field2;

                col3[i] = new DataGridViewTextBoxColumn();
                col3[i].Name = field3;
                col3[i].Width = 75;
                col3[i].HeaderText = field3;
                col3[i].ValueType = typeof(int);
                col3[i].DefaultCellStyle = IntStyle;
                col3[i].DataPropertyName = field3;

                col4[i] = new DataGridViewTextBoxColumn();
                col4[i].Name = field4;
                col4[i].Width = 75;
                col4[i].HeaderText = field4;
                col4[i].ValueType = typeof(int);
                col4[i].DefaultCellStyle = IntStyle;
                col4[i].DataPropertyName = field4;

                col5[i] = new DataGridViewTextBoxColumn();
                col5[i].Name = field5;
                col5[i].Width = 75;
                col5[i].HeaderText = field5;
                col5[i].ValueType = typeof(int);
                col5[i].DefaultCellStyle = IntStyle;
                col5[i].DataPropertyName = field5;

                col6[i] = new DataGridViewTextBoxColumn();
                col6[i].Name = field6;
                col6[i].Width = 75;
                col6[i].HeaderText = field6;
                col6[i].ValueType = typeof(int);
                col6[i].DefaultCellStyle = IntStyle;
                col6[i].DataPropertyName = field6;

                col7[i] = new DataGridViewTextBoxColumn();
                col7[i].Name = field7;
                col7[i].Width = 75;
                col7[i].HeaderText = field7;
                col7[i].ValueType = typeof(int);
                col7[i].DefaultCellStyle = IntStyle;
                col7[i].DataPropertyName = field7;

                dgv.Columns.AddRange(new DataGridViewColumn[] { col1[i], col2[i], col3[i], col4[i], col5[i], col6[i], col7[i] });

                dtDate = dtDate.AddMonths(1);

                nameField = dtDate.Year.ToString() + dtDate.Month.ToString(); 
            }

            dsCnt1.Tables.Add(dt);
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            #endregion

            #region Закачиваем данные во временную таблицу с переменным числом столбцов
            int countRows = dsCnt1.vG_ReportVolume_Period.Rows.Count;
            if (countRows > 0)
            {
                string col0 = "";
                int numCol = 0;
                DataRow r;
                r = dt.NewRow();
                for (int i = 0; i <= countRows-1; i++)
                {
                    if (dsCnt1.vG_ReportVolume_Period.Rows[i]["Worker"].ToString() != col0)
                    {
                        if (i != 0) 
                            dt.Rows.Add(r);
                        r = dt.NewRow();
                        r["Специалист"] = dsCnt1.vG_ReportVolume_Period.Rows[i]["Worker"];
                        col0 = dsCnt1.vG_ReportVolume_Period.Rows[i]["Worker"].ToString(); 
                        numCol = 1;
                    }
                    r[numCol++] = dsCnt1.vG_ReportVolume_Period.Rows[i]["Volume"];
                    r[numCol++] = dsCnt1.vG_ReportVolume_Period.Rows[i]["People"];
                    r[numCol++] = dsCnt1.vG_ReportVolume_Period.Rows[i]["Other"];
                    r[numCol++] = dsCnt1.vG_ReportVolume_Period.Rows[i]["DNU"];
                    r[numCol++] = dsCnt1.vG_ReportVolume_Period.Rows[i]["Abonent"];
                    r[numCol++] = dsCnt1.vG_ReportVolume_Period.Rows[i]["Object"];
                    r[numCol++] = dsCnt1.vG_ReportVolume_Period.Rows[i]["Meter"];
                }
                
            }
            this.Cursor = Cursors.Default;
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = bds;


            #endregion


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormReportPeriod_Load_1(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCnt1, dsCnt1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCnt1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCnt1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCnt1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCnt1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);

            //dtBegin.Value = new DateTime(2014,1,1);
            //dtEnd.Value = new DateTime(2016,12,31);
            
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

                // Шапка
                for (int i = 1; i <= dgv.Columns.Count; i++)
                {
                    excelcells = (Excel.Range)xlWorkSheet.Cells[1, i];
                    excelcells.Value2 = dgv.Columns[i - 1].Name;
                }

                int ColCount = dgv.Columns.Count - 1;
                //int i = 0;
                int j = 0;
                int k = 4;
                // вывод данных в ячейки
                int m = dgv.RowCount;
                for (int i = 0; i <= m - 1; i++)
                {
                    for (j = 0; j <= dgv.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgv[j, i];
                        xlWorkSheet.Cells[i + k, j + 1] = cell.Value;
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
