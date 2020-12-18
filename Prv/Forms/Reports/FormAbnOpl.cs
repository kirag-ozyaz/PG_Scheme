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
    public partial class FormAbnOpl : FormLbr.FormBase
    {
        private int idAbn,idPoint;

        public FormAbnOpl()
        {
            InitializeComponent();
        }

        public FormAbnOpl(int idA,int idP)
        {
            InitializeComponent();
            idAbn = idA;
            idPoint = idP;
            
        }


        private void FormAbnOpl_Load(object sender, EventArgs e)
        {

            this.SelectSqlData(dsRep, dsRep.vAbnForRep, true, " where id = " + idAbn.ToString());
            //this.SelectSqlData(dsRep, dsRep.vAbnObjAddress, true, " where idAbn = " + idAbn.ToString());
            this.SelectSqlData(dsRep, dsRep.vDocAll, true, " where IdPoint = " + idPoint.ToString());
            
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("idAbn", idAbn.ToString());
            this.RVAbnOpl.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p1 });
            
            this.RVAbnOpl.RefreshReport();
            this.RVAbnOpl.RefreshReport();
        }
    }
}
