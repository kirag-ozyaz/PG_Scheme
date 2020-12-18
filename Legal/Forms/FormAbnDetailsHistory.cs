using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnDetailsHistory : FormLbr.FormBase
    {
        private int ID = -1;

        public FormAbnDetailsHistory()
        {
            InitializeComponent();
        }
        
        public FormAbnDetailsHistory(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FormAbnDetailsHistory_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnDetails1, dsAbnDetails1.vG_AbnDetailsHistory, true, " where idAbn = " + ID.ToString() + "order by DateChange desc, id desc");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
