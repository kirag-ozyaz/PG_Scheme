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
    public partial class FormObj_Linking : FormLbr.FormBase
    {
        public int IDABN;
        public int IDOBJ;

        public FormObj_Linking()
        {
            InitializeComponent();
        }

        public FormObj_Linking(int idAbn, int idObj)
        {
            InitializeComponent();
            IDABN = idAbn;
            IDOBJ = idObj;
        }

        private void FormObj_Linking_Load(object sender, EventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";
                strCmd = "select * from fn_LegObg_Linking(@idAbn)";

                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                SqlParameter p1 = new SqlParameter("@idAbn", IDABN);
                sqlCmd.Parameters.Add(p1);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsObj1.dtObj);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }

            for (int i = 0; i < dgvSelect.Rows.Count; i++)
            {
                if (Convert.ToUInt32(dgvSelect.Rows[i].Cells["idObjDGV"].Value) == IDOBJ)
                {
                    dgvSelect.CurrentCell = dgvSelect.Rows[i].Cells["NameDGV"];
                }
            }

        }


        private void dgvSelect_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Object.FormObjAE frm = (Object.FormObjAE)this.Owner;
            frm.OBJSELECT = Convert.ToInt32(dgvSelect.CurrentRow.Cells["idObjDGV"].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
