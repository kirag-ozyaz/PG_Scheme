namespace ReferenceWorker
{
	public partial class FormWorkerAddEditPadez : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.btnCopy = new System.Windows.Forms.Button();
            this.t_OTextBox = new System.Windows.Forms.TextBox();
            this.t_ITextBox = new System.Windows.Forms.TextBox();
            this.t_FTextBox = new System.Windows.Forms.TextBox();
            this.d_OTextBox = new System.Windows.Forms.TextBox();
            this.d_ITextBox = new System.Windows.Forms.TextBox();
            this.d_FTextBox = new System.Windows.Forms.TextBox();
            this.r_OTextBox = new System.Windows.Forms.TextBox();
            this.r_ITextBox = new System.Windows.Forms.TextBox();
            this.r_FTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.i_OTextBox = new System.Windows.Forms.TextBox();
            this.i_ITextBox = new System.Windows.Forms.TextBox();
            this.i_FTextBox = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataSetWorker = new ReferenceWorker.DataSetWorker();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Location = new System.Drawing.Point(391, 111);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(110, 23);
            this.btnCopy.TabIndex = 77;
            this.btnCopy.Text = "Копировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // t_OTextBox
            // 
            this.t_OTextBox.Location = new System.Drawing.Point(101, 374);
            this.t_OTextBox.Name = "t_OTextBox";
            this.t_OTextBox.Size = new System.Drawing.Size(400, 20);
            this.t_OTextBox.TabIndex = 76;
            // 
            // t_ITextBox
            // 
            this.t_ITextBox.Location = new System.Drawing.Point(101, 348);
            this.t_ITextBox.Name = "t_ITextBox";
            this.t_ITextBox.Size = new System.Drawing.Size(400, 20);
            this.t_ITextBox.TabIndex = 74;
            // 
            // t_FTextBox
            // 
            this.t_FTextBox.Location = new System.Drawing.Point(101, 322);
            this.t_FTextBox.Name = "t_FTextBox";
            this.t_FTextBox.Size = new System.Drawing.Size(400, 20);
            this.t_FTextBox.TabIndex = 72;
            // 
            // d_OTextBox
            // 
            this.d_OTextBox.Location = new System.Drawing.Point(101, 279);
            this.d_OTextBox.Name = "d_OTextBox";
            this.d_OTextBox.Size = new System.Drawing.Size(400, 20);
            this.d_OTextBox.TabIndex = 70;
            // 
            // d_ITextBox
            // 
            this.d_ITextBox.Location = new System.Drawing.Point(101, 253);
            this.d_ITextBox.Name = "d_ITextBox";
            this.d_ITextBox.Size = new System.Drawing.Size(400, 20);
            this.d_ITextBox.TabIndex = 68;
            // 
            // d_FTextBox
            // 
            this.d_FTextBox.Location = new System.Drawing.Point(101, 227);
            this.d_FTextBox.Name = "d_FTextBox";
            this.d_FTextBox.Size = new System.Drawing.Size(400, 20);
            this.d_FTextBox.TabIndex = 66;
            // 
            // r_OTextBox
            // 
            this.r_OTextBox.Location = new System.Drawing.Point(101, 190);
            this.r_OTextBox.Name = "r_OTextBox";
            this.r_OTextBox.Size = new System.Drawing.Size(400, 20);
            this.r_OTextBox.TabIndex = 64;
            // 
            // r_ITextBox
            // 
            this.r_ITextBox.Location = new System.Drawing.Point(101, 164);
            this.r_ITextBox.Name = "r_ITextBox";
            this.r_ITextBox.Size = new System.Drawing.Size(400, 20);
            this.r_ITextBox.TabIndex = 62;
            // 
            // r_FTextBox
            // 
            this.r_FTextBox.Location = new System.Drawing.Point(101, 138);
            this.r_FTextBox.Name = "r_FTextBox";
            this.r_FTextBox.Size = new System.Drawing.Size(400, 20);
            this.r_FTextBox.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Творительный(кем):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Дательный(кому):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Родительный(кого):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Именительный(кто):";
            // 
            // i_OTextBox
            // 
            this.i_OTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.i_OTextBox.Location = new System.Drawing.Point(101, 85);
            this.i_OTextBox.Name = "i_OTextBox";
            this.i_OTextBox.ReadOnly = true;
            this.i_OTextBox.Size = new System.Drawing.Size(400, 20);
            this.i_OTextBox.TabIndex = 54;
            // 
            // i_ITextBox
            // 
            this.i_ITextBox.BackColor = System.Drawing.SystemColors.Window;
            this.i_ITextBox.Location = new System.Drawing.Point(101, 59);
            this.i_ITextBox.Name = "i_ITextBox";
            this.i_ITextBox.ReadOnly = true;
            this.i_ITextBox.Size = new System.Drawing.Size(400, 20);
            this.i_ITextBox.TabIndex = 52;
            // 
            // i_FTextBox
            // 
            this.i_FTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.i_FTextBox.Location = new System.Drawing.Point(101, 33);
            this.i_FTextBox.Name = "i_FTextBox";
            this.i_FTextBox.ReadOnly = true;
            this.i_FTextBox.Size = new System.Drawing.Size(400, 20);
            this.i_FTextBox.TabIndex = 50;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(15, 409);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 78;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(426, 409);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 79;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dataSetWorker
            // 
            this.dataSetWorker.DataSetName = "DataSetWorkers";
            this.dataSetWorker.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(38, 377);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 13);
            this.label.TabIndex = 75;
            this.label.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Имя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Фамилия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Отчество:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Имя:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Фамилия:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Отчество:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Имя:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Фамилия:";
            // 
            // FormWorkerAddEditPadez
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(516, 443);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label);
            this.Controls.Add(this.t_OTextBox);
            this.Controls.Add(this.t_ITextBox);
            this.Controls.Add(this.t_FTextBox);
            this.Controls.Add(this.d_OTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.d_ITextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.d_FTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.r_OTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.r_ITextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.r_FTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.i_OTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.i_ITextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.i_FTextBox);
            this.Name = "FormWorkerAddEditPadez";
            this.Text = "Склонение по падежам";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWorkerAddEditPadez_FormClosing);
            this.Load += new System.EventHandler(this.FormWorkerAddEditPadez_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Button btnCopy;

		private System.Windows.Forms.TextBox t_OTextBox;

		private System.Windows.Forms.TextBox t_ITextBox;

		private System.Windows.Forms.TextBox t_FTextBox;

		private System.Windows.Forms.TextBox d_OTextBox;

		private System.Windows.Forms.TextBox d_ITextBox;

		private System.Windows.Forms.TextBox d_FTextBox;

		private System.Windows.Forms.TextBox r_OTextBox;

		private System.Windows.Forms.TextBox r_ITextBox;

		private System.Windows.Forms.TextBox r_FTextBox;

		private System.Windows.Forms.Label label4;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.TextBox i_OTextBox;

		private System.Windows.Forms.TextBox i_ITextBox;

		private System.Windows.Forms.TextBox i_FTextBox;

		private System.Windows.Forms.Button buttonOK;

		private System.Windows.Forms.Button buttonCancel;

		private ReferenceWorker.DataSetWorker dataSetWorker;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}
