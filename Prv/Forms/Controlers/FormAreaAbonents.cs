using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;

namespace Prv.Forms.Controlers
{
    public partial class FormAreaAbonents : FormLbr.FormBase
    {
        int codeStreet = -1;
        object house;
        object houseprefix;

        public FormAreaAbonents()
        {
            InitializeComponent();
        }
        public FormAreaAbonents(int codeStreet, object house, object houseprefix)
        {
            InitializeComponent();
            this.codeStreet = codeStreet;
            this.house = house;
            this.houseprefix = houseprefix;
        }

        private void FormAreaAbonents_Load(object sender, EventArgs e)
        {
            LoadAbonents();
        }

        #region toolStripMain
        // Поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvAreaControler.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin,
                toolStripTextBoxFind.Text);
        }
        // нажатие клавиши
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((!e.Control) && (e.KeyCode == Keys.Enter))
                dgvAreaControler.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next,
                    toolStripTextBoxFind.Text);
        }
        // поиск вперед
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvAreaControler.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next,
                toolStripTextBoxFind.Text);
        }
        // поиск назад
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvAreaControler.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev,
                toolStripTextBoxFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvAreaControler.PrintDataGridView();
        }
        // копировать в ексель
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvAreaControler.CopyToExcel(true);
        }
        // обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadAbonents();
        }
        #endregion

        #region contextMenu
        private void toolMenuItemOpen_Click(object sender, EventArgs e)
        {
            Prv.Forms.Abonent.FormAbonent f = new Prv.Forms.Abonent.FormAbonent(
                (int)dgvAreaControler.CurrentRow.Cells["codeAbonentDataGridViewTextBoxColumn"].Value, Constants.Constants.TypeAbnPrivate);
            f.SqlSettings = this.SqlSettings;
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void toolMenuItemCopy_Click(object sender, EventArgs e)
        {
            dgvAreaControler.CopyToBuffer(false);
        }

        private void toolMenuItemExcel_Click(object sender, EventArgs e)
        {
            dgvAreaControler.CopyToExcel(false);
        }

        private void еoolMenuItemPrint_Click(object sender, EventArgs e)
        {
            dgvAreaControler.PrintDataGridView();
        }
        #endregion

        private void LoadAbonents()
        {
            string wherehouse = "";
            if (house != DBNull.Value)
            {
                wherehouse = " and house = " + house.ToString();
                if (houseprefix == DBNull.Value)
                    wherehouse += " and houseprefix is null ";
                else
                    wherehouse += " and houseprefix = '" + houseprefix.ToString() + "' ";
            }
            this.SelectSqlData(dsPrv, dsPrv.vAbnFind, true, " where idStreet = " + codeStreet.ToString() +
                wherehouse + " and typeAbn = " + Constants.Constants.TypeAbnPrivate.ToString() +
                " and deleted = 0 and isActive = 1 "+
                " order by kladrobjName, streetname, house, houseprefix, dbo.GEtInt(apartment)");
        }

        private void dgvAreaControler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            {
                toolMenuItemOpen.Text = "Открыть " +
                    dgvAreaControler.CurrentRow.Cells["codeAbonentDataGridViewTextBoxColumn"].Value.ToString();
                //dgvControlers.CurrentRow.Cells["streetDataGrvTxtColumn"].Value.ToString();
                /*if (!String.IsNullOrEmpty(dgvControlers.CurrentRow.Cells["houseAllDgvTxtColumn"].Value.ToString()))
                    toolMenuItemOpen.Text += " д." +
                        dgvControlers.CurrentRow.Cells["houseAllDgvTxtColumn"].Value.ToString();*/
                this.contextMenuAbonents.Show(System.Windows.Forms.Cursor.Position);
            }
        }
    }
}
