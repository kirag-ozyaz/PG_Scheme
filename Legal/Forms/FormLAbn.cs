using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using FormLbr.Classes;

namespace Legal.Forms
{
    public partial class FormLAbn : FormLbr.FormBase
    {
        public FormLAbn()
        {
            InitializeComponent();
        }

        private void FormLAbn_Load(object sender, EventArgs e)
        {
            cbStatus.ComboBox.SelectedIndex = 0;
            this.SelectSqlData(dataSetLAbn1, dataSetLAbn1.vG_Customer, true);   
        }

        private void AllTotal()
        {
            int AbnTotal;
            int ObjTotal;
            int MeterTotal;
            AbnTotal = 0;
            ObjTotal = 0;
            MeterTotal = 0;
            for (int i = 0; i < dataGridViewAbn.RowCount; i++)
            {
                AbnTotal = AbnTotal + 1;
                ObjTotal = ObjTotal + (int)(dataGridViewAbn.Rows[i].Cells["CountObj"].Value);
                MeterTotal = MeterTotal + (int)(dataGridViewAbn.Rows[i].Cells["CountMeter"].Value);
            }
            this.tBoxAbnCount.Text = AbnTotal.ToString();
            this.tBoxObjCount.Text = ObjTotal.ToString();
            this.tBoxMeterCount.Text = MeterTotal.ToString();
            if (cbStatus.ComboBox.SelectedIndex != 0)
                tBoxObjCount.Text = "";
        }

        private void dataGridViewAbn_Paint(object sender, PaintEventArgs e)
        {
            AllTotal(); 
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewAbn.Rows.Count > 0)
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

                int ColCount = dataGridViewAbn.Columns.Count - 1;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:G").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:G").Font.Size = 10;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "G2").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "G2").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "G2").Font.Size = 12;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "G1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "G1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "G1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "G1").Value2 = "Список потребителей МУП УльГЭС";

                xlWorkSheet.get_Range("A2", "G2").Merge(misValue);
                xlWorkSheet.get_Range("A2", "G2").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "G2").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "G2").Value2 = "на " + System.DateTime.Today.ToShortDateString();

                int i = 0;
                int j = 0;
                int k = 4;

                k = k + 2;
                // заголовок таблицы
                xlWorkSheet.get_Range("A" + k, misValue).Value2 = "№дог";
                xlWorkSheet.get_Range("B" + k, misValue).Value2 = "№дог доп";
                xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Наименование";
                xlWorkSheet.get_Range("D" + k, misValue).Value2 = "Контролер";
                xlWorkSheet.get_Range("E" + k, misValue).Value2 = "Договор";
                xlWorkSheet.get_Range("F" + k, misValue).Value2 = "Объекты";
                xlWorkSheet.get_Range("G" + k, misValue).Value2 = "Счетчики";

                // установим ширину столбцов
                xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 6;
                xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 12;
                xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 75;
                xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 10;
                xlWorkSheet.get_Range("E:E", misValue).ColumnWidth = 10;
                xlWorkSheet.get_Range("F:F", misValue).ColumnWidth = 7;
                xlWorkSheet.get_Range("G:G", misValue).ColumnWidth = 7;

                xlWorkSheet.get_Range("A" + k, "R" + k).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A" + k, "R" + k).HorizontalAlignment = Excel.Constants.xlCenter;

                k = k + 1;
                // вывод данных в ячейки
                int m = dataGridViewAbn.RowCount;
                for (i = 0; i <= m - 1; i++)
                {
                    for (j = 0; j <= dataGridViewAbn.ColumnCount - 2; j++)
                    {
                        DataGridViewCell cell = dataGridViewAbn[j, i];
                        xlWorkSheet.Cells[i + k, j + 1] = cell.Value;
                    }
                    txtCountRows.Text = (i + 1).ToString() + " из " + tBoxAbnCount.Text;
                }

                // форматирование данных
                xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("D:D", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("E:E", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("F:F", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("G:G", misValue).NumberFormat = "### ##0";

                //
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                k = k + m + 2;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).Merge(misValue);
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).Value2 = "Начальник службы контроля и учета электроэнергии                  И.А.Гулько";

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

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.ComboBox.SelectedIndex == 0)
                SelectSqlDataTableOther(dataSetLAbn1, dataSetLAbn1.vG_Customer, "vG_Customer", true, "");
            else
                SelectSqlDataTableOther(dataSetLAbn1, dataSetLAbn1.vG_Customer, "vG_Customer_All", true, "");

        }

        private void btnNumberMonth_Click(object sender, EventArgs e)
        {
            FormNumberMonth frm = new FormNumberMonth();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK) { };
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Legal.Forms.Export.FormExportNewAbn frm = new Legal.Forms.Export.FormExportNewAbn();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK) { };
        }

  
    }
}
