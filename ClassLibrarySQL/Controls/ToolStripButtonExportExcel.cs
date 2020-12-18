using System.Collections;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using ControlsLbr.DataGridViewExcelFilter;

namespace Library
{
    /*
     1. убрать лишние атрибуты и события
     2. добавить картинку
     3. запретить формирование функций из событий при кликах на кнопке и в списках событий
     */
    public partial class ToolStripButtonExportExcel : ToolStripButton
    {
        [Browsable(true)]
        public override string Text { get => base.Text; set => base.Text = "Экспорт в Excel"; }
        [Browsable(true)]
        [Description("Выводимая таблица с фильтрами на печать")]
        public DataGridView DataGridView
        {
            get;set;
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
                if (DataGridView.GetType() == typeof(DataGridViewExcelFilter))
                    ((DataGridViewExcelFilter)DataGridView).ExportToExcel();
                else
                    return;
            }
            catch (Exception exc) { MessageBox.Show("Ошибка " + exc); }
           // base.OnClick(e);
        }

        private Bitmap _BaseImage;
        public bool ShouldSerializeImage()
        {
            return !object.ReferenceEquals(this.Image, _BaseImage);
        }

        //public override void ResetImage()
        //{
        //    this.Image = _BaseImage;
        //}

        protected override void OnPaint(PaintEventArgs pe)
        {
            this.Image = _BaseImage;
            // Calling the base class OnPaint
            base.OnPaint(pe);
            //Brush b = new System.Drawing.Drawing2D.LinearGradientBrush
            //    (ClientRectangle, c1, c2, 10);
            //pe.Graphics.FillRectangle(b, ClientRectangle);
            //b.Dispose();
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
            
            _BaseImage = Properties.Resources.Excel;
            this.Image = _BaseImage;
        }

        public ToolStripButtonExportExcel()
        {
            InitializeComponent();
            ChangeProperties();
        }

        public ToolStripButtonExportExcel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            ChangeProperties();
        }
    }
}
