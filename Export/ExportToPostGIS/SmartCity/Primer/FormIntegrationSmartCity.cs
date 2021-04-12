using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExportToPostGIS.SmartCity
{
    public partial class FormIntegrationSmartCity : FormBase
    {
        public FormIntegrationSmartCity()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SmartCity ss = new SmartCity();
            ss.SqlSettings = this.SqlSettings;
            ss.Integration();
        }
    }
}
