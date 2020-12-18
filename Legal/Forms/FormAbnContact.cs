using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnContact : FormLbr.FormBase
    {
        private int ID = -1;

        public FormAbnContact()
        {
            InitializeComponent();
        }
        
        public FormAbnContact(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FormAbnContact_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnContact1, dsAbnContact1.tAbnContact, true, " where idAbn = " + ID.ToString());   
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormAbnContactAdd fAdd = new FormAbnContactAdd(ID, true);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbnContact1, dsAbnContact1.tAbnContact, true, " where idAbn = " + ID.ToString());
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewAbnContact.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
            FormAbnContactAdd fAdd = new FormAbnContactAdd(id, false);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbnContact1, dsAbnContact1.tAbnContact, true, " where idAbn = " + ID.ToString());
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите удалить контакт?", "Удаление",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridViewAbnContact.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                DeleteSqlDataById(dsAbnContact1.tAbnContact, id);
                this.SelectSqlData(dsAbnContact1, dsAbnContact1.tAbnContact, true, " where idAbn = " + ID.ToString());
            }
        }
    }
}
