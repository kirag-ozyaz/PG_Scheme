namespace Documents.Forms
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormFilter : Form
    {
        private bool bool_0 = true;
        private CheckBox checkBox1;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
        private CheckBox checkBox17;
        private CheckBox checkBox18;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private IContainer icontainer_0;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panelPeriodApplication;
        private Panel PeriodExecutionApplication;

        public FormFilter()
        {
            this.InitializeComponent();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox3.Enabled = this.checkBox8.Checked;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox5.Enabled = this.checkBox9.Checked;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                this.bool_0 = false;
                this.dateTimePicker1.Value -= this.dateTimePicker1.Value.TimeOfDay;
                this.bool_0 = true;
            }
            if (this.dateTimePicker1.Value > this.dateTimePicker2.Value)
            {
                this.dateTimePicker2.Value = this.dateTimePicker1.Value;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                this.bool_0 = false;
                DateTime time = this.dateTimePicker2.Value - this.dateTimePicker2.Value.TimeOfDay;
                this.dateTimePicker2.Value = time.AddHours(24.0).AddSeconds(-1.0);
                this.bool_0 = true;
            }
            if (this.dateTimePicker2.Value < this.dateTimePicker1.Value)
            {
                this.dateTimePicker1.Value = this.dateTimePicker2.Value;
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                this.bool_0 = false;
                DateTime time = this.dateTimePicker3.Value - this.dateTimePicker3.Value.TimeOfDay;
                this.dateTimePicker3.Value = time.AddHours(24.0).AddSeconds(-1.0);
                this.bool_0 = true;
            }
            if (this.dateTimePicker3.Value < this.dateTimePicker4.Value)
            {
                this.dateTimePicker4.Value = this.dateTimePicker3.Value;
            }
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                this.bool_0 = false;
                this.dateTimePicker4.Value -= this.dateTimePicker4.Value.TimeOfDay;
                this.bool_0 = true;
            }
            if (this.dateTimePicker4.Value > this.dateTimePicker3.Value)
            {
                this.dateTimePicker3.Value = this.dateTimePicker4.Value;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormFilter_Load(object sender, EventArgs e)
        {
            int num = 2;
            foreach (Control control in base.Controls)
            {
                if (control.Visible)
                {
                    num += control.Size.Height;
                }
            }
            base.Height = num;
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new GroupBox();
            this.checkBox2 = new CheckBox();
            this.checkBox1 = new CheckBox();
            this.groupBox2 = new GroupBox();
            this.checkBox5 = new CheckBox();
            this.checkBox3 = new CheckBox();
            this.checkBox4 = new CheckBox();
            this.groupBox3 = new GroupBox();
            this.label2 = new Label();
            this.label1 = new Label();
            this.dateTimePicker2 = new DateTimePicker();
            this.dateTimePicker1 = new DateTimePicker();
            this.groupBox4 = new GroupBox();
            this.checkBox15 = new CheckBox();
            this.checkBox16 = new CheckBox();
            this.checkBox17 = new CheckBox();
            this.checkBox7 = new CheckBox();
            this.checkBox6 = new CheckBox();
            this.checkBox8 = new CheckBox();
            this.panelPeriodApplication = new Panel();
            this.PeriodExecutionApplication = new Panel();
            this.checkBox9 = new CheckBox();
            this.groupBox5 = new GroupBox();
            this.label3 = new Label();
            this.label4 = new Label();
            this.dateTimePicker3 = new DateTimePicker();
            this.dateTimePicker4 = new DateTimePicker();
            this.groupBox6 = new GroupBox();
            this.checkBox14 = new CheckBox();
            this.checkBox13 = new CheckBox();
            this.checkBox12 = new CheckBox();
            this.checkBox11 = new CheckBox();
            this.checkBox10 = new CheckBox();
            this.checkBox18 = new CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelPeriodApplication.SuspendLayout();
            this.PeriodExecutionApplication.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Dock = DockStyle.Top;
            this.groupBox1.Location = new Point(0, 0);
            this.groupBox1.MinimumSize = new Size(0xe0, 0x43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0xe0, 0x43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип абонента";
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new Point(6, 0x2a);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(0x75, 0x11);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Физические лица";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new Point(6, 0x13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(0x79, 0x11);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Юридические лица";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Dock = DockStyle.Top;
            this.groupBox2.Location = new Point(0, 0x43);
            this.groupBox2.MinimumSize = new Size(0xe0, 0x56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0xe0, 0x56);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип действия";
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new Point(6, 0x41);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new Size(0x41, 0x11);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Отмена";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new Point(6, 0x2a);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new Size(0x69, 0x11);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Возобновление";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new Point(6, 0x13);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new Size(0x58, 0x11);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Отключение";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new Point(1, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0xdf, 0x63);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(6, 0x37);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конец";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(6, 0x10);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2c, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начало";
            this.dateTimePicker2.Location = new Point(6, 0x47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new Size(0xbc, 20);
            this.dateTimePicker2.TabIndex = 0;
            this.dateTimePicker2.ValueChanged += new EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker1.Location = new Point(6, 0x20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new Size(0xbc, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new EventHandler(this.dateTimePicker1_ValueChanged);
            this.groupBox4.Controls.Add(this.checkBox15);
            this.groupBox4.Controls.Add(this.checkBox16);
            this.groupBox4.Controls.Add(this.checkBox17);
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Dock = DockStyle.Top;
            this.groupBox4.Location = new Point(0, 0x99);
            this.groupBox4.MinimumSize = new Size(0xe0, 0x41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(0xe0, 0x87);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Не отображать";
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new Point(6, 0x58);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new Size(0x71, 0x11);
            this.checkBox15.TabIndex = 0;
            this.checkBox15.Text = "Неотправленные";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new Point(6, 0x6f);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new Size(0xb6, 0x11);
            this.checkBox16.TabIndex = 0;
            this.checkBox16.Text = "Невыполненные (вне периода)";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new Point(6, 0x41);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new Size(110, 0x11);
            this.checkBox17.TabIndex = 0;
            this.checkBox17.Text = "Невыполненные";
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new Point(6, 0x2a);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new Size(0x61, 0x11);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "Выполненные";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new Point(6, 0x13);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new Size(0x5b, 0x11);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Отменённые";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new Point(6, 0);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new Size(0x67, 0x11);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "Период заявки";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new EventHandler(this.checkBox8_CheckedChanged);
            this.panelPeriodApplication.Controls.Add(this.checkBox8);
            this.panelPeriodApplication.Controls.Add(this.groupBox3);
            this.panelPeriodApplication.Dock = DockStyle.Top;
            this.panelPeriodApplication.Location = new Point(0, 0x120);
            this.panelPeriodApplication.MinimumSize = new Size(0xe0, 0x67);
            this.panelPeriodApplication.Name = "panelPeriodApplication";
            this.panelPeriodApplication.Size = new Size(0xe0, 0x67);
            this.panelPeriodApplication.TabIndex = 1;
            this.PeriodExecutionApplication.Controls.Add(this.checkBox9);
            this.PeriodExecutionApplication.Controls.Add(this.groupBox5);
            this.PeriodExecutionApplication.Dock = DockStyle.Top;
            this.PeriodExecutionApplication.Location = new Point(0, 0x187);
            this.PeriodExecutionApplication.MinimumSize = new Size(0xe0, 0x67);
            this.PeriodExecutionApplication.Name = "PeriodExecutionApplication";
            this.PeriodExecutionApplication.Size = new Size(0xe0, 0x67);
            this.PeriodExecutionApplication.TabIndex = 2;
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new Point(6, 0);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new Size(0xa6, 0x11);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "Период исполнения заявки";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new EventHandler(this.checkBox9_CheckedChanged);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.dateTimePicker3);
            this.groupBox5.Controls.Add(this.dateTimePicker4);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new Point(1, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new Size(0xdf, 0x63);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(6, 0x37);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Конец";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(6, 0x10);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x2c, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Начало";
            this.dateTimePicker3.Location = new Point(6, 0x47);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new Size(0xbc, 20);
            this.dateTimePicker3.TabIndex = 0;
            this.dateTimePicker3.ValueChanged += new EventHandler(this.dateTimePicker3_ValueChanged);
            this.dateTimePicker4.Location = new Point(6, 0x20);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new Size(0xbc, 20);
            this.dateTimePicker4.TabIndex = 0;
            this.dateTimePicker4.ValueChanged += new EventHandler(this.dateTimePicker4_ValueChanged);
            this.groupBox6.Controls.Add(this.checkBox18);
            this.groupBox6.Controls.Add(this.checkBox14);
            this.groupBox6.Controls.Add(this.checkBox13);
            this.groupBox6.Controls.Add(this.checkBox12);
            this.groupBox6.Controls.Add(this.checkBox11);
            this.groupBox6.Controls.Add(this.checkBox10);
            this.groupBox6.Dock = DockStyle.Top;
            this.groupBox6.Location = new Point(0, 0x1ee);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new Size(0xe0, 0x9d);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Районы";
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new Point(6, 0x6f);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new Size(50, 0x11);
            this.checkBox14.TabIndex = 0;
            this.checkBox14.Text = "ОДС";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new Point(6, 0x58);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new Size(0x79, 0x11);
            this.checkBox13.TabIndex = 0;
            this.checkBox13.Text = "Сетевой район №4";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new Point(6, 0x41);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new Size(0x79, 0x11);
            this.checkBox12.TabIndex = 0;
            this.checkBox12.Text = "Сетевой район №3";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new Point(6, 0x2a);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new Size(0x79, 0x11);
            this.checkBox11.TabIndex = 0;
            this.checkBox11.Text = "Сетевой район №2";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new Point(6, 0x13);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new Size(0x79, 0x11);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Text = "Сетевой район №1";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new Point(6, 0x86);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new Size(0x3f, 0x11);
            this.checkBox18.TabIndex = 0;
            this.checkBox18.Text = "СЭСНО";
            this.checkBox18.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0xe0, 0x28b);
            base.ControlBox = false;
            base.Controls.Add(this.groupBox6);
            base.Controls.Add(this.PeriodExecutionApplication);
            base.Controls.Add(this.panelPeriodApplication);
            base.Controls.Add(this.groupBox4);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Name = "FormFilter";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.Manual;
            base.Load += new EventHandler(this.FormFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelPeriodApplication.ResumeLayout(false);
            this.panelPeriodApplication.PerformLayout();
            this.PeriodExecutionApplication.ResumeLayout(false);
            this.PeriodExecutionApplication.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            base.ResumeLayout(false);
        }

        protected override void OnDeactivate(EventArgs eventArgs_0)
        {
            base.OnDeactivate(eventArgs_0);
            base.Hide();
        }

        public DateTime BeginningOfPeriod
        {
            get
            {
                return this.dateTimePicker1.Value;
            }
            set
            {
                this.dateTimePicker1.Value = value;
            }
        }

        public DateTime BeginningOfPeriodExecution
        {
            get
            {
                return this.dateTimePicker4.Value;
            }
            set
            {
                this.dateTimePicker4.Value = value;
            }
        }

        public bool Cancel
        {
            get
            {
                return this.checkBox5.Checked;
            }
            set
            {
                this.checkBox5.Checked = value;
            }
        }

        public bool Disconnection
        {
            get
            {
                return this.checkBox4.Checked;
            }
            set
            {
                this.checkBox4.Checked = value;
            }
        }

        public bool DoNotDisplayCancelled
        {
            get
            {
                return this.checkBox6.Checked;
            }
            set
            {
                this.checkBox6.Checked = value;
            }
        }

        public bool DoNotDisplayPerformed
        {
            get
            {
                return this.checkBox7.Checked;
            }
            set
            {
                this.checkBox7.Checked = value;
            }
        }

        public bool DoNotDisplayUnperformed
        {
            get
            {
                return this.checkBox17.Checked;
            }
            set
            {
                this.checkBox17.Checked = value;
            }
        }

        public DateTime EndOfPeriod
        {
            get
            {
                return this.dateTimePicker2.Value;
            }
            set
            {
                this.dateTimePicker2.Value = value;
            }
        }

        public DateTime EndOfPeriodExecution
        {
            get
            {
                return this.dateTimePicker3.Value;
            }
            set
            {
                this.dateTimePicker3.Value = value;
            }
        }

        public bool ForDisconected
        {
            get
            {
                return this.groupBox2.Enabled;
            }
            set
            {
                this.groupBox2.Enabled = value;
                this.groupBox4.Enabled = value;
            }
        }

        public bool Individual
        {
            get
            {
                return this.checkBox2.Checked;
            }
            set
            {
                this.checkBox2.Checked = value;
            }
        }

        public bool Legal
        {
            get
            {
                return this.checkBox1.Checked;
            }
            set
            {
                this.checkBox1.Checked = value;
            }
        }

        public bool NetArea1
        {
            get
            {
                return this.checkBox10.Checked;
            }
            set
            {
                this.checkBox10.Checked = value;
            }
        }

        public bool NetArea2
        {
            get
            {
                return this.checkBox11.Checked;
            }
            set
            {
                this.checkBox11.Checked = value;
            }
        }

        public bool NetArea3
        {
            get
            {
                return this.checkBox12.Checked;
            }
            set
            {
                this.checkBox12.Checked = value;
            }
        }

        public bool NetArea4
        {
            get
            {
                return this.checkBox13.Checked;
            }
            set
            {
                this.checkBox13.Checked = value;
            }
        }

        public bool ODS
        {
            get
            {
                return this.checkBox14.Checked;
            }
            set
            {
                this.checkBox14.Checked = value;
            }
        }

        public bool Resumption
        {
            get
            {
                return this.checkBox3.Checked;
            }
            set
            {
                this.checkBox3.Checked = value;
            }
        }

        public bool SESNO
        {
            get
            {
                return this.checkBox18.Checked;
            }
            set
            {
                this.checkBox18.Checked = value;
            }
        }

        public bool ShowDoNotDisplayZone
        {
            get
            {
                return this.groupBox4.Visible;
            }
            set
            {
                this.groupBox4.Visible = value;
            }
        }

        public bool ShowNetArea
        {
            get
            {
                return this.groupBox6.Visible;
            }
            set
            {
                this.groupBox6.Visible = value;
            }
        }

        public bool ShowPeriodApplication
        {
            get
            {
                return this.panelPeriodApplication.Visible;
            }
            set
            {
                this.panelPeriodApplication.Visible = value;
            }
        }

        public bool ShowPeriodExecutionApplication
        {
            get
            {
                return this.PeriodExecutionApplication.Visible;
            }
            set
            {
                this.PeriodExecutionApplication.Visible = value;
            }
        }

        public bool SkipUnperformed
        {
            get
            {
                return this.checkBox16.Checked;
            }
            set
            {
                this.checkBox16.Checked = value;
            }
        }

        public bool SkipUnsent
        {
            get
            {
                return this.checkBox15.Checked;
            }
            set
            {
                this.checkBox15.Checked = value;
            }
        }

        public bool UsePeriod
        {
            get
            {
                return this.checkBox8.Checked;
            }
            set
            {
                this.checkBox8.Checked = value;
            }
        }

        public bool UsePeriodExecution
        {
            get
            {
                return this.checkBox9.Checked;
            }
            set
            {
                this.checkBox9.Checked = value;
            }
        }
    }
}

