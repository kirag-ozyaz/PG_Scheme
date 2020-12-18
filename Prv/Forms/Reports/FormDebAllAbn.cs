using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prv.Forms.Reports
{
    public partial class FormDebAllAbn : FormLbr.FormBase
    {
        public FormDebAllAbn()
        {
            InitializeComponent();
        }


        #region toolStripMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            DGEFDeb.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                DGEFDeb.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            DGEFDeb.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            DGEFDeb.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }

        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            DGEFDeb.CopyToExcel(true);
        }
        // Обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {

           DataGridAdd();

        }
        #endregion


        private void FormDebAllAbn_Load(object sender, EventArgs e)
        {
            

            for (int i = 2009; i <= 2020; i++)
                cbYearBeg.Items.Add(i);
            cbYearBeg.SelectedIndex = cbYearBeg.FindString((Convert.ToInt16(DateTime.Today.Year)-1).ToString());
            for (int i = 2009; i <= 2020; i++)
                cbYearEnd.Items.Add(i);
            cbYearEnd.SelectedIndex = cbYearBeg.FindString(DateTime.Today.Year.ToString());

            cbMonthBeg.SelectedIndex = 0;
            cbMonthEnd.SelectedIndex = Convert.ToInt16(DateTime.Today.Month)-1;

        }

        private void DataGridAdd()
        {
            
            Cursor.Current = Cursors.WaitCursor;

            string select = "";
            DateTime DateBeg = new DateTime(Convert.ToInt32(cbYearBeg.Text), Convert.ToInt32(cbMonthBeg.SelectedIndex)+1, 1);
            DateTime DateEnd = new DateTime(Convert.ToInt32(cbYearEnd.Text), Convert.ToInt32(cbMonthEnd.SelectedIndex)+1, 1);

            select += " SELECT abn.[CodeAbonent],"
                    + " abn.[CodeAbnStr],dbo.fn_PrvGetObjAdress(obj.id) [Address]";
            for (DateTime i = DateBeg; i < DateEnd; i = i.AddMonths(1))
            {
                //MessageBox.Show(i.ToString("yyyyMM"));
                select += " ,(select sum(KWT) from tPrv_Debitorka where  idPoint = point.id and OK = 1 and MonthRasch = " + i.ToString("yyyyMM") + " ) [" + i.ToString("yyyyMM") + " УльГЭС] "
                       + "  ,(select sum(Itog) from tPrv_DebitorkaUE where  idPoint = point.id and MonthDeb = " + i.ToString("yyyyMM") + ") [" + i.ToString("yyyyMM") + " УлЭнерго]";
            }


             select +="  FROM [vAbn] abn"
                    + " left join tAbnObj  as obj ON abn.id = obj.idAbn"
                    + " left join tPoint as point on point.idAbnObj = obj.id"
                    + " where abn.CodeAbonent > 0 and abn.TypeAbn = 206 and abn.deleted = 0 and abn.isActive = 1"
                    + " order by CodeAbonent";
            
            DGEFDeb.AutoGenerateColumns = true;

            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
            try
            {

                sql.OpenConnection(this.SqlSettings);

                dsRep.Tables["TableAnalysisDeb"].Clear();


                SqlCommand sqlCmd = new SqlCommand(select, sql.Connection);

                sqlCmd.CommandTimeout = 600;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsRep, "TableAnalysisDeb");


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
            int j = 3; //начинаем с 16 столбца
            for (DateTime i = DateBeg; i < DateEnd; i = i.AddMonths(1))
            {
                DGEFDeb.Columns[j].Width = 60;
                j++;
                DGEFDeb.Columns[j].Width = 60;
                j++;
            }


            
            Cursor.Current = Cursors.Default;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            DataGridAdd();
        }



    }
}
