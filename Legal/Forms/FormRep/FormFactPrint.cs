using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Constants;

namespace Legal.Forms.FormRep
{
    public partial class FormFactPrint : FormLbr.FormBase
    {
        private int ID;
        private DateTime DTBANK;
        private int Selector;
        private DateTime DTBEGIN;
        private DateTime DTFACT;

        public FormFactPrint()
        {
            InitializeComponent();
        }

        public FormFactPrint(int id)
        {
            InitializeComponent();
            ID = id;
            Selector = 1;
        }

        public FormFactPrint(DateTime dtBank)
        {
            InitializeComponent();
            DTBANK = dtBank;
            Selector = 2;
        }

        public FormFactPrint(DateTime dtBank, DateTime dtBegin)
        {
            InitializeComponent();
            DTBANK = dtBank;
            DTBEGIN = dtBegin;
            Selector = 3;
        }

        public FormFactPrint(int id, DateTime dtFact)
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
                // одна счет-фактура с текущей формой(FormAbnCalcPrint)
                case 1:
                    if (SelectSqlData(dsCntVal, dsCntVal.vG_SchetFact, true, " where id = " + ID))
                    {
                        if (dsCntVal.vG_SchetFact.Rows.Count > 0)
                        {
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
                // фактуры за выбранный банковский день с текущей формой(FormGroupDoc)
                case 2:
                    if (SelectSqlData(dsCntVal, dsCntVal.vG_SchetFact, true, " where  dtBank = '" + DTBANK.Date.ToString("yyyyMMdd") + "' order by idReg"))
                    {
                        if (dsCntVal.vG_SchetFact.Rows.Count > 0)
                        {
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
                // фактуры за период для архива(FormGroupDoc)
                // dtBegin для определения Формы фактуры
                // dtBank = DateTime(2012,1,1) поскольку счет-фактуры за период формируются на эту дату
                case 3:
                    if (SelectSqlData(dsCntVal, dsCntVal.vG_SchetFact, true, " where  dtBank = '" + DTBANK.Date.ToString("yyyyMMdd") + "' order by idReg"))
                    {
                        if (dsCntVal.vG_SchetFact.Rows.Count > 0)
                        {
                            // найдем форму фактуры для заданного периода
                            string txtWhere = "DocType in (" + Constants.Constants.PaymentSchetFact + ") and '" + DTBEGIN.Date.ToString("yyyyMMdd") + "' between EntryDate and LeaveDate";
                            SelectSqlData(dsCntVal, dsCntVal.tG_FormsPaymentDoc, true, " where " + txtWhere);

                            string FormName = Convert.ToString(dsCntVal.tG_FormsPaymentDoc.Rows[0]["DocForm"]);
                            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports." + FormName;

                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
                case 4:
                    // одна счет-фактура с формой которая определяется в зависимости от даты фактуры dtFact (из FormAbnCalcPrint)
                    if (SelectSqlData(dsCntVal, dsCntVal.vG_SchetFact, true, " where id = " + ID))
                    {
                        if (dsCntVal.vG_SchetFact.Rows.Count > 0)
                        {
                            // найдем форму фактуры для заданного периода
                            string txtWhere = "DocType in (" + Constants.Constants.PaymentSchetFact + ") and '" + DTFACT.Date.ToString("yyyyMMdd") + "' between EntryDate and LeaveDate";
                            SelectSqlData(dsCntVal, dsCntVal.tG_FormsPaymentDoc, true, " where " + txtWhere);

                            string FormName = Convert.ToString(dsCntVal.tG_FormsPaymentDoc.Rows[0]["DocForm"]);
                            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports." + FormName;

                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
            }
        }
    }
}
