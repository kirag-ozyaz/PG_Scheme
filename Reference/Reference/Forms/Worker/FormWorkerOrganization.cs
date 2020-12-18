using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;

namespace Reference.Forms.Worker
{
	public partial class FormWorkerOrganization : FormBase
	{
		public int IdAbn
		{
			get
			{
				return this.int_0;
			}
		}

		public string NameAbn
		{
			get
			{
				return this.string_0;
			}
		}

		public FormWorkerOrganization()
		{
			
			this.int_0 = -1;
			this.string_0 = "";
			
			this.InitializeComponent();
		}

		private void FormWorkerOrganization_Load(object sender, EventArgs e)
		{
			string str = "207,231,230," + 683.ToString() + "," + 581.ToString();
			base.SelectSqlData(this.class48_0, this.class48_0.tAbn, true, " where typeAbn in (" + str + ") order by name");
			this.toolStrip1.Focus();
			this.toolStrip1.Select();
			this.toolTxtFilter.Focus();
			this.toolTxtFilter.Select();
		}

		private void toolTxtFilter_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.toolTxtFilter.Text))
			{
				this.bindingSource_0.Filter = "";
				return;
			}
			this.bindingSource_0.Filter = " name like '%" + this.toolTxtFilter.Text + "%'";
		}

		private void FormWorkerOrganization_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && this.dgv.CurrentRow != null)
			{
				this.int_0 = Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
				this.string_0 = this.dgv.CurrentRow.Cells[this.nameDataGridViewTextBoxColumn.Name].Value.ToString();
			}
		}

		private void FormWorkerOrganization_Activated(object sender, EventArgs e)
		{
			this.toolStrip1.Focus();
			this.toolStrip1.Select();
			this.toolTxtFilter.Focus();
			this.toolTxtFilter.Select();
		}

		private int int_0;

		private string string_0;
	}
}
