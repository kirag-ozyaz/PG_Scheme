using FormLbr;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Form26 : FormBase
{
    [CompilerGenerated]
    private bool bool_0;
    private Button button_0;
    private Button button_1;
    private CheckBox checkBox_0;
    private IContainer icontainer_0;
    private Label label_0;
    [CompilerGenerated]
    private string string_0;
    private TextBox textBox_0;

    internal Form26()
    {
        this.method_2();
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.textBox_0.Text))
        {
            MessageBox.Show("Пароль не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            this.method_1(this.checkBox_0.Checked);
            this.Password = this.textBox_0.Text;
            base.DialogResult = DialogResult.OK;
            base.Close();
        }
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.Cancel;
        base.Close();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    [CompilerGenerated]
    internal bool method_0()
    {
        return this.bool_0;
    }

    [CompilerGenerated]
    internal void method_1(bool bool_1)
    {
        this.bool_0 = bool_1;
    }

    private void method_2()
    {
        this.textBox_0 = new TextBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.label_0 = new Label();
        this.checkBox_0 = new CheckBox();
        base.SuspendLayout();
        this.textBox_0.Location = new Point(15, 0x2c);
        this.textBox_0.Name = "tbPassword";
        this.textBox_0.Size = new Size(0x115, 20);
        this.textBox_0.TabIndex = 0;
        this.textBox_0.UseSystemPasswordChar = true;
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(0xa7, 0x4f);
        this.button_0.Name = "btnOk";
        this.button_0.Size = new Size(0x2b, 0x17);
        this.button_0.TabIndex = 2;
        this.button_0.Text = "Ок";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0xd9, 0x4f);
        this.button_1.Name = "btnCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 3;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 0x13);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0xbc, 13);
        this.label_0.TabIndex = 4;
        this.label_0.Text = "Введите пароль к \"Босс Референт\"";
        this.checkBox_0.AutoSize = true;
        this.checkBox_0.Location = new Point(15, 0x53);
        this.checkBox_0.Name = "checkBox1";
        this.checkBox_0.Size = new Size(0x52, 0x11);
        this.checkBox_0.TabIndex = 1;
        this.checkBox_0.Text = "Запомнить";
        this.checkBox_0.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x130, 110);
        base.Controls.Add(this.checkBox_0);
        base.Controls.Add(this.label_0);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.textBox_0);
        base.Name = "FormPassword";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Проверка входа доступа";
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    internal string Password
    {
        [CompilerGenerated]
        get
        {
            return this.string_0;
        }
        [CompilerGenerated]
        set
        {
            this.string_0 = value;
        }
    }
}

