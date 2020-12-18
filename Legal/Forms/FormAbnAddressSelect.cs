using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnAddressSelect : FormLbr.FormBase
    {
        private int flagTour = -1;
        private int flagRepeat = -1;
        public FormAbnAddressSelect()
        {
            InitializeComponent();
        }


        private void FormAbnAddressSelect_Load(object sender, EventArgs e)
        {
            //this.SelectSqlData(dsAbnAddressSelect1, dsAbnAddressSelect1.tR_KladrObj, true);
            this.SelectSqlData(dsAbnAddressSelect1, dsAbnAddressSelect1.tR_KladrStreet, true, " order by KladrObjID");

            int IDLOCAL = 0;
            int IDCITY = 0;
            int IDDISTRICT = 0;
            int IDREGION = 0;
            string LOCAL = "";
            string CITY = "";
            string DISTRICT = "";
            string REGION = "";

            for (int curRow = 0; curRow < dsAbnAddressSelect1.tR_KladrStreet.Rows.Count; curRow++)
            {
                DataRow r = dsAbnAddressSelect1.tG_AbnAddressSelect.NewRow();
                r["idStreet"] = dsAbnAddressSelect1.tR_KladrStreet.Rows[curRow]["id"];
                r["Street"] = dsAbnAddressSelect1.tR_KladrStreet.Rows[curRow]["Name"] + " " + dsAbnAddressSelect1.tR_KladrStreet.Rows[curRow]["Socr"];
                r["ZipCode"] = dsAbnAddressSelect1.tR_KladrStreet.Rows[curRow]["Index"];

                if (flagRepeat != Convert.ToInt32(dsAbnAddressSelect1.tR_KladrStreet.Rows[curRow]["KladrObjID"]))
                {
                    IDLOCAL = 0;
                    IDCITY = 0;
                    IDDISTRICT = 0;
                    IDREGION = 0;
                    LOCAL = "";
                    CITY = "";
                    DISTRICT = "";
                    REGION = "";

                    int IDOBJ = Convert.ToInt32(dsAbnAddressSelect1.tR_KladrStreet[curRow]["KladrObjID"]);
                    dsAbnAddressSelect1.tR_KladrObj.Clear();
                    this.SelectSqlData(dsAbnAddressSelect1, dsAbnAddressSelect1.tR_KladrObj, true, " where id = " + IDOBJ.ToString());
                    if (dsAbnAddressSelect1.tR_KladrObj.Rows.Count > 0)
                    {
                        flagTour = 0;
                        //if (dsAbnAddressSelect1.tR_KladrObj.Rows[0]["PrimaryKey"].ToString() == "punct")
                        //{
                            r["Local"] = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Name"] + " " + dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Socr"];
                            LOCAL = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Name"].ToString() + " " + dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Socr"].ToString();
                            r["idLocal"] = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["id"];
                            IDLOCAL = Convert.ToInt32(dsAbnAddressSelect1.tR_KladrObj.Rows[0]["id"]);
                            flagTour = 1;
                        //}
                        if (flagTour > 0)
                        {
                            IDOBJ = Convert.ToInt32(dsAbnAddressSelect1.tR_KladrObj[0]["ParentID"]);
                            dsAbnAddressSelect1.tR_KladrObj.Clear();
                            this.SelectSqlData(dsAbnAddressSelect1, dsAbnAddressSelect1.tR_KladrObj, true, " where id = " + IDOBJ.ToString());
                        }

                        if (dsAbnAddressSelect1.tR_KladrObj.Rows.Count > 0)
                        {
                            if (dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Level"].ToString() == "3")
                            {
                                r["City"] = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Name"] + " " + dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Socr"];
                                CITY = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Name"].ToString() + " " + dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Socr"].ToString();
                                r["idCity"] = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["id"];
                                IDCITY = Convert.ToInt32(dsAbnAddressSelect1.tR_KladrObj.Rows[0]["id"]);
                            }
                            else
                            {
                                r["District"] = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Name"] + " " + dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Socr"];
                                DISTRICT = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Name"].ToString();
                                r["idDistrict"] = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["id"];
                                IDDISTRICT = Convert.ToInt32(dsAbnAddressSelect1.tR_KladrObj.Rows[0]["id"]);
                            }
                        }
                        IDOBJ = Convert.ToInt32(dsAbnAddressSelect1.tR_KladrObj[0]["ParentID"]);
                        dsAbnAddressSelect1.tR_KladrObj.Clear();
                        this.SelectSqlData(dsAbnAddressSelect1, dsAbnAddressSelect1.tR_KladrObj, true, " where id = " + IDOBJ.ToString());
                        if (dsAbnAddressSelect1.tR_KladrObj.Rows.Count > 0)
                        {
                            r["Region"] = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Name"] + " " + dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Socr"];
                            REGION = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Name"].ToString() + " " + dsAbnAddressSelect1.tR_KladrObj.Rows[0]["Socr"].ToString();
                            r["idRegion"] = dsAbnAddressSelect1.tR_KladrObj.Rows[0]["id"];
                            IDREGION = Convert.ToInt32(dsAbnAddressSelect1.tR_KladrObj.Rows[0]["id"]);
                        }
                    }
                }
                else
                {
                    r["Local"] = LOCAL;
                    r["idLocal"] = IDLOCAL;
                    r["City"] = CITY;
                    r["idCity"] = IDCITY;
                    r["District"] = DISTRICT;
                    r["idDistrict"] = IDDISTRICT;
                    r["Region"] = REGION;
                    r["idRegion"] = IDREGION;
                }
                //dsAbnAddressSelect1.tG_AbnAddressSelect.Rows.Add(r);
                flagRepeat = Convert.ToInt32(dsAbnAddressSelect1.tR_KladrStreet.Rows[curRow]["KladrObjID"]);
            }
        }


        private void dgvSelect_DoubleClick(object sender, EventArgs e)
        {
            FormAbnAddress frm = (FormAbnAddress)this.Owner;
            frm.IDSTREET = Convert.ToInt32(dgvSelect.CurrentRow.Cells["idStreet"].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
 