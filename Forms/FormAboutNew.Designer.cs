namespace EIS.Forms
{
    partial class FormAboutNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutNew));
            this.Field11 = new System.Windows.Forms.PictureBox();
            this.Field10 = new System.Windows.Forms.Label();
            this.Field9 = new System.Windows.Forms.Label();
            this.Field8 = new System.Windows.Forms.Button();
            this.Field7 = new System.Windows.Forms.DataGridView();
            this.Field6 = new System.Windows.Forms.Label();
            this.Field5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)this.Field11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.Field7).BeginInit();
            base.SuspendLayout();
            this.Field11.Dock = System.Windows.Forms.DockStyle.Top;
            this.Field11.Image = global::EIS.Properties.Resources.logo_full_trans;

            this.Field11.Location = new System.Drawing.Point(9, 9);
            this.Field11.Name = "pictureBoxCoder";
            this.Field11.Size = new System.Drawing.Size(666, 183);
            this.Field11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Field11.TabIndex = 0;
            this.Field11.TabStop = false;
            this.Field10.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.Field10.Font = new System.Drawing.Font(clRSACrypto.Method39(1908), 16f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Field10.Location = new System.Drawing.Point(9, 195);
            this.Field10.Name = clRSACrypto.Method39(1952);
            this.Field10.Size = new System.Drawing.Size(666, 34);
            this.Field10.TabIndex = 1;
            this.Field10.Text = "Программно-технический комплекс \"Энергосхема\"";
            this.Field10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Field9.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.Field9.Location = new System.Drawing.Point(6, 407);
            this.Field9.Name = clRSACrypto.Method39(2068);
            this.Field9.Size = new System.Drawing.Size(669, 33);
            this.Field9.TabIndex = 2;
            this.Field9.Text = resources.GetString("label1.Text");
            this.Field8.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.Field8.Location = new System.Drawing.Point(600, 443);
            this.Field8.Name = clRSACrypto.Method39(2110);
            this.Field8.Size = new System.Drawing.Size(75, 23);
            this.Field8.TabIndex = 3;
            this.Field8.Text = clRSACrypto.Method39(2130);
            this.Field8.UseVisualStyleBackColor = true;
            this.Field8.Click += new System.EventHandler(this.Method50);
            this.Field7.AllowUserToAddRows = false;
            this.Field7.AllowUserToDeleteRows = false;
            this.Field7.AllowUserToOrderColumns = true;
            this.Field7.AllowUserToResizeRows = false;
            this.Field7.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.Field7.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Field7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Field7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
        this.Field5,
        this.Field4,
        this.Field3,
        this.Field2
            });
            this.Field7.Location = new System.Drawing.Point(9, 241);
            this.Field7.MultiSelect = false;
            this.Field7.Name = "dgvDlls";
            this.Field7.ReadOnly = true;
            this.Field7.RowHeadersVisible = false;
            this.Field7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Field7.Size = new System.Drawing.Size(666, 163);
            this.Field7.TabIndex = 4;
            this.Field6.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.Field6.Location = new System.Drawing.Point(6, 225);
            this.Field6.Name = clRSACrypto.Method39(2156);
            this.Field6.Size = new System.Drawing.Size(669, 13);
            this.Field6.TabIndex = 5;
            this.Field6.Text = clRSACrypto.Method39(2172);
            this.Field6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Field5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Field5.HeaderText = "Установленные модули";
            this.Field5.Name = clRSACrypto.Method39(2372);
            this.Field5.ReadOnly = true;
            this.Field4.HeaderText = "DLL";
            this.Field4.Name = clRSACrypto.Method39(2420);
            this.Field4.ReadOnly = true;
            this.Field4.Visible = false;
            this.Field3.HeaderText = "Версия";
            this.Field3.Name = "columnVersion";
            this.Field3.ReadOnly = true;
            this.Field3.Width = 200;
            this.Field2.HeaderText = clRSACrypto.Method39(2488);
            this.Field2.Name = clRSACrypto.Method39(2508);
            this.Field2.ReadOnly = true;
            this.Field1.AutoSize = true;
            this.Field1.Location = new System.Drawing.Point(6, 453);
            this.Field1.Name = "label3";
            this.Field1.Size = new System.Drawing.Size(158, 13);
            this.Field1.TabIndex = 6;
            this.Field1.Text = clRSACrypto.Method39(2554);
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(684, 474);
            base.Controls.Add(this.Field1);
            base.Controls.Add(this.Field6);
            base.Controls.Add(this.Field7);
            base.Controls.Add(this.Field8);
            base.Controls.Add(this.Field9);
            base.Controls.Add(this.Field10);
            base.Controls.Add(this.Field11);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            base.Icon = (System.Drawing.Icon)resources.GetObject(clRSACrypto.Method39(2610));
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FormAboutNew";
            base.Padding = new System.Windows.Forms.Padding(9);
            base.ShowInTaskbar = false;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            base.Load += new System.EventHandler(this.FormAboutNew_Load);
            ((System.ComponentModel.ISupportInitialize)this.Field11).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.Field7).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.button1 = new System.Windows.Forms.Button();
        //    this.SuspendLayout();
        //    // 
        //    // button1
        //    // 
        //    this.button1.Location = new System.Drawing.Point(166, 116);
        //    this.button1.Name = "button1";
        //    this.button1.Size = new System.Drawing.Size(75, 23);
        //    this.button1.TabIndex = 0;
        //    this.button1.Text = "button1";
        //    this.button1.UseVisualStyleBackColor = true;
        //    // 
        //    // FormAboutNew
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(284, 262);
        //    this.Controls.Add(this.button1);
        //    this.Name = "FormAboutNew";
        //    this.Text = "Form1";
        //    this.ResumeLayout(false);

        //}

        #endregion

        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Field11;
        private System.Windows.Forms.Label Field10;
        private System.Windows.Forms.Label Field9;
        private System.Windows.Forms.Button Field8;
        private System.Windows.Forms.DataGridView Field7;
        private System.Windows.Forms.Label Field6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field2;
        private System.Windows.Forms.Label Field1;
    }
}