using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnAddress : FormLbr.FormBase
    {
        private int ID = -1;
        private bool isInsert = false;  // false - update]
        public int IDSTREET;
        private int IDOBJ = -1;


        public FormAbnAddress()
        {
            InitializeComponent();
        }
        
        // id - IDABN или IDROW 
        public FormAbnAddress(int id, bool insert)
        {
            InitializeComponent();
            ID = id;
            isInsert = insert;
            this.Text = (isInsert) ? "Новый адрес" : "Редактировать адрес";
        }

        private void FormAbnAddress_Load(object sender, EventArgs e)
        {
            // список видов адреса
            this.SelectSqlData(dsAbnAddress1, dsAbnAddress1.tR_Classifier, true, "where ParentKey = ';Contact;' and Value = 1" );

            if (isInsert) // добавление
            {
                DataRow r = dsAbnAddress1.tG_AbnAddress.NewRow();
                r["idAbn"] = 0;
                r["idTypeAddress"] = Constants.Constants.AddressLegal;
                r["idStreet"] = 0;
                r["House"] = "";
                r["Housing"] = "";
                r["Apartment"] = "";
                r["Representation"] = "";
                r["DateChange"] = System.DateTime.Now.Date;
                dsAbnAddress1.tG_AbnAddress.Rows.Add(r);

                tsbCopy.Enabled = false;
            }
            else
            {
                this.SelectSqlData(dsAbnAddress1, dsAbnAddress1.tG_AbnAddress, true, "where id = " + ID.ToString());
                if (dsAbnAddress1.tG_AbnAddress.Rows[0]["idStreet"] != System.DBNull.Value)
                {
                    IDSTREET = Convert.ToInt32(dsAbnAddress1.tG_AbnAddress.Rows[0]["idStreet"]);
                    this.AddressSelect();
                }
                cmbAddressType.Enabled = false;
            }
        }

        private void tsbSelect_Click(object sender, EventArgs e)
        {
            FormAbnAddressSelect frm = new FormAbnAddressSelect();
            frm.SqlSettings = this.SqlSettings;
            frm.Owner = this;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.AddressSelect();
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            string adress=tbRepresentation.Text;
            string house = tbHouse.Text;
            string housing = tbHousing.Text;
            string appartment = tbApartment.Text;

            dsAbnAddress1.tG_AbnAddress.Rows[0]["House"] = house;
            dsAbnAddress1.tG_AbnAddress.Rows[0]["Housing"] = housing;
            dsAbnAddress1.tG_AbnAddress.Rows[0]["Apartment"] = appartment;

            dsAbnAddress1.tG_AbnAddress.Rows[0]["idTypeAddress"] = cmbAddressType.SelectedValue;
            dsAbnAddress1.tG_AbnAddress.Rows[0]["idStreet"] = IDSTREET;
            dsAbnAddress1.tG_AbnAddress.Rows[0]["Representation"] = adress;
            dsAbnAddress1.tG_AbnAddress.Rows[0].EndEdit();
            bool isOk = false;
            if (isInsert)
            {
                dsAbnAddress1.tG_AbnAddress.Rows[0]["idAbn"] = ID;
                isOk = this.InsertSqlData(dsAbnAddress1, dsAbnAddress1.tG_AbnAddress);
            }
            else
                isOk = this.UpdateSqlData(dsAbnAddress1, dsAbnAddress1.tG_AbnAddress);
            if (isOk) this.DialogResult = DialogResult.OK;
        }

        private void tsbCansel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void tsmCreateView_Click(object sender, EventArgs e)
        {
            string rp = "";
            if (tbIndex.Text != "") 
                rp = tbIndex.Text;
            if (tbRegion.Text != "")
                rp = rp + ", " + tbRegion.Text;
            if (tbCity.Text != "")
                rp = rp + ", " + tbCity.Text;
            if (tbLocal.Text != "")
                rp = rp + ", " + tbLocal.Text;
            if (tbStreet.Text != "")
                rp = rp + ", " + tbStreet.Text;
            if (tbHouse.Text != "")
                rp = rp + ", " + "дом №" + tbHouse.Text;
            if (tbHousing.Text != "")
                rp = rp + ", " + "корпус " + tbHousing.Text;
            if (tbApartment.Text != "")
                rp = rp + ", " + "кв. " + tbApartment.Text;
            this.tbRepresentation.Focus();
            this.tbRepresentation.Text = rp;
            this.cmbAddressType.Focus();
        }

        private void AddressSelect()
        {
            // IDSTREET должен содержать idStreet выбранной строки
            // заполним поля регион район город улица
            int flagTour = 0;
            if (IDSTREET > 0)
            {
                this.SelectSqlData(dsAbnAddress1, dsAbnAddress1.tR_KladrStreet, true, " where id = " + IDSTREET.ToString());
                this.tbStreet.Text = dsAbnAddress1.tR_KladrStreet[0]["Name"].ToString() + " " + dsAbnAddress1.tR_KladrStreet[0]["Socr"].ToString();
                this.tbIndex.Text = dsAbnAddress1.tR_KladrStreet[0]["Index"].ToString();
                IDOBJ = Convert.ToInt32(dsAbnAddress1.tR_KladrStreet[0]["KladrObjID"]);
                this.SelectSqlData(dsAbnAddress1, dsAbnAddress1.tR_KladrObj, true, " where id = " + IDOBJ.ToString());

                //if (dsAbnAddress1.tR_KladrObj.Rows[0]["PrimaryKey"].ToString() == "punct")
                //{
                    this.tbLocal.Text = dsAbnAddress1.tR_KladrObj[0]["Name"].ToString() + " " + dsAbnAddress1.tR_KladrObj[0]["Socr"].ToString();
                    flagTour = 1;
                //}
                if (flagTour > 0)
                {
                    IDOBJ = Convert.ToInt32(dsAbnAddress1.tR_KladrObj[0]["ParentId"]);
                    this.SelectSqlData(dsAbnAddress1, dsAbnAddress1.tR_KladrObj, true, " where Id = " + IDOBJ.ToString());
                }
                this.tbCity.Text = dsAbnAddress1.tR_KladrObj[0]["Name"].ToString() + " " + dsAbnAddress1.tR_KladrObj[0]["Socr"].ToString();
                IDOBJ = Convert.ToInt32(dsAbnAddress1.tR_KladrObj[0]["ParentId"]);
                this.SelectSqlData(dsAbnAddress1, dsAbnAddress1.tR_KladrObj, true, " where id = " + IDOBJ.ToString());
                this.tbRegion.Text = dsAbnAddress1.tR_KladrObj[0]["Name"].ToString() + " " + dsAbnAddress1.tR_KladrObj[0]["Socr"].ToString();
            }
        }

        private void buttonCreateView_Click(object sender, EventArgs e)
        {
            string rp = "";
            if (tbIndex.Text != "")
                rp = tbIndex.Text;
            if (tbRegion.Text != "")
                rp = rp + ", " + tbRegion.Text;
            if (tbCity.Text != "")
                rp = rp + ", " + tbCity.Text;
            if (tbLocal.Text != "")
                rp = rp + ", " + tbLocal.Text;
            if (tbStreet.Text != "")
                rp = rp + ", " + tbStreet.Text;
            if (tbHouse.Text != "")
                rp = rp + ", " + "дом №" + tbHouse.Text;
            if (tbHousing.Text != "")
                rp = rp + ", " + "корпус " + tbHousing.Text;
            if (tbApartment.Text != "")
                rp = rp + ", " + "кв. " + tbApartment.Text;
            this.tbRepresentation.Focus();
            this.tbRepresentation.Text = rp;
            this.cmbAddressType.Focus();
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {

            int idAbn = (int)dsAbnAddress1.tG_AbnAddress.Rows[0]["idAbn"];
            int type = (int)dsAbnAddress1.tG_AbnAddress.Rows[0]["idTypeAddress"];
            string adress = tbRepresentation.Text;
            string house = tbHouse.Text;
            string housing = tbHousing.Text;
            string appartment = tbApartment.Text;

            dsAbnAddress1.tG_AbnAddress.Clear();
            DataRow r = dsAbnAddress1.tG_AbnAddress.NewRow();
            r["idAbn"] = idAbn;
            switch (type)
            {
                case Constants.Constants.AddressLegal: r["idTypeAddress"] = Constants.Constants.AddressMailing;
                    break;
                case Constants.Constants.AddressMailing:  r["idTypeAddress"] = Constants.Constants.AddressLegal;
                    break;
            }

            r["idStreet"] = IDSTREET;
            r["House"] = house;
            r["Housing"] = housing;
            r["Apartment"] = appartment;
            r["Representation"] = adress;
            r["DateChange"] = System.DateTime.Now.Date;
            dsAbnAddress1.tG_AbnAddress.Rows.Add(r);

             bool isOk = false;
                isOk = this.InsertSqlData(dsAbnAddress1, dsAbnAddress1.tG_AbnAddress);

            if (isOk) this.DialogResult = DialogResult.OK;
        }
    }
}
