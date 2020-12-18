namespace Personnel
{
    partial class FormExportPersonnel
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportPersonnel));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImportPersonnel = new System.Windows.Forms.ToolStripButton();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImportReferens = new System.Windows.Forms.ToolStripButton();
            this.chkSaveDate = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabImport.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabExport.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabImport);
            this.tabControl1.Controls.Add(this.tabExport);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 375);
            this.tabControl1.TabIndex = 3;
            // 
            // tabImport
            // 
            this.tabImport.Controls.Add(this.chkSaveDate);
            this.tabImport.Controls.Add(this.richTextBox1);
            this.tabImport.Controls.Add(this.toolStrip1);
            this.tabImport.Location = new System.Drawing.Point(4, 22);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabImport.Size = new System.Drawing.Size(596, 349);
            this.tabImport.TabIndex = 0;
            this.tabImport.Text = "Импорт";
            this.tabImport.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(590, 318);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportPersonnel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(590, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnImportPersonnel
            // 
            this.btnImportPersonnel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImportPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("btnImportPersonnel.Image")));
            this.btnImportPersonnel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportPersonnel.Name = "btnImportPersonnel";
            this.btnImportPersonnel.Size = new System.Drawing.Size(46, 22);
            this.btnImportPersonnel.Text = "Кадры";
            this.btnImportPersonnel.Click += new System.EventHandler(this.btnImportPersonnel_Click);
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.richTextBox2);
            this.tabExport.Controls.Add(this.toolStrip2);
            this.tabExport.Location = new System.Drawing.Point(4, 22);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabExport.Size = new System.Drawing.Size(596, 349);
            this.tabExport.TabIndex = 1;
            this.tabExport.Text = "Экспорт";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 28);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(590, 318);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.tsbImportReferens});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(590, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbImportReferens
            // 
            this.tsbImportReferens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbImportReferens.Image = ((System.Drawing.Image)(resources.GetObject("tsbImportReferens.Image")));
            this.tsbImportReferens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImportReferens.Name = "tsbImportReferens";
            this.tsbImportReferens.Size = new System.Drawing.Size(69, 22);
            this.tsbImportReferens.Text = "Отправить";
            // 
            // chkSaveDate
            // 
            this.chkSaveDate.AutoSize = true;
            this.chkSaveDate.Location = new System.Drawing.Point(119, 6);
            this.chkSaveDate.Name = "chkSaveDate";
            this.chkSaveDate.Size = new System.Drawing.Size(103, 17);
            this.chkSaveDate.TabIndex = 3;
            this.chkSaveDate.Text = "Запись данных";
            this.chkSaveDate.UseVisualStyleBackColor = true;
            // 
            // FormExportPersonnel
            // 
            this.ClientSize = new System.Drawing.Size(604, 375);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormExportPersonnel";
            this.ShowIcon = false;
            this.Text = "Импорт кадровых данных";
            this.tabControl1.ResumeLayout(false);
            this.tabImport.ResumeLayout(false);
            this.tabImport.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabExport.ResumeLayout(false);
            this.tabExport.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabImport;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnImportPersonnel;
        private System.Windows.Forms.TabPage tabExport;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbImportReferens;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox chkSaveDate;
    }
}