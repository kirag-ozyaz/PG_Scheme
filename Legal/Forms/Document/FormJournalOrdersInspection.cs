using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ControlsLbr;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;


namespace Legal.Forms.Document
{
    public partial class FormJournalOrdersInspection : FormLbr.FormBase
    {
        private DialogResult result;

        public FormJournalOrdersInspection()
        {
            InitializeComponent();
        }

        private void FormJournalOrdersInspection_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            int year = DateTime.Now.Date.Year;
            dtBegin.Value = new DateTime(year, 1, 1);
            dtEnd.Value = new DateTime(year, 12, 31);

            SelectSqlData(dsAbnDocum1, dsAbnDocum1.vJournalOrdersInspection, true, " where" + BuildWhereDate() + " order by NumberOrder desc");
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

        private string BuildWhereDate()
        {
            string txtWhereDate = "";
            txtWhereDate += " (DateOrder >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                " (DateOrder <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            return txtWhereDate;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // найдем последний номер в журнале и дату текущего журнала
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.tJournalOrdersInspection, true, " order by id desc" );
            int MaxNumber = 0;
            DateTime CurrentJournalDate = DateTime.Now.Date;
            if (dsAbnDocum1.tJournalOrdersInspection.Rows.Count > 0)
            {
                if (dsAbnDocum1.tJournalOrdersInspection.Rows[0]["NumberJournal"] != DBNull.Value)
                    MaxNumber = Convert.ToInt32(dsAbnDocum1.tJournalOrdersInspection.Rows[0]["NumberJournal"]);
                if (dsAbnDocum1.tJournalOrdersInspection.Rows[0]["DateJournal"] != DBNull.Value)
                    CurrentJournalDate = Convert.ToDateTime(dsAbnDocum1.tJournalOrdersInspection.Rows[0]["DateJournal"]);
            }
            MaxNumber = MaxNumber + 1;


            // добавим новую запись в журнал
            dsAbnDocum1.tJournalOrdersInspection.Rows.Clear();
            DataRow dr = dsAbnDocum1.tJournalOrdersInspection.NewRow();
            dr["NumberJournal"] = MaxNumber;
            dr["DateJournal"] = CurrentJournalDate;
            dr["DateOrder"] = DateTime.Now.Date;
            dr["AuthorOrder"] = Environment.UserName;
            dr["DateCurrent"] = DateTime.Now;
            dr["Deleted"] = 0;
            dsAbnDocum1.tJournalOrdersInspection.Rows.Add(dr);
            int idJournal = 0;
            idJournal = InsertSqlDataOneRow(dsAbnDocum1, dsAbnDocum1.tJournalOrdersInspection);

            if (idJournal > 0)
            {
                Document.FormOrderInspection fAdd = new Document.FormOrderInspection(idJournal);
                fAdd.SqlSettings = this.SqlSettings;
                if (fAdd.ShowDialog() == DialogResult.OK)
                    LoadJournal(idJournal);
            }
            else
            {
                MessageBox.Show("Не удается создать запись в журнале распоряжений");
                return;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvJournal.Rows.Count > 0)
            {
                int CurrentRowId = Convert.ToInt32(dgvJournal.CurrentRow.Cells["idDGV"].Value);
                Document.FormOrderInspection fAdd = new Document.FormOrderInspection(CurrentRowId);
                fAdd.SqlSettings = this.SqlSettings;
                fAdd.Text = "Распоряжение №" + dgvJournal.CurrentRow.Cells["numberOrderDataGridViewTextBoxColumn"].Value +
                    " от " + dgvJournal.CurrentRow.Cells["dateOrderDataGridViewTextBoxColumn"].Value;
                if (fAdd.ShowDialog() == DialogResult.OK)
                    LoadJournal(CurrentRowId);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int CurrentRowId = Convert.ToInt32(dgvJournal.CurrentRow.Cells["idDGV"].Value);
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.tJournalOrdersInspection, true, "where id = " + CurrentRowId);
            dsAbnDocum1.tJournalOrdersInspection.Rows[0].BeginEdit();
            dsAbnDocum1.tJournalOrdersInspection.Rows[0]["Deleted"] = -1;
            dsAbnDocum1.tJournalOrdersInspection.Rows[0].EndEdit();
            UpdateSqlData(dsAbnDocum1, dsAbnDocum1.tJournalOrdersInspection);
            dsAbnDocum1.tJournalOrdersInspection.Rows.Clear();
            if (dgvJournal.Rows.Count > 0)
                LoadJournal(CurrentRowId - 1);
            else
                LoadJournal(CurrentRowId);
        }

        private void LoadJournal()
        {
            dsAbnDocum1.vJournalOrdersInspection.Clear();
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.vJournalOrdersInspection, true, " where" + BuildWhereDate() + " order by NumberOrder desc");
            dgvJournal.Refresh();
        }
        /// <summary>
        /// загрузка с последующим позиционированием на текущей ячейке
        /// </summary>
        /// <param name="RowId"></param>
        private void LoadJournal(int RowId)
        {
            dsAbnDocum1.vJournalOrdersInspection.Clear();
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.vJournalOrdersInspection, true, " where" + BuildWhereDate() + " order by NumberOrder desc");
            dgvJournal.Refresh();
            // надо сделать отображение таблицы по текущему фокусу

            for (int i = 0; i < dgvJournal.Rows.Count; i++)
            {
                if ((int)dgvJournal.Rows[i].Cells["idDGV"].Value == RowId)
                {
                    dgvJournal.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void dgvJournal_DoubleClick(object sender, EventArgs e)
        {
        }

        private void cmbPrintOrder_Click(object sender, EventArgs e)
        {
            FormRep.FormRepOrder fOrder = new FormRep.FormRepOrder(Convert.ToInt32(dgvJournal.CurrentRow.Cells["idDGV"].Value));
            fOrder.SqlSettings = this.SqlSettings;
            fOrder.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.vJournalOrdersInspection, true, " where" + BuildWhereDate());
            dgvJournal.Refresh();
        }

        private void cmbExportExcel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.ApplicationClass();


            // определимся нужно ли создавать новый файл или записывать в существующий
            result = MessageBox.Show("Записать в существующий файл?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string fileName = "";
                if (openFileDialogExport.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialogExport.FileName;
                    xlWorkBook = xlApp.Workbooks.Open(fileName);
                }
                else
                    return;
            }
            else
            {
                xlWorkBook = xlApp.Workbooks.Add(misValue);
            }

            this.Cursor = Cursors.WaitCursor;

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Add(misValue);

            xlWorkSheet.Name = dgvJournal.CurrentRow.Cells["contractorDataGridViewTextBoxColumn"].Value.ToString();

            // шрифт для всего листа
            xlWorkSheet.get_Range("A:E").Font.Name = "Arial";
            xlWorkSheet.get_Range("A:E").Font.Size = 9;

            xlWorkSheet.get_Range("A3", "N3").Font.Bold = true;

            // заголовок таблицы
            xlWorkSheet.get_Range("A3", misValue).Value2 = "№ дог.";
            xlWorkSheet.get_Range("B3", misValue).Value2 = "Наименование потребителя";
            xlWorkSheet.get_Range("C3", misValue).Value2 = "Контакты";
            xlWorkSheet.get_Range("D3", misValue).Value2 = "№ об.";
            xlWorkSheet.get_Range("E3", misValue).Value2 = "Адрес объекта";
            xlWorkSheet.get_Range("F3", misValue).Value2 = "Наименование объекта";
            xlWorkSheet.get_Range("G3", misValue).Value2 = "Тип сч.";
            xlWorkSheet.get_Range("H3", misValue).Value2 = "Номер сч.";
            xlWorkSheet.get_Range("I3", misValue).Value2 = "ГП сч.";
            xlWorkSheet.get_Range("J3", misValue).Value2 = "ГП т/т";
            xlWorkSheet.get_Range("K3", misValue).Value2 = "Ктт";
            xlWorkSheet.get_Range("L3", misValue).Value2 = "Показание сч.";
            xlWorkSheet.get_Range("M3", misValue).Value2 = "Дата пред.акта";
            xlWorkSheet.get_Range("N3", misValue).Value2 = "Р уст.";

            // установим ширину столбцов
            xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 5.5;
            xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 18;
            xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 11;
            xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 2.86;
            xlWorkSheet.get_Range("E:E", misValue).ColumnWidth = 15.5;
            xlWorkSheet.get_Range("F:F", misValue).ColumnWidth = 22;
            xlWorkSheet.get_Range("G:G", misValue).ColumnWidth = 5.5;
            xlWorkSheet.get_Range("H:H", misValue).ColumnWidth = 15;
            xlWorkSheet.get_Range("I:I", misValue).ColumnWidth = 5.5;
            xlWorkSheet.get_Range("J:J", misValue).ColumnWidth = 5.5;
            xlWorkSheet.get_Range("K:K", misValue).ColumnWidth = 5;
            xlWorkSheet.get_Range("L:L", misValue).ColumnWidth = 9;
            xlWorkSheet.get_Range("M:M", misValue).ColumnWidth = 9;
            xlWorkSheet.get_Range("N:N", misValue).ColumnWidth = 3.5;

            // шрифт для наименования отчета
            xlWorkSheet.get_Range("A1", "N1").Font.Name = "Arial";
            xlWorkSheet.get_Range("A1", "G1").Font.Size = 12;
            xlWorkSheet.get_Range("A4", "G3").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            int ID = Convert.ToInt32(dgvJournal.CurrentRow.Cells["idDGV"].Value);
            this.SelectSqlDataTableOther(dsAbnDocum1, dsAbnDocum1.vJournalOrdersInspection1, "vJournalOrdersInspection", true, " where id = " + ID);

            // наименование отчета
            xlWorkSheet.get_Range("A1", "E1").Merge(misValue);
            xlWorkSheet.get_Range("A1", "E1").VerticalAlignment = Excel.Constants.xlCenter;
            xlWorkSheet.get_Range("A1", "E1").HorizontalAlignment = Excel.Constants.xlCenter;

            string nn = "РАСПОРЯЖЕНИЕ №" + dsAbnDocum1.vJournalOrdersInspection1.Rows[0]["NumberOrder"].ToString();
            xlWorkSheet.get_Range("A1", "E1").Value2 = nn;

            xlWorkSheet.get_Range("G1", "N1").Merge(misValue);
            xlWorkSheet.get_Range("G1", "N1").VerticalAlignment = Excel.Constants.xlCenter;
            xlWorkSheet.get_Range("G1", "N1").HorizontalAlignment = Excel.Constants.xlLeft;

            nn = "на " + Convert.ToDateTime(dsAbnDocum1.vJournalOrdersInspection1.Rows[0]["DateOrder"]).ToLongDateString();
            xlWorkSheet.get_Range("G1", "N1").Value2 = nn;

            xlWorkSheet.get_Range("A2", "N2").Merge(misValue);
            xlWorkSheet.get_Range("A2", "N2").VerticalAlignment = Excel.Constants.xlCenter;
            xlWorkSheet.get_Range("A2", "N2").HorizontalAlignment = Excel.Constants.xlCenter;

            nn = dsAbnDocum1.vJournalOrdersInspection.Rows[0]["pContractor"].ToString() + " участка по работе с юридическими лицами СКУЭЭ МУП УльГЭС " + dsAbnDocum1.vJournalOrdersInspection.Rows[0]["Contractor"].ToString() + " " + dsAbnDocum1.vJournalOrdersInspection.Rows[0]["aContractor"].ToString() + "гр.";
            xlWorkSheet.get_Range("A2", "N2").Value2 = nn;

            int idJournal = (int)dsAbnDocum1.vJournalOrdersInspection1.Rows[0]["id"];
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.vOrdersInspection, true, " where idJournal = " + idJournal);


            // вывод данных в ячейки
            int i = 0;
            //int j = 0;
            for (i = 0; i < dsAbnDocum1.vOrdersInspection.Rows.Count; i++)
            {
                xlWorkSheet.Cells[i + 4, 1] = dsAbnDocum1.vOrdersInspection.Rows[i]["CodeAbonent"].ToString();
                xlWorkSheet.Cells[i + 4, 2] = dsAbnDocum1.vOrdersInspection.Rows[i]["Name"].ToString();
                xlWorkSheet.Cells[i + 4, 3] = dsAbnDocum1.vOrdersInspection.Rows[i]["AbnPhone"].ToString();
                xlWorkSheet.Cells[i + 4, 4] = dsAbnDocum1.vOrdersInspection.Rows[i]["NumberObj"].ToString();
                xlWorkSheet.Cells[i + 4, 5] = dsAbnDocum1.vOrdersInspection.Rows[i]["ObjAdress"].ToString();
                xlWorkSheet.Cells[i + 4, 6] = dsAbnDocum1.vOrdersInspection.Rows[i]["NameObj"].ToString();
                xlWorkSheet.Cells[i + 4, 7] = dsAbnDocum1.vOrdersInspection.Rows[i]["NameMeter"].ToString();
                xlWorkSheet.Cells[i + 4, 8] = dsAbnDocum1.vOrdersInspection.Rows[i]["Number"].ToString();
                xlWorkSheet.Cells[i + 4, 9] = dsAbnDocum1.vOrdersInspection.Rows[i]["GosEndMeter"].ToString();
                xlWorkSheet.Cells[i + 4, 10] = dsAbnDocum1.vOrdersInspection.Rows[i]["GosEndTrans"].ToString();
                xlWorkSheet.Cells[i + 4, 11] = dsAbnDocum1.vOrdersInspection.Rows[i]["Ktran"].ToString();
                xlWorkSheet.Cells[i + 4, 12] = dsAbnDocum1.vOrdersInspection.Rows[i]["Values"].ToString();
                if (dsAbnDocum1.vOrdersInspection.Rows[i]["DateAct"] != DBNull.Value)
                    xlWorkSheet.Cells[i + 4, 13] = Convert.ToDateTime(dsAbnDocum1.vOrdersInspection.Rows[i]["DateAct"]).ToShortDateString();
                xlWorkSheet.Cells[i + 4, 14] = dsAbnDocum1.vOrdersInspection.Rows[i]["PowerSet"].ToString();
            }

            // форматирование данных
            xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "##0";
            ////xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "Общий";
            ////xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "Общий";
            xlWorkSheet.get_Range("D:D", misValue).NumberFormat = "##0";
            ////xlWorkSheet.get_Range("E:E", misValue).NumberFormat = "Общий";
            ////xlWorkSheet.get_Range("F:F", misValue).NumberFormat = "Общий";
            ////xlWorkSheet.get_Range("G:G", misValue).NumberFormat = "Общий";
            xlWorkSheet.get_Range("H:H", misValue).NumberFormat = "##0";
            ////xlWorkSheet.get_Range("I:I", misValue).NumberFormat = "Общий";
            ////xlWorkSheet.get_Range("J:J", misValue).NumberFormat = "Общий";
            ////xlWorkSheet.get_Range("K:K", misValue).NumberFormat = "Общий";
            ////xlWorkSheet.get_Range("L:L", misValue).NumberFormat = "Общий";
            ////xlWorkSheet.get_Range("M:M", misValue).NumberFormat = "Общий";
            xlWorkSheet.get_Range("N:N", misValue).NumberFormat = "##0";


            xlWorkSheet.get_Range("A:A", misValue).WrapText = true;
            xlWorkSheet.get_Range("B:B", misValue).WrapText = true;
            xlWorkSheet.get_Range("C:C", misValue).WrapText = true;
            xlWorkSheet.get_Range("D:D", misValue).WrapText = true;
            xlWorkSheet.get_Range("E:E", misValue).WrapText = true;
            xlWorkSheet.get_Range("F:F", misValue).WrapText = true;
            xlWorkSheet.get_Range("G:G", misValue).WrapText = true;
            xlWorkSheet.get_Range("H:H", misValue).WrapText = true;
            xlWorkSheet.get_Range("I:I", misValue).WrapText = true;
            xlWorkSheet.get_Range("J:J", misValue).WrapText = true;
            xlWorkSheet.get_Range("K:K", misValue).WrapText = true;
            xlWorkSheet.get_Range("L:L", misValue).WrapText = true;
            xlWorkSheet.get_Range("M:M", misValue).WrapText = true;
            xlWorkSheet.get_Range("N:N", misValue).WrapText = true;


            xlWorkSheet.get_Range(xlWorkSheet.Cells[i + 5, 3], xlWorkSheet.Cells[i + 5, 14]).Merge(misValue);
            nn = "Распоряжение выдал _________________ /" + dsAbnDocum1.vJournalOrdersInspection.Rows[0]["pManager"] + " " + dsAbnDocum1.vJournalOrdersInspection.Rows[0]["Manager"] + " " + dsAbnDocum1.vJournalOrdersInspection.Rows[0]["aManager"]  + "гр./";
            xlWorkSheet.get_Range(xlWorkSheet.Cells[i + 5, 3], xlWorkSheet.Cells[i + 5, 14]).Value2 = nn ;                

            xlWorkSheet.get_Range(xlWorkSheet.Cells[i + 5, 3], xlWorkSheet.Cells[i + 5, 14]).HorizontalAlignment = Excel.Constants.xlLeft;

            xlWorkSheet.get_Range(xlWorkSheet.Cells[3, 1], xlWorkSheet.Cells[i + 3, 14]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            xlWorkSheet.get_Range(xlWorkSheet.Cells[3, 1], xlWorkSheet.Cells[i + 3, 14]).Borders.Weight = Excel.XlBorderWeight.xlThin;

            xlWorkSheet.get_Range(xlWorkSheet.Cells[3, 1], xlWorkSheet.Cells[i + 5, 14]).Font.Name = "Arial";
            xlWorkSheet.get_Range(xlWorkSheet.Cells[3, 1], xlWorkSheet.Cells[i + 5, 14]).Font.Size = 9;

            xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

            xlWorkSheet.PageSetup.LeftMargin = 5;
            xlWorkSheet.PageSetup.RightMargin = 5;
            xlWorkSheet.PageSetup.BottomMargin = 7;
            xlWorkSheet.PageSetup.TopMargin = 8;


            this.Cursor = Cursors.Default;
            xlApp.Visible = true;

        }
        /// <summary>
        /// редактирование текущей ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvJournal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvJournal.Rows.Count > 0)
            {
               
                int CurrentRowId = Convert.ToInt32(dgvJournal.CurrentRow.Cells["idDGV"].Value);
                Document.FormOrderInspection fAdd = new Document.FormOrderInspection(CurrentRowId);
                fAdd.SqlSettings = this.SqlSettings;
                fAdd.MdiParent = this.MdiParent;
                fAdd.Text = "Распоряжение №" + dgvJournal.CurrentRow.Cells["numberOrderDataGridViewTextBoxColumn"].Value + 
                    " от " + dgvJournal.CurrentRow.Cells["dateOrderDataGridViewTextBoxColumn"].Value;
                fAdd.Show();

                LoadJournal(CurrentRowId);
            }
        }
    }
}
