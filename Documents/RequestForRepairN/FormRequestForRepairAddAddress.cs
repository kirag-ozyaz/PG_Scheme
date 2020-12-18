using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr;
using DataSql;
using FormLbr;
/// <summary>
/// Добавление адреса
/// </summary>
internal partial class FormRequestForRepairAddAddress : FormBase
{

    public DataTable tableKladr;
    public override SQLSettings SqlSettings
	{
		get
		{
			return base.SqlSettings;
		}
		set
		{
			base.SqlSettings = value;
			if (value != null)
			{
				this.kladrStreetControl.SqlSettings = value;
			}
		}
	}

	internal FormRequestForRepairAddAddress()
	{

		this.tableKladr = new DataTable();
		this.InitializeComponent();
	}

	private void kladrStreetControl_ChangeTypeHouseSelect(object sender, EventArgs e)
	{
		if (((ComboBox)sender).SelectedIndex == ((ComboBox)sender).Items.Count - 1)
			this.listBoxHouse.Enabled = true;
        else
            this.listBoxHouse.Enabled = false;
	}

	private void kladrStreetControl_ChangeStreetSelect(object sender, EventArgs e)
	{
		this.FillBoxHouse();
	}

	private void kladrStreetControl_ChangeRaionOblSelect(object sender, EventArgs e)
	{
		this.FillBoxHouse();
	}

	private void kladrStreetControl_ChangePunktsSelect(object sender, EventArgs e)
	{
		this.FillBoxHouse();
	}

	private void kladrStreetControl_ChangeOblSelect(object sender, EventArgs e)
	{
		this.FillBoxHouse();
	}

	private void FillBoxHouse()
	{
		this.listBoxHouse.Items.Clear();
		if (this.kladrStreetControl.SelectedStreet.SelectedIndex >= 0)
		{
			DataTable dataTable = new DataTable("tMapObj");
			base.SelectSqlData(dataTable, true, " left join tAbnObj obj on tMapObj.idMap = obj.idMap  left join tAbn abn on abn.id = obj.idabn  where not abn.id is null and tMapObj.Street = " + this.kladrStreetControl.SelectedStreet.SelectedValue.ToString() + " order by house, houseprefix", null, true, 0);
			foreach (DataRow dataRow in dataTable.Rows)
			{
				this.listBoxHouse.Items.Add(new RegisterHouseMaps(dataRow["House"].ToString() + dataRow["HousePrefix"].ToString(), Convert.ToInt32(dataRow["IdMap"])));
			}
		}
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		if (this.kladrStreetControl.SelectedStreet.SelectedIndex < 0)
		{
			MessageBox.Show("Не выбрана улица");
			return;
		}
		if (this.kladrStreetControl.SelectedHouseType.SelectedIndex >= 0 && (!(this.kladrStreetControl.SelectedHouseType.SelectedItem.ToString() == "Отдельные дома") || this.listBoxHouse.SelectedItems.Count != 0))
		{
			this.tableKladr.Columns.Clear();
			this.tableKladr.Columns.Add("idKladrObj", typeof(int));
			this.tableKladr.Columns.Add("idstreet", typeof(int));
			this.tableKladr.Columns.Add("house", typeof(string));
			this.tableKladr.Rows.Clear();
			int idKladrObj;
			if (this.kladrStreetControl.SelectedCity.SelectedIndex < 0)
			{
				idKladrObj = Convert.ToInt32(this.kladrStreetControl.SelectedRaionObl.SelectedValue);
			}
			else
			{
				idKladrObj = Convert.ToInt32(this.kladrStreetControl.SelectedCity.SelectedValue);
			}
			int idStreet = Convert.ToInt32(this.kladrStreetControl.SelectedStreet.SelectedValue);
            if (Convert.ToInt32(this.kladrStreetControl.SelectedHouseType.SelectedValue) == 0)
            {
                foreach (RegisterHouseMaps houseMaps in this.listBoxHouse.SelectedItems)
                {
                    this.tableKladr.Rows.Add(new object[]
                    {idKladrObj, idStreet, houseMaps.Name});
                }
            }
            else
            {
                foreach (RegisterHouseMaps houseMaps in this.listBoxHouse.Items)
                {
                    this.tableKladr.Rows.Add(new object[]
                    {idKladrObj, idStreet, houseMaps.Name});
                }
            }
            DialogResult = DialogResult.OK;
            Close();
            return;
        }
		MessageBox.Show("Не выбраны дома");
	}
}
