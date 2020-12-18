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
	public class FormRegistrAddEditBalance : FormBase
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

		public FormRegistrAddEditBalance()
		{
			this.method_3();
		}

		public FormRegistrAddEditBalance(SQLSettings settings, int int_1, StateFormCreate state)
		{
			this.method_3();
			this.SqlSettings = settings;
			this.int_0 = int_1;
			this.stateFormCreate_0 = state;
		}

		private void method_0()
		{
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tAbn, true, "WHERE Deleted = ((0)) AND TypeAbn IN (207, 230, 231, 614, 683)");
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = this.dsPassport_0.tAbn;
			bindingSource.Sort = "Name";
			this.comboBox_0.DataSource = bindingSource;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "Name";
		}

		private void method_1()
		{
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_DocList, true, "WHERE Id = " + this.int_0.ToString());
			this.class53_0 = (dsPassport.Class53)this.dsPassport_0.tP_DocList.Rows[0];
			this.textBox_0.Text = this.class53_0.method_6();
			this.comboBox_0.SelectedText = this.class53_0.Comment;
			this.dateTimePicker_0.Value = this.class53_0.method_4();
			this.textBox_1.Text = this.class53_0.method_8();
		}

		private void method_2()
		{
			StateFormCreate stateFormCreate = this.stateFormCreate_0;
			if (stateFormCreate == null)
			{
				dsPassport.Class53 @class = this.dsPassport_0.tP_DocList.method_5();
				@class.method_1(-1);
				@class.method_3(this.int_0);
				@class.method_5(this.dateTimePicker_0.Value);
				@class.method_7(this.textBox_0.Text);
				@class.Comment = this.comboBox_0.Text;
				@class.method_9(this.textBox_1.Text);
				@class.method_11(960);
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
			this.class53_0.method_7(this.textBox_0.Text);
			this.class53_0.Comment = this.comboBox_0.Text;
			this.class53_0.method_9(this.textBox_1.Text);
			base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_DocList);
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			this.method_2();
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		private void FormRegistrAddEditBalance_Shown(object sender, EventArgs e)
		{
			this.method_0();
			if (this.stateFormCreate_0 == 1)
			{
				this.method_1();
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

		private void method_3()
		{
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.textBox_0 = new TextBox();
			this.comboBox_0 = new ComboBox();
			this.textBox_1 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dsPassport_0 = new dsPassport();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(15, 46);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(78, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Дата приказа";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(15, 19);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(86, 13);
			this.label_1.TabIndex = 1;
			this.label_1.Text = "Номер приказа";
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(15, 71);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(46, 13);
			this.label_2.TabIndex = 2;
			this.label_2.Text = "От кого";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(15, 98);
			this.label_3.Name = "label4";
			this.label_3.Size = new Size(80, 13);
			this.label_3.TabIndex = 3;
			this.label_3.Text = "Оборудование";
			this.dateTimePicker_0.Location = new Point(109, 42);
			this.dateTimePicker_0.Name = "dtpDate";
			this.dateTimePicker_0.Size = new Size(200, 20);
			this.dateTimePicker_0.TabIndex = 5;
			this.textBox_0.Location = new Point(109, 16);
			this.textBox_0.Name = "tbNumberDoc";
			this.textBox_0.Size = new Size(200, 20);
			this.textBox_0.TabIndex = 6;
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(109, 68);
			this.comboBox_0.Name = "cbCompany";
			this.comboBox_0.Size = new Size(200, 21);
			this.comboBox_0.TabIndex = 7;
			this.textBox_1.Location = new Point(109, 95);
			this.textBox_1.Name = "tbEquipment";
			this.textBox_1.Size = new Size(200, 20);
			this.textBox_1.TabIndex = 8;
			this.button_0.Location = new Point(109, 135);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(92, 23);
			this.button_0.TabIndex = 9;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(222, 135);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 10;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(319, 173);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.textBox_1);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.dateTimePicker_0);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.MaximizeBox = false;
			this.MaximumSize = new Size(335, 211);
			base.MinimizeBox = false;
			this.MinimumSize = new Size(335, 211);
			base.Name = "FormRegistrAddEditBalance";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Принятие на баланс";
			base.Shown += this.FormRegistrAddEditBalance_Shown;
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

		private Label label_2;

		private Label label_3;

		private DateTimePicker dateTimePicker_0;

		private TextBox textBox_0;

		private ComboBox comboBox_0;

		private TextBox textBox_1;

		private Button button_0;

		private Button button_1;

		private dsPassport dsPassport_0;
	}
}
