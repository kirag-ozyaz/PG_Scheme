using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Legal.Forms.Calculat
{
    public partial class FormGroupDocSchet : FormLbr.FormBase
    {
        private int IDDOC;

        public FormGroupDocSchet()
        {
            InitializeComponent();
        }
        
        public FormGroupDocSchet(int idDoc)
        {
            InitializeComponent();
            IDDOC = idDoc;
        }

        private void FormGroupDocSchet_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsCntVal, dsCntVal.Tables["vG_DocSchet"], true, " where idDoc = " + IDDOC + " order by Title");
        }

    }
}
