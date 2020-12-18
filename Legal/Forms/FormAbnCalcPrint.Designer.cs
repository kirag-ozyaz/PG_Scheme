namespace Legal.Forms
{
    partial class FormAbnCalcPrint
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
            this.components = new System.ComponentModel.Container();
            this.dsCntVal1 = new Legal.DataSet.dsCntVal();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NumSchet = new System.Windows.Forms.TextBox();
            this.dt_Schet = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DelSchet = new System.Windows.Forms.Button();
            this.btn_OpenSchet = new System.Windows.Forms.Button();
            this.btn_AddSchet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_OpenAct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_Act = new System.Windows.Forms.DateTimePicker();
            this.tb_NumAct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_OpenInv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_Inv = new System.Windows.Forms.DateTimePicker();
            this.tb_NumInv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_DelFact = new System.Windows.Forms.Button();
            this.btn_OpenFact = new System.Windows.Forms.Button();
            this.btn_AddFact = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_Fact = new System.Windows.Forms.DateTimePicker();
            this.tb_NumFact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tGSchetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tGSchetValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_DelReq = new System.Windows.Forms.Button();
            this.btn_OpenReq = new System.Windows.Forms.Button();
            this.btn_AddReq = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_Req = new System.Windows.Forms.DateTimePicker();
            this.tb_NumReq = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_DelFact_Correct = new System.Windows.Forms.Button();
            this.btn_OpenFact_Correct = new System.Windows.Forms.Button();
            this.btn_AddFact_Correct = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dt_Fact_Correct = new System.Windows.Forms.DateTimePicker();
            this.tb_NumFact_Correct = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tGSchetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGSchetValueBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsCntVal1
            // 
            this.dsCntVal1.DataSetName = "dsCntVal";
            this.dsCntVal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // tb_NumSchet
            // 
            this.tb_NumSchet.Location = new System.Drawing.Point(76, 30);
            this.tb_NumSchet.Name = "tb_NumSchet";
            this.tb_NumSchet.Size = new System.Drawing.Size(100, 20);
            this.tb_NumSchet.TabIndex = 4;
            // 
            // dt_Schet
            // 
            this.dt_Schet.Location = new System.Drawing.Point(218, 30);
            this.dt_Schet.Name = "dt_Schet";
            this.dt_Schet.Size = new System.Drawing.Size(136, 20);
            this.dt_Schet.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_DelSchet);
            this.groupBox1.Controls.Add(this.btn_OpenSchet);
            this.groupBox1.Controls.Add(this.btn_AddSchet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dt_Schet);
            this.groupBox1.Controls.Add(this.tb_NumSchet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 95);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Счет к оплате";
            // 
            // btn_DelSchet
            // 
            this.btn_DelSchet.Location = new System.Drawing.Point(262, 65);
            this.btn_DelSchet.Name = "btn_DelSchet";
            this.btn_DelSchet.Size = new System.Drawing.Size(75, 23);
            this.btn_DelSchet.TabIndex = 12;
            this.btn_DelSchet.Text = "Удалить";
            this.btn_DelSchet.UseVisualStyleBackColor = true;
            this.btn_DelSchet.Click += new System.EventHandler(this.btn_DelSchet_Click);
            // 
            // btn_OpenSchet
            // 
            this.btn_OpenSchet.Location = new System.Drawing.Point(169, 65);
            this.btn_OpenSchet.Name = "btn_OpenSchet";
            this.btn_OpenSchet.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenSchet.TabIndex = 11;
            this.btn_OpenSchet.Text = "Открыть";
            this.btn_OpenSchet.UseVisualStyleBackColor = true;
            this.btn_OpenSchet.Click += new System.EventHandler(this.btn_OpenSchet_Click);
            // 
            // btn_AddSchet
            // 
            this.btn_AddSchet.Location = new System.Drawing.Point(76, 65);
            this.btn_AddSchet.Name = "btn_AddSchet";
            this.btn_AddSchet.Size = new System.Drawing.Size(75, 23);
            this.btn_AddSchet.TabIndex = 10;
            this.btn_AddSchet.Text = "Создать";
            this.btn_AddSchet.UseVisualStyleBackColor = true;
            this.btn_AddSchet.Click += new System.EventHandler(this.btn_AddSchet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "от";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_OpenAct);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dt_Act);
            this.groupBox2.Controls.Add(this.tb_NumAct);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(29, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 95);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Акт оказания услуг";
            // 
            // btn_OpenAct
            // 
            this.btn_OpenAct.Location = new System.Drawing.Point(169, 66);
            this.btn_OpenAct.Name = "btn_OpenAct";
            this.btn_OpenAct.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenAct.TabIndex = 11;
            this.btn_OpenAct.Text = "Открыть";
            this.btn_OpenAct.UseVisualStyleBackColor = true;
            this.btn_OpenAct.Click += new System.EventHandler(this.btn_OpenAct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "от";
            // 
            // dt_Act
            // 
            this.dt_Act.Location = new System.Drawing.Point(218, 31);
            this.dt_Act.Name = "dt_Act";
            this.dt_Act.Size = new System.Drawing.Size(136, 20);
            this.dt_Act.TabIndex = 8;
            // 
            // tb_NumAct
            // 
            this.tb_NumAct.Location = new System.Drawing.Point(76, 31);
            this.tb_NumAct.Name = "tb_NumAct";
            this.tb_NumAct.Size = new System.Drawing.Size(100, 20);
            this.tb_NumAct.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Номер";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_OpenInv);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dt_Inv);
            this.groupBox3.Controls.Add(this.tb_NumInv);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(29, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 95);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Накладная на отпуск";
            // 
            // btn_OpenInv
            // 
            this.btn_OpenInv.Location = new System.Drawing.Point(169, 66);
            this.btn_OpenInv.Name = "btn_OpenInv";
            this.btn_OpenInv.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenInv.TabIndex = 11;
            this.btn_OpenInv.Text = "Открыть";
            this.btn_OpenInv.UseVisualStyleBackColor = true;
            this.btn_OpenInv.Click += new System.EventHandler(this.btn_OpenInv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "от";
            // 
            // dt_Inv
            // 
            this.dt_Inv.Location = new System.Drawing.Point(218, 31);
            this.dt_Inv.Name = "dt_Inv";
            this.dt_Inv.Size = new System.Drawing.Size(136, 20);
            this.dt_Inv.TabIndex = 8;
            // 
            // tb_NumInv
            // 
            this.tb_NumInv.Location = new System.Drawing.Point(76, 31);
            this.tb_NumInv.Name = "tb_NumInv";
            this.tb_NumInv.Size = new System.Drawing.Size(100, 20);
            this.tb_NumInv.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номер";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_DelFact);
            this.groupBox4.Controls.Add(this.btn_OpenFact);
            this.groupBox4.Controls.Add(this.btn_AddFact);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dt_Fact);
            this.groupBox4.Controls.Add(this.tb_NumFact);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(29, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 95);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Счет - фактура";
            // 
            // btn_DelFact
            // 
            this.btn_DelFact.Location = new System.Drawing.Point(262, 66);
            this.btn_DelFact.Name = "btn_DelFact";
            this.btn_DelFact.Size = new System.Drawing.Size(75, 23);
            this.btn_DelFact.TabIndex = 12;
            this.btn_DelFact.Text = "Удалить";
            this.btn_DelFact.UseVisualStyleBackColor = true;
            this.btn_DelFact.Click += new System.EventHandler(this.btn_DelFact_Click);
            // 
            // btn_OpenFact
            // 
            this.btn_OpenFact.Location = new System.Drawing.Point(169, 66);
            this.btn_OpenFact.Name = "btn_OpenFact";
            this.btn_OpenFact.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenFact.TabIndex = 11;
            this.btn_OpenFact.Text = "Открыть";
            this.btn_OpenFact.UseVisualStyleBackColor = true;
            this.btn_OpenFact.Click += new System.EventHandler(this.btn_OpenFact_Click);
            // 
            // btn_AddFact
            // 
            this.btn_AddFact.Location = new System.Drawing.Point(76, 66);
            this.btn_AddFact.Name = "btn_AddFact";
            this.btn_AddFact.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFact.TabIndex = 10;
            this.btn_AddFact.Text = "Создать";
            this.btn_AddFact.UseVisualStyleBackColor = true;
            this.btn_AddFact.Click += new System.EventHandler(this.btn_AddFact_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "от";
            // 
            // dt_Fact
            // 
            this.dt_Fact.Location = new System.Drawing.Point(218, 31);
            this.dt_Fact.Name = "dt_Fact";
            this.dt_Fact.Size = new System.Drawing.Size(136, 20);
            this.dt_Fact.TabIndex = 8;
            // 
            // tb_NumFact
            // 
            this.tb_NumFact.Location = new System.Drawing.Point(76, 31);
            this.tb_NumFact.Name = "tb_NumFact";
            this.tb_NumFact.Size = new System.Drawing.Size(100, 20);
            this.tb_NumFact.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Номер";
            // 
            // tGSchetBindingSource
            // 
            this.tGSchetBindingSource.DataMember = "tG_Schet";
            this.tGSchetBindingSource.DataSource = this.dsCntVal1;
            // 
            // tGSchetValueBindingSource
            // 
            this.tGSchetValueBindingSource.DataMember = "tG_SchetValue";
            this.tGSchetValueBindingSource.DataSource = this.dsCntVal1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_DelReq);
            this.groupBox5.Controls.Add(this.btn_OpenReq);
            this.groupBox5.Controls.Add(this.btn_AddReq);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.dt_Req);
            this.groupBox5.Controls.Add(this.tb_NumReq);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(29, 386);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(401, 95);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Платежное требование";
            // 
            // btn_DelReq
            // 
            this.btn_DelReq.Location = new System.Drawing.Point(262, 63);
            this.btn_DelReq.Name = "btn_DelReq";
            this.btn_DelReq.Size = new System.Drawing.Size(75, 23);
            this.btn_DelReq.TabIndex = 19;
            this.btn_DelReq.Text = "Удалить";
            this.btn_DelReq.UseVisualStyleBackColor = true;
            this.btn_DelReq.Click += new System.EventHandler(this.btn_DelReq_Click);
            // 
            // btn_OpenReq
            // 
            this.btn_OpenReq.Location = new System.Drawing.Point(169, 63);
            this.btn_OpenReq.Name = "btn_OpenReq";
            this.btn_OpenReq.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenReq.TabIndex = 18;
            this.btn_OpenReq.Text = "Открыть";
            this.btn_OpenReq.UseVisualStyleBackColor = true;
            this.btn_OpenReq.Click += new System.EventHandler(this.btn_OpenReq_Click);
            // 
            // btn_AddReq
            // 
            this.btn_AddReq.Location = new System.Drawing.Point(76, 63);
            this.btn_AddReq.Name = "btn_AddReq";
            this.btn_AddReq.Size = new System.Drawing.Size(75, 23);
            this.btn_AddReq.TabIndex = 17;
            this.btn_AddReq.Text = "Создать";
            this.btn_AddReq.UseVisualStyleBackColor = true;
            this.btn_AddReq.Click += new System.EventHandler(this.btn_AddReq_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "от";
            // 
            // dt_Req
            // 
            this.dt_Req.Location = new System.Drawing.Point(218, 27);
            this.dt_Req.Name = "dt_Req";
            this.dt_Req.Size = new System.Drawing.Size(136, 20);
            this.dt_Req.TabIndex = 15;
            // 
            // tb_NumReq
            // 
            this.tb_NumReq.Location = new System.Drawing.Point(76, 28);
            this.tb_NumReq.Name = "tb_NumReq";
            this.tb_NumReq.Size = new System.Drawing.Size(100, 20);
            this.tb_NumReq.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Номер";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_DelFact_Correct);
            this.groupBox6.Controls.Add(this.btn_OpenFact_Correct);
            this.groupBox6.Controls.Add(this.btn_AddFact_Correct);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.dt_Fact_Correct);
            this.groupBox6.Controls.Add(this.tb_NumFact_Correct);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(29, 481);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(401, 95);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Счет - фактура корректировочный";
            // 
            // btn_DelFact_Correct
            // 
            this.btn_DelFact_Correct.Location = new System.Drawing.Point(262, 66);
            this.btn_DelFact_Correct.Name = "btn_DelFact_Correct";
            this.btn_DelFact_Correct.Size = new System.Drawing.Size(75, 23);
            this.btn_DelFact_Correct.TabIndex = 12;
            this.btn_DelFact_Correct.Text = "Удалить";
            this.btn_DelFact_Correct.UseVisualStyleBackColor = true;
            this.btn_DelFact_Correct.Click += new System.EventHandler(this.btn_DelFact_Correct_Click);
            // 
            // btn_OpenFact_Correct
            // 
            this.btn_OpenFact_Correct.Location = new System.Drawing.Point(169, 66);
            this.btn_OpenFact_Correct.Name = "btn_OpenFact_Correct";
            this.btn_OpenFact_Correct.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenFact_Correct.TabIndex = 11;
            this.btn_OpenFact_Correct.Text = "Открыть";
            this.btn_OpenFact_Correct.UseVisualStyleBackColor = true;
            this.btn_OpenFact_Correct.Click += new System.EventHandler(this.btn_OpenFact_Correct_Click);
            // 
            // btn_AddFact_Correct
            // 
            this.btn_AddFact_Correct.Location = new System.Drawing.Point(76, 66);
            this.btn_AddFact_Correct.Name = "btn_AddFact_Correct";
            this.btn_AddFact_Correct.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFact_Correct.TabIndex = 10;
            this.btn_AddFact_Correct.Text = "Создать";
            this.btn_AddFact_Correct.UseVisualStyleBackColor = true;
            this.btn_AddFact_Correct.Click += new System.EventHandler(this.btn_AddFact_Correct_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "от";
            // 
            // dt_Fact_Correct
            // 
            this.dt_Fact_Correct.Location = new System.Drawing.Point(218, 31);
            this.dt_Fact_Correct.Name = "dt_Fact_Correct";
            this.dt_Fact_Correct.Size = new System.Drawing.Size(136, 20);
            this.dt_Fact_Correct.TabIndex = 8;
            // 
            // tb_NumFact_Correct
            // 
            this.tb_NumFact_Correct.Location = new System.Drawing.Point(76, 31);
            this.tb_NumFact_Correct.Name = "tb_NumFact_Correct";
            this.tb_NumFact_Correct.Size = new System.Drawing.Size(100, 20);
            this.tb_NumFact_Correct.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Номер";
            // 
            // FormAbnCalcPrint
            // 
            this.ClientSize = new System.Drawing.Size(462, 586);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAbnCalcPrint";
            this.Text = "Платежные документы";
            this.Load += new System.EventHandler(this.FormAbnCalcPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tGSchetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGSchetValueBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet.dsCntVal dsCntVal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NumSchet;
        private System.Windows.Forms.DateTimePicker dt_Schet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DelSchet;
        private System.Windows.Forms.Button btn_OpenSchet;
        private System.Windows.Forms.Button btn_AddSchet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_OpenAct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_Act;
        private System.Windows.Forms.TextBox tb_NumAct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_OpenInv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_Inv;
        private System.Windows.Forms.TextBox tb_NumInv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_DelFact;
        private System.Windows.Forms.Button btn_OpenFact;
        private System.Windows.Forms.Button btn_AddFact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_Fact;
        private System.Windows.Forms.TextBox tb_NumFact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource tGSchetBindingSource;
        private System.Windows.Forms.BindingSource tGSchetValueBindingSource;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_DelReq;
        private System.Windows.Forms.Button btn_OpenReq;
        private System.Windows.Forms.Button btn_AddReq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_Req;
        private System.Windows.Forms.TextBox tb_NumReq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_DelFact_Correct;
        private System.Windows.Forms.Button btn_OpenFact_Correct;
        private System.Windows.Forms.Button btn_AddFact_Correct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dt_Fact_Correct;
        private System.Windows.Forms.TextBox tb_NumFact_Correct;
        private System.Windows.Forms.Label label12;
    }
}
