namespace Legal.Forms.Document
{
    partial class FormDocScan
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
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtCnt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAbn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpScan = new System.Windows.Forms.GroupBox();
            this.dgvScan = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.ImageOriginal = new System.Windows.Forms.DataGridViewImageColumn();
            this.Compressed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDoc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dsScan1 = new Legal.DataSet.dsScan();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.pbScan = new System.Windows.Forms.PictureBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.txtDir = new System.Windows.Forms.RichTextBox();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDir = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.grp1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScan)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsScan1)).BeginInit();
            this.grp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
            this.grpFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).BeginInit();
            this.SuspendLayout();
            // 
            // grp1
            // 
            this.grp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grp1.Controls.Add(this.btnFind);
            this.grp1.Controls.Add(this.btnDel);
            this.grp1.Controls.Add(this.btnAdd);
            this.grp1.Controls.Add(this.groupBox8);
            this.grp1.Controls.Add(this.groupBox5);
            this.grp1.Controls.Add(this.grpScan);
            this.grp1.Controls.Add(this.groupBox3);
            this.grp1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grp1.Location = new System.Drawing.Point(8, 4);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(326, 675);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            this.grp1.Text = " к чему привязываем ";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(44, 400);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(44, 481);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(44, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.txtCnt);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.txtObj);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.txtAbn);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Location = new System.Drawing.Point(6, 528);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(314, 141);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "сведения о владельце документа";
            // 
            // txtCnt
            // 
            this.txtCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCnt.Location = new System.Drawing.Point(4, 114);
            this.txtCnt.Name = "txtCnt";
            this.txtCnt.Size = new System.Drawing.Size(302, 20);
            this.txtCnt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "прибор учета:";
            // 
            // txtObj
            // 
            this.txtObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObj.Location = new System.Drawing.Point(4, 75);
            this.txtObj.Name = "txtObj";
            this.txtObj.Size = new System.Drawing.Size(304, 20);
            this.txtObj.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "объект:";
            // 
            // txtAbn
            // 
            this.txtAbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAbn.Location = new System.Drawing.Point(4, 36);
            this.txtAbn.Name = "txtAbn";
            this.txtAbn.Size = new System.Drawing.Size(304, 20);
            this.txtAbn.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "потребитель:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbYear);
            this.groupBox5.Controls.Add(this.cmbRegion);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(6, 251);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(147, 143);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "дополнительно";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbYear.Location = new System.Drawing.Point(4, 83);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(134, 21);
            this.cmbYear.TabIndex = 5;
            // 
            // cmbRegion
            // 
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Items.AddRange(new object[] {
            "Сетевой район №1",
            "Сетевой район №2",
            "Сетевой район №3",
            "Сетевой район №4"});
            this.cmbRegion.Location = new System.Drawing.Point(4, 43);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(134, 21);
            this.cmbRegion.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "год документа:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "сетевой район:";
            // 
            // grpScan
            // 
            this.grpScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpScan.Controls.Add(this.dgvScan);
            this.grpScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpScan.Location = new System.Drawing.Point(159, 27);
            this.grpScan.Name = "grpScan";
            this.grpScan.Size = new System.Drawing.Size(167, 492);
            this.grpScan.TabIndex = 1;
            this.grpScan.TabStop = false;
            this.grpScan.Text = "сканы документа";
            // 
            // dgvScan
            // 
            this.dgvScan.AllowUserToAddRows = false;
            this.dgvScan.AllowUserToDeleteRows = false;
            this.dgvScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScan.ColumnHeadersVisible = false;
            this.dgvScan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.ImageOriginal,
            this.Compressed,
            this.id});
            this.dgvScan.Location = new System.Drawing.Point(0, 19);
            this.dgvScan.Name = "dgvScan";
            this.dgvScan.ReadOnly = true;
            this.dgvScan.RowHeadersWidth = 4;
            this.dgvScan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvScan.RowTemplate.Height = 200;
            this.dgvScan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScan.Size = new System.Drawing.Size(167, 473);
            this.dgvScan.TabIndex = 40;
            this.dgvScan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvScan_CellMouseClick);
            this.dgvScan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvScan_MouseDoubleClick);
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image.HeaderText = "image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            // 
            // ImageOriginal
            // 
            this.ImageOriginal.HeaderText = "ImageOriginal";
            this.ImageOriginal.Name = "ImageOriginal";
            this.ImageOriginal.ReadOnly = true;
            this.ImageOriginal.Visible = false;
            // 
            // Compressed
            // 
            this.Compressed.HeaderText = "Compressed";
            this.Compressed.Name = "Compressed";
            this.Compressed.ReadOnly = true;
            this.Compressed.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbOwner);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtDoc);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNumberDoc);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbType);
            this.groupBox3.Location = new System.Drawing.Point(6, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 218);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "документ";
            // 
            // cmbOwner
            // 
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Items.AddRange(new object[] {
            "потребитель",
            "объект",
            "прибор учета"});
            this.cmbOwner.Location = new System.Drawing.Point(4, 44);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(137, 21);
            this.cmbOwner.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "тип владельца документа:";
            // 
            // dtDoc
            // 
            this.dtDoc.Location = new System.Drawing.Point(5, 185);
            this.dtDoc.Name = "dtDoc";
            this.dtDoc.Size = new System.Drawing.Size(134, 20);
            this.dtDoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "дата документа:";
            // 
            // txtNumberDoc
            // 
            this.txtNumberDoc.Location = new System.Drawing.Point(4, 137);
            this.txtNumberDoc.Name = "txtNumberDoc";
            this.txtNumberDoc.Size = new System.Drawing.Size(134, 20);
            this.txtNumberDoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "номер документа:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "вид документа:";
            // 
            // cmbType
            // 
            this.cmbType.DataSource = this.dsScan1;
            this.cmbType.DisplayMember = "tR_Classifier.Name";
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(4, 89);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(137, 21);
            this.cmbType.TabIndex = 2;
            this.cmbType.ValueMember = "tR_Classifier.Id";
            // 
            // dsScan1
            // 
            this.dsScan1.DataSetName = "dsScan";
            this.dsScan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grp2
            // 
            this.grp2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp2.Controls.Add(this.pbScan);
            this.grp2.Controls.Add(this.Cancel);
            this.grp2.Controls.Add(this.grpFile);
            this.grp2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grp2.Location = new System.Drawing.Point(340, 4);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(658, 681);
            this.grp2.TabIndex = 1;
            this.grp2.TabStop = false;
            this.grp2.Text = " что привязываем ";
            // 
            // pbScan
            // 
            this.pbScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbScan.Location = new System.Drawing.Point(6, 19);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(463, 656);
            this.pbScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScan.TabIndex = 0;
            this.pbScan.TabStop = false;
            this.pbScan.Click += new System.EventHandler(this.pbScan_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(532, 645);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Выход";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // grpFile
            // 
            this.grpFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFile.Controls.Add(this.txtDir);
            this.grpFile.Controls.Add(this.txtMask);
            this.grpFile.Controls.Add(this.label8);
            this.grpFile.Controls.Add(this.dgvDir);
            this.grpFile.Controls.Add(this.buttonFile);
            this.grpFile.Location = new System.Drawing.Point(475, 19);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(177, 620);
            this.grpFile.TabIndex = 1;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "откуда привязываем";
            // 
            // txtDir
            // 
            this.txtDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDir.Location = new System.Drawing.Point(6, 18);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(135, 65);
            this.txtDir.TabIndex = 103;
            this.txtDir.Text = "";
            // 
            // txtMask
            // 
            this.txtMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMask.Location = new System.Drawing.Point(8, 594);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(165, 20);
            this.txtMask.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Маска для файлов:";
            // 
            // dgvDir
            // 
            this.dgvDir.AllowUserToAddRows = false;
            this.dgvDir.AllowUserToDeleteRows = false;
            this.dgvDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName});
            this.dgvDir.Location = new System.Drawing.Point(6, 89);
            this.dgvDir.Name = "dgvDir";
            this.dgvDir.ReadOnly = true;
            this.dgvDir.RowHeadersWidth = 4;
            this.dgvDir.Size = new System.Drawing.Size(165, 476);
            this.dgvDir.TabIndex = 100;
            this.dgvDir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDir_MouseClick);
            // 
            // FileName
            // 
            this.FileName.HeaderText = "Файл с изображением";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 200;
            // 
            // buttonFile
            // 
            this.buttonFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFile.AutoEllipsis = true;
            this.buttonFile.Image = global::Legal.Properties.Resources.stock_folder_move;
            this.buttonFile.Location = new System.Drawing.Point(147, 36);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(24, 20);
            this.buttonFile.TabIndex = 99;
            this.buttonFile.Text = "...";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // FormDocScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(1000, 684);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Name = "FormDocScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Привязка сканированных изображений к документам";
            this.Load += new System.EventHandler(this.FormDocScan_Load);
            this.grp1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpScan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsScan1)).EndInit();
            this.grp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).EndInit();
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox grpScan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DateTimePicker dtDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAbn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtDir;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDir;
        private System.Windows.Forms.Button buttonFile;
        private DataSet.dsScan dsScan1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.PictureBox pbScan;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvScan;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewImageColumn ImageOriginal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Compressed;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}