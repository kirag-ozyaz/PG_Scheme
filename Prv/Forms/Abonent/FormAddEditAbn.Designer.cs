namespace Prv.Forms.Abonent
{
    partial class FormAddEditAbn
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
            this.labelTypeAbn = new System.Windows.Forms.Label();
            this.cmbTypeAbn = new System.Windows.Forms.ComboBox();
            this.dsAbn = new Prv.DataSets.DataSetPrv();
            this.bindingSourceTypeAbn = new System.Windows.Forms.BindingSource(this.components);
            this.labelCodeAbonent = new System.Windows.Forms.Label();
            this.txtCodeAbonent = new System.Windows.Forms.TextBox();
            this.Фамилия = new System.Windows.Forms.Label();
            this.labelDateBeg = new System.Windows.Forms.Label();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.bindingSourceActive = new System.Windows.Forms.BindingSource(this.components);
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOtchestvo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelControler = new System.Windows.Forms.Label();
            this.cmbControler = new System.Windows.Forms.ComboBox();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.labelReason = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new ControlsLbr.NullableDateTimePicker();
            this.bindingSourceNoActive = new System.Windows.Forms.BindingSource(this.components);
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.bindingSourceReason = new System.Windows.Forms.BindingSource(this.components);
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.cbNotLive = new System.Windows.Forms.CheckBox();
            this.dtpNotLive = new System.Windows.Forms.DateTimePicker();
            this.labelDopCode = new System.Windows.Forms.Label();
            this.textBoxDopCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypeAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNoActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReason)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTypeAbn
            // 
            this.labelTypeAbn.AutoSize = true;
            this.labelTypeAbn.Location = new System.Drawing.Point(148, 9);
            this.labelTypeAbn.Name = "labelTypeAbn";
            this.labelTypeAbn.Size = new System.Drawing.Size(76, 13);
            this.labelTypeAbn.TabIndex = 2;
            this.labelTypeAbn.Text = "Тип абонента";
            // 
            // cmbTypeAbn
            // 
            this.cmbTypeAbn.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAbn, "tAbn.TypeAbn", true));
            this.cmbTypeAbn.DataSource = this.bindingSourceTypeAbn;
            this.cmbTypeAbn.DisplayMember = "Name";
            this.cmbTypeAbn.FormattingEnabled = true;
            this.cmbTypeAbn.Location = new System.Drawing.Point(151, 25);
            this.cmbTypeAbn.Name = "cmbTypeAbn";
            this.cmbTypeAbn.Size = new System.Drawing.Size(130, 21);
            this.cmbTypeAbn.TabIndex = 3;
            this.cmbTypeAbn.ValueMember = "Id";
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetPrv";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceTypeAbn
            // 
            this.bindingSourceTypeAbn.DataMember = "tR_Classifier";
            this.bindingSourceTypeAbn.DataSource = this.dsAbn;
            this.bindingSourceTypeAbn.Filter = "ParentKey = \';SKUEE;TypeAbn;\'";
            // 
            // labelCodeAbonent
            // 
            this.labelCodeAbonent.AutoSize = true;
            this.labelCodeAbonent.Location = new System.Drawing.Point(12, 9);
            this.labelCodeAbonent.Name = "labelCodeAbonent";
            this.labelCodeAbonent.Size = new System.Drawing.Size(76, 13);
            this.labelCodeAbonent.TabIndex = 0;
            this.labelCodeAbonent.Text = "Код абонента";
            // 
            // txtCodeAbonent
            // 
            this.txtCodeAbonent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbn.CodeAbonent", true));
            this.txtCodeAbonent.Location = new System.Drawing.Point(15, 25);
            this.txtCodeAbonent.Name = "txtCodeAbonent";
            this.txtCodeAbonent.Size = new System.Drawing.Size(130, 20);
            this.txtCodeAbonent.TabIndex = 1;
            // 
            // Фамилия
            // 
            this.Фамилия.AutoSize = true;
            this.Фамилия.Location = new System.Drawing.Point(14, 139);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(56, 13);
            this.Фамилия.TabIndex = 12;
            this.Фамилия.Text = "Фамилия";
            // 
            // labelDateBeg
            // 
            this.labelDateBeg.AutoSize = true;
            this.labelDateBeg.Location = new System.Drawing.Point(14, 88);
            this.labelDateBeg.Name = "labelDateBeg";
            this.labelDateBeg.Size = new System.Drawing.Size(71, 13);
            this.labelDateBeg.TabIndex = 6;
            this.labelDateBeg.Text = "Дата начала";
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceActive, "DateChange", true));
            this.dateTimePickerBegin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActive, "DateChange", true));
            this.dateTimePickerBegin.Location = new System.Drawing.Point(17, 104);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerBegin.TabIndex = 7;
            // 
            // bindingSourceActive
            // 
            this.bindingSourceActive.DataMember = "tAbnStatus";
            this.bindingSourceActive.DataSource = this.dsAbn;
            this.bindingSourceActive.Filter = "IsActive = true";
            // 
            // txtFamily
            // 
            this.txtFamily.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbnContact.F", true));
            this.txtFamily.Location = new System.Drawing.Point(17, 155);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(130, 20);
            this.txtFamily.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbnContact.I", true));
            this.txtName.Location = new System.Drawing.Point(153, 155);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Имя";
            // 
            // txtOtchestvo
            // 
            this.txtOtchestvo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbnContact.O", true));
            this.txtOtchestvo.Location = new System.Drawing.Point(297, 155);
            this.txtOtchestvo.Name = "txtOtchestvo";
            this.txtOtchestvo.Size = new System.Drawing.Size(130, 20);
            this.txtOtchestvo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Отчество";
            // 
            // labelControler
            // 
            this.labelControler.AutoSize = true;
            this.labelControler.Location = new System.Drawing.Point(292, 9);
            this.labelControler.Name = "labelControler";
            this.labelControler.Size = new System.Drawing.Size(61, 13);
            this.labelControler.TabIndex = 4;
            this.labelControler.Text = "Контролер";
            // 
            // cmbControler
            // 
            this.cmbControler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbControler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbControler.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAbn, "tAbn.idWorker", true));
            this.cmbControler.DataSource = this.dsAbn;
            this.cmbControler.DisplayMember = "vWorkerGroup.FIO";
            this.cmbControler.FormattingEnabled = true;
            this.cmbControler.Location = new System.Drawing.Point(295, 25);
            this.cmbControler.Name = "cmbControler";
            this.cmbControler.Size = new System.Drawing.Size(130, 21);
            this.cmbControler.TabIndex = 5;
            this.cmbControler.ValueMember = "vWorkerGroup.id";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(153, 88);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(89, 13);
            this.labelDateEnd.TabIndex = 8;
            this.labelDateEnd.Text = "Дата окончания";
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(294, 88);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(50, 13);
            this.labelReason.TabIndex = 10;
            this.labelReason.Text = "Причина";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceNoActive, "DateChange", true));
            this.dateTimePickerEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNoActive, "DateChange", true));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(153, 104);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerEnd.TabIndex = 9;
            this.dateTimePickerEnd.Value = new System.DateTime(2010, 11, 15, 13, 57, 14, 428);
            // 
            // bindingSourceNoActive
            // 
            this.bindingSourceNoActive.DataMember = "tAbnStatus";
            this.bindingSourceNoActive.DataSource = this.dsAbn;
            this.bindingSourceNoActive.Filter = "IsActive = false";
            // 
            // cmbReason
            // 
            this.cmbReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReason.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceNoActive, "idReason", true));
            this.cmbReason.DataSource = this.bindingSourceReason;
            this.cmbReason.DisplayMember = "Name";
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new System.Drawing.Point(297, 104);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(130, 21);
            this.cmbReason.TabIndex = 11;
            this.cmbReason.ValueMember = "Id";
            // 
            // bindingSourceReason
            // 
            this.bindingSourceReason.DataMember = "tR_Classifier";
            this.bindingSourceReason.DataSource = this.dsAbn;
            this.bindingSourceReason.Filter = "ParentKey = \';SKUEE;ReasonStatus;ReasonAbnFL;\'";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(15, 188);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 18;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(350, 188);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // cbNotLive
            // 
            this.cbNotLive.AutoSize = true;
            this.cbNotLive.Location = new System.Drawing.Point(110, 191);
            this.cbNotLive.Name = "cbNotLive";
            this.cbNotLive.Size = new System.Drawing.Size(89, 17);
            this.cbNotLive.TabIndex = 20;
            this.cbNotLive.Text = "Нет допуска";
            this.cbNotLive.UseVisualStyleBackColor = true;
            this.cbNotLive.CheckedChanged += new System.EventHandler(this.cbNotLive_CheckedChanged);
            // 
            // dtpNotLive
            // 
            this.dtpNotLive.Location = new System.Drawing.Point(205, 191);
            this.dtpNotLive.Name = "dtpNotLive";
            this.dtpNotLive.Size = new System.Drawing.Size(137, 20);
            this.dtpNotLive.TabIndex = 21;
            // 
            // labelDopCode
            // 
            this.labelDopCode.AutoSize = true;
            this.labelDopCode.Location = new System.Drawing.Point(14, 59);
            this.labelDopCode.Name = "labelDopCode";
            this.labelDopCode.Size = new System.Drawing.Size(116, 13);
            this.labelDopCode.TabIndex = 22;
            this.labelDopCode.Text = "Дополнительный код";
            // 
            // textBoxDopCode
            // 
            this.textBoxDopCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbn.CodeAbnStr", true));
            this.textBoxDopCode.Location = new System.Drawing.Point(151, 56);
            this.textBoxDopCode.Name = "textBoxDopCode";
            this.textBoxDopCode.Size = new System.Drawing.Size(274, 20);
            this.textBoxDopCode.TabIndex = 23;
            // 
            // FormAddEditAbn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(440, 223);
            this.Controls.Add(this.textBoxDopCode);
            this.Controls.Add(this.labelDopCode);
            this.Controls.Add(this.dtpNotLive);
            this.Controls.Add(this.cbNotLive);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.cmbReason);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.cmbControler);
            this.Controls.Add(this.labelControler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOtchestvo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.dateTimePickerBegin);
            this.Controls.Add(this.labelDateBeg);
            this.Controls.Add(this.Фамилия);
            this.Controls.Add(this.txtCodeAbonent);
            this.Controls.Add(this.labelCodeAbonent);
            this.Controls.Add(this.cmbTypeAbn);
            this.Controls.Add(this.labelTypeAbn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEditAbn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddEditAbn";
            this.Load += new System.EventHandler(this.FormAddEditAbn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypeAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNoActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeAbn;
        private System.Windows.Forms.ComboBox cmbTypeAbn;
        private System.Windows.Forms.Label labelCodeAbonent;
        private System.Windows.Forms.TextBox txtCodeAbonent;
        private System.Windows.Forms.Label Фамилия;
        private System.Windows.Forms.Label labelDateBeg;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOtchestvo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelControler;
        private System.Windows.Forms.ComboBox cmbControler;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Label labelReason;
        private ControlsLbr.NullableDateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private Prv.DataSets.DataSetPrv dsAbn;
        private System.Windows.Forms.BindingSource bindingSourceTypeAbn;
        private System.Windows.Forms.BindingSource bindingSourceReason;
        private System.Windows.Forms.BindingSource bindingSourceActive;
        private System.Windows.Forms.BindingSource bindingSourceNoActive;
        private System.Windows.Forms.CheckBox cbNotLive;
        private System.Windows.Forms.DateTimePicker dtpNotLive;
        private System.Windows.Forms.Label labelDopCode;
        private System.Windows.Forms.TextBox textBoxDopCode;
    }
}