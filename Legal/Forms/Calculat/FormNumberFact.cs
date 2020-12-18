using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Legal.Forms.Calculat
{
    public partial class FormNumberFact : FormLbr.FormBase
    {
        public FormNumberFact()
        {
            InitializeComponent();
        }

        private void FormNumberFact_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsCalc1, dsCalc1.tG_NumberFact, true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calculat.FormNumberFactAdd fAdd = new FormNumberFactAdd();
            fAdd.SqlSettings = this.SqlSettings;
            fAdd.ShowDialog();
            SelectSqlData(dsCalc1, dsCalc1.tG_NumberFact, true);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "LegSaveNumberCount";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                int id = Convert.ToInt32(dgv.CurrentRow.Cells["id"].Value);
                SqlParameter p1 = new SqlParameter("@id", id);
                sqlCmd.Parameters.Add(p1);

                int m = Convert.ToInt32(dgv.CurrentRow.Cells["periodMonth"].Value);
                SqlParameter p2 = new SqlParameter("@periodMonth", m);
                sqlCmd.Parameters.Add(p2);

                int y = Convert.ToInt32(dgv.CurrentRow.Cells["periodYear"].Value);
                SqlParameter p3 = new SqlParameter("@periodYear", y);
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
            SelectSqlData(dsCalc1, dsCalc1.tG_NumberFact, true);
        }
    }
}
