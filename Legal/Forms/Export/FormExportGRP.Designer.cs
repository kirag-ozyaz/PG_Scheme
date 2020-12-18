namespace Legal.Forms.Export
{
    partial class FormExportGRP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtInfo = new System.Windows.Forms.DateTimePicker();
            this.btnObj = new System.Windows.Forms.Button();
            this.btnAbn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTransEnd = new System.Windows.Forms.DateTimePicker();
            this.dtTransBegin = new System.Windows.Forms.DateTimePicker();
            this.btnObjTrans = new System.Windows.Forms.Button();
            this.btnAbnTrans = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtVolume = new System.Windows.Forms.DateTimePicker();
            this.btnObjVolume = new System.Windows.Forms.Button();
            this.btnAbnVolume = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtInfo);
            this.groupBox1.Controls.Add(this.btnObj);
            this.groupBox1.Controls.Add(this.btnAbn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Договорная информация";
            // 
            // dtInfo
            // 
            this.dtInfo.CustomFormat = "MMMM yyyy";
            this.dtInfo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInfo.Location = new System.Drawing.Point(56, 32);
            this.dtInfo.Name = "dtInfo";
            this.dtInfo.Size = new System.Drawing.Size(129, 20);
            this.dtInfo.TabIndex = 2;
            // 
            // btnObj
            // 
            this.btnObj.Location = new System.Drawing.Point(239, 48);
            this.btnObj.Name = "btnObj";
            this.btnObj.Size = new System.Drawing.Size(111, 23);
            this.btnObj.TabIndex = 1;
            this.btnObj.Text = "Объекты";
            this.btnObj.UseVisualStyleBackColor = true;
            this.btnObj.Click += new System.EventHandler(this.btnObj_Click);
            // 
            // btnAbn
            // 
            this.btnAbn.Location = new System.Drawing.Point(239, 19);
            this.btnAbn.Name = "btnAbn";
            this.btnAbn.Size = new System.Drawing.Size(111, 23);
            this.btnAbn.TabIndex = 0;
            this.btnAbn.Text = "Потребители";
            this.btnAbn.UseVisualStyleBackColor = true;
            this.btnAbn.Click += new System.EventHandler(this.btnAbn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtTransEnd);
            this.groupBox2.Controls.Add(this.dtTransBegin);
            this.groupBox2.Controls.Add(this.btnObjTrans);
            this.groupBox2.Controls.Add(this.btnAbnTrans);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Передача электроэнергии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "с";
            // 
            // dtTransEnd
            // 
            this.dtTransEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTransEnd.Location = new System.Drawing.Point(57, 49);
            this.dtTransEnd.Name = "dtTransEnd";
            this.dtTransEnd.Size = new System.Drawing.Size(128, 20);
            this.dtTransEnd.TabIndex = 3;
            // 
            // dtTransBegin
            // 
            this.dtTransBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTransBegin.Location = new System.Drawing.Point(56, 19);
            this.dtTransBegin.Name = "dtTransBegin";
            this.dtTransBegin.Size = new System.Drawing.Size(129, 20);
            this.dtTransBegin.TabIndex = 2;
            // 
            // btnObjTrans
            // 
            this.btnObjTrans.Location = new System.Drawing.Point(239, 48);
            this.btnObjTrans.Name = "btnObjTrans";
            this.btnObjTrans.Size = new System.Drawing.Size(111, 23);
            this.btnObjTrans.TabIndex = 1;
            this.btnObjTrans.Text = "Объекты";
            this.btnObjTrans.UseVisualStyleBackColor = true;
            this.btnObjTrans.Click += new System.EventHandler(this.btnObjTrans_Click);
            // 
            // btnAbnTrans
            // 
            this.btnAbnTrans.Location = new System.Drawing.Point(239, 19);
            this.btnAbnTrans.Name = "btnAbnTrans";
            this.btnAbnTrans.Size = new System.Drawing.Size(111, 23);
            this.btnAbnTrans.TabIndex = 0;
            this.btnAbnTrans.Text = "Потребители";
            this.btnAbnTrans.UseVisualStyleBackColor = true;
            this.btnAbnTrans.Click += new System.EventHandler(this.btnAbnTrans_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtVolume);
            this.groupBox3.Controls.Add(this.btnObjVolume);
            this.groupBox3.Controls.Add(this.btnAbnVolume);
            this.groupBox3.Location = new System.Drawing.Point(12, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Плановые объемы";
            // 
            // dtVolume
            // 
            this.dtVolume.CustomFormat = "yyyy";
            this.dtVolume.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVolume.Location = new System.Drawing.Point(57, 37);
            this.dtVolume.Name = "dtVolume";
            this.dtVolume.Size = new System.Drawing.Size(128, 20);
            this.dtVolume.TabIndex = 2;
            // 
            // btnObjVolume
            // 
            this.btnObjVolume.Location = new System.Drawing.Point(239, 48);
            this.btnObjVolume.Name = "btnObjVolume";
            this.btnObjVolume.Size = new System.Drawing.Size(111, 23);
            this.btnObjVolume.TabIndex = 1;
            this.btnObjVolume.Text = "Объекты";
            this.btnObjVolume.UseVisualStyleBackColor = true;
            this.btnObjVolume.Click += new System.EventHandler(this.btnObjVolume_Click);
            // 
            // btnAbnVolume
            // 
            this.btnAbnVolume.Location = new System.Drawing.Point(239, 19);
            this.btnAbnVolume.Name = "btnAbnVolume";
            this.btnAbnVolume.Size = new System.Drawing.Size(111, 23);
            this.btnAbnVolume.TabIndex = 0;
            this.btnAbnVolume.Text = "Потребители";
            this.btnAbnVolume.UseVisualStyleBackColor = true;
            this.btnAbnVolume.Click += new System.EventHandler(this.btnAbnVolume_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(175, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormExportGRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(396, 303);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormExportGRP";
            this.Text = "Выгрузка группы по работе с потребителями ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAbn;
        private System.Windows.Forms.Button btnObj;
        private System.Windows.Forms.DateTimePicker dtInfo;
        private System.Windows.Forms.Button btnObjTrans;
        private System.Windows.Forms.Button btnAbnTrans;
        private System.Windows.Forms.Button btnObjVolume;
        private System.Windows.Forms.Button btnAbnVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTransEnd;
        private System.Windows.Forms.DateTimePicker dtTransBegin;
        private System.Windows.Forms.DateTimePicker dtVolume;
        private System.Windows.Forms.Button btnCancel;
    }
}