using ControlsLbr.DataGridViewExcelFilter;
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
    public partial class ToolStripButtonMail : ToolStripButton
    {

        [Browsable(true)]
        public override string Text { get => base.Text; set => base.Text = "Отправить почту"; }
        [Browsable(true)]
        [Description("Отправляемая таблица с фильтрами на почту")]
        public DataGridView DataGridView
        {
            get; set;
        }
        protected override void OnDoubleClick(EventArgs e)
        {
            //base.OnDoubleClick(e);
        }
        protected override void OnClick(EventArgs e)
        {
            if (DataGridView is null)
            {
                MessageBox.Show("Нет привязки к таблице для экспорта");
                return;
            }
            try
            {
                // открыть форму отправки почты
            }
            catch (Exception exc) { MessageBox.Show("Ошибка " + exc); }
            // base.OnClick(e);
        }

        private Bitmap _BaseImage;
        public bool ShouldSerializeImage()
        {
            return !object.ReferenceEquals(this.Image, _BaseImage);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            this.Image = _BaseImage;
            // Calling the base class OnPaint
            base.OnPaint(pe);

        }
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public new Image Image
        {
            get { return base.Image; }
            set { base.Image = value; }
        }

        void ChangeProperties()
        {
            this.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;

            _BaseImage = Properties.Resources.Send;
            this.Image = _BaseImage;
        }


        public ToolStripButtonMail()
        {
            InitializeComponent();
            ChangeProperties();
        }

        public ToolStripButtonMail(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            ChangeProperties();
        }
    }
}
