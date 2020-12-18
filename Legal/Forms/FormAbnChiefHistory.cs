using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnChiefHistory : FormLbr.FormBase
    {
        private int ID = -1;

        public FormAbnChiefHistory()
        {
            InitializeComponent();
        }
        
        public FormAbnChiefHistory(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FormAbnChiefHistory_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnChief, dsAbnChief.tG_AbnChief, true, " where idAbn = " + ID.ToString() + "order by DateChange desc");
        }

        private void dataGridViewAbnChiefHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //позиционирование в гриде
        private int GetRowIndexByKey(DataGridView dgv, string columnName, int key)
        {
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                if (Convert.ToInt32(dr.Cells[columnName].Value) == key)
                    return dr.Index;
            }
            return 0;
        }

        private void dataGridViewAbnChiefHistory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idGrid = Convert.ToInt32(dataGridViewAbnChiefHistory.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
            FormAbnChief f = new FormAbnChief(idGrid, false, "FormAbnChiefHistory");
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                dataGridViewAbnChiefHistory.CurrentCell = dataGridViewAbnChiefHistory["idDataGridViewTextBoxColumn", GetRowIndexByKey(dataGridViewAbnChiefHistory, "idDataGridViewTextBoxColumn", idGrid)];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
