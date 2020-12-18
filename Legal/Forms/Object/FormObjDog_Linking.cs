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
    public partial class FormObjDog_Linking : FormLbr.FormBase
    {
        public int[] idArray;
        public int IDABN;
        public int IDDOG;

        public FormObjDog_Linking()
        {
            InitializeComponent();
        }

        public FormObjDog_Linking(int id, int idDog)
        {
            InitializeComponent();
            IDABN = id;
            IDDOG = idDog;
        }

        private void FormObjDog_Linking_Load(object sender, EventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";
                strCmd = "select * from fn_LegObgDog_Linking2(@idAbn, @idDog)";

                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                SqlParameter p = new SqlParameter("@idAbn", IDABN);
                sqlCmd.Parameters.Add(p);

                SqlParameter p2 = new SqlParameter("@idDog", IDDOG);
                sqlCmd.Parameters.Add(p2);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsObj1.dtObj);

                int ArrayLenght = dgvSelect.RowCount;
                idArray = new int[ArrayLenght];
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSelect.RowCount; i++)
            {
                if (dgvSelect.Rows[i].Cells["SelectCell"].Value != null)
                {
                    if ((bool)dgvSelect.Rows[i].Cells["SelectCell"].Value == true)
                        idArray[i] = (int)dgvSelect.Rows[i].Cells["id"].Value;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSelect.RowCount; i++)
            {
                dgvSelect.Rows[i].Cells["SelectCell"].Value = true;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSelect.RowCount; i++)
            {
                dgvSelect.Rows[i].Cells["SelectCell"].Value = false;
            }
        }

        private void dgvSelect_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvSelect.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

    }
}
