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
    public partial class FormHouses :  FormLbr.FormBase
    {
        public FormHouses()
        {
            InitializeComponent();
        }


        private void FormHouses_Load(object sender, EventArgs e)
        {
        //    SelectSqlData(dsPrv, dsPrv.vPrv_HouseAll, true, "");


            panelWait.Visible = false;

            //dgvefHouses.AutoGenerateColumns = true;
            //bwHouses.RunWorkerAsync();
        }

        #region toolStripMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvefHouses.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvefHouses.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvefHouses.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvefHouses.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvefHouses.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvefHouses.CopyToExcel(true);
        }
        // Обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            
            panelWait.Visible = true;

            panelWait.Refresh();

            DataGridAdd();
        
        }
        #endregion

        private void DataGridAdd()
        {


            string select = "select *";

            for (int i = 2009; i <= DateTime.Today.Year; i++)
            {

                 //select += ",[dbo].[fn_PrvGetMapDebitorka]([vPrv_HouseAll].idMap," + i.ToString() + ") [" + i.ToString() + "г.] ";
                select += ",(select sum(pKWT.KWT)	FROM   dbo.tMapObj AS m "
                            + "LEFT JOIN dbo.tAbnObj AS o ON o.idMap = m.idMap "
                            + "left join tPoint p on p.idAbnObj = o.id "
                            + "left join (SELECT [idPoint], "
                            + "				  sum(KWT) as [KWT] "
                            + "		   FROM [dbo].[tPrv_Debitorka] "
                            + "		   where [OK]= 1 and left(convert(varchar(6),MonthRasch),4) = left(convert(varchar(6)," + i.ToString() + "),4) "
                            + "		   group by [idPoint]) pKWT on pKWT.idPoint = p.id "
                            + "where m.idMap = [vPrv_HouseAll].idMap) [" + i.ToString() + "г.] ";
            }

            select += "from [vPrv_HouseAll] order by [KladrObj], [Street], [HouseAll]";



                dgvefHouses.AutoGenerateColumns = true;

                DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
                try
                {
                    
                    sql.OpenConnection(this.SqlSettings);

                    dsPrv.Tables["vPrv_HouseAll"].Clear();
                    

                    SqlCommand sqlCmd = new SqlCommand(select, sql.Connection);

                    sqlCmd.CommandTimeout = 600;

                    SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                    dAdapt.Fill(dsPrv, "vPrv_HouseAll");


                }
                catch (Exception ex) // Если ошибка
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {   // В любом случае коннект надо закрыть
                    sql.CloseConnection();
                }

                //форматируем столбци годов
                int j = 15; //начинаем с 16 столбца
                for (int i = 2009; i <= DateTime.Today.Year; i++)
                {
                    dgvefHouses.Columns[j].Width = 60;
                    j++;
                }

                panelWait.Visible = false;
        }

        private void dgvefHouses_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvefHouses.Columns[dgvefHouses.CurrentCell.ColumnIndex].HeaderText.Substring(0, 2) == "20"
                && dgvefHouses.Columns[dgvefHouses.CurrentCell.ColumnIndex].HeaderText.Substring(0, 4) != "2007"
                && dgvefHouses.Columns[dgvefHouses.CurrentCell.ColumnIndex].HeaderText.Substring(0, 4) != "2008")
            {
                //MessageBox.Show(dgvefHouses.Columns[dgvefHouses.CurrentCell.ColumnIndex].HeaderText );
                //
                FormHouesDebMonth f = new FormHouesDebMonth((int)dgvefHouses.CurrentRow.Cells[0].Value,
                                                            Convert.ToInt32(dgvefHouses.Columns[dgvefHouses.CurrentCell.ColumnIndex].HeaderText.Substring(0, 4))
                                                            , dgvefHouses.CurrentRow.Cells["kladrObj"].Value.ToString() + ", " + dgvefHouses.CurrentRow.Cells["street"].Value.ToString() + ", дом " + dgvefHouses.CurrentRow.Cells["house"].Value.ToString());
                f.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
                f.Show();
            }
        }

        private void FormHouses_Shown(object sender, EventArgs e)
        {
            
            panelWait.Visible = true;

            panelWait.Refresh();
            Cursor.Current = Cursors.WaitCursor;

            DataGridAdd();

            Cursor.Current = Cursors.Default;
        }

        private void dgvefHouses_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0) // если правой кнопкой
            {
                this.dgvefHouses.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                ///-----------
                dgvefHouses.CurrentCell = dgvefHouses[e.ColumnIndex, e.RowIndex]; //делаем текущей

                DebAbonentHouseTSMI.Visible= false;
                DebAllHouseMonthTSMI.Visible = false;

                if (dgvefHouses.Columns[dgvefHouses.CurrentCell.ColumnIndex].HeaderText.Substring(0, 2) == "20"
                && dgvefHouses.Columns[dgvefHouses.CurrentCell.ColumnIndex].HeaderText.Substring(0, 4) != "2007"
                && dgvefHouses.Columns[dgvefHouses.CurrentCell.ColumnIndex].HeaderText.Substring(0, 4) != "2008")
                {
                    DebAbonentHouseTSMI.Visible = true;
                    DebAllHouseMonthTSMI.Visible = true;
                }
                this.cmsHouses.Show(System.Windows.Forms.Cursor.Position);
            }
        }

        private void DebAbonentHouseTSMI_Click(object sender, EventArgs e)
        {
            FormHouesDebMonth f = new FormHouesDebMonth((int)dgvefHouses.CurrentRow.Cells[0].Value,
                                                     Convert.ToInt32(dgvefHouses.Columns[dgvefHouses.CurrentCell.ColumnIndex].HeaderText.Substring(0, 4))
                                                     , dgvefHouses.CurrentRow.Cells["kladrObj"].Value.ToString() + ", " + dgvefHouses.CurrentRow.Cells["street"].Value.ToString() + ", дом " + dgvefHouses.CurrentRow.Cells["house"].Value.ToString());
            f.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
            f.Show();
        }

        private void DebAllHouseMonthTSMI_Click(object sender, EventArgs e)
        {
            
            FormHousesAllDebMonth f = new FormHousesAllDebMonth(Convert.ToInt32(dgvefHouses.Columns[dgvefHouses.CurrentCell.ColumnIndex].HeaderText.Substring(0, 4)));
            f.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
            
            f.Show();
        }

        private void CloseHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHouseClose f = new FormHouseClose((int)dgvefHouses.CurrentRow.Cells[0].Value
                                         , dgvefHouses.CurrentRow.Cells["kladrObj"].Value.ToString() + ", " + dgvefHouses.CurrentRow.Cells["street"].Value.ToString() + ", дом " + dgvefHouses.CurrentRow.Cells["house"].Value.ToString(),"All");
            f.MdiParent = this.MdiParent;
            f.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
            f.Show();
        }

        private void DelStatHouseTSMenuItem_Click(object sender, EventArgs e)
        {
            FormHouseOpen f = new FormHouseOpen((int)dgvefHouses.CurrentRow.Cells[0].Value
                             , dgvefHouses.CurrentRow.Cells["kladrObj"].Value.ToString() + ", " + dgvefHouses.CurrentRow.Cells["street"].Value.ToString() + ", дом " + dgvefHouses.CurrentRow.Cells["house"].Value.ToString());
            f.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
            f.Show();
        }

        private void tsmiActiveChangeStatus_Click(object sender, EventArgs e)
        {
            FormHouseClose f = new FormHouseClose((int)dgvefHouses.CurrentRow.Cells[0].Value
                             , dgvefHouses.CurrentRow.Cells["kladrObj"].Value.ToString() + ", " + dgvefHouses.CurrentRow.Cells["street"].Value.ToString() + ", дом " + dgvefHouses.CurrentRow.Cells["house"].Value.ToString(), "OnlyActive");
            f.MdiParent = this.MdiParent;
            f.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
            f.Show();
        }


    

          
        
    }
}
