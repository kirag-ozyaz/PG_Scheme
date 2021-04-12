using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
namespace JournalOrder
{
    internal partial class FormJournalOrderClose : FormBase
    {
        internal FormJournalOrderClose()
        {
            this.InitializeComponent();
        }

        private void FormJournalOrderClose_Load(object sender, EventArgs e)
        {
            this.dateTimePickerCloseReg.Value = DateTime.Now;
            this.dateTimePickerRes.Value = DateTime.Now;
            this.LoadWorkers();
            this.LoadRegistered();
            this.LoadOrder();
        }

        private void LoadWorkers()
        {
            base.SelectSqlData(this.dsOrderRegistered, this.dsOrderRegistered.vWorkerGroup, true, " where ParentKey in (';GroupWorker;Dispatchers;')  and dateend is null order by fio ");
            base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.vWorkerGroup, true, " where ParentKey in (';GroupWorker;Dispatchers;')  and dateend is null order by fio ");
            this.cmbCloseWorkerRegistered.SelectedIndex = -1;
            this.cmbOrderRes.SelectedIndex = -1;
        }

        private void LoadRegistered()
        {
            this.Cursor = Cursors.WaitCursor;
            int idDokum = -1;
            if (this.dgvOrderRegistered.CurrentRow != null)
            {
                idDokum = Convert.ToInt32(this.dgvOrderRegistered.CurrentRow.Cells[this.idDgvColumnReg.Name].Value);
            }
            string str = string.Concat(new string[]
            {
            " (registered <> 0 and beginRes is null and dateclose is null) and dateEnd < '",
            this.dateTimePickerCloseReg.Value.ToString("yyyyMMdd HH:mm"),
            "' and (dateEndExt < '",
            this.dateTimePickerCloseReg.Value.ToString("yyyyMMdd HH:mm"),
            "' or dateEndExt is null)"
            });
            string str2 = string.Concat(new string[]
            {
            " (registered <> 0 and dateclose is null) and dateEnd < '",
            this.dateTimePickerCloseReg.Value.ToString("yyyyMMdd HH:mm"),
            "' and (dateEndExt < '",
            this.dateTimePickerCloseReg.Value.ToString("yyyyMMdd HH:mm"),
            "' or dateEndExt is null)"
            });
            base.SelectSqlData(this.dsOrderRegistered, this.dsOrderRegistered.vJ_Order, true, " where " + str + " order by num");
            base.SelectSqlData(this.dsOrderRegistered, this.dsOrderRegistered.tJ_Order, true, " where " + str2 + " order by num");
            if (idDokum > 0)
            {
                this.dgvOrderRegistered.SearchGrid(this.idDgvColumnReg.Name, idDokum.ToString(), false);
            }
            this.Cursor = Cursors.Default;
        }

        private void LoadOrder()
        {
            this.Cursor = Cursors.WaitCursor;
            int idDokum = -1;
            if (this.dgvOrder.CurrentRow != null)
            {
                idDokum = Convert.ToInt32(this.dgvOrder.CurrentRow.Cells[this.idDgvColumn.Name].Value);
            }
            string str = string.Concat(new string[]
            {
            " (beginRes is not null and dateClose is null) and dateEnd < '",
            this.dateTimePickerRes.Value.ToString("yyyyMMdd HH:mm"),
            "' and (dateEndExt < '",
            this.dateTimePickerCloseReg.Value.ToString("yyyyMMdd HH:mm"),
            "' or dateEndExt is null)"
            });
            string str2 = string.Concat(new string[]
            {
            " (dateclose is null) and dateEnd < '",
            this.dateTimePickerRes.Value.ToString("yyyyMMdd HH:mm"),
            "' and (dateEndExt < '",
            this.dateTimePickerCloseReg.Value.ToString("yyyyMMdd HH:mm"),
            "' or dateEndExt is null)"
            });
            base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.vJ_Order, true, " where " + str + " order by num");
            base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_Order, true, " where " + str2 + " order by num");
            if (idDokum > 0)
            {
                this.dgvOrder.SearchGrid(this.idDgvColumn.Name, idDokum.ToString(), false);
            }
            this.Cursor = Cursors.Default;
        }

        private void buttonCloseAllReg_Click(object sender, EventArgs e)
        {
            if (this.cmbCloseWorkerRegistered.SelectedValue == null)
            {
                MessageBox.Show("Не выбран диспетчер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            foreach (object obj in ((IEnumerable)this.dgvOrderRegistered.Rows))
            {
                int num = Convert.ToInt32(((DataGridViewRow)obj).Cells[this.idDgvColumnReg.Name].Value);
                DataRow[] array = this.dsOrderRegistered.tJ_Order.Select("id = " + num.ToString());
                if (array.Length != 0)
                {
                    array[0]["DateClose"] = this.dateTimePickerCloseReg.Value;
                    array[0]["closeWorker"] = this.cmbCloseWorkerRegistered.SelectedValue;
                    array[0].EndEdit();
                }
            }
            base.UpdateSqlData(this.dsOrderRegistered, this.dsOrderRegistered.tJ_Order);
            this.LoadRegistered();
            MessageBox.Show("Наряды успешно закрыты");
        }

        private void buttonCloseSelReg_Click(object sender, EventArgs e)
        {
            if (this.cmbCloseWorkerRegistered.SelectedValue == null)
            {
                MessageBox.Show("Не выбран диспетчер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            foreach (object obj in this.dgvOrderRegistered.SelectedRows)
            {
                int idDokum = Convert.ToInt32(((DataGridViewRow)obj).Cells[this.idDgvColumnReg.Name].Value);
                DataRow[] array = this.dsOrderRegistered.tJ_Order.Select("id = " + idDokum.ToString());
                if (array.Length != 0)
                {
                    array[0]["DateClose"] = this.dateTimePickerCloseReg.Value;
                    array[0]["closeWorker"] = this.cmbCloseWorkerRegistered.SelectedValue;
                    array[0].EndEdit();
                }
            }
            base.UpdateSqlData(this.dsOrderRegistered, this.dsOrderRegistered.tJ_Order);
            this.LoadRegistered();
            MessageBox.Show("Наряды успешно закрыты");
        }

        private void buttonCloseAllRes_Click(object sender, EventArgs e)
        {
            if (this.cmbOrderRes.SelectedValue == null)
            {
                MessageBox.Show("Не выбран диспетчер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            foreach (object obj in ((IEnumerable)this.dgvOrder.Rows))
            {
                int idDokum = Convert.ToInt32(((DataGridViewRow)obj).Cells[this.idDgvColumn.Name].Value);
                DataRow[] array = this.dataSetOrder.tJ_Order.Select("id = " + idDokum.ToString());
                if (array.Length != 0)
                {
                    array[0]["DateClose"] = this.dateTimePickerRes.Value;
                    array[0]["closeWorker"] = this.cmbOrderRes.SelectedValue;
                    array[0].EndEdit();
                }
            }
            base.UpdateSqlData(this.dataSetOrder, this.dataSetOrder.tJ_Order);
            this.LoadOrder();
            MessageBox.Show("Наряды успешно закрыты");
        }

        private void buttonCloseSelRes_Click(object sender, EventArgs e)
        {
            if (this.cmbOrderRes.SelectedValue == null)
            {
                MessageBox.Show("Не выбран диспетчер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            foreach (object obj in this.dgvOrder.SelectedRows)
            {
                int idDokum = Convert.ToInt32(((DataGridViewRow)obj).Cells[this.idDgvColumn.Name].Value);
                DataRow[] array = this.dataSetOrder.tJ_Order.Select("id = " + idDokum.ToString());
                if (array.Length != 0)
                {
                    array[0]["DateClose"] = this.dateTimePickerRes.Value;
                    array[0]["closeWorker"] = this.cmbOrderRes.SelectedValue;
                    array[0].EndEdit();
                }
            }
            base.UpdateSqlData(this.dataSetOrder, this.dataSetOrder.tJ_Order);
            this.LoadOrder();
            MessageBox.Show("Наряды успешно закрыты");
        }

        private void dgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.dgvOrder[this.beginResDgvColumnRes.Name, e.RowIndex].Value != DBNull.Value)
                {
                    e.CellStyle.BackColor = Color.LawnGreen;
                }
                if (this.dgvOrder[this.endResDgvColumnRes.Name, e.RowIndex].Value != DBNull.Value && this.dgvOrder.Columns[e.ColumnIndex] == this.numDgvColumn)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dgvOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && this.dgvOrder.CurrentRow != null)
            {
                FormJournalOrderAddEdit form = new FormJournalOrderAddEdit(Convert.ToInt32(this.dgvOrder.CurrentRow.Cells[this.idDgvColumn.Name].Value), false);
                form.SqlSettings = this.SqlSettings;
                form.ShowDialog();
                this.LoadOrder();
                this.dgvOrder.SearchGrid(this.idDgvColumn.Name, form.IdOrder.ToString(), false);
            }
        }

        private void dgvOrderRegistered_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && this.dgvOrderRegistered.CurrentRow != null)
            {
                FormJournalOrderAddEdit form = new FormJournalOrderAddEdit(Convert.ToInt32(this.dgvOrderRegistered.CurrentRow.Cells[this.idDgvColumnReg.Name].Value), false);
                form.SqlSettings = this.SqlSettings;
                form.ShowDialog();
                this.LoadRegistered();
                this.dgvOrderRegistered.SearchGrid(this.idDgvColumnReg.Name, form.IdOrder.ToString(), false);
            }
        }


    }
}