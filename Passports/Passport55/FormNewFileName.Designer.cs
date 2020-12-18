internal partial class FormNewFileName : global::System.Windows.Forms.Form
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
		this.buttonClose = new global::System.Windows.Forms.Button();
		this.buttonSave = new global::System.Windows.Forms.Button();
		this.btnCancel = new global::System.Windows.Forms.Button();
		this.btnAccept = new global::System.Windows.Forms.Button();
		this.tbNewFileName = new global::System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.buttonClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.buttonClose.Location = new global::System.Drawing.Point(491, 20);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new global::System.Drawing.Size(75, 23);
		this.buttonClose.TabIndex = 25;
		this.buttonClose.Text = "Закрыть";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.buttonSave.Location = new global::System.Drawing.Point(-158, 20);
		this.buttonSave.Name = "buttonSave";
		this.buttonSave.Size = new global::System.Drawing.Size(75, 23);
		this.buttonSave.TabIndex = 24;
		this.buttonSave.Text = "Сохранить";
		this.buttonSave.UseVisualStyleBackColor = true;
		this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnCancel.Location = new global::System.Drawing.Point(321, 46);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 27;
		this.btnCancel.Text = "Закрыть";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
		this.btnAccept.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.btnAccept.Location = new global::System.Drawing.Point(12, 46);
		this.btnAccept.Name = "btnAccept";
		this.btnAccept.Size = new global::System.Drawing.Size(75, 23);
		this.btnAccept.TabIndex = 26;
		this.btnAccept.Text = "Сохранить";
		this.btnAccept.UseVisualStyleBackColor = true;
		this.btnAccept.Click += new global::System.EventHandler(this.btnAccept_Click);
		this.tbNewFileName.Location = new global::System.Drawing.Point(12, 12);
		this.tbNewFileName.Name = "tbNewFileName";
		this.tbNewFileName.Size = new global::System.Drawing.Size(384, 20);
		this.tbNewFileName.TabIndex = 28;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(408, 81);
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

	private global::System.ComponentModel.IContainer icontainer_0;

	private global::System.Windows.Forms.Button buttonClose;

	private global::System.Windows.Forms.Button buttonSave;

	private global::System.Windows.Forms.Button btnCancel;

	private global::System.Windows.Forms.Button btnAccept;

	private global::System.Windows.Forms.TextBox tbNewFileName;
}
