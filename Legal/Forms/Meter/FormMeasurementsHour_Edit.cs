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
    public partial class FormMeasurementsHour_Edit : FormLbr.FormBase
    {
        private bool isUpdate = false;
        private int ID = -1;

        public FormMeasurementsHour_Edit()
        {
            InitializeComponent();
        }

        public FormMeasurementsHour_Edit(int id, bool update)
        {
            InitializeComponent();
            isUpdate = update;
            ID = id;
        }

        private void FormMeasurementsHour_Edit_Load(object sender, EventArgs e)
        {
            if (isUpdate == false)
            {
                DataRow r = dsAbnObjAct1.tG_MeasurementsHour.NewRow();
                r["YearValue"] = DateTime.Today.Year;
                r["MonthValue"] = DateTime.Today.Month;
                dsAbnObjAct1.tG_MeasurementsHour.Rows.Add(r);
                this.Text = "Новая запись";
            }
            else
            {
                this.SelectSqlData(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsHour, true, " where id = " + ID.ToString());
                this.Text = "Редактирование";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i = 0;
            foreach (Control cntr in grp.Controls)
            {
                CheckBox tb = cntr as CheckBox;
                if (tb != null)
                {
                    CheckBox chb = (CheckBox)cntr; 
                    if (chb.Checked == true)
                        i = i + 1;
                }
            }

            dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["HourCount"] = i;
            bool isOk = false;
            dsAbnObjAct1.tG_MeasurementsHour.Rows[0].EndEdit();
            if (isUpdate == false)
            {
                ID = this.InsertSqlDataOneRow(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsHour);
                if (ID > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Не удалось добавить запись");
            }
            else
            {
                isOk = this.UpdateSqlData(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsHour);
                if (isOk)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Не удалось изменить запись");
            }
            Close();
        }

    }
}
