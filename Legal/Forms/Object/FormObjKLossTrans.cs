using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormLbr.Classes;
using System.Data.SqlClient;

namespace Legal.Forms.Object
{
    public partial class FormObjKLossTrans : FormLbr.FormBase
    {
        private int idObj;
        private int LEVELDATA = 0;
        private string POINT = "";

        public FormObjKLossTrans()
        {
            InitializeComponent();
        }

        public FormObjKLossTrans(int AbnObj)
        {
            InitializeComponent();
            this.idObj = AbnObj;
            for (int i = 2009; i <= 2050; i++)
                comboBoxYear.Items.Add(i);
            comboBoxYear.SelectedIndex = comboBoxYear.FindString(DateTime.Today.Year.ToString());
        }

        public FormObjKLossTrans(int AbnObj, string Point) : this(AbnObj)
        {
            LEVELDATA = 1;
            POINT = Point;
        }


        private void FormObjKLossTrans_Load(object sender, EventArgs e)
        {
            toolTipIns.SetToolTip(buttonInsert, "Внести");
            toolTipEdit.SetToolTip(buttonEdit, "Отредактировать");
            toolTipDel.SetToolTip(buttonDelete, "Удалить");

            if (LEVELDATA == 0)
            {
                this.SelectSqlData(dsAbn, dsAbn.vG_AbnObj, true, "where id = " + idObj.ToString());
                labelObjName.Text = "Объект " + dsAbn.vG_AbnObj.Rows[0]["ObjName"].ToString();
            }
            else
            {
                labelObjName.Text = "Счетчик " + POINT;
            }

            this.SelectSqlData(dsAbn, dsAbn.vG_AbnObjKLossTrans, true, "where idAbnObj = " + idObj.ToString() + " and LevelData = " + LEVELDATA.ToString());

            dgvInsert.Rows.Add(new object[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0});
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (dgvObjKLossTrans.Rows.Count>0)
            for(int i = 0; i < dgvObjKLossTrans.Rows.Count; i++)
            {
                if ((int)dgvObjKLossTrans.Rows[i].Cells["yearDGVTBC"].Value == (int)comboBoxYear.SelectedItem)
                {
                    MessageBox.Show("Потери на этот год уже внесены");
                    return;
                }
            }

            dsAbn.tG_AbnObjKLossTrans.Clear();

            DataRow dr = dsAbn.tG_AbnObjKLossTrans.NewRow();

              dr["idAbnObj"] = idObj;
              dr["Year"] = comboBoxYear.SelectedItem ;
              dr["M1"] = dgvInsert.Rows[0].Cells["M1"].Value;
              dr["M2"] = dgvInsert.Rows[0].Cells["M2"].Value;
              dr["M3"] = dgvInsert.Rows[0].Cells["M3"].Value;
              dr["M4"] = dgvInsert.Rows[0].Cells["M4"].Value;
              dr["M5"] = dgvInsert.Rows[0].Cells["M5"].Value;
              dr["M6"] = dgvInsert.Rows[0].Cells["M6"].Value;
              dr["M7"] = dgvInsert.Rows[0].Cells["M7"].Value;
              dr["M8"] = dgvInsert.Rows[0].Cells["M8"].Value;
              dr["M9"] = dgvInsert.Rows[0].Cells["M9"].Value;
              dr["M10"] = dgvInsert.Rows[0].Cells["M10"].Value;
              dr["M11"] = dgvInsert.Rows[0].Cells["M11"].Value;
              dr["M12"] = dgvInsert.Rows[0].Cells["M12"].Value;
              dr["Deleted"] = 0;
              dr["LevelData"] = LEVELDATA; 

            dsAbn.tG_AbnObjKLossTrans.Rows.Add(dr);

            dsAbn.tG_AbnObjKLossTrans.Rows[0].EndEdit();
            this.InsertSqlDataOneRow(dsAbn, dsAbn.tG_AbnObjKLossTrans);

            this.SelectSqlData(dsAbn, dsAbn.vG_AbnObjKLossTrans, true, "where idAbnObj = " + idObj.ToString());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int idLoss = (int)dgvObjKLossTrans.CurrentRow.Cells["id"].Value ;

            if (idLoss > 0)
            {
                dsAbn.tG_AbnObjKLossTrans.Clear();

                DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                SelectSqlData(ds.tG_AbnObjKLossTrans, true, "where id = " + idLoss.ToString(), null, false, 1);
                ds.tG_AbnObjKLossTrans.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tG_AbnObjKLossTrans.Rows[0]["Deleted"]);
                ds.tG_AbnObjKLossTrans.Rows[0].EndEdit();
                if (this.UpdateSqlData(ds, ds.tG_AbnObjKLossTrans))
                {
                    if (Convert.ToBoolean(ds.tG_AbnObjKLossTrans.Rows[0]["Deleted"]))
                    {
                        MessageBox.Show("Потери успешно удалены");
                        this.SelectSqlData(dsAbn, dsAbn.vG_AbnObjKLossTrans, true, "where idAbnObj = " + idObj.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Потери успешно восстановлены");
                        this.SelectSqlData(dsAbn, dsAbn.vG_AbnObjKLossTrans, true, "where idAbnObj = " + idObj.ToString());
                    }
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int idLoss = (int)dgvObjKLossTrans.CurrentRow.Cells["id"].Value ;

            if (idLoss > 0)
            {
                dsAbn.tG_AbnObjKLossTrans.Clear();

                DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                SelectSqlData(ds.tG_AbnObjKLossTrans, true, "where id = " + idLoss.ToString(), null,false,1);
                ds.tG_AbnObjKLossTrans.Rows[0]["idAbnObj"] = idObj;
                ds.tG_AbnObjKLossTrans.Rows[0]["Year"] = comboBoxYear.SelectedItem;
                ds.tG_AbnObjKLossTrans.Rows[0]["M1"] = dgvInsert.Rows[0].Cells["M1"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["M2"] = dgvInsert.Rows[0].Cells["M2"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["M3"] = dgvInsert.Rows[0].Cells["M3"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["M4"] = dgvInsert.Rows[0].Cells["M4"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["M5"] = dgvInsert.Rows[0].Cells["M5"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["M6"] = dgvInsert.Rows[0].Cells["M6"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["M7"] = dgvInsert.Rows[0].Cells["M7"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["M8"] = dgvInsert.Rows[0].Cells["M8"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["M9"] = dgvInsert.Rows[0].Cells["M9"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["M10"] = dgvInsert.Rows[0].Cells["M10"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["M11"] = dgvInsert.Rows[0].Cells["M11"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["M12"] = dgvInsert.Rows[0].Cells["M12"].Value;
                ds.tG_AbnObjKLossTrans.Rows[0]["Deleted"] = 0;
                ds.tG_AbnObjKLossTrans.Rows[0].EndEdit();
                if (this.UpdateSqlData(ds, ds.tG_AbnObjKLossTrans))
                {
                        MessageBox.Show("Потери успешно отредактированы");
                        this.SelectSqlData(dsAbn, dsAbn.vG_AbnObjKLossTrans, true, "where idAbnObj = " + idObj.ToString());
                }
                 else
                {
                        MessageBox.Show("Потери отредактировать неудалось");
                 }
                
            }
        }

        private void dgvObjKLossTrans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvObjKLossTrans.RowCount > 0)
            {
                comboBoxYear.SelectedItem = (int)dgvObjKLossTrans.CurrentRow.Cells["yearDGVTBC"].Value;
                dgvInsert.Rows[0].Cells["M1"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m1DataGridViewTextBoxColumn"].Value;
                dgvInsert.Rows[0].Cells["M2"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m2DataGridViewTextBoxColumn"].Value;
                dgvInsert.Rows[0].Cells["M3"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m3DataGridViewTextBoxColumn"].Value;
                dgvInsert.Rows[0].Cells["M4"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m4DataGridViewTextBoxColumn"].Value;
                dgvInsert.Rows[0].Cells["M5"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m5DataGridViewTextBoxColumn"].Value;
                dgvInsert.Rows[0].Cells["M6"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m6DataGridViewTextBoxColumn"].Value;
                dgvInsert.Rows[0].Cells["M7"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m7DataGridViewTextBoxColumn"].Value;
                dgvInsert.Rows[0].Cells["M8"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m8DataGridViewTextBoxColumn"].Value;
                dgvInsert.Rows[0].Cells["M9"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m9DataGridViewTextBoxColumn"].Value;
                dgvInsert.Rows[0].Cells["M10"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m10DataGridViewTextBoxColumn"].Value;
                dgvInsert.Rows[0].Cells["M11"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m11DataGridViewTextBoxColumn"].Value;
                dgvInsert.Rows[0].Cells["M12"].Value = (int)dgvObjKLossTrans.CurrentRow.Cells["m12DataGridViewTextBoxColumn"].Value;
            }
        }

    }
}
