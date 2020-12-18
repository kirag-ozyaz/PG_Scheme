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
    public partial class FormDocCopy : FormLbr.FormBase
    {
        private int IDDOC;

        public FormDocCopy()
        {
            InitializeComponent();
        }

        public FormDocCopy(int idDoc)
        {
            InitializeComponent();
            IDDOC = idDoc;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    strCmd = "LegDocCopy";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@idDoc", IDDOC);
                    sqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("@dtPay", dtDoc.Value.Date.ToString("yyyyMMdd"));
                    sqlCmd.Parameters.Add(p2);

                    bool Minus = cbMinus.Checked;
                    SqlParameter p3 = new SqlParameter("@Minus", Minus);
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

                DialogResult = DialogResult.OK;
                this.Close();
        }
    }
}
