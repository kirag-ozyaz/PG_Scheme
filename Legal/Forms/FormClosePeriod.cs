using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Legal.Forms
{
    public partial class FormClosePeriod : FormLbr.FormBase
    {
        public FormClosePeriod()
        {
            InitializeComponent();
        }

        private void FormClosePeriod_Load(object sender, EventArgs e)
        {

            SelectSqlData(dsCntVal1, dsCntVal1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCntVal1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCntVal1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCntVal1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCntVal1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);


            //DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dtBegin.Value = dt;
            //dtEnd.Value = dt.AddMonths(1).AddDays(-1);
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            ClosePeriod(true);
        }

        private void ClosePeriod(Boolean param)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "LegAbnCalcLockSetPeriod";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                // параметры
                DateTime BeginPeriod = dtBegin.Value.Date;
                SqlParameter p1 = new SqlParameter("@BeginPeriod", BeginPeriod);
                sqlCmd.Parameters.Add(p1);

                DateTime EndPeriod = dtEnd.Value.Date;
                SqlParameter p2 = new SqlParameter("@EndPeriod", EndPeriod);
                sqlCmd.Parameters.Add(p2);

                int parLock;
                if (param)
                    parLock = 1;
                else
                    parLock = 0;

                SqlParameter p3 = new SqlParameter("@parLock", parLock);
                sqlCmd.Parameters.Add(p3);
                sqlCmd.CommandTimeout = 0;

                sqlCmd.ExecuteNonQuery();
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

        private void btnNoLock_Click(object sender, EventArgs e)
        {
            ClosePeriod(false);
        }
    }
}
