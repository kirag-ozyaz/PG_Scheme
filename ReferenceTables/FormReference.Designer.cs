namespace Reference
{
    partial class FormReference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReference));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolBtnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLabelPeriodKWT = new System.Windows.Forms.ToolStripLabel();
            this.toolBtnLoad = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSend = new System.Windows.Forms.ToolStripButton();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabVedomosty = new System.Windows.Forms.TabPage();
            this.dgvResultat = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilterN();
            this.StatusForSend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabVedomosty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnRefresh,
            this.toolBtnExportExcel,
            this.toolStripSeparator1,
            this.toolLabelPeriodKWT,
            this.toolBtnLoad,
            this.toolBtnSend});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 10;
            this.toolStrip.Text = "toolStrip1";
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
            this.toolBtnExportExcel.Text = "Выгрузка в Excel";
            this.toolBtnExportExcel.Click += new System.EventHandler(this.toolBtnExportExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolLabelPeriodKWT
            // 
            this.toolLabelPeriodKWT.Name = "toolLabelPeriodKWT";
            this.toolLabelPeriodKWT.Size = new System.Drawing.Size(103, 22);
            this.toolLabelPeriodKWT.Text = "Период выгрузки";
            // 
            // toolBtnLoad
            // 
            this.toolBtnLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnLoad.Image")));
            this.toolBtnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnLoad.Name = "toolBtnLoad";
            this.toolBtnLoad.Size = new System.Drawing.Size(111, 22);
            this.toolBtnLoad.Text = "Сформировать";
            this.toolBtnLoad.Click += new System.EventHandler(this.toolBtnLoad_Click);
            // 
            // toolBtnSend
            // 
            this.toolBtnSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSend.Image = global::References.Properties.Resources.Send;
            this.toolBtnSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSend.Name = "toolBtnSend";
            this.toolBtnSend.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSend.Text = "Отправить почтой";
            this.toolBtnSend.Click += new System.EventHandler(this.toolBtnSend_Click);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabVedomosty);
            this.tabGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGeneral.Location = new System.Drawing.Point(0, 25);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(800, 425);
            this.tabGeneral.TabIndex = 11;
            // 
            // tabVedomosty
            // 
            this.tabVedomosty.Controls.Add(this.dgvResultat);
            this.tabVedomosty.Location = new System.Drawing.Point(4, 22);
            this.tabVedomosty.Name = "tabVedomosty";
            this.tabVedomosty.Padding = new System.Windows.Forms.Padding(3);
            this.tabVedomosty.Size = new System.Drawing.Size(792, 399);
            this.tabVedomosty.TabIndex = 0;
            this.tabVedomosty.Text = "Ведомость";
            this.tabVedomosty.UseVisualStyleBackColor = true;
            // 
            // dgvResultat
            // 
            this.dgvResultat.AllowUserToAddRows = false;
            this.dgvResultat.AllowUserToDeleteRows = false;
            this.dgvResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusForSend});
            this.dgvResultat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultat.Location = new System.Drawing.Point(3, 3);
            this.dgvResultat.Name = "dgvResultat";
            this.dgvResultat.ReadOnly = true;
            this.dgvResultat.Size = new System.Drawing.Size(786, 393);
            this.dgvResultat.TabIndex = 0;
            this.dgvResultat.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSendME_DataError);
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
            // FormReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabGeneral);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormReference";
            this.Text = "Ведомость";
            this.Load += new System.EventHandler(this.FormCorrectiveStatements_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabVedomosty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolBtnRefresh;
        private System.Windows.Forms.ToolStripButton toolBtnExportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolLabelPeriodKWT;
        private System.Windows.Forms.ToolStripButton toolBtnLoad;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabVedomosty;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilterN dgvResultat;
        private System.Windows.Forms.DateTimePicker dateTimePeriodKWT;
        private System.Windows.Forms.ComboBox cmbVedomosty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StatusForSend;
        private System.Windows.Forms.ToolStripButton toolBtnSend;
    }
}