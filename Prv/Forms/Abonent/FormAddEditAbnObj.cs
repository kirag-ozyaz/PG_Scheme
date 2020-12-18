using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prv.Forms.Abonent
{
    /// <summary>
    /// Форма добавления/редактирования/просмотра объекта и его характеристик.
    /// </summary>
    public partial class FormAddEditAbnObj : FormLbr.FormBase
    {
        /// <summary>
        /// Действия над объктом
        /// </summary>
        public enum ActionAbnObj
        {
            /// <summary>
            /// Добавить
            /// </summary>
            Add,
            /// <summary>
            /// Редактировать
            /// </summary>
            Edit,
            /// <summary>
            /// Просмотр
            /// </summary>
            Read
        }
        /// <summary>
        /// Действия над характерситиками объекта
        /// </summary>
        public enum ActionAbnObjReg
        {
            /// <summary>
            /// Добавить
            /// </summary>
            Add,
            /// <summary>
            /// Редактировать
            /// </summary>
            Edit,
            /// <summary>
            /// Просмотр
            /// </summary>
            Read
        }

        private int idAbn = -1;         // id абонента
        private int idAbnObj = -1;      // id объекта
        private int idAbnObjReg = -1;   // id истории объекта

        private ActionAbnObj actAbnObj;         // действия над объектом
        private ActionAbnObjReg actAbnObjReg;   // действия над харак-ами

        #region Constructors
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAddEditAbnObj()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Контсрутор с параметрами
        /// </summary>
        /// <param name="abn">id абонента</param>
        /// <param name="idObj">id объекта (если новый, то -1)</param>
        /// <param name="actObj">действие над объектом</param>
        /// <param name="idObjReg">id характеристики объекта (если новая, то -1)</param>
        /// <param name="actObjReg">действия над характеристикой</param>
        public FormAddEditAbnObj(int abn, int idObj, ActionAbnObj actObj, int idObjReg, ActionAbnObjReg actObjReg)
        {
            InitializeComponent();
            idAbn = abn;
            idAbnObj = idObj;
            idAbnObjReg = idObjReg;
            actAbnObj = actObj;
            actAbnObjReg = actObjReg;

            switch (actAbnObj)
            {
                case ActionAbnObj.Add:  // Добавить объект
                    this.Text = "Новый объект";
                    actAbnObjReg = ActionAbnObjReg.Add; // на всякий случай
                    break;
                case ActionAbnObj.Edit: // Редактировать объект
                    this.Text = "Редактировать объект";
                    if (actAbnObjReg == ActionAbnObjReg.Read) // просмотр характеристик
                        EnabledObjRegControls(false);
                    break;
                case ActionAbnObj.Read:  // Просмотр
                    groupBoxAddress.Enabled = false;
                    switch (actAbnObjReg)
                    {
                        case ActionAbnObjReg.Add: // добавить хар-ку
                            this.Text = "Новые характеристики";
                            break;
                        case ActionAbnObjReg.Edit:
                            this.Text = "Редактировать харак-ки";
                            break;
                        case ActionAbnObjReg.Read:
                            this.Text = "Просмотр";
                            EnabledObjRegControls(false);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

        }
        private void EnabledObjRegControls(bool b)
        {
            cmbAbnNet.Enabled = b;
            cmbAbnSale.Enabled = b;
            txtCountPeoples.Enabled = b;
            txtCountRooms.Enabled = b;
            txtSquare.Enabled = b;
            txtPowerSet.Enabled = b;
            dateTimePickerDateChange.Enabled = b;
            richTextBoxComment.Enabled = b;
        }
        #endregion

        #region FormAddEditAbnObj Events
        private void FormAddEditAbnObj_Load(object sender, EventArgs e)
        {
            if (!LoadtAbn()) // загрузка абонента, сбытовых и сетевых организаций
            {
                MessageBox.Show("Не найден абонент");
                this.Close();
            }

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

            InitAbnObj();
        }
        #endregion

        // Инициализация
        private bool InitAbnObj()
        {
            switch (actAbnObj)
            {
                case ActionAbnObj.Add:  // НОВЫЙ ОБЪЕКТ
                    dsPrv.tAbnObj.Rows.Add(dsPrv.tAbnObj.NewRow());
                    NewAbnObjReg();
                    break;
                case ActionAbnObj.Edit: // РЕДАКТИРОВАТЬ ОБЪЕКТ
                case ActionAbnObj.Read: // ПРОСМОТР ОБЪЕКТА
                    if (!LoadAbnObj())  //загука текущего объекта
                    {
                        MessageBox.Show("Невозможно загрузить объект");
                        return false;
                    }
                    LoadtMapObj();  // Загрузка MapObj
                    switch (actAbnObjReg)  //действия над характеристиками
                    {
                        case ActionAbnObjReg.Add: // новая
                            NewAbnObjReg();
                            break;
                        case ActionAbnObjReg.Edit: // редактирование истории
                        case ActionAbnObjReg.Read: // просмотр истории
                            if (!LoadAbnObjReg())
                            {
                                if (MessageBox.Show("Невозможно загрузить характеристики\n" +
                                    "Создать новые характеристики?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    NewAbnObjReg();
                                else
                                    return true;
                            }
                            break;
                        default: break;
                    }
                    break;
                default: break;
            }
            return true;
        }
        // Новая история объекта
        private void NewAbnObjReg()
        {
            DataRow dr = dsPrv.tAbnObjReg.NewRow();
            dr["idAbn"] = idAbn;
            dr["idAbnObj"] = 0;
            dr["idAbnNet"] = 0;
            dr["idAbnSale"] = 0;
            dr["DateChange"] = System.DateTime.Now.Date;
            dr["CalcLoss"] = 0;
            dr["SubNet"] = 0;
            dsPrv.tAbnObjReg.Rows.Add(dr);
        }

        #region LoadData
        // загрзка абонета, сетевых и сбытовых организаций
        private bool LoadtAbn()
        {
            this.SelectSqlData(dsPrv, dsPrv.tAbn, true, "where id = " + idAbn.ToString() + " or TypeAbn in (" +
                Constants.Constants.TypeAbnNet.ToString() + "," + Constants.Constants.TypeAbnSale.ToString() + ") and deleted = 0");

            bindingSourceAbnNet.Filter = "TypeAbn = " + Constants.Constants.TypeAbnNet.ToString();      // сетевые организации
            bindingSourceAbnSale.Filter = "TypeAbn = " + Constants.Constants.TypeAbnSale.ToString();    // сбытовые организации
            DataRow[] dr = dsPrv.tAbn.Select("id = " + idAbn.ToString());
            if (dr.Length <= 0) return false;
            txtCodeAbonent.Text = dr[0]["CodeABonent"].ToString();
            txtFIO.Text = dr[0]["Name"].ToString();
            return true;
        }
        // загрузка объекта
        private bool LoadAbnObj()
        {
            if (this.SelectSqlData(dsPrv, dsPrv.tAbnObj, true, " where id = " + idAbnObj.ToString()))
            {
                if (dsPrv.tAbnObj.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        // загрузка истории объекта
        private bool LoadAbnObjReg()
        {
            if (this.SelectSqlData(dsPrv, dsPrv.tAbnObjReg, true, " where id = " + idAbnObjReg.ToString()))
            {
                if (dsPrv.tAbnObjReg.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        // загрузка mapObj
        private void LoadtMapObj()
        {
            if (dsPrv.tAbnObj.Rows[0]["idmap"] == DBNull.Value)
            {
                groupBoxAddress.Enabled = true;
                return;
            }
            this.SelectSqlData(dsPrv, dsPrv.tMapObj, true, " where idMap = " + dsPrv.tAbnObj.Rows[0]["idmap"].ToString());

            txtHouse.Text = dsPrv.tMapObj.Rows[0]["House"].ToString();
            txtHousePrefix.Text = dsPrv.tMapObj.Rows[0]["HousePrefix"].ToString();

            // получим Улицу
            this.SelectSqlData(dsPrv, dsPrv.tR_KladrStreet, true, " where id = " + dsPrv.tMapObj.Rows[0]["Street"].ToString());
            // получим нас пункт
            this.SelectSqlData(dsPrv, dsPrv.tR_KladrObj, true, " where id = " + dsPrv.tR_KladrStreet.Rows[0]["KladrObjId"].ToString());
            int punkt = -1;
            int raionObl = -1;
            int obl = -1;
            int levelPunkt = 2;

            punkt = (int)dsPrv.tR_KladrStreet.Rows[0]["KladrObjId"];
            try
            {
                levelPunkt = (int)dsPrv.tR_KladrObj.Rows[0]["level"];
            }
            catch { }
            this.SelectSqlData(dsPrv, dsPrv.tR_KladrObj, true, " where id = " + dsPrv.tR_KladrObj.Rows[0]["ParentId"].ToString());
            // id области
            raionObl = (int)dsPrv.tR_KladrObj.Rows[0]["Id"];
            // id страны
            obl = (int)dsPrv.tR_KladrObj.Rows[0]["ParentId"];
            // установим Ульяновскую область
            cmbObl.SelectedIndex = 0;

            if (levelPunkt == 2 || levelPunkt == 3)
            {
                obl = raionObl;
                raionObl = punkt;
                punkt = -1;
            }

            cmbObl.SelectedValue = obl;
            cmbRaionObl.SelectedValue = raionObl;
            cmbCity.SelectedValue = punkt;

            txtIndex.Text = dsPrv.tMapObj.Rows[0]["Index"].ToString();
            if (dsPrv.tMapObj.Rows[0]["Raion"] != DBNull.Value)
                cmbRaionCity.SelectedValue = Convert.ToInt32(dsPrv.tMapObj.Rows[0]["Raion"]);
            cmbStreet.SelectedValue = Convert.ToInt32(dsPrv.tMapObj.Rows[0]["Street"]);
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

        // Принять изменения
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!CheckAbnObj())
                return;

            int idMap = FindIdMap();    //получаем код карты

            if (idMap == -1)
            {
                MessageBox.Show("Не удается создать объект - дом");
                return;
            }

            switch (actAbnObj)
            {
                case ActionAbnObj.Add: // НОВЫЙ ОБЪЕКТ
                    int abnObj = InsertIntotAbnObj(idMap);
                    if (abnObj < 0)
                    {
                        MessageBox.Show("Не удается создать объект");
                        return;
                    }
                    if (InsertIntotAbnObjReg(abnObj) < 0)
                    {
                        MessageBox.Show("Не удается создать характеристики");
                        return;
                    }
                    break;
                case ActionAbnObj.Edit: // РЕДАКТИРОВАТЬ ОБЪЕКТ
                case ActionAbnObj.Read: // Просмтор
                    if (actAbnObj == ActionAbnObj.Edit)
                        if (!UpdatetAbnObj(idMap))
                        {
                            MessageBox.Show("Не удается отредактировать объект");
                            return;
                        }

                    switch (actAbnObjReg)
                    {
                        case ActionAbnObjReg.Add: // новая
                            if (InsertIntotAbnObjReg(Convert.ToInt32(dsPrv.tAbnObj.Rows[0]["id"])) < 0)
                            {
                                MessageBox.Show("Не удается создать новые характеристики");
                                return;
                            }
                            break;
                        case ActionAbnObjReg.Edit: // EDIT
                            if (!UpdatetAbnObjReg(Convert.ToInt32(dsPrv.tAbnObj.Rows[0]["id"])))
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
        // проверка заполнености объекта
        private bool CheckAbnObj()
        {
            if (actAbnObj != ActionAbnObj.Read)
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
                if (String.IsNullOrEmpty(txtHouse.Text))
                {
                    MessageBox.Show("Не указан номер дома");
                    return false;
                }

            }
            if (actAbnObjReg != ActionAbnObjReg.Read)
            {
                if (cmbAbnNet.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбрана сетевая организация");
                    return false;
                }
                if (cmbAbnSale.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбрана сбытовая организация");
                    return false;
                }
                if (String.IsNullOrEmpty(txtCountRooms.Text))
                {
                    MessageBox.Show("Не указано кол-во комнат");
                    return false;
                }
                if (String.IsNullOrEmpty(txtCountPeoples.Text))
                {
                    MessageBox.Show("Не указано кол-во проживающих");
                    return false;
                }
                if (String.IsNullOrEmpty(txtSquare.Text))
                {
                    MessageBox.Show("Не указана площадь");
                    return false;
                }

                /*if (String.IsNullOrEmpty(txtPowerSet.Text))
                {
                    MessageBox.Show("Не указана установленная мощность");
                    return false;
                }*/
                // Мощность не у всех
            }
            return true;
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

        // Добавить объект в базу
        private int InsertIntotAbnObj(int idMap)
        {
            dsPrv.tAbnObj.Rows[0]["idAbn"] = idAbn;
            if (String.IsNullOrEmpty(txtName.Text))
                dsPrv.tAbnObj.Rows[0]["Name"] = DBNull.Value;
            else
                dsPrv.tAbnObj.Rows[0]["Name"] = txtName.Text;
            dsPrv.tAbnObj.Rows[0]["typeObj"] = (int)Constants.KontragentObjType.AbnObjFL;
            dsPrv.tAbnObj.Rows[0]["idMap"] = idMap;
            dsPrv.tAbnObj.Rows[0].EndEdit();
            return this.InsertSqlDataOneRow(dsPrv, dsPrv.tAbnObj);
        }
        //Редактировать объект
        private bool UpdatetAbnObj(int idMap)
        {
            if (String.IsNullOrEmpty(txtName.Text))
                dsPrv.tAbnObj.Rows[0]["Name"] = DBNull.Value;
            else
                dsPrv.tAbnObj.Rows[0]["Name"] = txtName.Text;
            dsPrv.tAbnObj.Rows[0]["idMap"] = idMap;
            dsPrv.tAbnObj.Rows[0].EndEdit();
            return this.UpdateSqlData(dsPrv, dsPrv.tAbnObj);
        }
        // добавить хар=ки
        private int InsertIntotAbnObjReg(int AbnObj)
        {
            dateTimePickerDateChange.Value = dateTimePickerDateChange.Value.Date;
            dsPrv.tAbnObjReg.Rows[0]["idAbnObj"] = AbnObj;
            dsPrv.tAbnObjReg.Rows[0].EndEdit();
            return this.InsertSqlDataOneRow(dsPrv, dsPrv.tAbnObjReg);
        }
        // редактировать хар-ки
        private bool UpdatetAbnObjReg(int AbnObj)
        {
            dateTimePickerDateChange.Value = dateTimePickerDateChange.Value.Date;
            dsPrv.tAbnObjReg.Rows[0]["idAbnObj"] = AbnObj;
            dsPrv.tAbnObjReg.Rows[0].EndEdit();
            return this.UpdateSqlData(dsPrv, dsPrv.tAbnObjReg);
        }
    }
}
