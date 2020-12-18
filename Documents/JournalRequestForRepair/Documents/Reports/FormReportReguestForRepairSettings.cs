using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Documents.JournalRequestForRepair
{

    /// <summary>
    /// Настройки отчета
    /// </summary>
    internal class FormReportReguestForRepairSettings : Form
    {
        private Button buttonCancel;
        private Button buttonOK;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAppoveFIO;
        private TextBox txtAppoveOrg;
        private TextBox txtAppoveTitle;
        private TextBox txtSignatureFIO1;
        private TextBox txtSignatureFIO2;
        private TextBox txtSignatureTitle1;
        private TextBox txtSignatureTitle2;

        internal FormReportReguestForRepairSettings()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.groupBox1 = new GroupBox();
            this.label1 = new Label();
            this.txtAppoveTitle = new TextBox();
            this.label2 = new Label();
            this.txtAppoveOrg = new TextBox();
            this.label3 = new Label();
            this.txtAppoveFIO = new TextBox();
            this.groupBox2 = new GroupBox();
            this.label4 = new Label();
            this.txtSignatureTitle1 = new TextBox();
            this.label5 = new Label();
            this.txtSignatureTitle2 = new TextBox();
            this.label6 = new Label();
            this.txtSignatureFIO1 = new TextBox();
            this.label7 = new Label();
            this.txtSignatureFIO2 = new TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.buttonOK.DialogResult = DialogResult.OK;
            this.buttonOK.Location = new Point(12, 0xf4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(0x4b, 0x17);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(390, 0xf4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(0x4b, 0x17);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.groupBox1.Controls.Add(this.txtAppoveFIO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAppoveOrg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAppoveTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x1c5, 0x66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Утверждаю";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(6, 0x10);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Должность";
            this.txtAppoveTitle.Location = new Point(9, 0x20);
            this.txtAppoveTitle.Name = "txtAppoveTitle";
            this.txtAppoveTitle.Size = new Size(0xaf, 20);
            this.txtAppoveTitle.TabIndex = 1;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(210, 0x10);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x4a, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Организация";
            this.txtAppoveOrg.Location = new Point(0xd5, 0x20);
            this.txtAppoveOrg.Name = "txtAppoveOrg";
            this.txtAppoveOrg.Size = new Size(0xea, 20);
            this.txtAppoveOrg.TabIndex = 3;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(6, 0x37);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ФИО";
            this.txtAppoveFIO.Location = new Point(9, 0x47);
            this.txtAppoveFIO.Name = "txtAppoveFIO";
            this.txtAppoveFIO.Size = new Size(0x1b6, 20);
            this.txtAppoveFIO.TabIndex = 5;
            this.groupBox2.Controls.Add(this.txtSignatureFIO2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSignatureFIO1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSignatureTitle2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSignatureTitle1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x1c5, 0x76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подпись";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(6, 0x10);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Должность1";
            this.txtSignatureTitle1.Location = new Point(9, 0x20);
            this.txtSignatureTitle1.Name = "txtSignatureTitle1";
            this.txtSignatureTitle1.Size = new Size(0xaf, 20);
            this.txtSignatureTitle1.TabIndex = 1;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(6, 0x37);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Должность2";
            this.txtSignatureTitle2.Location = new Point(9, 0x47);
            this.txtSignatureTitle2.Name = "txtSignatureTitle2";
            this.txtSignatureTitle2.Size = new Size(0xaf, 20);
            this.txtSignatureTitle2.TabIndex = 3;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(210, 0x10);
            this.label6.Name = "label6";
            this.label6.Size = new Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "ФИО1";
            this.txtSignatureFIO1.Location = new Point(0xd5, 0x20);
            this.txtSignatureFIO1.Name = "txtSignatureFIO1";
            this.txtSignatureFIO1.Size = new Size(0xea, 20);
            this.txtSignatureFIO1.TabIndex = 5;
            this.label7.AutoSize = true;
            this.label7.Location = new Point(210, 0x37);
            this.label7.Name = "label7";
            this.label7.Size = new Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ФИО2";
            this.txtSignatureFIO2.Location = new Point(0xd5, 0x47);
            this.txtSignatureFIO2.Name = "txtSignatureFIO2";
            this.txtSignatureFIO2.Size = new Size(0xea, 20);
            this.txtSignatureFIO2.TabIndex = 7;
            base.AcceptButton = this.buttonOK;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.buttonCancel;
            base.ClientSize = new Size(0x1dd, 0x112);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.buttonCancel);
            base.Controls.Add(this.buttonOK);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FormReportReguestForRepairSettings";
            this.Text = "Настройки отчета";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        
        internal string GetAppoveTitle()
        {
            return this.txtAppoveTitle.Text;
        }

        internal void SetAppoveTitle(string str)
        {
            this.txtAppoveTitle.Text = str;
        }
  
        internal string GetSignatureTitle2()
        {
            return this.txtSignatureTitle2.Text;
        }

        internal void SetSignatureTitle2(string str)
        {
            this.txtSignatureTitle2.Text = str;
        }

        internal string method_12()
        {
            return this.txtSignatureFIO2.Text;
        }

        internal void method_13(string str)
        {
            this.txtSignatureFIO2.Text = str;
        }

        internal string method_2()
        {
            return this.txtAppoveOrg.Text;
        }

        internal void method_3(string str)
        {
            this.txtAppoveOrg.Text = str;
        }

        internal string method_4()
        {
            return this.txtAppoveFIO.Text;
        }

        internal void method_5(string str)
        {
            this.txtAppoveFIO.Text = str;
        }

        internal string method_6()
        {
            return this.txtSignatureTitle1.Text;
        }

        internal void method_7(string str)
        {
            this.txtSignatureTitle1.Text = str;
        }
        ///**************************************************************/
        //internal string GetSignatureFIO1()
        //{
        //    return this.txtSignatureFIO1.Text;
        //}

        //internal void SetSignatureFIO1(string str)
        //{
        //    this.txtSignatureFIO1.Text = str;
        //}
        public string SignatureFIO1
        {
            get
            {
                return this.txtSignatureFIO1.Text;
            }
            set
            {
                this.txtSignatureFIO1.Text = value;
            }
        }
    }

}