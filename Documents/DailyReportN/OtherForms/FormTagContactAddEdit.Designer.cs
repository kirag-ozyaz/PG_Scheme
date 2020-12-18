using ControlsLbr;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormTagContactAddEdit : global::FormLbr.FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	private global::System.ComponentModel.IContainer components=null;

    private void InitializeComponent()
    {
        this.labelTag = new Label();
        this.txtTag = new TextBox();
        this.labelDivision = new Label();
        this.cmbDivision = new ComboBox();
        this.labelFIO = new Label();
        this.cmbFIO = new ComboBox();
        this.labelContact = new Label();
        this.txtContact = new TextBox();
        this.buttonOK = new Button();
        this.buttonCancel = new Button();
        this.panel1 = new Panel();
        this.panel1.SuspendLayout();
        base.SuspendLayout();
        this.labelTag.AutoSize = true;
        this.labelTag.Location = new Point(12, 9);
        this.labelTag.Name = "labelTag";
        this.labelTag.Size = new Size(54, 13);
        this.labelTag.TabIndex = 0;
        this.labelTag.Text = "Имя тэга";
        this.txtTag.Location = new Point(12, 25);
        this.txtTag.Name = "txtTag";
        this.txtTag.Size = new Size(396, 20);
        this.txtTag.TabIndex = 1;
        this.labelDivision.AutoSize = true;
        this.labelDivision.Location = new Point(12, 48);
        this.labelDivision.Name = "labelDivision";
        this.labelDivision.Size = new Size(87, 13);
        this.labelDivision.TabIndex = 2;
        this.labelDivision.Text = "Подразделение";
        this.cmbDivision.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.cmbDivision.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.cmbDivision.FormattingEnabled = true;
        this.cmbDivision.Location = new Point(12, 64);
        this.cmbDivision.Name = "cmbDivision";
        this.cmbDivision.Size = new Size(396, 21);
        this.cmbDivision.TabIndex = 3;
        this.labelFIO.AutoSize = true;
        this.labelFIO.Location = new Point(13, 0);
        this.labelFIO.Name = "labelFIO";
        this.labelFIO.Size = new Size(34, 13);
        this.labelFIO.TabIndex = 4;
        this.labelFIO.Text = "ФИО";
        this.cmbFIO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.cmbFIO.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.cmbFIO.FormattingEnabled = true;
        this.cmbFIO.Location = new Point(12, 16);
        this.cmbFIO.Name = "cmbFIO";
        this.cmbFIO.Size = new Size(396, 21);
        this.cmbFIO.TabIndex = 5;
        this.labelContact.AutoSize = true;
        this.labelContact.Location = new Point(13, 40);
        this.labelContact.Name = "labelContact";
        this.labelContact.Size = new Size(48, 13);
        this.labelContact.TabIndex = 6;
        this.labelContact.Text = "Контакт";
        this.txtContact.Location = new Point(13, 56);
        this.txtContact.Name = "txtContact";
        this.txtContact.Size = new Size(396, 20);
        this.txtContact.TabIndex = 7;
        this.buttonOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        this.buttonOK.DialogResult = DialogResult.OK;
        this.buttonOK.Location = new Point(12, 170);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new Size(75, 23);
        this.buttonOK.TabIndex = 8;
        this.buttonOK.Text = "ОК";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        this.buttonCancel.DialogResult = DialogResult.Cancel;
        this.buttonCancel.Location = new Point(333, 170);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(75, 23);
        this.buttonCancel.TabIndex = 9;
        this.buttonCancel.Text = "Отмена";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.panel1.AutoSize = true;
        this.panel1.Controls.Add(this.labelFIO);
        this.panel1.Controls.Add(this.cmbFIO);
        this.panel1.Controls.Add(this.labelContact);
        this.panel1.Controls.Add(this.txtContact);
        this.panel1.Location = new Point(0, 88);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(412, 79);
        this.panel1.TabIndex = 10;
        base.AcceptButton = this.buttonOK;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.buttonCancel;
        base.ClientSize = new Size(413, 200);
        base.Controls.Add(this.panel1);
        base.Controls.Add(this.buttonCancel);
        base.Controls.Add(this.buttonOK);
        base.Controls.Add(this.cmbDivision);
        base.Controls.Add(this.labelDivision);
        base.Controls.Add(this.txtTag);
        base.Controls.Add(this.labelTag);
        base.Name = "FormTagContactAddEdit";
        this.Text = "FormTagContactAddEdit";
        base.FormClosing += this.FormTagContactAddEdit_FormClosing;
        base.Load += this.FormTagContactAddEdit_Load;
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
    private TreeDataGridViewNode treeDataGridViewNode_0;

    private Label labelTag;

    private TextBox txtTag;

    private Label labelDivision;

    private ComboBox cmbDivision;

    private Label labelFIO;

    private ComboBox cmbFIO;

    private Label labelContact;

    private TextBox txtContact;

    private Button buttonOK;

    private Button buttonCancel;

    private Panel panel1;
}
