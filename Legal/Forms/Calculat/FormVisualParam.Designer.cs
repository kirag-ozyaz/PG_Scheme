namespace Legal.Forms.Calculat
{
    partial class FormVisualParam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPercentMinus = new System.Windows.Forms.MaskedTextBox();
            this.tbPercentPlus = new System.Windows.Forms.MaskedTextBox();
            this.tbCountMonth = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(94, 210);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(190, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Допустимый процент отклонения расхода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество предшествующих месяцев для проверки";
            // 
            // tbPercentMinus
            // 
            this.tbPercentMinus.ForeColor = System.Drawing.Color.Blue;
            this.tbPercentMinus.Location = new System.Drawing.Point(154, 45);
            this.tbPercentMinus.Name = "tbPercentMinus";
            this.tbPercentMinus.Size = new System.Drawing.Size(100, 20);
            this.tbPercentMinus.TabIndex = 4;
            this.tbPercentMinus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPercentPlus
            // 
            this.tbPercentPlus.ForeColor = System.Drawing.Color.Blue;
            this.tbPercentPlus.Location = new System.Drawing.Point(154, 77);
            this.tbPercentPlus.Name = "tbPercentPlus";
            this.tbPercentPlus.Size = new System.Drawing.Size(100, 20);
            this.tbPercentPlus.TabIndex = 5;
            this.tbPercentPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCountMonth
            // 
            this.tbCountMonth.ForeColor = System.Drawing.Color.Blue;
            this.tbCountMonth.Location = new System.Drawing.Point(20, 151);
            this.tbCountMonth.Name = "tbCountMonth";
            this.tbCountMonth.Size = new System.Drawing.Size(100, 20);
            this.tbCountMonth.TabIndex = 6;
            this.tbCountMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "в меньшую сторону";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "в большую сторону";
            // 
            // FormVisualParam
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(361, 245);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCountMonth);
            this.Controls.Add(this.tbPercentPlus);
            this.Controls.Add(this.tbPercentMinus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "FormVisualParam";
            this.Text = "Параметры визуального контроля";
            this.Load += new System.EventHandler(this.FormVisualParam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbPercentMinus;
        private System.Windows.Forms.MaskedTextBox tbPercentPlus;
        private System.Windows.Forms.MaskedTextBox tbCountMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}
