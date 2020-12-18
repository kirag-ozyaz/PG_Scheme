using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;
using ReferenceMapObj.DataSets;

namespace ReferenceMapObj
{
	public partial class FormMapObjAddEdit : FormBase
	{
        private int mapId = -1;
        public FormMapObjAddEdit(int idMap)
		{
			this.InitializeComponent();
			this.mapId = idMap;
		}

		private void FormMapObjAdd_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dsObl, this.dsObl.Tables["tR_KladrObj"], true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr");
			if (this.mapId == -1)
			{
				if (this.cmbObl.SelectedIndex >= 0)
				{
					base.SelectSqlData(this.dsRaionObl, this.dsRaionObl.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
					this.cmbRaionObl.Text = "Ульяновск г";
				}
				DataRow dataRow = this.dsKladr.tMapObj.NewRow();
				dataRow["IsHouse"] = true;
				dataRow["Deleted"] = false;
				dataRow["Street"] = -1;
				this.dsKladr.tMapObj.Rows.Add(dataRow);
				return;
			}
			base.SelectSqlData(this.dsKladr, this.dsKladr.tMapObj, true, " where idMap = " + this.mapId.ToString());
			base.SelectSqlData(this.dsKladr, this.dsKladr.tR_KladrStreet, true, " where id = " + this.dsKladr.tMapObj.Rows[0]["Street"].ToString());
			base.SelectSqlData(this.dsKladr, this.dsKladr.tR_KladrObj, true, " where id = " + this.dsKladr.tR_KladrStreet.Rows[0]["KladrObjId"].ToString());
			int KladrObjId = (int)this.dsKladr.tR_KladrStreet.Rows[0]["KladrObjId"];
			base.SelectSqlData(this.dsKladr, this.dsKladr.tR_KladrObj, true, " where id = " + this.dsKladr.tR_KladrObj.Rows[0]["ParentId"].ToString());
			int Id = (int)this.dsKladr.tR_KladrObj.Rows[0]["Id"];
			int ParentId = (int)this.dsKladr.tR_KladrObj.Rows[0]["ParentId"];
			this.cmbObl.SelectedValue = ParentId;
			if (this.cmbObl.SelectedIndex >= 0)
			{
				base.SelectSqlData(this.dsRaionObl, this.dsRaionObl.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
				this.cmbRaionObl.SelectedValue = Id;
			}
			if (this.cmbRaionObl.SelectedIndex >= 0 && KladrObjId >= 0)
			{
				base.SelectSqlData(this.dsPunkts, this.dsPunkts.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
				this.cmbCity.SelectedValue = KladrObjId;
			}
			base.SelectSqlData(this.dsKladr, this.dsKladr.tMapObj, true, " where idMap = " + this.mapId.ToString());
		}

		private void cmbObl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbObl.SelectedIndex < 0)
			{
				this.dsRaionObl.Tables["tR_KladrObj"].Clear();
				return;
			}
			base.SelectSqlData(this.dsRaionObl, this.dsRaionObl.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			this.cmbRaionObl.SelectedIndex = -1;
		}

		private void cmbRaionObl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbRaionObl.SelectedIndex < 0)
			{
				this.dsPunkts.Tables["tR_KladrObj"].Clear();
				return;
			}
			base.SelectSqlData(this.dsPunkts, this.dsPunkts.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			this.cmbCity.SelectedIndex = -1;
			DataSetKladr dataSetKladr = new DataSetKladr();
			base.SelectSqlData(dataSetKladr, dataSetKladr.tR_Classifier, true, "where parentkey like '%;CityRaion;%' and value = " + this.cmbRaionObl.SelectedValue.ToString());
			if (dataSetKladr.tR_Classifier.Rows.Count <= 0)
			{
				this.dsKladr.tR_Classifier.Clear();
			}
			else
			{
				base.SelectSqlData(this.dsKladr, this.dsKladr.tR_Classifier, true, "where isGRoup = 0 and parentkey = '" + dataSetKladr.tR_Classifier.Rows[0]["ParentKey"] + "' and deleted = 0 order by name");
				this.cmbRaionCity.SelectedIndex = -1;
			}
			base.SelectSqlData(this.dsStreet, this.dsStreet.Tables["tR_KladrStreet"], true, " where KladrObjId = " + this.cmbRaionObl.SelectedValue + " and deleted = 0 order by name, socr ");
			this.cmbStreet.SelectedIndex = -1;
		}

		private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbCity.SelectedIndex >= 0)
			{
				DataSetKladr dataSetKladr = new DataSetKladr();
				base.SelectSqlData(dataSetKladr, dataSetKladr.tR_Classifier, true, "where parentkey like '%;CityRaion;%' and value = " + this.cmbCity.SelectedValue.ToString());
				if (dataSetKladr.tR_Classifier.Rows.Count <= 0)
				{
					this.dsKladr.tR_Classifier.Clear();
				}
				else
				{
					base.SelectSqlData(this.dsKladr, this.dsKladr.tR_Classifier, true, "where isGRoup = 0 and parentkey = '" + dataSetKladr.tR_Classifier.Rows[0]["ParentKey"] + "' and deleted = 0 order by name");
					this.cmbRaionCity.SelectedIndex = -1;
				}
				base.SelectSqlData(this.dsStreet, this.dsStreet.Tables["tR_KladrStreet"], true, " where KladrObjId = " + this.cmbCity.SelectedValue + " and deleted = 0 order by name, socr ");
				this.cmbStreet.SelectedIndex = -1;
			}
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (!this.CheckData())
			{
				return;
			}
			this.dsKladr.tMapObj.Rows[0].EndEdit();
			bool flag;
			if (this.mapId == -1)
			{
				flag = base.InsertSqlData(this.dsKladr, this.dsKladr.tMapObj);
			}
			else
			{
				flag = base.UpdateSqlData(this.dsKladr, this.dsKladr.tMapObj);
			}
			if (flag)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		private bool CheckData()
		{
			if (this.cmbStreet.SelectedIndex < 0)
			{
				MessageBox.Show("Не выбрана улица");
				return false;
			}
			return true;
		}

		
	}
}
