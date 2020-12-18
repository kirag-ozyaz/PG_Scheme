using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using FormLbr;

namespace ReferenceWorker
{
	public partial class FormDivisionsAddEdit : FormBase
	{
        private int Id=-1;
        private int ParentId=-1;
        private StateFormCreate stateFormCreate_0;

        internal StateFormCreate method_0()
		{
			return this.stateFormCreate_0;
		}

	
		internal void method_1(StateFormCreate value)
		{
			this.stateFormCreate_0 = value;
		}
		public FormDivisionsAddEdit()
		{
			this.InitializeComponent();
		}

		public FormDivisionsAddEdit(int Id, int ParentId)
		{
			this.InitializeComponent();
			this.Id = Id;
			this.ParentId = ParentId;
		}

		private void FormDivisionsAddEdit_Load(object sender, EventArgs e)
		{
			this.method_2();
			StateFormCreate stateFormCreate = this.method_0();
			if (stateFormCreate == null)
			{
				this.Text = "Добавить подразделение";
                DataSetWorker.tR_DivisionRow row = this.dataSetWorker.tR_Division.NewtR_DivisionRow();
				if (this.ParentId != -1)
				{
					row.ParentID = this.ParentId;
				}
				row.Code = "0000";
				row.Description = "";
				row.Deleted = false;
				row.Flag = 1;
				this.dataSetWorker.tR_Division.Rows.Add(row);
				return;
			}
			if (stateFormCreate != StateFormCreate.Edit)
			{
				return;
			}
			this.Text = "Редактировать подразделение";
			base.SelectSqlData(this.dataSetWorker, this.dataSetWorker.tR_Division, true, "where id = " + this.Id.ToString());
		}

		private void method_2()
		{
			DataTable dataTable = new DataTable("tR_Division");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Description", typeof(string));
			base.SelectSqlData(dataTable, true, string.Format("where deleted = '0' and id != '{0}' order by Description", this.Id), null, false, 0);
			dataTable.Rows.Add(dataTable.NewRow());
			DataView dataView = new DataView(dataTable);
			dataView.Sort = "Description";
			this.cbGroup.DataSource = dataView;
			this.cbGroup.ValueMember = "id";
			this.cbGroup.DisplayMember = "Description";
		}

		private bool method_3()
		{
			if (this.dataSetWorker.tR_Division[0].Description.ToString() == string.Empty)
			{
				MessageBox.Show("Введите наименование подразделения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			return true;
		}

		private bool method_4()
		{
			if (!this.dataSetWorker.tR_Division[0].IsNull("ParentID"))
			{
				this.dataSetWorker.tR_Division[0].ParentCode = this.dataSetWorker.tR_Division[0].ParentID.ToString();
				this.dataSetWorker.tR_Division[0].ParentDescription = this.cbGroup.GetItemText(this.cbGroup.SelectedItem);
			}
			this.dataSetWorker.tR_Division[0].EndEdit();
			if (this.method_0() == null)
			{
				if (!base.InsertSqlData(this.dataSetWorker.tR_Division))
				{
					return false;
				}
			}
			else if (this.method_0() == StateFormCreate.Edit && !base.UpdateSqlDataOnlyChange(this.dataSetWorker.tR_Division))
			{
				return false;
			}
			return true;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (!this.method_3())
			{
				return;
			}
			if (!this.method_4())
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
}
