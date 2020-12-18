using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Legal.Forms
{
    public partial class FormSchetPrint : FormLbr.FormBase
    {
        private int ID;
        private DateTime DTBANK;
        private int Selector;
        private DateTime DATESTORNO;
        private bool FLAG = false;

        public FormSchetPrint()
        {
            InitializeComponent();
        }

        public FormSchetPrint(int id)
        {
            InitializeComponent();
            ID = id;
            Selector = 1;
        }

        public FormSchetPrint(int id, DateTime DateStorno, bool Flag)
        {
            InitializeComponent();
            ID = id;
            DATESTORNO = DateStorno;
            FLAG = Flag;
            Selector = 3;

        }

        public FormSchetPrint(DateTime dtBank)
        {
            InitializeComponent();
            DTBANK = dtBank;
            Selector = 2;
        }

        public FormSchetPrint(int i, DateTime dtBank)
        {
            InitializeComponent();
            DTBANK = dtBank;
            Selector = 5;
        }

        // печать счетов для Ульяновскэнерго
        public FormSchetPrint(DateTime dtBank, int i)
        {
            InitializeComponent();
            DTBANK = dtBank;
            Selector = 4;
        }

        private void FormSchetPrint_Load(object sender, EventArgs e)
        {
            switch (Selector)
            {
                case 1:
                    if (SelectSqlData(dsCntVal, dsCntVal.vG_SchetPrint, true, " where id = " + ID))
                    {
                        if (dsCntVal.vG_SchetPrint.Rows.Count > 0)
                        {
                            SelectSqlData(dsCntVal, dsCntVal.vG_SchetPrintTariff, true, " where id = " + ID);
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
                case 2:
                    if (SelectSqlData(dsCntVal, dsCntVal.vG_SchetPrint, true, " where  dtBank = '" + DTBANK.Date.ToString("yyyyMMdd") + "' order by idReg, id" ))
                    {
                        if (dsCntVal.vG_SchetPrint.Rows.Count > 0)
                        {
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
                case 3:
                    if (SelectSqlData(dsCntVal, dsCntVal.vG_SchetPrint, true, " where id = " + ID))
                    {
                        if (dsCntVal.vG_SchetPrint.Rows.Count > 0)
                        {
                            ReportParameter prm1 = new ReportParameter("DateStorno", DATESTORNO.ToShortDateString());
                            this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter[] { prm1});

                            ReportParameter prm2 = new ReportParameter("Flag", FLAG.ToString());
                            this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter[] { prm2 });

                            SelectSqlData(dsCntVal, dsCntVal.vG_SchetPrintTariff, true, " where id = " + ID);
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
                case 4:
                    if (SelectSqlDataTableOther(dsCntVal, dsCntVal.vG_SchetPrint, "vG_SchetPrintUlenergo", true, " where  dtBank = '" + DTBANK.Date.ToString("yyyyMMdd") + "' order by idReg, id"))
                    {
                        if (dsCntVal.vG_SchetPrint.Rows.Count > 0)
                        {
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;
                case 5:
                    if (SelectSqlDataTableOther(dsCntVal, dsCntVal.vG_SchetPrint, "vG_SchetPrint_CodeAbnStr", true, " where  dtBank = '" + DTBANK.Date.ToString("yyyyMMdd") + "' order by idReg, id"))
                    {
                        if (dsCntVal.vG_SchetPrint.Rows.Count > 0)
                        {
                            this.reportViewerRus1.RefreshReport();
                        }
                    }
                    break;

            }
        }
    }
}
