using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

namespace ReferenceWorker
{
	public partial class FormWorkerGroupAddEdit : FormBase
	{
		public FormWorkerGroupAddEdit(int id, int worker)
		{
			
			this.InitializeComponent();
			this.Id = id;
			this.IdWorker = worker;
			this.Text = (this.isInsert ? "Добавление группы" : "Редактирование группы");
		}

		public FormWorkerGroupAddEdit(int id, List<int> worker)
		{
			this.listWorker = new List<int>();
			this.list = new List<DataRow>();
			
			this.InitializeComponent();
			this.Id = id;
			this.listWorker = worker;
			this.Text = (this.isInsert ? "Добавление группы" : "Редактирование группы");
		}

		private void FormWorkerGroupAddEdit_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dsWorker, this.dsWorker.tR_Classifier, true, " where parentKey LIKE '%;GRoupWorker;%' and isgroup = 0 order by name");
			if (this.IdWorker > -1)
			{
				base.SelectSqlData(this.dsWorker, this.dsWorker.tR_Worker, true, " where id = " + this.IdWorker.ToString());
				this.textBoxFIO.Text = string.Concat(new string[]
				{
					this.dsWorker.tR_Worker.Rows[0]["F"].ToString(),
					" ",
					this.dsWorker.tR_Worker.Rows[0]["I"].ToString(),
					" ",
					this.dsWorker.tR_Worker.Rows[0]["O"].ToString()
				});
			}
			else if (this.listWorker.Count > 0)
			{
				this.textBoxFIO.Text = "Группа сотрудников";
			}
			if (this.Id == -1)
			{
				if (this.listWorker.Count > 0)
				{
					using (var enumerator = this.listWorker.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							int num = enumerator.Current;
							DataRow dataRow = this.dsWorker.tL_ClassifierWorker.NewRow();
							dataRow["IdWorker"] = num;
							dataRow["IdGRoup"] = -1;
							this.dsWorker.tL_ClassifierWorker.Rows.Add(dataRow);
							this.list.Add(dataRow);
						}
						return;
					}
				}
				DataRow dataRow2 = this.dsWorker.tL_ClassifierWorker.NewRow();
				dataRow2["IdWorker"] = this.IdWorker;
				dataRow2["IdGRoup"] = -1;
				this.dsWorker.tL_ClassifierWorker.Rows.Add(dataRow2);
				return;
			}
			base.SelectSqlData(this.dsWorker, this.dsWorker.tL_ClassifierWorker, true, " where id = " + this.Id.ToString());
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (this.comboBoxGroupWorker.SelectedIndex < 0)
			{
				MessageBox.Show("Выберите группу");
				return;
			}
			bool flag = false;
			for (int i = 0; i < this.dsWorker.tL_ClassifierWorker.Rows.Count; i++)
			{
				this.dsWorker.tL_ClassifierWorker.Rows[i].EndEdit();
			}
			if (this.Id == -1)
			{
				flag = base.InsertSqlData(this.dsWorker, this.dsWorker.tL_ClassifierWorker);
			}
			else if (this.IdWorker > -1)
			{
				flag = base.UpdateSqlData(this.dsWorker, this.dsWorker.tL_ClassifierWorker);
			}
			if (flag)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		private void comboBoxGroupWorker_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.Id == -1 && this.listWorker.Count > 0)
			{
				foreach (DataRow dataRow in this.list)
				{
					dataRow["IdGRoup"] = this.comboBoxGroupWorker.SelectedValue;
				}
			}
		}

		private int Id =-1;
		private int IdWorker=-1;
		private List<int> listWorker = new List<int>();
		private List<DataRow> list = new List<DataRow>();
		private bool isInsert = false;
	}
}
