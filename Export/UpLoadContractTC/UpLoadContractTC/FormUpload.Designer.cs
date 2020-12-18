namespace UpLoadContractTC
{
    partial class FormUpload
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
            this.btnUploadContraktTC = new System.Windows.Forms.Button();
            this.btnUploadAktTC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUplosdYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUploadContraktTC
            // 
            this.btnUploadContraktTC.Location = new System.Drawing.Point(105, 29);
            this.btnUploadContraktTC.Name = "btnUploadContraktTC";
            this.btnUploadContraktTC.Size = new System.Drawing.Size(75, 23);
            this.btnUploadContraktTC.TabIndex = 0;
            this.btnUploadContraktTC.Text = "...";
            this.btnUploadContraktTC.UseVisualStyleBackColor = true;
            this.btnUploadContraktTC.Click += new System.EventHandler(this.btnUploadContraktTC_Click);
            // 
            // btnUploadAktTC
            // 
            this.btnUploadAktTC.Location = new System.Drawing.Point(105, 59);
            this.btnUploadAktTC.Name = "btnUploadAktTC";
            this.btnUploadAktTC.Size = new System.Drawing.Size(75, 23);
            this.btnUploadAktTC.TabIndex = 1;
            this.btnUploadAktTC.Text = "...";
            this.btnUploadAktTC.UseVisualStyleBackColor = true;
            this.btnUploadAktTC.Click += new System.EventHandler(this.btnUploadAktTC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Договора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Акты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год выгрузки";
            // 
            // cmbUplosdYear
            // 
            this.cmbUplosdYear.FormattingEnabled = true;
            this.cmbUplosdYear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.cmbUplosdYear.Location = new System.Drawing.Point(108, 3);
            this.cmbUplosdYear.Name = "cmbUplosdYear";
            this.cmbUplosdYear.Size = new System.Drawing.Size(101, 21);
            this.cmbUplosdYear.TabIndex = 5;
            // 
            // FormUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 100);
            this.Controls.Add(this.cmbUplosdYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUploadAktTC);
            this.Controls.Add(this.btnUploadContraktTC);
            this.Name = "FormUpload";
            this.Text = "Выгрузка";
            this.Load += new System.EventHandler(this.FormUpload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadContraktTC;
        private System.Windows.Forms.Button btnUploadAktTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUplosdYear;
    }
}