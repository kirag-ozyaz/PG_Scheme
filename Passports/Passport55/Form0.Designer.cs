using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using FormLbr;

internal class Form0 : FormBase
{
	internal Struct0 method_0()
	{
		return this.struct0_0;
	}

	internal Form0(Struct0? nullable_0 = null)
	{
		this.method_3();
		if (nullable_0 != null)
		{
			this.struct0_0 = nullable_0.Value;
		}
		if (nullable_0 == null)
		{
			this.Text = "Новый документ";
			return;
		}
		this.Text = "Редактирование документа";
	}

	private void Form0_Load(object sender, EventArgs e)
	{
		this.method_1();
		if (Struct0.smethod_1(this.struct0_0, Struct0.struct0_0))
		{
			this.comboBox_0.SelectedValue = this.struct0_0.int_0;
			int int_ = this.struct0_0.int_0;
			if (int_ == 891)
			{
				this.comboBox_2.SelectedValue = this.struct0_0.dateTime_0.Year;
				this.comboBox_1.SelectedValue = this.struct0_0.nullable_0;
				return;
			}
			this.textBox_0.Text = this.struct0_0.string_0;
			this.dateTimePicker_0.Value = this.struct0_0.dateTime_0;
		}
	}

	private void method_1()
	{
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		foreach (object obj in Enum.GetValues(typeof(Enum0)))
		{
			Enum0 @enum = (Enum0)obj;
			dataTable.Rows.Add(new object[]
			{
				(int)@enum,
				@enum.smethod_0()
			});
		}
		this.comboBox_0.DisplayMember = "name";
		this.comboBox_0.ValueMember = "id";
		this.comboBox_0.DataSource = dataTable;
		this.comboBox_0.SelectedValue = 891;
	}

	private void comboBox_0_SelectedValueChanged(object sender, EventArgs e)
	{
		if (this.comboBox_0.SelectedValue != null)
		{
			if (this.comboBox_0.SelectedValue != DBNull.Value)
			{
				int num = Convert.ToInt32(this.comboBox_0.SelectedValue);
				if (num != 891)
				{
					this.panel_1.Visible = false;
					this.panel_0.Visible = true;
					return;
				}
				this.panel_1.Visible = true;
				this.panel_0.Visible = false;
				int? num2 = null;
				if (this.comboBox_2.SelectedValue != null && this.comboBox_2.SelectedValue != DBNull.Value)
				{
					num2 = new int?(Convert.ToInt32(this.comboBox_2.SelectedValue));
				}
				DataTable dataSource = new SqlDataCommand(this.SqlSettings).SelectSqlData("select year(dateBegin) as year from tJ_Order group by year(dateBegin)");
				this.comboBox_2.DisplayMember = "year";
				this.comboBox_2.ValueMember = "year";
				this.comboBox_2.DataSource = dataSource;
				if (num2 == null)
				{
					this.comboBox_2.SelectedIndex = -1;
					return;
				}
				this.comboBox_2.SelectedValue = num2;
				return;
			}
		}
		this.panel_1.Visible = false;
		this.panel_0.Visible = true;
	}

	private void comboBox_2_SelectedValueChanged(object sender, EventArgs e)
	{
		if (this.comboBox_2.SelectedValue != null)
		{
			if (this.comboBox_2.SelectedValue != DBNull.Value)
			{
				DataTable dataSource = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select id, cast(num as varchar(10))  + ' от ' + convert( varchar(10), datebegin, 104) as name\r\n                                                            from tJ_Order\r\n                                                            where year(dateBegin) = {0}\r\n                                                            order by num", this.comboBox_2.SelectedValue));
				this.comboBox_1.DisplayMember = "name";
				this.comboBox_1.ValueMember = "id";
				this.comboBox_1.DataSource = dataSource;
				this.comboBox_1.SelectedIndex = -1;
				return;
			}
		}
		this.comboBox_1.DataSource = null;
	}

	private void Form0_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK)
		{
			if (!this.method_2())
			{
				e.Cancel = true;
				return;
			}
			this.struct0_0 = default(Struct0);
			this.struct0_0.int_0 = Convert.ToInt32(this.comboBox_0.SelectedValue);
			int num = Convert.ToInt32(this.comboBox_0.SelectedValue);
			if (num != 891)
			{
				this.struct0_0.dateTime_0 = this.dateTimePicker_0.Value.Date;
				this.struct0_0.string_0 = this.textBox_0.Text;
				return;
			}
			this.struct0_0.nullable_0 = new int?(Convert.ToInt32(this.comboBox_1.SelectedValue));
			DataTable dataTable = new DataTable("tJ_Order");
			dataTable.Columns.Add("num", typeof(int));
			dataTable.Columns.Add("datebegin", typeof(DateTime));
			base.SelectSqlData(dataTable, true, "where id = " + this.struct0_0.nullable_0.ToString(), false);
			if (dataTable.Rows.Count > 0)
			{
				this.struct0_0.string_0 = dataTable.Rows[0]["num"].ToString();
				this.struct0_0.dateTime_0 = Convert.ToDateTime(dataTable.Rows[0]["datebegin"]);
				return;
			}
		}
	}

	private bool method_2()
	{
		if (this.comboBox_0.SelectedValue != null)
		{
			if (this.comboBox_0.SelectedValue != DBNull.Value)
			{
				int num = Convert.ToInt32(this.comboBox_0.SelectedValue);
				if (num == 891)
				{
					if (this.comboBox_1.SelectedValue == null || this.comboBox_1.SelectedValue == DBNull.Value)
					{
						MessageBox.Show("Не выбран номер наряда");
						return false;
					}
				}
				else if (string.IsNullOrEmpty(this.textBox_0.Text))
				{
					MessageBox.Show("Не введен номер документа");
					return false;
				}
				return true;
			}
		}
		MessageBox.Show("Не выбран тип дкоумента");
		return false;
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
		this.comboBox_0 = new ComboBox();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.panel_0 = new Panel();
		this.label_1 = new Label();
		this.dateTimePicker_0 = new DateTimePicker();
		this.textBox_0 = new TextBox();
		this.label_2 = new Label();
		this.panel_1 = new Panel();
		this.label_3 = new Label();
		this.comboBox_1 = new ComboBox();
		this.comboBox_2 = new ComboBox();
		this.label_4 = new Label();
		this.panel_0.SuspendLayout();
		this.panel_1.SuspendLayout();
		base.SuspendLayout();
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(12, 13);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(83, 13);
		this.label_0.TabIndex = 0;
		this.label_0.Text = "Тип документа";
		this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(108, 10);
		this.comboBox_0.Name = "cmbTypeDoc";
		this.comboBox_0.Size = new Size(248, 21);
		this.comboBox_0.TabIndex = 1;
		this.comboBox_0.SelectedValueChanged += this.comboBox_0_SelectedValueChanged;
		this.button_0.DialogResult = DialogResult.OK;
		this.button_0.Location = new Point(15, 108);
		this.button_0.Name = "buttonOK";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 2;
		this.button_0.Text = "ОК";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_1.DialogResult = DialogResult.Cancel;
		this.button_1.Location = new Point(280, 108);
		this.button_1.Name = "buttonCancel";
		this.button_1.Size = new Size(75, 23);
		this.button_1.TabIndex = 3;
		this.button_1.Text = "Отмена";
		this.button_1.UseVisualStyleBackColor = true;
		this.panel_0.Controls.Add(this.label_1);
		this.panel_0.Controls.Add(this.dateTimePicker_0);
		this.panel_0.Controls.Add(this.textBox_0);
		this.panel_0.Controls.Add(this.label_2);
		this.panel_0.Location = new Point(1, 37);
		this.panel_0.Name = "panelOtherDoc";
		this.panel_0.Size = new Size(366, 65);
		this.panel_0.TabIndex = 4;
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(11, 35);
		this.label_1.Name = "label3";
		this.label_1.Size = new Size(90, 13);
		this.label_1.TabIndex = 3;
		this.label_1.Text = "Дата документа";
		this.dateTimePicker_0.Location = new Point(107, 29);
		this.dateTimePicker_0.Name = "dtpDateDocOther";
		this.dateTimePicker_0.Size = new Size(247, 20);
		this.dateTimePicker_0.TabIndex = 2;
		this.textBox_0.Location = new Point(107, 3);
		this.textBox_0.Name = "txtNumDocOther";
		this.textBox_0.Size = new Size(247, 20);
		this.textBox_0.TabIndex = 1;
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(11, 6);
		this.label_2.Name = "label2";
		this.label_2.Size = new Size(75, 13);
		this.label_2.TabIndex = 0;
		this.label_2.Text = "№ документа";
		this.panel_1.Controls.Add(this.label_3);
		this.panel_1.Controls.Add(this.comboBox_1);
		this.panel_1.Controls.Add(this.comboBox_2);
		this.panel_1.Controls.Add(this.label_4);
		this.panel_1.Location = new Point(1, 37);
		this.panel_1.Name = "panelDocOrder";
		this.panel_1.Size = new Size(366, 65);
		this.panel_1.TabIndex = 5;
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(11, 43);
		this.label_3.Name = "label5";
		this.label_3.Size = new Size(75, 13);
		this.label_3.TabIndex = 3;
		this.label_3.Text = "№ документа";
		this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_1.FormattingEnabled = true;
		this.comboBox_1.Location = new Point(107, 35);
		this.comboBox_1.Name = "cmbNumDocOrder";
		this.comboBox_1.Size = new Size(247, 21);
		this.comboBox_1.TabIndex = 2;
		this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_2.FormattingEnabled = true;
		this.comboBox_2.Location = new Point(107, 6);
		this.comboBox_2.Name = "cmbYearDocOrder";
		this.comboBox_2.Size = new Size(248, 21);
		this.comboBox_2.TabIndex = 1;
		this.comboBox_2.SelectedValueChanged += this.comboBox_2_SelectedValueChanged;
		this.label_4.AutoSize = true;
		this.label_4.Location = new Point(11, 9);
		this.label_4.Name = "label4";
		this.label_4.Size = new Size(25, 13);
		this.label_4.TabIndex = 0;
		this.label_4.Text = "Год";
		base.AcceptButton = this.button_0;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = this.button_1;
		base.ClientSize = new Size(367, 143);
		base.Controls.Add(this.panel_1);
		base.Controls.Add(this.panel_0);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.comboBox_0);
		base.Controls.Add(this.label_0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormDocReasonAddEdit";
		this.Text = "FormDocReasonAddEdit";
		base.FormClosing += this.Form0_FormClosing;
		base.Load += this.Form0_Load;
		this.panel_0.ResumeLayout(false);
		this.panel_0.PerformLayout();
		this.panel_1.ResumeLayout(false);
		this.panel_1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private Struct0 struct0_0;

	private IContainer icontainer_0;

	private Label label_0;

	private ComboBox comboBox_0;

	private Button button_0;

	private Button button_1;

	private Panel panel_0;

	private Label label_1;

	private DateTimePicker dateTimePicker_0;

	private TextBox textBox_0;

	private Label label_2;

	private Panel panel_1;

	private Label label_3;

	private ComboBox comboBox_1;

	private ComboBox comboBox_2;

	private Label label_4;
}
