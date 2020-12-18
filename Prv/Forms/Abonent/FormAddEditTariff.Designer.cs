namespace Prv.Forms.Abonent
{
    partial class FormAddEditTariff
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTariff = new System.Windows.Forms.Label();
            this.cmbTariff = new System.Windows.Forms.ComboBox();
            this.dsTariff = new Prv.DataSets.DataSetPrv();
            this.dateTimePickerDateTariff = new System.Windows.Forms.DateTimePicker();
            this.labelDateTariff = new System.Windows.Forms.Label();
            this.txtCodeAbonent = new System.Windows.Forms.TextBox();
            this.labelCodeAbonent = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsTariff)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(170, 93);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelTariff
            // 
            this.labelTariff.AutoSize = true;
            this.labelTariff.Location = new System.Drawing.Point(58, 62);
            this.labelTariff.Name = "labelTariff";
            this.labelTariff.Size = new System.Drawing.Size(40, 13);
            this.labelTariff.TabIndex = 20;
            this.labelTariff.Text = "Тариф";
            // 
            // cmbTariff
            // 
            this.cmbTariff.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsTariff, "tTariffReg.idTariff", true));
            this.cmbTariff.DataSource = this.dsTariff;
            this.cmbTariff.DisplayMember = "tR_Classifier.Name";
            this.cmbTariff.FormattingEnabled = true;
            this.cmbTariff.Location = new System.Drawing.Point(104, 59);
            this.cmbTariff.Name = "cmbTariff";
            this.cmbTariff.Size = new System.Drawing.Size(141, 21);
            this.cmbTariff.TabIndex = 21;
            this.cmbTariff.ValueMember = "tR_Classifier.Id";
            // 
            // dsTariff
            // 
            this.dsTariff.DataSetName = "DataSetPrv";
            this.dsTariff.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerDateTariff
            // 
            this.dateTimePickerDateTariff.Checked = false;
            this.dateTimePickerDateTariff.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsTariff, "tTariffReg.SetDate", true));
            this.dateTimePickerDateTariff.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTariff, "tTariffReg.SetDate", true));
            this.dateTimePickerDateTariff.Location = new System.Drawing.Point(104, 32);
            this.dateTimePickerDateTariff.Name = "dateTimePickerDateTariff";
            this.dateTimePickerDateTariff.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerDateTariff.TabIndex = 27;
            // 
            // labelDateTariff
            // 
            this.labelDateTariff.AutoSize = true;
            this.labelDateTariff.Location = new System.Drawing.Point(62, 38);
            this.labelDateTariff.Name = "labelDateTariff";
            this.labelDateTariff.Size = new System.Drawing.Size(36, 13);
            this.labelDateTariff.TabIndex = 26;
            this.labelDateTariff.Text = "Дата:";
            // 
            // txtCodeAbonent
            // 
            this.txtCodeAbonent.Location = new System.Drawing.Point(104, 6);
            this.txtCodeAbonent.Name = "txtCodeAbonent";
            this.txtCodeAbonent.ReadOnly = true;
            this.txtCodeAbonent.Size = new System.Drawing.Size(141, 20);
            this.txtCodeAbonent.TabIndex = 25;
            // 
            // labelCodeAbonent
            // 
            this.labelCodeAbonent.AutoSize = true;
            this.labelCodeAbonent.Location = new System.Drawing.Point(19, 9);
            this.labelCodeAbonent.Name = "labelCodeAbonent";
            this.labelCodeAbonent.Size = new System.Drawing.Size(79, 13);
            this.labelCodeAbonent.TabIndex = 24;
            this.labelCodeAbonent.Text = "Лицевой счет:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 93);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 28;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAddEditTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(259, 127);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelTariff);
            this.Controls.Add(this.cmbTariff);
            this.Controls.Add(this.dateTimePickerDateTariff);
            this.Controls.Add(this.labelDateTariff);
            this.Controls.Add(this.txtCodeAbonent);
            this.Controls.Add(this.labelCodeAbonent);
            this.Name = "FormAddEditTariff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddEditTariff";
            this.Load += new System.EventHandler(this.FormAddEditTariff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTariff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTariff;
        private System.Windows.Forms.ComboBox cmbTariff;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTariff;
        private System.Windows.Forms.Label labelDateTariff;
        private System.Windows.Forms.TextBox txtCodeAbonent;
        private System.Windows.Forms.Label labelCodeAbonent;
        private Prv.DataSets.DataSetPrv dsTariff;
        private System.Windows.Forms.Button buttonOk;
    }
}