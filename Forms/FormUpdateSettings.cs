
using FormLbr;
using FormLbr.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EIS.Forms
{
    public partial class FormUpdateSettings : FormBase
    {
        private UpdateSettings updSEtt;

        public UpdateSettings UpdateSettings
        {
            get
            {
                return this.updSEtt;
            }
            set
            {
                this.textBox1.Text = value.DownloadPath;
                this.numericUpDown1.Value = value.IntervalUpdate / 1000 / 60 < 10 ? new Decimal(10) : (Decimal)(value.IntervalUpdate / 1000 / 60);
                this.updSEtt = value;
            }
        }

        public FormUpdateSettings()
        {
            this.InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.UpdateSettings.DownloadPath = (this.textBox1.Text);
            this.UpdateSettings.IntervalUpdate = ((int)(this.numericUpDown1.Value * new Decimal(60) * new Decimal(1000)));
            ((Form)this).Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            ((Form)this).Close();
        }

    }
}
