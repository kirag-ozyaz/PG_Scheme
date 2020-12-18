namespace Legal.Forms
{
    partial class FormCntValEnter
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
            this.btnCansel = new System.Windows.Forms.Button();
            this.tbEnter = new ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty.TextBoxNumeric();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(238, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 25);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Добавить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCansel.Location = new System.Drawing.Point(238, 55);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(83, 25);
            this.btnCansel.TabIndex = 2;
            this.btnCansel.Text = "Отменить";
            this.btnCansel.UseVisualStyleBackColor = true;
            // 
            // tbEnter
            // 
            this.tbEnter.Location = new System.Drawing.Point(37, 36);
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(100, 20);
            this.tbEnter.TabIndex = 0;
            // 
            // FormCntValEnter
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCansel;
            this.ClientSize = new System.Drawing.Size(374, 100);
            this.Controls.Add(this.tbEnter);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnOK);
            this.Name = "FormCntValEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ввод начисления вручную";
            this.Load += new System.EventHandler(this.FormCntValEnter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCansel;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty.TextBoxNumeric tbEnter;
    }
}
