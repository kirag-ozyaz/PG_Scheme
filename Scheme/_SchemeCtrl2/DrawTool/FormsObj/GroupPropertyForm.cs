﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class GroupPropertyForm : Form
	{
		public GroupPropertyForm()
		{
			this.InitializeComponent();
		}

		public GroupPropertyForm(GroupDrawObjectBase group)
		{
			this.InitializeComponent();
			this.groupDrawObjectBase_0 = group;
			this.textBoxNameGroup.Text = this.groupDrawObjectBase_0.Name;
			foreach (DrawObjectBase item in this.groupDrawObjectBase_0)
			{
				this.listBoxGroup.Items.Add(item);
			}
		}

		private void buttonRemObj_Click(object sender, EventArgs e)
		{
			if (this.listBoxGroup.Items.Count <= 2)
			{
				if (MessageBox.Show("При удалении этого элемента группа будет расформирована и удалена. Вы действительно хотите убрать элемент из группы?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					this.groupDrawObjectBase_0.Remove();
					base.DialogResult = DialogResult.Cancel;
					base.Close();
					return;
				}
			}
			else
			{
				this.listBoxGroup.Items.Remove(this.listBoxGroup.SelectedItem);
			}
		}

		private void GroupPropertyForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.listBoxGroup.Items.Count > 1)
				{
					int i = 0;
					while (i < this.groupDrawObjectBase_0.Count)
					{
						if (!this.listBoxGroup.Items.Contains(this.groupDrawObjectBase_0[i]))
						{
							this.groupDrawObjectBase_0.Remove(i);
						}
						else
						{
							i++;
						}
					}
					if (this.textBoxNameGroup.Text != this.groupDrawObjectBase_0.Name)
					{
						this.groupDrawObjectBase_0.Name = this.textBoxNameGroup.Text;
					}
					this.groupDrawObjectBase_0.SaveToSQL();
					return;
				}
				this.groupDrawObjectBase_0.Remove();
			}
		}

		private GroupDrawObjectBase groupDrawObjectBase_0;
	}
}
