using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;

namespace Prv.Forms.Abonent
{
    public partial class FormAbnStatus : FormLbr.FormBase
    {
        private int ID = -1;
        private int CA = -1; 

        #region Property
        public int CodeAbonent
        {
            get
            {
                return CA ;
            }
        }
        public int TypeAbn
        {
            get
            {
                return 206;
            }
        }
        #endregion

        public FormAbnStatus()
        {
            InitializeComponent();
        }
        
        public FormAbnStatus(int id,int CodeAbonent)
        {
            InitializeComponent();
            ID = id;
            CA = CodeAbonent;
        }
        //позиционирование в гриде
        private int GetRowIndexByKey(DataGridView dgv, string columnName, int key)
        {
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                if (Convert.ToInt32(dr.Cells[columnName].Value) == key)
                    return dr.Index;
            }
            return 0;
        }
        private void FormAbnStat_Load(object sender, EventArgs e)
        {

            this.SelectSqlData(dsAbn, dsAbn.tR_Classifier, true, " where ParentId = 289 order by Name");
            this.SelectSqlData(dsAbn, dsAbn.vAbnStatusReason, true, " where idAbn = " + ID.ToString() + "order by DateChange desc");
   
            GetStat();
        }

        private void GetStat()
        {
           
            if (radioButtonEdit.Checked)
            {

                if ((bool)dGVEFStat.CurrentRow.Cells["isActiveDGVCheckBoxColumn"].Value == true)
                {
                    checkBoxStatus.CheckState = CheckState.Checked;
                }
                else { checkBoxStatus.CheckState = CheckState.Unchecked; };

                if (Convert.ToString(dGVEFStat.CurrentRow.Cells["nameDGVTBC"].Value) == "") idReasonComboBox.SelectedIndex = -1;
                else idReasonComboBox.SelectedIndex = idReasonComboBox.FindString(Convert.ToString(dGVEFStat.CurrentRow.Cells["nameDGVTBC"].Value));

                dTPStat.Value = Convert.ToDateTime(dGVEFStat.CurrentRow.Cells["dateChangeDGrVTBC"].Value);
            }
            if (radioButtonNew.Checked)
            {
                checkBoxStatus.CheckState = CheckState.Unchecked;
                idReasonComboBox.SelectedIndex = -1;
                dTPStat.Value = DateTime.Today;
            }
            
        }
       
        private void dGVEFStat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetStat();
        }


        private void dGVEFStat_KeyUp(object sender, KeyEventArgs e)
        {
            GetStat();
        }

        private void radioButtonNew_MouseClick(object sender, MouseEventArgs e)
        {
            GetStat();
        }

        private void radioButtonEdit_MouseClick(object sender, MouseEventArgs e)
        {
            GetStat();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonEdit.Checked)
            {
               int id = Convert.ToInt32(dGVEFStat.CurrentRow.Cells["idDGVTBC"].Value);
               Prv.DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
               this.SelectSqlData(ds, ds.tAbnStatus, true, "where id = " + Convert.ToInt32(dGVEFStat.CurrentRow.Cells["idDGVTBC"].Value));

               ds.tAbnStatus.Rows[0]["idAbn"] = ID;// Convert.ToInt32(dGVEFStat.CurrentRow.Cells["idAbnDGVTBC"].Value);
               ds.tAbnStatus.Rows[0]["isActive"] = checkBoxStatus.Checked;
               ds.tAbnStatus.Rows[0]["idReason"] = (idReasonComboBox.SelectedValue == null) ? DBNull.Value : idReasonComboBox.SelectedValue; 
               ds.tAbnStatus.Rows[0]["DateChange"] = dTPStat.Value;
               ds.tAbnStatus.Rows[0].EndEdit();
               if (this.UpdateSqlData(ds, ds.tAbnStatus))
                {
                    MessageBox.Show("Данные изменены.");
                 }
               this.SelectSqlData(dsAbn, dsAbn.vAbnStatusReason, true, " where idAbn = " + ID.ToString() + "order by DateChange desc");
               //dGVEFStat.CurrentCell = dGVEFStat["idDGVTBC", GetRowIndexByKey(dGVEFStat, "idDGVTBC", id)];
               dGVEFStat.CurrentCell = dGVEFStat["dateChangeDGrVTBC", GetRowIndexByKey(dGVEFStat, "idDGVTBC", id)];
               GetStat();
           
            }
            if (radioButtonNew.Checked)
            {
                int ok = 1;
                for (int i = 0; i < dGVEFStat.RowCount; i++)
                    if (Convert.ToDateTime(dGVEFStat["dateChangeDGrVTBC", i].Value) == dTPStat.Value)
                    {
                        MessageBox.Show("Статус с такой датой уже существует.");
                        ok = 0;
                        return;
                    }
                if (ok == 1)
                {
                    DataRow r = dsAbn.tAbnStatus.NewRow();
                    r["idAbn"] = ID;
                    r["isActive"] = checkBoxStatus.Checked;
                    r["idReason"] = (idReasonComboBox.SelectedValue == null) ? DBNull.Value : idReasonComboBox.SelectedValue;
                    r["DateChange"] = dTPStat.Value;
                    dsAbn.tAbnStatus.Rows.Add(r);
                    int idDoc = this.InsertSqlDataOneRow(dsAbn, dsAbn.tAbnStatus);
                    //  if (idDoc > 0)
                    //      DialogResult = DialogResult.OK;


                    this.SelectSqlData(dsAbn, dsAbn.vAbnStatusReason, true, " where idAbn = " + ID.ToString() + "order by DateChange desc");
                    GetStat();
                }
             }
            dsAbn.tAbnStatus.Clear();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    
    
    }

}
