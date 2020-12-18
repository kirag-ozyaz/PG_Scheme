using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Object
{
    public partial class FormObjHistory : FormLbr.FormBase
    {
        private int ID = -1;

        public FormObjHistory()
        {
            InitializeComponent();
        }
        
        public FormObjHistory(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FormObjHistory_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsObj, dsObj.vG_AbnObjReg, true, " where idAbnObj = " + ID.ToString() + "order by DateChange desc");
        }

    }
}
