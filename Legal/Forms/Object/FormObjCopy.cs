using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Legal.Forms.Object
{
    public partial class FormObjCopy : FormLbr.FormBase
    {
        public int ID_SELECT;
        public int CODE_SELECT;
        public string NAME_SELECT;
        private int IDABN = -1;
        private int IDOBJ = -1;

        public FormObjCopy()
        {
            InitializeComponent();
        }

        public FormObjCopy(int idObj)
        {
            InitializeComponent();
            IDOBJ = idObj;
        }

        private void btnAbnName_Click(object sender, EventArgs e)
        {
            FormAbnObjFind f = new FormAbnObjFind(-2);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtCode.Text = CODE_SELECT.ToString();
                txtAbnName.Text = NAME_SELECT;
                IDABN = ID_SELECT;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if ((IDABN > 0) && (IDOBJ > 0))
            {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    strCmd = "Leg_ObjCopy";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@idAbn", IDABN);
                    sqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("@idAbnObj", IDOBJ);
                    sqlCmd.Parameters.Add(p2);

                    bool Minus = cbxMinus.Checked;
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
            }
            this.Close();

        }
    }
}
