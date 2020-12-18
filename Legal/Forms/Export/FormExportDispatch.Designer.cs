namespace Legal.Forms.Export
{
    partial class FormExportDispatch
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtWinterEnd = new System.Windows.Forms.DateTimePicker();
            this.dtWinterBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtSummerEnd = new System.Windows.Forms.DateTimePicker();
            this.dtSummerBegin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "с";
            // 
            // dtWinterEnd
            // 
            this.dtWinterEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtWinterEnd.Location = new System.Drawing.Point(42, 59);
            this.dtWinterEnd.Name = "dtWinterEnd";
            this.dtWinterEnd.Size = new System.Drawing.Size(128, 20);
            this.dtWinterEnd.TabIndex = 7;
            // 
            // dtWinterBegin
            // 
            this.dtWinterBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtWinterBegin.Location = new System.Drawing.Point(41, 29);
            this.dtWinterBegin.Name = "dtWinterBegin";
            this.dtWinterBegin.Size = new System.Drawing.Size(129, 20);
            this.dtWinterBegin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "по";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "с";
            // 
            // dtSummerEnd
            // 
            this.dtSummerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSummerEnd.Location = new System.Drawing.Point(42, 61);
            this.dtSummerEnd.Name = "dtSummerEnd";
            this.dtSummerEnd.Size = new System.Drawing.Size(128, 20);
            this.dtSummerEnd.TabIndex = 11;
            // 
            // dtSummerBegin
            // 
            this.dtSummerBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSummerBegin.Location = new System.Drawing.Point(41, 31);
            this.dtSummerBegin.Name = "dtSummerBegin";
            this.dtSummerBegin.Size = new System.Drawing.Size(129, 20);
            this.dtSummerBegin.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Рассчитывать передачу электроэнергии за:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtWinterBegin);
            this.groupBox1.Controls.Add(this.dtWinterEnd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "зимние месяцы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtSummerBegin);
            this.groupBox2.Controls.Add(this.dtSummerEnd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(237, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "летние месяцы";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(140, 169);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "Выполнить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Отказаться";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormExportDispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "FormExportDispatch";
            this.Text = "Выгрузка для диспетчерской";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtWinterEnd;
        private System.Windows.Forms.DateTimePicker dtWinterBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtSummerEnd;
        private System.Windows.Forms.DateTimePicker dtSummerBegin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}