using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prv.Forms.Reports
{
    public partial class FormActBezuch : FormLbr.FormBase
    {
        private int idAbn, idPoint, QRooms, Peop, QDays, codeAbonent;
        private int Itog;
        //private DateTime DateKO;
        private string AbnFIO, Adress, Cont;
        private string it = "";

        public FormActBezuch()
        {
            InitializeComponent();
        }

        public FormActBezuch(int idA, int idP)
        {
            InitializeComponent();
            idAbn = idA;
            idPoint = idP;
        }


        private void FormActBezuch_Load(object sender, EventArgs e)
        {
            panelPrn.Visible = false;
            panelData.Visible = true;

            this.SelectSqlData(dsRep, dsRep.Tables["vWorkerGroup"], true, " where idGroup = " + Constants.Constants.WorkerGroupControlerBS.ToString() +
            " and dateEnd is null order by FIO");

            this.SelectSqlData(dsRep, dsRep.vAbnForRep, true, " where id = " + idAbn.ToString());

            this.SelectSqlData(dsRep, dsRep.vDocAct, true, "where idDocType = " + ((int)Constants.DocType.ActKO).ToString() + " and IdPoint = " + idPoint.ToString() + " order by DateAct desc");
            this.SelectSqlData(dsRep, dsRep.vDocActBezuch, true, "where idDocType = " + ((int)Constants.DocType.ActBezuch).ToString() + " and IdPoint = " + idPoint.ToString() + " order by DateAct desc");

            codeAbonent = (int)dsRep.vAbnForRep.Rows[0]["CodeAbonent"];
            AbnFIO = dsRep.vAbnForRep.Rows[0]["Name"].ToString();
            Adress = dsRep.vAbnForRep.Rows[0]["Street"].ToString();
                     if (dsRep.vAbnForRep.Rows[0]["Street"] != DBNull.Value) Adress = Adress +" д." + dsRep.vAbnForRep.Rows[0]["HouseAll"].ToString();
                     if (dsRep.vAbnForRep.Rows[0]["objName"] != DBNull.Value) Adress = Adress + " кв." + dsRep.vAbnForRep.Rows[0]["objName"].ToString();
            QRooms = (dsRep.vAbnForRep.Rows[0]["CountRooms"] == DBNull.Value) ? 0 : Convert.ToInt32(dsRep.vAbnForRep.Rows[0]["CountRooms"]) ;
            Peop = (dsRep.vAbnForRep.Rows[0]["CountPeoples"] == DBNull.Value) ? 0 : Convert.ToInt32(dsRep.vAbnForRep.Rows[0]["CountPeoples"]);
            Cont = dsRep.vAbnForRep.Rows[0]["Worker"].ToString();

            labelCA.Text = Convert.ToString(codeAbonent);
            labelAdr.Text = Adress;
            lFIO.Text = AbnFIO;
            lCont.Text = Cont;
            lQRooms.Text = Convert.ToString(QRooms);
            lPeop.Text = Convert.ToString(Peop);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (tbAktNumber.Text == "")
            {
                MessageBox.Show("Нет номера акта.");
            }
            else
            {
                if (tbRasch.Text == "" || tbItog.Text == "")
                {
                    MessageBox.Show("Расчет не сформирован.");
                }
                else
                {
                    if (dgvAbnAktRcp.RowCount > 0)
                    {
                        Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("RPAbnFIO", AbnFIO);
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p1 });
                        Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("RPCodeAbn", codeAbonent.ToString());
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p2 });
                        Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("RPAdress", Adress.ToString());
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p3 });
                        Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("RPAktNumber", tbAktNumber.Text.ToString());
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p4 });
                        Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("RPAktDate", Convert.ToDateTime(dgvAbnAktRcp.CurrentRow.Cells["dateActBezuch"].Value).ToShortDateString());
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p5 });
                        Microsoft.Reporting.WinForms.ReportParameter p6 = new Microsoft.Reporting.WinForms.ReportParameter("RPAktCont", Convert.ToString(dgvAbnAktRcp.CurrentRow.Cells["workerAct"].Value));
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p6 });
                        Microsoft.Reporting.WinForms.ReportParameter p7 = new Microsoft.Reporting.WinForms.ReportParameter("RPQRooms", QRooms.ToString());
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p7 });
                        Microsoft.Reporting.WinForms.ReportParameter p8 = new Microsoft.Reporting.WinForms.ReportParameter("RPPeop", Peop.ToString());
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p8 });
                        Microsoft.Reporting.WinForms.ReportParameter p9 = new Microsoft.Reporting.WinForms.ReportParameter("RPAktKO", Convert.ToDateTime(dgvAktKO.CurrentRow.Cells["dateActKO"].Value).ToShortDateString());
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p9 });
                        Microsoft.Reporting.WinForms.ReportParameter p10 = new Microsoft.Reporting.WinForms.ReportParameter("RPDays", QDays.ToString());
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p10 });
                        Microsoft.Reporting.WinForms.ReportParameter p11 = new Microsoft.Reporting.WinForms.ReportParameter("RPRasch", tbRasch.Text);
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p11 });
                        Microsoft.Reporting.WinForms.ReportParameter p12 = new Microsoft.Reporting.WinForms.ReportParameter("RPItog", tbItog.Text);
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p12 });
                        Microsoft.Reporting.WinForms.ReportParameter p13 = new Microsoft.Reporting.WinForms.ReportParameter("RPCont", comboBoxEngeneer.Text);
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p13 });
                        Microsoft.Reporting.WinForms.ReportParameter p14 = new Microsoft.Reporting.WinForms.ReportParameter("Boss", tbBoss.Text);
                        this.reportViewerAkt.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p14 });

                        this.reportViewerAkt.RefreshReport();


                        panelPrn.Visible = true;
                        panelData.Visible = false;

                    }
                }
            }
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            panelPrn.Visible = false;
            panelData.Visible = true;
        }

        private void buttonRasch_Click(object sender, EventArgs e)
        {
            if (dgvAbnAktRcp.RowCount > 0)
            {
                DateTime DateAkt = Convert.ToDateTime(dgvAbnAktRcp.CurrentRow.Cells["dateActBezuch"].Value);
                int Norm = Convert.ToInt32(dgvAbnAktRcp.CurrentRow.Cells["Norm"].Value);
                DateTime DateKO = Convert.ToDateTime(dgvAktKO.CurrentRow.Cells["dateActKO"].Value);
                var days = DateAkt - DateKO;

                QDays = days.Days;

                if (DateAkt.Month - DateKO.Month + (DateAkt.Year - DateKO.Year) * 12 > 0)
                {
                    int QMonth = DateAkt.Month - DateKO.Month + (DateAkt.Year - DateKO.Year) * 12;


                    DateTime DK = DateKO;

                    for (int i = 0; i <= QMonth; i++)
                    {
                        if (i > 0) DateKO = DateKO.AddMonths(1);
                        DK = DateKO.AddMonths(1);
                        DK = DK.AddDays(-DateKO.Day);
                        if (i == 0)
                        {
                            it = it + DateKO.ToString("MMMM") + "( " + Norm.ToString() + "кВт*ч. /" + DK.Day.ToString() + "суток *" + (DK.Day - DateKO.Day + 1).ToString() + "суток =" + ((int)(Norm / (float)DK.Day * (DK.Day - DateKO.Day + 1))).ToString() + "кВт*ч.)";
                            Itog = Itog + (int)(Norm / (float)DK.Day * (DK.Day - DateKO.Day + 1));
                        }
                        if (i > 0 && i < QMonth)
                        {
                            //                  it = it + ", " + DateKO.ToString("MMMM") + "( " + Norm.ToString() + "кВт*ч. /" + DK.Day.ToString() + "суток *" + (DK.Day - DateKO.Day + 1).ToString() + "суток =" + (Norm / (float)DK.Day * DK.Day) + "кВт*ч.)";
                            it = it + ", " + DateKO.ToString("MMMM") + "( " + Norm.ToString() + "кВт*ч. /" + DK.Day.ToString() + "суток *" + (DK.Day).ToString() + "суток =" + (Norm / (float)DK.Day * DK.Day) + "кВт*ч.)";
                            Itog = Itog + Norm;
                        }

                        if (i == QMonth)
                        {
                            it = it + ", " + DateKO.ToString("MMMM") + "( " + Norm.ToString() + "кВт*ч. /" + DK.Day.ToString() + "суток *" + DateAkt.Day.ToString() + "суток =" + ((int)(Norm / (float)DK.Day * DateAkt.Day)).ToString() + "кВт*ч.)";
                            Itog = Itog + (int)(Norm / (float)DK.Day * DateAkt.Day);
                        }
                    }
                }
                else MessageBox.Show("Контрольный обход позже акта"); ;

                //   MessageBox.Show( it );
                //Itog = (Norm / (float)30) ;
                //Itog = Itog * QDays;
                tbRasch.Text = it;//Norm.ToString() + "кВт*ч. / 30суток * " + QDays.ToString()+"суток";
                tbItog.Text = Itog.ToString() + " кВт*ч.";

                if (Itog < 0) MessageBox.Show("Результат отрицательный. Проверьте правильность выбора документа проверки узла учета.");

            }
            else
            {
                MessageBox.Show("Акты отсутствуют.");
            }
        }


    }
}
