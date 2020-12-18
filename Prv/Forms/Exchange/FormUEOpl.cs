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
    public partial class FormUEOpl : FormLbr.FormBase
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)] string path,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
            int shortPathLength);

        private int oldRowIndex = -1;
        private bool isPrig = false;

        public FormUEOpl()
        {
            InitializeComponent();
        }


        // Открытие файлов(а)
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
            panelProgress.Left = this.ClientSize.Width / 4;
            panelProgress.Width = this.ClientSize.Width / 2;
            panelProgress.Top = this.ClientSize.Height / 2 - panelProgress.Height / 2;

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
                        //|| (dataGridViewFiles.CurrentRow.Cells["columnLand"].Value == null)
                        //|| (dataGridViewFiles.CurrentRow.Cells["columnLand"].Value.ToString() == "")
                        //|| (dataGridViewFiles.CurrentRow.Cells["columnPeriod"].Value == null)
                        //|| (dataGridViewFiles.CurrentRow.Cells["columnPeriod"].Value.ToString() == "")
                        || (dataGridViewFiles.CurrentRow.Cells["columnPrig"].Value == null)
                        || (dataGridViewFiles.CurrentRow.Cells["columnPrig"].Value.ToString() == "")
                        )
                        MessageBox.Show("Заполните все поля");
                    else
                    {
                        //// имя базы
                        //dbName = (dataGridViewFiles.CurrentRow.Cells["columnLand"].Value.ToString() == "Правый берег")
                        //    ? PrvDB : PrvDBnc;
                        //// период
                        //period = Convert.ToDateTime(dataGridViewFiles.CurrentRow.Cells["columnPeriod"].Value);
                        //// приг/непригород
                        isPrig = (dataGridViewFiles.CurrentRow.Cells["columnPrig"].Value.ToString() == "Пригород")
                            ? true : false;
                        DisableControls(progressBar);
                        backgroundWorkerImpSQL.RunWorkerAsync();
                    }
                }
                else
                    if (dataGridViewFiles.CurrentRow.Cells["columnCatch"].Value.ToString() == "Отменить")
                    {
                        if ((dataGridViewFiles.CurrentRow.Cells["columnBanderol"].Value == null)
                            || (dataGridViewFiles.CurrentRow.Cells["columnBanderol"].Value.ToString() == ""))
                            MessageBox.Show("Непонятно какую бандероль удалять");
                        else
                        {
                            //// имя базы
                            //dbName = (dataGridViewFiles.CurrentRow.Cells["columnLand"].Value.ToString() == "Правый берег")
                            //    ? PrvDB : PrvDBnc;
                            //// период
                            //period = Convert.ToDateTime(dataGridViewFiles.CurrentRow.Cells["columnPeriod"].Value);
                            //// приг/непригород
                            isPrig = (dataGridViewFiles.CurrentRow.Cells["columnPrig"].Value.ToString() == "Пригород")
                                ? true : false;
                            DisableControls(progressBarEndLess);
                            labelProgress.Text = "Подождите, идет удаление бандероли...";
                            backgroundWorkerDelBanderol.RunWorkerAsync(dataGridViewFiles.CurrentRow.Cells["columnBanderol"].Value);
                        }
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

        private void InsertPayUE(SqlConnection con, byte tarif, string FileName)
        {
            int KWT1 = 0;
            int KWT2 = 0;
            int COU_VAL_S1 = 0;
            int COU_VAL_S2 = 0;
            //decimal KWT3 = 0;

            for (int i = 0; i < dataSetOpl.Tables["TableOpl"].Rows.Count; i++)
            {
                //if (i == 2067) 
                //   MessageBox.Show ("Alarma!");
                int percent = (int)(i * 100 / dataSetOpl.Tables["TableOpl"].Rows.Count);

                string str;
                switch (tarif)
                {
                    case 1: str = "Загрузка первого тарифа...\nЗаписей "
                        + i.ToString() + " из " + dataSetOpl.Tables["TableOpl"].Rows.Count.ToString();
                        break;
                    case 2:
                        str = "Загрузка второго тарифа...\nЗаписей "
                        + i.ToString() + " из " + dataSetOpl.Tables["TableOpl"].Rows.Count.ToString();
                        break;
                    case 3:
                        str = "Загрузка пригорода...\nЗаписей "
                        + i.ToString() + " из " + dataSetOpl.Tables["TableOpl"].Rows.Count.ToString();
                        break;
                    default:
                        str = "Загрузка...\nЗаписей "
                        + i.ToString() + " из " + dataSetOpl.Tables["TableOpl"].Rows.Count.ToString();
                        break;
                }

                backgroundWorkerImpSQL.ReportProgress(percent, str);
                DataRow r = dataSetOpl.Tables["TableOpl"].Rows[i];

                //гребаное УЭ очередна заплата
                KWT1 = 0;
                KWT2 = 0;
                if (r["KWT1"] != DBNull.Value) Int32.TryParse(r["KWT1"].ToString(), out KWT1);
                if (r["KWT2"] != DBNull.Value) Int32.TryParse(r["KWT2"].ToString(), out KWT2);
                COU_VAL_S1 = 0;
                COU_VAL_S2 = 0;
                if (r["COU_VAL_S1"] != DBNull.Value) Int32.TryParse(r["COU_VAL_S1"].ToString(), out COU_VAL_S1);
                if (r["COU_VAL_S2"] != DBNull.Value) Int32.TryParse(r["COU_VAL_S2"].ToString(), out COU_VAL_S2);


                if (((tarif == 2) && (KWT2 <= 0)) || r["COU_VAL_S1"] == DBNull.Value) continue;

                string InsOplUE = "sp_InsOplUE";

                SqlCommand sqlcom = new SqlCommand(InsOplUE ,con);
                sqlcom.CommandType = CommandType.StoredProcedure;


                sqlcom.Parameters.Add("@Dogovor", SqlDbType.VarChar, 15);
                sqlcom.Parameters["@Dogovor"].Value = r["Dogovor"];
                
                sqlcom.Parameters.Add("@NomPoint", SqlDbType.Int);
                sqlcom.Parameters["@NomPoint"].Value = Convert.ToInt32(r["NomPoint"]);
                
                sqlcom.Parameters.Add("@DATE_OPLAT", SqlDbType.DateTime);
                //if (Convert.ToDateTime(r["DATE_OPLAT"]) <= Convert.ToDateTime("01.01.1950")) 
                //    MessageBox.Show ("Alarma!");
                sqlcom.Parameters["@DATE_OPLAT"].Value = (Convert.ToDateTime(r["DATE_OPLAT"]) <= Convert.ToDateTime("01.01.1950")) ?  
                    Convert.ToDateTime("01.01.1950") : Convert.ToDateTime(r["DATE_OPLAT"]) ;
                
                sqlcom.Parameters.Add("@SUM_TO_PAY", SqlDbType.Money);
                sqlcom.Parameters["@SUM_TO_PAY"].Value = Convert.ToDecimal(r["SUM_TO_PAY"]);
                
                sqlcom.Parameters.Add("@COU_VAL_S", SqlDbType.Int);
               // sqlcom.Parameters["@COU_VAL_S"].Value = (tarif == 2) ? Convert.ToInt32(r["COU_VAL_S2"]) : Convert.ToInt32(r["COU_VAL_S1"]);
                sqlcom.Parameters["@COU_VAL_S"].Value = (tarif == 2) ? COU_VAL_S2 : COU_VAL_S1;
                
                sqlcom.Parameters.Add("@PO", SqlDbType.VarChar, 6);

                sqlcom.Parameters["@PO"].Value =  r["PO"];

                sqlcom.Parameters.Add("@KWT", SqlDbType.Int);
//               if (r["KWT1"] != DBNull.Value) sqlcom.Parameters["@KWT"].Value = (tarif == 2) ? Convert.ToInt32(r["KWT2"]) : Convert.ToInt32(r["KWT1"]);
                if (r["KWT1"] != DBNull.Value) sqlcom.Parameters["@KWT"].Value = (tarif == 2) ? KWT2 : KWT1;
                else sqlcom.Parameters["@KWT"].Value = 0;
                
                sqlcom.Parameters.Add("@Code", SqlDbType.SmallInt);
                sqlcom.Parameters["@Code"].Value = Convert.ToInt16(tarif);
                
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

                if (!isPrig)
                {
                    InsertPayUE(con.Connection,1,fileName);
                    InsertPayUE(con.Connection, 2, fileName);
                }
                else
                    InsertPayUE(con.Connection, 3, fileName);
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
