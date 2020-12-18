using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using ControlsLbr;
using DataSql;
using FormLbr;
using Passport.Classes;

internal class Form15 : FormBase
{
	[CompilerGenerated]
	internal int method_0()
	{
		return this.JhZmomoeCoQ;
	}

	[CompilerGenerated]
	internal void method_1(int int_2)
	{
		this.JhZmomoeCoQ = int_2;
	}

	[CompilerGenerated]
	internal int method_2()
	{
		return this.int_0;
	}

	[CompilerGenerated]
	internal void method_3(int int_2)
	{
		this.int_0 = int_2;
	}

	[CompilerGenerated]
	internal int method_4()
	{
		return this.int_1;
	}

	[CompilerGenerated]
	internal void method_5(int int_2)
	{
		this.int_1 = int_2;
	}

	[CompilerGenerated]
	internal StateFormCreate method_6()
	{
		return this.stateFormCreate_0;
	}

	[CompilerGenerated]
	internal void method_7(StateFormCreate stateFormCreate_1)
	{
		this.stateFormCreate_0 = stateFormCreate_1;
	}

	internal Form15()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_10();
	}

	internal Form15(SQLSettings sqlsettings_0, int int_2)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_10();
		this.SqlSettings = sqlsettings_0;
		this.method_1(int_2);
		this.method_7(1);
	}

	internal Form15(SQLSettings sqlsettings_0, int int_2, int int_3)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_10();
		this.SqlSettings = sqlsettings_0;
		this.method_3(int_2);
		this.method_5(int_3);
		this.method_7(0);
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	private void textBox_1_KeyPress(object sender, KeyPressEventArgs e)
	{
		InputCheck.OnlyDigit(sender, e);
	}

	private void Form15_Load(object sender, EventArgs e)
	{
		this.Text = ((this.method_6() == null) ? "Добавление" : "Редактирование");
		if (this.method_6() == null)
		{
			this.method_8();
		}
		else
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_EESConnectPower, true, "where id = " + this.method_0().ToString());
			this.method_3(this.class107_0.tP_EESConnectPower.First<Class107.Class282>().idSubstation);
			this.method_5(this.class107_0.tP_EESConnectPower.First<Class107.Class282>().idTransf);
		}
		if (this.method_2() != -1)
		{
			DataTable dataTable = base.SelectSqlData("tSchm_ObjList", true, "WHERE id = " + this.method_4().ToString());
			int int_;
			if (dataTable.Rows.Count > 0)
			{
				if (dataTable.Rows[0]["idParentAddl"] != DBNull.Value)
				{
					int_ = (int)dataTable.Rows[0]["idParentAddl"];
					goto IL_10B;
				}
			}
			int_ = -1;
			IL_10B:
			this.method_3(int_);
		}
		base.SelectSqlData(this.class107_0, this.class107_0.vP_SubstationTransf, true, (this.method_2() != -1) ? ("where idParent = " + this.method_2().ToString()) : ("where id = " + this.method_4().ToString()));
		this.SmSmotOejiL.Position = this.SmSmotOejiL.Find("Id", this.method_4());
	}

	private void method_8()
	{
		Class107.Class282 @class = this.class107_0.tP_EESConnectPower.method_5();
		@class.idSubstation = this.method_2();
		@class.idTransf = this.method_4();
		@class.Deleted = false;
		this.class107_0.tP_EESConnectPower.method_0(@class);
	}

	private bool method_9()
	{
		this.bindingSource_0.EndEdit();
		if (this.method_6() == null)
		{
			this.method_1(base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_EESConnectPower));
			return this.method_0() > 0;
		}
		return base.UpdateSqlData(this.class107_0, this.class107_0.tP_EESConnectPower);
	}

	private void Form15_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK && !this.method_9())
		{
			e.Cancel = false;
			base.DialogResult = DialogResult.Cancel;
			MessageBox.Show("Сохранение.", "Ошибка при сохранении данных.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form15.mhxtgd90DIkhHNnlA9tY(this, bool_0);
	}

	private void method_10()
	{
		this.icontainer_0 = new Container();
		this.class107_0 = new Class107();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.SmSmotOejiL = new BindingSource(this.icontainer_0);
		this.comboBox_0 = new ComboBox();
		this.label_0 = new Label();
		this.textBox_0 = new TextBox();
		this.label_1 = new Label();
		this.nullableDateTimePicker_0 = new NullableDateTimePicker();
		this.nullableDateTimePicker_1 = new NullableDateTimePicker();
		this.label_2 = new Label();
		this.label_3 = new Label();
		this.textBox_1 = new TextBox();
		this.label_4 = new Label();
		this.tableLayoutPanel_0 = new TableLayoutPanel();
		this.button_0 = new Button();
		this.button_1 = new Button();
		((ISupportInitialize)this.class107_0).BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		((ISupportInitialize)this.SmSmotOejiL).BeginInit();
		this.tableLayoutPanel_0.SuspendLayout();
		base.SuspendLayout();
		this.class107_0.DataSetName = "dsPassport";
		this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.bindingSource_0.DataMember = "tP_EESConnectPower";
		this.bindingSource_0.DataSource = this.class107_0;
		this.SmSmotOejiL.DataMember = "vP_SubstationTransf";
		this.SmSmotOejiL.DataSource = this.class107_0;
		this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "idTransf", true));
		this.comboBox_0.DataSource = this.SmSmotOejiL;
		this.comboBox_0.DisplayMember = "Name";
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(114, 6);
		this.comboBox_0.Name = "cbTransf";
		this.comboBox_0.Size = new Size(224, 21);
		this.comboBox_0.TabIndex = 0;
		this.comboBox_0.ValueMember = "Id";
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(12, 9);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(89, 13);
		this.label_0.TabIndex = 1;
		this.label_0.Text = "Трансформатор";
		this.textBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Dogovor", true));
		this.textBox_0.Location = new Point(114, 33);
		this.textBox_0.Name = "tbNumDoc";
		this.textBox_0.Size = new Size(224, 20);
		this.textBox_0.TabIndex = 2;
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(12, 36);
		this.label_1.Name = "label2";
		this.label_1.Size = new Size(91, 13);
		this.label_1.TabIndex = 3;
		this.label_1.Text = "Номер договора";
		this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.bindingSource_0, "dateBegin", true));
		this.nullableDateTimePicker_0.Location = new Point(169, 59);
		this.nullableDateTimePicker_0.Name = "dtpDateBegin";
		this.nullableDateTimePicker_0.Size = new Size(169, 20);
		this.nullableDateTimePicker_0.TabIndex = 4;
		this.nullableDateTimePicker_0.Value = new DateTime(2013, 11, 5, 11, 16, 17, 609);
		this.nullableDateTimePicker_1.DataBindings.Add(new Binding("Value", this.bindingSource_0, "dateEnd", true));
		this.nullableDateTimePicker_1.Location = new Point(169, 85);
		this.nullableDateTimePicker_1.Name = "dtpDateEnd";
		this.nullableDateTimePicker_1.Size = new Size(169, 20);
		this.nullableDateTimePicker_1.TabIndex = 5;
		this.nullableDateTimePicker_1.Value = new DateTime(2013, 11, 5, 11, 16, 18, 987);
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(12, 62);
		this.label_2.Name = "label3";
		this.label_2.Size = new Size(147, 13);
		this.label_2.TabIndex = 6;
		this.label_2.Text = "Дата заключения договора";
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(12, 88);
		this.label_3.Name = "label4";
		this.label_3.Size = new Size(139, 13);
		this.label_3.TabIndex = 7;
		this.label_3.Text = "Дата окончания договора";
		this.textBox_1.DataBindings.Add(new Binding("Text", this.bindingSource_0, "MaxPower", true));
		this.textBox_1.Location = new Point(282, 111);
		this.textBox_1.Name = "tbPower";
		this.textBox_1.Size = new Size(56, 20);
		this.textBox_1.TabIndex = 8;
		this.textBox_1.KeyPress += this.textBox_1_KeyPress;
		this.label_4.AutoSize = true;
		this.label_4.Location = new Point(12, 114);
		this.label_4.Name = "label5";
		this.label_4.Size = new Size(264, 13);
		this.label_4.TabIndex = 9;
		this.label_4.Text = "Максимальная мощность согласно договору, кВА";
		this.tableLayoutPanel_0.ColumnCount = 2;
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108f));
		this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 0);
		this.tableLayoutPanel_0.Controls.Add(this.button_1, 0, 0);
		this.tableLayoutPanel_0.Dock = DockStyle.Bottom;
		this.tableLayoutPanel_0.Location = new Point(0, 143);
		this.tableLayoutPanel_0.Name = "tableLayoutPanel2";
		this.tableLayoutPanel_0.RowCount = 1;
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_0.Size = new Size(350, 33);
		this.tableLayoutPanel_0.TabIndex = 20;
		this.button_0.DialogResult = DialogResult.Cancel;
		this.button_0.Dock = DockStyle.Left;
		this.button_0.Location = new Point(252, 3);
		this.button_0.Margin = new Padding(10, 3, 3, 3);
		this.button_0.Name = "btnCancel";
		this.button_0.Size = new Size(75, 27);
		this.button_0.TabIndex = 6;
		this.button_0.Text = "Отмена";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_0_Click;
		this.button_1.DialogResult = DialogResult.OK;
		this.button_1.Dock = DockStyle.Right;
		this.button_1.Location = new Point(133, 3);
		this.button_1.Margin = new Padding(3, 3, 10, 3);
		this.button_1.Name = "btnAccept";
		this.button_1.Size = new Size(99, 27);
		this.button_1.TabIndex = 8;
		this.button_1.Text = "Применить";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(350, 176);
		base.Controls.Add(this.tableLayoutPanel_0);
		base.Controls.Add(this.label_4);
		base.Controls.Add(this.textBox_1);
		base.Controls.Add(this.label_3);
		base.Controls.Add(this.label_2);
		base.Controls.Add(this.nullableDateTimePicker_1);
		base.Controls.Add(this.nullableDateTimePicker_0);
		base.Controls.Add(this.label_1);
		base.Controls.Add(this.textBox_0);
		base.Controls.Add(this.label_0);
		base.Controls.Add(this.comboBox_0);
		base.Name = "FormTehConnectAddEdit";
		this.Text = "FormTehConnectAddEdit";
		base.FormClosing += this.Form15_FormClosing;
		base.Load += this.Form15_Load;
		((ISupportInitialize)this.class107_0).EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		((ISupportInitialize)this.SmSmotOejiL).EndInit();
		this.tableLayoutPanel_0.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	internal static void mhxtgd90DIkhHNnlA9tY(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	[CompilerGenerated]
	private int JhZmomoeCoQ;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private StateFormCreate stateFormCreate_0;

	private IContainer icontainer_0;

	private Class107 class107_0;

	private BindingSource bindingSource_0;

	private BindingSource SmSmotOejiL;

	private ComboBox comboBox_0;

	private Label label_0;

	private TextBox textBox_0;

	private Label label_1;

	private NullableDateTimePicker nullableDateTimePicker_0;

	private NullableDateTimePicker nullableDateTimePicker_1;

	private Label label_2;

	private Label label_3;

	private TextBox textBox_1;

	private Label label_4;

	private TableLayoutPanel tableLayoutPanel_0;

	private Button button_0;

	private Button button_1;
}
