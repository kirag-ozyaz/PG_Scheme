using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Legal.Forms.Calculat
{
    public partial class FormEnterTariff_Edit: FormLbr.FormBase 
    {
        private int ID;
        private string NAME;

        public FormEnterTariff_Edit()
        {
            InitializeComponent();
        }

        public FormEnterTariff_Edit(int id, string Name)
        {
            InitializeComponent();
            ID = id;
            NAME = Name;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEnterTariff_Edit_Load(object sender, EventArgs e)
        {
            DataRow r = dsCalc1.tTariff.NewRow();
            r["idTariff"] = ID;
            r["idZone"] = System.DBNull.Value;
            r["SetDate"] = System.DateTime.Now.Date;
            r["Price"] = 0;
            dsCalc1.tTariff.Rows.Add(r);

            txtTariffName.Text = NAME;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            dsCalc1.tTariff.Rows[0].EndEdit();
            isOk = this.InsertSqlData(dsCalc1, dsCalc1.tTariff);
            if (isOk) this.DialogResult = DialogResult.OK;

            this.Close();
        }

    }
}
