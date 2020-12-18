using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;
using System.Drawing.Imaging;
using FormLbr.Classes;
using System.Data.SqlClient;
using System.Xml;
using System.Globalization;
using System.Xml.Serialization;
using System.IO;

namespace Legal.Forms.Object
{
    public partial class FormObjAE : FormLbr.FormBase
    {
        private DataRow drAddImg;
        public int OBJSELECT;
        System.Diagnostics.Process proc = new System.Diagnostics.Process();
        bool st = false; 


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
        private int idAbnObjParent = -1; // id родительского объекта
        private int idAbnObjSame = -1;  // id объекта, который рассчитывается в другом абоненте

        private ActionAbnObj actAbnObj;         // действия над объектом
        private ActionAbnObjReg actAbnObjReg;   // действия над харак-ами

        public FormObjAE()
        {
            InitializeComponent();

            toolStripTP.Enabled = false; // не надо больше здесь ничего редактировать. пусть привязка идет к схеме напрямую
        }

        public FormObjAE(int abn, int idObj, ActionAbnObj actObj, int idObjReg, ActionAbnObjReg actObjReg)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

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
                    tabControlLuinkSchmAbnObj.Visible = false;
                    //groupBoxTP.Visible = false;
                    groupBoxLoss.Visible = false;
                    break;
                case ActionAbnObj.Edit: // Редактировать объект
                    this.Text = "Редактировать объект";
                    //if (actAbnObjReg == ActionAbnObjReg.Read) // просмотр характеристик
                    //    EnabledObjRegControls(false);
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
                            break;
                        default: 
                            break;
                    }
                    break;
                default:                
                    break;
            }

        }

        // загрузка источников данных для контролов
        private void FormObjAE_Load(object sender, EventArgs e)
        {
            string userNameWin = System.Environment.UserName;
            if ((userNameWin.ToLower() == "per") || (userNameWin.ToLower() == "kostjaevaev"))   
                PowerSetNUD.Enabled = true;
            else
                PowerSetNUD.Enabled = false;

            GetVisibleTabePageODS();
            // загрузка контролеров
            this.SelectSqlData(dsAbn, dsAbn.vWorkerGroup, true, " where idGroup = " + Constants.Constants.WorkerGroupMasterUL.ToString());

            // загрузка cетевой организации
            this.SelectSqlDataTableOther(dsAbn, dsAbn.vAbnNet, "vAbn", true, "where deleted = 0 and typeAbn = " + ((int)Constants.AbnType.Net).ToString());

            // загрузка сбытовой организации
            this.SelectSqlDataTableOther(dsAbn, dsAbn.vAbnSale, "vAbn", true, "where deleted = 0 and typeAbn = " + ((int)Constants.AbnType.Sale).ToString());

            // загрзузка обслуживающей организации
            LoadCmbServicing();

            // загрузка статуса
            this.SelectSqlData(dsAbn, dsAbn.vAbnObjStatus, true);

            // загрузка категории
            InitCategoryCmb();

            // загрузка тарифов
            this.SelectSqlDataTableOther(dsAbn, dsAbn.tR_Classifier_Tariff, "tR_Classifier", true, " where ParentKey like ';SKUEE;Tariff;TariffLeg;%' and isGroup = 0 and deleted = 0");

            // загрузка номеров разрешений ТП
            NumRazr_Load();

            if (!LoadtAbn()) // загрузка абонента, сбытовых и сетевых организаций
            {
                MessageBox.Show("Не найден абонент");
                this.Close();
            }

            // загрузка областей
            this.SelectSqlData(dsObl, dsObl.Tables["tR_KladrObj"], true,
                " where Level = 1 and deleted = 0 and KladrCode is not null order by name, socr");

            if (cmbObl.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where (Level Between 2 and 3) and deleted = 0 order by name, socr");
                cmbRaionObl.Text = "Ульяновск г";
            }

            // загрузка сканов
            SelectSqlData(dsAbn, dsAbn.tAbnObj_Image, true, "where idAbnObj=" + idAbnObj.ToString() + " order by id asc");
            if (dsAbn.tAbnObj_Image.Count > 0)
            {
                for (int i = 0; i < dsAbn.tAbnObj_Image.Count; i++)
                {
                    if (dsAbn.tAbnObj_Image.Rows[i]["Scan"] != System.DBNull.Value)
                        LoadDataToGridImages((byte[])dsAbn.tAbnObj_Image.Rows[i]["Scan"], (int)dsAbn.tAbnObj_Image.Rows[i]["id"]);
                }
                if (dataGridViewImages.CurrentRow != null)
                    pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            // загрузка классификатора потребителей
            this.SelectSqlDataTableOther(dsLObj, dsLObj.tR_Classifier_ConsumerGroup, "tR_Classifier", true, " where ParentKey like ';Consumer;%' and isGroup <> 0 and deleted = 0 and id <> 783");
//            this.SelectSqlDataTableOther(dsLObj, dsLObj.tR_Classifier_Consumer, "tR_Classifier", true, " where ParentKey like ';Consumer;%' and isGroup = 0 and deleted = 0 order by Name");

            this.SelectSqlDataTableOther(dsLObj, dsLObj.tR_Classifier_Consumer, "tR_Classifier", true, " where ParentKey like '" + dsLObj.tR_Classifier_ConsumerGroup[(int)cmbConsumerGroup.SelectedIndex]["ParentKey"] + "' and isGroup = 0 and deleted = 0");

            LoadLinkSchmAbn();

            InitAbnObj();
        }

        private void InitCategoryCmb()
        {
            DataTable dt = new DataTable("tR_Classifier");
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));

            categoryComboBox.DataSource = dt;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "id";
            this.SelectSqlData(dt, true, @" WHERE (ParentKey = ';SKUEE;Category;') AND (IsGroup = 0)
                                            ORDER BY Name");
        }
        private void GetVisibleTabePageODS()
        {
#if DEBUG
            //tabControl1.TabPages.Remove(tabPageODS);
#else
            DataTable dt = new DataTable("tUser");
            dt.Columns.Add("idUser", typeof(int));
            this.SelectSqlData(dt, true, @" left join vworkergroup w on w.id = tuser.idWorker
                                where w.ParentKey = ';GroupWorker;Dispatchers;' and tuser.login = SYSTEM_USER");
            if (dt.Rows.Count == 0)
                tabControl1.TabPages.Remove(tabPageODS);
#endif
        }

        // загрузка данных владельца объекта
        private bool LoadtAbn()
        {
            this.SelectSqlData(dsAbn, dsAbn.tAbn, true, "where id = " + idAbn.ToString() );

            DataRow[] dr = dsAbn.tAbn.Select("id = " + idAbn.ToString());
            if (dr.Length <= 0) return false;
            txtCodeAbonent.Text = dr[0]["CodeABonent"].ToString();
            txtAbn.Text = dr[0]["Name"].ToString();
            return true;
        }

        // менеджер формы
        private bool InitAbnObj()
        {
            switch (actAbnObj)
            {
                case ActionAbnObj.Add:  // новый объект
                    dsAbn.tAbnObj.Rows.Add(dsAbn.tAbnObj.NewRow());
                    NewAbnObjConnect();
                    NewAbnObjReg();
                    break;
                case ActionAbnObj.Edit: // редактировать объект
                case ActionAbnObj.Read: // просмотр объекта
                    if (!LoadAbnObj())  //загрузка текущего объекта
                    {
                        MessageBox.Show("Невозможно загрузить объект");
                        return false;
                    }
                    LoadtMapObj();  // загрузка MapObj
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

        // загрузка данных из tAbnObj, tConnect, vG_AbnObjKLossTrans
        private bool LoadAbnObj()
        {
            if (this.SelectSqlData(dsAbn, dsAbn.tAbnObj, true, " where id = " + idAbnObj.ToString()))
            {
                if (dsAbn.tAbnObj.Rows.Count > 0)
                {
                    txtName.Text = dsAbn.tAbnObj.Rows[0]["Name"].ToString();
                    txtShortName.Text = dsAbn.tAbnObj.Rows[0]["ShortName"].ToString();

                    if (dsAbn.tAbnObj.Rows[0]["IdObjParent"] != DBNull.Value)
                    {
                        idAbnObjParent = (int)dsAbn.tAbnObj.Rows[0]["IdObjParent"];
                        LoadtAbnObjParent();
                    }

                    // загрузка подключений
                    SelectSqlData(dsAbn, dsAbn.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc");
                    dgvTP.Columns[0].Visible = false;

                    // загрузка потерь
                    SelectSqlData(dsAbn.vG_AbnObjKLossTrans, true, "where idAbnObj = " + idAbnObj.ToString() + " and Year = " + DateTime.Today.Year.ToString(), null, false, 1);
                    if (dsAbn.vG_AbnObjKLossTrans.Rows.Count > 0)
                    {
                        dgvLoss.Rows.Add(new object[] { "Январь", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M1"].ToString() });
                        dgvLoss.Rows.Add(new object[] { "Февраль", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M2"].ToString() });
                        dgvLoss.Rows.Add(new object[] { "Март", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M3"].ToString() });
                        dgvLoss.Rows.Add(new object[] { "Апрель", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M4"].ToString() });
                        dgvLoss.Rows.Add(new object[] { "Май", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M5"].ToString() });
                        dgvLoss.Rows.Add(new object[] { "Июнь", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M6"].ToString() });
                        dgvLoss.Rows.Add(new object[] { "Июль", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M7"].ToString() });
                        dgvLoss.Rows.Add(new object[] { "Август", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M8"].ToString() });
                        dgvLoss.Rows.Add(new object[] { "Сентябрь", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M9"].ToString() });
                        dgvLoss.Rows.Add(new object[] { "Октябрь", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M10"].ToString() });
                        dgvLoss.Rows.Add(new object[] { "Ноябрь", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M11"].ToString() });
                        dgvLoss.Rows.Add(new object[] { "Декабрь", dsAbn.vG_AbnObjKLossTrans.Rows[0]["M12"].ToString() });
                    }

                    // загрузка данных по последним замерам
                    SelectSqlData(dsObj1, dsObj1.tG_MeasurementsOfObject, true, "where idObj = " + idAbnObj.ToString() + "order by id desc"); 
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        // загрузка истории объекта
        private bool LoadAbnObjReg()
        {
            if (this.SelectSqlData(dsAbn, dsAbn.tAbnObjReg, true, " where id = " + idAbnObjReg.ToString()))
            {
                if (dsAbn.tAbnObjReg.Rows.Count > 0)
                {
                    AbnNetComboBox.SelectedValue = dsAbn.tAbnObjReg.Rows[0]["idAbnNet"];
                    abnSaleComboBox.SelectedValue = dsAbn.tAbnObjReg.Rows[0]["idAbnSale"];
                    abnServicingComboBox.SelectedValue = dsAbn.tAbnObjReg.Rows[0]["idAbnServicing"];
                    statusNameComboBox.SelectedValue = dsAbn.tAbnObjReg.Rows[0]["idStatus"];
                    categoryComboBox.SelectedValue = dsAbn.tAbnObjReg.Rows[0]["Category"];
                    TariffcomboBox.SelectedValue = dsAbn.tAbnObjReg.Rows[0]["idTariff"];
                    txtComment.Text = dsAbn.tAbnObjReg.Rows[0]["Comment"].ToString();
                    txtCommentODS.Text = dsAbn.tAbnObjReg.Rows[0]["CommentODS"].ToString();

                    if (dsAbn.tAbnObjReg.Rows[0]["ConsumerGroup"] != System.DBNull.Value)
                        cmbConsumerGroup.SelectedValue = dsAbn.tAbnObjReg.Rows[0]["ConsumerGroup"];

                    if (dsAbn.tAbnObjReg.Rows[0]["Consumer"] != System.DBNull.Value)
                        cmbConsumer.SelectedValue = dsAbn.tAbnObjReg.Rows[0]["Consumer"];

                    RegimeNUD.Value = (dsAbn.tAbnObjReg.Rows[0]["Regime"] == DBNull.Value) ? 0: Convert.ToInt16( dsAbn.tAbnObjReg.Rows[0]["Regime"]);
                    KLossNUD.Value = (dsAbn.tAbnObjReg.Rows[0]["KLoss"] == DBNull.Value) ? 0 : Convert.ToDecimal(dsAbn.tAbnObjReg.Rows[0]["KLoss"]);
                    PowerSetNUD.Value = (dsAbn.tAbnObjReg.Rows[0]["PowerSet"] == DBNull.Value) ? 0 : Convert.ToDecimal(dsAbn.tAbnObjReg.Rows[0]["PowerSet"]);
                    PowerOtherNUD.Value = (dsAbn.tAbnObjReg.Rows[0]["PowerOther"] == DBNull.Value) ? 0 : Convert.ToDecimal(dsAbn.tAbnObjReg.Rows[0]["PowerOther"]);
                    PowerFactNUD.Value = (dsAbn.tAbnObjReg.Rows[0]["PowerFact"] == DBNull.Value) ? 0 : Convert.ToDecimal(dsAbn.tAbnObjReg.Rows[0]["PowerFact"]);
                    PowerCalcNUD.Value = (dsAbn.tAbnObjReg.Rows[0]["PowerCalc"] == DBNull.Value) ? 0 : Convert.ToDecimal(dsAbn.tAbnObjReg.Rows[0]["PowerCalc"]);

                    cbxCalcLoss.Checked = Convert.ToBoolean(dsAbn.tAbnObjReg.Rows[0]["CalcLoss"]);

                    cbxSubNet.Checked = Convert.ToBoolean(dsAbn.tAbnObjReg.Rows[0]["SubNet"]);
                    txtSubNetComment.Text = dsAbn.tAbnObjReg.Rows[0]["SubNetComment"].ToString();

                    if (dsAbn.tAbnObjReg.Rows[0]["NumberTP"] != DBNull.Value)
                        cmbNumberTP.SelectedValue = dsAbn.tAbnObjReg.Rows[0]["NumberTP"];
                    else
                        cmbNumberTP.SelectedIndex = -1;
                    if (dsAbn.tAbnObjReg.Rows[0]["DateTP"] != DBNull.Value)
                        cmbDateTP.SelectedValue = dsAbn.tAbnObjReg.Rows[0]["DateTP"].ToString();
                    else
                        cmbDateTP.SelectedIndex = -1;
                    
                    txtNumberTU.Text = (dsAbn.tAbnObjReg.Rows[0]["NumberTU"] == DBNull.Value) ? "" : dsAbn.tAbnObjReg.Rows[0]["NumberTU"].ToString();
                    dtDateTU.Text = (dsAbn.tAbnObjReg.Rows[0]["DateTU"] == DBNull.Value) ? "" : dsAbn.tAbnObjReg.Rows[0]["DateTU"].ToString();

                    dtDatePowerFact.Text = (dsAbn.tAbnObjReg.Rows[0]["DatePowerFact"] == DBNull.Value) ? "" : dsAbn.tAbnObjReg.Rows[0]["DatePowerFact"].ToString();

                    if (dsAbn.tAbnObjReg.Rows[0]["idAbnObjSame"] != DBNull.Value)
                    {
                        idAbnObjSame = (int)dsAbn.tAbnObjReg.Rows[0]["idAbnObjSame"];
                        LoadtAbnObjSame();
                        //txtNumberTU.Click += (ss, ee) => { return; };
                    }

                    this.ApplyComment();

                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        // новая история объекта
        private void NewAbnObjReg()
        {
            DataRow dr = dsAbn.tAbnObjReg.NewRow();
            dr["idAbn"] = idAbn;
            dr["idAbnObj"] = 0;
            dr["idAbnNet"] = 0;
            dr["idAbnSale"] = 0;
            dr["CalcLoss"] = 0;
            dr["DateChange"] = System.DateTime.Now;
            dr["DateTU"] = DBNull.Value; 
            dsAbn.tAbnObjReg.Rows.Add(dr);
            AbnNetComboBox.SelectedValue = (int)ServiceOrg.Net;
            abnSaleComboBox.SelectedValue = (int)ServiceOrg.Sale;
            abnServicingComboBox.SelectedIndex = -1;
            TariffcomboBox.SelectedIndex = -1;
//            cmbConsumerGroup.SelectedIndex = -1;
//            cmbConsumer.SelectedIndex = -1;
        }

        // загрузка mapObj
        private void LoadtMapObj()
        {
            try
            {
                if (dsAbn.tAbnObj.Rows[0]["idmap"] == DBNull.Value)
                {
                    groupBoxAddress.Enabled = true;
                    return;
                }
                this.SelectSqlData(dsAbn, dsAbn.tMapObj, true, " where idMap = " + dsAbn.tAbnObj.Rows[0]["idmap"].ToString());

                txtHouse.Text = dsAbn.tMapObj.Rows[0]["House"].ToString();
                txtHousePrefix.Text = dsAbn.tMapObj.Rows[0]["HousePrefix"].ToString();
                txtAddressComment.Text = dsAbn.tMapObj.Rows[0]["Comment"].ToString();

                // получим улицу
                this.SelectSqlData(dsAbn, dsAbn.tR_KladrStreet, true, " where id = " + dsAbn.tMapObj.Rows[0]["Street"].ToString());

                if (dsAbn.tR_KladrStreet.Rows.Count == 0)
                {
                    MessageBox.Show("                  Отсутствует улица !!!\r\n \r\n Уточните и отредактируйте адрес объекта.");
                }
                else
                {
                    // получим город(район области)
                    this.SelectSqlData(dsAbn, dsAbn.tR_KladrObj, true, " where id = " + dsAbn.tR_KladrStreet.Rows[0]["KladrObjId"].ToString());

                    int punkt = -1;
                    int raionObl = -1;
                    int obl = -1;
                    int levelPunkt = 2;

                    // id города(района области)
                    punkt = (int)dsAbn.tR_KladrStreet.Rows[0]["KladrObjId"];
                    levelPunkt = (int)dsAbn.tR_KladrObj.Rows[0]["level"];
                    this.SelectSqlData(dsAbn, dsAbn.tR_KladrObj, true, " where id = " + dsAbn.tR_KladrObj.Rows[0]["ParentId"].ToString());
                    // id области
                    raionObl = (int)dsAbn.tR_KladrObj.Rows[0]["Id"];
                    // id страны
                    obl = (int)dsAbn.tR_KladrObj.Rows[0]["ParentId"];
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

                    // загрузка районов/городов
                    /*if (cmbObl.SelectedIndex >= 0)
                    {
                        if (levelPunkt == 2 || levelPunkt == 3)
                        {
                            this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                            " where ParentId = " + cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
             
                            cmbRaionObl.SelectedIndex = -1;
                            cmbRaionObl.SelectedValue = punkt;
                        }
                    }*/

                    txtIndex.Text = dsAbn.tMapObj.Rows[0]["Index"].ToString();
                    if (dsAbn.tMapObj.Rows[0]["Raion"] != DBNull.Value)
                        cmbRaionCity.SelectedValue = Convert.ToInt32(dsAbn.tMapObj.Rows[0]["Raion"]);
                    cmbStreet.SelectedValue = Convert.ToInt32(dsAbn.tMapObj.Rows[0]["Street"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить адрес объекта\r\n" + ex.Message, ex.Source);
            }
        }

        // подключение для нового объекта
        private void NewAbnObjConnect()
        {
            DataRow dr = dsAbn.tConnect.NewRow();
            dr["idObj_old"] = 0;
            dr["UserName"] = System.Environment.UserName.ToString();
            dr["CompName"] = System.Environment.MachineName.ToString();
            dr["DataMod"] = System.DateTime.Now;
            dr["Deleted"] = true;
            dsAbn.tConnect.Rows.Add(dr);
        }

        // события при выборе реквизитов адреса
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
                cmbRaionObl.SelectedIndex = cmbRaionObl.FindString("Ульяновск", 0);

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
                // населенные пункты
                this.SelectSqlData(dsPunkts, dsPunkts.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbCity.SelectedIndex = -1;

                // районы города/населенного пункта
                DataSet.DataSetAbn dsTmp = new DataSet.DataSetAbn();
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

        // привязка к новому родительскому объекту
        private void btnObjParent_Click(object sender, EventArgs e)
        {
            Object.FormObj_Linking f = new Object.FormObj_Linking(idAbn, idAbnObjParent);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                idAbnObjParent = OBJSELECT;
                LoadtAbnObjParent();
            }
        }

        // сохранить изменения
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
            //int idMap = 0;
            switch (actAbnObj)
            {
                case ActionAbnObj.Add: // новый объект
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
                case ActionAbnObj.Edit: // редактировать объект
                case ActionAbnObj.Read: // просмотр
                    if (actAbnObj == ActionAbnObj.Edit)
                    {
                        if (!UpdatetAbnObj(idMap))
                        {
                            MessageBox.Show("Не удается отредактировать объект");
                            return;
                        }


                        if (InsertIntotAbnObjReg(Convert.ToInt32(dsAbn.tAbnObj.Rows[0]["id"])) < 0)
                        {
                            MessageBox.Show("Не удается создать характеристики");
                            return;
                        }
                    }
                    break;
                default: break;
            }

            this.DialogResult = DialogResult.OK;
            if (dataGridViewImages.Rows.Count > 0)
            {
                dataGridViewImages.Dispose();
                pbScanDoc.Image = null;
                GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

        // проверка заполнености объекта
        private bool CheckAbnObj()
        {
            if (actAbnObj != ActionAbnObj.Read)
            {

                if (String.IsNullOrEmpty(txtName.Text))
                 {
                     MessageBox.Show("Нет названия объекта");
                     return false;
                 }
            
                //if (cmbObl.SelectedIndex < 0)
                //{
                //    MessageBox.Show("Не выбрана область");
                //    return false;
                //}
                //if (cmbRaionObl.SelectedIndex < 0)
                //{
                //    MessageBox.Show("Не выбран район/город");
                //    return false;
                //}
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
                if (AbnNetComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбрана сетевая организация");
                    return false;
                }
                if (abnSaleComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбрана сбытовая организация");
                    return false;
                }
          
            }
            return true;
        }

        private int FindIdMap()
        {
            string housePrefix = (String.IsNullOrEmpty(txtHousePrefix.Text)) ?
                " and HousePrefix is null " : " and HousePrefix = '" + txtHousePrefix.Text + "'";
            this.SelectSqlData(dsAbn, dsAbn.tMapObj, true, "where Street = " + cmbStreet.SelectedValue.ToString() +
                " and House = " + txtHouse.Text + housePrefix + " and IsHouse = 1 and Name is null");

            if (dsAbn.tMapObj.Rows.Count > 0) // есть такой дом (создавать не надо)
            {
                dsAbn.tMapObj.Rows[0]["Index"] = txtIndex.Text;
                dsAbn.tMapObj.Rows[0]["Comment"] = txtAddressComment.Text;
                dsAbn.tMapObj.Rows[0]["Raion"] = (cmbRaionCity.SelectedValue == null) ? DBNull.Value : cmbRaionCity.SelectedValue;
                dsAbn.tMapObj.Rows[0].EndEdit();
                if (this.UpdateSqlData(dsAbn, dsAbn.tMapObj))
                    return Convert.ToInt32(dsAbn.tMapObj.Rows[0]["idMap"]);
                else
                    return -1;
            }
            else
            {
                DataRow dr = dsAbn.tMapObj.NewRow();
                dr["Raion"] = (cmbRaionCity.SelectedValue == null) ? DBNull.Value : cmbRaionCity.SelectedValue;
                dr["Street"] = cmbStreet.SelectedValue;
                dr["House"] = txtHouse.Text;
                if (!String.IsNullOrEmpty(txtHousePrefix.Text))
                    dr["HousePrefix"] = txtHousePrefix.Text;
                dr["IsHouse"] = true;
                dr["Index"] = txtIndex.Text;
                dr["Deleted"] = 0;
                if (!String.IsNullOrEmpty(txtAddressComment.Text))
                    dr["Comment"] = txtAddressComment.Text;

                dsAbn.tMapObj.Rows.Add(dr);

                dsAbn.tMapObj.Rows[0].EndEdit();
                return this.InsertSqlDataOneRow(dsAbn, dsAbn.tMapObj);
            }
        }

        // добавить объект в базу
        private int InsertIntotAbnObj(int idMap)
        {
            dsAbn.tAbnObj.Rows[0]["idAbn"] = idAbn;
            if (String.IsNullOrEmpty(txtName.Text))
                dsAbn.tAbnObj.Rows[0]["Name"] = DBNull.Value;
            else
                dsAbn.tAbnObj.Rows[0]["Name"] = txtName.Text.Trim();

            if (String.IsNullOrEmpty(txtShortName.Text))
                dsAbn.tAbnObj.Rows[0]["ShortName"] = DBNull.Value;
            else
                dsAbn.tAbnObj.Rows[0]["ShortName"] = txtShortName.Text.Trim();

            dsAbn.tAbnObj.Rows[0]["idMap"] = idMap;

            if (String.IsNullOrEmpty(txtParent.Text))
                dsAbn.tAbnObj.Rows[0]["idObjParent"] = DBNull.Value;
            else
                dsAbn.tAbnObj.Rows[0]["idObjParent"] = idAbnObjParent;

            dsAbn.tAbnObj.Rows[0].EndEdit();
            return this.InsertSqlDataOneRow(dsAbn, dsAbn.tAbnObj);
        }

        // добавить характеристики объекта
        private int InsertIntotAbnObjReg(int AbnObj)
        {
            // 26.05.2015 дублируем статус объекта в таблице признаков объекта
            if (dsAbn.tAbnObjReg.Rows[0]["idStatus"] != DBNull.Value)
            {
                if (Convert.ToInt32(dsAbn.tAbnObjReg.Rows[0]["idStatus"]) == 1293)
                {
                    if (Convert.ToInt32(statusNameComboBox.SelectedValue) != 1293)
                        Update_tAbnObjFlags(AbnObj, 937, 1);
                }
                else
                {
                    if (Convert.ToInt32(statusNameComboBox.SelectedValue) == 1293)
                        Update_tAbnObjFlags(AbnObj, 937, 0);
                }
            }


            DataRow dr = dsAbn.tAbnObjReg.NewRow();

            dsAbn.tAbnObjReg.Rows.Clear();

            dr["idAbn"] = idAbn;
            dr["idAbnObj"] = AbnObj;
            dr["idAbnNet"] = (AbnNetComboBox.SelectedValue == null) ? DBNull.Value : AbnNetComboBox.SelectedValue;
            dr["idAbnSale"] = (abnSaleComboBox.SelectedValue == null) ? DBNull.Value : abnSaleComboBox.SelectedValue;
            dr["idAbnServicing"] = (abnServicingComboBox.SelectedValue == null) ? DBNull.Value : abnServicingComboBox.SelectedValue;
            dr["idStatus"] = (statusNameComboBox.SelectedValue == null) ? DBNull.Value : statusNameComboBox.SelectedValue;
            dr["Category"] = (categoryComboBox.SelectedValue == null) ? DBNull.Value : categoryComboBox.SelectedValue;
            dr["idTariff"] = (TariffcomboBox.SelectedValue == null) ? DBNull.Value : TariffcomboBox.SelectedValue;
            dr["Comment"] = txtComment.Text;
            dr["CommentODS"] = txtCommentODS.Text;
            dr["Regime"] = RegimeNUD.Value;
            dr["KLoss"] = KLossNUD.Value;
            dr["PowerSet"] = PowerSetNUD.Value;
            dr["PowerOther"] = PowerOtherNUD.Value;
            dr["PowerFact"] = PowerFactNUD.Value;
            dr["PowerCalc"] = PowerCalcNUD.Value;
            dr["CalcLoss"] = cbxCalcLoss.Checked;
            dr["DateChange"] = System.DateTime.Now;
            dr["ConsumerGroup"] = (cmbConsumerGroup.SelectedValue == null) ? DBNull.Value : cmbConsumerGroup.SelectedValue;
            dr["Consumer"] = (cmbConsumer.SelectedValue == null) ? DBNull.Value : cmbConsumer.SelectedValue;

            dr["SubNet"] = cbxSubNet.Checked;
            dr["SubNetComment"] = txtSubNetComment.Text;

            dr["NumberTP"] = (cmbNumberTP.SelectedValue == null) ? DBNull.Value : cmbNumberTP.SelectedValue;
            dr["DateTP"] = (cmbDateTP.SelectedValue == null) ? DBNull.Value : cmbDateTP.SelectedValue;
            if ((txtNumberTU.Text != null) & (txtNumberTU.Text != ""))
            {
                dr["NumberTU"] = Convert.ToInt32(txtNumberTU.Text);
                dr["DateTU"] = dtDateTU.Value.Date;
            }

            if (String.IsNullOrEmpty(txtObjectSame.Text))
                dr["idAbnObjSame"] = DBNull.Value;
            else
                dr["idAbnObjSame"] = idAbnObjSame;

            try
            {
                dr["CommentXML"] = this.CreateXmlComment().InnerXml;
            }
            catch { };

            dsAbn.tAbnObjReg.Rows.Add(dr);

            return this.InsertSqlDataOneRow(dsAbn, dsAbn.tAbnObjReg);
        }

        // редактировать объект
        private bool UpdatetAbnObj(int idMap)
        {
            if (String.IsNullOrEmpty(txtName.Text))
                dsAbn.tAbnObj.Rows[0]["Name"] = DBNull.Value;
            else
                dsAbn.tAbnObj.Rows[0]["Name"] = txtName.Text.Trim();

            if (String.IsNullOrEmpty(txtShortName.Text))
                dsAbn.tAbnObj.Rows[0]["ShortName"] = DBNull.Value;
            else
                dsAbn.tAbnObj.Rows[0]["ShortName"] = txtShortName.Text.Trim();
            
            dsAbn.tAbnObj.Rows[0]["idMap"] = idMap;

            if (String.IsNullOrEmpty(txtParent.Text))
                dsAbn.tAbnObj.Rows[0]["idObjParent"] = DBNull.Value;
            else
                dsAbn.tAbnObj.Rows[0]["idObjParent"] = idAbnObjParent;
            
            dsAbn.tAbnObj.Rows[0].EndEdit();
            return this.UpdateSqlData(dsAbn, dsAbn.tAbnObj);
        }

        // редактировать хар-ки    ПОХОЖЕ НЕ ИСПОЛЬЗУЕТСЯ
        private bool UpdatetAbnObjReg(int AbnObj)
        {
            dateTimePickerDateChange.Value = dateTimePickerDateChange.Value.Date;
            dsAbn.tAbnObjReg.Rows[0]["idAbnObj"] = AbnObj;
            dsAbn.tAbnObjReg.Rows[0]["idAbnNet"] = (AbnNetComboBox.SelectedValue == null) ? DBNull.Value : AbnNetComboBox.SelectedValue;
            dsAbn.tAbnObjReg.Rows[0]["idAbnSale"] = (abnSaleComboBox.SelectedValue == null) ? DBNull.Value : abnSaleComboBox.SelectedValue;
            dsAbn.tAbnObjReg.Rows[0]["idAbnServicing"] = (abnServicingComboBox.SelectedValue == null) ? DBNull.Value : abnServicingComboBox.SelectedValue;
            dsAbn.tAbnObjReg.Rows[0]["idStatus"] = (statusNameComboBox.SelectedValue == null) ? DBNull.Value : statusNameComboBox.SelectedValue;
            dsAbn.tAbnObjReg.Rows[0]["Category"] = (categoryComboBox.SelectedValue == null) ? DBNull.Value : categoryComboBox.SelectedValue;
            dsAbn.tAbnObjReg.Rows[0]["idTariff"] = (TariffcomboBox.SelectedValue == null) ? DBNull.Value : TariffcomboBox.SelectedValue;
            dsAbn.tAbnObjReg.Rows[0]["Comment"] = txtComment.Text ;
            dsAbn.tAbnObjReg.Rows[0]["CommentODS"] = txtCommentODS.Text;
            dsAbn.tAbnObjReg.Rows[0]["CommentXML"] = this.CreateXmlComment().InnerXml;

            dsAbn.tAbnObjReg.Rows[0]["Regime"] = RegimeNUD.Value;
            dsAbn.tAbnObjReg.Rows[0]["KLoss"] = KLossNUD.Value;
            dsAbn.tAbnObjReg.Rows[0]["PowerSet"] = PowerSetNUD.Value;
            dsAbn.tAbnObjReg.Rows[0]["PowerOther"] = PowerOtherNUD.Value;
            dsAbn.tAbnObjReg.Rows[0]["PowerFact"] = PowerFactNUD.Value;
            dsAbn.tAbnObjReg.Rows[0]["PowerCalc"] = PowerCalcNUD.Value;

            dsAbn.tAbnObjReg.Rows[0]["CalcLoss"] = cbxCalcLoss.Checked;

            dsAbn.tAbnObjReg.Rows[0]["NumberTP"] = cmbNumberTP;
            dsAbn.tAbnObjReg.Rows[0]["DateTP"] = cmbDateTP;
            dsAbn.tAbnObjReg.Rows[0]["NumberTU"] = txtNumberTU;
            dsAbn.tAbnObjReg.Rows[0]["DateTU"] = dtDateTU;

            dsAbn.tAbnObjReg.Rows[0].EndEdit();
            return this.UpdateSqlData(dsAbn, dsAbn.tAbnObjReg);
        }

        // загрузка родительского объекта
        // с которого минусуем данные
        private bool LoadtAbnObjParent()
        {
            this.SelectSqlDataTableOther(dsAbn, dsAbn.tAbnObjParent, "tAbnObj", true, "where id = " + idAbnObjParent.ToString());
            DataRow[] row = dsAbn.tAbnObjParent.Select();
            if (row.Length <= 0) return false;
            txtParent.Text = row[0]["Name"].ToString();
            return true;
        }

        // загрузка рассчитываемого объекта
        private bool LoadtAbnObjSame()
        {
            this.SelectSqlDataTableOther(dsAbn, dsAbn.tAbnObjSame, "tAbnObj", true, "where id = " + idAbnObjSame.ToString());
            DataRow[] row = dsAbn.tAbnObjSame.Select();
            if (row.Length <= 0) return false;
            txtObjectSame.Text = row[0]["Name"].ToString();
            return true;
        }

        private void LoadDataToGridImages(Byte[] ImageData, int id)
        {
            try
            {
                using (Bitmap bmp = ImageCompress.LoadBitmap(ImageData))
                {
                    if (bmp != null)
                    {
                        dataGridViewImages.Rows.Add(new Bitmap(bmp, 120, 160), new Bitmap(bmp), true, id);
                    }
                }
//                dataGridViewImages.Rows.Add(new Bitmap(ImageCompress.LoadBitmap(ImageData), 120, 160), ImageCompress.LoadBitmap(ImageData), true, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // добавление изображения
        private void tsbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Multiselect = true;
            fileOpen.Filter = "JPEG Documents|*.jpg";
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in fileOpen.FileNames)
                {
                    using (Bitmap img = new Bitmap(fileName))
                    {
                        dsAbn.tAbnObj_Image.Rows.Clear();

                        drAddImg = dsAbn.tAbnObj_Image.NewRow();
                        drAddImg["idAbnObj"] = idAbnObj;
                        drAddImg["Scan"] = ImageCompress.GetCompressBytes((Image)img, 30L);
                        dsAbn.tAbnObj_Image.Rows.Add(drAddImg);

                        int id = InsertSqlDataOneRow(dsAbn, dsAbn.tAbnObj_Image);

                        pbScanDoc.Image = ImageCompress.LoadBitmap(fileName);
                        pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
                        dataGridViewImages.Rows.Add(new Bitmap(img, 120, 160), ImageCompress.LoadBitmap(fileName), false, id);
                    }
                    //img.Dispose();
                }
            }
        }

        // удаление изображения
        private void tsbRemoveImage_Click(object sender, EventArgs e)
        {
            if (DeleteSqlDataById(dsAbn.tAbnObj_Image, (int)dataGridViewImages.CurrentRow.Cells["id"].Value))
            {
                dataGridViewImages.Rows.RemoveAt(dataGridViewImages.CurrentRow.Index);
                MessageBox.Show("Изображение удалено..");
            }
            else
                MessageBox.Show("Изображение удалить не удалось..");
        }

        // запись изображения в файл
        private void tsbSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = ".jpg";
            fileSave.FileName = "Temp";
            fileSave.Title = "Сохраните файл с изображением в любой папке";

            if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageCompress.SaveBitmapUsingExtension(pbScanDoc.Image, fileSave.FileName);
                MessageBox.Show("Изображение успешно сохранено.");
            }
        }

        // переход к другому изображению
        private void dataGridViewImages_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex >= 0) // если левой кнопкой
            {
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            {
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;

                this.dataGridViewImages.Rows[e.RowIndex].Selected = true;
                dataGridViewImages.CurrentCell = dataGridViewImages[0, e.RowIndex]; //делаем текущей
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
                this.contextMenuStripImage.Show(System.Windows.Forms.Cursor.Position);
            }
        }

        private void cmbNumberTP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbNumberTP.Text != "")
                PtsRazr_Load();
        }

        // привязка к минусующему объекту
        private void btnObjSame_Click(object sender, EventArgs e)
        {
            FormAbnObjFind f = new FormAbnObjFind(-3, idAbnObjSame);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                idAbnObjSame = OBJSELECT;
                LoadtAbnObjSame();
            }
        }

        private void buttonKLossTrans_Click(object sender, EventArgs e)
        {

            FormObjKLossTrans f = new FormObjKLossTrans(idAbnObj);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            { };
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = ".jpg";
            fileSave.FileName = "Temp";
            fileSave.Title = "Сохраните файл с изображением в любой папке";
            if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageCompress.SaveBitmapUsingExtension(pbScanDoc.Image, fileSave.FileName);
            }

            if (fileSave.FileName != "")
            {
                proc.StartInfo.FileName = fileSave.FileName; //указываем имя файла с изображением
                if (!st)
                {
                    st = true; //указываем, что процесс запускается
                    proc.EnableRaisingEvents = true; //при закрытии файла будет вызвано событие Exited
                    proc.Exited += new EventHandler(proc_Exited); //добавляем обработчик события
                    proc.Start(); //запускаем программу просмотра изображения
                }
                else
                {
                    MessageBox.Show("Закройте файл с изображением, чтобы снова его запустить!");
                }
            }
            else
            {
                MessageBox.Show("Отсутствует имя файла!");
            }
        }

        void proc_Exited(object sender, EventArgs e)
        {
            st = false;
            proc.Exited -= new EventHandler(proc_Exited); //убираем обработчик
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tsbNewTP_Click(object sender, EventArgs e)
        {
            //if (dgvTP.RowCount > 0)
            //{
                FormAddEditConnect f = new FormAddEditConnect(-1,idAbnObj, Object.FormAddEditConnect.ActionСonnect.Add);
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == DialogResult.OK)
                { SelectSqlData(dsAbn, dsAbn.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc");
                dgvTP.Columns[0].Visible = false;
                };
            //}
           
        }

        private void tsbEditTP_Click(object sender, EventArgs e)
        {
            if (dgvTP.RowCount > 0)
            {
                FormAddEditConnect f = new FormAddEditConnect(Convert.ToInt32(dgvTP.CurrentRow.Cells["idxDataGridViewTextBoxColumn"].Value),idAbnObj, Object.FormAddEditConnect.ActionСonnect.Edit);
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == DialogResult.OK)
                { SelectSqlData(dsAbn, dsAbn.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc");
                dgvTP.Columns[0].Visible = false;
                };
            }
            else
            { MessageBox.Show("Нечего редактировать"); }
        }

        private void tsbDelTP_Click(object sender, EventArgs e)
        {
            if (dgvTP.RowCount > 0)
            {
                int idx = Convert.ToInt32(dgvTP.CurrentRow.Cells["idxDataGridViewTextBoxColumn"].Value);
                if (MessageBox.Show("Вы действительно хотите удалить текущее подключение?", "Удаление",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tConnect, true, "where idx = " + idx.ToString());
                    ds.tConnect.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tConnect.Rows[0]["Deleted"]);
                    ds.tConnect.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tConnect))
                    {
                        if (Convert.ToBoolean(ds.tConnect.Rows[0]["Deleted"]))
                        {
                            MessageBox.Show("Подключене успешно удалено.");
                            SelectSqlData(dsAbn, dsAbn.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc");
                            dgvTP.Columns[0].Visible = false;
                         }
                        else
                        {
                            MessageBox.Show("Подключение успешно восстановлено");
                         }
                    }

                }

            
            
            }
            else
            { MessageBox.Show("Нечего удалять"); }
        }

        private void cmbConsumerGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectSqlDataTableOther(dsLObj, dsLObj.tR_Classifier_Consumer, "tR_Classifier", true, " where ParentKey like '" + dsLObj.tR_Classifier_ConsumerGroup[(int)cmbConsumerGroup.SelectedIndex]["ParentKey"] + "' and isGroup = 0 and deleted = 0");
            cmbConsumer.SelectedIndex = -1;
        }

        private void btnMeasur_Click(object sender, EventArgs e)
        {
            Object.FormMeasurementsOfObject f = new Object.FormMeasurementsOfObject(idAbnObj);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                SelectSqlData(dsObj1, dsObj1.tG_MeasurementsOfObject, true, "where idObj = " + idAbnObj.ToString() + "order by id desc"); 
            }
        }

        private void NumRazr_Load()
        {

            this.SelectSqlData(dsAbn, dsAbn.tR_Classifier, true, " where SocrName = 'PermissionConnection'");
            string Path = "";
            if (dsAbn.tR_Classifier.Rows.Count != 0)
                Path = dsAbn.tR_Classifier.Rows[0]["Comment"].ToString();
            dsAbn.vG_NumRazresh.Clear();
            if (string.IsNullOrEmpty(Path)) return;   // Shumilov Alexandr 06.03.2013. Если нет - то и таблитчки tbl_razresh тоже нет!!!!
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                Path = Path.Trim();
                strCmd = "select distinct TOP (100) PERCENT Num_Razr from " + Path + "tbl_razresh order by Num_Razr";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsAbn, "vG_NumRazresh");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }

        }

        private void PtsRazr_Load()
        {

            this.SelectSqlData(dsAbn, dsAbn.tR_Classifier, true, " where SocrName = 'PermissionConnection'");
            string Path = "";
            if (dsAbn.tR_Classifier.Rows.Count != 0)
                Path = dsAbn.tR_Classifier.Rows[0]["Comment"].ToString();
            dsAbn.vG_PtsRazresh.Clear();
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                Path = Path.Trim();
                strCmd = "select distinct TOP (100) PERCENT Date_Vidan from " + Path + " tbl_razresh where Num_Razr = " + cmbNumberTP.Text + " order by Date_Vidan desc";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsAbn, "vG_PtsRazresh");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
        }


        #region toolStripLinkSchmAbnObj
        private void LoadLinkSchmAbn()
        {
            // привязка к схеме
            this.SelectSqlData(dsAbn, dsAbn.vL_SchmAbn, true, " where idAbnObj = " + idAbnObj.ToString() + " order by SchmObjName ");
        }
        private void toolBtnAddLinkSchmAbnObj_Click(object sender, EventArgs e)
        {
            if (idAbnObj != -1)
            {
                Dictionary<int, string> linkObjects = new Dictionary<int, string>();
                foreach (DataRow r in dsAbn.vL_SchmAbn)
                {
                    if (r["TypeDoc"] != DBNull.Value && (Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ActTC ||
                        Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ActRBP ||
                        Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ChangeSwitch))
                    {
                        if (linkObjects.ContainsKey(Convert.ToInt32(r["idSchmObj"])))
                            linkObjects.Remove(Convert.ToInt32(r["idSchmObj"]));
                    }
                    else
                    {
                        if (!linkObjects.ContainsKey(Convert.ToInt32(r["idSchmObj"])))
                            linkObjects.Add(Convert.ToInt32(r["idSchmObj"]), r["SchmObjName"].ToString());
                    }
                }

                Documents.Forms.Scheme.FormLinkAbnObjAndSchm f = new Documents.Forms.Scheme.FormLinkAbnObjAndSchm();
                f.LinkObjects = linkObjects;
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    linkObjects = f.LinkObjects;
                    UpdateLinkSchmAbn(linkObjects);
                    LoadLinkSchmAbn();
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать объект");
            }
        }
        private void UpdateLinkSchmAbn(Dictionary<int, string> linkObjects)
        {
            foreach (DataRow r in dsAbn.vL_SchmAbn)
            {
                if (r["TypeDoc"] != DBNull.Value && (Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ActTC ||
                    Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ActRBP ||
                    Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ChangeSwitch))
                    continue;
                int idSchmObj = Convert.ToInt32(r["idSchmObj"]);
                if (!linkObjects.ContainsKey(idSchmObj))
                    this.DeleteSqlDataById(dsAbn.tL_SchmAbn, Convert.ToInt32(r["id"]));
                else
                    linkObjects.Remove(idSchmObj);
            }
            dsAbn.tL_SchmAbn.Clear();
            foreach (int i in linkObjects.Keys)
            {
                if (dsAbn.tL_SchmAbn.Select("idSchmObj = " + idAbnObj.ToString()).Length <= 0)
                {
                    DataRow newR = dsAbn.tL_SchmAbn.NewRow();
                    newR["idSchmObj"] = i;
                    newR["idAbn"] = idAbn;
                    newR["idAbnObj"] = idAbnObj;
                    dsAbn.tL_SchmAbn.Rows.Add(newR);
                }
            }
            this.InsertSqlData(dsAbn, dsAbn.tL_SchmAbn);
            dsAbn.tL_SchmAbn.Clear();

        }

        private void toolBtnDelLinkSchmAbnObj_Click(object sender, EventArgs e)
        {
            if (dgvLinkSchmAbnObj.SelectedRows != null && dgvLinkSchmAbnObj.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранные привязки?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    bool isNoDel = false;
                    foreach (DataGridViewRow dgvR in dgvLinkSchmAbnObj.SelectedRows)
                    {
                        if (dgvR.Cells[typeDocDgvColumn.Name].Value != null && dgvR.Cells[typeDocDgvColumn.Name].Value != DBNull.Value)
                        {
                            if (Convert.ToInt32(dgvR.Cells[typeDocDgvColumn.Name].Value) == (int)Constants.eTypeDocTC.ActTC ||
                                Convert.ToInt32(dgvR.Cells[typeDocDgvColumn.Name].Value) == (int)Constants.eTypeDocTC.ActRBP ||
                                Convert.ToInt32(dgvR.Cells[typeDocDgvColumn.Name].Value) == (int)Constants.eTypeDocTC.ChangeSwitch)
                            {
                                if (Convert.ToBoolean(dgvR.Cells[delDocDgvColumn.Name].Value))
                                {
                                    // здесь может что то сказать типа документ удален...
                                }
                                else
                                {
                                    isNoDel = true;
                                    continue;
                                }
                            }
                        }

                        this.DeleteSqlDataById(dsAbn.tL_SchmAbn, 
                            Convert.ToInt32(dgvR.Cells[idLinkSchmAbnDgvColumn.Name].Value));
                    }
                    if (isNoDel)
                        MessageBox.Show("Привязки, которые принадлежат акту разграничения балансовой принадлежности " +
                            "и акту о техническом присоединениипривзяку невозможно удалить");


                    LoadLinkSchmAbn();
                }
            }

        }

        private void dgvLinkSchmAbnObj_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow dgvR = dgvLinkSchmAbnObj.Rows[e.RowIndex];
            if (dgvR.Cells[typeDocDgvColumn.Name].Value != null &&
                dgvR.Cells[typeDocDgvColumn.Name].Value != DBNull.Value)
            {
                switch (Convert.ToInt32(dgvR.Cells[typeDocDgvColumn.Name].Value))
                {
                    case (int)Constants.eTypeDocTC.ActRBP:
                        Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP = 
                            new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, 
                                idAbnObj, Convert.ToInt32(dgvR.Cells[idDocDGV.Name].Value));
                        frmAktRBP.FormClosed += new FormClosedEventHandler(frmActLinkSchm_FormClosed);
                        frmAktRBP.Show();
                        break;
                    case (int)Constants.eTypeDocTC.ActTC:
                        Documents.Forms.TechnologicalConnection.ActTC.FormTCAddEdit fTC =
                            new Documents.Forms.TechnologicalConnection.ActTC.FormTCAddEdit(Convert.ToInt32(dgvR.Cells[idDocDGV.Name].Value));
                        fTC.SqlSettings = this.SqlSettings;
                        fTC.MdiParent = this.MdiParent;
                        fTC.FormClosed += new FormClosedEventHandler(frmActLinkSchm_FormClosed);
                        fTC.Show();
                        break;
                    case (int)Constants.eTypeDocTC.ChangeSwitch:
                        Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch fChSw =
                            new Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch(Convert.ToInt32(dgvR.Cells[idDocDGV.Name].Value), true);
                        fChSw.SqlSettings = this.SqlSettings;
                        fChSw.MdiParent = this.MdiParent;
                        fChSw.Show();
                        break;
                }
            }
        }

        void frmActLinkSchm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadLinkSchmAbn();
        }

        private void dgvLinkSchmAbnObj_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (Convert.ToBoolean(dgvLinkSchmAbnObj[delDocDgvColumn.Name, e.RowIndex].Value)) // если документ удален
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red;
                    DataGridViewCell cell =
                        this.dgvLinkSchmAbnObj.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.ToolTipText = "Документ удален";
                }
            }
        }
        #endregion

        #region ServicingKontragent
        private void LoadCmbServicing()
        {
            DataTable dt = this.SelectSqlData("vAbnType", true, "where typeKontragent = " + ((int)Constants.KontragentType.Servicing).ToString() +
                " order by name");
            abnServicingComboBox.DisplayMember = "name";
            abnServicingComboBox.ValueMember = "idAbn";
            abnServicingComboBox.DataSource = dt;
        }

        private void abnServicingComboBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(abnServicingComboBox.Text))
                abnServicingComboBox.SelectedIndex = -1;
        }
        #endregion

        private void FormObjAE_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridViewImages.Rows.Count > 0)
            {
                dataGridViewImages.Dispose();
                pbScanDoc.Image = null;
                GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

        private void btnCopyName_Click(object sender, EventArgs e)
        {
            int n = txtName.Text.IndexOf(",");
            if (n > 0)
                txtShortName.Text = txtName.Text.Substring(0, n).Trim();
        }

        private void btnNewName_Click(object sender, EventArgs e)
        {
            if (txtShortName.Text.Length > 0)
            {
                string Address = "";
                if (cmbStreet.SelectedIndex >= 0)
                {
                    // добавим адрес к короткому имени
                    DataRow[] dr = dsStreet.Tables["tR_KladrStreet"].Select("Id = " + cmbStreet.SelectedValue.ToString());
                    Address = dr[0]["Socr"].ToString() + "." + dr[0]["Name"].ToString() + " " + txtHouse.Text + " " + txtHousePrefix.Text;
                }
                if (Address.Length > 0)
                    txtName.Text = txtShortName.Text + ", " + Address;
                else
                    txtName.Text = txtShortName.Text;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (dataGridViewImages.Rows.Count > 0)
            {
                dataGridViewImages.Dispose();
                pbScanDoc.Image = null;
                GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

        public FormClosedEventHandler frmAct_FormClosed { get; set; }

        private void Update_tAbnObjFlags(int idObj, int idFlag, int del)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "Update_tAbnObjFlags";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@idObj", idObj);
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@idFlag", idFlag);
                sqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@del", del);
                sqlCmd.Parameters.Add(p3);

                sqlCmd.CommandTimeout = 0;

                sqlCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }

        }

       
        public class ReservationInfo<T>
        {
            [XmlAttribute]
            public T Value { get; set; }
        }
        [Serializable]
        [XmlRoot(ElementName = "ActApprovalReservation")]
        public class ActApprovalReservation
        {
            [XmlElement("NumDoc")]
            public ReservationInfo<string> NumDoc { get; set; }

            [XmlElement("DateDoc")]
            public ReservationInfo<DateTime> DateDoc { get; set; }

            [XmlElement("EmergencyReserv")]
            public ReservationInfo<decimal> EmergencyReserv { get; set; }

            [XmlElement("TechnologicalReserv")]
            public ReservationInfo<decimal> TechnologicalReserv { get; set; }
        }
        [Serializable]
        [XmlRoot(ElementName = "CommentXML")]
        public class CommentXML
        {
            [XmlElement(ElementName = "ActApprovalReservation")]
            public ActApprovalReservation ActApprovalReservation { get; set; }
        }
        private XmlDocument CreateXmlComment()
        {
            if (String.IsNullOrEmpty(this.txtNumDocActApprovalReservation.Text)) return null;
            XmlDocument xmlDocument = new XmlDocument();

            decimal EmergencyReserv = 0;
            Decimal.TryParse(this.txtEmergencyReserv.Text, out EmergencyReserv);

            decimal TechnologicalReserv = 0;
            Decimal.TryParse(this.txtTechnologicalReserv.Text, out TechnologicalReserv);
            
            CommentXML com = new CommentXML
            {
                ActApprovalReservation = new ActApprovalReservation
                {
                    NumDoc = new ReservationInfo<string> { Value = this.txtNumDocActApprovalReservation.Text },
                    DateDoc = new ReservationInfo<DateTime> { Value = this.dtpDateDocActApprovalReservation.Value },
                    EmergencyReserv = new ReservationInfo<decimal> { Value = EmergencyReserv },
                    TechnologicalReserv = new ReservationInfo<decimal> { Value = TechnologicalReserv }
                }
            };

            XmlSerializer serializer = new XmlSerializer(com.GetType());
            MemoryStream xmlStream = new MemoryStream();
            serializer.Serialize(xmlStream, com);
            xmlStream.Position = 0;
            xmlDocument.Load(xmlStream);

            return xmlDocument;
        }
        private void ApplyComment()
        {
            if (dsAbn.tAbnObjReg.Rows.Count > 0 && this.dsAbn.tAbnObjReg.Rows[0]["CommentXML"] != DBNull.Value)
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(dsAbn.tAbnObjReg.Rows[0]["CommentXML"].ToString());
                string xmlString = xmlDocument.OuterXml.ToString();

                XmlSerializer serializer = new XmlSerializer(typeof(CommentXML));

                var stringReader = new StringReader(xmlString);
                CommentXML comq = (CommentXML)serializer.Deserialize(stringReader);

                this.txtNumDocActApprovalReservation.Text = comq.ActApprovalReservation.NumDoc.Value;
                this.dtpDateDocActApprovalReservation.Value = comq.ActApprovalReservation.DateDoc.Value;
                this.txtEmergencyReserv.Text = comq.ActApprovalReservation.EmergencyReserv.Value.ToString();
                this.txtTechnologicalReserv.Text = comq.ActApprovalReservation.TechnologicalReserv.Value.ToString();

            }
        }


        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Separator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator[0];
            //Separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (((e.KeyChar == '.') || (e.KeyChar == ',')) && (((TextBox)sender).Text.IndexOf(Separator) == -1) && (((TextBox)sender).Text.Length != 0))
                e.KeyChar = Separator;
            else
                if (!(Char.IsDigit(e.KeyChar)))
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                }
        }



    }
}
