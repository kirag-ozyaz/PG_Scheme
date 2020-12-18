namespace ASCAPC
{
    partial class DlgImportToTok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgImportToTok));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbLoad80200 = new System.Windows.Forms.ToolStripButton();
            this.tsbStruktFider = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripDropDownButton();
            this.datasetTOK5 = new ASCAPC.DataSet.dsASCAPC();
            this.rtLogger = new System.Windows.Forms.RichTextBox();
            this.tsbUMZ = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogUMZ = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetTOK5)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "XML files|*.xml";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Browse XML Files";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoad80200,
            this.tsbUMZ,
            this.tsbStruktFider});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(780, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbLoad80200
            // 
            this.tsbLoad80200.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLoad80200.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoad80200.Image")));
            this.tsbLoad80200.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoad80200.Name = "tsbLoad80200";
            this.tsbLoad80200.Size = new System.Drawing.Size(41, 22);
            this.tsbLoad80200.Text = "80200";
            this.tsbLoad80200.Click += new System.EventHandler(this.tsbLoad80200_Click);
            // 
            // tsbStruktFider
            // 
            this.tsbStruktFider.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStruktFider.Image = ((System.Drawing.Image)(resources.GetObject("tsbStruktFider.Image")));
            this.tsbStruktFider.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStruktFider.Name = "tsbStruktFider";
            this.tsbStruktFider.Size = new System.Drawing.Size(164, 22);
            this.tsbStruktFider.Text = "Структура точек измерения";
            this.tsbStruktFider.Click += new System.EventHandler(this.tsbStruktFider_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(54, 20);
            this.tsbClose.Text = "Выход";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // datasetTOK5
            // 
            this.datasetTOK5.DataSetName = "dsASCAPC";
            this.datasetTOK5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtLogger
            // 
            this.rtLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtLogger.Location = new System.Drawing.Point(0, 25);
            this.rtLogger.Name = "rtLogger";
            this.rtLogger.Size = new System.Drawing.Size(780, 345);
            this.rtLogger.TabIndex = 3;
            this.rtLogger.Text = "";
            // 
            // tsbUMZ
            // 
            this.tsbUMZ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUMZ.Image = ((System.Drawing.Image)(resources.GetObject("tsbUMZ.Image")));
            this.tsbUMZ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUMZ.Name = "tsbUMZ";
            this.tsbUMZ.Size = new System.Drawing.Size(36, 22);
            this.tsbUMZ.Text = "УМЗ";
            this.tsbUMZ.Click += new System.EventHandler(this.tsbUMZ_Click);
            // 
            // openFileDialogUMZ
            // 
            this.openFileDialogUMZ.DefaultExt = "xml";
            this.openFileDialogUMZ.Filter = "XLSX files|*.xlsx";
            this.openFileDialogUMZ.Multiselect = true;
            this.openFileDialogUMZ.RestoreDirectory = true;
            this.openFileDialogUMZ.Title = "Browse XLSX Files UMZ";
            // 
            // DlgImportToTok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 392);
            this.Controls.Add(this.rtLogger);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DlgImportToTok";
            this.Text = "DlgImportToTok";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetTOK5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbLoad80200;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsbClose;
        private DataSet.dsASCAPC datasetTOK5;
        private System.Windows.Forms.RichTextBox rtLogger;
        private System.Windows.Forms.ToolStripButton tsbStruktFider;
        private System.Windows.Forms.ToolStripButton tsbUMZ;
        private System.Windows.Forms.OpenFileDialog openFileDialogUMZ;
    }
}