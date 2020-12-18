using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
/// <summary>
/// ввод числа
/// </summary>
namespace Library
{
    public partial class FormChooseNumberOn : Form
    {
        public int NumberOn
        {
            get
            {
                return Convert.ToInt32(this.txtNumber.Text);
            }
            set
            {
                this.txtNumber.Text = value.ToString();
            }
        }


        public FormChooseNumberOn()
        {
            this.InitializeComponent();
            this.ActiveControl = txtNumber;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void FormChooseNumberOn_Load(object sender, EventArgs e)
        {
            
            txtNumber.Focus();
        }
    }
}