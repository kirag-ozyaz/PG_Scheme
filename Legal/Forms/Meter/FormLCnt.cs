using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Legal.Forms.Meter
{
    public partial class FormLCnt : FormLbr.FormBase
    {
        public FormLCnt()
        {
            InitializeComponent();
        }

        private void FormLCnt_Load(object sender, EventArgs e)
        {
            cbStatus.ComboBox.SelectedIndex = 0;
            this.SelectSqlData(dsCnt, dsCnt.vG_AbnObjMeter_New, true, "order By Ndog, Consumer, ObjName, Number");   
        }

        private void MeterCount()
        {
            int MeterTotal;
            MeterTotal = 0;
            for (int i = 0; i < dgvListMeter.RowCount; i++)
            {
                MeterTotal = MeterTotal + 1;
            }
            this.txtMeterCount.Text = MeterTotal.ToString();
        }

        private void dgvListMeter_Paint(object sender, PaintEventArgs e)
        {
            MeterCount();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.ComboBox.SelectedIndex == 0)
                SelectSqlDataTableOther(dsCnt, dsCnt.vG_AbnObjMeter_New, "vG_AbnObjMeter_New", true, "order By Ndog, Consumer, ObjName, Number");
            else
                SelectSqlDataTableOther(dsCnt, dsCnt.vG_AbnObjMeter_New, "vG_AbnObjMeter_New_All", true, "order By Ndog, Consumer, ObjName, Number");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            if (dgvListMeter.Rows.Count > 0) 
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

                int ColCount = dgvListMeter.Columns.Count;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:R").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:R").Font.Size = 10;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "R2").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "R2").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "R2").Font.Size = 12;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "R1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "R1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "R1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "R1").Value2 = "Список приборов учета";

                xlWorkSheet.get_Range("A2", "R2").Merge(misValue);
                xlWorkSheet.get_Range("A2", "R2").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "R2").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "R2").Value2 = "на " + System.DateTime.Today.ToShortDateString();

                int i = 0;
                int j = 0;
                int k = 4;

                k = k + 2;
                    // заголовок таблицы
                    xlWorkSheet.get_Range("A" + k, misValue).Value2 = "№дог";
                    xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Потребитель";
                    xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Объект";
                    xlWorkSheet.get_Range("D" + k, misValue).Value2 = "Номер";
                    xlWorkSheet.get_Range("E" + k, misValue).Value2 = "Тип";
                    xlWorkSheet.get_Range("F" + k, misValue).Value2 = "Разрядность";
                    xlWorkSheet.get_Range("G" + k, misValue).Value2 = "Фазность";
                    xlWorkSheet.get_Range("H" + k, misValue).Value2 = "Напряжение";
                    xlWorkSheet.get_Range("I" + k, misValue).Value2 = "Точность";
                    xlWorkSheet.get_Range("J" + k, misValue).Value2 = "Интервал";
                    xlWorkSheet.get_Range("K" + k, misValue).Value2 = "КолТариф";
                    xlWorkSheet.get_Range("L" + k, misValue).Value2 = "ТарифГруппа";
                    xlWorkSheet.get_Range("M" + k, misValue).Value2 = "КоэфТр";
                    xlWorkSheet.get_Range("N" + k, misValue).Value2 = "ДатаУст";
                    xlWorkSheet.get_Range("O" + k, misValue).Value2 = "Установка";
                    xlWorkSheet.get_Range("P" + k, misValue).Value2 = "ДатаПов";
                    xlWorkSheet.get_Range("Q" + k, misValue).Value2 = "ДатаДем";
                    xlWorkSheet.get_Range("R" + k, misValue).Value2 = "Демонтаж";
                    xlWorkSheet.get_Range("S" + k, misValue).Value2 = "Расположение";
                    xlWorkSheet.get_Range("T" + k, misValue).Value2 = "Договор";

                    // установим ширину столбцов
                    xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 6;
                    xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 30;
                    xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 30;
                    xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 25;
                    xlWorkSheet.get_Range("E:E", misValue).ColumnWidth = 7;
                    xlWorkSheet.get_Range("F:F", misValue).ColumnWidth = 7;
                    xlWorkSheet.get_Range("G:G", misValue).ColumnWidth = 7;
                    xlWorkSheet.get_Range("H:H", misValue).ColumnWidth = 7;
                    xlWorkSheet.get_Range("I:I", misValue).ColumnWidth = 7;
                    xlWorkSheet.get_Range("J:J", misValue).ColumnWidth = 7;
                    xlWorkSheet.get_Range("K:K", misValue).ColumnWidth = 7;
                    xlWorkSheet.get_Range("L:L", misValue).ColumnWidth = 10;
                    xlWorkSheet.get_Range("M:M", misValue).ColumnWidth = 7;
                    xlWorkSheet.get_Range("N:N", misValue).ColumnWidth = 10;
                    xlWorkSheet.get_Range("O:O", misValue).ColumnWidth = 10;
                    xlWorkSheet.get_Range("P:P", misValue).ColumnWidth = 10;
                    xlWorkSheet.get_Range("Q:Q", misValue).ColumnWidth = 10;
                    xlWorkSheet.get_Range("R:R", misValue).ColumnWidth = 10;
                    xlWorkSheet.get_Range("S:S", misValue).ColumnWidth = 30;
                    xlWorkSheet.get_Range("T:T", misValue).ColumnWidth = 30;

                xlWorkSheet.get_Range("A" + k, "T" + k).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A" + k, "T" + k).HorizontalAlignment = Excel.Constants.xlCenter;

                // форматирование данных
                xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("D:D", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("E:E", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("F:F", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("G:G", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("H:H", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("I:I", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("J:J", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("K:K", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("L:L", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("M:M", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("N:N", misValue).NumberFormat = "";
                xlWorkSheet.get_Range("O:O", misValue).NumberFormat = "";
                xlWorkSheet.get_Range("P:P", misValue).NumberFormat = "";
                xlWorkSheet.get_Range("Q:Q", misValue).NumberFormat = "";
                xlWorkSheet.get_Range("R:R", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("S:S", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("T:T", misValue).NumberFormat = "@";


                k = k + 1;
                // вывод данных в ячейки
                int m = dgvListMeter.RowCount;
                for (i = 0; i <= m - 1; i++)
                {
                    for (j = 0; j <= dgvListMeter.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvListMeter[j, i];
                        xlWorkSheet.Cells[i + k, j + 1] = cell.Value;
                    }
                    txtCountRows.Text = (i+1).ToString() + " из " + txtMeterCount.Text; 
                }


                //
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                k = k + m + 2;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).Merge(misValue);
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).Value2 = "Начальник службы контроля и учета электроэнергии                  И.А.Гулько";

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

        private void btnReportCountMeter_Click(object sender, EventArgs e)
        {
            Legal.Forms.Meter.FormCountMeter frm = new Legal.Forms.Meter.FormCountMeter();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            this.dgvListMeter.ExportToExcel();
        }
    }
}
