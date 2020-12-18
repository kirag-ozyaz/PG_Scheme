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
    public partial class FormDebNotIns : FormLbr.FormBase
    {
        private int idM;
        private string MStr;


        public FormDebNotIns( int Period,  string PeriodStr )
        {
            idM = Period;
            MStr = PeriodStr;
            InitializeComponent();
        }

        private void FormDebNotIns_Load(object sender, EventArgs e)
        {
            this.Text = "Не прогружены за "  + MStr;

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            con.OpenConnection(SqlSettings);

            string strCmd = "select * from dbo.fn_PrvRepDebNotIns( @Month )";

            SqlCommand cmd = new SqlCommand(strCmd, con.Connection);

            cmd.Parameters.Add("@Month", SqlDbType.Int);
            cmd.Parameters["@Month"].Value = idM;

            SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);

            dAdapt.Fill(dsRep, "fn_PrvRepDebNotIns");

        }

        private void tsbToExel_Click(object sender, EventArgs e)
        {
            dgvefDebNotIns.CopyToExcel(true);
        }
    }
}
