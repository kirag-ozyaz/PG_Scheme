using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using FormLbr;

namespace Reference.Forms
{
	public partial class FormDivisionsAddEdit : FormBase
	{
		[CompilerGenerated]
		internal StateFormCreate method_0()
		{
			return this.stateFormCreate_0;
		}

		[CompilerGenerated]
		internal void method_1(StateFormCreate value)
		{
			this.stateFormCreate_0 = value;
		}

		public FormDivisionsAddEdit()
		{
			
			this.int_0 = -1;
			this.int_1 = -1;
			
			this.InitializeComponent();
		}

		public FormDivisionsAddEdit(int Id, int ParentId)
		{
			
			this.int_0 = -1;
			this.int_1 = -1;
			
			this.InitializeComponent();
			this.int_0 = Id;
			this.int_1 = ParentId;
		}

		private void FormDivisionsAddEdit_Load(object sender, EventArgs e)
		{
			this.method_2();
			StateFormCreate stateFormCreate = this.method_0();
			if (stateFormCreate == null)
			{
				this.Text = "Добавить подразделение";
				Class48.Class59 @class = this.class48_0.tR_Division.method_4();
				if (this.int_1 != -1)
				{
					@class.ParentID = this.int_1;
				}
				@class.Code = "0000";
				@class.Description = "";
				@class.Deleted = false;
				@class.Flag = 1;
				this.class48_0.tR_Division.Rows.Add(@class);
				return;
			}
			if (stateFormCreate != 1)
			{
				return;
			}
			this.Text = "Редактировать подразделение";
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Division, true, "where id = " + this.int_0.ToString());
		}

		private void method_2()
		{
			DataTable dataTable = new DataTable("tR_Division");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Description", typeof(string));
			base.SelectSqlData(dataTable, true, string.Format("where deleted = '0' and id != '{0}' order by Description", this.int_0), null, false, 0);
			dataTable.Rows.Add(dataTable.NewRow());
			DataView dataView = new DataView(dataTable);
			dataView.Sort = "Description";
			this.cbGroup.DataSource = dataView;
			this.cbGroup.ValueMember = "id";
			this.cbGroup.DisplayMember = "Description";
		}

		private bool method_3()
		{
			if (this.class48_0.tR_Division[0].Description.ToString() == string.Empty)
			{
				MessageBox.Show("Введите наименование подразделения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			return true;
		}

		private bool method_4()
		{
			if (!this.class48_0.tR_Division[0].method_2())
			{
				this.class48_0.tR_Division[0].ParentCode = this.class48_0.tR_Division[0].ParentID.ToString();
				this.class48_0.tR_Division[0].ParentDescription = this.cbGroup.GetItemText(this.cbGroup.SelectedItem);
			}
			this.class48_0.tR_Division[0].EndEdit();
			if (this.method_0() == null)
			{
				if (!base.InsertSqlData(this.class48_0.tR_Division))
				{
					return false;
				}
			}
			else if (this.method_0() == 1 && !base.UpdateSqlDataOnlyChange(this.class48_0.tR_Division))
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

		private int int_0;

		private int int_1;

		[CompilerGenerated]
		private StateFormCreate stateFormCreate_0;
	}
}
