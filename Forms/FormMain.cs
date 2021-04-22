using Constants;
//using Consumer.Forms;
//using Consumer.Forms.Balance;
//using Consumer.Forms.Plombs;
//using Consumer.Import.Matrica;
//using Consumer.Import.UE;
using DataSql;
//using DocPPR.Forms;
//using DocPPR.Forms;
//using Documents.Measurement;
using Documents.Forms;
using Documents.Forms.Abonent;
using Documents.Forms.DailyReport.ActDetection;
using Documents.Forms.DailyReport.JournalDamage;
using Documents.Forms.DailyReport.Temperature;
using Documents.Forms.DocTamplateReference;
using Documents.Forms.JournalCalcLoss;
using Documents.Forms.JournalDefect;
using Documents.Forms.JournalExcavation;
using Documents.Forms.JournalOrder;
using Documents.Forms.JournalRelayProtectionAutomation;
using Documents.Forms.JournalRequest;
using Documents.Forms.JournalRequestForRepair;
using Documents.Forms.JournalTechnologicalFailures;
using Documents.Forms.JournalUpdateProgram;
using Documents.Forms.Measurement;
using Documents.Forms.Memorandums;
using Documents.Forms.TechnologicalConnection;
using Documents.Forms.TechnologicalConnection.ActTC;
using Documents.Forms.TechnologicalConnection.Consumers;
using Documents.Forms.TechnologicalConnection.Contract;
using Documents.Forms.TechnologicalConnection.MailTU;
using Documents.Forms.TechnologicalConnection.RBP;
using Documents.Forms.TechnologicalConnection.Rebinding;
using Documents.Forms.TechnologicalConnection.TU;
using Documents.Service;
using EIS.Classes;
using FormLbr;
using FormLbr.Classes;
//using GRP;
using Legal.Forms;
using Legal.Forms.Calculat;
using Legal.Forms.Document;
using Legal.Forms.Export;
using Legal.Forms.FormRep;
using Legal.Forms.GraphicsInspector;
using Legal.Forms.Meter;
using Legal.Forms.Object;
using Legal.Forms.Prognosis;
using Legal.Forms.Test;
using Passport;
using Passport.Classes;
using Passport.Forms;
using Passport.Forms.Cable.Report;
using Passport.Forms.PassportChars;
using Passport.Forms.PassportEE;
using Passport.Forms.StateEquipmentList;
using Passport.Forms.Transf;
using PluginInterfaces;
using Prv.Forms.Abonent;
using Prv.Forms.Controlers;
using Prv.Forms.Exchange;
using Prv.Forms.Houses;
using Prv.Forms.Plombs;
using Prv.Forms.Reports;
using Reference.Forms;
using Reference.Forms.MapObj;
using RequestsClient.Forms;
using Scheme.Forms;
using Scheme.Forms.LinkSchmAbn;
using Scheme.Forms.OPCMessage;
using Scheme.Forms.Reports;
using Services.Forms;
using Services.Forms.Chat;
using Services.Forms.Log;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using WinFormsUI.Docking;
using DailyReportN;
using CefSharp.Net;
using CefSharp.WinForms.WebBrowser;

//using WeifenLuo.WinFormsUI.Docking;

namespace EIS.Forms
{
    public partial class FormMain : FormBase, IPluginHost
    {

        #region Constants
        const string SERVER_DB = "ulges-sql2";        // сервер БД по умолчанию
        const string DB_NAME = "GES";             // имя БД по умлчанию
        const string DB_TOK = "TOK";             // имя БД тока по умолчанию
        const string AUTENTIFICATION = "WINDOWS";   // аутентификация по умочанию
        const int FORM_WIDTH = 1000;             // ширина формы по умолчанию
        const int FORM_HEIGHT = 700;             // высота формы по умолчанию

        const string TABLE_USER = "tUser";     // табличка с пользователями
        #endregion

        private delegate void MulticastDelegate1(Bitmap bmp);
        private delegate void MulticastDelegate2(String s);
        //public EISSettings eisSettings;

        #region Переменные
        public EISSettings eisSettings = new EISSettings();
        #endregion
        #region Переменые и поля формы

        private bool isLoadRequestClient = false;
        private string xSettings;
        //private FormReportEvent frmReportMessage;
        internal BackgroundWorker backgroundWorkerUpdater;
        private TCPSocketListener tcpsocketChat;
        private string Login;
        private string _Name;
        private const string Field1 = "document";
        #endregion

        public FormMain()
        {
            this.InitializeComponent();
            this.CreateBeginnerParametrChat();
            this.toolBtnMessage.Visible = false;

            this.tsSepar8.Visible = false;
            /******************************************/
            this.tspDatatoGIS.Visible = true;
            this.tspMenuItemMap.Visible = false;
            this.tspMenuItemUE.Visible = false;
            this.tspMenuItemSchedulers.Visible = false;
            this.tspMenuItemJournalN.Visible = false;
            this.tspTOK5.Visible = false;
            this.tspUploadRepairPlannedToolStripMenuItem.Visible = false;
            this.toolMenuItemExportTo1C.Visible = false;
#if !DEBUG
            this.tsmiMeasurement.Visible = false;
            this.toolMenuItemDailyReport.Visible = false;
            this.toolMenuItemJRequestForRepair.Visible = false;
            //this.toolStripMenuItemDebug.Visible = false;
#endif

        }

        private void LoadConfig()
        {
            this.eisSettings = new EISSettings();
            this.eisSettings = new AppConfig().OpenAppConfig();
            //можно и так сделать?
            //AppConfig appConfig = new AppConfig();
            //eisSettings = appConfig.OpenAppConfig();
            if (string.IsNullOrEmpty(eisSettings.SqlSettings.ServerDB)) eisSettings.SqlSettings.ServerDB = SERVER_DB;
            if (string.IsNullOrEmpty(eisSettings.SqlSettings.DBName)) eisSettings.SqlSettings.DBName = DB_NAME;
            if (string.IsNullOrEmpty(eisSettings.SqlSettings.Autentification)) eisSettings.SqlSettings.Autentification = AUTENTIFICATION;
            if (eisSettings.FrmMainSettings.Width <= 300) eisSettings.FrmMainSettings.Width = FORM_WIDTH;
            if (eisSettings.FrmMainSettings.Height <= 100) eisSettings.FrmMainSettings.Height = FORM_HEIGHT;
            (this).Width = eisSettings.FrmMainSettings.Width;
            (this).Height = eisSettings.FrmMainSettings.Height;
            (this).WindowState = eisSettings.FrmMainSettings.WindowsState;
            if (!eisSettings.IsShowFormConnect && new SqlDataConnect().CheckConnection(eisSettings.SqlSettings))
            {
                this.SqlSettings = this.eisSettings.SqlSettings;
                //DataTable dataTable = new DataTable();
                if ((!(this.SqlSettings.Autentification.ToUpper() == "WINDOWS")
                            ? this.SelectSqlData(TABLE_USER, false, "where Login = '" + this.SqlSettings.SqlUserConnect + "' AND Deleted = 0") : this.SelectSqlData(TABLE_USER, false, "where Login = SYSTEM_USER AND Deleted = 0")).Rows.Count > 0)
                    return;
                int num = (int)MessageBox.Show("Данный пользователь не зарегистрирован в базе " + this.SqlSettings.DBName + "\nОбратитесь к админитсратору базы данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            while (true)
            {
                while (!this.ShowFormConnect())// ShowFormConnect
                    Environment.Exit(0);
                this.SqlSettings = eisSettings.SqlSettings;
                //DataTable dataTable = new DataTable();
                if ((!(this.SqlSettings.Autentification.ToUpper() == "WINDOWS") ? this.SelectSqlData(TABLE_USER, false, "where Login = '" + this.SqlSettings.SqlUserConnect + "' AND Deleted = 0") : this.SelectSqlData(TABLE_USER, false, "where Login = SYSTEM_USER AND Deleted = 0")).Rows.Count <= 0)
                {
                    int num = (int)MessageBox.Show("Данный пользователь не зарегистрирован в базе " + this.SqlSettings.DBName +
                        "\nОбратитесь к админитстратору базы данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                    break;
                // здесь раньше стоял такой код
                // Environment.Exit(0);  // здесь такая заплатка, потому что в конструторе это дело происходит
            }
        }

        /// <summary>
        /// форма соединения с базой данных
        /// </summary>
        /// <returns></returns>
        private bool ShowFormConnect()
        {
            FormConnect formConnect = new FormConnect(eisSettings.SqlSettings);
            if (formConnect.ShowDialog() != DialogResult.OK)
                return false;
            this.eisSettings.SqlSettings = formConnect.SqlSetting;
            return true;
        }
        /// <summary>
        /// установить наименование заголовка приложения
        /// </summary>
        private void SetCaption()
        {
            Library.Security security = new Library.Security();
            security.SqlSettings = SqlSettings;
            string CurrentUsers = security.GetCurrentUser();
            // DataTable dataTable = new DataTable("vAbnType");
            // SelectSqlData - данный метод после ноября 2016 не используется
            // четвертый параметр не может быть boolean
            // this.SelectSqlData(dataTable, true, " where typeKontragent = {0} ", false);
            DataTable dataTable = this.SelectSqlData("vAbnType", true, string.Format(" where typeKontragent = {0} ", 1115));
            if (dataTable.Rows.Count <= 0 || dataTable.Rows[0]["Name"] == DBNull.Value)
                return;
            this.Text = ((Control)this).Text + string.Format(" ({0})", dataTable.Rows[0]["Name"].ToString());
            this.Text = this.Text + " (" + eisSettings.SqlSettings.ServerDB + "\\" + eisSettings.SqlSettings.DBName + " )";
            this.Text = this.Text + " " + CurrentUsers;
        }
        /// <summary>
        /// настройки подключения к службе обмена данными открытых схем
        /// </summary>
        private void LoadSchemaService()
        {
            // настройки подключения к службе обмена данными открытых схем
            DataTable dataTable = this.SelectSqlData("tSettings", true, "where Module = 'SchemaService'");
            if (dataTable.Rows.Count <= 0)
                return;
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                string xml = dataTable.Rows[0]["Settings"].ToString();
                xmlDocument.LoadXml(xml);
                string xpath = "WCFSchemeServer";
                this.xSettings = xmlDocument.SelectSingleNode(xpath).InnerText;
            }
            catch
            {
            }
        }
        /// <summary>
        /// не понятная загрузка?
        /// </summary>
        private void LoadRequestsClient()
        {
            try
            {
                Assembly.Load("RequestsClient");
                // было  
                this.isLoadRequestClient = true;
            }
            catch
            {
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        #region FormMain Events (События)
        private void FormMain_Load(object sender, EventArgs e)
        {
            Visible = false;

            this.timerMain.Enabled = true;
#if DEBUG
            this.timerMain.Enabled = false;
            this.Text = this.Text + " ОТЛАДКА";
#endif
            this.LoadConfig();
            // обновление данных в таблице объектов схемы
            // пусть пока останется
            // там все закомменчено
            UpdatetSChm_ObjList.UpdatetSChm_ObjListTypeCodeId(SqlSettings);
            this.LoadChat();
            this.LoadSchemaService();
            Visible = true;

            this.ConnectChat();

            this.notifyIconBirthDay.BalloonTipClosed += new EventHandler(this.notifyIconBirthDay_BalloonTipClosed);
            this.ShowBirthDays();
            this.LoadPlugins();
            this.LoadRequestsClient();
            //this.ShowFormReportEvent();
            // непонятная фигня, для загрузки контагентов c id = 1115
            this.SetCaption();
            //

            CreateVisibleMenuItems();

        }
        private bool AccessToSKUEE = false;
        /// <summary>
        /// погасим или отобразим менюшки
        /// </summary>
        private void CreateVisibleMenuItems()
        {
            
            Library.Security security = new Library.Security();
            security.SqlSettings = SqlSettings;
            DataTable CurrentRules = security.GetCurrentUserRules();
            foreach (DataRow row in CurrentRules.Rows)
            {
                string ParentKey = row["ParentKey"].ToString();
                switch (ParentKey)
                {
                    case ";GroupWorker;Administrator;": {
                            this.toolMenuItemExportTo1C.Visible = true;
                            this.tspUploadRepairPlannedToolStripMenuItem.Visible = true; this.tspMenuItemSchedulers.Visible = true; this.tspMenuItemJournalN.Visible = true; } break;
                    case ";GroupWorker;Map;": {/* this.tspDatatoGIS.Visible = true; */ this.tspMenuItemMap.Visible = true; } break;
                    case ";GroupWorker;GeneralInterfaceLegal;": this.tspMenuItemUE.Visible = true; break;
                    case ";GroupWorker;GrantSKUEE;": AccessToSKUEE = true; break;
                    case ";GroupWorker;TOK_5;": { this.tspUploadRepairPlannedToolStripMenuItem.Visible = true;  this.tspTOK5.Visible = true; break; }
                    default: break;
                }
            }
            if (!AccessToSKUEE)
            {
                // Бытовой сектор
                this.toolMenuItemJPlomb.Visible = false;
                this.toolMenuItemListHouses.Visible = false;
                this.toolMenuItemControlers.Visible = false;
                this.toolMenuItemReports.Visible = false;
                this.обменToolStripMenuItem.Visible = false;
                this.журналАбонентовToolStripMenuItem.Visible = false;
                this.журналРаспоряженийToolStripMenuItem.Visible = false;
                // Государственный сектор
                this.toolMenuItemChargeLegal.Visible = false;
                this.toolMenuItemReportsLegal.Visible = false;
                // меню справочник в госекторе
                //this.toolMenuItemReferenceLegal.Visible = false;
                // подменю справочника госсектора
                this.toolMenuItemAbonentsLegal.Visible = false;
                this.toolMenuItemAbnObjectsLegal.Visible = false;
                this.toolMenuItemMeterLegal.Visible = false;
                this.приборыУчетаASOKAToolStripMenuItem.Visible = false;
                this.toolMenuItemBanksLegal.Visible = false;
                //
                this.toolMenuItemsDocsLegal.Visible = false;
                this.toolMenuItemGraphicSurveys.Visible = false;
                this.toolMenuSettingsLegal.Visible = false;
                this.toolStripMenuItemForeCast.Visible = false;
                this.toolMenuItemExportLegal.Visible = false;
                this.toolMenuItemCheckLegal.Visible = false;
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.notifyIconBirthDay.Visible = false;//notifyIconBirthDay
            AppConfig appConfig = new AppConfig();
            if (WindowState == FormWindowState.Normal)
            {

                eisSettings.FrmMainSettings.Width = this.Width;
                eisSettings.FrmMainSettings.Height = this.Height;
            }
            eisSettings.FrmMainSettings.WindowsState = this.WindowState;
            if (this.WindowState == FormWindowState.Minimized)
                eisSettings.FrmMainSettings.WindowsState = FormWindowState.Normal;
            appConfig.SaveAppConfig(eisSettings);
            backgroundWorkerUpdater.CancelAsync();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != (Keys.J | Keys.Shift | Keys.Control))
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
            Passport.Forms.FormRegistr formRegistr = new Passport.Forms.FormRegistr(this.SqlSettings);
            formRegistr.SqlSettings = SqlSettings;
            formRegistr.MdiParent = this;
            formRegistr.Show();
            return true;
        }
        #endregion
        private void ShowUpdateProgram()
        {
            DataTable dataTable = this.SelectSqlData("tJ_UpdateProgram", true, "where dateUpdate < getdate() order by dateUpdate desc");
            if (dataTable.Rows.Count <= 0 ||
                this.SelectSqlData("tJ_UpdateProgramUserCheck", true, " where Login = SYSTEM_USER and dateCheck >= '" + Convert.ToDateTime(dataTable.Rows[0]["dateUpdate"]).ToString("yyyyMMdd HH:mm") + "'").Rows.Count != 0)
                return;
            notifyIconBirthDay.BalloonTipText = "Вышли новые обновления программы";
            notifyIconBirthDay.BalloonTipText += "\nКликните для просмотра журнала обновлений";
            notifyIconBirthDay.BalloonTipTitle = "Обновления";
            notifyIconBirthDay.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconBirthDay.Tag = "Update";
            notifyIconBirthDay.ShowBalloonTip(0);
        }
        /// <summary>
        /// дни рождения
        /// </summary>
        private void ShowBirthDays()
        {
            //DataSet dataSet = new DataSet();
            //this.SelectSqlData(dataSet, "tr_Worker", true, " where Day(birthDay) = DAy(getdate()) and Month(BirthDay) = Month(getdate()) and DateEnd is Null order by F, I, O");
            //DataTable dataTable = this.SelectSqlData("tr_Worker", true, " where Day(birthDay) = DAy(getdate()) and Month(BirthDay) = Month(getdate()) and DateEnd is Null order by F, I, O");

            DataTable dataTable = this.SelectSqlData("tr_Worker", true, " where Day(birthDay) = DAy(getdate()) and Month(BirthDay) = Month(getdate()) and DateEnd is Null order by F, I, O");
            string str = "";
            //foreach (DataRow row in (InternalDataCollectionBase) dataSet.Tables["tr_worker"].Rows)
            foreach (DataRow row in dataTable.Rows)
                str = str + row["F"].ToString() + " " + row["I"].ToString() + " " + row["O"].ToString() + "\n";
            this.notifyIconBirthDay.Tag = "BirthDay";
            if (str != "")
            {
                this.notifyIconBirthDay.BalloonTipText = str;
                this.notifyIconBirthDay.BalloonTipTitle = "Дни рождения";
                this.notifyIconBirthDay.BalloonTipIcon = ToolTipIcon.Info;
                this.notifyIconBirthDay.ShowBalloonTip(0);
            }
            else
                this.ShowUpdateProgram();
        }

        private void notifyIconBirthDay_MouseClick(object sender, MouseEventArgs e)
        {
            this.ShowBirthDays();
        }

        private void notifyIconBirthDay_BalloonTipClicked(object sender, EventArgs e)
        {
            if (((Form)this).WindowState == FormWindowState.Minimized)
                ((Form)this).WindowState = FormWindowState.Normal;
            ((Form)this).Activate();
            if (this.notifyIconBirthDay.Tag.ToString() == "BirthDay")
            {
                this.ShowUpdateProgram();
            }
            else
            {
                if (!(this.notifyIconBirthDay.Tag.ToString() == "Update"))
                    return;
                this.ShowMdiForm(typeof(FormJournalUpdateProgram));
            }
        }

        private void notifyIconBirthDay_BalloonTipClosed(object sender, EventArgs e)
        {
            if (!(this.notifyIconBirthDay.Tag.ToString() == "BirthDay"))
                return;
            this.ShowUpdateProgram();
        }

        private void notifyIconBirthDay_DoubleClick(object sender, EventArgs e)
        {
            if (((Form)this).WindowState == FormWindowState.Minimized)
                ((Form)this).WindowState = FormWindowState.Normal;
            ((Form)this).Activate();
        }

        // Таймер
        private void timerMain_Tick(object sender, EventArgs e)
        {
            this.toolStripLabelTime.Text = DateTime.Now.ToLongDateString() + ' ' + DateTime.Now.ToLongTimeString();
        }

        // таймер обновлений
        // это надо убирать
        private bool isCheckUpdate;
        public string pathUpdate;
        private void timerUpdater_Tick(object sender, EventArgs e)
        {
            this.timerUpdater.Interval = this.eisSettings.UpdateSettings.IntervalUpdate;
            if (this.isCheckUpdate || !string.IsNullOrEmpty(this.pathUpdate))
                return;
            this.isCheckUpdate = true;
        }

        private void backgroundWorkerUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            if (this.eisSettings.UpdateSettings.DownloadPath.IndexOf("ftp") == 0)
            {
                ChekerDownloaderFromFTP downloaderFromFtp = new ChekerDownloaderFromFTP(this.eisSettings.UpdateSettings.DownloadPath);
                downloaderFromFtp.CurrentVersion = Assembly.GetEntryAssembly().GetName().Version;
                downloaderFromFtp.FTPUser = "ftpuser";
                downloaderFromFtp.FTPPassword = "qazwsxedc";
                this.pathUpdate = downloaderFromFtp.PrepareUpdates();
            }
            else
            {
                ChekerDownloaderFromFolder downloaderFromFolder = new ChekerDownloaderFromFolder(this.eisSettings.UpdateSettings.DownloadPath);
                downloaderFromFolder.CurrentVersion = Assembly.GetEntryAssembly().GetName().Version;
                this.pathUpdate = downloaderFromFolder.PrepareUpdates();
            }
        }

        private void backgroundWorkerUpdater_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.isCheckUpdate = false;
            if (string.IsNullOrEmpty(this.pathUpdate))
                return;
            this.toolBtnUpdate.Visible = true;
        }
        #region Функции открытия форм
        // открытие формы в родительском окне
        // надо добавить поиск уже открытого окна
        private void ShowMdiForm(System.Type typeForm, params object[] args)
        {
            FormBase formBase = (FormBase)null;
            try
            {
                formBase = (FormBase)Activator.CreateInstance(typeForm, args);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message + (object)ex.InnerException != null ? "\r\n" + ex.InnerException.Message : "", ex.Source + " (Вызов формы)");
            }
            if (formBase == null)
                return;
            ((Form)formBase).MdiParent = (Form)this;
            formBase.SqlSettings = this.eisSettings.SqlSettings;
            formBase.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            formBase.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Control)formBase).Show();
        }

        private FormBase form_ShowForm(object sender, ShowFormEventArgs e)
        {
            FormBase formBase = (FormBase)null;
            try
            {
                formBase = (FormBase)Activator.CreateInstance(System.Type.GetType(e.TypeForm), e.Param);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, ex.Source);
            }
            if (formBase == null)
                return (FormBase)null;
            e.Form = formBase;
            if (e.FormMode == eFormMode.Mdi)
                ((Form)formBase).MdiParent = (Form)this;
            if (e.SQLSettings != null)
                formBase.SqlSettings = e.SQLSettings;
            else
                formBase.SqlSettings = this.eisSettings.SqlSettings;
            formBase.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            switch ((int)e.FormMode)
            {
                case 0:
                    e.DialogResult = ((Form)formBase).ShowDialog();
                    break;
                case 1:
                    (formBase).Show();
                    break;
                case 2:
                    if (formBase is DockContentBase && e.DockPanel != null && e.DockPanel is DockPanel)
                    {
                        ((DockContentBase)formBase).Show((DockPanel)e.DockPanel);
                        break;
                    }
                (formBase).Show();
                    break;
            }
            return formBase;
        }

        private void f_GoToSchema(object sender, GoToSchemaEventArgs e)
        {
            foreach (Form mdiChild in ((Form)this).MdiChildren)
            {
                if (mdiChild.GetType() == typeof(FormGeneralScheme2))
                {
                    if (!((FormGeneralScheme2)mdiChild).SetObjectsInCenterScreen(e.IdObjList))
                        return;
                    mdiChild.WindowState = ((Form)this).ActiveMdiChild == null ? FormWindowState.Normal : ((Form)this).ActiveMdiChild.WindowState;
                    mdiChild.Activate();
                    mdiChild.Visible = true;
                    return;
                }
            }
            int num = (int)MessageBox.Show("Для начала нужно открыть схему");
        }

        #endregion


        private void toolStripMenuItemFLAbonent_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormAbonent));
        }



        private void toolMenuItemListAllHouses_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormHouses));
        }

        private void toolMenuItemChangeAddressHouse_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormHousesEditAdress));
        }

        private void toolMenuItemControlers_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormControlers));
        }

        private void toolMenuItemActs_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormActs));
        }

        private void toolMenuItemRepPlombs_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormPlombs));
        }

        private void toolMenuItemProtocolDeb_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormDebitorka));
        }

        private void toolMenuItemAnalysisAndComparison_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormDebRep));
        }

        private void toolMenuItemReportControler_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormWorkControllers));
        }

        private void toolMenuItemReportOnGrounds_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormRepAbnFlag));
        }

        private void toolMenuItemExportDocuments_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormKOinUE));
        }

        private void Method175(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormUEOpl));
        }

        private void UEOplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormUEOpl));
        }

        private void UEDebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormUEDeb));
        }
        //ЭТО ДЛЯ ХОЛДИНГА
        private void UESurveyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.ShowMdiForm(typeof (FormImportSurveyFromUE));
        }

        private void toolMenuItemUEOplPost_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormUEoplPOST));
        }

        private void toolMenuItemUEAnalysis_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormUEanalysis));
        }

        private void toolMenuItemImportFromSberbank_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormSBROpl));
        }

        private void toolMenuItemImportFromMatrica_Click(object sender, EventArgs e)
        {
            // this.ShowMdiForm(typeof(FormImportMatricaSurvey));
            this.ShowMdiForm(typeof(FormMatritca));
        }

        private void toolMenuItemLegalAbn_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormAbn));
        }

        private void toolMenuItemInputCharge_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormCntVal));
        }

        private void toolMenuItemInputCheck_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormInputCheck));
        }

        private void toolMenuItemCreateAndPrintDocs_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormGroupDoc));
        }

        private void toolMenuItemReportCharge_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormReportMain));
        }

        private void toolMenuItemReportInvoice_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormReportCorrect));
        }

        private void toolMenuItemREportPerformance_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormReportOper));
        }

        private void toolMenuItemNoticeGos_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormNotification));
        }

        private void toolMenuItemAbonentsLegal_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormLAbn));
        }

        private void toolMenuItemAbnObjectsLegal_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Legal.Forms.Object.FormLObj));
        }

        private void toolMenuItemMeterLegal_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Legal.Forms.Meter.FormLCnt));
        }

        private void toolMenuItemBanksLegal_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormBanks));
        }

        private void toolMenuItemActBalanceInventory_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormActBalance));
        }

        private void toolStripMenuTechConnectionActRBPNew_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalActRBP));
        }

        private void toolMenuItemGraphicSurveys_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormGraphicsView));
        }

        private void toolMenuItemSetAccountPeriod_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormCalcPeriod));
        }

        private void toolMenuItemCloseAccountPeriod_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormClosePeriod));
        }

        private void toolMenuItemAuthorizedPersons_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormAuthorizedPerson));
        }

        private void toolMenuItemNumInvoice_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormNumberFact));
        }

        private void toolMenuItemTariffLegal_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormEnterTariff));
        }

        private void toolMenuItemInputForecast_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormPrognosisMonthAdd));
        }

        private void toolMenuItemExportToGRP_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormExportGRP));
        }

        private void toolMenuItemExportToODS_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormExportDispatch));
        }

        private void toolMenuItemExportToUE_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormExportUlenergo));
        }

        private void toolMenuItemExportTo1C_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormExport1C));
        }

        private void toolMenuItemExportToMRSK_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormExportMRSK));
        }

        private void toolMenuItemCheckInvoice_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormTestSchetFact));
        }

        private void toolMenuItemCheckDocAndInvoice_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormTestDocSum));
        }

        private void плановыеЧасыПиковойНагрузкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormMeasurementsHour));
        }

        private void отчетПоЗамерамРежимногоДняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormReportMeasur));
        }

        private void toolMenuItemDocScan_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormDocScan));
        }

        private void toolStripMenuItemClassifier_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormClassifier));
        }

        private void toolStripMenuItemJobTitles_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJobTitles));
        }

        private void toolStripMenuItemDivisions_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormDivisions));
        }

        private void toolStripMenuItemWorkers_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormWorkers));
        }

        private void toolStripMenuItemCounter_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormCounter));
        }

        private void toolStripMenuItemTransformator_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormTrans));
        }

        private void toolStripMenuItemTransf_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormTrasformer));
        }

        private void toolMenuItemCoupling_Click(object sender, EventArgs e)
        {
            FormEquipment formEquipment = new FormEquipment(this.eisSettings.SqlSettings, (EquipmentType)612);
            ((Form)formEquipment).MdiParent = (Form)this;
            ((Control)formEquipment).Show();
        }

        private void toolMenuItemCable_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormCable));
        }

        private void toolStripMenuItemKladrObj_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormKladr));
        }

        private void toolStripMenuItemKladrSocr_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormKladrSocr));
        }

        private void toolMenuItemGroupWorker_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormGroupWorker));
        }

        private void toolStripMenuItemKladrHouse_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormMapObj));
        }

        private void Method123(object sender, EventArgs e)
        {
            ((DockContentBase)new FormDocValueList(this.SqlSettings)).Show();
        }

        private void tsmiPassportChars_Click(object sender, EventArgs e)
        {
            FormReferPassportChars referPassportChars = new FormReferPassportChars(this.SqlSettings, (TypeCharacteristic)0);
            ((Form)referPassportChars).MdiParent = (Form)this;
            int num = 1;
            ((Form)referPassportChars).StartPosition = (FormStartPosition)num;
            ((DockContentBase)referPassportChars).Show();
        }

        private void toolStripMenuItemKontragent_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormTechConnectionAddAbn));
        }


        private void toolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormUsers));
        }

        private void toolStripMenuItemSecurity_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormSecurityUser));
        }

        private void toolStripMenuItemLogInOut_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormLogInOut));
        }

        private void LoadChat(object sender, EventArgs e)
        {
            foreach (Form mdiChild in ((Form)this).MdiChildren)
            {
                if (mdiChild.GetType() == typeof(FormChatClient))
                {
                    mdiChild.WindowState = ((Form)this).ActiveMdiChild == null ? FormWindowState.Normal : ((Form)this).ActiveMdiChild.WindowState;
                    mdiChild.Activate();
                    mdiChild.Visible = true;
                    return;
                }
            }
            FormChatClient formChatClient = new FormChatClient(this.tcpsocketChat);
            // SQLSettings sqlSettings = this.SqlSettings;
            ((FormBase)formChatClient).SqlSettings = SqlSettings;
            ((Form)formChatClient).MdiParent = (Form)this;
            ((Control)formChatClient).Show();
        }

        private void toolStripMenuItemChatService_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(FormChatService))
                {
                    mdiChild.WindowState = this.ActiveMdiChild == null ? FormWindowState.Normal : ((Form)this).ActiveMdiChild.WindowState;
                    mdiChild.Activate();
                    mdiChild.Visible = true;
                    return;
                }
            }
            FormChatService formChatService1 = new FormChatService(this.tcpsocketChat);
            formChatService1.SqlSettings = SqlSettings;
            formChatService1.MdiParent = this;
            formChatService1.SendCommandEvent += new SendCommandHandler(this.Method1);
            SendCommandEvent += new SendCommandHandler(formChatService1.GetNetworkMessage);
            formChatService1.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in ((Form)this).MdiChildren)
            {
                if (mdiChild.GetType() == typeof(FormChatService))
                {
                    mdiChild.WindowState = ((Form)this).ActiveMdiChild == null ? FormWindowState.Normal : ((Form)this).ActiveMdiChild.WindowState;
                    mdiChild.Activate();
                    mdiChild.Visible = true;
                    return;
                }
            }
            FormNetControl formNetControl1 = new FormNetControl();
            formNetControl1.SqlSettings = this.SqlSettings;
            ((Form)formNetControl1).MdiParent = (Form)this;
            formNetControl1.SendCommandEvent += new SendCommandHandler(this.Method1);
            this.SendCommandEvent += new SendCommandHandler(formNetControl1.GetNetworkMessage);
            formNetControl1.Show();
        }

        private void toolMenuItemJournalLog_CLick(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalLog));
        }

        private void toolMenuitemGeneralScheme_Click(object sender, EventArgs e)
        {
            FormGeneralScheme2 formGeneralScheme2_1 = new FormGeneralScheme2(new SQLSettings(this.eisSettings.SqlSettings));
            formGeneralScheme2_1.MdiParent = (Form)this;
            formGeneralScheme2_1.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            formGeneralScheme2_1.SendCommandEvent += new SendCommandHandler(this.Method1);
            formGeneralScheme2_1.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            this.SendCommandEvent += new SendCommandHandler(formGeneralScheme2_1.GetNetworkMessage);
            formGeneralScheme2_1.Show();
        }

        private void toolStripMenuItemNormalSchema_Click(object sender, EventArgs e)
        {
            FormGeneralScheme2 formGeneralScheme2 = new FormGeneralScheme2(new SQLSettings(this.eisSettings.SqlSettings), 2, 0);
            formGeneralScheme2.MdiParent = this;
            formGeneralScheme2.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            formGeneralScheme2.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            formGeneralScheme2.Show();
        }

        private void toolStripMenuItemConnectToServer_Click(object sender, EventArgs e)
        {
            FormGeneralScheme2 formGeneralScheme2 = new FormGeneralScheme2(new SQLSettings(this.eisSettings.SqlSettings), new EndpointAddress(new Uri("net.tcp://192.168.1.248:22222/WCFSchemeServer").ToString()), 1);
            formGeneralScheme2.MdiParent = (Form)this;
            formGeneralScheme2.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            formGeneralScheme2.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            formGeneralScheme2.Show();
        }

        private void toolMenuItemOPCMessageConfig_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormOPCMessageConfig));
        }

        private void toolMenuItemLinkCellPoint_Click(object sender, EventArgs e)
        {
            FormLinkSchmAbn formLinkSchmAbn = new FormLinkSchmAbn();
            ((FormBase)formLinkSchmAbn).SqlSettings = SqlSettings;
            formLinkSchmAbn.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            formLinkSchmAbn.MdiParent = (Form)this;
            formLinkSchmAbn.Show();
        }

        private void toolMenuItemLogDispatcher_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormLogDispatcher));
        }

        private void toolStripMenuItemPoweringReport_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormPoweringReport));
        }

        private void toolStripMenuItemMeasurementReport_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormMeasuringReport));
        }

        private void toolMenuItemAbnOff_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormLinkAbnOff));
        }
        /// <summary>
        /// Отчет привязанные абоненты
        /// </summary>
        private void toolMenuItemLREportLinkAbn_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormLinkAbnNewAndOld));
        }

        private void tsmiPassportPS_Click(object sender, EventArgs e)
        {
            FormDockPassport frm = new FormDockPassport(this.SqlSettings, TypeObjListGroup.Substations);

            frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Form)frm).MdiParent = (Form)this;
            ((DockContentBase)frm).Show();
        }


        private void tsmiPassportCable_Click(object sender, EventArgs e)
        {
            FormDockPassport formDockPassport = new FormDockPassport(SqlSettings, TypeObjListGroup.CableLines);
            formDockPassport.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            formDockPassport.MdiParent = (this);
            ((DockContentBase)formDockPassport).Show();
        }

        private void tsmiPassportAirLine_Click(object sender, EventArgs e)
        {
            FormDockPassport formDockPassport = new FormDockPassport(this.SqlSettings, TypeObjListGroup.AirLines);
            formDockPassport.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Form)formDockPassport).MdiParent = (Form)this;
            ((DockContentBase)formDockPassport).Show();
        }

        private void tsmiPassportTransf_Click(object sender, EventArgs e)
        {
            FormDockPassport formDockPassport = new FormDockPassport(this.SqlSettings, TypeObjListGroup.Transformer);
            ((FormBase)formDockPassport).GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Form)formDockPassport).MdiParent = (Form)this;
            ((DockContentBase)formDockPassport).Show();
        }

        private void tsmiPassportSettingsPanel_Click(object sender, EventArgs e)
        {

            FormSettings formSettings = new FormSettings(this.SqlSettings, Constants.TypeSettings.PassportPanel);
            formSettings.ShowDialog();
            formSettings.Dispose();
        }

        private void tsmiPassportReports_Click(object sender, EventArgs e)
        {
            FormRegistr formRegistr = new FormRegistr(this.SqlSettings);
            formRegistr.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((FormBase)formRegistr).SqlSettings = SqlSettings;
            ((Form)formRegistr).MdiParent = (Form)this;
            ((Control)formRegistr).Show();
        }

        private void tsmiPassportValueLists_Click(object sender, EventArgs e)
        {
            FormReferValueLists formReferValueLists = new FormReferValueLists(this.SqlSettings);
            ((Form)formReferValueLists).MdiParent = (Form)this;
            ((Control)formReferValueLists).Show();
        }

        private void tsmiReportOffKL_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormReportOffKL));
        }

        private void toolStripMenuItemCalcLoss_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalCalcLoss));
        }
        #region Documents
        // загрузка грп - не нужна
        private void toolStripMenuItemUnloadingGRP_Click(object sender, EventArgs e)
        {
            //UnloadingGWC unloadingGwc = new UnloadingGWC();
            //((Form)unloadingGwc).MdiParent = (Form)this;
            //SQLSettings sqlSettings = new SQLSettings(this.eisSettings.SqlSettings);
            //((FormBase)unloadingGwc).SqlSettings = sqlSettings;
            //(unloadingGwc).Show();
        }
        // Журнал задач
        private void toolMenuItemJRequest_Click(object sender, EventArgs e)
        {
            FormJournalRequest formJournalRequest = new FormJournalRequest();
            formJournalRequest.MdiParent = (this);
            //SQLSettings sqlSettings = new SQLSettings(this.eisSettings.SqlSettings);
            formJournalRequest.SqlSettings = SqlSettings;
            formJournalRequest.Show();
        }
        // Журнал нарядов
        private void toolMenuItemJOrder_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in ((Form)this).MdiChildren)
            {
                if (mdiChild.GetType() == typeof(FormJournalOrder))
                {
                    mdiChild.WindowState = ((Form)this).ActiveMdiChild == null ? FormWindowState.Normal : ((Form)this).ActiveMdiChild.WindowState;
                    mdiChild.Activate();
                    mdiChild.Visible = true;
                    return;
                }
            }
            this.ShowMdiForm(typeof(FormJournalOrder));
        }
        // Журнал заявок на ремонт
        private void toolMenuItemJRequestForRepair_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalRequestForRepair));
        }
        // Журнал по отключениям для службы 05
        private void toolMenuItemJRequestForRepairCrash_Click(object sender, EventArgs e)
        {
            //this.ShowMdiForm(typeof(FormJournalRequestForRepair), (object)true);
            this.ShowMdiForm(typeof(RequestForRepairN.FormJournalRequestForRepair), (object)true);
        }
        // Уставки РЗА
        private void toolMenuItemJRelayProtectionAutomation_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalRelayProtectionAutomation));
        }
        // Журнал раскопок
        private void toolMenuItemJExcavation_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalExcavation));
        }
        #endregion
        private void toolMenuItemJTechnologicalFailures_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormTechnologicalFailures));
        }

        private void toolStripMenuItemJDefect_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJDefect));
        }

        private void Method83(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(TemperatureSR));
        }

        private void toolStripMenuTechConnectionRequest_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormTechConnectionRequest));
        }

        private void toolStripMenuTechConnectionTU_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalTU));
        }

        private void toolStripMenuTechConnectionMailTU_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalMailTU));
        }

        private void договораНаТПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalContract));
        }

        private void toolStripMenuTechConnectionTC_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalActs), -1, 1240);
        }

        private void toolStripMenuActsElectricalInspection_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalActs), -1, 1238);
        }

        private void toolStripMenuItemActsPerformingTU_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalActs), -1, 1239);
        }

        private void toolStripMenuTechConnectionActRBP_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormActBalance));
        }

        private void toolMenuItemJournalTCRebinding_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalRebinding));
        }

        private void tsmiMeasurement_Click(object sender, EventArgs e)
        {
            // this.ShowMdiForm(typeof(Documents.Forms.Measurement.FormMeasurement));
            this.ShowMdiForm(typeof(FormMeasurement));
        }

        private void tsmiMeasurement_Click_N(object sender, EventArgs e)
        {
            // Documents.Measurement.FormMeasurement frm = new Documents.Measurement.FormMeasurement();
            //ShowMdiForm(typeof(Documents.Measurement.FormMeasurement));

            Documents.Measurement.FormMeasurement frm = new Documents.Measurement.FormMeasurement();
            ((Form)frm).MdiParent = (Form)this;
            frm.SqlSettings = this.eisSettings.SqlSettings;
            frm.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Control)frm).Show();

        }

        private void toolStripMenuItemFileExplorer_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormFileExplorer));
        }

        private void toolMenuItemMergeAbnMoveAbnObj_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormMergeAndMoveAbnObj));
        }

        private void toolMenuItemJournalDistributionConsumers_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormDistributionConsumers));
        }

        private void toolMenuItemJournalDamage_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalDamage));
        }

        private void toolMenuItemJournalActDefection_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalActDetection));
        }

        private void toolMenuItemTemperature_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalTemperature));
        }
        #region Работа с ограничением потребителей
        //Заявки на ограничение/возобновление режима потребления
        private void toolStripMenuItemConnectDisconnect_Click(object sender, EventArgs e)
        {
            FormList formList = new FormList();
            ((Form)formList).MdiParent = (Form)this;
            //SQLSettings sqlSettings = this.eisSettings.SqlSettings;
            ((FormBase)formList).SqlSettings = this.eisSettings.SqlSettings;
            ((Control)formList).Show();
        }
        //Отчёт ОДС по заявкам на ограничение режима потребления
        private void toolStripMenuItemReportODS_Click(object sender, EventArgs e)
        {
            FormODS formOds = new FormODS();
            ((Form)formOds).MdiParent = (Form)this;
            // SQLSettings sqlSettings = this.eisSettings.SqlSettings;
            ((FormBase)formOds).SqlSettings = this.eisSettings.SqlSettings;
            ((Control)formOds).Show();
        }
        #endregion
        // Журнал обновлений
        private void toolMenuItemUpdateProgram_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalUpdateProgram));
        }

        private void AboutClick(object sender, EventArgs e)
        {
            // MemoryManagement.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
            FormAboutUlges frm = new FormAboutUlges();
            frm.ShowDialog();
            frm.Dispose();

        }

        private void toolMenuItemUpdates_Click(object sender, EventArgs e)
        {
            FormUpdateSettings formUpdateSettings = new FormUpdateSettings();
            formUpdateSettings.UpdateSettings = this.eisSettings.UpdateSettings;
            ((Form)formUpdateSettings).MdiParent = (Form)this;
            ((Control)formUpdateSettings).Show();
        }

        private void Method60(object sender, EventArgs e)
        {
            FormPassportCountSwitch passportCountSwitch = new FormPassportCountSwitch(this.SqlSettings);
            ((Form)passportCountSwitch).MdiParent = (Form)this;
            ((Control)passportCountSwitch).Show();
        }

        private void tsmiPassportDoc_Click(object sender, EventArgs e)
        {
            FormDocValueList formDocValueList = new FormDocValueList(this.SqlSettings);
            ((Form)formDocValueList).MdiParent = (Form)this;
            ((DockContentBase)formDocValueList).Show();
        }

        private void tsmiImportoldTransf_Click(object sender, EventArgs e)
        {
            FormImportOldTransf formImportOldTransf = new FormImportOldTransf();
            //SQLSettings sqlSettings = this.SqlSettings;
            ((FormBase)formImportOldTransf).SqlSettings = SqlSettings;
            ((Form)formImportOldTransf).MdiParent = (Form)this;
            ((Control)formImportOldTransf).Show();
        }

        // Контроль ввода в эксплуатацию КЛ
        private void tsmiCableTestingAfterRepair_Click(object sender, EventArgs e)
        {
            FormCableTestingAfterRepair testingAfterRepair = new FormCableTestingAfterRepair(this.SqlSettings);
            //SQLSettings sqlSettings = this.SqlSettings;
            ((FormBase)testingAfterRepair).SqlSettings = SqlSettings;
            ((Form)testingAfterRepair).MdiParent = (Form)this;
            ((Control)testingAfterRepair).Show();
        }

        private void tsmiDocTamplates_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormDocTamplateReference));
        }

        private void журналАбонентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalAbn));
        }

        private void tsmiMemorandums_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormMemorandumJournal));
        }

        private void tsmiBossUsers_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormBossUsers));
        }

        private void gfcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormPassportEE));
        }

        private void TimerMessage_Tick(object sender, EventArgs e)
        {
            this.toolBtnMessage.Visible = true;
            if (this.toolBtnMessage.DisplayStyle == ToolStripItemDisplayStyle.Image)
                this.toolBtnMessage.DisplayStyle = ToolStripItemDisplayStyle.None;
            else
                this.toolBtnMessage.DisplayStyle = ToolStripItemDisplayStyle.Image;
        }

        private void toolBtnMessage_Click(object sender, EventArgs e)
        {
            this.TimerMessage.Stop();
            this.toolBtnMessage.Visible = false;
            //if (((Form)this).ActiveMdiChild != null)
            //    ((Form)this.frmReportMessage).WindowState = ((Form)this).ActiveMdiChild.WindowState;
            //else
            //    ((Form)this.frmReportMessage).WindowState = FormWindowState.Normal;
            //((Control)this.frmReportMessage).Visible = true;
            //((Control)this.frmReportMessage).Show();
            //((Form)this.frmReportMessage).Activate();
        }

        //private void ShowFormReportEvent()
        //{
        //    this.frmReportMessage = new FormReportEvent();
        //    this.frmReportMessage.NewEvent += new EventHandler(this.StartTimerMessage);
        //    this.frmReportMessage.SqlSettings = SqlSettings;
        //    ((Form)this.frmReportMessage).MdiParent = (Form)this;
        //}

        private void StartTimerMessage(object sender, EventArgs e)
        {
            //    if (this.frmReportMessage == ((Form)this).ActiveMdiChild || this.TimerMessage.Enabled)
            //        return;
            this.TimerMessage.Start();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ReportsEvents.ReportEvent += new MainEventHandler(this.frmReportMessage.FEEvent);
        //    ReportsEvents.Report1();
        //}


        private void CreateBeginnerParametrChat()
        {
            this.TimerChat = new System.Timers.Timer(10000.0);
            this.TimerChat.Enabled = false;
            this.TimerChat.Elapsed += new ElapsedEventHandler(this.TimerChat_Elapsed);

            this.tcpsocketChat = new TCPSocketListener();
            this.tcpsocketChat.AutoReconnect = false;
            this.tcpsocketChat.FinalWord = "</document>";
            this.tcpsocketChat.OnSocketEvent += new DelegateSocketEventMethod(this.tcpsocketChat_OnSocketEvent);
            // эта хрень не нужна
            //  this.Field5.RemoteEndPoint = new IPEndPoint(IPAddress.Parse("192.168.7.5"), 30792);
        }
        /// <summary>
        /// Вроде чат
        /// </summary>
        private void LoadChat()
        {
            // загрузим настройки чата
            DataTable dataTable = this.SelectSqlData("tSettings", true, "where Module = 'Chat'");
            if (dataTable.Rows.Count <= 0)
                return;
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                string xml = dataTable.Rows[0]["Settings"].ToString();
                xmlDocument.LoadXml(xml);
                string xpath = "Sett";
                XmlNode xmlNode = xmlDocument.SelectSingleNode(xpath);
                this.tcpsocketChat.RemoteEndPoint = new IPEndPoint(IPAddress.Parse(xmlNode.Attributes["IP"].Value.ToString()), Convert.ToInt32(xmlNode.Attributes["Port"].Value));
                Convert.ToBoolean(xmlNode.Attributes["IsReconnect"].Value);
                this.TimerChat.Interval = Convert.ToDouble(xmlNode.Attributes["TimeReconnect"].Value) * 1000.0;
            }
            catch
            {
            }
        }

        private void ConnectChat()
        {
            this.GetTUser();
            this.tcpsocketChat.Sync_Connect();
        }

        private void GetTUser()
        {
            // DataTable dataTable = new DataTable("tUser");
            DataTable dataTable = this.SelectSqlData("tUser", true, " where Login = SYSTEM_USER");
            if (dataTable.Rows.Count <= 0)
                return;
            this.Login = dataTable.Rows[0]["Login"].ToString();
            this._Name = dataTable.Rows[0]["Name"].ToString();
        }

        private void tcpsocketChat_OnSocketEvent(SocketEventTypeEnum socketEventTypeEnum, object EventData)
        {
            switch (socketEventTypeEnum - 1)
            {
                case SocketEventTypeEnum.Connected:
                    if (this.TimerChat.Enabled)
                        this.TimerChat.Stop();
                    this.CreateCommandBox();
                    this.SetStatusConnect(global::EIS.Properties.Resources.Connect); //Connect
                    this.tcpsocketChat.Async_Receive(10000);
                    return;
                case SocketEventTypeEnum.Accepted:
                case SocketEventTypeEnum.DataSent:
                case SocketEventTypeEnum.Error:
                    break;
                case SocketEventTypeEnum.DataRecieved:
                    this.tcpsocketChat.Async_Receive(10000);
                    return;
                case SocketEventTypeEnum.MessageReceive:
                    this.MessageReceive(EventData.ToString());
                    return;
                case SocketEventTypeEnum.Disconnected:
                    if (!this.TimerChat.Enabled)
                    {
                        this.TimerChat.Stop();
                        return;
                    }
                    break;
                case SocketEventTypeEnum.RemoteSideDisconnected:
                    this.TimerChat.Start();
                    this.SetStatusConnect(global::EIS.Properties.Resources.Disconnect); //Disconnect
                    return;
                case SocketEventTypeEnum.ErrorConnect:
                    this.TimerChat.Start();
                    if (this.toolLabelConnect.Image != global::EIS.Properties.Resources.Disconnect)
                        this.SetStatusConnect(global::EIS.Properties.Resources.Disconnect); ;

                    break;
                default:
                    return;

            }
        }

        private void Method15(Bitmap bitmap)
        {
            if (this.toolStripMain.IsDisposed || !this.toolStripMain.IsHandleCreated)
                return;
            this.toolLabelConnect.Image = (Image)bitmap;
        }

        private void SetStatusConnect(Bitmap bitmap)
        {
            if (this.toolStripMain.InvokeRequired)
            {
                if (this.toolStripMain.IsDisposed || !this.toolStripMain.IsHandleCreated)
                    return;
                this.toolStripMain.Invoke((Delegate)new MulticastDelegate1(this.Method15), bitmap);
            }
            else
                this.toolLabelConnect.Image = (Image)bitmap;
        }


        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FlashWindow(IntPtr _param1, bool _param2);

        private void Method13(string str)
        {
            FlashWindow(Handle, true);
            int num = (int)MessageBox.Show(str, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Method12(string text)
        {
            if (InvokeRequired)
            {
                MulticastDelegate2 method = new MulticastDelegate2(Method13);
                object[] args = new object[] { text };
                Invoke(method, args);
            }
            FlashWindow(Handle, true);
            MessageBox.Show(text, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void MessageReceive(string xml)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);
                string xpath = "document";
                XmlNode xmlNode = xmlDocument.SelectSingleNode(xpath);
                if (xmlNode == null)
                    return;
                SendCommandEventArgs commandEventArgs = new SendCommandEventArgs();
                XmlAttribute xmlAttribute = xmlNode.Attributes["Cookie"];
                if (xmlAttribute != null)
                    commandEventArgs.Cake = (Convert.ToInt32(xmlAttribute.Value));
                XmlNodeList xmlNodeList = xmlNode.SelectNodes("Command");
                if (xmlNodeList != null && xmlNodeList.Count > 0)
                {
                    foreach (XmlNode xmlNode2 in xmlNodeList)
                    {
                        xmlAttribute = xmlNode2.Attributes["Name"];
                        if (xmlAttribute != null)
                        {
                            CommandBox commandBox = new CommandBox((Command)Enum.Parse(typeof(Command), xmlAttribute.Value));
                            foreach (XmlAttribute xmlAttribute2 in xmlNode2.Attributes)
                                commandBox.AddAttribute(xmlAttribute2.Name, xmlAttribute2.Value);
                            foreach (XmlNode xmlNode3 in xmlNode2.ChildNodes)
                            {
                                CommandValue commandValue = new CommandValue(xmlNode3.Name);
                                foreach (XmlAttribute xmlAttribute3 in xmlNode3.Attributes)
                                    commandValue.AddAtribute(xmlAttribute3.Name, xmlAttribute3.Value);
                                commandBox.AddValue(commandValue);
                            }
                            commandEventArgs.AddCommand(commandBox);
                        }
                    }
                    OnSendCommand(this, commandEventArgs);
                }
            }
            catch (Exception xmlDocument)
            {
                MessageBox.Show(xmlDocument.Message);
            }
        }

        private XmlDocument Method10(int Cake = -1)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode xmlDeclaration = (XmlNode)xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(xmlDeclaration);
            string name1 = "document";
            XmlNode element = (XmlNode)xmlDocument.CreateElement(name1);
            XmlNode newChild = element;
            xmlDocument.AppendChild(newChild);
            string name2 = "Cookie";
            XmlAttribute attribute = xmlDocument.CreateAttribute(name2);
            attribute.Value = Cake.ToString();
            element.Attributes.Append(attribute);
            this.Method8(element);
            return xmlDocument;
        }

        private void TimerChat_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.tcpsocketChat.Sync_Connect();
        }

        private void Method8(XmlNode xmlDoc)
        {
            XmlDocument ownerDocument = xmlDoc.OwnerDocument;
            string name1 = "Sender";
            XmlNode element = (XmlNode)ownerDocument.CreateElement(name1);
            xmlDoc.AppendChild(element);
            string name2 = "Login";
            XmlAttribute attribute1 = ownerDocument.CreateAttribute(name2);
            attribute1.Value = this.Login;
            element.Attributes.Append(attribute1);
            string name3 = "LoginName";
            XmlAttribute attribute2 = ownerDocument.CreateAttribute(name3);
            attribute2.Value = this._Name;
            element.Attributes.Append(attribute2);
            string name4 = "Computer";
            XmlAttribute attribute3 = ownerDocument.CreateAttribute(name4);
            attribute3.Value = Environment.MachineName;
            element.Attributes.Append(attribute3);
        }

        private void Method7(XmlNode xmlDoc, List<string> Recipients)
        {
            XmlDocument ownerDocument = xmlDoc.OwnerDocument;
            foreach (string str in Recipients)
            {
                XmlNode element = (XmlNode)ownerDocument.CreateElement("Recipient");
                element.Value = str;
                xmlDoc.AppendChild(element);
            }
        }

        private void CreateCommandsEvent(CommandBox Commands, int num, XmlNode xmlDoc)
        {
            XmlDocument ownerDocument = xmlDoc.OwnerDocument;
            XmlNode xmlNode = (XmlNode)ownerDocument.CreateElement("Command");
            xmlDoc.AppendChild(xmlNode);
            XmlAttribute xmlAttribute = ownerDocument.CreateAttribute("Name");
            xmlAttribute.Value = Commands.Command.ToString();
            xmlNode.Attributes.Append(xmlAttribute);
            foreach (string attrebuteName in Commands.AttrebuteNames)
            {
                xmlAttribute = ownerDocument.CreateAttribute(attrebuteName);
                xmlAttribute.Value = Commands.GetAttributeValue(attrebuteName).ToString();
                xmlNode.Attributes.Append(xmlAttribute);
            }
            using (var enumerator = Commands.Values.GetEnumerator())
            {
                while ((enumerator).MoveNext())
                {
                    CommandValue current = enumerator.Current;
                    XmlNode xmlNode2 = (XmlNode)ownerDocument.CreateElement(current.Name);
                    xmlNode.AppendChild(xmlNode2);
                    foreach (string attrebuteName in current.AttrebuteNames)
                    {
                        xmlAttribute = ownerDocument.CreateAttribute(attrebuteName);
                        xmlAttribute.Value = current.GetAttributeValue(attrebuteName);
                        xmlNode2.Attributes.Append(xmlAttribute);
                    }
                }
            }
        }

        private void Method5(CommandBox Commands, List<string> Recipients = null)
        {
            XmlDocument xmlDocument = this.Method10(-1);
            XmlNode xmlNode = xmlDocument.SelectSingleNode("document");
            if (Recipients != null)
                this.Method7(xmlNode, Recipients);
            this.CreateCommandsEvent(Commands, 1, xmlNode);
            this.tcpsocketChat.Async_send(xmlDocument.InnerXml);
        }

        private void Method4(IEnumerable<CommandBox> Commands, List<string> Recipients = null, int Cake = -1)
        {
            XmlDocument xmlDocument = this.Method10(Cake);
            XmlNode xmlNode = xmlDocument.SelectSingleNode("document");
            if (Recipients != null)
                this.Method7(xmlNode, Recipients);
            int num = 0;
            using (var enumerator = Commands.GetEnumerator())
            {
                while ((enumerator).MoveNext())
                    this.CreateCommandsEvent(enumerator.Current, ++num, xmlNode);
            }
            this.tcpsocketChat.Async_send(xmlDocument.InnerXml);
        }

        private void CreateCommandBox()
        {
            CommandBox commandBox = new CommandBox(Command.Login);
            commandBox.AddAttribute("Login", this.Login);
            commandBox.AddAttribute("LoginName", this._Name);
            commandBox.AddAttribute("Computer", Environment.MachineName);
            this.Method5(commandBox, null);
        }

        //private void Method2()
        //{
        //    this.tcpsocketChat.Sync_Disconnect();
        //}

        private void Method1(object sender, FormLbr.SendCommandEventArgs e)
        {
            this.Method4(e.Commands, e.Recipients, e.Cake);
        }
        // Журнал распоряжений Бытовой сектор
        private void журналРаспоряженийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////
        }
        // Журнал распоряжений Государтвенный сектор
        private void ToolMenuItemJournalOrdersInspection_Click(object sender, EventArgs e)
        {
            //Legal.Forms.Document.FormJournalOrdersInspection frm = new Legal.Forms.Document.FormJournalOrdersInspection();
            //frm.MdiParent = this;
            //frm.SqlSettings = SqlSettings;
            //frm.Show();
            ShowMdiForm(typeof(Legal.Forms.Document.FormJournalOrdersInspection));
        }

        private void привязанныеАбонентыNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(SchemeReports.FormLinkAbnNewAndOld));
        }

        private void заявкиНаРемонтToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.ShowMdiForm(typeof(Documents.JournalRequestForRepair.FormJournalRequestForRepair));
        }

        private void аварийныеОтключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Documents.JournalRequestForRepair.FormJournalRequestForRepair), (object)true);
        }
        #region аварийные Отключения и заявки На Ремонт
        private void заявкиНаРемонтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(RequestForRepair.FormJournalRequestForRepair));
        }

        private void аварийныеОтключенияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(RequestForRepair.FormJournalRequestForRepair), (object)true);
        }
        private void заявкиНаРемонтToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(RequestForRepairN.FormJournalRequestForRepair));
        }

        private void аварийныеОтключенияToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(RequestForRepairN.FormJournalRequestForRepair), (object)true);
        }

        #endregion
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void поступлениеВСетьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(ASCAPC.DlgGraphSource));
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void toolMenuItemCountMeter_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Legal.Forms.Meter.FormCountMeter));
        }

        private void ReportAverageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.ShowMdiForm(typeof(Legal.Forms.Calculat.FormReportMain_Average));

        }

        private void toolMenuItemImportDNU_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormImportDNU));
        }
        #region Технологические нарушения v1
        /// <summary>
        /// журнал технологических нарушений
        /// </summary>
        private void toolStripMenuItemFormJournalDamage_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(DailyReport.JournalDamage.FormJournalDamage));
        }
        /// <summary>
        /// акты расследований
        /// </summary>
        private void toolStripMenuItemFormJournalActDetection_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Documents.ActDetection.FormJournalActDetection));
        }
        /// <summary>
        /// журнал погоды
        /// </summary>
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Documents.Temperature.FormJournalTemperature));
        }
        #endregion

        private void всеДомаСНачислениямипоПериодамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormReportHouseAll));

        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void расчетПотерьЭлектрическойЭнергииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalCalcLoss));
        }

        #region Технологические нарушения v2
        /// <summary>
        /// журнал технологических нарушений
        /// </summary>
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(DailyReportN.JournalDamage.FormJournalDamage));
        }
        /// <summary>
        /// акты расследований
        /// </summary>
        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(DailyReportN.JournalActDetection.FormJournalActDetection));
        }
        /// <summary>
        /// журнал погоды
        /// </summary>
        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(DailyReportN.Temperature.FormJournalTemperature));
        }
        #endregion

        #region Технологические нарушения v2 (Дополнительные журналы)
        private void журналТехнологическихНарушенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(DailyReportN.JournalDamage.FormJournalDamage), new List<eTypeDocuments>
            {
                eTypeDocuments.DamageHV,
                eTypeDocuments.DamageLV
            }
            , "Журнал нарушений");
        }

        private void журналДефектовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(DailyReportN.JournalDamage.FormJournalDamage), new List<eTypeDocuments>
            {
                eTypeDocuments.DefectHV,
                eTypeDocuments.DefectLV
            }
            , "Журнал дефектов");
        }

        private void общийЖурналТехнологическихНарушенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyReportN.JournalDamage.FormJournalDamage frm = new DailyReportN.JournalDamage.FormJournalDamage();
            ((FormBase)frm).SqlSettings = SqlSettings;
            frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            frm.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            frm.MdiParent = (Form)this;
            frm.Text = "Общий журнал технологических нарушений";
            frm.Show();

        }
        #endregion

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {

        }



        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Test1.Form1));
        }

        private void выгрузкаДоговоровТПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(UpLoadContractTC.FormUpload));
        }


        #region Технологические нарушения v2(меню Документы)
        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(DailyReportN.JournalDamage.FormJournalDamage));
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(DailyReportN.JournalActDetection.FormJournalActDetection));
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(DailyReportN.Temperature.FormJournalTemperature));
        }
        #endregion
        #region Технологические нарушения v2 (Дополнительные журналы)(меню Журналы)
        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            DailyReportN.JournalDamage.FormJournalDamage frm = new DailyReportN.JournalDamage.FormJournalDamage();
            ((FormBase)frm).SqlSettings = SqlSettings;
            frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            frm.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            frm.MdiParent = (Form)this;
            frm.Text = "Общий журнал технологических нарушений";
            frm.Show();

        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(DailyReportN.JournalDamage.FormJournalDamage), new List<eTypeDocuments>
            {
                eTypeDocuments.DamageHV,
                eTypeDocuments.DamageLV
            }
      , "Журнал нарушений");
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(DailyReportN.JournalDamage.FormJournalDamage), new List<eTypeDocuments>
            {
                eTypeDocuments.DefectHV,
                eTypeDocuments.DefectLV
            }
            , "Журнал дефектов");

        }
        #endregion
        #region Заявки на отключение
        // Журнал отключений на ремонт
        private void toolStripMenuItem31_Click_1(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(RequestForRepairN.FormJournalRequestForRepair));
        }

        #endregion

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {

            Documents.Measurement.FormMeasurement frm = new Documents.Measurement.FormMeasurement();
            ((Form)frm).MdiParent = (Form)this;
            frm.SqlSettings = this.eisSettings.SqlSettings;
            frm.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Control)frm).Show();
        }

        private void ведомостьКорректировкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            StatementsForME.FormCorrectiveStatements frm = new StatementsForME.FormCorrectiveStatements();
            ((Form)frm).MdiParent = (Form)this;
            frm.SqlSettings = this.eisSettings.SqlSettings;
            frm.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Control)frm).Show();


        }

        private void тестReportView12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            this.ShowMdiForm(typeof(Test1.Form1));
        }

        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        {

        }


        private void справочникОбъектовдомовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(ReferenceMapObj.FormMapObj));
        }

        private void toolStripMenuItem36_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(ReferenceWorker.FormJobTitles));
        }

        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(ReferenceWorker.FormDivisions));
        }

        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(ReferenceWorker.FormWorkers));
        }

        private void произвольныеСправочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormReference
            this.ShowMdiForm(typeof(Reference.FormReference));
        }

        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {

            StatementsForME.FormCorrectiveStatements frm = new StatementsForME.FormCorrectiveStatements();
            ((Form)frm).MdiParent = (Form)this;
            frm.SqlSettings = this.eisSettings.SqlSettings;
            frm.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Control)frm).Show();
        }

        private void журналАбонентовToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //this.ShowMdiForm(typeof(Abonent.FormJournalAbnN));
        }

        private void отчетПоСпециаличтамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Legal.Forms.Calculat.FormReportPeriod frm = new Legal.Forms.Calculat.FormReportPeriod();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void toolStripMenuItemSchedulers_Click(object sender, EventArgs e)
        {
            FormSettingsSender frm = new FormSettingsSender();
            ((Form)frm).MdiParent = (Form)this;
            frm.SqlSettings = this.eisSettings.SqlSettings;
            frm.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Control)frm).Show();

        }

        private void журналАктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormActJournal frm = new FormActJournal();
            //frm.SqlSettings = this.SqlSettings;
            //frm.Show();

            this.ShowMdiForm(typeof(FormActJournal));
        }

        //[DllImport("cefsharp.net.dll")]
        //private static extern void Init();
        private void LoadWebBrowser(bool isFlag = true)
        {
            string Url = @"http://192.168.1.33/lm";
            if (isFlag)
            {
                this.ShowMdiForm(typeof(Library.Browser), Url);
            }
            else
            {
                //ExamplePresenter.Init();

                //Browser brw = new Browser
                //{
                //    Url = Url
                //};
                //brw.Show();
            }

        }

        private void гИСToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadWebBrowser();
        }


        private void ведомостьОбменаДаннымиСГИСToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(ExportToPostGIS.FormExportReference));
        }

        private void журналАктовToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ShowMdiForm(typeof(Legal.Forms.ActCheck.Form_Journal_ActReplace));
        }

        private void toolStripMenuItemChatService_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        {
            LoadWebBrowser();
        }

        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(ExportToPostGIS.FormExportReference));
        }

        private void импортКадровыхДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Personnel.FormExportPersonnel));
        }

        private void отчётПоЗамерамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(SchemeReports.FormMeasuringReport));
        }

        private void отчетПоЗамерам2019ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(SchemeReports.FormMeasuringReport));
        }

        private void протоколРаботыСпециалистовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            this.ShowMdiForm(typeof(Prv.Forms.Reports.FormLogs));

        }



        private void toolStripMenuItem51_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJournalAbn));
        }


        private void toolStripMenuItemConsumer_Click(object sender, EventArgs e)
        {
            //this.ShowMdiForm(typeof(Consumer.Forms.AbnFastTree));
         
            //Consumer.Forms.AbnFastTree frm = new Consumer.Forms.AbnFastTree();
            //frm.SqlSettings = this.SqlSettings;
            ////frm.Show();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //}

            Consumer.Forms.AbnFastTree frm = new Consumer.Forms.AbnFastTree ();
            ((Form)frm).MdiParent = (Form)this;
            frm.SqlSettings = this.eisSettings.SqlSettings;
            frm.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Control)frm).Show();
        }

        private void toolStripMenuItemJournalAbonentov_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Abonent.FormJournalAbnN2));
            
        }

        private void toolStripMenuItemFindConsumers_Click(object sender, EventArgs e)
        {
 
            FormAbnFind fFind = new FormAbnFind();
            fFind.SqlSettings = this.SqlSettings;
            //fFind.MdiParent = this.MdiParent;
            if (fFind.ShowDialog() == DialogResult.OK)
            {
                if (fFind.SelectedTypeAbn == Constants.Constants.TypeAbnLegal
                    || fFind.SelectedTypeAbn == Constants.Constants.TypeAbnNet
                    || fFind.SelectedTypeAbn == Constants.Constants.TypeAbnSale)
                {
                    //FormLbr.Classes.ShowFormEventArgs eShow = new FormLbr.Classes.ShowFormEventArgs();
                    //eShow.TypeForm = "Legal.Forms.FormAbn, Legal";
                    //eShow.FormMode = FormLbr.Classes.eFormMode.Mdi;
                    //eShow.Param = new object[2];
                    //eShow.Param[0] = fFind.SelectedAbonent;
                    //eShow.Param[1] = fFind.SelectedObj;
                    //eShow.SQLSettings = this.SqlSettings;
                    //this.OnShowForm(eShow);

                    FormAbn frm = new FormAbn(fFind.SelectedAbonent, fFind.SelectedObj);
                    frm.SqlSettings = this.SqlSettings;
                    frm.MdiParent = this;

                    frm.Show();

                }
                if (fFind.SelectedTypeAbn == Constants.Constants.TypeAbnPrivate
                    || fFind.SelectedTypeAbn == Constants.Constants.TypeAbnPrivateNoDog)
                {
                    Prv.Forms.Abonent.FormAbonent frm = new Prv.Forms.Abonent.FormAbonent(fFind.SelectedAbonent, fFind.SelectedTypeAbn);
                    frm.SqlSettings = this.SqlSettings;
                    frm.MdiParent = this;

                    frm.Show();
                }

            }


        }

        private void тестDockContentBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Abonent.FormJournalAbnN2));
        }
        /// <summary>
        /// отчет Потребления Помесячно По Объекта С Привязками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void отчетПотребленияПомесячноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Calculat.FormReportObjLink));
        }

        private void toolMenuItemJPlombGos_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJPlomb));
        }
        private void toolMenuItemJPlomb_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormJPlomb));
        }

        private void toolStripMenuItem47_Click_1(object sender, EventArgs e)
        {
                this.ShowMdiForm(typeof(Reference.FormReference));
        }

        private void журналДемонтажаПриборовУчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(Legal.Forms.ActCheck.Form_Journal_MeterDemontag));
            //
            //Legal.Forms.ActCheck.Form_Journal_MeterDemontag frm = new Legal.Forms.ActCheck.Form_Journal_MeterDemontag();
            //frm.SqlSettings = this.SqlSettings;
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //}
        }

        private void умныйГородToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(ExportToPostGIS.SmartCity.FormIntegrationSmartCity)); 
        }

        private void ведомостьПоПризнакампоПрямымПеретокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormRepQuantityAbnObjFlag));
        }

        private void деревоОбъектовСхемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(SchemeReports.FormTreeSchmObj));
        }

        private void тестЗагрузкиМоделиСхемыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(SchemeReports.FormTestShmEdge));
        }

        private void импортПолучасовокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(ASCAPC.DlgImportToTok));
        }

        private void структураТочекИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.ShowMdiForm(typeof(ASCAPC.DlgStructFider));

            ASCAPC.DlgStructFider frm = new ASCAPC.DlgStructFider();
            ((Form)frm).MdiParent = (Form)this;
            ((Form)frm).Show();

            //
            //ASCAPC.DlgStructFider frm = new ASCAPC.DlgStructFider();
            //((ASCAPC.FormBaseTok)frm).ShowDialog();
        }

        private void приборыУчетаASOKAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Meter.FormASOCAMeters));
        }

        private void загрузкаНарядовНаРаботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(ExportToPostGIS.Dokuments.FormExportOrder));
        }

        private void отчетПоРазногласиямВКонтрольныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            //Legal.Forms.Meter.FormMeter_ControlUchet frm = new Legal.Forms.Meter.FormMeter_ControlUchet();
            //frm.SqlSettings = this.SqlSettings;
            //frm.Show();

            ShowMdiForm(typeof(Legal.Forms.Meter.FormMeter_ControlUchet));
        }

        private void tspMenuItemJournalN_Click(object sender, EventArgs e)
        {
            //
        }

        private void реестрТочекИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ASCAPC.DlgStructFiderReestr frm = new ASCAPC.DlgStructFiderReestr();
            ((Form)frm).MdiParent = (Form)this;
            ((Form)frm).Show();
        }

        private void toolStripMenuItem52_Click(object sender, EventArgs e)
        {
            //
        }

        private void уведомлениеОбОтключенияхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(NotificationOfRepairs.FormJournalNotificationOfRepairs));
        }

        private void анализПотребляемойЭнергииИУстановленнойМощностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormRepPowerVolume));
        }

        private void ведомостьПоПризнакамСПриборамиУчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormRepAbnObjMeter_Flag));
        }

        private void выгрузкаАварйныхИПлановыхРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(StatementsForME.FormReportToPlanned));
        }

        private void реестрТочекПодключенияПоУровнюНапряженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormAbnObjPoint));
        }

        private void формированиеСчетовНаАвансToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(FormAvans));
        }

        private void отчетРуководителюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(StatementsForME.FormReportToManager));
        }


        private void выгрузкаПлановыхРаботНаСайтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(typeof(StatementsForME.FormReportRepairPlanned));
        }

        private void нарядыНаРаботу2021ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                foreach (Form mdiChild in ((Form)this).MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(JournalOrder.FormJournalOrder))
                    {
                        mdiChild.WindowState = ((Form)this).ActiveMdiChild == null ? FormWindowState.Normal : ((Form)this).ActiveMdiChild.WindowState;
                        mdiChild.Activate();
                        mdiChild.Visible = true;
                        return;
                    }
                }
                this.ShowMdiForm(typeof(JournalOrder.FormJournalOrder));
            
        }
    }
}
