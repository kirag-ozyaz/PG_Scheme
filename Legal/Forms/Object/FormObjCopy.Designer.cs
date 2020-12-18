namespace Legal.Forms.Object
{
    partial class FormObjCopy
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
            this.txtAbnName = new System.Windows.Forms.TextBox();
            this.btnAbnName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxMinus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtAbnName
            // 
            this.txtAbnName.Location = new System.Drawing.Point(90, 37);
            this.txtAbnName.Name = "txtAbnName";
            this.txtAbnName.ReadOnly = true;
            this.txtAbnName.ShortcutsEnabled = false;
            this.txtAbnName.Size = new System.Drawing.Size(377, 20);
            this.txtAbnName.TabIndex = 0;
            // 
            // btnAbnName
            // 
            this.btnAbnName.Location = new System.Drawing.Point(473, 35);
            this.btnAbnName.Name = "btnAbnName";
            this.btnAbnName.Size = new System.Drawing.Size(75, 23);
            this.btnAbnName.TabIndex = 1;
            this.btnAbnName.Text = "Выбор";
            this.btnAbnName.UseVisualStyleBackColor = true;
            this.btnAbnName.Click += new System.EventHandler(this.btnAbnName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Абонент - назначение:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 37);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(72, 20);
            this.txtCode.TabIndex = 3;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(377, 115);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Копировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(473, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxMinus
            // 
            this.cbxMinus.AutoSize = true;
            this.cbxMinus.Location = new System.Drawing.Point(21, 84);
            this.cbxMinus.Name = "cbxMinus";
            this.cbxMinus.Size = new System.Drawing.Size(307, 17);
            this.cbxMinus.TabIndex = 6;
            this.cbxMinus.Text = "Копировать в минусующий объект с нулевым тарифом";
            this.cbxMinus.UseVisualStyleBackColor = true;
            // 
            // FormObjCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(560, 152);
            this.ControlBox = false;
            this.Controls.Add(this.cbxMinus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbnName);
            this.Controls.Add(this.txtAbnName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormObjCopy";
            this.Text = "Копирование объекта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAbnName;
        private System.Windows.Forms.Button btnAbnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbxMinus;
    }
}