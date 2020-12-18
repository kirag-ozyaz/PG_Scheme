using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using FormLbr;

internal partial class FormJobTitlesAddEdit : FormBase
{
	[CompilerGenerated]
	internal StateFormCreate method_0()
	{
		return this.stateFormCreate_0;
	}

	[CompilerGenerated]
	internal void method_1(StateFormCreate stateFormCreate_1)
	{
		this.stateFormCreate_0 = stateFormCreate_1;
	}

	internal FormJobTitlesAddEdit()
	{
		
		this.int_0 = -1;
		
		this.InitializeComponent();
	}

	internal FormJobTitlesAddEdit(int int_1)
	{
		
		this.int_0 = -1;
		
		this.InitializeComponent();
		this.int_0 = int_1;
	}

	private void FormJobTitlesAddEdit_Load(object sender, EventArgs e)
	{
		StateFormCreate stateFormCreate = this.method_0();
		if (stateFormCreate == null)
		{
			this.Text = "Добавить должность";
			Class48.Class62 @class = this.class48_0.tR_JobTitle.method_5();
			@class.Deleted = false;
			@class.Description = this.txtName.Text;
			@class.RName = this.txtRating.Text;
			@class.Razrjad = Convert.ToInt32(this.numUpDownRate.Value);
			this.class48_0.tR_JobTitle.Rows.Add(@class);
			return;
		}
		if (stateFormCreate != 1)
		{
			return;
		}
		this.Text = "Редактировать должность";
		base.SelectSqlData(this.class48_0, this.class48_0.tR_JobTitle, true, string.Format("where id = '{0}'", this.int_0));
	}

	private bool method_2()
	{
		if (string.IsNullOrEmpty(this.class48_0.tR_JobTitle[0].Description))
		{
			MessageBox.Show("Введите наименование должности");
			return false;
		}
		return true;
	}

	private bool method_3()
	{
		this.class48_0.tR_JobTitle.Rows[0].EndEdit();
		StateFormCreate stateFormCreate = this.method_0();
		if (stateFormCreate != null)
		{
			if (stateFormCreate == 1)
			{
				if (!base.UpdateSqlDataOnlyChange(this.class48_0.tR_JobTitle))
				{
					return false;
				}
			}
		}
		else if (!base.InsertSqlData(this.class48_0.tR_JobTitle))
		{
			return false;
		}
		return true;
	}

	private void btnOK_Click(object sender, EventArgs e)
	{
		if (!this.method_2())
		{
			return;
		}
		if (!this.method_3())
		{
			MessageBox.Show("Не удалось применить изменения");
		}
		base.Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private int int_0;

	[CompilerGenerated]
	private StateFormCreate stateFormCreate_0;
}
