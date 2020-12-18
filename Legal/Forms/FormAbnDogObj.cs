using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnDogObj : FormLbr.FormBase
    {
        private int ID;
        public FormAbnDogObj()
        {
            InitializeComponent();
        }
        public FormAbnDogObj(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FormAbnDogObj_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnDogObj1, dsAbnDogObj1.tG_Dog_Obj, true, " where id = " + ID.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsAbnDogObj1.tG_Dog_Obj.Rows[0].BeginEdit();

            dsAbnDogObj1.tG_Dog_Obj.Rows[0]["DateBegin"] = dateTimePicker1.Value.Date;
            if (dateTimePicker2.Checked)
                dsAbnDogObj1.tG_Dog_Obj.Rows[0]["DateEnd"] = dateTimePicker2.Value.Date;
            else
                dsAbnDogObj1.tG_Dog_Obj.Rows[0]["DateEnd"] = System.DBNull.Value;

            if (tbNumberObj.Text == "")
                dsAbnDogObj1.tG_Dog_Obj.Rows[0]["NumberObj"] = 0;
            else
                dsAbnDogObj1.tG_Dog_Obj.Rows[0]["NumberObj"] = tbNumberObj.Text;
            
            if (tbNumberSubObj.Text == "")
                dsAbnDogObj1.tG_Dog_Obj.Rows[0]["NumberSubObj"] = 0;
            else
                dsAbnDogObj1.tG_Dog_Obj.Rows[0]["NumberSubObj"] = tbNumberSubObj.Text;

            dsAbnDogObj1.tG_Dog_Obj.Rows[0].EndEdit();
            UpdateSqlData(dsAbnDogObj1, dsAbnDogObj1.tG_Dog_Obj);
            this.DialogResult = DialogResult.OK;
        }
    }
}
