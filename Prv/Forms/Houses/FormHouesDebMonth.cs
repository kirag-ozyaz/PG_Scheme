using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prv.Forms.Houses
{
    public partial class FormHouesDebMonth : FormLbr.FormBase
    {
        private int idM, Y;
        private string MStr;

        public FormHouesDebMonth()
        {
            InitializeComponent();
        }

        public FormHouesDebMonth(int idMap,int Year, string MapStr)
        {
            idM = idMap;
            Y = Year;
            MStr = MapStr;
            InitializeComponent();
        }

        #region toolStripMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvefHouse.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvefHouse.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvefHouse.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvefHouse.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvefHouse.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvefHouse.CopyToExcel(true); // ???
        }
        // Обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            dgvefHouse.Refresh();
        }
        #endregion

        private void FormHouesDebMonth_Load(object sender, EventArgs e)
        {
            this.Text = "Дебиторка за "+Y.ToString()+"г. по адресу "+ MStr;

            string select = "select * from dbo.fn_PrvMapHouseDeb (" + Y.ToString() + "," + idM.ToString() + ") order by CodeAbonent";


            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
            try
            {
                sql.OpenConnection(this.SqlSettings);

                dsPrv.Tables["fn_PrvMapHouseDeb"].Clear();
                System.Data.SqlClient.SqlDataAdapter dAdapt = new System.Data.SqlClient.SqlDataAdapter(select, sql.Connection);
                dAdapt.Fill(dsPrv, "fn_PrvMapHouseDeb");


            }
            catch (Exception ex) // Если ошибка
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {   // В любом случае коннект надо закрыть
                sql.CloseConnection();
            }


        }


    }
}
