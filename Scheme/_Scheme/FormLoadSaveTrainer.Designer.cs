internal partial class FormLoadSaveTrainer : global::FormLbr.FormBase
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
		this.buttonCancel = new global::System.Windows.Forms.Button();
		this.buttonOK = new global::System.Windows.Forms.Button();
		this.panelSave = new global::System.Windows.Forms.Panel();
		this.label1 = new global::System.Windows.Forms.Label();
		this.textBox1 = new global::System.Windows.Forms.TextBox();
		this.panelLoad = new global::System.Windows.Forms.Panel();
		this.label2 = new global::System.Windows.Forms.Label();
		this.comboBox1 = new global::System.Windows.Forms.ComboBox();
		this.panelSave.SuspendLayout();
		this.panelLoad.SuspendLayout();
		base.SuspendLayout();
		this.buttonCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new global::System.Drawing.Point(197, 51);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 0;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.buttonOK.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
		this.buttonOK.Location = new global::System.Drawing.Point(116, 51);
		this.buttonOK.Name = "buttonOK";
		this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
		this.buttonOK.TabIndex = 0;
		this.buttonOK.Text = "OK";
		this.buttonOK.UseVisualStyleBackColor = true;
		this.panelSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.panelSave.Controls.Add(this.textBox1);
		this.panelSave.Controls.Add(this.label1);
		this.panelSave.Location = new global::System.Drawing.Point(0, 0);
		this.panelSave.Name = "panelSave";
		this.panelSave.Size = new global::System.Drawing.Size(283, 45);
		this.panelSave.TabIndex = 1;
		this.label1.AutoSize = true;
		this.label1.Location = new global::System.Drawing.Point(11, 15);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(87, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Имя тренажёра";
		this.textBox1.Location = new global::System.Drawing.Point(104, 12);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new global::System.Drawing.Size(167, 20);
		this.textBox1.TabIndex = 1;
		this.panelLoad.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.panelLoad.Controls.Add(this.comboBox1);
		this.panelLoad.Controls.Add(this.label2);
		this.panelLoad.Location = new global::System.Drawing.Point(0, 0);
		this.panelLoad.Name = "panelLoad";
		this.panelLoad.Size = new global::System.Drawing.Size(283, 45);
		this.panelLoad.TabIndex = 2;
		this.label2.AutoSize = true;
		this.label2.Location = new global::System.Drawing.Point(11, 15);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(87, 13);
		this.label2.TabIndex = 0;
		this.label2.Text = "Имя тренажёра";
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Location = new global::System.Drawing.Point(104, 12);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new global::System.Drawing.Size(167, 21);
		this.comboBox1.TabIndex = 1;
		base.AcceptButton = this.buttonOK;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new global::System.Drawing.Size(284, 86);
		base.Controls.Add(this.panelLoad);
		base.Controls.Add(this.panelSave);
		base.Controls.Add(this.buttonOK);
		base.Controls.Add(this.buttonCancel);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormLoadSaveTrainer";
		this.Text = "FormLoadSaveTrainer";
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormLoadSaveTrainer_FormClosing);
		this.panelSave.ResumeLayout(false);
		this.panelSave.PerformLayout();
		this.panelLoad.ResumeLayout(false);
		this.panelLoad.PerformLayout();
		base.ResumeLayout(false);
	}

	private global::System.ComponentModel.IContainer icontainer_0;

	private global::System.Windows.Forms.Button buttonCancel;

	private global::System.Windows.Forms.Button buttonOK;

	private global::System.Windows.Forms.Panel panelSave;

	private global::System.Windows.Forms.TextBox textBox1;

	private global::System.Windows.Forms.Label label1;

	private global::System.Windows.Forms.Panel panelLoad;

	private global::System.Windows.Forms.ComboBox comboBox1;

	private global::System.Windows.Forms.Label label2;
}
