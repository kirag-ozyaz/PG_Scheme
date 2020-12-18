using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;



namespace Prv.Forms.Reports
{
    public partial class FormActJournal : FormLbr.FormBase
    {
        private DialogResult result;

        public FormActJournal()
        {
            InitializeComponent();
        }

        private void FormActJournal_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            int year = DateTime.Now.Date.Year;
            dtBegin.Value = new DateTime(year, 1, 1);
            dtEnd.Value = new DateTime(year, 12, 31);

            SelectSqlData(dataSetRep1, dataSetRep1.tPrv_JournalAct, true, " where" + BuildWhereDate() + " order by numberAct desc");

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(1).AddDays(-1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(-1).AddDays(-1);
        }

        private string BuildWhereDate()
        {
            string txtWhereDate = " Deleted = 0";
            txtWhereDate += " and (dateAct >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                " (dateAct <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            return txtWhereDate;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvJournal.Rows.Count > 0)
            {
                FormActAddEdit frm = new FormActAddEdit(Convert.ToInt32(dgvJournal.CurrentRow.Cells["idDGV"].Value));
                frm.SqlSettings = this.SqlSettings;
                frm.Show();
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            // печать акта
            int ID = Convert.ToInt32(dgvJournal.CurrentRow.Cells["idDGV"].Value);
            this.SelectSqlData(dataSetRep1, dataSetRep1.tPrv_RepAct, true, " where idJournal = " + ID + " order by id");

            dataSetRep1.RepAct.Rows.Clear();
            int j = 0;
            for (int k = 0; k < dataSetRep1.tPrv_RepAct.Rows.Count; k++)
            {
                DataRow rw = dataSetRep1.RepAct.NewRow();
                rw["CodeAbonent"] = dataSetRep1.tPrv_RepAct.Rows[k]["CodeAbonent"];
                rw["Address"] = dataSetRep1.tPrv_RepAct.Rows[k]["Address"];
                rw["FIO"] = dataSetRep1.tPrv_RepAct.Rows[k]["FIO"];
                rw["Mark"] = dataSetRep1.tPrv_RepAct.Rows[k]["Mark"];
                rw["Number"] = dataSetRep1.tPrv_RepAct.Rows[k]["Number"];
                rw["NumberAct"] = Convert.ToInt32(dgvJournal.CurrentRow.Cells["numberAct"].Value);
                rw["DateAct"] = Convert.ToDateTime(dgvJournal.CurrentRow.Cells["dateAct"].Value);

                dataSetRep1.RepAct.Rows.Add(rw);
                dataSetRep1.RepAct.Rows[j++].EndEdit();
            }

            bool isDetail = false;
            FormRepNoKo rep = new FormRepNoKo(dataSetRep1, isDetail);
            rep.SqlSettings = this.SqlSettings;
            rep.MdiParent = this.ParentForm;
            rep.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadJournal();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("Вы действительно хотите удалить акт?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SelectSqlData(dataSetRep1, dataSetRep1.tPrv_JournalAct, true, "where id = " + Convert.ToInt32(dgvJournal.CurrentRow.Cells["idDGV"].Value));
                dataSetRep1.tPrv_JournalAct.Rows[0].BeginEdit();
                dataSetRep1.tPrv_JournalAct.Rows[0]["Deleted"] = -1;
                dataSetRep1.tPrv_JournalAct.Rows[0].EndEdit();
                UpdateSqlData(dataSetRep1, dataSetRep1.tPrv_JournalAct);
                dataSetRep1.tPrv_JournalAct.Rows.Clear();
                LoadJournal();
                MessageBox.Show("Акт удален ..");
            }
        }

        private void LoadJournal()
        {
            dataSetRep1.tPrv_JournalAct.Clear();
            SelectSqlData(dataSetRep1, dataSetRep1.tPrv_JournalAct, true, " where" + BuildWhereDate() + " order by NumberAct desc");
            dgvJournal.Refresh();
        }

        private void dgvJournal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvJournal.Rows.Count > 0)
            { 

                FormActAddEdit frm = new FormActAddEdit(Convert.ToInt32(dgvJournal.CurrentRow.Cells["idDGV"].Value));
                frm.SqlSettings = this.SqlSettings;
                frm.Show();
            }

        }


    }
}
