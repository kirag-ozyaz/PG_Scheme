using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Legal.DataSet;
using Microsoft.Reporting.WinForms;

namespace Legal.Forms.Calculat
{
    public partial class FormReportObjLinkPrint : FormLbr.FormBase
    {
        FormReportObjLink frmOwner;
        internal dsDop.tG_ReportMain_LinkDataTable TableReport;

        internal FormReportObjLink FormParent { get; set; }

        public FormReportObjLinkPrint()
        {
            InitializeComponent();
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(reportViewerRus_ReportRefresh);
        }

        private void FormReportObjLinkPrint_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            if (this.FormParent.GetType() == typeof(FormReportObjLink))
            {
                frmOwner = (FormReportObjLink)this.FormParent;

                this.Text = "Отчет потребления помесячно по объекта с привязками к схеме";

                FillReport();
            }
            else
            {
                MessageBox.Show("Некорректная форма вызова для печатной формы!");
            }
        }
        private void reportViewerRus_ReportRefresh(object sender, CancelEventArgs e)
        {
            FillReport();
        }

        private void FillReport()
        {
            this.dsDop.tG_ReportMain_Link.Clear();
            this.TableReport.CopyToDataTable(this.dsDop.tG_ReportMain_Link, LoadOption.OverwriteChanges);

            this.reportViewer1.RefreshReport();
        }
    }
}
