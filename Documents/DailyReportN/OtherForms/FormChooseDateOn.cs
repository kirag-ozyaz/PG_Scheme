using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
/// <summary>
/// Выбор даты
/// </summary>
internal partial class FormChooseDateOn : Form
{
	internal DateTime DateOn
	{
		get
		{
			return this.dtpDate.Value;
		}
	}

	internal bool GetCheckIncludeChain()
	{
		return this.checkBoxIncludeChain.Checked;
	}

	internal FormChooseDateOn()
	{
		//
		
		this.InitializeComponent();
		this.dtpDate.Value = DateTime.Now;
	}
}
