using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using FormLbr;

namespace Passport.Forms.PassportChars
{
	public class FormTypeCharTextToListReplace : FormBase
	{
		public FormTypeCharTextToListReplace(SQLSettings settings)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_1();
			this.SqlSettings = settings;
			base.SelectSqlDataTableOther(this.class107_0, this.class107_0.vP_GetGroupList, "vP_GetValueList", true, "where ParentId is null and isGroup = ((1)) and deleted = ((0)) order by Name");
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "id";
		}

		public int IdGroupValueChar
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

		private void radioButton_0_CheckedChanged(object sender, EventArgs e)
		{
			this.mmxmaTnfWj5.Checked = !this.radioButton_0.Checked;
			this.comboBox_0.Enabled = this.radioButton_0.Checked;
			this.textBox_0.Enabled = this.mmxmaTnfWj5.Checked;
		}

		private void mmxmaTnfWj5_CheckedChanged(object sender, EventArgs e)
		{
			this.radioButton_0.Checked = !this.mmxmaTnfWj5.Checked;
		}

		private int method_0(string string_0)
		{
			Class107.Class272 @class = this.class107_0.tP_ValueLists.method_5();
			@class.Name = string_0;
			@class.isGroup = true;
			@class.Deleted = false;
			this.class107_0.tP_ValueLists.method_0(@class);
			return base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_ValueLists);
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.mmxmaTnfWj5.Checked)
				{
					if (this.textBox_0.Text.Trim().Length == 0)
					{
						MessageBox.Show("Вы не ввели название группы значений характеристики.", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.textBox_0.Focus();
						return;
					}
					this.int_0 = this.method_0(this.textBox_0.Text);
				}
				else
				{
					this.int_0 = (int)this.comboBox_0.SelectedValue;
				}
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
			catch (Exception)
			{
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_1()
		{
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.radioButton_0 = new RadioButton();
			this.mmxmaTnfWj5 = new RadioButton();
			this.comboBox_0 = new ComboBox();
			this.textBox_0 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.label_2 = new Label();
			this.class107_0 = new Class107();
			((ISupportInitialize)this.class107_0).BeginInit();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 18);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(299, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Вы изменили тип характеристики с \"Текст\" на \"Список\".";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 41);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(294, 13);
			this.label_1.TabIndex = 1;
			this.label_1.Text = "Пожалуйста, выберите группу значений характеристики";
			this.radioButton_0.AutoSize = true;
			this.radioButton_0.Location = new Point(15, 87);
			this.radioButton_0.Name = "rbExists";
			this.radioButton_0.Size = new Size(14, 13);
			this.radioButton_0.TabIndex = 2;
			this.radioButton_0.TabStop = true;
			this.radioButton_0.UseVisualStyleBackColor = true;
			this.radioButton_0.CheckedChanged += this.radioButton_0_CheckedChanged;
			this.mmxmaTnfWj5.AutoSize = true;
			this.mmxmaTnfWj5.Location = new Point(15, 114);
			this.mmxmaTnfWj5.Name = "rbNew";
			this.mmxmaTnfWj5.Size = new Size(14, 13);
			this.mmxmaTnfWj5.TabIndex = 3;
			this.mmxmaTnfWj5.TabStop = true;
			this.mmxmaTnfWj5.UseVisualStyleBackColor = true;
			this.mmxmaTnfWj5.CheckedChanged += this.mmxmaTnfWj5_CheckedChanged;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(35, 84);
			this.comboBox_0.Name = "cbTypeList";
			this.comboBox_0.Size = new Size(276, 21);
			this.comboBox_0.TabIndex = 4;
			this.textBox_0.Location = new Point(35, 111);
			this.textBox_0.Name = "tbGroupName";
			this.textBox_0.Size = new Size(276, 20);
			this.textBox_0.TabIndex = 5;
			this.button_0.Location = new Point(126, 147);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(92, 23);
			this.button_0.TabIndex = 6;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(236, 147);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 7;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(12, 59);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(156, 13);
			this.label_2.TabIndex = 8;
			this.label_2.Text = "или введите название новой:";
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(327, 183);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.mmxmaTnfWj5);
			base.Controls.Add(this.radioButton_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Name = "FormTypeCharTextToListReplace";
			((ISupportInitialize)this.class107_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private int int_0;

		private IContainer icontainer_0;

		private Label label_0;

		private Label label_1;

		private RadioButton radioButton_0;

		private RadioButton mmxmaTnfWj5;

		private ComboBox comboBox_0;

		private TextBox textBox_0;

		private Button button_0;

		private Button button_1;

		private Label label_2;

		private Class107 class107_0;
	}
}
