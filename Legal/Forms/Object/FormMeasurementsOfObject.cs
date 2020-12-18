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
    public partial class FormMeasurementsOfObject : FormLbr.FormBase
    {
        private int IDOBJ;

        public FormMeasurementsOfObject()
        {
            InitializeComponent();
        }

        public FormMeasurementsOfObject(int idObj)
        {
            InitializeComponent();
            IDOBJ = idObj;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Object.FormMeasurementsOfObject_Edit frm = new Object.FormMeasurementsOfObject_Edit(IDOBJ, false);
            frm.SqlSettings = this.SqlSettings;
            frm.ShowDialog();
            this.SelectSqlData(dsObj1, dsObj1.vG_MeasurementsOfObject , true, " where idObj = " + IDOBJ.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMeasurObj.Rows.Count > 0)
            {
                Object.FormMeasurementsOfObject_Edit frm = new Object.FormMeasurementsOfObject_Edit((Int32)dgvMeasurObj.CurrentRow.Cells["idDGV"].Value, true);
                frm.SqlSettings = this.SqlSettings;
                frm.ShowDialog();
                this.SelectSqlData(dsObj1, dsObj1.vG_MeasurementsOfObject, true, " where idObj = " + IDOBJ.ToString());
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvMeasurObj.Rows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить текущую строку?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                    try
                    {
                        int id = (Int32)dgvMeasurObj.CurrentRow.Cells["idDGV"].Value;
                        this.DeleteSqlDataById(dsObj1.tG_MeasurementsOfObject, id);
                        /*con.OpenConnection(SqlSettings);
                        
                        string strCmd = "";
                        strCmd = "Leg_DelMeasurObj";
                        SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@id", id);
                        sqlCmd.Parameters.Add(p1);

                        sqlCmd.CommandTimeout = 0;
                        sqlCmd.ExecuteNonQuery();*/
                        this.SelectSqlData(dsObj1, dsObj1.vG_MeasurementsOfObject, true, " where idObj = " + IDOBJ.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                    //finally
                    //{
                    //    con.CloseConnection();
                    //}
                }
            }
        }

        private void FormMeasurementsOfObject_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsObj1, dsObj1.vG_MeasurementsOfObject, true, " where idObj = " + IDOBJ.ToString());
        }

    }
}
