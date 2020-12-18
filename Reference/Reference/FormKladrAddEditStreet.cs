using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

internal partial class FormKladrAddEditStreet : FormBase
{
	internal FormKladrAddEditStreet(int int_2, int int_3)
	{
		
		this.int_0 = -1;
		this.int_1 = -1;
		
		this.InitializeComponent();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.Text = ((this.int_0 == -1) ? "Добавление улицы" : "Редактирование улицы");
	}

	private void FormKladrAddEditStreet_Load(object sender, EventArgs e)
	{
		base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_KladrObj"], true, "order by name, socr");
		base.SelectSqlData(this.class20_0, this.class20_0.tR_KladrSocr, true, "where level = 5  order by scname");
		if (this.int_0 == -1)
		{
			DataRow dataRow = this.class20_0.tR_KladrStreet.NewRow();
			dataRow["KladrObjId"] = this.int_1;
			dataRow["Deleted"] = false;
			this.class20_0.tR_KladrStreet.Rows.Add(dataRow);
			return;
		}
		base.SelectSqlData(this.class20_0, this.class20_0.tR_KladrStreet, true, " where id = " + this.int_0.ToString());
	}

	private void buttonOk_Click(object sender, EventArgs e)
	{
		if (this.comboBoxKladrObj.SelectedIndex < 0)
		{
			MessageBox.Show("Не выбран населенный пункт, к котораму принадлежит улица");
			return;
		}
		if (string.IsNullOrEmpty(this.textBoxName.Text))
		{
			MessageBox.Show("Наименование не может быть пустым");
			return;
		}
		if (this.comboBoxPrefix.SelectedIndex < 0)
		{
			this.class20_0.tR_KladrStreet.Rows[0]["Socr"] = DBNull.Value;
		}
		if (string.IsNullOrEmpty(this.textBoxKladrCode.Text))
		{
			this.class20_0.tR_KladrStreet.Rows[0]["KladrCode"] = DBNull.Value;
		}
		if (string.IsNullOrEmpty(this.textBoxIndex.Text))
		{
			this.class20_0.tR_KladrStreet.Rows[0]["Index"] = DBNull.Value;
		}
		if (string.IsNullOrEmpty(this.textBoxGninmb.Text))
		{
			this.class20_0.tR_KladrStreet.Rows[0]["Gninmb"] = DBNull.Value;
		}
		this.class20_0.tR_KladrStreet.Rows[0].EndEdit();
		bool flag;
		if (this.int_0 == -1)
		{
			flag = base.InsertSqlData(this.class20_0, this.class20_0.tR_KladrStreet);
		}
		else
		{
			flag = base.UpdateSqlData(this.class20_0, this.class20_0.tR_KladrStreet);
		}
		if (flag)
		{
			base.DialogResult = DialogResult.OK;
		}
	}

	private int int_0;

	private int int_1;
}
