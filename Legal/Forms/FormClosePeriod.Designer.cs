namespace Legal.Forms
{
    partial class FormClosePeriod
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
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnNoLock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dsCntVal1 = new Legal.DataSet.dsCntVal();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(24, 60);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(150, 20);
            this.dtBegin.TabIndex = 0;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(222, 60);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(150, 20);
            this.dtEnd.TabIndex = 1;
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(99, 99);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 2;
            this.btnLock.Text = "Закрыть";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnNoLock
            // 
            this.btnNoLock.Location = new System.Drawing.Point(207, 99);
            this.btnNoLock.Name = "btnNoLock";
            this.btnNoLock.Size = new System.Drawing.Size(75, 23);
            this.btnNoLock.TabIndex = 3;
            this.btnNoLock.Text = "Открыть";
            this.btnNoLock.UseVisualStyleBackColor = true;
            this.btnNoLock.Click += new System.EventHandler(this.btnNoLock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "по";
            // 
            // dsCntVal1
            // 
            this.dsCntVal1.DataSetName = "dsCntVal";
            this.dsCntVal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.Color.Blue;
            this.richTextBox1.Location = new System.Drawing.Point(5, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(367, 42);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "При закрытии периода становится недоступным ввод данных и редактирование в нем пл" +
    "атежныз документов";
            // 
            // FormClosePeriod
            // 
            this.ClientSize = new System.Drawing.Size(386, 137);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNoLock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtBegin);
            this.Name = "FormClosePeriod";
            this.Text = "Закрыть(открыть) период";
            this.Load += new System.EventHandler(this.FormClosePeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnNoLock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataSet.dsCntVal dsCntVal1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
