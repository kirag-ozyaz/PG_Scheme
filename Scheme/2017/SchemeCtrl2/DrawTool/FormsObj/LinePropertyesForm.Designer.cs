namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class LinePropertyesForm : global::System.Windows.Forms.Form
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
			this.destinationListBox = new global::System.Windows.Forms.ListBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.OKButton = new global::System.Windows.Forms.Button();
			this.cancelButton = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.radioBtnAirLineProtected = new global::System.Windows.Forms.RadioButton();
			this.airLineRadioButton = new global::System.Windows.Forms.RadioButton();
			this.cabelLineRadioButton = new global::System.Windows.Forms.RadioButton();
			this.labelNameLine = new global::System.Windows.Forms.Label();
			this.textBoxNameLine = new global::System.Windows.Forms.TextBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.listBoxOfSupplyCells = new global::System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			base.SuspendLayout();
			this.destinationListBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.destinationListBox.FormattingEnabled = true;
			this.destinationListBox.Location = new global::System.Drawing.Point(3, 16);
			this.destinationListBox.Name = "destinationListBox";
			this.destinationListBox.Size = new global::System.Drawing.Size(470, 138);
			this.destinationListBox.TabIndex = 0;
			this.groupBox1.Controls.Add(this.destinationListBox);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 51);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(476, 157);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Список подключенных объектов";
			this.OKButton.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.OKButton.Location = new global::System.Drawing.Point(12, 312);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new global::System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 2;
			this.OKButton.Text = "ОК";
			this.OKButton.UseVisualStyleBackColor = true;
			this.cancelButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new global::System.Drawing.Point(413, 312);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new global::System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.groupBox2.Controls.Add(this.radioBtnAirLineProtected);
			this.groupBox2.Controls.Add(this.airLineRadioButton);
			this.groupBox2.Controls.Add(this.cabelLineRadioButton);
			this.groupBox2.Location = new global::System.Drawing.Point(12, 219);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(148, 84);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Тип линии";
			this.radioBtnAirLineProtected.AutoSize = true;
			this.radioBtnAirLineProtected.Location = new global::System.Drawing.Point(6, 62);
			this.radioBtnAirLineProtected.Name = "radioBtnAirLineProtected";
			this.radioBtnAirLineProtected.Size = new global::System.Drawing.Size(47, 17);
			this.radioBtnAirLineProtected.TabIndex = 2;
			this.radioBtnAirLineProtected.TabStop = true;
			this.radioBtnAirLineProtected.Text = "ВЛЗ";
			this.radioBtnAirLineProtected.UseVisualStyleBackColor = true;
			this.airLineRadioButton.AutoSize = true;
			this.airLineRadioButton.Location = new global::System.Drawing.Point(6, 39);
			this.airLineRadioButton.Name = "airLineRadioButton";
			this.airLineRadioButton.Size = new global::System.Drawing.Size(114, 17);
			this.airLineRadioButton.TabIndex = 1;
			this.airLineRadioButton.TabStop = true;
			this.airLineRadioButton.Text = "Воздушная линия";
			this.airLineRadioButton.UseVisualStyleBackColor = true;
			this.cabelLineRadioButton.AutoSize = true;
			this.cabelLineRadioButton.Location = new global::System.Drawing.Point(6, 16);
			this.cabelLineRadioButton.Name = "cabelLineRadioButton";
			this.cabelLineRadioButton.Size = new global::System.Drawing.Size(113, 17);
			this.cabelLineRadioButton.TabIndex = 0;
			this.cabelLineRadioButton.TabStop = true;
			this.cabelLineRadioButton.Text = "Кабельная линия";
			this.cabelLineRadioButton.UseVisualStyleBackColor = true;
			this.labelNameLine.AutoSize = true;
			this.labelNameLine.Location = new global::System.Drawing.Point(15, 9);
			this.labelNameLine.Name = "labelNameLine";
			this.labelNameLine.Size = new global::System.Drawing.Size(62, 13);
			this.labelNameLine.TabIndex = 5;
			this.labelNameLine.Text = "Имя линии";
			this.textBoxNameLine.Location = new global::System.Drawing.Point(12, 25);
			this.textBoxNameLine.Name = "textBoxNameLine";
			this.textBoxNameLine.Size = new global::System.Drawing.Size(476, 20);
			this.textBoxNameLine.TabIndex = 6;
			this.groupBox3.Controls.Add(this.listBoxOfSupplyCells);
			this.groupBox3.Location = new global::System.Drawing.Point(166, 219);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(322, 87);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Список питающих ячеек";
			this.listBoxOfSupplyCells.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listBoxOfSupplyCells.FormattingEnabled = true;
			this.listBoxOfSupplyCells.Location = new global::System.Drawing.Point(3, 16);
			this.listBoxOfSupplyCells.Name = "listBoxOfSupplyCells";
			this.listBoxOfSupplyCells.Size = new global::System.Drawing.Size(316, 68);
			this.listBoxOfSupplyCells.TabIndex = 0;
			base.AcceptButton = this.OKButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.cancelButton;
			base.ClientSize = new global::System.Drawing.Size(494, 347);
			base.Controls.Add(this.textBoxNameLine);
			base.Controls.Add(this.labelNameLine);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.cancelButton);
			base.Controls.Add(this.OKButton);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "LinePropertyesForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Свойство линии";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.LinePropertyesForm_FormClosing);
			base.Load += new global::System.EventHandler(this.LinePropertyesForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.ListBox destinationListBox;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.Button OKButton;

		private global::System.Windows.Forms.Button cancelButton;

		private global::System.Windows.Forms.GroupBox groupBox2;

		private global::System.Windows.Forms.RadioButton airLineRadioButton;

		private global::System.Windows.Forms.RadioButton cabelLineRadioButton;

		private global::System.Windows.Forms.Label labelNameLine;

		private global::System.Windows.Forms.TextBox textBoxNameLine;

		private global::System.Windows.Forms.GroupBox groupBox3;

		private global::System.Windows.Forms.ListBox listBoxOfSupplyCells;

		private global::System.Windows.Forms.RadioButton radioBtnAirLineProtected;
	}
}
