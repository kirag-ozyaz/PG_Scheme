using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExportToPostGIS.Dokuments
{
    public partial class FormExportOrder : FormBase
    {
        public FormExportOrder()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText($"Начали {DateTime.Now}\r\n");
            Order dok = new Order();
            dok.SqlSettings = this.SqlSettings;
            dok.Export();
            richTextBox1.AppendText($"Закончили {DateTime.Now}\r\n");
        }
    }
}
