internal partial class FormRequestForRepairAddAddress : FormLbr.FormBase
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
		this.listBoxHouse = new System.Windows.Forms.ListBox();
		this.kladrStreetControl = new ControlsLbr.KladrStreetControl();
		this.buttonOK = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.listBoxHouse.Enabled = false;
		this.listBoxHouse.FormattingEnabled = true;
		this.listBoxHouse.Location = new System.Drawing.Point(181, 1);
		this.listBoxHouse.Name = "listBoxHouse";
		this.listBoxHouse.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
		this.listBoxHouse.Size = new System.Drawing.Size(82, 199);
		this.listBoxHouse.TabIndex = 4;
		this.kladrStreetControl.Location = new System.Drawing.Point(1, 1);
		this.kladrStreetControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.kladrStreetControl.Name = "kladrStreetControl";
		this.kladrStreetControl.Size = new System.Drawing.Size(173, 208);
		this.kladrStreetControl.SqlSettings = null;
		this.kladrStreetControl.TabIndex = 3;
		this.kladrStreetControl.VisibleCmbTypeHouse = true;
		this.kladrStreetControl.ChangeOblSelect += new System.EventHandler(this.kladrStreetControl_ChangeOblSelect);
		this.kladrStreetControl.ChangeRaionOblSelect += new System.EventHandler(this.kladrStreetControl_ChangeRaionOblSelect);
		this.kladrStreetControl.ChangePunktsSelect += new System.EventHandler(this.kladrStreetControl_ChangePunktsSelect);
		this.kladrStreetControl.ChangeStreetSelect += new System.EventHandler(this.kladrStreetControl_ChangeStreetSelect);
		this.kladrStreetControl.ChangeTypeHouseSelect += new System.EventHandler(this.kladrStreetControl_ChangeTypeHouseSelect);
		this.buttonOK.Location = new System.Drawing.Point(12, 217);
		this.buttonOK.Name = "buttonOK";
		this.buttonOK.Size = new System.Drawing.Size(75, 23);
		this.buttonOK.TabIndex = 5;
		this.buttonOK.Text = "ОК";
		this.buttonOK.UseVisualStyleBackColor = true;
		this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
		this.buttonCancel.Location = new System.Drawing.Point(188, 217);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 6;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(267, 249);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOK);
		base.Controls.Add(this.listBoxHouse);
		base.Controls.Add(this.kladrStreetControl);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormRequestForRepairAddAddress";
		this.Text = "Добавление адреса";
		base.ResumeLayout(false);
	}

	private System.ComponentModel.IContainer components = null;

	private System.Windows.Forms.ListBox listBoxHouse;

	private ControlsLbr.KladrStreetControl kladrStreetControl;

	private System.Windows.Forms.Button buttonOK;

	private System.Windows.Forms.Button buttonCancel;
}
