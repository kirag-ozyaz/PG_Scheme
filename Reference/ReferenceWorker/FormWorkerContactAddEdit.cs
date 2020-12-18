using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

namespace Reference.Forms
{
	public partial class FormWorkerContactAddEdit : FormBase
	{
		public FormWorkerContactAddEdit(int id, int worker, bool insert)
		{
			
			this.int_0 = -1;
			this.int_1 = -1;
			
			this.InitializeComponent();
			this.int_0 = id;
			this.bool_0 = insert;
			this.int_1 = worker;
			this.Text = (this.bool_0 ? "Добавление" : "Редактирование");
		}

		private void FormWorkerContactAddEdit_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Classifier, true, " where parentKey = ';Contact;' and isgroup = 0 ");
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true, " where id = " + this.int_1.ToString());
			this.textBox_0.Text = string.Concat(new string[]
			{
				this.class48_0.tR_Worker.Rows[0]["F"].ToString(),
				" ",
				this.class48_0.tR_Worker.Rows[0]["I"].ToString(),
				" ",
				this.class48_0.tR_Worker.Rows[0]["O"].ToString()
			});
			if (this.bool_0)
			{
				DataRow dataRow = this.class48_0.tR_WorkerContact.NewRow();
				dataRow["Worker"] = this.int_1;
				dataRow["KadrExport"] = false;
				dataRow["Description"] = "";
				dataRow["Type"] = this.class48_0.tR_Classifier.Rows[0]["Id"];
				this.class48_0.tR_WorkerContact.Rows.Add(dataRow);
				return;
			}
			base.SelectSqlData(this.class48_0, this.class48_0.tR_WorkerContact, true, " where id = " + this.int_0.ToString());
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.textBoxContact.Text))
			{
				MessageBox.Show("Введите контактную информацию");
				return;
			}
			if (this.comboBoxType.SelectedIndex < 0)
			{
				MessageBox.Show("Выберите тип контакнтой информации");
				return;
			}
			this.class48_0.tR_WorkerContact.Rows[0].EndEdit();
			bool flag;
			if (this.bool_0)
			{
				flag = base.InsertSqlData(this.class48_0, this.class48_0.tR_WorkerContact);
			}
			else
			{
				flag = base.UpdateSqlData(this.class48_0, this.class48_0.tR_WorkerContact);
			}
			if (flag)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		private int int_0;

		private int int_1;

		private bool bool_0;
	}
}
