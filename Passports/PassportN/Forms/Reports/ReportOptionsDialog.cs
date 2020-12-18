using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Passport.Forms.Reports
{
	public partial class ReportOptionsDialog : Form
	{
		internal ReportOptionsDialog(List<Class328> availableFields)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.InitializeComponent();
			this.list_0 = availableFields;
			foreach (Class328 @class in availableFields)
			{
				this.fieldsListBox.Items.Add(@class.method_0());
			}
			for (int i = 0; i < this.fieldsListBox.Items.Count; i++)
			{
				this.fieldsListBox.SetItemChecked(i, true);
			}
		}

		internal List<Class328> method_0()
		{
			List<Class328> list = new List<Class328>();
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

		private List<Class328> list_0;
	}
}
