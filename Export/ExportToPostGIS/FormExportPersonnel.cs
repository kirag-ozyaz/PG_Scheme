using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Personnel
{
    public partial class FormExportPersonnel : FormBase
    {
        public FormExportPersonnel()
        {
            InitializeComponent();
        }

        private void btnImportPersonnel_Click(object sender, EventArgs e)
        {
            //
            this.richTextBox1.Clear();

            Personnel.Export exp = new Personnel.Export();
            exp.SqlSettings = this.SqlSettings;
            exp.isSaveDate = false;
            exp.FormParent = this;
            exp.Start();
        }
    }
}
