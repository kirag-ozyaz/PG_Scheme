namespace SchemeCtrl2.Canvas.Forms
{
	public partial class FormCanvasRemoveTransformer : global::System.Windows.Forms.Form
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
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SchemeCtrl2.Canvas.Forms.FormCanvasRemoveTransformer));
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.labelText = new global::System.Windows.Forms.Label();
			this.checkBoxAll = new global::System.Windows.Forms.CheckBox();
			base.SuspendLayout();
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.Yes;
			this.button1.Location = new global::System.Drawing.Point(327, 112);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Удалить";
			this.button1.UseVisualStyleBackColor = true;
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.DialogResult = global::System.Windows.Forms.DialogResult.No;
			this.button2.Location = new global::System.Drawing.Point(246, 112);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "Убрать";
			this.button2.UseVisualStyleBackColor = true;
			this.button3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button3.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button3.Location = new global::System.Drawing.Point(408, 112);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(75, 23);
			this.button3.TabIndex = 0;
			this.button3.Text = "Отмена";
			this.button3.UseVisualStyleBackColor = true;
			this.labelText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.labelText.Location = new global::System.Drawing.Point(12, 9);
			this.labelText.Name = "labelText";
			this.labelText.Size = new global::System.Drawing.Size(464, 78);
			this.labelText.TabIndex = 1;
			this.checkBoxAll.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.checkBoxAll.AutoSize = true;
			this.checkBoxAll.Location = new global::System.Drawing.Point(12, 116);
			this.checkBoxAll.Name = "checkBoxAll";
			this.checkBoxAll.Size = new global::System.Drawing.Size(146, 17);
			this.checkBoxAll.TabIndex = 2;
			this.checkBoxAll.Text = "Использовать для всех";
			this.checkBoxAll.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(495, 147);
			base.Controls.Add(this.checkBoxAll);
			base.Controls.Add(this.labelText);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			this.ForeColor = global::System.Drawing.Color.Black;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(425, 117);
			base.Name = "FormCanvasRemoveTransformer";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Удаление";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.Button button1;

		private global::System.Windows.Forms.Button button2;

		private global::System.Windows.Forms.Button button3;

		private global::System.Windows.Forms.Label labelText;

		private global::System.Windows.Forms.CheckBox checkBoxAll;
	}
}
