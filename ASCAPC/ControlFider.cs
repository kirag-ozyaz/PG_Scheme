using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASCAPC
{
    public partial class ControlFiderN : UserControl
    {
        private TypeNode typeNode;

        public TypeNode TypeNode
        {
            get { return typeNode; }
            set
            {
                if (value == null)
                {
                    typeNode = new TypeNode();
                }
                else
                {
                    typeNode = value;

                    this.IDC_CODE.Enabled = false;
                    this.IDC_CODE.Text = typeNode.Code.ToString();
                    this.IDC_NAME.Text = typeNode.Name.ToString();
                    if (typeNode.TypeCode == TypeCodes.Node)
                    {
                        this.IDC_CALC_FACTOR.Text = typeNode.CALC_FACTOR.ToString();
                        this.IDC_XML_CODE.Text = typeNode.XML_CODE.ToString();

                        var METER_TYPE = typeNode.METER_TYPE;
                        if (METER_TYPE == 'P')
                        {
                            this.IDC_ACT.Checked = true;
                            this.IDC_REACT.Checked = false;
                        }
                        else // if (METER_TYPE == 'Q')
                        {
                            this.IDC_ACT.Checked = false;
                            this.IDC_REACT.Checked = true;
                        }

                        this.IDC_CALC_FACTOR.Enabled = true;
                        this.IDC_XML_CODE.Enabled = true;
                        this.IDC_ACT.Enabled = true;
                        this.IDC_REACT.Enabled = true;
                    }
                    else if (typeNode.TypeCode == TypeCodes.Object)
                    {
                        this.IDC_CALC_FACTOR.Text = "";
                        this.IDC_XML_CODE.Text = "";

                        this.IDC_CALC_FACTOR.Enabled = false;
                        this.IDC_XML_CODE.Enabled = false;
                        this.IDC_ACT.Enabled = false;
                        this.IDC_REACT.Enabled = false;
                    }
                    else
                        this.Enabled = false;
                };
            }
        }
        public ControlFiderN()
        {
            InitializeComponent();
            if (TypeNode == null)
            {
                TypeNode = new TypeNode();
            }
        }

        private void IDC_CODE_TextChanged(object sender, EventArgs e)
        {
            short Code = Convert.ToInt16(this.IDC_CODE.Text);
            this.IDC_CODE.Text = Code < (short)-1 ? "" : Code.ToString();
            typeNode.Code = Code < (short)-1 ? (short)-1 : Code;
        }

        private void IDC_NAME_TextChanged(object sender, EventArgs e)
        {
            typeNode.Name = this.IDC_NAME.Text;
        }

        private void IDC_CALC_FACTOR_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(this.IDC_CALC_FACTOR.Text, out x))
            {
                typeNode.CALC_FACTOR = Convert.ToDouble(this.IDC_CALC_FACTOR.Text);
            }
            else { this.IDC_CALC_FACTOR.Text = "1"; typeNode.CALC_FACTOR = 1; }
            
        }

        private void IDC_XML_CODE_TextChanged(object sender, EventArgs e)
        {
            typeNode.XML_CODE = this.IDC_XML_CODE.Text;
        }

        private void IDC_ACT_CheckedChanged(object sender, EventArgs e)
        {
            if (typeNode != null)
                if (((RadioButton)sender).Checked)
                    typeNode.METER_TYPE = 'P';
                else
                    typeNode.METER_TYPE = 'Q';
        }

        private void IDC_REACT_CheckedChanged(object sender, EventArgs e)
        {
            if (typeNode != null)
                if (!((RadioButton)sender).Checked)
                    typeNode.METER_TYPE = 'P';
                else
                    typeNode.METER_TYPE = 'Q';

        }

        private void IDC_CODE_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 45 ASCII(-)
            if (e.KeyChar == '-') // e.KeyChar!= 45
            {
                if (this.IDC_CODE.Text.IndexOf('-') != -1)
                    e.Handled = true;
                else if (((System.Windows.Forms.TextBoxBase)sender).SelectionStart != 0)
                    e.Handled = true;
            }
            else if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
            {
                    e.Handled = true;
            }
        }

        private void IDC_XML_CODE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
            {
                    e.Handled = true;
            }
        }

        private void IDC_CALC_FACTOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 44 ASCII(,)
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != 44)
            {
                    e.Handled = true;
            }
        }

        private void IDC_CODE_KeyUp(object sender, KeyEventArgs e)
        {
            //
        }
    }
}
