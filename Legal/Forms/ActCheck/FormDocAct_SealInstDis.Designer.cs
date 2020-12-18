namespace Legal.Forms.ActCheck
{
    partial class FormDocAct_SealInstDis
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
            this.dtpDateInst = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSealType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSealNumber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSealLocation = new System.Windows.Forms.TextBox();
            this.tbSealComment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dsAbnObjAkt1 = new Legal.DataSet.dsAbnObjAct();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnObjAkt1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateInst
            // 
            this.dtpDateInst.Location = new System.Drawing.Point(260, 22);
            this.dtpDateInst.Name = "dtpDateInst";
            this.dtpDateInst.Size = new System.Drawing.Size(178, 20);
            this.dtpDateInst.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата";
            // 
            // cbWorker
            // 
            this.cbWorker.BackColor = System.Drawing.Color.White;
            this.cbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(64, 22);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(146, 21);
            this.cbWorker.TabIndex = 5;
            this.cbWorker.SelectedIndexChanged += new System.EventHandler(this.cbWorker_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Мастер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип пломбы";
            // 
            // cbSealType
            // 
            this.cbSealType.BackColor = System.Drawing.Color.White;
            this.cbSealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSealType.FormattingEnabled = true;
            this.cbSealType.Location = new System.Drawing.Point(89, 49);
            this.cbSealType.Name = "cbSealType";
            this.cbSealType.Size = new System.Drawing.Size(121, 21);
            this.cbSealType.TabIndex = 9;
            this.cbSealType.SelectedIndexChanged += new System.EventHandler(this.cbSealType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Серия и номер";
            // 
            // cbSealNumber
            // 
            this.cbSealNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSealNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSealNumber.BackColor = System.Drawing.Color.White;
            this.cbSealNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSealNumber.FormattingEnabled = true;
            this.cbSealNumber.Location = new System.Drawing.Point(309, 48);
            this.cbSealNumber.Name = "cbSealNumber";
            this.cbSealNumber.Size = new System.Drawing.Size(129, 21);
            this.cbSealNumber.TabIndex = 11;
            this.cbSealNumber.SelectedIndexChanged += new System.EventHandler(this.cbSealNumber_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Место расположения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Комментарий";
            // 
            // tbSealLocation
            // 
            this.tbSealLocation.Location = new System.Drawing.Point(132, 76);
            this.tbSealLocation.Name = "tbSealLocation";
            this.tbSealLocation.Size = new System.Drawing.Size(306, 20);
            this.tbSealLocation.TabIndex = 14;
            // 
            // tbSealComment
            // 
            this.tbSealComment.Location = new System.Drawing.Point(96, 102);
            this.tbSealComment.Multiline = true;
            this.tbSealComment.Name = "tbSealComment";
            this.tbSealComment.Size = new System.Drawing.Size(342, 42);
            this.tbSealComment.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(260, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(363, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dsAbnObjAkt1
            // 
            this.dsAbnObjAkt1.DataSetName = "dsAbnObjAkt";
            this.dsAbnObjAkt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormDocAct_SealInstDis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 182);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbSealComment);
            this.Controls.Add(this.tbSealLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSealNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSealType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateInst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbWorker);
            this.Controls.Add(this.label1);
            this.Name = "FormDocAct_SealInstDis";
            this.Text = "Добавление пломбы";
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnObjAkt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateInst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSealType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSealNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSealLocation;
        private System.Windows.Forms.TextBox tbSealComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private DataSet.dsAbnObjAct dsAbnObjAkt1;

    }
}