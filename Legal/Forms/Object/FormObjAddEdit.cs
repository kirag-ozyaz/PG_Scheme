using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Object
{
    public partial class FormObjAddEdit : FormLbr.FormBase
    {
        #region Declare

        public enum ActionAbnObj
        {
            Add,
            Edit,
            Read
        }

        public enum ActionAbnObjReg
        {
            Add,
            Edit,
            Read
        }

        private ActionAbnObj actAbnObj;         // действия над объектом
        private ActionAbnObjReg actAbnObjReg;   // действия над параметрами объекта

        private int ID = -1; // id объекта
        private int IDREG = -1; // id истории объекта

        private int? IDABN;
        private int? IDOBJPARENT;
        private int? IDMAP;

        #endregion

        #region Constructors

        public FormObjAddEdit()
        {
            InitializeComponent();
        }

        public FormObjAddEdit(int idObj, int idObjReg, ActionAbnObj actObj, ActionAbnObjReg actObjReg, int idAbn)
        {
            InitializeComponent();
            ID = idObj;
            IDREG = idObjReg;
            IDABN = idAbn;
            actAbnObj = actObj;
            actAbnObjReg = actObjReg;

            switch (actAbnObj)
            {
                case ActionAbnObj.Add:  // Добавить объект
                    this.Text = "Новый объект";
                    break;
                case ActionAbnObj.Edit: // Редактировать объект
                    this.Text = "Редактировать объект";
                    break;
                case ActionAbnObj.Read:  // Просмотр
                    switch (actAbnObjReg)
                    {
                        case ActionAbnObjReg.Add:
                            this.Text = "Новые параметры";
                            break;
                        case ActionAbnObjReg.Edit:
                            this.Text = "Изменить параметры";
                            break;
                        case ActionAbnObjReg.Read:
                            break;
                    }
                    break;
                default:                
                    break;
            }
        }

        #endregion

        #region Events
        
        private void FormObjAddEdit_Load(object sender, EventArgs e)
        {
            
            // загрузка данных для комбобоксов

            // загрузка контролеров
            this.SelectSqlData(dsObj1, dsObj1.vWorkerGroup, true, " where idGroup = " + Constants.Constants.WorkerGroupMasterUL.ToString());

            // загрузка cетевой организации
            this.SelectSqlData(dsObj1, dsObj1.vAbnNet, true);

            // загрузка сбытовой организации
            this.SelectSqlData(dsObj1, dsObj1.vAbnSale, true);

            // загрузка статуса
            this.SelectSqlData(dsObj1, dsObj1.vAbnObjStatus, true);

            // загрузка категории
            this.SelectSqlData(dsObj1, dsObj1.vAbnObjCategory, true);

            //загрузка тарифов
            this.SelectSqlDataTableOther(dsObj1, dsObj1.tR_Classifier_Tariff, "tR_Classifier", true, " where ParentKey in (';SKUEE;Tariff;TariffLeg;') and isGroup = 0 and deleted = 0");

            // загрузка областей
            this.SelectSqlData(dsObl, dsObl.Tables["tR_KladrObj"], true,
                " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr");

            // загрузка районов/городов
            if (cmbObl.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbRaionObl.SelectedValue = 24;
            }

            
            switch (actAbnObj)
            {
                // добавить объект и параметры
                case ActionAbnObj.Add:  
                    dsObj1.tAbnObj.Rows.Add(dsObj1.tAbnObj.NewRow());
                    DataRow row = dsObj1.tAbnObjReg.NewRow();
                    if (IDABN == -1) 
                        row["idAbn"] = 0;
                    else
                        row["idAbn"] = IDABN;
                    row["idAbnObj"] = 0;
                    row["idAbnNet"] = 0;
                    row["idAbnSale"] = 0;
                    row["idStatus"] = 0;
                    row["DateChange"] = System.DateTime.Now.Date;
                    EnabledObjControls(true);
                    EnabledObjControlsReg(true);
                    break;
                // редактировать объект
                case ActionAbnObj.Edit: 
                // просмотр
                case ActionAbnObj.Read:  
                    // загрузка объекта
                    this.SelectSqlData(dsObj1, dsObj1.tAbnObj, true, " where id = " + ID.ToString());
                    DataRow[] row1 = dsObj1.tAbnObj.Select();
                    IDABN = (row1[0]["idAbn"]) == DBNull.Value ? (int?)null : Convert.ToInt32(row1[0]["idAbn"]);
                    IDOBJPARENT = (row1[0]["idObjParent"]) == DBNull.Value ? (int?)null : Convert.ToInt32(row1[0]["idObjParent"]);
                    IDMAP = (row1[0]["idMap"]) == DBNull.Value ? (int?)null : Convert.ToInt32(row1[0]["idMap"]);
                    if (IDABN.HasValue)
                        LoadtAbn();
                    if (IDOBJPARENT.HasValue)
                        LoadtAbnObj1();
                    if (IDMAP.HasValue)
                        LoadtMapObj();
                    // загрузка истории объекта
                    this.SelectSqlData(dsObj1, dsObj1.tAbnObjReg, true, " where id = " + IDREG.ToString());

                    switch (actAbnObjReg)
                    {
                        // добавить новые параметры объекта
                        case ActionAbnObjReg.Add:  
                            DataRow rowNew = dsObj1.tAbnObjReg.NewRow();
                            rowNew["idAbn"] = 0;
                            rowNew["idAbnObj"] = 0;
                            rowNew["idAbnNet"] = 0;
                            rowNew["idAbnSale"] = 0;
                            rowNew["idStatus"] = 0;
                            rowNew["DateChange"] = System.DateTime.Now.Date;
                            EnabledObjControls(false);
                            EnabledObjControlsReg(true);
                            break;
                        // редактировать параметры объекта
                        case ActionAbnObjReg.Edit:  
                        case ActionAbnObjReg.Read:
                            if (actAbnObj == ActionAbnObj.Read)
                            {
                                EnabledObjControls(false);
                                EnabledObjControlsReg(true);
                            }
                            if (actAbnObj == ActionAbnObj.Edit)
                            {
                                EnabledObjControls(true);
                                EnabledObjControlsReg(true);
                            }
                           break;
                    }
                    break;
                default:                
                    break;
            }
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
                DataSet.dsObj dsTmp = new DataSet.dsObj();
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

        }
        #endregion


        //загрузка владельца
        private bool LoadtAbn()
        {
            this.SelectSqlData(dsObj1, dsObj1.tAbn, true, "where id = " + IDABN.ToString());
            DataRow[] row = dsObj1.tAbn.Select("id = " + IDABN.ToString());
            if (row.Length <= 0) return false;
            txtCodeAbonent.Text = row[0]["CodeABonent"].ToString();
            txtAbn.Text = row[0]["Name"].ToString();
            return true;
        }

        //загрузка родительского объекта
        private bool LoadtAbnObj1()
        {
            this.SelectSqlDataTableOther(dsObj1, dsObj1.tAbnObj1, "tAbnObj", true, "where id = " + IDOBJPARENT.ToString());
            DataRow[] row = dsObj1.tAbnObj1.Select();
            if (row.Length <= 0) return false;
            txtParent.Text = row[0]["Name"].ToString();
            return true;
        }

        //загрузка карты
        private void LoadtMapObj()
        {

         if (dsObj1.tAbnObj.Rows[0]["idmap"] == DBNull.Value)
            {
                groupBoxAddress.Enabled = true;
                return;
            }
                      this.SelectSqlData(dsObj1, dsObj1.tMapObj, true, " where idMap = " + dsObj1.tAbnObj.Rows[0]["idmap"].ToString());

                      txtHouse.Text = dsObj1.tMapObj.Rows[0]["House"].ToString();
                      txtHousePrefix.Text = dsObj1.tMapObj.Rows[0]["HousePrefix"].ToString();

            // получим Улицу
                      this.SelectSqlData(dsObj1, dsObj1.tR_KladrStreet, true, " where id = " + dsObj1.tMapObj.Rows[0]["Street"].ToString());
            // получим нас пункт
                      this.SelectSqlData(dsObj1, dsObj1.tR_KladrObj, true, " where id = " + dsObj1.tR_KladrStreet.Rows[0]["KladrObjId"].ToString());
            int punkt = -1;
            int raionObl = -1;
            int obl = -1;
            //if (dsObj1.tR_KladrObj.Rows[0]["PrimaryKey"].ToString() == "punct") // нас пункт
            //{
                punkt = (int)dsObj1.tR_KladrStreet.Rows[0]["KladrObjId"];
                this.SelectSqlData(dsObj1, dsObj1.tR_KladrObj, true, " where id = " +
                    dsObj1.tR_KladrObj.Rows[0]["ParentId"].ToString());
                raionObl = (int)dsObj1.tR_KladrObj.Rows[0]["Id"];
                obl = (int)dsObj1.tR_KladrObj.Rows[0]["ParentId"];
            //}
            //else  // район/город   (в области не может быть просто улицы)
            //{
            //    raionObl = (int)dsObj1.tR_KladrObj.Rows[0]["Id"];
            //    obl = (int)dsObj1.tR_KladrObj.Rows[0]["ParentId"];
            //}

            cmbObl.SelectedValue = obl;
            // загрузка районов/городов
            if (cmbObl.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbRaionObl.SelectedIndex = -1;
                cmbRaionObl.SelectedValue = raionObl;
            }

            if ((cmbRaionObl.SelectedIndex >= 0) && (punkt >= 0))
            {
                this.SelectSqlData(dsPunkts, dsPunkts.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbCity.SelectedIndex = -1;
                cmbCity.SelectedValue = punkt;
            }

            txtIndex.Text = dsObj1.tMapObj.Rows[0]["Index"].ToString();
            if (dsObj1.tMapObj.Rows[0]["Raion"] != DBNull.Value)
                cmbRaionCity.SelectedValue = Convert.ToInt32(dsObj1.tMapObj.Rows[0]["Raion"]);
            cmbStreet.SelectedValue = Convert.ToInt32(dsObj1.tMapObj.Rows[0]["Street"]);
        }

        //выбор родительского объекта
        private void btnObjParent_Click(object sender, EventArgs e)
        {
            FormObjSelect fSelect = new FormObjSelect(-1, 0, FormObjSelect.SelectionMethod.Many);
            fSelect.SqlSettings = this.SqlSettings;
            fSelect.ShowDialog();
            IDOBJPARENT = fSelect.idObjPar;
            LoadtAbnObj1();
        }

        // сохранение объекта с параметрами
        private void buttonOK_Click(object sender, EventArgs e)
        {
//            if (!CheckAbnObj())
//                return;

            IDMAP = FindIdMap();    //получаем код карты

            if (IDMAP == -1)
            {
                MessageBox.Show("Не удается создать объект - дом");
                return;
            }

            switch (actAbnObj)
            {
                case ActionAbnObj.Add: 
                    int abnObj = InsertIntotAbnObj();
                    if (abnObj < 0)
                    {
                        MessageBox.Show("Не удается создать объект");
                        return;
                    }
                    if (InsertIntotAbnObjReg() < 0)
                    {
                        MessageBox.Show("Не удается создать характеристики");
                        return;
                    }
                    break;
                case ActionAbnObj.Edit: 
                case ActionAbnObj.Read: 
                    if (actAbnObj == ActionAbnObj.Edit)
                        if (!UpdatetAbnObj())
                        {
                            MessageBox.Show("Не удается отредактировать объект");
                            return;
                        }

                    switch (actAbnObjReg)
                    {
                        case ActionAbnObjReg.Add:
                            if (InsertIntotAbnObjReg() < 0)
                            {
                                MessageBox.Show("Не удается создать новые характеристики");
                                return;
                            }
                            break;
                        case ActionAbnObjReg.Edit: 
                            if (!UpdatetAbnObjReg())
                            {
                                MessageBox.Show("Не удается редактировать характеристики");
                                return;
                            }
                            break;
                        default: break;
                    }
                    break;
                default: break;
            }

            this.DialogResult = DialogResult.OK;
        }
        //получаем код карты
        private int FindIdMap()
        {
            string housePrefix = (String.IsNullOrEmpty(txtHousePrefix.Text)) ?
                " and HousePrefix is null " : " and HousePrefix = '" + txtHousePrefix.Text + "'";
            this.SelectSqlData(dsObj1, dsObj1.tMapObj, true, "where Street = " + cmbStreet.SelectedValue.ToString() +
                " and House = " + txtHouse.Text + housePrefix + " and IsHouse = 1 and Name is null");

            if (dsObj1.tMapObj.Rows.Count > 0) // есть такой дом (создавать не надо)
            {
                dsObj1.tMapObj.Rows[0]["Index"] = txtIndex.Text;
                dsObj1.tMapObj.Rows[0]["Raion"] = (cmbRaionCity.SelectedValue == null) ? DBNull.Value : cmbRaionCity.SelectedValue;
                dsObj1.tMapObj.Rows[0].EndEdit();
                if (this.UpdateSqlData(dsObj1, dsObj1.tMapObj))
                    return Convert.ToInt32(dsObj1.tMapObj.Rows[0]["idMap"]);
                else
                    return -1;
            }
            else
            {
                DataRow dr = dsObj1.tMapObj.NewRow();
                dr["Raion"] = (cmbRaionCity.SelectedValue == null) ? DBNull.Value : cmbRaionCity.SelectedValue;
                dr["Street"] = cmbStreet.SelectedValue;
                dr["House"] = txtHouse.Text;
                if (!String.IsNullOrEmpty(txtHousePrefix.Text))
                    dr["HousePrefix"] = txtHousePrefix.Text;
                dr["IsHouse"] = true;
                dr["Index"] = txtIndex.Text;
                dr["Deleted"] = 0;
                dsObj1.tMapObj.Rows.Add(dr);

                dsObj1.tMapObj.Rows[0].EndEdit();
                return this.InsertSqlDataOneRow(dsObj1, dsObj1.tMapObj);
            }
        }

        // добавить объект в базу
        private int InsertIntotAbnObj()
        {
            dsObj1.tAbnObj.Rows[0]["idAbn"] = IDABN;
            if (String.IsNullOrEmpty(txtName.Text))
                dsObj1.tAbnObj.Rows[0]["Name"] = DBNull.Value;
            else
                dsObj1.tAbnObj.Rows[0]["Name"] = txtName.Text;

            if (IDOBJPARENT != null) dsObj1.tAbnObj.Rows[0]["IdObjParent"] =  IDOBJPARENT; //IDOBJPARENT;
            dsObj1.tAbnObj.Rows[0]["idMap"] = IDMAP;
            dsObj1.tAbnObj.Rows[0].EndEdit();
            return this.InsertSqlDataOneRow(dsObj1, dsObj1.tAbnObj);
        }
        //редактировать объект
        private bool UpdatetAbnObj()
        {
            if (String.IsNullOrEmpty(txtName.Text))
                dsObj1.tAbnObj.Rows[0]["Name"] = DBNull.Value;
            else
                dsObj1.tAbnObj.Rows[0]["Name"] = txtName.Text;
            dsObj1.tAbnObj.Rows[0]["IdObjParent"] = IDOBJPARENT;
            dsObj1.tAbnObj.Rows[0]["idMap"] = IDMAP;
            dsObj1.tAbnObj.Rows[0].EndEdit();
            return this.UpdateSqlData(dsObj1, dsObj1.tAbnObj);
        }
        // добавить параметры
        private int InsertIntotAbnObjReg()
        {
            dateTimePickerDateChange.Value = dateTimePickerDateChange.Value.Date;
          //  dsObj1.tAbnObjReg.Rows[0]["idAbnObj"] = ID;
            dsObj1.tAbnObjReg.Rows[0]["idAbn"] = dsObj1.tAbnObj.Rows[0]["idAbn"];
            dsObj1.tAbnObjReg.Rows[0].EndEdit();
            return this.InsertSqlDataOneRow(dsObj1, dsObj1.tAbnObjReg);
        }
        // редактировать параметры
        private bool UpdatetAbnObjReg()
        {
            dateTimePickerDateChange.Value = dateTimePickerDateChange.Value.Date;
            dsObj1.tAbnObjReg.Rows[0]["idAbnObj"] = ID;
            dsObj1.tAbnObjReg.Rows[0]["idAbn"] = dsObj1.tAbnObj.Rows[0]["idAbn"];
            dsObj1.tAbnObjReg.Rows[0].EndEdit();
            return this.UpdateSqlData(dsObj1, dsObj1.tAbnObjReg);
        }
        private void EnabledObjControls(bool b)
        {
            txtName.Enabled = b;
            txtCodeAbonent.Enabled = b;
            txtAbn.Enabled = b;
            cmbWorker.Enabled = b;
            txtComment.Enabled = b;
            txtParent.Enabled = b;
//            btnObjParent.Enabled = b;           
            groupBoxAddress.Enabled = b;
        }
        private void EnabledObjControlsReg(bool b)
        {
            AbnNetComboBox.Enabled = b;
            abnSaleComboBox.Enabled = b;
            statusNameComboBox.Enabled = b;
            categoryComboBox.Enabled = b;
            dateTimePickerDateChange.Enabled = b;
            commentRichTextBox.Enabled = b;
            regimeTextBox.Enabled = b;
            kLossTextBox.Enabled = b;
            powerSetTextBox.Enabled = b;
            powerOtherTextBox.Enabled = b;
            powerFactTextBox.Enabled = b;
        }




 
 
    }
}
