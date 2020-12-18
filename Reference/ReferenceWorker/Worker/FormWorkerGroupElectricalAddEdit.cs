using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr;
using FormLbr;

namespace ReferenceWorker
{
	public partial class FormWorkerGroupElectricalAddEdit : FormBase
	{
		public FormWorkerGroupElectricalAddEdit(int id, int worker)
		{
			this.InitializeComponent();
			this.Id = id;
			this.IdWorker = worker;
			this.Text = ((id == -1) ? "Добавление группы" : "Редактирование группы");
		}

		private void FormWorkerGroupElectricalAddEdit_Load(object sender, EventArgs e)
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
			if (this.Id == -1)
			{
				base.SelectSqlData(this.dsWorker.tJ_GroupElectricalWorker, true, " where idWorker = " + this.IdWorker.ToString() + " order by DateBegin desc ", null, false, 1);
				if (this.dsWorker.tJ_GroupElectricalWorker.Rows.Count > 0)
				{
					this.dateTimePickerBegin.MinDate = Convert.ToDateTime(this.dsWorker.tJ_GroupElectricalWorker.Rows[0]["DateEnd"]).AddDays(1.0);
				}
				this.dsWorker.tJ_GroupElectricalWorker.Clear();
				DataRow dataRow = this.dsWorker.tJ_GroupElectricalWorker.NewRow();
				dataRow["IdWorker"] = this.IdWorker;
				dataRow["DateBegin"] = ((this.dateTimePickerBegin.MinDate > DateTime.Now.Date) ? this.dateTimePickerBegin.MinDate : DateTime.Now.Date);
				dataRow["GroupElectrical"] = 1;
				this.dsWorker.tJ_GroupElectricalWorker.Rows.Add(dataRow);
				return;
			}
			base.SelectSqlData(this.dsWorker, this.dsWorker.tJ_GroupElectricalWorker, true, " where id = " + this.Id.ToString());
			if (this.dsWorker.tJ_GroupElectricalWorker.Rows.Count > 0)
			{
				this.comboBoxGroup.SelectedIndex = Convert.ToInt32(this.dsWorker.tJ_GroupElectricalWorker.Rows[0]["GroupElectrical"]) - 1;
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
				this.dsWorker.tJ_GroupElectricalWorker.Rows[0]["GRoupElectrical"] = this.comboBoxGroup.SelectedIndex + 1;
				if (this.dateTimePickerBegin.Value == null)
				{
					MessageBox.Show("Не указана дата начала");
					e.Cancel = true;
					return;
				}
				if (this.dsWorker.tJ_GroupElectricalWorker.Rows[0]["DateEnd"] != DBNull.Value)
				{
					this.dsWorker.tJ_GroupElectricalWorker.Rows[0]["DateEnd"] = Convert.ToDateTime(this.dsWorker.tJ_GroupElectricalWorker.Rows[0]["DateEnd"]).Date;
				}
				this.dsWorker.tJ_GroupElectricalWorker.Rows[0].EndEdit();
				bool flag;
				if (this.Id == -1)
				{
					flag = base.InsertSqlData(this.dsWorker, this.dsWorker.tJ_GroupElectricalWorker);
				}
				else
				{
					flag = base.UpdateSqlData(this.dsWorker, this.dsWorker.tJ_GroupElectricalWorker);
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
        private int Id = -1;
        private int IdWorker = -1;
    }
}
