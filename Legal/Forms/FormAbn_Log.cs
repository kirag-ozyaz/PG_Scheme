using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Legal.Forms
{
    public partial class FormAbn_Log : FormLbr.FormBase
    {
        private int ID;

        public FormAbn_Log()
        {
            InitializeComponent();
        }

        public FormAbn_Log(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FormAbn_Log_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsInfo1, dsInfo1.vG_AbnInfo_Log, true, " where idAbn = " + ID + " order by id");
        }

    }
}
