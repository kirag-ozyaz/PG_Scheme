internal partial class FormReportReguestForRepairSettings
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAppoveFIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAppoveOrg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAppoveTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSignatureFIO2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSignatureFIO1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSignatureTitle2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSignatureTitle1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 244);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(390, 244);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAppoveFIO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAppoveOrg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAppoveTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Утверждаю";
            // 
            // txtAppoveFIO
            // 
            this.txtAppoveFIO.Location = new System.Drawing.Point(9, 71);
            this.txtAppoveFIO.Name = "txtAppoveFIO";
            this.txtAppoveFIO.Size = new System.Drawing.Size(438, 20);
            this.txtAppoveFIO.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ФИО";
            // 
            // txtAppoveOrg
            // 
            this.txtAppoveOrg.Location = new System.Drawing.Point(213, 32);
            this.txtAppoveOrg.Name = "txtAppoveOrg";
            this.txtAppoveOrg.Size = new System.Drawing.Size(234, 20);
            this.txtAppoveOrg.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Организация";
            // 
            // txtAppoveTitle
            // 
            this.txtAppoveTitle.Location = new System.Drawing.Point(9, 32);
            this.txtAppoveTitle.Name = "txtAppoveTitle";
            this.txtAppoveTitle.Size = new System.Drawing.Size(175, 20);
            this.txtAppoveTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Должность";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSignatureFIO2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSignatureFIO1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSignatureTitle2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSignatureTitle1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 118);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подпись";
            // 
            // txtSignatureFIO2
            // 
            this.txtSignatureFIO2.Location = new System.Drawing.Point(213, 71);
            this.txtSignatureFIO2.Name = "txtSignatureFIO2";
            this.txtSignatureFIO2.Size = new System.Drawing.Size(234, 20);
            this.txtSignatureFIO2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ФИО2";
            // 
            // txtSignatureFIO1
            // 
            this.txtSignatureFIO1.Location = new System.Drawing.Point(213, 32);
            this.txtSignatureFIO1.Name = "txtSignatureFIO1";
            this.txtSignatureFIO1.Size = new System.Drawing.Size(234, 20);
            this.txtSignatureFIO1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "ФИО1";
            // 
            // txtSignatureTitle2
            // 
            this.txtSignatureTitle2.Location = new System.Drawing.Point(9, 71);
            this.txtSignatureTitle2.Name = "txtSignatureTitle2";
            this.txtSignatureTitle2.Size = new System.Drawing.Size(175, 20);
            this.txtSignatureTitle2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Должность2";
            // 
            // txtSignatureTitle1
            // 
            this.txtSignatureTitle1.Location = new System.Drawing.Point(9, 32);
            this.txtSignatureTitle1.Name = "txtSignatureTitle1";
            this.txtSignatureTitle1.Size = new System.Drawing.Size(175, 20);
            this.txtSignatureTitle1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Должность1";
            // 
            // FormReportReguestForRepairSettings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(481, 274);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReportReguestForRepairSettings";
            this.Text = "Настройки отчета";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

	}

    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button buttonOK;
	private System.Windows.Forms.Button buttonCancel;
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.TextBox txtAppoveFIO;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.TextBox txtAppoveOrg;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.TextBox txtAppoveTitle;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.GroupBox groupBox2;
	private System.Windows.Forms.TextBox txtSignatureFIO2;
	private System.Windows.Forms.Label label7;
	private System.Windows.Forms.TextBox txtSignatureFIO1;
	private System.Windows.Forms.Label label6;
	private System.Windows.Forms.TextBox txtSignatureTitle2;
	private System.Windows.Forms.Label label5;
	private System.Windows.Forms.TextBox txtSignatureTitle1;
	private System.Windows.Forms.Label label4;
}
