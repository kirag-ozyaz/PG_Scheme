using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Dogovor
{
    public partial class FormObjDogovorCopy : FormLbr.FormBase
    {
       // public int[] id;

        private int idAbn;
        private int idDog;

        public FormObjDogovorCopy()
        {
            InitializeComponent();
        }

        public FormObjDogovorCopy(int idAbn,int idDog)
        {
            this.idAbn = idAbn;
            this.idDog = idDog;
            InitializeComponent();

        }

        private void FormObjDogovorCopy_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbn, dsAbn.vAbnDoc_List, true, " where idAbn = " + idAbn.ToString() + " order by DocDate desc");
            if (dgvAbnDoc.Rows.Count > 0) { this.SelectSqlData(dsAbn, dsAbn.vG_Dog_Obj, true, " where idList = " + dgvAbnDoc.CurrentRow.Cells["idDocDGVTBC"].Value.ToString() + " order by NumberObj, NumberSubObj"); }
        }

        private void dgvAbnDoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.SelectSqlData(dsAbn, dsAbn.vG_Dog_Obj, true, " where idList = " + dgvAbnDoc.CurrentRow.Cells["idDocDGVTBC"].Value.ToString() + " and DateEnd is null order by NumberObj, NumberSubObj");
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            if (dgvObj.Rows.Count > 0)
            {

                for (int i = 0; i < dgvObj.RowCount; i++)
                {
                    dsAbn.tG_Dog_Obj.Clear();
                    SelectSqlData(dsAbn, dsAbn.tG_Dog_Obj, true, "where idDog =" + idDog.ToString() + " and idObj = " + dgvObj.Rows[i].Cells["idObj"].Value.ToString());

                    if (dsAbn.tG_Dog_Obj.Rows.Count == 0)
                    {
                        dsAbn.tG_Dog_Obj.Clear();
                        DataRow drw = dsAbn.tG_Dog_Obj.NewRow();
                        drw["idDog"] = idDog;
                        drw["idObj"] = (int)dgvObj.Rows[i].Cells["idObj"].Value;
                        drw["NumberObj"] = (int)dgvObj.Rows[i].Cells["numberObj"].Value;
                        drw["NumberSubObj"] = (int)dgvObj.Rows[i].Cells["numberSubObj"].Value;
                        drw["DateBegin"] = dtpDate.Value;
                        drw["DateEnd"] = DBNull.Value;
                        dsAbn.tG_Dog_Obj.Rows.Add(drw);
                        InsertSqlData(dsAbn, dsAbn.tG_Dog_Obj);
                    }
                    else
                    { MessageBox.Show("Объект [ " + dgvObj.Rows[i].Cells["nameDataGridViewTextBoxColumn"].Value.ToString() + " ] уже есть в договоре."); }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Копировать нечего");
            }
        }
    }
}
