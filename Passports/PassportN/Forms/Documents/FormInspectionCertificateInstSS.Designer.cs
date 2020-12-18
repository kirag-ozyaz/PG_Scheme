namespace Passport.Forms.Documents
{
	public partial class FormInspectionCertificateInstSS : global::System.Windows.Forms.Form
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
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.button1 = new global::System.Windows.Forms.Button();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.dataGridView2 = new global::System.Windows.Forms.DataGridView();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.lbActName = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView2).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 10);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lbActName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 9);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 11;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 23.33333f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 23.33333f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 22f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 36.66667f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 16.66667f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 28f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(671, 605);
			this.tableLayoutPanel1.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label1.Location = new global::System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(665, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Акт";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.tabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new global::System.Drawing.Point(3, 317);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(665, 160);
			this.tabControl1.TabIndex = 1;
			this.button1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.button1.Location = new global::System.Drawing.Point(581, 578);
			this.button1.Margin = new global::System.Windows.Forms.Padding(15, 3, 15, 3);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.dataGridView1.BackgroundColor = global::System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.Blue;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new global::System.Drawing.Point(3, 63);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new global::System.Drawing.Size(665, 100);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView2.BackgroundColor = global::System.Drawing.Color.White;
			this.dataGridView2.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.Blue;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new global::System.Drawing.Point(3, 189);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new global::System.Drawing.Size(665, 100);
			this.dataGridView2.TabIndex = 4;
			this.label2.AutoSize = true;
			this.label2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new global::System.Drawing.Point(3, 166);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(665, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Состояние строительной части:";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.AutoSize = true;
			this.label3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new global::System.Drawing.Point(3, 292);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(665, 22);
			this.label3.TabIndex = 6;
			this.label3.Text = "Состояние электротехнической части";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.AutoSize = true;
			this.label4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new global::System.Drawing.Point(3, 480);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(665, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Выводы комиссии:";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.AutoSize = true;
			this.label5.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new global::System.Drawing.Point(3, 40);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(665, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Состав комисии:";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lbActName.AutoSize = true;
			this.lbActName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lbActName.Location = new global::System.Drawing.Point(3, 20);
			this.lbActName.Name = "lbActName";
			this.lbActName.Size = new global::System.Drawing.Size(665, 20);
			this.lbActName.TabIndex = 9;
			this.lbActName.Text = "label6";
			this.lbActName.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new global::System.Drawing.Point(3, 503);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(665, 69);
			this.textBox1.TabIndex = 10;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(671, 605);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Name = "FormInspectionCertificateInstSS";
			this.Text = "FormInspectionCertificateInstSS";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView2).EndInit();
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.TabControl tabControl1;

		private global::System.Windows.Forms.Button button1;

		private global::System.Windows.Forms.DataGridView dataGridView1;

		private global::System.Windows.Forms.DataGridView dataGridView2;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.Label lbActName;

		private global::System.Windows.Forms.TextBox textBox1;
	}
}
