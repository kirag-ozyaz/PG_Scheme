using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Meter
{
    public partial class FormMeterParameters_Log : FormLbr.FormBase
    {
        private int IDPOINTREG;

        public FormMeterParameters_Log()
        {
            InitializeComponent();
        }

        public FormMeterParameters_Log(int idPointReg)
        {
            InitializeComponent();
            IDPOINTREG = idPointReg;
        }

        private void FormMeterParameters_Log_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsCnt1, dsCnt1.vG_PointParameters_Log, true, " where idPointReg = " + IDPOINTREG + " order by datecommand");
        }


    }
}
