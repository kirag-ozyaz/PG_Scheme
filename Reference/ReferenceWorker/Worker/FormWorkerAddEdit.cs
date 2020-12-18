using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr;
using FormLbr;

namespace ReferenceWorker
{
	public partial class FormWorkerAddEdit : FormBase
	{
        public FormWorkerAddEdit()
        {
            this.InitializeComponent();
        }
            public FormWorkerAddEdit(int idWorker, int idDivision)
        { 
			this.InitializeComponent();
			this.IdDivision = idDivision;
			this.IdWorker = idWorker;
			this.Text = ((idWorker == -1) ? "Добавление" : "Редактирование");
		}

		private void FormWorkerAddEdit_Load(object sender, EventArgs e)
		{
			this.toolTip_0.SetToolTip(this.ndtpDateEnd, "Удалить дату - клавиша Delete");
			this.toolTip_0.InitialDelay = 800;
			this.FillTableJobTitle();
			base.SelectSqlData(this.dsWorker, this.dsWorker.tR_Division, true, " order by description ");
			if (this.IdDivision != -1)
			{
				this.comboBoxDivision.SelectedValue = this.IdDivision;
				this.comboBoxDivision.Enabled = false;
			}
			if (this.IdWorker == -1)
			{
				ReferenceWorker.DataSetWorker.tR_WorkerRow row = this.dsWorker.tR_Worker.NewtR_WorkerRow();
				byte[] idrref = new byte[20];
				row.IDRRef = idrref;
				row.F = "";
				row.Birthday = this.dateTimePickerDateBirth.MinDate;
				row.DateBegin = this.dtpDateBegin.Value;
				row.Division = this.IdDivision;
				row.DivisionCurrent = this.IdDivision;
				this.dsWorker.tR_Worker.Rows.Add(row);
				return;
			}
			base.SelectSqlData(this.dsWorker, this.dsWorker.tR_Worker, true, " where id = " + this.IdWorker.ToString());
		}

		private void FillTableJobTitle()
		{
			DataTable dataTable = new DataTable("tR_JobTitle");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Description", typeof(string));
			base.SelectSqlData(dataTable, true, "where deleted = '0' order by Description", null, false, 0);
			this.cbJobTitle.DataSource = dataTable;
			this.cbJobTitle.DisplayMember = "Description";
			this.cbJobTitle.ValueMember = "id";
		}

		private void FormWorkerAddEdit_FormClosing(object sender, FormClosingEventArgs e)
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
				this.dsWorker.tR_Worker.Rows[0].EndEdit();
				bool flag = false;
				if (this.IdWorker == -1)
				{
					//flag = base.InsertSqlData(this.dsWorker, this.dsWorker.tR_Worker);
                    IdWorker = this.InsertSqlDataOneRow(this.dsWorker, this.dsWorker.tR_Worker);
                    if (IdWorker != -1) flag = true;
				}
				else
				{
					flag = base.UpdateSqlData(this.dsWorker, this.dsWorker.tR_Worker);
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
				this.IdAbn = formWorkerOrganization.IdAbn;
			}
		}

		private int IdDivision = -1;
        private int IdWorker = -1;
        private int IdAbn = -1;
        public int idPersonalSelect
        {
            get
            {
                return this.IdWorker;
            }
        }
    }
}
