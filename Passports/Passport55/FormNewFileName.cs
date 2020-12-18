using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal partial class FormNewFileName : Form
{
	[CompilerGenerated]
	public string method_0()
	{
		return this.string_0;
	}

	[CompilerGenerated]
	public void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	public FormNewFileName()
	{
		this.InitializeComponent();
		this.string_1 = Path.GetExtension(this.method_0());
		this.tbNewFileName.Text = Path.GetFileNameWithoutExtension(this.method_0());
	}

	public FormNewFileName(string string_2)
	{
		this.InitializeComponent();
		this.string_1 = Path.GetExtension(string_2);
		this.tbNewFileName.Text = Path.GetFileNameWithoutExtension(string_2);
	}

	private void btnAccept_Click(object sender, EventArgs e)
	{
		this.method_1(this.tbNewFileName.Text + this.string_1);
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

	private string string_1 = "";
}
