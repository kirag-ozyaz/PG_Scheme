using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using FormLbr;
using ReferenceWorker;

internal partial class FormJobTitlesAddEdit : FormBase
{
    private int Id = -1;
    internal StateFormCreate status { get; set; }

    internal FormJobTitlesAddEdit()
	{
		this.InitializeComponent();
	}

	internal FormJobTitlesAddEdit(int id)
	{
		this.InitializeComponent();
		this.Id = id;
	}

	private void FormJobTitlesAddEdit_Load(object sender, EventArgs e)
	{
		StateFormCreate stateFormCreate = this.status;
		if (stateFormCreate ==StateFormCreate.Add)
		{
			this.Text = "Добавить должность";
            DataSetWorker.tR_JobTitleRow ds = this.dsWorker.tR_JobTitle.NewtR_JobTitleRow();
			ds.Deleted = false;
			ds.Description = this.txtName.Text;
			ds.RName = this.txtRating.Text;
			ds.Razrjad = Convert.ToInt32(this.numUpDownRate.Value);
			this.dsWorker.tR_JobTitle.Rows.Add(ds);
			return;
		}
		else if (stateFormCreate != StateFormCreate.Edit)
		{
			return;
		}
		this.Text = "Редактировать должность";
		base.SelectSqlData(this.dsWorker, this.dsWorker.tR_JobTitle, true, string.Format("where id = '{0}'", this.Id));
	}

	private bool CreateName()
	{
		if (string.IsNullOrEmpty(this.dsWorker.tR_JobTitle[0].Description))
		{
			MessageBox.Show("Введите наименование должности");
			return false;
		}
		return true;
	}

	private bool SaveElement()
	{
		this.dsWorker.tR_JobTitle.Rows[0].EndEdit();
		StateFormCreate stateFormCreate = this.status;
	if (stateFormCreate == StateFormCreate.Edit)
			{
				if (!base.UpdateSqlDataOnlyChange(this.dsWorker.tR_JobTitle))
				{
					return false;
				}
			}
		
		else if (!base.InsertSqlData(this.dsWorker.tR_JobTitle))
		{
			return false;
		}
		return true;
	}

	private void btnOK_Click(object sender, EventArgs e)
	{
		if (!this.CreateName())
		{
			return;
		}
		if (!this.SaveElement())
		{
			MessageBox.Show("Не удалось применить изменения");
		}
		base.Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		base.Close();
	}


}
