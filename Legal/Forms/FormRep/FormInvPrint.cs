using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Legal.Forms.FormRep
{
    public partial class FormInvPrint : FormLbr.FormBase
    {
        private int ID;
        private decimal pNal;
        private decimal pTot;
        private string pNalStr;
        private string pTotStr;
        private DateTime DTBANK;
        private int Selector;
        private int NUMBERSTORNO;
        private DateTime DATESTORNO;
        private bool FLAG;


        public FormInvPrint()
        {
            InitializeComponent();
        }

        public FormInvPrint(int id)
        {
            InitializeComponent();
            ID = id;
            Selector = 1;
        }

        public FormInvPrint(DateTime dtBank)
        {
            InitializeComponent();
            DTBANK = dtBank;
            Selector = 2;
        }

        public FormInvPrint(int id, int NumberStorno, DateTime DateStorno, bool Flag)
        {
            InitializeComponent();
            ID = id;
            Selector = 3;
            NUMBERSTORNO = NumberStorno;
            DATESTORNO = DateStorno;
            FLAG = Flag;
        }
        
        
        private void FormInvPrint_Load(object sender, EventArgs e)
        {
            switch (Selector)
            {
                case 1:
                    if (SelectSqlData(dsCntVal, dsCntVal.vG_SchetFact, true, " where id = " + ID))
                    {
                        if (dsCntVal.vG_SchetFact.Rows.Count > 0)
                        {
                            dsCntVal.vG_SchetFact.Rows[0].BeginEdit();
                            pTot = (decimal)dsCntVal.vG_SchetFact[0]["SumTot"];
                            pNal = (decimal)dsCntVal.vG_SchetFact[0]["SumNal"];
                            pNalStr = Legal.Classes.NumByWords.RurPhrase(pNal);
                            pTotStr = Legal.Classes.NumByWords.RurPhrase(pTot);
                            dsCntVal.vG_SchetFact.Rows[0]["SumTotStr"] = pTotStr;
                            dsCntVal.vG_SchetFact.Rows[0]["SumNalStr"] = pNalStr;
                            dsCntVal.vG_SchetFact.Rows[0].EndEdit();
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
                case 2:
                    if (SelectSqlData(dsCntVal, dsCntVal.vG_SchetFact, true, " where dtBank = '" + DTBANK.Date.ToString("yyyyMMdd") + "'"))
                    {
                        if (dsCntVal.vG_SchetFact.Rows.Count > 0)
                        {
                            for (int i = 0; i < dsCntVal.vG_SchetFact.Rows.Count; i++)
                            {
                                dsCntVal.vG_SchetFact.Rows[i].BeginEdit();
                                pTot = (decimal)dsCntVal.vG_SchetFact[i]["SumTot"];
                                pNal = (decimal)dsCntVal.vG_SchetFact[i]["SumNal"];
                                pNalStr = Legal.Classes.NumByWords.RurPhrase(pNal);
                                pTotStr = Legal.Classes.NumByWords.RurPhrase(pTot);
                                dsCntVal.vG_SchetFact.Rows[i]["SumTotStr"] = pTotStr;
                                dsCntVal.vG_SchetFact.Rows[i]["SumNalStr"] = pNalStr;
                                dsCntVal.vG_SchetFact.Rows[i].EndEdit();
                                this.reportViewerRus1.RefreshReport();
                            }
                        }
                    }
                    break;
                case 3:
                    if (SelectSqlData(dsCntVal, dsCntVal.vG_SchetFact, true, " where id = " + ID))
                    {
                        if (dsCntVal.vG_SchetFact.Rows.Count > 0)
                        {
                            dsCntVal.vG_SchetFact.Rows[0].BeginEdit();
                            pTot = (decimal)dsCntVal.vG_SchetFact[0]["SumTot"];
                            pNal = (decimal)dsCntVal.vG_SchetFact[0]["SumNal"];
                            pNalStr = Legal.Classes.NumByWords.RurPhrase(pNal);
                            pTotStr = Legal.Classes.NumByWords.RurPhrase(pTot);
                            dsCntVal.vG_SchetFact.Rows[0]["SumTotStr"] = pTotStr;
                            dsCntVal.vG_SchetFact.Rows[0]["SumNalStr"] = pNalStr;
                            dsCntVal.vG_SchetFact.Rows[0].EndEdit();

                            ReportParameter prm1 = new ReportParameter("NumberStorno", NUMBERSTORNO.ToString());
                            this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter[] { prm1 });

                            ReportParameter prm2 = new ReportParameter("DateStorno", DATESTORNO.ToShortDateString());
                            this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter[] { prm2 });

                            ReportParameter prm3 = new ReportParameter("Flag", FLAG.ToString());
                            this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter[] { prm3 });

                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;


            }
        }
    }
}
