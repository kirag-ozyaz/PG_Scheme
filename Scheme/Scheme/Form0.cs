using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using FormLbr;

internal partial class Form0 : FormBase
{
	[CompilerGenerated]
	internal string method_0()
	{
		return this.string_0;
	}

	[CompilerGenerated]
	internal void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	internal Form0(bool bool_0)
	{
		
		
		this.method_2();
		this.method_1(string.Empty);
		SqlConnection connection = new SqlConnection(SqlDataConnect.GetConnectionString(this.SqlSettings));
		SqlDataReader reader = new SqlCommand("select name from tSchm_TrainingSchema", connection).ExecuteReader();
		this.dataTable_0 = new DataTable();
		this.dataTable_0.Load(reader);
		if (bool_0)
		{
			this.panel_0.Visible = false;
			this.comboBox_0.DataSource = this.dataTable_0;
			this.comboBox_0.DisplayMember = "name";
			this.Text = "Загрузка";
			return;
		}
		this.panel_1.Visible = false;
		this.Text = "Сохранение";
	}

	private void Form0_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (this.panel_1.Visible)
		{
			this.method_1(this.comboBox_0.Text);
			return;
		}
		this.method_1(this.textBox_0.Text);
	}

	private void method_2()
	{
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.panel_0 = new Panel();
		this.label_0 = new Label();
		this.textBox_0 = new TextBox();
		this.panel_1 = new Panel();
		this.label_1 = new Label();
		this.comboBox_0 = new ComboBox();
		this.panel_0.SuspendLayout();
		this.panel_1.SuspendLayout();
		base.SuspendLayout();
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_0.DialogResult = DialogResult.Cancel;
		this.button_0.Location = new Point(197, 51);
		this.button_0.Name = "buttonCancel";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 0;
		this.button_0.Text = "Отмена";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_1.DialogResult = DialogResult.OK;
		this.button_1.Location = new Point(116, 51);
		this.button_1.Name = "buttonOK";
		this.button_1.Size = new Size(75, 23);
		this.button_1.TabIndex = 0;
		this.button_1.Text = "OK";
		this.button_1.UseVisualStyleBackColor = true;
		this.panel_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.panel_0.Controls.Add(this.textBox_0);
		this.panel_0.Controls.Add(this.label_0);
		this.panel_0.Location = new Point(0, 0);
		this.panel_0.Name = "panelSave";
		this.panel_0.Size = new Size(283, 45);
		this.panel_0.TabIndex = 1;
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(11, 15);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(87, 13);
		this.label_0.TabIndex = 0;
		this.label_0.Text = "Имя тренажёра";
		this.textBox_0.Location = new Point(104, 12);
		this.textBox_0.Name = "textBox1";
		this.textBox_0.Size = new Size(167, 20);
		this.textBox_0.TabIndex = 1;
		this.panel_1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.panel_1.Controls.Add(this.comboBox_0);
		this.panel_1.Controls.Add(this.label_1);
		this.panel_1.Location = new Point(0, 0);
		this.panel_1.Name = "panelLoad";
		this.panel_1.Size = new Size(283, 45);
		this.panel_1.TabIndex = 2;
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(11, 15);
		this.label_1.Name = "label2";
		this.label_1.Size = new Size(87, 13);
		this.label_1.TabIndex = 0;
		this.label_1.Text = "Имя тренажёра";
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(104, 12);
		this.comboBox_0.Name = "comboBox1";
		this.comboBox_0.Size = new Size(167, 21);
		this.comboBox_0.TabIndex = 1;
		base.AcceptButton = this.button_1;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = this.button_0;
		base.ClientSize = new Size(284, 86);
		base.Controls.Add(this.panel_1);
		base.Controls.Add(this.panel_0);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormLoadSaveTrainer";
		this.Text = "FormLoadSaveTrainer";
		base.FormClosing += this.Form0_FormClosing;
		this.panel_0.ResumeLayout(false);
		this.panel_0.PerformLayout();
		this.panel_1.ResumeLayout(false);
		this.panel_1.PerformLayout();
		base.ResumeLayout(false);
	}

	private DataTable dataTable_0;

	[CompilerGenerated]
	private string string_0;

	private Button button_0;

	private Button button_1;

	private Panel panel_0;

	private TextBox textBox_0;

	private Label label_0;

	private Panel panel_1;

	private ComboBox comboBox_0;

	private Label label_1;
}
