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

namespace Prv.Forms.Exchange
{
    public partial class FormSBROpl : FormLbr.FormBase
    {
        public FormSBROpl()
        {
            InitializeComponent();

            for (int i = 0; i < 12; i++)
            {
                DateTime d = System.DateTime.Now.AddMonths(0 - i);
                comboBoxMonth.Items.Add(d);

            }

        }

        private void buttonAddFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialogDBF.ShowDialog() == DialogResult.OK) // диалог открытия файлов
            {
                for (int i = 0; i < openFileDialogDBF.FileNames.Length; i++)  // все открытые
                    dataGridViewFiles.Rows.Add(System.IO.Path.GetDirectoryName(
                        openFileDialogDBF.FileNames[i]),
                        System.IO.Path.GetFileName(openFileDialogDBF.FileNames[i]));
            }
        }

        // Загрузка DBF
        private void LoadDBF(string dataSource, string fileName)
        {
            this.Cursor = Cursors.AppStarting;
            dataSetDBF.Tables["TableDBF"].Clear();

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource +
                ";Persist Security Info=False;Extended Properties=dBASE IV";
            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand("select * from " + fileName +
                    " where not n_lc is null and n_lc <> ''", con);

                OleDbDataAdapter dAdapt = new OleDbDataAdapter(cmd);
                dAdapt.Fill(dataSetDBF, "TableDBF");
            }
            catch (Exception ex) // ошибка соединения
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.Close();
                this.Cursor = Cursors.Default;
            }
        }
        // выделение текущего файла
        private void dataGridViewFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFiles.Rows.Count > 0)
            {
                string dataSource = dataGridViewFiles.CurrentRow.Cells["colDirectory"].Value.ToString();
                string fileName = dataGridViewFiles.CurrentRow.Cells["colFileName"].Value.ToString();
                LoadDBF(dataSource, fileName); // загрузка из файла платежей
            }
            else
            {
                dataSetDBF.Tables["TableDBF"].Clear();
            }
        }

        private void dataGridViewFiles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {   // если правой кнопкой
                this.dataGridViewFiles.Rows[e.RowIndex].Selected = true;
                string dataSource = dataGridViewFiles.Rows[e.RowIndex].Cells["colDirectory"].Value.ToString();
                string filName = dataGridViewFiles.Rows[e.RowIndex].Cells["colFileName"].Value.ToString();
                LoadDBF(dataSource, filName);  // открытие выделенного файла

                if (dataGridViewFiles.Rows[e.RowIndex].Cells["colPackPB"].Value == null)
                {
                    toolStripMenuItemCancel.Enabled = false;
                    toolStripMenuItemCatch.Enabled = true;// (comboBoxMonth.SelectedItem == null) ? false : true;
                }
                else
                {
                    toolStripMenuItemCancel.Enabled = true;
                    toolStripMenuItemCatch.Enabled = false;
                }

                this.contextMenuStripImport.Show(System.Windows.Forms.Cursor.Position);
            }
        }

         // Удаление файла из списка
		private void toolStripMenuItemDel_Click(object sender, EventArgs e)
		{
			dataGridViewFiles.Rows.Remove(dataGridViewFiles.SelectedRows[0]);
        }

        private void DisableControls()
        {
            dataGridViewFiles.Enabled = false;
            dataGridViewDBF.Enabled = false;
            buttonAddFiles.Enabled = false;
            comboBoxMonth.Enabled = false;
            panelProgress.Visible = true;
        }
        private void EnableControls()
        {
            dataGridViewFiles.Enabled = true;
            dataGridViewDBF.Enabled = true;
            buttonAddFiles.Enabled = true;
            comboBoxMonth.Enabled = true;
            panelProgress.Visible = false;
        }


        // Провести файл
  		private void toolStripMenuItemCatch_Click(object sender, EventArgs e)
		{
            DisableControls();
            this.Cursor = Cursors.AppStarting;
            backgroundWorkerCatch.RunWorkerAsync(comboBoxMonth.SelectedItem);
        }


        #region backgroundWorkerCatch
        private void backgroundWorkerCatch_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataSetDBF.Tables["TableDBF"].Rows.Count > 0)
            {
                try // если соединение установлено
                {

                    // Заносим квитанции
                    CallInsertPay(dataGridViewFiles.SelectedRows[0].Cells["colFileName"].Value.ToString());

                    dataGridViewFiles.SelectedRows[0].Cells["OK"].Value = "OK";
     
                }
                catch (Exception ex) // ошибка соединения
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    backgroundWorkerCatch.ReportProgress(100, "ок");
                }
            }
            else
                MessageBox.Show("Проводить нечего");
            backgroundWorkerCatch.ReportProgress(100, "Завершено");
            System.Threading.Thread.Sleep(1000);
        }

        private void backgroundWorkerCatch_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            EnableControls();
            this.Cursor = Cursors.Default;
        }
        #endregion

        private void CallInsertPay(string FileName)
        {
            string InsOplSBR= "sp_InsOplSBR";
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();

            for (int i = 0; i < dataSetDBF.Tables["TableDBF"].Rows.Count; i++)
            {
                try
                {
                con.OpenConnection(SqlSettings);


                DataRow r = dataSetDBF.Tables["TableDBF"].Rows[i];
                SqlCommand sqlcom = new SqlCommand(InsOplSBR, con.Connection);
                sqlcom.CommandType = CommandType.StoredProcedure;

                sqlcom.Parameters.Add("@iCodeABonent", SqlDbType.Int);
                sqlcom.Parameters["@iCodeAbonent"].Value = Convert.ToInt32(r["n_lc"]);
                sqlcom.Parameters.Add("@iSUM_TO_PAY", SqlDbType.Money);
                sqlcom.Parameters["@iSUM_TO_PAY"].Value = Convert.ToDecimal(r["SUM_TO_PAY"]);
                sqlcom.Parameters.Add("@iPROC_DATE", SqlDbType.SmallDateTime);
                sqlcom.Parameters["@iPROC_DATE"].Value = Convert.ToDateTime(r["PROC_DATE"]);
                sqlcom.Parameters.Add("@iPO", SqlDbType.VarChar, 20);
                sqlcom.Parameters["@iPO"].Value = r["PO"];
                sqlcom.Parameters.Add("@iCOU_VAL_S", SqlDbType.Int);
                sqlcom.Parameters["@iCOU_VAL_S"].Value = Convert.ToInt32(r["COU_VAL_S"]);
                sqlcom.Parameters.Add("@iPAYTYPE", SqlDbType.TinyInt);
                sqlcom.Parameters["@iPAYTYPE"].Value = Convert.ToInt32(r["PAYTYPE"]);
                sqlcom.Parameters.Add("@NameFile", SqlDbType.VarChar);
                sqlcom.Parameters["@NameFile"].Value = FileName;


                sqlcom.ExecuteNonQuery();
                                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }


    }
}
