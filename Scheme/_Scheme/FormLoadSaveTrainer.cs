using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using FormLbr;

internal partial class FormLoadSaveTrainer : FormBase
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

	internal FormLoadSaveTrainer(bool bool_0)
	{
		Class68.AGd1PxHzk5wxP();
		base..ctor();
		this.InitializeComponent();
		this.method_1(string.Empty);
		SqlConnection connection = new SqlConnection(SqlDataConnect.GetConnectionString(this.SqlSettings));
		SqlDataReader reader = new SqlCommand("select name from tSchm_TrainingSchema", connection).ExecuteReader();
		this.dataTable_0 = new DataTable();
		this.dataTable_0.Load(reader);
		if (bool_0)
		{
			this.panelSave.Visible = false;
			this.comboBox1.DataSource = this.dataTable_0;
			this.comboBox1.DisplayMember = "name";
			this.Text = "Загрузка";
			return;
		}
		this.panelLoad.Visible = false;
		this.Text = "Сохранение";
	}

	private void FormLoadSaveTrainer_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (this.panelLoad.Visible)
		{
			this.method_1(this.comboBox1.Text);
			return;
		}
		this.method_1(this.textBox1.Text);
	}

	private DataTable dataTable_0;

	[CompilerGenerated]
	private string string_0;
}
