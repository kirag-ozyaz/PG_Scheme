using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataSql;



namespace Legal.Forms.Document
{
    public partial class FormOrderAct : FormLbr.FormBase
    {
        // id объекта
        private int ID;
        // дата для фильтрации актов
        private DateTime DT;
        private int IDORDER;

        public FormOrderAct()
        {
            InitializeComponent();
        }

        public FormOrderAct(int id, DateTime dt, int idAct)
        {
            InitializeComponent();
            ID = id;
            DT = dt;
            IDORDER = idAct;
        }

        private void FormOrderAct_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_ActOrder, true, " where id = " + IDORDER);
            if (dsAbnDocum1.tG_ActOrder.Count > 0)
            {
                int idAct = Convert.ToInt32(dsAbnDocum1.tG_ActOrder.Rows[0]["idAct"]);
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.vAbnObjDoc_List, true, " where id = " + idAct);
            }
            else
            {
                string txtWhere = " where idAbnObj = " + ID.ToString();
                txtWhere += " and (DocDate >= '" + DT.ToString("yyyyMMdd") + "')";
                txtWhere += " and idDocType in (273, 599, 600, 601, 588)";

                SelectSqlData(dsAbnDocum1, dsAbnDocum1.vAbnObjDoc_List, true, txtWhere + " Order by DocDate desc");
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvObjDoc.CurrentRow != null)
            {
                ActCheck.FormDocAct_CheckAdd frmActCheckAdd = new ActCheck.FormDocAct_CheckAdd(this.SqlSettings, ID, Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idObjDocDGVBC"].Value));
                frmActCheckAdd.Show();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvObjDoc_DoubleClick(object sender, EventArgs e)
        {
            if (dgvObjDoc.CurrentRow != null)
            {
                ActCheck.FormDocAct_CheckAdd frmActCheckAdd = new ActCheck.FormDocAct_CheckAdd(this.SqlSettings, ID, Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idObjDocDGVBC"].Value));
                frmActCheckAdd.Show();
            }

        }
    }
}
