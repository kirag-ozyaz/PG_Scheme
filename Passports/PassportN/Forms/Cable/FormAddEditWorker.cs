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
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.InitializeComponent();
		}

		public FormAddEditWorker(DataTable dt)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.InitializeComponent();
			this.Text = "Добавление сотрудника";
			this.method_0(dt);
		}

		public FormAddEditWorker(DataTable dt, int id)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.InitializeComponent();
			this.Text = "Редактирование сотрудника";
			this.method_0(dt);
			this.cbWorker.SelectedValue = id;
			this.IdWorker = id;
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
