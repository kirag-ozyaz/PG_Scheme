namespace Prv.Forms.Reports
{
    partial class FormActBezuch
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
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelData = new System.Windows.Forms.Panel();
            this.lBoss = new System.Windows.Forms.Label();
            this.tbBoss = new System.Windows.Forms.TextBox();
            this.labelEngeneer = new System.Windows.Forms.Label();
            this.comboBoxEngeneer = new System.Windows.Forms.ComboBox();
            this.dsRep = new Prv.DataSets.DataSetRep();
            this.tbItog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAkt = new System.Windows.Forms.GroupBox();
            this.dgvAbnAktRcp = new System.Windows.Forms.DataGridView();
            this.Norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointRegDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateActBezuch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueKWTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeKWT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueMoneyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOwnerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBezuch = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxKO = new System.Windows.Forms.GroupBox();
            this.dgvAktKO = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateActKO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueKWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerKO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeKWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsKO = new System.Windows.Forms.BindingSource(this.components);
            this.tbRasch = new System.Windows.Forms.TextBox();
            this.buttonRasch = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tbAktNumber = new System.Windows.Forms.TextBox();
            this.labelAkt = new System.Windows.Forms.Label();
            this.lPeop = new System.Windows.Forms.Label();
            this.labelPeop = new System.Windows.Forms.Label();
            this.lQRooms = new System.Windows.Forms.Label();
            this.labelQRooms = new System.Windows.Forms.Label();
            this.lCont = new System.Windows.Forms.Label();
            this.labelCont = new System.Windows.Forms.Label();
            this.lFIO = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelAdr = new System.Windows.Forms.Label();
            this.labelCA = new System.Windows.Forms.Label();
            this.labelCodeAbonent = new System.Windows.Forms.Label();
            this.panelPrn = new System.Windows.Forms.Panel();
            this.reportViewerAkt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            this.groupBoxAkt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnAktRcp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBezuch)).BeginInit();
            this.groupBoxKO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktKO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKO)).BeginInit();
            this.panelPrn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.lBoss);
            this.panelData.Controls.Add(this.tbBoss);
            this.panelData.Controls.Add(this.labelEngeneer);
            this.panelData.Controls.Add(this.comboBoxEngeneer);
            this.panelData.Controls.Add(this.tbItog);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.groupBoxAkt);
            this.panelData.Controls.Add(this.groupBoxKO);
            this.panelData.Controls.Add(this.tbRasch);
            this.panelData.Controls.Add(this.buttonRasch);
            this.panelData.Controls.Add(this.buttonCreate);
            this.panelData.Controls.Add(this.buttonCancel);
            this.panelData.Controls.Add(this.tbAktNumber);
            this.panelData.Controls.Add(this.labelAkt);
            this.panelData.Controls.Add(this.lPeop);
            this.panelData.Controls.Add(this.labelPeop);
            this.panelData.Controls.Add(this.lQRooms);
            this.panelData.Controls.Add(this.labelQRooms);
            this.panelData.Controls.Add(this.lCont);
            this.panelData.Controls.Add(this.labelCont);
            this.panelData.Controls.Add(this.lFIO);
            this.panelData.Controls.Add(this.labelFIO);
            this.panelData.Controls.Add(this.labelAdress);
            this.panelData.Controls.Add(this.labelAdr);
            this.panelData.Controls.Add(this.labelCA);
            this.panelData.Controls.Add(this.labelCodeAbonent);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(657, 404);
            this.panelData.TabIndex = 30;
            // 
            // lBoss
            // 
            this.lBoss.AutoSize = true;
            this.lBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBoss.Location = new System.Drawing.Point(372, 71);
            this.lBoss.Name = "lBoss";
            this.lBoss.Size = new System.Drawing.Size(120, 18);
            this.lBoss.TabIndex = 32;
            this.lBoss.Text = "Руководитель";
            // 
            // tbBoss
            // 
            this.tbBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBoss.Location = new System.Drawing.Point(498, 68);
            this.tbBoss.Name = "tbBoss";
            this.tbBoss.Size = new System.Drawing.Size(127, 24);
            this.tbBoss.TabIndex = 31;
            this.tbBoss.Text = "Н.В. Исаева";
            // 
            // labelEngeneer
            // 
            this.labelEngeneer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEngeneer.AutoSize = true;
            this.labelEngeneer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEngeneer.Location = new System.Drawing.Point(133, 71);
            this.labelEngeneer.Name = "labelEngeneer";
            this.labelEngeneer.Size = new System.Drawing.Size(77, 18);
            this.labelEngeneer.TabIndex = 30;
            this.labelEngeneer.Text = "Инженер";
            // 
            // comboBoxEngeneer
            // 
            this.comboBoxEngeneer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEngeneer.DataSource = this.dsRep;
            this.comboBoxEngeneer.DisplayMember = "vWorkerGroup.FIO";
            this.comboBoxEngeneer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEngeneer.FormattingEnabled = true;
            this.comboBoxEngeneer.Location = new System.Drawing.Point(216, 68);
            this.comboBoxEngeneer.Name = "comboBoxEngeneer";
            this.comboBoxEngeneer.Size = new System.Drawing.Size(146, 26);
            this.comboBoxEngeneer.TabIndex = 29;
            this.comboBoxEngeneer.ValueMember = "vWorkerGroup.id";
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "DataSetRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbItog
            // 
            this.tbItog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbItog.Location = new System.Drawing.Point(338, 371);
            this.tbItog.Name = "tbItog";
            this.tbItog.Size = new System.Drawing.Size(86, 20);
            this.tbItog.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "=";
            // 
            // groupBoxAkt
            // 
            this.groupBoxAkt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAkt.Controls.Add(this.dgvAbnAktRcp);
            this.groupBoxAkt.Location = new System.Drawing.Point(3, 222);
            this.groupBoxAkt.Name = "groupBoxAkt";
            this.groupBoxAkt.Size = new System.Drawing.Size(650, 142);
            this.groupBoxAkt.TabIndex = 26;
            this.groupBoxAkt.TabStop = false;
            this.groupBoxAkt.Text = "Акты";
            // 
            // dgvAbnAktRcp
            // 
            this.dgvAbnAktRcp.AllowUserToAddRows = false;
            this.dgvAbnAktRcp.AllowUserToDeleteRows = false;
            this.dgvAbnAktRcp.AutoGenerateColumns = false;
            this.dgvAbnAktRcp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbnAktRcp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Norm,
            this.idDataGridViewTextBoxColumn1,
            this.idPointDataGridViewTextBoxColumn1,
            this.idPointRegDataGridViewTextBoxColumn1,
            this.idDocTypeDataGridViewTextBoxColumn1,
            this.docTypeDataGridViewTextBoxColumn1,
            this.idZoneDataGridViewTextBoxColumn1,
            this.dateActBezuch,
            this.zoneDataGridViewTextBoxColumn1,
            this.valueKWTDataGridViewTextBoxColumn1,
            this.SizeKWT,
            this.valueMoneyDataGridViewTextBoxColumn1,
            this.dateInDataGridViewTextBoxColumn1,
            this.idWorkerDataGridViewTextBoxColumn1,
            this.workerAct,
            this.idOwnerDataGridViewTextBoxColumn1,
            this.commentDataGridViewTextBoxColumn1,
            this.owner,
            this.dataGridViewTextBoxColumn1});
            this.dgvAbnAktRcp.DataSource = this.bsBezuch;
            this.dgvAbnAktRcp.Location = new System.Drawing.Point(3, 16);
            this.dgvAbnAktRcp.Name = "dgvAbnAktRcp";
            this.dgvAbnAktRcp.ReadOnly = true;
            this.dgvAbnAktRcp.RowHeadersWidth = 5;
            this.dgvAbnAktRcp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbnAktRcp.Size = new System.Drawing.Size(644, 123);
            this.dgvAbnAktRcp.TabIndex = 5;
            // 
            // Norm
            // 
            this.Norm.DataPropertyName = "Norm";
            this.Norm.HeaderText = "Norm";
            this.Norm.Name = "Norm";
            this.Norm.ReadOnly = true;
            this.Norm.Visible = false;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idPointDataGridViewTextBoxColumn1
            // 
            this.idPointDataGridViewTextBoxColumn1.DataPropertyName = "IdPoint";
            this.idPointDataGridViewTextBoxColumn1.HeaderText = "IdPoint";
            this.idPointDataGridViewTextBoxColumn1.Name = "idPointDataGridViewTextBoxColumn1";
            this.idPointDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idPointDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idPointRegDataGridViewTextBoxColumn1
            // 
            this.idPointRegDataGridViewTextBoxColumn1.DataPropertyName = "IdPointReg";
            this.idPointRegDataGridViewTextBoxColumn1.HeaderText = "IdPointReg";
            this.idPointRegDataGridViewTextBoxColumn1.Name = "idPointRegDataGridViewTextBoxColumn1";
            this.idPointRegDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idPointRegDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idDocTypeDataGridViewTextBoxColumn1
            // 
            this.idDocTypeDataGridViewTextBoxColumn1.DataPropertyName = "idDocType";
            this.idDocTypeDataGridViewTextBoxColumn1.HeaderText = "idDocType";
            this.idDocTypeDataGridViewTextBoxColumn1.Name = "idDocTypeDataGridViewTextBoxColumn1";
            this.idDocTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDocTypeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // docTypeDataGridViewTextBoxColumn1
            // 
            this.docTypeDataGridViewTextBoxColumn1.DataPropertyName = "DocType";
            this.docTypeDataGridViewTextBoxColumn1.HeaderText = "DocType";
            this.docTypeDataGridViewTextBoxColumn1.Name = "docTypeDataGridViewTextBoxColumn1";
            this.docTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.docTypeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idZoneDataGridViewTextBoxColumn1
            // 
            this.idZoneDataGridViewTextBoxColumn1.DataPropertyName = "IdZone";
            this.idZoneDataGridViewTextBoxColumn1.HeaderText = "IdZone";
            this.idZoneDataGridViewTextBoxColumn1.Name = "idZoneDataGridViewTextBoxColumn1";
            this.idZoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idZoneDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dateActBezuch
            // 
            this.dateActBezuch.DataPropertyName = "DateAct";
            this.dateActBezuch.HeaderText = "Дата";
            this.dateActBezuch.Name = "dateActBezuch";
            this.dateActBezuch.ReadOnly = true;
            this.dateActBezuch.Width = 80;
            // 
            // zoneDataGridViewTextBoxColumn1
            // 
            this.zoneDataGridViewTextBoxColumn1.DataPropertyName = "zone";
            this.zoneDataGridViewTextBoxColumn1.HeaderText = "Зона";
            this.zoneDataGridViewTextBoxColumn1.Name = "zoneDataGridViewTextBoxColumn1";
            this.zoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.zoneDataGridViewTextBoxColumn1.Width = 60;
            // 
            // valueKWTDataGridViewTextBoxColumn1
            // 
            this.valueKWTDataGridViewTextBoxColumn1.DataPropertyName = "ValueKWT";
            this.valueKWTDataGridViewTextBoxColumn1.HeaderText = "Показание";
            this.valueKWTDataGridViewTextBoxColumn1.Name = "valueKWTDataGridViewTextBoxColumn1";
            this.valueKWTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.valueKWTDataGridViewTextBoxColumn1.Width = 70;
            // 
            // SizeKWT
            // 
            this.SizeKWT.DataPropertyName = "SizeKWT";
            this.SizeKWT.HeaderText = "кВт*ч";
            this.SizeKWT.Name = "SizeKWT";
            this.SizeKWT.ReadOnly = true;
            this.SizeKWT.Width = 70;
            // 
            // valueMoneyDataGridViewTextBoxColumn1
            // 
            this.valueMoneyDataGridViewTextBoxColumn1.DataPropertyName = "ValueMoney";
            this.valueMoneyDataGridViewTextBoxColumn1.HeaderText = "ValueMoney";
            this.valueMoneyDataGridViewTextBoxColumn1.Name = "valueMoneyDataGridViewTextBoxColumn1";
            this.valueMoneyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.valueMoneyDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dateInDataGridViewTextBoxColumn1
            // 
            this.dateInDataGridViewTextBoxColumn1.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn1.HeaderText = "DateIn";
            this.dateInDataGridViewTextBoxColumn1.Name = "dateInDataGridViewTextBoxColumn1";
            this.dateInDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateInDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idWorkerDataGridViewTextBoxColumn1
            // 
            this.idWorkerDataGridViewTextBoxColumn1.DataPropertyName = "IdWorker";
            this.idWorkerDataGridViewTextBoxColumn1.HeaderText = "IdWorker";
            this.idWorkerDataGridViewTextBoxColumn1.Name = "idWorkerDataGridViewTextBoxColumn1";
            this.idWorkerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idWorkerDataGridViewTextBoxColumn1.Visible = false;
            // 
            // workerAct
            // 
            this.workerAct.DataPropertyName = "worker";
            this.workerAct.HeaderText = "Контролер";
            this.workerAct.Name = "workerAct";
            this.workerAct.ReadOnly = true;
            // 
            // idOwnerDataGridViewTextBoxColumn1
            // 
            this.idOwnerDataGridViewTextBoxColumn1.DataPropertyName = "IdOwner";
            this.idOwnerDataGridViewTextBoxColumn1.HeaderText = "IdOwner";
            this.idOwnerDataGridViewTextBoxColumn1.Name = "idOwnerDataGridViewTextBoxColumn1";
            this.idOwnerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idOwnerDataGridViewTextBoxColumn1.Visible = false;
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "Коментарий";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            this.commentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn1.Width = 200;
            // 
            // owner
            // 
            this.owner.DataPropertyName = "owner";
            this.owner.HeaderText = "owner";
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            this.owner.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Norm";
            this.dataGridViewTextBoxColumn1.HeaderText = "Norm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // bsBezuch
            // 
            this.bsBezuch.DataMember = "vDocActBezuch";
            this.bsBezuch.DataSource = this.dsRep;
            // 
            // groupBoxKO
            // 
            this.groupBoxKO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxKO.Controls.Add(this.dgvAktKO);
            this.groupBoxKO.Location = new System.Drawing.Point(3, 92);
            this.groupBoxKO.Name = "groupBoxKO";
            this.groupBoxKO.Size = new System.Drawing.Size(650, 133);
            this.groupBoxKO.TabIndex = 25;
            this.groupBoxKO.TabStop = false;
            this.groupBoxKO.Text = "Контрольные обходы";
            // 
            // dgvAktKO
            // 
            this.dgvAktKO.AllowUserToAddRows = false;
            this.dgvAktKO.AllowUserToDeleteRows = false;
            this.dgvAktKO.AutoGenerateColumns = false;
            this.dgvAktKO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktKO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idPointDataGridViewTextBoxColumn,
            this.idPointRegDataGridViewTextBoxColumn,
            this.idDocTypeDataGridViewTextBoxColumn,
            this.docTypeDataGridViewTextBoxColumn,
            this.idZoneDataGridViewTextBoxColumn,
            this.valueMoneyDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.dateActKO,
            this.zoneDataGridViewTextBoxColumn,
            this.valueKWTDataGridViewTextBoxColumn,
            this.idWorkerDataGridViewTextBoxColumn,
            this.workerKO,
            this.idOwnerDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.sizeKWTDataGridViewTextBoxColumn});
            this.dgvAktKO.DataSource = this.bsKO;
            this.dgvAktKO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAktKO.Location = new System.Drawing.Point(3, 16);
            this.dgvAktKO.Name = "dgvAktKO";
            this.dgvAktKO.ReadOnly = true;
            this.dgvAktKO.RowHeadersWidth = 5;
            this.dgvAktKO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAktKO.Size = new System.Drawing.Size(644, 114);
            this.dgvAktKO.TabIndex = 24;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPointDataGridViewTextBoxColumn
            // 
            this.idPointDataGridViewTextBoxColumn.DataPropertyName = "IdPoint";
            this.idPointDataGridViewTextBoxColumn.HeaderText = "IdPoint";
            this.idPointDataGridViewTextBoxColumn.Name = "idPointDataGridViewTextBoxColumn";
            this.idPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPointRegDataGridViewTextBoxColumn
            // 
            this.idPointRegDataGridViewTextBoxColumn.DataPropertyName = "IdPointReg";
            this.idPointRegDataGridViewTextBoxColumn.HeaderText = "IdPointReg";
            this.idPointRegDataGridViewTextBoxColumn.Name = "idPointRegDataGridViewTextBoxColumn";
            this.idPointRegDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointRegDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDocTypeDataGridViewTextBoxColumn
            // 
            this.idDocTypeDataGridViewTextBoxColumn.DataPropertyName = "idDocType";
            this.idDocTypeDataGridViewTextBoxColumn.HeaderText = "idDocType";
            this.idDocTypeDataGridViewTextBoxColumn.Name = "idDocTypeDataGridViewTextBoxColumn";
            this.idDocTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // docTypeDataGridViewTextBoxColumn
            // 
            this.docTypeDataGridViewTextBoxColumn.DataPropertyName = "DocType";
            this.docTypeDataGridViewTextBoxColumn.HeaderText = "DocType";
            this.docTypeDataGridViewTextBoxColumn.Name = "docTypeDataGridViewTextBoxColumn";
            this.docTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.docTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // idZoneDataGridViewTextBoxColumn
            // 
            this.idZoneDataGridViewTextBoxColumn.DataPropertyName = "IdZone";
            this.idZoneDataGridViewTextBoxColumn.HeaderText = "IdZone";
            this.idZoneDataGridViewTextBoxColumn.Name = "idZoneDataGridViewTextBoxColumn";
            this.idZoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.idZoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // valueMoneyDataGridViewTextBoxColumn
            // 
            this.valueMoneyDataGridViewTextBoxColumn.DataPropertyName = "ValueMoney";
            this.valueMoneyDataGridViewTextBoxColumn.HeaderText = "ValueMoney";
            this.valueMoneyDataGridViewTextBoxColumn.Name = "valueMoneyDataGridViewTextBoxColumn";
            this.valueMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.valueMoneyDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "DateIn";
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            this.dateInDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateInDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateActKO
            // 
            this.dateActKO.DataPropertyName = "DateAct";
            this.dateActKO.HeaderText = "Дата";
            this.dateActKO.Name = "dateActKO";
            this.dateActKO.ReadOnly = true;
            this.dateActKO.Width = 80;
            // 
            // zoneDataGridViewTextBoxColumn
            // 
            this.zoneDataGridViewTextBoxColumn.DataPropertyName = "zone";
            this.zoneDataGridViewTextBoxColumn.HeaderText = "Зона";
            this.zoneDataGridViewTextBoxColumn.Name = "zoneDataGridViewTextBoxColumn";
            this.zoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.zoneDataGridViewTextBoxColumn.Width = 60;
            // 
            // valueKWTDataGridViewTextBoxColumn
            // 
            this.valueKWTDataGridViewTextBoxColumn.DataPropertyName = "ValueKWT";
            this.valueKWTDataGridViewTextBoxColumn.HeaderText = "Показание";
            this.valueKWTDataGridViewTextBoxColumn.Name = "valueKWTDataGridViewTextBoxColumn";
            this.valueKWTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "IdWorker";
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "IdWorker";
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            this.idWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idWorkerDataGridViewTextBoxColumn.Visible = false;
            // 
            // workerKO
            // 
            this.workerKO.DataPropertyName = "worker";
            this.workerKO.HeaderText = "Контролер";
            this.workerKO.Name = "workerKO";
            this.workerKO.ReadOnly = true;
            // 
            // idOwnerDataGridViewTextBoxColumn
            // 
            this.idOwnerDataGridViewTextBoxColumn.DataPropertyName = "IdOwner";
            this.idOwnerDataGridViewTextBoxColumn.HeaderText = "IdOwner";
            this.idOwnerDataGridViewTextBoxColumn.Name = "idOwnerDataGridViewTextBoxColumn";
            this.idOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOwnerDataGridViewTextBoxColumn.Visible = false;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "owner";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerDataGridViewTextBoxColumn.Visible = false;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Коментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // sizeKWTDataGridViewTextBoxColumn
            // 
            this.sizeKWTDataGridViewTextBoxColumn.DataPropertyName = "SizeKWT";
            this.sizeKWTDataGridViewTextBoxColumn.HeaderText = "SizeKWT";
            this.sizeKWTDataGridViewTextBoxColumn.Name = "sizeKWTDataGridViewTextBoxColumn";
            this.sizeKWTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeKWTDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsKO
            // 
            this.bsKO.DataMember = "vDocAct";
            this.bsKO.DataSource = this.dsRep;
            // 
            // tbRasch
            // 
            this.tbRasch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbRasch.Location = new System.Drawing.Point(91, 371);
            this.tbRasch.Name = "tbRasch";
            this.tbRasch.Size = new System.Drawing.Size(222, 20);
            this.tbRasch.TabIndex = 23;
            // 
            // buttonRasch
            // 
            this.buttonRasch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRasch.Location = new System.Drawing.Point(10, 369);
            this.buttonRasch.Name = "buttonRasch";
            this.buttonRasch.Size = new System.Drawing.Size(75, 23);
            this.buttonRasch.TabIndex = 22;
            this.buttonRasch.Text = "Рассчет";
            this.buttonRasch.UseVisualStyleBackColor = true;
            this.buttonRasch.Click += new System.EventHandler(this.buttonRasch_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(430, 370);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(111, 23);
            this.buttonCreate.TabIndex = 21;
            this.buttonCreate.Text = "Сформировать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(547, 370);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tbAktNumber
            // 
            this.tbAktNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAktNumber.Location = new System.Drawing.Point(72, 68);
            this.tbAktNumber.Name = "tbAktNumber";
            this.tbAktNumber.Size = new System.Drawing.Size(55, 24);
            this.tbAktNumber.TabIndex = 17;
            // 
            // labelAkt
            // 
            this.labelAkt.AutoSize = true;
            this.labelAkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAkt.Location = new System.Drawing.Point(12, 71);
            this.labelAkt.Name = "labelAkt";
            this.labelAkt.Size = new System.Drawing.Size(56, 18);
            this.labelAkt.TabIndex = 16;
            this.labelAkt.Text = "Акт №";
            // 
            // lPeop
            // 
            this.lPeop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lPeop.AutoSize = true;
            this.lPeop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPeop.Location = new System.Drawing.Point(495, 42);
            this.lPeop.Name = "lPeop";
            this.lPeop.Size = new System.Drawing.Size(40, 15);
            this.lPeop.TabIndex = 13;
            this.lPeop.Text = "Peop";
            // 
            // labelPeop
            // 
            this.labelPeop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPeop.AutoSize = true;
            this.labelPeop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPeop.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPeop.Location = new System.Drawing.Point(391, 42);
            this.labelPeop.Name = "labelPeop";
            this.labelPeop.Size = new System.Drawing.Size(107, 13);
            this.labelPeop.TabIndex = 12;
            this.labelPeop.Text = "Кол-во прожив. :";
            // 
            // lQRooms
            // 
            this.lQRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lQRooms.AutoSize = true;
            this.lQRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQRooms.Location = new System.Drawing.Point(495, 24);
            this.lQRooms.Name = "lQRooms";
            this.lQRooms.Size = new System.Drawing.Size(62, 15);
            this.lQRooms.TabIndex = 11;
            this.lQRooms.Text = "QRooms";
            // 
            // labelQRooms
            // 
            this.labelQRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQRooms.AutoSize = true;
            this.labelQRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQRooms.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelQRooms.Location = new System.Drawing.Point(396, 26);
            this.labelQRooms.Name = "labelQRooms";
            this.labelQRooms.Size = new System.Drawing.Size(102, 13);
            this.labelQRooms.TabIndex = 10;
            this.labelQRooms.Text = "Кол-во комнат :";
            // 
            // lCont
            // 
            this.lCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCont.AutoSize = true;
            this.lCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCont.Location = new System.Drawing.Point(495, 6);
            this.lCont.Name = "lCont";
            this.lCont.Size = new System.Drawing.Size(70, 15);
            this.lCont.TabIndex = 9;
            this.lCont.Text = "Controller";
            // 
            // labelCont
            // 
            this.labelCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCont.AutoSize = true;
            this.labelCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCont.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCont.Location = new System.Drawing.Point(420, 8);
            this.labelCont.Name = "labelCont";
            this.labelCont.Size = new System.Drawing.Size(78, 13);
            this.labelCont.TabIndex = 8;
            this.labelCont.Text = "Контролер :";
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFIO.Location = new System.Drawing.Point(91, 24);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(29, 15);
            this.lFIO.TabIndex = 7;
            this.lFIO.Text = "FIO";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFIO.Location = new System.Drawing.Point(28, 26);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(57, 13);
            this.labelFIO.TabIndex = 6;
            this.labelFIO.Text = "Ф.И.О. :";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAdress.Location = new System.Drawing.Point(34, 44);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(51, 13);
            this.labelAdress.TabIndex = 4;
            this.labelAdress.Text = "Адрес :";
            // 
            // labelAdr
            // 
            this.labelAdr.AutoSize = true;
            this.labelAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdr.Location = new System.Drawing.Point(91, 42);
            this.labelAdr.Name = "labelAdr";
            this.labelAdr.Size = new System.Drawing.Size(50, 15);
            this.labelAdr.TabIndex = 3;
            this.labelAdr.Text = "Adress";
            // 
            // labelCA
            // 
            this.labelCA.AutoSize = true;
            this.labelCA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRep, "vAbnForRep.CodeAbonent", true));
            this.labelCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCA.Location = new System.Drawing.Point(126, 3);
            this.labelCA.Name = "labelCA";
            this.labelCA.Size = new System.Drawing.Size(119, 20);
            this.labelCA.TabIndex = 2;
            this.labelCA.Text = "CodeAbonent";
            // 
            // labelCodeAbonent
            // 
            this.labelCodeAbonent.AutoSize = true;
            this.labelCodeAbonent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCodeAbonent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCodeAbonent.Location = new System.Drawing.Point(28, 8);
            this.labelCodeAbonent.Name = "labelCodeAbonent";
            this.labelCodeAbonent.Size = new System.Drawing.Size(92, 13);
            this.labelCodeAbonent.TabIndex = 1;
            this.labelCodeAbonent.Text = "Лицевой счет:";
            // 
            // panelPrn
            // 
            this.panelPrn.Controls.Add(this.reportViewerAkt);
            this.panelPrn.Controls.Add(this.buttonReturn);
            this.panelPrn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrn.Location = new System.Drawing.Point(0, 0);
            this.panelPrn.Name = "panelPrn";
            this.panelPrn.Size = new System.Drawing.Size(657, 404);
            this.panelPrn.TabIndex = 31;
            // 
            // reportViewerAkt
            // 
            this.reportViewerAkt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerAkt.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportActBezuch.rdlc";
            this.reportViewerAkt.Location = new System.Drawing.Point(0, 0);
            this.reportViewerAkt.Name = "reportViewerAkt";
            this.reportViewerAkt.Size = new System.Drawing.Size(656, 320);
            this.reportViewerAkt.TabIndex = 1;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturn.Location = new System.Drawing.Point(568, 325);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormActBezuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 404);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelPrn);
            this.Name = "FormActBezuch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Акт безучетного потребления";
            this.Load += new System.EventHandler(this.FormActBezuch_Load);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            this.groupBoxAkt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnAktRcp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBezuch)).EndInit();
            this.groupBoxKO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktKO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKO)).EndInit();
            this.panelPrn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label labelEngeneer;
        private System.Windows.Forms.ComboBox comboBoxEngeneer;
        private System.Windows.Forms.TextBox tbItog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAkt;
        private System.Windows.Forms.DataGridView dgvAbnAktRcp;
        private System.Windows.Forms.GroupBox groupBoxKO;
        private System.Windows.Forms.DataGridView dgvAktKO;
        private System.Windows.Forms.TextBox tbRasch;
        private System.Windows.Forms.Button buttonRasch;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox tbAktNumber;
        private System.Windows.Forms.Label labelAkt;
        private System.Windows.Forms.Label lPeop;
        private System.Windows.Forms.Label labelPeop;
        private System.Windows.Forms.Label lQRooms;
        private System.Windows.Forms.Label labelQRooms;
        private System.Windows.Forms.Label lCont;
        private System.Windows.Forms.Label labelCont;
        private System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelAdr;
        private System.Windows.Forms.Label labelCA;
        private System.Windows.Forms.Label labelCodeAbonent;
        private System.Windows.Forms.Panel panelPrn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAkt;
        private System.Windows.Forms.Button buttonReturn;
        private DataSets.DataSetRep dsRep;
        private System.Windows.Forms.BindingSource bsBezuch;
        private System.Windows.Forms.BindingSource bsKO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Norm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointRegDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn docTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateActBezuch;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueKWTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeKWT;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueMoneyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOwnerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateActKO;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueKWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerKO;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeKWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lBoss;
        private System.Windows.Forms.TextBox tbBoss;
    }
}