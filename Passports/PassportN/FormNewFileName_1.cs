using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal partial class FormNewFileName_1 : Form
{
	public string FileName { get; set; }

	public FormNewFileName_1()
	{
		Class330.Mus9JxKz1CNxy();
		this.loHaazvjlHB = "";
		base..ctor();
		this.InitializeComponent();
		this.loHaazvjlHB = Path.GetExtension(this.FileName);
		this.tbNewFileName.Text = Path.GetFileNameWithoutExtension(this.FileName);
	}

	public FormNewFileName_1(string string_1)
	{
		Class330.Mus9JxKz1CNxy();
		this.loHaazvjlHB = "";
		base..ctor();
		this.InitializeComponent();
		this.loHaazvjlHB = Path.GetExtension(string_1);
		this.tbNewFileName.Text = Path.GetFileNameWithoutExtension(string_1);
	}

	private void btnAccept_Click(object sender, EventArgs e)
	{
		this.FileName = this.tbNewFileName.Text + this.loHaazvjlHB;
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	[CompilerGenerated]
	private string string_0;

	private string loHaazvjlHB;
}
