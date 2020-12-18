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

    public partial class FormNotification : FormLbr.FormBase
    {
        public class myList
        {
            private string id, name;
            public string Id
            {
                get { return id; }
            }
            public myList(string id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public override string ToString()
            {
                return name;
            }
        }

        public FormNotification()
        {
            InitializeComponent();
        }

        private void FormNotification_Load(object sender, EventArgs e)
        {
            LoadControllers();

            cmbDogovor.SelectedIndex = 0;

            if (dtpPrilDate.Value.Month > 6)
                cbSeason.SelectedIndex = 0;
            else
                cbSeason.SelectedIndex = 1;
        }

        // загрузка контролеров
        private void LoadControllers()
        {
            cbSignature.SelectedIndex = 0;

            this.SelectSqlData(dsAbn, dsAbn.Tables["vWorkerGroup"], true, " where idgroup = " + Constants.Constants.WorkerGroupControlerUL + " and DateEnd is null order by fio ");

            for (int i = 0; i < dsAbn.vWorkerGroup.Rows.Count; i++)
            {
                checkedListBoxController.Items.Add(new myList(dsAbn.vWorkerGroup[i]["id"].ToString(), dsAbn.vWorkerGroup[i]["FIO"].ToString()));
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (checkedListBoxController.CheckedItems.Count > 0)
            {

                if (cmbDogovor.SelectedIndex == 2)
                    SelectSqlData(dsAbn, dsAbn.vG_AbnDogDetails, true, BuildWhereContrl() + " order by CodeAbonent");
                else if (cmbDogovor.SelectedIndex == 0)
                    SelectSqlData(dsAbn, dsAbn.vG_AbnDogDetails, true, BuildWhereContrl() + " and idDocType = 501 order by CodeAbonent");
                else
                    SelectSqlData(dsAbn, dsAbn.vG_AbnDogDetails, true, BuildWhereContrl() + " and idDocType = 533 order by CodeAbonent");

                ReportParameter d1 = new ReportParameter("Signature", cbSignature.Text);
                reportViewerNotification.LocalReport.SetParameters(new ReportParameter[] { d1 });

                string season = "";
                season = cbSeason.Text + " " + dtpPrilDate.Value.Year.ToString() + "г.";

                ReportParameter d2 = new ReportParameter("Season", season);
                reportViewerNotification.LocalReport.SetParameters(new ReportParameter[] { d2 });

                ReportParameter d3 = new ReportParameter("Yr", dtpPrilDate.Value.Year.ToString());
                reportViewerNotification.LocalReport.SetParameters(new ReportParameter[] { d3 });

                string ispolnit = "";
                ispolnit = checkedListBoxController.Text;

                ReportParameter d4 = new ReportParameter("Ispolnit", ispolnit);
                reportViewerNotification.LocalReport.SetParameters(new ReportParameter[] { d4 });

                ReportParameter d5 = new ReportParameter("Phone", txtPhone.Text);
                reportViewerNotification.LocalReport.SetParameters(new ReportParameter[] { d5 });

                reportViewerNotification.RefreshReport();
            }
        }


        private string BuildWhereContrl()
        {
            string whereContrl = "";
            if ((checkedListBoxController.CheckedItems.Count <= 0) || (checkedListBoxController.CheckedItems.Count == checkedListBoxController.Items.Count))
                return whereContrl;
            else
            {
                for (int i = 0; i <= (checkedListBoxController.CheckedItems.Count) - 1; i++)
                {
                    myList mylist = (myList)checkedListBoxController.CheckedItems[i];
                    whereContrl += mylist.Id + ",";
                }
                whereContrl = "where idWorker in (" + whereContrl.Remove(whereContrl.Length - 1) + ")";
                return whereContrl;
            }

        }

        private void reportViewerNotification_Load(object sender, EventArgs e)
        {

        }

    }
}
