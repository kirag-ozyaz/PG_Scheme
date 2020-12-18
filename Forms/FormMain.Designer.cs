using System.Drawing;
using System.Windows.Forms;

namespace EIS.Forms
{
    partial class FormMain
    {

        #region  Дизайн формы
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolLabelConnect = new System.Windows.Forms.ToolStripLabel();
            this.toolBtnMessage = new System.Windows.Forms.ToolStripButton();
            this.menuStripFormMain = new System.Windows.Forms.MenuStrip();
            this.tspMenuItemUE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConsumer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemJournalAbonentov = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFindConsumers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFLAbonent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJPlomb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemListHouses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemListAllHouses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemChangeAddressHouse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemControlers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemReports = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemActs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemRepPlombs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemCharge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemProtocolDeb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemAnalysisAndComparison = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemReportControler = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemReportOnGrounds = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem42 = new System.Windows.Forms.ToolStripSeparator();
            this.журналАктовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протоколРаботыСпециалистовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обменToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemExportDocuments = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemImportFromUE = new System.Windows.Forms.ToolStripMenuItem();
            this.UEOplToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UEDebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UESurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemUEOplPost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemUEAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemImportFromSberbank = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemImportFromMatrica = new System.Windows.Forms.ToolStripMenuItem();
            this.журналАбонентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналРаспоряженийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemLegalAbn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemChargeLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemInputCharge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemInputCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemReportsLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemCreateAndPrintDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemReportCharge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemReportInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemREportPerformance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemReportOnGroundsGos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemNoticeGos = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоЗамерамРежимногоДняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuItemReportAverage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemImportDNU = new System.Windows.Forms.ToolStripMenuItem();
            this.всеДомаСНачислениямипоПериодамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоСпециаличтамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem44 = new System.Windows.Forms.ToolStripSeparator();
            this.отчетПотребленияПомесячноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьПоПризнакампоПрямымПеретокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоРазногласиямВКонтрольныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализПотребляемойЭнергииИУстановленнойМощностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemReferenceLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemAbonentsLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemAbnObjectsLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemMeterLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.приборыУчетаASOKAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemBanksLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuItemCountMeter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemsDocsLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemActBalanceInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemDocScan = new System.Windows.Forms.ToolStripMenuItem();
            this.журналРаспоряженийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.журналАктовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.журналДемонтажаПриборовУчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJPlombGos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemGraphicSurveys = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuSettingsLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemSetAccountPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemCloseAccountPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemAuthorizedPersons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemNumInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemTariffLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.плановыеЧасыПиковойНагрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemForeCast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemInputForecast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemExportLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemExportToGRP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemExportToODS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemExportToUE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemExportTo1C = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemExportToMRSK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemCheckLegal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemCheckInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemCheckDocAndInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemScheme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuitemGeneralScheme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConnectToServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNormalSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuItemOPCMessageConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemLinkCellPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReports = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemLogDispatcher = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPoweringReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMeasurementReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemAbnOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemLREportLinkAbn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem49 = new System.Windows.Forms.ToolStripSeparator();
            this.привязанныеАбонентыNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоЗамерам2019ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tspMenuItemMap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem46 = new System.Windows.Forms.ToolStripMenuItem();
            this.tspDatatoGIS = new System.Windows.Forms.ToolStripMenuItem();
            this.tspTOK5 = new System.Windows.Forms.ToolStripMenuItem();
            this.структураТочекИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрТочекИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поступлениеВСетьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортПолучасовокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReference = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuClassifier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClassifier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKladr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKladrObj = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKladrSocr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemGroupWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKladrHouse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemKadrs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemJobTitles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDivisions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWorkers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMeters = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCounter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTransformator = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTransf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemCoupling = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemCable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem110 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKontragent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSepar8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem47 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPassport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPassportPS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPassportCable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPassportAirLine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPassportTransf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator51 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPassportReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPassportReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCountSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportOffKL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCableTestingAfterRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPassportReferense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPassportChars = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPassportValueLists = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPassportDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator41 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPassportSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPassportSettingsPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportoldTransf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator91 = new System.Windows.Forms.ToolStripSeparator();
            this.gfcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUnloadingGRP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorBulletens = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuItemJournals = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJRequestForRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJRequestForRepairCrash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConnectDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReportODS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJRelayProtectionAutomation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJExcavation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJTechnologicalFailures = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemJDefect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMeasurement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMemorandums = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTechConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTechConnectionRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTechConnectionTU = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTechConnectionMailTU = new System.Windows.Forms.ToolStripMenuItem();
            this.договораНаТПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator71 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuActsElectricalInspection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemActsPerformingTU = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTechConnectionTC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTechConnectionActRBP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTechConnectionActRBPNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCalcLoss = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDocTamplates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator101 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuItemMergeAbnMoveAbnObj = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJournalDistributionConsumers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJournalTCRebinding = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator121 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuItemDailyReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJournalDamage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJournalActDefection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemTemperature = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemServices = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBossUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator111 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemLogInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemJournalLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tspMenuItemSchedulers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAditionally = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWindowCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRef = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemUpdateProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripSeparator();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.tspMenuItemJournalN = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникОбъектовдомовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripSeparator();
            this.произвольныеСправочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналАбонентовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.тестDockContentBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem43 = new System.Windows.Forms.ToolStripSeparator();
            this.импортКадровыхДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiMeasurementN = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиНаРемонтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аварийныеОтключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиНаРемонтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.аварийныеОтключенияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.общийЖурналТехнологическихНарушенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналТехнологическихНарушенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналДефектовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripSeparator();
            this.ведомостьКорректировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFormJournalDamage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFormJournalActDetection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.расчетПотерьЭлектрическойЭнергииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripSeparator();
            this.выгрузкаДоговоровТПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.умныйГородToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестReportView12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem45 = new System.Windows.Forms.ToolStripMenuItem();
            this.гИСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьОбменаДаннымиСГИСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem50 = new System.Windows.Forms.ToolStripSeparator();
            this.загрузкаНарядовНаРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem48 = new System.Windows.Forms.ToolStripSeparator();
            this.схемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётПоЗамерамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деревоОбъектовСхемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестЗагрузкиМоделиСхемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem51 = new System.Windows.Forms.ToolStripSeparator();
            this.уведомлениеОбОтключенияхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuWindow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemWindowsRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWindowsMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWindowMaximaze = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorWindow = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemWindowsClose = new System.Windows.Forms.ToolStripMenuItem();
            this.токToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconBirthDay = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerUpdater = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerUpdater = new System.ComponentModel.BackgroundWorker();
            this.TimerMessage = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem52 = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьПоПризнакамСПриборамиУчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain.SuspendLayout();
            this.menuStripFormMain.SuspendLayout();
            this.contextMenuWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelTime,
            this.toolStripSeparator2,
            this.toolBtnUpdate,
            this.toolLabelConnect,
            this.toolBtnMessage});
            this.toolStripMain.Location = new System.Drawing.Point(0, 596);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1063, 25);
            this.toolStripMain.TabIndex = 9;
            // 
            // toolStripLabelTime
            // 
            this.toolStripLabelTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelTime.AutoSize = false;
            this.toolStripLabelTime.Name = "toolStripLabelTime";
            this.toolStripLabelTime.Size = new System.Drawing.Size(200, 22);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnUpdate
            // 
            this.toolBtnUpdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnUpdate.Image")));
            this.toolBtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnUpdate.Name = "toolBtnUpdate";
            this.toolBtnUpdate.Size = new System.Drawing.Size(65, 22);
            this.toolBtnUpdate.Text = "Обновить";
            this.toolBtnUpdate.Visible = false;
            // 
            // toolLabelConnect
            // 
            this.toolLabelConnect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolLabelConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLabelConnect.Image = (Image)EIS.Properties.Resources.Disconnect;
            this.toolLabelConnect.Name = "toolLabelConnect";
            this.toolLabelConnect.Size = new System.Drawing.Size(16, 22);
            this.toolLabelConnect.Text = "Соединение";
            // 
            // toolBtnMessage
            // 
            this.toolBtnMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnMessage.Image = global::EIS.Properties.Resources.mail;
            this.toolBtnMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnMessage.Name = "toolBtnMessage";
            this.toolBtnMessage.Size = new System.Drawing.Size(23, 22);
            this.toolBtnMessage.Text = "toolStripButton1";
            this.toolBtnMessage.Click += new System.EventHandler(this.toolBtnMessage_Click);
            // 
            // menuStripFormMain
            // 
            this.menuStripFormMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspMenuItemUE,
            this.toolStripMenuItemFL,
            this.toolMenuItemLegal,
            this.toolMenuItemScheme,
            this.toolStripMenuItemReference,
            this.tsmPassport,
            this.toolStripMenuItemDocument,
            this.toolStripMenuItemServices,
            this.toolStripMenuItemAditionally,
            this.toolStripMenuItemWindows,
            this.toolStripMenuItemRef,
            this.tspMenuItemJournalN});
            this.menuStripFormMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripFormMain.Name = "menuStripFormMain";
            this.menuStripFormMain.Size = new System.Drawing.Size(1063, 24);
            this.menuStripFormMain.TabIndex = 8;
            this.menuStripFormMain.Text = "menuStrip1";
            // 
            // tspMenuItemUE
            // 
            this.tspMenuItemUE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemConsumer,
            this.toolStripMenuItemJournalAbonentov,
            this.toolStripMenuItemFindConsumers});
            this.tspMenuItemUE.Name = "tspMenuItemUE";
            this.tspMenuItemUE.Size = new System.Drawing.Size(136, 20);
            this.tspMenuItemUE.Text = "Учет электроэнергии";
            // 
            // toolStripMenuItemConsumer
            // 
            this.toolStripMenuItemConsumer.Image = global::EIS.Properties.Resources.partners;
            this.toolStripMenuItemConsumer.Name = "toolStripMenuItemConsumer";
            this.toolStripMenuItemConsumer.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItemConsumer.Text = "Контрагенты";
            this.toolStripMenuItemConsumer.Click += new System.EventHandler(this.toolStripMenuItemConsumer_Click);
            // 
            // toolStripMenuItemJournalAbonentov
            // 
            this.toolStripMenuItemJournalAbonentov.Image = global::EIS.Properties.Resources.PatientFile;
            this.toolStripMenuItemJournalAbonentov.Name = "toolStripMenuItemJournalAbonentov";
            this.toolStripMenuItemJournalAbonentov.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItemJournalAbonentov.Text = "Журнал абонентов";
            this.toolStripMenuItemJournalAbonentov.Click += new System.EventHandler(this.toolStripMenuItemJournalAbonentov_Click);
            // 
            // toolStripMenuItemFindConsumers
            // 
            this.toolStripMenuItemFindConsumers.Image = global::EIS.Properties.Resources.Find;
            this.toolStripMenuItemFindConsumers.Name = "toolStripMenuItemFindConsumers";
            this.toolStripMenuItemFindConsumers.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItemFindConsumers.Text = "Поиск абонентов";
            this.toolStripMenuItemFindConsumers.Click += new System.EventHandler(this.toolStripMenuItemFindConsumers_Click);
            // 
            // toolStripMenuItemFL
            // 
            this.toolStripMenuItemFL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFLAbonent,
            this.toolMenuItemJPlomb,
            this.toolMenuItemListHouses,
            this.toolMenuItemControlers,
            this.toolMenuItemReports,
            this.обменToolStripMenuItem,
            this.журналАбонентовToolStripMenuItem,
            this.журналРаспоряженийToolStripMenuItem});
            this.toolStripMenuItemFL.Name = "toolStripMenuItemFL";
            this.toolStripMenuItemFL.Size = new System.Drawing.Size(107, 20);
            this.toolStripMenuItemFL.Text = "Бытовой сектор";
            // 
            // toolStripMenuItemFLAbonent
            // 
            this.toolStripMenuItemFLAbonent.Image = global::EIS.Properties.Resources.FL;
            this.toolStripMenuItemFLAbonent.Name = "toolStripMenuItemFLAbonent";
            this.toolStripMenuItemFLAbonent.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItemFLAbonent.Text = "Карточка абонента";
            this.toolStripMenuItemFLAbonent.Click += new System.EventHandler(this.toolStripMenuItemFLAbonent_Click);
            // 
            // toolMenuItemJPlomb
            // 
            this.toolMenuItemJPlomb.Image = global::EIS.Properties.Resources.Seal;
            this.toolMenuItemJPlomb.Name = "toolMenuItemJPlomb";
            this.toolMenuItemJPlomb.Size = new System.Drawing.Size(203, 22);
            this.toolMenuItemJPlomb.Text = "Журнал пломб";
            this.toolMenuItemJPlomb.Click += new System.EventHandler(this.toolMenuItemJPlomb_Click);
            // 
            // toolMenuItemListHouses
            // 
            this.toolMenuItemListHouses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemListAllHouses,
            this.toolMenuItemChangeAddressHouse});
            this.toolMenuItemListHouses.Image = global::EIS.Properties.Resources.gohome;
            this.toolMenuItemListHouses.Name = "toolMenuItemListHouses";
            this.toolMenuItemListHouses.Size = new System.Drawing.Size(203, 22);
            this.toolMenuItemListHouses.Text = "Список домов";
            // 
            // toolMenuItemListAllHouses
            // 
            this.toolMenuItemListAllHouses.Name = "toolMenuItemListAllHouses";
            this.toolMenuItemListAllHouses.Size = new System.Drawing.Size(207, 22);
            this.toolMenuItemListAllHouses.Text = "Список всех домов";
            this.toolMenuItemListAllHouses.Click += new System.EventHandler(this.toolMenuItemListAllHouses_Click);
            // 
            // toolMenuItemChangeAddressHouse
            // 
            this.toolMenuItemChangeAddressHouse.Name = "toolMenuItemChangeAddressHouse";
            this.toolMenuItemChangeAddressHouse.Size = new System.Drawing.Size(207, 22);
            this.toolMenuItemChangeAddressHouse.Text = "Изменение адреса дома";
            this.toolMenuItemChangeAddressHouse.Click += new System.EventHandler(this.toolMenuItemChangeAddressHouse_Click);
            // 
            // toolMenuItemControlers
            // 
            this.toolMenuItemControlers.Image = global::EIS.Properties.Resources.mapControler;
            this.toolMenuItemControlers.Name = "toolMenuItemControlers";
            this.toolMenuItemControlers.Size = new System.Drawing.Size(203, 22);
            this.toolMenuItemControlers.Text = "Участки контролеров";
            this.toolMenuItemControlers.Click += new System.EventHandler(this.toolMenuItemControlers_Click);
            // 
            // toolMenuItemReports
            // 
            this.toolMenuItemReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemActs,
            this.toolMenuItemRepPlombs,
            this.toolMenuItemCharge,
            this.toolMenuItemReportControler,
            this.toolMenuItemReportOnGrounds,
            this.toolStripMenuItem42,
            this.журналАктовToolStripMenuItem,
            this.протоколРаботыСпециалистовToolStripMenuItem});
            this.toolMenuItemReports.Image = global::EIS.Properties.Resources.report;
            this.toolMenuItemReports.Name = "toolMenuItemReports";
            this.toolMenuItemReports.Size = new System.Drawing.Size(203, 22);
            this.toolMenuItemReports.Text = "Отчеты";
            // 
            // toolMenuItemActs
            // 
            this.toolMenuItemActs.Name = "toolMenuItemActs";
            this.toolMenuItemActs.Size = new System.Drawing.Size(253, 22);
            this.toolMenuItemActs.Text = "Акты";
            this.toolMenuItemActs.Click += new System.EventHandler(this.toolMenuItemActs_Click);
            // 
            // toolMenuItemRepPlombs
            // 
            this.toolMenuItemRepPlombs.Image = global::EIS.Properties.Resources.report_key;
            this.toolMenuItemRepPlombs.Name = "toolMenuItemRepPlombs";
            this.toolMenuItemRepPlombs.Size = new System.Drawing.Size(253, 22);
            this.toolMenuItemRepPlombs.Text = "Пломбы и марки";
            this.toolMenuItemRepPlombs.Click += new System.EventHandler(this.toolMenuItemRepPlombs_Click);
            // 
            // toolMenuItemCharge
            // 
            this.toolMenuItemCharge.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemProtocolDeb,
            this.toolMenuItemAnalysisAndComparison});
            this.toolMenuItemCharge.Name = "toolMenuItemCharge";
            this.toolMenuItemCharge.Size = new System.Drawing.Size(253, 22);
            this.toolMenuItemCharge.Text = "Начисления";
            // 
            // toolMenuItemProtocolDeb
            // 
            this.toolMenuItemProtocolDeb.Name = "toolMenuItemProtocolDeb";
            this.toolMenuItemProtocolDeb.Size = new System.Drawing.Size(185, 22);
            this.toolMenuItemProtocolDeb.Text = "Протокол";
            this.toolMenuItemProtocolDeb.Click += new System.EventHandler(this.toolMenuItemProtocolDeb_Click);
            // 
            // toolMenuItemAnalysisAndComparison
            // 
            this.toolMenuItemAnalysisAndComparison.Name = "toolMenuItemAnalysisAndComparison";
            this.toolMenuItemAnalysisAndComparison.Size = new System.Drawing.Size(185, 22);
            this.toolMenuItemAnalysisAndComparison.Text = "Анализ и сравнение";
            this.toolMenuItemAnalysisAndComparison.Click += new System.EventHandler(this.toolMenuItemAnalysisAndComparison_Click);
            // 
            // toolMenuItemReportControler
            // 
            this.toolMenuItemReportControler.Name = "toolMenuItemReportControler";
            this.toolMenuItemReportControler.Size = new System.Drawing.Size(253, 22);
            this.toolMenuItemReportControler.Text = "Отчет по контролерам";
            this.toolMenuItemReportControler.Click += new System.EventHandler(this.toolMenuItemReportControler_Click);
            // 
            // toolMenuItemReportOnGrounds
            // 
            this.toolMenuItemReportOnGrounds.Name = "toolMenuItemReportOnGrounds";
            this.toolMenuItemReportOnGrounds.Size = new System.Drawing.Size(253, 22);
            this.toolMenuItemReportOnGrounds.Text = "Отчет по признакам";
            this.toolMenuItemReportOnGrounds.Click += new System.EventHandler(this.toolMenuItemReportOnGrounds_Click);
            // 
            // toolStripMenuItem42
            // 
            this.toolStripMenuItem42.Name = "toolStripMenuItem42";
            this.toolStripMenuItem42.Size = new System.Drawing.Size(250, 6);
            // 
            // журналАктовToolStripMenuItem
            // 
            this.журналАктовToolStripMenuItem.Name = "журналАктовToolStripMenuItem";
            this.журналАктовToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.журналАктовToolStripMenuItem.Text = "Журнал актов";
            this.журналАктовToolStripMenuItem.Click += new System.EventHandler(this.журналАктовToolStripMenuItem_Click);
            // 
            // протоколРаботыСпециалистовToolStripMenuItem
            // 
            this.протоколРаботыСпециалистовToolStripMenuItem.Image = global::EIS.Properties.Resources.Logger;
            this.протоколРаботыСпециалистовToolStripMenuItem.Name = "протоколРаботыСпециалистовToolStripMenuItem";
            this.протоколРаботыСпециалистовToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.протоколРаботыСпециалистовToolStripMenuItem.Text = "Протокол работы специалистов";
            this.протоколРаботыСпециалистовToolStripMenuItem.Click += new System.EventHandler(this.протоколРаботыСпециалистовToolStripMenuItem_Click);
            // 
            // обменToolStripMenuItem
            // 
            this.обменToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemExportDocuments,
            this.toolMenuItemImportFromUE,
            this.toolMenuItemImportFromSberbank,
            this.toolMenuItemImportFromMatrica});
            this.обменToolStripMenuItem.Image = global::EIS.Properties.Resources.Обновить;
            this.обменToolStripMenuItem.Name = "обменToolStripMenuItem";
            this.обменToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.обменToolStripMenuItem.Text = "Обмен";
            // 
            // toolMenuItemExportDocuments
            // 
            this.toolMenuItemExportDocuments.Image = global::EIS.Properties.Resources.save;
            this.toolMenuItemExportDocuments.Name = "toolMenuItemExportDocuments";
            this.toolMenuItemExportDocuments.Size = new System.Drawing.Size(187, 22);
            this.toolMenuItemExportDocuments.Text = "Экспорт документов";
            this.toolMenuItemExportDocuments.Click += new System.EventHandler(this.toolMenuItemExportDocuments_Click);
            // 
            // toolMenuItemImportFromUE
            // 
            this.toolMenuItemImportFromUE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UEOplToolStripMenuItem,
            this.UEDebToolStripMenuItem,
            this.UESurveyToolStripMenuItem,
            this.toolMenuItemUEOplPost,
            this.toolMenuItemUEAnalysis});
            this.toolMenuItemImportFromUE.Image = global::EIS.Properties.Resources.cube;
            this.toolMenuItemImportFromUE.Name = "toolMenuItemImportFromUE";
            this.toolMenuItemImportFromUE.Size = new System.Drawing.Size(187, 22);
            this.toolMenuItemImportFromUE.Text = "Импорт из УЭ";
            // 
            // UEOplToolStripMenuItem
            // 
            this.UEOplToolStripMenuItem.Name = "UEOplToolStripMenuItem";
            this.UEOplToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.UEOplToolStripMenuItem.Text = "Оплата";
            this.UEOplToolStripMenuItem.Click += new System.EventHandler(this.UEOplToolStripMenuItem_Click);
            // 
            // UEDebToolStripMenuItem
            // 
            this.UEDebToolStripMenuItem.Name = "UEDebToolStripMenuItem";
            this.UEDebToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.UEDebToolStripMenuItem.Text = "Дебиторка";
            this.UEDebToolStripMenuItem.Click += new System.EventHandler(this.UEDebToolStripMenuItem_Click);
            // 
            // UESurveyToolStripMenuItem
            // 
            this.UESurveyToolStripMenuItem.Name = "UESurveyToolStripMenuItem";
            this.UESurveyToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.UESurveyToolStripMenuItem.Text = "Обследование";
            this.UESurveyToolStripMenuItem.Click += new System.EventHandler(this.UESurveyToolStripMenuItem_Click);
            // 
            // toolMenuItemUEOplPost
            // 
            this.toolMenuItemUEOplPost.Name = "toolMenuItemUEOplPost";
            this.toolMenuItemUEOplPost.Size = new System.Drawing.Size(166, 22);
            this.toolMenuItemUEOplPost.Text = "Оплата по почте";
            this.toolMenuItemUEOplPost.Click += new System.EventHandler(this.toolMenuItemUEOplPost_Click);
            // 
            // toolMenuItemUEAnalysis
            // 
            this.toolMenuItemUEAnalysis.Name = "toolMenuItemUEAnalysis";
            this.toolMenuItemUEAnalysis.Size = new System.Drawing.Size(166, 22);
            this.toolMenuItemUEAnalysis.Text = "Анализ";
            this.toolMenuItemUEAnalysis.Click += new System.EventHandler(this.toolMenuItemUEAnalysis_Click);
            // 
            // toolMenuItemImportFromSberbank
            // 
            this.toolMenuItemImportFromSberbank.Image = global::EIS.Properties.Resources.sberbank3;
            this.toolMenuItemImportFromSberbank.Name = "toolMenuItemImportFromSberbank";
            this.toolMenuItemImportFromSberbank.Size = new System.Drawing.Size(187, 22);
            this.toolMenuItemImportFromSberbank.Text = "Импорт из СБР";
            this.toolMenuItemImportFromSberbank.Click += new System.EventHandler(this.toolMenuItemImportFromSberbank_Click);
            // 
            // toolMenuItemImportFromMatrica
            // 
            this.toolMenuItemImportFromMatrica.Image = global::EIS.Properties.Resources.AppClient;
            this.toolMenuItemImportFromMatrica.Name = "toolMenuItemImportFromMatrica";
            this.toolMenuItemImportFromMatrica.Size = new System.Drawing.Size(187, 22);
            this.toolMenuItemImportFromMatrica.Text = "Импорт \"Матрица\"";
            this.toolMenuItemImportFromMatrica.Click += new System.EventHandler(this.toolMenuItemImportFromMatrica_Click);
            // 
            // журналАбонентовToolStripMenuItem
            // 
            this.журналАбонентовToolStripMenuItem.Image = global::EIS.Properties.Resources.PatientFile;
            this.журналАбонентовToolStripMenuItem.Name = "журналАбонентовToolStripMenuItem";
            this.журналАбонентовToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.журналАбонентовToolStripMenuItem.Text = "Журнал абонентов";
            this.журналАбонентовToolStripMenuItem.Click += new System.EventHandler(this.журналАбонентовToolStripMenuItem_Click);
            // 
            // журналРаспоряженийToolStripMenuItem
            // 
            this.журналРаспоряженийToolStripMenuItem.Name = "журналРаспоряженийToolStripMenuItem";
            this.журналРаспоряженийToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.журналРаспоряженийToolStripMenuItem.Text = "Журнал распоряжений";
            this.журналРаспоряженийToolStripMenuItem.Visible = false;
            this.журналРаспоряженийToolStripMenuItem.Click += new System.EventHandler(this.журналРаспоряженийToolStripMenuItem_Click);
            // 
            // toolMenuItemLegal
            // 
            this.toolMenuItemLegal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemLegalAbn,
            this.toolMenuItemChargeLegal,
            this.toolMenuItemReportsLegal,
            this.toolMenuItemReferenceLegal,
            this.toolMenuItemsDocsLegal,
            this.toolMenuItemGraphicSurveys,
            this.toolMenuSettingsLegal,
            this.toolStripMenuItemForeCast,
            this.toolMenuItemExportLegal,
            this.toolMenuItemCheckLegal});
            this.toolMenuItemLegal.Name = "toolMenuItemLegal";
            this.toolMenuItemLegal.Size = new System.Drawing.Size(75, 20);
            this.toolMenuItemLegal.Text = "Госсектор";
            // 
            // toolMenuItemLegalAbn
            // 
            this.toolMenuItemLegalAbn.Name = "toolMenuItemLegalAbn";
            this.toolMenuItemLegalAbn.Size = new System.Drawing.Size(204, 22);
            this.toolMenuItemLegalAbn.Text = "Карточка потребителя";
            this.toolMenuItemLegalAbn.Click += new System.EventHandler(this.toolMenuItemLegalAbn_Click);
            // 
            // toolMenuItemChargeLegal
            // 
            this.toolMenuItemChargeLegal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemInputCharge,
            this.toolMenuItemInputCheck});
            this.toolMenuItemChargeLegal.Name = "toolMenuItemChargeLegal";
            this.toolMenuItemChargeLegal.Size = new System.Drawing.Size(204, 22);
            this.toolMenuItemChargeLegal.Text = "Начисления";
            // 
            // toolMenuItemInputCharge
            // 
            this.toolMenuItemInputCharge.Name = "toolMenuItemInputCharge";
            this.toolMenuItemInputCharge.Size = new System.Drawing.Size(193, 22);
            this.toolMenuItemInputCharge.Text = "Ввод начислений";
            this.toolMenuItemInputCharge.Click += new System.EventHandler(this.toolMenuItemInputCharge_Click);
            // 
            // toolMenuItemInputCheck
            // 
            this.toolMenuItemInputCheck.Name = "toolMenuItemInputCheck";
            this.toolMenuItemInputCheck.Size = new System.Drawing.Size(193, 22);
            this.toolMenuItemInputCheck.Text = "Проверка на полноту";
            this.toolMenuItemInputCheck.Click += new System.EventHandler(this.toolMenuItemInputCheck_Click);
            // 
            // toolMenuItemReportsLegal
            // 
            this.toolMenuItemReportsLegal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemCreateAndPrintDocs,
            this.toolMenuItemReportCharge,
            this.toolMenuItemReportInvoice,
            this.toolMenuItemREportPerformance,
            this.toolMenuItemReportOnGroundsGos,
            this.toolMenuItemNoticeGos,
            this.отчетПоЗамерамРежимногоДняToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolMenuItemReportAverage,
            this.toolMenuItemImportDNU,
            this.всеДомаСНачислениямипоПериодамToolStripMenuItem,
            this.отчетПоСпециаличтамToolStripMenuItem,
            this.toolStripMenuItem44,
            this.отчетПотребленияПомесячноToolStripMenuItem,
            this.анализПотребляемойЭнергииИУстановленнойМощностиToolStripMenuItem,
            this.ведомостьПоПризнакампоПрямымПеретокToolStripMenuItem,
            this.ведомостьПоПризнакамСПриборамиУчетаToolStripMenuItem,
            this.отчетПоРазногласиямВКонтрольныхToolStripMenuItem});
            this.toolMenuItemReportsLegal.Name = "toolMenuItemReportsLegal";
            this.toolMenuItemReportsLegal.Size = new System.Drawing.Size(204, 22);
            this.toolMenuItemReportsLegal.Text = "Отчеты";
            // 
            // toolMenuItemCreateAndPrintDocs
            // 
            this.toolMenuItemCreateAndPrintDocs.Name = "toolMenuItemCreateAndPrintDocs";
            this.toolMenuItemCreateAndPrintDocs.Size = new System.Drawing.Size(449, 22);
            this.toolMenuItemCreateAndPrintDocs.Text = "Формирование и печать документов";
            this.toolMenuItemCreateAndPrintDocs.Click += new System.EventHandler(this.toolMenuItemCreateAndPrintDocs_Click);
            // 
            // toolMenuItemReportCharge
            // 
            this.toolMenuItemReportCharge.Name = "toolMenuItemReportCharge";
            this.toolMenuItemReportCharge.Size = new System.Drawing.Size(449, 22);
            this.toolMenuItemReportCharge.Text = "Ведомость по начислениям";
            this.toolMenuItemReportCharge.Click += new System.EventHandler(this.toolMenuItemReportCharge_Click);
            // 
            // toolMenuItemReportInvoice
            // 
            this.toolMenuItemReportInvoice.Name = "toolMenuItemReportInvoice";
            this.toolMenuItemReportInvoice.Size = new System.Drawing.Size(449, 22);
            this.toolMenuItemReportInvoice.Text = "Ведомость по корректным счет-фактурам";
            this.toolMenuItemReportInvoice.Click += new System.EventHandler(this.toolMenuItemReportInvoice_Click);
            // 
            // toolMenuItemREportPerformance
            // 
            this.toolMenuItemREportPerformance.Image = global::EIS.Properties.Resources.Logger;
            this.toolMenuItemREportPerformance.Name = "toolMenuItemREportPerformance";
            this.toolMenuItemREportPerformance.Size = new System.Drawing.Size(449, 22);
            this.toolMenuItemREportPerformance.Text = "Протокол работы специалистов";
            this.toolMenuItemREportPerformance.Click += new System.EventHandler(this.toolMenuItemREportPerformance_Click);
            // 
            // toolMenuItemReportOnGroundsGos
            // 
            this.toolMenuItemReportOnGroundsGos.Name = "toolMenuItemReportOnGroundsGos";
            this.toolMenuItemReportOnGroundsGos.Size = new System.Drawing.Size(449, 22);
            this.toolMenuItemReportOnGroundsGos.Text = "Отчет по наличию признаков";
            this.toolMenuItemReportOnGroundsGos.Click += new System.EventHandler(this.toolMenuItemReportOnGrounds_Click);
            // 
            // toolMenuItemNoticeGos
            // 
            this.toolMenuItemNoticeGos.Name = "toolMenuItemNoticeGos";
            this.toolMenuItemNoticeGos.Size = new System.Drawing.Size(449, 22);
            this.toolMenuItemNoticeGos.Text = "Уведомления";
            this.toolMenuItemNoticeGos.Click += new System.EventHandler(this.toolMenuItemNoticeGos_Click);
            // 
            // отчетПоЗамерамРежимногоДняToolStripMenuItem
            // 
            this.отчетПоЗамерамРежимногоДняToolStripMenuItem.Name = "отчетПоЗамерамРежимногоДняToolStripMenuItem";
            this.отчетПоЗамерамРежимногоДняToolStripMenuItem.Size = new System.Drawing.Size(449, 22);
            this.отчетПоЗамерамРежимногоДняToolStripMenuItem.Text = "Отчет по замерам режимного дня";
            this.отчетПоЗамерамРежимногоДняToolStripMenuItem.Click += new System.EventHandler(this.отчетПоЗамерамРежимногоДняToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(446, 6);
            // 
            // toolMenuItemReportAverage
            // 
            this.toolMenuItemReportAverage.Image = global::EIS.Properties.Resources.Export_To_Document;
            this.toolMenuItemReportAverage.Name = "toolMenuItemReportAverage";
            this.toolMenuItemReportAverage.Size = new System.Drawing.Size(449, 22);
            this.toolMenuItemReportAverage.Text = "Отчет по начислениям, введенным не по приборам учета";
            this.toolMenuItemReportAverage.Click += new System.EventHandler(this.ReportAverageToolStripMenuItem_Click);
            // 
            // toolMenuItemImportDNU
            // 
            this.toolMenuItemImportDNU.Image = global::EIS.Properties.Resources.Import_Document;
            this.toolMenuItemImportDNU.Name = "toolMenuItemImportDNU";
            this.toolMenuItemImportDNU.Size = new System.Drawing.Size(449, 22);
            this.toolMenuItemImportDNU.Text = "Журнал объемов ДНУ";
            this.toolMenuItemImportDNU.Click += new System.EventHandler(this.toolMenuItemImportDNU_Click);
            // 
            // всеДомаСНачислениямипоПериодамToolStripMenuItem
            // 
            this.всеДомаСНачислениямипоПериодамToolStripMenuItem.Image = global::EIS.Properties.Resources._object;
            this.всеДомаСНачислениямипоПериодамToolStripMenuItem.Name = "всеДомаСНачислениямипоПериодамToolStripMenuItem";
            this.всеДомаСНачислениямипоПериодамToolStripMenuItem.Size = new System.Drawing.Size(449, 22);
            this.всеДомаСНачислениямипоПериодамToolStripMenuItem.Text = "Анализ начислений по домам";
            this.всеДомаСНачислениямипоПериодамToolStripMenuItem.Click += new System.EventHandler(this.всеДомаСНачислениямипоПериодамToolStripMenuItem_Click);
            // 
            // отчетПоСпециаличтамToolStripMenuItem
            // 
            this.отчетПоСпециаличтамToolStripMenuItem.Image = global::EIS.Properties.Resources.blog;
            this.отчетПоСпециаличтамToolStripMenuItem.Name = "отчетПоСпециаличтамToolStripMenuItem";
            this.отчетПоСпециаличтамToolStripMenuItem.Size = new System.Drawing.Size(449, 22);
            this.отчетПоСпециаличтамToolStripMenuItem.Text = "Отчет по специалиcтам";
            this.отчетПоСпециаличтамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоСпециаличтамToolStripMenuItem_Click);
            // 
            // toolStripMenuItem44
            // 
            this.toolStripMenuItem44.Name = "toolStripMenuItem44";
            this.toolStripMenuItem44.Size = new System.Drawing.Size(446, 6);
            // 
            // отчетПотребленияПомесячноToolStripMenuItem
            // 
            this.отчетПотребленияПомесячноToolStripMenuItem.Name = "отчетПотребленияПомесячноToolStripMenuItem";
            this.отчетПотребленияПомесячноToolStripMenuItem.Size = new System.Drawing.Size(449, 22);
            this.отчетПотребленияПомесячноToolStripMenuItem.Text = "Потребление помесячно по объектам с привязками к схеме";
            this.отчетПотребленияПомесячноToolStripMenuItem.Click += new System.EventHandler(this.отчетПотребленияПомесячноToolStripMenuItem_Click);
            // 
            // ведомостьПоПризнакампоПрямымПеретокToolStripMenuItem
            // 
            this.ведомостьПоПризнакампоПрямымПеретокToolStripMenuItem.Name = "ведомостьПоПризнакампоПрямымПеретокToolStripMenuItem";
            this.ведомостьПоПризнакампоПрямымПеретокToolStripMenuItem.Size = new System.Drawing.Size(449, 22);
            this.ведомостьПоПризнакампоПрямымПеретокToolStripMenuItem.Text = "Ведомость по признакам (по прямым перетокам)";
            this.ведомостьПоПризнакампоПрямымПеретокToolStripMenuItem.Click += new System.EventHandler(this.ведомостьПоПризнакампоПрямымПеретокToolStripMenuItem_Click);
            // 
            // отчетПоРазногласиямВКонтрольныхToolStripMenuItem
            // 
            this.отчетПоРазногласиямВКонтрольныхToolStripMenuItem.Name = "отчетПоРазногласиямВКонтрольныхToolStripMenuItem";
            this.отчетПоРазногласиямВКонтрольныхToolStripMenuItem.Size = new System.Drawing.Size(449, 22);
            this.отчетПоРазногласиямВКонтрольныхToolStripMenuItem.Text = "Отчет по разногласиям в контрольных и расчетных приборах учета";
            this.отчетПоРазногласиямВКонтрольныхToolStripMenuItem.Click += new System.EventHandler(this.отчетПоРазногласиямВКонтрольныхToolStripMenuItem_Click);
            // 
            // анализПотребляемойЭнергииИУстановленнойМощностиToolStripMenuItem
            // 
            this.анализПотребляемойЭнергииИУстановленнойМощностиToolStripMenuItem.Name = "анализПотребляемойЭнергииИУстановленнойМощностиToolStripMenuItem";
            this.анализПотребляемойЭнергииИУстановленнойМощностиToolStripMenuItem.Size = new System.Drawing.Size(449, 22);
            this.анализПотребляемойЭнергииИУстановленнойМощностиToolStripMenuItem.Text = "Анализ потребляемой энергии и установленной мощности";
            this.анализПотребляемойЭнергииИУстановленнойМощностиToolStripMenuItem.Click += new System.EventHandler(this.анализПотребляемойЭнергииИУстановленнойМощностиToolStripMenuItem_Click);
            // 
            // toolMenuItemReferenceLegal
            // 
            this.toolMenuItemReferenceLegal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemAbonentsLegal,
            this.toolMenuItemAbnObjectsLegal,
            this.toolMenuItemMeterLegal,
            this.приборыУчетаASOKAToolStripMenuItem,
            this.toolMenuItemBanksLegal,
            this.toolStripMenuItem7,
            this.toolMenuItemCountMeter});
            this.toolMenuItemReferenceLegal.Name = "toolMenuItemReferenceLegal";
            this.toolMenuItemReferenceLegal.Size = new System.Drawing.Size(204, 22);
            this.toolMenuItemReferenceLegal.Text = "Справочники";
            // 
            // toolMenuItemAbonentsLegal
            // 
            this.toolMenuItemAbonentsLegal.Name = "toolMenuItemAbonentsLegal";
            this.toolMenuItemAbonentsLegal.Size = new System.Drawing.Size(280, 22);
            this.toolMenuItemAbonentsLegal.Text = "Потребители";
            this.toolMenuItemAbonentsLegal.Click += new System.EventHandler(this.toolMenuItemAbonentsLegal_Click);
            // 
            // toolMenuItemAbnObjectsLegal
            // 
            this.toolMenuItemAbnObjectsLegal.Name = "toolMenuItemAbnObjectsLegal";
            this.toolMenuItemAbnObjectsLegal.Size = new System.Drawing.Size(280, 22);
            this.toolMenuItemAbnObjectsLegal.Text = "Объекты";
            this.toolMenuItemAbnObjectsLegal.Click += new System.EventHandler(this.toolMenuItemAbnObjectsLegal_Click);
            // 
            // toolMenuItemMeterLegal
            // 
            this.toolMenuItemMeterLegal.Name = "toolMenuItemMeterLegal";
            this.toolMenuItemMeterLegal.Size = new System.Drawing.Size(280, 22);
            this.toolMenuItemMeterLegal.Text = "Приборы учета";
            this.toolMenuItemMeterLegal.Click += new System.EventHandler(this.toolMenuItemMeterLegal_Click);
            // 
            // приборыУчетаASOKAToolStripMenuItem
            // 
            this.приборыУчетаASOKAToolStripMenuItem.Name = "приборыУчетаASOKAToolStripMenuItem";
            this.приборыУчетаASOKAToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.приборыУчетаASOKAToolStripMenuItem.Text = "Приборы учета ASOKA";
            this.приборыУчетаASOKAToolStripMenuItem.Click += new System.EventHandler(this.приборыУчетаASOKAToolStripMenuItem_Click);
            // 
            // toolMenuItemBanksLegal
            // 
            this.toolMenuItemBanksLegal.Name = "toolMenuItemBanksLegal";
            this.toolMenuItemBanksLegal.Size = new System.Drawing.Size(280, 22);
            this.toolMenuItemBanksLegal.Text = "Банки";
            this.toolMenuItemBanksLegal.Click += new System.EventHandler(this.toolMenuItemBanksLegal_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(277, 6);
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolMenuItemCountMeter
            // 
            this.toolMenuItemCountMeter.Name = "toolMenuItemCountMeter";
            this.toolMenuItemCountMeter.Size = new System.Drawing.Size(280, 22);
            this.toolMenuItemCountMeter.Text = "Точки учета по уровням напряжения";
            this.toolMenuItemCountMeter.Click += new System.EventHandler(this.toolMenuItemCountMeter_Click);
            // 
            // toolMenuItemsDocsLegal
            // 
            this.toolMenuItemsDocsLegal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemActBalanceInventory,
            this.toolMenuItemDocScan,
            this.журналРаспоряженийToolStripMenuItem1,
            this.журналАктовToolStripMenuItem1,
            this.журналДемонтажаПриборовУчетаToolStripMenuItem,
            this.toolMenuItemJPlombGos});
            this.toolMenuItemsDocsLegal.Name = "toolMenuItemsDocsLegal";
            this.toolMenuItemsDocsLegal.Size = new System.Drawing.Size(204, 22);
            this.toolMenuItemsDocsLegal.Text = "Документы";
            // 
            // toolMenuItemActBalanceInventory
            // 
            this.toolMenuItemActBalanceInventory.Name = "toolMenuItemActBalanceInventory";
            this.toolMenuItemActBalanceInventory.Size = new System.Drawing.Size(372, 22);
            this.toolMenuItemActBalanceInventory.Text = "Акт разграничения балансовой принадлежности";
            this.toolMenuItemActBalanceInventory.Click += new System.EventHandler(this.toolMenuItemActBalanceInventory_Click);
            // 
            // toolMenuItemDocScan
            // 
            this.toolMenuItemDocScan.Name = "toolMenuItemDocScan";
            this.toolMenuItemDocScan.Size = new System.Drawing.Size(372, 22);
            this.toolMenuItemDocScan.Text = "Привязка сканированных изображений к документам";
            this.toolMenuItemDocScan.Click += new System.EventHandler(this.toolMenuItemDocScan_Click);
            // 
            // журналРаспоряженийToolStripMenuItem1
            // 
            this.журналРаспоряженийToolStripMenuItem1.Name = "журналРаспоряженийToolStripMenuItem1";
            this.журналРаспоряженийToolStripMenuItem1.Size = new System.Drawing.Size(372, 22);
            this.журналРаспоряженийToolStripMenuItem1.Text = "Журнал распоряжений";
            this.журналРаспоряженийToolStripMenuItem1.Click += new System.EventHandler(this.ToolMenuItemJournalOrdersInspection_Click);
            // 
            // журналАктовToolStripMenuItem1
            // 
            this.журналАктовToolStripMenuItem1.Image = global::EIS.Properties.Resources.address_book1;
            this.журналАктовToolStripMenuItem1.Name = "журналАктовToolStripMenuItem1";
            this.журналАктовToolStripMenuItem1.Size = new System.Drawing.Size(372, 22);
            this.журналАктовToolStripMenuItem1.Text = "Журнал актов";
            this.журналАктовToolStripMenuItem1.Click += new System.EventHandler(this.журналАктовToolStripMenuItem1_Click);
            // 
            // журналДемонтажаПриборовУчетаToolStripMenuItem
            // 
            this.журналДемонтажаПриборовУчетаToolStripMenuItem.Image = global::EIS.Properties.Resources.Register1;
            this.журналДемонтажаПриборовУчетаToolStripMenuItem.Name = "журналДемонтажаПриборовУчетаToolStripMenuItem";
            this.журналДемонтажаПриборовУчетаToolStripMenuItem.Size = new System.Drawing.Size(372, 22);
            this.журналДемонтажаПриборовУчетаToolStripMenuItem.Text = "Журнал демонтажа приборов учета";
            this.журналДемонтажаПриборовУчетаToolStripMenuItem.Click += new System.EventHandler(this.журналДемонтажаПриборовУчетаToolStripMenuItem_Click);
            // 
            // toolMenuItemJPlombGos
            // 
            this.toolMenuItemJPlombGos.Image = global::EIS.Properties.Resources.Seal;
            this.toolMenuItemJPlombGos.Name = "toolMenuItemJPlombGos";
            this.toolMenuItemJPlombGos.Size = new System.Drawing.Size(372, 22);
            this.toolMenuItemJPlombGos.Text = "Журнал пломб";
            this.toolMenuItemJPlombGos.Click += new System.EventHandler(this.toolMenuItemJPlombGos_Click);
            // 
            // toolMenuItemGraphicSurveys
            // 
            this.toolMenuItemGraphicSurveys.Name = "toolMenuItemGraphicSurveys";
            this.toolMenuItemGraphicSurveys.Size = new System.Drawing.Size(204, 22);
            this.toolMenuItemGraphicSurveys.Text = "Графики обследований";
            this.toolMenuItemGraphicSurveys.Click += new System.EventHandler(this.toolMenuItemGraphicSurveys_Click);
            // 
            // toolMenuSettingsLegal
            // 
            this.toolMenuSettingsLegal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemSetAccountPeriod,
            this.toolMenuItemCloseAccountPeriod,
            this.toolMenuItemAuthorizedPersons,
            this.toolMenuItemNumInvoice,
            this.toolMenuItemTariffLegal,
            this.плановыеЧасыПиковойНагрузкиToolStripMenuItem});
            this.toolMenuSettingsLegal.Name = "toolMenuSettingsLegal";
            this.toolMenuSettingsLegal.Size = new System.Drawing.Size(204, 22);
            this.toolMenuSettingsLegal.Text = "Настройки";
            // 
            // toolMenuItemSetAccountPeriod
            // 
            this.toolMenuItemSetAccountPeriod.Name = "toolMenuItemSetAccountPeriod";
            this.toolMenuItemSetAccountPeriod.Size = new System.Drawing.Size(264, 22);
            this.toolMenuItemSetAccountPeriod.Text = "Установить расчетный период";
            this.toolMenuItemSetAccountPeriod.Click += new System.EventHandler(this.toolMenuItemSetAccountPeriod_Click);
            // 
            // toolMenuItemCloseAccountPeriod
            // 
            this.toolMenuItemCloseAccountPeriod.Name = "toolMenuItemCloseAccountPeriod";
            this.toolMenuItemCloseAccountPeriod.Size = new System.Drawing.Size(264, 22);
            this.toolMenuItemCloseAccountPeriod.Text = "Закрыть расчетный период";
            this.toolMenuItemCloseAccountPeriod.Click += new System.EventHandler(this.toolMenuItemCloseAccountPeriod_Click);
            // 
            // toolMenuItemAuthorizedPersons
            // 
            this.toolMenuItemAuthorizedPersons.Name = "toolMenuItemAuthorizedPersons";
            this.toolMenuItemAuthorizedPersons.Size = new System.Drawing.Size(264, 22);
            this.toolMenuItemAuthorizedPersons.Text = "Уполномоченные лица";
            this.toolMenuItemAuthorizedPersons.Click += new System.EventHandler(this.toolMenuItemAuthorizedPersons_Click);
            // 
            // toolMenuItemNumInvoice
            // 
            this.toolMenuItemNumInvoice.Name = "toolMenuItemNumInvoice";
            this.toolMenuItemNumInvoice.Size = new System.Drawing.Size(264, 22);
            this.toolMenuItemNumInvoice.Text = "Номера счет-фактур";
            this.toolMenuItemNumInvoice.Click += new System.EventHandler(this.toolMenuItemNumInvoice_Click);
            // 
            // toolMenuItemTariffLegal
            // 
            this.toolMenuItemTariffLegal.Name = "toolMenuItemTariffLegal";
            this.toolMenuItemTariffLegal.Size = new System.Drawing.Size(264, 22);
            this.toolMenuItemTariffLegal.Text = "Тарифы";
            this.toolMenuItemTariffLegal.Click += new System.EventHandler(this.toolMenuItemTariffLegal_Click);
            // 
            // плановыеЧасыПиковойНагрузкиToolStripMenuItem
            // 
            this.плановыеЧасыПиковойНагрузкиToolStripMenuItem.Name = "плановыеЧасыПиковойНагрузкиToolStripMenuItem";
            this.плановыеЧасыПиковойНагрузкиToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.плановыеЧасыПиковойНагрузкиToolStripMenuItem.Text = "Плановые часы пиковой нагрузки";
            this.плановыеЧасыПиковойНагрузкиToolStripMenuItem.Click += new System.EventHandler(this.плановыеЧасыПиковойНагрузкиToolStripMenuItem_Click);
            // 
            // toolStripMenuItemForeCast
            // 
            this.toolStripMenuItemForeCast.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemInputForecast});
            this.toolStripMenuItemForeCast.Name = "toolStripMenuItemForeCast";
            this.toolStripMenuItemForeCast.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItemForeCast.Text = "Прогноз";
            // 
            // toolMenuItemInputForecast
            // 
            this.toolMenuItemInputForecast.Name = "toolMenuItemInputForecast";
            this.toolMenuItemInputForecast.Size = new System.Drawing.Size(240, 22);
            this.toolMenuItemInputForecast.Text = "Ввод прогнозируемых данных";
            this.toolMenuItemInputForecast.Click += new System.EventHandler(this.toolMenuItemInputForecast_Click);
            // 
            // toolMenuItemExportLegal
            // 
            this.toolMenuItemExportLegal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemExportToGRP,
            this.toolMenuItemExportToODS,
            this.toolMenuItemExportToUE,
            this.toolMenuItemExportTo1C,
            this.toolMenuItemExportToMRSK});
            this.toolMenuItemExportLegal.Name = "toolMenuItemExportLegal";
            this.toolMenuItemExportLegal.Size = new System.Drawing.Size(204, 22);
            this.toolMenuItemExportLegal.Text = "Экспорт";
            // 
            // toolMenuItemExportToGRP
            // 
            this.toolMenuItemExportToGRP.Name = "toolMenuItemExportToGRP";
            this.toolMenuItemExportToGRP.Size = new System.Drawing.Size(247, 22);
            this.toolMenuItemExportToGRP.Text = "Выгрузка для ГРП";
            this.toolMenuItemExportToGRP.Click += new System.EventHandler(this.toolMenuItemExportToGRP_Click);
            // 
            // toolMenuItemExportToODS
            // 
            this.toolMenuItemExportToODS.Name = "toolMenuItemExportToODS";
            this.toolMenuItemExportToODS.Size = new System.Drawing.Size(247, 22);
            this.toolMenuItemExportToODS.Text = "Выгрузка для ОДС";
            this.toolMenuItemExportToODS.Click += new System.EventHandler(this.toolMenuItemExportToODS_Click);
            // 
            // toolMenuItemExportToUE
            // 
            this.toolMenuItemExportToUE.Name = "toolMenuItemExportToUE";
            this.toolMenuItemExportToUE.Size = new System.Drawing.Size(247, 22);
            this.toolMenuItemExportToUE.Text = "Выгрузка для УльяновскЭнерго";
            this.toolMenuItemExportToUE.Click += new System.EventHandler(this.toolMenuItemExportToUE_Click);
            // 
            // toolMenuItemExportTo1C
            // 
            this.toolMenuItemExportTo1C.Name = "toolMenuItemExportTo1C";
            this.toolMenuItemExportTo1C.Size = new System.Drawing.Size(247, 22);
            this.toolMenuItemExportTo1C.Text = "Выгрузка для 1С бухгалтерии";
            this.toolMenuItemExportTo1C.Visible = false;
            this.toolMenuItemExportTo1C.Click += new System.EventHandler(this.toolMenuItemExportTo1C_Click);
            // 
            // toolMenuItemExportToMRSK
            // 
            this.toolMenuItemExportToMRSK.Name = "toolMenuItemExportToMRSK";
            this.toolMenuItemExportToMRSK.Size = new System.Drawing.Size(247, 22);
            this.toolMenuItemExportToMRSK.Text = "Выгрузка для МРСК";
            this.toolMenuItemExportToMRSK.Click += new System.EventHandler(this.toolMenuItemExportToMRSK_Click);
            // 
            // toolMenuItemCheckLegal
            // 
            this.toolMenuItemCheckLegal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemCheckInvoice,
            this.toolMenuItemCheckDocAndInvoice});
            this.toolMenuItemCheckLegal.Name = "toolMenuItemCheckLegal";
            this.toolMenuItemCheckLegal.Size = new System.Drawing.Size(204, 22);
            this.toolMenuItemCheckLegal.Text = "Проверки";
            // 
            // toolMenuItemCheckInvoice
            // 
            this.toolMenuItemCheckInvoice.Name = "toolMenuItemCheckInvoice";
            this.toolMenuItemCheckInvoice.Size = new System.Drawing.Size(266, 22);
            this.toolMenuItemCheckInvoice.Text = "Проверки на наличие счет-фактур";
            this.toolMenuItemCheckInvoice.Click += new System.EventHandler(this.toolMenuItemCheckInvoice_Click);
            // 
            // toolMenuItemCheckDocAndInvoice
            // 
            this.toolMenuItemCheckDocAndInvoice.Name = "toolMenuItemCheckDocAndInvoice";
            this.toolMenuItemCheckDocAndInvoice.Size = new System.Drawing.Size(266, 22);
            this.toolMenuItemCheckDocAndInvoice.Text = "Сверка данных документа и счета";
            this.toolMenuItemCheckDocAndInvoice.Click += new System.EventHandler(this.toolMenuItemCheckDocAndInvoice_Click);
            // 
            // toolMenuItemScheme
            // 
            this.toolMenuItemScheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuitemGeneralScheme,
            this.toolStripMenuItemConnectToServer,
            this.toolStripMenuItemNormalSchema,
            this.toolStripSeparator3,
            this.toolMenuItemOPCMessageConfig,
            this.toolMenuItemLinkCellPoint,
            this.toolStripMenuItemReports,
            this.toolStripMenuItem3,
            this.tspMenuItemMap,
            this.tspTOK5});
            this.toolMenuItemScheme.Name = "toolMenuItemScheme";
            this.toolMenuItemScheme.Size = new System.Drawing.Size(53, 20);
            this.toolMenuItemScheme.Text = "Схема";
            // 
            // toolMenuitemGeneralScheme
            // 
            this.toolMenuitemGeneralScheme.Name = "toolMenuitemGeneralScheme";
            this.toolMenuitemGeneralScheme.Size = new System.Drawing.Size(270, 22);
            this.toolMenuitemGeneralScheme.Text = "Общая схема";
            this.toolMenuitemGeneralScheme.Click += new System.EventHandler(this.toolMenuitemGeneralScheme_Click);
            // 
            // toolStripMenuItemConnectToServer
            // 
            this.toolStripMenuItemConnectToServer.Name = "toolStripMenuItemConnectToServer";
            this.toolStripMenuItemConnectToServer.Size = new System.Drawing.Size(270, 22);
            this.toolStripMenuItemConnectToServer.Text = "Подключиться к серверу";
            this.toolStripMenuItemConnectToServer.Click += new System.EventHandler(this.toolStripMenuItemConnectToServer_Click);
            // 
            // toolStripMenuItemNormalSchema
            // 
            this.toolStripMenuItemNormalSchema.Name = "toolStripMenuItemNormalSchema";
            this.toolStripMenuItemNormalSchema.Size = new System.Drawing.Size(270, 22);
            this.toolStripMenuItemNormalSchema.Text = "Схема по точкам токораздела";
            this.toolStripMenuItemNormalSchema.Click += new System.EventHandler(this.toolStripMenuItemNormalSchema_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(267, 6);
            // 
            // toolMenuItemOPCMessageConfig
            // 
            this.toolMenuItemOPCMessageConfig.Name = "toolMenuItemOPCMessageConfig";
            this.toolMenuItemOPCMessageConfig.Size = new System.Drawing.Size(270, 22);
            this.toolMenuItemOPCMessageConfig.Text = "Настройки сообщений телеметрии";
            this.toolMenuItemOPCMessageConfig.Click += new System.EventHandler(this.toolMenuItemOPCMessageConfig_Click);
            // 
            // toolMenuItemLinkCellPoint
            // 
            this.toolMenuItemLinkCellPoint.Name = "toolMenuItemLinkCellPoint";
            this.toolMenuItemLinkCellPoint.Size = new System.Drawing.Size(270, 22);
            this.toolMenuItemLinkCellPoint.Text = "Привязка абонентов к схеме";
            this.toolMenuItemLinkCellPoint.Click += new System.EventHandler(this.toolMenuItemLinkCellPoint_Click);
            // 
            // toolStripMenuItemReports
            // 
            this.toolStripMenuItemReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemLogDispatcher,
            this.toolStripMenuItemPoweringReport,
            this.toolStripMenuItemMeasurementReport,
            this.toolMenuItemAbnOff,
            this.toolMenuItemLREportLinkAbn,
            this.toolStripMenuItem49,
            this.привязанныеАбонентыNToolStripMenuItem,
            this.отчетПоЗамерам2019ToolStripMenuItem});
            this.toolStripMenuItemReports.Name = "toolStripMenuItemReports";
            this.toolStripMenuItemReports.Size = new System.Drawing.Size(270, 22);
            this.toolStripMenuItemReports.Text = "Отчёты";
            // 
            // toolMenuItemLogDispatcher
            // 
            this.toolMenuItemLogDispatcher.Name = "toolMenuItemLogDispatcher";
            this.toolMenuItemLogDispatcher.Size = new System.Drawing.Size(216, 22);
            this.toolMenuItemLogDispatcher.Text = "Отчет диспетчера";
            this.toolMenuItemLogDispatcher.Click += new System.EventHandler(this.toolMenuItemLogDispatcher_Click);
            // 
            // toolStripMenuItemPoweringReport
            // 
            this.toolStripMenuItemPoweringReport.Name = "toolStripMenuItemPoweringReport";
            this.toolStripMenuItemPoweringReport.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemPoweringReport.Text = "Отчёт по запитке";
            this.toolStripMenuItemPoweringReport.Click += new System.EventHandler(this.toolStripMenuItemPoweringReport_Click);
            // 
            // toolStripMenuItemMeasurementReport
            // 
            this.toolStripMenuItemMeasurementReport.Name = "toolStripMenuItemMeasurementReport";
            this.toolStripMenuItemMeasurementReport.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemMeasurementReport.Text = "Отчёт по замерам";
            this.toolStripMenuItemMeasurementReport.Click += new System.EventHandler(this.toolStripMenuItemMeasurementReport_Click);
            // 
            // toolMenuItemAbnOff
            // 
            this.toolMenuItemAbnOff.Name = "toolMenuItemAbnOff";
            this.toolMenuItemAbnOff.Size = new System.Drawing.Size(216, 22);
            this.toolMenuItemAbnOff.Text = "Отключенные абоненты";
            this.toolMenuItemAbnOff.Click += new System.EventHandler(this.toolMenuItemAbnOff_Click);
            // 
            // toolMenuItemLREportLinkAbn
            // 
            this.toolMenuItemLREportLinkAbn.Name = "toolMenuItemLREportLinkAbn";
            this.toolMenuItemLREportLinkAbn.Size = new System.Drawing.Size(216, 22);
            this.toolMenuItemLREportLinkAbn.Text = "\"Привязанные\" абоненты";
            this.toolMenuItemLREportLinkAbn.Click += new System.EventHandler(this.toolMenuItemLREportLinkAbn_Click);
            // 
            // toolStripMenuItem49
            // 
            this.toolStripMenuItem49.Name = "toolStripMenuItem49";
            this.toolStripMenuItem49.Size = new System.Drawing.Size(213, 6);
            // 
            // привязанныеАбонентыNToolStripMenuItem
            // 
            this.привязанныеАбонентыNToolStripMenuItem.Name = "привязанныеАбонентыNToolStripMenuItem";
            this.привязанныеАбонентыNToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.привязанныеАбонентыNToolStripMenuItem.Text = "Привязанные абоненты";
            this.привязанныеАбонентыNToolStripMenuItem.Click += new System.EventHandler(this.привязанныеАбонентыNToolStripMenuItem_Click);
            // 
            // отчетПоЗамерам2019ToolStripMenuItem
            // 
            this.отчетПоЗамерам2019ToolStripMenuItem.Name = "отчетПоЗамерам2019ToolStripMenuItem";
            this.отчетПоЗамерам2019ToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.отчетПоЗамерам2019ToolStripMenuItem.Text = "Отчет по замерам";
            this.отчетПоЗамерам2019ToolStripMenuItem.Click += new System.EventHandler(this.отчетПоЗамерам2019ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(267, 6);
            // 
            // tspMenuItemMap
            // 
            this.tspMenuItemMap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem46,
            this.tspDatatoGIS});
            this.tspMenuItemMap.Name = "tspMenuItemMap";
            this.tspMenuItemMap.Size = new System.Drawing.Size(270, 22);
            this.tspMenuItemMap.Text = "Карта";
            // 
            // toolStripMenuItem46
            // 
            this.toolStripMenuItem46.Image = global::EIS.Properties.Resources.LizMAP;
            this.toolStripMenuItem46.Name = "toolStripMenuItem46";
            this.toolStripMenuItem46.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItem46.Text = "ГИС";
            this.toolStripMenuItem46.Click += new System.EventHandler(this.toolStripMenuItem46_Click);
            // 
            // tspDatatoGIS
            // 
            this.tspDatatoGIS.Name = "tspDatatoGIS";
            this.tspDatatoGIS.Size = new System.Drawing.Size(267, 22);
            this.tspDatatoGIS.Text = "Ведомость обмена данными с ГИС";
            this.tspDatatoGIS.Click += new System.EventHandler(this.toolStripMenuItem47_Click);
            // 
            // tspTOK5
            // 
            this.tspTOK5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.структураТочекИзмеренияToolStripMenuItem,
            this.реестрТочекИзмеренияToolStripMenuItem,
            this.поступлениеВСетьToolStripMenuItem,
            this.импортПолучасовокToolStripMenuItem});
            this.tspTOK5.Name = "tspTOK5";
            this.tspTOK5.Size = new System.Drawing.Size(270, 22);
            this.tspTOK5.Text = "Данные ТОК-5";
            // 
            // структураТочекИзмеренияToolStripMenuItem
            // 
            this.структураТочекИзмеренияToolStripMenuItem.Name = "структураТочекИзмеренияToolStripMenuItem";
            this.структураТочекИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.структураТочекИзмеренияToolStripMenuItem.Text = "Структура точек измерения";
            this.структураТочекИзмеренияToolStripMenuItem.Click += new System.EventHandler(this.структураТочекИзмеренияToolStripMenuItem_Click);
            // 
            // реестрТочекИзмеренияToolStripMenuItem
            // 
            this.реестрТочекИзмеренияToolStripMenuItem.Name = "реестрТочекИзмеренияToolStripMenuItem";
            this.реестрТочекИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.реестрТочекИзмеренияToolStripMenuItem.Text = "Реестр точек измерения";
            this.реестрТочекИзмеренияToolStripMenuItem.Click += new System.EventHandler(this.реестрТочекИзмеренияToolStripMenuItem_Click);
            // 
            // поступлениеВСетьToolStripMenuItem
            // 
            this.поступлениеВСетьToolStripMenuItem.Name = "поступлениеВСетьToolStripMenuItem";
            this.поступлениеВСетьToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.поступлениеВСетьToolStripMenuItem.Text = "Поступления в сеть";
            this.поступлениеВСетьToolStripMenuItem.Click += new System.EventHandler(this.поступлениеВСетьToolStripMenuItem_Click);
            // 
            // импортПолучасовокToolStripMenuItem
            // 
            this.импортПолучасовокToolStripMenuItem.Name = "импортПолучасовокToolStripMenuItem";
            this.импортПолучасовокToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.импортПолучасовокToolStripMenuItem.Text = "Импорт получасовок";
            this.импортПолучасовокToolStripMenuItem.Click += new System.EventHandler(this.импортПолучасовокToolStripMenuItem_Click);
            // 
            // toolStripMenuItemReference
            // 
            this.toolStripMenuItemReference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuClassifier,
            this.toolStripMenuItemKadrs,
            this.toolStripMenuItemMeters,
            this.toolStripMenuItem110,
            this.toolStripMenuItemMaterial,
            this.toolStripMenuItemKontragent,
            this.tsSepar8,
            this.toolStripMenuItem47});
            this.toolStripMenuItemReference.Name = "toolStripMenuItemReference";
            this.toolStripMenuItemReference.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItemReference.Text = "Справочники";
            // 
            // toolMenuClassifier
            // 
            this.toolMenuClassifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemClassifier,
            this.toolStripMenuItemKladr,
            this.toolMenuItemGroupWorker,
            this.toolStripMenuItemKladrHouse,
            this.toolStripMenuItem18});
            this.toolMenuClassifier.Name = "toolMenuClassifier";
            this.toolMenuClassifier.Size = new System.Drawing.Size(166, 22);
            this.toolMenuClassifier.Text = "Классификатор";
            // 
            // toolStripMenuItemClassifier
            // 
            this.toolStripMenuItemClassifier.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemClassifier.Image")));
            this.toolStripMenuItemClassifier.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItemClassifier.Name = "toolStripMenuItemClassifier";
            this.toolStripMenuItemClassifier.Size = new System.Drawing.Size(239, 22);
            this.toolStripMenuItemClassifier.Text = "Общий классификатор";
            this.toolStripMenuItemClassifier.Click += new System.EventHandler(this.toolStripMenuItemClassifier_Click);
            // 
            // toolStripMenuItemKladr
            // 
            this.toolStripMenuItemKladr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemKladrObj,
            this.toolStripMenuItemKladrSocr});
            this.toolStripMenuItemKladr.Name = "toolStripMenuItemKladr";
            this.toolStripMenuItemKladr.Size = new System.Drawing.Size(239, 22);
            this.toolStripMenuItemKladr.Text = "Кладр";
            // 
            // toolStripMenuItemKladrObj
            // 
            this.toolStripMenuItemKladrObj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemKladrObj.Image")));
            this.toolStripMenuItemKladrObj.Name = "toolStripMenuItemKladrObj";
            this.toolStripMenuItemKladrObj.Size = new System.Drawing.Size(213, 22);
            this.toolStripMenuItemKladrObj.Text = "Классификатор адресов";
            this.toolStripMenuItemKladrObj.Click += new System.EventHandler(this.toolStripMenuItemKladrObj_Click);
            // 
            // toolStripMenuItemKladrSocr
            // 
            this.toolStripMenuItemKladrSocr.Name = "toolStripMenuItemKladrSocr";
            this.toolStripMenuItemKladrSocr.Size = new System.Drawing.Size(213, 22);
            this.toolStripMenuItemKladrSocr.Text = "Типы адресных объектов";
            this.toolStripMenuItemKladrSocr.Click += new System.EventHandler(this.toolStripMenuItemKladrSocr_Click);
            // 
            // toolMenuItemGroupWorker
            // 
            this.toolMenuItemGroupWorker.Name = "toolMenuItemGroupWorker";
            this.toolMenuItemGroupWorker.Size = new System.Drawing.Size(239, 22);
            this.toolMenuItemGroupWorker.Text = "Группы сотрудников";
            this.toolMenuItemGroupWorker.Click += new System.EventHandler(this.toolMenuItemGroupWorker_Click);
            // 
            // toolStripMenuItemKladrHouse
            // 
            this.toolStripMenuItemKladrHouse.Name = "toolStripMenuItemKladrHouse";
            this.toolStripMenuItemKladrHouse.Size = new System.Drawing.Size(239, 22);
            this.toolStripMenuItemKladrHouse.Text = "Справочник объектов(домов)";
            this.toolStripMenuItemKladrHouse.Click += new System.EventHandler(this.toolStripMenuItemKladrHouse_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(236, 6);
            this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStripMenuItem18_Click);
            // 
            // toolStripMenuItemKadrs
            // 
            this.toolStripMenuItemKadrs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemJobTitles,
            this.toolStripMenuItemDivisions,
            this.toolStripMenuItemWorkers});
            this.toolStripMenuItemKadrs.Name = "toolStripMenuItemKadrs";
            this.toolStripMenuItemKadrs.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemKadrs.Text = "Кадры";
            // 
            // toolStripMenuItemJobTitles
            // 
            this.toolStripMenuItemJobTitles.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemJobTitles.Image")));
            this.toolStripMenuItemJobTitles.Name = "toolStripMenuItemJobTitles";
            this.toolStripMenuItemJobTitles.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItemJobTitles.Text = "Справочник должностей";
            this.toolStripMenuItemJobTitles.Click += new System.EventHandler(this.toolStripMenuItemJobTitles_Click);
            // 
            // toolStripMenuItemDivisions
            // 
            this.toolStripMenuItemDivisions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemDivisions.Image")));
            this.toolStripMenuItemDivisions.Name = "toolStripMenuItemDivisions";
            this.toolStripMenuItemDivisions.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItemDivisions.Text = "Подразделения";
            this.toolStripMenuItemDivisions.Click += new System.EventHandler(this.toolStripMenuItemDivisions_Click);
            // 
            // toolStripMenuItemWorkers
            // 
            this.toolStripMenuItemWorkers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemWorkers.Image")));
            this.toolStripMenuItemWorkers.Name = "toolStripMenuItemWorkers";
            this.toolStripMenuItemWorkers.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItemWorkers.Text = "Сотрудники";
            this.toolStripMenuItemWorkers.Click += new System.EventHandler(this.toolStripMenuItemWorkers_Click);
            // 
            // toolStripMenuItemMeters
            // 
            this.toolStripMenuItemMeters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCounter,
            this.toolStripMenuItemTransformator,
            this.toolStripMenuItemTransf,
            this.toolMenuItemCoupling,
            this.toolMenuItemCable});
            this.toolStripMenuItemMeters.Name = "toolStripMenuItemMeters";
            this.toolStripMenuItemMeters.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemMeters.Text = "Оборудование";
            // 
            // toolStripMenuItemCounter
            // 
            this.toolStripMenuItemCounter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCounter.Image")));
            this.toolStripMenuItemCounter.Name = "toolStripMenuItemCounter";
            this.toolStripMenuItemCounter.Size = new System.Drawing.Size(263, 22);
            this.toolStripMenuItemCounter.Text = "Счетчики";
            this.toolStripMenuItemCounter.Click += new System.EventHandler(this.toolStripMenuItemCounter_Click);
            // 
            // toolStripMenuItemTransformator
            // 
            this.toolStripMenuItemTransformator.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemTransformator.Image")));
            this.toolStripMenuItemTransformator.Name = "toolStripMenuItemTransformator";
            this.toolStripMenuItemTransformator.Size = new System.Drawing.Size(263, 22);
            this.toolStripMenuItemTransformator.Text = "Трансформаторы измерительные";
            this.toolStripMenuItemTransformator.Click += new System.EventHandler(this.toolStripMenuItemTransformator_Click);
            // 
            // toolStripMenuItemTransf
            // 
            this.toolStripMenuItemTransf.Image = global::EIS.Properties.Resources.Transformator;
            this.toolStripMenuItemTransf.Name = "toolStripMenuItemTransf";
            this.toolStripMenuItemTransf.Size = new System.Drawing.Size(263, 22);
            this.toolStripMenuItemTransf.Text = "Трансформаторы силовые";
            this.toolStripMenuItemTransf.Click += new System.EventHandler(this.toolStripMenuItemTransf_Click);
            // 
            // toolMenuItemCoupling
            // 
            this.toolMenuItemCoupling.Name = "toolMenuItemCoupling";
            this.toolMenuItemCoupling.Size = new System.Drawing.Size(263, 22);
            this.toolMenuItemCoupling.Text = "Муфты";
            this.toolMenuItemCoupling.Visible = false;
            this.toolMenuItemCoupling.Click += new System.EventHandler(this.toolMenuItemCoupling_Click);
            // 
            // toolMenuItemCable
            // 
            this.toolMenuItemCable.Image = global::EIS.Properties.Resources.Cable;
            this.toolMenuItemCable.Name = "toolMenuItemCable";
            this.toolMenuItemCable.Size = new System.Drawing.Size(263, 22);
            this.toolMenuItemCable.Text = "Кабель";
            this.toolMenuItemCable.Click += new System.EventHandler(this.toolMenuItemCable_Click);
            // 
            // toolStripMenuItem110
            // 
            this.toolStripMenuItem110.Name = "toolStripMenuItem110";
            this.toolStripMenuItem110.Size = new System.Drawing.Size(163, 6);
            this.toolStripMenuItem110.Visible = false;
            // 
            // toolStripMenuItemMaterial
            // 
            this.toolStripMenuItemMaterial.Name = "toolStripMenuItemMaterial";
            this.toolStripMenuItemMaterial.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemMaterial.Text = "Материалы";
            this.toolStripMenuItemMaterial.Visible = false;
            // 
            // toolStripMenuItemKontragent
            // 
            this.toolStripMenuItemKontragent.Name = "toolStripMenuItemKontragent";
            this.toolStripMenuItemKontragent.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemKontragent.Text = "Контрагенты";
            this.toolStripMenuItemKontragent.Click += new System.EventHandler(this.toolStripMenuItemKontragent_Click);
            // 
            // tsSepar8
            // 
            this.tsSepar8.Name = "tsSepar8";
            this.tsSepar8.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItem47
            // 
            this.toolStripMenuItem47.Name = "toolStripMenuItem47";
            this.toolStripMenuItem47.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem47.Text = "Прочие реестры";
            this.toolStripMenuItem47.Click += new System.EventHandler(this.toolStripMenuItem47_Click_1);
            // 
            // tsmPassport
            // 
            this.tsmPassport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPassportPS,
            this.tsmiPassportCable,
            this.tsmiPassportAirLine,
            this.tsmiPassportTransf,
            this.toolStripSeparator51,
            this.tsmiPassportReports,
            this.tsmiPassportReport,
            this.toolStripSeparator15,
            this.tsmiPassportReferense,
            this.toolStripSeparator41,
            this.tsmiPassportSettings,
            this.tsmiImportoldTransf,
            this.toolStripSeparator91,
            this.gfcToolStripMenuItem});
            this.tsmPassport.Name = "tsmPassport";
            this.tsmPassport.Size = new System.Drawing.Size(66, 20);
            this.tsmPassport.Text = "Паспорт";
            // 
            // tsmiPassportPS
            // 
            this.tsmiPassportPS.Name = "tsmiPassportPS";
            this.tsmiPassportPS.Size = new System.Drawing.Size(298, 22);
            this.tsmiPassportPS.Text = "Подстанция";
            this.tsmiPassportPS.Click += new System.EventHandler(this.tsmiPassportPS_Click);
            // 
            // tsmiPassportCable
            // 
            this.tsmiPassportCable.Name = "tsmiPassportCable";
            this.tsmiPassportCable.Size = new System.Drawing.Size(298, 22);
            this.tsmiPassportCable.Text = "Кабельные линии";
            this.tsmiPassportCable.Click += new System.EventHandler(this.tsmiPassportCable_Click);
            // 
            // tsmiPassportAirLine
            // 
            this.tsmiPassportAirLine.Name = "tsmiPassportAirLine";
            this.tsmiPassportAirLine.Size = new System.Drawing.Size(298, 22);
            this.tsmiPassportAirLine.Text = "Воздушные линии";
            this.tsmiPassportAirLine.Click += new System.EventHandler(this.tsmiPassportAirLine_Click);
            // 
            // tsmiPassportTransf
            // 
            this.tsmiPassportTransf.Name = "tsmiPassportTransf";
            this.tsmiPassportTransf.Size = new System.Drawing.Size(298, 22);
            this.tsmiPassportTransf.Text = "Трансформатор";
            this.tsmiPassportTransf.Visible = false;
            this.tsmiPassportTransf.Click += new System.EventHandler(this.tsmiPassportTransf_Click);
            // 
            // toolStripSeparator51
            // 
            this.toolStripSeparator51.Name = "toolStripSeparator51";
            this.toolStripSeparator51.Size = new System.Drawing.Size(295, 6);
            this.toolStripSeparator51.Visible = false;
            // 
            // tsmiPassportReports
            // 
            this.tsmiPassportReports.Name = "tsmiPassportReports";
            this.tsmiPassportReports.Size = new System.Drawing.Size(298, 22);
            this.tsmiPassportReports.Text = "Журнал оборудования";
            this.tsmiPassportReports.Click += new System.EventHandler(this.tsmiPassportReports_Click);
            // 
            // tsmiPassportReport
            // 
            this.tsmiPassportReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCountSwitch,
            this.tsmiReportOffKL,
            this.tsmiCableTestingAfterRepair});
            this.tsmiPassportReport.Name = "tsmiPassportReport";
            this.tsmiPassportReport.Size = new System.Drawing.Size(298, 22);
            this.tsmiPassportReport.Text = "Отчеты";
            // 
            // tsmiCountSwitch
            // 
            this.tsmiCountSwitch.Name = "tsmiCountSwitch";
            this.tsmiCountSwitch.Size = new System.Drawing.Size(301, 22);
            this.tsmiCountSwitch.Text = "Количество выключателей в подстанции";
            // 
            // tsmiReportOffKL
            // 
            this.tsmiReportOffKL.Name = "tsmiReportOffKL";
            this.tsmiReportOffKL.Size = new System.Drawing.Size(301, 22);
            this.tsmiReportOffKL.Text = "Отключение кабельных линий";
            this.tsmiReportOffKL.Click += new System.EventHandler(this.tsmiReportOffKL_Click);
            // 
            // tsmiCableTestingAfterRepair
            // 
            this.tsmiCableTestingAfterRepair.Name = "tsmiCableTestingAfterRepair";
            this.tsmiCableTestingAfterRepair.Size = new System.Drawing.Size(301, 22);
            this.tsmiCableTestingAfterRepair.Text = "Контроль ввода в эксплуатацию КЛ";
            this.tsmiCableTestingAfterRepair.Click += new System.EventHandler(this.tsmiCableTestingAfterRepair_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(295, 6);
            // 
            // tsmiPassportReferense
            // 
            this.tsmiPassportReferense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPassportChars,
            this.tsmiPassportValueLists,
            this.tsmiPassportDoc});
            this.tsmiPassportReferense.Name = "tsmiPassportReferense";
            this.tsmiPassportReferense.Size = new System.Drawing.Size(298, 22);
            this.tsmiPassportReferense.Text = "Справочник";
            // 
            // tsmiPassportChars
            // 
            this.tsmiPassportChars.Name = "tsmiPassportChars";
            this.tsmiPassportChars.Size = new System.Drawing.Size(314, 22);
            this.tsmiPassportChars.Text = "Характеристики оборудования";
            this.tsmiPassportChars.Click += new System.EventHandler(this.tsmiPassportChars_Click);
            // 
            // tsmiPassportValueLists
            // 
            this.tsmiPassportValueLists.Name = "tsmiPassportValueLists";
            this.tsmiPassportValueLists.Size = new System.Drawing.Size(314, 22);
            this.tsmiPassportValueLists.Text = "Значения характеристик оборудования";
            this.tsmiPassportValueLists.Click += new System.EventHandler(this.tsmiPassportValueLists_Click);
            // 
            // tsmiPassportDoc
            // 
            this.tsmiPassportDoc.Name = "tsmiPassportDoc";
            this.tsmiPassportDoc.Size = new System.Drawing.Size(314, 22);
            this.tsmiPassportDoc.Text = "Список выпадающих значений документов";
            this.tsmiPassportDoc.Visible = false;
            this.tsmiPassportDoc.Click += new System.EventHandler(this.tsmiPassportDoc_Click);
            // 
            // toolStripSeparator41
            // 
            this.toolStripSeparator41.Name = "toolStripSeparator41";
            this.toolStripSeparator41.Size = new System.Drawing.Size(295, 6);
            this.toolStripSeparator41.Visible = false;
            // 
            // tsmiPassportSettings
            // 
            this.tsmiPassportSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPassportSettingsPanel});
            this.tsmiPassportSettings.Name = "tsmiPassportSettings";
            this.tsmiPassportSettings.Size = new System.Drawing.Size(298, 22);
            this.tsmiPassportSettings.Text = "Настройки";
            this.tsmiPassportSettings.Visible = false;
            // 
            // tsmiPassportSettingsPanel
            // 
            this.tsmiPassportSettingsPanel.Name = "tsmiPassportSettingsPanel";
            this.tsmiPassportSettingsPanel.Size = new System.Drawing.Size(169, 22);
            this.tsmiPassportSettingsPanel.Text = "Панель паспорта";
            this.tsmiPassportSettingsPanel.Click += new System.EventHandler(this.tsmiPassportSettingsPanel_Click);
            // 
            // tsmiImportoldTransf
            // 
            this.tsmiImportoldTransf.Name = "tsmiImportoldTransf";
            this.tsmiImportoldTransf.Size = new System.Drawing.Size(298, 22);
            this.tsmiImportoldTransf.Text = "Непрогруженные тр-ры";
            this.tsmiImportoldTransf.Click += new System.EventHandler(this.tsmiImportoldTransf_Click);
            // 
            // toolStripSeparator91
            // 
            this.toolStripSeparator91.Name = "toolStripSeparator91";
            this.toolStripSeparator91.Size = new System.Drawing.Size(295, 6);
            // 
            // gfcToolStripMenuItem
            // 
            this.gfcToolStripMenuItem.Name = "gfcToolStripMenuItem";
            this.gfcToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.gfcToolStripMenuItem.Text = "Паспорт электросетевого оборудования";
            this.gfcToolStripMenuItem.Click += new System.EventHandler(this.gfcToolStripMenuItem_Click);
            // 
            // toolStripMenuItemDocument
            // 
            this.toolStripMenuItemDocument.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUnloadingGRP,
            this.toolStripSeparatorBulletens,
            this.toolMenuItemJournals,
            this.toolStripMenuTechConnection,
            this.toolStripMenuItem21,
            this.toolStripMenuItemCalcLoss,
            this.toolStripMenuItemFileExplorer,
            this.tsmiDocTamplates,
            this.toolStripSeparator101,
            this.toolMenuItemMergeAbnMoveAbnObj,
            this.toolMenuItemJournalDistributionConsumers,
            this.toolMenuItemJournalTCRebinding,
            this.toolStripSeparator121,
            this.toolMenuItemDailyReport,
            this.toolStripMenuItem22,
            this.toolStripMenuItem29});
            this.toolStripMenuItemDocument.Name = "toolStripMenuItemDocument";
            this.toolStripMenuItemDocument.Size = new System.Drawing.Size(82, 20);
            this.toolStripMenuItemDocument.Text = "Документы";
            // 
            // toolStripMenuItemUnloadingGRP
            // 
            this.toolStripMenuItemUnloadingGRP.Image = global::EIS.Properties.Resources.WorkersGo;
            this.toolStripMenuItemUnloadingGRP.Name = "toolStripMenuItemUnloadingGRP";
            this.toolStripMenuItemUnloadingGRP.Size = new System.Drawing.Size(396, 22);
            this.toolStripMenuItemUnloadingGRP.Text = "Выгрузка группы по работе с потребителями";
            this.toolStripMenuItemUnloadingGRP.Visible = false;
            this.toolStripMenuItemUnloadingGRP.Click += new System.EventHandler(this.toolStripMenuItemUnloadingGRP_Click);
            // 
            // toolStripSeparatorBulletens
            // 
            this.toolStripSeparatorBulletens.Name = "toolStripSeparatorBulletens";
            this.toolStripSeparatorBulletens.Size = new System.Drawing.Size(393, 6);
            this.toolStripSeparatorBulletens.Visible = false;
            // 
            // toolMenuItemJournals
            // 
            this.toolMenuItemJournals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemJRequest,
            this.toolMenuItemJOrder,
            this.toolMenuItemJRequestForRepair,
            this.toolStripMenuItem31,
            this.toolMenuItemJRequestForRepairCrash,
            this.toolStripMenuItemConnectDisconnect,
            this.toolStripMenuItemReportODS,
            this.toolMenuItemJRelayProtectionAutomation,
            this.toolMenuItemJExcavation,
            this.toolMenuItemJTechnologicalFailures,
            this.toolStripMenuItemJDefect,
            this.tsmiMeasurement,
            this.tsmiMemorandums,
            this.toolStripMenuItem30});
            this.toolMenuItemJournals.Name = "toolMenuItemJournals";
            this.toolMenuItemJournals.Size = new System.Drawing.Size(396, 22);
            this.toolMenuItemJournals.Text = "Журналы";
            // 
            // toolMenuItemJRequest
            // 
            this.toolMenuItemJRequest.Image = global::EIS.Properties.Resources.stock_task;
            this.toolMenuItemJRequest.Name = "toolMenuItemJRequest";
            this.toolMenuItemJRequest.Size = new System.Drawing.Size(415, 22);
            this.toolMenuItemJRequest.Text = "Журнал задач";
            this.toolMenuItemJRequest.Click += new System.EventHandler(this.toolMenuItemJRequest_Click);
            // 
            // toolMenuItemJOrder
            // 
            this.toolMenuItemJOrder.Image = global::EIS.Properties.Resources.JournalOrder;
            this.toolMenuItemJOrder.Name = "toolMenuItemJOrder";
            this.toolMenuItemJOrder.Size = new System.Drawing.Size(415, 22);
            this.toolMenuItemJOrder.Text = "Наряды";
            this.toolMenuItemJOrder.Click += new System.EventHandler(this.toolMenuItemJOrder_Click);
            // 
            // toolMenuItemJRequestForRepair
            // 
            this.toolMenuItemJRequestForRepair.Image = global::EIS.Properties.Resources.repair;
            this.toolMenuItemJRequestForRepair.Name = "toolMenuItemJRequestForRepair";
            this.toolMenuItemJRequestForRepair.Size = new System.Drawing.Size(415, 22);
            this.toolMenuItemJRequestForRepair.Text = "Заявки на ремонт";
            this.toolMenuItemJRequestForRepair.Click += new System.EventHandler(this.toolMenuItemJRequestForRepair_Click);
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.Image = global::EIS.Properties.Resources.repair;
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            this.toolStripMenuItem31.Size = new System.Drawing.Size(415, 22);
            this.toolStripMenuItem31.Text = "Заявки  на ремонт (2019)";
            this.toolStripMenuItem31.Click += new System.EventHandler(this.toolStripMenuItem31_Click_1);
            // 
            // toolMenuItemJRequestForRepairCrash
            // 
            this.toolMenuItemJRequestForRepairCrash.Image = global::EIS.Properties.Resources.repair_Crash1;
            this.toolMenuItemJRequestForRepairCrash.Name = "toolMenuItemJRequestForRepairCrash";
            this.toolMenuItemJRequestForRepairCrash.Size = new System.Drawing.Size(415, 22);
            this.toolMenuItemJRequestForRepairCrash.Text = "Журнал по отключениям для службы 05";
            this.toolMenuItemJRequestForRepairCrash.Click += new System.EventHandler(this.toolMenuItemJRequestForRepairCrash_Click);
            // 
            // toolStripMenuItemConnectDisconnect
            // 
            this.toolStripMenuItemConnectDisconnect.Name = "toolStripMenuItemConnectDisconnect";
            this.toolStripMenuItemConnectDisconnect.Size = new System.Drawing.Size(415, 22);
            this.toolStripMenuItemConnectDisconnect.Text = "Заявки на ограничение/возобновление режима потребления";
            this.toolStripMenuItemConnectDisconnect.Click += new System.EventHandler(this.toolStripMenuItemConnectDisconnect_Click);
            // 
            // toolStripMenuItemReportODS
            // 
            this.toolStripMenuItemReportODS.Name = "toolStripMenuItemReportODS";
            this.toolStripMenuItemReportODS.Size = new System.Drawing.Size(415, 22);
            this.toolStripMenuItemReportODS.Text = "Отчёт ОДС по заявкам на ограничение режима потребления";
            this.toolStripMenuItemReportODS.Click += new System.EventHandler(this.toolStripMenuItemReportODS_Click);
            // 
            // toolMenuItemJRelayProtectionAutomation
            // 
            this.toolMenuItemJRelayProtectionAutomation.Image = global::EIS.Properties.Resources.RZA;
            this.toolMenuItemJRelayProtectionAutomation.Name = "toolMenuItemJRelayProtectionAutomation";
            this.toolMenuItemJRelayProtectionAutomation.Size = new System.Drawing.Size(415, 22);
            this.toolMenuItemJRelayProtectionAutomation.Text = "Уставки РЗА";
            this.toolMenuItemJRelayProtectionAutomation.Click += new System.EventHandler(this.toolMenuItemJRelayProtectionAutomation_Click);
            // 
            // toolMenuItemJExcavation
            // 
            this.toolMenuItemJExcavation.Image = global::EIS.Properties.Resources.showel;
            this.toolMenuItemJExcavation.Name = "toolMenuItemJExcavation";
            this.toolMenuItemJExcavation.Size = new System.Drawing.Size(415, 22);
            this.toolMenuItemJExcavation.Text = "Журнал раскопок";
            this.toolMenuItemJExcavation.Click += new System.EventHandler(this.toolMenuItemJExcavation_Click);
            // 
            // toolMenuItemJTechnologicalFailures
            // 
            this.toolMenuItemJTechnologicalFailures.Name = "toolMenuItemJTechnologicalFailures";
            this.toolMenuItemJTechnologicalFailures.Size = new System.Drawing.Size(415, 22);
            this.toolMenuItemJTechnologicalFailures.Text = "Журнал технологических нарушений";
            this.toolMenuItemJTechnologicalFailures.Click += new System.EventHandler(this.toolMenuItemJTechnologicalFailures_Click);
            // 
            // toolStripMenuItemJDefect
            // 
            this.toolStripMenuItemJDefect.Name = "toolStripMenuItemJDefect";
            this.toolStripMenuItemJDefect.Size = new System.Drawing.Size(415, 22);
            this.toolStripMenuItemJDefect.Text = "Журнал дефектов и неполадок";
            this.toolStripMenuItemJDefect.Click += new System.EventHandler(this.toolStripMenuItemJDefect_Click);
            // 
            // tsmiMeasurement
            // 
            this.tsmiMeasurement.Image = global::EIS.Properties.Resources.measurement;
            this.tsmiMeasurement.Name = "tsmiMeasurement";
            this.tsmiMeasurement.Size = new System.Drawing.Size(415, 22);
            this.tsmiMeasurement.Text = "Журнал замеров";
            this.tsmiMeasurement.Click += new System.EventHandler(this.tsmiMeasurement_Click);
            // 
            // tsmiMemorandums
            // 
            this.tsmiMemorandums.Name = "tsmiMemorandums";
            this.tsmiMemorandums.Size = new System.Drawing.Size(415, 22);
            this.tsmiMemorandums.Text = "Разрешения на тех. присоединение";
            this.tsmiMemorandums.Click += new System.EventHandler(this.tsmiMemorandums_Click);
            // 
            // toolStripMenuItem30
            // 
            this.toolStripMenuItem30.Image = global::EIS.Properties.Resources.measurement;
            this.toolStripMenuItem30.Name = "toolStripMenuItem30";
            this.toolStripMenuItem30.Size = new System.Drawing.Size(415, 22);
            this.toolStripMenuItem30.Text = "Замеры (2019)";
            this.toolStripMenuItem30.Click += new System.EventHandler(this.toolStripMenuItem30_Click);
            // 
            // toolStripMenuTechConnection
            // 
            this.toolStripMenuTechConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuTechConnectionRequest,
            this.toolStripMenuTechConnectionTU,
            this.toolStripMenuTechConnectionMailTU,
            this.договораНаТПToolStripMenuItem,
            this.toolStripSeparator71,
            this.toolStripMenuActsElectricalInspection,
            this.toolStripMenuItemActsPerformingTU,
            this.toolStripMenuTechConnectionTC,
            this.toolStripMenuTechConnectionActRBP,
            this.toolStripMenuTechConnectionActRBPNew});
            this.toolStripMenuTechConnection.Name = "toolStripMenuTechConnection";
            this.toolStripMenuTechConnection.Size = new System.Drawing.Size(396, 22);
            this.toolStripMenuTechConnection.Text = "Тех. присоединение";
            // 
            // toolStripMenuTechConnectionRequest
            // 
            this.toolStripMenuTechConnectionRequest.Image = global::EIS.Properties.Resources.network_connection_manager;
            this.toolStripMenuTechConnectionRequest.Name = "toolStripMenuTechConnectionRequest";
            this.toolStripMenuTechConnectionRequest.Size = new System.Drawing.Size(387, 22);
            this.toolStripMenuTechConnectionRequest.Text = "Заявки";
            this.toolStripMenuTechConnectionRequest.Click += new System.EventHandler(this.toolStripMenuTechConnectionRequest_Click);
            // 
            // toolStripMenuTechConnectionTU
            // 
            this.toolStripMenuTechConnectionTU.Image = global::EIS.Properties.Resources.Terms_rev;
            this.toolStripMenuTechConnectionTU.Name = "toolStripMenuTechConnectionTU";
            this.toolStripMenuTechConnectionTU.Size = new System.Drawing.Size(387, 22);
            this.toolStripMenuTechConnectionTU.Text = "Технические условия";
            this.toolStripMenuTechConnectionTU.Click += new System.EventHandler(this.toolStripMenuTechConnectionTU_Click);
            // 
            // toolStripMenuTechConnectionMailTU
            // 
            this.toolStripMenuTechConnectionMailTU.Image = global::EIS.Properties.Resources.mail;
            this.toolStripMenuTechConnectionMailTU.Name = "toolStripMenuTechConnectionMailTU";
            this.toolStripMenuTechConnectionMailTU.Size = new System.Drawing.Size(387, 22);
            this.toolStripMenuTechConnectionMailTU.Text = "Письма";
            this.toolStripMenuTechConnectionMailTU.Click += new System.EventHandler(this.toolStripMenuTechConnectionMailTU_Click);
            // 
            // договораНаТПToolStripMenuItem
            // 
            this.договораНаТПToolStripMenuItem.Image = global::EIS.Properties.Resources.Disconnect;
            this.договораНаТПToolStripMenuItem.Name = "договораНаТПToolStripMenuItem";
            this.договораНаТПToolStripMenuItem.Size = new System.Drawing.Size(387, 22);
            this.договораНаТПToolStripMenuItem.Text = "Договора на ТП";
            this.договораНаТПToolStripMenuItem.Click += new System.EventHandler(this.договораНаТПToolStripMenuItem_Click);
            // 
            // toolStripSeparator71
            // 
            this.toolStripSeparator71.Name = "toolStripSeparator71";
            this.toolStripSeparator71.Size = new System.Drawing.Size(384, 6);
            // 
            // toolStripMenuActsElectricalInspection
            // 
            this.toolStripMenuActsElectricalInspection.Name = "toolStripMenuActsElectricalInspection";
            this.toolStripMenuActsElectricalInspection.Size = new System.Drawing.Size(387, 22);
            this.toolStripMenuActsElectricalInspection.Text = "Акты осмотра электроустановок";
            this.toolStripMenuActsElectricalInspection.Click += new System.EventHandler(this.toolStripMenuActsElectricalInspection_Click);
            // 
            // toolStripMenuItemActsPerformingTU
            // 
            this.toolStripMenuItemActsPerformingTU.Name = "toolStripMenuItemActsPerformingTU";
            this.toolStripMenuItemActsPerformingTU.Size = new System.Drawing.Size(387, 22);
            this.toolStripMenuItemActsPerformingTU.Text = "Акты выполнения технических условий";
            this.toolStripMenuItemActsPerformingTU.Click += new System.EventHandler(this.toolStripMenuItemActsPerformingTU_Click);
            // 
            // toolStripMenuTechConnectionTC
            // 
            this.toolStripMenuTechConnectionTC.Name = "toolStripMenuTechConnectionTC";
            this.toolStripMenuTechConnectionTC.Size = new System.Drawing.Size(387, 22);
            this.toolStripMenuTechConnectionTC.Text = "Акты о технологическом присоединении";
            this.toolStripMenuTechConnectionTC.Click += new System.EventHandler(this.toolStripMenuTechConnectionTC_Click);
            // 
            // toolStripMenuTechConnectionActRBP
            // 
            this.toolStripMenuTechConnectionActRBP.Name = "toolStripMenuTechConnectionActRBP";
            this.toolStripMenuTechConnectionActRBP.Size = new System.Drawing.Size(387, 22);
            this.toolStripMenuTechConnectionActRBP.Text = "Акты разграничения балансовой принадлежности";
            this.toolStripMenuTechConnectionActRBP.Click += new System.EventHandler(this.toolStripMenuTechConnectionActRBP_Click);
            // 
            // toolStripMenuTechConnectionActRBPNew
            // 
            this.toolStripMenuTechConnectionActRBPNew.Name = "toolStripMenuTechConnectionActRBPNew";
            this.toolStripMenuTechConnectionActRBPNew.Size = new System.Drawing.Size(387, 22);
            this.toolStripMenuTechConnectionActRBPNew.Text = "Акты разграничения балансовой принадлежности (new)";
            this.toolStripMenuTechConnectionActRBPNew.Click += new System.EventHandler(this.toolStripMenuTechConnectionActRBPNew_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(393, 6);
            this.toolStripMenuItem21.Visible = false;
            // 
            // toolStripMenuItemCalcLoss
            // 
            this.toolStripMenuItemCalcLoss.Image = global::EIS.Properties.Resources.chart_area_down_blue;
            this.toolStripMenuItemCalcLoss.Name = "toolStripMenuItemCalcLoss";
            this.toolStripMenuItemCalcLoss.Size = new System.Drawing.Size(396, 22);
            this.toolStripMenuItemCalcLoss.Text = "Расчет потерь электрической энергии";
            this.toolStripMenuItemCalcLoss.Click += new System.EventHandler(this.toolStripMenuItemCalcLoss_Click);
            // 
            // toolStripMenuItemFileExplorer
            // 
            this.toolStripMenuItemFileExplorer.Image = global::EIS.Properties.Resources.FolderDocumentYellow;
            this.toolStripMenuItemFileExplorer.Name = "toolStripMenuItemFileExplorer";
            this.toolStripMenuItemFileExplorer.Size = new System.Drawing.Size(396, 22);
            this.toolStripMenuItemFileExplorer.Text = "Файлы";
            this.toolStripMenuItemFileExplorer.Visible = false;
            this.toolStripMenuItemFileExplorer.Click += new System.EventHandler(this.toolStripMenuItemFileExplorer_Click);
            // 
            // tsmiDocTamplates
            // 
            this.tsmiDocTamplates.Image = global::EIS.Properties.Resources.template;
            this.tsmiDocTamplates.Name = "tsmiDocTamplates";
            this.tsmiDocTamplates.Size = new System.Drawing.Size(396, 22);
            this.tsmiDocTamplates.Text = "Шаблоны";
            this.tsmiDocTamplates.Click += new System.EventHandler(this.tsmiDocTamplates_Click);
            // 
            // toolStripSeparator101
            // 
            this.toolStripSeparator101.Name = "toolStripSeparator101";
            this.toolStripSeparator101.Size = new System.Drawing.Size(393, 6);
            // 
            // toolMenuItemMergeAbnMoveAbnObj
            // 
            this.toolMenuItemMergeAbnMoveAbnObj.Name = "toolMenuItemMergeAbnMoveAbnObj";
            this.toolMenuItemMergeAbnMoveAbnObj.Size = new System.Drawing.Size(396, 22);
            this.toolMenuItemMergeAbnMoveAbnObj.Text = "Сервис объединения(перемещения) абонентов(объектов)";
            this.toolMenuItemMergeAbnMoveAbnObj.Click += new System.EventHandler(this.toolMenuItemMergeAbnMoveAbnObj_Click);
            // 
            // toolMenuItemJournalDistributionConsumers
            // 
            this.toolMenuItemJournalDistributionConsumers.Name = "toolMenuItemJournalDistributionConsumers";
            this.toolMenuItemJournalDistributionConsumers.Size = new System.Drawing.Size(396, 22);
            this.toolMenuItemJournalDistributionConsumers.Text = "Журнал распределения контрагентов";
            this.toolMenuItemJournalDistributionConsumers.Click += new System.EventHandler(this.toolMenuItemJournalDistributionConsumers_Click);
            // 
            // toolMenuItemJournalTCRebinding
            // 
            this.toolMenuItemJournalTCRebinding.Name = "toolMenuItemJournalTCRebinding";
            this.toolMenuItemJournalTCRebinding.Size = new System.Drawing.Size(396, 22);
            this.toolMenuItemJournalTCRebinding.Text = "Журнал перепривязок";
            this.toolMenuItemJournalTCRebinding.Click += new System.EventHandler(this.toolMenuItemJournalTCRebinding_Click);
            // 
            // toolStripSeparator121
            // 
            this.toolStripSeparator121.Name = "toolStripSeparator121";
            this.toolStripSeparator121.Size = new System.Drawing.Size(393, 6);
            // 
            // toolMenuItemDailyReport
            // 
            this.toolMenuItemDailyReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemJournalDamage,
            this.toolMenuItemJournalActDefection,
            this.toolMenuItemTemperature});
            this.toolMenuItemDailyReport.Name = "toolMenuItemDailyReport";
            this.toolMenuItemDailyReport.Size = new System.Drawing.Size(396, 22);
            this.toolMenuItemDailyReport.Text = "Учет аварийных событий и дефектов";
            // 
            // toolMenuItemJournalDamage
            // 
            this.toolMenuItemJournalDamage.Name = "toolMenuItemJournalDamage";
            this.toolMenuItemJournalDamage.Size = new System.Drawing.Size(281, 22);
            this.toolMenuItemJournalDamage.Text = "Журнал технологических нарушений";
            this.toolMenuItemJournalDamage.Click += new System.EventHandler(this.toolMenuItemJournalDamage_Click);
            // 
            // toolMenuItemJournalActDefection
            // 
            this.toolMenuItemJournalActDefection.Name = "toolMenuItemJournalActDefection";
            this.toolMenuItemJournalActDefection.Size = new System.Drawing.Size(281, 22);
            this.toolMenuItemJournalActDefection.Text = "Журнал актов расследования";
            this.toolMenuItemJournalActDefection.Click += new System.EventHandler(this.toolMenuItemJournalActDefection_Click);
            // 
            // toolMenuItemTemperature
            // 
            this.toolMenuItemTemperature.Image = global::EIS.Properties.Resources.weather;
            this.toolMenuItemTemperature.Name = "toolMenuItemTemperature";
            this.toolMenuItemTemperature.Size = new System.Drawing.Size(281, 22);
            this.toolMenuItemTemperature.Text = "Реестр температур";
            this.toolMenuItemTemperature.Click += new System.EventHandler(this.toolMenuItemTemperature_Click);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripSeparator4,
            this.toolStripMenuItem25,
            this.toolStripSeparator5,
            this.toolStripMenuItem26,
            this.toolStripMenuItem27,
            this.toolStripMenuItem28,
            this.toolStripMenuItem40,
            this.toolStripMenuItem41});
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(396, 22);
            this.toolStripMenuItem22.Text = "Учет аварийных событий и дефектов 2019";
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(323, 22);
            this.toolStripMenuItem23.Text = "Журнал технологических нарушений";
            this.toolStripMenuItem23.Click += new System.EventHandler(this.toolStripMenuItem23_Click);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(323, 22);
            this.toolStripMenuItem24.Text = "Журнал актов расследования";
            this.toolStripMenuItem24.Click += new System.EventHandler(this.toolStripMenuItem24_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(320, 6);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Image = global::EIS.Properties.Resources.weather;
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(323, 22);
            this.toolStripMenuItem25.Text = "Реестр температур";
            this.toolStripMenuItem25.Click += new System.EventHandler(this.toolStripMenuItem25_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(320, 6);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(323, 22);
            this.toolStripMenuItem26.Text = "Общий журнал технологических нарушений";
            this.toolStripMenuItem26.Click += new System.EventHandler(this.toolStripMenuItem26_Click);
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(323, 22);
            this.toolStripMenuItem27.Text = "Журнал нарушений";
            this.toolStripMenuItem27.Click += new System.EventHandler(this.toolStripMenuItem27_Click);
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(323, 22);
            this.toolStripMenuItem28.Text = "Журнал дефектов";
            this.toolStripMenuItem28.Click += new System.EventHandler(this.toolStripMenuItem28_Click);
            // 
            // toolStripMenuItem40
            // 
            this.toolStripMenuItem40.Name = "toolStripMenuItem40";
            this.toolStripMenuItem40.Size = new System.Drawing.Size(320, 6);
            // 
            // toolStripMenuItem41
            // 
            this.toolStripMenuItem41.Name = "toolStripMenuItem41";
            this.toolStripMenuItem41.Size = new System.Drawing.Size(323, 22);
            this.toolStripMenuItem41.Text = "Ведомость корректировки";
            this.toolStripMenuItem41.Click += new System.EventHandler(this.toolStripMenuItem41_Click);
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            this.toolStripMenuItem29.Size = new System.Drawing.Size(393, 6);
            // 
            // toolStripMenuItemServices
            // 
            this.toolStripMenuItemServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUsers,
            this.toolStripMenuItemSecurity,
            this.tsmiBossUsers,
            this.toolStripSeparator111,
            this.toolStripMenuItemLogInOut,
            this.toolMenuItemJournalLog,
            this.tspMenuItemSchedulers});
            this.toolStripMenuItemServices.Name = "toolStripMenuItemServices";
            this.toolStripMenuItemServices.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItemServices.Text = "Сервис";
            // 
            // toolStripMenuItemUsers
            // 
            this.toolStripMenuItemUsers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemUsers.Image")));
            this.toolStripMenuItemUsers.Name = "toolStripMenuItemUsers";
            this.toolStripMenuItemUsers.Size = new System.Drawing.Size(247, 22);
            this.toolStripMenuItemUsers.Text = "Пользователи";
            this.toolStripMenuItemUsers.Click += new System.EventHandler(this.toolStripMenuItemUsers_Click);
            // 
            // toolStripMenuItemSecurity
            // 
            this.toolStripMenuItemSecurity.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemSecurity.Image")));
            this.toolStripMenuItemSecurity.Name = "toolStripMenuItemSecurity";
            this.toolStripMenuItemSecurity.Size = new System.Drawing.Size(247, 22);
            this.toolStripMenuItemSecurity.Text = "Безопасность";
            this.toolStripMenuItemSecurity.Click += new System.EventHandler(this.toolStripMenuItemSecurity_Click);
            // 
            // tsmiBossUsers
            // 
            this.tsmiBossUsers.Name = "tsmiBossUsers";
            this.tsmiBossUsers.Size = new System.Drawing.Size(247, 22);
            this.tsmiBossUsers.Text = "Пользователи \"Босс референт\"";
            this.tsmiBossUsers.Click += new System.EventHandler(this.tsmiBossUsers_Click);
            // 
            // toolStripSeparator111
            // 
            this.toolStripSeparator111.Name = "toolStripSeparator111";
            this.toolStripSeparator111.Size = new System.Drawing.Size(244, 6);
            // 
            // toolStripMenuItemLogInOut
            // 
            this.toolStripMenuItemLogInOut.Image = global::EIS.Properties.Resources.file_extension_log;
            this.toolStripMenuItemLogInOut.Name = "toolStripMenuItemLogInOut";
            this.toolStripMenuItemLogInOut.Size = new System.Drawing.Size(247, 22);
            this.toolStripMenuItemLogInOut.Text = "Журнал входа/выхода";
            this.toolStripMenuItemLogInOut.Click += new System.EventHandler(this.toolStripMenuItemLogInOut_Click);
            // 
            // toolMenuItemJournalLog
            // 
            this.toolMenuItemJournalLog.Name = "toolMenuItemJournalLog";
            this.toolMenuItemJournalLog.Size = new System.Drawing.Size(247, 22);
            this.toolMenuItemJournalLog.Text = "Журнал логирования";
            this.toolMenuItemJournalLog.Click += new System.EventHandler(this.toolMenuItemJournalLog_CLick);
            // 
            // tspMenuItemSchedulers
            // 
            this.tspMenuItemSchedulers.Name = "tspMenuItemSchedulers";
            this.tspMenuItemSchedulers.Size = new System.Drawing.Size(247, 22);
            this.tspMenuItemSchedulers.Text = "Планировщики";
            this.tspMenuItemSchedulers.Click += new System.EventHandler(this.toolStripMenuItemSchedulers_Click);
            // 
            // toolStripMenuItemAditionally
            // 
            this.toolStripMenuItemAditionally.Name = "toolStripMenuItemAditionally";
            this.toolStripMenuItemAditionally.Size = new System.Drawing.Size(107, 20);
            this.toolStripMenuItemAditionally.Text = "Дополнительно";
            // 
            // toolStripMenuItemWindows
            // 
            this.toolStripMenuItemWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCascade,
            this.toolStripMenuItemTileHorizontal,
            this.toolStripMenuItemTileVertical,
            this.toolStripMenuItemWindowCloseAll});
            this.toolStripMenuItemWindows.Name = "toolStripMenuItemWindows";
            this.toolStripMenuItemWindows.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItemWindows.Text = "Окна";
            this.toolStripMenuItemWindows.DropDownClosed += new System.EventHandler(this.toolStripMenuItemWindows_DropDownClosed);
            this.toolStripMenuItemWindows.DropDownOpening += new System.EventHandler(this.toolStripMenuItemWindows_DropDownOpening);
            // 
            // toolStripMenuItemCascade
            // 
            this.toolStripMenuItemCascade.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCascade.Image")));
            this.toolStripMenuItemCascade.Name = "toolStripMenuItemCascade";
            this.toolStripMenuItemCascade.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemCascade.Text = "Каскадом";
            this.toolStripMenuItemCascade.Click += new System.EventHandler(this.toolStripMenuItemCascade_Click);
            // 
            // toolStripMenuItemTileHorizontal
            // 
            this.toolStripMenuItemTileHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemTileHorizontal.Image")));
            this.toolStripMenuItemTileHorizontal.Name = "toolStripMenuItemTileHorizontal";
            this.toolStripMenuItemTileHorizontal.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemTileHorizontal.Text = "Горизонтально";
            this.toolStripMenuItemTileHorizontal.Click += new System.EventHandler(this.toolStripMenuItemTileHorizontal_Click);
            // 
            // toolStripMenuItemTileVertical
            // 
            this.toolStripMenuItemTileVertical.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemTileVertical.Image")));
            this.toolStripMenuItemTileVertical.Name = "toolStripMenuItemTileVertical";
            this.toolStripMenuItemTileVertical.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemTileVertical.Text = "Вертикально";
            this.toolStripMenuItemTileVertical.Click += new System.EventHandler(this.toolStripMenuItemTileVertical_Click);
            // 
            // toolStripMenuItemWindowCloseAll
            // 
            this.toolStripMenuItemWindowCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemWindowCloseAll.Image")));
            this.toolStripMenuItemWindowCloseAll.Name = "toolStripMenuItemWindowCloseAll";
            this.toolStripMenuItemWindowCloseAll.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemWindowCloseAll.Text = "Закрыть все окна";
            this.toolStripMenuItemWindowCloseAll.Click += new System.EventHandler(this.toolStripMenuItemWindowCloseAll_Click);
            // 
            // toolStripMenuItemRef
            // 
            this.toolStripMenuItemRef.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemUpdateProgram,
            this.toolMenuItemUpdates,
            this.toolStripMenuItemChat,
            this.toolStripMenuItemAbout,
            this.About});
            this.toolStripMenuItemRef.Name = "toolStripMenuItemRef";
            this.toolStripMenuItemRef.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItemRef.Text = "Справка";
            // 
            // toolMenuItemUpdateProgram
            // 
            this.toolMenuItemUpdateProgram.Name = "toolMenuItemUpdateProgram";
            this.toolMenuItemUpdateProgram.Size = new System.Drawing.Size(189, 22);
            this.toolMenuItemUpdateProgram.Text = "Журнал обновлений";
            this.toolMenuItemUpdateProgram.Click += new System.EventHandler(this.toolMenuItemUpdateProgram_Click);
            // 
            // toolMenuItemUpdates
            // 
            this.toolMenuItemUpdates.Name = "toolMenuItemUpdates";
            this.toolMenuItemUpdates.Size = new System.Drawing.Size(189, 22);
            this.toolMenuItemUpdates.Text = "Обновления";
            this.toolMenuItemUpdates.Click += new System.EventHandler(this.toolMenuItemUpdates_Click);
            // 
            // toolStripMenuItemChat
            // 
            this.toolStripMenuItemChat.Name = "toolStripMenuItemChat";
            this.toolStripMenuItemChat.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemChat.Text = "Чат";
            this.toolStripMenuItemChat.Click += new System.EventHandler(this.LoadChat);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(186, 6);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(189, 22);
            this.About.Text = "О программе...";
            this.About.Click += new System.EventHandler(this.AboutClick);
            // 
            // tspMenuItemJournalN
            // 
            this.tspMenuItemJournalN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.toolStripMenuItem33,
            this.tsmiMeasurementN,
            this.заявкиНаРемонтToolStripMenuItem,
            this.аварийныеОтключенияToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem17,
            this.toolStripMenuItem19,
            this.заявкиНаРемонтToolStripMenuItem1,
            this.аварийныеОтключенияToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.toolStripMenuItem8,
            this.toolStripMenuItem12,
            this.toolStripMenuItem9,
            this.toolStripMenuItem13,
            this.расчетПотерьЭлектрическойЭнергииToolStripMenuItem,
            this.toolStripMenuItem20,
            this.выгрузкаДоговоровТПToolStripMenuItem,
            this.toolStripMenuItem2,
            this.умныйГородToolStripMenuItem,
            this.тестReportView12ToolStripMenuItem,
            this.toolStripMenuItem34,
            this.toolStripMenuItem45,
            this.toolStripMenuItem48,
            this.схемаToolStripMenuItem,
            this.toolStripMenuItem51,
            this.уведомлениеОбОтключенияхToolStripMenuItem});
            this.tspMenuItemJournalN.Name = "tspMenuItemJournalN";
            this.tspMenuItemJournalN.Size = new System.Drawing.Size(72, 20);
            this.tspMenuItemJournalN.Text = "Журналы";
            this.tspMenuItemJournalN.Click += new System.EventHandler(this.tspMenuItemJournalN_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникОбъектовдомовToolStripMenuItem,
            this.toolStripMenuItem35,
            this.toolStripMenuItem39,
            this.произвольныеСправочникиToolStripMenuItem,
            this.журналАбонентовToolStripMenuItem1,
            this.тестDockContentBaseToolStripMenuItem,
            this.toolStripMenuItem43,
            this.импортКадровыхДанныхToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // справочникОбъектовдомовToolStripMenuItem
            // 
            this.справочникОбъектовдомовToolStripMenuItem.Name = "справочникОбъектовдомовToolStripMenuItem";
            this.справочникОбъектовдомовToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.справочникОбъектовдомовToolStripMenuItem.Text = "Справочник объектов(домов)";
            this.справочникОбъектовдомовToolStripMenuItem.Click += new System.EventHandler(this.справочникОбъектовдомовToolStripMenuItem_Click);
            // 
            // toolStripMenuItem35
            // 
            this.toolStripMenuItem35.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem36,
            this.toolStripMenuItem37,
            this.toolStripMenuItem38});
            this.toolStripMenuItem35.Name = "toolStripMenuItem35";
            this.toolStripMenuItem35.Size = new System.Drawing.Size(239, 22);
            this.toolStripMenuItem35.Text = "Кадры";
            // 
            // toolStripMenuItem36
            // 
            this.toolStripMenuItem36.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem36.Image")));
            this.toolStripMenuItem36.Name = "toolStripMenuItem36";
            this.toolStripMenuItem36.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItem36.Text = "Справочник должностей";
            this.toolStripMenuItem36.Click += new System.EventHandler(this.toolStripMenuItem36_Click);
            // 
            // toolStripMenuItem37
            // 
            this.toolStripMenuItem37.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem37.Image")));
            this.toolStripMenuItem37.Name = "toolStripMenuItem37";
            this.toolStripMenuItem37.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItem37.Text = "Подразделения";
            this.toolStripMenuItem37.Click += new System.EventHandler(this.toolStripMenuItem37_Click);
            // 
            // toolStripMenuItem38
            // 
            this.toolStripMenuItem38.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem38.Image")));
            this.toolStripMenuItem38.Name = "toolStripMenuItem38";
            this.toolStripMenuItem38.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItem38.Text = "Сотрудники";
            this.toolStripMenuItem38.Click += new System.EventHandler(this.toolStripMenuItem38_Click);
            // 
            // toolStripMenuItem39
            // 
            this.toolStripMenuItem39.Name = "toolStripMenuItem39";
            this.toolStripMenuItem39.Size = new System.Drawing.Size(236, 6);
            // 
            // произвольныеСправочникиToolStripMenuItem
            // 
            this.произвольныеСправочникиToolStripMenuItem.Name = "произвольныеСправочникиToolStripMenuItem";
            this.произвольныеСправочникиToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.произвольныеСправочникиToolStripMenuItem.Text = "Произвольные справочники";
            this.произвольныеСправочникиToolStripMenuItem.Click += new System.EventHandler(this.произвольныеСправочникиToolStripMenuItem_Click);
            // 
            // журналАбонентовToolStripMenuItem1
            // 
            this.журналАбонентовToolStripMenuItem1.Image = global::EIS.Properties.Resources.PatientFile;
            this.журналАбонентовToolStripMenuItem1.Name = "журналАбонентовToolStripMenuItem1";
            this.журналАбонентовToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.журналАбонентовToolStripMenuItem1.Text = "Журнал абонентов";
            this.журналАбонентовToolStripMenuItem1.Click += new System.EventHandler(this.журналАбонентовToolStripMenuItem1_Click);
            // 
            // тестDockContentBaseToolStripMenuItem
            // 
            this.тестDockContentBaseToolStripMenuItem.Name = "тестDockContentBaseToolStripMenuItem";
            this.тестDockContentBaseToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.тестDockContentBaseToolStripMenuItem.Text = "Тест DockContentBase";
            this.тестDockContentBaseToolStripMenuItem.Click += new System.EventHandler(this.тестDockContentBaseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem43
            // 
            this.toolStripMenuItem43.Name = "toolStripMenuItem43";
            this.toolStripMenuItem43.Size = new System.Drawing.Size(236, 6);
            // 
            // импортКадровыхДанныхToolStripMenuItem
            // 
            this.импортКадровыхДанныхToolStripMenuItem.Name = "импортКадровыхДанныхToolStripMenuItem";
            this.импортКадровыхДанныхToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.импортКадровыхДанныхToolStripMenuItem.Text = "Импорт Кадровых данных";
            this.импортКадровыхДанныхToolStripMenuItem.Click += new System.EventHandler(this.импортКадровыхДанныхToolStripMenuItem_Click);
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(303, 6);
            // 
            // tsmiMeasurementN
            // 
            this.tsmiMeasurementN.Image = global::EIS.Properties.Resources.measurement;
            this.tsmiMeasurementN.Name = "tsmiMeasurementN";
            this.tsmiMeasurementN.Size = new System.Drawing.Size(306, 22);
            this.tsmiMeasurementN.Text = "Замеры";
            this.tsmiMeasurementN.Click += new System.EventHandler(this.tsmiMeasurement_Click_N);
            // 
            // заявкиНаРемонтToolStripMenuItem
            // 
            this.заявкиНаРемонтToolStripMenuItem.Image = global::EIS.Properties.Resources.repair;
            this.заявкиНаРемонтToolStripMenuItem.Name = "заявкиНаРемонтToolStripMenuItem";
            this.заявкиНаРемонтToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.заявкиНаРемонтToolStripMenuItem.Text = "Заявки на ремонт";
            this.заявкиНаРемонтToolStripMenuItem.Click += new System.EventHandler(this.заявкиНаРемонтToolStripMenuItem_Click);
            // 
            // аварийныеОтключенияToolStripMenuItem
            // 
            this.аварийныеОтключенияToolStripMenuItem.Image = global::EIS.Properties.Resources.repair_Crash1;
            this.аварийныеОтключенияToolStripMenuItem.Name = "аварийныеОтключенияToolStripMenuItem";
            this.аварийныеОтключенияToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.аварийныеОтключенияToolStripMenuItem.Text = "Аварийные отключения";
            this.аварийныеОтключенияToolStripMenuItem.Click += new System.EventHandler(this.аварийныеОтключенияToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(303, 6);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(306, 22);
            this.toolStripMenuItem17.Text = "Заявки  на ремонт";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.заявкиНаРемонтToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(306, 22);
            this.toolStripMenuItem19.Text = "Аварийные отключения";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.аварийныеОтключенияToolStripMenuItem1_Click);
            // 
            // заявкиНаРемонтToolStripMenuItem1
            // 
            this.заявкиНаРемонтToolStripMenuItem1.Name = "заявкиНаРемонтToolStripMenuItem1";
            this.заявкиНаРемонтToolStripMenuItem1.Size = new System.Drawing.Size(306, 22);
            this.заявкиНаРемонтToolStripMenuItem1.Text = "Заявки  на ремонт N2";
            this.заявкиНаРемонтToolStripMenuItem1.Click += new System.EventHandler(this.заявкиНаРемонтToolStripMenuItem2_Click);
            // 
            // аварийныеОтключенияToolStripMenuItem1
            // 
            this.аварийныеОтключенияToolStripMenuItem1.Name = "аварийныеОтключенияToolStripMenuItem1";
            this.аварийныеОтключенияToolStripMenuItem1.Size = new System.Drawing.Size(306, 22);
            this.аварийныеОтключенияToolStripMenuItem1.Text = "Аварийные отключения N2";
            this.аварийныеОтключенияToolStripMenuItem1.Click += new System.EventHandler(this.аварийныеОтключенияToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(303, 6);
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(303, 6);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripSeparator1,
            this.toolStripMenuItem16,
            this.toolStripMenuItem1,
            this.общийЖурналТехнологическихНарушенийToolStripMenuItem,
            this.журналТехнологическихНарушенийToolStripMenuItem,
            this.журналДефектовToolStripMenuItem,
            this.toolStripMenuItem32,
            this.ведомостьКорректировкиToolStripMenuItem});
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(306, 22);
            this.toolStripMenuItem12.Text = "Учет аварийных событий и дефектов NEW";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(323, 22);
            this.toolStripMenuItem14.Text = "Журнал технологических нарушений";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(323, 22);
            this.toolStripMenuItem15.Text = "Журнал актов расследования";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(320, 6);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Image = global::EIS.Properties.Resources.weather;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(323, 22);
            this.toolStripMenuItem16.Text = "Реестр температур";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem16_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(320, 6);
            // 
            // общийЖурналТехнологическихНарушенийToolStripMenuItem
            // 
            this.общийЖурналТехнологическихНарушенийToolStripMenuItem.Name = "общийЖурналТехнологическихНарушенийToolStripMenuItem";
            this.общийЖурналТехнологическихНарушенийToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.общийЖурналТехнологическихНарушенийToolStripMenuItem.Text = "Общий журнал технологических нарушений";
            this.общийЖурналТехнологическихНарушенийToolStripMenuItem.Click += new System.EventHandler(this.общийЖурналТехнологическихНарушенийToolStripMenuItem_Click);
            // 
            // журналТехнологическихНарушенийToolStripMenuItem
            // 
            this.журналТехнологическихНарушенийToolStripMenuItem.Name = "журналТехнологическихНарушенийToolStripMenuItem";
            this.журналТехнологическихНарушенийToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.журналТехнологическихНарушенийToolStripMenuItem.Text = "Журнал нарушений";
            this.журналТехнологическихНарушенийToolStripMenuItem.Click += new System.EventHandler(this.журналТехнологическихНарушенийToolStripMenuItem_Click);
            // 
            // журналДефектовToolStripMenuItem
            // 
            this.журналДефектовToolStripMenuItem.Name = "журналДефектовToolStripMenuItem";
            this.журналДефектовToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.журналДефектовToolStripMenuItem.Text = "Журнал дефектов";
            this.журналДефектовToolStripMenuItem.Click += new System.EventHandler(this.журналДефектовToolStripMenuItem_Click);
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            this.toolStripMenuItem32.Size = new System.Drawing.Size(320, 6);
            // 
            // ведомостьКорректировкиToolStripMenuItem
            // 
            this.ведомостьКорректировкиToolStripMenuItem.Name = "ведомостьКорректировкиToolStripMenuItem";
            this.ведомостьКорректировкиToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.ведомостьКорректировкиToolStripMenuItem.Text = "Ведомость корректировки";
            this.ведомостьКорректировкиToolStripMenuItem.Click += new System.EventHandler(this.ведомостьКорректировкиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFormJournalDamage,
            this.toolStripMenuItemFormJournalActDetection,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(306, 22);
            this.toolStripMenuItem9.Text = "Учет аварийных событий и дефектов OLD";
            // 
            // toolStripMenuItemFormJournalDamage
            // 
            this.toolStripMenuItemFormJournalDamage.Name = "toolStripMenuItemFormJournalDamage";
            this.toolStripMenuItemFormJournalDamage.Size = new System.Drawing.Size(281, 22);
            this.toolStripMenuItemFormJournalDamage.Text = "Журнал технологических нарушений";
            this.toolStripMenuItemFormJournalDamage.Click += new System.EventHandler(this.toolStripMenuItemFormJournalDamage_Click);
            // 
            // toolStripMenuItemFormJournalActDetection
            // 
            this.toolStripMenuItemFormJournalActDetection.Name = "toolStripMenuItemFormJournalActDetection";
            this.toolStripMenuItemFormJournalActDetection.Size = new System.Drawing.Size(281, 22);
            this.toolStripMenuItemFormJournalActDetection.Text = "Журнал актов расследования";
            this.toolStripMenuItemFormJournalActDetection.Click += new System.EventHandler(this.toolStripMenuItemFormJournalActDetection_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(278, 6);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Image = global::EIS.Properties.Resources.weather;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(281, 22);
            this.toolStripMenuItem11.Text = "Реестр температур";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(303, 6);
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // расчетПотерьЭлектрическойЭнергииToolStripMenuItem
            // 
            this.расчетПотерьЭлектрическойЭнергииToolStripMenuItem.Image = global::EIS.Properties.Resources.chart_area_down_blue;
            this.расчетПотерьЭлектрическойЭнергииToolStripMenuItem.Name = "расчетПотерьЭлектрическойЭнергииToolStripMenuItem";
            this.расчетПотерьЭлектрическойЭнергииToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.расчетПотерьЭлектрическойЭнергииToolStripMenuItem.Text = "Расчет потерь электрической энергии";
            this.расчетПотерьЭлектрическойЭнергииToolStripMenuItem.Click += new System.EventHandler(this.расчетПотерьЭлектрическойЭнергииToolStripMenuItem_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(303, 6);
            // 
            // выгрузкаДоговоровТПToolStripMenuItem
            // 
            this.выгрузкаДоговоровТПToolStripMenuItem.Name = "выгрузкаДоговоровТПToolStripMenuItem";
            this.выгрузкаДоговоровТПToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.выгрузкаДоговоровТПToolStripMenuItem.Text = "Выгрузка договоров ТП";
            this.выгрузкаДоговоровТПToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаДоговоровТПToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(303, 6);
            // 
            // умныйГородToolStripMenuItem
            // 
            this.умныйГородToolStripMenuItem.Name = "умныйГородToolStripMenuItem";
            this.умныйГородToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.умныйГородToolStripMenuItem.Text = "Умный город";
            this.умныйГородToolStripMenuItem.Click += new System.EventHandler(this.умныйГородToolStripMenuItem_Click);
            // 
            // тестReportView12ToolStripMenuItem
            // 
            this.тестReportView12ToolStripMenuItem.Name = "тестReportView12ToolStripMenuItem";
            this.тестReportView12ToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.тестReportView12ToolStripMenuItem.Text = "Тест ReportView12";
            this.тестReportView12ToolStripMenuItem.Click += new System.EventHandler(this.тестReportView12ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            this.toolStripMenuItem34.Size = new System.Drawing.Size(303, 6);
            this.toolStripMenuItem34.Click += new System.EventHandler(this.toolStripMenuItem34_Click);
            // 
            // toolStripMenuItem45
            // 
            this.toolStripMenuItem45.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гИСToolStripMenuItem,
            this.ведомостьОбменаДаннымиСГИСToolStripMenuItem,
            this.toolStripMenuItem50,
            this.загрузкаНарядовНаРаботуToolStripMenuItem});
            this.toolStripMenuItem45.Name = "toolStripMenuItem45";
            this.toolStripMenuItem45.Size = new System.Drawing.Size(306, 22);
            this.toolStripMenuItem45.Text = "Карта";
            // 
            // гИСToolStripMenuItem
            // 
            this.гИСToolStripMenuItem.Image = global::EIS.Properties.Resources.LizMAP;
            this.гИСToolStripMenuItem.Name = "гИСToolStripMenuItem";
            this.гИСToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.гИСToolStripMenuItem.Text = "ГИС";
            this.гИСToolStripMenuItem.Click += new System.EventHandler(this.гИСToolStripMenuItem_Click_1);
            // 
            // ведомостьОбменаДаннымиСГИСToolStripMenuItem
            // 
            this.ведомостьОбменаДаннымиСГИСToolStripMenuItem.Name = "ведомостьОбменаДаннымиСГИСToolStripMenuItem";
            this.ведомостьОбменаДаннымиСГИСToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.ведомостьОбменаДаннымиСГИСToolStripMenuItem.Text = "Ведомость обмена данными с ГИС";
            this.ведомостьОбменаДаннымиСГИСToolStripMenuItem.Click += new System.EventHandler(this.ведомостьОбменаДаннымиСГИСToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem50
            // 
            this.toolStripMenuItem50.Name = "toolStripMenuItem50";
            this.toolStripMenuItem50.Size = new System.Drawing.Size(264, 6);
            // 
            // загрузкаНарядовНаРаботуToolStripMenuItem
            // 
            this.загрузкаНарядовНаРаботуToolStripMenuItem.Name = "загрузкаНарядовНаРаботуToolStripMenuItem";
            this.загрузкаНарядовНаРаботуToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.загрузкаНарядовНаРаботуToolStripMenuItem.Text = "Загрузка нарядов на работу";
            this.загрузкаНарядовНаРаботуToolStripMenuItem.Click += new System.EventHandler(this.загрузкаНарядовНаРаботуToolStripMenuItem_Click);
            // 
            // toolStripMenuItem48
            // 
            this.toolStripMenuItem48.Name = "toolStripMenuItem48";
            this.toolStripMenuItem48.Size = new System.Drawing.Size(303, 6);
            // 
            // схемаToolStripMenuItem
            // 
            this.схемаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётПоЗамерамToolStripMenuItem,
            this.деревоОбъектовСхемыToolStripMenuItem,
            this.тестЗагрузкиМоделиСхемыToolStripMenuItem});
            this.схемаToolStripMenuItem.Name = "схемаToolStripMenuItem";
            this.схемаToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.схемаToolStripMenuItem.Text = "Схема";
            // 
            // отчётПоЗамерамToolStripMenuItem
            // 
            this.отчётПоЗамерамToolStripMenuItem.Name = "отчётПоЗамерамToolStripMenuItem";
            this.отчётПоЗамерамToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.отчётПоЗамерамToolStripMenuItem.Text = "Отчёт по замерам";
            this.отчётПоЗамерамToolStripMenuItem.Click += new System.EventHandler(this.отчётПоЗамерамToolStripMenuItem_Click);
            // 
            // деревоОбъектовСхемыToolStripMenuItem
            // 
            this.деревоОбъектовСхемыToolStripMenuItem.Name = "деревоОбъектовСхемыToolStripMenuItem";
            this.деревоОбъектовСхемыToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.деревоОбъектовСхемыToolStripMenuItem.Text = "Дерево объектов схемы";
            this.деревоОбъектовСхемыToolStripMenuItem.Click += new System.EventHandler(this.деревоОбъектовСхемыToolStripMenuItem_Click);
            // 
            // тестЗагрузкиМоделиСхемыToolStripMenuItem
            // 
            this.тестЗагрузкиМоделиСхемыToolStripMenuItem.Name = "тестЗагрузкиМоделиСхемыToolStripMenuItem";
            this.тестЗагрузкиМоделиСхемыToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.тестЗагрузкиМоделиСхемыToolStripMenuItem.Text = "Тест загрузки модели схемы";
            this.тестЗагрузкиМоделиСхемыToolStripMenuItem.Click += new System.EventHandler(this.тестЗагрузкиМоделиСхемыToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem51
            // 
            this.toolStripMenuItem51.Name = "toolStripMenuItem51";
            this.toolStripMenuItem51.Size = new System.Drawing.Size(303, 6);
            // 
            // уведомлениеОбОтключенияхToolStripMenuItem
            // 
            this.уведомлениеОбОтключенияхToolStripMenuItem.Image = global::EIS.Properties.Resources.work_are_required_manager;
            this.уведомлениеОбОтключенияхToolStripMenuItem.Name = "уведомлениеОбОтключенияхToolStripMenuItem";
            this.уведомлениеОбОтключенияхToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.уведомлениеОбОтключенияхToolStripMenuItem.Text = "Уведомление об отключениях";
            this.уведомлениеОбОтключенияхToolStripMenuItem.Click += new System.EventHandler(this.уведомлениеОбОтключенияхToolStripMenuItem_Click);
            // 
            // contextMenuWindow
            // 
            this.contextMenuWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemWindowsRestore,
            this.toolStripMenuItemWindowsMinimize,
            this.toolStripMenuItemWindowMaximaze,
            this.toolStripSeparatorWindow,
            this.toolStripMenuItemWindowsClose});
            this.contextMenuWindow.Name = "contextMenuWindow";
            this.contextMenuWindow.Size = new System.Drawing.Size(150, 98);
            // 
            // toolStripMenuItemWindowsRestore
            // 
            this.toolStripMenuItemWindowsRestore.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemWindowsRestore.Image")));
            this.toolStripMenuItemWindowsRestore.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemWindowsRestore.Name = "toolStripMenuItemWindowsRestore";
            this.toolStripMenuItemWindowsRestore.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemWindowsRestore.Text = "Восстановить";
            this.toolStripMenuItemWindowsRestore.Click += new System.EventHandler(this.toolStripMenuItemWindowsRestore_Click);
            // 
            // toolStripMenuItemWindowsMinimize
            // 
            this.toolStripMenuItemWindowsMinimize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemWindowsMinimize.Image")));
            this.toolStripMenuItemWindowsMinimize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemWindowsMinimize.Name = "toolStripMenuItemWindowsMinimize";
            this.toolStripMenuItemWindowsMinimize.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemWindowsMinimize.Text = "Свернуть";
            this.toolStripMenuItemWindowsMinimize.Click += new System.EventHandler(this.toolStripMenuItemWindowsMinimize_Click);
            // 
            // toolStripMenuItemWindowMaximaze
            // 
            this.toolStripMenuItemWindowMaximaze.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemWindowMaximaze.Image")));
            this.toolStripMenuItemWindowMaximaze.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemWindowMaximaze.Name = "toolStripMenuItemWindowMaximaze";
            this.toolStripMenuItemWindowMaximaze.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemWindowMaximaze.Text = "Развернуть";
            this.toolStripMenuItemWindowMaximaze.Click += new System.EventHandler(this.toolStripMenuItemWindowMaximaze_Click);
            // 
            // toolStripSeparatorWindow
            // 
            this.toolStripSeparatorWindow.Name = "toolStripSeparatorWindow";
            this.toolStripSeparatorWindow.Size = new System.Drawing.Size(146, 6);
            // 
            // toolStripMenuItemWindowsClose
            // 
            this.toolStripMenuItemWindowsClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemWindowsClose.Image")));
            this.toolStripMenuItemWindowsClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemWindowsClose.Name = "toolStripMenuItemWindowsClose";
            this.toolStripMenuItemWindowsClose.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemWindowsClose.Text = "Закрыть";
            this.toolStripMenuItemWindowsClose.Click += new System.EventHandler(this.toolStripMenuItemWindowsClose_Click);
            // 
            // токToolStripMenuItem
            // 
            this.токToolStripMenuItem.Name = "токToolStripMenuItem";
            this.токToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // notifyIconBirthDay
            // 
            this.notifyIconBirthDay.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconBirthDay.Icon")));
            this.notifyIconBirthDay.Text = "Энергосхема";
            this.notifyIconBirthDay.Visible = true;
            this.notifyIconBirthDay.BalloonTipClicked += new System.EventHandler(this.notifyIconBirthDay_BalloonTipClicked);
            this.notifyIconBirthDay.DoubleClick += new System.EventHandler(this.notifyIconBirthDay_DoubleClick);
            this.notifyIconBirthDay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconBirthDay_MouseClick);
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файл схемы|*.shf";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // timerUpdater
            // 
            this.timerUpdater.Tick += new System.EventHandler(this.timerUpdater_Tick);
            // 
            // backgroundWorkerUpdater
            // 
            this.backgroundWorkerUpdater.WorkerSupportsCancellation = true;
            this.backgroundWorkerUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUpdater_DoWork);
            this.backgroundWorkerUpdater.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUpdater_RunWorkerCompleted);
            // 
            // TimerMessage
            // 
            this.TimerMessage.Interval = 1000;
            this.TimerMessage.Tick += new System.EventHandler(this.TimerMessage_Tick);
            // 
            // toolStripMenuItem52
            // 
            this.toolStripMenuItem52.Name = "toolStripMenuItem52";
            this.toolStripMenuItem52.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem52.Text = "1";
            this.toolStripMenuItem52.Click += new System.EventHandler(this.toolStripMenuItem52_Click);
            // 
            // ведомостьПоПризнакамСПриборамиУчетаToolStripMenuItem
            // 
            this.ведомостьПоПризнакамСПриборамиУчетаToolStripMenuItem.Name = "ведомостьПоПризнакамСПриборамиУчетаToolStripMenuItem";
            this.ведомостьПоПризнакамСПриборамиУчетаToolStripMenuItem.Size = new System.Drawing.Size(449, 22);
            this.ведомостьПоПризнакамСПриборамиУчетаToolStripMenuItem.Text = "Ведомость по признакам с приборами учета";
            this.ведомостьПоПризнакамСПриборамиУчетаToolStripMenuItem.Click += new System.EventHandler(this.ведомостьПоПризнакамСПриборамиУчетаToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 621);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripFormMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = " Энергосхема";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.FormMain_MdiChildActivate);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.menuStripFormMain.ResumeLayout(false);
            this.menuStripFormMain.PerformLayout();
            this.contextMenuWindow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private ToolStrip toolStripMain;
        private ToolStripLabel toolStripLabelTime;
        private ToolStripSeparator toolStripSeparator2;
        public MenuStrip menuStripFormMain;
        private ToolStripMenuItem toolStripMenuItemWindows;
        private ToolStripMenuItem toolStripMenuItemCascade;
        private ToolStripMenuItem toolStripMenuItemTileHorizontal;
        private ToolStripMenuItem toolStripMenuItemTileVertical;
        private ToolStripMenuItem toolStripMenuItemWindowCloseAll;
        private ToolStripMenuItem toolStripMenuItemRef;
        private ToolStripMenuItem About;
        private ContextMenuStrip contextMenuWindow;
        private ToolStripMenuItem toolStripMenuItemWindowsRestore;
        private ToolStripMenuItem toolStripMenuItemWindowsMinimize;
        private ToolStripMenuItem toolStripMenuItemWindowMaximaze;
        private ToolStripSeparator toolStripSeparatorWindow;
        private ToolStripMenuItem toolStripMenuItemWindowsClose;
        private ToolStripMenuItem toolStripMenuItemReference;
        private ToolStripMenuItem toolStripMenuItemClassifier;
        private ToolStripMenuItem toolStripMenuItemKadrs;
        private ToolStripMenuItem toolStripMenuItemJobTitles;
        private ToolStripMenuItem toolStripMenuItemDivisions;
        private ToolStripMenuItem toolStripMenuItemWorkers;
        private ToolStripMenuItem toolStripMenuItemMeters;
        private ToolStripMenuItem toolStripMenuItemCounter;
        private ToolStripMenuItem toolStripMenuItemTransformator;
        private ToolStripMenuItem toolStripMenuItemServices;
        private ToolStripMenuItem toolStripMenuItemUsers;
        private ToolStripMenuItem toolStripMenuItemSecurity;
        private ToolStripMenuItem toolStripMenuItemKladr;
        private ToolStripMenuItem toolStripMenuItemKladrObj;
        private ToolStripMenuItem toolStripMenuItemKladrSocr;
        private ToolStripMenuItem toolStripMenuItemKladrHouse;
        private ToolStripMenuItem toolStripMenuItemFL;
        private ToolStripMenuItem toolStripMenuItemFLAbonent;
        private ToolStripMenuItem toolMenuItemLegal;
        private ToolStripMenuItem toolStripMenuItemDocument;
        private ToolStripMenuItem toolStripMenuItemCalcLoss;
        private ToolStripMenuItem токToolStripMenuItem;
        //private ToolStripMenuItem Field182;
        private ToolStripMenuItem toolMenuItemJPlomb;
        private ToolStripMenuItem toolMenuItemGroupWorker;
        private ToolStripMenuItem toolMenuItemReports;
        private ToolStripMenuItem toolMenuItemActs;
        private NotifyIcon notifyIconBirthDay;
        private System.Windows.Forms.Timer timerMain;
        private ToolStripMenuItem toolMenuItemRepPlombs;
        private ToolStripSeparator toolStripMenuItem110;
        private ToolStripMenuItem toolStripMenuItemMaterial;
        private ToolStripMenuItem toolMenuItemControlers;
        private ToolStripSeparator toolStripMenuItem21;
        private ToolStripMenuItem toolStripMenuItemUnloadingGRP;
        private ToolStripMenuItem toolMenuItemCharge;
        private ToolStripMenuItem toolMenuItemProtocolDeb;
        private ToolStripMenuItem toolMenuItemAnalysisAndComparison;
        private ToolStripMenuItem обменToolStripMenuItem;
        private ToolStripMenuItem toolMenuItemExportDocuments;
        private ToolStripMenuItem toolMenuItemLegalAbn;
        private ToolStripMenuItem toolMenuItemScheme;
        private ToolStripMenuItem toolMenuitemGeneralScheme;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem toolMenuSettingsLegal;
        private ToolStripMenuItem toolMenuItemCloseAccountPeriod;
        private ToolStripMenuItem toolMenuItemAuthorizedPersons;
        private ToolStripMenuItem toolMenuItemGraphicSurveys;
        private ToolStripMenuItem toolMenuItemReportsLegal;
        private ToolStripMenuItem toolMenuItemReportCharge;
        private ToolStripMenuItem toolStripMenuItemTransf;
        private ToolStripMenuItem toolMenuItemCoupling;
        private ToolStripMenuItem toolMenuItemJRequest;
        private ToolStripMenuItem toolMenuClassifier;
        private ToolStripMenuItem toolMenuItemCable;
        private ToolStripMenuItem toolMenuItemReferenceLegal;
        private ToolStripMenuItem toolMenuItemAbonentsLegal;
        private ToolStripMenuItem toolMenuItemAbnObjectsLegal;
        private ToolStripMenuItem toolMenuItemMeterLegal;
        private ToolStripMenuItem toolMenuItemBanksLegal;
        private ToolStripMenuItem toolMenuItemChargeLegal;
        private ToolStripMenuItem toolMenuItemInputCharge;
        private ToolStripMenuItem toolMenuItemSetAccountPeriod;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolMenuItemOPCMessageConfig;
        private ToolStripMenuItem toolMenuItemLinkCellPoint;
        private ToolStripMenuItem toolMenuItemInputCheck;
        private ToolStripMenuItem toolMenuItemCreateAndPrintDocs;
        private ToolStripMenuItem toolMenuItemsDocsLegal;
        private ToolStripMenuItem toolMenuItemActBalanceInventory;
        private ToolStripMenuItem toolStripMenuItemForeCast;
        private ToolStripMenuItem toolMenuItemInputForecast;
        private ToolStripMenuItem tsmPassport;
        private ToolStripMenuItem tsmiPassportPS;
        private ToolStripSeparator toolStripSeparator41;
        private ToolStripMenuItem tsmiPassportSettings;
        private ToolStripMenuItem tsmiPassportSettingsPanel;
        private ToolStripMenuItem toolStripMenuItemConnectToServer;
        private ToolStripMenuItem tsmiPassportTransf;
        private ToolStripMenuItem toolMenuItemJOrder;
        private ToolStripMenuItem tsmiPassportReports;
        private ToolStripMenuItem toolMenuItemListHouses;
        private ToolStripMenuItem toolMenuItemListAllHouses;
        private ToolStripMenuItem toolMenuItemChangeAddressHouse;
        private ToolStripMenuItem toolMenuItemReportControler;
        private ToolStripMenuItem toolMenuItemImportFromUE;
        private ToolStripMenuItem toolMenuItemImportFromSberbank;
        private ToolStripMenuItem toolMenuItemReportInvoice;
        private ToolStripMenuItem toolMenuItemREportPerformance;
        private ToolStripMenuItem toolMenuItemNumInvoice;
        private ToolStripMenuItem toolMenuItemTariffLegal;
        private ToolStripMenuItem toolMenuItemExportLegal;
        private ToolStripMenuItem toolMenuItemExportToGRP;
        private ToolStripMenuItem toolMenuItemExportToODS;
        private ToolStripMenuItem toolMenuItemExportToUE;
        private ToolStripMenuItem toolMenuItemExportTo1C;
        private ToolStripMenuItem toolMenuItemExportToMRSK;
        private ToolStripMenuItem toolMenuItemCheckLegal;
        private ToolStripMenuItem toolMenuItemCheckInvoice;
        private ToolStripMenuItem toolMenuItemCheckDocAndInvoice;
        private ToolStripMenuItem toolStripMenuItemLogInOut;
        private ToolStripSeparator toolStripSeparatorBulletens;
        private ToolStripMenuItem toolMenuItemJournals;
        private ToolStripMenuItem toolMenuItemJRequestForRepair;
        private ToolStripMenuItem toolStripMenuItemConnectDisconnect;
        private ToolStripMenuItem toolStripMenuItemReportODS;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripMenuItem tsmiPassportReferense;
        private ToolStripMenuItem tsmiPassportDoc;
        private ToolStripMenuItem toolMenuItemReportOnGrounds;
        private ToolStripMenuItem toolMenuItemReportOnGroundsGos;
        private ToolStripMenuItem tsmiPassportChars;
        private ToolStripSeparator toolStripSeparator51;
        private ToolStripMenuItem toolMenuItemJRelayProtectionAutomation;
        private ToolStripMenuItem tsmiPassportValueLists;
        private ToolStripMenuItem tsmiPassportReport;
        private ToolStripMenuItem toolMenuItemNoticeGos;
        private ToolStripMenuItem toolStripMenuItemAditionally;
        private ToolStripMenuItem плановыеЧасыПиковойНагрузкиToolStripMenuItem;
        private ToolStripMenuItem отчетПоЗамерамРежимногоДняToolStripMenuItem;
        private ToolStripMenuItem toolMenuItemUpdateProgram;
        private ToolTip toolTip1;
        private ToolStripMenuItem tsmiPassportCable;
        private ToolStripMenuItem tsmiCountSwitch;
        private ToolStripMenuItem tsmiReportOffKL;
        private ToolStripMenuItem toolMenuItemUpdates;
        private System.Windows.Forms.Timer timerUpdater;
        private ToolStripButton toolBtnUpdate;
        //internal BackgroundWorker backgroundWorkerUpdater;
        private ToolStripMenuItem tsmiImportoldTransf;
        private ToolStripMenuItem toolStripMenuItemNormalSchema;
        private ToolStripMenuItem toolStripMenuItemKontragent;
        private ToolStripMenuItem toolMenuItemJExcavation;
        private ToolStripMenuItem toolMenuItemJTechnologicalFailures;
        private ToolStripMenuItem toolStripMenuTechConnection;
        private ToolStripMenuItem toolStripMenuTechConnectionRequest;
        private ToolStripMenuItem toolStripMenuItemReports;
        private ToolStripMenuItem toolMenuItemLogDispatcher;
        private ToolStripMenuItem toolStripMenuItemPoweringReport;
        private ToolStripMenuItem toolStripMenuItemJDefect;
        private ToolStripMenuItem toolMenuItemDocScan;
        private ToolStripMenuItem tsmiCableTestingAfterRepair;
        private ToolStripMenuItem toolStripMenuItemChat;
        private ToolStripLabel toolLabelConnect;
        private ToolStripSeparator toolStripMenuItemAbout;
        private ToolStripMenuItem tsmiPassportAirLine;
        private ToolStripMenuItem toolStripMenuItemFileExplorer;
        private ToolStripMenuItem toolStripMenuTechConnectionTU;
        private ToolStripMenuItem tsmiDocTamplates;
        private ToolStripMenuItem toolMenuItemAbnOff;
        private ToolStripMenuItem toolMenuItemJRequestForRepairCrash;
        private ToolStripMenuItem toolStripMenuTechConnectionMailTU;
        private ToolStripMenuItem договораНаТПToolStripMenuItem;
        private ToolStripMenuItem toolMenuItemLREportLinkAbn;
        private ToolStripMenuItem toolStripMenuItemMeasurementReport;
        private ToolStripMenuItem toolStripMenuTechConnectionTC;
        private ToolStripSeparator toolStripSeparator71;
        private ToolStripMenuItem toolStripMenuActsElectricalInspection;
        private ToolStripMenuItem toolStripMenuItemActsPerformingTU;
        private ToolStripMenuItem журналАбонентовToolStripMenuItem;
        private ToolStripMenuItem tsmiMemorandums;
        private ToolStripMenuItem UEOplToolStripMenuItem;
        private ToolStripMenuItem UEDebToolStripMenuItem;
        private ToolStripMenuItem tsmiBossUsers;
        private ToolStripSeparator toolStripSeparator91;
        private ToolStripMenuItem gfcToolStripMenuItem;
        private ToolStripMenuItem UESurveyToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuTechConnectionActRBP;
        private ToolStripMenuItem toolMenuItemImportFromMatrica;
        private ToolStripMenuItem toolMenuItemUEOplPost;
        private ToolStripMenuItem toolMenuItemUEAnalysis;
        private ToolStripMenuItem toolMenuItemMergeAbnMoveAbnObj;
        private ToolStripButton toolBtnMessage;
        private System.Windows.Forms.Timer TimerMessage;
        //private Button button1;
        private ToolStripMenuItem toolMenuItemJournalTCRebinding;
        private ToolStripMenuItem toolMenuItemJournalDistributionConsumers;
        private ToolStripSeparator toolStripSeparator101;
        private ToolStripSeparator toolStripSeparator111;
        private ToolStripMenuItem toolMenuItemJournalLog;
        private ToolStripSeparator toolStripSeparator121;
        private ToolStripMenuItem toolMenuItemDailyReport;
        private ToolStripMenuItem toolMenuItemJournalDamage;
        private ToolStripMenuItem toolMenuItemTemperature;
        private ToolStripMenuItem toolStripMenuTechConnectionActRBPNew;
        private ToolStripMenuItem toolMenuItemJournalActDefection;
        private ToolStripSeparator tsSepar8;
        //private AvailablePlugins Field6;
        //private TCPSocketListener Field5;
        private System.Timers.Timer TimerChat;
        private ToolStripMenuItem журналРаспоряженийToolStripMenuItem;
        private ToolStripMenuItem журналРаспоряженийToolStripMenuItem1;
        private ToolStripMenuItem tsmiMeasurement;
        private ToolStripMenuItem привязанныеАбонентыNToolStripMenuItem;
        private ToolStripMenuItem tspMenuItemJournalN;
        private ToolStripMenuItem tsmiMeasurementN;
        private ToolStripMenuItem заявкиНаРемонтToolStripMenuItem;
        private ToolStripMenuItem аварийныеОтключенияToolStripMenuItem;
        private ToolStripMenuItem заявкиНаРемонтToolStripMenuItem1;
        private ToolStripMenuItem аварийныеОтключенияToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem поступлениеВСетьToolStripMenuItem;
        private ToolStripMenuItem toolMenuItemCountMeter;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem toolMenuItemReportAverage;
        private ToolStripMenuItem toolMenuItemImportDNU;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItemFormJournalDamage;
        private ToolStripMenuItem toolStripMenuItemFormJournalActDetection;
        private ToolStripSeparator toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem всеДомаСНачислениямипоПериодамToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem13;
        private ToolStripMenuItem расчетПотерьЭлектрическойЭнергииToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripSeparator toolStripMenuItem18;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem19;
        private ToolStripSeparator toolStripMenuItem20;
        private ToolStripMenuItem выгрузкаДоговоровТПToolStripMenuItem;
        private ToolStripMenuItem журналТехнологическихНарушенийToolStripMenuItem;
        private ToolStripMenuItem журналДефектовToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem общийЖурналТехнологическихНарушенийToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem22;
        private ToolStripMenuItem toolStripMenuItem23;
        private ToolStripMenuItem toolStripMenuItem24;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolStripMenuItem25;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem toolStripMenuItem26;
        private ToolStripMenuItem toolStripMenuItem27;
        private ToolStripMenuItem toolStripMenuItem28;
        private ToolStripSeparator toolStripMenuItem29;
        private ToolStripMenuItem toolStripMenuItem31;
        private ToolStripMenuItem toolStripMenuItem30;
        private ToolStripSeparator toolStripMenuItem32;
        private ToolStripMenuItem ведомостьКорректировкиToolStripMenuItem;
        private ToolStripMenuItem тестReportView12ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem34;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem33;
        private ToolStripMenuItem справочникОбъектовдомовToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem35;
        private ToolStripMenuItem toolStripMenuItem36;
        private ToolStripMenuItem toolStripMenuItem37;
        private ToolStripMenuItem toolStripMenuItem38;
        private ToolStripSeparator toolStripMenuItem39;
        private ToolStripMenuItem произвольныеСправочникиToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem40;
        private ToolStripMenuItem toolStripMenuItem41;
        private ToolStripMenuItem журналАбонентовToolStripMenuItem1;
        private ToolStripMenuItem отчетПоСпециаличтамToolStripMenuItem;
        private ToolStripMenuItem tspMenuItemSchedulers;
        private ToolStripSeparator toolStripMenuItem42;
        private ToolStripMenuItem журналАктовToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem43;
        private ToolStripMenuItem toolStripMenuItem45;
        private ToolStripMenuItem гИСToolStripMenuItem;
        private ToolStripMenuItem ведомостьОбменаДаннымиСГИСToolStripMenuItem;
        private ToolStripMenuItem журналАктовToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem tspMenuItemMap;
        private ToolStripMenuItem toolStripMenuItem46;
        private ToolStripMenuItem tspDatatoGIS;
        private ToolStripMenuItem импортКадровыхДанныхToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem48;
        private ToolStripMenuItem схемаToolStripMenuItem;
        private ToolStripMenuItem отчётПоЗамерамToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem49;
        private ToolStripMenuItem отчетПоЗамерам2019ToolStripMenuItem;
        private ToolStripMenuItem протоколРаботыСпециалистовToolStripMenuItem;
        private ToolStripMenuItem tspMenuItemUE;
        private ToolStripMenuItem toolStripMenuItemConsumer;
        private ToolStripMenuItem toolStripMenuItemJournalAbonentov;
        private ToolStripMenuItem toolStripMenuItemFindConsumers;
        private ToolStripMenuItem тестDockContentBaseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem44;
        private ToolStripMenuItem отчетПотребленияПомесячноToolStripMenuItem;
        private ToolStripMenuItem журналДемонтажаПриборовУчетаToolStripMenuItem;
        private ToolStripMenuItem toolMenuItemJPlombGos;
        private ToolStripMenuItem toolStripMenuItem47;
        private ToolStripMenuItem умныйГородToolStripMenuItem;
        private ToolStripMenuItem ведомостьПоПризнакампоПрямымПеретокToolStripMenuItem;
        private ToolStripMenuItem деревоОбъектовСхемыToolStripMenuItem;
        private ToolStripMenuItem тестЗагрузкиМоделиСхемыToolStripMenuItem;
        private ToolStripMenuItem импортПолучасовокToolStripMenuItem;
        private ToolStripMenuItem структураТочекИзмеренияToolStripMenuItem;
        private ToolStripMenuItem приборыУчетаASOKAToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem50;
        private ToolStripMenuItem загрузкаНарядовНаРаботуToolStripMenuItem;
        private ToolStripMenuItem отчетПоРазногласиямВКонтрольныхToolStripMenuItem;
        private ToolStripMenuItem реестрТочекИзмеренияToolStripMenuItem;
        private ToolStripMenuItem tspTOK5;
        private ToolStripMenuItem toolStripMenuItem52;
        private ToolStripSeparator toolStripMenuItem51;
        private ToolStripMenuItem уведомлениеОбОтключенияхToolStripMenuItem;
        private ToolStripMenuItem анализПотребляемойЭнергииИУстановленнойМощностиToolStripMenuItem;
        private ToolStripMenuItem ведомостьПоПризнакамСПриборамиУчетаToolStripMenuItem;
    }
}
