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
    public partial class FormActAddEdit : FormLbr.FormBase
    {
        private int ID = -1;

        public FormActAddEdit()
        {
            InitializeComponent();
        }

        public FormActAddEdit(int id)
        {
            InitializeComponent();
            ID = id;
        }


        private void FormActAddEdit_Load(object sender, EventArgs e)
        {
            if (ID > -1)
            {

                this.SelectSqlData(dataSetRep1, dataSetRep1.tPrv_JournalAct, true, " where id = " + ID + " and Deleted = 0");
                this.SelectSqlData(dataSetRep1, dataSetRep1.tPrv_RepAct, true, " where idJournal = " + ID + " order by id");

                txtNumber.Text = dataSetRep1.tPrv_JournalAct.Rows[0]["NumberAct"].ToString();
                dtActDate.Value = Convert.ToDateTime(dataSetRep1.tPrv_JournalAct.Rows[0]["DateAct"]);
            }
            else
            {
            }
        }
    }
}
