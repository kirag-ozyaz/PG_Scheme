using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Legal.Forms.Meter
{
    public partial class FormMeasurementsHour : FormLbr.FormBase
    {
        public FormMeasurementsHour()
        {
            InitializeComponent();
        }

        private void FormMeasurementsHour_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsHour, true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Meter.FormMeasurementsHour_Edit frm = new Meter.FormMeasurementsHour_Edit(0,false);
            frm.SqlSettings = this.SqlSettings;
            frm.ShowDialog();
            this.SelectSqlData(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsHour, true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvHour.Rows.Count > 0)
            {
                Meter.FormMeasurementsHour_Edit frm = new Meter.FormMeasurementsHour_Edit((Int32)dgvHour.CurrentRow.Cells["idDGV"].Value, true);
                frm.SqlSettings = this.SqlSettings;
                frm.ShowDialog();
                this.SelectSqlData(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsHour, true);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvHour.Rows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить текущую строку?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int id = (Int32)dgvHour.CurrentRow.Cells["idDGV"].Value;
                        this.DeleteSqlDataById(dsAbnObjAct1.tG_MeasurementsHour, id);
                        this.SelectSqlData(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsHour, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                }
            }

        }
    }
}
