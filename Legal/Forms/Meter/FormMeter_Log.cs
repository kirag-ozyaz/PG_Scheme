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
    public partial class FormMeter_Log : FormLbr.FormBase
    {
        private int IDPOINT;
        private int IDMETER;
        private DateTime DT;

        public FormMeter_Log()
        {
            InitializeComponent();
        }

        public FormMeter_Log(int idPoint, int idMeter, DateTime dt)
        {
            InitializeComponent();
            IDPOINT = idPoint;
            IDMETER = idMeter;
            DT = dt;
        }

        private void FormMeter_Log_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsCnt1, dsCnt1.vG_FormMeter_Log, true, " where idPoint = " + IDPOINT + " and idMeter = " + IDMETER + " and DateAct = '" + DT.Date.ToString("yyyyMMdd") + "'" + " order by id");
        }

    }
}
