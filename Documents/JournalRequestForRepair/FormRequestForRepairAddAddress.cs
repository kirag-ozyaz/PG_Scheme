using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControlsLbr;
using DataSql;
using FormLbr;

namespace RequestForRepair
{
    /// <summary>
    /// DB6vtwDbcGARY8yZXc
    /// </summary>
    public partial class FormRequestForRepairAddAddress : FormBase
    {
        //public override SQLSettings SqlSettings
        //{
        //    get
        //    {
        //        return SqlSettings;
        //    }
        //    set
        //    {
        //        SqlSettings = value;
        //        if (value != null)
        //        {
        //            this.kladrStreetControl.SqlSettings = value;
        //        }
        //    }
        //}

        public FormRequestForRepairAddAddress()
        {
            this.InitializeComponent();

        }
        private void kladrStreetControl_ChangeTypeHouseSelect(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == ((ComboBox)sender).Items.Count - 1)
            {
                this.listBoxHouse.Enabled = true;
                return;
            }
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
                DataSet dataSet = new DataSet();
                DataTable tbltMapObj = new DataTable("tMapObj");
                dataSet.Tables.Add(tbltMapObj);
                SelectSqlData(tbltMapObj, true, " left join tAbnObj obj on tMapObj.idMap = obj.idMap  left join tAbn abn on abn.id = obj.idabn  where not abn.id is null and tMapObj.Street = " + this.kladrStreetControl.SelectedStreet.SelectedValue.ToString() + " order by house, houseprefix", null, true, 0);

                foreach (DataRow dataRow in tbltMapObj.Rows)
                {
                    this.listBoxHouse.Items.Add(new RegisterHouseMaps(dataRow["House"].ToString() + dataRow["HousePrefix"].ToString(), Convert.ToInt32(dataRow["IdMap"])));
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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
                this.tbl.Columns.Clear();
                this.tbl.Columns.Add("idKladrObj", typeof(int));
                this.tbl.Columns.Add("idstreet", typeof(int));
                this.tbl.Columns.Add("house", typeof(string));
                this.tbl.Rows.Clear();
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
                //if (Convert.ToInt32(this.kladrStreetControl.SelectedHouseType.SelectedValue) == 0)
                //{
                //    using (IEnumerator enumerator = this.listBoxHouse.SelectedItems.GetEnumerator())
                //    {
                //        while (enumerator.MoveNext())
                //        {
                //            Class1 @class = (Class1)enumerator.Current;
                //            this.tbl.Rows.Add(new object[]
                //            {
                //            num,
                //            num2,
                //            @class.Name
                //            });
                //        }
                //        goto IL_244;
                //    }
                //}
                //foreach (Class1 class2 in this.listBoxHouse.Items)
                //{
                //    this.tbl.Rows.Add(new object[]
                //    {
                //    num,
                //    num2,
                //    class2.Name
                //    });
                //}
                //IL_244:
                //DialogResult = DialogResult.OK;
                //Close();
                //return;
                if (Convert.ToInt32(this.kladrStreetControl.SelectedHouseType.SelectedValue) == 0)
                {
                    foreach (RegisterHouseMaps houseMaps in this.listBoxHouse.SelectedItems)
                    {
                        //RegisterHouseMaps houseMaps = (RegisterHouseMaps)enumerator;
                        this.tbl.Rows.Add(new object[]
                        {idKladrObj, idStreet, houseMaps.Name});
                    }
                }
                else
                {
                    foreach (RegisterHouseMaps houseMaps in this.listBoxHouse.Items)
                    {
                        this.tbl.Rows.Add(new object[]
                        {idKladrObj, idStreet, houseMaps.Name});
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            MessageBox.Show("Не выбраны дома");
        }

        private void FormRequestForRepairAddAddress_Load(object sender, EventArgs e)
        {
            if (SqlSettings != null)
                this.kladrStreetControl.SqlSettings = SqlSettings;
        }
    }
}
