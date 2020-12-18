using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DailyReportN.DataSet;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace DailyReportN.JournalActDetection
{
    internal partial class FormActDetectionAddEdit : FormLbr.FormBase
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components = null;


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActDetectionAddEdit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.labelNumCrash = new System.Windows.Forms.Label();
            this.txtNumCrash = new System.Windows.Forms.TextBox();
            this.dataSetDamage = new DailyReportN.DataSet.dsDamage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRefreshUploadParentDoc = new System.Windows.Forms.Button();
            this.btnOpenParentDamage = new System.Windows.Forms.Button();
            this.groupBoxNoCrashEvents = new System.Windows.Forms.GroupBox();
            this.dgvNoCrashMeasure = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idNoCrashMeasureColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateCompleteDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.idOrgColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsNoCrashMeasure = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCrash = new System.Data.DataSet();
            this.dataTableNoCrashMeasure = new System.Data.DataTable();
            this.dataColumn27 = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataTableDefection = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataTableParametersEquipment = new System.Data.DataTable();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataTableComission = new System.Data.DataTable();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.dataColumn25 = new System.Data.DataColumn();
            this.dataColumn26 = new System.Data.DataColumn();
            this.dataColumn46 = new System.Data.DataColumn();
            this.dataColumn48 = new System.Data.DataColumn();
            this.dataColumn50 = new System.Data.DataColumn();
            this.dataColumn47 = new System.Data.DataColumn();
            this.dataColumn49 = new System.Data.DataColumn();
            this.dataColumn51 = new System.Data.DataColumn();
            this.dataColumn52 = new System.Data.DataColumn();
            this.dataColumn53 = new System.Data.DataColumn();
            this.dataColumn54 = new System.Data.DataColumn();
            this.dataColumn55 = new System.Data.DataColumn();
            this.dataColumn56 = new System.Data.DataColumn();
            this.dataColumn57 = new System.Data.DataColumn();
            this.dataColumn58 = new System.Data.DataColumn();
            this.dataColumn59 = new System.Data.DataColumn();
            this.dataColumn60 = new System.Data.DataColumn();
            this.dataColumn61 = new System.Data.DataColumn();
            this.dataColumn62 = new System.Data.DataColumn();
            this.dataColumn63 = new System.Data.DataColumn();
            this.dataTableVoltagePowerPlantConsumer = new System.Data.DataTable();
            this.dataColumn28 = new System.Data.DataColumn();
            this.dataColumn29 = new System.Data.DataColumn();
            this.dataColumn30 = new System.Data.DataColumn();
            this.dataColumn31 = new System.Data.DataColumn();
            this.dataTableAnnex = new System.Data.DataTable();
            this.dataColumnName = new System.Data.DataColumn();
            this.dataColumnValue = new System.Data.DataColumn();
            this.dataTablePersonal = new System.Data.DataTable();
            this.dataColumn32 = new System.Data.DataColumn();
            this.dataColumn33 = new System.Data.DataColumn();
            this.dataColumn34 = new System.Data.DataColumn();
            this.dataColumn35 = new System.Data.DataColumn();
            this.dataColumn36 = new System.Data.DataColumn();
            this.dataColumn37 = new System.Data.DataColumn();
            this.dataColumn38 = new System.Data.DataColumn();
            this.dataColumn39 = new System.Data.DataColumn();
            this.dataColumn40 = new System.Data.DataColumn();
            this.dataColumn41 = new System.Data.DataColumn();
            this.dataColumn42 = new System.Data.DataColumn();
            this.dataColumn43 = new System.Data.DataColumn();
            this.dataColumn44 = new System.Data.DataColumn();
            this.dataColumn45 = new System.Data.DataColumn();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.cmbOrgCrash = new ControlsLbr.ComboBoxReadOnly();
            this.cmbOrgCrashEq = new ControlsLbr.ComboBoxReadOnly();
            this.dtpBeginCrashMoscow = new ControlsLbr.NullableDateTimePicker();
            this.btnRefrshDateEndCrash = new System.Windows.Forms.Button();
            this.btnRefreshDateDoc = new System.Windows.Forms.Button();
            this.dtpEndCrashMoscow = new ControlsLbr.NullableDateTimePicker();
            this.dtpEndCrashLocal = new ControlsLbr.NullableDateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbReasonCrash = new ControlsLbr.ComboBoxReadOnly();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbReasonCrashEquipment = new ControlsLbr.ComboBoxReadOnly();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTypeEquipment = new ControlsLbr.ComboBoxReadOnly();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSignCrash = new ControlsLbr.ComboBoxReadOnly();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbOrg = new ControlsLbr.ComboBoxReadOnly();
            this.chkNoOff = new System.Windows.Forms.CheckBox();
            this.dtpDateDoc = new ControlsLbr.NullableDateTimePicker();
            this.label81 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonChooseParentDamage = new System.Windows.Forms.Button();
            this.txtParentDamage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkCrash = new System.Windows.Forms.CheckBox();
            this.cmbDivision = new ControlsLbr.ComboBoxReadOnly();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCompiler = new ControlsLbr.ComboBoxReadOnly();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateOwner = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumRequest = new System.Windows.Forms.TextBox();
            this.tabPageDescription = new System.Windows.Forms.TabPage();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.txtStatusBeforeCrash = new System.Windows.Forms.RichTextBox();
            this.txtFault = new System.Windows.Forms.RichTextBox();
            this.txtClassifierDamage = new System.Windows.Forms.RichTextBox();
            this.txtReasonBeginCrash = new System.Windows.Forms.RichTextBox();
            this.txtStatusCurrentCrash = new System.Windows.Forms.RichTextBox();
            this.cmbFault = new ControlsLbr.ComboBoxReadOnly();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbClassifierDamage = new ControlsLbr.ComboBoxReadOnly();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbReasonBeginCrash = new ControlsLbr.ComboBoxReadOnly();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvDefection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDefectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idNPADgvColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.punctNPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrgDefectionDgvColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsDefection = new System.Windows.Forms.BindingSource(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.cmbStatusCurrentCrash = new ControlsLbr.ComboBoxReadOnly();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbStatusBeforeCrash = new ControlsLbr.ComboBoxReadOnly();
            this.txtSchmObj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageSchm = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtNodeDetail = new System.Windows.Forms.TextBox();
            this.bsDamageCharacter = new System.Windows.Forms.BindingSource(this.components);
            this.label37 = new System.Windows.Forms.Label();
            this.cmbMaterial = new ControlsLbr.ComboBoxReadOnly();
            this.label36 = new System.Windows.Forms.Label();
            this.txtLenghtLine = new System.Windows.Forms.TextBox();
            this.chkAutoProtect = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cmbMarkEquipment = new ControlsLbr.ComboBoxReadOnly();
            this.txtLengthOverload = new System.Windows.Forms.TextBox();
            this.cmbParameters = new ControlsLbr.ComboBoxReadOnly();
            this.label34 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtClauseFail = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.cmbVoltage = new ControlsLbr.ComboBoxReadOnly();
            this.cmbNeutralState = new ControlsLbr.ComboBoxReadOnly();
            this.label26 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.cmbNodeDetail = new ControlsLbr.ComboBoxReadOnly();
            this.txtYearManufature = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.cmbVoltageSeti = new ControlsLbr.ComboBoxReadOnly();
            this.txtFactoryNumber = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtCountDefectEquipment = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.cmbClauseWork = new ControlsLbr.ComboBoxReadOnly();
            this.label45 = new System.Windows.Forms.Label();
            this.dtpTimeRecovery = new ControlsLbr.NullableDateTimePicker();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtLengthWorkEquipment = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtYearBegEquipment = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtAssociatedFact = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.cmbReasonDamage = new ControlsLbr.ComboBoxReadOnly();
            this.label39 = new System.Windows.Forms.Label();
            this.cmbCharacterDamage = new ControlsLbr.ComboBoxReadOnly();
            this.dtpLastDateTest = new ControlsLbr.NullableDateTimePicker();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.typeEquipmentDgvColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idDamCharacterDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSchmObjDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDamageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schmObjNameDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schmObjDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripEquipment = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddEquipment = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelEquipment = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPageComission = new System.Windows.Forms.TabPage();
            this.chkChairmanSpecial = new System.Windows.Forms.CheckBox();
            this.chkMemberComissionSpecial5 = new System.Windows.Forms.CheckBox();
            this.chkMemberComissionSpecial4 = new System.Windows.Forms.CheckBox();
            this.chkMemberComissionSpecial3 = new System.Windows.Forms.CheckBox();
            this.chkMemberComissionSpecial2 = new System.Windows.Forms.CheckBox();
            this.chkMemberComissionSpecial1 = new System.Windows.Forms.CheckBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.txtPostMemeber5 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.cmbMemberComission5 = new ControlsLbr.ComboBoxReadOnly();
            this.txtPostMemeber4 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.cmbMemberComission4 = new ControlsLbr.ComboBoxReadOnly();
            this.txtTotalComission = new System.Windows.Forms.RichTextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.txtPostMemeber3 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.cmbMemberComission3 = new ControlsLbr.ComboBoxReadOnly();
            this.txtPostMemeber2 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.cmbMemberComission2 = new ControlsLbr.ComboBoxReadOnly();
            this.txtPostMemeber1 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.cmbMemberComission1 = new ControlsLbr.ComboBoxReadOnly();
            this.label49 = new System.Windows.Forms.Label();
            this.txtPostChairman = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.cmbChairman = new ControlsLbr.ComboBoxReadOnly();
            this.label47 = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tabPageSpecialOpinion = new System.Windows.Forms.TabPage();
            this.txtMemberPostSpecial5 = new System.Windows.Forms.RichTextBox();
            this.lblMemberComissionSpecial5 = new System.Windows.Forms.Label();
            this.txtMemberPostSpecial4 = new System.Windows.Forms.RichTextBox();
            this.lblMemberComissionSpecial4 = new System.Windows.Forms.Label();
            this.txtMemberPostSpecial3 = new System.Windows.Forms.RichTextBox();
            this.lblMemberComissionSpecial3 = new System.Windows.Forms.Label();
            this.txtMemberPostSpecial2 = new System.Windows.Forms.RichTextBox();
            this.lblMemberComissionSpecial2 = new System.Windows.Forms.Label();
            this.txtMemberPostSpecial1 = new System.Windows.Forms.RichTextBox();
            this.lblMemberComissionSpecial1 = new System.Windows.Forms.Label();
            this.txtChairmanSpecial = new System.Windows.Forms.RichTextBox();
            this.lblChairmanSpecial = new System.Windows.Forms.Label();
            this.tabPagePrint = new System.Windows.Forms.TabPage();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDateLastCheck = new ControlsLbr.NullableDateTimePicker();
            this.bsPersonal = new System.Windows.Forms.BindingSource(this.components);
            this.txtReasonError = new System.Windows.Forms.RichTextBox();
            this.txtCircumstancesError = new System.Windows.Forms.RichTextBox();
            this.txtWorkExperience = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.txtPlaceWork = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspAddPersonal = new System.Windows.Forms.ToolStripButton();
            this.tsbDelPersonal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.idPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlaceWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceWorkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label79 = new System.Windows.Forms.Label();
            this.tabAnnex = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtConsumerPartialDeenergized = new System.Windows.Forms.RichTextBox();
            this.txtConsumerFullDeenergized = new System.Windows.Forms.RichTextBox();
            this.txtFeedObjectsList = new System.Windows.Forms.RichTextBox();
            this.txtCountDeEnergizedPopulation = new System.Windows.Forms.TextBox();
            this.txtCountDeEnergizedSocialObjects = new System.Windows.Forms.TextBox();
            this.txtCountDeEnergizedSettlements = new System.Windows.Forms.TextBox();
            this.txtCountDeEnergizedRP110 = new System.Windows.Forms.TextBox();
            this.txtCountDeEnergizedRP35 = new System.Windows.Forms.TextBox();
            this.txtCountDeEnergizedTP = new System.Windows.Forms.TextBox();
            this.txtPowerTotal = new System.Windows.Forms.TextBox();
            this.txtCountPointsSupply = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.dgvVoltagePowerPlantConsumer = new System.Windows.Forms.DataGridView();
            this.ColumnVoltage = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cat1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVoltagePowerPlantConsumer = new System.Windows.Forms.BindingSource(this.components);
            this.txtTSONeighList = new System.Windows.Forms.RichTextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.tabPageDocuments = new System.Windows.Forms.TabPage();
            this.dgvDocs = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumnDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDamageDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
            this.bsDamageDoc = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripDocuments = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnViewDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSaveDoc = new System.Windows.Forms.ToolStripButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.chkApply = new System.Windows.Forms.CheckBox();
            this.label54 = new System.Windows.Forms.Label();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpApply = new ControlsLbr.NullableDateTimePicker();
            this.cmbWorkerApply = new ControlsLbr.ComboBoxReadOnly();
            this.bsDamage = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxNoCrashEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoCrashMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNoCrashMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableNoCrashMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableDefection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableParametersEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableComission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVoltagePowerPlantConsumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAnnex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePersonal)).BeginInit();
            this.groupBoxGeneral.SuspendLayout();
            this.tabPageDescription.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDefection)).BeginInit();
            this.tabPageSchm.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamageCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            this.toolStripEquipment.SuspendLayout();
            this.tabPageComission.SuspendLayout();
            this.tabPageSpecialOpinion.SuspendLayout();
            this.tabPersonal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonal)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.tabAnnex.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoltagePowerPlantConsumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVoltagePowerPlantConsumer)).BeginInit();
            this.tabPageDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamageDoc)).BeginInit();
            this.toolStripDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageDescription);
            this.tabControl1.Controls.Add(this.tabPageSchm);
            this.tabControl1.Controls.Add(this.tabPageComission);
            this.tabControl1.Controls.Add(this.tabPageSpecialOpinion);
            this.tabControl1.Controls.Add(this.tabPagePrint);
            this.tabControl1.Controls.Add(this.tabPersonal);
            this.tabControl1.Controls.Add(this.tabAnnex);
            this.tabControl1.Controls.Add(this.tabPageDocuments);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 567);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.labelNumCrash);
            this.tabPageGeneral.Controls.Add(this.txtNumCrash);
            this.tabPageGeneral.Controls.Add(this.splitContainer1);
            this.tabPageGeneral.Controls.Add(this.chkCrash);
            this.tabPageGeneral.Controls.Add(this.cmbDivision);
            this.tabPageGeneral.Controls.Add(this.label5);
            this.tabPageGeneral.Controls.Add(this.cmbCompiler);
            this.tabPageGeneral.Controls.Add(this.label4);
            this.tabPageGeneral.Controls.Add(this.dtpDateOwner);
            this.tabPageGeneral.Controls.Add(this.label3);
            this.tabPageGeneral.Controls.Add(this.txtOwner);
            this.tabPageGeneral.Controls.Add(this.label2);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Controls.Add(this.txtNumRequest);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(776, 541);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общие";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // labelNumCrash
            // 
            this.labelNumCrash.AutoSize = true;
            this.labelNumCrash.Location = new System.Drawing.Point(653, 38);
            this.labelNumCrash.Name = "labelNumCrash";
            this.labelNumCrash.Size = new System.Drawing.Size(57, 13);
            this.labelNumCrash.TabIndex = 13;
            this.labelNumCrash.Text = "№ аварии";
            // 
            // txtNumCrash
            // 
            this.txtNumCrash.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.numCrash", true));
            this.txtNumCrash.Enabled = false;
            this.txtNumCrash.Location = new System.Drawing.Point(716, 35);
            this.txtNumCrash.Name = "txtNumCrash";
            this.txtNumCrash.Size = new System.Drawing.Size(52, 20);
            this.txtNumCrash.TabIndex = 12;
            this.txtNumCrash.TextChanged += new System.EventHandler(this.txtNumCrash_TextChanged);
            // 
            // dataSetDamage
            // 
            this.dataSetDamage.DataSetName = "dsDamage";
            this.dataSetDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 62);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRefreshUploadParentDoc);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenParentDamage);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxNoCrashEvents);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxGeneral);
            this.splitContainer1.Panel1.Controls.Add(this.buttonChooseParentDamage);
            this.splitContainer1.Panel1.Controls.Add(this.txtParentDamage);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(776, 479);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 11;
            // 
            // btnRefreshUploadParentDoc
            // 
            this.btnRefreshUploadParentDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshUploadParentDoc.Image = global::DailyReportN.Properties.Resources.refresh_16;
            this.btnRefreshUploadParentDoc.Location = new System.Drawing.Point(739, 12);
            this.btnRefreshUploadParentDoc.Name = "btnRefreshUploadParentDoc";
            this.btnRefreshUploadParentDoc.Size = new System.Drawing.Size(26, 23);
            this.btnRefreshUploadParentDoc.TabIndex = 6;
            this.btnRefreshUploadParentDoc.Text = "...";
            this.btnRefreshUploadParentDoc.UseVisualStyleBackColor = true;
            this.btnRefreshUploadParentDoc.Click += new System.EventHandler(this.btnRefreshUploadParentDoc_Click);
            // 
            // btnOpenParentDamage
            // 
            this.btnOpenParentDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenParentDamage.BackgroundImage = global::DailyReportN.Properties.Resources.ElementInformation;
            this.btnOpenParentDamage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenParentDamage.Location = new System.Drawing.Point(713, 12);
            this.btnOpenParentDamage.Name = "btnOpenParentDamage";
            this.btnOpenParentDamage.Size = new System.Drawing.Size(22, 23);
            this.btnOpenParentDamage.TabIndex = 5;
            this.btnOpenParentDamage.UseVisualStyleBackColor = true;
            this.btnOpenParentDamage.Click += new System.EventHandler(this.btnOpenParentDamage_Click);
            // 
            // groupBoxNoCrashEvents
            // 
            this.groupBoxNoCrashEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNoCrashEvents.Controls.Add(this.dgvNoCrashMeasure);
            this.groupBoxNoCrashEvents.Location = new System.Drawing.Point(0, 349);
            this.groupBoxNoCrashEvents.Name = "groupBoxNoCrashEvents";
            this.groupBoxNoCrashEvents.Size = new System.Drawing.Size(776, 130);
            this.groupBoxNoCrashEvents.TabIndex = 4;
            this.groupBoxNoCrashEvents.TabStop = false;
            this.groupBoxNoCrashEvents.Text = "3. Противоаварийные мероприятия";
            this.groupBoxNoCrashEvents.UseCompatibleTextRendering = true;
            // 
            // dgvNoCrashMeasure
            // 
            this.dgvNoCrashMeasure.AutoGenerateColumns = false;
            this.dgvNoCrashMeasure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoCrashMeasure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNoCrashMeasureColumn,
            this.dateCompleteDataGridViewTextBoxColumn,
            this.idOrgColumn});
            this.dgvNoCrashMeasure.DataSource = this.bsNoCrashMeasure;
            this.dgvNoCrashMeasure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNoCrashMeasure.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNoCrashMeasure.Location = new System.Drawing.Point(3, 16);
            this.dgvNoCrashMeasure.Name = "dgvNoCrashMeasure";
            this.dgvNoCrashMeasure.RowHeadersWidth = 21;
            this.dgvNoCrashMeasure.Size = new System.Drawing.Size(770, 111);
            this.dgvNoCrashMeasure.TabIndex = 0;
            this.dgvNoCrashMeasure.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            this.dgvNoCrashMeasure.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvNoCrashMeasure_EditingControlShowing);
            this.dgvNoCrashMeasure.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvNoCrashMeasure_MouseClick);
            // 
            // idNoCrashMeasureColumn
            // 
            this.idNoCrashMeasureColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idNoCrashMeasureColumn.DataPropertyName = "idNoCrashMeasure";
            this.idNoCrashMeasureColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idNoCrashMeasureColumn.HeaderText = "Мероприятие";
            this.idNoCrashMeasureColumn.Name = "idNoCrashMeasureColumn";
            this.idNoCrashMeasureColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateCompleteDataGridViewTextBoxColumn
            // 
            this.dateCompleteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateCompleteDataGridViewTextBoxColumn.DataPropertyName = "dateComplete";
            dataGridViewCellStyle1.Format = "MMMM.yyyy";
            this.dateCompleteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateCompleteDataGridViewTextBoxColumn.HeaderText = "Срок выполнения";
            this.dateCompleteDataGridViewTextBoxColumn.Name = "dateCompleteDataGridViewTextBoxColumn";
            this.dateCompleteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateCompleteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idOrgColumn
            // 
            this.idOrgColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idOrgColumn.DataPropertyName = "idOrg";
            this.idOrgColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idOrgColumn.HeaderText = "Организация";
            this.idOrgColumn.Name = "idOrgColumn";
            this.idOrgColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bsNoCrashMeasure
            // 
            this.bsNoCrashMeasure.DataMember = "dtNoCrashMeasure";
            this.bsNoCrashMeasure.DataSource = this.dataSetCrash;
            // 
            // dataSetCrash
            // 
            this.dataSetCrash.DataSetName = "dataSetCrash";
            this.dataSetCrash.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableNoCrashMeasure,
            this.dataTableDefection,
            this.dataTableParametersEquipment,
            this.dataTableComission,
            this.dataTableVoltagePowerPlantConsumer,
            this.dataTableAnnex,
            this.dataTablePersonal});
            // 
            // dataTableNoCrashMeasure
            // 
            this.dataTableNoCrashMeasure.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn27,
            this.dataColumn1,
            this.dataColumn2});
            this.dataTableNoCrashMeasure.TableName = "dtNoCrashMeasure";
            // 
            // dataColumn27
            // 
            this.dataColumn27.ColumnName = "idNoCrashMeasure";
            this.dataColumn27.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "dateComplete";
            this.dataColumn1.DataType = typeof(System.DateTime);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "idOrg";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataTableDefection
            // 
            this.dataTableDefection.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dataTableDefection.TableName = "dtDefection";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "idDefection";
            this.dataColumn3.ColumnName = "idDefection";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "idNPA";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "punctNPA";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "idOrg";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataTableParametersEquipment
            // 
            this.dataTableParametersEquipment.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13});
            this.dataTableParametersEquipment.TableName = "dtParametersEquipment";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "AutoProtect";
            this.dataColumn7.DataType = typeof(bool);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "idMark";
            this.dataColumn8.DataType = typeof(int);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Parameters";
            this.dataColumn9.DataType = typeof(int);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Voltage";
            this.dataColumn10.DataType = typeof(int);
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "NodeDetail";
            this.dataColumn11.DataType = typeof(int);
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "VoltageSeti";
            this.dataColumn12.DataType = typeof(int);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "CountDefectEquipment";
            this.dataColumn13.DataType = typeof(int);
            // 
            // dataTableComission
            // 
            this.dataTableComission.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn24,
            this.dataColumn25,
            this.dataColumn26,
            this.dataColumn46,
            this.dataColumn48,
            this.dataColumn50,
            this.dataColumn47,
            this.dataColumn49,
            this.dataColumn51,
            this.dataColumn52,
            this.dataColumn53,
            this.dataColumn54,
            this.dataColumn55,
            this.dataColumn56,
            this.dataColumn57,
            this.dataColumn58,
            this.dataColumn59,
            this.dataColumn60,
            this.dataColumn61,
            this.dataColumn62,
            this.dataColumn63});
            this.dataTableComission.TableName = "dtComission";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "Order";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Chairman";
            this.dataColumn15.DataType = typeof(int);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "PostChairman";
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "Member1";
            this.dataColumn17.DataType = typeof(int);
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "PostMember1";
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "Member2";
            this.dataColumn19.DataType = typeof(int);
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "PostMember2";
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "Member3";
            this.dataColumn21.DataType = typeof(int);
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "PostMember3";
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "Member4";
            this.dataColumn23.DataType = typeof(int);
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "PostMember4";
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "Member5";
            this.dataColumn25.DataType = typeof(int);
            // 
            // dataColumn26
            // 
            this.dataColumn26.ColumnName = "PostMember5";
            // 
            // dataColumn46
            // 
            this.dataColumn46.ColumnName = "MemberSpecial1";
            this.dataColumn46.DataType = typeof(bool);
            // 
            // dataColumn48
            // 
            this.dataColumn48.ColumnName = "MemberSpecial2";
            this.dataColumn48.DataType = typeof(bool);
            // 
            // dataColumn50
            // 
            this.dataColumn50.ColumnName = "MemberSpecial3";
            this.dataColumn50.DataType = typeof(bool);
            // 
            // dataColumn47
            // 
            this.dataColumn47.ColumnName = "MemberSpecial4";
            this.dataColumn47.DataType = typeof(bool);
            // 
            // dataColumn49
            // 
            this.dataColumn49.Caption = "MemberSpecial5";
            this.dataColumn49.ColumnName = "MemberSpecial5";
            this.dataColumn49.DataType = typeof(bool);
            // 
            // dataColumn51
            // 
            this.dataColumn51.ColumnName = "ChairmanSpecial";
            this.dataColumn51.DataType = typeof(bool);
            // 
            // dataColumn52
            // 
            this.dataColumn52.ColumnName = "MemberPostSpecial1";
            // 
            // dataColumn53
            // 
            this.dataColumn53.ColumnName = "MemberPostSpecial2";
            // 
            // dataColumn54
            // 
            this.dataColumn54.ColumnName = "MemberPostSpecial3";
            // 
            // dataColumn55
            // 
            this.dataColumn55.ColumnName = "MemberPostSpecial4";
            // 
            // dataColumn56
            // 
            this.dataColumn56.ColumnName = "MemberPostSpecial5";
            // 
            // dataColumn57
            // 
            this.dataColumn57.ColumnName = "ChairmanPostSpecial";
            // 
            // dataColumn58
            // 
            this.dataColumn58.ColumnName = "isMemberComissionSpecial5";
            this.dataColumn58.DataType = typeof(bool);
            // 
            // dataColumn59
            // 
            this.dataColumn59.ColumnName = "isMemberComissionSpecial4";
            this.dataColumn59.DataType = typeof(bool);
            // 
            // dataColumn60
            // 
            this.dataColumn60.ColumnName = "isMemberComissionSpecial3";
            this.dataColumn60.DataType = typeof(bool);
            // 
            // dataColumn61
            // 
            this.dataColumn61.ColumnName = "isMemberComissionSpecial2";
            this.dataColumn61.DataType = typeof(bool);
            // 
            // dataColumn62
            // 
            this.dataColumn62.ColumnName = "isMemberComissionSpecial1";
            this.dataColumn62.DataType = typeof(bool);
            // 
            // dataColumn63
            // 
            this.dataColumn63.ColumnName = "isChairmanSpecial";
            this.dataColumn63.DataType = typeof(bool);
            // 
            // dataTableVoltagePowerPlantConsumer
            // 
            this.dataTableVoltagePowerPlantConsumer.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn28,
            this.dataColumn29,
            this.dataColumn30,
            this.dataColumn31});
            this.dataTableVoltagePowerPlantConsumer.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Voltage"}, false)});
            this.dataTableVoltagePowerPlantConsumer.TableName = "dataTableVoltagePowerPlantConsumer";
            // 
            // dataColumn28
            // 
            this.dataColumn28.Caption = "Напряжение";
            this.dataColumn28.ColumnName = "Voltage";
            // 
            // dataColumn29
            // 
            this.dataColumn29.Caption = "I";
            this.dataColumn29.ColumnName = "cat1";
            this.dataColumn29.DataType = typeof(int);
            this.dataColumn29.DefaultValue = 0;
            // 
            // dataColumn30
            // 
            this.dataColumn30.Caption = "II";
            this.dataColumn30.ColumnName = "cat2";
            this.dataColumn30.DataType = typeof(int);
            this.dataColumn30.DefaultValue = 0;
            // 
            // dataColumn31
            // 
            this.dataColumn31.Caption = "III";
            this.dataColumn31.ColumnName = "cat3";
            this.dataColumn31.DataType = typeof(int);
            this.dataColumn31.DefaultValue = 0;
            // 
            // dataTableAnnex
            // 
            this.dataTableAnnex.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnName,
            this.dataColumnValue});
            this.dataTableAnnex.TableName = "dataTableAnnex";
            // 
            // dataColumnName
            // 
            this.dataColumnName.ColumnName = "Name";
            // 
            // dataColumnValue
            // 
            this.dataColumnValue.ColumnName = "Value";
            // 
            // dataTablePersonal
            // 
            this.dataTablePersonal.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn32,
            this.dataColumn33,
            this.dataColumn34,
            this.dataColumn35,
            this.dataColumn36,
            this.dataColumn37,
            this.dataColumn38,
            this.dataColumn39,
            this.dataColumn40,
            this.dataColumn41,
            this.dataColumn42,
            this.dataColumn43,
            this.dataColumn44,
            this.dataColumn45});
            this.dataTablePersonal.TableName = "dataTablePersonal";
            // 
            // dataColumn32
            // 
            this.dataColumn32.ColumnName = "idPersonal";
            this.dataColumn32.DataType = typeof(int);
            // 
            // dataColumn33
            // 
            this.dataColumn33.ColumnName = "idPlaceWork";
            this.dataColumn33.DataType = typeof(int);
            this.dataColumn33.DefaultValue = -1;
            // 
            // dataColumn34
            // 
            this.dataColumn34.ColumnName = "idSpecialty";
            this.dataColumn34.DataType = typeof(int);
            this.dataColumn34.DefaultValue = -1;
            // 
            // dataColumn35
            // 
            this.dataColumn35.ColumnName = "idEducation";
            this.dataColumn35.DataType = typeof(int);
            this.dataColumn35.DefaultValue = -1;
            // 
            // dataColumn36
            // 
            this.dataColumn36.ColumnName = "idFunction";
            this.dataColumn36.DataType = typeof(int);
            this.dataColumn36.DefaultValue = -1;
            // 
            // dataColumn37
            // 
            this.dataColumn37.ColumnName = "CircumstancesError";
            // 
            // dataColumn38
            // 
            this.dataColumn38.ColumnName = "ReasonError";
            // 
            // dataColumn39
            // 
            this.dataColumn39.ColumnName = "DateLastCheck";
            this.dataColumn39.DataType = typeof(System.DateTime);
            // 
            // dataColumn40
            // 
            this.dataColumn40.ColumnName = "WorkExperience";
            this.dataColumn40.DataType = typeof(int);
            // 
            // dataColumn41
            // 
            this.dataColumn41.ColumnName = "Personal";
            // 
            // dataColumn42
            // 
            this.dataColumn42.ColumnName = "PlaceWork";
            // 
            // dataColumn43
            // 
            this.dataColumn43.ColumnName = "Function";
            // 
            // dataColumn44
            // 
            this.dataColumn44.ColumnName = "Education";
            // 
            // dataColumn45
            // 
            this.dataColumn45.ColumnName = "Specialty";
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGeneral.Controls.Add(this.label83);
            this.groupBoxGeneral.Controls.Add(this.label82);
            this.groupBoxGeneral.Controls.Add(this.cmbOrgCrash);
            this.groupBoxGeneral.Controls.Add(this.cmbOrgCrashEq);
            this.groupBoxGeneral.Controls.Add(this.dtpBeginCrashMoscow);
            this.groupBoxGeneral.Controls.Add(this.btnRefrshDateEndCrash);
            this.groupBoxGeneral.Controls.Add(this.btnRefreshDateDoc);
            this.groupBoxGeneral.Controls.Add(this.dtpEndCrashMoscow);
            this.groupBoxGeneral.Controls.Add(this.dtpEndCrashLocal);
            this.groupBoxGeneral.Controls.Add(this.label17);
            this.groupBoxGeneral.Controls.Add(this.label16);
            this.groupBoxGeneral.Controls.Add(this.label15);
            this.groupBoxGeneral.Controls.Add(this.cmbReasonCrash);
            this.groupBoxGeneral.Controls.Add(this.label14);
            this.groupBoxGeneral.Controls.Add(this.cmbReasonCrashEquipment);
            this.groupBoxGeneral.Controls.Add(this.label13);
            this.groupBoxGeneral.Controls.Add(this.cmbTypeEquipment);
            this.groupBoxGeneral.Controls.Add(this.label12);
            this.groupBoxGeneral.Controls.Add(this.cmbSignCrash);
            this.groupBoxGeneral.Controls.Add(this.label11);
            this.groupBoxGeneral.Controls.Add(this.label10);
            this.groupBoxGeneral.Controls.Add(this.cmbOrg);
            this.groupBoxGeneral.Controls.Add(this.chkNoOff);
            this.groupBoxGeneral.Controls.Add(this.dtpDateDoc);
            this.groupBoxGeneral.Controls.Add(this.label81);
            this.groupBoxGeneral.Controls.Add(this.label7);
            this.groupBoxGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGeneral.Location = new System.Drawing.Point(0, 44);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(776, 299);
            this.groupBoxGeneral.TabIndex = 3;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "1. Общие сведения";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label83.Location = new System.Drawing.Point(499, 199);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(74, 13);
            this.label83.TabIndex = 24;
            this.label83.Text = "Организация";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label82.Location = new System.Drawing.Point(499, 159);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(74, 13);
            this.label82.TabIndex = 23;
            this.label82.Text = "Организация";
            // 
            // cmbOrgCrash
            // 
            this.cmbOrgCrash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrgCrash.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOrgCrash.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrgCrash.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idOrgCrash", true));
            this.cmbOrgCrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbOrgCrash.FormattingEnabled = true;
            this.cmbOrgCrash.Location = new System.Drawing.Point(495, 215);
            this.cmbOrgCrash.Name = "cmbOrgCrash";
            this.cmbOrgCrash.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbOrgCrash.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbOrgCrash.Size = new System.Drawing.Size(275, 21);
            this.cmbOrgCrash.TabIndex = 22;
            // 
            // cmbOrgCrashEq
            // 
            this.cmbOrgCrashEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrgCrashEq.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOrgCrashEq.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrgCrashEq.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idOrgCrashEq", true));
            this.cmbOrgCrashEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbOrgCrashEq.FormattingEnabled = true;
            this.cmbOrgCrashEq.Location = new System.Drawing.Point(495, 175);
            this.cmbOrgCrashEq.Name = "cmbOrgCrashEq";
            this.cmbOrgCrashEq.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbOrgCrashEq.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbOrgCrashEq.Size = new System.Drawing.Size(275, 21);
            this.cmbOrgCrashEq.TabIndex = 21;
            // 
            // dtpBeginCrashMoscow
            // 
            this.dtpBeginCrashMoscow.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpBeginCrashMoscow.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_DamageActDetection.dateBeginCrashMoscow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpBeginCrashMoscow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBeginCrashMoscow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeginCrashMoscow.Location = new System.Drawing.Point(530, 18);
            this.dtpBeginCrashMoscow.Name = "dtpBeginCrashMoscow";
            this.dtpBeginCrashMoscow.Size = new System.Drawing.Size(136, 20);
            this.dtpBeginCrashMoscow.TabIndex = 20;
            this.dtpBeginCrashMoscow.Value = new System.DateTime(2016, 3, 28, 16, 32, 55, 541);
            // 
            // btnRefrshDateEndCrash
            // 
            this.btnRefrshDateEndCrash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrshDateEndCrash.BackgroundImage = global::DailyReportN.Properties.Resources.refresh_16;
            this.btnRefrshDateEndCrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefrshDateEndCrash.Location = new System.Drawing.Point(745, 244);
            this.btnRefrshDateEndCrash.Name = "btnRefrshDateEndCrash";
            this.btnRefrshDateEndCrash.Size = new System.Drawing.Size(20, 20);
            this.btnRefrshDateEndCrash.TabIndex = 19;
            this.btnRefrshDateEndCrash.UseVisualStyleBackColor = true;
            this.btnRefrshDateEndCrash.Click += new System.EventHandler(this.btnRefreshDateEndCrash_Click);
            // 
            // btnRefreshDateDoc
            // 
            this.btnRefreshDateDoc.BackgroundImage = global::DailyReportN.Properties.Resources.refresh_16;
            this.btnRefreshDateDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshDateDoc.Location = new System.Drawing.Point(342, 19);
            this.btnRefreshDateDoc.Name = "btnRefreshDateDoc";
            this.btnRefreshDateDoc.Size = new System.Drawing.Size(20, 20);
            this.btnRefreshDateDoc.TabIndex = 18;
            this.btnRefreshDateDoc.UseVisualStyleBackColor = true;
            this.btnRefreshDateDoc.Click += new System.EventHandler(this.btnRefreshDateDoc_Click);
            // 
            // dtpEndCrashMoscow
            // 
            this.dtpEndCrashMoscow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndCrashMoscow.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpEndCrashMoscow.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_DamageActDetection.dateEndCrashMoscow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpEndCrashMoscow.Enabled = false;
            this.dtpEndCrashMoscow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEndCrashMoscow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndCrashMoscow.Location = new System.Drawing.Point(228, 270);
            this.dtpEndCrashMoscow.Name = "dtpEndCrashMoscow";
            this.dtpEndCrashMoscow.Size = new System.Drawing.Size(514, 20);
            this.dtpEndCrashMoscow.TabIndex = 17;
            this.dtpEndCrashMoscow.Value = new System.DateTime(2016, 3, 28, 16, 32, 55, 541);
            // 
            // dtpEndCrashLocal
            // 
            this.dtpEndCrashLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndCrashLocal.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpEndCrashLocal.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_DamageActDetection.dateEndCrashLocal", true));
            this.dtpEndCrashLocal.Enabled = false;
            this.dtpEndCrashLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEndCrashLocal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndCrashLocal.Location = new System.Drawing.Point(228, 244);
            this.dtpEndCrashLocal.Name = "dtpEndCrashLocal";
            this.dtpEndCrashLocal.Size = new System.Drawing.Size(514, 20);
            this.dtpEndCrashLocal.TabIndex = 16;
            this.dtpEndCrashLocal.Value = new System.DateTime(2016, 3, 28, 16, 32, 55, 541);
            this.dtpEndCrashLocal.ValueChanged += new System.EventHandler(this.dtpEndCrashLocal_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(142, 276);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "(московского)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(161, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "(местного)";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(8, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 53);
            this.label15.TabIndex = 13;
            this.label15.Text = "Дата и время ликвидации аварийного режима";
            // 
            // cmbReasonCrash
            // 
            this.cmbReasonCrash.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbReasonCrash.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReasonCrash.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idReasonCrash", true));
            this.cmbReasonCrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbReasonCrash.FormattingEnabled = true;
            this.cmbReasonCrash.Location = new System.Drawing.Point(11, 215);
            this.cmbReasonCrash.Name = "cmbReasonCrash";
            this.cmbReasonCrash.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbReasonCrash.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbReasonCrash.Size = new System.Drawing.Size(466, 21);
            this.cmbReasonCrash.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(8, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(258, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Классификация организационных причин аварии";
            // 
            // cmbReasonCrashEquipment
            // 
            this.cmbReasonCrashEquipment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbReasonCrashEquipment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReasonCrashEquipment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idReasonCrashEquipment", true));
            this.cmbReasonCrashEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbReasonCrashEquipment.FormattingEnabled = true;
            this.cmbReasonCrashEquipment.Location = new System.Drawing.Point(11, 175);
            this.cmbReasonCrashEquipment.Name = "cmbReasonCrashEquipment";
            this.cmbReasonCrashEquipment.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbReasonCrashEquipment.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbReasonCrashEquipment.Size = new System.Drawing.Size(466, 21);
            this.cmbReasonCrashEquipment.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(336, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Классификация технических причин повреждений оборудования";
            // 
            // cmbTypeEquipment
            // 
            this.cmbTypeEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTypeEquipment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTypeEquipment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTypeEquipment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idTypeEquipment", true));
            this.cmbTypeEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTypeEquipment.FormattingEnabled = true;
            this.cmbTypeEquipment.Location = new System.Drawing.Point(11, 135);
            this.cmbTypeEquipment.Name = "cmbTypeEquipment";
            this.cmbTypeEquipment.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbTypeEquipment.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbTypeEquipment.Size = new System.Drawing.Size(759, 21);
            this.cmbTypeEquipment.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Классификация видов оборудования";
            // 
            // cmbSignCrash
            // 
            this.cmbSignCrash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSignCrash.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSignCrash.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSignCrash.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idSignCrash", true));
            this.cmbSignCrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSignCrash.FormattingEnabled = true;
            this.cmbSignCrash.Location = new System.Drawing.Point(11, 95);
            this.cmbSignCrash.Name = "cmbSignCrash";
            this.cmbSignCrash.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbSignCrash.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbSignCrash.Size = new System.Drawing.Size(759, 21);
            this.cmbSignCrash.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Учетные признаки аварии";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Организация";
            // 
            // cmbOrg
            // 
            this.cmbOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOrg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrg.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idOrg", true));
            this.cmbOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbOrg.FormattingEnabled = true;
            this.cmbOrg.Location = new System.Drawing.Point(114, 51);
            this.cmbOrg.Name = "cmbOrg";
            this.cmbOrg.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbOrg.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbOrg.Size = new System.Drawing.Size(656, 21);
            this.cmbOrg.TabIndex = 3;
            // 
            // chkNoOff
            // 
            this.chkNoOff.AutoSize = true;
            this.chkNoOff.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetDamage, "tJ_DamageActDetection.isNoOff", true));
            this.chkNoOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNoOff.Location = new System.Drawing.Point(363, 21);
            this.chkNoOff.Name = "chkNoOff";
            this.chkNoOff.Size = new System.Drawing.Size(73, 17);
            this.chkNoOff.TabIndex = 2;
            this.chkNoOff.Text = "без откл.";
            this.chkNoOff.UseVisualStyleBackColor = true;
            // 
            // dtpDateDoc
            // 
            this.dtpDateDoc.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateDoc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Damage.DateDoc", true));
            this.dtpDateDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateDoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDoc.Location = new System.Drawing.Point(192, 19);
            this.dtpDateDoc.Name = "dtpDateDoc";
            this.dtpDateDoc.Size = new System.Drawing.Size(144, 20);
            this.dtpDateDoc.TabIndex = 1;
            this.dtpDateDoc.Value = new System.DateTime(2016, 3, 28, 16, 32, 55, 541);
            this.dtpDateDoc.ValueChanged += new System.EventHandler(this.dtpDateDoc_ValueChanged);
            // 
            // label81
            // 
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label81.Location = new System.Drawing.Point(442, 19);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(122, 22);
            this.label81.TabIndex = 0;
            this.label81.Text = "(московское)";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Дата и время возникновения события (местное)";
            // 
            // buttonChooseParentDamage
            // 
            this.buttonChooseParentDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseParentDamage.Location = new System.Drawing.Point(684, 12);
            this.buttonChooseParentDamage.Name = "buttonChooseParentDamage";
            this.buttonChooseParentDamage.Size = new System.Drawing.Size(26, 23);
            this.buttonChooseParentDamage.TabIndex = 2;
            this.buttonChooseParentDamage.Text = "...";
            this.buttonChooseParentDamage.UseVisualStyleBackColor = true;
            this.buttonChooseParentDamage.Click += new System.EventHandler(this.btnChooseParentDamage_Click);
            // 
            // txtParentDamage
            // 
            this.txtParentDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentDamage.BackColor = System.Drawing.SystemColors.Window;
            this.txtParentDamage.Location = new System.Drawing.Point(130, 12);
            this.txtParentDamage.Name = "txtParentDamage";
            this.txtParentDamage.ReadOnly = true;
            this.txtParentDamage.Size = new System.Drawing.Size(548, 20);
            this.txtParentDamage.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Документ аварийного события";
            // 
            // chkCrash
            // 
            this.chkCrash.AutoSize = true;
            this.chkCrash.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetDamage, "tJ_DamageActDetection.isCrash", true));
            this.chkCrash.Location = new System.Drawing.Point(584, 36);
            this.chkCrash.Name = "chkCrash";
            this.chkCrash.Size = new System.Drawing.Size(63, 17);
            this.chkCrash.TabIndex = 10;
            this.chkCrash.Text = "Авария";
            this.chkCrash.UseVisualStyleBackColor = true;
            this.chkCrash.CheckedChanged += new System.EventHandler(this.chkCrash_CheckedChanged);
            // 
            // cmbDivision
            // 
            this.cmbDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDivision.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivision", true));
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(390, 34);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbDivision.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDivision.Size = new System.Drawing.Size(174, 21);
            this.cmbDivision.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сетевой район";
            // 
            // cmbCompiler
            // 
            this.cmbCompiler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCompiler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompiler.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompiler", true));
            this.cmbCompiler.FormattingEnabled = true;
            this.cmbCompiler.Location = new System.Drawing.Point(114, 32);
            this.cmbCompiler.Name = "cmbCompiler";
            this.cmbCompiler.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbCompiler.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCompiler.Size = new System.Drawing.Size(166, 21);
            this.cmbCompiler.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ответственный за оформление акта";
            // 
            // dtpDateOwner
            // 
            this.dtpDateOwner.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateOwner.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Damage.DateOwner", true));
            this.dtpDateOwner.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOwner.Location = new System.Drawing.Point(615, 6);
            this.dtpDateOwner.Name = "dtpDateOwner";
            this.dtpDateOwner.Size = new System.Drawing.Size(153, 20);
            this.dtpDateOwner.TabIndex = 5;
            this.dtpDateOwner.CloseUp += new System.EventHandler(this.dtpDateOwner_CloseUp);
            this.dtpDateOwner.ValueChanged += new System.EventHandler(this.dtpDateOwner_ValueChanged);
            this.dtpDateOwner.Leave += new System.EventHandler(this.dtpDateOwner_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата создания акта";
            // 
            // txtOwner
            // 
            this.txtOwner.BackColor = System.Drawing.SystemColors.Window;
            this.txtOwner.Location = new System.Drawing.Point(286, 6);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(207, 20);
            this.txtOwner.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Автор акта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер акта";
            // 
            // txtNumRequest
            // 
            this.txtNumRequest.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumRequest.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_Damage.NumRequest", true));
            this.txtNumRequest.Location = new System.Drawing.Point(114, 6);
            this.txtNumRequest.Name = "txtNumRequest";
            this.txtNumRequest.ReadOnly = true;
            this.txtNumRequest.Size = new System.Drawing.Size(80, 20);
            this.txtNumRequest.TabIndex = 0;
            // 
            // tabPageDescription
            // 
            this.tabPageDescription.Controls.Add(this.groupBoxDescription);
            this.tabPageDescription.Location = new System.Drawing.Point(4, 22);
            this.tabPageDescription.Name = "tabPageDescription";
            this.tabPageDescription.Size = new System.Drawing.Size(776, 541);
            this.tabPageDescription.TabIndex = 4;
            this.tabPageDescription.Text = "Описательный блок";
            this.tabPageDescription.UseVisualStyleBackColor = true;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.txtStatusBeforeCrash);
            this.groupBoxDescription.Controls.Add(this.txtFault);
            this.groupBoxDescription.Controls.Add(this.txtClassifierDamage);
            this.groupBoxDescription.Controls.Add(this.txtReasonBeginCrash);
            this.groupBoxDescription.Controls.Add(this.txtStatusCurrentCrash);
            this.groupBoxDescription.Controls.Add(this.cmbFault);
            this.groupBoxDescription.Controls.Add(this.label22);
            this.groupBoxDescription.Controls.Add(this.cmbClassifierDamage);
            this.groupBoxDescription.Controls.Add(this.label21);
            this.groupBoxDescription.Controls.Add(this.cmbReasonBeginCrash);
            this.groupBoxDescription.Controls.Add(this.label20);
            this.groupBoxDescription.Controls.Add(this.dgvDefection);
            this.groupBoxDescription.Controls.Add(this.label19);
            this.groupBoxDescription.Controls.Add(this.cmbStatusCurrentCrash);
            this.groupBoxDescription.Controls.Add(this.label18);
            this.groupBoxDescription.Controls.Add(this.cmbStatusBeforeCrash);
            this.groupBoxDescription.Controls.Add(this.txtSchmObj);
            this.groupBoxDescription.Controls.Add(this.label9);
            this.groupBoxDescription.Controls.Add(this.label8);
            this.groupBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDescription.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(776, 541);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "2. Описательный блок";
            // 
            // txtStatusBeforeCrash
            // 
            this.txtStatusBeforeCrash.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.StatusBeforeCrash", true));
            this.txtStatusBeforeCrash.Location = new System.Drawing.Point(9, 70);
            this.txtStatusBeforeCrash.Name = "txtStatusBeforeCrash";
            this.txtStatusBeforeCrash.Size = new System.Drawing.Size(757, 25);
            this.txtStatusBeforeCrash.TabIndex = 28;
            this.txtStatusBeforeCrash.Text = "";
            // 
            // txtFault
            // 
            this.txtFault.AcceptsTab = true;
            this.txtFault.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFault.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.Fault", true));
            this.txtFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtFault.Location = new System.Drawing.Point(8, 500);
            this.txtFault.Name = "txtFault";
            this.txtFault.Size = new System.Drawing.Size(758, 38);
            this.txtFault.TabIndex = 27;
            this.txtFault.Text = "";
            // 
            // txtClassifierDamage
            // 
            this.txtClassifierDamage.AcceptsTab = true;
            this.txtClassifierDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassifierDamage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.ClassifierDamage", true));
            this.txtClassifierDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtClassifierDamage.Location = new System.Drawing.Point(7, 408);
            this.txtClassifierDamage.Name = "txtClassifierDamage";
            this.txtClassifierDamage.Size = new System.Drawing.Size(758, 41);
            this.txtClassifierDamage.TabIndex = 26;
            this.txtClassifierDamage.Text = "";
            // 
            // txtReasonBeginCrash
            // 
            this.txtReasonBeginCrash.AcceptsTab = true;
            this.txtReasonBeginCrash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReasonBeginCrash.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.ReasonBeginCrash", true));
            this.txtReasonBeginCrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtReasonBeginCrash.Location = new System.Drawing.Point(8, 321);
            this.txtReasonBeginCrash.Name = "txtReasonBeginCrash";
            this.txtReasonBeginCrash.Size = new System.Drawing.Size(758, 47);
            this.txtReasonBeginCrash.TabIndex = 25;
            this.txtReasonBeginCrash.Text = "";
            // 
            // txtStatusCurrentCrash
            // 
            this.txtStatusCurrentCrash.AcceptsTab = true;
            this.txtStatusCurrentCrash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusCurrentCrash.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.StatusCurrentCrash", true));
            this.txtStatusCurrentCrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtStatusCurrentCrash.Location = new System.Drawing.Point(9, 136);
            this.txtStatusCurrentCrash.Name = "txtStatusCurrentCrash";
            this.txtStatusCurrentCrash.Size = new System.Drawing.Size(757, 44);
            this.txtStatusCurrentCrash.TabIndex = 24;
            this.txtStatusCurrentCrash.Text = "";
            // 
            // cmbFault
            // 
            this.cmbFault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFault.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFault.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFault.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idFault", true));
            this.cmbFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFault.FormattingEnabled = true;
            this.cmbFault.Location = new System.Drawing.Point(9, 481);
            this.cmbFault.Name = "cmbFault";
            this.cmbFault.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbFault.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbFault.Size = new System.Drawing.Size(757, 21);
            this.cmbFault.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(9, 450);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(755, 28);
            this.label22.TabIndex = 22;
            this.label22.Text = resources.GetString("label22.Text");
            // 
            // cmbClassifierDamage
            // 
            this.cmbClassifierDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClassifierDamage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClassifierDamage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClassifierDamage.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idClassifierDamage", true));
            this.cmbClassifierDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbClassifierDamage.FormattingEnabled = true;
            this.cmbClassifierDamage.Location = new System.Drawing.Point(8, 385);
            this.cmbClassifierDamage.Name = "cmbClassifierDamage";
            this.cmbClassifierDamage.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbClassifierDamage.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbClassifierDamage.Size = new System.Drawing.Size(757, 21);
            this.cmbClassifierDamage.TabIndex = 21;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(4, 370);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(587, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Перечень и описание повреждения оборудования объектов электроэнергетики и энергоп" +
    "ринимающих устройств";
            // 
            // cmbReasonBeginCrash
            // 
            this.cmbReasonBeginCrash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReasonBeginCrash.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbReasonBeginCrash.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReasonBeginCrash.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idReasonBeginCrash", true));
            this.cmbReasonBeginCrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbReasonBeginCrash.FormattingEnabled = true;
            this.cmbReasonBeginCrash.Location = new System.Drawing.Point(252, 298);
            this.cmbReasonBeginCrash.Name = "cmbReasonBeginCrash";
            this.cmbReasonBeginCrash.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbReasonBeginCrash.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbReasonBeginCrash.Size = new System.Drawing.Size(512, 21);
            this.cmbReasonBeginCrash.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(6, 302);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(246, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Причины возникновения аварии и ее развития";
            // 
            // dgvDefection
            // 
            this.dgvDefection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDefection.AutoGenerateColumns = false;
            this.dgvDefection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDefectionDataGridViewTextBoxColumn,
            this.idNPADgvColumn,
            this.punctNPADataGridViewTextBoxColumn,
            this.idOrgDefectionDgvColumn});
            this.dgvDefection.DataSource = this.bsDefection;
            this.dgvDefection.Location = new System.Drawing.Point(0, 210);
            this.dgvDefection.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDefection.Name = "dgvDefection";
            this.dgvDefection.RowHeadersWidth = 22;
            this.dgvDefection.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvDefection.RowTemplate.Height = 24;
            this.dgvDefection.Size = new System.Drawing.Size(777, 86);
            this.dgvDefection.TabIndex = 17;
            this.dgvDefection.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // idDefectionDataGridViewTextBoxColumn
            // 
            this.idDefectionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDefectionDataGridViewTextBoxColumn.DataPropertyName = "idDefection";
            this.idDefectionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idDefectionDataGridViewTextBoxColumn.FillWeight = 103.6082F;
            this.idDefectionDataGridViewTextBoxColumn.HeaderText = "Описание нарушения";
            this.idDefectionDataGridViewTextBoxColumn.Name = "idDefectionDataGridViewTextBoxColumn";
            this.idDefectionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idNPADgvColumn
            // 
            this.idNPADgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idNPADgvColumn.DataPropertyName = "idNPA";
            this.idNPADgvColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idNPADgvColumn.HeaderText = "Наименование НПА (НТД)";
            this.idNPADgvColumn.Name = "idNPADgvColumn";
            this.idNPADgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idNPADgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // punctNPADataGridViewTextBoxColumn
            // 
            this.punctNPADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.punctNPADataGridViewTextBoxColumn.DataPropertyName = "punctNPA";
            this.punctNPADataGridViewTextBoxColumn.FillWeight = 50F;
            this.punctNPADataGridViewTextBoxColumn.HeaderText = "Пункт НПА (НТД)";
            this.punctNPADataGridViewTextBoxColumn.Name = "punctNPADataGridViewTextBoxColumn";
            // 
            // idOrgDefectionDgvColumn
            // 
            this.idOrgDefectionDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idOrgDefectionDgvColumn.DataPropertyName = "idOrg";
            this.idOrgDefectionDgvColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idOrgDefectionDgvColumn.FillWeight = 103.6082F;
            this.idOrgDefectionDgvColumn.HeaderText = "Организация";
            this.idOrgDefectionDgvColumn.Name = "idOrgDefectionDgvColumn";
            this.idOrgDefectionDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bsDefection
            // 
            this.bsDefection.DataMember = "dtDefection";
            this.bsDefection.DataSource = this.dataSetCrash;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(6, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(759, 39);
            this.label19.TabIndex = 16;
            this.label19.Text = resources.GetString("label19.Text");
            // 
            // cmbStatusCurrentCrash
            // 
            this.cmbStatusCurrentCrash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatusCurrentCrash.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatusCurrentCrash.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatusCurrentCrash.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idStatusCurrentCrash", true));
            this.cmbStatusCurrentCrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStatusCurrentCrash.FormattingEnabled = true;
            this.cmbStatusCurrentCrash.Location = new System.Drawing.Point(9, 114);
            this.cmbStatusCurrentCrash.Name = "cmbStatusCurrentCrash";
            this.cmbStatusCurrentCrash.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbStatusCurrentCrash.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbStatusCurrentCrash.Size = new System.Drawing.Size(756, 21);
            this.cmbStatusCurrentCrash.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(9, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(648, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Описание состояния и режима работы объектов электроэнергетики и (или) энергоприни" +
    "мающих установок во время аварии";
            // 
            // cmbStatusBeforeCrash
            // 
            this.cmbStatusBeforeCrash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatusBeforeCrash.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatusBeforeCrash.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatusBeforeCrash.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idStatusBeforeCrash", true));
            this.cmbStatusBeforeCrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStatusBeforeCrash.FormattingEnabled = true;
            this.cmbStatusBeforeCrash.Location = new System.Drawing.Point(9, 48);
            this.cmbStatusBeforeCrash.Name = "cmbStatusBeforeCrash";
            this.cmbStatusBeforeCrash.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbStatusBeforeCrash.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbStatusBeforeCrash.Size = new System.Drawing.Size(757, 21);
            this.cmbStatusBeforeCrash.TabIndex = 13;
            // 
            // txtSchmObj
            // 
            this.txtSchmObj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSchmObj.BackColor = System.Drawing.SystemColors.Window;
            this.txtSchmObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSchmObj.Location = new System.Drawing.Point(56, 28);
            this.txtSchmObj.Name = "txtSchmObj";
            this.txtSchmObj.ReadOnly = true;
            this.txtSchmObj.Size = new System.Drawing.Size(710, 20);
            this.txtSchmObj.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Объект";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(694, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Описание состояния и режима работы объектов электроэнергетики и (или) энергоприни" +
    "мающих установок до возникновения аварии";
            // 
            // tabPageSchm
            // 
            this.tabPageSchm.Controls.Add(this.splitContainer2);
            this.tabPageSchm.Controls.Add(this.dgvEquipment);
            this.tabPageSchm.Controls.Add(this.toolStripEquipment);
            this.tabPageSchm.Controls.Add(this.label23);
            this.tabPageSchm.Location = new System.Drawing.Point(4, 22);
            this.tabPageSchm.Name = "tabPageSchm";
            this.tabPageSchm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchm.Size = new System.Drawing.Size(776, 541);
            this.tabPageSchm.TabIndex = 1;
            this.tabPageSchm.Text = "Оборудование";
            this.tabPageSchm.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(3, 153);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtNodeDetail);
            this.splitContainer2.Panel1.Controls.Add(this.label37);
            this.splitContainer2.Panel1.Controls.Add(this.cmbMaterial);
            this.splitContainer2.Panel1.Controls.Add(this.label36);
            this.splitContainer2.Panel1.Controls.Add(this.txtLenghtLine);
            this.splitContainer2.Panel1.Controls.Add(this.chkAutoProtect);
            this.splitContainer2.Panel1.Controls.Add(this.label35);
            this.splitContainer2.Panel1.Controls.Add(this.cmbMarkEquipment);
            this.splitContainer2.Panel1.Controls.Add(this.txtLengthOverload);
            this.splitContainer2.Panel1.Controls.Add(this.cmbParameters);
            this.splitContainer2.Panel1.Controls.Add(this.label34);
            this.splitContainer2.Panel1.Controls.Add(this.label24);
            this.splitContainer2.Panel1.Controls.Add(this.txtClauseFail);
            this.splitContainer2.Panel1.Controls.Add(this.label25);
            this.splitContainer2.Panel1.Controls.Add(this.label33);
            this.splitContainer2.Panel1.Controls.Add(this.cmbVoltage);
            this.splitContainer2.Panel1.Controls.Add(this.cmbNeutralState);
            this.splitContainer2.Panel1.Controls.Add(this.label26);
            this.splitContainer2.Panel1.Controls.Add(this.label32);
            this.splitContainer2.Panel1.Controls.Add(this.cmbNodeDetail);
            this.splitContainer2.Panel1.Controls.Add(this.txtYearManufature);
            this.splitContainer2.Panel1.Controls.Add(this.label27);
            this.splitContainer2.Panel1.Controls.Add(this.label31);
            this.splitContainer2.Panel1.Controls.Add(this.cmbVoltageSeti);
            this.splitContainer2.Panel1.Controls.Add(this.txtFactoryNumber);
            this.splitContainer2.Panel1.Controls.Add(this.label28);
            this.splitContainer2.Panel1.Controls.Add(this.label30);
            this.splitContainer2.Panel1.Controls.Add(this.txtCountDefectEquipment);
            this.splitContainer2.Panel1.Controls.Add(this.txtManufacturer);
            this.splitContainer2.Panel1.Controls.Add(this.label29);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label38);
            this.splitContainer2.Panel2.Controls.Add(this.cmbClauseWork);
            this.splitContainer2.Panel2.Controls.Add(this.label45);
            this.splitContainer2.Panel2.Controls.Add(this.dtpTimeRecovery);
            this.splitContainer2.Panel2.Controls.Add(this.label44);
            this.splitContainer2.Panel2.Controls.Add(this.label43);
            this.splitContainer2.Panel2.Controls.Add(this.txtLengthWorkEquipment);
            this.splitContainer2.Panel2.Controls.Add(this.label42);
            this.splitContainer2.Panel2.Controls.Add(this.txtYearBegEquipment);
            this.splitContainer2.Panel2.Controls.Add(this.label41);
            this.splitContainer2.Panel2.Controls.Add(this.txtAssociatedFact);
            this.splitContainer2.Panel2.Controls.Add(this.label40);
            this.splitContainer2.Panel2.Controls.Add(this.cmbReasonDamage);
            this.splitContainer2.Panel2.Controls.Add(this.label39);
            this.splitContainer2.Panel2.Controls.Add(this.cmbCharacterDamage);
            this.splitContainer2.Panel2.Controls.Add(this.dtpLastDateTest);
            this.splitContainer2.Size = new System.Drawing.Size(773, 394);
            this.splitContainer2.SplitterDistance = 346;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 28;
            // 
            // txtNodeDetail
            // 
            this.txtNodeDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeDetail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDamageCharacter, "nodeDetailTxt", true));
            this.txtNodeDetail.Location = new System.Drawing.Point(127, 121);
            this.txtNodeDetail.Name = "txtNodeDetail";
            this.txtNodeDetail.Size = new System.Drawing.Size(207, 20);
            this.txtNodeDetail.TabIndex = 32;
            // 
            // bsDamageCharacter
            // 
            this.bsDamageCharacter.DataMember = "tJ_DamageCharacter";
            this.bsDamageCharacter.DataSource = this.dataSetDamage;
            this.bsDamageCharacter.CurrentChanged += new System.EventHandler(this.bsDamageCharacter_CurrentChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(11, 362);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(57, 13);
            this.label37.TabIndex = 31;
            this.label37.Text = "Материал";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaterial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDamageCharacter, "idMaterial", true));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(127, 359);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbMaterial.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbMaterial.Size = new System.Drawing.Size(207, 21);
            this.cmbMaterial.TabIndex = 30;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(11, 339);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(93, 13);
            this.label36.TabIndex = 29;
            this.label36.Text = "Длина КЛ, ВЛ, м";
            // 
            // txtLenghtLine
            // 
            this.txtLenghtLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLenghtLine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDamageCharacter, "LengthLine", true));
            this.txtLenghtLine.Location = new System.Drawing.Point(127, 337);
            this.txtLenghtLine.Margin = new System.Windows.Forms.Padding(2);
            this.txtLenghtLine.Name = "txtLenghtLine";
            this.txtLenghtLine.Size = new System.Drawing.Size(207, 20);
            this.txtLenghtLine.TabIndex = 28;
            // 
            // chkAutoProtect
            // 
            this.chkAutoProtect.AutoSize = true;
            this.chkAutoProtect.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsDamageCharacter, "AutoProtect", true));
            this.chkAutoProtect.Location = new System.Drawing.Point(14, 6);
            this.chkAutoProtect.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoProtect.Name = "chkAutoProtect";
            this.chkAutoProtect.Size = new System.Drawing.Size(151, 17);
            this.chkAutoProtect.TabIndex = 11;
            this.chkAutoProtect.Text = "Автоматическая защита";
            this.chkAutoProtect.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(11, 306);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(158, 29);
            this.label35.TabIndex = 27;
            this.label35.Text = "Продолжительность работы оборудования с перегрузкой";
            // 
            // cmbMarkEquipment
            // 
            this.cmbMarkEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMarkEquipment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMarkEquipment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMarkEquipment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDamageCharacter, "idMark", true));
            this.cmbMarkEquipment.FormattingEnabled = true;
            this.cmbMarkEquipment.Location = new System.Drawing.Point(127, 28);
            this.cmbMarkEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMarkEquipment.Name = "cmbMarkEquipment";
            this.cmbMarkEquipment.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbMarkEquipment.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbMarkEquipment.Size = new System.Drawing.Size(207, 21);
            this.cmbMarkEquipment.TabIndex = 3;
            // 
            // txtLengthOverload
            // 
            this.txtLengthOverload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLengthOverload.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDamageCharacter, "LengthOverload", true));
            this.txtLengthOverload.Location = new System.Drawing.Point(184, 314);
            this.txtLengthOverload.Margin = new System.Windows.Forms.Padding(2);
            this.txtLengthOverload.Name = "txtLengthOverload";
            this.txtLengthOverload.Size = new System.Drawing.Size(150, 20);
            this.txtLengthOverload.TabIndex = 26;
            // 
            // cmbParameters
            // 
            this.cmbParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbParameters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbParameters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParameters.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDamageCharacter, "idParameters", true));
            this.cmbParameters.FormattingEnabled = true;
            this.cmbParameters.Location = new System.Drawing.Point(127, 52);
            this.cmbParameters.Margin = new System.Windows.Forms.Padding(2);
            this.cmbParameters.Name = "cmbParameters";
            this.cmbParameters.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbParameters.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbParameters.Size = new System.Drawing.Size(207, 21);
            this.cmbParameters.TabIndex = 4;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(11, 286);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(163, 13);
            this.label34.TabIndex = 25;
            this.label34.Text = "Условия отказа оборудования";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 30);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "Марка";
            // 
            // txtClauseFail
            // 
            this.txtClauseFail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClauseFail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDamageCharacter, "ClauseFail", true));
            this.txtClauseFail.Location = new System.Drawing.Point(184, 284);
            this.txtClauseFail.Margin = new System.Windows.Forms.Padding(2);
            this.txtClauseFail.Name = "txtClauseFail";
            this.txtClauseFail.Size = new System.Drawing.Size(150, 20);
            this.txtClauseFail.TabIndex = 24;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(11, 54);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 13);
            this.label25.TabIndex = 6;
            this.label25.Text = "Параметры";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(11, 262);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(111, 13);
            this.label33.TabIndex = 23;
            this.label33.Text = "Состояние нейтрали";
            // 
            // cmbVoltage
            // 
            this.cmbVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVoltage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVoltage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVoltage.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDamageCharacter, "idVoltage", true));
            this.cmbVoltage.FormattingEnabled = true;
            this.cmbVoltage.Location = new System.Drawing.Point(166, 76);
            this.cmbVoltage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVoltage.Name = "cmbVoltage";
            this.cmbVoltage.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbVoltage.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbVoltage.Size = new System.Drawing.Size(168, 21);
            this.cmbVoltage.TabIndex = 7;
            // 
            // cmbNeutralState
            // 
            this.cmbNeutralState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNeutralState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNeutralState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNeutralState.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDamageCharacter, "idNeutralState", true));
            this.cmbNeutralState.FormattingEnabled = true;
            this.cmbNeutralState.Location = new System.Drawing.Point(127, 259);
            this.cmbNeutralState.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNeutralState.Name = "cmbNeutralState";
            this.cmbNeutralState.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbNeutralState.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbNeutralState.Size = new System.Drawing.Size(207, 21);
            this.cmbNeutralState.TabIndex = 22;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(11, 79);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(154, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Конструктивное напряжение";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(11, 239);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(172, 13);
            this.label32.TabIndex = 21;
            this.label32.Text = "Год изготовления оборудования";
            // 
            // cmbNodeDetail
            // 
            this.cmbNodeDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNodeDetail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNodeDetail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNodeDetail.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDamageCharacter, "nodeDetail", true));
            this.cmbNodeDetail.FormattingEnabled = true;
            this.cmbNodeDetail.Location = new System.Drawing.Point(127, 101);
            this.cmbNodeDetail.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNodeDetail.Name = "cmbNodeDetail";
            this.cmbNodeDetail.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbNodeDetail.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbNodeDetail.Size = new System.Drawing.Size(207, 21);
            this.cmbNodeDetail.TabIndex = 9;
            // 
            // txtYearManufature
            // 
            this.txtYearManufature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYearManufature.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDamageCharacter, "YearManufacture", true));
            this.txtYearManufature.Location = new System.Drawing.Point(184, 237);
            this.txtYearManufature.Margin = new System.Windows.Forms.Padding(2);
            this.txtYearManufature.Name = "txtYearManufature";
            this.txtYearManufature.Size = new System.Drawing.Size(150, 20);
            this.txtYearManufature.TabIndex = 20;
            this.txtYearManufature.Enter += new System.EventHandler(this.txtYearManufature_Enter);
            this.txtYearManufature.Leave += new System.EventHandler(this.txtYearManufature_Leave);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 103);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "Узел. деталь";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(11, 216);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(97, 13);
            this.label31.TabIndex = 19;
            this.label31.Text = "Заводской номер";
            // 
            // cmbVoltageSeti
            // 
            this.cmbVoltageSeti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVoltageSeti.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVoltageSeti.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVoltageSeti.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDamageCharacter, "idVoltageSeti", true));
            this.cmbVoltageSeti.FormattingEnabled = true;
            this.cmbVoltageSeti.Location = new System.Drawing.Point(166, 167);
            this.cmbVoltageSeti.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVoltageSeti.Name = "cmbVoltageSeti";
            this.cmbVoltageSeti.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbVoltageSeti.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbVoltageSeti.Size = new System.Drawing.Size(168, 21);
            this.cmbVoltageSeti.TabIndex = 12;
            // 
            // txtFactoryNumber
            // 
            this.txtFactoryNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFactoryNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDamageCharacter, "FactoryNumber", true));
            this.txtFactoryNumber.Location = new System.Drawing.Point(127, 214);
            this.txtFactoryNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtFactoryNumber.Name = "txtFactoryNumber";
            this.txtFactoryNumber.Size = new System.Drawing.Size(207, 20);
            this.txtFactoryNumber.TabIndex = 18;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(11, 169);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(97, 13);
            this.label28.TabIndex = 13;
            this.label28.Text = "Напряжение сети";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(11, 194);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(152, 13);
            this.label30.TabIndex = 17;
            this.label30.Text = "Изготовитель оборудования";
            // 
            // txtCountDefectEquipment
            // 
            this.txtCountDefectEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountDefectEquipment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDamageCharacter, "CountDefectEquipment", true));
            this.txtCountDefectEquipment.Location = new System.Drawing.Point(207, 144);
            this.txtCountDefectEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountDefectEquipment.Name = "txtCountDefectEquipment";
            this.txtCountDefectEquipment.Size = new System.Drawing.Size(127, 20);
            this.txtCountDefectEquipment.TabIndex = 14;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManufacturer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDamageCharacter, "Manufacturer", true));
            this.txtManufacturer.Location = new System.Drawing.Point(166, 191);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(2);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(168, 20);
            this.txtManufacturer.TabIndex = 16;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 147);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(184, 13);
            this.label29.TabIndex = 15;
            this.label29.Text = "Кол-во отказавшего оборудования";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(15, 30);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(91, 13);
            this.label38.TabIndex = 33;
            this.label38.Text = "Условия работы";
            // 
            // cmbClauseWork
            // 
            this.cmbClauseWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClauseWork.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClauseWork.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClauseWork.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDamageCharacter, "ClauseWork", true));
            this.cmbClauseWork.FormattingEnabled = true;
            this.cmbClauseWork.Location = new System.Drawing.Point(186, 27);
            this.cmbClauseWork.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClauseWork.Name = "cmbClauseWork";
            this.cmbClauseWork.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbClauseWork.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbClauseWork.Size = new System.Drawing.Size(226, 21);
            this.cmbClauseWork.TabIndex = 32;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(14, 147);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(119, 13);
            this.label45.TabIndex = 23;
            this.label45.Text = "Дата восстановления";
            // 
            // dtpTimeRecovery
            // 
            this.dtpTimeRecovery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTimeRecovery.CustomFormat = "HH:mm";
            this.dtpTimeRecovery.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDamageCharacter, "timeRecovery", true));
            this.dtpTimeRecovery.Location = new System.Drawing.Point(238, 143);
            this.dtpTimeRecovery.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeRecovery.Name = "dtpTimeRecovery";
            this.dtpTimeRecovery.Size = new System.Drawing.Size(174, 20);
            this.dtpTimeRecovery.TabIndex = 22;
            this.dtpTimeRecovery.Value = new System.DateTime(2016, 4, 12, 13, 47, 41, 144);
            this.dtpTimeRecovery.ValueChanged += new System.EventHandler(this.dtpTimeRecovery_ValueChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(14, 124);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(220, 13);
            this.label44.TabIndex = 21;
            this.label44.Text = "Последние эксплуатационные испытания";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(14, 100);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(182, 13);
            this.label43.TabIndex = 20;
            this.label43.Text = "Срок службы поврежденного узла";
            // 
            // txtLengthWorkEquipment
            // 
            this.txtLengthWorkEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLengthWorkEquipment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDamageCharacter, "lenghtWorkEquipment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLengthWorkEquipment.Location = new System.Drawing.Point(201, 98);
            this.txtLengthWorkEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.txtLengthWorkEquipment.Name = "txtLengthWorkEquipment";
            this.txtLengthWorkEquipment.Size = new System.Drawing.Size(211, 20);
            this.txtLengthWorkEquipment.TabIndex = 19;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(15, 77);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(117, 13);
            this.label42.TabIndex = 18;
            this.label42.Text = "Начало эксплуатации";
            // 
            // txtYearBegEquipment
            // 
            this.txtYearBegEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYearBegEquipment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDamageCharacter, "yearBegEquipment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtYearBegEquipment.Location = new System.Drawing.Point(186, 75);
            this.txtYearBegEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.txtYearBegEquipment.Name = "txtYearBegEquipment";
            this.txtYearBegEquipment.Size = new System.Drawing.Size(226, 20);
            this.txtYearBegEquipment.TabIndex = 17;
            this.txtYearBegEquipment.TextChanged += new System.EventHandler(this.txtYearBegEquipment_TextChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(15, 54);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(171, 13);
            this.label41.TabIndex = 16;
            this.label41.Text = "Сопутствующие обстоятельства";
            // 
            // txtAssociatedFact
            // 
            this.txtAssociatedFact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssociatedFact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDamageCharacter, "AssociatedFact", true));
            this.txtAssociatedFact.Location = new System.Drawing.Point(186, 52);
            this.txtAssociatedFact.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssociatedFact.Name = "txtAssociatedFact";
            this.txtAssociatedFact.Size = new System.Drawing.Size(226, 20);
            this.txtAssociatedFact.TabIndex = 15;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(15, 289);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(121, 13);
            this.label40.TabIndex = 8;
            this.label40.Text = "Причина повреждения";
            this.label40.Visible = false;
            // 
            // cmbReasonDamage
            // 
            this.cmbReasonDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReasonDamage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbReasonDamage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReasonDamage.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDamageCharacter, "idReasonDamage", true));
            this.cmbReasonDamage.FormattingEnabled = true;
            this.cmbReasonDamage.Location = new System.Drawing.Point(141, 287);
            this.cmbReasonDamage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbReasonDamage.Name = "cmbReasonDamage";
            this.cmbReasonDamage.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbReasonDamage.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbReasonDamage.Size = new System.Drawing.Size(239, 21);
            this.cmbReasonDamage.TabIndex = 7;
            this.cmbReasonDamage.Visible = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(15, 265);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(126, 13);
            this.label39.TabIndex = 6;
            this.label39.Text = "Характер повреждения";
            this.label39.Visible = false;
            // 
            // cmbCharacterDamage
            // 
            this.cmbCharacterDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCharacterDamage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCharacterDamage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCharacterDamage.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDamageCharacter, "idCharacterDamage", true));
            this.cmbCharacterDamage.FormattingEnabled = true;
            this.cmbCharacterDamage.Location = new System.Drawing.Point(141, 263);
            this.cmbCharacterDamage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCharacterDamage.Name = "cmbCharacterDamage";
            this.cmbCharacterDamage.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbCharacterDamage.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCharacterDamage.Size = new System.Drawing.Size(239, 21);
            this.cmbCharacterDamage.TabIndex = 4;
            this.cmbCharacterDamage.Visible = false;
            // 
            // dtpLastDateTest
            // 
            this.dtpLastDateTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpLastDateTest.CustomFormat = "yyyy г.";
            this.dtpLastDateTest.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDamageCharacter, "LastDateTest", true));
            this.dtpLastDateTest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastDateTest.Location = new System.Drawing.Point(238, 120);
            this.dtpLastDateTest.Margin = new System.Windows.Forms.Padding(2);
            this.dtpLastDateTest.MinDate = new System.DateTime(1913, 1, 1, 0, 0, 0, 0);
            this.dtpLastDateTest.Name = "dtpLastDateTest";
            this.dtpLastDateTest.ShowUpDown = true;
            this.dtpLastDateTest.Size = new System.Drawing.Size(174, 20);
            this.dtpLastDateTest.TabIndex = 0;
            this.dtpLastDateTest.Value = new System.DateTime(2016, 4, 12, 13, 47, 41, 144);
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.AllowUserToAddRows = false;
            this.dgvEquipment.AllowUserToDeleteRows = false;
            this.dgvEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipment.AutoGenerateColumns = false;
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeEquipmentDgvColumn,
            this.idDamCharacterDgvColumn,
            this.idSchmObjDgvColumn,
            this.idDamageDataGridViewTextBoxColumn,
            this.col2DataGridViewTextBoxColumn,
            this.col3DataGridViewTextBoxColumn,
            this.schmObjNameDgvColumn,
            this.schmObjDgvColumn});
            this.dgvEquipment.DataSource = this.bsDamageCharacter;
            this.dgvEquipment.Location = new System.Drawing.Point(3, 39);
            this.dgvEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.RowTemplate.Height = 24;
            this.dgvEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipment.Size = new System.Drawing.Size(773, 115);
            this.dgvEquipment.TabIndex = 2;
            this.dgvEquipment.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvEquipment_RowsAdded);
            // 
            // typeEquipmentDgvColumn
            // 
            this.typeEquipmentDgvColumn.DataPropertyName = "col1";
            this.typeEquipmentDgvColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.typeEquipmentDgvColumn.HeaderText = "Тип";
            this.typeEquipmentDgvColumn.Name = "typeEquipmentDgvColumn";
            this.typeEquipmentDgvColumn.ReadOnly = true;
            this.typeEquipmentDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeEquipmentDgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idDamCharacterDgvColumn
            // 
            this.idDamCharacterDgvColumn.DataPropertyName = "id";
            this.idDamCharacterDgvColumn.HeaderText = "id";
            this.idDamCharacterDgvColumn.Name = "idDamCharacterDgvColumn";
            this.idDamCharacterDgvColumn.ReadOnly = true;
            this.idDamCharacterDgvColumn.Visible = false;
            // 
            // idSchmObjDgvColumn
            // 
            this.idSchmObjDgvColumn.DataPropertyName = "idSchmObj";
            this.idSchmObjDgvColumn.HeaderText = "idSchmObj";
            this.idSchmObjDgvColumn.Name = "idSchmObjDgvColumn";
            this.idSchmObjDgvColumn.ReadOnly = true;
            this.idSchmObjDgvColumn.Visible = false;
            // 
            // idDamageDataGridViewTextBoxColumn
            // 
            this.idDamageDataGridViewTextBoxColumn.DataPropertyName = "idDamage";
            this.idDamageDataGridViewTextBoxColumn.HeaderText = "idDamage";
            this.idDamageDataGridViewTextBoxColumn.Name = "idDamageDataGridViewTextBoxColumn";
            this.idDamageDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDamageDataGridViewTextBoxColumn.Visible = false;
            // 
            // col2DataGridViewTextBoxColumn
            // 
            this.col2DataGridViewTextBoxColumn.DataPropertyName = "col2";
            this.col2DataGridViewTextBoxColumn.HeaderText = "col2";
            this.col2DataGridViewTextBoxColumn.Name = "col2DataGridViewTextBoxColumn";
            this.col2DataGridViewTextBoxColumn.ReadOnly = true;
            this.col2DataGridViewTextBoxColumn.Visible = false;
            // 
            // col3DataGridViewTextBoxColumn
            // 
            this.col3DataGridViewTextBoxColumn.DataPropertyName = "col3";
            this.col3DataGridViewTextBoxColumn.HeaderText = "col3";
            this.col3DataGridViewTextBoxColumn.Name = "col3DataGridViewTextBoxColumn";
            this.col3DataGridViewTextBoxColumn.ReadOnly = true;
            this.col3DataGridViewTextBoxColumn.Visible = false;
            // 
            // schmObjNameDgvColumn
            // 
            this.schmObjNameDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.schmObjNameDgvColumn.DataPropertyName = "SchmObjName";
            this.schmObjNameDgvColumn.HeaderText = "Примечание";
            this.schmObjNameDgvColumn.Name = "schmObjNameDgvColumn";
            // 
            // schmObjDgvColumn
            // 
            this.schmObjDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.schmObjDgvColumn.HeaderText = "Оборудование";
            this.schmObjDgvColumn.Name = "schmObjDgvColumn";
            this.schmObjDgvColumn.ReadOnly = true;
            // 
            // toolStripEquipment
            // 
            this.toolStripEquipment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEquipment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddEquipment,
            this.toolBtnDelEquipment,
            this.toolStripButton2});
            this.toolStripEquipment.Location = new System.Drawing.Point(3, 17);
            this.toolStripEquipment.Name = "toolStripEquipment";
            this.toolStripEquipment.Size = new System.Drawing.Size(770, 25);
            this.toolStripEquipment.TabIndex = 1;
            this.toolStripEquipment.Text = "toolStrip1";
            // 
            // toolBtnAddEquipment
            // 
            this.toolBtnAddEquipment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddEquipment.Image = global::DailyReportN.Properties.Resources.ElementAdd;
            this.toolBtnAddEquipment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddEquipment.Name = "toolBtnAddEquipment";
            this.toolBtnAddEquipment.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddEquipment.Text = "Добавить отказавшее оборудование";
            this.toolBtnAddEquipment.Click += new System.EventHandler(this.toolBtnAddEquipment_Click);
            // 
            // toolBtnDelEquipment
            // 
            this.toolBtnDelEquipment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelEquipment.Image = global::DailyReportN.Properties.Resources.ElementDel;
            this.toolBtnDelEquipment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelEquipment.Name = "toolBtnDelEquipment";
            this.toolBtnDelEquipment.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelEquipment.Text = "Удалить отказавшее оборудование";
            this.toolBtnDelEquipment.Click += new System.EventHandler(this.toolBtnDelEquipment_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::DailyReportN.Properties.Resources.refresh_16;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Обновить характеристик оборудования";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(3, 3);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(770, 14);
            this.label23.TabIndex = 0;
            this.label23.Text = "Сведения о поврежденном или отказавшем электротехническом оборудовании элеткричес" +
    "ких сетей";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPageComission
            // 
            this.tabPageComission.Controls.Add(this.chkChairmanSpecial);
            this.tabPageComission.Controls.Add(this.chkMemberComissionSpecial5);
            this.tabPageComission.Controls.Add(this.chkMemberComissionSpecial4);
            this.tabPageComission.Controls.Add(this.chkMemberComissionSpecial3);
            this.tabPageComission.Controls.Add(this.chkMemberComissionSpecial2);
            this.tabPageComission.Controls.Add(this.chkMemberComissionSpecial1);
            this.tabPageComission.Controls.Add(this.label84);
            this.tabPageComission.Controls.Add(this.label80);
            this.tabPageComission.Controls.Add(this.txtPostMemeber5);
            this.tabPageComission.Controls.Add(this.label55);
            this.tabPageComission.Controls.Add(this.cmbMemberComission5);
            this.tabPageComission.Controls.Add(this.txtPostMemeber4);
            this.tabPageComission.Controls.Add(this.label56);
            this.tabPageComission.Controls.Add(this.cmbMemberComission4);
            this.tabPageComission.Controls.Add(this.txtTotalComission);
            this.tabPageComission.Controls.Add(this.label53);
            this.tabPageComission.Controls.Add(this.txtPostMemeber3);
            this.tabPageComission.Controls.Add(this.label52);
            this.tabPageComission.Controls.Add(this.cmbMemberComission3);
            this.tabPageComission.Controls.Add(this.txtPostMemeber2);
            this.tabPageComission.Controls.Add(this.label51);
            this.tabPageComission.Controls.Add(this.cmbMemberComission2);
            this.tabPageComission.Controls.Add(this.txtPostMemeber1);
            this.tabPageComission.Controls.Add(this.label50);
            this.tabPageComission.Controls.Add(this.cmbMemberComission1);
            this.tabPageComission.Controls.Add(this.label49);
            this.tabPageComission.Controls.Add(this.txtPostChairman);
            this.tabPageComission.Controls.Add(this.label48);
            this.tabPageComission.Controls.Add(this.cmbChairman);
            this.tabPageComission.Controls.Add(this.label47);
            this.tabPageComission.Controls.Add(this.txtOrder);
            this.tabPageComission.Controls.Add(this.label46);
            this.tabPageComission.Location = new System.Drawing.Point(4, 22);
            this.tabPageComission.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageComission.Name = "tabPageComission";
            this.tabPageComission.Size = new System.Drawing.Size(776, 541);
            this.tabPageComission.TabIndex = 2;
            this.tabPageComission.Text = "Комиссия";
            this.tabPageComission.UseVisualStyleBackColor = true;
            // 
            // chkChairmanSpecial
            // 
            this.chkChairmanSpecial.AutoSize = true;
            this.chkChairmanSpecial.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetCrash, "dtComission.isChairmanSpecial", true));
            this.chkChairmanSpecial.Location = new System.Drawing.Point(582, 55);
            this.chkChairmanSpecial.Name = "chkChairmanSpecial";
            this.chkChairmanSpecial.Size = new System.Drawing.Size(15, 14);
            this.chkChairmanSpecial.TabIndex = 40;
            this.chkChairmanSpecial.UseVisualStyleBackColor = true;
            this.chkChairmanSpecial.CheckedChanged += new System.EventHandler(this.chkMemberComissionSpecial_CheckedChanged);
            // 
            // chkMemberComissionSpecial5
            // 
            this.chkMemberComissionSpecial5.AutoSize = true;
            this.chkMemberComissionSpecial5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetCrash, "dtComission.isMemberComissionSpecial5", true));
            this.chkMemberComissionSpecial5.Location = new System.Drawing.Point(582, 213);
            this.chkMemberComissionSpecial5.Name = "chkMemberComissionSpecial5";
            this.chkMemberComissionSpecial5.Size = new System.Drawing.Size(15, 14);
            this.chkMemberComissionSpecial5.TabIndex = 39;
            this.chkMemberComissionSpecial5.UseVisualStyleBackColor = true;
            this.chkMemberComissionSpecial5.CheckedChanged += new System.EventHandler(this.chkMemberComissionSpecial_CheckedChanged);
            // 
            // chkMemberComissionSpecial4
            // 
            this.chkMemberComissionSpecial4.AutoSize = true;
            this.chkMemberComissionSpecial4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetCrash, "dtComission.isMemberComissionSpecial4", true));
            this.chkMemberComissionSpecial4.Location = new System.Drawing.Point(582, 184);
            this.chkMemberComissionSpecial4.Name = "chkMemberComissionSpecial4";
            this.chkMemberComissionSpecial4.Size = new System.Drawing.Size(15, 14);
            this.chkMemberComissionSpecial4.TabIndex = 38;
            this.chkMemberComissionSpecial4.UseVisualStyleBackColor = true;
            this.chkMemberComissionSpecial4.CheckedChanged += new System.EventHandler(this.chkMemberComissionSpecial_CheckedChanged);
            // 
            // chkMemberComissionSpecial3
            // 
            this.chkMemberComissionSpecial3.AutoSize = true;
            this.chkMemberComissionSpecial3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetCrash, "dtComission.isMemberComissionSpecial3", true));
            this.chkMemberComissionSpecial3.Location = new System.Drawing.Point(582, 160);
            this.chkMemberComissionSpecial3.Name = "chkMemberComissionSpecial3";
            this.chkMemberComissionSpecial3.Size = new System.Drawing.Size(15, 14);
            this.chkMemberComissionSpecial3.TabIndex = 37;
            this.chkMemberComissionSpecial3.UseVisualStyleBackColor = true;
            this.chkMemberComissionSpecial3.CheckedChanged += new System.EventHandler(this.chkMemberComissionSpecial_CheckedChanged);
            // 
            // chkMemberComissionSpecial2
            // 
            this.chkMemberComissionSpecial2.AutoSize = true;
            this.chkMemberComissionSpecial2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetCrash, "dtComission.isMemberComissionSpecial2", true));
            this.chkMemberComissionSpecial2.Location = new System.Drawing.Point(582, 135);
            this.chkMemberComissionSpecial2.Name = "chkMemberComissionSpecial2";
            this.chkMemberComissionSpecial2.Size = new System.Drawing.Size(15, 14);
            this.chkMemberComissionSpecial2.TabIndex = 36;
            this.chkMemberComissionSpecial2.UseVisualStyleBackColor = true;
            this.chkMemberComissionSpecial2.CheckedChanged += new System.EventHandler(this.chkMemberComissionSpecial_CheckedChanged);
            // 
            // chkMemberComissionSpecial1
            // 
            this.chkMemberComissionSpecial1.AutoSize = true;
            this.chkMemberComissionSpecial1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetCrash, "dtComission.isMemberComissionSpecial1", true));
            this.chkMemberComissionSpecial1.Location = new System.Drawing.Point(582, 95);
            this.chkMemberComissionSpecial1.Name = "chkMemberComissionSpecial1";
            this.chkMemberComissionSpecial1.Size = new System.Drawing.Size(15, 14);
            this.chkMemberComissionSpecial1.TabIndex = 35;
            this.chkMemberComissionSpecial1.UseVisualStyleBackColor = true;
            this.chkMemberComissionSpecial1.CheckedChanged += new System.EventHandler(this.chkMemberComissionSpecial_CheckedChanged);
            // 
            // label84
            // 
            this.label84.Location = new System.Drawing.Point(529, 33);
            this.label84.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label84.Name = "label84";
            this.label84.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label84.Size = new System.Drawing.Size(239, 17);
            this.label84.TabIndex = 34;
            this.label84.Text = "Члены комиссии, имеющие особое мнение";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(12, 115);
            this.label80.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(94, 13);
            this.label80.TabIndex = 24;
            this.label80.Text = "Члены комиссии";
            // 
            // txtPostMemeber5
            // 
            this.txtPostMemeber5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.PostMember5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostMemeber5.Location = new System.Drawing.Point(296, 207);
            this.txtPostMemeber5.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostMemeber5.Name = "txtPostMemeber5";
            this.txtPostMemeber5.Size = new System.Drawing.Size(259, 20);
            this.txtPostMemeber5.TabIndex = 23;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(230, 209);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(65, 13);
            this.label55.TabIndex = 22;
            this.label55.Text = "Должность";
            // 
            // cmbMemberComission5
            // 
            this.cmbMemberComission5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMemberComission5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMemberComission5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetCrash, "dtComission.Member5", true));
            this.cmbMemberComission5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberComission5.FormattingEnabled = true;
            this.cmbMemberComission5.Location = new System.Drawing.Point(9, 207);
            this.cmbMemberComission5.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMemberComission5.Name = "cmbMemberComission5";
            this.cmbMemberComission5.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbMemberComission5.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbMemberComission5.Size = new System.Drawing.Size(201, 21);
            this.cmbMemberComission5.TabIndex = 21;
            this.cmbMemberComission5.SelectedValueChanged += new System.EventHandler(this.cmb_SelectedValueChanged);
            // 
            // txtPostMemeber4
            // 
            this.txtPostMemeber4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.PostMember4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostMemeber4.Location = new System.Drawing.Point(296, 182);
            this.txtPostMemeber4.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostMemeber4.Name = "txtPostMemeber4";
            this.txtPostMemeber4.Size = new System.Drawing.Size(259, 20);
            this.txtPostMemeber4.TabIndex = 20;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(230, 185);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(65, 13);
            this.label56.TabIndex = 19;
            this.label56.Text = "Должность";
            // 
            // cmbMemberComission4
            // 
            this.cmbMemberComission4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMemberComission4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMemberComission4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetCrash, "dtComission.Member4", true));
            this.cmbMemberComission4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberComission4.FormattingEnabled = true;
            this.cmbMemberComission4.Location = new System.Drawing.Point(9, 182);
            this.cmbMemberComission4.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMemberComission4.Name = "cmbMemberComission4";
            this.cmbMemberComission4.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbMemberComission4.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbMemberComission4.Size = new System.Drawing.Size(201, 21);
            this.cmbMemberComission4.TabIndex = 18;
            this.cmbMemberComission4.SelectedValueChanged += new System.EventHandler(this.cmb_SelectedValueChanged);
            // 
            // txtTotalComission
            // 
            this.txtTotalComission.AcceptsTab = true;
            this.txtTotalComission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalComission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.TotalComission", true));
            this.txtTotalComission.Location = new System.Drawing.Point(9, 254);
            this.txtTotalComission.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalComission.Name = "txtTotalComission";
            this.txtTotalComission.Size = new System.Drawing.Size(765, 288);
            this.txtTotalComission.TabIndex = 17;
            this.txtTotalComission.Text = "";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label53.Location = new System.Drawing.Point(16, 236);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(116, 13);
            this.label53.TabIndex = 16;
            this.label53.Text = "Выводы комиссии";
            // 
            // txtPostMemeber3
            // 
            this.txtPostMemeber3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.PostMember3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostMemeber3.Location = new System.Drawing.Point(296, 157);
            this.txtPostMemeber3.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostMemeber3.Name = "txtPostMemeber3";
            this.txtPostMemeber3.Size = new System.Drawing.Size(259, 20);
            this.txtPostMemeber3.TabIndex = 15;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(230, 159);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(65, 13);
            this.label52.TabIndex = 14;
            this.label52.Text = "Должность";
            // 
            // cmbMemberComission3
            // 
            this.cmbMemberComission3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMemberComission3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMemberComission3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetCrash, "dtComission.Member3", true));
            this.cmbMemberComission3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberComission3.FormattingEnabled = true;
            this.cmbMemberComission3.Location = new System.Drawing.Point(9, 157);
            this.cmbMemberComission3.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMemberComission3.Name = "cmbMemberComission3";
            this.cmbMemberComission3.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbMemberComission3.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbMemberComission3.Size = new System.Drawing.Size(201, 21);
            this.cmbMemberComission3.TabIndex = 13;
            this.cmbMemberComission3.SelectedValueChanged += new System.EventHandler(this.cmb_SelectedValueChanged);
            // 
            // txtPostMemeber2
            // 
            this.txtPostMemeber2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.PostMember2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostMemeber2.Location = new System.Drawing.Point(296, 132);
            this.txtPostMemeber2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostMemeber2.Name = "txtPostMemeber2";
            this.txtPostMemeber2.Size = new System.Drawing.Size(259, 20);
            this.txtPostMemeber2.TabIndex = 12;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(230, 135);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(65, 13);
            this.label51.TabIndex = 11;
            this.label51.Text = "Должность";
            // 
            // cmbMemberComission2
            // 
            this.cmbMemberComission2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMemberComission2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMemberComission2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetCrash, "dtComission.Member2", true));
            this.cmbMemberComission2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberComission2.FormattingEnabled = true;
            this.cmbMemberComission2.Location = new System.Drawing.Point(9, 132);
            this.cmbMemberComission2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMemberComission2.Name = "cmbMemberComission2";
            this.cmbMemberComission2.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbMemberComission2.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbMemberComission2.Size = new System.Drawing.Size(201, 21);
            this.cmbMemberComission2.TabIndex = 10;
            this.cmbMemberComission2.SelectedValueChanged += new System.EventHandler(this.cmb_SelectedValueChanged);
            // 
            // txtPostMemeber1
            // 
            this.txtPostMemeber1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.PostMember1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostMemeber1.Location = new System.Drawing.Point(296, 92);
            this.txtPostMemeber1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostMemeber1.Name = "txtPostMemeber1";
            this.txtPostMemeber1.Size = new System.Drawing.Size(259, 20);
            this.txtPostMemeber1.TabIndex = 9;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(230, 94);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(65, 13);
            this.label50.TabIndex = 8;
            this.label50.Text = "Должность";
            // 
            // cmbMemberComission1
            // 
            this.cmbMemberComission1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMemberComission1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMemberComission1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetCrash, "dtComission.Member1", true));
            this.cmbMemberComission1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberComission1.FormattingEnabled = true;
            this.cmbMemberComission1.Location = new System.Drawing.Point(9, 92);
            this.cmbMemberComission1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMemberComission1.Name = "cmbMemberComission1";
            this.cmbMemberComission1.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbMemberComission1.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbMemberComission1.Size = new System.Drawing.Size(201, 21);
            this.cmbMemberComission1.TabIndex = 7;
            this.cmbMemberComission1.SelectedValueChanged += new System.EventHandler(this.cmb_SelectedValueChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(12, 76);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(151, 13);
            this.label49.TabIndex = 6;
            this.label49.Text = "Заместитель председателя:";
            // 
            // txtPostChairman
            // 
            this.txtPostChairman.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.PostChairman", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostChairman.Location = new System.Drawing.Point(296, 52);
            this.txtPostChairman.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostChairman.Name = "txtPostChairman";
            this.txtPostChairman.Size = new System.Drawing.Size(259, 20);
            this.txtPostChairman.TabIndex = 5;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(230, 54);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(65, 13);
            this.label48.TabIndex = 4;
            this.label48.Text = "Должность";
            // 
            // cmbChairman
            // 
            this.cmbChairman.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbChairman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbChairman.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetCrash, "dtComission.Chairman", true));
            this.cmbChairman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChairman.FormattingEnabled = true;
            this.cmbChairman.Location = new System.Drawing.Point(9, 52);
            this.cmbChairman.Margin = new System.Windows.Forms.Padding(2);
            this.cmbChairman.Name = "cmbChairman";
            this.cmbChairman.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbChairman.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbChairman.Size = new System.Drawing.Size(201, 21);
            this.cmbChairman.TabIndex = 3;
            this.cmbChairman.SelectedValueChanged += new System.EventHandler(this.cmb_SelectedValueChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(12, 36);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(80, 13);
            this.label47.TabIndex = 2;
            this.label47.Text = "Председатель";
            // 
            // txtOrder
            // 
            this.txtOrder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.Order", true));
            this.txtOrder.Location = new System.Drawing.Point(430, 11);
            this.txtOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(242, 20);
            this.txtOrder.TabIndex = 1;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label46.Location = new System.Drawing.Point(58, 13);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(369, 13);
            this.label46.TabIndex = 0;
            this.label46.Text = "Комиссия, расследовавшая аварии, назначена приказом от";
            // 
            // tabPageSpecialOpinion
            // 
            this.tabPageSpecialOpinion.Controls.Add(this.txtMemberPostSpecial5);
            this.tabPageSpecialOpinion.Controls.Add(this.lblMemberComissionSpecial5);
            this.tabPageSpecialOpinion.Controls.Add(this.txtMemberPostSpecial4);
            this.tabPageSpecialOpinion.Controls.Add(this.lblMemberComissionSpecial4);
            this.tabPageSpecialOpinion.Controls.Add(this.txtMemberPostSpecial3);
            this.tabPageSpecialOpinion.Controls.Add(this.lblMemberComissionSpecial3);
            this.tabPageSpecialOpinion.Controls.Add(this.txtMemberPostSpecial2);
            this.tabPageSpecialOpinion.Controls.Add(this.lblMemberComissionSpecial2);
            this.tabPageSpecialOpinion.Controls.Add(this.txtMemberPostSpecial1);
            this.tabPageSpecialOpinion.Controls.Add(this.lblMemberComissionSpecial1);
            this.tabPageSpecialOpinion.Controls.Add(this.txtChairmanSpecial);
            this.tabPageSpecialOpinion.Controls.Add(this.lblChairmanSpecial);
            this.tabPageSpecialOpinion.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpecialOpinion.Name = "tabPageSpecialOpinion";
            this.tabPageSpecialOpinion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpecialOpinion.Size = new System.Drawing.Size(776, 541);
            this.tabPageSpecialOpinion.TabIndex = 7;
            this.tabPageSpecialOpinion.Text = "Специальное мнение";
            // 
            // txtMemberPostSpecial5
            // 
            this.txtMemberPostSpecial5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberPostSpecial5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.MemberPostSpecial5", true));
            this.txtMemberPostSpecial5.Location = new System.Drawing.Point(7, 442);
            this.txtMemberPostSpecial5.Name = "txtMemberPostSpecial5";
            this.txtMemberPostSpecial5.Size = new System.Drawing.Size(763, 66);
            this.txtMemberPostSpecial5.TabIndex = 11;
            this.txtMemberPostSpecial5.Text = "";
            // 
            // lblMemberComissionSpecial5
            // 
            this.lblMemberComissionSpecial5.AutoSize = true;
            this.lblMemberComissionSpecial5.Location = new System.Drawing.Point(7, 426);
            this.lblMemberComissionSpecial5.Name = "lblMemberComissionSpecial5";
            this.lblMemberComissionSpecial5.Size = new System.Drawing.Size(0, 13);
            this.lblMemberComissionSpecial5.TabIndex = 10;
            // 
            // txtMemberPostSpecial4
            // 
            this.txtMemberPostSpecial4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberPostSpecial4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.MemberPostSpecial4", true));
            this.txtMemberPostSpecial4.Location = new System.Drawing.Point(7, 357);
            this.txtMemberPostSpecial4.Name = "txtMemberPostSpecial4";
            this.txtMemberPostSpecial4.Size = new System.Drawing.Size(763, 66);
            this.txtMemberPostSpecial4.TabIndex = 9;
            this.txtMemberPostSpecial4.Text = "";
            // 
            // lblMemberComissionSpecial4
            // 
            this.lblMemberComissionSpecial4.AutoSize = true;
            this.lblMemberComissionSpecial4.Location = new System.Drawing.Point(7, 341);
            this.lblMemberComissionSpecial4.Name = "lblMemberComissionSpecial4";
            this.lblMemberComissionSpecial4.Size = new System.Drawing.Size(0, 13);
            this.lblMemberComissionSpecial4.TabIndex = 8;
            // 
            // txtMemberPostSpecial3
            // 
            this.txtMemberPostSpecial3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberPostSpecial3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.MemberPostSpecial3", true));
            this.txtMemberPostSpecial3.Location = new System.Drawing.Point(7, 275);
            this.txtMemberPostSpecial3.Name = "txtMemberPostSpecial3";
            this.txtMemberPostSpecial3.Size = new System.Drawing.Size(763, 66);
            this.txtMemberPostSpecial3.TabIndex = 7;
            this.txtMemberPostSpecial3.Text = "";
            // 
            // lblMemberComissionSpecial3
            // 
            this.lblMemberComissionSpecial3.AutoSize = true;
            this.lblMemberComissionSpecial3.Location = new System.Drawing.Point(7, 259);
            this.lblMemberComissionSpecial3.Name = "lblMemberComissionSpecial3";
            this.lblMemberComissionSpecial3.Size = new System.Drawing.Size(0, 13);
            this.lblMemberComissionSpecial3.TabIndex = 6;
            // 
            // txtMemberPostSpecial2
            // 
            this.txtMemberPostSpecial2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberPostSpecial2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.MemberPostSpecial2", true));
            this.txtMemberPostSpecial2.Location = new System.Drawing.Point(7, 190);
            this.txtMemberPostSpecial2.Name = "txtMemberPostSpecial2";
            this.txtMemberPostSpecial2.Size = new System.Drawing.Size(763, 66);
            this.txtMemberPostSpecial2.TabIndex = 5;
            this.txtMemberPostSpecial2.Text = "";
            // 
            // lblMemberComissionSpecial2
            // 
            this.lblMemberComissionSpecial2.AutoSize = true;
            this.lblMemberComissionSpecial2.Location = new System.Drawing.Point(7, 174);
            this.lblMemberComissionSpecial2.Name = "lblMemberComissionSpecial2";
            this.lblMemberComissionSpecial2.Size = new System.Drawing.Size(0, 13);
            this.lblMemberComissionSpecial2.TabIndex = 4;
            // 
            // txtMemberPostSpecial1
            // 
            this.txtMemberPostSpecial1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberPostSpecial1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.MemberPostSpecial1", true));
            this.txtMemberPostSpecial1.Location = new System.Drawing.Point(7, 105);
            this.txtMemberPostSpecial1.Name = "txtMemberPostSpecial1";
            this.txtMemberPostSpecial1.Size = new System.Drawing.Size(763, 66);
            this.txtMemberPostSpecial1.TabIndex = 3;
            this.txtMemberPostSpecial1.Text = "";
            // 
            // lblMemberComissionSpecial1
            // 
            this.lblMemberComissionSpecial1.AutoSize = true;
            this.lblMemberComissionSpecial1.Location = new System.Drawing.Point(7, 89);
            this.lblMemberComissionSpecial1.Name = "lblMemberComissionSpecial1";
            this.lblMemberComissionSpecial1.Size = new System.Drawing.Size(0, 13);
            this.lblMemberComissionSpecial1.TabIndex = 2;
            // 
            // txtChairmanSpecial
            // 
            this.txtChairmanSpecial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChairmanSpecial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetCrash, "dtComission.ChairmanPostSpecial", true));
            this.txtChairmanSpecial.Location = new System.Drawing.Point(7, 19);
            this.txtChairmanSpecial.Name = "txtChairmanSpecial";
            this.txtChairmanSpecial.Size = new System.Drawing.Size(763, 66);
            this.txtChairmanSpecial.TabIndex = 1;
            this.txtChairmanSpecial.Text = "";
            // 
            // lblChairmanSpecial
            // 
            this.lblChairmanSpecial.AutoSize = true;
            this.lblChairmanSpecial.Location = new System.Drawing.Point(7, 3);
            this.lblChairmanSpecial.Name = "lblChairmanSpecial";
            this.lblChairmanSpecial.Size = new System.Drawing.Size(0, 13);
            this.lblChairmanSpecial.TabIndex = 0;
            // 
            // tabPagePrint
            // 
            this.tabPagePrint.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrint.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePrint.Name = "tabPagePrint";
            this.tabPagePrint.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePrint.Size = new System.Drawing.Size(776, 541);
            this.tabPagePrint.TabIndex = 3;
            this.tabPagePrint.Text = "Печать";
            this.tabPagePrint.UseVisualStyleBackColor = true;
            // 
            // tabPersonal
            // 
            this.tabPersonal.Controls.Add(this.panel1);
            this.tabPersonal.Controls.Add(this.toolStrip1);
            this.tabPersonal.Controls.Add(this.dgvPersonal);
            this.tabPersonal.Controls.Add(this.label79);
            this.tabPersonal.Location = new System.Drawing.Point(4, 22);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Size = new System.Drawing.Size(776, 541);
            this.tabPersonal.TabIndex = 5;
            this.tabPersonal.Text = "Персонал";
            this.tabPersonal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtpDateLastCheck);
            this.panel1.Controls.Add(this.txtReasonError);
            this.panel1.Controls.Add(this.txtCircumstancesError);
            this.panel1.Controls.Add(this.txtWorkExperience);
            this.panel1.Controls.Add(this.label78);
            this.panel1.Controls.Add(this.label77);
            this.panel1.Controls.Add(this.label76);
            this.panel1.Controls.Add(this.label75);
            this.panel1.Controls.Add(this.txtSpecialty);
            this.panel1.Controls.Add(this.label74);
            this.panel1.Controls.Add(this.txtEducation);
            this.panel1.Controls.Add(this.label73);
            this.panel1.Controls.Add(this.txtFunction);
            this.panel1.Controls.Add(this.label72);
            this.panel1.Controls.Add(this.txtPlaceWork);
            this.panel1.Controls.Add(this.label71);
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 366);
            this.panel1.TabIndex = 73;
            // 
            // dtpDateLastCheck
            // 
            this.dtpDateLastCheck.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPersonal, "DateLastCheck", true));
            this.dtpDateLastCheck.Location = new System.Drawing.Point(274, 335);
            this.dtpDateLastCheck.Name = "dtpDateLastCheck";
            this.dtpDateLastCheck.Size = new System.Drawing.Size(134, 20);
            this.dtpDateLastCheck.TabIndex = 85;
            this.dtpDateLastCheck.Value = new System.DateTime(2019, 5, 20, 17, 23, 53, 804);
            // 
            // bsPersonal
            // 
            this.bsPersonal.DataMember = "dataTablePersonal";
            this.bsPersonal.DataSource = this.dataSetCrash;
            // 
            // txtReasonError
            // 
            this.txtReasonError.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonal, "ReasonError", true));
            this.txtReasonError.Location = new System.Drawing.Point(8, 220);
            this.txtReasonError.Name = "txtReasonError";
            this.txtReasonError.Size = new System.Drawing.Size(764, 87);
            this.txtReasonError.TabIndex = 84;
            this.txtReasonError.Text = "";
            // 
            // txtCircumstancesError
            // 
            this.txtCircumstancesError.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonal, "CircumstancesError", true));
            this.txtCircumstancesError.Location = new System.Drawing.Point(9, 122);
            this.txtCircumstancesError.Name = "txtCircumstancesError";
            this.txtCircumstancesError.Size = new System.Drawing.Size(763, 72);
            this.txtCircumstancesError.TabIndex = 83;
            this.txtCircumstancesError.Text = "";
            // 
            // txtWorkExperience
            // 
            this.txtWorkExperience.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonal, "WorkExperience", true));
            this.txtWorkExperience.Location = new System.Drawing.Point(274, 309);
            this.txtWorkExperience.Name = "txtWorkExperience";
            this.txtWorkExperience.Size = new System.Drawing.Size(100, 20);
            this.txtWorkExperience.TabIndex = 81;
            // 
            // label78
            // 
            this.label78.Location = new System.Drawing.Point(10, 336);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(242, 29);
            this.label78.TabIndex = 82;
            this.label78.Text = "Дата последней проверки знаний в объеме требований к занимаемой должности";
            // 
            // label77
            // 
            this.label77.Location = new System.Drawing.Point(10, 312);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(234, 24);
            this.label77.TabIndex = 80;
            this.label77.Text = "Стаж работы в данной должности, лет";
            // 
            // label76
            // 
            this.label76.Location = new System.Drawing.Point(9, 197);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(626, 20);
            this.label76.TabIndex = 79;
            this.label76.Text = "Причины ошибки";
            // 
            // label75
            // 
            this.label75.Location = new System.Drawing.Point(6, 98);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(626, 21);
            this.label75.TabIndex = 78;
            this.label75.Text = "Обстоятельства ошибки";
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonal, "Specialty", true));
            this.txtSpecialty.Location = new System.Drawing.Point(138, 75);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(576, 20);
            this.txtSpecialty.TabIndex = 76;
            // 
            // label74
            // 
            this.label74.Location = new System.Drawing.Point(5, 75);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(127, 19);
            this.label74.TabIndex = 77;
            this.label74.Text = "Специальность";
            // 
            // txtEducation
            // 
            this.txtEducation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonal, "Education", true));
            this.txtEducation.Location = new System.Drawing.Point(138, 49);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(576, 20);
            this.txtEducation.TabIndex = 74;
            // 
            // label73
            // 
            this.label73.Location = new System.Drawing.Point(6, 51);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(106, 20);
            this.label73.TabIndex = 75;
            this.label73.Text = "Образование\r\n";
            // 
            // txtFunction
            // 
            this.txtFunction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonal, "Function", true));
            this.txtFunction.Location = new System.Drawing.Point(138, 25);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(576, 20);
            this.txtFunction.TabIndex = 72;
            // 
            // label72
            // 
            this.label72.Location = new System.Drawing.Point(5, 28);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(132, 18);
            this.label72.TabIndex = 73;
            this.label72.Text = "Должность";
            // 
            // txtPlaceWork
            // 
            this.txtPlaceWork.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonal, "PlaceWork", true));
            this.txtPlaceWork.Location = new System.Drawing.Point(138, 2);
            this.txtPlaceWork.Name = "txtPlaceWork";
            this.txtPlaceWork.Size = new System.Drawing.Size(576, 20);
            this.txtPlaceWork.TabIndex = 70;
            // 
            // label71
            // 
            this.label71.Location = new System.Drawing.Point(5, 4);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(79, 18);
            this.label71.TabIndex = 71;
            this.label71.Text = "Место работы";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspAddPersonal,
            this.tsbDelPersonal,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 25);
            this.toolStrip1.TabIndex = 72;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspAddPersonal
            // 
            this.tspAddPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspAddPersonal.Image = global::DailyReportN.Properties.Resources.ElementAdd;
            this.tspAddPersonal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspAddPersonal.Name = "tspAddPersonal";
            this.tspAddPersonal.Size = new System.Drawing.Size(23, 22);
            this.tspAddPersonal.Text = "Добавить отказавшее оборудование";
            this.tspAddPersonal.Click += new System.EventHandler(this.tspAddPersonal_Click);
            // 
            // tsbDelPersonal
            // 
            this.tsbDelPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelPersonal.Image = global::DailyReportN.Properties.Resources.ElementDel;
            this.tsbDelPersonal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelPersonal.Name = "tsbDelPersonal";
            this.tsbDelPersonal.Size = new System.Drawing.Size(23, 22);
            this.tsbDelPersonal.Text = "Удалить отказавшее оборудование";
            this.tsbDelPersonal.Click += new System.EventHandler(this.tsbDelPersonal_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToDeleteRows = false;
            this.dgvPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonal.AutoGenerateColumns = false;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonalDataGridViewTextBoxColumn,
            this.idPlaceWorkDataGridViewTextBoxColumn,
            this.idSpecialtyDataGridViewTextBoxColumn,
            this.PersonalColumn,
            this.PlaceWorkColumn,
            this.SpecialtyColumn});
            this.dgvPersonal.DataSource = this.bsPersonal;
            this.dgvPersonal.Location = new System.Drawing.Point(0, 59);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            this.dgvPersonal.Size = new System.Drawing.Size(773, 108);
            this.dgvPersonal.TabIndex = 71;
            // 
            // idPersonalDataGridViewTextBoxColumn
            // 
            this.idPersonalDataGridViewTextBoxColumn.DataPropertyName = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.HeaderText = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.Name = "idPersonalDataGridViewTextBoxColumn";
            this.idPersonalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersonalDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPlaceWorkDataGridViewTextBoxColumn
            // 
            this.idPlaceWorkDataGridViewTextBoxColumn.DataPropertyName = "idPlaceWork";
            this.idPlaceWorkDataGridViewTextBoxColumn.HeaderText = "idPlaceWork";
            this.idPlaceWorkDataGridViewTextBoxColumn.Name = "idPlaceWorkDataGridViewTextBoxColumn";
            this.idPlaceWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPlaceWorkDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSpecialtyDataGridViewTextBoxColumn
            // 
            this.idSpecialtyDataGridViewTextBoxColumn.DataPropertyName = "idFunction";
            this.idSpecialtyDataGridViewTextBoxColumn.HeaderText = "idSpecialty";
            this.idSpecialtyDataGridViewTextBoxColumn.Name = "idSpecialtyDataGridViewTextBoxColumn";
            this.idSpecialtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSpecialtyDataGridViewTextBoxColumn.Visible = false;
            // 
            // PersonalColumn
            // 
            this.PersonalColumn.DataPropertyName = "Personal";
            this.PersonalColumn.HeaderText = "Персонал";
            this.PersonalColumn.Name = "PersonalColumn";
            this.PersonalColumn.ReadOnly = true;
            this.PersonalColumn.Width = 250;
            // 
            // PlaceWorkColumn
            // 
            this.PlaceWorkColumn.DataPropertyName = "PlaceWork";
            this.PlaceWorkColumn.HeaderText = "Место работы";
            this.PlaceWorkColumn.Name = "PlaceWorkColumn";
            this.PlaceWorkColumn.ReadOnly = true;
            this.PlaceWorkColumn.Width = 150;
            // 
            // SpecialtyColumn
            // 
            this.SpecialtyColumn.DataPropertyName = "Function";
            this.SpecialtyColumn.HeaderText = "Должность";
            this.SpecialtyColumn.Name = "SpecialtyColumn";
            this.SpecialtyColumn.ReadOnly = true;
            this.SpecialtyColumn.Width = 150;
            // 
            // label79
            // 
            this.label79.Dock = System.Windows.Forms.DockStyle.Top;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label79.Location = new System.Drawing.Point(0, 0);
            this.label79.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(776, 33);
            this.label79.TabIndex = 70;
            this.label79.Text = "Описание действий оперативного персонала и должностных лиц субъектов электроэнерг" +
    "етики и потребителей электрической энергии, послуживших предпосылками и (или) пр" +
    "ичинами возникновения аварии";
            this.label79.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabAnnex
            // 
            this.tabAnnex.Controls.Add(this.splitContainer3);
            this.tabAnnex.Location = new System.Drawing.Point(4, 22);
            this.tabAnnex.Name = "tabAnnex";
            this.tabAnnex.Size = new System.Drawing.Size(776, 541);
            this.tabAnnex.TabIndex = 6;
            this.tabAnnex.Text = "Приложение";
            this.tabAnnex.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtConsumerPartialDeenergized);
            this.splitContainer3.Panel1.Controls.Add(this.txtConsumerFullDeenergized);
            this.splitContainer3.Panel1.Controls.Add(this.txtFeedObjectsList);
            this.splitContainer3.Panel1.Controls.Add(this.txtCountDeEnergizedPopulation);
            this.splitContainer3.Panel1.Controls.Add(this.txtCountDeEnergizedSocialObjects);
            this.splitContainer3.Panel1.Controls.Add(this.txtCountDeEnergizedSettlements);
            this.splitContainer3.Panel1.Controls.Add(this.txtCountDeEnergizedRP110);
            this.splitContainer3.Panel1.Controls.Add(this.txtCountDeEnergizedRP35);
            this.splitContainer3.Panel1.Controls.Add(this.txtCountDeEnergizedTP);
            this.splitContainer3.Panel1.Controls.Add(this.txtPowerTotal);
            this.splitContainer3.Panel1.Controls.Add(this.txtCountPointsSupply);
            this.splitContainer3.Panel1.Controls.Add(this.label69);
            this.splitContainer3.Panel1.Controls.Add(this.label68);
            this.splitContainer3.Panel1.Controls.Add(this.label67);
            this.splitContainer3.Panel1.Controls.Add(this.label66);
            this.splitContainer3.Panel1.Controls.Add(this.label65);
            this.splitContainer3.Panel1.Controls.Add(this.label64);
            this.splitContainer3.Panel1.Controls.Add(this.label63);
            this.splitContainer3.Panel1.Controls.Add(this.label62);
            this.splitContainer3.Panel1.Controls.Add(this.label61);
            this.splitContainer3.Panel1.Controls.Add(this.label60);
            this.splitContainer3.Panel1.Controls.Add(this.label59);
            this.splitContainer3.Panel1.Controls.Add(this.label57);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvVoltagePowerPlantConsumer);
            this.splitContainer3.Panel2.Controls.Add(this.txtTSONeighList);
            this.splitContainer3.Panel2.Controls.Add(this.label70);
            this.splitContainer3.Panel2.Controls.Add(this.label58);
            this.splitContainer3.Size = new System.Drawing.Size(776, 541);
            this.splitContainer3.SplitterDistance = 402;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 1;
            // 
            // txtConsumerPartialDeenergized
            // 
            this.txtConsumerPartialDeenergized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConsumerPartialDeenergized.Location = new System.Drawing.Point(11, 341);
            this.txtConsumerPartialDeenergized.Name = "txtConsumerPartialDeenergized";
            this.txtConsumerPartialDeenergized.Size = new System.Drawing.Size(728, 58);
            this.txtConsumerPartialDeenergized.TabIndex = 70;
            this.txtConsumerPartialDeenergized.Text = "";
            this.txtConsumerPartialDeenergized.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtConsumerFullDeenergized
            // 
            this.txtConsumerFullDeenergized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConsumerFullDeenergized.Location = new System.Drawing.Point(9, 279);
            this.txtConsumerFullDeenergized.Name = "txtConsumerFullDeenergized";
            this.txtConsumerFullDeenergized.Size = new System.Drawing.Size(728, 35);
            this.txtConsumerFullDeenergized.TabIndex = 69;
            this.txtConsumerFullDeenergized.Text = "";
            this.txtConsumerFullDeenergized.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtFeedObjectsList
            // 
            this.txtFeedObjectsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFeedObjectsList.Location = new System.Drawing.Point(11, 230);
            this.txtFeedObjectsList.Name = "txtFeedObjectsList";
            this.txtFeedObjectsList.Size = new System.Drawing.Size(728, 19);
            this.txtFeedObjectsList.TabIndex = 68;
            this.txtFeedObjectsList.Text = "";
            this.txtFeedObjectsList.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtCountDeEnergizedPopulation
            // 
            this.txtCountDeEnergizedPopulation.Location = new System.Drawing.Point(669, 176);
            this.txtCountDeEnergizedPopulation.Name = "txtCountDeEnergizedPopulation";
            this.txtCountDeEnergizedPopulation.Size = new System.Drawing.Size(100, 20);
            this.txtCountDeEnergizedPopulation.TabIndex = 67;
            this.txtCountDeEnergizedPopulation.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtCountDeEnergizedSocialObjects
            // 
            this.txtCountDeEnergizedSocialObjects.Location = new System.Drawing.Point(669, 153);
            this.txtCountDeEnergizedSocialObjects.Name = "txtCountDeEnergizedSocialObjects";
            this.txtCountDeEnergizedSocialObjects.Size = new System.Drawing.Size(100, 20);
            this.txtCountDeEnergizedSocialObjects.TabIndex = 66;
            this.txtCountDeEnergizedSocialObjects.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtCountDeEnergizedSettlements
            // 
            this.txtCountDeEnergizedSettlements.Location = new System.Drawing.Point(669, 131);
            this.txtCountDeEnergizedSettlements.Name = "txtCountDeEnergizedSettlements";
            this.txtCountDeEnergizedSettlements.Size = new System.Drawing.Size(100, 20);
            this.txtCountDeEnergizedSettlements.TabIndex = 65;
            this.txtCountDeEnergizedSettlements.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtCountDeEnergizedRP110
            // 
            this.txtCountDeEnergizedRP110.Location = new System.Drawing.Point(669, 109);
            this.txtCountDeEnergizedRP110.Name = "txtCountDeEnergizedRP110";
            this.txtCountDeEnergizedRP110.Size = new System.Drawing.Size(100, 20);
            this.txtCountDeEnergizedRP110.TabIndex = 64;
            this.txtCountDeEnergizedRP110.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtCountDeEnergizedRP35
            // 
            this.txtCountDeEnergizedRP35.Location = new System.Drawing.Point(669, 87);
            this.txtCountDeEnergizedRP35.Name = "txtCountDeEnergizedRP35";
            this.txtCountDeEnergizedRP35.Size = new System.Drawing.Size(100, 20);
            this.txtCountDeEnergizedRP35.TabIndex = 63;
            this.txtCountDeEnergizedRP35.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtCountDeEnergizedTP
            // 
            this.txtCountDeEnergizedTP.Location = new System.Drawing.Point(669, 65);
            this.txtCountDeEnergizedTP.Name = "txtCountDeEnergizedTP";
            this.txtCountDeEnergizedTP.Size = new System.Drawing.Size(100, 20);
            this.txtCountDeEnergizedTP.TabIndex = 62;
            this.txtCountDeEnergizedTP.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtPowerTotal
            // 
            this.txtPowerTotal.Location = new System.Drawing.Point(669, 40);
            this.txtPowerTotal.Name = "txtPowerTotal";
            this.txtPowerTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPowerTotal.TabIndex = 61;
            this.txtPowerTotal.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtCountPointsSupply
            // 
            this.txtCountPointsSupply.Location = new System.Drawing.Point(669, 17);
            this.txtCountPointsSupply.Name = "txtCountPointsSupply";
            this.txtCountPointsSupply.Size = new System.Drawing.Size(100, 20);
            this.txtCountPointsSupply.TabIndex = 48;
            this.txtCountPointsSupply.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label69
            // 
            this.label69.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label69.Location = new System.Drawing.Point(8, 314);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(761, 29);
            this.label69.TabIndex = 60;
            this.label69.Text = "Перечень потребителей 1-й и 2-й категорий надёжности, в отношении которых произош" +
    "ло частичное ограничение режима потребления электрической энергии";
            // 
            // label68
            // 
            this.label68.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label68.Location = new System.Drawing.Point(10, 252);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(761, 29);
            this.label68.TabIndex = 59;
            this.label68.Text = "Перечень потребителей 1-й и 2-й категорий надежности, в отношении которых произош" +
    "ло полное ограничение режима потребления электрической энергии";
            // 
            // label67
            // 
            this.label67.Location = new System.Drawing.Point(8, 198);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(761, 29);
            this.label67.TabIndex = 58;
            this.label67.Text = resources.GetString("label67.Text");
            // 
            // label66
            // 
            this.label66.Location = new System.Drawing.Point(8, 179);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(626, 17);
            this.label66.TabIndex = 57;
            this.label66.Text = "Обесточенное население, шт";
            // 
            // label65
            // 
            this.label65.Location = new System.Drawing.Point(8, 156);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(626, 17);
            this.label65.TabIndex = 56;
            this.label65.Text = "Количество обесточенных социально значимых объектов, шт";
            // 
            // label64
            // 
            this.label64.Location = new System.Drawing.Point(8, 134);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(626, 17);
            this.label64.TabIndex = 55;
            this.label64.Text = "Количество обесточенных населённых пунктов, шт";
            // 
            // label63
            // 
            this.label63.Location = new System.Drawing.Point(8, 112);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(626, 17);
            this.label63.TabIndex = 54;
            this.label63.Text = "Количество обесточенных ПС, РП (110 кВ и выше), шт";
            // 
            // label62
            // 
            this.label62.Location = new System.Drawing.Point(8, 90);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(626, 17);
            this.label62.TabIndex = 53;
            this.label62.Text = "Количество обесточенных подстанций (далее - ПС), распределительных пунктов (далее" +
    " - РП) (35 кВ), шт";
            // 
            // label61
            // 
            this.label61.Location = new System.Drawing.Point(8, 71);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(626, 14);
            this.label61.TabIndex = 52;
            this.label61.Text = "Количество обесточенных трансформаторных подстанций (далее - ТП) (6-10 кВ), шт";
            // 
            // label60
            // 
            this.label60.Location = new System.Drawing.Point(8, 43);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(626, 29);
            this.label60.TabIndex = 49;
            this.label60.Text = "Суммарный объем фактической нагрузки (мощности) на присоединениях потребителей ус" +
    "луг, по которым произошло прекращение передачи электрической энергии на момент в" +
    "озникновения такого события, кВт";
            // 
            // label59
            // 
            this.label59.Location = new System.Drawing.Point(8, 17);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(626, 29);
            this.label59.TabIndex = 50;
            this.label59.Text = "Количество точек поставки потребителей услуг сетевой  организации, в отношении ко" +
    "торых произошёл перерыв электроснабжения, шт.";
            // 
            // label57
            // 
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label57.Location = new System.Drawing.Point(-1, 1);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(779, 16);
            this.label57.TabIndex = 51;
            this.label57.Text = "Данные о масштабе прекращения передачи электрической энергии в  результате возник" +
    "новения и (или) развития аварии:";
            // 
            // dgvVoltagePowerPlantConsumer
            // 
            this.dgvVoltagePowerPlantConsumer.AllowUserToAddRows = false;
            this.dgvVoltagePowerPlantConsumer.AllowUserToDeleteRows = false;
            this.dgvVoltagePowerPlantConsumer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvVoltagePowerPlantConsumer.AutoGenerateColumns = false;
            this.dgvVoltagePowerPlantConsumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoltagePowerPlantConsumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVoltage,
            this.cat1DataGridViewTextBoxColumn,
            this.cat2DataGridViewTextBoxColumn,
            this.cat3DataGridViewTextBoxColumn});
            this.dgvVoltagePowerPlantConsumer.DataSource = this.bsVoltagePowerPlantConsumer;
            this.dgvVoltagePowerPlantConsumer.Location = new System.Drawing.Point(13, 3);
            this.dgvVoltagePowerPlantConsumer.Name = "dgvVoltagePowerPlantConsumer";
            this.dgvVoltagePowerPlantConsumer.Size = new System.Drawing.Size(727, 83);
            this.dgvVoltagePowerPlantConsumer.TabIndex = 54;
            this.dgvVoltagePowerPlantConsumer.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // ColumnVoltage
            // 
            this.ColumnVoltage.DataPropertyName = "Voltage";
            this.ColumnVoltage.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ColumnVoltage.HeaderText = "Уровень напряжения, кВ";
            this.ColumnVoltage.MinimumWidth = 150;
            this.ColumnVoltage.Name = "ColumnVoltage";
            this.ColumnVoltage.ReadOnly = true;
            this.ColumnVoltage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnVoltage.Width = 150;
            // 
            // cat1DataGridViewTextBoxColumn
            // 
            this.cat1DataGridViewTextBoxColumn.DataPropertyName = "cat1";
            this.cat1DataGridViewTextBoxColumn.HeaderText = "I";
            this.cat1DataGridViewTextBoxColumn.Name = "cat1DataGridViewTextBoxColumn";
            this.cat1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cat2DataGridViewTextBoxColumn
            // 
            this.cat2DataGridViewTextBoxColumn.DataPropertyName = "cat2";
            this.cat2DataGridViewTextBoxColumn.HeaderText = "II";
            this.cat2DataGridViewTextBoxColumn.Name = "cat2DataGridViewTextBoxColumn";
            this.cat2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cat3DataGridViewTextBoxColumn
            // 
            this.cat3DataGridViewTextBoxColumn.DataPropertyName = "cat3";
            this.cat3DataGridViewTextBoxColumn.HeaderText = "III";
            this.cat3DataGridViewTextBoxColumn.Name = "cat3DataGridViewTextBoxColumn";
            this.cat3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bsVoltagePowerPlantConsumer
            // 
            this.bsVoltagePowerPlantConsumer.DataMember = "dataTableVoltagePowerPlantConsumer";
            this.bsVoltagePowerPlantConsumer.DataSource = this.dataSetCrash;
            // 
            // txtTSONeighList
            // 
            this.txtTSONeighList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTSONeighList.Location = new System.Drawing.Point(313, 105);
            this.txtTSONeighList.Name = "txtTSONeighList";
            this.txtTSONeighList.Size = new System.Drawing.Size(457, 29);
            this.txtTSONeighList.TabIndex = 53;
            this.txtTSONeighList.Text = "";
            this.txtTSONeighList.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label70
            // 
            this.label70.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label70.Location = new System.Drawing.Point(10, 105);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(297, 29);
            this.label70.TabIndex = 52;
            this.label70.Text = "Перечень смежных сетевых организаций, затронутых прекращением передачи электричес" +
    "кой энергии";
            // 
            // label58
            // 
            this.label58.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label58.Location = new System.Drawing.Point(4, 89);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(766, 14);
            this.label58.TabIndex = 51;
            this.label58.Text = "Данные о масштабе прекращения передачи электрической энергии в смежных сетевых ор" +
    "ганизациях:";
            // 
            // tabPageDocuments
            // 
            this.tabPageDocuments.Controls.Add(this.dgvDocs);
            this.tabPageDocuments.Controls.Add(this.toolStripDocuments);
            this.tabPageDocuments.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocuments.Name = "tabPageDocuments";
            this.tabPageDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocuments.Size = new System.Drawing.Size(776, 541);
            this.tabPageDocuments.TabIndex = 2;
            this.tabPageDocuments.Text = "Документы";
            this.tabPageDocuments.UseVisualStyleBackColor = true;
            // 
            // dgvDocs
            // 
            this.dgvDocs.AllowUserToAddRows = false;
            this.dgvDocs.AllowUserToDeleteRows = false;
            this.dgvDocs.AutoGenerateColumns = false;
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumnDoc,
            this.idDamageDocDataGridViewTextBoxColumn,
            this.documentDataGridViewImageColumn,
            this.commentDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.ColumnImage});
            this.dgvDocs.DataSource = this.bsDamageDoc;
            this.dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocs.Location = new System.Drawing.Point(3, 28);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.RowHeadersWidth = 21;
            this.dgvDocs.Size = new System.Drawing.Size(770, 510);
            this.dgvDocs.TabIndex = 2;
            this.dgvDocs.VirtualMode = true;
            this.dgvDocs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocs_CellContentClick);
            this.dgvDocs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocs_CellValueChanged);
            this.dgvDocs.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvDocs_CellValueNeeded);
            // 
            // idDataGridViewTextBoxColumnDoc
            // 
            this.idDataGridViewTextBoxColumnDoc.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumnDoc.HeaderText = "id";
            this.idDataGridViewTextBoxColumnDoc.Name = "idDataGridViewTextBoxColumnDoc";
            this.idDataGridViewTextBoxColumnDoc.ReadOnly = true;
            this.idDataGridViewTextBoxColumnDoc.Visible = false;
            // 
            // idDamageDocDataGridViewTextBoxColumn
            // 
            this.idDamageDocDataGridViewTextBoxColumn.DataPropertyName = "idDamage";
            this.idDamageDocDataGridViewTextBoxColumn.HeaderText = "idDamage";
            this.idDamageDocDataGridViewTextBoxColumn.Name = "idDamageDocDataGridViewTextBoxColumn";
            this.idDamageDocDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentDataGridViewImageColumn
            // 
            this.documentDataGridViewImageColumn.DataPropertyName = "Document";
            this.documentDataGridViewImageColumn.HeaderText = "Document";
            this.documentDataGridViewImageColumn.Name = "documentDataGridViewImageColumn";
            this.documentDataGridViewImageColumn.Visible = false;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Наименование приложения";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "Приложение";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fileNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fileNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // ColumnImage
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnImage.HeaderText = "";
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnImage.Width = 30;
            // 
            // bsDamageDoc
            // 
            this.bsDamageDoc.DataMember = "tJ_DamageDoc";
            this.bsDamageDoc.DataSource = this.dataSetDamage;
            // 
            // toolStripDocuments
            // 
            this.toolStripDocuments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddDoc,
            this.toolBtnDelDoc,
            this.toolBtnViewDoc,
            this.toolBtnSaveDoc});
            this.toolStripDocuments.Location = new System.Drawing.Point(3, 3);
            this.toolStripDocuments.Name = "toolStripDocuments";
            this.toolStripDocuments.Size = new System.Drawing.Size(770, 25);
            this.toolStripDocuments.TabIndex = 1;
            this.toolStripDocuments.Text = "toolStrip1";
            // 
            // toolBtnAddDoc
            // 
            this.toolBtnAddDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddDoc.Image = global::DailyReportN.Properties.Resources.ElementAdd;
            this.toolBtnAddDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddDoc.Name = "toolBtnAddDoc";
            this.toolBtnAddDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddDoc.Text = "Добавить документ";
            this.toolBtnAddDoc.Click += new System.EventHandler(this.toolBtnAddDoc_Click);
            // 
            // toolBtnDelDoc
            // 
            this.toolBtnDelDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelDoc.Image = global::DailyReportN.Properties.Resources.ElementDel;
            this.toolBtnDelDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelDoc.Name = "toolBtnDelDoc";
            this.toolBtnDelDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelDoc.Text = "Удалить документ";
            this.toolBtnDelDoc.Click += new System.EventHandler(this.toolBtnDelDoc_Click);
            // 
            // toolBtnViewDoc
            // 
            this.toolBtnViewDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnViewDoc.Image = global::DailyReportN.Properties.Resources.ElementInformation;
            this.toolBtnViewDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnViewDoc.Name = "toolBtnViewDoc";
            this.toolBtnViewDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnViewDoc.Text = "Открыть документ";
            this.toolBtnViewDoc.Click += new System.EventHandler(this.toolBtnViewDoc_Click);
            // 
            // toolBtnSaveDoc
            // 
            this.toolBtnSaveDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSaveDoc.Image = global::DailyReportN.Properties.Resources.Export;
            this.toolBtnSaveDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSaveDoc.Name = "toolBtnSaveDoc";
            this.toolBtnSaveDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSaveDoc.Text = "Сохранить документ";
            this.toolBtnSaveDoc.Click += new System.EventHandler(this.toolBtnSaveDoc_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(12, 573);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(700, 575);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // chkApply
            // 
            this.chkApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkApply.AutoSize = true;
            this.chkApply.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetDamage, "tJ_Damage.isApply", true));
            this.chkApply.Location = new System.Drawing.Point(127, 580);
            this.chkApply.Margin = new System.Windows.Forms.Padding(2);
            this.chkApply.Name = "chkApply";
            this.chkApply.Size = new System.Drawing.Size(82, 17);
            this.chkApply.TabIndex = 3;
            this.chkApply.Text = "Исполнено";
            this.chkApply.UseVisualStyleBackColor = true;
            this.chkApply.CheckedChanged += new System.EventHandler(this.chkApply_CheckedChanged);
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(438, 581);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(77, 13);
            this.label54.TabIndex = 5;
            this.label54.Text = "Дата и время";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "col1";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.HeaderText = "Тип";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idSchmObj";
            this.dataGridViewTextBoxColumn2.HeaderText = "idSchmObj";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Оборудование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idDamage";
            this.dataGridViewTextBoxColumn4.HeaderText = "idDamage";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "col2";
            this.dataGridViewTextBoxColumn5.HeaderText = "col2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "col3";
            this.dataGridViewTextBoxColumn6.HeaderText = "col3";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idLineSection";
            this.dataGridViewTextBoxColumn7.HeaderText = "idLineSection";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dtpApply
            // 
            this.dtpApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpApply.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpApply.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Damage.DateApply", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpApply.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpApply.Location = new System.Drawing.Point(520, 576);
            this.dtpApply.Margin = new System.Windows.Forms.Padding(2);
            this.dtpApply.Name = "dtpApply";
            this.dtpApply.Size = new System.Drawing.Size(151, 20);
            this.dtpApply.TabIndex = 6;
            this.dtpApply.Value = new System.DateTime(2016, 4, 14, 9, 21, 45, 414);
            // 
            // cmbWorkerApply
            // 
            this.cmbWorkerApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbWorkerApply.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWorkerApply.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorkerApply.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idWorkerApply", true));
            this.cmbWorkerApply.FormattingEnabled = true;
            this.cmbWorkerApply.Location = new System.Drawing.Point(213, 576);
            this.cmbWorkerApply.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWorkerApply.Name = "cmbWorkerApply";
            this.cmbWorkerApply.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cmbWorkerApply.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbWorkerApply.Size = new System.Drawing.Size(222, 21);
            this.cmbWorkerApply.TabIndex = 4;
            this.cmbWorkerApply.SelectedIndexChanged += new System.EventHandler(this.cmbWorkerApply_SelectedIndexChanged);
            // 
            // bsDamage
            // 
            this.bsDamage.DataMember = "tJ_Damage";
            this.bsDamage.DataSource = this.dataSetDamage;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Image = global::DailyReportN.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(90, 573);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(28, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormActDetectionAddEdit
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(784, 608);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpApply);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.cmbWorkerApply);
            this.Controls.Add(this.chkApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(800, 597);
            this.Name = "FormActDetectionAddEdit";
            this.PermissionsSql = false;
            this.Text = "Акт расследования";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormActDetectionAddEdit_FormClosing);
            this.Load += new System.EventHandler(this.FormActDetectionAddEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxNoCrashEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoCrashMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNoCrashMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableNoCrashMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableDefection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableParametersEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableComission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVoltagePowerPlantConsumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAnnex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePersonal)).EndInit();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.tabPageDescription.ResumeLayout(false);
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDefection)).EndInit();
            this.tabPageSchm.ResumeLayout(false);
            this.tabPageSchm.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDamageCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            this.toolStripEquipment.ResumeLayout(false);
            this.toolStripEquipment.PerformLayout();
            this.tabPageComission.ResumeLayout(false);
            this.tabPageComission.PerformLayout();
            this.tabPageSpecialOpinion.ResumeLayout(false);
            this.tabPageSpecialOpinion.PerformLayout();
            this.tabPersonal.ResumeLayout(false);
            this.tabPersonal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonal)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.tabAnnex.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoltagePowerPlantConsumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVoltagePowerPlantConsumer)).EndInit();
            this.tabPageDocuments.ResumeLayout(false);
            this.tabPageDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamageDoc)).EndInit();
            this.toolStripDocuments.ResumeLayout(false);
            this.toolStripDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private TabControl tabControl1;
        private TabPage tabPageGeneral;
        private TabPage tabPageSchm;
        private Button buttonSave;
        private Button buttonCancel;
        private CheckBox chkCrash;
        private ComboBoxReadOnly cmbDivision;
        private Label label5;
        internal ComboBoxReadOnly cmbCompiler;
        private Label label4;
        internal DateTimePicker dtpDateOwner;
        private Label label3;
        private TextBox txtOwner;
        private Label label2;
        private Label label1;
        internal TextBox txtNumRequest;
        // internal DailyReportN.DataSet.dsDamage dataSetDamage;
        internal dsDamage dataSetDamage;
        private SplitContainer splitContainer1;
        private Button buttonChooseParentDamage;
        private TextBox txtParentDamage;
        private Label label6;
        private GroupBox groupBoxGeneral;
        private CheckBox chkNoOff;
        private NullableDateTimePicker dtpDateDoc;
        private Label label7;
        private GroupBox groupBoxDescription;
        internal TextBox txtSchmObj;
        private Label label9;
        private Label label8;
        private Label label10;
        internal ComboBoxReadOnly cmbOrg;
        private Label label11;
        internal ComboBoxReadOnly cmbSignCrash;
        internal ComboBoxReadOnly cmbTypeEquipment;
        private Label label12;
        internal ComboBoxReadOnly cmbReasonCrashEquipment;
        private Label label13;
        internal ComboBoxReadOnly cmbReasonCrash;
        private Label label14;
        private NullableDateTimePicker dtpEndCrashMoscow;
        private NullableDateTimePicker dtpEndCrashLocal;
        private Label label17;
        private Label label16;
        private Label label15;
        internal ComboBoxReadOnly cmbStatusBeforeCrash;
        private GroupBox groupBoxNoCrashEvents;
        internal DataGridViewExcelFilter dgvNoCrashMeasure;
        private BindingSource bsNoCrashMeasure;
        private DataTable dataTableNoCrashMeasure;
        private DataColumn dataColumn27;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private Label label18;
        internal ComboBoxReadOnly cmbStatusCurrentCrash;
        private Label label19;
        private DataTable dataTableDefection;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        internal DataGridViewExcelFilter dgvDefection;
        private BindingSource bsDefection;
        internal DataGridViewComboBoxColumn idDefectionDataGridViewTextBoxColumn;
        internal DataGridViewComboBoxColumn idNPADgvColumn;
        internal DataGridViewTextBoxColumn punctNPADataGridViewTextBoxColumn;
        internal DataGridViewComboBoxColumn idOrgDefectionDgvColumn;
        internal ComboBoxReadOnly cmbFault;
        private Label label22;
        internal ComboBoxReadOnly cmbClassifierDamage;
        private Label label21;
        internal ComboBoxReadOnly cmbReasonBeginCrash;
        private Label label20;
        private Label label23;
        private ToolStrip toolStripEquipment;
        private ToolStripButton toolBtnAddEquipment;
        private ToolStripButton toolBtnDelEquipment;
        private Label label27;
        internal ComboBoxReadOnly cmbNodeDetail;
        private Label label26;
        private ComboBoxReadOnly cmbVoltage;
        private Label label25;
        private Label label24;
        private ComboBoxReadOnly cmbParameters;
        private ComboBoxReadOnly cmbMarkEquipment;
        internal DataGridView dgvEquipment;
        private BindingSource bsDamageCharacter;
        private DataTable dataTableParametersEquipment;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn9;
        private DataColumn dataColumn10;
        private CheckBox chkAutoProtect;
        private DataColumn dataColumn11;
        private DataColumn dataColumn12;
        private Label label28;
        private ComboBoxReadOnly cmbVoltageSeti;
        private DataColumn dataColumn13;
        private Label label29;
        private TextBox txtCountDefectEquipment;
        private Label label31;
        private TextBox txtFactoryNumber;
        private Label label30;
        private TextBox txtManufacturer;
        private Label label32;
        private TextBox txtYearManufature;
        private SplitContainer splitContainer2;
        private Label label38;
        private ComboBoxReadOnly cmbClauseWork;
        private Label label37;
        private ComboBoxReadOnly cmbMaterial;
        private Label label36;
        private TextBox txtLenghtLine;
        private Label label35;
        private TextBox txtLengthOverload;
        private Label label34;
        private TextBox txtClauseFail;
        private Label label33;
        private ComboBoxReadOnly cmbNeutralState;
        private NullableDateTimePicker dtpLastDateTest;
        private Label label40;
        private ComboBoxReadOnly cmbReasonDamage;
        private Label label39;
        private ComboBoxReadOnly cmbCharacterDamage;
        private Label label42;
        private TextBox txtYearBegEquipment;
        private Label label41;
        private TextBox txtAssociatedFact;
        private Label label44;
        private Label label43;
        private TextBox txtLengthWorkEquipment;
        private Label label45;
        private NullableDateTimePicker dtpTimeRecovery;
        private TabPage tabPageComission;
        internal TextBox txtOrder;
        private Label label46;
        internal TextBox txtPostChairman;
        private Label label48;
        internal ComboBoxReadOnly cmbChairman;
        private Label label47;
        internal RichTextBox txtTotalComission;
        private Label label53;
        internal TextBox txtPostMemeber3;
        private Label label52;
        internal ComboBoxReadOnly cmbMemberComission3;
        internal TextBox txtPostMemeber2;
        private Label label51;
        internal ComboBoxReadOnly cmbMemberComission2;
        internal TextBox txtPostMemeber1;
        private Label label50;
        internal ComboBoxReadOnly cmbMemberComission1;
        private Label label49;
        private CheckBox chkApply;
        private ComboBoxReadOnly cmbWorkerApply;
        private Label label54;
        private NullableDateTimePicker dtpApply;
        private DataTable dataTableComission;
        private DataColumn dataColumn14;
        private DataColumn dataColumn15;
        private DataColumn dataColumn16;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private DataColumn dataColumn19;
        private DataColumn dataColumn20;
        private DataColumn dataColumn21;
        private DataColumn dataColumn22;
        private TabPage tabPagePrint;
        internal BindingSource bsDamage;
        private Label labelNumCrash;
        internal DataGridViewComboBoxColumn idNoCrashMeasureColumn;
        internal DataGridViewFilterDateTimePickerColumn dateCompleteDataGridViewTextBoxColumn;
        internal DataGridViewComboBoxColumn idOrgColumn;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        internal TextBox txtPostMemeber5;
        private Label label55;
        internal ComboBoxReadOnly cmbMemberComission5;
        internal TextBox txtPostMemeber4;
        private Label label56;
        internal ComboBoxReadOnly cmbMemberComission4;
        private DataColumn dataColumn23;
        private DataColumn dataColumn24;
        private DataColumn dataColumn25;
        private DataColumn dataColumn26;
        private TextBox txtNodeDetail;
        internal DataGridViewComboBoxColumn typeEquipmentDgvColumn;
        internal DataGridViewTextBoxColumn idDamCharacterDgvColumn;
        internal DataGridViewTextBoxColumn idSchmObjDgvColumn;
        internal DataGridViewTextBoxColumn schmObjDgvColumn;
        internal DataGridViewTextBoxColumn idDamageDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn col2DataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn col3DataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn schmObjNameDgvColumn;
        private TabPage tabPageDescription;
        internal RichTextBox txtReasonBeginCrash;
        internal RichTextBox txtStatusCurrentCrash;
        private Button btnOpenParentDamage;
        private Button btnRefreshDateDoc;
        private Button btnRefrshDateEndCrash;
        internal DataTable tblClassifier;
        private Button btnPrint;
        internal TextBox txtNumCrash;
        private Button btnRefreshUploadParentDoc;
        internal RichTextBox txtFault;
        internal RichTextBox txtClassifierDamage;
        private TabPage tabPersonal;
        private TabPage tabAnnex;
        private System.Windows.Forms.TabPage tabPageDocuments;
        private SplitContainer splitContainer3;
        private RichTextBox txtConsumerFullDeenergized;
        private RichTextBox txtFeedObjectsList;
        private TextBox txtCountDeEnergizedPopulation;
        private TextBox txtCountDeEnergizedSocialObjects;
        private TextBox txtCountDeEnergizedSettlements;
        private TextBox txtCountDeEnergizedRP110;
        private TextBox txtCountDeEnergizedRP35;
        private TextBox txtCountDeEnergizedTP;
        private TextBox txtPowerTotal;
        private TextBox txtCountPointsSupply;
        private Label label69;
        private Label label68;
        private Label label67;
        private Label label66;
        private Label label65;
        private Label label64;
        private Label label63;
        private Label label62;
        private Label label61;
        private Label label60;
        private Label label59;
        private Label label57;
        private RichTextBox txtConsumerPartialDeenergized;
        private DataGridView dgvVoltagePowerPlantConsumer;
        private RichTextBox txtTSONeighList;
        private Label label70;
        private Label label58;
        private DataTable dataTableVoltagePowerPlantConsumer;
        private DataColumn dataColumn28;
        private DataColumn dataColumn29;
        private DataColumn dataColumn30;
        private DataColumn dataColumn31;
        private BindingSource bsVoltagePowerPlantConsumer;
        private DataTable dataTableAnnex;
        private DataColumn dataColumnName;
        private DataColumn dataColumnValue;
        private DataTable dataTablePersonal;
        private DataColumn dataColumn32;
        private DataColumn dataColumn33;
        private ToolStrip toolStrip1;
        private ToolStripButton tspAddPersonal;
        private ToolStripButton tsbDelPersonal;
        private DataGridView dgvPersonal;
        private Label label79;
        private Panel panel1;
        private ControlsLbr.NullableDateTimePicker dtpDateLastCheck;
        private RichTextBox txtReasonError;
        private RichTextBox txtCircumstancesError;
        private TextBox txtWorkExperience;
        private Label label78;
        private Label label77;
        private Label label76;
        private Label label75;
        private TextBox txtSpecialty;
        private Label label74;
        private TextBox txtEducation;
        private Label label73;
        private TextBox txtFunction;
        private Label label72;
        private TextBox txtPlaceWork;
        private Label label71;
        private BindingSource bsPersonal;
        private DataColumn dataColumn34;
        private DataColumn dataColumn35;
        private DataColumn dataColumn36;
        private DataColumn dataColumn37;
        private DataColumn dataColumn38;
        private DataColumn dataColumn39;
        private DataColumn dataColumn40;
        private ToolStripButton toolStripButton1;
        private DataColumn dataColumn41;
        private DataColumn dataColumn42;
        private DataColumn dataColumn43;
        private DataGridViewTextBoxColumn idPersonalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idPlaceWorkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSpecialtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PersonalColumn;
        private DataGridViewTextBoxColumn PlaceWorkColumn;
        private DataGridViewTextBoxColumn SpecialtyColumn;
        private DataColumn dataColumn44;
        private DataColumn dataColumn45;
        private DataGridViewComboBoxColumn ColumnVoltage;
        private DataGridViewTextBoxColumn cat1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cat2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cat3DataGridViewTextBoxColumn;
        private NullableDateTimePicker dtpBeginCrashMoscow;
        internal System.Data.DataSet dataSetCrash;
        internal RichTextBox txtStatusBeforeCrash;
        private ToolStrip toolStripDocuments;
        private ToolStripButton toolBtnAddDoc;
        private ToolStripButton toolBtnDelDoc;
        private ToolStripButton toolBtnViewDoc;
        private ToolStripButton toolBtnSaveDoc;
        private DataGridViewExcelFilter dgvDocs;
        private BindingSource bsDamageDoc;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumnDoc;
        private DataGridViewTextBoxColumn idDamageDocDataGridViewTextBoxColumn;
        private DataGridViewImageColumn documentDataGridViewImageColumn;
        private DataGridViewLinkColumn fileNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewImageColumnNotNull ColumnImage;
        private Label label80;
        private DataColumn dataColumn46;
        private DataColumn dataColumn48;
        private DataColumn dataColumn50;
        private Label label84;
        private DataColumn dataColumn47;
        private TabPage tabPageSpecialOpinion;
        private Label lblMemberComissionSpecial3;
        private Label lblMemberComissionSpecial2;
        private Label lblMemberComissionSpecial1;
        private Label lblChairmanSpecial;
        private DataColumn dataColumn49;
        private DataColumn dataColumn51;
        private Label lblMemberComissionSpecial5;
        private Label lblMemberComissionSpecial4;
        private DataColumn dataColumn52;
        private DataColumn dataColumn53;
        private DataColumn dataColumn54;
        private DataColumn dataColumn55;
        private DataColumn dataColumn56;
        private DataColumn dataColumn57;
        internal CheckBox chkMemberComissionSpecial4;
        internal CheckBox chkMemberComissionSpecial3;
        internal CheckBox chkMemberComissionSpecial2;
        internal CheckBox chkMemberComissionSpecial1;
        internal CheckBox chkMemberComissionSpecial5;
        internal CheckBox chkChairmanSpecial;
        internal RichTextBox txtChairmanSpecial;
        internal RichTextBox txtMemberPostSpecial3;
        internal RichTextBox txtMemberPostSpecial2;
        internal RichTextBox txtMemberPostSpecial1;
        internal RichTextBox txtMemberPostSpecial5;
        internal RichTextBox txtMemberPostSpecial4;
        private DataColumn dataColumn58;
        private DataColumn dataColumn59;
        private DataColumn dataColumn60;
        private DataColumn dataColumn61;
        private DataColumn dataColumn62;
        private DataColumn dataColumn63;
        private Label label81;
        internal ComboBoxReadOnly cmbOrgCrash;
        internal ComboBoxReadOnly cmbOrgCrashEq;
        private ToolStripButton toolStripButton2;
        private Label label83;
        private Label label82;
    }
}