namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class BranchPropertyesForm : global::System.Windows.Forms.Form
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
			this.OKButton = new global::System.Windows.Forms.Button();
			this.cancelButton = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.airLineRadioButton = new global::System.Windows.Forms.RadioButton();
			this.cabelLineRadioButton = new global::System.Windows.Forms.RadioButton();
			this.radioButtonAirLineProtected = new global::System.Windows.Forms.RadioButton();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.OKButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.OKButton.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.OKButton.Location = new global::System.Drawing.Point(167, 129);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new global::System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 2;
			this.OKButton.Text = "ОК";
			this.OKButton.UseVisualStyleBackColor = true;
			this.cancelButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.cancelButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new global::System.Drawing.Point(86, 129);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new global::System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.groupBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox2.Controls.Add(this.radioButtonAirLineProtected);
			this.groupBox2.Controls.Add(this.airLineRadioButton);
			this.groupBox2.Controls.Add(this.cabelLineRadioButton);
			this.groupBox2.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(230, 95);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Тип линии";
			this.airLineRadioButton.AutoSize = true;
			this.airLineRadioButton.Location = new global::System.Drawing.Point(6, 42);
			this.airLineRadioButton.Name = "airLineRadioButton";
			this.airLineRadioButton.Size = new global::System.Drawing.Size(114, 17);
			this.airLineRadioButton.TabIndex = 1;
			this.airLineRadioButton.TabStop = true;
			this.airLineRadioButton.Text = "Воздушная линия";
			this.airLineRadioButton.UseVisualStyleBackColor = true;
			this.cabelLineRadioButton.AutoSize = true;
			this.cabelLineRadioButton.Location = new global::System.Drawing.Point(6, 19);
			this.cabelLineRadioButton.Name = "cabelLineRadioButton";
			this.cabelLineRadioButton.Size = new global::System.Drawing.Size(113, 17);
			this.cabelLineRadioButton.TabIndex = 0;
			this.cabelLineRadioButton.TabStop = true;
			this.cabelLineRadioButton.Text = "Кабельная линия";
			this.cabelLineRadioButton.UseVisualStyleBackColor = true;
			this.radioButtonAirLineProtected.AutoSize = true;
			this.radioButtonAirLineProtected.Location = new global::System.Drawing.Point(6, 65);
			this.radioButtonAirLineProtected.Name = "radioButtonAirLineProtected";
			this.radioButtonAirLineProtected.Size = new global::System.Drawing.Size(47, 17);
			this.radioButtonAirLineProtected.TabIndex = 2;
			this.radioButtonAirLineProtected.TabStop = true;
			this.radioButtonAirLineProtected.Text = "ВЛЗ";
			this.radioButtonAirLineProtected.UseVisualStyleBackColor = true;
			base.AcceptButton = this.OKButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.cancelButton;
			base.ClientSize = new global::System.Drawing.Size(254, 165);
			base.ControlBox = false;
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.cancelButton);
			base.Controls.Add(this.OKButton);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "BranchPropertyesForm";
			this.Text = "Свойства ветки";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.BranchPropertyesForm_FormClosing);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.Button OKButton;

		private global::System.Windows.Forms.Button cancelButton;

		private global::System.Windows.Forms.GroupBox groupBox2;

		private global::System.Windows.Forms.RadioButton airLineRadioButton;

		private global::System.Windows.Forms.RadioButton cabelLineRadioButton;

		private global::System.Windows.Forms.RadioButton radioButtonAirLineProtected;
	}
}
