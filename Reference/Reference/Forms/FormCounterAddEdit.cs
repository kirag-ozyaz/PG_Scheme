﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FormLbr;

namespace Reference.Forms
{
	public partial class FormCounterAddEdit : FormBase
	{
		public FormCounterAddEdit(int id, bool insert)
		{
			
			this.int_0 = -1;
			
			this.InitializeComponent();
			this.int_0 = id;
			this.bool_0 = insert;
			this.Text = (this.bool_0 ? "Добавление счетчика" : "Редактирование счетчика");
		}

		private void FormCounterAddEdit_Load(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				DataRow dataRow = this.class37_0.tR_MarkMeter.NewRow();
				dataRow["Name"] = "NoName";
				dataRow["Digit"] = 5;
				dataRow["Phaze"] = 1;
				dataRow["Voltage"] = 220;
				dataRow["Interval"] = 16;
				dataRow["Precision"] = 1;
				dataRow["TarifCount"] = 1;
				dataRow["Image"] = null;
				dataRow["Deleted"] = false;
				this.class37_0.tR_MarkMeter.Rows.Add(dataRow);
				return;
			}
			base.SelectSqlData(this.class37_0, this.class37_0.tR_MarkMeter, true, " where id = " + this.int_0.ToString());
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.class37_0.tR_MarkMeter.Rows[0].EndEdit();
			bool flag;
			if (this.bool_0)
			{
				flag = base.InsertSqlData(this.class37_0, this.class37_0.tR_MarkMeter);
			}
			else
			{
				flag = base.UpdateSqlData(this.class37_0, this.class37_0.tR_MarkMeter);
			}
			if (flag)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			this.pictureBox.Focus();
			if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.class37_0.tR_MarkMeter.Rows[0]["Image"] = File.ReadAllBytes(this.openFileDialog_0.FileName);
				this.pictureBox.Image = Image.FromFile(this.openFileDialog_0.FileName);
			}
		}

		private int int_0;

		private bool bool_0;
	}
}