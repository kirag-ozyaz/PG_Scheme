using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr;
using FormLbr;
using Reference.Forms.Worker;

namespace Reference.Forms
{
	public partial class FormWorkerAddEdit : FormBase
	{
		public FormWorkerAddEdit(int idWorker, int idDivision)
		{
			
			this.int_0 = -1;
			this.int_1 = -1;
			this.int_2 = -1;
			
			this.InitializeComponent();
			this.int_0 = idDivision;
			this.int_1 = idWorker;
			this.Text = ((idWorker == -1) ? "Добавление" : "Редактирование");
		}

		private void FormWorkerAddEdit_Load(object sender, EventArgs e)
		{
			this.toolTip_0.SetToolTip(this.ndtpDateEnd, "Удалить дату - клавиша Delete");
			this.toolTip_0.InitialDelay = 800;
			this.method_0();
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Division, true, " order by description ");
			if (this.int_0 != -1)
			{
				this.comboBoxDivision.SelectedValue = this.int_0;
				this.comboBoxDivision.Enabled = false;
			}
			if (this.int_1 == -1)
			{
				Class48.Class61 @class = this.class48_0.tR_Worker.method_5();
				byte[] idrref = new byte[20];
				@class.IDRRef = idrref;
				@class.F = "";
				@class.Birthday = this.dateTimePickerDateBirth.MinDate;
				@class.DateBegin = this.dtpDateBegin.Value;
				@class.Division = this.int_0;
				@class.DivisionCurrent = this.int_0;
				this.class48_0.tR_Worker.Rows.Add(@class);
				return;
			}
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true, " where id = " + this.int_1.ToString());
		}

		private void method_0()
		{
			DataTable dataTable = new DataTable("tR_JobTitle");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Description", typeof(string));
			base.SelectSqlData(dataTable, true, "where deleted = '0' order by Description", null, false, 0);
			this.cbJobTitle.DataSource = dataTable;
			this.cbJobTitle.DisplayMember = "Description";
			this.cbJobTitle.ValueMember = "id";
		}

		private void WeJwNunrSe(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.comboBoxDivision.SelectedIndex < 0)
				{
					MessageBox.Show("Не выбрано подразделение");
					e.Cancel = true;
					return;
				}
				if (string.IsNullOrEmpty(this.textBoxFamily.Text))
				{
					MessageBox.Show("Не введена фамилия сотрудника");
					e.Cancel = true;
					return;
				}
				this.class48_0.tR_Worker.Rows[0].EndEdit();
				bool flag;
				if (this.int_1 == -1)
				{
					flag = base.InsertSqlData(this.class48_0, this.class48_0.tR_Worker);
				}
				else
				{
					flag = base.UpdateSqlData(this.class48_0, this.class48_0.tR_Worker);
				}
				if (!flag)
				{
					e.Cancel = true;
					return;
				}
			}
		}

		private void buttonOrganization_Click(object sender, EventArgs e)
		{
			FormWorkerOrganization formWorkerOrganization = new FormWorkerOrganization();
			formWorkerOrganization.SqlSettings = this.SqlSettings;
			if (formWorkerOrganization.ShowDialog() == DialogResult.OK)
			{
				this.txtOrganization.Text = formWorkerOrganization.NameAbn;
				this.int_2 = formWorkerOrganization.IdAbn;
			}
		}

		private int int_0;

		private int int_1;

		private int int_2;
	}
}
