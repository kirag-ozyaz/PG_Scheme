using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Legal.Forms.FormRep
{
    public partial class FormMeterData : FormLbr.FormBase
    {
        private int IDMETER;

        public FormMeterData()
        {
            InitializeComponent();
        }
        
        public FormMeterData(int idMeter)
        {
            InitializeComponent();
            IDMETER = idMeter;
        }

        private void FormMeterData_Load(object sender, EventArgs e)
        {
            dtBegin.Value = new DateTime(System.DateTime.Now.Year, 1, 1);
            dtEnd.Value = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Date.Day);

//            this.reportViewerRus1.RefreshReport();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            dsCntVal1.dtMeter.Clear();
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "select * from fn_LegGetMeter(@idMeter) ";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                SqlParameter p = new SqlParameter("@idMeter", IDMETER);
                sqlCmd.Parameters.Add(p);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCntVal1, "dtMeter");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
            

            dsCntVal1.dtMeterData.Clear();
            DataSql.SqlDataConnect con1 = new DataSql.SqlDataConnect();
            try
            {
                con1.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "select * from fn_LegGetMeterData(@idMeter) ";
                strCmd += "where " + BuildWhereDate() + BuildWhereTypeDoc() + BuildSort();
                SqlCommand sqlCmd = new SqlCommand(strCmd, con1.Connection);

                SqlParameter p = new SqlParameter("@idMeter", IDMETER);
                sqlCmd.Parameters.Add(p);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCntVal1, "dtMeterData");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }

            this.reportViewerRus1.RefreshReport();
        
        }

        // условие для даты
        private string BuildWhereDate()
        {
            string txtWhereDate = "";
            if (txtWhereDate != "")
                txtWhereDate += " and (DateAct >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                    " (DateAct <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            else
                txtWhereDate += " (DateAct >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                    " (DateAct <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            return txtWhereDate;
        }

        // условие для типа документа
        private string BuildWhereTypeDoc()
        {
            string txtWhereTypeDoc = "";
            if (rbtnTypeDocUser.Checked == true)
                txtWhereTypeDoc = " and (idDocType = 316)";
            if (rbtnTypeDocCheck.Checked == true)
                txtWhereTypeDoc = " and (idDocType != 316)";
            return txtWhereTypeDoc;
        }

        // сортировка
        private string BuildSort()
        {
            string txtSort = "";
            if (rbtnSortDate.Checked == true)
                txtSort = " order by DateAct desc, ZoneName";
            if (rbtnSortZone.Checked == true)
                txtSort = " order by ZoneName, DateAct desc";
            return txtSort;
        }
    }
}
