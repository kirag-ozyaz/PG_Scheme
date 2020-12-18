using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormLbr.Classes;

namespace Legal.Forms.Prognosis
{
    public partial class FormPrognosisMonthAdd : FormLbr.FormBase
    {

        private int AbnFilter = 0;

        public FormPrognosisMonthAdd()
        {
            InitializeComponent();

            for (DateTime d_c = System.DateTime.Now; d_c >= new DateTime(2007, 01, 01);
            d_c = d_c.AddMonths(-1))
                cBoxPeriod.Items.Add(d_c);
        }

        private void FormPrognosisMonthAdd_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbn, dsAbn.vG_Contrl, true, " order by F");

            this.SelectSqlData(dsAbn, dsAbn.vG_AbnPrognosis, true, "where Status = 'Активный' order by CodeAbonent ");

            bsAbn.Filter = "idWorker = " + comboBoxWorker.SelectedValue.ToString();
        }

        private void comboBoxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsAbn.Filter = "idWorker = " + comboBoxWorker.SelectedValue.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (AbnFilter == 1)
            {
                bsAbn.Filter = null;
                AbnFilter = 0;
            }

            else
            {
                bsAbn.Filter = "Name like '%" + textBoxSearchName.Text.Trim() + "%' ";
                AbnFilter = 1;
            }

            AbnMiniDGV.Refresh();
        }

        private void textBoxAbnSearch_KeyUp(object sender, KeyEventArgs e)
        {

            for (int i = 0; i < AbnMiniDGV.RowCount; i++)
                if (AbnMiniDGV[1, i].FormattedValue.ToString().
                    Contains(textBoxAbnSearch.Text.Trim()))
                {
                    AbnMiniDGV.CurrentCell = AbnMiniDGV[1, i];
                    return;
                }
        }

        private void AbnMiniDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 4 && e.ColumnIndex <= 6) AbnMiniDGV[7, e.RowIndex].Value = AbnMiniDGV[e.ColumnIndex, e.RowIndex].Value; //MessageBox.Show(AbnMiniDGV[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private void bI_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Внести результаты I расчета?", "Выбор", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            for (int i = 0; i < AbnMiniDGV.RowCount; i++)
            {
                
                AbnMiniDGV.Rows[i].Cells[7].Value = AbnMiniDGV.Rows[i].Cells[4].Value;
            }
        }

        private void bII_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Внести результаты II расчета?", "Выбор", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            for (int i = 0; i < AbnMiniDGV.RowCount; i++)
            {
                AbnMiniDGV.Rows[i].Cells[7].Value = AbnMiniDGV.Rows[i].Cells[5].Value;
            }
        }

        private void bIII_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Внести результаты III расчета?", "Выбор", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            for (int i = 0; i < AbnMiniDGV.RowCount; i++)
            {
                AbnMiniDGV.Rows[i].Cells[7].Value = AbnMiniDGV.Rows[i].Cells[6].Value;
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
