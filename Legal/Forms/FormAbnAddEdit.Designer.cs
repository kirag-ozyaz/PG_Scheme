namespace Legal.Forms
{
    partial class FormAbnAddEdit
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
            System.Windows.Forms.Label codeAbonentLabel;
            System.Windows.Forms.Label nameLabel;
            this.dsAbnAddEdit1 = new Legal.DataSet.dsAbnAddEdit();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.richTextBoxName = new System.Windows.Forms.RichTextBox();
            this.cmbTypeAbn = new System.Windows.Forms.ComboBox();
            this.labelTypeAbn = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.MaskedTextBox();
            this.btnFindCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeAbnStr = new System.Windows.Forms.TextBox();
            codeAbonentLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnAddEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // codeAbonentLabel
            // 
            codeAbonentLabel.AutoSize = true;
            codeAbonentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            codeAbonentLabel.Location = new System.Drawing.Point(12, 24);
            codeAbonentLabel.Name = "codeAbonentLabel";
            codeAbonentLabel.Size = new System.Drawing.Size(37, 17);
            codeAbonentLabel.TabIndex = 0;
            codeAbonentLabel.Text = "Код:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(13, 89);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(110, 17);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Наименование:";
            // 
            // dsAbnAddEdit1
            // 
            this.dsAbnAddEdit1.DataSetName = "dsAbnAddEdit";
            this.dsAbnAddEdit1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(95, 312);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(201, 312);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Специалист:";
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAbnAddEdit1, "tAbn.idWorker", true));
            this.comboBoxWorker.DataSource = this.dsAbnAddEdit1;
            this.comboBoxWorker.DisplayMember = "vG_Contrl.F";
            this.comboBoxWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(102, 211);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(199, 24);
            this.comboBoxWorker.TabIndex = 8;
            this.comboBoxWorker.ValueMember = "vG_Contrl.id";
            // 
            // richTextBoxName
            // 
            this.richTextBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnAddEdit1, "tAbn.Name", true));
            this.richTextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxName.Location = new System.Drawing.Point(15, 116);
            this.richTextBoxName.Name = "richTextBoxName";
            this.richTextBoxName.Size = new System.Drawing.Size(286, 81);
            this.richTextBoxName.TabIndex = 9;
            this.richTextBoxName.Text = "";
            // 
            // cmbTypeAbn
            // 
            this.cmbTypeAbn.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAbnAddEdit1, "tAbn.TypeAbn", true));
            this.cmbTypeAbn.DataSource = this.dsAbnAddEdit1;
            this.cmbTypeAbn.DisplayMember = "tR_Classifier.Name";
            this.cmbTypeAbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTypeAbn.FormattingEnabled = true;
            this.cmbTypeAbn.Location = new System.Drawing.Point(55, 62);
            this.cmbTypeAbn.Name = "cmbTypeAbn";
            this.cmbTypeAbn.Size = new System.Drawing.Size(246, 24);
            this.cmbTypeAbn.TabIndex = 10;
            this.cmbTypeAbn.ValueMember = "tR_Classifier.Id";
            // 
            // labelTypeAbn
            // 
            this.labelTypeAbn.AutoSize = true;
            this.labelTypeAbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeAbn.Location = new System.Drawing.Point(13, 62);
            this.labelTypeAbn.Name = "labelTypeAbn";
            this.labelTypeAbn.Size = new System.Drawing.Size(37, 17);
            this.labelTypeAbn.TabIndex = 11;
            this.labelTypeAbn.Text = "Тип:";
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnAddEdit1, "tAbn.CodeAbonent", true));
            this.txtCode.Location = new System.Drawing.Point(55, 23);
            this.txtCode.Mask = "00000";
            this.txtCode.Name = "txtCode";
            this.txtCode.PromptChar = ' ';
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 13;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // btnFindCode
            // 
            this.btnFindCode.Location = new System.Drawing.Point(161, 21);
            this.btnFindCode.Name = "btnFindCode";
            this.btnFindCode.Size = new System.Drawing.Size(75, 23);
            this.btnFindCode.TabIndex = 14;
            this.btnFindCode.Text = "Подбор";
            this.btnFindCode.UseVisualStyleBackColor = true;
            this.btnFindCode.Click += new System.EventHandler(this.btnFindCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Дополнительный код:";
            // 
            // txtCodeAbnStr
            // 
            this.txtCodeAbnStr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnAddEdit1, "tAbn.CodeAbnStr", true));
            this.txtCodeAbnStr.Location = new System.Drawing.Point(18, 273);
            this.txtCodeAbnStr.Name = "txtCodeAbnStr";
            this.txtCodeAbnStr.Size = new System.Drawing.Size(283, 20);
            this.txtCodeAbnStr.TabIndex = 16;
            // 
            // FormAbnAddEdit
            // 
            this.ClientSize = new System.Drawing.Size(319, 355);
            this.Controls.Add(this.txtCodeAbnStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFindCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelTypeAbn);
            this.Controls.Add(this.cmbTypeAbn);
            this.Controls.Add(this.richTextBoxName);
            this.Controls.Add(this.comboBoxWorker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(nameLabel);
            this.Controls.Add(codeAbonentLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbnAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAbnAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnAddEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Legal.DataSet.dsAbnAddEdit dsAbnAddEdit1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.RichTextBox richTextBoxName;
        private System.Windows.Forms.ComboBox cmbTypeAbn;
        private System.Windows.Forms.Label labelTypeAbn;
        private System.Windows.Forms.MaskedTextBox txtCode;
        private System.Windows.Forms.Button btnFindCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeAbnStr;
    }
}
