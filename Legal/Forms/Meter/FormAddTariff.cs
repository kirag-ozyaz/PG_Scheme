using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Legal.Forms.Meter
{
    public partial class FormAddTariff : FormLbr.FormBase
    {
        private int idObj;

        public FormAddTariff()
        {
            InitializeComponent();
        }

        public FormAddTariff(int idO)
        {
            InitializeComponent();
            idObj = idO;

        }

        private void FormAddTariff_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbn.vG_AbnObj, true, " where  id = " + idObj.ToString(), null, false, 1);
            tbObjName.Text = Convert.ToString(dsAbn.vG_AbnObj.Rows[0]["ObjName"]);
            //Счетчики
            this.SelectSqlData(dsAbn, dsAbn.vG_ObjMeter, true, " where idAbnObj = " + idObj.ToString());

            GetTariffPrice();

            GetTariff();

  
        }

        private void GetTariffPrice()
        {
            dsAbn.vG_Tariff.Clear();
            string commTXT = "select id, TariffName, Price from [dbo].[fn_LegGetTariffPrice] ('" + dtpDatePrice.Value.ToString("yyyyMMdd")+ "')";

            //MessageBox.Show(commTXT);
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            con.OpenConnection(SqlSettings);
            SqlCommand sqlCmd = new SqlCommand(commTXT, con.Connection);
            sqlCmd.CommandTimeout = 0;
            SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);
            dAdapt.Fill(dsAbn, "vG_Tariff");


                      

        }


        private void dtpDatePrice_ValueChanged(object sender, EventArgs e)
        {
            GetTariffPrice();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonОк_Click(object sender, EventArgs e)
        {
            var days = dtpDatePrice.Value - Convert.ToDateTime(TariffDGV["SetDateDGVTBC", 0].Value);

             int QDays = days.Days;
            
            
            if ( QDays <= 0 )
            {
                MessageBox.Show("update");


                for (int i = 0; i < objMeterdgv.RowCount; i++)
                {
                    this.SelectSqlData(dsAbn, dsAbn.vG_TariffPoint, true, " where idPoint = " + Convert.ToString(objMeterdgv["pointIDDGVTBC", i].Value) + " ORDER BY SetDate desc ");

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tTariffReg, true, "where id = " + dsAbn.vG_TariffPoint.Rows[0]["id"].ToString());

                    ds.tTariffReg.Rows[0]["idTariff"] = cbTariff.SelectedValue;
                    ds.tTariffReg.Rows[0].EndEdit();
                    this.UpdateSqlData(ds, ds.tTariffReg);
                }
      
            }
            else
            {
            for (int i = 0; i < objMeterdgv.RowCount; i++)
               {
                   
                   //MessageBox.Show(objMeterdgv["pointIDDGVTBC",i].Value.ToString());
                   DataRow dr = dsAbn.tTariffReg.NewRow();
                   dr["idTariff"] = cbTariff.SelectedValue;
                   dr["idPoint"] = Convert.ToInt32(objMeterdgv["pointIDDGVTBC", i].Value);
                   dr["SetDate"] = dtpDatePrice.Value;
                   dsAbn.tTariffReg.Rows.Add(dr);
                   dsAbn.tTariffReg.Rows[0].EndEdit();
                   this.InsertSqlData(dsAbn, dsAbn.tTariffReg);
                  
                   dsAbn.tTariffReg.Clear();

                }

            }
            GetTariff();
        }

        private void GetTariff()
        {

            //Тарифы
            this.SelectSqlData(dsAbn, dsAbn.vG_TariffPoint, true, " where idPoint = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value) + " ORDER BY SetDate desc ");

        }

        private void objMeterdgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetTariff();
        }

        private void objMeterdgv_KeyUp(object sender, KeyEventArgs e)
        {
            GetTariff();
        }

       
    }
}
