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
    public partial class FormExportNewAbn : FormLbr.FormBase
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)] string path,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
            int shortPathLength);

        private string txtWhere; 

        public FormExportNewAbn()
        {
            InitializeComponent();
        }

        private void FormExportNewAbn_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            dtBegin.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtEnd.Value = new DateTime(DateTime.Now.Year, 12, 31);

            textBoxFile.Text = "\\\\Ulges-sql\\Ulges\\ExtForms\\Gossektor\\NewAbn\\Abn.dbf";

            cbDirect.Checked = true;

        }


        private void btnSelectAbn_Click(object sender, EventArgs e)
        {
            dsCalc1.vG_Abn1C_Selected.Clear();
            txtWhere = " (DateCommand >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
            " (DateCommand <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            if (cbDirect.Checked == true)
                txtWhere += " and DogDate is not null";
            SelectSqlData(dsCalc1, dsCalc1.vG_Abn1C_Selected, true, " where " + txtWhere + " order by DateCommand desc");
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.FileName = textBoxFile.Text;
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = saveFileDialogExport.FileName;
            }
        }

        private void btnExportAbn_Click(object sender, EventArgs e)
        {
            string strCom;

            this.Cursor = Cursors.WaitCursor;

            if (System.IO.File.Exists(textBoxFile.Text))
            {
                System.IO.File.Delete(textBoxFile.Text); // удаляем файл
            }

            StringBuilder fileTemp = new StringBuilder(1024);
            // Получим коротокое имя временного файла
            GetShortPathName(System.IO.Path.GetTempFileName(), fileTemp, fileTemp.Capacity);
            // Папка временного файла
            string dir = System.IO.Path.GetDirectoryName(fileTemp.ToString());
            string fileName = "tmp";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir +
                ";Mode = Share Deny None;Persist Security Info=False;Extended Properties=dBASE IV";
            try
            {
                con.Open();
                // Имя файла без расширения
                fileName = System.IO.Path.GetFileNameWithoutExtension(fileTemp.ToString());
                System.IO.File.Delete(dir + "\\" + fileName + ".dbf");  // на всякий случай удаляем
                // Создадим таблицу с именем временного файла
                strCom = "";
                strCom = "CREATE TABLE `" + fileName + "` (AbnID int, " +
                "AbnCode int, " +
                "FullNam varchar(254), " +
                "NumDog varchar(20), " +
                "ShortName varchar(254), " +
                "INN varchar(50), " +
                "TypeOrg varchar(70), " +
                "Budg varchar(30), " +
                "Rsch varchar(50), " +
                "BankNam varchar(254), " +
                "Ksch varchar(30), " +
                "BIK varchar(20), " +
                "City varchar(128), " +
                "Contrcod int, " +
                "ContrNan varchar(40), " +
                "OTR varchar(50), " +
                "AltName varchar(1), " +
                "Street varchar(254), " +
                "DogDate datetime, " +
                "Post varchar(254), " +
                "AbnOwner int)"
                ;

                OleDbCommand cmd = new OleDbCommand(strCom, con);
                cmd.ExecuteNonQuery();


                // Занесем данные
                for (int i = 0; i < dgvAbn.Rows.Count; i++)
                {
                    if ((dgvAbn.Rows[i].Cells["SelectCell"].Value != null) && ((bool)dgvAbn.Rows[i].Cells["SelectCell"].Value == true))
                    {

                        strCom = "insert into `" + fileName +
                        "` VALUEs(@AbnID, @AbnCode, @FullNam, @NumDog, @ShortName, @INN, @TypeOrg, @Budg, @Rsch, @BankNam, @Ksch, @BIK, @City, @Contrcod, @ContrNan, @OTR, @AltName, @Street, @DogDate, @Post, @AbnOwner)";

                        cmd = new OleDbCommand(strCom, con);

                        SelectSqlDataTableOther(dsCalc1, dsCalc1.vG_Abn1C_Selected1, "vG_Abn1C_Selected", true, " where AbnID = " + dgvAbn.Rows[i].Cells["abnID"].Value);

                        DataRow r = dsCalc1.Tables["vG_Abn1C_Selected1"].Rows[0];

                        // Параметры функции 
                        OleDbParameter p = new OleDbParameter("@AbnID", r["AbnID"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@AbnCode", r["AbnCode"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@FullNam", r["FullNam"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@NumDog", r["NumDog"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@ShortName", r["ShortName"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@INN", r["INN"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@TypeOrg", r["TypeOrg"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Budg", r["Budg"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Rsch", r["Rsch"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@BankNam", r["BankNam"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Ksch", r["Ksch"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@BIK", r["BIK"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@City", r["City"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Contrcod", r["Contrcod"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@ContrNan", r["ContrNan"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@OTR", r["OTR"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@AltName", r["AltName"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Street", r["Street"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@DogDate", r["DogDate"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Post", r["Post"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@AbnOwner", r["AbnOwner"]);
                        cmd.Parameters.Add(p);

                        cmd.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex) // ошибка соединения
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

            System.IO.File.Move(dir + "\\" + fileName + ".dbf", textBoxFile.Text);
            this.Cursor = Cursors.Default;
            MessageBox.Show("Выгрузка успешно завершена ..");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAbn_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Displayed && e.Row.Index > 0)
            {
                if (e.Row.Cells[6].Value.ToString() == "" || e.Row.Cells[6].Value.ToString().Length < 10)
                {
                    e.Row.Cells[0].ReadOnly = true;
                }
            }
        }

    }
}
