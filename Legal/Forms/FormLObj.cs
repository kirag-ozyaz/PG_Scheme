using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormLObj : FormLbr.FormBase
    {
        public FormLObj()
        {
            InitializeComponent();
        }

        private void FormLObj_Load(object sender, EventArgs e)
        {
        }
        private void AllTotal()
        {
            int ObjTotal;
            ObjTotal = 0;
            for (int i = 0; i < dataGridViewObj.RowCount; i++)
            {
                ObjTotal = ObjTotal + 1;
            }
            this.tBoxObj.Text = ObjTotal.ToString();
        }

        private void dataGridViewObj_Paint(object sender, PaintEventArgs e)
        {
            AllTotal();
        }

 
    }

}

