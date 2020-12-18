using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

namespace Reference.Forms
{
	public partial class FormWorkerGroupAddEdit : FormBase
	{
		public FormWorkerGroupAddEdit(int id, int worker)
		{
			
			this.int_0 = -1;
			this.int_1 = -1;
			this.list_0 = new List<int>();
			this.list_1 = new List<DataRow>();
			
			this.InitializeComponent();
			this.int_0 = id;
			this.int_1 = worker;
			this.Text = (this.bool_0 ? "Добавление группы" : "Редактирование группы");
		}

		public FormWorkerGroupAddEdit(int id, List<int> worker)
		{
			
			this.int_0 = -1;
			this.int_1 = -1;
			this.list_0 = new List<int>();
			this.list_1 = new List<DataRow>();
			
			this.InitializeComponent();
			this.int_0 = id;
			this.list_0 = worker;
			this.Text = (this.bool_0 ? "Добавление группы" : "Редактирование группы");
		}

		private void FormWorkerGroupAddEdit_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Classifier, true, " where parentKey LIKE '%;GRoupWorker;%' and isgroup = 0 order by name");
			if (this.int_1 > -1)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true, " where id = " + this.int_1.ToString());
				this.textBox_0.Text = string.Concat(new string[]
				{
					this.class48_0.tR_Worker.Rows[0]["F"].ToString(),
					" ",
					this.class48_0.tR_Worker.Rows[0]["I"].ToString(),
					" ",
					this.class48_0.tR_Worker.Rows[0]["O"].ToString()
				});
			}
			else if (this.list_0.Count > 0)
			{
				this.textBox_0.Text = "Группа сотрудников";
			}
			if (this.int_0 == -1)
			{
				if (this.list_0.Count > 0)
				{
					using (List<int>.Enumerator enumerator = this.list_0.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							int num = enumerator.Current;
							DataRow dataRow = this.class48_0.tL_ClassifierWorker.NewRow();
							dataRow["IdWorker"] = num;
							dataRow["IdGRoup"] = -1;
							this.class48_0.tL_ClassifierWorker.Rows.Add(dataRow);
							this.list_1.Add(dataRow);
						}
						return;
					}
				}
				DataRow dataRow2 = this.class48_0.tL_ClassifierWorker.NewRow();
				dataRow2["IdWorker"] = this.int_1;
				dataRow2["IdGRoup"] = -1;
				this.class48_0.tL_ClassifierWorker.Rows.Add(dataRow2);
				return;
			}
			base.SelectSqlData(this.class48_0, this.class48_0.tL_ClassifierWorker, true, " where id = " + this.int_0.ToString());
		}

		private void ynbludKlFn_Click(object sender, EventArgs e)
		{
			if (this.comboBoxGroupWorker.SelectedIndex < 0)
			{
				MessageBox.Show("Выберите группу");
				return;
			}
			bool flag = false;
			for (int i = 0; i < this.class48_0.tL_ClassifierWorker.Rows.Count; i++)
			{
				this.class48_0.tL_ClassifierWorker.Rows[i].EndEdit();
			}
			if (this.int_0 == -1)
			{
				flag = base.InsertSqlData(this.class48_0, this.class48_0.tL_ClassifierWorker);
			}
			else if (this.int_1 > -1)
			{
				flag = base.UpdateSqlData(this.class48_0, this.class48_0.tL_ClassifierWorker);
			}
			if (flag)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		private void comboBoxGroupWorker_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.int_0 == -1 && this.list_0.Count > 0)
			{
				foreach (DataRow dataRow in this.list_1)
				{
					dataRow["IdGRoup"] = this.comboBoxGroupWorker.SelectedValue;
				}
			}
		}

		private int int_0;

		private int int_1;

		private List<int> list_0;

		private List<DataRow> list_1;

		private bool bool_0;
	}
}
