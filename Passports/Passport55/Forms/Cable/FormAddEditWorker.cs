using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Passport.Forms.Cable
{
	public partial class FormAddEditWorker : Form
	{
		[DefaultValue(-1)]
		public int IdWorker { get; set; }

		public FormAddEditWorker()
		{
			this.InitializeComponent();
		}

		public FormAddEditWorker(DataTable dataTable_0)
		{
			this.InitializeComponent();
			this.Text = "Добавление сотрудника";
			this.method_0(dataTable_0);
		}

		public FormAddEditWorker(DataTable dataTable_0, int int_1)
		{
			this.InitializeComponent();
			this.Text = "Редактирование сотрудника";
			this.method_0(dataTable_0);
			this.cbWorker.SelectedValue = int_1;
			this.IdWorker = int_1;
		}

		private void method_0(DataTable dataTable_0)
		{
			this.cbWorker.DataSource = dataTable_0;
			this.cbWorker.DisplayMember = "FIO";
			this.cbWorker.ValueMember = "id";
		}

		private void cbWorker_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.cbWorker.SelectedValue != null && this.cbWorker.SelectedValue is int)
			{
				this.IdWorker = (int)this.cbWorker.SelectedValue;
			}
		}

		[CompilerGenerated]
		private int int_0;
	}
}
