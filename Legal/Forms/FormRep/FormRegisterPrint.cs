using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.FormRep
{
    public partial class FormRegisterPrint : FormLbr.FormBase
    {
        private DateTime DTBANK;
        private string pTotStr;
        private decimal pTot;

        public FormRegisterPrint()
        {
            InitializeComponent();
        }
        
        public FormRegisterPrint(DateTime dtBank)
        {
            InitializeComponent();
            DTBANK = dtBank;
        }

        private void FormRegisterPrint_Load(object sender, EventArgs e)
        {
            if (SelectSqlData(dsCntVal, dsCntVal.vG_Register, true, " where DateReg = '" + DTBANK.Date.ToString("yyyyMMdd") + "' order by id"))
            {
                if (dsCntVal.vG_Register.Rows.Count > 0)
                {
                    for (int i = 0; i < dsCntVal.vG_Register.Rows.Count; i++)
                    {
                        dsCntVal.vG_Register.Rows[i].BeginEdit();
                        pTot = (decimal)dsCntVal.vG_Register[i]["SumReg"];
                        pTotStr = Legal.Classes.NumByWords.RurPhrase(pTot);
                        dsCntVal.vG_Register.Rows[i]["SumStr"] = pTotStr;
                        dsCntVal.vG_Register.Rows[i].EndEdit();
                    }
                    this.reportViewerRus1.RefreshReport();
                }
            }
        }
    }
}
