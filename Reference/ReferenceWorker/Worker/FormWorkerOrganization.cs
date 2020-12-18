using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;

namespace ReferenceWorker
{
	public partial class FormWorkerOrganization : FormBase
	{
		public int IdAbn
		{
			get
			{
				return this.idAbn;
			}
		}

		public string NameAbn
		{
			get
			{
				return this.nameAbn;
			}
		}

		public FormWorkerOrganization()
		{
			
			this.idAbn = -1;
			this.nameAbn = "";
			
			this.InitializeComponent();
		}

		private void FormWorkerOrganization_Load(object sender, EventArgs e)
		{
			string str = "207,231,230," + 683.ToString() + "," + 581.ToString();
			base.SelectSqlData(this.dataSetWorker, this.dataSetWorker.tAbn, true, " where typeAbn in (" + str + ") order by name");
			this.toolStrip1.Focus();
			this.toolStrip1.Select();
			this.toolTxtFilter.Focus();
			this.toolTxtFilter.Select();
		}

		private void toolTxtFilter_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.toolTxtFilter.Text))
			{
				this.bsAbn.Filter = "";
				return;
			}
			this.bsAbn.Filter = " name like '%" + this.toolTxtFilter.Text + "%'";
		}

		private void FormWorkerOrganization_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && this.dgv.CurrentRow != null)
			{
				this.idAbn = Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
				this.nameAbn = this.dgv.CurrentRow.Cells[this.nameDataGridViewTextBoxColumn.Name].Value.ToString();
			}
		}

		private void FormWorkerOrganization_Activated(object sender, EventArgs e)
		{
			this.toolStrip1.Focus();
			this.toolStrip1.Select();
			this.toolTxtFilter.Focus();
			this.toolTxtFilter.Select();
		}

		private int idAbn;

		private string nameAbn;
	}
}
