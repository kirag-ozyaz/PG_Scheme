namespace Reference.Forms.Worker
{
	public partial class FormWorkerAddEditPadez : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
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
			this.uYkZaStwm7 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.PegZfbHygK = new System.Windows.Forms.Label();
			this.i_OTextBox = new System.Windows.Forms.TextBox();
			this.i_ITextBox = new System.Windows.Forms.TextBox();
			this.i_FTextBox = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.class48_0 = new Class48();
			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label4 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label6 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label7 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label8 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label9 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label10 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label11 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label12 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)this.class48_0).BeginInit();
			base.SuspendLayout();
			this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			this.btnCopy.Location = new System.Drawing.Point(391, 111);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(110, 23);
			this.btnCopy.TabIndex = 77;
			this.btnCopy.Text = "Копировать";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			label.AutoSize = true;
			label.Location = new System.Drawing.Point(38, 377);
			label.Name = "t_OLabel";
			label.Size = new System.Drawing.Size(57, 13);
			label.TabIndex = 75;
			label.Text = "Отчество:";
			this.t_OTextBox.Location = new System.Drawing.Point(101, 374);
			this.t_OTextBox.Name = "t_OTextBox";
			this.t_OTextBox.Size = new System.Drawing.Size(400, 20);
			this.t_OTextBox.TabIndex = 76;
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(63, 348);
			label2.Name = "t_ILabel";
			label2.Size = new System.Drawing.Size(32, 13);
			label2.TabIndex = 73;
			label2.Text = "Имя:";
			this.t_ITextBox.Location = new System.Drawing.Point(101, 348);
			this.t_ITextBox.Name = "t_ITextBox";
			this.t_ITextBox.Size = new System.Drawing.Size(400, 20);
			this.t_ITextBox.TabIndex = 74;
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(36, 325);
			label3.Name = "t_FLabel";
			label3.Size = new System.Drawing.Size(59, 13);
			label3.TabIndex = 71;
			label3.Text = "Фамилия:";
			this.t_FTextBox.Location = new System.Drawing.Point(101, 322);
			this.t_FTextBox.Name = "t_FTextBox";
			this.t_FTextBox.Size = new System.Drawing.Size(400, 20);
			this.t_FTextBox.TabIndex = 72;
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(39, 282);
			label4.Name = "d_OLabel";
			label4.Size = new System.Drawing.Size(57, 13);
			label4.TabIndex = 69;
			label4.Text = "Отчество:";
			this.d_OTextBox.Location = new System.Drawing.Point(101, 279);
			this.d_OTextBox.Name = "d_OTextBox";
			this.d_OTextBox.Size = new System.Drawing.Size(400, 20);
			this.d_OTextBox.TabIndex = 70;
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(63, 256);
			label5.Name = "d_ILabel";
			label5.Size = new System.Drawing.Size(32, 13);
			label5.TabIndex = 67;
			label5.Text = "Имя:";
			this.d_ITextBox.Location = new System.Drawing.Point(101, 253);
			this.d_ITextBox.Name = "d_ITextBox";
			this.d_ITextBox.Size = new System.Drawing.Size(400, 20);
			this.d_ITextBox.TabIndex = 68;
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(36, 230);
			label6.Name = "d_FLabel";
			label6.Size = new System.Drawing.Size(59, 13);
			label6.TabIndex = 65;
			label6.Text = "Фамилия:";
			this.d_FTextBox.Location = new System.Drawing.Point(101, 227);
			this.d_FTextBox.Name = "d_FTextBox";
			this.d_FTextBox.Size = new System.Drawing.Size(400, 20);
			this.d_FTextBox.TabIndex = 66;
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(36, 193);
			label7.Name = "r_OLabel";
			label7.Size = new System.Drawing.Size(57, 13);
			label7.TabIndex = 63;
			label7.Text = "Отчество:";
			this.r_OTextBox.Location = new System.Drawing.Point(101, 190);
			this.r_OTextBox.Name = "r_OTextBox";
			this.r_OTextBox.Size = new System.Drawing.Size(400, 20);
			this.r_OTextBox.TabIndex = 64;
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(61, 167);
			label8.Name = "r_ILabel";
			label8.Size = new System.Drawing.Size(32, 13);
			label8.TabIndex = 61;
			label8.Text = "Имя:";
			this.r_ITextBox.Location = new System.Drawing.Point(101, 164);
			this.r_ITextBox.Name = "r_ITextBox";
			this.r_ITextBox.Size = new System.Drawing.Size(400, 20);
			this.r_ITextBox.TabIndex = 62;
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(36, 141);
			label9.Name = "r_FLabel";
			label9.Size = new System.Drawing.Size(59, 13);
			label9.TabIndex = 59;
			label9.Text = "Фамилия:";
			label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.uYkZaStwm7.Location = new System.Drawing.Point(101, 138);
			this.uYkZaStwm7.Name = "r_FTextBox";
			this.uYkZaStwm7.Size = new System.Drawing.Size(400, 20);
			this.uYkZaStwm7.TabIndex = 60;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(12, 302);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 17);
			this.label4.TabIndex = 58;
			this.label4.Text = "Творительный(кем):";
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(12, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 17);
			this.label3.TabIndex = 57;
			this.label3.Text = "Дательный(кому):";
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(12, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 17);
			this.label2.TabIndex = 56;
			this.label2.Text = "Родительный(кого):";
			this.PegZfbHygK.AutoSize = true;
			this.PegZfbHygK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			this.PegZfbHygK.ForeColor = System.Drawing.SystemColors.ControlText;
			this.PegZfbHygK.Location = new System.Drawing.Point(12, 9);
			this.PegZfbHygK.Name = "label1";
			this.PegZfbHygK.Size = new System.Drawing.Size(161, 17);
			this.PegZfbHygK.TabIndex = 55;
			this.PegZfbHygK.Text = "Именительный(кто):";
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(41, 88);
			label10.Name = "i_OLabel";
			label10.Size = new System.Drawing.Size(57, 13);
			label10.TabIndex = 53;
			label10.Text = "Отчество:";
			this.i_OTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.i_OTextBox.Location = new System.Drawing.Point(101, 85);
			this.i_OTextBox.Name = "i_OTextBox";
			this.i_OTextBox.ReadOnly = true;
			this.i_OTextBox.Size = new System.Drawing.Size(400, 20);
			this.i_OTextBox.TabIndex = 54;
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(63, 62);
			label11.Name = "i_ILabel";
			label11.Size = new System.Drawing.Size(32, 13);
			label11.TabIndex = 51;
			label11.Text = "Имя:";
			this.i_ITextBox.BackColor = System.Drawing.SystemColors.Window;
			this.i_ITextBox.Location = new System.Drawing.Point(101, 59);
			this.i_ITextBox.Name = "i_ITextBox";
			this.i_ITextBox.ReadOnly = true;
			this.i_ITextBox.Size = new System.Drawing.Size(400, 20);
			this.i_ITextBox.TabIndex = 52;
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(36, 36);
			label12.Name = "i_FLabel";
			label12.Size = new System.Drawing.Size(59, 13);
			label12.TabIndex = 49;
			label12.Text = "Фамилия:";
			this.i_FTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.i_FTextBox.Location = new System.Drawing.Point(101, 33);
			this.i_FTextBox.Name = "i_FTextBox";
			this.i_FTextBox.ReadOnly = true;
			this.i_FTextBox.Size = new System.Drawing.Size(400, 20);
			this.i_FTextBox.TabIndex = 50;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(15, 409);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 78;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(426, 409);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 79;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.class48_0.DataSetName = "DataSetWorkers";
			this.class48_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(516, 443);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.btnCopy);
			base.Controls.Add(label);
			base.Controls.Add(this.t_OTextBox);
			base.Controls.Add(label2);
			base.Controls.Add(this.t_ITextBox);
			base.Controls.Add(label3);
			base.Controls.Add(this.t_FTextBox);
			base.Controls.Add(label4);
			base.Controls.Add(this.d_OTextBox);
			base.Controls.Add(label5);
			base.Controls.Add(this.d_ITextBox);
			base.Controls.Add(label6);
			base.Controls.Add(this.d_FTextBox);
			base.Controls.Add(label7);
			base.Controls.Add(this.r_OTextBox);
			base.Controls.Add(label8);
			base.Controls.Add(this.r_ITextBox);
			base.Controls.Add(label9);
			base.Controls.Add(this.uYkZaStwm7);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.PegZfbHygK);
			base.Controls.Add(label10);
			base.Controls.Add(this.i_OTextBox);
			base.Controls.Add(label11);
			base.Controls.Add(this.i_ITextBox);
			base.Controls.Add(label12);
			base.Controls.Add(this.i_FTextBox);
			base.Name = "FormWorkerAddEditPadez";
			this.Text = "FormWorkerAddEditPadez";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWorkerAddEditPadez_FormClosing);
			base.Load += new System.EventHandler(this.FormWorkerAddEditPadez_Load);
			((System.ComponentModel.ISupportInitialize)this.class48_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.Button btnCopy;

		private System.Windows.Forms.TextBox t_OTextBox;

		private System.Windows.Forms.TextBox t_ITextBox;

		private System.Windows.Forms.TextBox t_FTextBox;

		private System.Windows.Forms.TextBox d_OTextBox;

		private System.Windows.Forms.TextBox d_ITextBox;

		private System.Windows.Forms.TextBox d_FTextBox;

		private System.Windows.Forms.TextBox r_OTextBox;

		private System.Windows.Forms.TextBox r_ITextBox;

		private System.Windows.Forms.TextBox uYkZaStwm7;

		private System.Windows.Forms.Label label4;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label PegZfbHygK;

		private System.Windows.Forms.TextBox i_OTextBox;

		private System.Windows.Forms.TextBox i_ITextBox;

		private System.Windows.Forms.TextBox i_FTextBox;

		private System.Windows.Forms.Button buttonOK;

		private System.Windows.Forms.Button buttonCancel;

		private Class48 class48_0;
	}
}
