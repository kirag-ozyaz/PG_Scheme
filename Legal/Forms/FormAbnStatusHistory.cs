using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnStatusHistory : FormLbr.FormBase
    {
        private int ID = -1;

        public FormAbnStatusHistory()
        {
            InitializeComponent();
        }
        
        public FormAbnStatusHistory(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FormAbnStatusHistory_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnStatus, dsAbnStatus.vG_AbnStatusReason, true, " where idAbn = " + ID.ToString() + "order by DateChange desc");
        }
    }
}
