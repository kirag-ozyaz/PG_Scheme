using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class FormNewFileName : Form
{
    private Button btnAccept;
    private Button btnCancel;
    private Button buttonClose;
    private Button buttonSave;
    private IContainer icontainer_0;
    [CompilerGenerated]
    private string string_0;
    private string string_1;
    private TextBox tbNewFileName;

    public FormNewFileName()
    {
        this.string_1 = "";
        this.InitializeComponent();
        this.string_1 = Path.GetExtension(this.method_0());
        this.tbNewFileName.Text = Path.GetFileNameWithoutExtension(this.method_0());
    }

    public FormNewFileName(string string_2)
    {
        this.string_1 = "";
        this.InitializeComponent();
        this.string_1 = Path.GetExtension(string_2);
        this.tbNewFileName.Text = Path.GetFileNameWithoutExtension(string_2);
    }

    private void btnAccept_Click(object sender, EventArgs e)
    {
        this.method_1(this.tbNewFileName.Text + this.string_1);
        base.DialogResult = DialogResult.OK;
        base.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
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

    private void InitializeComponent()
    {
        this.buttonClose = new Button();
        this.buttonSave = new Button();
        this.btnCancel = new Button();
        this.btnAccept = new Button();
        this.tbNewFileName = new TextBox();
        base.SuspendLayout();
        this.buttonClose.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.buttonClose.Location = new Point(0x1eb, 20);
        this.buttonClose.Name = "buttonClose";
        this.buttonClose.Size = new Size(0x4b, 0x17);
        this.buttonClose.TabIndex = 0x19;
        this.buttonClose.Text = "Закрыть";
        this.buttonClose.UseVisualStyleBackColor = true;
        this.buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.buttonSave.Location = new Point(-158, 20);
        this.buttonSave.Name = "buttonSave";
        this.buttonSave.Size = new Size(0x4b, 0x17);
        this.buttonSave.TabIndex = 0x18;
        this.buttonSave.Text = "Сохранить";
        this.buttonSave.UseVisualStyleBackColor = true;
        this.btnCancel.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.btnCancel.Location = new Point(0x141, 0x2e);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(0x4b, 0x17);
        this.btnCancel.TabIndex = 0x1b;
        this.btnCancel.Text = "Закрыть";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
        this.btnAccept.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.btnAccept.Location = new Point(12, 0x2e);
        this.btnAccept.Name = "btnAccept";
        this.btnAccept.Size = new Size(0x4b, 0x17);
        this.btnAccept.TabIndex = 0x1a;
        this.btnAccept.Text = "Сохранить";
        this.btnAccept.UseVisualStyleBackColor = true;
        this.btnAccept.Click += new EventHandler(this.btnAccept_Click);
        this.tbNewFileName.Location = new Point(12, 12);
        this.tbNewFileName.Name = "tbNewFileName";
        this.tbNewFileName.Size = new Size(0x180, 20);
        this.tbNewFileName.TabIndex = 0x1c;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x198, 0x51);
        base.Controls.Add(this.tbNewFileName);
        base.Controls.Add(this.btnCancel);
        base.Controls.Add(this.btnAccept);
        base.Controls.Add(this.buttonClose);
        base.Controls.Add(this.buttonSave);
        base.Name = "FormNewFileName";
        this.Text = "Имя документа";
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    [CompilerGenerated]
    public string method_0()
    {
        return this.string_0;
    }

    [CompilerGenerated]
    public void method_1(string string_2)
    {
        this.string_0 = string_2;
    }
}

