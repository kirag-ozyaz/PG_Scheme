namespace Legal.Forms.Calculat
{
    partial class FormReportMain
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportMain));
            this.clbSpecialist = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.dsCntVal1 = new Legal.DataSet.dsCntVal();
            this.f_PaymentSelect = new System.Windows.Forms.ComboBox();
            this.cmbDogovor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsCntVal1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.treeViewTariff = new nsThreeStateTreeview.ThreeStateTreeview();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEnter = new System.Windows.Forms.CheckBox();
            this.cbODN = new System.Windows.Forms.CheckBox();
            this.rbRaion = new System.Windows.Forms.RadioButton();
            this.rbMaster = new System.Windows.Forms.RadioButton();
            this.rbSpecial = new System.Windows.Forms.RadioButton();
            this.cbCrossFlow = new System.Windows.Forms.CheckBox();
            this.cbUnmetered = new System.Windows.Forms.CheckBox();
            this.cbDirect = new System.Windows.Forms.CheckBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTariff = new System.Windows.Forms.CheckBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnPrint1 = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnDNU = new System.Windows.Forms.ToolStripButton();
            this.btnExportExcelOther = new System.Windows.Forms.ToolStripButton();
            this.btnExportExcelObject = new System.Windows.Forms.ToolStripButton();
            this.btnReportAverage = new System.Windows.Forms.ToolStripButton();
            this.btnReportHouse = new System.Windows.Forms.ToolStripButton();
            this.txtCountRows = new System.Windows.Forms.ToolStripTextBox();
            this.btnReportPeriod = new System.Windows.Forms.ToolStripButton();
            this.btnJournalActCheck = new System.Windows.Forms.ToolStripButton();
            this.btnJournalMeterDemontag = new System.Windows.Forms.ToolStripButton();
            this.btnExcelObjLink = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnNet = new System.Windows.Forms.Button();
            this.clbOrgNet = new System.Windows.Forms.CheckedListBox();
            this.clbOrgSale = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRowCount = new System.Windows.Forms.TextBox();
            this.rbTariffGroup = new System.Windows.Forms.RadioButton();
            this.rbTariffValue = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.clbStation = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dsDop2 = new Legal.DataSet.dsDop();
            this.cbGroup = new System.Windows.Forms.CheckBox();
            this.dsReportMainFilter1 = new Legal.DataSet.dsReportMainFilter();
            this.cbObject = new System.Windows.Forms.CheckBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportMainFilter1)).BeginInit();
            this.SuspendLayout();
            // 
            // clbSpecialist
            // 
            this.clbSpecialist.FormattingEnabled = true;
            this.clbSpecialist.Location = new System.Drawing.Point(12, 109);
            this.clbSpecialist.Name = "clbSpecialist";
            this.clbSpecialist.Size = new System.Drawing.Size(198, 94);
            this.clbSpecialist.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "За период:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "по:";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(37, 63);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 38;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(37, 34);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 37;
            // 
            // dsCntVal1
            // 
            this.dsCntVal1.DataSetName = "dsCntVal";
            this.dsCntVal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_PaymentSelect
            // 
            this.f_PaymentSelect.DataSource = this.dsCntVal1;
            this.f_PaymentSelect.DisplayMember = "tR_Classifier.Name";
            this.f_PaymentSelect.FormattingEnabled = true;
            this.f_PaymentSelect.Location = new System.Drawing.Point(12, 284);
            this.f_PaymentSelect.Name = "f_PaymentSelect";
            this.f_PaymentSelect.Size = new System.Drawing.Size(199, 21);
            this.f_PaymentSelect.TabIndex = 39;
            this.f_PaymentSelect.ValueMember = "tR_Classifier.Id";
            // 
            // cmbDogovor
            // 
            this.cmbDogovor.DataSource = this.dsCntVal1;
            this.cmbDogovor.DisplayMember = "tR_Classifier1.Name";
            this.cmbDogovor.FormattingEnabled = true;
            this.cmbDogovor.Location = new System.Drawing.Point(13, 224);
            this.cmbDogovor.Name = "cmbDogovor";
            this.cmbDogovor.Size = new System.Drawing.Size(199, 21);
            this.cmbDogovor.TabIndex = 41;
            this.cmbDogovor.ValueMember = "tR_Classifier1.Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Тип договора:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(227, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(726, 464);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // dsCntVal1BindingSource
            // 
            this.dsCntVal1BindingSource.DataSource = this.dsCntVal1;
            this.dsCntVal1BindingSource.Position = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOK.Location = new System.Drawing.Point(823, 543);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 44;
            this.btnOK.Text = "Сформировать";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCancel.Location = new System.Drawing.Point(823, 583);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // treeViewTariff
            // 
            this.treeViewTariff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewTariff.CheckBoxes = true;
            this.treeViewTariff.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.treeViewTariff.Location = new System.Drawing.Point(13, 311);
            this.treeViewTariff.Name = "treeViewTariff";
            this.treeViewTariff.Size = new System.Drawing.Size(198, 92);
            this.treeViewTariff.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.cbEnter);
            this.groupBox1.Controls.Add(this.cbODN);
            this.groupBox1.Controls.Add(this.rbRaion);
            this.groupBox1.Controls.Add(this.rbMaster);
            this.groupBox1.Controls.Add(this.rbSpecial);
            this.groupBox1.Controls.Add(this.cbCrossFlow);
            this.groupBox1.Controls.Add(this.cbUnmetered);
            this.groupBox1.Controls.Add(this.cbDirect);
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Controls.Add(this.treeViewTariff);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDogovor);
            this.groupBox1.Controls.Add(this.f_PaymentSelect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.dtBegin);
            this.groupBox1.Controls.Add(this.clbSpecialist);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 409);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // cbEnter
            // 
            this.cbEnter.AutoSize = true;
            this.cbEnter.Location = new System.Drawing.Point(117, 263);
            this.cbEnter.Name = "cbEnter";
            this.cbEnter.Size = new System.Drawing.Size(49, 17);
            this.cbEnter.TabIndex = 63;
            this.cbEnter.Text = "вход";
            this.cbEnter.UseVisualStyleBackColor = true;
            // 
            // cbODN
            // 
            this.cbODN.AutoSize = true;
            this.cbODN.Location = new System.Drawing.Point(12, 263);
            this.cbODN.Name = "cbODN";
            this.cbODN.Size = new System.Drawing.Size(99, 17);
            this.cbODN.TabIndex = 62;
            this.cbODN.Text = "общедомовые";
            this.cbODN.UseVisualStyleBackColor = true;
            // 
            // rbRaion
            // 
            this.rbRaion.AutoSize = true;
            this.rbRaion.Location = new System.Drawing.Point(152, 89);
            this.rbRaion.Name = "rbRaion";
            this.rbRaion.Size = new System.Drawing.Size(63, 17);
            this.rbRaion.TabIndex = 61;
            this.rbRaion.TabStop = true;
            this.rbRaion.Text = "районы";
            this.rbRaion.UseVisualStyleBackColor = true;
            this.rbRaion.CheckedChanged += new System.EventHandler(this.rbRaion_CheckedChanged);
            // 
            // rbMaster
            // 
            this.rbMaster.AutoSize = true;
            this.rbMaster.Location = new System.Drawing.Point(78, 89);
            this.rbMaster.Name = "rbMaster";
            this.rbMaster.Size = new System.Drawing.Size(68, 17);
            this.rbMaster.TabIndex = 60;
            this.rbMaster.TabStop = true;
            this.rbMaster.Text = "мастера";
            this.rbMaster.UseVisualStyleBackColor = true;
            this.rbMaster.CheckedChanged += new System.EventHandler(this.rbMaster_CheckedChanged);
            // 
            // rbSpecial
            // 
            this.rbSpecial.AutoSize = true;
            this.rbSpecial.Location = new System.Drawing.Point(2, 89);
            this.rbSpecial.Name = "rbSpecial";
            this.rbSpecial.Size = new System.Drawing.Size(70, 17);
            this.rbSpecial.TabIndex = 59;
            this.rbSpecial.TabStop = true;
            this.rbSpecial.Text = "специал.";
            this.rbSpecial.UseVisualStyleBackColor = true;
            this.rbSpecial.CheckedChanged += new System.EventHandler(this.rbSpecial_CheckedChanged);
            // 
            // cbCrossFlow
            // 
            this.cbCrossFlow.AutoSize = true;
            this.cbCrossFlow.Location = new System.Drawing.Point(148, 248);
            this.cbCrossFlow.Name = "cbCrossFlow";
            this.cbCrossFlow.Size = new System.Drawing.Size(73, 17);
            this.cbCrossFlow.TabIndex = 58;
            this.cbCrossFlow.Text = "перетоки";
            this.cbCrossFlow.UseVisualStyleBackColor = true;
            // 
            // cbUnmetered
            // 
            this.cbUnmetered.AutoSize = true;
            this.cbUnmetered.Location = new System.Drawing.Point(77, 248);
            this.cbUnmetered.Name = "cbUnmetered";
            this.cbUnmetered.Size = new System.Drawing.Size(65, 17);
            this.cbUnmetered.TabIndex = 57;
            this.cbUnmetered.Text = "безучет";
            this.cbUnmetered.UseVisualStyleBackColor = true;
            // 
            // cbDirect
            // 
            this.cbDirect.AutoSize = true;
            this.cbDirect.Location = new System.Drawing.Point(12, 248);
            this.cbDirect.Name = "cbDirect";
            this.cbDirect.Size = new System.Drawing.Size(62, 17);
            this.cbDirect.TabIndex = 56;
            this.cbDirect.Text = "непоср";
            this.cbDirect.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(184, 62);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(16, 23);
            this.btnMinus.TabIndex = 55;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(184, 33);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(16, 23);
            this.btnPlus.TabIndex = 54;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Группировка строк:";
            // 
            // cbTariff
            // 
            this.cbTariff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTariff.AutoSize = true;
            this.cbTariff.Location = new System.Drawing.Point(13, 592);
            this.cbTariff.Name = "cbTariff";
            this.cbTariff.Size = new System.Drawing.Size(195, 17);
            this.cbTariff.TabIndex = 53;
            this.cbTariff.Text = "дополнит. разбивать по тарифам";
            this.cbTariff.UseVisualStyleBackColor = true;
            this.cbTariff.CheckedChanged += new System.EventHandler(this.cbTariff_CheckedChanged);
            // 
            // cmbGroup
            // 
            this.cmbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "Потребители",
            "Тарифы",
            "Специалисты",
            "Тип договора",
            "Вид начисления",
            "Подстанции",
            "Объекты",
            "Сети"});
            this.cmbGroup.Location = new System.Drawing.Point(13, 545);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(199, 21);
            this.cmbGroup.TabIndex = 51;
            this.cmbGroup.Tag = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.btnPrint1,
            this.btnExport,
            this.btnDNU,
            this.btnExportExcelOther,
            this.btnExportExcelObject,
            this.btnReportAverage,
            this.btnReportHouse,
            this.txtCountRows,
            this.btnReportPeriod,
            this.btnJournalActCheck,
            this.btnJournalMeterDemontag,
            this.btnExcelObjLink});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(957, 25);
            this.toolStrip1.TabIndex = 55;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.Text = "toolStripButton1";
            this.btnPrint.ToolTipText = "Экспорт в Excel - обычный отчет";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrint1
            // 
            this.btnPrint1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPrint1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint1.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint1.Image")));
            this.btnPrint1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint1.Name = "btnPrint1";
            this.btnPrint1.Size = new System.Drawing.Size(23, 22);
            this.btnPrint1.Text = "toolStripButton1";
            this.btnPrint1.ToolTipText = "Отчет для сверки с сбытовой организации";
            this.btnPrint1.Click += new System.EventHandler(this.btnPrint1_Click);
            // 
            // btnExport
            // 
            this.btnExport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(23, 22);
            this.btnExport.Text = "toolStripButton1";
            this.btnExport.ToolTipText = "Отчет для сверки с Ульяновскэнерго";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDNU
            // 
            this.btnDNU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDNU.Image = ((System.Drawing.Image)(resources.GetObject("btnDNU.Image")));
            this.btnDNU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDNU.Name = "btnDNU";
            this.btnDNU.Size = new System.Drawing.Size(23, 22);
            this.btnDNU.Text = "toolStripButton1";
            this.btnDNU.ToolTipText = "Импорт объемов по ДНУ";
            this.btnDNU.Click += new System.EventHandler(this.btnDNU_Click);
            // 
            // btnExportExcelOther
            // 
            this.btnExportExcelOther.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportExcelOther.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcelOther.Image")));
            this.btnExportExcelOther.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportExcelOther.Name = "btnExportExcelOther";
            this.btnExportExcelOther.Size = new System.Drawing.Size(23, 22);
            this.btnExportExcelOther.Text = "toolStripButton1";
            this.btnExportExcelOther.ToolTipText = "Экспорт помесячно по абонентам";
            this.btnExportExcelOther.Click += new System.EventHandler(this.btnExportExcelOther_Click);
            // 
            // btnExportExcelObject
            // 
            this.btnExportExcelObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportExcelObject.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcelObject.Image")));
            this.btnExportExcelObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportExcelObject.Name = "btnExportExcelObject";
            this.btnExportExcelObject.Size = new System.Drawing.Size(23, 22);
            this.btnExportExcelObject.ToolTipText = "Экспорт помесячно по объектам";
            this.btnExportExcelObject.Click += new System.EventHandler(this.btnExportExcelObject_Click);
            // 
            // btnReportAverage
            // 
            this.btnReportAverage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReportAverage.Image = ((System.Drawing.Image)(resources.GetObject("btnReportAverage.Image")));
            this.btnReportAverage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportAverage.Margin = new System.Windows.Forms.Padding(125, 1, 0, 2);
            this.btnReportAverage.Name = "btnReportAverage";
            this.btnReportAverage.Size = new System.Drawing.Size(23, 22);
            this.btnReportAverage.Text = "toolStripButton1";
            this.btnReportAverage.ToolTipText = "Отчет по начислениям, введенным не по приборам учета";
            this.btnReportAverage.Click += new System.EventHandler(this.btnReportAverage_Click);
            // 
            // btnReportHouse
            // 
            this.btnReportHouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReportHouse.Image = ((System.Drawing.Image)(resources.GetObject("btnReportHouse.Image")));
            this.btnReportHouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportHouse.Name = "btnReportHouse";
            this.btnReportHouse.Size = new System.Drawing.Size(23, 22);
            this.btnReportHouse.Text = "Все дома с начисениями";
            this.btnReportHouse.Click += new System.EventHandler(this.btnReportHouse_Click);
            // 
            // txtCountRows
            // 
            this.txtCountRows.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtCountRows.Name = "txtCountRows";
            this.txtCountRows.Size = new System.Drawing.Size(100, 25);
            // 
            // btnReportPeriod
            // 
            this.btnReportPeriod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReportPeriod.Image = ((System.Drawing.Image)(resources.GetObject("btnReportPeriod.Image")));
            this.btnReportPeriod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportPeriod.Name = "btnReportPeriod";
            this.btnReportPeriod.Size = new System.Drawing.Size(23, 22);
            this.btnReportPeriod.Text = "toolStripButton1";
            this.btnReportPeriod.ToolTipText = "Объемы по специалистам";
            this.btnReportPeriod.Click += new System.EventHandler(this.btnReportPeriod_Click);
            // 
            // btnJournalActCheck
            // 
            this.btnJournalActCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnJournalActCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnJournalActCheck.Image")));
            this.btnJournalActCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJournalActCheck.Name = "btnJournalActCheck";
            this.btnJournalActCheck.Size = new System.Drawing.Size(23, 22);
            this.btnJournalActCheck.Text = "Журнал актов";
            this.btnJournalActCheck.Click += new System.EventHandler(this.btnJournalActCheck_Click);
            // 
            // btnJournalMeterDemontag
            // 
            this.btnJournalMeterDemontag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnJournalMeterDemontag.Image = ((System.Drawing.Image)(resources.GetObject("btnJournalMeterDemontag.Image")));
            this.btnJournalMeterDemontag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJournalMeterDemontag.Name = "btnJournalMeterDemontag";
            this.btnJournalMeterDemontag.Size = new System.Drawing.Size(23, 22);
            this.btnJournalMeterDemontag.Text = "Журнал демонтажа приборов учета";
            this.btnJournalMeterDemontag.ToolTipText = "Журнал демонтажа приборов учета";
            this.btnJournalMeterDemontag.Click += new System.EventHandler(this.btnJournalMeterDemontag_Click);
            // 
            // btnExcelObjLink
            // 
            this.btnExcelObjLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcelObjLink.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelObjLink.Image")));
            this.btnExcelObjLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcelObjLink.Name = "btnExcelObjLink";
            this.btnExcelObjLink.Size = new System.Drawing.Size(23, 22);
            this.btnExcelObjLink.Text = "toolStripButton1";
            this.btnExcelObjLink.Click += new System.EventHandler(this.btnExcelObjLink_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.btnSale);
            this.panel3.Controls.Add(this.btnNet);
            this.panel3.Controls.Add(this.clbOrgNet);
            this.panel3.Controls.Add(this.clbOrgSale);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(229, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 134);
            this.panel3.TabIndex = 56;
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSale.Location = new System.Drawing.Point(199, 93);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(16, 23);
            this.btnSale.TabIndex = 6;
            this.btnSale.Text = ">";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnNet
            // 
            this.btnNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNet.Location = new System.Drawing.Point(199, 34);
            this.btnNet.Name = "btnNet";
            this.btnNet.Size = new System.Drawing.Size(16, 23);
            this.btnNet.TabIndex = 5;
            this.btnNet.Text = "< ";
            this.btnNet.UseVisualStyleBackColor = true;
            this.btnNet.Click += new System.EventHandler(this.btnNet_Click);
            // 
            // clbOrgNet
            // 
            this.clbOrgNet.FormattingEnabled = true;
            this.clbOrgNet.HorizontalScrollbar = true;
            this.clbOrgNet.Location = new System.Drawing.Point(3, 22);
            this.clbOrgNet.Name = "clbOrgNet";
            this.clbOrgNet.Size = new System.Drawing.Size(190, 109);
            this.clbOrgNet.TabIndex = 4;
            // 
            // clbOrgSale
            // 
            this.clbOrgSale.FormattingEnabled = true;
            this.clbOrgSale.HorizontalScrollbar = true;
            this.clbOrgSale.Location = new System.Drawing.Point(221, 22);
            this.clbOrgSale.Name = "clbOrgSale";
            this.clbOrgSale.Size = new System.Drawing.Size(190, 109);
            this.clbOrgSale.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Сбытовая организация:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Сетевая организация:";
            // 
            // txtRowCount
            // 
            this.txtRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRowCount.Enabled = false;
            this.txtRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRowCount.Location = new System.Drawing.Point(853, 495);
            this.txtRowCount.Name = "txtRowCount";
            this.txtRowCount.ReadOnly = true;
            this.txtRowCount.Size = new System.Drawing.Size(100, 20);
            this.txtRowCount.TabIndex = 57;
            // 
            // rbTariffGroup
            // 
            this.rbTariffGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbTariffGroup.AutoSize = true;
            this.rbTariffGroup.Location = new System.Drawing.Point(12, 483);
            this.rbTariffGroup.Name = "rbTariffGroup";
            this.rbTariffGroup.Size = new System.Drawing.Size(186, 17);
            this.rbTariffGroup.TabIndex = 59;
            this.rbTariffGroup.Text = "расход по уровням напряжения";
            this.rbTariffGroup.UseVisualStyleBackColor = true;
            this.rbTariffGroup.CheckedChanged += new System.EventHandler(this.rbTariffGroup_CheckedChanged);
            // 
            // rbTariffValue
            // 
            this.rbTariffValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbTariffValue.AutoSize = true;
            this.rbTariffValue.Checked = true;
            this.rbTariffValue.Location = new System.Drawing.Point(12, 501);
            this.rbTariffValue.Name = "rbTariffValue";
            this.rbTariffValue.Size = new System.Drawing.Size(105, 17);
            this.rbTariffValue.TabIndex = 60;
            this.rbTariffValue.TabStop = true;
            this.rbTariffValue.Text = "расход + сумма";
            this.rbTariffValue.UseVisualStyleBackColor = true;
            this.rbTariffValue.CheckedChanged += new System.EventHandler(this.rbTariffValue_CheckedChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 467);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Группировка колонок:";
            // 
            // clbStation
            // 
            this.clbStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clbStation.FormattingEnabled = true;
            this.clbStation.HorizontalScrollbar = true;
            this.clbStation.Location = new System.Drawing.Point(662, 517);
            this.clbStation.Name = "clbStation";
            this.clbStation.Size = new System.Drawing.Size(106, 109);
            this.clbStation.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Подстанции:";
            // 
            // dsDop2
            // 
            this.dsDop2.DataSetName = "dsDop";
            this.dsDop2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbGroup
            // 
            this.cbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbGroup.AutoSize = true;
            this.cbGroup.Location = new System.Drawing.Point(12, 443);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(199, 17);
            this.cbGroup.TabIndex = 64;
            this.cbGroup.Text = "Фильтр по группам потребителей";
            this.cbGroup.UseVisualStyleBackColor = true;
            this.cbGroup.CheckStateChanged += new System.EventHandler(this.cbGroup_CheckStateChanged);
            // 
            // dsReportMainFilter1
            // 
            this.dsReportMainFilter1.DataSetName = "dsReportMainFilter";
            this.dsReportMainFilter1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbObject
            // 
            this.cbObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbObject.AutoSize = true;
            this.cbObject.Location = new System.Drawing.Point(13, 612);
            this.cbObject.Name = "cbObject";
            this.cbObject.Size = new System.Drawing.Size(200, 17);
            this.cbObject.TabIndex = 65;
            this.cbObject.Text = "дополнит. разбивать по объектам";
            this.cbObject.UseVisualStyleBackColor = true;
            this.cbObject.CheckedChanged += new System.EventHandler(this.cbObject_CheckedChanged);
            // 
            // cbDate
            // 
            this.cbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(13, 569);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(173, 17);
            this.cbDate.TabIndex = 66;
            this.cbDate.Text = "дополнит. разбивать по дате";
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.cbDate_CheckedChanged);
            // 
            // FormReportMain
            // 
            this.ClientSize = new System.Drawing.Size(957, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.cbObject);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clbStation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rbTariffValue);
            this.Controls.Add(this.rbTariffGroup);
            this.Controls.Add(this.txtRowCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbTariff);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReportMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по начислениям по всем потребителям";
            this.Load += new System.EventHandler(this.FormReportMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportMainFilter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbSpecialist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private DataSet.dsCntVal dsCntVal1;
        private System.Windows.Forms.ComboBox f_PaymentSelect;
        private System.Windows.Forms.ComboBox cmbDogovor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource dsCntVal1BindingSource;
        private nsThreeStateTreeview.ThreeStateTreeview treeViewTariff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.CheckBox cbTariff;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox clbOrgSale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox clbOrgNet;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.TextBox txtRowCount;
        private System.Windows.Forms.ToolStripButton btnPrint1;
        private System.Windows.Forms.RadioButton rbTariffGroup;
        private System.Windows.Forms.RadioButton rbTariffValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnNet;
        private System.Windows.Forms.CheckedListBox clbStation;
        private System.Windows.Forms.Label label8;
        //private DataSet.dsDop dsDop1;
        private DataSet.dsDop dsDop2;
        private System.Windows.Forms.CheckBox cbDirect;
        private System.Windows.Forms.CheckBox cbGroup;
        private DataSet.dsReportMainFilter dsReportMainFilter1;
        private System.Windows.Forms.CheckBox cbObject;
        private System.Windows.Forms.CheckBox cbUnmetered;
        private System.Windows.Forms.CheckBox cbCrossFlow;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.RadioButton rbMaster;
        private System.Windows.Forms.RadioButton rbSpecial;
        private System.Windows.Forms.RadioButton rbRaion;
        private System.Windows.Forms.CheckBox cbODN;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnDNU;
        private System.Windows.Forms.ToolStripButton btnExportExcelOther;
        private System.Windows.Forms.CheckBox cbEnter;
        private System.Windows.Forms.ToolStripButton btnExportExcelObject;
        private System.Windows.Forms.ToolStripButton btnReportAverage;
        private System.Windows.Forms.ToolStripButton btnReportHouse;
        private System.Windows.Forms.ToolStripTextBox txtCountRows;
        private System.Windows.Forms.ToolStripButton btnReportPeriod;
        private System.Windows.Forms.ToolStripButton btnJournalActCheck;
        private System.Windows.Forms.ToolStripButton btnJournalMeterDemontag;
        private System.Windows.Forms.ToolStripButton btnExcelObjLink;
    }
}
