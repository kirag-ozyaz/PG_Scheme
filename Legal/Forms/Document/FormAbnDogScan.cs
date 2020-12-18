using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;
using System.Drawing.Imaging;
using FormLbr.Classes;
using System.Data.SqlClient;


namespace Legal.Forms.Document
{
    public partial class FormAbnDogScan : FormLbr.FormBase
    {
        private DataRow drAddImg;
        private int idAbn = -1;         // id абонента
        private int idList = -1;
        private int idType = -1;
        bool st = false; 

        System.Diagnostics.Process proc = new System.Diagnostics.Process();

        public FormAbnDogScan()
        {
            InitializeComponent();
        }

        public FormAbnDogScan(int idAbn, int idList, int idType)
        {
            InitializeComponent();
            this.idAbn = idAbn;
            this.idList = idList;
            this.idType = idType;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "JPEG Documents|*.jpg";
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap img = new Bitmap(fileOpen.FileName);

                dsAbnDocum.tAbn_Image.Rows.Clear();

                drAddImg = dsAbnDocum.tAbn_Image.NewRow();
                drAddImg["idAbn"] = idAbn;
                drAddImg["idList"] = idList;
                drAddImg["DocType"] = idType;
                drAddImg["Scan"] = ImageCompress.GetCompressBytes((Image)img, 30L);
                dsAbnDocum.tAbn_Image.Rows.Add(drAddImg);

                int id = InsertSqlDataOneRow(dsAbnDocum, dsAbnDocum.tAbn_Image);

                pbScanDoc.Image = ImageCompress.LoadBitmap(fileOpen.FileName);
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
                dataGridViewImages.Rows.Add(new Bitmap(img, 120, 160), ImageCompress.LoadBitmap(fileOpen.FileName), false, id);

                img.Dispose();
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DeleteSqlDataById(dsAbnDocum.tAbn_Image, (int)dataGridViewImages.CurrentRow.Cells["id"].Value))
            {
                dataGridViewImages.Rows.RemoveAt(dataGridViewImages.CurrentRow.Index);
                MessageBox.Show("Изображение удалено..");
            }
            else
                MessageBox.Show("Изображение удалить не удалось..");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = ".jpg";
            fileSave.FileName = "Temp";
            fileSave.Title = "Сохраните файл с изображением в любой папке";
            if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageCompress.SaveBitmapUsingExtension(pbScanDoc.Image, fileSave.FileName);
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
                ImageCompress.SaveBitmapUsingExtension(pbScanDoc.Image, fileSave.FileName);
                MessageBox.Show("Изображение успешно сохранено.");
            }
        }

        void proc_Exited(object sender, EventArgs e)
        {
            st = false;
            proc.Exited -= new EventHandler(proc_Exited); //убираем обработчик
        }

        private void FormAbnDogScan_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsAbnDocum, dsAbnDocum.tAbn_Image, true, "where idList =" + idList.ToString() + " order by id asc");
            if (dsAbnDocum.tAbn_Image.Count > 0)
            {
                for (int i = 0; i < dsAbnDocum.tAbn_Image.Count; i++)
                {
                    if (dsAbnDocum.tAbn_Image.Rows[i]["Scan"] != System.DBNull.Value)
                        LoadDataToGridImages((byte[])dsAbnDocum.tAbn_Image.Rows[i]["Scan"], (int)dsAbnDocum.tAbn_Image.Rows[i]["id"]);
                }
                if (dataGridViewImages.CurrentRow != null)
                    pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void LoadDataToGridImages(Byte[] ImageData, int id)
        {
            try
            {
                Bitmap bmp = ImageCompress.LoadBitmap(ImageData);
                if (bmp != null)
                {
                    dataGridViewImages.Rows.Add(new Bitmap(bmp, 120, 160), bmp, true, id);
                }

//                dataGridViewImages.Rows.Add(new Bitmap(ImageCompress.LoadBitmap(ImageData), 120, 160), ImageCompress.LoadBitmap(ImageData), true, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewImages_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex >= 0) // если левой кнопкой
            {
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            {
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;

                this.dataGridViewImages.Rows[e.RowIndex].Selected = true;
                dataGridViewImages.CurrentCell = dataGridViewImages[0, e.RowIndex]; //делаем текущей
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
        //        this.contextMenuStripImage.Show(System.Windows.Forms.Cursor.Position);
            }

        }

        private void FormAbnDogScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridViewImages.Dispose();
            pbScanDoc.Dispose();
        }


    }
}
