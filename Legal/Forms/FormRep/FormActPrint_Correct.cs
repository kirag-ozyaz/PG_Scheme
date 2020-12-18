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

    public partial class FormActPrint_Correct : FormLbr.FormBase
    {
        private int ID;
        private decimal pNal;
        private decimal pTot;
        private string pNalStr;
        private string pTotStr;
        private DateTime DTBANK;

        public FormActPrint_Correct()
        {
            InitializeComponent();
        }

        public FormActPrint_Correct(DateTime dtBank)
        {
            InitializeComponent();
            DTBANK = dtBank;
        }


        private void FormActPrint_Load(object sender, EventArgs e)
        {
            if (SelectSqlData(dsCntVal, dsCntVal.vG_SchetFact, true, " where dtBank = '" + DTBANK.Date.ToString("yyyyMMdd") + "'"))
            {
                if (dsCntVal.vG_SchetFact.Rows.Count > 0)
                {
                    for (int i = 0; i < dsCntVal.vG_SchetFact.Rows.Count; i++)
                    {
                        dsCntVal.vG_SchetFact.Rows[i].BeginEdit();
                        pTot = (decimal)dsCntVal.vG_SchetFact[i]["SumTot"];
                        if (pTot < 0)
                            pTot = -pTot;
                        pNal = (decimal)dsCntVal.vG_SchetFact[i]["SumNal"];
                        if (pNal < 0)
                            pNal = -pNal;
                        pNalStr = Legal.Classes.NumByWords.RurPhrase(pNal);
                        pTotStr = Legal.Classes.NumByWords.RurPhrase(pTot);
                        dsCntVal.vG_SchetFact.Rows[i]["SumTotStr"] = pTotStr;
                        dsCntVal.vG_SchetFact.Rows[i]["SumNalStr"] = pNalStr;
                        dsCntVal.vG_SchetFact.Rows[i].EndEdit();
                        this.reportViewerRus1.RefreshReport();
                    }
                }
            }

        }
    }
}
