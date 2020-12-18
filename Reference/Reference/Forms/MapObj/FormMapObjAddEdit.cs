using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

namespace Reference.Forms.MapObj
{
	public partial class FormMapObjAddEdit : FormBase
	{
		public FormMapObjAddEdit(int idMap)
		{
			
			this.int_0 = -1;
			
			this.InitializeComponent();
			this.int_0 = idMap;
		}

		private void cyvIfStEoT(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_KladrObj"], true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr");
			if (this.int_0 == -1)
			{
				if (this.cmbObl.SelectedIndex >= 0)
				{
					base.SelectSqlData(this.dataSet_1, this.dataSet_1.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
					this.cmbRaionObl.Text = "Ульяновск г";
				}
				DataRow dataRow = this.class20_0.tMapObj.NewRow();
				dataRow["IsHouse"] = true;
				dataRow["Deleted"] = false;
				dataRow["Street"] = -1;
				this.class20_0.tMapObj.Rows.Add(dataRow);
				return;
			}
			base.SelectSqlData(this.class20_0, this.class20_0.tMapObj, true, " where idMap = " + this.int_0.ToString());
			base.SelectSqlData(this.class20_0, this.class20_0.tR_KladrStreet, true, " where id = " + this.class20_0.tMapObj.Rows[0]["Street"].ToString());
			base.SelectSqlData(this.class20_0, this.class20_0.tR_KladrObj, true, " where id = " + this.class20_0.tR_KladrStreet.Rows[0]["KladrObjId"].ToString());
			int num = (int)this.class20_0.tR_KladrStreet.Rows[0]["KladrObjId"];
			base.SelectSqlData(this.class20_0, this.class20_0.tR_KladrObj, true, " where id = " + this.class20_0.tR_KladrObj.Rows[0]["ParentId"].ToString());
			int num2 = (int)this.class20_0.tR_KladrObj.Rows[0]["Id"];
			int num3 = (int)this.class20_0.tR_KladrObj.Rows[0]["ParentId"];
			this.cmbObl.SelectedValue = num3;
			if (this.cmbObl.SelectedIndex >= 0)
			{
				base.SelectSqlData(this.dataSet_1, this.dataSet_1.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
				this.cmbRaionObl.SelectedValue = num2;
			}
			if (this.cmbRaionObl.SelectedIndex >= 0 && num >= 0)
			{
				base.SelectSqlData(this.dataSet_2, this.dataSet_2.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
				this.kEeIxoqAnO.SelectedValue = num;
			}
			base.SelectSqlData(this.class20_0, this.class20_0.tMapObj, true, " where idMap = " + this.int_0.ToString());
		}

		private void cmbObl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbObl.SelectedIndex < 0)
			{
				this.dataSet_1.Tables["tR_KladrObj"].Clear();
				return;
			}
			base.SelectSqlData(this.dataSet_1, this.dataSet_1.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			this.cmbRaionObl.SelectedIndex = -1;
		}

		private void cmbRaionObl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbRaionObl.SelectedIndex < 0)
			{
				this.dataSet_2.Tables["tR_KladrObj"].Clear();
				return;
			}
			base.SelectSqlData(this.dataSet_2, this.dataSet_2.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			this.kEeIxoqAnO.SelectedIndex = -1;
			Class20 @class = new Class20();
			base.SelectSqlData(@class, @class.tR_Classifier, true, "where parentkey like '%;CityRaion;%' and value = " + this.cmbRaionObl.SelectedValue.ToString());
			if (@class.tR_Classifier.Rows.Count <= 0)
			{
				this.class20_0.tR_Classifier.Clear();
			}
			else
			{
				base.SelectSqlData(this.class20_0, this.class20_0.tR_Classifier, true, "where isGRoup = 0 and parentkey = '" + @class.tR_Classifier.Rows[0]["ParentKey"] + "' and deleted = 0 order by name");
				this.cmbRaionCity.SelectedIndex = -1;
			}
			base.SelectSqlData(this.dataSet_3, this.dataSet_3.Tables["tR_KladrStreet"], true, " where KladrObjId = " + this.cmbRaionObl.SelectedValue + " and deleted = 0 order by name, socr ");
			this.cmbStreet.SelectedIndex = -1;
		}

		private void kEeIxoqAnO_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.kEeIxoqAnO.SelectedIndex >= 0)
			{
				Class20 @class = new Class20();
				base.SelectSqlData(@class, @class.tR_Classifier, true, "where parentkey like '%;CityRaion;%' and value = " + this.kEeIxoqAnO.SelectedValue.ToString());
				if (@class.tR_Classifier.Rows.Count <= 0)
				{
					this.class20_0.tR_Classifier.Clear();
				}
				else
				{
					base.SelectSqlData(this.class20_0, this.class20_0.tR_Classifier, true, "where isGRoup = 0 and parentkey = '" + @class.tR_Classifier.Rows[0]["ParentKey"] + "' and deleted = 0 order by name");
					this.cmbRaionCity.SelectedIndex = -1;
				}
				base.SelectSqlData(this.dataSet_3, this.dataSet_3.Tables["tR_KladrStreet"], true, " where KladrObjId = " + this.kEeIxoqAnO.SelectedValue + " and deleted = 0 order by name, socr ");
				this.cmbStreet.SelectedIndex = -1;
			}
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (!this.method_0())
			{
				return;
			}
			this.class20_0.tMapObj.Rows[0].EndEdit();
			bool flag;
			if (this.int_0 == -1)
			{
				flag = base.InsertSqlData(this.class20_0, this.class20_0.tMapObj);
			}
			else
			{
				flag = base.UpdateSqlData(this.class20_0, this.class20_0.tMapObj);
			}
			if (flag)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		private bool method_0()
		{
			if (this.cmbStreet.SelectedIndex < 0)
			{
				MessageBox.Show("Не выбрана улица");
				return false;
			}
			return true;
		}

		private int int_0;
	}
}
