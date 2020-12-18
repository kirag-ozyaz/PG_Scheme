namespace ASCAPC
{
    partial class ControlFiderN
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDC_XML_CODE = new System.Windows.Forms.TextBox();
            this.IDC_CALC_FACTOR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDC_NAME = new System.Windows.Forms.TextBox();
            this.IDC_CODE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MTRTYPE = new System.Windows.Forms.GroupBox();
            this.IDC_REACT = new System.Windows.Forms.RadioButton();
            this.IDC_ACT = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.MTRTYPE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.IDC_XML_CODE);
            this.groupBox1.Controls.Add(this.IDC_CALC_FACTOR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.IDC_NAME);
            this.groupBox1.Controls.Add(this.IDC_CODE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MTRTYPE);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(4, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фидер";
            // 
            // IDC_XML_CODE
            // 
            this.IDC_XML_CODE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDC_XML_CODE.Location = new System.Drawing.Point(95, 187);
            this.IDC_XML_CODE.Name = "IDC_XML_CODE";
            this.IDC_XML_CODE.Size = new System.Drawing.Size(118, 20);
            this.IDC_XML_CODE.TabIndex = 8;
            this.IDC_XML_CODE.TextChanged += new System.EventHandler(this.IDC_XML_CODE_TextChanged);
            this.IDC_XML_CODE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDC_XML_CODE_KeyPress);
            // 
            // IDC_CALC_FACTOR
            // 
            this.IDC_CALC_FACTOR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDC_CALC_FACTOR.Location = new System.Drawing.Point(96, 161);
            this.IDC_CALC_FACTOR.Name = "IDC_CALC_FACTOR";
            this.IDC_CALC_FACTOR.Size = new System.Drawing.Size(70, 20);
            this.IDC_CALC_FACTOR.TabIndex = 7;
            this.IDC_CALC_FACTOR.TextChanged += new System.EventHandler(this.IDC_CALC_FACTOR_TextChanged);
            this.IDC_CALC_FACTOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDC_CALC_FACTOR_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Код XML 80020";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Множитель";
            // 
            // IDC_NAME
            // 
            this.IDC_NAME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDC_NAME.Location = new System.Drawing.Point(96, 46);
            this.IDC_NAME.Name = "IDC_NAME";
            this.IDC_NAME.Size = new System.Drawing.Size(118, 20);
            this.IDC_NAME.TabIndex = 4;
            this.IDC_NAME.TextChanged += new System.EventHandler(this.IDC_NAME_TextChanged);
            // 
            // IDC_CODE
            // 
            this.IDC_CODE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDC_CODE.Location = new System.Drawing.Point(96, 20);
            this.IDC_CODE.Name = "IDC_CODE";
            this.IDC_CODE.Size = new System.Drawing.Size(70, 20);
            this.IDC_CODE.TabIndex = 3;
            this.IDC_CODE.TextChanged += new System.EventHandler(this.IDC_CODE_TextChanged);
            this.IDC_CODE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDC_CODE_KeyPress);
            this.IDC_CODE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IDC_CODE_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код";
            // 
            // MTRTYPE
            // 
            this.MTRTYPE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MTRTYPE.Controls.Add(this.IDC_REACT);
            this.MTRTYPE.Controls.Add(this.IDC_ACT);
            this.MTRTYPE.Location = new System.Drawing.Point(6, 72);
            this.MTRTYPE.Name = "MTRTYPE";
            this.MTRTYPE.Size = new System.Drawing.Size(222, 73);
            this.MTRTYPE.TabIndex = 0;
            this.MTRTYPE.TabStop = false;
            this.MTRTYPE.Text = "Измерительный канал";
            // 
            // IDC_REACT
            // 
            this.IDC_REACT.AutoSize = true;
            this.IDC_REACT.Location = new System.Drawing.Point(22, 43);
            this.IDC_REACT.Name = "IDC_REACT";
            this.IDC_REACT.Size = new System.Drawing.Size(85, 17);
            this.IDC_REACT.TabIndex = 1;
            this.IDC_REACT.TabStop = true;
            this.IDC_REACT.Text = "Реактивная";
            this.IDC_REACT.UseVisualStyleBackColor = true;
            this.IDC_REACT.CheckedChanged += new System.EventHandler(this.IDC_REACT_CheckedChanged);
            // 
            // IDC_ACT
            // 
            this.IDC_ACT.AutoSize = true;
            this.IDC_ACT.Location = new System.Drawing.Point(22, 19);
            this.IDC_ACT.Name = "IDC_ACT";
            this.IDC_ACT.Size = new System.Drawing.Size(75, 17);
            this.IDC_ACT.TabIndex = 0;
            this.IDC_ACT.TabStop = true;
            this.IDC_ACT.Text = "Активный";
            this.IDC_ACT.UseVisualStyleBackColor = true;
            this.IDC_ACT.CheckedChanged += new System.EventHandler(this.IDC_ACT_CheckedChanged);
            // 
            // ControlFiderN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ControlFiderN";
            this.Size = new System.Drawing.Size(241, 211);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MTRTYPE.ResumeLayout(false);
            this.MTRTYPE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox MTRTYPE;
        public System.Windows.Forms.TextBox IDC_XML_CODE;
        public System.Windows.Forms.TextBox IDC_CALC_FACTOR;
        public System.Windows.Forms.TextBox IDC_NAME;
        public System.Windows.Forms.TextBox IDC_CODE;
        public System.Windows.Forms.RadioButton IDC_REACT;
        public System.Windows.Forms.RadioButton IDC_ACT;
    }
}
