namespace Legal
{
    partial class UnloadingGWC
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnloadingGWC));
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.dtOUT = new System.Windows.Forms.DateTimePicker();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dtOutAbnObj = new System.Windows.Forms.DateTimePicker();
            this.btnInfo = new System.Windows.Forms.Button();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.btnOut1 = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnVolume = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPlanVolum = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.btnAnalizAbnObj = new System.Windows.Forms.Button();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.btnAnalizAbn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtLastAnaliz = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtCurrentAnaliz = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(381, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выгрузка группы по работе с потребителями";
            this.label1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(286, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Контактная информация по потребителям (файл 1)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 106);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(227, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Потребление по потребителям (файл 4)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(9, 34);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(273, 17);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Потребление по объектам потребления (файл 3)";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(292, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(155, 17);
            this.progressBar1.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(313, 37);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(136, 17);
            this.progressBar2.TabIndex = 16;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(250, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Плановые объемы по потребителю (файл 5)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(87, 132);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(358, 17);
            this.progressBar3.TabIndex = 13;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(87, 57);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(358, 17);
            this.progressBar5.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Период:";
            // 
            // dtOUT
            // 
            this.dtOUT.CustomFormat = "MMMM yyyy";
            this.dtOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOUT.Location = new System.Drawing.Point(67, 9);
            this.dtOUT.Name = "dtOUT";
            this.dtOUT.Size = new System.Drawing.Size(115, 20);
            this.dtOUT.TabIndex = 8;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 60);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(301, 17);
            this.checkBox6.TabIndex = 17;
            this.checkBox6.Text = "Плановые объемы по объектам потребителя (файл 6)";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // progressBar6
            // 
            this.progressBar6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar6.Location = new System.Drawing.Point(313, 60);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(136, 17);
            this.progressBar6.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 184);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtOutAbnObj);
            this.tabPage1.Controls.Add(this.btnInfo);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.checkBox7);
            this.tabPage1.Controls.Add(this.progressBar7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(453, 158);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Период:";
            // 
            // dtOutAbnObj
            // 
            this.dtOutAbnObj.CustomFormat = "MMMM yyyy";
            this.dtOutAbnObj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutAbnObj.Location = new System.Drawing.Point(67, 34);
            this.dtOutAbnObj.Name = "dtOutAbnObj";
            this.dtOutAbnObj.Size = new System.Drawing.Size(115, 20);
            this.dtOutAbnObj.TabIndex = 14;
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInfo.Location = new System.Drawing.Point(3, 129);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 13;
            this.btnInfo.Text = "Выгрузка";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 59);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(272, 17);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "Информация по объектам потребления (файл 2)";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // progressBar7
            // 
            this.progressBar7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar7.Location = new System.Drawing.Point(292, 61);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(155, 15);
            this.progressBar7.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dtEnd);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dtBegin);
            this.tabPage2.Controls.Add(this.btnOut1);
            this.tabPage2.Controls.Add(this.btnOut);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.progressBar3);
            this.tabPage2.Controls.Add(this.checkBox5);
            this.tabPage2.Controls.Add(this.progressBar5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtOUT);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(453, 158);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Потребление";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(191, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "по:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "MMMM yyyy";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(231, 80);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(95, 20);
            this.dtEnd.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Период с:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtBegin
            // 
            this.dtBegin.CustomFormat = "MMMM yyyy";
            this.dtBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBegin.Location = new System.Drawing.Point(87, 80);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(95, 20);
            this.dtBegin.TabIndex = 17;
            // 
            // btnOut1
            // 
            this.btnOut1.Location = new System.Drawing.Point(6, 55);
            this.btnOut1.Name = "btnOut1";
            this.btnOut1.Size = new System.Drawing.Size(75, 23);
            this.btnOut1.TabIndex = 16;
            this.btnOut1.Text = "Выгрузка";
            this.btnOut1.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(9, 129);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 15;
            this.btnOut.Text = "Выгрузка";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btnVolume);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dtPlanVolum);
            this.tabPage3.Controls.Add(this.progressBar6);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.checkBox6);
            this.tabPage3.Controls.Add(this.progressBar2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(453, 158);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Плановые объемы";
            // 
            // btnVolume
            // 
            this.btnVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolume.Location = new System.Drawing.Point(3, 132);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(75, 23);
            this.btnVolume.TabIndex = 21;
            this.btnVolume.Text = "Выгрузка";
            this.btnVolume.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Период:";
            // 
            // dtPlanVolum
            // 
            this.dtPlanVolum.CustomFormat = "yyyy";
            this.dtPlanVolum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPlanVolum.Location = new System.Drawing.Point(93, 5);
            this.dtPlanVolum.Name = "dtPlanVolum";
            this.dtPlanVolum.Size = new System.Drawing.Size(66, 20);
            this.dtPlanVolum.TabIndex = 19;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBox9);
            this.tabPage4.Controls.Add(this.btnAnalizAbnObj);
            this.tabPage4.Controls.Add(this.checkBox8);
            this.tabPage4.Controls.Add(this.btnAnalizAbn);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.dtLastAnaliz);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.dtCurrentAnaliz);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(453, 158);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Закрытие";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(179, 57);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(204, 17);
            this.checkBox9.TabIndex = 28;
            this.checkBox9.Text = "Анализ по объектам потребителей";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // btnAnalizAbnObj
            // 
            this.btnAnalizAbnObj.Location = new System.Drawing.Point(176, 80);
            this.btnAnalizAbnObj.Name = "btnAnalizAbnObj";
            this.btnAnalizAbnObj.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizAbnObj.TabIndex = 27;
            this.btnAnalizAbnObj.Text = "Выгрузка";
            this.btnAnalizAbnObj.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(9, 57);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(153, 17);
            this.checkBox8.TabIndex = 26;
            this.checkBox8.Text = "Анализ по потребителям";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // btnAnalizAbn
            // 
            this.btnAnalizAbn.Location = new System.Drawing.Point(6, 80);
            this.btnAnalizAbn.Name = "btnAnalizAbn";
            this.btnAnalizAbn.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizAbn.TabIndex = 25;
            this.btnAnalizAbn.Text = "Выгрузка";
            this.btnAnalizAbn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Период прошлый:";
            // 
            // dtLastAnaliz
            // 
            this.dtLastAnaliz.CustomFormat = "MMMM yyyy";
            this.dtLastAnaliz.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLastAnaliz.Location = new System.Drawing.Point(136, 34);
            this.dtLastAnaliz.Name = "dtLastAnaliz";
            this.dtLastAnaliz.Size = new System.Drawing.Size(115, 20);
            this.dtLastAnaliz.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Период текущий:";
            // 
            // dtCurrentAnaliz
            // 
            this.dtCurrentAnaliz.CustomFormat = "MMMM yyyy";
            this.dtCurrentAnaliz.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCurrentAnaliz.Location = new System.Drawing.Point(136, 8);
            this.dtCurrentAnaliz.Name = "dtCurrentAnaliz";
            this.dtCurrentAnaliz.Size = new System.Drawing.Size(115, 20);
            this.dtCurrentAnaliz.TabIndex = 21;
            // 
            // UnloadingGWC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 250);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UnloadingGWC";
            this.Text = "Выгрузка группы по работе с потребителями";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtOUT;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPlanVolum;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Button btnOut1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtOutAbnObj;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Button btnAnalizAbnObj;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Button btnAnalizAbn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtLastAnaliz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtCurrentAnaliz;
    }
}

