using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    public partial class ToolStripN : System.Windows.Forms.ToolStrip
    {
        public ToolStripN()
        {
            InitializeComponent();
        }

        public ToolStripN(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public override ToolStripItemCollection Items => base.Items;
    }
}
