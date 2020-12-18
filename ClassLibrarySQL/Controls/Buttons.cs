using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    [ToolboxBitmap(typeof(ButtonTest), "Excel")]
    public partial class ButtonTest : Button
    {
        public override string Text { get => base.Text; set => base.Text = ""; }

        private Bitmap _BaseImage;
        public bool ShouldSerializeImage()
        {
            return !object.ReferenceEquals(this.Image, _BaseImage);
        }

        public void ResetImage()
        {
            this.Image = _BaseImage;
        }
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public new Image Image
        {
            get { return base.Image; }
            set { base.Image = value; }
        }

        public ButtonTest()
        {
            InitializeComponent();

            _BaseImage = Properties.Resources.Excel;
            this.Image = _BaseImage;
        }

        public ButtonTest(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            _BaseImage = Properties.Resources.Excel;
            this.Image = _BaseImage;
        }
    }
}
