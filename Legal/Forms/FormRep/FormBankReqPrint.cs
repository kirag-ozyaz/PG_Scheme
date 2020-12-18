using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.FormRep
{
    public partial class FormBankReqPrint : FormLbr.FormBase
    {
        private int ID;
        private DateTime DTBANK;
        private int Selector;
        private string pTotStr;
        private decimal pTot;

        public FormBankReqPrint()
        {
            InitializeComponent();
        }

        public FormBankReqPrint(int id)
        {
            InitializeComponent();
            ID = id;
            Selector = 1;
        }

        public FormBankReqPrint(DateTime dtBank)
        {
            InitializeComponent();
            DTBANK = dtBank;
            Selector = 2;
        }

        private void FormBankReqPrint_Load(object sender, EventArgs e)
        {
            switch (Selector)
            {
                case 1:
                    if (SelectSqlData(dsCntVal, dsCntVal.tG_BankReq, true, " where id = " + ID))
                    {
                        if (dsCntVal.tG_BankReq.Rows.Count > 0)
                        {
                            dsCntVal.tG_BankReq.Rows[0].BeginEdit();
                            pTot = (decimal)dsCntVal.tG_BankReq[0]["SumTotal"];
                            if (pTot < 0)
                                pTot = - pTot;
                            pTotStr = Legal.Classes.NumByWords.RurPhrase(pTot);
                            dsCntVal.tG_BankReq.Rows[0]["SumStr"] = pTotStr;
                            dsCntVal.tG_BankReq.Rows[0].EndEdit();
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
                case 2:
                    if (SelectSqlData(dsCntVal, dsCntVal.tG_BankReq, true, " where DateReq = '" + DTBANK.Date.ToString("yyyyMMdd") + "'"))
                    {
                        if (dsCntVal.tG_BankReq.Rows.Count > 0)
                        {
                            for (int i = 0; i < dsCntVal.tG_BankReq.Rows.Count; i++)
                            {
                                dsCntVal.tG_BankReq.Rows[i].BeginEdit();
                                pTot = (decimal)dsCntVal.tG_BankReq[i]["SumTotal"];
                                if (pTot < 0)
                                    pTot = -pTot;
                                pTotStr = Legal.Classes.NumByWords.RurPhrase(pTot);
                                dsCntVal.tG_BankReq.Rows[i]["SumStr"] = pTotStr;
                                dsCntVal.tG_BankReq.Rows[i].EndEdit();
                            }
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
            }
        }
    }
}
