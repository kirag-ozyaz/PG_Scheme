namespace Legal.Forms
{
    partial class FormAbnSelectSign
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
            this.dtpPrilDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDogDate = new System.Windows.Forms.DateTimePicker();
            this.lbPrilDate = new System.Windows.Forms.Label();
            this.lbDogDate = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbSignature = new System.Windows.Forms.ComboBox();
            this.lbSignature = new System.Windows.Forms.Label();
            this.dsInfo1 = new Legal.DataSet.dsInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfo1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPrilDate
            // 
            this.dtpPrilDate.Location = new System.Drawing.Point(124, 30);
            this.dtpPrilDate.Name = "dtpPrilDate";
            this.dtpPrilDate.Size = new System.Drawing.Size(157, 20);
            this.dtpPrilDate.TabIndex = 0;
            // 
            // dtpDogDate
            // 
            this.dtpDogDate.Location = new System.Drawing.Point(124, 65);
            this.dtpDogDate.Name = "dtpDogDate";
            this.dtpDogDate.Size = new System.Drawing.Size(157, 20);
            this.dtpDogDate.TabIndex = 1;
            // 
            // lbPrilDate
            // 
            this.lbPrilDate.AutoSize = true;
            this.lbPrilDate.Location = new System.Drawing.Point(12, 32);
            this.lbPrilDate.Name = "lbPrilDate";
            this.lbPrilDate.Size = new System.Drawing.Size(98, 13);
            this.lbPrilDate.TabIndex = 2;
            this.lbPrilDate.Text = "Дата приложения";
            // 
            // lbDogDate
            // 
            this.lbDogDate.AutoSize = true;
            this.lbDogDate.Location = new System.Drawing.Point(12, 67);
            this.lbDogDate.Name = "lbDogDate";
            this.lbDogDate.Size = new System.Drawing.Size(83, 13);
            this.lbDogDate.TabIndex = 3;
            this.lbDogDate.Text = "Дата договора";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(195, 137);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbSignature
            // 
            this.cbSignature.FormattingEnabled = true;
            this.cbSignature.Items.AddRange(new object[] {
            "В.В.Вульфсон",
            "И.А.Гулько",
            "С.М.Курбатов",
            "А.К.Абубекяров"});
            this.cbSignature.Location = new System.Drawing.Point(78, 99);
            this.cbSignature.Name = "cbSignature";
            this.cbSignature.Size = new System.Drawing.Size(203, 21);
            this.cbSignature.TabIndex = 5;
            // 
            // lbSignature
            // 
            this.lbSignature.AutoSize = true;
            this.lbSignature.Location = new System.Drawing.Point(12, 102);
            this.lbSignature.Name = "lbSignature";
            this.lbSignature.Size = new System.Drawing.Size(51, 13);
            this.lbSignature.TabIndex = 6;
            this.lbSignature.Text = "Подпись";
            // 
            // dsInfo1
            // 
            this.dsInfo1.DataSetName = "dsInfo";
            this.dsInfo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormAbnSelectSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 172);
            this.Controls.Add(this.lbSignature);
            this.Controls.Add(this.cbSignature);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbDogDate);
            this.Controls.Add(this.lbPrilDate);
            this.Controls.Add(this.dtpDogDate);
            this.Controls.Add(this.dtpPrilDate);
            this.MaximumSize = new System.Drawing.Size(309, 210);
            this.MinimumSize = new System.Drawing.Size(309, 210);
            this.Name = "FormAbnSelectSign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите дату и руководителя";
            this.Load += new System.EventHandler(this.FormAbnSelectSign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsInfo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPrilDate;
        private System.Windows.Forms.DateTimePicker dtpDogDate;
        private System.Windows.Forms.Label lbPrilDate;
        private System.Windows.Forms.Label lbDogDate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cbSignature;
        private System.Windows.Forms.Label lbSignature;
        private Legal.DataSet.dsInfo dsInfo1;
    }
}