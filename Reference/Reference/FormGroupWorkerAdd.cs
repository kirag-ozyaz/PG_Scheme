using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

internal partial class FormGroupWorkerAdd : FormBase
{
	internal FormGroupWorkerAdd()
	{
		
		this.int_0 = -1;
		this.int_1 = -1;
		
		this.InitializeComponent();
	}

	internal FormGroupWorkerAdd(int int_2)
	{
		
		this.int_0 = -1;
		this.int_1 = -1;
		
		this.InitializeComponent();
		this.int_0 = int_2;
	}

	internal FormGroupWorkerAdd(int int_2, int int_3)
	{
		
		this.int_0 = -1;
		this.int_1 = -1;
		
		this.InitializeComponent();
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	private void FormGroupWorkerAdd_Load(object sender, EventArgs e)
	{
		base.SelectSqlData(this.class48_0, this.class48_0.tR_Classifier, true, " where ParentKey like ';GroupWorker;%' and isGRoup = 0  and deleted = 0 order by name");
		this.cmbGroup.SelectedIndex = -1;
		this.cmbGroup.SelectedValue = this.int_0;
	}

	private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.cmbGroup.SelectedIndex >= 0)
		{
			base.SelectSqlData(this.class48_0, this.class48_0.tL_ClassifierWorker, true, " where idGRoup = " + this.cmbGroup.SelectedValue.ToString());
			if (this.class48_0.tL_ClassifierWorker.Rows.Count > 0)
			{
				string text = "";
				foreach (object obj in this.class48_0.tL_ClassifierWorker.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					text = text + dataRow["idWorker"].ToString() + ",";
				}
				text = " where id not in (" + text.Remove(text.Length - 1) + ") ";
				base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_Worker"], true, text + " order by f, i, o");
			}
		}
	}

	private void buttonOk_Click(object sender, EventArgs e)
	{
		if (this.cmbGroup.SelectedIndex < 0)
		{
			MessageBox.Show("Не выбрана группа");
			return;
		}
		if (this.cmbWorker.SelectedIndex < 0)
		{
			MessageBox.Show("Не выбран сотрудник");
			return;
		}
		Class48 @class = new Class48();
		DataRow dataRow = @class.tL_ClassifierWorker.NewRow();
		dataRow["idGRoup"] = this.cmbGroup.SelectedValue;
		dataRow["idWorker"] = this.cmbWorker.SelectedValue;
		@class.tL_ClassifierWorker.Rows.Add(dataRow);
		if (base.InsertSqlData(@class, @class.tL_ClassifierWorker))
		{
			base.DialogResult = DialogResult.OK;
		}
	}

	private int int_0;

	private int int_1;
}
