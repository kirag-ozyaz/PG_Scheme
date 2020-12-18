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
    public partial class FormHouseClose : FormLbr.FormBase
    {
        private int idM;
        private string MStr;
        private string Active;

        public FormHouseClose()
        {
            InitializeComponent();
        }

        public FormHouseClose(int idMap,  string MapStr, string Active)
        {
            idM = idMap;
            MStr = MapStr;
            this.Active = Active;
            InitializeComponent();
            if (this.Active == "OnlyActive") { bCloseHouse.Text = "Сменить статус у активных."; }
        }

        private void FormHouseClose_Load(object sender, EventArgs e)
        {
            this.Text = MStr;

            dateTimePickerEnd.Value = DateTime.Now.Date;


            this.SelectSqlData(dsPrv, dsPrv.tR_Classifier, true, "where IsGroup = 0 and deleted = 0 and " +
             " ((ParentKey = ';SKUEE;TypeAbn;' and id in (" + Constants.Constants.TypeAbnPrivate.ToString() + "," +
             Constants.Constants.TypeAbnPrivateNoDog.ToString() + ")) or (ParentKey = ';SKUEE;ReasonStatus;ReasonAbnFL;'))");


            //dateTimePickerEnd.Value = new DateTime(2014, 10, 31);
            //cmbReason.SelectedIndex = 1;

            DataGridAdd();
        }

        private void DataGridAdd()
        {


            string select = "select *";

            if (Active == "OnlyActive")
            {
                for (int i = 2009; i <= DateTime.Today.Year; i++)
                {

                    select += ",( select sum(pKWT.KWT)	 "
                              + "FROM   dbo.tAbn AS a  "
                              + "LEFT JOIN dbo.tAbnObj AS o ON o.idAbn = a.id "
                              + "left join tPoint p on p.idAbnObj = o.id  "
                              + "left join (SELECT [idPoint],  "
                              + "				  sum(KWT) as [KWT]  "
                              + "		   FROM [dbo].[tPrv_Debitorka]  "
                              + "		   where [OK]= 1 and left(convert(varchar(6),MonthRasch),4) = left(convert(varchar(6)," + i.ToString() + "),4)  "
                              + "		   group by [idPoint]) pKWT on pKWT.idPoint = p.id  "
                              + "where a.id = [vPrv_HousesCloseOnlyActive].id ) [" + i.ToString() + "г.] ";
                }

                select += "from [vPrv_HousesCloseOnlyActive] where idmap = " + idM.ToString() + "  order by [Apartment]";

            }
            else
            {
                for (int i = 2009; i <= DateTime.Today.Year; i++)
                {

                    select += ",( select sum(pKWT.KWT)	 "
                              + "FROM   dbo.tAbn AS a  "
                              + "LEFT JOIN dbo.tAbnObj AS o ON o.idAbn = a.id "
                              + "left join tPoint p on p.idAbnObj = o.id  "
                              + "left join (SELECT [idPoint],  "
                              + "				  sum(KWT) as [KWT]  "
                              + "		   FROM [dbo].[tPrv_Debitorka]  "
                              + "		   where [OK]= 1 and left(convert(varchar(6),MonthRasch),4) = left(convert(varchar(6)," + i.ToString() + "),4)  "
                              + "		   group by [idPoint]) pKWT on pKWT.idPoint = p.id  "
                              + "where a.id = [vPrv_HousesClose].id ) [" + i.ToString() + "г.] ";
                }

                select += "from [vPrv_HousesClose] where idmap = " + idM.ToString() + "  order by [Apartment]";
            }

            DGVEFAbnClose.AutoGenerateColumns = true;

            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
            try
            {

                sql.OpenConnection(this.SqlSettings);

                dsPrv.Tables["vPrv_HousesClose"].Clear();


                SqlCommand sqlCmd = new SqlCommand(select, sql.Connection);

                sqlCmd.CommandTimeout = 600;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsPrv, "vPrv_HousesClose");


            }
            catch (Exception ex) // Если ошибка
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {   // В любом случае коннект надо закрыть
                sql.CloseConnection();
            }

            ////форматируем столбци годов
            int j = 9; //начинаем с 16 столбца
            for (int i = 2009; i <= DateTime.Today.Year; i++)
            {
                DGVEFAbnClose.Columns[j].Width = 60;
                j++;
            }

        }

        #region toolStripMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            DGVEFAbnClose.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                DGVEFAbnClose.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            DGVEFAbnClose.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            DGVEFAbnClose.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            DGVEFAbnClose.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            DGVEFAbnClose.CopyToExcel(true);
        }
        // Обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            DataGridAdd();
        }
        #endregion

        private void bCloseHouse_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Поменять статус на \"" + cmbReason.Text + "\" ?", "Изменение статуса", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dialogResult = MessageBox.Show("Дата нового статуса " + Convert.ToDateTime(dateTimePickerEnd.Value).ToString("dd MMMM yyyy") + " ?", "Дата статуса", MessageBoxButtons.YesNo);
               if (dialogResult == DialogResult.Yes)
               {

                   for (int i = 0; i < DGVEFAbnClose.RowCount; i++)
                   {
                       dsPrv.tAbnStatus.Clear();

                       DataRow drStatus = dsPrv.tAbnStatus.NewRow();
                       drStatus["idAbn"] = Convert.ToInt32( DGVEFAbnClose.Rows[i].Cells["id"].Value);
                       if (Convert.ToInt32(cmbReason.SelectedValue) == 2340) { drStatus["isActive"] = true; } else { drStatus["isActive"] = false; }
                       drStatus["idReason"] = cmbReason.SelectedValue;
                       drStatus["DateChange"] = dateTimePickerEnd.Value; // DateTime.Now.Date;
                       dsPrv.tAbnStatus.Rows.Add(drStatus);

                       dsPrv.tAbnStatus.Rows[0].EndEdit();
                       this.InsertSqlData(dsPrv, dsPrv.tAbnStatus);

                   };

                   DataGridAdd();

               }
            }
        }

    }
}
