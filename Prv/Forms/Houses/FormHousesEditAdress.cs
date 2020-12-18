using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prv.Forms.Houses
{
    public partial class FormHousesEditAdress : FormLbr.FormBase
    {
        public FormHousesEditAdress()
        {
            InitializeComponent();
        }

        #region toolStripMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvefHouses.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvefHouses.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvefHouses.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvefHouses.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvefHouses.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvefHouses.CopyToExcel(true);
        }
        // Обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {

         }
        #endregion
        #region comboBoxes Events
        // смена области
        private void cmbObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // загрузка районов/города выбранной области
            if (cmbObl.SelectedIndex < 0)
                dsRaionObl.Tables["tR_KladrObj"].Clear();
            else
            {
                this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbRaionCity.SelectedIndex = -1;
            }
        }
        // смена района/города области
        private void cmbRaionObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // загрузка районов/города выбранной области
            if (cmbRaionObl.SelectedIndex < 0)
                dsPunkts.Tables["tR_KladrObj"].Clear();
            else
            {
                // yfctktyyst geyrns
                this.SelectSqlData(dsPunkts, dsPunkts.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbCity.SelectedIndex = -1;

                // районы города/населенного пункта
                DataSets.DataSetPrv dsTmp = new DataSets.DataSetPrv();
                this.SelectSqlData(dsTmp, dsTmp.tR_Classifier, true, "where parentkey like '%;CityRaion;%' and value = " +
                    cmbRaionObl.SelectedValue.ToString());

                if (dsTmp.tR_Classifier.Rows.Count <= 0)
                    dsRaionCity.Tables["tR_Classifier"].Clear();
                else
                {
                    this.SelectSqlData(dsRaionCity, dsRaionCity.Tables["tR_Classifier"], true, "where isGRoup = 0 and parentkey = '" +
                        dsTmp.tR_Classifier.Rows[0]["ParentKey"] + "' and deleted = 0 order by name");
                    cmbRaionCity.SelectedIndex = -1;
                }

                this.SelectSqlData(dsStreet, dsStreet.Tables["tR_KladrStreet"], true,
                    " where KladrObjId = " + cmbRaionObl.SelectedValue + " and deleted = 0 order by name, socr ");
                cmbStreet.SelectedIndex = -1;
            }
        }
        // выбор населенного пункта
        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsStreet, dsStreet.Tables["tR_KladrStreet"], true,
                    " where KladrObjId = " + cmbCity.SelectedValue + " and deleted = 0 order by name, socr ");
                cmbStreet.SelectedIndex = -1;
            }
        }
        // Смена улицы
        private void cmbStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStreet.SelectedIndex >= 0)
            {
                DataRow[] dr = dsStreet.Tables["tR_KladrStreet"].Select("Id = " + cmbStreet.SelectedValue.ToString());
                txtIndex.Text = dr[0]["Index"].ToString();
            }
        }
        #endregion

        private void bClose_Click(object sender, EventArgs e)
        {
            if (panelHouses.Visible == true) this.Close();
            else
            {
                panelHouses.Visible = true;
                panelAbn.Visible = false;
                gbStreetHouse.Visible = true;
                bCreate.Visible = true;
                bClose.Text = "Закрыть";
            };
        }

        private void FormHousesEditAdress_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsPrv, dsPrv.vPrv_HouseAll_Mini, true, "order by KladrObj, Street ,House ,HousePrefix ");
            panelHouses.Visible = true;
            panelAbn.Visible = false;

            rbHouse.Checked = true;


            // загрузка областей
            this.SelectSqlData(dsObl, dsObl.Tables["tR_KladrObj"], true,
                " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr");

            // загрузка районов/городов
            if (cmbObl.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbRaionObl.Text = "Ульяновск г";
            }


        }

        private void dgvefHouses_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Create();
        }

        private void Create()
        {
            string idmaps = "";

            txtHouse.Enabled = true;
            txtHousePrefix.Enabled = true;

            if (rbHouse.Checked == true) 
                SelectSqlData(dsPrv, dsPrv.vPrv_HouseAbn, true, "where idmap = " + dgvefHouses.CurrentRow.Cells[0].Value.ToString());
            if (rbAll.Checked == true)
            {

                txtHouse.Enabled = false;
                txtHousePrefix.Enabled = false;

                if (dgvefHouses.RowCount < 1) { MessageBox.Show("Пусто!"); }
                else
                {
                    idmaps = dgvefHouses.Rows[0].Cells[0].Value.ToString();
                    for (int i = 1; i < dgvefHouses.RowCount; i++)
                    {
                        idmaps = idmaps + ", " + dgvefHouses.Rows[i].Cells[0].Value.ToString();

                    };
                }

                SelectSqlData(dsPrv, dsPrv.vPrv_HouseAbn, true, "where idmap in ( " + idmaps + " )");
                // MessageBox.Show(idmaps);
            }
            panelHouses.Visible = false;
            panelAbn.Visible = true;
            gbStreetHouse.Visible = false;
            bCreate.Visible = false;

            lSelected.Text = dgvAbnHouseEdit.RowCount.ToString();
            bClose.Text = "Назад";
        }

        private int FindIdMap()
        {
            string housePrefix = (String.IsNullOrEmpty(txtHousePrefix.Text)) ?
                " and HousePrefix is null " : " and HousePrefix = '" + txtHousePrefix.Text + "'";
            this.SelectSqlData(dsPrv, dsPrv.tMapObj, true, "where Street = " + cmbStreet.SelectedValue.ToString() +
                " and House = " + txtHouse.Text + housePrefix + " and IsHouse = 1 and Name is null");

            if (dsPrv.tMapObj.Rows.Count > 0) // есть такой дом (создавать не надо)
            {
                dsPrv.tMapObj.Rows[0]["Index"] = txtIndex.Text;
                dsPrv.tMapObj.Rows[0]["Raion"] = (cmbRaionCity.SelectedValue == null) ? DBNull.Value : cmbRaionCity.SelectedValue;
                dsPrv.tMapObj.Rows[0].EndEdit();
                if (this.UpdateSqlData(dsPrv, dsPrv.tMapObj))
                    return Convert.ToInt32(dsPrv.tMapObj.Rows[0]["idMap"]);
                else
                    return -1;
            }
            else
            {
                DataRow dr = dsPrv.tMapObj.NewRow();
                dr["Raion"] = (cmbRaionCity.SelectedValue == null) ? DBNull.Value : cmbRaionCity.SelectedValue;
                dr["Street"] = cmbStreet.SelectedValue;
                dr["House"] = txtHouse.Text;
                if (!String.IsNullOrEmpty(txtHousePrefix.Text))
                    dr["HousePrefix"] = txtHousePrefix.Text;
                dr["IsHouse"] = true;
                dr["Index"] = txtIndex.Text;
                dr["Deleted"] = 0;
                dsPrv.tMapObj.Rows.Add(dr);

                dsPrv.tMapObj.Rows[0].EndEdit();
                return this.InsertSqlDataOneRow(dsPrv, dsPrv.tMapObj);
            }
        }

        private bool CheckAbnObj()
        {
                          if (cmbObl.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбрана область");
                    return false;
                }
                if (cmbRaionObl.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбран район/город");
                    return false;
                }
                if (cmbStreet.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбрана улица");
                    return false;
                }
                if (rbHouse.Checked == true && String.IsNullOrEmpty(txtHouse.Text))
                {
                    MessageBox.Show("Не указан номер дома");
                    return false;
                }
       
           return true;
        }

        
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (rbHouse.Checked == true)
            {
                if (!CheckAbnObj())
                    return;

                int idMap = FindIdMap();    //получаем код карты

                if (idMap == -1)
                {
                    MessageBox.Show("Не удается создать объект - дом");
                    return;
                }

                for (int i = 0; i < dgvAbnHouseEdit.RowCount; i++)
                {
                    dsPrv.tAbnObj.Clear();
                    SelectSqlData(dsPrv.tAbnObj, true, "where id = " + dgvAbnHouseEdit.Rows[i].Cells["id"].Value.ToString(), null, false, 1);
                    dsPrv.tAbnObj.Rows[0]["idMap"] = idMap;
                    dsPrv.tAbnObj.Rows[0].EndEdit();
                    this.UpdateSqlData(dsPrv, dsPrv.tAbnObj);
                };

                SelectSqlData(dsPrv, dsPrv.vPrv_HouseAbn, true, "where idmap = " + idMap.ToString());
            }

            if (rbAll.Checked == true)
            {
                if (!CheckAbnObj())
                    return;

                string idMaps = "";

                for (int i = 0; i < dgvAbnHouseEdit.RowCount; i++)
                {
                    txtHouse.Text = dgvAbnHouseEdit.Rows[i].Cells["house"].Value.ToString();
                    txtHousePrefix.Text = dgvAbnHouseEdit.Rows[i].Cells["housePrefix"].Value.ToString();

                    int idMap = FindIdMap();

                    if (idMap == -1)
                    {
                        MessageBox.Show("Не удается создать объект - дом");
                        return;
                    }

                    dsPrv.tAbnObj.Clear();
                    SelectSqlData(dsPrv.tAbnObj, true, "where id = " + dgvAbnHouseEdit.Rows[i].Cells["id"].Value.ToString(), null, false, 1);
                    dsPrv.tAbnObj.Rows[0]["idMap"] = idMap;
                    dsPrv.tAbnObj.Rows[0].EndEdit();
                    this.UpdateSqlData(dsPrv, dsPrv.tAbnObj);

                    if (i == 0) { idMaps = idMap.ToString(); } else { idMaps = idMaps + ", " + idMap.ToString(); }
                };

                SelectSqlData(dsPrv, dsPrv.vPrv_HouseAbn, true, "where idmap in ( " + idMaps+ " )");

            }


        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            Create();
        }
    }
}
