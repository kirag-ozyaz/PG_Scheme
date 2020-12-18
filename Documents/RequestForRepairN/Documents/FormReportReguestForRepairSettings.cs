using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormReportReguestForRepairSettings : Form
{
	internal string AppoveTitle
	{
		get
		{
			return this.txtAppoveTitle.Text;
		}
		set
		{
			this.txtAppoveTitle.Text = value;
		}
	}

	internal string AppoveOrg
	{
		get
		{
			return this.txtAppoveOrg.Text;
		}
		set
		{
			this.txtAppoveOrg.Text = value;
		}
	}

	internal string AppoveFIO
	{
		get
		{
			return this.txtAppoveFIO.Text;
		}
		set
		{
			this.txtAppoveFIO.Text = value;
		}
	}

	internal string SignatureTitle1
	{
		get
		{
			return this.txtSignatureTitle1.Text;
		}
		set
		{
			this.txtSignatureTitle1.Text = value;
		}
	}

	internal string SignatureFIO1
	{
		get
		{
			return this.txtSignatureFIO1.Text;
		}
		set
		{
			this.txtSignatureFIO1.Text = value;
		}
	}

	internal string SignatureTitle2
	{
		get
		{
			return this.txtSignatureTitle2.Text;
		}
		set
		{
			this.txtSignatureTitle2.Text = value;
		}
	}

	internal string SignatureFIO2
	{
		get
		{
			return this.txtSignatureFIO2.Text;
		}
		set
		{
			this.txtSignatureFIO2.Text = value;
		}
	}

	internal FormReportReguestForRepairSettings()
	{
		this.InitializeComponent();
	}
}
