using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Legal.DataSet;
using DataSql;
using Constants;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace Legal.Forms.Document
{
    public partial class FormDocScan : FormLbr.FormBase
    {
        System.Diagnostics.Process proc = new System.Diagnostics.Process();
        // flag = 0 изображение в PictureBox показывается из внешнего файла
        // flag = 1 изображение в PictureBox показывается из таблицы
//        private int flag = 0;
        private DataRow drAddImg;
        private int idList = 0;
        //private bool st;

        public FormDocScan()
        {
            InitializeComponent();
        }

        private void FormDocScan_Load(object sender, EventArgs e)
        {
            cmbOwner.SelectedIndex = 1;
            int i = cmbOwner.SelectedIndex;
            switch (i)
            {
                case 0:
                    SelectSqlData(dsScan1, dsScan1.tR_Classifier, true, " where ParentKey = ';TypeDoc;tAbn;' and IsGroup = 0");
                    break;
                case 1:
                    SelectSqlData(dsScan1, dsScan1.tR_Classifier, true, " where ParentKey = ';TypeDoc;tAbnObj;' and IsGroup = 0");
                    break;
                case 2:
                    SelectSqlData(dsScan1, dsScan1.tR_Classifier, true, " where ParentKey = ';TypeDoc;tDocAct;' and IsGroup = 0");
                    break;
            }

            cmbRegion.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            txtMask.Text = "jpg";
            cmbYear.SelectedItem = DateTime.Today.Year.ToString();

        }

        #region что привязываем

        // заполним грид списком файлов с изображениями
        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDir.Text = folderBrowserDialog1.SelectedPath;
            }

            System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(@folderBrowserDialog1.SelectedPath);
            StringBuilder fileList = new StringBuilder();
            foreach (System.IO.FileInfo f in d.GetFiles("*." + txtMask.Text))
            {
                fileList.AppendLine(f.Name);
                dgvDir.Rows.Add(f.Name);
            }
            Show_Image();
        }

        // покажем изображение из файла
        private void dgvDir_MouseClick(object sender, MouseEventArgs e)
        {
            Show_Image();
        }

        private void Show_Image()
        {
            string FullNameFile = txtDir.Text + "\\" + dgvDir.CurrentRow.Cells["FileName"].Value;
            Bitmap img = new Bitmap(FullNameFile);

            pbScan.Image = FormLbr.Classes.ImageCompress.LoadBitmap(FullNameFile);
            pbScan.SizeMode = PictureBoxSizeMode.StretchImage;
            // flag = 0;
            img.Dispose();
        }

        #endregion

        #region просмотр изображения во внешней программе
        private void pbScan_Click(object sender, EventArgs e)
        {

            //if (flag == 0)
            //{
                string FullNameFile = txtDir.Text + "\\" + dgvDir.CurrentRow.Cells["FileName"].Value;
                FormLbr.Classes.ImageCompress.SaveBitmapUsingExtension(pbScan.Image, FullNameFile);
                proc.StartInfo.FileName = FullNameFile; //указываем имя файла с изображением
                //st = true; //указываем, что процесс запускается
                proc.EnableRaisingEvents = true; //при закрытии файла будет вызвано событие Exited
                proc.Exited += new EventHandler(proc_Exited); //добавляем обработчик события
                proc.Start(); //запускаем программу просмотра изображения
            //}
            //else
            //{
            //    SaveFileDialog fileSave = new SaveFileDialog();
            //    fileSave.DefaultExt = ".jpg";
            //    fileSave.FileName = "Temp";
            //    fileSave.Title = "Сохраните файл с изображением в любой папке";
            //    if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        FormLbr.Classes.ImageCompress.SaveBitmapUsingExtension(pbScan.Image, fileSave.FileName);
            //    }

            //    if (fileSave.FileName != "")
            //    {
            //        proc.StartInfo.FileName = fileSave.FileName; //указываем имя файла с изображением
            //        st = true; //указываем, что процесс запускается
            //        proc.EnableRaisingEvents = true; //при закрытии файла будет вызвано событие Exited
            //        proc.Exited += new EventHandler(proc_Exited); //добавляем обработчик события
            //        proc.Start(); //запускаем программу просмотра изображения
            //    }
            //    else
            //    {
            //        MessageBox.Show("Отсутствует имя файла!");
            //    }
            //}
        }

        void proc_Exited(object sender, EventArgs e)
        {
            //st = false;
            proc.Exited -= new EventHandler(proc_Exited); //убираем обработчик
        }
        #endregion

        #region к чему привязываем

        // найдем владельца документа
        private void btnFind_Click(object sender, EventArgs e)
        {
            int i = cmbOwner.SelectedIndex;
            int k = cmbType.SelectedIndex;
            switch (i)
            {
                case 0:
                    break;
                case 1:
                    switch (k)
                    {
                        case 0:
                            // найдем документ - акт разграничения
                            SelectSqlData(dsScan1, dsScan1.vActBalance, true, " where ActNumber = '" + txtNumberDoc.Text + "' and ActRegion = '" + cmbRegion.SelectedItem + "' and Left(Convert(varchar(10),ActDate,112),4) = " + cmbYear.SelectedItem);
                            if (dsScan1.vActBalance.Rows.Count != 0)
                            {
                                txtAbn.Text = dsScan1.vActBalance.Rows[0]["Name"].ToString();
                                txtObj.Text = dsScan1.vActBalance.Rows[0]["ObjName"].ToString();
                                dtDoc.Value = (DateTime)dsScan1.vActBalance.Rows[0]["ActDate"];

                                idList = Convert.ToInt32(dsScan1.vActBalance.Rows[0]["idList"]);

                                // заполним грид маленькими сканами 
                                SelectSqlData(dsScan1, dsScan1.tAbnObjDoc_Image, true, "where idList=" + idList + " order by id");
                                if (dsScan1.tAbnObjDoc_Image.Count > 0)
                                {
                                    dgvScan.Rows.Clear();
                                    for (int j = 0; j < dsScan1.tAbnObjDoc_Image.Count; j++)
                                    {
                                        LoadDataToGridImages((byte[])dsScan1.tAbnObjDoc_Image.Rows[j]["Scan"], (int)dsScan1.tAbnObjDoc_Image.Rows[j]["id"]);
                                    }
                                    //pbScan.Image = (Bitmap)dgvScan.CurrentRow.Cells["ImageOriginal"].Value;
                                    //pbScan.SizeMode = PictureBoxSizeMode.StretchImage;
                                    //flag = 1;
                                }
                            }
                            else
                                MessageBox.Show("Документ не найден.."); 
                            break;
                        case 1:
                            break;
                        case 2:
                            break;
                    }
                    break;
                case 2:
                    break;
            }
        }

        private void LoadDataToGridImages(Byte[] ImageData, int id)
        {
            try
            {
                dgvScan.Rows.Add(new Bitmap(FormLbr.Classes.ImageCompress.LoadBitmap(ImageData), 120, 160), FormLbr.Classes.ImageCompress.LoadBitmap(ImageData), true, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // покажем изображение из грида со сканами
        private void dgvScan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left && e.RowIndex >= 0) // если левой кнопкой
            //{
            //    pbScan.Image = (Bitmap)dgvScan.CurrentRow.Cells["ImageOriginal"].Value;
            //    pbScan.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            //{
            //    pbScan.Image = (Bitmap)dgvScan.CurrentRow.Cells["ImageOriginal"].Value;
            //    pbScan.SizeMode = PictureBoxSizeMode.StretchImage;

            //    this.dgvScan.Rows[e.RowIndex].Selected = true;
            //    dgvScan.CurrentCell = dgvScan[0, e.RowIndex]; //делаем текущей
            //    pbScan.Image = (Bitmap)dgvScan.CurrentRow.Cells["ImageOriginal"].Value;
            //    pbScan.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
        }

        // добавим изображение из файла
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (flag == 0)
            //{
                string FullNameFile = txtDir.Text + "\\" + dgvDir.CurrentRow.Cells["FileName"].Value;

                Bitmap img = new Bitmap(FullNameFile);

                drAddImg = dsScan1.tAbnObjDoc_Image.NewRow();
                drAddImg["idList"] = idList;
                drAddImg["Scan"] = FormLbr.Classes.ImageCompress.GetCompressBytes((Image)img, 30L);
                dsScan1.tAbnObjDoc_Image.Rows.Add(drAddImg);

                InsertSqlDataOneRow(dsScan1, dsScan1.tAbnObjDoc_Image);

                drAddImg.AcceptChanges();

                img.Dispose();

                // обновим грид
                // заполним грид маленькими сканами 
                SelectSqlData(dsScan1, dsScan1.tAbnObjDoc_Image, true, "where idList=" + idList + " order by id");
                if (dsScan1.tAbnObjDoc_Image.Count > 0)
                {
                    dgvScan.Rows.Clear();
                    for (int j = 0; j < dsScan1.tAbnObjDoc_Image.Count; j++)
                    {
                        LoadDataToGridImages((byte[])dsScan1.tAbnObjDoc_Image.Rows[j]["Scan"], (int)dsScan1.tAbnObjDoc_Image.Rows[j]["id"]);
                    }
                }

                // удалим файл из списка

            //}
            //else
            //    MessageBox.Show("Выберите файл с изображением для добавления..");
                                    
        }

        // удалим изображение
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DeleteSqlDataById(dsScan1.tAbnObjDoc_Image, (int)dgvScan.CurrentRow.Cells["id"].Value))
            {
                dgvScan.Rows.RemoveAt(dgvScan.CurrentRow.Index);
                MessageBox.Show("Изображение удалено..");
            }
            else
                MessageBox.Show("Изображение удалить не удалось..");
        }

        private void dgvScan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = ".jpg";
            fileSave.FileName = "Temp";
            fileSave.Title = "Сохраните файл с изображением в любой папке";
            if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FormLbr.Classes.ImageCompress.SaveBitmapUsingExtension((Bitmap)dgvScan.CurrentRow.Cells["ImageOriginal"].Value, fileSave.FileName);
            }

            if (fileSave.FileName != "")
            {
                proc.StartInfo.FileName = fileSave.FileName; //указываем имя файла с изображением
                //st = true; //указываем, что процесс запускается
                proc.EnableRaisingEvents = true; //при закрытии файла будет вызвано событие Exited
                proc.Exited += new EventHandler(proc_Exited); //добавляем обработчик события
                proc.Start(); //запускаем программу просмотра изображения
            }
            else
            {
                MessageBox.Show("Отсутствует имя файла!");
            }
        }

        #endregion
    }
}
