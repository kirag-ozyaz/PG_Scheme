using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormNewFileName : Form
    {
        public string FileName { get; set; }

        private string ext = "";

        public FormNewFileName()
        {
            InitializeComponent();
            ext = System.IO.Path.GetExtension(FileName);
            tbNewFileName.Text = System.IO.Path.GetFileNameWithoutExtension(FileName);
            //tbNewFileName.Text = FileName;
        }

        public FormNewFileName(string fileName)
        {
            InitializeComponent();
            ext = System.IO.Path.GetExtension(fileName);
            tbNewFileName.Text = System.IO.Path.GetFileNameWithoutExtension(fileName);
            //tbNewFileName.Text = fileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.FileName = tbNewFileName.Text + ext;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
