namespace Legal.Forms
{
    partial class FormAbnDetails
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
            System.Windows.Forms.Label nameFullLabel;
            System.Windows.Forms.Label dateChangeLabel;
            System.Windows.Forms.Label bankPayerLabel;
            System.Windows.Forms.Label bankPayeeLabel;
            System.Windows.Forms.Label bankAcntLabel;
            System.Windows.Forms.Label oKPOLabel;
            System.Windows.Forms.Label oKVEDLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label iNNLabel;
            this.dsAbnDetails1 = new Legal.DataSet.dsAbnDetails();
            this.dateChangeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bankPayerComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankPayeeComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.bankAcntmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameFullTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnParent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.INNmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.OKPOmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.OKVEDmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lemail = new System.Windows.Forms.Label();
            this.btnInnCheck = new System.Windows.Forms.Button();
            nameFullLabel = new System.Windows.Forms.Label();
            dateChangeLabel = new System.Windows.Forms.Label();
            bankPayerLabel = new System.Windows.Forms.Label();
            bankPayeeLabel = new System.Windows.Forms.Label();
            bankAcntLabel = new System.Windows.Forms.Label();
            oKPOLabel = new System.Windows.Forms.Label();
            oKVEDLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDetails1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameFullLabel
            // 
            nameFullLabel.AutoSize = true;
            nameFullLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameFullLabel.Location = new System.Drawing.Point(11, 146);
            nameFullLabel.Name = "nameFullLabel";
            nameFullLabel.Size = new System.Drawing.Size(163, 15);
            nameFullLabel.TabIndex = 3;
            nameFullLabel.Text = "Полное наименование:";
            // 
            // dateChangeLabel
            // 
            dateChangeLabel.AutoSize = true;
            dateChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateChangeLabel.Location = new System.Drawing.Point(85, 477);
            dateChangeLabel.Name = "dateChangeLabel";
            dateChangeLabel.Size = new System.Drawing.Size(85, 15);
            dateChangeLabel.TabIndex = 13;
            dateChangeLabel.Text = "Обновлено:";
            // 
            // bankPayerLabel
            // 
            bankPayerLabel.AutoSize = true;
            bankPayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bankPayerLabel.Location = new System.Drawing.Point(34, 302);
            bankPayerLabel.Name = "bankPayerLabel";
            bankPayerLabel.Size = new System.Drawing.Size(136, 15);
            bankPayerLabel.TabIndex = 14;
            bankPayerLabel.Text = "Банк плательщика:";
            // 
            // bankPayeeLabel
            // 
            bankPayeeLabel.AutoSize = true;
            bankPayeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bankPayeeLabel.Location = new System.Drawing.Point(46, 375);
            bankPayeeLabel.Name = "bankPayeeLabel";
            bankPayeeLabel.Size = new System.Drawing.Size(124, 15);
            bankPayeeLabel.TabIndex = 16;
            bankPayeeLabel.Text = "Банк получателя:";
            // 
            // bankAcntLabel
            // 
            bankAcntLabel.AutoSize = true;
            bankAcntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bankAcntLabel.Location = new System.Drawing.Point(52, 340);
            bankAcntLabel.Name = "bankAcntLabel";
            bankAcntLabel.Size = new System.Drawing.Size(118, 15);
            bankAcntLabel.TabIndex = 18;
            bankAcntLabel.Text = "Расчетный счет:";
            // 
            // oKPOLabel
            // 
            oKPOLabel.AutoSize = true;
            oKPOLabel.BackColor = System.Drawing.SystemColors.Control;
            oKPOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            oKPOLabel.Location = new System.Drawing.Point(582, 217);
            oKPOLabel.Name = "oKPOLabel";
            oKPOLabel.Size = new System.Drawing.Size(50, 15);
            oKPOLabel.TabIndex = 11;
            oKPOLabel.Text = "ОКПО:";
            // 
            // oKVEDLabel
            // 
            oKVEDLabel.AutoSize = true;
            oKVEDLabel.BackColor = System.Drawing.SystemColors.Control;
            oKVEDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            oKVEDLabel.Location = new System.Drawing.Point(112, 252);
            oKVEDLabel.Name = "oKVEDLabel";
            oKVEDLabel.Size = new System.Drawing.Size(58, 15);
            oKVEDLabel.TabIndex = 9;
            oKVEDLabel.Text = "ОКВЭД:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.BackColor = System.Drawing.SystemColors.Control;
            kPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kPPLabel.Location = new System.Drawing.Point(398, 218);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(40, 15);
            kPPLabel.TabIndex = 7;
            kPPLabel.Text = "КПП:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.BackColor = System.Drawing.SystemColors.Control;
            iNNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iNNLabel.Location = new System.Drawing.Point(130, 220);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(41, 15);
            iNNLabel.TabIndex = 5;
            iNNLabel.Text = "ИНН:";
            // 
            // dsAbnDetails1
            // 
            this.dsAbnDetails1.DataSetName = "dsAbnDetails";
            this.dsAbnDetails1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateChangeDateTimePicker
            // 
            this.dateChangeDateTimePicker.Enabled = false;
            this.dateChangeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateChangeDateTimePicker.Location = new System.Drawing.Point(181, 472);
            this.dateChangeDateTimePicker.Name = "dateChangeDateTimePicker";
            this.dateChangeDateTimePicker.Size = new System.Drawing.Size(160, 21);
            this.dateChangeDateTimePicker.TabIndex = 14;
            // 
            // bankPayerComboBox
            // 
            this.bankPayerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAbnDetails1, "tG_AbnInfo.BankID", true));
            this.bankPayerComboBox.DataSource = this.bindingSource1;
            this.bankPayerComboBox.DisplayMember = "NameShort";
            this.bankPayerComboBox.FormattingEnabled = true;
            this.bankPayerComboBox.Location = new System.Drawing.Point(181, 296);
            this.bankPayerComboBox.Name = "bankPayerComboBox";
            this.bankPayerComboBox.Size = new System.Drawing.Size(567, 21);
            this.bankPayerComboBox.TabIndex = 20;
            this.bankPayerComboBox.ValueMember = "BankID";
            this.bankPayerComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bankPayerComboBox_KeyUp);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tBanks";
            this.bindingSource1.DataSource = this.dsAbnDetails1;
            // 
            // bankPayeeComboBox
            // 
            this.bankPayeeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAbnDetails1, "tG_AbnInfo.BankDest", true));
            this.bankPayeeComboBox.DataSource = this.bindingSource2;
            this.bankPayeeComboBox.DisplayMember = "NameShort";
            this.bankPayeeComboBox.FormattingEnabled = true;
            this.bankPayeeComboBox.Location = new System.Drawing.Point(181, 373);
            this.bankPayeeComboBox.Name = "bankPayeeComboBox";
            this.bankPayeeComboBox.Size = new System.Drawing.Size(567, 21);
            this.bankPayeeComboBox.TabIndex = 21;
            this.bankPayeeComboBox.ValueMember = "BankID";
            this.bankPayeeComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bankPayeeComboBox_KeyUp);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "tBanks";
            this.bindingSource2.DataSource = this.dsAbnDetails1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(638, 472);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(511, 472);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 22;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // bankAcntmaskedTextBox
            // 
            this.bankAcntmaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.BankAcnt", true));
            this.bankAcntmaskedTextBox.Location = new System.Drawing.Point(181, 335);
            this.bankAcntmaskedTextBox.Mask = "000 000 000 000 000  000 00";
            this.bankAcntmaskedTextBox.Name = "bankAcntmaskedTextBox";
            this.bankAcntmaskedTextBox.Size = new System.Drawing.Size(224, 20);
            this.bankAcntmaskedTextBox.TabIndex = 22;
            this.bankAcntmaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // nameFullTextBox
            // 
            this.nameFullTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.NameFull", true));
            this.nameFullTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameFullTextBox.Location = new System.Drawing.Point(181, 114);
            this.nameFullTextBox.Name = "nameFullTextBox";
            this.nameFullTextBox.Size = new System.Drawing.Size(569, 80);
            this.nameFullTextBox.TabIndex = 27;
            this.nameFullTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Наименование:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.NameShort", true));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(181, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(567, 80);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // btnParent
            // 
            this.btnParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParent.Location = new System.Drawing.Point(181, 420);
            this.btnParent.Name = "btnParent";
            this.btnParent.Size = new System.Drawing.Size(115, 23);
            this.btnParent.TabIndex = 30;
            this.btnParent.Text = "Новая";
            this.btnParent.UseVisualStyleBackColor = true;
            this.btnParent.Click += new System.EventHandler(this.btnParent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Головная организация:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(315, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // INNmaskedTextBox
            // 
            this.INNmaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.INN", true));
            this.INNmaskedTextBox.Enabled = false;
            this.INNmaskedTextBox.Location = new System.Drawing.Point(181, 217);
            this.INNmaskedTextBox.Mask = "999 999 999 999";
            this.INNmaskedTextBox.Name = "INNmaskedTextBox";
            this.INNmaskedTextBox.Size = new System.Drawing.Size(130, 20);
            this.INNmaskedTextBox.TabIndex = 13;
            this.INNmaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.KPP", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(443, 215);
            this.maskedTextBox1.Mask = "999 999 999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox1.TabIndex = 14;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // OKPOmaskedTextBox
            // 
            this.OKPOmaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.OKPO", true));
            this.OKPOmaskedTextBox.Location = new System.Drawing.Point(638, 215);
            this.OKPOmaskedTextBox.Mask = "999 999 999 9";
            this.OKPOmaskedTextBox.Name = "OKPOmaskedTextBox";
            this.OKPOmaskedTextBox.Size = new System.Drawing.Size(110, 20);
            this.OKPOmaskedTextBox.TabIndex = 15;
            this.OKPOmaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // OKVEDmaskedTextBox
            // 
            this.OKVEDmaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.OKVED", true));
            this.OKVEDmaskedTextBox.Location = new System.Drawing.Point(181, 249);
            this.OKVEDmaskedTextBox.Name = "OKVEDmaskedTextBox";
            this.OKVEDmaskedTextBox.Size = new System.Drawing.Size(130, 20);
            this.OKVEDmaskedTextBox.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.Email", true));
            this.txtEmail.Location = new System.Drawing.Point(395, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(353, 20);
            this.txtEmail.TabIndex = 33;
            // 
            // lemail
            // 
            this.lemail.AutoSize = true;
            this.lemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lemail.Location = new System.Drawing.Point(341, 252);
            this.lemail.Name = "lemail";
            this.lemail.Size = new System.Drawing.Size(49, 13);
            this.lemail.TabIndex = 34;
            this.lemail.Text = "E-mail :";
            // 
            // btnInnCheck
            // 
            this.btnInnCheck.Location = new System.Drawing.Point(317, 215);
            this.btnInnCheck.Name = "btnInnCheck";
            this.btnInnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnInnCheck.TabIndex = 35;
            this.btnInnCheck.Text = "Проверить";
            this.btnInnCheck.UseVisualStyleBackColor = true;
            this.btnInnCheck.Click += new System.EventHandler(this.btnInnCheck_Click);
            // 
            // FormAbnDetails
            // 
            this.ClientSize = new System.Drawing.Size(762, 512);
            this.Controls.Add(this.btnInnCheck);
            this.Controls.Add(this.lemail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankAcntmaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateChangeDateTimePicker);
            this.Controls.Add(this.btnParent);
            this.Controls.Add(this.bankPayeeComboBox);
            this.Controls.Add(this.OKVEDmaskedTextBox);
            this.Controls.Add(dateChangeLabel);
            this.Controls.Add(this.bankPayerComboBox);
            this.Controls.Add(bankAcntLabel);
            this.Controls.Add(this.OKPOmaskedTextBox);
            this.Controls.Add(bankPayeeLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(bankPayerLabel);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.INNmaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.nameFullTextBox);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(oKVEDLabel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(oKPOLabel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(nameFullLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbnDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Платежные реквизиты потребителя";
            this.Load += new System.EventHandler(this.FormAbnDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDetails1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Legal.DataSet.dsAbnDetails dsAbnDetails1;
        private System.Windows.Forms.DateTimePicker dateChangeDateTimePicker;
        private System.Windows.Forms.ComboBox bankPayerComboBox;
        private System.Windows.Forms.ComboBox bankPayeeComboBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.RichTextBox nameFullTextBox;
        private System.Windows.Forms.MaskedTextBox bankAcntmaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnParent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox INNmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox OKPOmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox OKVEDmaskedTextBox;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lemail;
        private System.Windows.Forms.Button btnInnCheck;
    }
}
