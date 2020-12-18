namespace ASCAPC
{
    partial class DlgStructFiderReestr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgStructFiderReestr));
            this.datasetTOK5 = new ASCAPC.DataSet.dsASCAPC();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolBtnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.dgvResultat = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilterN();
            this.StatusForSend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datasetTOK5)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // datasetTOK5
            // 
            this.datasetTOK5.DataSetName = "dsASCAPC";
            this.datasetTOK5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnRefresh,
            this.toolBtnExportExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnRefresh
            // 
            this.toolBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnRefresh.Image")));
            this.toolBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRefresh.Text = "Обновить";
            this.toolBtnRefresh.Click += new System.EventHandler(this.toolBtnRefresh_Click);
            // 
            // toolBtnExportExcel
            // 
            this.toolBtnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnExportExcel.Image")));
            this.toolBtnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnExportExcel.Name = "toolBtnExportExcel";
            this.toolBtnExportExcel.Size = new System.Drawing.Size(23, 22);
            this.toolBtnExportExcel.Text = "toolStripButton1";
            this.toolBtnExportExcel.Click += new System.EventHandler(this.toolBtnExportExcel_Click);
            // 
            // dgvResultat
            // 
            this.dgvResultat.AllowUserToAddRows = false;
            this.dgvResultat.AllowUserToDeleteRows = false;
            this.dgvResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusForSend});
            this.dgvResultat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultat.Location = new System.Drawing.Point(0, 25);
            this.dgvResultat.Name = "dgvResultat";
            this.dgvResultat.ReadOnly = true;
            this.dgvResultat.Size = new System.Drawing.Size(800, 425);
            this.dgvResultat.TabIndex = 1;
            // 
            // StatusForSend
            // 
            this.StatusForSend.HeaderText = "...";
            this.StatusForSend.Name = "StatusForSend";
            this.StatusForSend.ReadOnly = true;
            this.StatusForSend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StatusForSend.ToolTipText = "Для отправки";
            this.StatusForSend.Width = 25;
            // 
            // DlgStructFiderReestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResultat);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DlgStructFiderReestr";
            this.Text = "DlgStructFiderReestr";
            this.Load += new System.EventHandler(this.DlgStructFiderReestr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasetTOK5)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet.dsASCAPC datasetTOK5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilterN dgvResultat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StatusForSend;
        private System.Windows.Forms.ToolStripButton toolBtnRefresh;
        private System.Windows.Forms.ToolStripButton toolBtnExportExcel;
    }
}