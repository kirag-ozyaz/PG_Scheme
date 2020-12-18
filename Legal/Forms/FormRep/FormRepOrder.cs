using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Legal.Forms.FormRep
{
    public partial class FormRepOrder : FormLbr.FormBase
    {
        private int ID;

        public FormRepOrder()
        {
            InitializeComponent();
        }

        public FormRepOrder(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FormRepOrder_Load(object sender, EventArgs e)
        {

            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.vJournalOrdersInspection, true, " where id = " + ID);
            int idJournal = (int)dsAbnDocum1.vJournalOrdersInspection.Rows[0]["id"]; 
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.vOrdersInspection, true, " where idJournal = " + idJournal);

            int j = 0;

            for (int i = 0; i < dsAbnDocum1.vOrdersInspection.Rows.Count; i++)
            {
                DataRow dr = dsAbn.GraphicPointOrder.NewRow();
                if (dsAbnDocum1.vOrdersInspection.Rows[i]["CodeAbonent"] != DBNull.Value)
                    dr["CodeAbonent"] = (int)dsAbnDocum1.vOrdersInspection.Rows[i]["CodeAbonent"];
  //              dr["TypeAbn"] = dsAbnDocum1.vOrdersInspection.Rows[i]["TypeAbn"];
                dr["Name"] = dsAbnDocum1.vOrdersInspection.Rows[i]["Name"];
                dr["AbnPhone"] = dsAbnDocum1.vOrdersInspection.Rows[i]["AbnPhone"];
                dr["Deleted"] = dsAbnDocum1.vOrdersInspection.Rows[i]["Deleted"];
  //              dr["idObj"] = dsAbnDocum1.vOrdersInspection.Rows[i]["idObj"];
                dr["NumberObj"] = dsAbnDocum1.vOrdersInspection.Rows[i]["NumberObj"];
                dr["NameObj"] = dsAbnDocum1.vOrdersInspection.Rows[i]["NameObj"];
                dr["ObjAdress"] = dsAbnDocum1.vOrdersInspection.Rows[i]["ObjAdress"];
  //              dr["idAbn"] = dsAbnDocum1.vOrdersInspection.Rows[i]["idAbn"];
  //              dr["id"] = dsAbnDocum1.vOrdersInspection.Rows[i]["id"];
  //              dr["idPoint"] = dsAbnDocum1.vOrdersInspection.Rows[i]["idPoint"];
  //              dr["MasterID"] = dsAbnDocum1.vOrdersInspection.Rows[0]["MasterID"];
                dr["Number"] = dsAbnDocum1.vOrdersInspection.Rows[i]["Number"];
                dr["NameMeter"] = dsAbnDocum1.vOrdersInspection.Rows[i]["NameMeter"];
  //              dr["DateBegin"] = dsAbnDocum1.vOrdersInspection.Rows[i]["DateBegin"];
  //              dr["MeterDCheck"] = dsAbnDocum1.vOrdersInspection.Rows[i]["MeterDCheck"];
  //              dr["MeterDCheckStr"] = dsAbnDocum1.vOrdersInspection.Rows[i]["MeterDCheckStr"];
                dr["GosEndMeter"] = dsAbnDocum1.vOrdersInspection.Rows[i]["GosEndMeter"];
  //              dr["NameTrans"] = dsAbnDocum1.vOrdersInspection.Rows[i]["NameTrans"];
  //              dr["TypeTrans"] = dsAbnDocum1.vOrdersInspection.Rows[i]["TypeTrans"];
  //              dr["TransDCheck"] = dsAbnDocum1.vOrdersInspection.Rows[i]["TransDCheck"];
  //              dr["TransDCheckStr"] = dsAbnDocum1.vOrdersInspection.Rows[i]["TransDCheckStr"];
                dr["GosEndTrans"] = dsAbnDocum1.vOrdersInspection.Rows[i]["GosEndTrans"];
                dr["Ktran"] = dsAbnDocum1.vOrdersInspection.Rows[i]["Ktran"];
                dr["Values"] = dsAbnDocum1.vOrdersInspection.Rows[i]["Values"];
                dr["DateAct"] = dsAbnDocum1.vOrdersInspection.Rows[i]["DateAct"];
                dr["PowerSet"] = dsAbnDocum1.vOrdersInspection.Rows[i]["PowerSet"];
                dsAbn.GraphicPointOrder.Rows.Add(dr);
                dsAbn.GraphicPointOrder.Rows[j++].EndEdit();
            }

            ReportParameter d1 = new ReportParameter("Number", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["NumberOrder"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d1 });

            ReportParameter d2 = new ReportParameter("Whom", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["Contractor"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d2 });

            ReportParameter d3 = new ReportParameter("Who", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["Manager"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d3 });

            ReportParameter d4 = new ReportParameter("NumberJournal", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["NumberJournal"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d4 });

            ReportParameter d5 = new ReportParameter("DateJournal", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["DateOrder"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d5 });

            ReportParameter d6 = new ReportParameter("Member", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["Member"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d6 });

            ReportParameter d7 = new ReportParameter("pManager", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["pManager"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d7 });

            ReportParameter d8 = new ReportParameter("dManager", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["dManager"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d8 });

            ReportParameter d9 = new ReportParameter("aManager", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["aManager"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d9 });

            ReportParameter d10 = new ReportParameter("pContractor", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["pContractor"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d10 });

            ReportParameter d11 = new ReportParameter("dContractor", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["dContractor"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d11 });

            ReportParameter d12 = new ReportParameter("aContractor", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["aContractor"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d12 });

            ReportParameter d13 = new ReportParameter("pMember", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["pMember"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d13 });

            ReportParameter d14 = new ReportParameter("dMember", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["dMember"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d14 });

            ReportParameter d15 = new ReportParameter("aMember", dsAbnDocum1.vJournalOrdersInspection.Rows[0]["aMember"].ToString());
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d15 });

            reportViewerOrder.RefreshReport();

        }
    }
}
