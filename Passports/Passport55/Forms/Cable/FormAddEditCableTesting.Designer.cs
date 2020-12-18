using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Passport.Classes;
using Passport.DataSets;

namespace Passport.Forms.Cable
{
	public class FormAddEditCableTesting : FormBase
	{
		public int IdCable
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		public int IdCabtesting
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

		public FormAddEditCableTesting(SQLSettings settings, int int_3, StateFormCreate state)
		{
			this.method_2();
			this.SqlSettings = settings;
			this.stateFormCreate_0 = state;
			if (state != null)
			{
				if (state == 1)
				{
					this.int_0 = int_3;
					this.Text = "Редактирование испытания кабеля";
					base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabTesting, true, string.Format("WHERE id = {0} AND Deleted = ((0))", this.int_0));
					base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_ValueLists, true, string.Format("WHERE ParentId = {0} AND Deleted = ((0))", 389));
				}
			}
			else
			{
				this.int_1 = int_3;
				this.Text = "Добавление испытания кабеля";
				this.dsPassport_0.tP_CabTesting.method_0(this.dsPassport_0.tP_CabTesting.method_5());
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_ValueLists, true, string.Format("WHERE ParentId = {0} AND Deleted = ((0))", 389));
			}
			this.int_2 = Class110.smethod_0(this.SqlSettings, base.Name);
		}

		private void FormAddEditCableTesting_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.stateFormCreate_0 == null && !this.method_0())
				{
					e.Cancel = true;
					return;
				}
				if (this.stateFormCreate_0 == 1 && !this.method_1())
				{
					e.Cancel = true;
					return;
				}
				Class110.smethod_2(this.SqlSettings, this.int_2, this.stateFormCreate_0);
			}
			Class110.smethod_1(this.SqlSettings, this.int_2);
		}

		private bool method_0()
		{
			this.dsPassport_0.tP_CabTesting.Rows[0]["idObjList"] = this.int_1;
			this.dsPassport_0.tP_CabTesting.Rows[0]["Deleted"] = false;
			this.dsPassport_0.tP_CabTesting.Rows[0].EndEdit();
			this.int_0 = base.InsertSqlDataOneRow(this.dsPassport_0, this.dsPassport_0.tP_CabTesting);
			return this.int_0 > 0;
		}

		private bool method_1()
		{
			this.dsPassport_0.tP_CabTesting.Rows[0].EndEdit();
			return base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabTesting);
		}

		private void textBox_1_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputCheck.OnlyDigit(sender, e);
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
			this.icontainer_0 = new Container();
			this.dateTimePicker_0 = new DateTimePicker();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dsPassport_0 = new dsPassport();
			this.comboBox_0 = new ComboBox();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.textBox_0 = new TextBox();
			this.textBox_1 = new TextBox();
			this.textBox_2 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.label_4 = new Label();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			base.SuspendLayout();
			this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.bindingSource_0, "Date", true));
			this.dateTimePicker_0.Format = DateTimePickerFormat.Short;
			this.dateTimePicker_0.Location = new Point(156, 9);
			this.dateTimePicker_0.Name = "dtpDate";
			this.dateTimePicker_0.Size = new Size(196, 20);
			this.dateTimePicker_0.TabIndex = 0;
			this.bindingSource_0.DataMember = "tP_CabTesting";
			this.bindingSource_0.DataSource = this.dsPassport_0;
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "Reason", true));
			this.comboBox_0.DataSource = this.bindingSource_1;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(156, 35);
			this.comboBox_0.Name = "cbReason";
			this.comboBox_0.Size = new Size(196, 21);
			this.comboBox_0.TabIndex = 1;
			this.comboBox_0.ValueMember = "id";
			this.bindingSource_1.DataMember = "tP_ValueLists";
			this.bindingSource_1.DataSource = this.dsPassport_0;
			this.textBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Voltage", true));
			this.textBox_0.Location = new Point(156, 62);
			this.textBox_0.Name = "tbVoltage";
			this.textBox_0.Size = new Size(196, 20);
			this.textBox_0.TabIndex = 2;
			this.textBox_0.KeyPress += this.textBox_1_KeyPress;
			this.textBox_1.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Duration", true));
			this.textBox_1.Location = new Point(156, 88);
			this.textBox_1.Name = "tbDuration";
			this.textBox_1.Size = new Size(196, 20);
			this.textBox_1.TabIndex = 3;
			this.textBox_1.KeyPress += this.textBox_1_KeyPress;
			this.textBox_2.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Conclusion", true));
			this.textBox_2.Location = new Point(156, 114);
			this.textBox_2.Name = "textBox3";
			this.textBox_2.Size = new Size(196, 20);
			this.textBox_2.TabIndex = 4;
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Location = new Point(157, 154);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(104, 23);
			this.button_0.TabIndex = 5;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(267, 154);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 6;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(15, 12);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(33, 13);
			this.label_0.TabIndex = 7;
			this.label_0.Text = "Дата";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(13, 38);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(50, 13);
			this.label_1.TabIndex = 8;
			this.label_1.Text = "Причина";
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(13, 65);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(71, 13);
			this.label_2.TabIndex = 9;
			this.label_2.Text = "Напряжение";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(13, 91);
			this.label_3.Name = "label4";
			this.label_3.Size = new Size(137, 13);
			this.label_3.TabIndex = 10;
			this.label_3.Text = "Продолжительность мин.";
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(13, 117);
			this.label_4.Name = "label5";
			this.label_4.Size = new Size(69, 13);
			this.label_4.TabIndex = 11;
			this.label_4.Text = "Заключение";
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(364, 189);
			base.Controls.Add(this.label_4);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.textBox_2);
			base.Controls.Add(this.textBox_1);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.dateTimePicker_0);
			this.MaximumSize = new Size(380, 227);
			this.MinimumSize = new Size(380, 227);
			base.Name = "FormAddEditCableTesting";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "FormAddEditCableTesting";
			base.FormClosing += this.FormAddEditCableTesting_FormClosing;
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dsPassport_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private int int_0;

		private int int_1;

		private int int_2;

		private StateFormCreate stateFormCreate_0;

		private IContainer icontainer_0;

		private DateTimePicker dateTimePicker_0;

		private ComboBox comboBox_0;

		private TextBox textBox_0;

		private TextBox textBox_1;

		private TextBox textBox_2;

		private Button button_0;

		private Button button_1;

		private Label label_0;

		private Label label_1;

		private Label label_2;

		private Label label_3;

		private Label label_4;

		private BindingSource bindingSource_0;

		private dsPassport dsPassport_0;

		private BindingSource bindingSource_1;
	}
}
