using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.FormRep
{
    public partial class FormFactPrint_Correct : FormLbr.FormBase
    {
        private int ID;
        private DateTime DTBANK;
        private int Selector;
        private DateTime DTFACT;

        public FormFactPrint_Correct()
        {
            InitializeComponent();
        }

        public FormFactPrint_Correct(int id)
        {
            InitializeComponent();
            ID = id;
            Selector = 1;
        }

        public FormFactPrint_Correct(DateTime dtBank)
        {
            InitializeComponent();
            DTBANK = dtBank;
            Selector = 2;
        }

        public FormFactPrint_Correct(int id, DateTime dtFact)
        {
            InitializeComponent();
            ID = id;
            DTFACT = dtFact;
            Selector = 4;
        }


        private void FormFactPrint_Load(object sender, EventArgs e)
        {
            switch (Selector)
            {
                case 1:
                    if (SelectSqlData(dsCntVal1, dsCntVal1.vG_SchetFact_Correct, true, " where id = " + ID + " order by NumPosition, BasicDoc"))
                    {
                        if (dsCntVal1.vG_SchetFact_Correct.Rows.Count > 0)
                        {
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
                case 2:
                    if (SelectSqlData(dsCntVal1, dsCntVal1.vG_SchetFact_Correct, true, " where  dtBank = '" + DTBANK.Date.ToString("yyyyMMdd") + "' order by idReg"))
                    {
                        if (dsCntVal1.vG_SchetFact_Correct.Rows.Count > 0)
                        {
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
                case 4:
                    // одна счет-фактура с формой которая определяется в зависимости от даты фактуры dtFact (из FormAbnCalcPrint)
                    if (SelectSqlData(dsCntVal1, dsCntVal1.vG_SchetFact_Correct, true, " where id = " + ID))
                    {
                        if (dsCntVal1.vG_SchetFact_Correct.Rows.Count > 0)
                        {
                            // найдем форму фактуры для заданного периода
                            string txtWhere = "DocType in (" + Constants.Constants.PaymentSchetFactCorrect + ") and '" + DTFACT.Date.ToString("yyyyMMdd") + "' between EntryDate and LeaveDate";
                            SelectSqlData(dsCntVal1, dsCntVal1.tG_FormsPaymentDoc, true, " where " + txtWhere);

                            string FormName = Convert.ToString(dsCntVal1.tG_FormsPaymentDoc.Rows[0]["DocForm"]);
                            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports." + FormName;

                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;

            }
        }

    }
}
