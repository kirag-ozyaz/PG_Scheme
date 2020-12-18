using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

namespace ReferenceWorker
{
	public partial class FormWorkerContactAddEdit : FormBase
	{
		public FormWorkerContactAddEdit(int id, int worker, bool insert)
		{
			
			
			this.InitializeComponent();
			this.Id = id;
			this.isInsert = insert;
			this.IdWorker = worker;
			this.Text = (this.isInsert ? "Добавление" : "Редактирование");
            
		}

		private void FormWorkerContactAddEdit_Load(object sender, EventArgs e)
		{
            this.buttonOk.Enabled = flgView1;
            base.SelectSqlData(this.dsWorker, this.dsWorker.tR_Classifier, true, " where parentKey = ';Contact;' and isgroup = 0 ");
			base.SelectSqlData(this.dsWorker, this.dsWorker.tR_Worker, true, " where id = " + this.IdWorker.ToString());
			this.txtFIO.Text = string.Concat(new string[]
			{
				this.dsWorker.tR_Worker.Rows[0]["F"].ToString(),
				" ",
				this.dsWorker.tR_Worker.Rows[0]["I"].ToString(),
				" ",
				this.dsWorker.tR_Worker.Rows[0]["O"].ToString()
			});
			if (this.isInsert)
			{
				DataRow dataRow = this.dsWorker.tR_WorkerContact.NewRow();
				dataRow["Worker"] = this.IdWorker;
				dataRow["KadrExport"] = false;
				dataRow["Description"] = "";
				dataRow["Type"] = this.dsWorker.tR_Classifier.Rows[0]["Id"];
				this.dsWorker.tR_WorkerContact.Rows.Add(dataRow);
				return;
			}
			base.SelectSqlData(this.dsWorker, this.dsWorker.tR_WorkerContact, true, " where id = " + this.Id.ToString());
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
			this.dsWorker.tR_WorkerContact.Rows[0].EndEdit();
			bool flag;
			if (this.isInsert)
			{
				flag = base.InsertSqlData(this.dsWorker, this.dsWorker.tR_WorkerContact);
			}
			else
			{
				flag = base.UpdateSqlData(this.dsWorker, this.dsWorker.tR_WorkerContact);
			}
			if (flag)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		private int Id = -1;

		private int IdWorker = -1;

		private bool isInsert;
        private bool flgView1;

        public bool FlgView { set => flgView1 = value; }
    }
}
