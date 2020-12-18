using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Passport.Forms
{
	public partial class FormSearch : Form
	{
		public DataGridView dataGridView
		{
			get
			{
				return this.dataGridView_0;
			}
			set
			{
				this.dataGridView_0 = value;
				this.method_0();
				this.method_2(this.comboBox1.Text.Length > 0 && this.textBox1.Text.Length > 0);
			}
		}

		public FormSearch(DataGridView dataGridView_1)
		{
			this.InitializeComponent();
			this.dataGridView_0 = dataGridView_1;
			base.TopMost = true;
		}

		private void method_0()
		{
			this.comboBox1.Items.Clear();
			foreach (object obj in this.dataGridView_0.Columns)
			{
				DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
				if (dataGridViewColumn.Visible)
				{
					this.comboBox1.Items.Add(dataGridViewColumn.Name);
				}
			}
		}

		private void method_1(bool bool_0, string string_0, string string_1)
		{
			if (bool_0)
			{
				for (int i = this.dataGridView_0.SelectedRows[0].Index + 1; i < this.dataGridView_0.Rows.Count; i++)
				{
					if (this.dataGridView_0.Rows[i].Cells[string_0].Value.ToString().Contains(string_1))
					{
						this.dataGridView_0.Rows[i].Selected = true;
						this.dataGridView_0.FirstDisplayedScrollingRowIndex = this.dataGridView_0.Rows[i].Index;
						return;
					}
				}
				MessageBox.Show("не удается найти " + string_1 + ".", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			for (int j = 0; j < this.dataGridView_0.Rows.Count; j++)
			{
				if (this.dataGridView_0.Rows[j].Cells[string_0].Value.ToString().Contains(string_1))
				{
					this.dataGridView_0.Rows[j].Selected = true;
					this.dataGridView_0.FirstDisplayedScrollingRowIndex = this.dataGridView_0.Rows[j].Index;
					return;
				}
			}
			MessageBox.Show("не удается найти " + string_1 + ".", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.method_1(false, this.comboBox1.Text, this.textBox1.Text);
		}

		private void btnNextSearch_Click(object sender, EventArgs e)
		{
			this.method_1(true, this.comboBox1.Text, this.textBox1.Text);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_2(this.comboBox1.Text.Length > 0 && this.textBox1.Text.Length > 0);
		}

		private void method_2(bool bool_0)
		{
			this.btnSearch.Enabled = bool_0;
			this.btnNextSearch.Enabled = bool_0;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.method_2(this.comboBox1.Text.Length > 0 && this.textBox1.Text.Length > 0);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void FormSearch_Load(object sender, EventArgs e)
		{
			this.method_0();
		}

		private DataGridView dataGridView_0;
	}
}
