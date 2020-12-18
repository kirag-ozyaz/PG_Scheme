using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prv.Forms.Exchange
{
    public partial class FormMatritca : FormLbr.FormBase
    {
        private DateTime d_beg; //дата начала
        private DateTime d_end; //дата окончания
        private string strCmd;

        public FormMatritca()
        {
            InitializeComponent();
        }

        private void buttonFillData_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dataSetExchange.Tables["fn_PrvFromMatritca"].Clear();

            d_beg = Convert.ToDateTime(dTimeBeg.Value); //дата начала
            d_end = Convert.ToDateTime(dTimeEnd.Value); //дата окончания

            //string select = "select * from dbo.fn_PrvFromMatritca ('" + d_beg.ToString("yyyyMMdd") + "','" + d_end.ToString("yyyyMMdd") + "') order by CodeAbonent";

            //MessageBox.Show(select);
            
            //DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
            //try
            //{
            //    sql.OpenConnection(this.SqlSettings);

            //    dataSetExchange.Tables["fn_PrvFromMatritca"].Clear();
            //    System.Data.SqlClient.SqlDataAdapter dAdapt = new System.Data.SqlClient.SqlDataAdapter(select, sql.Connection);
            //    dAdapt.Fill(dataSetExchange, "fn_PrvFromMatritca");


            //}
            //catch (Exception ex) // Если ошибка
            //{
            //    MessageBox.Show(ex.Message, ex.Source);
            //}
            //finally
            //{   // В любом случае коннект надо закрыть
            //    sql.CloseConnection();
            //}

            if (checkBoxOnlyOne.Checked) strCmd = "select * from dbo.fn_PrvFromMatritcaEnd ('" + d_beg.ToString("yyyyMMdd") + "','" + d_end.ToString("yyyyMMdd") + "') order by CodeAbonent,Time ";
               else  strCmd = "select * from dbo.fn_PrvFromMatritca ('" + d_beg.ToString("yyyyMMdd") + "','" + d_end.ToString("yyyyMMdd") + "') order by CodeAbonent,Time ";

            try
            {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                con.OpenConnection(SqlSettings);

                SqlCommand cmd = new SqlCommand(strCmd, con.Connection);

                cmd.CommandTimeout = 600;

                SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);

                dAdapt.Fill(dataSetExchange, "fn_PrvFromMatritca");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            this.Cursor = Cursors.Default;
        }

        private void buttonCheckNoValue_Click(object sender, EventArgs e)
        {
            FormMatritcaCheckNoValues f = new FormMatritcaCheckNoValues(Convert.ToDateTime(dTimeBeg.Value), Convert.ToDateTime(dTimeEnd.Value));
            f.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
            f.Show();
        }

        private void buttonInsToGES_Click(object sender, EventArgs e)
        {

            DateTime date = dateTimePickerDateIns.Value.Date;

            DialogResult dialogResult = MessageBox.Show("Дата актов: " + date.ToString("D") + "\r\n" + "\r\n" + "        Внести данные?", "Внимание !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;

                string InsFromMatrica = "sp_InsFromMatrica";

                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();

                for (int i = 0; i < dataSetExchange.Tables["fn_PrvFromMatritca"].Rows.Count; i++)
                {
                   try
                    {

                    con.OpenConnection(SqlSettings);

                    DataRow r = dataSetExchange.Tables["fn_PrvFromMatritca"].Rows[i];
                    SqlCommand sqlcom = new SqlCommand(InsFromMatrica, con.Connection);
                    sqlcom.CommandType = CommandType.StoredProcedure;

                    sqlcom.Parameters.Add("@idPointReg", SqlDbType.Int);
                    sqlcom.Parameters["@idPointReg"].Value = Convert.ToInt32(r["idPointReg"]);

                    sqlcom.Parameters.Add("@idPoint", SqlDbType.Int);
                    sqlcom.Parameters["@idPoint"].Value = Convert.ToInt32(r["idPoint"]);

                    sqlcom.Parameters.Add("@Time", SqlDbType.DateTime);
                    if (checkBoxDateIns.Checked) sqlcom.Parameters["@Time"].Value = date;
                                            else sqlcom.Parameters["@Time"].Value = Convert.ToDateTime(r["Time"]);

                    sqlcom.Parameters.Add("@NValue", SqlDbType.Real);
                    sqlcom.Parameters["@NValue"].Value = Convert.ToDecimal(r["NValue"]);

                    sqlcom.Parameters.Add("@DValue", SqlDbType.Real);
                    sqlcom.Parameters["@DValue"].Value = Convert.ToDecimal(r["DValue"]);


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

                this.Cursor = Cursors.Default;
                MessageBox.Show("Данные успешно прогружены");
            }
        }

                // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgveData.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgveData.CopyToExcel(true);
        }
    }
}
