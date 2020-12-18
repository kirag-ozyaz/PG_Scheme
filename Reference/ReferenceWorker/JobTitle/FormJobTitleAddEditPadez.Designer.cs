namespace ReferenceWorker
{
	public partial class FormJobTitleAddEditPadez : FormLbr.FormBase
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
			this.t_FTextBox = new System.Windows.Forms.TextBox();
			this.d_FTextBox = new System.Windows.Forms.TextBox();
			this.r_FTextBox = new System.Windows.Forms.TextBox();
			//this.label4 = new System.Windows.Forms.Label();
			//this.label3 = new System.Windows.Forms.Label();
			//this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.i_FTextBox = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.dsWorker = new ReferenceWorker.DataSetWorker();
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
			System.Windows.Forms.Label label4 = new System.Windows.Forms.Label();
System.Windows.Forms.Label label7 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label label6 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)this.dsWorker).BeginInit();
			base.SuspendLayout();
			label.AutoSize = true;
			label.Location = new System.Drawing.Point(28, 36);
			label.Name = "i_FLabel";
			label.Size = new System.Drawing.Size(68, 13);
			label.TabIndex = 49;
			label.Text = "Должность:";
			this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			this.btnCopy.Location = new System.Drawing.Point(391, 53);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(110, 23);
			this.btnCopy.TabIndex = 77;
			this.btnCopy.Text = "Копировать";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			this.t_FTextBox.Location = new System.Drawing.Point(101, 166);
			this.t_FTextBox.Name = "t_FTextBox";
			this.t_FTextBox.Size = new System.Drawing.Size(400, 20);
			this.t_FTextBox.TabIndex = 72;
			this.d_FTextBox.Location = new System.Drawing.Point(101, 123);
			this.d_FTextBox.Name = "d_FTextBox";
			this.d_FTextBox.Size = new System.Drawing.Size(400, 20);
			this.d_FTextBox.TabIndex = 66;
			this.r_FTextBox.Location = new System.Drawing.Point(101, 80);
			this.r_FTextBox.Name = "r_FTextBox";
			this.r_FTextBox.Size = new System.Drawing.Size(400, 20);
			this.r_FTextBox.TabIndex = 60;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(12, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 17);
			this.label4.TabIndex = 58;
			this.label4.Text = "Творительный(кем):";
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(12, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 17);
			this.label3.TabIndex = 57;
			this.label3.Text = "Дательный(кому):";
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 17);
			this.label2.TabIndex = 56;
			this.label2.Text = "Родительный(кого):";
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 17);
			this.label1.TabIndex = 55;
			this.label1.Text = "Именительный(кто):";
			this.i_FTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.i_FTextBox.Location = new System.Drawing.Point(101, 33);
			this.i_FTextBox.Name = "i_FTextBox";
			this.i_FTextBox.ReadOnly = true;
			this.i_FTextBox.Size = new System.Drawing.Size(400, 20);
			this.i_FTextBox.TabIndex = 50;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(15, 203);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 78;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(426, 203);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 79;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.dsWorker.DataSetName = "DataSetWorkers";
			this.dsWorker.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(27, 83);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 13);
			label5.TabIndex = 80;
            label5.Text = "Должность:";
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(28, 126);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(68, 13);
            label6.TabIndex = 81;
            label6.Text = "Должность:";
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(22, 169);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(68, 13);
            label7.TabIndex = 82;
            label7.Text = "Должность:";
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(516, 238);
			base.Controls.Add(label4);
			base.Controls.Add(label3);
			base.Controls.Add(label2);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.btnCopy);
			base.Controls.Add(this.t_FTextBox);
			base.Controls.Add(this.d_FTextBox);
			base.Controls.Add(this.r_FTextBox);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label1);
			base.Controls.Add(label);
			base.Controls.Add(this.i_FTextBox);
			base.Name = "FormJobTitleAddEditPadez";
			this.Text = "FormWorkerAddEditPadez";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJobTitleAddEditPadez_FormClosing);
			base.Load += new System.EventHandler(this.FormJobTitleAddEditPadez_Load);
			((System.ComponentModel.ISupportInitialize)this.dsWorker).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Button btnCopy;

		private System.Windows.Forms.TextBox t_FTextBox;

		private System.Windows.Forms.TextBox d_FTextBox;

		private System.Windows.Forms.TextBox r_FTextBox;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.TextBox i_FTextBox;

		private System.Windows.Forms.Button buttonOK;

		private System.Windows.Forms.Button buttonCancel;

		private ReferenceWorker.DataSetWorker dsWorker;
	}
}
