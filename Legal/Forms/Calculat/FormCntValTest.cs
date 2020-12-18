using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Calculat
{
    public partial class FormCntValTest : FormLbr.FormBase
    {
        public FormCntValTest()
        {
            InitializeComponent();
        }

        public FormCntValTest(int id)
        {
            InitializeComponent();
        }

        private void FormCntValTest_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsCntVal1, dsCntVal1.tG_DocSchetTemp, true);
        }

        private void splitContainer2_SplitterMoving(object sender, SplitterCancelEventArgs e)
        {
           splitContainer3.SplitterDistance = splitContainer2.SplitterDistance;
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitContainer3.SplitterDistance = splitContainer2.SplitterDistance;
        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitContainer2.SplitterDistance = splitContainer3.SplitterDistance;
        }
    }
}
