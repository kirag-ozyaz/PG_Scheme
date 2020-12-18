using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;


namespace Legal.Forms.FormRep
{
    public partial class FormObjectData : FormLbr.FormBase
    {
        private int IDABN;
        private string txtWhereObject;
        private string DOGOVOR_TYPE;

        public FormObjectData()
        {
            InitializeComponent();
        }
        
        public FormObjectData(int idAbn, string Dogovor_Type)
        {
            InitializeComponent();
            IDABN = idAbn;
            DOGOVOR_TYPE = Dogovor_Type;
        }

        private void FormObjectData_Load(object sender, EventArgs e)
        {
            dtBegin.Value = new DateTime(System.DateTime.Now.Year, 1, 1);
            dtEnd.Value = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Date.Day);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dsCntVal1.dtObjectData.Clear();
            dsCntVal1.dtObjectData1.Clear();

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                if (cbObj.Checked == true)
                {
                    strCmd = "select * from fn_LegGetObjectData(@idAbn) ";
                    strCmd += "where " + BuildWhereDate() + BuildWhereObject();
                }
                else
                {
                    strCmd = "select * from fn_LegGetObjectData1(@idAbn) ";
                    strCmd += "where " + BuildWhereDate();
                }
                 
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                SqlParameter p = new SqlParameter("@idAbn", IDABN);
                sqlCmd.Parameters.Add(p);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);


                if (cbObj.Checked == true)
                    dAdapt.Fill(dsCntVal1, "dtObjectData");
                else
                    dAdapt.Fill(dsCntVal1, "dtObjectData1");

                SelectSqlData(dsCntVal1, dsCntVal1.tAbn, true, "where id = " + IDABN.ToString());
                string CodeAbn = dsCntVal1.tAbn[0]["CodeAbonent"].ToString() + ", " + DOGOVOR_TYPE;
                string NameAbn = dsCntVal1.tAbn[0]["Name"].ToString();
                
                ReportParameter prm1 = new ReportParameter("CodeAbn", CodeAbn);
                ReportParameter prm2 = new ReportParameter("NameAbn", NameAbn);
                ReportParameter prm3 = new ReportParameter("dtBegin", this.dtBegin.Value.Date.ToShortDateString());
                ReportParameter prm4 = new ReportParameter("dtEnd", this.dtEnd.Value.Date.ToShortDateString());

                reportViewerRus1.ProcessingMode = ProcessingMode.Local;

                if (cbObj.Checked == true)
                {
                    reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportObjectData.rdlc";
                    this.reportViewerRus1.LocalReport.DataSources.Add(new ReportDataSource("dsObjectData", bindingSource1));
                }
                else
                {
                    reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportObjectData1.rdlc";
                    this.reportViewerRus1.LocalReport.DataSources.Add(new ReportDataSource("dsObjectData1", bindingSource2));
                }
                
                this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter[] {prm1, prm2, prm3, prm4});


                this.reportViewerRus1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
        }

        // условие для даты
        private string BuildWhereDate()
        {
            string txtWhereDate = "";
            if (txtWhereDate != "")
                txtWhereDate += " and (dtCalc >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                    " (dtCalc <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            else
                txtWhereDate += " (dtCalc >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                    " (dtCalc <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            return txtWhereDate;
        }

        private void btnSelectObject_Click(object sender, EventArgs e)
        {
            txtWhereObject = "";
            FormObjSelect fSelect = new FormObjSelect(IDABN, 100, FormObjSelect.SelectionMethod.Many);
            fSelect.SqlSettings = this.SqlSettings;
            if (fSelect.ShowDialog() == DialogResult.OK)
            {
                if (fSelect.idObjPar == -1)
                {
                    for (int i = 0; i < fSelect.idArray.Length; i++)
                    {
                        if (fSelect.idArray[i] != 0)
                        {
                            txtWhereObject += fSelect.idArray[i].ToString() + ",";
                        }
                    }
                    if (txtWhereObject.Length > 0)
                    {
                        txtWhereObject = txtWhereObject.Substring(0, txtWhereObject.Length - 1);
                        txtWhereObject = " and idObj in (" + txtWhereObject + ")";
                    }

                }
            }
        }

        // условие для объектов
        private string BuildWhereObject()
        {
            if (cbSelectObject.Checked == true)
            {
                if (txtWhereObject.Length > 0)
                {
                    return txtWhereObject;
                }
                else
                    return "";
            }
            else
                return "";
        }

        private void cbAbn_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void cbObj_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }


    }
}
