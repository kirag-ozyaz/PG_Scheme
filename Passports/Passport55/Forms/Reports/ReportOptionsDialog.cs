using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Passport.Forms.Reports
{
	public partial class ReportOptionsDialog : Form
	{
		internal ReportOptionsDialog(List<Class120> list_1)
		{
			this.InitializeComponent();
			this.list_0 = list_1;
			foreach (Class120 @class in list_1)
			{
				this.fieldsListBox.Items.Add(@class.method_0());
			}
			for (int i = 0; i < this.fieldsListBox.Items.Count; i++)
			{
				this.fieldsListBox.SetItemChecked(i, true);
			}
		}

		internal List<Class120> method_0()
		{
			List<Class120> list = new List<Class120>();
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.fieldsListBox.CheckedItems.Contains(this.list_0[i].method_0()))
				{
					list.Add(this.list_0[i]);
				}
			}
			return list;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (this.fieldsListBox.CheckedItems.Count == 0)
			{
				MessageBox.Show("At least one field must be selected");
				return;
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private List<Class120> list_0;
	}
}
