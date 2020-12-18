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
    public partial class FormHouseOpen : FormLbr.FormBase
    {
        private int idM;
        private string MStr;

        public FormHouseOpen()
        {
            InitializeComponent();
        }

        public FormHouseOpen(int idMap, string MapStr)
        {
            idM = idMap;
            MStr = MapStr;
            InitializeComponent();
        }
     

        private void FormHouseOpen_Load(object sender, EventArgs e)
        {
            this.Text = MStr;

            this.SelectSqlData(dsPrv, dsPrv.tR_Classifier, true, "where IsGroup = 0 and deleted = 0 and " +
             " ((ParentKey = ';SKUEE;TypeAbn;' and id in (" + Constants.Constants.TypeAbnPrivate.ToString() + "," +
             Constants.Constants.TypeAbnPrivateNoDog.ToString() + ")) or (ParentKey = ';SKUEE;ReasonStatus;ReasonAbnFL;'))");

            DataGridAdd();
        }

        private void DataGridAdd()
        {


            string select = "select *";

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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DelStatbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить текущий статус у всего дома?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Уверены? ВСЕ ТЕКУЩИЕ ДАННЫЕ БУДУТ ПОТЕРЯНЫ!!!", "Внимание!", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {


                    for (int i = 0; i < DGVEFAbnClose.RowCount; i++)
                    {
                        this.DeleteSqlDataById(dsPrv.tAbnStatus, Convert.ToInt32(DGVEFAbnClose.Rows[i].Cells["idStatus"].Value));
                        //if (this.DeleteSqlDataById(dsPrv.tAbnStatus, Convert.ToInt32(DGVEFAbnClose.Rows[i].Cells["idStatus"].Value)))
                        //{
                        //    MessageBox.Show("Статус успешно удален");
                        //    DataGridAdd();
                        //}

                    };

                    DataGridAdd();
                    MessageBox.Show("Статус успешно удален");
                }

            }   

        }

    }
}
