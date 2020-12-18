using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Passport.DataSets;

namespace Passport.Forms
{
	public class FormRegistrAddEditRepair : FormBase
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

		public StateFormCreate State
		{
			get
			{
				return this.stateFormCreate_0;
			}
			set
			{
				this.stateFormCreate_0 = value;
			}
		}

		public FormRegistrAddEditRepair()
		{
			this.method_2();
		}

		public FormRegistrAddEditRepair(SQLSettings settings, int int_1, StateFormCreate state)
		{
			this.method_2();
			this.SqlSettings = settings;
			this.int_0 = int_1;
			this.stateFormCreate_0 = state;
		}

		private void method_0()
		{
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_DocList, true, "WHERE Id = " + this.int_0.ToString());
			this.class53_0 = (dsPassport.Class53)this.dsPassport_0.tP_DocList.Rows[0];
			this.textBox_0.SelectedText = this.class53_0.Comment;
			this.dateTimePicker_0.Value = this.class53_0.method_4();
		}

		private void method_1()
		{
			StateFormCreate stateFormCreate = this.stateFormCreate_0;
			if (stateFormCreate == null)
			{
				dsPassport.Class53 @class = this.dsPassport_0.tP_DocList.method_5();
				@class.method_1(-1);
				@class.method_3(this.int_0);
				@class.method_5(this.dateTimePicker_0.Value);
				@class.Comment = this.textBox_0.Text;
				@class.method_11(961);
				@class.method_13(true);
				@class.method_15(false);
				this.dsPassport_0.tP_DocList.method_0(@class);
				this.int_0 = base.InsertSqlDataOneRow(this.dsPassport_0, this.dsPassport_0.tP_DocList);
				return;
			}
			if (stateFormCreate != 1)
			{
				return;
			}
			this.class53_0.method_5(this.dateTimePicker_0.Value);
			this.class53_0.Comment = this.textBox_0.Text;
			base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_DocList);
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			this.method_1();
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		private void FormRegistrAddEditRepair_Shown(object sender, EventArgs e)
		{
			if (this.stateFormCreate_0 == 1)
			{
				this.method_0();
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

		private void method_2()
		{
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dsPassport_0 = new dsPassport();
			this.textBox_0 = new TextBox();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(15, 21);
			this.label_0.Name = "lbDate";
			this.label_0.Size = new Size(36, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Дата ";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(15, 46);
			this.label_1.Name = "lbWork";
			this.label_1.Size = new Size(43, 13);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "Работа";
			this.dateTimePicker_0.Location = new Point(109, 17);
			this.dateTimePicker_0.Name = "dtpDate";
			this.dateTimePicker_0.Size = new Size(200, 20);
			this.dateTimePicker_0.TabIndex = 5;
			this.button_0.Location = new Point(119, 82);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(92, 23);
			this.button_0.TabIndex = 9;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(232, 82);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 10;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.textBox_0.Location = new Point(109, 43);
			this.textBox_0.Name = "tbWork";
			this.textBox_0.Size = new Size(200, 20);
			this.textBox_0.TabIndex = 11;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(324, 118);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.dateTimePicker_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			this.MaximumSize = new Size(340, 156);
			this.MinimumSize = new Size(340, 156);
			base.Name = "FormRegistrAddEditRepair";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Ремонт";
			base.Shown += this.FormRegistrAddEditRepair_Shown;
			((ISupportInitialize)this.dsPassport_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private int int_0;

		private StateFormCreate stateFormCreate_0;

		private dsPassport.Class53 class53_0;

		private IContainer icontainer_0;

		private Label label_0;

		private Label label_1;

		private DateTimePicker dateTimePicker_0;

		private Button button_0;

		private Button button_1;

		private dsPassport dsPassport_0;

		private TextBox textBox_0;
	}
}
