using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Legal.Forms.Calculat
{
    public partial class FormCntVal_Log : FormLbr.FormBase
    {
        private int ID;
        private DateTime DT;

        public FormCntVal_Log()
        {
            InitializeComponent();
        }

        public FormCntVal_Log(int id, DateTime dt)
        {
            InitializeComponent();
            ID = id;
            DT = dt;
        }

        
        private void FormCntVal_Log_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsCntVal1, dsCntVal1.vG_FormCntVal_Log, true, " where idAbnObj = " + ID + " and dtCalc = '" + DT.Date.ToString("yyyyMMdd") + "'" + " order by id");
        }
    }
}
