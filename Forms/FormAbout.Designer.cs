using System.Windows.Forms;

namespace EIS.Forms
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.TableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.TableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel8
            // 
            this.TableLayoutPanel8.ColumnCount = 2;
            this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.TableLayoutPanel8.Controls.Add(this.PictureBox7, 0, 0);
            this.TableLayoutPanel8.Controls.Add(this.Label5, 1, 1);
            this.TableLayoutPanel8.Controls.Add(this.Label4, 1, 2);
            this.TableLayoutPanel8.Controls.Add(this.Label3, 1, 3);
            this.TableLayoutPanel8.Controls.Add(this.TextBox2, 1, 4);
            this.TableLayoutPanel8.Controls.Add(this.Button1, 1, 5);
            this.TableLayoutPanel8.Controls.Add(this.Label6, 1, 0);
            this.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel8.Location = new System.Drawing.Point(9, 9);
            this.TableLayoutPanel8.Name = "TableLayoutPanel8";
            this.TableLayoutPanel8.RowCount = 6;
            this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.20755F));
            this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.301887F));
            this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.301887F));
            this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.679245F));
            this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
            this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel8.Size = new System.Drawing.Size(417, 265);
            this.TableLayoutPanel8.TabIndex = 0;
            // 
            // PictureBox7
            // 
            this.PictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox7.Image = global::EIS.Properties.Resources.logo_full_trans;
            this.PictureBox7.Location = new System.Drawing.Point(3, 3);
            this.PictureBox7.Name = "PictureBox7";
            this.TableLayoutPanel8.SetRowSpan(this.PictureBox7, 6);
            this.PictureBox7.Size = new System.Drawing.Size(131, 259);
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox7.TabIndex = 12;
            this.PictureBox7.TabStop = false;
            // 
            // Label5
            // 
            this.Label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label5.Location = new System.Drawing.Point(143, 35);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.Label5.MaximumSize = new System.Drawing.Size(0, 17);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(271, 17);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Version";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label4.Location = new System.Drawing.Point(143, 57);
            this.Label4.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.Label4.MaximumSize = new System.Drawing.Size(0, 17);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(271, 17);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Copyright";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label3.Location = new System.Drawing.Point(143, 79);
            this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.Label3.MaximumSize = new System.Drawing.Size(0, 17);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(271, 17);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Company Name";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox2
            // 
            this.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox2.Location = new System.Drawing.Point(143, 105);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox2.Size = new System.Drawing.Size(271, 129);
            this.TextBox2.TabIndex = 23;
            this.TextBox2.TabStop = false;
            this.TextBox2.Text = "Description";
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button1.Location = new System.Drawing.Point(339, 240);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 22);
            this.Button1.TabIndex = 24;
            this.Button1.Text = "&OK";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label6.ForeColor = System.Drawing.Color.Red;
            this.Label6.Location = new System.Drawing.Point(143, 0);
            this.Label6.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(271, 35);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "K W T";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAbout
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this.TableLayoutPanel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.TableLayoutPanel8.ResumeLayout(false);
            this.TableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        private TableLayoutPanel TableLayoutPanel8;
        private PictureBox PictureBox7;
        private Label Label6;
        private Label Label5;
        private Label Label4;
        private Label Label3;
        private TextBox TextBox2;
        private Button Button1;
    }
}
