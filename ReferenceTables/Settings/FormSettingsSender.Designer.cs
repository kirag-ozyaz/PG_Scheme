
	public partial class FormSettingsSender : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettingsSender));
            this.txtFTP05_FileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFTP05_NameFTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFTP05_FTPUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFTP05_FTPPwd = new System.Windows.Forms.MaskedTextBox();
            this.chbFTP05_Proxy = new System.Windows.Forms.CheckBox();
            this.txtFTP05_Proxy = new System.Windows.Forms.TextBox();
            this.txtFTP05_ProxyUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFTP05_ProxyPwd = new System.Windows.Forms.MaskedTextBox();
            this.chbUseFTP05 = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePlan = new System.Windows.Forms.TabPage();
            this.btnFTP_ChoiceFileNameSESNO = new System.Windows.Forms.Button();
            this.txtFTP_FileNameSESNO = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBoxSheduleFTP = new System.Windows.Forms.GroupBox();
            this.numFTP_weeks = new System.Windows.Forms.NumericUpDown();
            this.numFTP_days = new System.Windows.Forms.NumericUpDown();
            this.numFTP_hours = new System.Windows.Forms.NumericUpDown();
            this.rbFTP_weeks = new System.Windows.Forms.RadioButton();
            this.rbFTP_days = new System.Windows.Forms.RadioButton();
            this.rbFTP_hours = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFTP_start = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnFTP_ChoicePath = new System.Windows.Forms.Button();
            this.btnFTP_ChoiceFileName = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFTP_PathName = new System.Windows.Forms.TextBox();
            this.chbUseFTP = new System.Windows.Forms.CheckBox();
            this.txtFTP_FileName = new System.Windows.Forms.TextBox();
            this.txtFTP_ProxyPwd = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFTP_NameFTP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFTP_ProxyUser = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFTP_Proxy = new System.Windows.Forms.TextBox();
            this.txtFTP_FTPUser = new System.Windows.Forms.TextBox();
            this.chbFTP_Proxy = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFTP_FTPPwd = new System.Windows.Forms.MaskedTextBox();
            this.tabPageCrash = new System.Windows.Forms.TabPage();
            this.groupBoxSheduleFTP05 = new System.Windows.Forms.GroupBox();
            this.numFTP05_weeks = new System.Windows.Forms.NumericUpDown();
            this.numFTP05_days = new System.Windows.Forms.NumericUpDown();
            this.numFTP05_hours = new System.Windows.Forms.NumericUpDown();
            this.rbFTP05_weeks = new System.Windows.Forms.RadioButton();
            this.rbFTP05_days = new System.Windows.Forms.RadioButton();
            this.rbFTP05_hours = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFTP05_start = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFTP05_ChoicePath = new System.Windows.Forms.Button();
            this.btnFTP05_ChoiceFileName = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFTP05_PathName = new System.Windows.Forms.TextBox();
            this.tabPagePlannedMail = new System.Windows.Forms.TabPage();
            this.groupBoxSheduleMailPlanned = new System.Windows.Forms.GroupBox();
            this.numMailPlanned_weeks = new System.Windows.Forms.NumericUpDown();
            this.numMailPlanned_days = new System.Windows.Forms.NumericUpDown();
            this.numMailPlanned_hours = new System.Windows.Forms.NumericUpDown();
            this.rbMailPlanned_weeks = new System.Windows.Forms.RadioButton();
            this.rbMailPlanned_days = new System.Windows.Forms.RadioButton();
            this.rbMailPlanned_hours = new System.Windows.Forms.RadioButton();
            this.label30 = new System.Windows.Forms.Label();
            this.dtpMailPlanned_start = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtBodyPlanned = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSubjectPlanned = new System.Windows.Forms.TextBox();
            this.dgvRecipients = new System.Windows.Forms.DataGridView();
            this.addressRecipientDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameRecipientDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBoxSender = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSenderNamePlanned = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSenderAddressPlanned = new System.Windows.Forms.TextBox();
            this.groupBoxSMTP = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtPwdSMTPPlanned = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtLoginSMTPPlanned = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSMTPServerPortPlanned = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSMTPServerPlanned = new System.Windows.Forms.TextBox();
            this.btnChoiseFileMail = new System.Windows.Forms.Button();
            this.txtFileNameReportHead = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkUseMailPlanned = new System.Windows.Forms.CheckBox();
            this.tabPageRIC = new System.Windows.Forms.TabPage();
            this.groupBoxServices = new System.Windows.Forms.GroupBox();
            this.serviceStatus = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtRemoteServer = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.tsbRestart = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSendCorrectDamage = new System.Windows.Forms.CheckBox();
            this.chkSendNullListAbonent = new System.Windows.Forms.CheckBox();
            this.txtNameURL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCreateAktDLV = new System.Windows.Forms.CheckBox();
            this.chkCreateAktDHV = new System.Windows.Forms.CheckBox();
            this.checkBoxSendME = new System.Windows.Forms.CheckBox();
            this.txtPwdME = new System.Windows.Forms.MaskedTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtUserME = new System.Windows.Forms.TextBox();
            this.checkBoxSendRIC = new System.Windows.Forms.CheckBox();
            this.tabPageReportHead = new System.Windows.Forms.TabPage();
            this.groupBoxCollectionStartingPoint = new System.Windows.Forms.GroupBox();
            this.label49 = new System.Windows.Forms.Label();
            this.cmbOutFormatFile = new System.Windows.Forms.ComboBox();
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.label50 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txtPeriodToBeginDay = new System.Windows.Forms.TextBox();
            this.groupBoxSheduleMail = new System.Windows.Forms.GroupBox();
            this.numMail_weeks = new System.Windows.Forms.NumericUpDown();
            this.numMail_day = new System.Windows.Forms.NumericUpDown();
            this.numMail_hours = new System.Windows.Forms.NumericUpDown();
            this.rbMail_weeks = new System.Windows.Forms.RadioButton();
            this.rbMail_days = new System.Windows.Forms.RadioButton();
            this.rbMail_hours = new System.Windows.Forms.RadioButton();
            this.label35 = new System.Windows.Forms.Label();
            this.dtpBeginMail = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.dgvRecipientsHead = new System.Windows.Forms.DataGridView();
            this.addressDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBoxSenderHead = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtSenderAddress = new System.Windows.Forms.TextBox();
            this.groupBoxSMTPHead = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtPwdSMTP = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtLoginSMTP = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtSMTPServerPort = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.txtSMTPServer = new System.Windows.Forms.TextBox();
            this.btnChoiseReportHead = new System.Windows.Forms.Button();
            this.txtFileNameMailReportHead = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.chkSendReportHead = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCURL = new System.Windows.Forms.TextBox();
            this.btnChoiceCURL = new System.Windows.Forms.Button();
            this.timerServiceRun = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabPagePlan.SuspendLayout();
            this.groupBoxSheduleFTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP_weeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP_days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP_hours)).BeginInit();
            this.tabPageCrash.SuspendLayout();
            this.groupBoxSheduleFTP05.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP05_weeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP05_days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP05_hours)).BeginInit();
            this.tabPagePlannedMail.SuspendLayout();
            this.groupBoxSheduleMailPlanned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMailPlanned_weeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMailPlanned_days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMailPlanned_hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipients)).BeginInit();
            this.groupBoxSender.SuspendLayout();
            this.groupBoxSMTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMTPServerPortPlanned)).BeginInit();
            this.tabPageRIC.SuspendLayout();
            this.groupBoxServices.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageReportHead.SuspendLayout();
            this.groupBoxCollectionStartingPoint.SuspendLayout();
            this.groupBoxSheduleMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMail_weeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMail_day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMail_hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipientsHead)).BeginInit();
            this.groupBoxSenderHead.SuspendLayout();
            this.groupBoxSMTPHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMTPServerPort)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFTP05_FileName
            // 
            this.txtFTP05_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP05_FileName.Location = new System.Drawing.Point(90, 39);
            this.txtFTP05_FileName.Name = "txtFTP05_FileName";
            this.txtFTP05_FileName.Size = new System.Drawing.Size(358, 20);
            this.txtFTP05_FileName.TabIndex = 0;
            this.txtFTP05_FileName.Text = "\\\\ulges-fs\\software\\Ulges\\Site\\oper_otkl.html";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя файла";
            // 
            // txtFTP05_NameFTP
            // 
            this.txtFTP05_NameFTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP05_NameFTP.Location = new System.Drawing.Point(90, 92);
            this.txtFTP05_NameFTP.Name = "txtFTP05_NameFTP";
            this.txtFTP05_NameFTP.Size = new System.Drawing.Size(389, 20);
            this.txtFTP05_NameFTP.TabIndex = 2;
            this.txtFTP05_NameFTP.Text = "ftp://pike.z8.ru/www/site1/public_html/consumer/rabota/oper_otkl.html";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь FTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин FTP";
            // 
            // txtFTP05_FTPUser
            // 
            this.txtFTP05_FTPUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP05_FTPUser.Location = new System.Drawing.Point(90, 118);
            this.txtFTP05_FTPUser.Name = "txtFTP05_FTPUser";
            this.txtFTP05_FTPUser.Size = new System.Drawing.Size(389, 20);
            this.txtFTP05_FTPUser.TabIndex = 5;
            this.txtFTP05_FTPUser.Text = "ulges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль FTP";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 556);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(417, 556);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFTP05_FTPPwd
            // 
            this.txtFTP05_FTPPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP05_FTPPwd.Location = new System.Drawing.Point(90, 144);
            this.txtFTP05_FTPPwd.Name = "txtFTP05_FTPPwd";
            this.txtFTP05_FTPPwd.PasswordChar = '*';
            this.txtFTP05_FTPPwd.Size = new System.Drawing.Size(389, 20);
            this.txtFTP05_FTPPwd.TabIndex = 10;
            this.txtFTP05_FTPPwd.Text = "kil777o";
            // 
            // chbFTP05_Proxy
            // 
            this.chbFTP05_Proxy.AutoSize = true;
            this.chbFTP05_Proxy.Location = new System.Drawing.Point(10, 172);
            this.chbFTP05_Proxy.Name = "chbFTP05_Proxy";
            this.chbFTP05_Proxy.Size = new System.Drawing.Size(138, 17);
            this.chbFTP05_Proxy.TabIndex = 11;
            this.chbFTP05_Proxy.Text = "Использовать прокси";
            this.chbFTP05_Proxy.UseVisualStyleBackColor = true;
            this.chbFTP05_Proxy.CheckedChanged += new System.EventHandler(this.chbFTP05_Proxy_CheckedChanged);
            // 
            // txtFTP05_Proxy
            // 
            this.txtFTP05_Proxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP05_Proxy.Enabled = false;
            this.txtFTP05_Proxy.Location = new System.Drawing.Point(154, 170);
            this.txtFTP05_Proxy.Name = "txtFTP05_Proxy";
            this.txtFTP05_Proxy.Size = new System.Drawing.Size(325, 20);
            this.txtFTP05_Proxy.TabIndex = 12;
            this.txtFTP05_Proxy.Text = "ulges-proxy:8080";
            // 
            // txtFTP05_ProxyUser
            // 
            this.txtFTP05_ProxyUser.Enabled = false;
            this.txtFTP05_ProxyUser.Location = new System.Drawing.Point(132, 196);
            this.txtFTP05_ProxyUser.Name = "txtFTP05_ProxyUser";
            this.txtFTP05_ProxyUser.Size = new System.Drawing.Size(139, 20);
            this.txtFTP05_ProxyUser.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Пользователь прокси";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Пароль";
            // 
            // txtFTP05_ProxyPwd
            // 
            this.txtFTP05_ProxyPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP05_ProxyPwd.Enabled = false;
            this.txtFTP05_ProxyPwd.Location = new System.Drawing.Point(328, 196);
            this.txtFTP05_ProxyPwd.Name = "txtFTP05_ProxyPwd";
            this.txtFTP05_ProxyPwd.PasswordChar = '*';
            this.txtFTP05_ProxyPwd.Size = new System.Drawing.Size(151, 20);
            this.txtFTP05_ProxyPwd.TabIndex = 16;
            this.txtFTP05_ProxyPwd.Text = "kil777o";
            // 
            // chbUseFTP05
            // 
            this.chbUseFTP05.AutoSize = true;
            this.chbUseFTP05.Checked = true;
            this.chbUseFTP05.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbUseFTP05.Location = new System.Drawing.Point(10, 16);
            this.chbUseFTP05.Name = "chbUseFTP05";
            this.chbUseFTP05.Size = new System.Drawing.Size(186, 17);
            this.chbUseFTP05.TabIndex = 17;
            this.chbUseFTP05.Text = "Использовать отправку на FTP";
            this.chbUseFTP05.UseVisualStyleBackColor = true;
            this.chbUseFTP05.CheckedChanged += new System.EventHandler(this.chbUseFTP05_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPagePlan);
            this.tabControl.Controls.Add(this.tabPageCrash);
            this.tabControl.Controls.Add(this.tabPagePlannedMail);
            this.tabControl.Controls.Add(this.tabPageRIC);
            this.tabControl.Controls.Add(this.tabPageReportHead);
            this.tabControl.Location = new System.Drawing.Point(1, 39);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(506, 511);
            this.tabControl.TabIndex = 18;
            // 
            // tabPagePlan
            // 
            this.tabPagePlan.Controls.Add(this.btnFTP_ChoiceFileNameSESNO);
            this.tabPagePlan.Controls.Add(this.txtFTP_FileNameSESNO);
            this.tabPagePlan.Controls.Add(this.label53);
            this.tabPagePlan.Controls.Add(this.groupBoxSheduleFTP);
            this.tabPagePlan.Controls.Add(this.btnFTP_ChoicePath);
            this.tabPagePlan.Controls.Add(this.btnFTP_ChoiceFileName);
            this.tabPagePlan.Controls.Add(this.label13);
            this.tabPagePlan.Controls.Add(this.txtFTP_PathName);
            this.tabPagePlan.Controls.Add(this.chbUseFTP);
            this.tabPagePlan.Controls.Add(this.txtFTP_FileName);
            this.tabPagePlan.Controls.Add(this.txtFTP_ProxyPwd);
            this.tabPagePlan.Controls.Add(this.label14);
            this.tabPagePlan.Controls.Add(this.label15);
            this.tabPagePlan.Controls.Add(this.txtFTP_NameFTP);
            this.tabPagePlan.Controls.Add(this.label16);
            this.tabPagePlan.Controls.Add(this.label17);
            this.tabPagePlan.Controls.Add(this.txtFTP_ProxyUser);
            this.tabPagePlan.Controls.Add(this.label18);
            this.tabPagePlan.Controls.Add(this.txtFTP_Proxy);
            this.tabPagePlan.Controls.Add(this.txtFTP_FTPUser);
            this.tabPagePlan.Controls.Add(this.chbFTP_Proxy);
            this.tabPagePlan.Controls.Add(this.label19);
            this.tabPagePlan.Controls.Add(this.txtFTP_FTPPwd);
            this.tabPagePlan.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlan.Name = "tabPagePlan";
            this.tabPagePlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlan.Size = new System.Drawing.Size(498, 485);
            this.tabPagePlan.TabIndex = 0;
            this.tabPagePlan.Text = "Плановые";
            this.tabPagePlan.UseVisualStyleBackColor = true;
            // 
            // btnFTP_ChoiceFileNameSESNO
            // 
            this.btnFTP_ChoiceFileNameSESNO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFTP_ChoiceFileNameSESNO.Location = new System.Drawing.Point(452, 58);
            this.btnFTP_ChoiceFileNameSESNO.Name = "btnFTP_ChoiceFileNameSESNO";
            this.btnFTP_ChoiceFileNameSESNO.Size = new System.Drawing.Size(28, 23);
            this.btnFTP_ChoiceFileNameSESNO.TabIndex = 47;
            this.btnFTP_ChoiceFileNameSESNO.Text = "...";
            this.btnFTP_ChoiceFileNameSESNO.UseVisualStyleBackColor = true;
            this.btnFTP_ChoiceFileNameSESNO.Click += new System.EventHandler(this.btnFTP_ChoiceFileNameSESNO_Click);
            // 
            // txtFTP_FileNameSESNO
            // 
            this.txtFTP_FileNameSESNO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP_FileNameSESNO.Location = new System.Drawing.Point(137, 60);
            this.txtFTP_FileNameSESNO.Name = "txtFTP_FileNameSESNO";
            this.txtFTP_FileNameSESNO.Size = new System.Drawing.Size(312, 20);
            this.txtFTP_FileNameSESNO.TabIndex = 45;
            this.txtFTP_FileNameSESNO.Text = "plan_rabota_sesno.php";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(9, 57);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(122, 26);
            this.label53.TabIndex = 46;
            this.label53.Text = "Имя файла\r\n(наружное освещение)";
            // 
            // groupBoxSheduleFTP
            // 
            this.groupBoxSheduleFTP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSheduleFTP.Controls.Add(this.numFTP_weeks);
            this.groupBoxSheduleFTP.Controls.Add(this.numFTP_days);
            this.groupBoxSheduleFTP.Controls.Add(this.numFTP_hours);
            this.groupBoxSheduleFTP.Controls.Add(this.rbFTP_weeks);
            this.groupBoxSheduleFTP.Controls.Add(this.rbFTP_days);
            this.groupBoxSheduleFTP.Controls.Add(this.rbFTP_hours);
            this.groupBoxSheduleFTP.Controls.Add(this.label11);
            this.groupBoxSheduleFTP.Controls.Add(this.dtpFTP_start);
            this.groupBoxSheduleFTP.Controls.Add(this.label12);
            this.groupBoxSheduleFTP.Location = new System.Drawing.Point(12, 252);
            this.groupBoxSheduleFTP.Name = "groupBoxSheduleFTP";
            this.groupBoxSheduleFTP.Size = new System.Drawing.Size(468, 219);
            this.groupBoxSheduleFTP.TabIndex = 44;
            this.groupBoxSheduleFTP.TabStop = false;
            this.groupBoxSheduleFTP.Text = "Расписание";
            // 
            // numFTP_weeks
            // 
            this.numFTP_weeks.Enabled = false;
            this.numFTP_weeks.Location = new System.Drawing.Point(80, 114);
            this.numFTP_weeks.Name = "numFTP_weeks";
            this.numFTP_weeks.Size = new System.Drawing.Size(120, 20);
            this.numFTP_weeks.TabIndex = 11;
            // 
            // numFTP_days
            // 
            this.numFTP_days.Enabled = false;
            this.numFTP_days.Location = new System.Drawing.Point(80, 91);
            this.numFTP_days.Name = "numFTP_days";
            this.numFTP_days.Size = new System.Drawing.Size(120, 20);
            this.numFTP_days.TabIndex = 10;
            // 
            // numFTP_hours
            // 
            this.numFTP_hours.Location = new System.Drawing.Point(80, 68);
            this.numFTP_hours.Name = "numFTP_hours";
            this.numFTP_hours.Size = new System.Drawing.Size(120, 20);
            this.numFTP_hours.TabIndex = 8;
            // 
            // rbFTP_weeks
            // 
            this.rbFTP_weeks.AutoSize = true;
            this.rbFTP_weeks.Location = new System.Drawing.Point(13, 117);
            this.rbFTP_weeks.Name = "rbFTP_weeks";
            this.rbFTP_weeks.Size = new System.Drawing.Size(63, 17);
            this.rbFTP_weeks.TabIndex = 5;
            this.rbFTP_weeks.Text = "Недели";
            this.rbFTP_weeks.UseVisualStyleBackColor = true;
            this.rbFTP_weeks.CheckedChanged += new System.EventHandler(this.rbFTP_hours_CheckedChanged);
            // 
            // rbFTP_days
            // 
            this.rbFTP_days.AutoSize = true;
            this.rbFTP_days.Location = new System.Drawing.Point(13, 94);
            this.rbFTP_days.Name = "rbFTP_days";
            this.rbFTP_days.Size = new System.Drawing.Size(46, 17);
            this.rbFTP_days.TabIndex = 4;
            this.rbFTP_days.Text = "Дни";
            this.rbFTP_days.UseVisualStyleBackColor = true;
            this.rbFTP_days.CheckedChanged += new System.EventHandler(this.rbFTP_hours_CheckedChanged);
            // 
            // rbFTP_hours
            // 
            this.rbFTP_hours.AutoSize = true;
            this.rbFTP_hours.Checked = true;
            this.rbFTP_hours.Location = new System.Drawing.Point(13, 71);
            this.rbFTP_hours.Name = "rbFTP_hours";
            this.rbFTP_hours.Size = new System.Drawing.Size(53, 17);
            this.rbFTP_hours.TabIndex = 3;
            this.rbFTP_hours.TabStop = true;
            this.rbFTP_hours.Text = "Часы";
            this.rbFTP_hours.UseVisualStyleBackColor = true;
            this.rbFTP_hours.CheckedChanged += new System.EventHandler(this.rbFTP_hours_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Повторять каждые";
            // 
            // dtpFTP_start
            // 
            this.dtpFTP_start.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFTP_start.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpFTP_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFTP_start.Location = new System.Drawing.Point(80, 15);
            this.dtpFTP_start.Name = "dtpFTP_start";
            this.dtpFTP_start.Size = new System.Drawing.Size(200, 20);
            this.dtpFTP_start.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Начать с ";
            // 
            // btnFTP_ChoicePath
            // 
            this.btnFTP_ChoicePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFTP_ChoicePath.Location = new System.Drawing.Point(452, 91);
            this.btnFTP_ChoicePath.Name = "btnFTP_ChoicePath";
            this.btnFTP_ChoicePath.Size = new System.Drawing.Size(28, 23);
            this.btnFTP_ChoicePath.TabIndex = 43;
            this.btnFTP_ChoicePath.Text = "...";
            this.btnFTP_ChoicePath.UseVisualStyleBackColor = true;
            this.btnFTP_ChoicePath.Click += new System.EventHandler(this.btnFTP_ChoicePath_Click);
            // 
            // btnFTP_ChoiceFileName
            // 
            this.btnFTP_ChoiceFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFTP_ChoiceFileName.Location = new System.Drawing.Point(452, 32);
            this.btnFTP_ChoiceFileName.Name = "btnFTP_ChoiceFileName";
            this.btnFTP_ChoiceFileName.Size = new System.Drawing.Size(28, 23);
            this.btnFTP_ChoiceFileName.TabIndex = 42;
            this.btnFTP_ChoiceFileName.Text = "...";
            this.btnFTP_ChoiceFileName.UseVisualStyleBackColor = true;
            this.btnFTP_ChoiceFileName.Click += new System.EventHandler(this.btnFTP_ChoiceFileName_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(9, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 31);
            this.label13.TabIndex = 41;
            this.label13.Text = "Пусть файла (для службы)";
            // 
            // txtFTP_PathName
            // 
            this.txtFTP_PathName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP_PathName.Location = new System.Drawing.Point(92, 93);
            this.txtFTP_PathName.Name = "txtFTP_PathName";
            this.txtFTP_PathName.Size = new System.Drawing.Size(357, 20);
            this.txtFTP_PathName.TabIndex = 40;
            this.txtFTP_PathName.Text = "\\\\ulges-fs\\software\\Ulges\\Site\\oper_otkl.html";
            // 
            // chbUseFTP
            // 
            this.chbUseFTP.AutoSize = true;
            this.chbUseFTP.Checked = true;
            this.chbUseFTP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbUseFTP.Location = new System.Drawing.Point(12, 11);
            this.chbUseFTP.Name = "chbUseFTP";
            this.chbUseFTP.Size = new System.Drawing.Size(186, 17);
            this.chbUseFTP.TabIndex = 39;
            this.chbUseFTP.Text = "Использовать отправку на FTP";
            this.chbUseFTP.UseVisualStyleBackColor = true;
            this.chbUseFTP.CheckedChanged += new System.EventHandler(this.chbUseFTP_CheckedChanged);
            // 
            // txtFTP_FileName
            // 
            this.txtFTP_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP_FileName.Location = new System.Drawing.Point(92, 34);
            this.txtFTP_FileName.Name = "txtFTP_FileName";
            this.txtFTP_FileName.Size = new System.Drawing.Size(357, 20);
            this.txtFTP_FileName.TabIndex = 25;
            this.txtFTP_FileName.Text = "\\\\ulges-fs\\software\\Ulges\\Site\\oper_otkl.html";
            // 
            // txtFTP_ProxyPwd
            // 
            this.txtFTP_ProxyPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP_ProxyPwd.Enabled = false;
            this.txtFTP_ProxyPwd.Location = new System.Drawing.Point(330, 224);
            this.txtFTP_ProxyPwd.Name = "txtFTP_ProxyPwd";
            this.txtFTP_ProxyPwd.PasswordChar = '*';
            this.txtFTP_ProxyPwd.Size = new System.Drawing.Size(150, 20);
            this.txtFTP_ProxyPwd.TabIndex = 38;
            this.txtFTP_ProxyPwd.Text = "kil777o";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Имя файла";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(279, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Пароль";
            // 
            // txtFTP_NameFTP
            // 
            this.txtFTP_NameFTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP_NameFTP.Location = new System.Drawing.Point(92, 120);
            this.txtFTP_NameFTP.Name = "txtFTP_NameFTP";
            this.txtFTP_NameFTP.Size = new System.Drawing.Size(388, 20);
            this.txtFTP_NameFTP.TabIndex = 27;
            this.txtFTP_NameFTP.Text = "ftp://pike.z8.ru/www/site1/public_html/consumer/rabota/oper_otkl.html";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Пользователь прокси";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Путь FTP";
            // 
            // txtFTP_ProxyUser
            // 
            this.txtFTP_ProxyUser.Enabled = false;
            this.txtFTP_ProxyUser.Location = new System.Drawing.Point(134, 224);
            this.txtFTP_ProxyUser.Name = "txtFTP_ProxyUser";
            this.txtFTP_ProxyUser.Size = new System.Drawing.Size(139, 20);
            this.txtFTP_ProxyUser.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Логин FTP";
            // 
            // txtFTP_Proxy
            // 
            this.txtFTP_Proxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP_Proxy.Enabled = false;
            this.txtFTP_Proxy.Location = new System.Drawing.Point(156, 198);
            this.txtFTP_Proxy.Name = "txtFTP_Proxy";
            this.txtFTP_Proxy.Size = new System.Drawing.Size(324, 20);
            this.txtFTP_Proxy.TabIndex = 34;
            this.txtFTP_Proxy.Text = "ulges-proxy:8080";
            // 
            // txtFTP_FTPUser
            // 
            this.txtFTP_FTPUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP_FTPUser.Location = new System.Drawing.Point(92, 146);
            this.txtFTP_FTPUser.Name = "txtFTP_FTPUser";
            this.txtFTP_FTPUser.Size = new System.Drawing.Size(388, 20);
            this.txtFTP_FTPUser.TabIndex = 30;
            this.txtFTP_FTPUser.Text = "ulges";
            // 
            // chbFTP_Proxy
            // 
            this.chbFTP_Proxy.AutoSize = true;
            this.chbFTP_Proxy.Location = new System.Drawing.Point(12, 200);
            this.chbFTP_Proxy.Name = "chbFTP_Proxy";
            this.chbFTP_Proxy.Size = new System.Drawing.Size(138, 17);
            this.chbFTP_Proxy.TabIndex = 33;
            this.chbFTP_Proxy.Text = "Использовать прокси";
            this.chbFTP_Proxy.UseVisualStyleBackColor = true;
            this.chbFTP_Proxy.CheckedChanged += new System.EventHandler(this.chbFTP_Proxy_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Пароль FTP";
            // 
            // txtFTP_FTPPwd
            // 
            this.txtFTP_FTPPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP_FTPPwd.Location = new System.Drawing.Point(92, 172);
            this.txtFTP_FTPPwd.Name = "txtFTP_FTPPwd";
            this.txtFTP_FTPPwd.PasswordChar = '*';
            this.txtFTP_FTPPwd.Size = new System.Drawing.Size(388, 20);
            this.txtFTP_FTPPwd.TabIndex = 32;
            this.txtFTP_FTPPwd.Text = "kil777o";
            // 
            // tabPageCrash
            // 
            this.tabPageCrash.Controls.Add(this.groupBoxSheduleFTP05);
            this.tabPageCrash.Controls.Add(this.btnFTP05_ChoicePath);
            this.tabPageCrash.Controls.Add(this.btnFTP05_ChoiceFileName);
            this.tabPageCrash.Controls.Add(this.label8);
            this.tabPageCrash.Controls.Add(this.txtFTP05_PathName);
            this.tabPageCrash.Controls.Add(this.chbUseFTP05);
            this.tabPageCrash.Controls.Add(this.txtFTP05_FileName);
            this.tabPageCrash.Controls.Add(this.txtFTP05_ProxyPwd);
            this.tabPageCrash.Controls.Add(this.label1);
            this.tabPageCrash.Controls.Add(this.label6);
            this.tabPageCrash.Controls.Add(this.txtFTP05_NameFTP);
            this.tabPageCrash.Controls.Add(this.label5);
            this.tabPageCrash.Controls.Add(this.label2);
            this.tabPageCrash.Controls.Add(this.txtFTP05_ProxyUser);
            this.tabPageCrash.Controls.Add(this.label3);
            this.tabPageCrash.Controls.Add(this.txtFTP05_Proxy);
            this.tabPageCrash.Controls.Add(this.txtFTP05_FTPUser);
            this.tabPageCrash.Controls.Add(this.chbFTP05_Proxy);
            this.tabPageCrash.Controls.Add(this.label4);
            this.tabPageCrash.Controls.Add(this.txtFTP05_FTPPwd);
            this.tabPageCrash.Location = new System.Drawing.Point(4, 22);
            this.tabPageCrash.Name = "tabPageCrash";
            this.tabPageCrash.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCrash.Size = new System.Drawing.Size(498, 485);
            this.tabPageCrash.TabIndex = 1;
            this.tabPageCrash.Text = "Аварийные";
            this.tabPageCrash.UseVisualStyleBackColor = true;
            // 
            // groupBoxSheduleFTP05
            // 
            this.groupBoxSheduleFTP05.Controls.Add(this.numFTP05_weeks);
            this.groupBoxSheduleFTP05.Controls.Add(this.numFTP05_days);
            this.groupBoxSheduleFTP05.Controls.Add(this.numFTP05_hours);
            this.groupBoxSheduleFTP05.Controls.Add(this.rbFTP05_weeks);
            this.groupBoxSheduleFTP05.Controls.Add(this.rbFTP05_days);
            this.groupBoxSheduleFTP05.Controls.Add(this.rbFTP05_hours);
            this.groupBoxSheduleFTP05.Controls.Add(this.label10);
            this.groupBoxSheduleFTP05.Controls.Add(this.dtpFTP05_start);
            this.groupBoxSheduleFTP05.Controls.Add(this.label9);
            this.groupBoxSheduleFTP05.Location = new System.Drawing.Point(10, 222);
            this.groupBoxSheduleFTP05.Name = "groupBoxSheduleFTP05";
            this.groupBoxSheduleFTP05.Size = new System.Drawing.Size(585, 151);
            this.groupBoxSheduleFTP05.TabIndex = 24;
            this.groupBoxSheduleFTP05.TabStop = false;
            this.groupBoxSheduleFTP05.Text = "Расписание";
            // 
            // numFTP05_weeks
            // 
            this.numFTP05_weeks.Enabled = false;
            this.numFTP05_weeks.Location = new System.Drawing.Point(80, 121);
            this.numFTP05_weeks.Name = "numFTP05_weeks";
            this.numFTP05_weeks.Size = new System.Drawing.Size(120, 20);
            this.numFTP05_weeks.TabIndex = 11;
            // 
            // numFTP05_days
            // 
            this.numFTP05_days.Enabled = false;
            this.numFTP05_days.Location = new System.Drawing.Point(80, 98);
            this.numFTP05_days.Name = "numFTP05_days";
            this.numFTP05_days.Size = new System.Drawing.Size(120, 20);
            this.numFTP05_days.TabIndex = 10;
            // 
            // numFTP05_hours
            // 
            this.numFTP05_hours.Location = new System.Drawing.Point(80, 75);
            this.numFTP05_hours.Name = "numFTP05_hours";
            this.numFTP05_hours.Size = new System.Drawing.Size(120, 20);
            this.numFTP05_hours.TabIndex = 8;
            // 
            // rbFTP05_weeks
            // 
            this.rbFTP05_weeks.AutoSize = true;
            this.rbFTP05_weeks.Location = new System.Drawing.Point(13, 124);
            this.rbFTP05_weeks.Name = "rbFTP05_weeks";
            this.rbFTP05_weeks.Size = new System.Drawing.Size(63, 17);
            this.rbFTP05_weeks.TabIndex = 5;
            this.rbFTP05_weeks.Text = "Недели";
            this.rbFTP05_weeks.UseVisualStyleBackColor = true;
            this.rbFTP05_weeks.CheckedChanged += new System.EventHandler(this.rbFTP05_hours_CheckedChanged);
            // 
            // rbFTP05_days
            // 
            this.rbFTP05_days.AutoSize = true;
            this.rbFTP05_days.Location = new System.Drawing.Point(13, 101);
            this.rbFTP05_days.Name = "rbFTP05_days";
            this.rbFTP05_days.Size = new System.Drawing.Size(46, 17);
            this.rbFTP05_days.TabIndex = 4;
            this.rbFTP05_days.Text = "Дни";
            this.rbFTP05_days.UseVisualStyleBackColor = true;
            this.rbFTP05_days.CheckedChanged += new System.EventHandler(this.rbFTP05_hours_CheckedChanged);
            // 
            // rbFTP05_hours
            // 
            this.rbFTP05_hours.AutoSize = true;
            this.rbFTP05_hours.Checked = true;
            this.rbFTP05_hours.Location = new System.Drawing.Point(13, 78);
            this.rbFTP05_hours.Name = "rbFTP05_hours";
            this.rbFTP05_hours.Size = new System.Drawing.Size(53, 17);
            this.rbFTP05_hours.TabIndex = 3;
            this.rbFTP05_hours.TabStop = true;
            this.rbFTP05_hours.Text = "Часы";
            this.rbFTP05_hours.UseVisualStyleBackColor = true;
            this.rbFTP05_hours.CheckedChanged += new System.EventHandler(this.rbFTP05_hours_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Повторять каждые";
            // 
            // dtpFTP05_start
            // 
            this.dtpFTP05_start.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFTP05_start.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpFTP05_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFTP05_start.Location = new System.Drawing.Point(80, 19);
            this.dtpFTP05_start.Name = "dtpFTP05_start";
            this.dtpFTP05_start.Size = new System.Drawing.Size(200, 20);
            this.dtpFTP05_start.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Начать с ";
            // 
            // btnFTP05_ChoicePath
            // 
            this.btnFTP05_ChoicePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFTP05_ChoicePath.Location = new System.Drawing.Point(451, 63);
            this.btnFTP05_ChoicePath.Name = "btnFTP05_ChoicePath";
            this.btnFTP05_ChoicePath.Size = new System.Drawing.Size(28, 23);
            this.btnFTP05_ChoicePath.TabIndex = 23;
            this.btnFTP05_ChoicePath.Text = "...";
            this.btnFTP05_ChoicePath.UseVisualStyleBackColor = true;
            this.btnFTP05_ChoicePath.Click += new System.EventHandler(this.btnFTP05_ChoicePath_Click);
            // 
            // btnFTP05_ChoiceFileName
            // 
            this.btnFTP05_ChoiceFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFTP05_ChoiceFileName.Location = new System.Drawing.Point(451, 37);
            this.btnFTP05_ChoiceFileName.Name = "btnFTP05_ChoiceFileName";
            this.btnFTP05_ChoiceFileName.Size = new System.Drawing.Size(28, 23);
            this.btnFTP05_ChoiceFileName.TabIndex = 22;
            this.btnFTP05_ChoiceFileName.Text = "...";
            this.btnFTP05_ChoiceFileName.UseVisualStyleBackColor = true;
            this.btnFTP05_ChoiceFileName.Click += new System.EventHandler(this.btnFTP05_ChoiceFileName_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "Пусть файла (для службы)";
            // 
            // txtFTP05_PathName
            // 
            this.txtFTP05_PathName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP05_PathName.Location = new System.Drawing.Point(90, 65);
            this.txtFTP05_PathName.Name = "txtFTP05_PathName";
            this.txtFTP05_PathName.Size = new System.Drawing.Size(358, 20);
            this.txtFTP05_PathName.TabIndex = 18;
            this.txtFTP05_PathName.Text = "\\\\ulges-fs\\software\\Ulges\\Site\\oper_otkl.html";
            // 
            // tabPagePlannedMail
            // 
            this.tabPagePlannedMail.Controls.Add(this.groupBoxSheduleMailPlanned);
            this.tabPagePlannedMail.Controls.Add(this.label29);
            this.tabPagePlannedMail.Controls.Add(this.txtBodyPlanned);
            this.tabPagePlannedMail.Controls.Add(this.label28);
            this.tabPagePlannedMail.Controls.Add(this.txtSubjectPlanned);
            this.tabPagePlannedMail.Controls.Add(this.dgvRecipients);
            this.tabPagePlannedMail.Controls.Add(this.label27);
            this.tabPagePlannedMail.Controls.Add(this.groupBoxSender);
            this.tabPagePlannedMail.Controls.Add(this.groupBoxSMTP);
            this.tabPagePlannedMail.Controls.Add(this.btnChoiseFileMail);
            this.tabPagePlannedMail.Controls.Add(this.txtFileNameReportHead);
            this.tabPagePlannedMail.Controls.Add(this.label20);
            this.tabPagePlannedMail.Controls.Add(this.chkUseMailPlanned);
            this.tabPagePlannedMail.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlannedMail.Name = "tabPagePlannedMail";
            this.tabPagePlannedMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlannedMail.Size = new System.Drawing.Size(498, 485);
            this.tabPagePlannedMail.TabIndex = 2;
            this.tabPagePlannedMail.Text = "Плановые почта";
            this.tabPagePlannedMail.UseVisualStyleBackColor = true;
            // 
            // groupBoxSheduleMailPlanned
            // 
            this.groupBoxSheduleMailPlanned.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSheduleMailPlanned.Controls.Add(this.numMailPlanned_weeks);
            this.groupBoxSheduleMailPlanned.Controls.Add(this.numMailPlanned_days);
            this.groupBoxSheduleMailPlanned.Controls.Add(this.numMailPlanned_hours);
            this.groupBoxSheduleMailPlanned.Controls.Add(this.rbMailPlanned_weeks);
            this.groupBoxSheduleMailPlanned.Controls.Add(this.rbMailPlanned_days);
            this.groupBoxSheduleMailPlanned.Controls.Add(this.rbMailPlanned_hours);
            this.groupBoxSheduleMailPlanned.Controls.Add(this.label30);
            this.groupBoxSheduleMailPlanned.Controls.Add(this.dtpMailPlanned_start);
            this.groupBoxSheduleMailPlanned.Controls.Add(this.label31);
            this.groupBoxSheduleMailPlanned.Location = new System.Drawing.Point(7, 365);
            this.groupBoxSheduleMailPlanned.Name = "groupBoxSheduleMailPlanned";
            this.groupBoxSheduleMailPlanned.Size = new System.Drawing.Size(472, 117);
            this.groupBoxSheduleMailPlanned.TabIndex = 45;
            this.groupBoxSheduleMailPlanned.TabStop = false;
            this.groupBoxSheduleMailPlanned.Text = "Расписание";
            // 
            // numMailPlanned_weeks
            // 
            this.numMailPlanned_weeks.Enabled = false;
            this.numMailPlanned_weeks.Location = new System.Drawing.Point(192, 88);
            this.numMailPlanned_weeks.Name = "numMailPlanned_weeks";
            this.numMailPlanned_weeks.Size = new System.Drawing.Size(120, 20);
            this.numMailPlanned_weeks.TabIndex = 11;
            // 
            // numMailPlanned_days
            // 
            this.numMailPlanned_days.Enabled = false;
            this.numMailPlanned_days.Location = new System.Drawing.Point(192, 65);
            this.numMailPlanned_days.Name = "numMailPlanned_days";
            this.numMailPlanned_days.Size = new System.Drawing.Size(120, 20);
            this.numMailPlanned_days.TabIndex = 10;
            // 
            // numMailPlanned_hours
            // 
            this.numMailPlanned_hours.Location = new System.Drawing.Point(192, 42);
            this.numMailPlanned_hours.Name = "numMailPlanned_hours";
            this.numMailPlanned_hours.Size = new System.Drawing.Size(120, 20);
            this.numMailPlanned_hours.TabIndex = 8;
            // 
            // rbMailPlanned_weeks
            // 
            this.rbMailPlanned_weeks.AutoSize = true;
            this.rbMailPlanned_weeks.Location = new System.Drawing.Point(125, 91);
            this.rbMailPlanned_weeks.Name = "rbMailPlanned_weeks";
            this.rbMailPlanned_weeks.Size = new System.Drawing.Size(63, 17);
            this.rbMailPlanned_weeks.TabIndex = 5;
            this.rbMailPlanned_weeks.Text = "Недели";
            this.rbMailPlanned_weeks.UseVisualStyleBackColor = true;
            this.rbMailPlanned_weeks.CheckedChanged += new System.EventHandler(this.rbMailPlanned_hours_CheckedChanged);
            // 
            // rbMailPlanned_days
            // 
            this.rbMailPlanned_days.AutoSize = true;
            this.rbMailPlanned_days.Location = new System.Drawing.Point(125, 68);
            this.rbMailPlanned_days.Name = "rbMailPlanned_days";
            this.rbMailPlanned_days.Size = new System.Drawing.Size(46, 17);
            this.rbMailPlanned_days.TabIndex = 4;
            this.rbMailPlanned_days.Text = "Дни";
            this.rbMailPlanned_days.UseVisualStyleBackColor = true;
            this.rbMailPlanned_days.CheckedChanged += new System.EventHandler(this.rbMailPlanned_hours_CheckedChanged);
            // 
            // rbMailPlanned_hours
            // 
            this.rbMailPlanned_hours.AutoSize = true;
            this.rbMailPlanned_hours.Checked = true;
            this.rbMailPlanned_hours.Location = new System.Drawing.Point(125, 45);
            this.rbMailPlanned_hours.Name = "rbMailPlanned_hours";
            this.rbMailPlanned_hours.Size = new System.Drawing.Size(53, 17);
            this.rbMailPlanned_hours.TabIndex = 3;
            this.rbMailPlanned_hours.TabStop = true;
            this.rbMailPlanned_hours.Text = "Часы";
            this.rbMailPlanned_hours.UseVisualStyleBackColor = true;
            this.rbMailPlanned_hours.CheckedChanged += new System.EventHandler(this.rbMailPlanned_hours_CheckedChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 42);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Повторять каждые";
            // 
            // dtpMailPlanned_start
            // 
            this.dtpMailPlanned_start.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpMailPlanned_start.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpMailPlanned_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMailPlanned_start.Location = new System.Drawing.Point(80, 19);
            this.dtpMailPlanned_start.Name = "dtpMailPlanned_start";
            this.dtpMailPlanned_start.Size = new System.Drawing.Size(200, 20);
            this.dtpMailPlanned_start.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 22);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "Начать с ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 342);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(97, 13);
            this.label29.TabIndex = 33;
            this.label29.Text = "Текст сообщения";
            // 
            // txtBodyPlanned
            // 
            this.txtBodyPlanned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBodyPlanned.Location = new System.Drawing.Point(107, 339);
            this.txtBodyPlanned.Name = "txtBodyPlanned";
            this.txtBodyPlanned.Size = new System.Drawing.Size(372, 20);
            this.txtBodyPlanned.TabIndex = 32;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 316);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(94, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "Тема сообщения";
            // 
            // txtSubjectPlanned
            // 
            this.txtSubjectPlanned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubjectPlanned.Location = new System.Drawing.Point(107, 313);
            this.txtSubjectPlanned.Name = "txtSubjectPlanned";
            this.txtSubjectPlanned.Size = new System.Drawing.Size(372, 20);
            this.txtSubjectPlanned.TabIndex = 30;
            // 
            // dgvRecipients
            // 
            this.dgvRecipients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecipients.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecipients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecipients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressRecipientDgvColumn,
            this.nameRecipientDgvColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecipients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecipients.Location = new System.Drawing.Point(10, 227);
            this.dgvRecipients.Name = "dgvRecipients";
            this.dgvRecipients.RowHeadersWidth = 15;
            this.dgvRecipients.Size = new System.Drawing.Size(469, 80);
            this.dgvRecipients.TabIndex = 29;
            // 
            // addressRecipientDgvColumn
            // 
            this.addressRecipientDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressRecipientDgvColumn.HeaderText = "Адрес";
            this.addressRecipientDgvColumn.Name = "addressRecipientDgvColumn";
            // 
            // nameRecipientDgvColumn
            // 
            this.nameRecipientDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameRecipientDgvColumn.HeaderText = "Имя";
            this.nameRecipientDgvColumn.Name = "nameRecipientDgvColumn";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 211);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(66, 13);
            this.label27.TabIndex = 28;
            this.label27.Text = "Получатели";
            // 
            // groupBoxSender
            // 
            this.groupBoxSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSender.Controls.Add(this.label26);
            this.groupBoxSender.Controls.Add(this.txtSenderNamePlanned);
            this.groupBoxSender.Controls.Add(this.label25);
            this.groupBoxSender.Controls.Add(this.txtSenderAddressPlanned);
            this.groupBoxSender.Location = new System.Drawing.Point(10, 134);
            this.groupBoxSender.Name = "groupBoxSender";
            this.groupBoxSender.Size = new System.Drawing.Size(469, 74);
            this.groupBoxSender.TabIndex = 27;
            this.groupBoxSender.TabStop = false;
            this.groupBoxSender.Text = "Отправитель";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "Имя";
            // 
            // txtSenderNamePlanned
            // 
            this.txtSenderNamePlanned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenderNamePlanned.Location = new System.Drawing.Point(80, 45);
            this.txtSenderNamePlanned.Name = "txtSenderNamePlanned";
            this.txtSenderNamePlanned.Size = new System.Drawing.Size(383, 20);
            this.txtSenderNamePlanned.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Адрес";
            // 
            // txtSenderAddressPlanned
            // 
            this.txtSenderAddressPlanned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenderAddressPlanned.Location = new System.Drawing.Point(80, 19);
            this.txtSenderAddressPlanned.Name = "txtSenderAddressPlanned";
            this.txtSenderAddressPlanned.Size = new System.Drawing.Size(383, 20);
            this.txtSenderAddressPlanned.TabIndex = 1;
            // 
            // groupBoxSMTP
            // 
            this.groupBoxSMTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSMTP.Controls.Add(this.label24);
            this.groupBoxSMTP.Controls.Add(this.txtPwdSMTPPlanned);
            this.groupBoxSMTP.Controls.Add(this.label23);
            this.groupBoxSMTP.Controls.Add(this.txtLoginSMTPPlanned);
            this.groupBoxSMTP.Controls.Add(this.label22);
            this.groupBoxSMTP.Controls.Add(this.txtSMTPServerPortPlanned);
            this.groupBoxSMTP.Controls.Add(this.label21);
            this.groupBoxSMTP.Controls.Add(this.txtSMTPServerPlanned);
            this.groupBoxSMTP.Location = new System.Drawing.Point(10, 55);
            this.groupBoxSMTP.Name = "groupBoxSMTP";
            this.groupBoxSMTP.Size = new System.Drawing.Size(469, 73);
            this.groupBoxSMTP.TabIndex = 26;
            this.groupBoxSMTP.TabStop = false;
            this.groupBoxSMTP.Text = "SMTP-сервер (сервер отправки)";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(275, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Пароль";
            // 
            // txtPwdSMTPPlanned
            // 
            this.txtPwdSMTPPlanned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwdSMTPPlanned.Location = new System.Drawing.Point(326, 45);
            this.txtPwdSMTPPlanned.Name = "txtPwdSMTPPlanned";
            this.txtPwdSMTPPlanned.PasswordChar = '*';
            this.txtPwdSMTPPlanned.Size = new System.Drawing.Size(137, 20);
            this.txtPwdSMTPPlanned.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Логин";
            // 
            // txtLoginSMTPPlanned
            // 
            this.txtLoginSMTPPlanned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginSMTPPlanned.Location = new System.Drawing.Point(80, 45);
            this.txtLoginSMTPPlanned.Name = "txtLoginSMTPPlanned";
            this.txtLoginSMTPPlanned.Size = new System.Drawing.Size(189, 20);
            this.txtLoginSMTPPlanned.TabIndex = 4;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(346, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Порт";
            // 
            // txtSMTPServerPortPlanned
            // 
            this.txtSMTPServerPortPlanned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSMTPServerPortPlanned.Location = new System.Drawing.Point(384, 19);
            this.txtSMTPServerPortPlanned.Name = "txtSMTPServerPortPlanned";
            this.txtSMTPServerPortPlanned.Size = new System.Drawing.Size(79, 20);
            this.txtSMTPServerPortPlanned.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Имя сервера";
            // 
            // txtSMTPServerPlanned
            // 
            this.txtSMTPServerPlanned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSMTPServerPlanned.Location = new System.Drawing.Point(80, 19);
            this.txtSMTPServerPlanned.Name = "txtSMTPServerPlanned";
            this.txtSMTPServerPlanned.Size = new System.Drawing.Size(260, 20);
            this.txtSMTPServerPlanned.TabIndex = 0;
            // 
            // btnChoiseFileMail
            // 
            this.btnChoiseFileMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoiseFileMail.Location = new System.Drawing.Point(451, 27);
            this.btnChoiseFileMail.Name = "btnChoiseFileMail";
            this.btnChoiseFileMail.Size = new System.Drawing.Size(28, 23);
            this.btnChoiseFileMail.TabIndex = 25;
            this.btnChoiseFileMail.Text = "...";
            this.btnChoiseFileMail.UseVisualStyleBackColor = true;
            this.btnChoiseFileMail.Click += new System.EventHandler(this.btnChoiseFileMail_Click);
            // 
            // txtFileNameReportHead
            // 
            this.txtFileNameReportHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileNameReportHead.Location = new System.Drawing.Point(90, 29);
            this.txtFileNameReportHead.Name = "txtFileNameReportHead";
            this.txtFileNameReportHead.Size = new System.Drawing.Size(358, 20);
            this.txtFileNameReportHead.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Имя файла";
            // 
            // chkUseMailPlanned
            // 
            this.chkUseMailPlanned.AutoSize = true;
            this.chkUseMailPlanned.Checked = true;
            this.chkUseMailPlanned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseMailPlanned.Location = new System.Drawing.Point(10, 6);
            this.chkUseMailPlanned.Name = "chkUseMailPlanned";
            this.chkUseMailPlanned.Size = new System.Drawing.Size(124, 17);
            this.chkUseMailPlanned.TabIndex = 0;
            this.chkUseMailPlanned.Text = "Включить отправку";
            this.chkUseMailPlanned.UseVisualStyleBackColor = true;
            this.chkUseMailPlanned.CheckedChanged += new System.EventHandler(this.chkUseMailPlanned_CheckedChanged);
            // 
            // tabPageRIC
            // 
            this.tabPageRIC.Controls.Add(this.groupBoxServices);
            this.tabPageRIC.Controls.Add(this.groupBox1);
            this.tabPageRIC.Controls.Add(this.checkBoxSendRIC);
            this.tabPageRIC.Location = new System.Drawing.Point(4, 22);
            this.tabPageRIC.Name = "tabPageRIC";
            this.tabPageRIC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRIC.Size = new System.Drawing.Size(498, 485);
            this.tabPageRIC.TabIndex = 3;
            this.tabPageRIC.Text = "Прочие";
            this.tabPageRIC.UseVisualStyleBackColor = true;
            // 
            // groupBoxServices
            // 
            this.groupBoxServices.Controls.Add(this.serviceStatus);
            this.groupBoxServices.Controls.Add(this.txtServiceName);
            this.groupBoxServices.Controls.Add(this.label52);
            this.groupBoxServices.Controls.Add(this.txtRemoteServer);
            this.groupBoxServices.Controls.Add(this.label51);
            this.groupBoxServices.Controls.Add(this.toolStrip1);
            this.groupBoxServices.Location = new System.Drawing.Point(10, 338);
            this.groupBoxServices.Name = "groupBoxServices";
            this.groupBoxServices.Size = new System.Drawing.Size(470, 141);
            this.groupBoxServices.TabIndex = 4;
            this.groupBoxServices.TabStop = false;
            this.groupBoxServices.Text = "Управление службой";
            // 
            // serviceStatus
            // 
            this.serviceStatus.AutoSize = true;
            this.serviceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceStatus.Location = new System.Drawing.Point(204, 102);
            this.serviceStatus.Name = "serviceStatus";
            this.serviceStatus.Size = new System.Drawing.Size(0, 13);
            this.serviceStatus.TabIndex = 8;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(97, 98);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(100, 20);
            this.txtServiceName.TabIndex = 7;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(9, 102);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(45, 13);
            this.label52.TabIndex = 6;
            this.label52.Text = "Служба";
            // 
            // txtRemoteServer
            // 
            this.txtRemoteServer.Location = new System.Drawing.Point(97, 68);
            this.txtRemoteServer.Name = "txtRemoteServer";
            this.txtRemoteServer.Size = new System.Drawing.Size(100, 20);
            this.txtRemoteServer.TabIndex = 5;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 71);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(44, 13);
            this.label51.TabIndex = 4;
            this.label51.Text = "Сервер";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStart,
            this.tsbRestart,
            this.tsbStop});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 37);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbStart
            // 
            this.tsbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStart.Image = global::References.Properties.Resources.Play;
            this.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.Size = new System.Drawing.Size(34, 34);
            this.tsbStart.Text = "tsbStart";
            this.tsbStart.ToolTipText = "Start";
            this.tsbStart.Click += new System.EventHandler(this.btnStartServices_Click);
            // 
            // tsbRestart
            // 
            this.tsbRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRestart.Image = global::References.Properties.Resources.Restart;
            this.tsbRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRestart.Name = "tsbRestart";
            this.tsbRestart.Size = new System.Drawing.Size(34, 34);
            this.tsbRestart.Text = "tsbRestart";
            this.tsbRestart.ToolTipText = "Restart";
            this.tsbRestart.Click += new System.EventHandler(this.btnRestartServices_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = global::References.Properties.Resources.Stop;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(34, 34);
            this.tsbStop.Text = "tsbStop";
            this.tsbStop.ToolTipText = "Stop";
            this.tsbStop.Click += new System.EventHandler(this.btnStopServices_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtNameURL);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.checkBoxSendME);
            this.groupBox1.Controls.Add(this.txtPwdME);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.txtUserME);
            this.groupBox1.Location = new System.Drawing.Point(10, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 293);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отправка отчетности в Министерство энергетики";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSendCorrectDamage);
            this.groupBox3.Controls.Add(this.chkSendNullListAbonent);
            this.groupBox3.Location = new System.Drawing.Point(12, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 76);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтр отправленных данных";
            // 
            // chkSendCorrectDamage
            // 
            this.chkSendCorrectDamage.AutoSize = true;
            this.chkSendCorrectDamage.Location = new System.Drawing.Point(6, 52);
            this.chkSendCorrectDamage.Name = "chkSendCorrectDamage";
            this.chkSendCorrectDamage.Size = new System.Drawing.Size(329, 17);
            this.chkSendCorrectDamage.TabIndex = 1;
            this.chkSendCorrectDamage.Text = "проверка корректности типа поврежденного оборудования";
            this.chkSendCorrectDamage.UseVisualStyleBackColor = true;
            // 
            // chkSendNullListAbonent
            // 
            this.chkSendNullListAbonent.AutoSize = true;
            this.chkSendNullListAbonent.Location = new System.Drawing.Point(6, 25);
            this.chkSendNullListAbonent.Name = "chkSendNullListAbonent";
            this.chkSendNullListAbonent.Size = new System.Drawing.Size(232, 17);
            this.chkSendNullListAbonent.TabIndex = 0;
            this.chkSendNullListAbonent.Text = "проверка заполнения списка абонентов";
            this.chkSendNullListAbonent.UseVisualStyleBackColor = true;
            // 
            // txtNameURL
            // 
            this.txtNameURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameURL.Location = new System.Drawing.Point(59, 42);
            this.txtNameURL.Name = "txtNameURL";
            this.txtNameURL.Size = new System.Drawing.Size(389, 20);
            this.txtNameURL.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCreateAktDLV);
            this.groupBox2.Controls.Add(this.chkCreateAktDHV);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 76);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Автоматическое формирование актов расследования";
            // 
            // chkCreateAktDLV
            // 
            this.chkCreateAktDLV.AutoSize = true;
            this.chkCreateAktDLV.Location = new System.Drawing.Point(6, 52);
            this.chkCreateAktDLV.Name = "chkCreateAktDLV";
            this.chkCreateAktDLV.Size = new System.Drawing.Size(121, 17);
            this.chkCreateAktDLV.TabIndex = 1;
            this.chkCreateAktDLV.Text = "для нарушений НН";
            this.chkCreateAktDLV.UseVisualStyleBackColor = true;
            // 
            // chkCreateAktDHV
            // 
            this.chkCreateAktDHV.AutoSize = true;
            this.chkCreateAktDHV.Location = new System.Drawing.Point(6, 25);
            this.chkCreateAktDHV.Name = "chkCreateAktDHV";
            this.chkCreateAktDHV.Size = new System.Drawing.Size(120, 17);
            this.chkCreateAktDHV.TabIndex = 0;
            this.chkCreateAktDHV.Text = "для нарушений ВН";
            this.chkCreateAktDHV.UseVisualStyleBackColor = true;
            // 
            // checkBoxSendME
            // 
            this.checkBoxSendME.AutoSize = true;
            this.checkBoxSendME.Checked = true;
            this.checkBoxSendME.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSendME.Location = new System.Drawing.Point(6, 19);
            this.checkBoxSendME.Name = "checkBoxSendME";
            this.checkBoxSendME.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSendME.TabIndex = 1;
            this.checkBoxSendME.Text = "Отправка данных";
            this.checkBoxSendME.UseVisualStyleBackColor = true;
            this.checkBoxSendME.CheckedChanged += new System.EventHandler(this.checkBoxSendME_CheckedChanged);
            // 
            // txtPwdME
            // 
            this.txtPwdME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwdME.Location = new System.Drawing.Point(59, 98);
            this.txtPwdME.Name = "txtPwdME";
            this.txtPwdME.PasswordChar = '*';
            this.txtPwdME.Size = new System.Drawing.Size(389, 20);
            this.txtPwdME.TabIndex = 16;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 45);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(31, 13);
            this.label32.TabIndex = 12;
            this.label32.Text = "Путь";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 98);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(45, 13);
            this.label34.TabIndex = 15;
            this.label34.Text = "Пароль";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 72);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(38, 13);
            this.label33.TabIndex = 13;
            this.label33.Text = "Логин";
            // 
            // txtUserME
            // 
            this.txtUserME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserME.Location = new System.Drawing.Point(59, 72);
            this.txtUserME.Name = "txtUserME";
            this.txtUserME.Size = new System.Drawing.Size(389, 20);
            this.txtUserME.TabIndex = 14;
            // 
            // checkBoxSendRIC
            // 
            this.checkBoxSendRIC.AutoSize = true;
            this.checkBoxSendRIC.Location = new System.Drawing.Point(10, 16);
            this.checkBoxSendRIC.Name = "checkBoxSendRIC";
            this.checkBoxSendRIC.Size = new System.Drawing.Size(162, 17);
            this.checkBoxSendRIC.TabIndex = 0;
            this.checkBoxSendRIC.Text = "Отправлять данные в РИЦ";
            this.checkBoxSendRIC.UseVisualStyleBackColor = true;
            // 
            // tabPageReportHead
            // 
            this.tabPageReportHead.Controls.Add(this.groupBoxCollectionStartingPoint);
            this.tabPageReportHead.Controls.Add(this.groupBoxSheduleMail);
            this.tabPageReportHead.Controls.Add(this.label37);
            this.tabPageReportHead.Controls.Add(this.txtBody);
            this.tabPageReportHead.Controls.Add(this.label38);
            this.tabPageReportHead.Controls.Add(this.txtSubject);
            this.tabPageReportHead.Controls.Add(this.dgvRecipientsHead);
            this.tabPageReportHead.Controls.Add(this.label39);
            this.tabPageReportHead.Controls.Add(this.groupBoxSenderHead);
            this.tabPageReportHead.Controls.Add(this.groupBoxSMTPHead);
            this.tabPageReportHead.Controls.Add(this.btnChoiseReportHead);
            this.tabPageReportHead.Controls.Add(this.txtFileNameMailReportHead);
            this.tabPageReportHead.Controls.Add(this.label46);
            this.tabPageReportHead.Controls.Add(this.chkSendReportHead);
            this.tabPageReportHead.Location = new System.Drawing.Point(4, 22);
            this.tabPageReportHead.Name = "tabPageReportHead";
            this.tabPageReportHead.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportHead.Size = new System.Drawing.Size(498, 485);
            this.tabPageReportHead.TabIndex = 4;
            this.tabPageReportHead.Text = "Отчет руководителю";
            this.tabPageReportHead.UseVisualStyleBackColor = true;
            // 
            // groupBoxCollectionStartingPoint
            // 
            this.groupBoxCollectionStartingPoint.Controls.Add(this.label49);
            this.groupBoxCollectionStartingPoint.Controls.Add(this.cmbOutFormatFile);
            this.groupBoxCollectionStartingPoint.Controls.Add(this.dtpTimeEnd);
            this.groupBoxCollectionStartingPoint.Controls.Add(this.dtpTimeBegin);
            this.groupBoxCollectionStartingPoint.Controls.Add(this.label50);
            this.groupBoxCollectionStartingPoint.Controls.Add(this.label48);
            this.groupBoxCollectionStartingPoint.Controls.Add(this.label47);
            this.groupBoxCollectionStartingPoint.Controls.Add(this.txtPeriodToBeginDay);
            this.groupBoxCollectionStartingPoint.Location = new System.Drawing.Point(261, 363);
            this.groupBoxCollectionStartingPoint.Name = "groupBoxCollectionStartingPoint";
            this.groupBoxCollectionStartingPoint.Size = new System.Drawing.Size(220, 116);
            this.groupBoxCollectionStartingPoint.TabIndex = 59;
            this.groupBoxCollectionStartingPoint.TabStop = false;
            this.groupBoxCollectionStartingPoint.Text = "Начальная точка отсчета сбора";
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(109, 20);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(53, 42);
            this.label49.TabIndex = 18;
            this.label49.Text = "Формат файла\r\nвыгрузки";
            // 
            // cmbOutFormatFile
            // 
            this.cmbOutFormatFile.FormattingEnabled = true;
            this.cmbOutFormatFile.Items.AddRange(new object[] {
            "PDF",
            "Excel",
            "Word"});
            this.cmbOutFormatFile.Location = new System.Drawing.Point(159, 35);
            this.cmbOutFormatFile.Name = "cmbOutFormatFile";
            this.cmbOutFormatFile.Size = new System.Drawing.Size(55, 21);
            this.cmbOutFormatFile.TabIndex = 17;
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.AllowDrop = true;
            this.dtpTimeEnd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpTimeEnd.CustomFormat = "HH:mm";
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeEnd.Location = new System.Drawing.Point(118, 94);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.ShowUpDown = true;
            this.dtpTimeEnd.Size = new System.Drawing.Size(53, 20);
            this.dtpTimeEnd.TabIndex = 16;
            // 
            // dtpTimeBegin
            // 
            this.dtpTimeBegin.AllowDrop = true;
            this.dtpTimeBegin.Cursor = System.Windows.Forms.Cursors.No;
            this.dtpTimeBegin.CustomFormat = "HH:mm";
            this.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeBegin.Location = new System.Drawing.Point(118, 71);
            this.dtpTimeBegin.Name = "dtpTimeBegin";
            this.dtpTimeBegin.ShowUpDown = true;
            this.dtpTimeBegin.Size = new System.Drawing.Size(53, 20);
            this.dtpTimeBegin.TabIndex = 16;
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(0, 94);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(104, 20);
            this.label50.TabIndex = 15;
            this.label50.Text = "Время окончания";
            // 
            // label48
            // 
            this.label48.Location = new System.Drawing.Point(2, 74);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(102, 20);
            this.label48.TabIndex = 15;
            this.label48.Text = "Время начала";
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(6, 25);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(53, 39);
            this.label47.TabIndex = 13;
            this.label47.Text = "Кол. дней до начала";
            // 
            // txtPeriodToBeginDay
            // 
            this.txtPeriodToBeginDay.Location = new System.Drawing.Point(64, 35);
            this.txtPeriodToBeginDay.Name = "txtPeriodToBeginDay";
            this.txtPeriodToBeginDay.Size = new System.Drawing.Size(39, 20);
            this.txtPeriodToBeginDay.TabIndex = 12;
            this.txtPeriodToBeginDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodToBeginDay_KeyPress);
            // 
            // groupBoxSheduleMail
            // 
            this.groupBoxSheduleMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSheduleMail.Controls.Add(this.numMail_weeks);
            this.groupBoxSheduleMail.Controls.Add(this.numMail_day);
            this.groupBoxSheduleMail.Controls.Add(this.numMail_hours);
            this.groupBoxSheduleMail.Controls.Add(this.rbMail_weeks);
            this.groupBoxSheduleMail.Controls.Add(this.rbMail_days);
            this.groupBoxSheduleMail.Controls.Add(this.rbMail_hours);
            this.groupBoxSheduleMail.Controls.Add(this.label35);
            this.groupBoxSheduleMail.Controls.Add(this.dtpBeginMail);
            this.groupBoxSheduleMail.Controls.Add(this.label36);
            this.groupBoxSheduleMail.Location = new System.Drawing.Point(9, 363);
            this.groupBoxSheduleMail.Name = "groupBoxSheduleMail";
            this.groupBoxSheduleMail.Size = new System.Drawing.Size(246, 117);
            this.groupBoxSheduleMail.TabIndex = 58;
            this.groupBoxSheduleMail.TabStop = false;
            this.groupBoxSheduleMail.Text = "Расписание";
            // 
            // numMail_weeks
            // 
            this.numMail_weeks.Enabled = false;
            this.numMail_weeks.Location = new System.Drawing.Point(192, 88);
            this.numMail_weeks.Name = "numMail_weeks";
            this.numMail_weeks.Size = new System.Drawing.Size(45, 20);
            this.numMail_weeks.TabIndex = 11;
            // 
            // numMail_day
            // 
            this.numMail_day.Enabled = false;
            this.numMail_day.Location = new System.Drawing.Point(192, 65);
            this.numMail_day.Name = "numMail_day";
            this.numMail_day.Size = new System.Drawing.Size(45, 20);
            this.numMail_day.TabIndex = 10;
            // 
            // numMail_hours
            // 
            this.numMail_hours.Location = new System.Drawing.Point(192, 42);
            this.numMail_hours.Name = "numMail_hours";
            this.numMail_hours.Size = new System.Drawing.Size(45, 20);
            this.numMail_hours.TabIndex = 8;
            // 
            // rbMail_weeks
            // 
            this.rbMail_weeks.AutoSize = true;
            this.rbMail_weeks.Location = new System.Drawing.Point(125, 91);
            this.rbMail_weeks.Name = "rbMail_weeks";
            this.rbMail_weeks.Size = new System.Drawing.Size(63, 17);
            this.rbMail_weeks.TabIndex = 5;
            this.rbMail_weeks.Text = "Недели";
            this.rbMail_weeks.UseVisualStyleBackColor = true;
            // 
            // rbMail_days
            // 
            this.rbMail_days.AutoSize = true;
            this.rbMail_days.Location = new System.Drawing.Point(125, 68);
            this.rbMail_days.Name = "rbMail_days";
            this.rbMail_days.Size = new System.Drawing.Size(46, 17);
            this.rbMail_days.TabIndex = 4;
            this.rbMail_days.Text = "Дни";
            this.rbMail_days.UseVisualStyleBackColor = true;
            this.rbMail_days.CheckedChanged += new System.EventHandler(this.rbMail_CheckedChanged);
            // 
            // rbMail_hours
            // 
            this.rbMail_hours.AutoSize = true;
            this.rbMail_hours.Checked = true;
            this.rbMail_hours.Location = new System.Drawing.Point(125, 45);
            this.rbMail_hours.Name = "rbMail_hours";
            this.rbMail_hours.Size = new System.Drawing.Size(53, 17);
            this.rbMail_hours.TabIndex = 3;
            this.rbMail_hours.TabStop = true;
            this.rbMail_hours.Text = "Часы";
            this.rbMail_hours.UseVisualStyleBackColor = true;
            this.rbMail_hours.CheckedChanged += new System.EventHandler(this.rbMail_CheckedChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 42);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(104, 13);
            this.label35.TabIndex = 2;
            this.label35.Text = "Повторять каждые";
            // 
            // dtpBeginMail
            // 
            this.dtpBeginMail.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpBeginMail.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpBeginMail.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeginMail.Location = new System.Drawing.Point(65, 19);
            this.dtpBeginMail.Name = "dtpBeginMail";
            this.dtpBeginMail.Size = new System.Drawing.Size(123, 20);
            this.dtpBeginMail.TabIndex = 1;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 21);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(55, 13);
            this.label36.TabIndex = 0;
            this.label36.Text = "Начать с ";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(9, 340);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(97, 13);
            this.label37.TabIndex = 57;
            this.label37.Text = "Текст сообщения";
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.Location = new System.Drawing.Point(109, 337);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(372, 20);
            this.txtBody.TabIndex = 56;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(9, 314);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(94, 13);
            this.label38.TabIndex = 55;
            this.label38.Text = "Тема сообщения";
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(109, 311);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(372, 20);
            this.txtSubject.TabIndex = 54;
            // 
            // dgvRecipientsHead
            // 
            this.dgvRecipientsHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecipientsHead.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecipientsHead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecipientsHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipientsHead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressDgvColumn,
            this.nameDgvColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecipientsHead.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecipientsHead.Location = new System.Drawing.Point(12, 225);
            this.dgvRecipientsHead.Name = "dgvRecipientsHead";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecipientsHead.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecipientsHead.RowHeadersWidth = 15;
            this.dgvRecipientsHead.Size = new System.Drawing.Size(469, 80);
            this.dgvRecipientsHead.TabIndex = 53;
            // 
            // addressDgvColumn
            // 
            this.addressDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDgvColumn.HeaderText = "Адрес";
            this.addressDgvColumn.Name = "addressDgvColumn";
            // 
            // nameDgvColumn
            // 
            this.nameDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDgvColumn.HeaderText = "Имя";
            this.nameDgvColumn.Name = "nameDgvColumn";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(18, 209);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(66, 13);
            this.label39.TabIndex = 52;
            this.label39.Text = "Получатели";
            // 
            // groupBoxSenderHead
            // 
            this.groupBoxSenderHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSenderHead.Controls.Add(this.label40);
            this.groupBoxSenderHead.Controls.Add(this.txtSenderName);
            this.groupBoxSenderHead.Controls.Add(this.label41);
            this.groupBoxSenderHead.Controls.Add(this.txtSenderAddress);
            this.groupBoxSenderHead.Location = new System.Drawing.Point(12, 132);
            this.groupBoxSenderHead.Name = "groupBoxSenderHead";
            this.groupBoxSenderHead.Size = new System.Drawing.Size(469, 74);
            this.groupBoxSenderHead.TabIndex = 51;
            this.groupBoxSenderHead.TabStop = false;
            this.groupBoxSenderHead.Text = "Отправитель";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 48);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(29, 13);
            this.label40.TabIndex = 4;
            this.label40.Text = "Имя";
            // 
            // txtSenderName
            // 
            this.txtSenderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenderName.Location = new System.Drawing.Point(80, 45);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(383, 20);
            this.txtSenderName.TabIndex = 3;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 22);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(38, 13);
            this.label41.TabIndex = 2;
            this.label41.Text = "Адрес";
            // 
            // txtSenderAddress
            // 
            this.txtSenderAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenderAddress.Location = new System.Drawing.Point(80, 19);
            this.txtSenderAddress.Name = "txtSenderAddress";
            this.txtSenderAddress.Size = new System.Drawing.Size(383, 20);
            this.txtSenderAddress.TabIndex = 1;
            // 
            // groupBoxSMTPHead
            // 
            this.groupBoxSMTPHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSMTPHead.Controls.Add(this.label42);
            this.groupBoxSMTPHead.Controls.Add(this.txtPwdSMTP);
            this.groupBoxSMTPHead.Controls.Add(this.label43);
            this.groupBoxSMTPHead.Controls.Add(this.txtLoginSMTP);
            this.groupBoxSMTPHead.Controls.Add(this.label44);
            this.groupBoxSMTPHead.Controls.Add(this.txtSMTPServerPort);
            this.groupBoxSMTPHead.Controls.Add(this.label45);
            this.groupBoxSMTPHead.Controls.Add(this.txtSMTPServer);
            this.groupBoxSMTPHead.Location = new System.Drawing.Point(12, 53);
            this.groupBoxSMTPHead.Name = "groupBoxSMTPHead";
            this.groupBoxSMTPHead.Size = new System.Drawing.Size(469, 73);
            this.groupBoxSMTPHead.TabIndex = 50;
            this.groupBoxSMTPHead.TabStop = false;
            this.groupBoxSMTPHead.Text = "SMTP-сервер (сервер отправки)";
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(275, 48);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(45, 13);
            this.label42.TabIndex = 7;
            this.label42.Text = "Пароль";
            // 
            // txtPwdSMTP
            // 
            this.txtPwdSMTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwdSMTP.Location = new System.Drawing.Point(326, 45);
            this.txtPwdSMTP.Name = "txtPwdSMTP";
            this.txtPwdSMTP.PasswordChar = '*';
            this.txtPwdSMTP.Size = new System.Drawing.Size(137, 20);
            this.txtPwdSMTP.TabIndex = 6;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 48);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(38, 13);
            this.label43.TabIndex = 5;
            this.label43.Text = "Логин";
            // 
            // txtLoginSMTP
            // 
            this.txtLoginSMTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginSMTP.Location = new System.Drawing.Point(80, 45);
            this.txtLoginSMTP.Name = "txtLoginSMTP";
            this.txtLoginSMTP.Size = new System.Drawing.Size(189, 20);
            this.txtLoginSMTP.TabIndex = 4;
            // 
            // label44
            // 
            this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(346, 22);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(32, 13);
            this.label44.TabIndex = 3;
            this.label44.Text = "Порт";
            // 
            // txtSMTPServerPort
            // 
            this.txtSMTPServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSMTPServerPort.Location = new System.Drawing.Point(384, 19);
            this.txtSMTPServerPort.Name = "txtSMTPServerPort";
            this.txtSMTPServerPort.Size = new System.Drawing.Size(79, 20);
            this.txtSMTPServerPort.TabIndex = 2;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 22);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(74, 13);
            this.label45.TabIndex = 1;
            this.label45.Text = "Имя сервера";
            // 
            // txtSMTPServer
            // 
            this.txtSMTPServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSMTPServer.Location = new System.Drawing.Point(80, 19);
            this.txtSMTPServer.Name = "txtSMTPServer";
            this.txtSMTPServer.Size = new System.Drawing.Size(260, 20);
            this.txtSMTPServer.TabIndex = 0;
            // 
            // btnChoiseReportHead
            // 
            this.btnChoiseReportHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoiseReportHead.Location = new System.Drawing.Point(453, 25);
            this.btnChoiseReportHead.Name = "btnChoiseReportHead";
            this.btnChoiseReportHead.Size = new System.Drawing.Size(28, 23);
            this.btnChoiseReportHead.TabIndex = 49;
            this.btnChoiseReportHead.Text = "...";
            this.btnChoiseReportHead.UseVisualStyleBackColor = true;
            this.btnChoiseReportHead.Click += new System.EventHandler(this.btnChoiseReportHead_Click);
            // 
            // txtFileNameMailReportHead
            // 
            this.txtFileNameMailReportHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileNameMailReportHead.Location = new System.Drawing.Point(92, 27);
            this.txtFileNameMailReportHead.Name = "txtFileNameMailReportHead";
            this.txtFileNameMailReportHead.Size = new System.Drawing.Size(358, 20);
            this.txtFileNameMailReportHead.TabIndex = 47;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(9, 30);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(64, 13);
            this.label46.TabIndex = 48;
            this.label46.Text = "Имя файла";
            // 
            // chkSendReportHead
            // 
            this.chkSendReportHead.AutoSize = true;
            this.chkSendReportHead.Checked = true;
            this.chkSendReportHead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSendReportHead.Location = new System.Drawing.Point(12, 4);
            this.chkSendReportHead.Name = "chkSendReportHead";
            this.chkSendReportHead.Size = new System.Drawing.Size(124, 17);
            this.chkSendReportHead.TabIndex = 46;
            this.chkSendReportHead.Text = "Включить отправку";
            this.chkSendReportHead.UseVisualStyleBackColor = true;
            this.chkSendReportHead.CheckedChanged += new System.EventHandler(this.chkSendReportHead_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Путь до cURL";
            // 
            // txtCURL
            // 
            this.txtCURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCURL.BackColor = System.Drawing.SystemColors.Window;
            this.txtCURL.Location = new System.Drawing.Point(95, 12);
            this.txtCURL.Name = "txtCURL";
            this.txtCURL.Size = new System.Drawing.Size(366, 20);
            this.txtCURL.TabIndex = 20;
            this.txtCURL.Text = "\\\\ulges-fs\\software\\Ulges\\EIS\\Plugins\\curl.exe";
            // 
            // btnChoiceCURL
            // 
            this.btnChoiceCURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoiceCURL.Location = new System.Drawing.Point(464, 10);
            this.btnChoiceCURL.Name = "btnChoiceCURL";
            this.btnChoiceCURL.Size = new System.Drawing.Size(28, 23);
            this.btnChoiceCURL.TabIndex = 21;
            this.btnChoiceCURL.Text = "...";
            this.btnChoiceCURL.UseVisualStyleBackColor = true;
            this.btnChoiceCURL.Click += new System.EventHandler(this.btnChoiceCURL_Click);
            // 
            // timerServiceRun
            // 
            this.timerServiceRun.Interval = 1000;
            this.timerServiceRun.Tick += new System.EventHandler(this.timerServiceRun_Tick);
            // 
            // FormSettingsSender
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(504, 588);
            this.Controls.Add(this.btnChoiceCURL);
            this.Controls.Add(this.txtCURL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 514);
            this.Name = "FormSettingsSender";
            this.Text = "Настройки отправки данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettingsSender_FormClosing);
            this.Load += new System.EventHandler(this.FormSettingsSender_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPagePlan.ResumeLayout(false);
            this.tabPagePlan.PerformLayout();
            this.groupBoxSheduleFTP.ResumeLayout(false);
            this.groupBoxSheduleFTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP_weeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP_days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP_hours)).EndInit();
            this.tabPageCrash.ResumeLayout(false);
            this.tabPageCrash.PerformLayout();
            this.groupBoxSheduleFTP05.ResumeLayout(false);
            this.groupBoxSheduleFTP05.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP05_weeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP05_days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFTP05_hours)).EndInit();
            this.tabPagePlannedMail.ResumeLayout(false);
            this.tabPagePlannedMail.PerformLayout();
            this.groupBoxSheduleMailPlanned.ResumeLayout(false);
            this.groupBoxSheduleMailPlanned.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMailPlanned_weeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMailPlanned_days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMailPlanned_hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipients)).EndInit();
            this.groupBoxSender.ResumeLayout(false);
            this.groupBoxSender.PerformLayout();
            this.groupBoxSMTP.ResumeLayout(false);
            this.groupBoxSMTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMTPServerPortPlanned)).EndInit();
            this.tabPageRIC.ResumeLayout(false);
            this.tabPageRIC.PerformLayout();
            this.groupBoxServices.ResumeLayout(false);
            this.groupBoxServices.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageReportHead.ResumeLayout(false);
            this.tabPageReportHead.PerformLayout();
            this.groupBoxCollectionStartingPoint.ResumeLayout(false);
            this.groupBoxCollectionStartingPoint.PerformLayout();
            this.groupBoxSheduleMail.ResumeLayout(false);
            this.groupBoxSheduleMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMail_weeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMail_day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMail_hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipientsHead)).EndInit();
            this.groupBoxSenderHead.ResumeLayout(false);
            this.groupBoxSenderHead.PerformLayout();
            this.groupBoxSMTPHead.ResumeLayout(false);
            this.groupBoxSMTPHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMTPServerPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.ComponentModel.IContainer components=null;

		private System.Windows.Forms.TextBox txtFTP05_FileName;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.TextBox txtFTP05_NameFTP;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.TextBox txtFTP05_FTPUser;

		private System.Windows.Forms.Label label4;

		private System.Windows.Forms.Button btnOK;

		private System.Windows.Forms.Button btnClose;

		private System.Windows.Forms.MaskedTextBox txtFTP05_FTPPwd;

		private System.Windows.Forms.CheckBox chbFTP05_Proxy;

		private System.Windows.Forms.TextBox txtFTP05_Proxy;

		private System.Windows.Forms.TextBox txtFTP05_ProxyUser;

		private System.Windows.Forms.Label label5;

		private System.Windows.Forms.Label label6;

		private System.Windows.Forms.MaskedTextBox txtFTP05_ProxyPwd;

		private System.Windows.Forms.CheckBox chbUseFTP05;

		private System.Windows.Forms.TabControl tabControl;

		private System.Windows.Forms.TabPage tabPagePlan;

		private System.Windows.Forms.TabPage tabPageCrash;

		private System.Windows.Forms.Label label7;

		private System.Windows.Forms.TextBox txtCURL;

		private System.Windows.Forms.Button btnChoiceCURL;

		private System.Windows.Forms.Button btnFTP05_ChoiceFileName;

		private System.Windows.Forms.Label label8;

		private System.Windows.Forms.TextBox txtFTP05_PathName;

		private System.Windows.Forms.Button btnFTP05_ChoicePath;

		private System.Windows.Forms.GroupBox groupBoxSheduleFTP05;

		private System.Windows.Forms.RadioButton rbFTP05_weeks;

		private System.Windows.Forms.RadioButton rbFTP05_days;

		private System.Windows.Forms.RadioButton rbFTP05_hours;

		private System.Windows.Forms.Label label10;

		private System.Windows.Forms.DateTimePicker dtpFTP05_start;

		private System.Windows.Forms.Label label9;

		private System.Windows.Forms.NumericUpDown numFTP05_weeks;

		private System.Windows.Forms.NumericUpDown numFTP05_days;

		private System.Windows.Forms.NumericUpDown numFTP05_hours;

		private System.Windows.Forms.GroupBox groupBoxSheduleFTP;

		private System.Windows.Forms.NumericUpDown numFTP_weeks;

		private System.Windows.Forms.NumericUpDown numFTP_days;

		private System.Windows.Forms.NumericUpDown numFTP_hours;

		private System.Windows.Forms.RadioButton rbFTP_weeks;

		private System.Windows.Forms.RadioButton rbFTP_days;

		private System.Windows.Forms.RadioButton rbFTP_hours;

		private System.Windows.Forms.Label label11;

		private System.Windows.Forms.DateTimePicker dtpFTP_start;

		private System.Windows.Forms.Label label12;

		private System.Windows.Forms.Button btnFTP_ChoicePath;

		private System.Windows.Forms.Button btnFTP_ChoiceFileName;

		private System.Windows.Forms.Label label13;

		private System.Windows.Forms.TextBox txtFTP_PathName;

		private System.Windows.Forms.CheckBox chbUseFTP;

		private System.Windows.Forms.TextBox txtFTP_FileName;

		private System.Windows.Forms.MaskedTextBox txtFTP_ProxyPwd;

		private System.Windows.Forms.Label label14;

		private System.Windows.Forms.Label label15;

		private System.Windows.Forms.TextBox txtFTP_NameFTP;

		private System.Windows.Forms.Label label16;

		private System.Windows.Forms.Label label17;

		private System.Windows.Forms.TextBox txtFTP_ProxyUser;

		private System.Windows.Forms.Label label18;

		private System.Windows.Forms.TextBox txtFTP_Proxy;

		private System.Windows.Forms.TextBox txtFTP_FTPUser;

		private System.Windows.Forms.CheckBox chbFTP_Proxy;

		private System.Windows.Forms.Label label19;

		private System.Windows.Forms.MaskedTextBox txtFTP_FTPPwd;

		private System.Windows.Forms.TabPage tabPagePlannedMail;

		private System.Windows.Forms.Button btnChoiseFileMail;

		private System.Windows.Forms.TextBox txtFileNameReportHead;

		private System.Windows.Forms.Label label20;

		private System.Windows.Forms.CheckBox chkUseMailPlanned;

		private System.Windows.Forms.GroupBox groupBoxSMTP;

		private System.Windows.Forms.Label label24;

		private System.Windows.Forms.TextBox txtPwdSMTPPlanned;

		private System.Windows.Forms.Label label23;

		private System.Windows.Forms.TextBox txtLoginSMTPPlanned;

		private System.Windows.Forms.Label label22;

		private System.Windows.Forms.NumericUpDown txtSMTPServerPortPlanned;

		private System.Windows.Forms.Label label21;

		private System.Windows.Forms.TextBox txtSMTPServerPlanned;

		private System.Windows.Forms.GroupBox groupBoxSender;

		private System.Windows.Forms.Label label26;

		private System.Windows.Forms.TextBox txtSenderNamePlanned;

		private System.Windows.Forms.Label label25;

		private System.Windows.Forms.TextBox txtSenderAddressPlanned;

		private System.Windows.Forms.Label label27;

		private System.Windows.Forms.GroupBox groupBoxSheduleMailPlanned;

		private System.Windows.Forms.NumericUpDown numMailPlanned_weeks;

		private System.Windows.Forms.NumericUpDown numMailPlanned_days;

		private System.Windows.Forms.NumericUpDown numMailPlanned_hours;

		private System.Windows.Forms.RadioButton rbMailPlanned_weeks;

		private System.Windows.Forms.RadioButton rbMailPlanned_days;

		private System.Windows.Forms.RadioButton rbMailPlanned_hours;

		private System.Windows.Forms.Label label30;

		private System.Windows.Forms.DateTimePicker dtpMailPlanned_start;

		private System.Windows.Forms.Label label31;

		private System.Windows.Forms.Label label29;

		private System.Windows.Forms.TextBox txtBodyPlanned;

		private System.Windows.Forms.Label label28;

		private System.Windows.Forms.TextBox txtSubjectPlanned;

		private System.Windows.Forms.DataGridView dgvRecipients;

		private System.Windows.Forms.DataGridViewTextBoxColumn addressRecipientDgvColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn nameRecipientDgvColumn;

		private System.Windows.Forms.TabPage tabPageRIC;

		private System.Windows.Forms.CheckBox checkBoxSendRIC;
    private System.Windows.Forms.TextBox txtNameURL;
    private System.Windows.Forms.CheckBox checkBoxSendME;
    private System.Windows.Forms.Label label32;
    private System.Windows.Forms.Label label33;
    private System.Windows.Forms.TextBox txtUserME;
    private System.Windows.Forms.Label label34;
    private System.Windows.Forms.MaskedTextBox txtPwdME;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox chkCreateAktDLV;
    private System.Windows.Forms.CheckBox chkCreateAktDHV;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.CheckBox chkSendCorrectDamage;
    private System.Windows.Forms.CheckBox chkSendNullListAbonent;
    private System.Windows.Forms.TabPage tabPageReportHead;
    private System.Windows.Forms.GroupBox groupBoxSheduleMail;
    private System.Windows.Forms.NumericUpDown numMail_weeks;
    private System.Windows.Forms.NumericUpDown numMail_day;
    private System.Windows.Forms.NumericUpDown numMail_hours;
    private System.Windows.Forms.RadioButton rbMail_weeks;
    private System.Windows.Forms.RadioButton rbMail_days;
    private System.Windows.Forms.RadioButton rbMail_hours;
    private System.Windows.Forms.Label label35;
    private System.Windows.Forms.DateTimePicker dtpBeginMail;
    private System.Windows.Forms.Label label36;
    private System.Windows.Forms.Label label37;
    private System.Windows.Forms.TextBox txtBody;
    private System.Windows.Forms.Label label38;
    private System.Windows.Forms.TextBox txtSubject;
    private System.Windows.Forms.DataGridView dgvRecipientsHead;
    private System.Windows.Forms.Label label39;
    private System.Windows.Forms.GroupBox groupBoxSenderHead;
    private System.Windows.Forms.Label label40;
    private System.Windows.Forms.TextBox txtSenderName;
    private System.Windows.Forms.Label label41;
    private System.Windows.Forms.TextBox txtSenderAddress;
    private System.Windows.Forms.GroupBox groupBoxSMTPHead;
    private System.Windows.Forms.Label label42;
    private System.Windows.Forms.TextBox txtPwdSMTP;
    private System.Windows.Forms.Label label43;
    private System.Windows.Forms.TextBox txtLoginSMTP;
    private System.Windows.Forms.Label label44;
    private System.Windows.Forms.NumericUpDown txtSMTPServerPort;
    private System.Windows.Forms.Label label45;
    private System.Windows.Forms.TextBox txtSMTPServer;
    private System.Windows.Forms.Button btnChoiseReportHead;
    private System.Windows.Forms.TextBox txtFileNameMailReportHead;
    private System.Windows.Forms.Label label46;
    private System.Windows.Forms.CheckBox chkSendReportHead;
    private System.Windows.Forms.DataGridViewTextBoxColumn addressDgvColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDgvColumn;
    private System.Windows.Forms.Label label47;
    private System.Windows.Forms.TextBox txtPeriodToBeginDay;
    private System.Windows.Forms.GroupBox groupBoxCollectionStartingPoint;
    private System.Windows.Forms.DateTimePicker dtpTimeBegin;
    private System.Windows.Forms.Label label48;
    private System.Windows.Forms.DateTimePicker dtpTimeEnd;
    private System.Windows.Forms.Label label50;
    private System.Windows.Forms.ComboBox cmbOutFormatFile;
    private System.Windows.Forms.Label label49;
    private System.Windows.Forms.GroupBox groupBoxServices;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbStart;
    private System.Windows.Forms.ToolStripButton tsbRestart;
    private System.Windows.Forms.ToolStripButton tsbStop;
    private System.Windows.Forms.Label label51;
    private System.Windows.Forms.TextBox txtRemoteServer;
    private System.Windows.Forms.TextBox txtServiceName;
    private System.Windows.Forms.Label label52;
    private System.Windows.Forms.Label serviceStatus;
    private System.Windows.Forms.Timer timerServiceRun;
    private System.Windows.Forms.Button btnFTP_ChoiceFileNameSESNO;
    private System.Windows.Forms.TextBox txtFTP_FileNameSESNO;
    private System.Windows.Forms.Label label53;
}
