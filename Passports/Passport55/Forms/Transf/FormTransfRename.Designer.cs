using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Passport.DataSets;

namespace Passport.Forms.Transf
{
	public class FormTransfRename : FormBase
	{
		public int Id
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public FormTransfRename()
		{
			this.method_0();
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tSchm_ObjList, true, "WHERE id = " + this.int_0.ToString());
			this.textBox_0.Text = this.dsPassport_0.tSchm_ObjList.Rows[0]["Name"].ToString();
		}

		public FormTransfRename(SQLSettings settings, int int_1)
		{
			this.method_0();
			this.SqlSettings = settings;
			this.int_0 = int_1;
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tSchm_ObjList, true, "WHERE id = " + this.int_0.ToString());
			this.textBox_0.Text = this.dsPassport_0.tSchm_ObjList.Rows[0]["Name"].ToString();
		}

		private void FormTransfRename_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				this.dsPassport_0.tSchm_ObjList.Rows[0]["Name"] = this.textBox_0.Text;
				if (!base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tSchm_ObjList))
				{
					e.Cancel = true;
					return;
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_0()
		{
			this.label_0 = new Label();
			this.textBox_0 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 15);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(83, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Наименование";
			this.textBox_0.Location = new Point(101, 12);
			this.textBox_0.Name = "tbName";
			this.textBox_0.Size = new Size(220, 20);
			this.textBox_0.TabIndex = 1;
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Location = new Point(148, 48);
			this.button_0.Name = "btnAccept";
			this.button_0.Size = new Size(92, 23);
			this.button_0.TabIndex = 2;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(246, 48);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 3;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(333, 81);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_0);
			base.Name = "FormTransfRename";
			this.Text = "Переименование";
			base.FormClosing += this.FormTransfRename_FormClosing;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private int int_0;

		private dsPassport dsPassport_0 = new dsPassport();

		private IContainer icontainer_0;

		private Label label_0;

		private TextBox textBox_0;

		private Button button_0;

		private Button button_1;
	}
}
