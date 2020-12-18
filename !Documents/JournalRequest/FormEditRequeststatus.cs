using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Documents.Forms.JournalRequest
{
    public partial class FormEditRequeststatus : FormLbr.FormBase
    {
        int idRequest = -1;

        public FormEditRequeststatus()
        {
            InitializeComponent();
        }
        public FormEditRequeststatus(int id)
        {
            InitializeComponent();
            idRequest = id;
        }

        private void FormEditRequeststatus_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsRef, dsRef.Tables["tR_Classifier"], true, 
                "where deleted = 0 and isgroup = 0 and ParentKey in (';Other;StatusTask;', ';Other;TypeTask;')");

            this.SelectSqlData(dsGES, dsGES.tJ_Request, true, "where id = " + idRequest.ToString());
        }

        private void FormEditRequeststatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dsGES.tJ_Request.Rows[0].EndEdit();
                this.UpdateSqlData(dsGES, dsGES.tJ_Request);
            }
        }


    }
}
