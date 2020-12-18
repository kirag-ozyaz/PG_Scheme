using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Prv.Forms.Exchange
{
    public partial class FormUEoplPOST : FormLbr.FormBase
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)] string path,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
            int shortPathLength);

        private int oldRowIndex = -1;
        //private bool isPrig = false;

        public FormUEoplPOST()
        {
            InitializeComponent();
        }

        private void toolStripButtonOpenFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialogOpl.ShowDialog() == DialogResult.OK)
            {   // Все выдленные файлы заносим в грид
                for (int i = 0; i < openFileDialogOpl.FileNames.Length; i++) // добавляем в грид
                    dataGridViewFiles.Rows.Add(openFileDialogOpl.FileNames[i], "", "", "", "", "Провести");
            }
        }
        #region Disable/Enable Controls
        private void DisableControls(Control ctrl)
        {
            toolStripOpl.Enabled = false;
            statusStripOpl.Enabled = false;
            dataGridViewFiles.Enabled = false;
            dataGridViewDBF.Enabled = false;
            splitContainerOpl.Enabled = false;

            // размеры панели
            //panelProgress.Left = this.ClientSize.Width / 4;
            //panelProgress.Width = this.ClientSize.Width / 2;
            //panelProgress.Top = this.ClientSize.Height / 2 - panelProgress.Height / 2;

            if (ctrl == progressBar)
            {
                progressBar.Visible = true;
                progressBarEndLess.Visible = false;
            }
            if (ctrl == progressBarEndLess)
            {
                progressBar.Visible = false;
                progressBarEndLess.Visible = true;
            }

            panelProgress.Visible = true;
            progressBarEndLess.AutoProgress = true;

            dataGridViewDBF.DataSource = null;
        }
        private void EnableControls()
        {
            splitContainerOpl.Enabled = true;
            toolStripOpl.Enabled = true;
            statusStripOpl.Enabled = true;
            dataGridViewFiles.Enabled = true;
            dataGridViewDBF.Enabled = true;
            progressBarEndLess.AutoProgress = false;
            panelProgress.Visible = false;

            dataGridViewDBF.DataSource = dataSetOpl.Tables["TableOpl"];
        }
        #endregion

        #region dataGRidViewFiles events
        // Нажатие на грид (для того чтобы comboBoxы с одного клика открывались)
        private void dataGridViewFiles_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitInfo = this.dataGridViewFiles.HitTest(e.X, e.Y);
            if (hitInfo.Type == DataGridViewHitTestType.RowHeader)
            {
                this.dataGridViewFiles.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                this.dataGridViewFiles.EndEdit();
            }
            else
            {
                this.dataGridViewFiles.EditMode = DataGridViewEditMode.EditOnEnter;
            }
        }
        // нажататие на текущ ячейку
        private void dataGridViewFiles_CurrentCellChanged(object sender, EventArgs e)
        {
            if ((dataGridViewFiles.Rows.Count > 0) &&
                (oldRowIndex != this.dataGridViewFiles.CurrentCellAddress.Y)
                && (this.dataGridViewFiles.CurrentCellAddress.Y >= 0))
            {   // если мы перешли на новую строку (надо подгрузить dbf-ку)
                string fileName = dataGridViewFiles.CurrentRow.Cells["columnFile"].Value.ToString();
                statusLabelFile.Text = fileName;

                DisableControls(progressBarEndLess);
                dataSetOpl.Tables["TableOpl"].Clear();
                labelProgress.Text = "Подождите, идет загрузка данных из файла...";
                backgroundWorkerLoadDBF.RunWorkerAsync(fileName);

            }
            if (dataGridViewFiles.Rows.Count <= 0)
                dataSetOpl.Tables["TableOpl"].Clear();

            oldRowIndex = this.dataGridViewFiles.CurrentCellAddress.Y;
        }
        // нажатие на контент ячейки
        private void dataGridViewFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFiles.Columns[e.ColumnIndex] == ColumnCatch)
            {   // если столбец - кнопка
                if (dataGridViewFiles.CurrentRow.Cells["columnCatch"].Value.ToString() == "Провести")
                {   // если надо провести
                    if ((dataGridViewFiles.CurrentRow.Cells["columnFile"].Value == null)
                        || (dataGridViewFiles.CurrentRow.Cells["columnFile"].Value.ToString() == "")

                        )
                        MessageBox.Show("Заполните все поля");
                    else
                    {
                        DisableControls(progressBar);
                        backgroundWorkerImpSQL.RunWorkerAsync();
                    }
                }
                else
                    if (dataGridViewFiles.CurrentRow.Cells["columnCatch"].Value.ToString() == "Отменить")
                    {

                       DisableControls(progressBarEndLess);

                    }
            }

        }
        #endregion


        #region backgroundWorkerLoadDBF
        private void backgroundWorkerLoadDBF_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string dataSource = System.IO.Path.GetDirectoryName(e.Argument.ToString());
            string fileName = System.IO.Path.GetFileName(e.Argument.ToString());

            dataSetOpl.Tables["TableOpl"].Clear();

            StringBuilder fileTemp = new StringBuilder(1024);
            GetShortPathName(dataSource + "\\" + fileName, fileTemp, fileTemp.Capacity);
            fileName = System.IO.Path.GetFileName(fileTemp.ToString());

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString =
                 "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource +
                ";Persist Security Info=False;Extended Properties=dBASE IV";
            try
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dataSource + ";Extended Properties=dbase IV;";
                    con.Open();
                }

                OleDbCommand cmd = new OleDbCommand("select * from `" + fileName + "`", con);

                OleDbDataAdapter dAdapt = new OleDbDataAdapter(cmd);
                dAdapt.Fill(dataSetOpl, "TableOpl");


            }
            catch (Exception ex) // ошибка соединения
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.Close();
            }

        }

        private void backgroundWorkerLoadDBF_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            EnableControls();
        }
        #endregion


        private void InsertPayUE(SqlConnection con,  string FileName)
        {

            for (int i = 0; i < dataSetOpl.Tables["TableOpl"].Rows.Count; i++)
            {
                //if (i == 2067) 
                //   MessageBox.Show ("Alarma!");
                int percent = (int)(i * 100 / dataSetOpl.Tables["TableOpl"].Rows.Count);

                string str;
 
                        str = "Загрузка...\nЗаписей "
                        + i.ToString() + " из " + dataSetOpl.Tables["TableOpl"].Rows.Count.ToString();


                backgroundWorkerImpSQL.ReportProgress(percent, str);
                DataRow r = dataSetOpl.Tables["TableOpl"].Rows[i];

                string InsOplUE = "sp_InsOplUEPost";

                SqlCommand sqlcom = new SqlCommand(InsOplUE, con);
                sqlcom.CommandType = CommandType.StoredProcedure;

                //if (r["Dogovor"].ToString() == "41000439") 
                //   MessageBox.Show ("Alarma!");

                sqlcom.Parameters.Add("@Dogovor", SqlDbType.VarChar, 15);
                sqlcom.Parameters["@Dogovor"].Value = r["Dogovor"];

                sqlcom.Parameters.Add("@NomPoint", SqlDbType.Int);
                sqlcom.Parameters["@NomPoint"].Value = Convert.ToInt32(r["NomPoint"]);

                sqlcom.Parameters.Add("@FIO", SqlDbType.VarChar, 70);
                sqlcom.Parameters["@FIO"].Value = (r["FIO"] == DBNull.Value) ? "" : r["FIO"];

                sqlcom.Parameters.Add("@Raion", SqlDbType.VarChar, 50);
                sqlcom.Parameters["@Raion"].Value = (r["Raion"] == DBNull.Value) ? "" : r["Raion"];

                sqlcom.Parameters.Add("@Gorodok", SqlDbType.VarChar, 50);
                sqlcom.Parameters["@Gorodok"].Value = (r["Gorodok"] == DBNull.Value) ? "" : r["Gorodok"]; 

                sqlcom.Parameters.Add("@Ulica", SqlDbType.VarChar, 50);
                sqlcom.Parameters["@Ulica"].Value = (r["Ulica"] == DBNull.Value) ? "" : r["Ulica"]; 

                sqlcom.Parameters.Add("@Dom", SqlDbType.VarChar, 50);
                sqlcom.Parameters["@Dom"].Value = (r["Dom"] == DBNull.Value) ? "" : r["Dom"];

                sqlcom.Parameters.Add("@Korp", SqlDbType.VarChar, 50);
                sqlcom.Parameters["@Korp"].Value = (r["Korp"] == DBNull.Value) ? "" : r["Korp"]; 

                sqlcom.Parameters.Add("@Kv", SqlDbType.VarChar, 20);
                sqlcom.Parameters["@Kv"].Value = (r["Kv"] == DBNull.Value) ? "" : r["Kv"]; 

                sqlcom.Parameters.Add("@NomPom", SqlDbType.VarChar, 20);
                sqlcom.Parameters["@NomPom"].Value = (r["NomPom"] == DBNull.Value) ? "" : r["NomPom"];

                sqlcom.Parameters.Add("@DataOpl", SqlDbType.DateTime);
                if (r["DataOpl"] == DBNull.Value)
                    sqlcom.Parameters["@DataOpl"].Value = Convert.ToDateTime("01.01.1950");
                else
                sqlcom.Parameters["@DataOpl"].Value = (Convert.ToDateTime(r["DataOpl"]) <= Convert.ToDateTime("01.01.1950") ) ?
                    Convert.ToDateTime("01.01.1950") : Convert.ToDateTime(r["DataOpl"]);

                sqlcom.Parameters.Add("@DataRazn", SqlDbType.DateTime);
                if (r["DataRazn"] == DBNull.Value)
                    sqlcom.Parameters["@DataRazn"].Value = Convert.ToDateTime("01.01.1950");
                else
                sqlcom.Parameters["@DataRazn"].Value = (Convert.ToDateTime(r["DataRazn"]) <= Convert.ToDateTime("01.01.1950") ) ?
                    Convert.ToDateTime("01.01.1950") : Convert.ToDateTime(r["DataRazn"]);

                sqlcom.Parameters.Add("@TypeOpl", SqlDbType.VarChar, 30);
                sqlcom.Parameters["@TypeOpl"].Value = (r["TypeOpl"] == DBNull.Value) ? "" : r["TypeOpl"]; 

                sqlcom.Parameters.Add("@TypeKod", SqlDbType.Int);
                sqlcom.Parameters["@TypeKod"].Value = (r["TypeKod"] == DBNull.Value) ? -1 : Convert.ToInt32(r["TypeKod"]); 

                sqlcom.Parameters.Add("@PredPok", SqlDbType.Int);
                sqlcom.Parameters["@PredPok"].Value = Convert.ToInt32(r["PredPok"]);

                sqlcom.Parameters.Add("@TekPok", SqlDbType.Int);
                sqlcom.Parameters["@TekPok"].Value = Convert.ToInt32(r["TekPok"]);

                sqlcom.Parameters.Add("@ColKVT", SqlDbType.Int);
                sqlcom.Parameters["@ColKVT"].Value = Convert.ToInt32(r["ColKVT"]);

                sqlcom.Parameters.Add("@ColKVTit", SqlDbType.Int);
                sqlcom.Parameters["@ColKVTit"].Value = (r["ColKVTit"] == DBNull.Value) ? -1 : Convert.ToInt32(r["ColKVTit"]); 

                sqlcom.Parameters.Add("@NomTarif", SqlDbType.Int);
                sqlcom.Parameters["@NomTarif"].Value = Convert.ToInt32(r["NomTarif"]);

                sqlcom.Parameters.Add("@ByPeriod", SqlDbType.VarChar, 100);
                sqlcom.Parameters["@ByPeriod"].Value = (r["ByPeriod"] == DBNull.Value) ? "" : r["ByPeriod"]; 

                sqlcom.Parameters.Add("@KeyOpl", SqlDbType.Int);
                sqlcom.Parameters["@KeyOpl"].Value = Convert.ToInt32(r["KeyOpl"]);

                sqlcom.Parameters.Add("@PoNorme", SqlDbType.Int);
                sqlcom.Parameters["@PoNorme"].Value = (r["PoNorme"] == DBNull.Value) ? -1 : Convert.ToInt32(r["PoNorme"]); 

                sqlcom.Parameters.Add("@DopPriznak", SqlDbType.Int);
                sqlcom.Parameters["@DopPriznak"].Value = (r["DopPriznak"] == DBNull.Value) ? -1 : Convert.ToInt32(r["DopPriznak"]);

                sqlcom.Parameters.Add("@IST_Nach", SqlDbType.Int);
                sqlcom.Parameters["@IST_Nach"].Value = (r["IST_Nach"] == DBNull.Value) ? -1 : Convert.ToInt32(r["IST_Nach"]); 

                sqlcom.Parameters.Add("@Const_Code", SqlDbType.Int);
                sqlcom.Parameters["@Const_Code"].Value = Convert.ToInt32(r["Const_Code"]);

                sqlcom.Parameters.Add("@NameFile", SqlDbType.VarChar);
                sqlcom.Parameters["@NameFile"].Value = FileName;

                sqlcom.ExecuteNonQuery();
            }
        }

        #region backgroundWorkerImpSQL
        private void backgroundWorkerImpSQL_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string fileName = dataGridViewFiles.CurrentRow.Cells["columnFile"].Value.ToString();
                backgroundWorkerImpSQL.ReportProgress(0, "Создание бандероли");

                    InsertPayUE(con.Connection,  fileName);
            }
            catch (Exception ex) // ошибка соединения
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
        }

        private void backgroundWorkerImpSQL_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            labelProgress.Text = e.UserState.ToString();
            progressBar.Value = e.ProgressPercentage;

        }

        private void backgroundWorkerImpSQL_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            EnableControls();
            dataGridViewFiles.CurrentRow.Cells["columnLand"].ReadOnly = true;
            dataGridViewFiles.CurrentRow.Cells["columnPeriod"].ReadOnly = true;
            dataGridViewFiles.CurrentRow.Cells["columnPrig"].ReadOnly = true;
            dataGridViewFiles.CurrentRow.Cells["columnCatch"].Value = "ОК";
            dataGridViewFiles.CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            MessageBox.Show("Данные успешно проведены");
        }
        #endregion

    }
}
