namespace Documents.Forms.JournalExcavation.Reports
{
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormExportExcavation : FormBase
    {
        private Button button_0;
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private CheckBox checkBox_0;
        private DateTimePicker dateTimePicker_0;
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private TextBox textBox_0;

        public FormExportExcavation()
        {
            this.method_0();
            this.dateTimePicker_0.Value = DateTime.Now.Date;
            this.textBox_0.Text = "Excavation.html";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox_0.Text = dialog.FileName;
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            try
            {
                Class188.smethod_2(this.get_SqlSettings(), this.textBox_0.Text, this.dateTimePicker_0.Value, this.checkBox_0.Checked);
                MessageBox.Show("Данные выгружены успешно");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            for (DateTime time = new DateTime(0x7de, 7, 4); time <= new DateTime(0x7de, 7, 13); time = time.AddDays(1.0))
            {
                Class188.smethod_2(this.get_SqlSettings(), @"d:\temp\exc\" + time.ToString("yyyyMMdd") + ".html", time, this.checkBox_0.Checked);
            }
            MessageBox.Show("Данные выгружены успешно");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void method_0()
        {
            this.label_0 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_1 = new Label();
            this.textBox_0 = new TextBox();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.button_2 = new Button();
            this.checkBox_0 = new CheckBox();
            this.button_3 = new Button();
            base.SuspendLayout();
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 9);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x21, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Дата";
            this.dateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_0.Location = new Point(15, 0x19);
            this.dateTimePicker_0.Name = "dateTimePicker";
            this.dateTimePicker_0.Size = new Size(0xe5, 20);
            this.dateTimePicker_0.TabIndex = 1;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(12, 0x30);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x40, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Имя файла";
            this.textBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_0.Location = new Point(15, 0x40);
            this.textBox_0.Name = "textBoxFile";
            this.textBox_0.Size = new Size(200, 20);
            this.textBox_0.TabIndex = 3;
            this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.button_0.Location = new Point(0xdd, 0x40);
            this.button_0.Name = "buttonFile";
            this.button_0.Size = new Size(0x17, 20);
            this.button_0.TabIndex = 4;
            this.button_0.Text = "...";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Location = new Point(15, 130);
            this.button_1.Name = "buttonSave";
            this.button_1.Size = new Size(0x4c, 0x17);
            this.button_1.TabIndex = 5;
            this.button_1.Text = "Экспорт";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.button_2.Location = new Point(170, 130);
            this.button_2.Name = "buttonClose";
            this.button_2.Size = new Size(0x4b, 0x17);
            this.button_2.TabIndex = 6;
            this.button_2.Text = "Закрыть";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new EventHandler(this.button_2_Click);
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Checked = true;
            this.checkBox_0.CheckState = CheckState.Checked;
            this.checkBox_0.Location = new Point(15, 0x60);
            this.checkBox_0.Name = "checkBoxAgreed";
            this.checkBox_0.Size = new Size(0x6a, 0x11);
            this.checkBox_0.TabIndex = 7;
            this.checkBox_0.Text = "Согласованные";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.button_3.Location = new Point(0x6d, 130);
            this.button_3.Name = "button1";
            this.button_3.Size = new Size(0x4b, 0x17);
            this.button_3.TabIndex = 8;
            this.button_3.Text = "button1";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Visible = false;
            this.button_3.Click += new EventHandler(this.button_3_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x101, 0xa5);
            base.Controls.Add(this.button_3);
            base.Controls.Add(this.checkBox_0);
            base.Controls.Add(this.button_2);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.textBox_0);
            base.Controls.Add(this.label_1);
            base.Controls.Add(this.dateTimePicker_0);
            base.Controls.Add(this.label_0);
            base.Name = "FormExportExcavation";
            this.Text = "Экспорт журанала раскопок";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

