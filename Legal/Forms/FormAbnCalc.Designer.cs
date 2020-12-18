namespace Legal.Forms
{
    partial class FormAbnCalc
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
            System.Windows.Forms.Label dtPayLabel;
            System.Windows.Forms.Label dtBankLabel;
            System.Windows.Forms.Label sumRealizLabel;
            System.Windows.Forms.Label sumNalogLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label blockingLabel;
            this.f_dtPay = new System.Windows.Forms.DateTimePicker();
            this.tG_DocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCntVal1 = new Legal.DataSet.dsCntVal();
            this.f_dtBank = new System.Windows.Forms.DateTimePicker();
            this.f_sumRealiz = new System.Windows.Forms.TextBox();
            this.f_sumNalog = new System.Windows.Forms.TextBox();
            this.f_payment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.f_sumTotal = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.f_quantity = new System.Windows.Forms.TextBox();
            this.blockingCheckBox = new System.Windows.Forms.CheckBox();
            this.f_PaymentSelect = new System.Windows.Forms.ComboBox();
            this.f_TariffLegal = new System.Windows.Forms.ComboBox();
            this.f_NumberStorno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.f_Select_FactNumber = new System.Windows.Forms.ComboBox();
            this.dsCalc1 = new Legal.DataSet.dsCalc();
            this.f_TypeFact = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.f_DateStorno = new System.Windows.Forms.DateTimePicker();
            this.btnGetNumberFact = new System.Windows.Forms.Button();
            this.f_DateFactCorrect = new System.Windows.Forms.DateTimePicker();
            this.f_NumberFactCorrect = new System.Windows.Forms.NumericUpDown();
            this.f_DateFact = new System.Windows.Forms.DateTimePicker();
            this.f_NumberFact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            dtPayLabel = new System.Windows.Forms.Label();
            dtBankLabel = new System.Windows.Forms.Label();
            sumRealizLabel = new System.Windows.Forms.Label();
            sumNalogLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            blockingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tG_DocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_NumberFactCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPayLabel
            // 
            dtPayLabel.AutoSize = true;
            dtPayLabel.Location = new System.Drawing.Point(36, 27);
            dtPayLabel.Name = "dtPayLabel";
            dtPayLabel.Size = new System.Drawing.Size(79, 13);
            dtPayLabel.TabIndex = 0;
            dtPayLabel.Text = "Дата расчета:";
            // 
            // dtBankLabel
            // 
            dtBankLabel.AutoSize = true;
            dtBankLabel.Location = new System.Drawing.Point(46, 66);
            dtBankLabel.Name = "dtBankLabel";
            dtBankLabel.Size = new System.Drawing.Size(69, 13);
            dtBankLabel.TabIndex = 2;
            dtBankLabel.Text = "Дата банка:";
            // 
            // sumRealizLabel
            // 
            sumRealizLabel.AutoSize = true;
            sumRealizLabel.Location = new System.Drawing.Point(31, 22);
            sumRealizLabel.Name = "sumRealizLabel";
            sumRealizLabel.Size = new System.Drawing.Size(44, 13);
            sumRealizLabel.TabIndex = 8;
            sumRealizLabel.Text = "Сумма:";
            // 
            // sumNalogLabel
            // 
            sumNalogLabel.AutoSize = true;
            sumNalogLabel.Location = new System.Drawing.Point(190, 22);
            sumNalogLabel.Name = "sumNalogLabel";
            sumNalogLabel.Size = new System.Drawing.Size(41, 13);
            sumNalogLabel.TabIndex = 10;
            sumNalogLabel.Text = "Налог:";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new System.Drawing.Point(12, 198);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(117, 13);
            paymentLabel.TabIndex = 12;
            paymentLabel.Text = "Назначение платежа:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(309, 53);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(69, 13);
            quantityLabel.TabIndex = 21;
            quantityLabel.Text = "Количество:";
            // 
            // blockingLabel
            // 
            blockingLabel.AutoSize = true;
            blockingLabel.Location = new System.Drawing.Point(346, 46);
            blockingLabel.Name = "blockingLabel";
            blockingLabel.Size = new System.Drawing.Size(44, 13);
            blockingLabel.TabIndex = 21;
            blockingLabel.Text = "Статус:";
            // 
            // f_dtPay
            // 
            this.f_dtPay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tG_DocBindingSource, "dtPay", true));
            this.f_dtPay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "dtPay", true));
            this.f_dtPay.Location = new System.Drawing.Point(131, 27);
            this.f_dtPay.Name = "f_dtPay";
            this.f_dtPay.Size = new System.Drawing.Size(143, 20);
            this.f_dtPay.TabIndex = 1;
            // 
            // tG_DocBindingSource
            // 
            this.tG_DocBindingSource.DataMember = "tG_Doc";
            this.tG_DocBindingSource.DataSource = this.dsCntVal1;
            // 
            // dsCntVal1
            // 
            this.dsCntVal1.DataSetName = "dsCntVal";
            this.dsCntVal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_dtBank
            // 
            this.f_dtBank.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tG_DocBindingSource, "dtBank", true));
            this.f_dtBank.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "dtBank", true));
            this.f_dtBank.Location = new System.Drawing.Point(131, 62);
            this.f_dtBank.Name = "f_dtBank";
            this.f_dtBank.Size = new System.Drawing.Size(143, 20);
            this.f_dtBank.TabIndex = 3;
            // 
            // f_sumRealiz
            // 
            this.f_sumRealiz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "SumRealiz", true));
            this.f_sumRealiz.Location = new System.Drawing.Point(84, 19);
            this.f_sumRealiz.Name = "f_sumRealiz";
            this.f_sumRealiz.Size = new System.Drawing.Size(100, 20);
            this.f_sumRealiz.TabIndex = 9;
            this.f_sumRealiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // f_sumNalog
            // 
            this.f_sumNalog.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "SumNalog", true));
            this.f_sumNalog.Location = new System.Drawing.Point(237, 19);
            this.f_sumNalog.Name = "f_sumNalog";
            this.f_sumNalog.Size = new System.Drawing.Size(100, 20);
            this.f_sumNalog.TabIndex = 11;
            this.f_sumNalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // f_payment
            // 
            this.f_payment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "Payment", true));
            this.f_payment.Location = new System.Drawing.Point(15, 228);
            this.f_payment.Name = "f_payment";
            this.f_payment.Size = new System.Drawing.Size(503, 20);
            this.f_payment.TabIndex = 13;
            this.f_payment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Всего:";
            // 
            // f_sumTotal
            // 
            this.f_sumTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "SumTotal", true));
            this.f_sumTotal.Location = new System.Drawing.Point(389, 19);
            this.f_sumTotal.Name = "f_sumTotal";
            this.f_sumTotal.Size = new System.Drawing.Size(100, 20);
            this.f_sumTotal.TabIndex = 16;
            this.f_sumTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(337, 476);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 18;
            this.btnCalc.Text = "Сохранить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(443, 476);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(quantityLabel);
            this.groupBox2.Controls.Add(this.f_sumTotal);
            this.groupBox2.Controls.Add(this.f_quantity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(sumNalogLabel);
            this.groupBox2.Controls.Add(this.f_sumNalog);
            this.groupBox2.Controls.Add(sumRealizLabel);
            this.groupBox2.Controls.Add(this.f_sumRealiz);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 80);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выставлено";
            // 
            // f_quantity
            // 
            this.f_quantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "Quantity", true));
            this.f_quantity.Location = new System.Drawing.Point(389, 50);
            this.f_quantity.Name = "f_quantity";
            this.f_quantity.Size = new System.Drawing.Size(100, 20);
            this.f_quantity.TabIndex = 22;
            this.f_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // blockingCheckBox
            // 
            this.blockingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tG_DocBindingSource, "Blocking", true));
            this.blockingCheckBox.Enabled = false;
            this.blockingCheckBox.Location = new System.Drawing.Point(397, 41);
            this.blockingCheckBox.Name = "blockingCheckBox";
            this.blockingCheckBox.Size = new System.Drawing.Size(104, 24);
            this.blockingCheckBox.TabIndex = 22;
            this.blockingCheckBox.Text = "Закрыто";
            this.blockingCheckBox.UseVisualStyleBackColor = true;
            // 
            // f_PaymentSelect
            // 
            this.f_PaymentSelect.DataSource = this.dsCntVal1;
            this.f_PaymentSelect.DisplayMember = "tR_Classifier.Name";
            this.f_PaymentSelect.FormattingEnabled = true;
            this.f_PaymentSelect.Location = new System.Drawing.Point(144, 195);
            this.f_PaymentSelect.Name = "f_PaymentSelect";
            this.f_PaymentSelect.Size = new System.Drawing.Size(374, 21);
            this.f_PaymentSelect.TabIndex = 23;
            this.f_PaymentSelect.ValueMember = "tR_Classifier.Id";
            this.f_PaymentSelect.TextChanged += new System.EventHandler(this.f_PaymentSelect_TextChanged);
            // 
            // f_TariffLegal
            // 
            this.f_TariffLegal.DataSource = this.dsCntVal1;
            this.f_TariffLegal.DisplayMember = "tR_Classifier1.Name";
            this.f_TariffLegal.FormattingEnabled = true;
            this.f_TariffLegal.Location = new System.Drawing.Point(15, 261);
            this.f_TariffLegal.Name = "f_TariffLegal";
            this.f_TariffLegal.Size = new System.Drawing.Size(503, 21);
            this.f_TariffLegal.TabIndex = 25;
            this.f_TariffLegal.ValueMember = "tR_Classifier1.Id";
            // 
            // f_NumberStorno
            // 
            this.f_NumberStorno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "NumberStorno", true));
            this.f_NumberStorno.Location = new System.Drawing.Point(132, 128);
            this.f_NumberStorno.Name = "f_NumberStorno";
            this.f_NumberStorno.Size = new System.Drawing.Size(99, 20);
            this.f_NumberStorno.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Номер сторнируемого:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Дата:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.f_Select_FactNumber);
            this.groupBox1.Controls.Add(this.f_TypeFact);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.f_DateStorno);
            this.groupBox1.Controls.Add(this.btnGetNumberFact);
            this.groupBox1.Controls.Add(this.f_DateFactCorrect);
            this.groupBox1.Controls.Add(this.f_NumberFactCorrect);
            this.groupBox1.Controls.Add(this.f_DateFact);
            this.groupBox1.Controls.Add(this.f_NumberFact);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.f_NumberStorno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 163);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Счет-фактура(только для потребителей с договорами на оказание услуг по передаче)";
            // 
            // f_Select_FactNumber
            // 
            this.f_Select_FactNumber.DataSource = this.dsCalc1;
            this.f_Select_FactNumber.DisplayMember = "dtNumberSelect.FactNumber";
            this.f_Select_FactNumber.FormattingEnabled = true;
            this.f_Select_FactNumber.Location = new System.Drawing.Point(237, 57);
            this.f_Select_FactNumber.Name = "f_Select_FactNumber";
            this.f_Select_FactNumber.Size = new System.Drawing.Size(89, 21);
            this.f_Select_FactNumber.TabIndex = 44;
            this.f_Select_FactNumber.ValueMember = "dtNumberSelect.FactNumber";
            this.f_Select_FactNumber.SelectedIndexChanged += new System.EventHandler(this.f_Select_FactNumber_SelectedIndexChanged);
            this.f_Select_FactNumber.SelectionChangeCommitted += new System.EventHandler(this.f_Select_FactNumber_SelectionChangeCommitted);
            // 
            // dsCalc1
            // 
            this.dsCalc1.DataSetName = "dsCalc";
            this.dsCalc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_TypeFact
            // 
            this.f_TypeFact.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tG_DocBindingSource, "SchetFactType", true));
            this.f_TypeFact.DataSource = this.dsCntVal1;
            this.f_TypeFact.DisplayMember = "tR_Classifier2.Name";
            this.f_TypeFact.FormattingEnabled = true;
            this.f_TypeFact.Location = new System.Drawing.Point(51, 27);
            this.f_TypeFact.Name = "f_TypeFact";
            this.f_TypeFact.Size = new System.Drawing.Size(201, 21);
            this.f_TypeFact.TabIndex = 43;
            this.f_TypeFact.ValueMember = "tR_Classifier2.Id";
            this.f_TypeFact.SelectedIndexChanged += new System.EventHandler(this.f_TypeFact_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Тип:";
            // 
            // f_DateStorno
            // 
            this.f_DateStorno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "DateStorno", true));
            this.f_DateStorno.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tG_DocBindingSource, "DateStorno", true));
            this.f_DateStorno.Location = new System.Drawing.Point(374, 125);
            this.f_DateStorno.Name = "f_DateStorno";
            this.f_DateStorno.Size = new System.Drawing.Size(126, 20);
            this.f_DateStorno.TabIndex = 39;
            // 
            // btnGetNumberFact
            // 
            this.btnGetNumberFact.BackColor = System.Drawing.Color.Transparent;
            this.btnGetNumberFact.Image = global::Legal.Properties.Resources.Обновить;
            this.btnGetNumberFact.Location = new System.Drawing.Point(193, 57);
            this.btnGetNumberFact.Name = "btnGetNumberFact";
            this.btnGetNumberFact.Size = new System.Drawing.Size(25, 22);
            this.btnGetNumberFact.TabIndex = 38;
            this.btnGetNumberFact.UseVisualStyleBackColor = false;
            this.btnGetNumberFact.Click += new System.EventHandler(this.btnGetNumberFact_Click);
            // 
            // f_DateFactCorrect
            // 
            this.f_DateFactCorrect.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "dtFactCorrection", true));
            this.f_DateFactCorrect.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tG_DocBindingSource, "dtFactCorrection", true));
            this.f_DateFactCorrect.Location = new System.Drawing.Point(374, 89);
            this.f_DateFactCorrect.Name = "f_DateFactCorrect";
            this.f_DateFactCorrect.Size = new System.Drawing.Size(126, 20);
            this.f_DateFactCorrect.TabIndex = 37;
            // 
            // f_NumberFactCorrect
            // 
            this.f_NumberFactCorrect.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tG_DocBindingSource, "NumberFactCorrection", true));
            this.f_NumberFactCorrect.Location = new System.Drawing.Point(132, 93);
            this.f_NumberFactCorrect.Name = "f_NumberFactCorrect";
            this.f_NumberFactCorrect.Size = new System.Drawing.Size(64, 20);
            this.f_NumberFactCorrect.TabIndex = 36;
            // 
            // f_DateFact
            // 
            this.f_DateFact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "dtSchetFact", true));
            this.f_DateFact.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tG_DocBindingSource, "dtSchetFact", true));
            this.f_DateFact.Location = new System.Drawing.Point(374, 57);
            this.f_DateFact.Name = "f_DateFact";
            this.f_DateFact.Size = new System.Drawing.Size(126, 20);
            this.f_DateFact.TabIndex = 35;
            this.f_DateFact.ValueChanged += new System.EventHandler(this.f_DateFact_ValueChanged);
            // 
            // f_NumberFact
            // 
            this.f_NumberFact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tG_DocBindingSource, "NumberSchetFact", true));
            this.f_NumberFact.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tG_DocBindingSource, "NumberSchetFact", true));
            this.f_NumberFact.Location = new System.Drawing.Point(75, 58);
            this.f_NumberFact.Name = "f_NumberFact";
            this.f_NumberFact.Size = new System.Drawing.Size(99, 20);
            this.f_NumberFact.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Дата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Номер исправления:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Дата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Номер:";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "dtNumberSelect";
            this.bindingSource1.DataSource = this.dsCalc1;
            // 
            // FormAbnCalc
            // 
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(526, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.f_TariffLegal);
            this.Controls.Add(this.f_PaymentSelect);
            this.Controls.Add(blockingLabel);
            this.Controls.Add(this.blockingCheckBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(paymentLabel);
            this.Controls.Add(this.f_payment);
            this.Controls.Add(dtBankLabel);
            this.Controls.Add(this.f_dtBank);
            this.Controls.Add(dtPayLabel);
            this.Controls.Add(this.f_dtPay);
            this.Name = "FormAbnCalc";
            this.Text = "Документ";
            this.Load += new System.EventHandler(this.FormAbnCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tG_DocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_NumberFactCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Legal.DataSet.dsCntVal dsCntVal1;
        private System.Windows.Forms.BindingSource tG_DocBindingSource;
        private System.Windows.Forms.DateTimePicker f_dtPay;
        private System.Windows.Forms.DateTimePicker f_dtBank;
        private System.Windows.Forms.TextBox f_sumRealiz;
        private System.Windows.Forms.TextBox f_sumNalog;
        private System.Windows.Forms.RichTextBox f_payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox f_sumTotal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox f_quantity;
        private System.Windows.Forms.CheckBox blockingCheckBox;
        private System.Windows.Forms.ComboBox f_PaymentSelect;
        private System.Windows.Forms.ComboBox f_TariffLegal;
        private System.Windows.Forms.TextBox f_NumberStorno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker f_DateStorno;
        private System.Windows.Forms.Button btnGetNumberFact;
        private System.Windows.Forms.DateTimePicker f_DateFactCorrect;
        private System.Windows.Forms.NumericUpDown f_NumberFactCorrect;
        private System.Windows.Forms.DateTimePicker f_DateFact;
        private System.Windows.Forms.TextBox f_NumberFact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox f_TypeFact;
        private System.Windows.Forms.Label label8;
        //private System.Windows.Forms.ComboBox f_NumberFact_Select;
        //private System.Windows.Forms.ComboBox f_NumberSelect;
        private System.Windows.Forms.ComboBox f_Select_FactNumber;
        private DataSet.dsCalc dsCalc1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
