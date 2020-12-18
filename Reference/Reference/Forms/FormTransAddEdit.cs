using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FormLbr;

namespace Reference.Forms
{
	public partial class FormTransAddEdit : FormBase
	{
		public FormTransAddEdit(int id, bool insert)
		{
			
			this.int_0 = -1;
			
			this.InitializeComponent();
			this.int_0 = id;
			this.bool_0 = insert;
			this.Text = (this.bool_0 ? "Добавление трансформатора" : "Редактирование трансформатора");
		}

		private void FormTransAddEdit_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class37_0, this.class37_0.tR_Classifier, true, "where parentKey = ';Tansformator;' and isgroup = 0 and deleted = 0 order by name");
			if (this.bool_0)
			{
				DataRow dataRow = this.class37_0.tR_MarkTrans.NewRow();
				dataRow["Name"] = "NoName";
				dataRow["Primary"] = 100;
				dataRow["Secondary"] = 1;
				dataRow["Interval"] = 4;
				dataRow["Precision"] = 1;
				dataRow["TypeTrans"] = this.class37_0.tR_Classifier.Rows[0]["Id"];
				dataRow["Image"] = null;
				dataRow["Deleted"] = false;
				this.class37_0.tR_MarkTrans.Rows.Add(dataRow);
				return;
			}
			base.SelectSqlData(this.class37_0, this.class37_0.tR_MarkTrans, true, " where id = " + this.int_0.ToString());
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.class37_0.tR_MarkTrans.Rows[0].EndEdit();
			bool flag;
			if (this.bool_0)
			{
				flag = base.InsertSqlData(this.class37_0, this.class37_0.tR_MarkTrans);
			}
			else
			{
				flag = base.UpdateSqlData(this.class37_0, this.class37_0.tR_MarkTrans);
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
				this.class37_0.tR_MarkTrans.Rows[0]["Image"] = File.ReadAllBytes(this.openFileDialog_0.FileName);
				this.pictureBox.Image = Image.FromFile(this.openFileDialog_0.FileName);
			}
		}

		private int int_0;

		private bool bool_0;
	}
}
