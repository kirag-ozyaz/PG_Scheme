using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prv.Forms.Houses
{
    public partial class FormHousesAllDebMonth : FormLbr.FormBase
    {

        private int  Y;

        public FormHousesAllDebMonth()
        {
            InitializeComponent();
        }

        public FormHousesAllDebMonth(int Year)
        {
            Y = Year;
            InitializeComponent();
        }

        #region toolStripMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvefHousesAll.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvefHousesAll.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvefHousesAll.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvefHousesAll.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvefHousesAll.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvefHousesAll.CopyToExcel(true);
        }
        // Обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            dgvefHousesAll.Refresh();
        }
        #endregion

        private void FormHousesAllDebMonth_Load(object sender, EventArgs e)
        {      
            this.Text = "Дебиторка за " + Y.ToString();
            panelWait.Visible = true;

            panelWait.Refresh();
            Cursor.Current = Cursors.WaitCursor;

            DataGridAdd();


            panelWait.Visible = false;
            Cursor.Current = Cursors.Default;

            this.Show();
        }
          
        private void DataGridAdd()
        {
            string select = "select * from fn_PrvGetMapHouseAllDeb (" + Y.ToString() + ") order by [KladrObj], [Street], [HouseAll]";

            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
            try
            {
                sql.OpenConnection(this.SqlSettings);

                dsPrv.Tables["fn_PrvGetMapHouseAllDeb"].Clear();


                SqlCommand sqlCmd = new SqlCommand(select, sql.Connection);

                sqlCmd.CommandTimeout = 600;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsPrv, "fn_PrvGetMapHouseAllDeb");


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
