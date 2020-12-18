using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormExportRequestForRepair
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	private global::System.ComponentModel.IContainer components = null;

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportRequestForRepair));
            this.groupBoxHTML = new System.Windows.Forms.GroupBox();
            this.dateTimePickerHTMLEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerHTMLBeg = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateHTML = new System.Windows.Forms.Button();
            this.buttonHTML = new System.Windows.Forms.Button();
            this.textBoxHTML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialogHTML = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerExcel = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreateExcel = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.textBoxExcel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialogXLS = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxMail = new System.Windows.Forms.GroupBox();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.textBoxBodyMail = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxSubjectMail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonFileMail = new System.Windows.Forms.Button();
            this.textBoxFileNameMail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxRecipientAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSenderAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxRecipientName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSenderName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSmtpPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSmtoServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxHTML.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMail.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHTML
            // 
            this.groupBoxHTML.Controls.Add(this.dateTimePickerHTMLEnd);
            this.groupBoxHTML.Controls.Add(this.label3);
            this.groupBoxHTML.Controls.Add(this.dateTimePickerHTMLBeg);
            this.groupBoxHTML.Controls.Add(this.label2);
            this.groupBoxHTML.Controls.Add(this.buttonCreateHTML);
            this.groupBoxHTML.Controls.Add(this.buttonHTML);
            this.groupBoxHTML.Controls.Add(this.textBoxHTML);
            this.groupBoxHTML.Controls.Add(this.label1);
            this.groupBoxHTML.Location = new System.Drawing.Point(1, 2);
            this.groupBoxHTML.Name = "groupBoxHTML";
            this.groupBoxHTML.Size = new System.Drawing.Size(311, 134);
            this.groupBoxHTML.TabIndex = 0;
            this.groupBoxHTML.TabStop = false;
            this.groupBoxHTML.Text = "HTML";
            // 
            // dateTimePickerHTMLEnd
            // 
            this.dateTimePickerHTMLEnd.Location = new System.Drawing.Point(174, 33);
            this.dateTimePickerHTMLEnd.Name = "dateTimePickerHTMLEnd";
            this.dateTimePickerHTMLEnd.Size = new System.Drawing.Size(131, 20);
            this.dateTimePickerHTMLEnd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "до";
            // 
            // dateTimePickerHTMLBeg
            // 
            this.dateTimePickerHTMLBeg.Location = new System.Drawing.Point(14, 33);
            this.dateTimePickerHTMLBeg.Name = "dateTimePickerHTMLBeg";
            this.dateTimePickerHTMLBeg.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerHTMLBeg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата от";
            // 
            // buttonCreateHTML
            // 
            this.buttonCreateHTML.Location = new System.Drawing.Point(11, 105);
            this.buttonCreateHTML.Name = "buttonCreateHTML";
            this.buttonCreateHTML.Size = new System.Drawing.Size(101, 23);
            this.buttonCreateHTML.TabIndex = 3;
            this.buttonCreateHTML.Text = "Сформировать";
            this.buttonCreateHTML.UseVisualStyleBackColor = true;
            this.buttonCreateHTML.Click += new System.EventHandler(this.buttonCreateHTML_Click);
            // 
            // buttonHTML
            // 
            this.buttonHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHTML.Location = new System.Drawing.Point(281, 78);
            this.buttonHTML.Name = "buttonHTML";
            this.buttonHTML.Size = new System.Drawing.Size(26, 23);
            this.buttonHTML.TabIndex = 2;
            this.buttonHTML.Text = "...";
            this.buttonHTML.UseVisualStyleBackColor = true;
            this.buttonHTML.Click += new System.EventHandler(this.buttonHTML_Click);
            // 
            // textBoxHTML
            // 
            this.textBoxHTML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHTML.Location = new System.Drawing.Point(11, 79);
            this.textBoxHTML.Name = "textBoxHTML";
            this.textBoxHTML.Size = new System.Drawing.Size(274, 20);
            this.textBoxHTML.TabIndex = 1;
            this.textBoxHTML.TextChanged += new System.EventHandler(this.textBoxHTML_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя файла";
            // 
            // saveFileDialogHTML
            // 
            this.saveFileDialogHTML.Filter = "HTML Files (*.html)|*.html";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerExcel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonCreateExcel);
            this.groupBox1.Controls.Add(this.buttonExcel);
            this.groupBox1.Controls.Add(this.textBoxExcel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(1, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel";
            // 
            // dateTimePickerExcel
            // 
            this.dateTimePickerExcel.Location = new System.Drawing.Point(14, 33);
            this.dateTimePickerExcel.Name = "dateTimePickerExcel";
            this.dateTimePickerExcel.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerExcel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата";
            // 
            // buttonCreateExcel
            // 
            this.buttonCreateExcel.Location = new System.Drawing.Point(11, 105);
            this.buttonCreateExcel.Name = "buttonCreateExcel";
            this.buttonCreateExcel.Size = new System.Drawing.Size(101, 23);
            this.buttonCreateExcel.TabIndex = 3;
            this.buttonCreateExcel.Text = "Сформировать";
            this.buttonCreateExcel.UseVisualStyleBackColor = true;
            this.buttonCreateExcel.Click += new System.EventHandler(this.buttonCreateExcel2_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcel.Location = new System.Drawing.Point(281, 77);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(26, 23);
            this.buttonExcel.TabIndex = 2;
            this.buttonExcel.Text = "...";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // textBoxExcel
            // 
            this.textBoxExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExcel.Location = new System.Drawing.Point(11, 79);
            this.textBoxExcel.Name = "textBoxExcel";
            this.textBoxExcel.Size = new System.Drawing.Size(274, 20);
            this.textBoxExcel.TabIndex = 1;
            this.textBoxExcel.TextChanged += new System.EventHandler(this.textBoxExcel_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Имя файла";
            // 
            // saveFileDialogXLS
            // 
            this.saveFileDialogXLS.Filter = "Excel Files (*.xls)|*.xls";
            // 
            // groupBoxMail
            // 
            this.groupBoxMail.Controls.Add(this.buttonSendMail);
            this.groupBoxMail.Controls.Add(this.textBoxBodyMail);
            this.groupBoxMail.Controls.Add(this.label16);
            this.groupBoxMail.Controls.Add(this.textBoxSubjectMail);
            this.groupBoxMail.Controls.Add(this.label15);
            this.groupBoxMail.Controls.Add(this.buttonFileMail);
            this.groupBoxMail.Controls.Add(this.textBoxFileNameMail);
            this.groupBoxMail.Controls.Add(this.label14);
            this.groupBoxMail.Controls.Add(this.splitContainer1);
            this.groupBoxMail.Controls.Add(this.textBoxSmtpPort);
            this.groupBoxMail.Controls.Add(this.label7);
            this.groupBoxMail.Controls.Add(this.textBoxSmtoServer);
            this.groupBoxMail.Controls.Add(this.label4);
            this.groupBoxMail.Location = new System.Drawing.Point(314, 2);
            this.groupBoxMail.Name = "groupBoxMail";
            this.groupBoxMail.Size = new System.Drawing.Size(428, 360);
            this.groupBoxMail.TabIndex = 2;
            this.groupBoxMail.TabStop = false;
            this.groupBoxMail.Text = "Почта";
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.Location = new System.Drawing.Point(14, 334);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(75, 23);
            this.buttonSendMail.TabIndex = 12;
            this.buttonSendMail.Text = "Отправить";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // textBoxBodyMail
            // 
            this.textBoxBodyMail.Location = new System.Drawing.Point(14, 278);
            this.textBoxBodyMail.Name = "textBoxBodyMail";
            this.textBoxBodyMail.Size = new System.Drawing.Size(409, 50);
            this.textBoxBodyMail.TabIndex = 11;
            this.textBoxBodyMail.Text = "";
            this.textBoxBodyMail.TextChanged += new System.EventHandler(this.textBoxBodyMail_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Текст письма";
            // 
            // textBoxSubjectMail
            // 
            this.textBoxSubjectMail.Location = new System.Drawing.Point(14, 240);
            this.textBoxSubjectMail.Name = "textBoxSubjectMail";
            this.textBoxSubjectMail.Size = new System.Drawing.Size(409, 20);
            this.textBoxSubjectMail.TabIndex = 9;
            this.textBoxSubjectMail.TextChanged += new System.EventHandler(this.textBoxSubjectMail_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Тема письма";
            // 
            // buttonFileMail
            // 
            this.buttonFileMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileMail.Location = new System.Drawing.Point(398, 198);
            this.buttonFileMail.Name = "buttonFileMail";
            this.buttonFileMail.Size = new System.Drawing.Size(26, 23);
            this.buttonFileMail.TabIndex = 7;
            this.buttonFileMail.Text = "...";
            this.buttonFileMail.UseVisualStyleBackColor = true;
            this.buttonFileMail.Click += new System.EventHandler(this.buttonFileMail_Click);
            // 
            // textBoxFileNameMail
            // 
            this.textBoxFileNameMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileNameMail.Location = new System.Drawing.Point(14, 201);
            this.textBoxFileNameMail.Name = "textBoxFileNameMail";
            this.textBoxFileNameMail.Size = new System.Drawing.Size(384, 20);
            this.textBoxFileNameMail.TabIndex = 6;
            this.textBoxFileNameMail.TextChanged += new System.EventHandler(this.textBoxFileNameMail_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Имя файла";
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxRecipientAddress);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSenderAddress);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLogin);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPassword);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxRecipientName);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSenderName);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Size = new System.Drawing.Size(427, 124);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            // 
            // textBoxRecipientAddress
            // 
            this.textBoxRecipientAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRecipientAddress.Location = new System.Drawing.Point(14, 94);
            this.textBoxRecipientAddress.Name = "textBoxRecipientAddress";
            this.textBoxRecipientAddress.Size = new System.Drawing.Size(194, 20);
            this.textBoxRecipientAddress.TabIndex = 5;
            this.textBoxRecipientAddress.TextChanged += new System.EventHandler(this.textBoxRecipientAddress_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Адрес получателя";
            // 
            // textBoxSenderAddress
            // 
            this.textBoxSenderAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSenderAddress.Location = new System.Drawing.Point(14, 55);
            this.textBoxSenderAddress.Name = "textBoxSenderAddress";
            this.textBoxSenderAddress.Size = new System.Drawing.Size(194, 20);
            this.textBoxSenderAddress.TabIndex = 3;
            this.textBoxSenderAddress.TextChanged += new System.EventHandler(this.textBoxSenderAddress_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Адрес отправителя";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.Location = new System.Drawing.Point(14, 16);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(194, 20);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Логин";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 16);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '☻';
            this.textBoxPassword.Size = new System.Drawing.Size(206, 20);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxRecipientName
            // 
            this.textBoxRecipientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRecipientName.Location = new System.Drawing.Point(6, 94);
            this.textBoxRecipientName.Name = "textBoxRecipientName";
            this.textBoxRecipientName.Size = new System.Drawing.Size(205, 20);
            this.textBoxRecipientName.TabIndex = 7;
            this.textBoxRecipientName.TextChanged += new System.EventHandler(this.textBoxRecipientName_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Имя получателя";
            // 
            // textBoxSenderName
            // 
            this.textBoxSenderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSenderName.Location = new System.Drawing.Point(6, 55);
            this.textBoxSenderName.Name = "textBoxSenderName";
            this.textBoxSenderName.Size = new System.Drawing.Size(205, 20);
            this.textBoxSenderName.TabIndex = 5;
            this.textBoxSenderName.TextChanged += new System.EventHandler(this.textBoxSenderName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Имя отправителя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Пароль";
            // 
            // textBoxSmtpPort
            // 
            this.textBoxSmtpPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSmtpPort.Location = new System.Drawing.Point(328, 32);
            this.textBoxSmtpPort.Name = "textBoxSmtpPort";
            this.textBoxSmtpPort.Size = new System.Drawing.Size(96, 20);
            this.textBoxSmtpPort.TabIndex = 3;
            this.textBoxSmtpPort.TextChanged += new System.EventHandler(this.textBoxSmtpPort_TextChanged);
            this.textBoxSmtpPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSmtpPort_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Порт";
            // 
            // textBoxSmtoServer
            // 
            this.textBoxSmtoServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSmtoServer.Location = new System.Drawing.Point(11, 32);
            this.textBoxSmtoServer.Name = "textBoxSmtoServer";
            this.textBoxSmtoServer.Size = new System.Drawing.Size(295, 20);
            this.textBoxSmtoServer.TabIndex = 1;
            this.textBoxSmtoServer.TextChanged += new System.EventHandler(this.textBoxSmtoServer_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Сервер отправки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormExportRequestForRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxMail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxHTML);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(760, 406);
            this.Name = "FormExportRequestForRepair";
            this.Text = "Экспорт заявок на ремонт оборудования";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExportRequestForRepair_FormClosing);
            this.Load += new System.EventHandler(this.FormExportRequestForRepair_Load);
            this.groupBoxHTML.ResumeLayout(false);
            this.groupBoxHTML.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMail.ResumeLayout(false);
            this.groupBoxMail.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

    }
    private GroupBox groupBoxHTML;

    private Button buttonCreateHTML;

    private Button buttonHTML;

    private TextBox textBoxHTML;

    private Label label1;

    private SaveFileDialog saveFileDialogHTML;

    private DateTimePicker dateTimePickerHTMLEnd;

    private Label label3;

    private DateTimePicker dateTimePickerHTMLBeg;

    private Label label2;

    private GroupBox groupBox1;

    private DateTimePicker dateTimePickerExcel;

    private Label label5;

    private Button buttonCreateExcel;

    private Button buttonExcel;

    private TextBox textBoxExcel;

    private Label label6;

    private SaveFileDialog saveFileDialogXLS;

    private GroupBox groupBoxMail;

    private Button buttonSendMail;

    private RichTextBox textBoxBodyMail;

    private Label label16;

    private TextBox textBoxSubjectMail;

    private Label label15;

    private Button buttonFileMail;

    private TextBox textBoxFileNameMail;

    private Label label14;

    private SplitContainer splitContainer1;

    private TextBox textBoxRecipientAddress;

    private Label label12;

    private TextBox textBoxSenderAddress;

    private Label label10;

    private TextBox textBoxLogin;

    private Label label8;

    private TextBox textBoxRecipientName;

    private Label label13;

    private TextBox textBoxSenderName;

    private Label label11;

    private Label label9;

    private TextBox textBoxSmtpPort;

    private Label label7;

    private TextBox textBoxSmtoServer;

    private Label label4;

    private OpenFileDialog openFileDialog;

    private TextBox textBoxPassword;

    private Button button1;

}
