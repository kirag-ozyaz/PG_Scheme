using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prv.Forms.Reports
{
    public partial class FormDebCalc : FormLbr.FormBase
    
    {
        private int MonthBegin, MonthEnd;
        private int sec;
        private DateTime localDate;
        private string message;

        public FormDebCalc()
        {
            InitializeComponent();


            for (DateTime d_c = System.DateTime.Now; d_c >= new DateTime(2007, 01, 01);
            d_c = d_c.AddMonths(-1))
            {
                cBoxBegin.Items.Add(d_c);
                cBoxEnd.Items.Add(d_c);
            }
            cBoxBegin.SelectedIndex = 1;
            cBoxEnd.SelectedIndex = 1;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("             Произвести расчет ?", "Расчет", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Будет произведен расчет с " + cBoxBegin.Text + " по " + cBoxEnd.Text + " . РАССЧИТАТЬ ? ", "Внимание!", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {

                    Cursor.Current = Cursors.WaitCursor;

                    MonthBegin = Convert.ToInt32(Convert.ToDateTime(cBoxBegin.SelectedItem).ToString("yyyyMM"));
                    MonthEnd = Convert.ToInt32(Convert.ToDateTime(cBoxEnd.SelectedItem).ToString("yyyyMM"));
                 
                    sec = 0;
                    localDate = DateTime.Now;
                    timerCalc.Start();

                    bgWCalc.RunWorkerAsync();

                    
                }
            }

            
        }

        private void timerCalc_Tick(object sender, EventArgs e)
        {
            sec = sec + 1;

            int minutes = sec / 60;
            int newSec = sec - minutes * 60;
            int hour = minutes / 60;
            int newMinnutes = minutes - hour * 60;
            TimeSpan time = new TimeSpan(0,hour, newMinnutes, newSec);

            //if (newMinnutes == 1) { bgWCount.RunWorkerAsync(); };

            labelTimer.Text = String.Format("Время выполнения  {0} ч. {1} м. {2} с.", time.Hours, time.Minutes, time.Seconds);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            sec = 0;
            timerCalc.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerCalc.Stop();
        }

        private void bgWCalc_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            con.OpenConnection(SqlSettings);

            try
            {


                string CalcDeb = "sp_PrvCalcDebitorkaAll";

                SqlCommand sqlcom = new SqlCommand(CalcDeb, con.Connection);
                sqlcom.CommandType = CommandType.StoredProcedure;

                sqlcom.Parameters.Add("@Date_Beg", SqlDbType.Int);
                sqlcom.Parameters["@Date_Beg"].Value = MonthBegin;

                sqlcom.Parameters.Add("@Date_End", SqlDbType.Int);
                sqlcom.Parameters["@Date_End"].Value = MonthEnd;

                sqlcom.CommandTimeout = 7200;
                sqlcom.ExecuteNonQuery();

            }
            catch (Exception ex) // ошибка соединения
            {
                con.CloseConnection();
                Cursor.Current = Cursors.Default;
                message = "Что то пошло не так!";

                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
                Cursor.Current = Cursors.Default;
                message = "Расчет прошел успешно!";
               // MessageBox.Show("Расчет прошел успешно!");
            }
        }

        private void bgWCalc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timerCalc.Stop();

            labelEnd.Text = message;
        }


        private void CalcCount() 
        {
            
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            con.OpenConnection(SqlSettings);

            string sql =
                " select count(*) from tPrv_Debitorka where [OK] = 1 and  [DateRasch] > = (@date) ";
            SqlCommand sqlcom = new SqlCommand(sql, con.Connection);
            sqlcom.Parameters.Add("@date", SqlDbType.DateTime);
            sqlcom.Parameters["@date"].Value = localDate;

            sqlcom.CommandTimeout = 180;
                try
                {
                  labelEnd.Text = Convert.ToString((Int32)sqlcom.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
  
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            string test = SqlSettings.ToString();
            CalcCount();
        }

        private void bgWCount_DoWork(object sender, DoWorkEventArgs e)
        {
           CalcCount();
        }
    }
}
