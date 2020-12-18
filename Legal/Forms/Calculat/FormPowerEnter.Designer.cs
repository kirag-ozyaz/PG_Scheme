namespace Legal.Forms.Calculat
{
    partial class FormPowerEnter
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbEnter = new ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty.TextBoxNumeric();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegime = new ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty.TextBoxNumeric();
            this.tbCalc = new ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty.TextBoxNumeric();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPower = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(58, 175);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Добавить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(192, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbEnter
            // 
            this.tbEnter.Location = new System.Drawing.Point(109, 138);
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(100, 20);
            this.tbEnter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Установленная мощность(кВт)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Режим работы(час/мес)";
            // 
            // tbRegime
            // 
            this.tbRegime.Location = new System.Drawing.Point(188, 34);
            this.tbRegime.Name = "tbRegime";
            this.tbRegime.Size = new System.Drawing.Size(100, 20);
            this.tbRegime.TabIndex = 6;
            // 
            // tbCalc
            // 
            this.tbCalc.Location = new System.Drawing.Point(97, 80);
            this.tbCalc.Name = "tbCalc";
            this.tbCalc.Size = new System.Drawing.Size(100, 20);
            this.tbCalc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Расчетное начисление(кВт*час)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPower);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCalc);
            this.groupBox1.Controls.Add(this.tbRegime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 107);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Расчет ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Текущее начисление";
            // 
            // tbPower
            // 
            this.tbPower.ForeColor = System.Drawing.Color.Blue;
            this.tbPower.Location = new System.Drawing.Point(7, 34);
            this.tbPower.Name = "tbPower";
            this.tbPower.Size = new System.Drawing.Size(100, 20);
            this.tbPower.TabIndex = 9;
            this.tbPower.Text = "0";
            this.tbPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormPowerEnter
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(344, 213);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbEnter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "FormPowerEnter";
            this.Text = "Ввод начисления по мощности";
            this.Load += new System.EventHandler(this.FormPowerEnter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty.TextBoxNumeric tbEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty.TextBoxNumeric tbRegime;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty.TextBoxNumeric tbCalc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPower;
    }
}
