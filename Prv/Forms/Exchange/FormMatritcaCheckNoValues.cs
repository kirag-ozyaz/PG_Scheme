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
    public partial class FormMatritcaCheckNoValues : FormLbr.FormBase
    {
        private DateTime d_beg; //дата начала
        private DateTime d_end; //дата окончания

        public FormMatritcaCheckNoValues()
        {
            InitializeComponent();
        }

        public FormMatritcaCheckNoValues(DateTime dbeg, DateTime dend)
        {
            d_beg = dbeg;
            d_end = dend;
            InitializeComponent();

        }


        private void FormMatritcaCheckNoValues_Load(object sender, EventArgs e)
        {
            labelDate.Text = "Нет показаний за период :     " + d_beg.ToString("yyyy.MM.dd") + "   по   " + d_end.ToString("yyyy.MM.dd");

            string strCmd = "select * from dbo.fn_PrvFromMatritcaCheckNoValues ('" + d_beg.ToString("yyyyMMdd") + "','" + d_end.ToString("yyyyMMdd") + "') order by CodeAbonent ";

            try
            {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                con.OpenConnection(SqlSettings);

                SqlCommand cmd = new SqlCommand(strCmd, con.Connection);

                cmd.CommandTimeout = 600;

                SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);

                dAdapt.Fill(dataSetExchange, "fn_PrvFromMatritcaCheckNoValues");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            this.Cursor = Cursors.Default;
        }

        private void buttonXls_Click(object sender, EventArgs e)
        {
            dgveData.CopyToExcel(true);
        }
    }
}
