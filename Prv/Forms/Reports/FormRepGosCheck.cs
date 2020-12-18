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
    internal partial class FormRepGosCheck : Form
    {
        public FormRepGosCheck(DataSets.DataSetRep ds)
		{
			InitializeComponent();

			for (int i = 0; i < ds.RepDateCheck.Rows.Count; i++)
			{
                dataSetRep.RepDateCheck.ImportRow(ds.RepDateCheck.Rows[i]);
			}
		}

        private void FormGosCheck_Load(object sender, EventArgs e)
        {
            this.reportViewerRus1.RefreshReport();
        }
    }
}
