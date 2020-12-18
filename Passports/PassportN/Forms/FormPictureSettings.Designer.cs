namespace Passport.Forms
{
	public partial class FormPictureSettings : global::System.Windows.Forms.Form
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
			this.tlpImage = new global::System.Windows.Forms.TableLayoutPanel();
			this.tbrImage = new global::System.Windows.Forms.TrackBar();
			this.pbImage = new global::System.Windows.Forms.PictureBox();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.tlpImage.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbrImage).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbImage).BeginInit();
			base.SuspendLayout();
			this.tlpImage.ColumnCount = 2;
			this.tlpImage.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tlpImage.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 50f));
			this.tlpImage.Controls.Add(this.tbrImage, 1, 0);
			this.tlpImage.Controls.Add(this.pbImage, 0, 0);
			this.tlpImage.Controls.Add(this.btnOk, 0, 1);
			this.tlpImage.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tlpImage.Location = new global::System.Drawing.Point(0, 0);
			this.tlpImage.Name = "tlpImage";
			this.tlpImage.RowCount = 2;
			this.tlpImage.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tlpImage.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 31f));
			this.tlpImage.Size = new global::System.Drawing.Size(353, 413);
			this.tlpImage.TabIndex = 0;
			this.tbrImage.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tbrImage.Location = new global::System.Drawing.Point(306, 3);
			this.tbrImage.Maximum = 100;
			this.tbrImage.Name = "tbrImage";
			this.tbrImage.Orientation = global::System.Windows.Forms.Orientation.Vertical;
			this.tbrImage.Size = new global::System.Drawing.Size(44, 376);
			this.tbrImage.TabIndex = 0;
			this.tbrImage.TickStyle = global::System.Windows.Forms.TickStyle.Both;
			this.tbrImage.Value = 30;
			this.tbrImage.ValueChanged += new global::System.EventHandler(this.tbrImage_ValueChanged);
			this.pbImage.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pbImage.Location = new global::System.Drawing.Point(3, 3);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new global::System.Drawing.Size(297, 376);
			this.pbImage.TabIndex = 1;
			this.pbImage.TabStop = false;
			this.btnOk.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnOk.Location = new global::System.Drawing.Point(206, 385);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(94, 25);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "Сохранить";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(353, 413);
			base.Controls.Add(this.tlpImage);
			base.Name = "FormPictureSettings";
			this.Text = "Параметры сжатия";
			this.tlpImage.ResumeLayout(false);
			this.tlpImage.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbrImage).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbImage).EndInit();
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.TableLayoutPanel tlpImage;

		private global::System.Windows.Forms.TrackBar tbrImage;

		private global::System.Windows.Forms.PictureBox pbImage;

		private global::System.Windows.Forms.Button btnOk;
	}
}
