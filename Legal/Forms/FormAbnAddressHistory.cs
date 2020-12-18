using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnAddressHistory : FormLbr.FormBase
    {
        private int IDABN = -1;
        private int IDROW = -1;

        public FormAbnAddressHistory()
        {
            InitializeComponent();
        }

        public FormAbnAddressHistory(int id)
        {
            InitializeComponent();
            IDABN = id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAbnAddress frm = new FormAbnAddress(IDABN, true);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbnAddressList1, dsAbnAddressList1.tG_AbnAddress, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc, id desc");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAddressList.RowCount > 0)
            {
                IDROW = Convert.ToInt32(dgvAddressList.CurrentRow.Cells["dgvId"].Value);
                FormAbnAddress frm = new FormAbnAddress(IDROW, false);
                frm.SqlSettings = this.SqlSettings;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsAbnAddressList1, dsAbnAddressList1.tG_AbnAddress, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc, id desc");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvAddressList.RowCount > 0)
            {
                if (MessageBox.Show("Хотите удалить адрес?", "Удаление",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IDROW = Convert.ToInt32(dgvAddressList.CurrentRow.Cells["dgvId"].Value);
                    DeleteSqlDataById(dsAbnAddressList1.tG_AbnAddress, IDROW);
                    this.SelectSqlData(dsAbnAddressList1, dsAbnAddressList1.tG_AbnAddress, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc, id desc");
                }
            }

        }

        private void FormAbnAddressHistory_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnAddressList1, dsAbnAddressList1.tG_AbnAddress, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc, id desc");
            this.SelectSqlData(dsAbnAddressList1, dsAbnAddressList1.tR_Classifier, true, " where ParentKey = ';Contact;' and (Value = 1 or Value = 2)");
        }

        private void dgvAddressList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((int)dgvAddressList.Rows[e.RowIndex].Cells[2].Value == 54)
                    e.CellStyle.BackColor = Color.Gainsboro;
            }
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAddressList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }

    }
}
