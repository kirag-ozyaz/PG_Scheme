using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prv.Forms.Exchange
{
    public partial class FormUEanalysis : FormLbr.FormBase
    {
        private string where = "";

        public FormUEanalysis()
        {
            InitializeComponent();
        }

        private void FormUEanalysis_Load(object sender, EventArgs e)
        {
            tscbOk.SelectedIndex = 0;
            tscbTypeDoc.SelectedIndex = 0;
            this.SelectSqlData(dsExchange, dsExchange.vPrv_DocOplUEPostFiles, false);
        }


        private void LoadOpl()
        {
            if (dgvefUEoplPostFiles.RowCount > 0)
            {
                where = "";

                if (tscbOk.Text == "Не провелась") where = "where Ok = 0 ";
                if (tscbTypeDoc.Text == "Оплата")
                {
                    if (where == "")
                        where = "where TypeKod in (1,12) ";
                    else
                        where = where + " and TypeKod in (1,12) ";
                }

                if (where == "") where = "where NameFile = '" + dgvefUEoplPostFiles.CurrentRow.Cells[0].Value.ToString() + "'";
                else where = where + " and NameFile = '" + dgvefUEoplPostFiles.CurrentRow.Cells[0].Value.ToString() + "'";

                if (string.IsNullOrEmpty(where)) where = "where  not [Dogovor]  in (select dogovor from tPrv_UEPostNotIns)";
                else where += " and not [Dogovor]  in (select dogovor from tPrv_UEPostNotIns)";
                this.SelectSqlDataTableOther(dsExchange, dsExchange.vPrv_DocOplUEPost, "tPrv_DocOplUEPost", true, where);
            }
        }

        private void dgvefUEoplPostFiles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoadOpl();
        }

        private void tscbTypeDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOpl();
        }

        private void tscbOk_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOpl();
        }

        #region toolStripMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvefUEoplPostDoc.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvefUEoplPostDoc.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvefUEoplPostDoc.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvefUEoplPostDoc.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvefUEoplPostDoc.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvefUEoplPostDoc.CopyToExcel(true);
        }

        #endregion

        private void tsbInsAgain_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Внести оплату?", "Внести оплату", MessageBoxButtons.YesNo);
           if (dialogResult == DialogResult.Yes)
           {
               DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
               try
               {
                   con.OpenConnection(SqlSettings);

                   InsertPayUEagain(con.Connection);
               }
               catch (Exception ex) // ошибка соединения
               {
                   MessageBox.Show(ex.Message, ex.Source);
               }
               finally
               {
                   con.CloseConnection();
                   LoadOpl();
               }
           }
        }

        private void InsertPayUEagain(SqlConnection con)
        {
            string InsOplUEagain = "sp_InsOplUEPostAgain";

            SqlCommand sqlcom = new SqlCommand(InsOplUEagain, con);
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.ExecuteNonQuery();
        }
    }
}
