using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FormLbr;

internal class Form2 : FormBase
{
	internal Form2()
	{
		Class90.TDroV38zslI2T();
		base..ctor();
		this.method_6();
	}

	[CompilerGenerated]
	internal bool method_0()
	{
		return this.bool_0;
	}

	[CompilerGenerated]
	internal void method_1(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	internal DateTime method_2()
	{
		return this.dateTimePicker_0.Value;
	}

	internal string method_3()
	{
		return this.comboBox_0.SelectedText;
	}

	internal int method_4()
	{
		int result = -1;
		try
		{
			result = Convert.ToInt32(this.comboBox_0.SelectedValue);
		}
		catch
		{
		}
		return result;
	}

	internal bool method_5()
	{
		return this.checkBox_0.Checked;
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		if (!this.method_0() && this.SqlSettings != null)
		{
			this.Text = "Вывод кабеля из эксплуатации";
			DataTable dataSource = base.SelectSqlData("tP_ValueLists", false, "where ParentKey like ';Cable;Addl;OperReason;' and isGroup = 0");
			this.comboBox_0.DataSource = dataSource;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "id";
			return;
		}
		this.Text = "Ввод кабеля в эксплуатацию";
		this.comboBox_0.Enabled = false;
	}

	protected override void Dispose(bool bool_1)
	{
		if (bool_1 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form2.EmDUl4eWxgqhvtnGP5h(this, bool_1);
	}

	private void method_6()
	{
		this.label_0 = new Label();
		this.label_1 = new Label();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.comboBox_0 = new ComboBox();
		this.dateTimePicker_0 = new DateTimePicker();
		this.checkBox_0 = new CheckBox();
		base.SuspendLayout();
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(12, 18);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(33, 13);
		this.label_0.TabIndex = 0;
		this.label_0.Text = "Дата";
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(12, 41);
		this.label_1.Name = "label2";
		this.label_1.Size = new Size(50, 13);
		this.label_1.TabIndex = 0;
		this.label_1.Text = "Причина";
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_0.DialogResult = DialogResult.Cancel;
		this.button_0.Location = new Point(197, 90);
		this.button_0.Name = "buttonCancel";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 1;
		this.button_0.Text = "Отмена";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_1.DialogResult = DialogResult.OK;
		this.button_1.Location = new Point(116, 90);
		this.button_1.Name = "buttonOK";
		this.button_1.Size = new Size(75, 23);
		this.button_1.TabIndex = 1;
		this.button_1.Text = "ОК";
		this.button_1.UseVisualStyleBackColor = true;
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(72, 38);
		this.comboBox_0.Name = "comboBoxReason";
		this.comboBox_0.Size = new Size(200, 21);
		this.comboBox_0.TabIndex = 2;
		this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm";
		this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
		this.dateTimePicker_0.Location = new Point(72, 12);
		this.dateTimePicker_0.Name = "dateTimePickerInstalAtr";
		this.dateTimePicker_0.Size = new Size(200, 20);
		this.dateTimePicker_0.TabIndex = 3;
		this.checkBox_0.AutoSize = true;
		this.checkBox_0.Location = new Point(15, 65);
		this.checkBox_0.Name = "checkBoxDoNotMark";
		this.checkBox_0.Size = new Size(145, 17);
		this.checkBox_0.TabIndex = 4;
		this.checkBox_0.Text = "Не отмечать в журнале";
		this.checkBox_0.UseVisualStyleBackColor = true;
		base.AcceptButton = this.button_1;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = this.button_0;
		base.ClientSize = new Size(284, 125);
		base.Controls.Add(this.checkBox_0);
		base.Controls.Add(this.dateTimePicker_0);
		base.Controls.Add(this.comboBox_0);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.label_1);
		base.Controls.Add(this.label_0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormDamageToolProperty";
		base.StartPosition = FormStartPosition.Manual;
		this.Text = "Вывод кабеля из эксплуатации";
		base.Load += this.Form2_Load;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	internal static void EmDUl4eWxgqhvtnGP5h(Form form_0, bool bool_1)
	{
		form_0.Dispose(bool_1);
	}

	[CompilerGenerated]
	private bool bool_0;

	private IContainer icontainer_0;

	private Label label_0;

	private Label label_1;

	private Button button_0;

	private Button button_1;

	private ComboBox comboBox_0;

	private DateTimePicker dateTimePicker_0;

	private CheckBox checkBox_0;
}
