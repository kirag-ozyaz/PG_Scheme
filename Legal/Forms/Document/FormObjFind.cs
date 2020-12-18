using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Legal.Forms.Document
{
    public partial class FormObjFind : FormLbr.FormBase
    {
        private int ABNID = -1;
        private int OBJID = -1;
        private string CODE = "";

        public FormObjFind()
        {
            InitializeComponent();
        }

        public FormObjFind(int idAbn)
        {
            InitializeComponent();
            ABNID = idAbn;
        }

        public FormObjFind(int idAbn, int idAbnObj)
        {
            InitializeComponent();
            ABNID = idAbn;
            OBJID = idAbnObj;
        }

        // загрузка данных для грида
        private void FormObjFind_Load(object sender, EventArgs e)
        {
            cbxFilter.SelectedIndex = 0;
            SelectSqlData(dsFind1, dsFind1.vG_Find, true, " order by CodeAbonent");
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

        // обработка нажатий клавиш 
        private void dgvAbn_KeyDown(object sender, KeyEventArgs e)
        {
            if (CODE.Length > 3)
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
                        FormClose();
                        break;

                    default:
                        CODE = "";
                        break;
                }
                if (CODE != "")
                    AbnFind();
            }
        }

        // и переход на нужную строку
        private void AbnFind()
        {
            for (int i = 0; i < dgvAbn.RowCount; i++)
                if (dgvAbn[1, i].FormattedValue.ToString().Contains(CODE))
                {
                    dgvAbn.CurrentCell = dgvAbn[1, i];
                    return;
                }
        }

        // фильтровать данные в гриде
        private void btnFilter_Click(object sender, EventArgs e)
        {
            int id = cbxFilter.SelectedIndex;
            switch (id)
            {
                case 0:
                    this.SelectSqlData(dsFind1.vG_Find, true, " where [name] like '%" + txtFilter.Text + "%' order by codeAbonent ");
                    break;
                case 1:
                    this.SelectSqlData(dsFind1.vG_Find, true, " where [objname] like '%" + txtFilter.Text + "%' order by codeAbonent ");
                    break;
                default:
                    dsFind1.vG_Find.Clear();
                    break;
            }
            dgvAbn.Refresh();
        }

        // убрать фильтр
        private void btnDelFilter_Click(object sender, EventArgs e)
        {
            dsFind1.vG_Find.Clear();
            SelectSqlData(dsFind1, dsFind1.vG_Find, true, " order by CodeAbonent");
            dgvAbn.Refresh();
        }

        // выход и передача выбранных данных вызывающей форме
        private void dgvAbn_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormClose();
        }

        // выход из формы
        private void FormClose()
        {
            Document.FormActBalance frm = (Document.FormActBalance)this.Owner;
            frm.ABNSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbn"].Value);
            if (dgvAbn.CurrentRow.Cells["dgvIDAbnObj"].Value != System.DBNull.Value)
                frm.OBJSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["dgvIDAbnObj"].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
