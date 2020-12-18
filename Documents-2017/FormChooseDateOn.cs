using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal class FormChooseDateOn : Form
{
    private Button buttonCancel;
    private Button buttonOK;
    private CheckBox checkBoxIncludeChain;
    private DateTimePicker dtpDate;
    private IContainer icontainer_0;
    private Label label1;

    internal FormChooseDateOn()
    {
        this.InitializeComponent();
        this.dtpDate.Value = DateTime.Now;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.label1 = new Label();
        this.dtpDate = new DateTimePicker();
        this.checkBoxIncludeChain = new CheckBox();
        this.buttonOK = new Button();
        this.buttonCancel = new Button();
        base.SuspendLayout();
        this.label1.AutoSize = true;
        this.label1.Location = new Point(12, 15);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x4d, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Дата и время";
        this.dtpDate.CustomFormat = "dd.MM.yyyy HH:mm";
        this.dtpDate.Format = DateTimePickerFormat.Custom;
        this.dtpDate.Location = new Point(0x5f, 9);
        this.dtpDate.Name = "dtpDate";
        this.dtpDate.Size = new Size(200, 20);
        this.dtpDate.TabIndex = 1;
        this.checkBoxIncludeChain.AutoSize = true;
        this.checkBoxIncludeChain.Checked = true;
        this.checkBoxIncludeChain.CheckState = CheckState.Checked;
        this.checkBoxIncludeChain.Location = new Point(0x4c, 0x2c);
        this.checkBoxIncludeChain.Name = "checkBoxIncludeChain";
        this.checkBoxIncludeChain.Size = new Size(0x86, 0x11);
        this.checkBoxIncludeChain.TabIndex = 2;
        this.checkBoxIncludeChain.Text = "Включить по цепочке";
        this.checkBoxIncludeChain.UseVisualStyleBackColor = true;
        this.buttonOK.DialogResult = DialogResult.OK;
        this.buttonOK.Location = new Point(15, 0x4d);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new Size(0x4b, 0x17);
        this.buttonOK.TabIndex = 3;
        this.buttonOK.Text = "ОК";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonCancel.DialogResult = DialogResult.Cancel;
        this.buttonCancel.Location = new Point(220, 0x4d);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(0x4b, 0x17);
        this.buttonCancel.TabIndex = 4;
        this.buttonCancel.Text = "Отмена";
        this.buttonCancel.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x131, 0x70);
        base.Controls.Add(this.buttonCancel);
        base.Controls.Add(this.buttonOK);
        base.Controls.Add(this.checkBoxIncludeChain);
        base.Controls.Add(this.dtpDate);
        base.Controls.Add(this.label1);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormChooseDateOn";
        this.Text = "Выбор даты";
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    internal DateTime method_0()
    {
        return this.dtpDate.Value;
    }

    internal bool method_1()
    {
        return this.checkBoxIncludeChain.Checked;
    }
}

