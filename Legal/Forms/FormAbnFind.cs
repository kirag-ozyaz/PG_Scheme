using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Legal.Forms
{
    public partial class FormAbnObjFind : FormLbr.FormBase
    {
        private int ABNID = -1;
        private int OBJID = -1;
        private string CODE = "";

        public FormAbnObjFind()
        {
            InitializeComponent();
        }

        public FormAbnObjFind(int idAbn)
        {
            InitializeComponent();
            ABNID = idAbn;
        }

        public FormAbnObjFind(int idAbn, int idAbnObj)
        {
            InitializeComponent();
            ABNID = idAbn;
            OBJID = idAbnObj;
        }


        private void FormAbnFind_Load(object sender, EventArgs e)
        {
            cbxFilter.SelectedIndex = 0;
            SelectSqlData(dsFind1, dsFind1.vG_AbnObjCnt, true, " order by CodeAbonent");
            if (ABNID > 0)
            {
                for (int i = 0; i < dgvAbn.RowCount; i++)
                    if (dgvAbn[0, i].FormattedValue.ToString().Contains(ABNID.ToString()))
                    {
                        dgvAbn.CurrentCell = dgvAbn[1, i];
                        return;
                    }
            }
            else if (OBJID > 0)
            {
                for (int i = 0; i < dgvAbn.RowCount; i++)
                    if (dgvAbn[8, i].FormattedValue.ToString().Contains(OBJID.ToString()))
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
                        //if (ABNID == -1)
                        //{
                        //    FormAbn frm = (FormAbn)this.Owner;
                        //    frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvCodeAbonent"].Value);
                        //    this.DialogResult = DialogResult.OK;
                        //    this.Close();
                        //}
                        //else
                        //{
                        //        FormCntVal frm = (FormCntVal)this.Owner;
                        //        frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvCodeAbonent"].Value);
                        //        this.DialogResult = DialogResult.OK;
                        //        this.Close();
                        //}

                        if (ABNID == -1)
                        {
                            FormAbn frm = (FormAbn)this.Owner;
                            frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvCodeAbonent"].Value);
                            this.DialogResult = DialogResult.OK;
                            dgvAbn.Dispose();
                            dsFind1.Clear();
                            this.Close();
                        }
                        else if (ABNID == -2)
                        {
                            Object.FormObjCopy frm = (Object.FormObjCopy)this.Owner;
                            frm.CODE_SELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvCodeAbonent"].Value);
                            frm.NAME_SELECT = dgvAbn.CurrentRow.Cells["dgvName"].Value.ToString();
                            frm.ID_SELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbn"].Value);
                            this.DialogResult = DialogResult.OK;
                            dgvAbn.Dispose();
                            dsFind1.Clear();
                            this.Close();
                        }
                        else if (ABNID == -3)
                        {
                            Object.FormObjAE frm = (Object.FormObjAE)this.Owner;
                            frm.OBJSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbnObj"].Value);
                            this.DialogResult = DialogResult.OK;
                            dgvAbn.Dispose();
                            dsFind1.Clear();
                            this.Close();
                        }
                        else if (ABNID == -4)
                        {
                            Document.FormActBalance frm = (Document.FormActBalance)this.Owner;
                            frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbn"].Value);
                            frm.OBJSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbnObj"].Value);
                            this.DialogResult = DialogResult.OK;
                            dgvAbn.Dispose();
                            dsFind1.Clear();
                            this.Close();
                        }
                        else if (ABNID == -5)
                        {
                            Document.FormActBalance frm = (Document.FormActBalance)this.Owner;
                            frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbn"].Value);
                            this.DialogResult = DialogResult.OK;
                            dgvAbn.Dispose();
                            dsFind1.Clear();
                            this.Close();
                        }
                        else
                            if (OBJID == -1)
                            {
                                FormCntVal frm = (FormCntVal)this.Owner;
                                frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvCodeAbonent"].Value);
                                this.DialogResult = DialogResult.OK;
                                dgvAbn.Dispose();
                                dsFind1.Clear();
                                this.Close();
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int id = cbxFilter.SelectedIndex;
            switch (id)
            {
                case 0:
                    this.SelectSqlDataTableOther(dsFind1, dsFind1.vG_AbnObjCnt, "vG_AbnObjCnt", true, " where [name] like '%" + txtFilter.Text + "%' order by codeAbonent ");
                    break;
                case 1:
                    this.SelectSqlDataTableOther(dsFind1, dsFind1.vG_AbnObjCnt, "vG_AbnObjCnt", true, " where [objname] like '%" + txtFilter.Text + "%' order by codeAbonent ");
                    break;
                case 2:
                    this.SelectSqlDataTableOther(dsFind1, dsFind1.vG_AbnObjCnt, "vG_AbnObjCnt", true, " where [number] like '%" + txtFilter.Text + "%' order by codeAbonent ");
                    break;
                case 3:
                    this.SelectSqlDataTableOther(dsFind1, dsFind1.vG_AbnObjCnt, "vG_AbnObjCnt", true, " where [name_group] like '%" + txtFilter.Text + "%' order by codeAbonent ");
                    break;
                case 4:
                    this.SelectSqlDataTableOther(dsFind1, dsFind1.vG_AbnObjCnt, "vG_AbnObjCnt", true, " where [idNet] like '%" + cbxFilter2.ComboBox.SelectedValue.ToString() + "%' order by codeAbonent ");
                    break;
                case 5:
                    this.SelectSqlDataTableOther(dsFind1, dsFind1.vG_AbnObjCnt, "vG_AbnObjCnt", true, " where [idSale] like '%" + cbxFilter2.ComboBox.SelectedValue.ToString() + "%' order by codeAbonent ");
                    break;
                case 6:
                    this.SelectSqlDataTableOther(dsFind1, dsFind1.vG_AbnObjCnt, "vG_AbnObjCnt", true, " where [CodeAbnStr] like '%" + txtFilter.Text + "%' order by codeAbonent ");
                    break;
                case 7:
                    this.SelectSqlDataTableOther(dsFind1, dsFind1.vG_AbnObjCnt, "vG_AbnObjCnt", true, " where [schmObjName] like '%" + txtFilter.Text + "%' order by codeAbonent ");
                    break;

                default:
                    dsFind1.vG_AbnObjCnt1.Clear();
                    break;
            }


            dgvAbn.Refresh();
        }

        private void btnDelFilter_Click(object sender, EventArgs e)
        {
            dsFind1.vG_AbnObjCnt.Clear();
            SelectSqlData(dsFind1, dsFind1.vG_AbnObjCnt, true, " order by CodeAbonent");
            dgvAbn.Refresh();
        }

        private void dgvAbn_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ABNID == -1)
            {
                FormAbn frm = (FormAbn)this.Owner;
                frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvCodeAbonent"].Value);
                this.DialogResult = DialogResult.OK;
                dgvAbn.Dispose();
                dsFind1.Clear();
                this.Close();
            }
            else if (ABNID == -2)
            {
                Object.FormObjCopy frm = (Object.FormObjCopy)this.Owner;
                frm.CODE_SELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvCodeAbonent"].Value);
                frm.NAME_SELECT = dgvAbn.CurrentRow.Cells["dgvName"].Value.ToString();
                frm.ID_SELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbn"].Value);
                this.DialogResult = DialogResult.OK;
                dgvAbn.Dispose();
                dsFind1.Clear();
                this.Close();
            }
            else if (ABNID == -3)
            {
                Object.FormObjAE frm = (Object.FormObjAE)this.Owner;
                frm.OBJSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbnObj"].Value);
                this.DialogResult = DialogResult.OK;
                dgvAbn.Dispose();
                dsFind1.Clear();
                this.Close();
            }
            else if (ABNID == -4)
            {
                Document.FormActBalance frm = (Document.FormActBalance)this.Owner;
                frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbn"].Value);
                frm.OBJSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbnObj"].Value);
                this.DialogResult = DialogResult.OK;
                dgvAbn.Dispose();
                dsFind1.Clear();
                this.Close();
            }
            else if (ABNID == -5)
            {
                Document.FormActBalance frm = (Document.FormActBalance)this.Owner;
                frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbn"].Value);
                this.DialogResult = DialogResult.OK;
                dgvAbn.Dispose();
                dsFind1.Clear();
                this.Close();
            }
            else if (ABNID == -6)
            {
                Calculat.FormReportHouseAll frm = (Calculat.FormReportHouseAll)this.Owner;
                frm.OBJSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbnObj"].Value);
                this.DialogResult = DialogResult.OK;
                dgvAbn.Dispose();
                dsFind1.Clear();
                this.Close();
            }
            else if (ABNID == -7)
            {
                Calculat.FormReportHouseAll frm = (Calculat.FormReportHouseAll)this.Owner;
                frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbn"].Value);
                this.DialogResult = DialogResult.OK;
                dgvAbn.Dispose();
                dsFind1.Clear();
                this.Close();
            }

            else
            if (OBJID == -1)
            {
                FormCntVal frm = (FormCntVal)this.Owner;
                frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvCodeAbonent"].Value);
                this.DialogResult = DialogResult.OK;
                dgvAbn.Dispose();
                dsFind1.Clear();
                this.Close();
            }
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFilter.ComboBox.SelectedIndex == 4)
            {
                SelectSqlData(dsFind1, dsFind1.tAbn, true, " where TypeAbn = " + (int)Constants.AbnType.Net);
                cbxFilter2.ComboBox.DataSource = dsFind1.tAbn;
                cbxFilter2.ComboBox.DisplayMember = "Name";
                cbxFilter2.ComboBox.ValueMember = "id";
            }
            else if (cbxFilter.ComboBox.SelectedIndex == 5)
            {
                SelectSqlData(dsFind1, dsFind1.tAbn, true, " where TypeAbn = " + (int)Constants.AbnType.Sale);
                cbxFilter2.ComboBox.DataSource = dsFind1.tAbn;
                cbxFilter2.ComboBox.DisplayMember = "Name";
                cbxFilter2.ComboBox.ValueMember = "id";
            }

        }

        private void FormAbnObjFind_FormClosed(object sender, FormClosedEventArgs e)
        {
            dsFind1.Clear();
        }

        private void dgvAbn_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //if (e.RowIndex > -1 && e.RowIndex < dgvAbn.RowCount)
            //{
            //    if (dgvAbn.Rows[e.RowIndex].Cells["Flag"].Value.ToString() == null)
            //        ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            //}
        }

    }
}
