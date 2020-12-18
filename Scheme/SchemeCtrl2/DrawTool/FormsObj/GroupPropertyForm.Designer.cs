namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class GroupPropertyForm : global::System.Windows.Forms.Form
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
			this.textBoxNameGroup = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.listBoxGroup = new global::System.Windows.Forms.ListBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.buttonRemObj = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(197, 211);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.textBoxNameGroup.Location = new global::System.Drawing.Point(98, 12);
			this.textBoxNameGroup.Name = "textBoxNameGroup";
			this.textBoxNameGroup.Size = new global::System.Drawing.Size(174, 20);
			this.textBoxNameGroup.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(68, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Имя группы";
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(116, 211);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.listBoxGroup.FormattingEnabled = true;
			this.listBoxGroup.Location = new global::System.Drawing.Point(98, 38);
			this.listBoxGroup.Name = "listBoxGroup";
			this.listBoxGroup.Size = new global::System.Drawing.Size(174, 160);
			this.listBoxGroup.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Члены группы";
			this.buttonRemObj.Location = new global::System.Drawing.Point(12, 99);
			this.buttonRemObj.Name = "buttonRemObj";
			this.buttonRemObj.Size = new global::System.Drawing.Size(77, 42);
			this.buttonRemObj.TabIndex = 0;
			this.buttonRemObj.Text = "Убрать из группы";
			this.buttonRemObj.UseVisualStyleBackColor = true;
			this.buttonRemObj.Click += new global::System.EventHandler(this.buttonRemObj_Click);
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(284, 246);
			base.ControlBox = false;
			base.Controls.Add(this.listBoxGroup);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBoxNameGroup);
			base.Controls.Add(this.buttonRemObj);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.buttonCancel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "GroupPropertiForm";
			this.Text = "Свойства группы";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.GroupPropertyForm_FormClosing);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.TextBox textBoxNameGroup;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.ListBox listBoxGroup;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Button buttonRemObj;
	}
}
