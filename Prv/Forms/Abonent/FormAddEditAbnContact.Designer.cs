namespace Prv.Forms.Abonent
{
    partial class FormAddEditAbnContact
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
            this.labelCodeAbonent = new System.Windows.Forms.Label();
            this.txtCodeAbonent = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOtchestvo = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOtchestvo = new System.Windows.Forms.Label();
            this.richTextBoxPhone = new System.Windows.Forms.RichTextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.dateTimePickerDateChange = new System.Windows.Forms.DateTimePicker();
            this.labelDateChange = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dsAbnContact = new Prv.DataSets.DataSetPrv();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnContact)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodeAbonent
            // 
            this.labelCodeAbonent.AutoSize = true;
            this.labelCodeAbonent.Location = new System.Drawing.Point(24, 9);
            this.labelCodeAbonent.Name = "labelCodeAbonent";
            this.labelCodeAbonent.Size = new System.Drawing.Size(76, 13);
            this.labelCodeAbonent.TabIndex = 12;
            this.labelCodeAbonent.Text = "Лицевой счет";
            // 
            // txtCodeAbonent
            // 
            this.txtCodeAbonent.Location = new System.Drawing.Point(106, 6);
            this.txtCodeAbonent.Name = "txtCodeAbonent";
            this.txtCodeAbonent.ReadOnly = true;
            this.txtCodeAbonent.Size = new System.Drawing.Size(166, 20);
            this.txtCodeAbonent.TabIndex = 13;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(44, 61);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(56, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Фамилия";
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnContact, "tAbnContact.F", true));
            this.txtFirstName.Location = new System.Drawing.Point(106, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(166, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnContact, "tAbnContact.I", true));
            this.txtName.Location = new System.Drawing.Point(106, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtOtchestvo
            // 
            this.txtOtchestvo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnContact, "tAbnContact.O", true));
            this.txtOtchestvo.Location = new System.Drawing.Point(106, 110);
            this.txtOtchestvo.Name = "txtOtchestvo";
            this.txtOtchestvo.Size = new System.Drawing.Size(166, 20);
            this.txtOtchestvo.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(71, 87);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // labelOtchestvo
            // 
            this.labelOtchestvo.AutoSize = true;
            this.labelOtchestvo.Location = new System.Drawing.Point(46, 113);
            this.labelOtchestvo.Name = "labelOtchestvo";
            this.labelOtchestvo.Size = new System.Drawing.Size(54, 13);
            this.labelOtchestvo.TabIndex = 4;
            this.labelOtchestvo.Text = "Отчество";
            // 
            // richTextBoxPhone
            // 
            this.richTextBoxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnContact, "tAbnContact.Phone", true));
            this.richTextBoxPhone.Location = new System.Drawing.Point(106, 136);
            this.richTextBoxPhone.Name = "richTextBoxPhone";
            this.richTextBoxPhone.Size = new System.Drawing.Size(166, 45);
            this.richTextBoxPhone.TabIndex = 7;
            this.richTextBoxPhone.Text = "";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(40, 139);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(60, 13);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Телефоны";
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnContact, "tAbnContact.Comment", true));
            this.richTextBoxComment.Location = new System.Drawing.Point(106, 187);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(166, 52);
            this.richTextBoxComment.TabIndex = 9;
            this.richTextBoxComment.Text = "";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(23, 190);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(77, 13);
            this.labelComment.TabIndex = 8;
            this.labelComment.Text = "Комментарий";
            // 
            // dateTimePickerDateChange
            // 
            this.dateTimePickerDateChange.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsAbnContact, "tAbnContact.DateChange", true));
            this.dateTimePickerDateChange.Location = new System.Drawing.Point(106, 32);
            this.dateTimePickerDateChange.Name = "dateTimePickerDateChange";
            this.dateTimePickerDateChange.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerDateChange.TabIndex = 15;
            // 
            // labelDateChange
            // 
            this.labelDateChange.AutoSize = true;
            this.labelDateChange.Location = new System.Drawing.Point(65, 38);
            this.labelDateChange.Name = "labelDateChange";
            this.labelDateChange.Size = new System.Drawing.Size(33, 13);
            this.labelDateChange.TabIndex = 14;
            this.labelDateChange.Text = "Дата";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 251);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(197, 251);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dsAbnContact
            // 
            this.dsAbnContact.DataSetName = "DataSetPrv";
            this.dsAbnContact.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormAddEditAbnContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 283);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelDateChange);
            this.Controls.Add(this.dateTimePickerDateChange);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.richTextBoxPhone);
            this.Controls.Add(this.labelOtchestvo);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtOtchestvo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.txtCodeAbonent);
            this.Controls.Add(this.labelCodeAbonent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEditAbnContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddEditAbnContact";
            this.Load += new System.EventHandler(this.FormAddEditAbnContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodeAbonent;
        private System.Windows.Forms.TextBox txtCodeAbonent;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOtchestvo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOtchestvo;
        private System.Windows.Forms.RichTextBox richTextBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateChange;
        private System.Windows.Forms.Label labelDateChange;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private Prv.DataSets.DataSetPrv dsAbnContact;
    }
}