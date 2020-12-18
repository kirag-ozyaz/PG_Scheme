using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

internal partial class FormKladrAddEditPunkts : FormBase
{
	internal FormKladrAddEditPunkts(int int_2, int int_3)
	{
		
		this.int_0 = -1;
		this.int_1 = -1;
		
		this.InitializeComponent();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.Text = ((this.int_0 == -1) ? "Добавление населенного пункта" : "Редактирование населенного пункта");
	}

	private void FormKladrAddEditPunkts_Load(object sender, EventArgs e)
	{
		this.cmbTypeObj.Items.Clear();
		base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_KladrObj"], true, "where id <> " + this.int_0.ToString() + " and deleted = 0 order by name, socr");
		if (this.int_0 == -1)
		{
			DataRow dataRow = this.class20_0.tR_KladrObj.NewRow();
			dataRow["ParentId"] = this.int_1;
			dataRow["Deleted"] = false;
			this.class20_0.tR_KladrObj.Rows.Add(dataRow);
			return;
		}
		base.SelectSqlData(this.class20_0, this.class20_0.tR_KladrObj, true, " where id = " + this.int_0.ToString());
		if (this.class20_0.tR_KladrObj.Rows.Count > 0)
		{
			int num = (int)Convert.ToInt16(this.class20_0.tR_KladrObj.Rows[0]["Level"]);
			foreach (object obj in this.cmbTypeObj.Items)
			{
				if (((FormKladrAddEditPunkts.Struct0)obj).int_0 == num)
				{
					this.cmbTypeObj.SelectedItem = obj;
				}
			}
			foreach (object obj2 in this.comboBoxPrefix.Items)
			{
				if (((DataRowView)obj2).Row["scname"].ToString() == this.class20_0.tR_KladrObj.Rows[0]["Socr"].ToString())
				{
					this.comboBoxPrefix.SelectedItem = obj2;
				}
			}
		}
	}

	private void comboBoxParent_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.method_0();
	}

	private void method_0()
	{
		this.cmbTypeObj.SelectedIndex = -1;
		this.cmbTypeObj.Items.Clear();
		this.cmbTypeObj.Text = "";
		if (this.comboBoxParent.SelectedIndex < 0)
		{
			this.cmbTypeObj.Items.Add(new FormKladrAddEditPunkts.Struct0("Страна", 0));
			return;
		}
		int num = (int)this.comboBoxParent.SelectedValue;
		DataRow[] array = this.dataSet_0.Tables["tR_KladrObj"].Select("id = " + num.ToString());
		if (array.Length != 0)
		{
			switch (Convert.ToInt16(array[0]["Level"]))
			{
			case 0:
				this.cmbTypeObj.Items.Add(new FormKladrAddEditPunkts.Struct0("Область/край/город/АО", 1));
				return;
			case 1:
				this.cmbTypeObj.Items.Add(new FormKladrAddEditPunkts.Struct0("Район/Территория", 2));
				this.cmbTypeObj.Items.Add(new FormKladrAddEditPunkts.Struct0("Город", 3));
				this.cmbTypeObj.Items.Add(new FormKladrAddEditPunkts.Struct0("Населенный пункт", 4));
				return;
			case 2:
				this.cmbTypeObj.Items.Add(new FormKladrAddEditPunkts.Struct0("Город", 3));
				this.cmbTypeObj.Items.Add(new FormKladrAddEditPunkts.Struct0("Населенный пункт", 4));
				return;
			case 3:
				this.cmbTypeObj.Items.Add(new FormKladrAddEditPunkts.Struct0("Населенный пункт", 4));
				break;
			case 4:
				break;
			default:
				return;
			}
		}
	}

	private void cmbTypeObj_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.class20_0.tR_KladrSocr.Clear();
		if (this.cmbTypeObj.SelectedIndex >= 0 && this.cmbTypeObj.SelectedItem != null)
		{
			FormKladrAddEditPunkts.Struct0 @struct = (FormKladrAddEditPunkts.Struct0)this.cmbTypeObj.SelectedItem;
			base.SelectSqlData(this.class20_0, this.class20_0.tR_KladrSocr, true, " where [level] = " + @struct.int_0.ToString() + " order by scname");
		}
	}

	private void FormKladrAddEditPunkts_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK)
		{
			if (string.IsNullOrEmpty(this.textBoxName.Text))
			{
				MessageBox.Show("Наименование не может быть пустым");
				e.Cancel = true;
				return;
			}
			if (this.cmbTypeObj.SelectedIndex < 0 || this.cmbTypeObj.SelectedItem == null)
			{
				MessageBox.Show("Не выбран тип населенного пункта");
				e.Cancel = true;
				return;
			}
			FormKladrAddEditPunkts.Struct0 @struct = (FormKladrAddEditPunkts.Struct0)this.cmbTypeObj.SelectedItem;
			this.class20_0.tR_KladrObj.Rows[0]["Level"] = @struct.int_0;
			if (this.comboBoxParent.SelectedIndex < 0)
			{
				this.class20_0.tR_KladrObj.Rows[0]["ParentId"] = DBNull.Value;
			}
			if (this.comboBoxPrefix.SelectedIndex < 0)
			{
				this.class20_0.tR_KladrObj.Rows[0]["Socr"] = DBNull.Value;
			}
			if (string.IsNullOrEmpty(this.textBoxKladrCode.Text))
			{
				this.class20_0.tR_KladrObj.Rows[0]["KladrCode"] = DBNull.Value;
			}
			if (string.IsNullOrEmpty(this.textBoxIndex.Text))
			{
				this.class20_0.tR_KladrObj.Rows[0]["Index"] = DBNull.Value;
			}
			if (string.IsNullOrEmpty(this.textBoxGninmb.Text))
			{
				this.class20_0.tR_KladrObj.Rows[0]["Gninmb"] = DBNull.Value;
			}
			this.class20_0.tR_KladrObj.Rows[0].EndEdit();
			bool flag;
			if (this.int_0 == -1)
			{
				flag = base.InsertSqlData(this.class20_0, this.class20_0.tR_KladrObj);
			}
			else
			{
				flag = base.UpdateSqlData(this.class20_0, this.class20_0.tR_KladrObj);
			}
			if (!flag)
			{
				e.Cancel = true;
				return;
			}
		}
	}

	private int int_0;

	private int int_1;

	private struct Struct0
	{
		internal Struct0(string string_1, int int_1)
		{
			
			this.string_0 = string_1;
			this.int_0 = int_1;
		}

		public override string ToString()
		{
			return this.string_0;
		}

		public string string_0;

		public int int_0;
	}
}
