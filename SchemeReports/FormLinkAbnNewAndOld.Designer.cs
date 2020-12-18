using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SchemeReports
{
    partial class FormLinkAbnNewAndOld
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>resources
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeDataGridView2 = new ControlsLbr.TreeDataGridView();
            this.treeGridColumn1 = new ControlsLbr.TreeGridColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeDataGridView1 = new ControlsLbr.TreeDataGridView();
            this.Column1 = new ControlsLbr.TreeGridColumn();
            this.Column2 = new ControlsLbr.TreeGridColumn();
            this.Column3 = new ControlsLbr.TreeGridColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgLinkAbnNewAndOld = new System.ComponentModel.BackgroundWorker();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarEndLess = new ControlsLbr.ProgressBarEndLess();
            this.dgvListLegal = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAbnDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetnameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.houseDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.subnameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.busnameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.cellNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.TPConnectDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.tPrazrDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idSchmObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schmObjNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSchmAbnFull = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetScheme = new SchemeReports.DataSetScheme();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolBtnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLabelTypeSchema = new System.Windows.Forms.ToolStripLabel();
            this.toolCmbTypeSchema = new System.Windows.Forms.ToolStripComboBox();
            this.toolLabelPeriodKWT = new System.Windows.Forms.ToolStripLabel();
            this.toolBtnLoad = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvListLegalContact = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAbnContact = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAbnWithCP = new System.Windows.Forms.TabPage();
            this.dgvReportCP = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bsReportCP = new System.Windows.Forms.BindingSource(this.components);
            this.dsSchemeReport = new System.Data.DataSet();
            this.dtReportCP = new System.Data.DataTable();
            this.idAbn = new System.Data.DataColumn();
            this.codeAbonent = new System.Data.DataColumn();
            this.nameAbn = new System.Data.DataColumn();
            this.typeAbn = new System.Data.DataColumn();
            this.typeAbnName = new System.Data.DataColumn();
            this.idAbnObj = new System.Data.DataColumn();
            this.nameObj = new System.Data.DataColumn();
            this.address = new System.Data.DataColumn();
            this.kladrObjId = new System.Data.DataColumn();
            this.KladrObjName = new System.Data.DataColumn();
            this.category = new System.Data.DataColumn();
            this.categoryName = new System.Data.DataColumn();
            this.idTariff = new System.Data.DataColumn();
            this.tariffName = new System.Data.DataColumn();
            this.powerSet = new System.Data.DataColumn();
            this.powerFact = new System.Data.DataColumn();
            this.Consumer = new System.Data.DataColumn();
            this.consumerName = new System.Data.DataColumn();
            this.contact = new System.Data.DataColumn();
            this.abnNet = new System.Data.DataColumn();
            this.abnServicing = new System.Data.DataColumn();
            this.idSchmObj = new System.Data.DataColumn();
            this.idDoc = new System.Data.DataColumn();
            this.TypeDoc = new System.Data.DataColumn();
            this.TypeDocName = new System.Data.DataColumn();
            this.cellId = new System.Data.DataColumn();
            this.cellName = new System.Data.DataColumn();
            this.busId = new System.Data.DataColumn();
            this.busName = new System.Data.DataColumn();
            this.subId = new System.Data.DataColumn();
            this.subName = new System.Data.DataColumn();
            this.schmObjName = new System.Data.DataColumn();
            this.cellCPId = new System.Data.DataColumn();
            this.cellCPName = new System.Data.DataColumn();
            this.busCPId = new System.Data.DataColumn();
            this.busCPName = new System.Data.DataColumn();
            this.subCPId = new System.Data.DataColumn();
            this.subCPName = new System.Data.DataColumn();
            this.SumKWT = new System.Data.DataColumn();
            this.docAbn1 = new System.Data.DataColumn();
            this.legalAddress1 = new System.Data.DataColumn();
            this.postAddress1 = new System.Data.DataColumn();
            this.Meter = new System.Data.DataColumn();
            this.CountMeter = new System.Data.DataColumn();
            this.listNodes = new System.Data.DataColumn();
            this.listNodesDown = new System.Data.DataColumn();
            this.highestVoltageClass = new System.Data.DataColumn();
            this.voltageClass = new System.Data.DataColumn();
            this.is811 = new System.Data.DataColumn();
            this.tabPageLegal = new System.Windows.Forms.TabPage();
            this.tabPage811 = new System.Windows.Forms.TabPage();
            this.dgvReport811 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.subCPNameDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.listNodesDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.subNameDataGridViewTextBoxColumn2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.highestVoltageClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listNodesDownDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.voltageClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Всего = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.categoryReliabilityFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryReliabilitySecondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryReliabilityThirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelVoltageHVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelVoltageSV1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelVoltageSV2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelVoltageLVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkOrganizationsDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Commnets = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.bsReport811 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage811_2019 = new System.Windows.Forms.TabPage();
            this.dgvReport811_2019 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.subCPNameDataGridViewTextBoxColumn1_2019 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.listNodesDataGridViewTextBoxColumn1_2019 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.subNameDataGridViewTextBoxColumn2_2019 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.highestVoltageClassDataGridViewTextBoxColumn_2019 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listNodesDownDataGridViewTextBoxColumn1_2019 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.voltageClassDataGridViewTextBoxColumn_2019 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Всего_2019 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.categoryReliabilityFirstDataGridViewTextBoxColumn_2019 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryReliabilitySecondDataGridViewTextBoxColumn_2019 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryReliabilityThirdDataGridViewTextBoxColumn_2019 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelVoltageHVDataGridViewTextBoxColumn_2019 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelVoltageSV1DataGridViewTextBoxColumn_2019 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelVoltageSV2DataGridViewTextBoxColumn_2019 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelVoltageLVDataGridViewTextBoxColumn_2019 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkOrganizationsDataGridViewTextBoxColumn_2019 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Commnets_2019 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.bsReport811_2019 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageNominalPowerCP = new System.Windows.Forms.TabPage();
            this.dgvNominalPowerCP = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.subCPNameDataGridViewTextBoxColumn11 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.powerSetDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.listNodesDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsNominalPowerCP = new System.Windows.Forms.BindingSource(this.components);
            this.bgLinkAbnWithCP = new System.ComponentModel.BackgroundWorker();
            this.bgLinkAbnWithCP_2019 = new System.ComponentModel.BackgroundWorker();
            this.bgNominalPowerCP = new System.ComponentModel.BackgroundWorker();
            this.dsSchemeReports1 = new SchemeReports.DataSetScheme();
            this.dataColumnNumDoc = new System.Data.DataColumn();
            this.dataColumnDateDoc = new System.Data.DataColumn();
            this.dataColumnEmergencyReserv = new System.Data.DataColumn();
            this.dataColumnTechnologicalReserv = new System.Data.DataColumn();
            this.subCPNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.cellCPNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.subNameDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.busNameDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.cellNameDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.docAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameAbnDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAbnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAbnNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legalAddress = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.postAddress = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrObjIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrObjNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idTariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.powerSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerFactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumKWTDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumerNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abnNetDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.abnServicingDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idSchmObjDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schmObjNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellCPIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busCPIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busCPNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCPIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listNodesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listNodesDownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumDocActApproval = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.ColumnDateDocActApproval = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.ColumnEmergencyReserv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.ColumnTechnologicalReserv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDataGridView1)).BeginInit();
            this.panelProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLegal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSchmAbnFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheme)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLegalContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnContact)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAbnWithCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReportCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSchemeReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtReportCP)).BeginInit();
            this.tabPageLegal.SuspendLayout();
            this.tabPage811.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport811)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReport811)).BeginInit();
            this.tabPage811_2019.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport811_2019)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReport811_2019)).BeginInit();
            this.tabPageNominalPowerCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominalPowerCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNominalPowerCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSchemeReports1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeDataGridView2
            // 
            this.treeDataGridView2.AllowUserToAddRows = false;
            this.treeDataGridView2.AllowUserToDeleteRows = false;
            this.treeDataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.treeDataGridView2.ImageList = null;
            this.treeDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.treeDataGridView2.Name = "treeDataGridView2";
            this.treeDataGridView2.Size = new System.Drawing.Size(240, 150);
            this.treeDataGridView2.TabIndex = 0;
            // 
            // treeGridColumn1
            // 
            this.treeGridColumn1.DefaultNodeImage = null;
            this.treeGridColumn1.Name = "treeGridColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column4";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // treeDataGridView1
            // 
            this.treeDataGridView1.AllowUserToAddRows = false;
            this.treeDataGridView1.AllowUserToDeleteRows = false;
            this.treeDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.treeDataGridView1.ImageList = null;
            this.treeDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.treeDataGridView1.Name = "treeDataGridView1";
            this.treeDataGridView1.Size = new System.Drawing.Size(240, 150);
            this.treeDataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DefaultNodeImage = null;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DefaultNodeImage = null;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DefaultNodeImage = null;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bgLinkAbnNewAndOld
            // 
            this.bgLinkAbnNewAndOld.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLinkAbnNewAndOld_DoWork);
            this.bgLinkAbnNewAndOld.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLinkAbnNewAndOld_RunWorkerCompleted);
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.SystemColors.Control;
            this.panelProgress.Controls.Add(this.label3);
            this.panelProgress.Controls.Add(this.progressBarEndLess);
            this.panelProgress.Location = new System.Drawing.Point(272, 209);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(431, 74);
            this.panelProgress.TabIndex = 7;
            this.panelProgress.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Подождите... Идет загрузка из базы";
            // 
            // progressBarEndLess
            // 
            this.progressBarEndLess.AutoProgressSpeed = 130;
            this.progressBarEndLess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarEndLess.Location = new System.Drawing.Point(0, 39);
            this.progressBarEndLess.Name = "progressBarEndLess";
            this.progressBarEndLess.NormalImage = global::SchemeReports.Properties.Resources.NormalImage;
            this.progressBarEndLess.PointImage = global::SchemeReports.Properties.Resources.PointImage;
            this.progressBarEndLess.Position = 0;
            this.progressBarEndLess.ProgressBoxStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessBoxStyleConstants.SolidSameSize;
            this.progressBarEndLess.ProgressStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessStyleConstants.LeftAndRight;
            this.progressBarEndLess.ProgressType = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessTypeConstants.GraphicType;
            this.progressBarEndLess.Size = new System.Drawing.Size(431, 35);
            this.progressBarEndLess.TabIndex = 5;
            // 
            // dgvListLegal
            // 
            this.dgvListLegal.AllowUserToAddRows = false;
            this.dgvListLegal.AllowUserToDeleteRows = false;
            this.dgvListLegal.AutoGenerateColumns = false;
            this.dgvListLegal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLegal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonentDataGridViewTextBoxColumn1,
            this.idAbnDataGridViewTextBoxColumn,
            this.nameAbnDataGridViewTextBoxColumn1,
            this.typeAbnDataGridViewTextBoxColumn,
            this.nameObjDataGridViewTextBoxColumn1,
            this.idAbnObjDataGridViewTextBoxColumn,
            this.streetnameDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn1,
            this.subnameDataGridViewTextBoxColumn,
            this.busnameDataGridViewTextBoxColumn,
            this.cellNameDataGridViewTextBoxColumn,
            this.TPConnectDgvColumn,
            this.tPrazrDgvColumn,
            this.idSchmObjDataGridViewTextBoxColumn,
            this.cellIdDataGridViewTextBoxColumn,
            this.busidDataGridViewTextBoxColumn,
            this.subidDataGridViewTextBoxColumn,
            this.schmObjNameDataGridViewTextBoxColumn});
            this.dgvListLegal.DataSource = this.bsSchmAbnFull;
            this.dgvListLegal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListLegal.Location = new System.Drawing.Point(0, 0);
            this.dgvListLegal.Name = "dgvListLegal";
            this.dgvListLegal.ReadOnly = true;
            this.dgvListLegal.Size = new System.Drawing.Size(961, 216);
            this.dgvListLegal.TabIndex = 8;
            // 
            // codeAbonentDataGridViewTextBoxColumn1
            // 
            this.codeAbonentDataGridViewTextBoxColumn1.DataPropertyName = "codeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn1.HeaderText = "№ договора";
            this.codeAbonentDataGridViewTextBoxColumn1.Name = "codeAbonentDataGridViewTextBoxColumn1";
            this.codeAbonentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeAbonentDataGridViewTextBoxColumn1.Width = 70;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameAbnDataGridViewTextBoxColumn1
            // 
            this.nameAbnDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameAbnDataGridViewTextBoxColumn1.DataPropertyName = "nameAbn";
            this.nameAbnDataGridViewTextBoxColumn1.HeaderText = "Абонент";
            this.nameAbnDataGridViewTextBoxColumn1.Name = "nameAbnDataGridViewTextBoxColumn1";
            this.nameAbnDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameAbnDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeAbnDataGridViewTextBoxColumn
            // 
            this.typeAbnDataGridViewTextBoxColumn.DataPropertyName = "typeAbn";
            this.typeAbnDataGridViewTextBoxColumn.HeaderText = "typeAbn";
            this.typeAbnDataGridViewTextBoxColumn.Name = "typeAbnDataGridViewTextBoxColumn";
            this.typeAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameObjDataGridViewTextBoxColumn1
            // 
            this.nameObjDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameObjDataGridViewTextBoxColumn1.DataPropertyName = "nameObj";
            this.nameObjDataGridViewTextBoxColumn1.HeaderText = "Объект";
            this.nameObjDataGridViewTextBoxColumn1.Name = "nameObjDataGridViewTextBoxColumn1";
            this.nameObjDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameObjDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idAbnObjDataGridViewTextBoxColumn
            // 
            this.idAbnObjDataGridViewTextBoxColumn.DataPropertyName = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.HeaderText = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.idAbnObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // streetnameDataGridViewTextBoxColumn
            // 
            this.streetnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.streetnameDataGridViewTextBoxColumn.DataPropertyName = "streetname";
            this.streetnameDataGridViewTextBoxColumn.FillWeight = 70F;
            this.streetnameDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetnameDataGridViewTextBoxColumn.Name = "streetnameDataGridViewTextBoxColumn";
            this.streetnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // houseDataGridViewTextBoxColumn1
            // 
            this.houseDataGridViewTextBoxColumn1.DataPropertyName = "house";
            this.houseDataGridViewTextBoxColumn1.HeaderText = "Дом";
            this.houseDataGridViewTextBoxColumn1.Name = "houseDataGridViewTextBoxColumn1";
            this.houseDataGridViewTextBoxColumn1.ReadOnly = true;
            this.houseDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // subnameDataGridViewTextBoxColumn
            // 
            this.subnameDataGridViewTextBoxColumn.DataPropertyName = "subname";
            this.subnameDataGridViewTextBoxColumn.HeaderText = "ПС";
            this.subnameDataGridViewTextBoxColumn.Name = "subnameDataGridViewTextBoxColumn";
            this.subnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.subnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subnameDataGridViewTextBoxColumn.Width = 65;
            // 
            // busnameDataGridViewTextBoxColumn
            // 
            this.busnameDataGridViewTextBoxColumn.DataPropertyName = "busname";
            this.busnameDataGridViewTextBoxColumn.HeaderText = "Шина";
            this.busnameDataGridViewTextBoxColumn.Name = "busnameDataGridViewTextBoxColumn";
            this.busnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.busnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.busnameDataGridViewTextBoxColumn.Visible = false;
            this.busnameDataGridViewTextBoxColumn.Width = 55;
            // 
            // cellNameDataGridViewTextBoxColumn
            // 
            this.cellNameDataGridViewTextBoxColumn.DataPropertyName = "CellName";
            this.cellNameDataGridViewTextBoxColumn.HeaderText = "Ячейка";
            this.cellNameDataGridViewTextBoxColumn.Name = "cellNameDataGridViewTextBoxColumn";
            this.cellNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cellNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellNameDataGridViewTextBoxColumn.Visible = false;
            this.cellNameDataGridViewTextBoxColumn.Width = 55;
            // 
            // TPConnectDgvColumn
            // 
            this.TPConnectDgvColumn.Name = "TPConnectDgvColumn";
            this.TPConnectDgvColumn.ReadOnly = true;
            // 
            // tPrazrDgvColumn
            // 
            this.tPrazrDgvColumn.Name = "tPrazrDgvColumn";
            this.tPrazrDgvColumn.ReadOnly = true;
            // 
            // idSchmObjDataGridViewTextBoxColumn
            // 
            this.idSchmObjDataGridViewTextBoxColumn.DataPropertyName = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.HeaderText = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.Name = "idSchmObjDataGridViewTextBoxColumn";
            this.idSchmObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSchmObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // cellIdDataGridViewTextBoxColumn
            // 
            this.cellIdDataGridViewTextBoxColumn.DataPropertyName = "cellId";
            this.cellIdDataGridViewTextBoxColumn.HeaderText = "cellId";
            this.cellIdDataGridViewTextBoxColumn.Name = "cellIdDataGridViewTextBoxColumn";
            this.cellIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cellIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // busidDataGridViewTextBoxColumn
            // 
            this.busidDataGridViewTextBoxColumn.DataPropertyName = "busid";
            this.busidDataGridViewTextBoxColumn.HeaderText = "busid";
            this.busidDataGridViewTextBoxColumn.Name = "busidDataGridViewTextBoxColumn";
            this.busidDataGridViewTextBoxColumn.ReadOnly = true;
            this.busidDataGridViewTextBoxColumn.Visible = false;
            // 
            // subidDataGridViewTextBoxColumn
            // 
            this.subidDataGridViewTextBoxColumn.DataPropertyName = "subid";
            this.subidDataGridViewTextBoxColumn.HeaderText = "subid";
            this.subidDataGridViewTextBoxColumn.Name = "subidDataGridViewTextBoxColumn";
            this.subidDataGridViewTextBoxColumn.ReadOnly = true;
            this.subidDataGridViewTextBoxColumn.Visible = false;
            // 
            // schmObjNameDataGridViewTextBoxColumn
            // 
            this.schmObjNameDataGridViewTextBoxColumn.DataPropertyName = "schmObjName";
            this.schmObjNameDataGridViewTextBoxColumn.HeaderText = "schmObjName";
            this.schmObjNameDataGridViewTextBoxColumn.Name = "schmObjNameDataGridViewTextBoxColumn";
            this.schmObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.schmObjNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsSchmAbnFull
            // 
            this.bsSchmAbnFull.DataMember = "vL_SchmAbnFull";
            this.bsSchmAbnFull.DataSource = this.dataSetScheme;
            this.bsSchmAbnFull.CurrentChanged += new System.EventHandler(this.bsSchmAbnFullCurrentChanged);
            // 
            // dataSetScheme
            // 
            this.dataSetScheme.DataSetName = "DataSetScheme";
            this.dataSetScheme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnRefresh,
            this.toolBtnExportExcel,
            this.toolStripSeparator1,
            this.toolLabelTypeSchema,
            this.toolCmbTypeSchema,
            this.toolLabelPeriodKWT,
            this.toolBtnLoad});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(975, 25);
            this.toolStrip.TabIndex = 9;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolBtnRefresh
            // 
            this.toolBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefresh.Image = global::SchemeReports.Properties.Resources.Refresh;
            this.toolBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRefresh.Text = "Обновить";
            this.toolBtnRefresh.Click += new System.EventHandler(this.toolBtnRefresh_Click);
            // 
            // toolBtnExportExcel
            // 
            this.toolBtnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnExportExcel.Image = global::SchemeReports.Properties.Resources.Excel;
            this.toolBtnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnExportExcel.Name = "toolBtnExportExcel";
            this.toolBtnExportExcel.Size = new System.Drawing.Size(23, 22);
            this.toolBtnExportExcel.Text = "Выгрузка в эксель";
            this.toolBtnExportExcel.Click += new System.EventHandler(this.toolBtnExportExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolLabelTypeSchema
            // 
            this.toolLabelTypeSchema.Name = "toolLabelTypeSchema";
            this.toolLabelTypeSchema.Size = new System.Drawing.Size(41, 22);
            this.toolLabelTypeSchema.Text = "Схема";
            // 
            // toolCmbTypeSchema
            // 
            this.toolCmbTypeSchema.Items.AddRange(new object[] {
            "Оперативная схема",
            "По точкам токоразделов"});
            this.toolCmbTypeSchema.Name = "toolCmbTypeSchema";
            this.toolCmbTypeSchema.Size = new System.Drawing.Size(121, 25);
            // 
            // toolLabelPeriodKWT
            // 
            this.toolLabelPeriodKWT.Name = "toolLabelPeriodKWT";
            this.toolLabelPeriodKWT.Size = new System.Drawing.Size(119, 22);
            this.toolLabelPeriodKWT.Text = "Период начислений";
            // 
            // toolBtnLoad
            // 
            this.toolBtnLoad.Image = global::SchemeReports.Properties.Resources.Play;
            this.toolBtnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnLoad.Name = "toolBtnLoad";
            this.toolBtnLoad.Size = new System.Drawing.Size(111, 22);
            this.toolBtnLoad.Text = "Сформировать";
            this.toolBtnLoad.Click += new System.EventHandler(this.toolBtnLoad_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvListLegal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvListLegalContact);
            this.splitContainer1.Size = new System.Drawing.Size(961, 436);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 10;
            // 
            // dgvListLegalContact
            // 
            this.dgvListLegalContact.AllowUserToAddRows = false;
            this.dgvListLegalContact.AllowUserToDeleteRows = false;
            this.dgvListLegalContact.AllowUserToResizeRows = false;
            this.dgvListLegalContact.AutoGenerateColumns = false;
            this.dgvListLegalContact.BackgroundColor = System.Drawing.Color.White;
            this.dgvListLegalContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLegalContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dgvListLegalContact.DataSource = this.bsAbnContact;
            this.dgvListLegalContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListLegalContact.Location = new System.Drawing.Point(0, 0);
            this.dgvListLegalContact.MultiSelect = false;
            this.dgvListLegalContact.Name = "dgvListLegalContact";
            this.dgvListLegalContact.ReadOnly = true;
            this.dgvListLegalContact.RowHeadersWidth = 21;
            this.dgvListLegalContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListLegalContact.Size = new System.Drawing.Size(961, 216);
            this.dgvListLegalContact.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn5.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Post";
            this.dataGridViewTextBoxColumn6.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "F";
            this.dataGridViewTextBoxColumn7.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "I";
            this.dataGridViewTextBoxColumn8.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "O";
            this.dataGridViewTextBoxColumn9.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn10.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DateChange";
            this.dataGridViewTextBoxColumn11.HeaderText = "DateChange";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn12.HeaderText = "Коментарий";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn13.HeaderText = "e`mail";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // bsAbnContact
            // 
            this.bsAbnContact.DataMember = "tAbnContact";
            this.bsAbnContact.DataSource = this.dataSetScheme;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAbnWithCP);
            this.tabControl1.Controls.Add(this.tabPageLegal);
            this.tabControl1.Controls.Add(this.tabPage811);
            this.tabControl1.Controls.Add(this.tabPage811_2019);
            this.tabControl1.Controls.Add(this.tabPageNominalPowerCP);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 468);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageAbnWithCP
            // 
            this.tabPageAbnWithCP.Controls.Add(this.dgvReportCP);
            this.tabPageAbnWithCP.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbnWithCP.Name = "tabPageAbnWithCP";
            this.tabPageAbnWithCP.Size = new System.Drawing.Size(967, 442);
            this.tabPageAbnWithCP.TabIndex = 1;
            this.tabPageAbnWithCP.Text = "Привязка к питающим центрам";
            this.tabPageAbnWithCP.UseVisualStyleBackColor = true;
            // 
            // dgvReportCP
            // 
            this.dgvReportCP.AllowUserToAddRows = false;
            this.dgvReportCP.AllowUserToDeleteRows = false;
            this.dgvReportCP.AutoGenerateColumns = false;
            this.dgvReportCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportCP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subCPNameDataGridViewTextBoxColumn,
            this.cellCPNameDataGridViewTextBoxColumn,
            this.subNameDataGridViewTextBoxColumn1,
            this.busNameDataGridViewTextBoxColumn1,
            this.cellNameDataGridViewTextBoxColumn1,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.docAbn,
            this.nameAbnDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn1,
            this.typeAbnDataGridViewTextBoxColumn1,
            this.typeAbnNameDataGridViewTextBoxColumn,
            this.idAbnObjDataGridViewTextBoxColumn1,
            this.legalAddress,
            this.postAddress,
            this.nameObjDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.kladrObjIdDataGridViewTextBoxColumn,
            this.kladrObjNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.idTariffDataGridViewTextBoxColumn,
            this.tariffNameDataGridViewTextBoxColumn,
            this.powerSetDataGridViewTextBoxColumn,
            this.powerFactDataGridViewTextBoxColumn,
            this.consumerDataGridViewTextBoxColumn,
            this.sumKWTDgvColumn,
            this.consumerNameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.abnNetDataGridViewTextBoxColumn,
            this.abnServicingDataGridViewTextBoxColumn,
            this.idSchmObjDataGridViewTextBoxColumn1,
            this.idDocDataGridViewTextBoxColumn,
            this.typeDocDataGridViewTextBoxColumn,
            this.typeDocNameDataGridViewTextBoxColumn,
            this.cellIdDataGridViewTextBoxColumn1,
            this.busIdDataGridViewTextBoxColumn1,
            this.subIdDataGridViewTextBoxColumn1,
            this.schmObjNameDataGridViewTextBoxColumn1,
            this.cellCPIdDataGridViewTextBoxColumn,
            this.busCPIdDataGridViewTextBoxColumn,
            this.busCPNameDataGridViewTextBoxColumn,
            this.subCPIdDataGridViewTextBoxColumn,
            this.meterDataGridViewTextBoxColumn,
            this.countMeterDataGridViewTextBoxColumn,
            this.listNodesDataGridViewTextBoxColumn,
            this.listNodesDownDataGridViewTextBoxColumn,
            this.ColumnNumDocActApproval,
            this.ColumnDateDocActApproval,
            this.ColumnEmergencyReserv,
            this.ColumnTechnologicalReserv});
            this.dgvReportCP.DataSource = this.bsReportCP;
            this.dgvReportCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportCP.Location = new System.Drawing.Point(0, 0);
            this.dgvReportCP.Name = "dgvReportCP";
            this.dgvReportCP.ReadOnly = true;
            this.dgvReportCP.Size = new System.Drawing.Size(967, 442);
            this.dgvReportCP.TabIndex = 0;
            this.dgvReportCP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportCP_CellClick);
            this.dgvReportCP.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvReportCP_RowPostPaint);
            // 
            // bsReportCP
            // 
            this.bsReportCP.DataMember = "dtReportCP";
            this.bsReportCP.DataSource = this.dsSchemeReport;
            // 
            // dsSchemeReport
            // 
            this.dsSchemeReport.DataSetName = "NewDataSet";
            this.dsSchemeReport.Tables.AddRange(new System.Data.DataTable[] {
            this.dtReportCP});
            // 
            // dtReportCP
            // 
            this.dtReportCP.Columns.AddRange(new System.Data.DataColumn[] {
            this.idAbn,
            this.codeAbonent,
            this.nameAbn,
            this.typeAbn,
            this.typeAbnName,
            this.idAbnObj,
            this.nameObj,
            this.address,
            this.kladrObjId,
            this.KladrObjName,
            this.category,
            this.categoryName,
            this.idTariff,
            this.tariffName,
            this.powerSet,
            this.powerFact,
            this.Consumer,
            this.consumerName,
            this.contact,
            this.abnNet,
            this.abnServicing,
            this.idSchmObj,
            this.idDoc,
            this.TypeDoc,
            this.TypeDocName,
            this.cellId,
            this.cellName,
            this.busId,
            this.busName,
            this.subId,
            this.subName,
            this.schmObjName,
            this.cellCPId,
            this.cellCPName,
            this.busCPId,
            this.busCPName,
            this.subCPId,
            this.subCPName,
            this.SumKWT,
            this.docAbn1,
            this.legalAddress1,
            this.postAddress1,
            this.Meter,
            this.CountMeter,
            this.listNodes,
            this.listNodesDown,
            this.highestVoltageClass,
            this.voltageClass,
            this.is811,
            this.dataColumnNumDoc,
            this.dataColumnDateDoc,
            this.dataColumnEmergencyReserv,
            this.dataColumnTechnologicalReserv});
            this.dtReportCP.TableName = "dtReportCP";
            // 
            // idAbn
            // 
            this.idAbn.ColumnName = "idAbn";
            this.idAbn.DataType = typeof(int);
            // 
            // codeAbonent
            // 
            this.codeAbonent.ColumnName = "codeAbonent";
            this.codeAbonent.DataType = typeof(int);
            // 
            // nameAbn
            // 
            this.nameAbn.ColumnName = "nameAbn";
            // 
            // typeAbn
            // 
            this.typeAbn.ColumnName = "typeAbn";
            this.typeAbn.DataType = typeof(int);
            // 
            // typeAbnName
            // 
            this.typeAbnName.ColumnName = "typeAbnName";
            // 
            // idAbnObj
            // 
            this.idAbnObj.ColumnName = "idAbnObj";
            this.idAbnObj.DataType = typeof(int);
            // 
            // nameObj
            // 
            this.nameObj.ColumnName = "nameObj";
            // 
            // address
            // 
            this.address.ColumnName = "address";
            // 
            // kladrObjId
            // 
            this.kladrObjId.ColumnName = "kladrObjId";
            this.kladrObjId.DataType = typeof(int);
            // 
            // KladrObjName
            // 
            this.KladrObjName.ColumnName = "KladrObjName";
            // 
            // category
            // 
            this.category.ColumnName = "category";
            this.category.DataType = typeof(int);
            // 
            // categoryName
            // 
            this.categoryName.ColumnName = "categoryName";
            // 
            // idTariff
            // 
            this.idTariff.ColumnName = "idTariff";
            this.idTariff.DataType = typeof(int);
            // 
            // tariffName
            // 
            this.tariffName.ColumnName = "tariffName";
            // 
            // powerSet
            // 
            this.powerSet.ColumnName = "powerSet";
            this.powerSet.DataType = typeof(decimal);
            // 
            // powerFact
            // 
            this.powerFact.ColumnName = "powerFact";
            this.powerFact.DataType = typeof(decimal);
            // 
            // Consumer
            // 
            this.Consumer.ColumnName = "Consumer";
            this.Consumer.DataType = typeof(int);
            // 
            // consumerName
            // 
            this.consumerName.ColumnName = "consumerName";
            // 
            // contact
            // 
            this.contact.ColumnName = "contact";
            // 
            // abnNet
            // 
            this.abnNet.ColumnName = "abnNet";
            // 
            // abnServicing
            // 
            this.abnServicing.ColumnName = "abnServicing";
            // 
            // idSchmObj
            // 
            this.idSchmObj.ColumnName = "idSchmObj";
            this.idSchmObj.DataType = typeof(int);
            // 
            // idDoc
            // 
            this.idDoc.ColumnName = "idDoc";
            this.idDoc.DataType = typeof(int);
            // 
            // TypeDoc
            // 
            this.TypeDoc.ColumnName = "TypeDoc";
            this.TypeDoc.DataType = typeof(int);
            // 
            // TypeDocName
            // 
            this.TypeDocName.ColumnName = "TypeDocName";
            // 
            // cellId
            // 
            this.cellId.ColumnName = "cellId";
            this.cellId.DataType = typeof(int);
            // 
            // cellName
            // 
            this.cellName.ColumnName = "cellName";
            // 
            // busId
            // 
            this.busId.ColumnName = "busId";
            this.busId.DataType = typeof(int);
            // 
            // busName
            // 
            this.busName.ColumnName = "busName";
            // 
            // subId
            // 
            this.subId.ColumnName = "subId";
            this.subId.DataType = typeof(int);
            // 
            // subName
            // 
            this.subName.ColumnName = "subName";
            // 
            // schmObjName
            // 
            this.schmObjName.ColumnName = "schmObjName";
            // 
            // cellCPId
            // 
            this.cellCPId.ColumnName = "cellCPId";
            // 
            // cellCPName
            // 
            this.cellCPName.ColumnName = "cellCPName";
            // 
            // busCPId
            // 
            this.busCPId.ColumnName = "busCPId";
            // 
            // busCPName
            // 
            this.busCPName.ColumnName = "busCPName";
            // 
            // subCPId
            // 
            this.subCPId.ColumnName = "subCPId";
            // 
            // subCPName
            // 
            this.subCPName.ColumnName = "subCPName";
            // 
            // SumKWT
            // 
            this.SumKWT.ColumnName = "SumKWT";
            this.SumKWT.DataType = typeof(int);
            // 
            // docAbn1
            // 
            this.docAbn1.ColumnName = "docAbn";
            // 
            // legalAddress1
            // 
            this.legalAddress1.ColumnName = "legalAddress";
            // 
            // postAddress1
            // 
            this.postAddress1.ColumnName = "postAddress";
            // 
            // Meter
            // 
            this.Meter.ColumnName = "Meter";
            this.Meter.DataType = typeof(int);
            // 
            // CountMeter
            // 
            this.CountMeter.ColumnName = "CountMeter";
            this.CountMeter.DataType = typeof(int);
            // 
            // listNodes
            // 
            this.listNodes.ColumnName = "listNodes";
            // 
            // listNodesDown
            // 
            this.listNodesDown.ColumnName = "listNodesDown";
            // 
            // highestVoltageClass
            // 
            this.highestVoltageClass.ColumnName = "highestVoltageClass";
            // 
            // voltageClass
            // 
            this.voltageClass.ColumnName = "voltageClass";
            // 
            // is811
            // 
            this.is811.ColumnName = "is811";
            this.is811.DataType = typeof(bool);
            this.is811.DefaultValue = true;
            // 
            // tabPageLegal
            // 
            this.tabPageLegal.Controls.Add(this.splitContainer1);
            this.tabPageLegal.Location = new System.Drawing.Point(4, 22);
            this.tabPageLegal.Name = "tabPageLegal";
            this.tabPageLegal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLegal.Size = new System.Drawing.Size(967, 442);
            this.tabPageLegal.TabIndex = 0;
            this.tabPageLegal.Text = "Юридические лица";
            this.tabPageLegal.UseVisualStyleBackColor = true;
            // 
            // tabPage811
            // 
            this.tabPage811.Controls.Add(this.dgvReport811);
            this.tabPage811.Location = new System.Drawing.Point(4, 22);
            this.tabPage811.Name = "tabPage811";
            this.tabPage811.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage811.Size = new System.Drawing.Size(967, 442);
            this.tabPage811.TabIndex = 0;
            this.tabPage811.Text = "Ведомость присоединений";
            this.tabPage811.UseVisualStyleBackColor = true;
            // 
            // dgvReport811
            // 
            this.dgvReport811.AllowUserToAddRows = false;
            this.dgvReport811.AllowUserToDeleteRows = false;
            this.dgvReport811.AutoGenerateColumns = false;
            this.dgvReport811.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport811.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subCPNameDataGridViewTextBoxColumn1,
            this.listNodesDataGridViewTextBoxColumn1,
            this.subNameDataGridViewTextBoxColumn2,
            this.highestVoltageClassDataGridViewTextBoxColumn,
            this.listNodesDownDataGridViewTextBoxColumn1,
            this.voltageClassDataGridViewTextBoxColumn,
            this.Всего,
            this.categoryReliabilityFirstDataGridViewTextBoxColumn,
            this.categoryReliabilitySecondDataGridViewTextBoxColumn,
            this.categoryReliabilityThirdDataGridViewTextBoxColumn,
            this.levelVoltageHVDataGridViewTextBoxColumn,
            this.levelVoltageSV1DataGridViewTextBoxColumn,
            this.levelVoltageSV2DataGridViewTextBoxColumn,
            this.levelVoltageLVDataGridViewTextBoxColumn,
            this.networkOrganizationsDataGridViewTextBoxColumn,
            this.Commnets});
            this.dgvReport811.DataSource = this.bsReport811;
            this.dgvReport811.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport811.Location = new System.Drawing.Point(3, 3);
            this.dgvReport811.Name = "dgvReport811";
            this.dgvReport811.ReadOnly = true;
            this.dgvReport811.Size = new System.Drawing.Size(961, 436);
            this.dgvReport811.TabIndex = 0;
            // 
            // subCPNameDataGridViewTextBoxColumn1
            // 
            this.subCPNameDataGridViewTextBoxColumn1.DataPropertyName = "subCPName";
            this.subCPNameDataGridViewTextBoxColumn1.HeaderText = "ЦП";
            this.subCPNameDataGridViewTextBoxColumn1.Name = "subCPNameDataGridViewTextBoxColumn1";
            this.subCPNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.subCPNameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // listNodesDataGridViewTextBoxColumn1
            // 
            this.listNodesDataGridViewTextBoxColumn1.DataPropertyName = "listNodes";
            this.listNodesDataGridViewTextBoxColumn1.HeaderText = "Запитка";
            this.listNodesDataGridViewTextBoxColumn1.Name = "listNodesDataGridViewTextBoxColumn1";
            this.listNodesDataGridViewTextBoxColumn1.ReadOnly = true;
            this.listNodesDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listNodesDataGridViewTextBoxColumn1.Width = 200;
            // 
            // subNameDataGridViewTextBoxColumn2
            // 
            this.subNameDataGridViewTextBoxColumn2.DataPropertyName = "subName";
            this.subNameDataGridViewTextBoxColumn2.HeaderText = "ПС";
            this.subNameDataGridViewTextBoxColumn2.Name = "subNameDataGridViewTextBoxColumn2";
            this.subNameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.subNameDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // highestVoltageClassDataGridViewTextBoxColumn
            // 
            this.highestVoltageClassDataGridViewTextBoxColumn.DataPropertyName = "HighestVoltageClass";
            this.highestVoltageClassDataGridViewTextBoxColumn.HeaderText = "Высший класс напряжения";
            this.highestVoltageClassDataGridViewTextBoxColumn.Name = "highestVoltageClassDataGridViewTextBoxColumn";
            this.highestVoltageClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.highestVoltageClassDataGridViewTextBoxColumn.Width = 75;
            // 
            // listNodesDownDataGridViewTextBoxColumn1
            // 
            this.listNodesDownDataGridViewTextBoxColumn1.DataPropertyName = "listNodesDown";
            this.listNodesDownDataGridViewTextBoxColumn1.HeaderText = "Запитка абонента";
            this.listNodesDownDataGridViewTextBoxColumn1.Name = "listNodesDownDataGridViewTextBoxColumn1";
            this.listNodesDownDataGridViewTextBoxColumn1.ReadOnly = true;
            this.listNodesDownDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listNodesDownDataGridViewTextBoxColumn1.Width = 150;
            // 
            // voltageClassDataGridViewTextBoxColumn
            // 
            this.voltageClassDataGridViewTextBoxColumn.DataPropertyName = "VoltageClass";
            this.voltageClassDataGridViewTextBoxColumn.HeaderText = "Класс напряжения";
            this.voltageClassDataGridViewTextBoxColumn.Name = "voltageClassDataGridViewTextBoxColumn";
            this.voltageClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.voltageClassDataGridViewTextBoxColumn.Width = 75;
            // 
            // Всего
            // 
            this.Всего.DataPropertyName = "MeterAll";
            this.Всего.HeaderText = "Всего";
            this.Всего.Name = "Всего";
            this.Всего.ReadOnly = true;
            this.Всего.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Всего.Width = 40;
            // 
            // categoryReliabilityFirstDataGridViewTextBoxColumn
            // 
            this.categoryReliabilityFirstDataGridViewTextBoxColumn.DataPropertyName = "CategoryReliabilityFirst";
            this.categoryReliabilityFirstDataGridViewTextBoxColumn.HeaderText = "I";
            this.categoryReliabilityFirstDataGridViewTextBoxColumn.Name = "categoryReliabilityFirstDataGridViewTextBoxColumn";
            this.categoryReliabilityFirstDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryReliabilityFirstDataGridViewTextBoxColumn.Width = 25;
            // 
            // categoryReliabilitySecondDataGridViewTextBoxColumn
            // 
            this.categoryReliabilitySecondDataGridViewTextBoxColumn.DataPropertyName = "CategoryReliabilitySecond";
            this.categoryReliabilitySecondDataGridViewTextBoxColumn.HeaderText = "II";
            this.categoryReliabilitySecondDataGridViewTextBoxColumn.Name = "categoryReliabilitySecondDataGridViewTextBoxColumn";
            this.categoryReliabilitySecondDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryReliabilitySecondDataGridViewTextBoxColumn.Width = 25;
            // 
            // categoryReliabilityThirdDataGridViewTextBoxColumn
            // 
            this.categoryReliabilityThirdDataGridViewTextBoxColumn.DataPropertyName = "CategoryReliabilityThird";
            this.categoryReliabilityThirdDataGridViewTextBoxColumn.HeaderText = "III";
            this.categoryReliabilityThirdDataGridViewTextBoxColumn.Name = "categoryReliabilityThirdDataGridViewTextBoxColumn";
            this.categoryReliabilityThirdDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryReliabilityThirdDataGridViewTextBoxColumn.Width = 25;
            // 
            // levelVoltageHVDataGridViewTextBoxColumn
            // 
            this.levelVoltageHVDataGridViewTextBoxColumn.DataPropertyName = "LevelVoltageHV";
            this.levelVoltageHVDataGridViewTextBoxColumn.HeaderText = "ВН";
            this.levelVoltageHVDataGridViewTextBoxColumn.Name = "levelVoltageHVDataGridViewTextBoxColumn";
            this.levelVoltageHVDataGridViewTextBoxColumn.ReadOnly = true;
            this.levelVoltageHVDataGridViewTextBoxColumn.Width = 25;
            // 
            // levelVoltageSV1DataGridViewTextBoxColumn
            // 
            this.levelVoltageSV1DataGridViewTextBoxColumn.DataPropertyName = "LevelVoltageSV-1";
            this.levelVoltageSV1DataGridViewTextBoxColumn.HeaderText = "СН1";
            this.levelVoltageSV1DataGridViewTextBoxColumn.Name = "levelVoltageSV1DataGridViewTextBoxColumn";
            this.levelVoltageSV1DataGridViewTextBoxColumn.ReadOnly = true;
            this.levelVoltageSV1DataGridViewTextBoxColumn.Width = 35;
            // 
            // levelVoltageSV2DataGridViewTextBoxColumn
            // 
            this.levelVoltageSV2DataGridViewTextBoxColumn.DataPropertyName = "LevelVoltageSV-2";
            this.levelVoltageSV2DataGridViewTextBoxColumn.HeaderText = "СН2";
            this.levelVoltageSV2DataGridViewTextBoxColumn.Name = "levelVoltageSV2DataGridViewTextBoxColumn";
            this.levelVoltageSV2DataGridViewTextBoxColumn.ReadOnly = true;
            this.levelVoltageSV2DataGridViewTextBoxColumn.Width = 35;
            // 
            // levelVoltageLVDataGridViewTextBoxColumn
            // 
            this.levelVoltageLVDataGridViewTextBoxColumn.DataPropertyName = "LevelVoltageLV";
            this.levelVoltageLVDataGridViewTextBoxColumn.HeaderText = "НН";
            this.levelVoltageLVDataGridViewTextBoxColumn.Name = "levelVoltageLVDataGridViewTextBoxColumn";
            this.levelVoltageLVDataGridViewTextBoxColumn.ReadOnly = true;
            this.levelVoltageLVDataGridViewTextBoxColumn.Width = 25;
            // 
            // networkOrganizationsDataGridViewTextBoxColumn
            // 
            this.networkOrganizationsDataGridViewTextBoxColumn.DataPropertyName = "NetworkOrganizations";
            this.networkOrganizationsDataGridViewTextBoxColumn.HeaderText = "Смежные сетевые";
            this.networkOrganizationsDataGridViewTextBoxColumn.Name = "networkOrganizationsDataGridViewTextBoxColumn";
            this.networkOrganizationsDataGridViewTextBoxColumn.ReadOnly = true;
            this.networkOrganizationsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Commnets
            // 
            this.Commnets.DataPropertyName = "Commnets";
            this.Commnets.HeaderText = "Примечание";
            this.Commnets.Name = "Commnets";
            this.Commnets.ReadOnly = true;
            this.Commnets.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bsReport811
            // 
            this.bsReport811.DataMember = "tReport811";
            this.bsReport811.DataSource = this.dataSetScheme;
            // 
            // tabPage811_2019
            // 
            this.tabPage811_2019.Controls.Add(this.dgvReport811_2019);
            this.tabPage811_2019.Location = new System.Drawing.Point(4, 22);
            this.tabPage811_2019.Name = "tabPage811_2019";
            this.tabPage811_2019.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage811_2019.Size = new System.Drawing.Size(967, 442);
            this.tabPage811_2019.TabIndex = 0;
            this.tabPage811_2019.Text = "Ведомость присоединений (2019)";
            this.tabPage811_2019.UseVisualStyleBackColor = true;
            // 
            // dgvReport811_2019
            // 
            this.dgvReport811_2019.AllowUserToAddRows = false;
            this.dgvReport811_2019.AllowUserToDeleteRows = false;
            this.dgvReport811_2019.AutoGenerateColumns = false;
            this.dgvReport811_2019.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport811_2019.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subCPNameDataGridViewTextBoxColumn1_2019,
            this.listNodesDataGridViewTextBoxColumn1_2019,
            this.subNameDataGridViewTextBoxColumn2_2019,
            this.highestVoltageClassDataGridViewTextBoxColumn_2019,
            this.listNodesDownDataGridViewTextBoxColumn1_2019,
            this.voltageClassDataGridViewTextBoxColumn_2019,
            this.Всего_2019,
            this.categoryReliabilityFirstDataGridViewTextBoxColumn_2019,
            this.categoryReliabilitySecondDataGridViewTextBoxColumn_2019,
            this.categoryReliabilityThirdDataGridViewTextBoxColumn_2019,
            this.levelVoltageHVDataGridViewTextBoxColumn_2019,
            this.levelVoltageSV1DataGridViewTextBoxColumn_2019,
            this.levelVoltageSV2DataGridViewTextBoxColumn_2019,
            this.levelVoltageLVDataGridViewTextBoxColumn_2019,
            this.networkOrganizationsDataGridViewTextBoxColumn_2019,
            this.Commnets_2019});
            this.dgvReport811_2019.DataSource = this.bsReport811_2019;
            this.dgvReport811_2019.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport811_2019.Location = new System.Drawing.Point(3, 3);
            this.dgvReport811_2019.Name = "dgvReport811_2019";
            this.dgvReport811_2019.ReadOnly = true;
            this.dgvReport811_2019.Size = new System.Drawing.Size(961, 436);
            this.dgvReport811_2019.TabIndex = 0;
            // 
            // subCPNameDataGridViewTextBoxColumn1_2019
            // 
            this.subCPNameDataGridViewTextBoxColumn1_2019.DataPropertyName = "subCPName";
            this.subCPNameDataGridViewTextBoxColumn1_2019.HeaderText = "ЦП";
            this.subCPNameDataGridViewTextBoxColumn1_2019.Name = "subCPNameDataGridViewTextBoxColumn1_2019";
            this.subCPNameDataGridViewTextBoxColumn1_2019.ReadOnly = true;
            this.subCPNameDataGridViewTextBoxColumn1_2019.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // listNodesDataGridViewTextBoxColumn1_2019
            // 
            this.listNodesDataGridViewTextBoxColumn1_2019.DataPropertyName = "listNodes";
            this.listNodesDataGridViewTextBoxColumn1_2019.HeaderText = "Запитка";
            this.listNodesDataGridViewTextBoxColumn1_2019.Name = "listNodesDataGridViewTextBoxColumn1_2019";
            this.listNodesDataGridViewTextBoxColumn1_2019.ReadOnly = true;
            this.listNodesDataGridViewTextBoxColumn1_2019.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listNodesDataGridViewTextBoxColumn1_2019.Width = 200;
            // 
            // subNameDataGridViewTextBoxColumn2_2019
            // 
            this.subNameDataGridViewTextBoxColumn2_2019.DataPropertyName = "subName";
            this.subNameDataGridViewTextBoxColumn2_2019.HeaderText = "ПС";
            this.subNameDataGridViewTextBoxColumn2_2019.Name = "subNameDataGridViewTextBoxColumn2_2019";
            this.subNameDataGridViewTextBoxColumn2_2019.ReadOnly = true;
            this.subNameDataGridViewTextBoxColumn2_2019.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // highestVoltageClassDataGridViewTextBoxColumn_2019
            // 
            this.highestVoltageClassDataGridViewTextBoxColumn_2019.DataPropertyName = "HighestVoltageClass";
            this.highestVoltageClassDataGridViewTextBoxColumn_2019.HeaderText = "Высший класс напряжения";
            this.highestVoltageClassDataGridViewTextBoxColumn_2019.Name = "highestVoltageClassDataGridViewTextBoxColumn_2019";
            this.highestVoltageClassDataGridViewTextBoxColumn_2019.ReadOnly = true;
            this.highestVoltageClassDataGridViewTextBoxColumn_2019.Width = 75;
            // 
            // listNodesDownDataGridViewTextBoxColumn1_2019
            // 
            this.listNodesDownDataGridViewTextBoxColumn1_2019.DataPropertyName = "listNodesDown";
            this.listNodesDownDataGridViewTextBoxColumn1_2019.HeaderText = "Запитка абонента";
            this.listNodesDownDataGridViewTextBoxColumn1_2019.Name = "listNodesDownDataGridViewTextBoxColumn1_2019";
            this.listNodesDownDataGridViewTextBoxColumn1_2019.ReadOnly = true;
            this.listNodesDownDataGridViewTextBoxColumn1_2019.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listNodesDownDataGridViewTextBoxColumn1_2019.Width = 150;
            // 
            // voltageClassDataGridViewTextBoxColumn_2019
            // 
            this.voltageClassDataGridViewTextBoxColumn_2019.DataPropertyName = "VoltageClass";
            this.voltageClassDataGridViewTextBoxColumn_2019.HeaderText = "Класс напряжения";
            this.voltageClassDataGridViewTextBoxColumn_2019.Name = "voltageClassDataGridViewTextBoxColumn_2019";
            this.voltageClassDataGridViewTextBoxColumn_2019.ReadOnly = true;
            this.voltageClassDataGridViewTextBoxColumn_2019.Width = 75;
            // 
            // Всего_2019
            // 
            this.Всего_2019.DataPropertyName = "MeterAll";
            this.Всего_2019.HeaderText = "Всего";
            this.Всего_2019.Name = "Всего_2019";
            this.Всего_2019.ReadOnly = true;
            this.Всего_2019.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Всего_2019.Width = 40;
            // 
            // categoryReliabilityFirstDataGridViewTextBoxColumn_2019
            // 
            this.categoryReliabilityFirstDataGridViewTextBoxColumn_2019.DataPropertyName = "CategoryReliabilityFirst";
            this.categoryReliabilityFirstDataGridViewTextBoxColumn_2019.HeaderText = "I";
            this.categoryReliabilityFirstDataGridViewTextBoxColumn_2019.Name = "categoryReliabilityFirstDataGridViewTextBoxColumn_2019";
            this.categoryReliabilityFirstDataGridViewTextBoxColumn_2019.ReadOnly = true;
            this.categoryReliabilityFirstDataGridViewTextBoxColumn_2019.Width = 25;
            // 
            // categoryReliabilitySecondDataGridViewTextBoxColumn_2019
            // 
            this.categoryReliabilitySecondDataGridViewTextBoxColumn_2019.DataPropertyName = "CategoryReliabilitySecond";
            this.categoryReliabilitySecondDataGridViewTextBoxColumn_2019.HeaderText = "II";
            this.categoryReliabilitySecondDataGridViewTextBoxColumn_2019.Name = "categoryReliabilitySecondDataGridViewTextBoxColumn_2019";
            this.categoryReliabilitySecondDataGridViewTextBoxColumn_2019.ReadOnly = true;
            this.categoryReliabilitySecondDataGridViewTextBoxColumn_2019.Width = 25;
            // 
            // categoryReliabilityThirdDataGridViewTextBoxColumn_2019
            // 
            this.categoryReliabilityThirdDataGridViewTextBoxColumn_2019.DataPropertyName = "CategoryReliabilityThird";
            this.categoryReliabilityThirdDataGridViewTextBoxColumn_2019.HeaderText = "III";
            this.categoryReliabilityThirdDataGridViewTextBoxColumn_2019.Name = "categoryReliabilityThirdDataGridViewTextBoxColumn_2019";
            this.categoryReliabilityThirdDataGridViewTextBoxColumn_2019.ReadOnly = true;
            this.categoryReliabilityThirdDataGridViewTextBoxColumn_2019.Width = 25;
            // 
            // levelVoltageHVDataGridViewTextBoxColumn_2019
            // 
            this.levelVoltageHVDataGridViewTextBoxColumn_2019.DataPropertyName = "LevelVoltageHV";
            this.levelVoltageHVDataGridViewTextBoxColumn_2019.HeaderText = "ВН";
            this.levelVoltageHVDataGridViewTextBoxColumn_2019.Name = "levelVoltageHVDataGridViewTextBoxColumn_2019";
            this.levelVoltageHVDataGridViewTextBoxColumn_2019.ReadOnly = true;
            this.levelVoltageHVDataGridViewTextBoxColumn_2019.Width = 25;
            // 
            // levelVoltageSV1DataGridViewTextBoxColumn_2019
            // 
            this.levelVoltageSV1DataGridViewTextBoxColumn_2019.DataPropertyName = "LevelVoltageSV-1";
            this.levelVoltageSV1DataGridViewTextBoxColumn_2019.HeaderText = "СН1";
            this.levelVoltageSV1DataGridViewTextBoxColumn_2019.Name = "levelVoltageSV1DataGridViewTextBoxColumn_2019";
            this.levelVoltageSV1DataGridViewTextBoxColumn_2019.ReadOnly = true;
            this.levelVoltageSV1DataGridViewTextBoxColumn_2019.Width = 35;
            // 
            // levelVoltageSV2DataGridViewTextBoxColumn_2019
            // 
            this.levelVoltageSV2DataGridViewTextBoxColumn_2019.DataPropertyName = "LevelVoltageSV-2";
            this.levelVoltageSV2DataGridViewTextBoxColumn_2019.HeaderText = "СН2";
            this.levelVoltageSV2DataGridViewTextBoxColumn_2019.Name = "levelVoltageSV2DataGridViewTextBoxColumn_2019";
            this.levelVoltageSV2DataGridViewTextBoxColumn_2019.ReadOnly = true;
            this.levelVoltageSV2DataGridViewTextBoxColumn_2019.Width = 35;
            // 
            // levelVoltageLVDataGridViewTextBoxColumn_2019
            // 
            this.levelVoltageLVDataGridViewTextBoxColumn_2019.DataPropertyName = "LevelVoltageLV";
            this.levelVoltageLVDataGridViewTextBoxColumn_2019.HeaderText = "НН";
            this.levelVoltageLVDataGridViewTextBoxColumn_2019.Name = "levelVoltageLVDataGridViewTextBoxColumn_2019";
            this.levelVoltageLVDataGridViewTextBoxColumn_2019.ReadOnly = true;
            this.levelVoltageLVDataGridViewTextBoxColumn_2019.Width = 25;
            // 
            // networkOrganizationsDataGridViewTextBoxColumn_2019
            // 
            this.networkOrganizationsDataGridViewTextBoxColumn_2019.DataPropertyName = "NetworkOrganizations";
            this.networkOrganizationsDataGridViewTextBoxColumn_2019.HeaderText = "Смежные сетевые";
            this.networkOrganizationsDataGridViewTextBoxColumn_2019.Name = "networkOrganizationsDataGridViewTextBoxColumn_2019";
            this.networkOrganizationsDataGridViewTextBoxColumn_2019.ReadOnly = true;
            this.networkOrganizationsDataGridViewTextBoxColumn_2019.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Commnets_2019
            // 
            this.Commnets_2019.DataPropertyName = "Commnets";
            this.Commnets_2019.HeaderText = "Примечание";
            this.Commnets_2019.Name = "Commnets_2019";
            this.Commnets_2019.ReadOnly = true;
            this.Commnets_2019.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bsReport811_2019
            // 
            this.bsReport811_2019.DataMember = "tReport811";
            this.bsReport811_2019.DataSource = this.dataSetScheme;
            // 
            // tabPageNominalPowerCP
            // 
            this.tabPageNominalPowerCP.Controls.Add(this.dgvNominalPowerCP);
            this.tabPageNominalPowerCP.Location = new System.Drawing.Point(4, 22);
            this.tabPageNominalPowerCP.Name = "tabPageNominalPowerCP";
            this.tabPageNominalPowerCP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNominalPowerCP.Size = new System.Drawing.Size(967, 442);
            this.tabPageNominalPowerCP.TabIndex = 2;
            this.tabPageNominalPowerCP.Text = "Ведомость присоединенной мощности";
            this.tabPageNominalPowerCP.UseVisualStyleBackColor = true;
            // 
            // dgvNominalPowerCP
            // 
            this.dgvNominalPowerCP.AllowUserToAddRows = false;
            this.dgvNominalPowerCP.AllowUserToDeleteRows = false;
            this.dgvNominalPowerCP.AutoGenerateColumns = false;
            this.dgvNominalPowerCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNominalPowerCP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subCPNameDataGridViewTextBoxColumn11,
            this.powerSetDataGridViewTextBoxColumn1,
            this.listNodesDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn14});
            this.dgvNominalPowerCP.DataSource = this.bsNominalPowerCP;
            this.dgvNominalPowerCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNominalPowerCP.Location = new System.Drawing.Point(3, 3);
            this.dgvNominalPowerCP.Name = "dgvNominalPowerCP";
            this.dgvNominalPowerCP.ReadOnly = true;
            this.dgvNominalPowerCP.Size = new System.Drawing.Size(961, 436);
            this.dgvNominalPowerCP.TabIndex = 1;
            // 
            // subCPNameDataGridViewTextBoxColumn11
            // 
            this.subCPNameDataGridViewTextBoxColumn11.DataPropertyName = "subCPName";
            this.subCPNameDataGridViewTextBoxColumn11.HeaderText = "ЦП";
            this.subCPNameDataGridViewTextBoxColumn11.Name = "subCPNameDataGridViewTextBoxColumn11";
            this.subCPNameDataGridViewTextBoxColumn11.ReadOnly = true;
            this.subCPNameDataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // powerSetDataGridViewTextBoxColumn1
            // 
            this.powerSetDataGridViewTextBoxColumn1.DataPropertyName = "PowerSetCP";
            this.powerSetDataGridViewTextBoxColumn1.HeaderText = "Мощность ном.";
            this.powerSetDataGridViewTextBoxColumn1.Name = "powerSetDataGridViewTextBoxColumn1";
            this.powerSetDataGridViewTextBoxColumn1.ReadOnly = true;
            this.powerSetDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // listNodesDataGridViewTextBoxColumn2
            // 
            this.listNodesDataGridViewTextBoxColumn2.DataPropertyName = "listNodes";
            this.listNodesDataGridViewTextBoxColumn2.HeaderText = "listNodes";
            this.listNodesDataGridViewTextBoxColumn2.Name = "listNodesDataGridViewTextBoxColumn2";
            this.listNodesDataGridViewTextBoxColumn2.ReadOnly = true;
            this.listNodesDataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Commnets";
            this.dataGridViewTextBoxColumn14.HeaderText = "Commnets";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // bsNominalPowerCP
            // 
            this.bsNominalPowerCP.AllowNew = true;
            this.bsNominalPowerCP.DataMember = "tNominalPower";
            this.bsNominalPowerCP.DataSource = this.dataSetScheme;
            // 
            // bgLinkAbnWithCP
            // 
            this.bgLinkAbnWithCP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLinkAbnWithCP_DoWork);
            this.bgLinkAbnWithCP.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLinkAbnWithCP_RunWorkerCompleted);
            // 
            // bgLinkAbnWithCP_2019
            // 
            this.bgLinkAbnWithCP_2019.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLinkAbnWithCP_2019_DoWork);
            this.bgLinkAbnWithCP_2019.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLinkAbnWithCP_2019_RunWorkerCompleted);
            // 
            // bgNominalPowerCP
            // 
            this.bgNominalPowerCP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgNominalPowerCP_DoWork);
            this.bgNominalPowerCP.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgNominalPowerCP_RunWorkerCompleted);
            // 
            // dsSchemeReports1
            // 
            this.dsSchemeReports1.DataSetName = "DataSetScheme";
            this.dsSchemeReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataColumnNumDoc
            // 
            this.dataColumnNumDoc.ColumnName = "NumDoc";
            // 
            // dataColumnDateDoc
            // 
            this.dataColumnDateDoc.ColumnName = "DateDoc";
            this.dataColumnDateDoc.DataType = typeof(System.DateTime);
            // 
            // dataColumnEmergencyReserv
            // 
            this.dataColumnEmergencyReserv.ColumnName = "EmergencyReserv";
            // 
            // dataColumnTechnologicalReserv
            // 
            this.dataColumnTechnologicalReserv.ColumnName = "TechnologicalReserv";
            // 
            // subCPNameDataGridViewTextBoxColumn
            // 
            this.subCPNameDataGridViewTextBoxColumn.DataPropertyName = "subCPName";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subCPNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.subCPNameDataGridViewTextBoxColumn.HeaderText = "ЦП";
            this.subCPNameDataGridViewTextBoxColumn.Name = "subCPNameDataGridViewTextBoxColumn";
            this.subCPNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.subCPNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cellCPNameDataGridViewTextBoxColumn
            // 
            this.cellCPNameDataGridViewTextBoxColumn.DataPropertyName = "cellCPName";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cellCPNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cellCPNameDataGridViewTextBoxColumn.HeaderText = "Ячейка ЦП";
            this.cellCPNameDataGridViewTextBoxColumn.Name = "cellCPNameDataGridViewTextBoxColumn";
            this.cellCPNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cellCPNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellCPNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // subNameDataGridViewTextBoxColumn1
            // 
            this.subNameDataGridViewTextBoxColumn1.DataPropertyName = "subName";
            this.subNameDataGridViewTextBoxColumn1.HeaderText = "ПС";
            this.subNameDataGridViewTextBoxColumn1.Name = "subNameDataGridViewTextBoxColumn1";
            this.subNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.subNameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subNameDataGridViewTextBoxColumn1.Width = 90;
            // 
            // busNameDataGridViewTextBoxColumn1
            // 
            this.busNameDataGridViewTextBoxColumn1.DataPropertyName = "busName";
            this.busNameDataGridViewTextBoxColumn1.HeaderText = "Шина";
            this.busNameDataGridViewTextBoxColumn1.Name = "busNameDataGridViewTextBoxColumn1";
            this.busNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.busNameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.busNameDataGridViewTextBoxColumn1.Width = 80;
            // 
            // cellNameDataGridViewTextBoxColumn1
            // 
            this.cellNameDataGridViewTextBoxColumn1.DataPropertyName = "cellName";
            this.cellNameDataGridViewTextBoxColumn1.HeaderText = "Ячейка";
            this.cellNameDataGridViewTextBoxColumn1.Name = "cellNameDataGridViewTextBoxColumn1";
            this.cellNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cellNameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellNameDataGridViewTextBoxColumn1.Width = 80;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "codeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "№ договора";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeAbonentDataGridViewTextBoxColumn.Visible = false;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 90;
            // 
            // docAbn
            // 
            this.docAbn.DataPropertyName = "docAbn";
            this.docAbn.HeaderText = "№ договора";
            this.docAbn.Name = "docAbn";
            this.docAbn.ReadOnly = true;
            this.docAbn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameAbnDataGridViewTextBoxColumn
            // 
            this.nameAbnDataGridViewTextBoxColumn.DataPropertyName = "nameAbn";
            this.nameAbnDataGridViewTextBoxColumn.HeaderText = "Абонент";
            this.nameAbnDataGridViewTextBoxColumn.Name = "nameAbnDataGridViewTextBoxColumn";
            this.nameAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAbnDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idAbnDataGridViewTextBoxColumn1
            // 
            this.idAbnDataGridViewTextBoxColumn1.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn1.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn1.Name = "idAbnDataGridViewTextBoxColumn1";
            this.idAbnDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn1.Visible = false;
            // 
            // typeAbnDataGridViewTextBoxColumn1
            // 
            this.typeAbnDataGridViewTextBoxColumn1.DataPropertyName = "typeAbn";
            this.typeAbnDataGridViewTextBoxColumn1.HeaderText = "typeAbn";
            this.typeAbnDataGridViewTextBoxColumn1.Name = "typeAbnDataGridViewTextBoxColumn1";
            this.typeAbnDataGridViewTextBoxColumn1.ReadOnly = true;
            this.typeAbnDataGridViewTextBoxColumn1.Visible = false;
            // 
            // typeAbnNameDataGridViewTextBoxColumn
            // 
            this.typeAbnNameDataGridViewTextBoxColumn.DataPropertyName = "typeAbnName";
            this.typeAbnNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeAbnNameDataGridViewTextBoxColumn.Name = "typeAbnNameDataGridViewTextBoxColumn";
            this.typeAbnNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeAbnNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idAbnObjDataGridViewTextBoxColumn1
            // 
            this.idAbnObjDataGridViewTextBoxColumn1.DataPropertyName = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn1.HeaderText = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn1.Name = "idAbnObjDataGridViewTextBoxColumn1";
            this.idAbnObjDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idAbnObjDataGridViewTextBoxColumn1.Visible = false;
            // 
            // legalAddress
            // 
            this.legalAddress.DataPropertyName = "legalAddress";
            this.legalAddress.HeaderText = "Юридический адрес";
            this.legalAddress.Name = "legalAddress";
            this.legalAddress.ReadOnly = true;
            this.legalAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // postAddress
            // 
            this.postAddress.DataPropertyName = "postAddress";
            this.postAddress.HeaderText = "Почтовый адрес";
            this.postAddress.Name = "postAddress";
            this.postAddress.ReadOnly = true;
            this.postAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameObjDataGridViewTextBoxColumn
            // 
            this.nameObjDataGridViewTextBoxColumn.DataPropertyName = "nameObj";
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес объекта";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kladrObjIdDataGridViewTextBoxColumn
            // 
            this.kladrObjIdDataGridViewTextBoxColumn.DataPropertyName = "kladrObjId";
            this.kladrObjIdDataGridViewTextBoxColumn.HeaderText = "kladrObjId";
            this.kladrObjIdDataGridViewTextBoxColumn.Name = "kladrObjIdDataGridViewTextBoxColumn";
            this.kladrObjIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.kladrObjIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kladrObjNameDataGridViewTextBoxColumn
            // 
            this.kladrObjNameDataGridViewTextBoxColumn.DataPropertyName = "KladrObjName";
            this.kladrObjNameDataGridViewTextBoxColumn.HeaderText = "Город";
            this.kladrObjNameDataGridViewTextBoxColumn.Name = "kladrObjNameDataGridViewTextBoxColumn";
            this.kladrObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.kladrObjNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kladrObjNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Кат";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryNameDataGridViewTextBoxColumn.Width = 50;
            // 
            // idTariffDataGridViewTextBoxColumn
            // 
            this.idTariffDataGridViewTextBoxColumn.DataPropertyName = "idTariff";
            this.idTariffDataGridViewTextBoxColumn.HeaderText = "idTariff";
            this.idTariffDataGridViewTextBoxColumn.Name = "idTariffDataGridViewTextBoxColumn";
            this.idTariffDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTariffDataGridViewTextBoxColumn.Visible = false;
            // 
            // tariffNameDataGridViewTextBoxColumn
            // 
            this.tariffNameDataGridViewTextBoxColumn.DataPropertyName = "tariffName";
            this.tariffNameDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.tariffNameDataGridViewTextBoxColumn.Name = "tariffNameDataGridViewTextBoxColumn";
            this.tariffNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tariffNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tariffNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // powerSetDataGridViewTextBoxColumn
            // 
            this.powerSetDataGridViewTextBoxColumn.DataPropertyName = "powerSet";
            this.powerSetDataGridViewTextBoxColumn.HeaderText = "Уст мощность";
            this.powerSetDataGridViewTextBoxColumn.Name = "powerSetDataGridViewTextBoxColumn";
            this.powerSetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powerFactDataGridViewTextBoxColumn
            // 
            this.powerFactDataGridViewTextBoxColumn.DataPropertyName = "powerFact";
            this.powerFactDataGridViewTextBoxColumn.HeaderText = "Факт мощность";
            this.powerFactDataGridViewTextBoxColumn.Name = "powerFactDataGridViewTextBoxColumn";
            this.powerFactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consumerDataGridViewTextBoxColumn
            // 
            this.consumerDataGridViewTextBoxColumn.DataPropertyName = "Consumer";
            this.consumerDataGridViewTextBoxColumn.HeaderText = "Consumer";
            this.consumerDataGridViewTextBoxColumn.Name = "consumerDataGridViewTextBoxColumn";
            this.consumerDataGridViewTextBoxColumn.ReadOnly = true;
            this.consumerDataGridViewTextBoxColumn.Visible = false;
            // 
            // sumKWTDgvColumn
            // 
            this.sumKWTDgvColumn.DataPropertyName = "SumKWT";
            this.sumKWTDgvColumn.HeaderText = "Потребление";
            this.sumKWTDgvColumn.Name = "sumKWTDgvColumn";
            this.sumKWTDgvColumn.ReadOnly = true;
            // 
            // consumerNameDataGridViewTextBoxColumn
            // 
            this.consumerNameDataGridViewTextBoxColumn.DataPropertyName = "consumerName";
            this.consumerNameDataGridViewTextBoxColumn.HeaderText = "Состав группы";
            this.consumerNameDataGridViewTextBoxColumn.Name = "consumerNameDataGridViewTextBoxColumn";
            this.consumerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.consumerNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contactDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.contactDataGridViewTextBoxColumn.HeaderText = "Телефоны";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abnNetDataGridViewTextBoxColumn
            // 
            this.abnNetDataGridViewTextBoxColumn.DataPropertyName = "abnNet";
            this.abnNetDataGridViewTextBoxColumn.HeaderText = "Сетевая орг-ция";
            this.abnNetDataGridViewTextBoxColumn.Name = "abnNetDataGridViewTextBoxColumn";
            this.abnNetDataGridViewTextBoxColumn.ReadOnly = true;
            this.abnNetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // abnServicingDataGridViewTextBoxColumn
            // 
            this.abnServicingDataGridViewTextBoxColumn.DataPropertyName = "abnServicing";
            this.abnServicingDataGridViewTextBoxColumn.HeaderText = "Обсл-ая орг-ция";
            this.abnServicingDataGridViewTextBoxColumn.Name = "abnServicingDataGridViewTextBoxColumn";
            this.abnServicingDataGridViewTextBoxColumn.ReadOnly = true;
            this.abnServicingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idSchmObjDataGridViewTextBoxColumn1
            // 
            this.idSchmObjDataGridViewTextBoxColumn1.DataPropertyName = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn1.HeaderText = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn1.Name = "idSchmObjDataGridViewTextBoxColumn1";
            this.idSchmObjDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idSchmObjDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            this.idDocDataGridViewTextBoxColumn.DataPropertyName = "idDoc";
            this.idDocDataGridViewTextBoxColumn.HeaderText = "idDoc";
            this.idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            this.idDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDocDataGridViewTextBoxColumn
            // 
            this.typeDocDataGridViewTextBoxColumn.DataPropertyName = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn.HeaderText = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn.Name = "typeDocDataGridViewTextBoxColumn";
            this.typeDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDocDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDocNameDataGridViewTextBoxColumn
            // 
            this.typeDocNameDataGridViewTextBoxColumn.DataPropertyName = "TypeDocName";
            this.typeDocNameDataGridViewTextBoxColumn.HeaderText = "TypeDocName";
            this.typeDocNameDataGridViewTextBoxColumn.Name = "typeDocNameDataGridViewTextBoxColumn";
            this.typeDocNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDocNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // cellIdDataGridViewTextBoxColumn1
            // 
            this.cellIdDataGridViewTextBoxColumn1.DataPropertyName = "cellId";
            this.cellIdDataGridViewTextBoxColumn1.HeaderText = "cellId";
            this.cellIdDataGridViewTextBoxColumn1.Name = "cellIdDataGridViewTextBoxColumn1";
            this.cellIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cellIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // busIdDataGridViewTextBoxColumn1
            // 
            this.busIdDataGridViewTextBoxColumn1.DataPropertyName = "busId";
            this.busIdDataGridViewTextBoxColumn1.HeaderText = "busId";
            this.busIdDataGridViewTextBoxColumn1.Name = "busIdDataGridViewTextBoxColumn1";
            this.busIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.busIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // subIdDataGridViewTextBoxColumn1
            // 
            this.subIdDataGridViewTextBoxColumn1.DataPropertyName = "subId";
            this.subIdDataGridViewTextBoxColumn1.HeaderText = "subId";
            this.subIdDataGridViewTextBoxColumn1.Name = "subIdDataGridViewTextBoxColumn1";
            this.subIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.subIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // schmObjNameDataGridViewTextBoxColumn1
            // 
            this.schmObjNameDataGridViewTextBoxColumn1.DataPropertyName = "schmObjName";
            this.schmObjNameDataGridViewTextBoxColumn1.HeaderText = "schmObjName";
            this.schmObjNameDataGridViewTextBoxColumn1.Name = "schmObjNameDataGridViewTextBoxColumn1";
            this.schmObjNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.schmObjNameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cellCPIdDataGridViewTextBoxColumn
            // 
            this.cellCPIdDataGridViewTextBoxColumn.DataPropertyName = "cellCPId";
            this.cellCPIdDataGridViewTextBoxColumn.HeaderText = "cellCPId";
            this.cellCPIdDataGridViewTextBoxColumn.Name = "cellCPIdDataGridViewTextBoxColumn";
            this.cellCPIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cellCPIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // busCPIdDataGridViewTextBoxColumn
            // 
            this.busCPIdDataGridViewTextBoxColumn.DataPropertyName = "busCPId";
            this.busCPIdDataGridViewTextBoxColumn.HeaderText = "busCPId";
            this.busCPIdDataGridViewTextBoxColumn.Name = "busCPIdDataGridViewTextBoxColumn";
            this.busCPIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.busCPIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // busCPNameDataGridViewTextBoxColumn
            // 
            this.busCPNameDataGridViewTextBoxColumn.DataPropertyName = "busCPName";
            this.busCPNameDataGridViewTextBoxColumn.HeaderText = "busCPName";
            this.busCPNameDataGridViewTextBoxColumn.Name = "busCPNameDataGridViewTextBoxColumn";
            this.busCPNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.busCPNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // subCPIdDataGridViewTextBoxColumn
            // 
            this.subCPIdDataGridViewTextBoxColumn.DataPropertyName = "subCPId";
            this.subCPIdDataGridViewTextBoxColumn.HeaderText = "subCPId";
            this.subCPIdDataGridViewTextBoxColumn.Name = "subCPIdDataGridViewTextBoxColumn";
            this.subCPIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.subCPIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // meterDataGridViewTextBoxColumn
            // 
            this.meterDataGridViewTextBoxColumn.DataPropertyName = "Meter";
            this.meterDataGridViewTextBoxColumn.HeaderText = "Счётчик";
            this.meterDataGridViewTextBoxColumn.Name = "meterDataGridViewTextBoxColumn";
            this.meterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countMeterDataGridViewTextBoxColumn
            // 
            this.countMeterDataGridViewTextBoxColumn.DataPropertyName = "CountMeter";
            this.countMeterDataGridViewTextBoxColumn.HeaderText = "Количество счётчиков";
            this.countMeterDataGridViewTextBoxColumn.Name = "countMeterDataGridViewTextBoxColumn";
            this.countMeterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listNodesDataGridViewTextBoxColumn
            // 
            this.listNodesDataGridViewTextBoxColumn.DataPropertyName = "listNodes";
            this.listNodesDataGridViewTextBoxColumn.HeaderText = "Запитка";
            this.listNodesDataGridViewTextBoxColumn.Name = "listNodesDataGridViewTextBoxColumn";
            this.listNodesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listNodesDownDataGridViewTextBoxColumn
            // 
            this.listNodesDownDataGridViewTextBoxColumn.DataPropertyName = "listNodesDown";
            this.listNodesDownDataGridViewTextBoxColumn.HeaderText = "Запитка абонента";
            this.listNodesDownDataGridViewTextBoxColumn.Name = "listNodesDownDataGridViewTextBoxColumn";
            this.listNodesDownDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ColumnNumDocActApproval
            // 
            this.ColumnNumDocActApproval.DataPropertyName = "NumDoc";
            this.ColumnNumDocActApproval.HeaderText = "Акт согласования  брони";
            this.ColumnNumDocActApproval.Name = "ColumnNumDocActApproval";
            this.ColumnNumDocActApproval.ReadOnly = true;
            // 
            // ColumnDateDocActApproval
            // 
            this.ColumnDateDocActApproval.DataPropertyName = "DateDoc";
            this.ColumnDateDocActApproval.HeaderText = "Дата акта согласования брони";
            this.ColumnDateDocActApproval.Name = "ColumnDateDocActApproval";
            this.ColumnDateDocActApproval.ReadOnly = true;
            // 
            // ColumnEmergencyReserv
            // 
            this.ColumnEmergencyReserv.DataPropertyName = "EmergencyReserv";
            this.ColumnEmergencyReserv.HeaderText = "Аварийная броня";
            this.ColumnEmergencyReserv.Name = "ColumnEmergencyReserv";
            this.ColumnEmergencyReserv.ReadOnly = true;
            // 
            // ColumnTechnologicalReserv
            // 
            this.ColumnTechnologicalReserv.DataPropertyName = "TechnologicalReserv";
            this.ColumnTechnologicalReserv.HeaderText = "Технологическая  броня";
            this.ColumnTechnologicalReserv.Name = "ColumnTechnologicalReserv";
            this.ColumnTechnologicalReserv.ReadOnly = true;
            // 
            // FormLinkAbnNewAndOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 493);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip);
            this.MinimumSize = new System.Drawing.Size(821, 319);
            this.Name = "FormLinkAbnNewAndOld";
            this.Text = "Привязанные абоненты (N)";
            this.Load += new System.EventHandler(this.FormLinkAbnNewAndOld_Load);
            this.Resize += new System.EventHandler(this.FormLinkAbnNewAndOld_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.treeDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDataGridView1)).EndInit();
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLegal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSchmAbnFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheme)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLegalContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnContact)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAbnWithCP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReportCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSchemeReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtReportCP)).EndInit();
            this.tabPageLegal.ResumeLayout(false);
            this.tabPage811.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport811)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReport811)).EndInit();
            this.tabPage811_2019.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport811_2019)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReport811_2019)).EndInit();
            this.tabPageNominalPowerCP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominalPowerCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNominalPowerCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSchemeReports1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

 

        #endregion




        private DateTimePicker dateTimePeriodKWT;

        private TreeDataGridView treeDataGridView1;

        private TreeGridColumn Column1;

        private TreeGridColumn Column2;

        private TreeGridColumn Column3;

        private DataGridViewTextBoxColumn Column4;

        private TreeDataGridView treeDataGridView2;

        private TreeGridColumn treeGridColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private BackgroundWorker bgLinkAbnNewAndOld;

        private Panel panelProgress;

        private Label label3;

        private ProgressBarEndLess progressBarEndLess;

        private BindingSource bsSchmAbnFull;

        private DataSetScheme dataSetScheme;

        private DataGridViewExcelFilter dgvListLegal;

        private ToolStrip toolStrip;

        private SplitContainer splitContainer1;

        private BindingSource bsAbnContact;

        private DataGridViewExcelFilter dgvListLegalContact;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

        private ToolStripButton toolBtnRefresh;

        private TabControl tabControl1;

        private TabPage tabPageLegal;
        private TabPage tabPage811;
        private TabPage tabPage811_2019;
        private DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameAbnDataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn typeAbnDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn streetnameDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn houseDataGridViewTextBoxColumn1;

        private DataGridViewFilterTextBoxColumn subnameDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn busnameDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn cellNameDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn TPConnectDgvColumn;

        private DataGridViewFilterTextBoxColumn tPrazrDgvColumn;

        private DataGridViewTextBoxColumn idSchmObjDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn cellIdDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn busidDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn subidDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn schmObjNameDataGridViewTextBoxColumn;

        private TabPage tabPageAbnWithCP;

        private BackgroundWorker bgLinkAbnWithCP;

        private BackgroundWorker bgLinkAbnWithCP_2019;

        private BackgroundWorker bgNominalPowerCP;

        private DataSet dsSchemeReport;

        private DataTable dtReportCP;

        private DataColumn idAbn;

        private DataColumn codeAbonent;

        private DataColumn nameAbn;

        private DataColumn typeAbn;

        private DataColumn typeAbnName;

        private DataColumn idAbnObj;

        private DataColumn nameObj;

        private DataColumn address;

        private DataColumn kladrObjId;

        private DataColumn KladrObjName;
        private DataColumn category;

        private DataColumn categoryName;

        private DataColumn idTariff;

        private DataColumn tariffName;

        private DataColumn powerSet;

        private DataColumn powerFact;

        private DataColumn Consumer;

        private DataColumn consumerName;

        private DataColumn contact;

        private DataColumn abnNet;

        private DataColumn abnServicing;

        private DataColumn idSchmObj;

        private DataColumn idDoc;
        private DataColumn TypeDoc;

        private DataColumn TypeDocName;

        private DataColumn cellId;

        private DataColumn cellName;

        private DataColumn busId;

        private DataColumn busName;

        private DataColumn subId;

        private DataColumn subName;

        private DataColumn schmObjName;

        private DataGridViewExcelFilter dgvReportCP;

        private BindingSource bsReportCP;

        private DataColumn cellCPId;

        private DataColumn cellCPName;
        private DataColumn Meter;
        private DataColumn CountMeter;
        private DataColumn listNodes;
        private DataColumn listNodesDown;

        private DataColumn highestVoltageClass;
        private DataColumn voltageClass;

        private DataColumn busCPId;

        private DataColumn busCPName;

        private DataColumn subCPId;

        private DataColumn subCPName;

        private ToolStripButton toolBtnExportExcel;

        private ToolStripSeparator toolStripSeparator1;

        private ToolStripLabel toolLabelTypeSchema;

        private ToolStripComboBox toolCmbTypeSchema;

        private ToolStripLabel toolLabelPeriodKWT;

        private DataColumn SumKWT;

        private ToolStripButton toolBtnLoad;

        private DataColumn docAbn1;

        private DataColumn legalAddress1;

        private DataColumn postAddress1;
        private SchemeReports.DataSetScheme dsSchemeReports1;
        private BindingSource bsReport811;
        private BindingSource bsReport811_2019;
        //private DataGridView dgvReport811;
        private DataGridViewExcelFilter dgvReport811;
        private DataGridViewExcelFilter dgvReport811_2019;
        private DataColumn is811;
        private DataGridViewFilterTextBoxColumn subCPNameDataGridViewTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn listNodesDataGridViewTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn subNameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn highestVoltageClassDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn listNodesDownDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn voltageClassDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn Всего;
        private DataGridViewTextBoxColumn categoryReliabilityFirstDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryReliabilitySecondDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryReliabilityThirdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn levelVoltageHVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn levelVoltageSV1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn levelVoltageSV2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn levelVoltageLVDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn networkOrganizationsDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn Commnets;
        //
        private DataGridViewFilterTextBoxColumn subCPNameDataGridViewTextBoxColumn1_2019;
        private DataGridViewFilterTextBoxColumn listNodesDataGridViewTextBoxColumn1_2019;
        private DataGridViewFilterTextBoxColumn subNameDataGridViewTextBoxColumn2_2019;
        private DataGridViewTextBoxColumn highestVoltageClassDataGridViewTextBoxColumn_2019;
        private DataGridViewFilterTextBoxColumn listNodesDownDataGridViewTextBoxColumn1_2019;
        private DataGridViewTextBoxColumn voltageClassDataGridViewTextBoxColumn_2019;
        private DataGridViewFilterTextBoxColumn Всего_2019;
        private DataGridViewTextBoxColumn categoryReliabilityFirstDataGridViewTextBoxColumn_2019;
        private DataGridViewTextBoxColumn categoryReliabilitySecondDataGridViewTextBoxColumn_2019;
        private DataGridViewTextBoxColumn categoryReliabilityThirdDataGridViewTextBoxColumn_2019;
        private DataGridViewTextBoxColumn levelVoltageHVDataGridViewTextBoxColumn_2019;
        private DataGridViewTextBoxColumn levelVoltageSV1DataGridViewTextBoxColumn_2019;
        private DataGridViewTextBoxColumn levelVoltageSV2DataGridViewTextBoxColumn_2019;
        private DataGridViewTextBoxColumn levelVoltageLVDataGridViewTextBoxColumn_2019;
        private DataGridViewFilterTextBoxColumn networkOrganizationsDataGridViewTextBoxColumn_2019;
        private DataGridViewFilterTextBoxColumn Commnets_2019;
        private TabPage tabPageNominalPowerCP;
        private DataGridViewExcelFilter dgvNominalPowerCP;
        private BindingSource bsNominalPowerCP;
        private DataGridViewFilterTextBoxColumn subCPNameDataGridViewTextBoxColumn11;
        private DataGridViewFilterTextBoxColumn powerSetDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn listNodesDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataColumn dataColumnNumDoc;
        private DataColumn dataColumnDateDoc;
        private DataColumn dataColumnEmergencyReserv;
        private DataColumn dataColumnTechnologicalReserv;
        private DataGridViewFilterTextBoxColumn subCPNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn cellCPNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn subNameDataGridViewTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn busNameDataGridViewTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn cellNameDataGridViewTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn docAbn;
        private DataGridViewFilterTextBoxColumn nameAbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn typeAbnDataGridViewTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn typeAbnNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn legalAddress;
        private DataGridViewFilterTextBoxColumn postAddress;
        private DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kladrObjIdDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn kladrObjNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTariffDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn tariffNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn powerSetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn powerFactDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn consumerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumKWTDgvColumn;
        private DataGridViewFilterTextBoxColumn consumerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn abnNetDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn abnServicingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSchmObjDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idDocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDocNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cellIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn busIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn subIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn schmObjNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cellCPIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busCPIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn busCPNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subCPIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countMeterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listNodesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listNodesDownDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn ColumnNumDocActApproval;
        private DataGridViewFilterDateTimePickerColumn ColumnDateDocActApproval;
        private DataGridViewFilterTextBoxColumn ColumnEmergencyReserv;
        private DataGridViewFilterTextBoxColumn ColumnTechnologicalReserv;
    }
}