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
    public partial class FormReportMainFilter : FormLbr.FormBase
    {
        public FormReportMainFilter()
        {
            InitializeComponent();
        }

        // заполнить данные
        private void FormReportMainFilter_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsReportMainFilter1, dsReportMainFilter1.tG_NameFilter, true, " where TypeFilter = 1 and deleted = 0 order by NameFilter");
            dgvFilter_Load();
        }

        // добавить новый фильтр
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                DataRow r = dsReportMainFilter1.tG_NameFilter.NewRow();
                r["id"] = -1;
                r["NameFilter"] = txtName.Text;
                r["TypeFilter"] = 1;
                r["Deleted"] = false;
                dsReportMainFilter1.tG_NameFilter.Rows.Add(r);
                int id = this.InsertSqlDataOneRow(dsReportMainFilter1, dsReportMainFilter1.tG_NameFilter);
                if (id < 0)
                    MessageBox.Show("Не удалось добавить фильтр..");
                // обновим список фильтров
                SelectSqlData(dsReportMainFilter1, dsReportMainFilter1.tG_NameFilter, true, " where TypeFilter = 1 and deleted = 0 order by NameFilter");
                // установим указатель на новую строку
                for (int i = 0; i < dgvListFilter.Rows.Count; i++)
                {
                    if ((int)dgvListFilter.Rows[i].Cells["dgvID"].Value == id)
                    {
                        dgvListFilter.CurrentCell = dgvListFilter.Rows[i].Cells["dgvNameFilter"];
                    }
                }

                // обновим грид "Формирование фильтра"
                dgvFilter_Load();
            }
            else
                MessageBox.Show("Введите имя фильтра..");
        }

        // удалить фильтр
        private void btnDel_Click(object sender, EventArgs e)
        {
            dsReportMainFilter1.tG_NameFilter.Rows[dgvListFilter.CurrentRow.Index].BeginEdit();
            dsReportMainFilter1.tG_NameFilter[dgvListFilter.CurrentRow.Index]["Deleted"] = true;
            dsReportMainFilter1.tG_NameFilter.Rows[dgvListFilter.CurrentRow.Index].EndEdit();
            UpdateSqlData(dsReportMainFilter1, dsReportMainFilter1.tG_NameFilter);

            // обновим список фильтров
            SelectSqlData(dsReportMainFilter1, dsReportMainFilter1.tG_NameFilter, true, " where TypeFilter = 1 and deleted = 0 order by NameFilter");

            // обновим грид "Формирование фильтра"
            dgvFilter_Load();
        }

        // добавить все элементы в фильтр
        private void btnCheck_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dgvFilter.RowCount; i++)
            {
                dgvFilter.Rows[i].Cells["dgvFlag"].Value = true;
            }
            Cursor.Current = Cursors.Default;
        }

        // удалить все элементы из фильтра
        private void btnUncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvFilter.RowCount; i++)
            {
                dgvFilter.Rows[i].Cells["dgvFlag"].Value = false;
            }
        }

        // сохранить изменения в фильтре
        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dgvFilter.RowCount; i++)
            {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    strCmd = "sp_LegSetFilter_GroupConsumer";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    int idFilter = Convert.ToInt32(dgvListFilter.CurrentRow.Cells["dgvID"].Value);
                    SqlParameter p1 = new SqlParameter("@idFilter", idFilter);
                    sqlCmd.Parameters.Add(p1);

                    int idClass = Convert.ToInt32(dgvFilter.Rows[i].Cells["dgvIdClass"].Value);
                    SqlParameter p2 = new SqlParameter("@idClass", idClass);
                    sqlCmd.Parameters.Add(p2);

                    bool Flag = Convert.ToBoolean(dgvFilter.Rows[i].Cells["dgvFlag"].Value);
                    SqlParameter p3 = new SqlParameter("@Flag", Flag);
                    sqlCmd.Parameters.Add(p3);

                    sqlCmd.CommandTimeout = 0;

                    sqlCmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }
            }
            Cursor.Current = Cursors.WaitCursor;
            MessageBox.Show("Фильтр сохранен..");
        }

        // выбрать фильтр и вернуться в основную форму
        private void dgvListFilter_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Calculat.FormReportMain frm = (Calculat.FormReportMain)this.Owner;
            frm.idFilter = Convert.ToInt32(dgvListFilter.CurrentRow.Cells["dgvID"].Value);;
            this.DialogResult = DialogResult.OK;
        }

        // загрузка грида "Формирование фильтра"
        private void dgvFilter_Load()
        {
            if (dgvListFilter.Rows.Count > 0)
            {

                if (dgvFilter.Rows.Count > 0)
                    dsReportMainFilter1.tFilter.Clear();

                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    strCmd = "select * from fn_LegGetFilter_GroupConsumer(@idFilter) ";
                    strCmd += " order by NameGroup, NameMember ";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                    int idFilter = Convert.ToInt32(dgvListFilter.CurrentRow.Cells["dgvID"].Value);
                    SqlParameter p1 = new SqlParameter("@idFilter", idFilter);
                    sqlCmd.Parameters.Add(p1);

                    sqlCmd.CommandTimeout = 0;

                    SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                    dAdapt.Fill(dsReportMainFilter1, "tFilter");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        // выбираем следующий фильтр и обновляем грид "Формирование фильтра
        private void dgvListFilter_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFilter_Load();
        }

        private void dgvFilter_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvFilter.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Calculat.FormReportMain frm = (Calculat.FormReportMain)this.Owner;
            frm.idFilter = Convert.ToInt32(dgvListFilter.CurrentRow.Cells["dgvID"].Value); ;
            this.DialogResult = DialogResult.OK;
        }

    }
}
