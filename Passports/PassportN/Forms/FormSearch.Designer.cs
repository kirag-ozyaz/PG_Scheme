namespace Passport.Forms
{
	public partial class FormSearch : global::System.Windows.Forms.Form
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
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.btnSearch = new global::System.Windows.Forms.Button();
			this.btnNextSearch = new global::System.Windows.Forms.Button();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.comboBox1.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBox1.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(51, 46);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(275, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.textBox1.Location = new global::System.Drawing.Point(53, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(273, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.btnSearch.Enabled = false;
			this.btnSearch.Location = new global::System.Drawing.Point(69, 82);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new global::System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Найти";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.btnNextSearch.Enabled = false;
			this.btnNextSearch.Location = new global::System.Drawing.Point(150, 82);
			this.btnNextSearch.Name = "btnNextSearch";
			this.btnNextSearch.Size = new global::System.Drawing.Size(97, 23);
			this.btnNextSearch.TabIndex = 3;
			this.btnNextSearch.Text = "Найти далее";
			this.btnNextSearch.UseVisualStyleBackColor = true;
			this.btnNextSearch.Click += new global::System.EventHandler(this.btnNextSearch_Click);
			this.btnClose.Location = new global::System.Drawing.Point(253, 82);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new global::System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 49);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(33, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Поле";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 18);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(37, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Текст";
			base.AcceptButton = this.btnSearch;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(338, 115);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.btnNextSearch);
			base.Controls.Add(this.btnSearch);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.comboBox1);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(354, 153);
			this.MinimumSize = new global::System.Drawing.Size(354, 153);
			base.Name = "FormSearch";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Поиск";
			base.Load += new global::System.EventHandler(this.FormSearch_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.ComboBox comboBox1;

		private global::System.Windows.Forms.TextBox textBox1;

		private global::System.Windows.Forms.Button btnSearch;

		private global::System.Windows.Forms.Button btnNextSearch;

		private global::System.Windows.Forms.Button btnClose;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.Label label2;
	}
}
