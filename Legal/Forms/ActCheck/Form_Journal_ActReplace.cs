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
using FormLbr.Classes;

namespace Legal.Forms.ActCheck
{
    public partial class Form_Journal_ActReplace : FormLbr.FormBase
    {
        System.Diagnostics.Process proc = new System.Diagnostics.Process();
        bool st = false;
        private int RowsCheck;


        public Form_Journal_ActReplace()
        {
            InitializeComponent();
        }

        private void Form_Journal_ActReplace_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            int year = DateTime.Now.Date.Year;
            dtBegin.Value = new DateTime(year, 1, 1);
            dtEnd.Value = new DateTime(year, 12, 31);

            SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_Journal_ActCheck, true, " where" + BuildWhereDate() + " order by DateAct, DocNumber asc");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddYears(1);
            dtEnd.Value = dtEnd.Value.AddYears(1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddYears(-1);
            dtEnd.Value = dtEnd.Value.AddYears(-1);
        }

        private string BuildWhereDate()
        {
            string txtWhereDate = "";
            txtWhereDate += " (DateAct >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                " (DateAct <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            return txtWhereDate;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dsAbnDocum1.vG_Journal_ActCheck.Clear();
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_Journal_ActCheck, true, " where" + BuildWhereDate() + " order by DocNumber desc");
        }

        private void btnExport_Click(object sender, EventArgs e)
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

                string fileName = "";
                saveFileDialogExport.FileName = "Акты";
                saveFileDialogExport.DefaultExt = "xlsx";
                saveFileDialogExport.AddExtension = true;
                string pathName = "";
                string fileSave = "";
                DateTime dateAct;
                string strdtAct;
                Bitmap bmp;

                if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
                {
                    // Имя файла Excel
                    fileName = saveFileDialogExport.FileName;
                    // Создаем каталог куда будем записывать файлы со сканами
                    pathName = Path.GetDirectoryName(fileName) + "\\Сканы";
                    DirectoryInfo di = Directory.CreateDirectory(pathName);
                }
                else
                    return;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                Excel.Range excelcells;

                excelcells = (Excel.Range)xlWorkSheet.Cells[1, 1];
                excelcells.Value2 = "";

                // Шапка
                for (int i = 2; i <= dgv.Columns.Count-3; i++)
                {
                    excelcells = (Excel.Range)xlWorkSheet.Cells[1, i];
                    excelcells.Value2 = dgv.Columns[i - 1].HeaderText;
                }

                int ColCount = dgv.Columns.Count - 1;
                int j = 0;
                int k = 2;
                int n = 0;

                // вывод данных в ячейки
                xlApp.Visible = true;

                int m = dgv.RowCount;
                for (int i = 0; i <= m - 1; i++)
                {
                    if (dgv.Rows[i].Cells["SelectCell"].Value != null)
                    {
                        for (j = 1; j <= dgv.ColumnCount - 3; j++)
                        {
                            DataGridViewCell cell = dgv[j-1, i];
                            if (j == 1)
                                xlWorkSheet.Cells[n + k, j] = n+1;
                            else
                                xlWorkSheet.Cells[n + k, j] = cell.Value;
                        }

                        if (chkScan.Checked == true)
                            if (dgv.Rows[i].Cells["idImg"].Value != null) 
                            {
                                dateAct = (DateTime)dgv.Rows[i].Cells["dateAct"].Value;
                                strdtAct = dateAct.ToString("yyyyMMdd");
                                fileSave = "Акт" + dgv.Rows[i].Cells["docNumber"].Value.ToString() + "от" + strdtAct;
                                fileSave = pathName + "\\" + fileSave + ".jpg";

                                dsAbnDocum1.tPointAct_Image.Rows.Clear();
                                int ActID = (int)dgv.Rows[i].Cells["idAct"].Value;
                                SelectSqlData(dsAbnDocum1, dsAbnDocum1.tPointAct_Image, true, "where idAct=" + ActID.ToString() + " order by id asc");

                                for (int t = 0; t < dsAbnDocum1.tPointAct_Image.Count; t++)
                                {
                                    bmp = ImageCompress.LoadBitmap((byte[])dsAbnDocum1.tPointAct_Image.Rows[t]["Scan"]);
                                    ImageCompress.SaveBitmapUsingExtension(bmp, fileSave);
                                    Microsoft.Office.Interop.Excel.Range excelCell = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[n + k, dgv.ColumnCount - 2 + t];
                                    xlWorkSheet.Hyperlinks.Add(excelCell, fileSave, Type.Missing, "Посмотреть скан акта", fileSave);
                                }

                            }
                        n++;
                    }
                }

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                xlWorkSheet.PageSetup.LeftMargin = 70;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;

                this.Cursor = Cursors.Default;

                xlWorkBook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                
                saveFileDialogExport.Dispose();

                xlApp.Visible = true;


            }
            else
                MessageBox.Show("Нет данных для отчета ..");
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow != null) {
                FormDocAct_Check frmActCheck = new FormDocAct_Check(this.SqlSettings, Convert.ToInt32(dgv.CurrentRow.Cells["idObj"].Value), Convert.ToInt32(dgv.CurrentRow.Cells["idAct"].Value));
                frmActCheck.ShowDialog();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Multiselect = true;
            fileOpen.Filter = "JPEG Documents|*.jpg";
            DataRow drAddImg;
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in fileOpen.FileNames)
                {
                    using (Bitmap img = new Bitmap(fileName))
                    {
                        dsAbnDocum1.tPointAct_Image.Rows.Clear();

                        drAddImg = dsAbnDocum1.tPointAct_Image.NewRow();
                        drAddImg["idAct"] = (int)dgv.CurrentRow.Cells["idAct"].Value;
                        drAddImg["Scan"] = ImageCompress.GetCompressBytes((Image)img, 30L);
                        dsAbnDocum1.tPointAct_Image.Rows.Add(drAddImg);

                        int id = InsertSqlDataOneRow(dsAbnDocum1, dsAbnDocum1.tPointAct_Image);

                        dgvImage.Rows.Add(new Bitmap(img, 120, 160), ImageCompress.LoadBitmap(fileName), false, id);
                    }
                    //img.Dispose();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)//
        {
            if (DeleteSqlDataById(dsAbnDocum1.tPointAct_Image, (int)dgvImage.CurrentRow.Cells["id"].Value))
            {
                dgvImage.Rows.RemoveAt(dgvImage.CurrentRow.Index);
                MessageBox.Show("Изображение удалено..");
            }
            else
                MessageBox.Show("Изображение удалить не удалось..");
        }

        void proc_Exited(object sender, EventArgs e)
        {
            st = false;
            proc.Exited -= new EventHandler(proc_Exited); //убираем обработчик
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = ".jpg";
            fileSave.FileName = "Temp";
            fileSave.Title = "Сохраните файл с изображением в любой папке";
            if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageCompress.SaveBitmapUsingExtension((Bitmap)dgvImage.CurrentRow.Cells["ImageOriginal"].Value, fileSave.FileName);
            }

            
            if (fileSave.FileName != "")
            {
                proc.StartInfo.FileName = fileSave.FileName; //указываем имя файла с изображением
                if (!st)
                {
                    st = true; //указываем, что процесс запускается
                    proc.EnableRaisingEvents = true; //при закрытии файла будет вызвано событие Exited
                    proc.Exited += new EventHandler(proc_Exited); //добавляем обработчик события
                    proc.Start(); //запускаем программу просмотра изображения
                }
                else
                {
                    MessageBox.Show("Закройте файл с изображением, чтобы снова его запустить!");
                }
            }
            else
            {
                MessageBox.Show("Отсутствует имя файла!");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = ".jpg";
            fileSave.FileName = "Temp";
            fileSave.Title = "Сохраните файл с изображением в любой папке";

            if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageCompress.SaveBitmapUsingExtension((Bitmap)dgvImage.CurrentRow.Cells["ImageOriginal"].Value, fileSave.FileName);
                MessageBox.Show("Изображение успешно сохранено.");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
//            dgv.CurrentRow.DefaultCellStyle.BackColor = Color.LightCoral;
            dsAbnDocum1.tPointAct_Image.Rows.Clear();
            dgvImage.Rows.Clear();
            int ActID = (int)dgv.CurrentRow.Cells["idAct"].Value;
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.tPointAct_Image, true, "where idAct=" + ActID.ToString() + " order by id asc");
            if (dsAbnDocum1.tPointAct_Image.Count > 0)
            {
                for (int i = 0; i < dsAbnDocum1.tPointAct_Image.Count; i++)
                {
                    if (dsAbnDocum1.tPointAct_Image.Rows[i]["Scan"] != System.DBNull.Value)
                        LoadDataToGridImages((byte[])dsAbnDocum1.tPointAct_Image.Rows[i]["Scan"], (int)dsAbnDocum1.tPointAct_Image.Rows[i]["id"]);
                }
            }
        }

        private void LoadDataToGridImages(Byte[] ImageData, int id)
        {
            try
            {
                using (Bitmap bmp = ImageCompress.LoadBitmap(ImageData))
                {
                    if (bmp != null)
                    {
                        dgvImage.Rows.Add(new Bitmap(bmp, 120, 160), new Bitmap(bmp), true, id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells["SelectCell"].Value = true;
                RowsCheck = (int)dgv.RowCount;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnUncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells["SelectCell"].Value = false;
                RowsCheck = 0;
            }
        }


        private void dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);

        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //            dgv.CurrentRow.DefaultCellStyle.BackColor = Color.LightCoral;
            dsAbnDocum1.tPointAct_Image.Rows.Clear();
            dgvImage.Rows.Clear();
            int ActID = (int)dgv.CurrentRow.Cells["idAct"].Value;
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.tPointAct_Image, true, "where idAct=" + ActID.ToString() + " order by id asc");
            if (dsAbnDocum1.tPointAct_Image.Count > 0)
            {
                for (int i = 0; i < dsAbnDocum1.tPointAct_Image.Count; i++)
                {
                    if (dsAbnDocum1.tPointAct_Image.Rows[i]["Scan"] != System.DBNull.Value)
                        LoadDataToGridImages((byte[])dsAbnDocum1.tPointAct_Image.Rows[i]["Scan"], (int)dsAbnDocum1.tPointAct_Image.Rows[i]["id"]);
                }
            }

        }

        private void dgvImage_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }




    }
}
