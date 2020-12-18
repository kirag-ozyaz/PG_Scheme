using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnFindShort : FormLbr.FormBase
    {
        private int ABNID = -1;
        private string CODE = "";

        public FormAbnFindShort()
        {
            InitializeComponent();
        }

        public FormAbnFindShort(int idAbn)
        {
            InitializeComponent();
            ABNID = idAbn;
        }

        private void FormAbnFindShort_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsFind1, dsFind1.vG_AbnObjCntShort, true, " order by CodeAbonent");
            if (ABNID > 0)
            {
                for (int i = 0; i < dgvAbn.RowCount; i++)
                    if (dgvAbn[0, i].FormattedValue.ToString().Contains(ABNID.ToString()))
                    {
                        dgvAbn.CurrentCell = dgvAbn[1, i];
                        return;
                    }
            }

        }

        private void dgvAbn_KeyDown(object sender, KeyEventArgs e)
        {
            if (CODE.Length > 4)
                CODE = "";
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                        CODE += '0';
                        break;
                    case Keys.D1:
                        CODE += '1';
                        break;
                    case Keys.D2:
                        CODE += '2';
                        break;
                    case Keys.D3:
                        CODE += '3';
                        break;
                    case Keys.D4:
                        CODE += '4';
                        break;
                    case Keys.D5:
                        CODE += '5';
                        break;
                    case Keys.D6:
                        CODE += '6';
                        break;
                    case Keys.D7:
                        CODE += '7';
                        break;
                    case Keys.D8:
                        CODE += '8';
                        break;
                    case Keys.D9:
                        CODE += '9';
                        break;
                    case Keys.NumPad0:
                        CODE += '0';
                        break;
                    case Keys.NumPad1:
                        CODE += '1';
                        break;
                    case Keys.NumPad2:
                        CODE += '2';
                        break;
                    case Keys.NumPad3:
                        CODE += '3';
                        break;
                    case Keys.NumPad4:
                        CODE += '4';
                        break;
                    case Keys.NumPad5:
                        CODE += '5';
                        break;
                    case Keys.NumPad6:
                        CODE += '6';
                        break;
                    case Keys.NumPad7:
                        CODE += '7';
                        break;
                    case Keys.NumPad8:
                        CODE += '8';
                        break;
                    case Keys.NumPad9:
                        CODE += '9';
                        break;
                    case Keys.Enter:
                        if (ABNID == -1)
                        {
                            FormAbn frm = (FormAbn)this.Owner;
                            frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvCodeAbonent"].Value);
                            this.DialogResult = DialogResult.OK;
                            frm = null;
                            dsFind1.vG_AbnObjCntShort.Rows.Clear();
                            dgvAbn.Dispose();
                            dsFind1.Clear();
                            dsFind1.Dispose();
                            this.Close();
                            this.Dispose();
                        }
                        else
                        {
                            FormCntVal frm = (FormCntVal)this.Owner;
                            frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvCodeAbonent"].Value);
                            this.DialogResult = DialogResult.OK;
                            frm = null;
                            dsFind1.vG_AbnObjCntShort.Rows.Clear();
                            dgvAbn.Dispose();
                            dsFind1.Clear();
                            dsFind1.Dispose();
                            this.Close();
                            this.Dispose();
                        }
                        break;
                    default:
                        CODE = "";
                        break;
                }
                if (CODE != "")
                    AbnFind();
            }
        }

        private void AbnFind()
        {
            for (int i = 0; i < dgvAbn.RowCount; i++)
                if (dgvAbn[1, i].FormattedValue.ToString().Contains(CODE))
                {
                    dgvAbn.CurrentCell = dgvAbn[1, i];
                    return;
                }
        }

        private void dgvAbn_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormCntVal frm = (FormCntVal)this.Owner;
            frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvCodeAbonent"].Value);
            this.DialogResult = DialogResult.OK;
            frm = null;
            dsFind1.vG_AbnObjCntShort.Rows.Clear();
            dgvAbn.Dispose();
            dsFind1.Clear();
            dsFind1.Dispose();
            this.Close();
            this.Dispose();
        }



    }
}
