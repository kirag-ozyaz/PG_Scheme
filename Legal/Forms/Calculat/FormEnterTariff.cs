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
    public partial class FormEnterTariff : FormLbr.FormBase
    {
        public FormEnterTariff()
        {
            InitializeComponent();
        }

        private void FormEnterTariff_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsCalc1, dsCalc1.vG_EnterTariff, true, " order by SocrName, SetDate");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv.CurrentRow.Cells["idDGV"].Value);
            string Name = Convert.ToString(dgv.CurrentRow.Cells["NameDGV"].Value);
            Calculat.FormEnterTariff_Edit fAdd = new Calculat.FormEnterTariff_Edit(id, Name);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                SelectSqlData(dsCalc1, dsCalc1.vG_EnterTariff, true, " order by SocrName, SetDate");
            }
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormCntVal frm = (FormCntVal)this.Owner;
            frm.IDTARIFF = Convert.ToInt32(dgv.CurrentRow.Cells["idDGV"].Value);
            frm.TARIFFVALUE = Convert.ToDecimal(dgv.CurrentRow.Cells["priceDataGridViewTextBoxColumn"].Value);
            this.DialogResult = DialogResult.OK;
            frm = null;
            this.Close();
            this.Dispose();
        }
    }
}
