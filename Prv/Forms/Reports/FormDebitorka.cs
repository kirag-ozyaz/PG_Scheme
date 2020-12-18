using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Constants;

namespace Prv.Forms.Reports
{
    public partial class FormDebitorka : FormLbr.FormBase
    {
        public string commTXT = "";
        decimal decLimit1 = 0;
        decimal decLimit2 = 0;
     
        private class ItemChecked
        {

            public string Name { get; set; }
            public int Id { get; set; }

            public ItemChecked()
            {
            }

            public ItemChecked(string name, int id)
            {
                Name = name;
                Id = id;
            }

            public override string ToString()
            {
                return Name;
            }
        }





        public FormDebitorka()
        {
            InitializeComponent();

        }

        private void FormDebitorka_Load(object sender, EventArgs e)
        {
            groupBoxWait.Visible = false;
            comboBoxYear.Items.Add("Все");
            for (int i = 2009; i <= 2050; i++)
                comboBoxYear.Items.Add(i);
            comboBoxYear.SelectedIndex = comboBoxYear.FindString(DateTime.Today.Year.ToString());

            checkBoxNo.CheckState = CheckState.Checked;
            maskedTextBoxLimit1.Text = "10000"; maskedTextBoxLimit2.Text = "-10000";

            LoadPunkts();
            LoadRaions();
            
            int id = ((ItemChecked)checkedListBoxPunkts.SelectedItem).Id;
            this.SelectSqlData(dsStreet, dsStreet.Tables["tR_KladrStreet"], true, " where KladrObjId = " +
                id.ToString() + " order by name, socr");

         //   this.reportViewerDebGraf.RefreshReport();
        }
        private void LoadPunkts()
        {
            #region checkedListBox
            this.SelectSqlData(dsDirectory, dsDirectory.tR_KladrObj, true, " where id = " + Constants.Constants.KladrObjUlyanovsk.ToString());
            checkedListBoxPunkts.Items.Clear();
            ItemChecked item = new ItemChecked(dsDirectory.tR_KladrObj.Rows[0]["Name"].ToString() + " " +
                                    dsDirectory.tR_KladrObj.Rows[0]["Socr"].ToString(),
                                    Convert.ToInt32(dsDirectory.tR_KladrObj.Rows[0]["Id"].ToString()));
            checkedListBoxPunkts.Items.Add(item, true);
            checkedListBoxPunkts.SelectedIndex = 0;

            this.SelectSqlData(dsDirectory, dsDirectory.tR_KladrObj, true, " where Parentid = " + Constants.Constants.KladrObjUlyanovsk.ToString() +
                " and Deleted = 0 order by name, socr");
            foreach (DataRow dr in dsDirectory.tR_KladrObj.Rows)
            {
                item = new ItemChecked(dr["Name"].ToString() + " " + dr["Socr"].ToString(),
                    Convert.ToInt32(dr["Id"]));
                checkedListBoxPunkts.Items.Add(item, true);
            }
            #endregion
        }
        // Загрузка районов
        private void LoadRaions()
        {
            this.SelectSqlData(dsDirectory, dsDirectory.tR_Classifier, true, " where IsGroup = 0 and deleted = 0 " +
                " and ParentKey = ';CityRaion;UlyanovskRaion;' order by name ");
            foreach (DataRow dr in dsDirectory.tR_Classifier.Rows)
            {
                ItemChecked item = new ItemChecked(dr["Name"].ToString(), Convert.ToInt32(dr["Id"]));
                checkedListBoxRaion.Items.Add(item, true);
            }
        }

        #region TabPageAddAddress
        // Выбор начеленного пункта
        private void checkedListBoxPunkts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((ItemChecked)checkedListBoxPunkts.SelectedItem).Id;
            this.SelectSqlData(dsStreet, dsStreet.Tables["tR_KladrStreet"], true, " where KladrObjId = " +
                id.ToString() + " order by name, socr");
        }
        // Один дом
        private void rbHousesOne_CheckedChanged(object sender, EventArgs e)
        {
            txtHousesOne.Enabled = (rbHousesOne.Checked) ? true : false;
        }
        // Диапазон домов
        private void rbHousesRange_CheckedChanged(object sender, EventArgs e)
        {
            txtHousesRange1.Enabled = (rbHousesRange.Checked) ? true : false;
            txtHousesRange2.Enabled = (rbHousesRange.Checked) ? true : false;
        }
        // Одна квартира
        private void rbFlatsOne_CheckedChanged(object sender, EventArgs e)
        {
            txtFlatsOne.Enabled = (rbFlatsOne.Checked) ? true : false;
        }
        // Диапазон квартир
        private void rbFlatsRange_CheckedChanged(object sender, EventArgs e)
        {
            txtFlatsRange1.Enabled = (rbFlatsRange.Checked) ? true : false;
            txtFlatsRange2.Enabled = (rbFlatsRange.Checked) ? true : false;
        }

        // Добавить адрес
        private void buttonAddAdress_Click(object sender, EventArgs e)
        {
            if (comboBoxStreet.SelectedIndex >= 0)
            {
                string count = (dataGridViewAdress.RowCount + 1).ToString();
                string isdel = (checkBoxDelAdress.Checked) ? "true" : "false";
                string street = comboBoxStreet.Text.ToString();
                string codeStreet = comboBoxStreet.SelectedValue.ToString();

                // разбор домов
                string house = "";
                if (rbHousesAll.Checked) house = "Все";
                if (rbHousesOne.Checked) house = txtHousesOne.Text;
                if (rbHousesRange.Checked)
                    house = "с " + txtHousesRange1.Text + " по " + txtHousesRange2.Text;
                if (house == "") return;

                // разбор квартир
                string flat = "";
                if (rbFlatsAll.Checked) flat = "Все";
                if (rbFlatsOne.Checked) flat = txtFlatsOne.Text;
                if (rbFlatsRange.Checked)
                    flat = "с " + txtFlatsRange1.Text + " по " + txtFlatsRange2.Text;
                if (flat == "") return;

                dataGridViewAdress.Rows.Add(count, isdel, street, house, flat, codeStreet);
            }
        }
        // удалить адрес (а)
        private void buttonDelAdress_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdress.RowCount > 0)
            {
                dataGridViewAdress.Rows.Remove(dataGridViewAdress.CurrentRow);
            }
        }
        #endregion

        string GetcommTXT()
        {
            commTXT = "";

            //commTXT = commTXT + " SELECT     deb.Period, LEFT(CONVERT(varchar(8), deb.Period), 4) + '.' + RIGHT(CONVERT(varchar(8), deb.Period), 2) AS PStr, deb.Year, SUM(deb.KWT) AS KWT, COUNT(*) AS Count ";
            //commTXT = commTXT + " ,debU.itogU,debU.countU ";
            //commTXT = commTXT + " FROM  dbo.vPrv_RepDebitorka deb";
            //commTXT = commTXT + " left join (select debue.[MonthDeb] ";
            //commTXT = commTXT + "  ,sum(debue.[Itog]) as itogU,count(*) as countU";
            //commTXT = commTXT + " from (SELECT ";
            //commTXT = commTXT + "	  [MonthDeb]";
            //commTXT = commTXT + "	  ,idPoint";
            //commTXT = commTXT + "	  ,sum([Itog]) as Itog";
            //commTXT = commTXT + "	   FROM [GES].[dbo].[tPrv_DebitorkaUE] ";
            //commTXT = commTXT + "	   where [idPoint]>0 ";
            //commTXT = commTXT + "	   group by [MonthDeb],idPoint) debue ";
            //commTXT = commTXT + " where debue.[Itog] > "+ decLimit2.ToString();
            //commTXT = commTXT + " and debue.[Itog]< " + decLimit1.ToString();
            //commTXT = commTXT + " group by debue.[MonthDeb] ";
            //commTXT = commTXT + " ) debU on debU.[MonthDeb] = deb.[Period] ";


             commTXT = commTXT + " select deb.[MonthRasch] as Period ";
             commTXT = commTXT + " , LEFT(CONVERT(varchar(8), deb.[MonthRasch]), 4) + '.' + RIGHT(CONVERT(varchar(8), deb.[MonthRasch]), 2) AS PStr ";
             commTXT = commTXT + " ,LEFT(deb.MonthRasch, 4) AS Year  ";
             commTXT = commTXT + " ,sum(deb.[KWT]) AS KWT,count(*) AS Count ";
             commTXT = commTXT + " ,debU.ItogU,debU.countU ";
      
             commTXT = commTXT + " from (SELECT "; 
             commTXT = commTXT + "      [MonthRasch] ";
             commTXT = commTXT + "      ,idPoint ";
             commTXT = commTXT + "      ,sum([KWT] ) as KWT ";
             commTXT = commTXT + " FROM [GES].[dbo].[tPrv_Debitorka]  ";
             commTXT = commTXT + " where OK=1  ";
             commTXT = commTXT + " group by [MonthRasch],idPoint) deb ";

             commTXT = commTXT + " left join ";
             commTXT = commTXT + " (select debue.[MonthDeb]  ";
             commTXT = commTXT + "       ,sum(debue.[Itog]) as itogU,count(*) as countU ";
             commTXT = commTXT + " from (SELECT  ";
             commTXT = commTXT + "       [MonthDeb] ";
             commTXT = commTXT + "       ,idPoint ";
             commTXT = commTXT + "       ,sum([Itog]) as Itog ";
             commTXT = commTXT + "        FROM [GES].[dbo].[tPrv_DebitorkaUE]  ";
             commTXT = commTXT + "        where [idPoint]>0  ";
             commTXT = commTXT + "        group by [MonthDeb],idPoint) debue ";
             commTXT = commTXT + " where debue.[Itog] > "+ decLimit2.ToString();
             commTXT = commTXT + " and debue.[Itog]< " + decLimit1.ToString();
             commTXT = commTXT + " group by debue.[MonthDeb] ";
             commTXT = commTXT + " ) debU on debU.[MonthDeb] = deb.[MonthRasch] ";



            commTXT = commTXT + " where ";
            
            if (comboBoxYear.SelectedItem.ToString() != "Все")
            {
                 //commTXT = commTXT +" deb.Year = " + comboBoxYear.SelectedItem;
                 commTXT = commTXT + " convert(int,LEFT(deb.MonthRasch, 4)) = " + comboBoxYear.SelectedItem;
            }
            else
            {
                commTXT = commTXT + " deb.MonthRasch >200900 ";
            }

            if (checkBoxNo.CheckState == CheckState.Checked)
            {
                if (checkBoxTR.Checked)
                {
                    commTXT = commTXT + " and (KTrans > 1 ";
                    commTXT = commTXT + " or ";
                }
                else
                    commTXT = commTXT + " and (";

                commTXT = commTXT + " (deb.KWT<" + decLimit1.ToString();
                commTXT = commTXT + " and deb.KWT>" + decLimit2.ToString() + ")) ";

            }

            if (BuildWhereArea() !="") commTXT = commTXT +" and "+ BuildWhereArea();
            if (BuildWhereAdress() != "") commTXT = commTXT + " and " + BuildWhereAdress();
            commTXT = commTXT + " GROUP BY deb.MonthRasch ,debU.itogU,debU.countU ";
            commTXT = commTXT + " order by deb.MonthRasch asc ";
            //commTXT = commTXT + " GROUP BY deb.Period, deb.Year ,debU.itogU,debU.countU ";
            //commTXT = commTXT + " order by deb.Period asc ";
            return commTXT;
        }
        // Уловие по адресам
        private string BuildWhereAdress()
        {
            // АДРЕСА!!!!!!!!!!!!!!!!
            string whereAdress = "";
            string adress = "";
            string adressNot = "";
            if (dataGridViewAdress.RowCount > 0)
            {
                for (int i = 0; i < dataGridViewAdress.RowCount; i++)
                {
                    string codeStreet = dataGridViewAdress.Rows[i].Cells["colHousesCodeStreet"].Value.ToString();
                    string house = dataGridViewAdress.Rows[i].Cells["colHousesDom"].Value.ToString();
                    string flat = dataGridViewAdress.Rows[i].Cells["colHousesFlat"].Value.ToString();
                    if (dataGridViewAdress.Rows[i].Cells["colHousesDel"].Value.ToString() == "true")
                    {   // ИСКЛЮЧИТЬ
                        #region Все квартиры
                        if (flat == "Все")
                        {   //ВСЕ квартиры
                            if (house == "Все")  // все дома
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + ") ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + ") ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "') ";
                            }
                        }
                        #endregion
                        #region Одна квартира
                        if ((flat.Substring(0, 1) != "с") && (flat != "Все")) //одна квартира
                        {
                            if (house == "Все")  // все дома
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and apartment = '" + flat + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and apartment = '" + flat + "') ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment = '" + flat + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment = '" + flat + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment = '" + flat + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment = '" + flat + "') ";
                            }
                        }
                        #endregion
                        #region Диапазон квартир
                        if (flat.Substring(0, 1) == "с") //диапазон квартир
                        {
                            int indflat = flat.IndexOf(" по ");
                            string f1 = flat.Substring(2, indflat - 1);
                            string f2 = flat.Substring(indflat + 4);
                            if (house == "Все")  // все дома
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment >= '" + f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment >= '" + f1 + "' and apartment <= '" + f2 + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                            }
                        }
                        #endregion
                    }
                    else // ВКЛЮЧИТЬ
                    {
                        #region Все квартиры
                        if (flat == "Все")
                        {   //ВСЕ квартиры
                            if (house == "Все")  // все дома
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + ") ";
                                else
                                    adress += " or (codestreet = " + codeStreet + ") ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "') ";
                            }
                        }
                        #endregion
                        #region Одна квартира
                        if ((flat.Substring(0, 1) != "с") && (flat != "Все")) //одна квартира
                        {
                            if (house == "Все")  // все дома
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and apartment = '" + flat + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and apartment = '" + flat + "') ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment = '" + flat + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment = '" + flat + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment = '" + flat + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment = '" + flat + "') ";
                            }
                        }
                        #endregion
                        #region диапазон кваритр
                        if (flat.Substring(0, 1) == "с") //диапазон квартир
                        {
                            int indflat = flat.IndexOf(" по ");
                            string f1 = flat.Substring(2, indflat - 1);
                            string f2 = flat.Substring(indflat + 4);
                            if (house == "Все")  // все дома
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment >= '" + f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment >= '" + f1 + "' and apartment <= '" + f2 + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                            }
                        }
                        #endregion
                    }
                }
            }
            else // нет улиц
            {
                if ((checkedListBoxPunkts.CheckedItems.Count != checkedListBoxPunkts.Items.Count) &&
                    (checkedListBoxPunkts.CheckedItems.Count > 0))
                {
                    foreach (ItemChecked item in checkedListBoxPunkts.CheckedItems)
                    {
                        adress += item.Id + ",";
                    }
                    adress = " (kladrObjId in (" + adress.Remove(adress.Length - 1) + ")) ";
                }
            }

            if (adress != "")
                whereAdress = " (" + adress + ") ";
            if (adressNot != "")
                if (whereAdress == "")
                    whereAdress = " (not(" + adressNot + ")) ";
                else
                    whereAdress = " (" + whereAdress + " and (not(" + adressNot + "))) ";

            return whereAdress;
        }

        // Условие по районам
        private string BuildWhereArea()
        {
            string whereArea = "";

            if ((checkedListBoxRaion.CheckedItems.Count == checkedListBoxRaion.Items.Count) ||
                (checkedListBoxRaion.CheckedItems.Count <= 0))
                return whereArea;
            else
            {
                foreach (ItemChecked item in checkedListBoxRaion.CheckedItems)
                {
                    whereArea += item.Id + ",";
                }
                whereArea = " (Raion in (" + whereArea.Remove(whereArea.Length - 1) + ")) ";
                return whereArea;
            }

        }
        private void buttonBegin_Click(object sender, EventArgs e)
        {

            try
            {
                if (checkBoxNo.CheckState == CheckState.Checked)
                {
                    decLimit1 = Convert.ToDecimal(maskedTextBoxLimit1.Text);
                    decLimit2 = Convert.ToDecimal(maskedTextBoxLimit2.Text);
                    if (decLimit1 < decLimit2)
                    {
                        MessageBox.Show("Первое ограничение меньше второго!");
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неправильный формат ограничений!");
                return;
            }


            GetcommTXT();

            groupBoxWait.Visible = true;
            progressBarEndLess.AutoProgress = true;

            dsRep.vPrv_RepDebitorkaAll.Clear();
            backgroundWorkerDebAll.RunWorkerAsync();
            
  
           
        }

        private void backgroundWorkerDebAll_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            con.OpenConnection(SqlSettings);
            SqlCommand sqlCmd = new SqlCommand(commTXT, con.Connection);
            sqlCmd.CommandTimeout = 0;
            SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);
            dAdapt.Fill(dsRep, "vPrv_RepDebitorkaAll");

        }
        private void backgroundWorkerDebAll_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridViewExcelFilterDabAll.DataSource = null;
            dataGridViewExcelFilterDabAll.DataSource = dsRep.Tables["vPrv_RepDebitorkaAll"];
            groupBoxWait.Visible = false;
            reportViewerDebGraf.RefreshReport();

        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            SelectCheckBoxNo();
        }

        void SelectCheckBoxNo()
        {
            switch (checkBoxNo.CheckState)
            {
                case CheckState.Checked:
                    groupBoxNO.Visible = true;
                    break;
                default:
                    groupBoxNO.Visible = false;
                    break;
            }
        }

        private void buttonDebCalc_Click(object sender, EventArgs e)
        {
            FormDebCalc f = new FormDebCalc();
            f.MdiParent = this.MdiParent;
            f.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
            f.Show();
        }

       
       



       

  

       
    }
}
