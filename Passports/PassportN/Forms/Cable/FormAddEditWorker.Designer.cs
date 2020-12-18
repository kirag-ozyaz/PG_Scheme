namespace Passport.Forms.Cable
{
	public partial class FormAddEditWorker : global::System.Windows.Forms.Form
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
			this.label1 = new global::System.Windows.Forms.Label();
			this.cbWorker = new global::System.Windows.Forms.ComboBox();
			this.btnAccept = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Сотрудник";
			this.cbWorker.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbWorker.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbWorker.FormattingEnabled = true;
			this.cbWorker.Location = new global::System.Drawing.Point(78, 12);
			this.cbWorker.Name = "cbWorker";
			this.cbWorker.Size = new global::System.Drawing.Size(190, 21);
			this.cbWorker.TabIndex = 1;
			this.cbWorker.SelectedValueChanged += new global::System.EventHandler(this.cbWorker_SelectedValueChanged);
			this.btnAccept.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnAccept.Location = new global::System.Drawing.Point(91, 48);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new global::System.Drawing.Size(85, 23);
			this.btnAccept.TabIndex = 2;
			this.btnAccept.Text = "Применить";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(193, 48);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			base.AcceptButton = this.btnAccept;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(280, 83);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAccept);
			base.Controls.Add(this.cbWorker);
			base.Controls.Add(this.label1);
			base.Name = "FormAddEditWorker";
			this.Text = "FormAddEditWorker";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.ComboBox cbWorker;

		private global::System.Windows.Forms.Button btnAccept;

		private global::System.Windows.Forms.Button btnCancel;
	}
}
