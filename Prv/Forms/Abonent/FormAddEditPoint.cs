using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;

namespace Prv.Forms.Abonent
{
    public partial class FormAddEditPoint : FormLbr.FormBase
    {
        /// <summary>
        /// Действия над точкой
        /// </summary>
        public enum ActionPoint { 
            /// <summary>
            /// Установка новой точки
            /// </summary>
            Installation, 
            /// <summary>
            /// Демонтаж точки
            /// </summary>
            Deinstallation, 
            /// <summary>
            /// Редактирование точки
            /// </summary>
            Edit, 
            /// <summary>
            /// Просмотр точки
            /// </summary>
            Read }  
        /// <summary>
        /// Действия над счетчиком
        /// </summary>
        public enum ActionMeter { 
            /// <summary>
            /// Установка счетчика
            /// </summary>
            Installation, 
            /// <summary>
            /// Демонтаж счетчика
            /// </summary>
            Deinstallation, 
            /// <summary>
            /// Редактирование счетчика
            /// </summary>
            Edit, 
            /// <summary>
            /// Просмотр счетчика
            /// </summary>
            Read }  
        /// <summary>
        /// Действия над трансформатором
        /// </summary>
        public enum ActionTrans { 
            /// <summary>
            /// Установка трансформатора
            /// </summary>
            Installation, 
            /// <summary>
            /// Демонтаж трансформатора
            /// </summary>
            Deinstallation, 
            /// <summary>
            /// Редактирование трансформатора
            /// </summary>
            Edit, 
            /// <summary>
            /// Просмотр трансформатора
            /// </summary>
            Read
        }

        #region Переменные
        private int idAbnObj = -1;      // id объекта
        private int idPoint = -1;       // id точки учета
        private int idMeter = -1;       // id счетчика
        private int idTrans = -1;       // id трансформатора

        private ActionPoint actPoint;   // действия над точкой
        private ActionMeter actMeter;   // действия над счетчиком
        private ActionTrans actTrans;   // действия над трансформатором
        private DateTime minDateCounterUst = DateTime.MinValue;
        private DateTime minDateTransUst = DateTime.MinValue;
        #endregion

        #region Properties
        public DateTime MinDateCounterUst
        {
            get { return minDateCounterUst; }
            set 
            {
                minDateCounterUst = value;
                if (value > dateTimePickerDateUst.MinDate)
                {
                    dateTimePickerDateUst.MinDate = value;
                }
            }
        }
        public DateTime MinDateTransUst
        {
            get { return minDateTransUst; }
            set
            {
                minDateTransUst = value;
                if (value > dateTimePickerTransDateUst.MinDate)
                {
                    dateTimePickerTransDateUst.MinDate = value;
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAddEditPoint()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="obj">id Объекта</param>
        /// <param name="point">id точки учета</param>
        /// <param name="actPoint">действия над точкой учета</param>
        /// <param name="meterReg">id установленного счетчика</param>
        /// <param name="actMeter">действия над счетчиком</param>
        /// <param name="transReg">id трансформатора</param>
        /// <param name="actTrans">действия над трансформтором</param>
        public FormAddEditPoint(int obj, int point, ActionPoint actPoint,
                    int meterReg, ActionMeter actMeter, int transReg, ActionTrans actTrans)
        {
            InitializeComponent();
            dateTimePickerDateUst.Value = DateTime.Now.Date;
            idAbnObj = obj;
            idPoint = point;
            this.actPoint = actPoint;
            idMeter = meterReg;
            this.actMeter = actMeter;
            idTrans = transReg;
            this.actTrans = actTrans;
            // года для даты госповерки
            for (int i = System.DateTime.Now.Year; i >= 1950; i--)
            {
                cmbMeterCheckYear.Items.Add(i);          // счетчика
                cmbTransCheckYear.Items.Add(i);     // трансформатора
            }

            MinDateCounterUst = DateTime.MinValue;
            InitFormName();
        }
        // Название формы
        private void InitFormName()
        {
            switch (actPoint)
            {
                case ActionPoint.Installation:
                    this.Text = "Новая точка учета";
                    break;
                case ActionPoint.Deinstallation:
                    this.Text = "Демонтаж точки учета";
                    break;
                case ActionPoint.Edit:
                    this.Text = "Редактирование точки учета";
                    break;
                case ActionPoint.Read:
                    switch (actMeter)
                    {
                        case ActionMeter.Installation:
                            this.Text = "Установка счетчика";
                            break;
                        case ActionMeter.Deinstallation:
                            this.Text = "Демонтаж счетчика";
                            break;
                        case ActionMeter.Edit:
                            this.Text = "Редактирование счетчика";
                            break;
                        case ActionMeter.Read:
                            switch (actTrans)
                            {
                                case ActionTrans.Installation:
                                    this.Text = "Установка трансформатора";
                                    break;
                                case ActionTrans.Deinstallation:
                                    this.Text = "Демонтаж трансформатора";
                                    break;
                                case ActionTrans.Edit:
                                    this.Text = "Редактирование трансформатора";
                                    break;
                                case ActionTrans.Read:
                                    this.Text = "Просмотр";
                                    break;
                                default: break;
                            }
                            break;
                        default: break;
                    }
                    break;
                default: break;
            }
        }
        #endregion

        #region FormAddEditPoint Events
        // загрузка формы
        private void FormAddEditPoint_Load(object sender, EventArgs e)
        {
            LoadDirecoty();                 // загрузка справочников
            cmbTension.SelectedValue = Constants.Constants.TensionLowVoltage;  // по идеи у все Низкое Напряжение 
            cmbLocation.SelectedIndex = -1; // расположение точки

            if (!LoadAbn())   // загрузка абонента
                this.Close(); // если не загрузили - то закгрываем форму

            InitPoint();  // инициализация точки
            InitMeter();  // инициализация счетчика
            InitTrans();  // инициализация трансофрматора

            // stupid microsoft (patch)
            TabPage selPage = tabControlMark.SelectedTab;
            for (int i = 0; i < tabControlMark.TabPages.Count; i++)
                tabControlMark.SelectedIndex = i;
            tabControlMark.SelectedTab = selPage;

        }
        #endregion

        #region LoadData
        // загрузка справочников
        private void LoadDirecoty()
        {
            // классфикатор
            this.SelectSqlData(dsPoint, dsPoint.tR_Classifier, true, " where ParentKey in (';SKUEE;TypeTension;', " +
                "';SKUEE;PointLocation;', ';SKUEE;TypePoint;') and IsGRoup = 0 and deleted = 0");

            bindingSourceTypeMeter.Filter =String.Format("ParentKey = ';SKUEE;TypePoint;' and id not in ({0},{1})",
                ((int)Constants.DevicePointType.TransAmperage).ToString(), ((int)Constants.DevicePointType.TransVoltage).ToString());

            // справочник счетчиков
            this.SelectSqlData(dsPoint, dsPoint.tR_MarkMeter, true, " where deleted = 0 order by name, digit");
            cmbMarkMeter.DataSource = dsPoint.tR_MarkMeter;
            cmbMarkMeter.DisplayMember = "Name";
            cmbMarkMeter.ValueMember = "Id";
            cmbMarkMeter.SelectedIndex = -1;
            // справочник трансформаторов
            this.SelectSqlData(dsPoint, dsPoint.tR_MarkTrans, true, " where deleted = 0 order by name, [primary], [secondary]");
            cmbMarkTrans.DataSource = dsPoint.tR_MarkTrans;
            cmbMarkTrans.DisplayMember = "Name";
            cmbMarkTrans.ValueMember = "Id";
            cmbMarkTrans.SelectedIndex = -1;

            // справочник мастеров (уст. счечтичков)
            DataTable dtWorkerGRoup = new DataTable("vWorkerGroup");
            dtWorkerGRoup.Columns.Add("id", typeof(int));
            dtWorkerGRoup.Columns.Add("fio", typeof(string));
           // cmbWorkerDem.DataSource = dtWorkerGRoup;
            cmbWorkerUst.DataSource = dtWorkerGRoup;
           // cmbTransMasterDem.DataSource = dtWorkerGRoup;
            cmbTransMasterUst.DataSource = dtWorkerGRoup;

            this.SelectSqlData(dtWorkerGRoup, true, " where idGRoup in ( " + Constants.Constants.WorkerGroupMasterBS.ToString() + ",  "
                                                                                                     + Constants.Constants.WorkerGroupMasterUL.ToString() + ",  "
                                                                                                     + Constants.Constants.WorkerGroupControlerBS.ToString() + ",  "
                                                                                                     + Constants.Constants.WorkerGroupOther.ToString() + " ) " +
                " and dateEnd is null order by FIO", null, true);


            // справочник мастеров (деь. счечтичков)
            DataTable dtWorkerGRoupDem = new DataTable("vWorkerGroup");
            dtWorkerGRoupDem.Columns.Add("id", typeof(int));
            dtWorkerGRoupDem.Columns.Add("fio", typeof(string));
            cmbWorkerDem.DataSource = dtWorkerGRoupDem;
            cmbTransMasterDem.DataSource = dtWorkerGRoupDem;
            this.SelectSqlData(dtWorkerGRoupDem, true, " where idGRoup in ( " + Constants.Constants.WorkerGroupMasterBS.ToString() + ",  "
                                                                                                     + Constants.Constants.WorkerGroupMasterUL.ToString() + ",  "
                                                                                                     + Constants.Constants.WorkerGroupControlerBS.ToString() + ",  "
                                                                                                     + Constants.Constants.WorkerGroupOther.ToString() + " ) " +
                " and dateEnd is null order by FIO", null, true);








            //this.SelectSqlData(dsPoint, dsPoint.Tables["vWorkerGroup"], true, " where idGRoup in ( " + Constants.Constants.WorkerGroupMasterBS.ToString() + ",  "
            //                                                                                         + Constants.Constants.WorkerGroupMasterUL.ToString() + ",  " 
            //                                                                                         + Constants.Constants.WorkerGroupControlerBS.ToString() + ",  "
            //                                                                                         + Constants.Constants.WorkerGroupOther.ToString() + " ) " +
            //    " and dateEnd is null order by FIO", true);
            // справочник зон
            this.SelectSqlData(dsZone, dsZone.Tables["tR_Classifier"], true, " where ParentKey like ';SKUEE;TimeZone;%' " +
                " and ParentKey <> ';SKUEE;TimeZone;' and isGroup = 1");
            cmbZone.SelectedIndex = -1;
        }
        // загрузка абонента
        public bool LoadAbn()
        {
            if (this.SelectSqlData(dsPoint, dsPoint.tAbnObj, true, " where id = " + idAbnObj.ToString()))
            {
                if (dsPoint.tAbnObj.Rows.Count <= 0) // не нашли объект
                {
                    MessageBox.Show("Не удалось найти объект");
                    return false;
                }
            }
            else
                return false;
            if (!this.SelectSqlData(dsPoint, dsPoint.tAbn, true, "where id = " + dsPoint.tAbnObj.Rows[0]["idAbn"].ToString()))
                return false;
            txtCodeAbn.Text = dsPoint.tAbn.Rows[0]["CodeAbonent"].ToString();
            return true;
        }
        #endregion

        #region Init Methods
        // Инициализация точки учета
        private void InitPoint()
        {
            switch (actPoint)   // действия над точкой
            {
                case ActionPoint.Installation: //новая точка учета
                    DataRow dr = dsPoint.tPoint.NewRow();
                    dr["IdAbnObj"] = idAbnObj;  // id Объекта
                    dr["idTension"] = Constants.Constants.TensionLowVoltage; //НН
                    dr["Voltage"] = 0.23;   // Уровень напряжения
                    dr["DateBegin"] = System.DateTime.Now.Date; //Дата начала
                    dsPoint.tPoint.Rows.Add(dr);
                    break;
                case ActionPoint.Edit:  //редактировать точку учета
                    dateTimePickerBeg.Enabled = false;
                    dateTimePickerEnd.Enabled = false;
                    this.SelectSqlData(dsPoint, dsPoint.tPoint, true, "where id = " + idPoint.ToString());// грузим редактируемую точку
                    break;
                case ActionPoint.Deinstallation: //демонтаж точки
                    this.SelectSqlData(dsPoint, dsPoint.tPoint, true, "where id = " + idPoint.ToString());// грузим редактируемую точку
                    dateTimePickerBeg.Enabled = false;
                    cmbLocation.Enabled = false;
                    cmbTension.Enabled = false;
                    txtVoltage.ReadOnly = true;
                    break;
                case ActionPoint.Read:  // Просмотр
                    this.SelectSqlData(dsPoint, dsPoint.tPoint, true, "where id = " + idPoint.ToString());// грузим редактируемую точку
                    dateTimePickerBeg.Enabled = false;
                    dateTimePickerEnd.Enabled = false;
                    cmbLocation.Enabled = false;
                    cmbTension.Enabled = false;
                    txtVoltage.ReadOnly = true;
                    break;
                default: break;
            }
        }
        // Инициализация счетчика
        private void InitMeter()
        {
            switch (actMeter)
            {
                case ActionMeter.Installation: // новый счетчик (установка)
                    NewtPointRegMeter();
                    break;
                case ActionMeter.Edit: // редактирование счетчика
                case ActionMeter.Deinstallation: // демонтаж счетчика
                    LoadtPointRegMeter();
                    if (dsPoint.tPointReg.Rows.Count <= 0) // нету записей
                    {
                        NewtPointRegMeter();
                        actMeter = ActionMeter.Installation;
                        break;
                    }
                    else
                    {
                        idMeter = Convert.ToInt32(dsPoint.tPointReg.Rows[0]["Id"]);
                        GetCheckDateMeterKvartalAndYear(dsPoint.tPointReg.Rows[0]["DateCheck"]);
                    }

                    cmbTypeMeter.Enabled = false;    
                    if (actMeter == ActionMeter.Edit)
                        dateTimePickerDateUst.Enabled = true; // Изменил по просьбе Дубовой А.В. (Кураков Ю.С. 20140707)
                    cmbWorkerUst.Enabled = false;

                    if (cmbZone.SelectedIndex >= 0)
                        cmbZone.Enabled = false;

                    if (actMeter == ActionMeter.Deinstallation)  // Демонтаж счетчика
                    {
                        cmbMarkMeter.Enabled = false;
                        dateTimePickerDateMade.Enabled = false;
                        txtNumberMeter.ReadOnly = true;
                        cmbMeterCheckKvartal.Enabled = false;
                        cmbMeterCheckYear.Enabled = false;
                        dgvZoneIndicator.Columns["ColumnUst"].ReadOnly = true;
                    }
                    else
                    {
                        dateTimePickerDateDem.Enabled = false;
                        cmbWorkerDem.Enabled = false;
                    }
                    break;
                case ActionMeter.Read: // просмотр
                    LoadtPointRegMeter();
                    if (dsPoint.tPointReg.Rows.Count > 0)
                    {
                        idMeter = Convert.ToInt32(dsPoint.tPointReg.Rows[0]["Id"]);
                        GetCheckDateMeterKvartalAndYear(dsPoint.tPointReg.Rows[0]["DateCheck"]);
                    }
                    cmbTypeMeter.Enabled = false;
                    cmbMarkMeter.Enabled = false;
                    dateTimePickerDateMade.Enabled = false;
                    txtNumberMeter.ReadOnly = true;
                    cmbMeterCheckKvartal.Enabled = false;
                    cmbMeterCheckYear.Enabled = false;
                    dateTimePickerDateUst.Enabled = false;
                    cmbWorkerUst.Enabled = false;
                    dateTimePickerDateDem.Enabled = false;
                    cmbWorkerDem.Enabled = false;
                    cmbZone.Enabled = false;
                    dgvZoneIndicator.Columns["ColumnUst"].ReadOnly = true;
                    dgvZoneIndicator.Columns["ColumnDem"].ReadOnly = true;
                    richTextBoxComment.ReadOnly = true;
                    break;
                default: break;
            }
        }
        //новый счетчик
        private void NewtPointRegMeter()
        {
            DataRow dr = dsPoint.tPointReg.NewRow();
            dr["IdPoint"] = idPoint;                        // id точки учета
            dr["DateBegin"] = dateTimePickerDateUst.Value.Date;     // дата установки
            dr["Type"] = (int)Constants.DevicePointType.Meter;  // тип точки - СЧЕТЧИК5
            dsPoint.tPointReg.Rows.Add(dr);
        }      
        // загрука счетчика
        private void LoadtPointRegMeter()
        {
            if (idMeter < 0) // неизвестно
                this.SelectSqlData(dsPoint.tPointReg, true,
                    String.Format(" where idPoint = {0} and [Type] not in ({1},{2}) order by DateBegin desc", 
                    idPoint.ToString(), (int)Constants.DevicePointType.TransAmperage, (int)Constants.DevicePointType.TransVoltage), null, false, 1); // гузим последнюю запись
            else
                this.SelectSqlData(dsPoint.tPointReg, true,
                     " where id = " + idMeter.ToString());
        }        
        // Инициализация трансформатора
        private void InitTrans()
        {
            switch (actTrans)
            {
                case ActionTrans.Installation: // новый трансформатор (установка)
                    if (actMeter == ActionMeter.Read)
                    {
                        tabControlMark.TabPages.Clear();
                        tabControlMark.TabPages.Add(tabPageMarkTrans);
                    }
                    NewtPointRegTrans();
                    break;
                case ActionTrans.Deinstallation:    //демонтаж
                case ActionTrans.Edit:              //редактирование
                    if (actMeter == ActionMeter.Read)
                    {
                        tabControlMark.TabPages.Clear();
                        tabControlMark.TabPages.Add(tabPageMarkTrans);
                    }
                    LoadtPointRegTrans();
                    if (dsTrans.tPointReg.Rows.Count <= 0) // нету записей
                    {
                        //NewtPointRegTrans();
                        actTrans = ActionTrans.Read;   // поставим пока на чтение
                        break;
                    }
                    else
                    {
                        idTrans = Convert.ToInt32(dsTrans.tPointReg.Rows[0]["Id"]);
                        GetCheckDateTransKvartalAndYear(dsTrans.tPointReg.Rows[0]["DateCheck"]);
                    }

                    dateTimePickerTransDateUst.Enabled = false;
                    cmbTransMasterUst.Enabled = false;
                    if (actTrans == ActionTrans.Deinstallation)  // Демонтаж трансфоматора
                    {
                        cmbMarkTrans.Enabled = false;
                        dateTimePickerTransDateMade.Enabled = false;
                        txtTransNumber.ReadOnly = true;
                        cmbTransCheckKvartal.Enabled = false;
                        cmbTransCheckYear.Enabled = false;
                    }
                    else
                    {
                        dateTimePickerTransdateDem.Enabled = false;
                        cmbTransMasterDem.Enabled = false;
                    }
                    break;
                case ActionTrans.Read: // просмотр
                    LoadtPointRegTrans();
                    if (dsTrans.tPointReg.Rows.Count > 0)
                    {
                        idTrans = Convert.ToInt32(dsTrans.tPointReg.Rows[0]["Id"]);
                        GetCheckDateTransKvartalAndYear(dsTrans.tPointReg.Rows[0]["DateCheck"]);
                    }
                    cmbMarkTrans.Enabled = false;
                    dateTimePickerTransDateMade.Enabled = false;
                    txtTransNumber.ReadOnly = true;
                    cmbTransCheckKvartal.Enabled = false;
                    cmbTransCheckYear.Enabled = false;
                    dateTimePickerTransDateUst.Enabled = false;
                    dateTimePickerTransdateDem.Enabled = false;
                    cmbTransMasterUst.Enabled = false;
                    cmbTransMasterDem.Enabled = false;
                    richTextBoxTransComment.ReadOnly = true;
                    break;
                default: break;
            }
        }
        //новый трансформатор
        private void NewtPointRegTrans()
        {
            DataRow dr = dsTrans.tPointReg.NewRow();
            dr["IdPoint"] = idPoint;                        // id точки учета
            dr["DateBegin"] = dateTimePickerTransDateUst.Value.Date; ;     // дата установки
            dr["Type"] = (int)Constants.DevicePointType.TransAmperage;  // тип точки - ТРАНСФОРМАТОР
            dsTrans.tPointReg.Rows.Add(dr);
        }
        // загрука трансформатора
        private void LoadtPointRegTrans()
        {
            if (idTrans < 0) // неизвестно
                this.SelectSqlData(dsTrans.tPointReg, true,
                    " where idPoint = " + idPoint.ToString() + " and [Type] = " + ((int)Constants.DevicePointType.TransAmperage).ToString() +
                    " order by DateBegin desc", null, false, 1); // гузим последнюю запись
            else
                this.SelectSqlData(dsTrans, dsTrans.tPointReg, true,
                     " where id = " + idTrans.ToString());
        }        
        #endregion

        // Кнопка ОК
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (Check())
            { // проверка прошла усепшно
                int point = InsUpdPoint();

                if (point > 0)  //успешно
                {
                    if (InsUpdMeter(point))
                        if (InsUpdTrans(point))
                            DialogResult = DialogResult.OK;
                }
            }
        }

        #region Check
        // Проверка всего!!!
        private bool Check()
        {
            if (!CheckPoint())
                return false;
            if (!CheckMeter())
                return false;
            if (!CheckTrans())
                return false;
            return true;
        }
        // Проверка точки учета
        private bool CheckPoint()
        {
            if (actPoint != ActionPoint.Read)
            {
                if ((cmbTension.SelectedIndex < 0) || (String.IsNullOrEmpty(txtVoltage.Text)))
                {
                    MessageBox.Show("Введитие уровень напряжения");
                    return false;
                }

                if ((actPoint == ActionPoint.Deinstallation) && (dateTimePickerEnd.Value == null))
                {
                    MessageBox.Show("Введити дату окночанния");
                    return false;
                }
            }

            return true;
        }
        // Проверка счетчика
        private bool CheckMeter()
        {
            if (actMeter != ActionMeter.Read)
            {
                if (Convert.ToInt32(cmbTypeMeter.SelectedValue) ==
                    (int)Constants.DevicePointType.Meter) // если выбрали счетчик
                {
                    if (cmbMarkMeter.SelectedIndex < 0) // не выбрали марку счетчика
                    {
                        MessageBox.Show("Выберите марку счетчика");
                        return false;
                    }
                    if (dateTimePickerDateMade.Value == null) // не введена дата производства счетчика
                    {
                        MessageBox.Show("Введите дату производства счетчика");
                        return false;
                    }
                    if (String.IsNullOrEmpty(txtNumberMeter.Text)) // не ввели заводской номер
                    {
                        MessageBox.Show("Введите заводской номер счетчика");
                        return false;
                    }
                    if ((cmbMeterCheckKvartal.SelectedIndex < 0) || (cmbMeterCheckYear.SelectedIndex < 0)) // не ввели дату госповерки
                    {
                        MessageBox.Show("Введите дату госповерки");
                        return false;
                    }
                    if (cmbZone.SelectedIndex < 0) //не выбрали временную зону
                    {
                        MessageBox.Show("Выберите временную зону счетчика");
                        return false;
                    }

                    // проверка показаний при установке/демонтаже
                    foreach (DataRow dr in dsZone.Tables["vR_Zone"].Rows)
                    {
                        if (dr["ValueBegin"] == DBNull.Value)
                        {
                            MessageBox.Show("Введите показания при установке");
                            return false;
                        }
                        if ((dateTimePickerDateDem.Value != null) && (dr["ValueEnd"] == DBNull.Value))
                        {
                            MessageBox.Show("Введите показания при демонтаже");
                            return false;
                        }
                    }
                }

                if (actMeter == ActionMeter.Deinstallation) // демонтаж
                {
                    if (dateTimePickerDateDem.Value == null)
                    {
                        MessageBox.Show("Введите дату демонтажа");
                        return false;
                    }
                }
            }

            return true;
        }
        // Проверка трансформатора
        private bool CheckTrans()
        {
            if (actTrans != ActionTrans.Read)
            {
                if (cmbMarkTrans.SelectedIndex < 0) // не выбрали марку трансформатора
                {
                    if ((actTrans == ActionTrans.Installation) && (actPoint == ActionPoint.Installation))
                    {
                        if (Convert.ToInt32(cmbTypeMeter.SelectedValue) == (int)Constants.DevicePointType.Meter) // если счетчик
                            if (MessageBox.Show("Не выбран трансформатор тока. \n Пропустить ввод трансформатора?", "",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                actTrans = ActionTrans.Read;
                                return true;
                            }
                            else
                            {
                                if (tabControlMark.TabCount == 3)
                                    tabControlMark.SelectedIndex = 2;
                                return false;
                            }
                        else
                        {
                            actTrans = ActionTrans.Read;
                            return true;
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Выберите марку трансформатора");
                        return false;
                    }
                }
                //if (dateTimePickerTransDateMade.Value == null) // не введена дата производства трансформатора
                //{
                //    MessageBox.Show("Введите дату производства трансформатора");
                //    return false;
                //}
                //if (String.IsNullOrEmpty(txtTransNumber.Text)) // не ввели заводской номер
                //{
                //    MessageBox.Show("Введите заводской номер трансформатора");
                //    return false;
                //}
                if ((cmbTransCheckKvartal.SelectedIndex < 0) || (cmbTransCheckYear.SelectedIndex < 0)) // не ввели дату госповерки
                {
                    MessageBox.Show("Введите дату госповерки трансформатора");
                    return false;
                }

                if (actTrans == ActionTrans.Deinstallation) // демонтаж
                {
                    if (dateTimePickerTransdateDem.Value == null)
                    {
                        MessageBox.Show("Введите дату демонтажа трансформатора");
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region InsUpd
        // Добавление/изменение точки учета
        private int InsUpdPoint()
        {
            switch (actPoint)
            {
                case ActionPoint.Installation: //новая точка учета
                    dsPoint.tPoint.Rows[0].EndEdit();
                    int id = this.InsertSqlDataOneRow(dsPoint, dsPoint.tPoint);
                    if (id > 0)
                        return id;
                    else
                    {
                        MessageBox.Show("Не удалось создать точку учета");
                        return -1;
                    }
                case ActionPoint.Edit:  //редактировать точку учекта
                    dsPoint.tPoint.Rows[0].EndEdit();
                    if (this.UpdateSqlData(dsPoint, dsPoint.tPoint))
                        return Convert.ToInt32(dsPoint.tPoint.Rows[0]["Id"]);
                    else
                    {
                        MessageBox.Show("Не удалось отредактировать точку учета");
                        return -1;
                    }
                case ActionPoint.Deinstallation: //демонтаж точки
                    dsPoint.tPoint.Rows[0].EndEdit();
                    if (this.UpdateSqlData(dsPoint, dsPoint.tPoint))
                        return Convert.ToInt32(dsPoint.tPoint.Rows[0]["Id"]);
                    else
                    {
                        MessageBox.Show("Не удалось отредактировать точку учета");
                        return -1;
                    }
                case ActionPoint.Read:
                    return Convert.ToInt32(dsPoint.tPoint.Rows[0]["Id"]);
                default:
                    return -1;
            }
        }
        // Добавление/изменение прибора учета
        private bool InsUpdMeter(int point)
        {
            switch (actMeter)
            {
                case ActionMeter.Installation:      // установка прибора учета
                case ActionMeter.Edit:              // редактирование
                case ActionMeter.Deinstallation:    // демонтаж
                    dsPoint.tPointReg.Rows[0]["IdPoint"] = point;       //точка учета
                    if (Convert.ToInt32(cmbTypeMeter.SelectedValue) ==
                        (int)Constants.DevicePointType.Meter) // если счетчик
                        dsPoint.tPointReg.Rows[0]["DateCheck"] = GetCheckDate(Convert.ToInt32(cmbMeterCheckYear.SelectedItem),
                            cmbMeterCheckKvartal.SelectedIndex + 1);  //дат госповерки
                    dsPoint.tPointReg.Rows[0].EndEdit();

                    int idCounter = Convert.ToInt32(dsPoint.tPointReg.Rows[0]["id"]);
                    if (actMeter == ActionMeter.Installation) // если установка
                    {
                        idCounter = this.InsertSqlDataOneRow(dsPoint, dsPoint.tPointReg);
                        if (idCounter < 0)
                        {
                            MessageBox.Show("Не удалось создать новый счетчик");
                            return false;
                        }
                    }
                    else
                        if (!this.UpdateSqlData(dsPoint, dsPoint.tPointReg))
                        {
                            MessageBox.Show("Не удалось отредактировать счетчик");
                            return false;
                        }

                    if (Convert.ToInt32(cmbTypeMeter.SelectedValue) == (int)Constants.DevicePointType.Meter) // если счетчик
                    {
                        foreach (DataRow dr in dsZone.Tables["vR_Zone"].Rows)
                        {
                            if (!InsUpdDocAct(point, idCounter, Convert.ToInt32(dr["ValueBegin"]),
                                    (int)Constants.DocType.ActUst, Convert.ToInt32(dr["idSubZoneName"])))
                            {
                                MessageBox.Show("Не удалось внести показания при установке");
                                return false;
                            }

                            if (dateTimePickerDateDem.Value != null)
                                if (!InsUpdDocAct(point, idCounter, Convert.ToInt32(dr["ValueEnd"]),
                                    (int)Constants.DocType.ActDem, Convert.ToInt32(dr["idSubZoneName"])))
                                {
                                    MessageBox.Show("Не удалось внести показания при демонтаже");
                                    return false;
                                }
                        }
                    }
                    return true;
                case ActionMeter.Read:
                    return true;
                default: 
                   MessageBox.Show("Ошибка");
                    return false;
            }
        }
        // Добавление/изменение трансформатора
        private bool InsUpdTrans(int point)
        {
            switch (actTrans)
            {
                case ActionTrans.Installation: // установка прибора учета
                case ActionTrans.Deinstallation:
                case ActionTrans.Edit:
                    dsTrans.tPointReg.Rows[0]["IdPoint"] = point; //точка учета
                    dsTrans.tPointReg.Rows[0]["DateCheck"] =
                        GetCheckDate(Convert.ToInt32(cmbTransCheckYear.SelectedItem), cmbTransCheckKvartal.SelectedIndex + 1);
                    dsTrans.tPointReg.Rows[0].EndEdit();

                    if (actTrans == ActionTrans.Installation) // если установка
                        if (this.InsertSqlDataOneRow(dsTrans, dsTrans.tPointReg) > 0)
                            return true;
                        else
                        {
                            MessageBox.Show("Не удалось создать новый трансформатор");
                            return false;
                        }
                    else
                        if (!this.UpdateSqlData(dsTrans, dsTrans.tPointReg))
                        {
                            MessageBox.Show("Не удалось отредактировать трансформатор");
                            return false;
                        }
                    return true;
                case ActionTrans.Read:
                    return true;
                default:
                    MessageBox.Show("Ошибка");
                    return false;
            }
        }
        // Добавить/изменить показания прибора учета
        private bool InsUpdDocAct(int point, int idMeter, int value, int typeDoc, int idZone)
        {
            this.SelectSqlData(dsPoint.tDocAct, true, " where idpoint = " + point.ToString() +
                    " and idpointreg = " + idMeter.ToString() + " and idDocType = " + typeDoc.ToString() + 
                    " and idZone = " + idZone.ToString(), null, false, 1);
            if (dsPoint.tDocAct.Rows.Count <= 0) //insert
            {
                DataRow dr = dsPoint.tDocAct.NewRow();
                dr["idPoint"] = point;
                dr["idPointReg"] = idMeter;
                dr["IdDocType"] = typeDoc;
                dr["idZone"] = idZone;
                dr["ValueKWT"] = value;
                dr["DateIn"] = System.DateTime.Now.Date;
                if (typeDoc == (int)DocType.ActUst)
                {
                    dr["DateAct"] = dateTimePickerDateUst.Value;
                    if (cmbWorkerUst.SelectedValue == null)
                        dr["idWorker"] = DBNull.Value;
                    else
                        dr["idWorker"] = cmbWorkerUst.SelectedValue;
                }
                if (typeDoc == (int)Constants.DocType.ActDem)
                {
                    dr["DateAct"] = dateTimePickerDateDem.Value;
                    if (cmbWorkerDem.SelectedValue == null)
                        dr["idWorker"] = DBNull.Value;
                    else
                        dr["idWorker"] = cmbWorkerDem.SelectedValue;
                }
                dr["isActive"] = true;
                dr["Deleted"] = false;
                dsPoint.tDocAct.Rows.Add(dr);
                dsPoint.tDocAct.Rows[0].EndEdit();
                return this.InsertSqlData(dsPoint, dsPoint.tDocAct);
            }
            else //update
            {
                dsPoint.tDocAct.Rows[0]["ValueKWT"] = value;
                if (typeDoc == (int)Constants.DocType.ActUst)
                {
                    dsPoint.tDocAct.Rows[0]["DateAct"] = dateTimePickerDateUst.Value;
                    if (cmbWorkerUst.SelectedValue == null)
                        dsPoint.tDocAct.Rows[0]["idWorker"] = DBNull.Value;
                    else
                        dsPoint.tDocAct.Rows[0]["idWorker"] = cmbWorkerUst.SelectedValue;
                }
                if (typeDoc == (int)DocType.ActDem)
                {
                    dsPoint.tDocAct.Rows[0]["DateAct"] = dateTimePickerDateDem.Value;
                    if (cmbWorkerDem.SelectedValue == null)
                        dsPoint.tDocAct.Rows[0]["idWorker"] = DBNull.Value;
                    else
                        dsPoint.tDocAct.Rows[0]["idWorker"] = cmbWorkerDem.SelectedValue;
                }
                dsPoint.tDocAct.Rows[0].EndEdit();
                return this.UpdateSqlData(dsPoint, dsPoint.tDocAct);
            }
        }
        #endregion

        #region Госповекрка
        private void GetCheckDateTransKvartalAndYear(object value)
        {
            if (!String.IsNullOrEmpty(value.ToString()))
            {
                DateTime checkDate = Convert.ToDateTime(value);
                cmbTransCheckYear.SelectedItem = checkDate.Year;
                switch (checkDate.Month)
                {
                    case 1:
                    case 2:
                    case 3: cmbTransCheckKvartal.SelectedIndex = 0; // первый квартал
                        break;
                    case 4:
                    case 5:
                    case 6: cmbTransCheckKvartal.SelectedIndex = 1;  // второй квартал
                        break;
                    case 7:
                    case 8:
                    case 9: cmbTransCheckKvartal.SelectedIndex = 2;  // третий квартал
                        break;
                    case 10:
                    case 11:
                    case 12: cmbTransCheckKvartal.SelectedIndex = 3;  // четвертый квартал
                        break;
                }
            }
        }
        private void GetCheckDateMeterKvartalAndYear(object value)
        {
            if (!String.IsNullOrEmpty(value.ToString()))
            {
                DateTime checkDate = Convert.ToDateTime(value);
                cmbMeterCheckYear.SelectedItem = checkDate.Year;
                switch (checkDate.Month)
                {
                    case 1:
                    case 2:
                    case 3: cmbMeterCheckKvartal.SelectedIndex = 0; // первый квартал
                        break;
                    case 4:
                    case 5:
                    case 6: cmbMeterCheckKvartal.SelectedIndex = 1;  // второй квартал
                        break;
                    case 7:
                    case 8:
                    case 9: cmbMeterCheckKvartal.SelectedIndex = 2;  // третий квартал
                        break;
                    case 10:
                    case 11:
                    case 12: cmbMeterCheckKvartal.SelectedIndex = 3;  // четвертый квартал
                        break;
                }
            }
        }
        private DateTime GetCheckDate(int year, int kvartal)
        {
            int month = 1;

            switch (kvartal)
            {
                case 1: // первый квартал
                    month = 4; break;
                case 2: // второй квартал
                    month = 7; break;
                case 3: // третий квартал
                    month = 10; break;
                case 4: // четвертый квартал
                    month = 1;
                    year++; break;
                default: break;
            }

            DateTime date = new DateTime(year, month, 1);
            date = date.AddDays(-1);
            return date;
        }
        #endregion

        #region Controls Events
        // смена даты начала точки учета
        private void dateTimePickerBeg_ValueChanged(object sender, EventArgs e)
        {
            //if dateTimePickerDateUst.MinDate = dateTimePickerBeg.Value; //пример счетчик 1999г. точка 2000г. демонтаж внести корректно нельзя
            if (dateTimePickerDateUst.MinDate < minDateCounterUst)
                dateTimePickerDateUst.MinDate = minDateCounterUst;

            dateTimePickerEnd.MinDate = dateTimePickerBeg.Value;

            dateTimePickerTransDateUst.MinDate = dateTimePickerBeg.Value;
            if (dateTimePickerTransDateUst.MinDate < minDateTransUst)
                dateTimePickerTransDateUst.MinDate = minDateTransUst;
        }
        // смена даты установки
        private void dateTimePickerDateUst_ValueChanged(object sender, EventArgs e)
        {
            //dsPoint.tPointReg.Rows[0]["DateBegin"] = dateTimePickerDateUst.Value;
            dateTimePickerDateMade.MaxDate = dateTimePickerDateUst.Value;
            dateTimePickerDateDem.MinDate = dateTimePickerDateUst.Value;
        }
        // смена даты установки трансформатора
        private void dateTimePickerTransDateUst_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTransDateMade.MaxDate = dateTimePickerTransDateUst.Value;
            dateTimePickerTransdateDem.MinDate = dateTimePickerTransDateUst.Value;
        }
        // смена типа точки учета
        private void cmbTypeMeter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((ComboBox)sender).SelectedValue) ==
                (int)Constants.DevicePointType.Meter) // выбран счетчик
            {
                tabControlMark.TabPages.Insert(1, tabPageZone);
                tabControlMark.TabPages.Insert(2, tabPageMarkTrans);
                cmbMarkMeter.Enabled = true;
                dateTimePickerDateMade.Enabled = true;
                txtNumberMeter.Enabled = true;
                cmbMeterCheckKvartal.Enabled = true;
                cmbMeterCheckYear.Enabled = true;
            }
            else
            {
                tabControlMark.TabPages.Remove(tabPageZone);
                tabControlMark.TabPages.Remove(tabPageMarkTrans);
                cmbMarkMeter.Enabled = false;
                dateTimePickerDateMade.Enabled = false;
                txtNumberMeter.Enabled = false;
                cmbMeterCheckKvartal.Enabled = false;
                cmbMeterCheckYear.Enabled = false;
            }
        }
        // ВЫбор временной зоны
        private void cmbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex >= 0)
            {
                this.SelectSqlData(dsZone, dsZone.Tables["vR_Zone"], true, " where idZoneName = " +
                    ((ComboBox)sender).SelectedValue.ToString());

                for (int i = 0; i < dsZone.Tables["vR_ZOne"].Rows.Count; i++)
                {
                    DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
                    this.SelectSqlData(ds.tDocAct, true, " where idPointReg = " + idMeter.ToString() +
                        " and idDocType = " + ((int)DocType.ActUst).ToString() +
                        " and idZone = " + dsZone.Tables["vR_Zone"].Rows[i]["idSubZoneName"].ToString(), null, false, 1);
                    if (ds.tDocAct.Rows.Count > 0)
                        dsZone.Tables["vR_ZOne"].Rows[i]["VAlueBegin"] = ds.tDocAct.Rows[0]["ValueKWT"];

                    this.SelectSqlData(ds.tDocAct, true, " where idPointReg = " + idMeter.ToString() +
                        " and idDocType = " + ((int)DocType.ActDem).ToString() +
                        " and idZone = " + dsZone.Tables["vR_Zone"].Rows[i]["idSubZoneName"].ToString(), null, false, 1);
                    if (ds.tDocAct.Rows.Count > 0)
                        dsZone.Tables["vR_ZOne"].Rows[i]["VAlueEnd"] = ds.tDocAct.Rows[0]["ValueKWT"];
                }

            }
        }
        #endregion

  
    }
}
