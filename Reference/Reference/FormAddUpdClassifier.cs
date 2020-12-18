using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

internal partial class FormAddUpdClassifier : FormBase
{
	internal FormAddUpdClassifier(int int_2, int int_3, bool bool_2, bool bool_3)
	{
		
		this.int_0 = -1;
		this.string_0 = "";
		this.int_1 = -1;
		
		this.InitializeComponent();
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.bool_0 = bool_3;
		this.bool_1 = bool_2;
		this.Text = (this.bool_0 ? (this.bool_1 ? "Добавление новой группы" : "Добавление нового элемента") : (this.bool_1 ? "Редактирование группы" : "Редактирование элемента"));
	}

	private void FormAddUpdClassifier_Load(object sender, EventArgs e)
	{
		this.method_0();
		this.method_1();
	}

	private void method_0()
	{
		if (this.int_0 < 0)
		{
			this.textBoxParent.Text = "нет родителя";
			return;
		}
		DataTable dataTable = base.SelectSqlData("tR_Classifier", true, "where id = " + this.int_0.ToString());
		if (dataTable.Rows.Count < 0)
		{
			return;
		}
		this.textBoxParent.Text = dataTable.Rows[0]["Name"].ToString();
		this.string_0 = dataTable.Rows[0]["ParentKey"].ToString();
	}

	private void method_1()
	{
		if (this.bool_0)
		{
			DataRow dataRow = this.class48_0.DataTableCollection_0["tR_Classifier"].NewRow();
			dataRow["IsGroup"] = this.bool_1;
			if (!this.bool_1)
			{
				this.textBoxParentKey.Enabled = false;
			}
			if (this.int_0 >= 0)
			{
				dataRow["parentId"] = this.int_0;
			}
			dataRow["Name"] = "";
			dataRow["Deleted"] = false;
			dataRow["ParentKey"] = this.string_0;
			this.class48_0.DataTableCollection_0["tR_Classifier"].Rows.Add(dataRow);
			return;
		}
		base.SelectSqlData(this.class48_0.tR_Classifier, true, "where id = " + this.int_1.ToString(), null, false, 0);
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.textBoxName.Text))
		{
			MessageBox.Show("Введите наименование");
			return;
		}
		decimal num;
		if (!string.IsNullOrEmpty(this.textBoxValue.Text) && !decimal.TryParse(this.textBoxValue.Text, out num))
		{
			MessageBox.Show("Некорректно введено значение");
			return;
		}
		if (!this.GbTjzrnwu9(this.textBoxParentKey.Text))
		{
			MessageBox.Show("Некорректно введено значение ключа");
			return;
		}
		this.class48_0.DataTableCollection_0["tR_Classifier"].Rows[0].EndEdit();
		bool flag;
		if (this.bool_0)
		{
			flag = base.InsertSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"]);
		}
		else
		{
			flag = base.UpdateSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"]);
		}
		if (flag)
		{
			base.DialogResult = DialogResult.OK;
		}
	}

	private bool GbTjzrnwu9(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return false;
		}
		if (string.IsNullOrEmpty(this.string_0) && string_1.IndexOf(";") >= 0)
		{
			return true;
		}
		if (!this.bool_1 && string_1 != this.string_0)
		{
			return false;
		}
		if (string_1.IndexOf(this.string_0) != 0)
		{
			return false;
		}
		if (this.bool_1 && string_1.IndexOf(this.string_0) != 0 && this.bool_0)
		{
			return false;
		}
		if (this.bool_1 && string_1.Length - this.string_0.Length <= 0)
		{
			return false;
		}
		if (this.bool_1)
		{
			string text = string_1.Substring(this.string_0.Length, string_1.Length - this.string_0.Length);
			if (text.IndexOf(";") != text.Length - 1)
			{
				return false;
			}
		}
		return true;
	}

	private int int_0;

	private string string_0;

	private int int_1;

	private bool bool_0;

	private bool bool_1;
}
