using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr;
using FormLbr;

namespace Reference.Forms
{
	public partial class FormWorkerGroupElectricalAddEdit : FormBase
	{
		public FormWorkerGroupElectricalAddEdit(int id, int worker)
		{
			
			this.ifeFmvbfgj = -1;
			this.int_0 = -1;
			
			this.InitializeComponent();
			this.ifeFmvbfgj = id;
			this.int_0 = worker;
			this.Text = ((id == -1) ? "Добавление группы" : "Редактирование группы");
		}

		private void FormWorkerGroupElectricalAddEdit_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true, " where id = " + this.int_0.ToString());
			this.textBox_0.Text = string.Concat(new string[]
			{
				this.class48_0.tR_Worker.Rows[0]["F"].ToString(),
				" ",
				this.class48_0.tR_Worker.Rows[0]["I"].ToString(),
				" ",
				this.class48_0.tR_Worker.Rows[0]["O"].ToString()
			});
			if (this.ifeFmvbfgj == -1)
			{
				base.SelectSqlData(this.class48_0.tJ_GroupElectricalWorker, true, " where idWorker = " + this.int_0.ToString() + " order by DateBegin desc ", null, false, 1);
				if (this.class48_0.tJ_GroupElectricalWorker.Rows.Count > 0)
				{
					this.dateTimePickerBegin.MinDate = Convert.ToDateTime(this.class48_0.tJ_GroupElectricalWorker.Rows[0]["DateEnd"]).AddDays(1.0);
				}
				this.class48_0.tJ_GroupElectricalWorker.Clear();
				DataRow dataRow = this.class48_0.tJ_GroupElectricalWorker.NewRow();
				dataRow["IdWorker"] = this.int_0;
				dataRow["DateBegin"] = ((this.dateTimePickerBegin.MinDate > DateTime.Now.Date) ? this.dateTimePickerBegin.MinDate : DateTime.Now.Date);
				dataRow["GroupElectrical"] = 1;
				this.class48_0.tJ_GroupElectricalWorker.Rows.Add(dataRow);
				return;
			}
			base.SelectSqlData(this.class48_0, this.class48_0.tJ_GroupElectricalWorker, true, " where id = " + this.ifeFmvbfgj.ToString());
			if (this.class48_0.tJ_GroupElectricalWorker.Rows.Count > 0)
			{
				this.comboBoxGroup.SelectedIndex = Convert.ToInt32(this.class48_0.tJ_GroupElectricalWorker.Rows[0]["GroupElectrical"]) - 1;
			}
		}

		private void FormWorkerGroupElectricalAddEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.comboBoxGroup.SelectedIndex < 0)
				{
					MessageBox.Show("Не указан группа допуска электробезопасности");
					e.Cancel = true;
					return;
				}
				this.class48_0.tJ_GroupElectricalWorker.Rows[0]["GRoupElectrical"] = this.comboBoxGroup.SelectedIndex + 1;
				if (this.dateTimePickerBegin.Value == null)
				{
					MessageBox.Show("Не указана дата начала");
					e.Cancel = true;
					return;
				}
				if (this.class48_0.tJ_GroupElectricalWorker.Rows[0]["DateEnd"] != DBNull.Value)
				{
					this.class48_0.tJ_GroupElectricalWorker.Rows[0]["DateEnd"] = Convert.ToDateTime(this.class48_0.tJ_GroupElectricalWorker.Rows[0]["DateEnd"]).Date;
				}
				this.class48_0.tJ_GroupElectricalWorker.Rows[0].EndEdit();
				bool flag;
				if (this.ifeFmvbfgj == -1)
				{
					flag = base.InsertSqlData(this.class48_0, this.class48_0.tJ_GroupElectricalWorker);
				}
				else
				{
					flag = base.UpdateSqlData(this.class48_0, this.class48_0.tJ_GroupElectricalWorker);
				}
				if (!flag)
				{
					e.Cancel = true;
					return;
				}
			}
		}

		private void dateTimePickerBegin_ValueChanged(object sender, EventArgs e)
		{
			this.dateTimePickerEnd.MinDate = Convert.ToDateTime(this.dateTimePickerBegin.Value).AddDays(1.0);
		}

		private int ifeFmvbfgj;

		private int int_0;
	}
}
