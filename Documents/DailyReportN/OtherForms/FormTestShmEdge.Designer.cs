namespace DailyReportN.OtherForms
{
    partial class FormTestShmEdge
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateDoc = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.rtBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата и время заявки";
            // 
            // dtpDateDoc
            // 
            this.dtpDateDoc.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateDoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDoc.Location = new System.Drawing.Point(146, 3);
            this.dtpDateDoc.Name = "dtpDateDoc";
            this.dtpDateDoc.Size = new System.Drawing.Size(144, 20);
            this.dtpDateDoc.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(308, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // rtBox
            // 
            this.rtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtBox.Location = new System.Drawing.Point(1, 32);
            this.rtBox.Name = "rtBox";
            this.rtBox.Size = new System.Drawing.Size(588, 254);
            this.rtBox.TabIndex = 8;
            this.rtBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTestShmEdge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtBox);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateDoc);
            this.Name = "FormTestShmEdge";
            this.Text = "FormTestShmEdge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateDoc;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.RichTextBox rtBox;
        private System.Windows.Forms.Button button1;
    }
}