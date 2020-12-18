using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SchemeCtrl2.Canvas.Forms
{
	public partial class FormCanvasRemoveTransformer : Form
	{
		public FormCanvasRemoveTransformer()
		{
			
			
			this.InitializeComponent();
			this.button_3 = false;
		}

		public string Caption
		{
			get
			{
				return this.labelText.Text;
			}
			set
			{
				this.labelText.Text = value;
			}
		}

		public bool All
		{
			get
			{
				return this.checkBoxAll.Checked;
			}
			set
			{
				this.checkBoxAll.Checked = value;
			}
		}

		public bool button_3
		{
			get
			{
				return this.button2.Visible;
			}
			set
			{
				this.button2.Visible = value;
			}
		}
	}
}
