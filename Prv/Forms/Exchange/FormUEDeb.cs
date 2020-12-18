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
    public partial class FormUEDeb : FormLbr.FormBase
    {

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)] string path,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
            int shortPathLength);

        private int oldRowIndex = -1;
        private bool isPrig = false;

        public FormUEDeb()
        {
            InitializeComponent();
        }

        private void FormUEDeb_Load(object sender, EventArgs e)
        {
            string[] year = new string[(int)DateTime.Today.Year - 2010];
            int j = 0;
            for (int i = (int)DateTime.Today.Year; i >=2011 ; i--) { year[j++] = i.ToString();}
            ((DataGridViewComboBoxColumn)dataGridViewFiles.Columns[1]).Items.AddRange(year);

        }

        // Открытие файлов(а)
        private void toolStripButtonOpenFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialogDeb.ShowDialog() == DialogResult.OK)
            {   // Все выдленные файлы заносим в грид
                for (int i = 0; i < openFileDialogDeb.FileNames.Length; i++) // добавляем в грид
                    dataGridViewFiles.Rows.Add(openFileDialogDeb.FileNames[i], "", "", "", "Провести");
            }
        }


        #region Disable/Enable Controls
        private void DisableControls(Control ctrl)
        {
            toolStripDeb.Enabled = false;
            statusStripDeb.Enabled = false;
            dataGridViewFiles.Enabled = false;
            dataGridViewDBF.Enabled = false;
            splitContainerDeb.Enabled = false;

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
            splitContainerDeb.Enabled = true;
            toolStripDeb.Enabled = true;
            statusStripDeb.Enabled = true;
            dataGridViewFiles.Enabled = true;
            dataGridViewDBF.Enabled = true;
            progressBarEndLess.AutoProgress = false;
            panelProgress.Visible = false;

            dataGridViewDBF.DataSource = dataSetDeb.Tables["TableDeb"];
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
                dataSetDeb.Tables["TableDeb"].Clear();
                labelProgress.Text = "Подождите, идет загрузка данных из файла...";
                backgroundWorkerLoadDBF.RunWorkerAsync(fileName);

            }
            if (dataGridViewFiles.Rows.Count <= 0)
                dataSetDeb.Tables["TableDeb"].Clear();

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
                        || (dataGridViewFiles.CurrentRow.Cells["columnYear"].Value == null)
                        || (dataGridViewFiles.CurrentRow.Cells["columnYear"].Value.ToString() == "")
                        || (dataGridViewFiles.CurrentRow.Cells["columnMonth"].Value == null)
                        || (dataGridViewFiles.CurrentRow.Cells["columnMonth"].Value.ToString() == "")
                        || (dataGridViewFiles.CurrentRow.Cells["columnPrig"].Value == null)
                        || (dataGridViewFiles.CurrentRow.Cells["columnPrig"].Value.ToString() == "")
                        )
                        MessageBox.Show("Заполните все поля");
                    else
                    {

                        isPrig = (dataGridViewFiles.CurrentRow.Cells["columnPrig"].Value.ToString() == "Пригород")
                            ? true : false;
                        DisableControls(progressBar);
                       backgroundWorkerImpSQL.RunWorkerAsync();
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

            dataSetDeb.Tables["TableDeb"].Clear();

            StringBuilder fileTemp = new StringBuilder(1024);
            GetShortPathName(dataSource + "\\" + fileName, fileTemp, fileTemp.Capacity);
            fileName = System.IO.Path.GetFileName(fileTemp.ToString());

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource +
                ";Persist Security Info=False;Extended Properties=dBASE IV";
            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand("select * from `" + fileName + "`", con);

                OleDbDataAdapter dAdapt = new OleDbDataAdapter(cmd);
                dAdapt.Fill(dataSetDeb, "TableDeb");


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

        private void InsertDebUE(SqlConnection con, byte tarif, string FileName)
        {
            for (int i = 0; i < dataSetDeb.Tables["TableDeb"].Rows.Count; i++)
            {
                //if (i == 2067) 
                //   MessageBox.Show ("Alarma!");
                int percent = (int)(i * 100 / dataSetDeb.Tables["TableDeb"].Rows.Count);

                string str;
                switch (tarif)
                {
                    case 1: str = "Загрузка первого тарифа...\nЗаписей "
                        + i.ToString() + " из " + dataSetDeb.Tables["TableDeb"].Rows.Count.ToString();
                        break;
                    case 2:
                        str = "Загрузка второго тарифа...\nЗаписей "
                        + i.ToString() + " из " + dataSetDeb.Tables["TableDeb"].Rows.Count.ToString();
                        break;
                    case 3:
                        str = "Загрузка пригорода...\nЗаписей "
                        + i.ToString() + " из " + dataSetDeb.Tables["TableDeb"].Rows.Count.ToString();
                        break;
                    default:
                        str = "Загрузка...\nЗаписей "
                        + i.ToString() + " из " + dataSetDeb.Tables["TableDeb"].Rows.Count.ToString();
                        break;
                }

                backgroundWorkerImpSQL.ReportProgress(percent, str);
                DataRow r = dataSetDeb.Tables["TableDeb"].Rows[i];

                string InsDebUE = "sp_InsDebUE";

                SqlCommand sqlcom = new SqlCommand(InsDebUE, con);
                sqlcom.CommandType = CommandType.StoredProcedure;


                sqlcom.Parameters.Add("@Dogovor", SqlDbType.VarChar, 20);
                sqlcom.Parameters["@Dogovor"].Value = r["Dogovor"];

                sqlcom.Parameters.Add("@Gorodok", SqlDbType.VarChar, 50);
                sqlcom.Parameters["@Gorodok"].Value = r["Gorodok"];

                sqlcom.Parameters.Add("@FIO", SqlDbType.VarChar, 50);
                sqlcom.Parameters["@FIO"].Value = r["FIO"];

                sqlcom.Parameters.Add("@Adress", SqlDbType.VarChar, 70);
                sqlcom.Parameters["@Adress"].Value = r["Adress"];

                sqlcom.Parameters.Add("@Type", SqlDbType.VarChar, 15);
                sqlcom.Parameters["@Type"].Value = r["Receipt"];

                sqlcom.Parameters.Add("@Itog", SqlDbType.Money);
                sqlcom.Parameters["@Itog"].Value = Convert.ToDecimal(r["Itog"]);

                sqlcom.Parameters.Add("@SETI", SqlDbType.VarChar, 40);
                sqlcom.Parameters["@SETI"].Value = r["SETI"];

                sqlcom.Parameters.Add("@DATA_D", SqlDbType.DateTime);
                sqlcom.Parameters["@DATA_D"].Value =
                    (Convert.ToDateTime(r["DATA_D"]) <= Convert.ToDateTime("01.01.1950")) ?
                    Convert.ToDateTime("01.01.1950") : Convert.ToDateTime(r["DATA_D"]);
                    
                    //Convert.ToDateTime(r["DATA_D"]);

                int Month;
                switch (dataGridViewFiles.CurrentRow.Cells["ColumnMonth"].Value.ToString())
                                {
                                    case "январь" : Month = 1 ;
                                                  break;
                                    case "февраль": Month = 2 ;
                                                  break;
                                    case "март" : Month = 3 ;
                                                  break;
                                   case "апрель" : Month = 4 ;
                                                  break;
                                   case "май" : Month = 5 ;
                                                  break;
                                    case "июнь": Month = 6 ;
                                                  break;
                                    case "июль": Month = 7;
                                                  break;
                                    case "август": Month = 8;
                                                  break;
                                    case "сентябрь": Month = 9;
                                                  break;
                                    case "октябрь": Month = 10;
                                                  break;
                                    case "ноябрь": Month = 11;
                                                  break;
                                    case "декабрь": Month = 12;
                                                  break;
                                    default : Month = 1;
                                                  break;

                                 };

                int Monthdeb = Convert.ToInt32(dataGridViewFiles.CurrentRow.Cells["ColumnYear"].Value) * 100 + Month;

                sqlcom.Parameters.Add("@MonthDeb", SqlDbType.Int);
                sqlcom.Parameters["@MonthDeb"].Value = Monthdeb ;

                sqlcom.Parameters.Add("@Code", SqlDbType.Int);
                sqlcom.Parameters["@Code"].Value = Convert.ToInt16(tarif);

                sqlcom.Parameters.Add("@NameFile", SqlDbType.VarChar,100);
                sqlcom.Parameters["@NameFile"].Value = FileName;

                sqlcom.Parameters.Add("@NOMTARIF", SqlDbType.Int);
                sqlcom.Parameters["@NOMTARIF"].Value = Convert.ToInt16(r["NOMTARIF"]);
                


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
                    InsertDebUE(con.Connection, 1, fileName);
                    InsertDebUE(con.Connection, 2, fileName);
                }
                else
                    InsertDebUE(con.Connection, 3, fileName);
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
            dataGridViewFiles.CurrentRow.Cells["columnYear"].ReadOnly = true;
            dataGridViewFiles.CurrentRow.Cells["columnMonth"].ReadOnly = true;
            dataGridViewFiles.CurrentRow.Cells["columnPrig"].ReadOnly = true;
            dataGridViewFiles.CurrentRow.Cells["columnCatch"].Value = "ОК";
            dataGridViewFiles.CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            MessageBox.Show("Данные успешно проведены");
        }
        #endregion

    }
}
