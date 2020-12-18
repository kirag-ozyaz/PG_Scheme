using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using Excel = Microsoft.Office.Interop.Excel;


namespace Legal.Forms.Calculat
{
    public partial class FormReportMeasur : FormLbr.FormBase
    {

        public FormReportMeasur()
        {
            InitializeComponent();
        }

        private class myList
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

        private void FormReportMeasur_Load(object sender, EventArgs e)
        {
            // загрузка режимных дней
            SelectSqlData(dsObj1, dsObj1.vG_MeasurementsDays, true, "order by DateOfIntroduction desc");


            // загрузка подстанций
            DataSet.dsDop.vSchm_ObjListDataTable dt = new DataSet.dsDop.vSchm_ObjListDataTable(); 
            string whereType = "";
            foreach (Constants.SchmTypeSubstation type in Enum.GetValues(typeof(Constants.SchmTypeSubstation)))
                if (type != Constants.SchmTypeSubstation.PPNO)
                {
                    if (string.IsNullOrEmpty(whereType)) whereType = ((int)type).ToString();
                    else whereType += "," + ((int)type).ToString();
                }
            this.SelectSqlData(dt, true, " where typeCodeId in (" + whereType + ") and deleted = 0 order by typeCodeSocr, name");
            foreach (DataRow r in dt.Rows)
                clbStation.Items.Add(new myList(r["id"].ToString(), r["typeCodeSocr"]+"-"+r["Name"].ToString()));

        }

        // условие для подстанций
        private string BuildWhereStation()
        {
            string whereStation = "";
            if ((clbStation.CheckedItems.Count <= 0) || (clbStation.CheckedItems.Count == clbStation.Items.Count))
                return whereStation;
            else
            {
                string whereSchmObj = "";
                for (int i = 0; i <= (clbStation.CheckedItems.Count) - 1; i++)
                    if (string.IsNullOrEmpty(whereSchmObj)) whereSchmObj = ((myList)clbStation.CheckedItems[i]).Id;
                    else whereSchmObj += "," + ((myList)clbStation.CheckedItems[i]).Id;

                if (!string.IsNullOrEmpty(whereSchmObj))
                {
                    DataTable dt = this.SelectSqlData("vL_SchmAbnFull", true, " where subid in (" + whereSchmObj + ") " +
                        " and typeAbn in (" + Constants.Constants.TypeAbnLegalAll + ")");
                    foreach (DataRow r in dt.Rows)
                        if (string.IsNullOrEmpty(whereStation)) whereStation = r["idAbnObj"].ToString();
                        else whereStation += "," + r["idAbnObj"].ToString();
                }
                if (whereStation.Length > 0)
                    whereStation = "(idObj in (" + whereStation + "))";
                
                return whereStation; 
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string txtWhere = "";

            // условие для даты
            txtWhere = "dateOfIntroduction = '" + ((DateTime)cmbDay.SelectedValue).Date.ToString("yyyyMMdd") + "'";

            // условие для подстанций
            string whereSt = BuildWhereStation();
            if (string.IsNullOrEmpty(whereSt))
            {
                if (txtWhere != "")
                    txtWhere += " and " + whereSt;
                else
                    txtWhere = whereSt;
            }

            SelectSqlData(dsObj1, dsObj1.vG_MeasurementReport, true, "where " + txtWhere + " order by CodeAbonent, ObjName");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvMeasur.Rows.Count > 0)
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

                int ColCount = dgvMeasur.Columns.Count;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:D").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:D").Font.Size = 10;

                // заголовок таблицы
                xlWorkSheet.get_Range("A" + 1, misValue).Value2 = "Код";
                xlWorkSheet.get_Range("B" + 1, misValue).Value2 = "Потребитель";
                xlWorkSheet.get_Range("C" + 1, misValue).Value2 = "Объект";
                xlWorkSheet.get_Range("D" + 1, misValue).Value2 = "Мощность";

                // установим ширину столбцов
                xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 8;
                xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 50;
                xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 50;
                xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 12;

                // вывод данных в ячейки
                int m = dgvMeasur.RowCount;
                for (int i = 0; i <= m - 1; i++)
                {
                    for (int j = 0; j <= dgvMeasur.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvMeasur[j, i];
                        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }

                // форматирование данных
                xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "Общий";
                xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "Общий";
                xlWorkSheet.get_Range("D:D", misValue).NumberFormat = "### ##0,0000";

                xlWorkSheet.get_Range(xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[m, ColCount]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[m, ColCount]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                xlWorkSheet.PageSetup.LeftMargin = 80;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;

                xlApp.Visible = true;
                this.Cursor = Cursors.Default;
            }
            else
                MessageBox.Show("Нет данных для отчета ..");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
