namespace Legal.Forms.Calculat
{
    partial class FormReportHouseAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportHouseAll));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFilterAbn = new System.Windows.Forms.ToolStripButton();
            this.btnFilterObj = new System.Windows.Forms.ToolStripButton();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.btnClearFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dgvHouse = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilterN();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbObject = new System.Windows.Forms.RadioButton();
            this.rbHouse = new System.Windows.Forms.RadioButton();
            this.cbPrv = new System.Windows.Forms.CheckBox();
            this.cbDNU = new System.Windows.Forms.CheckBox();
            this.cbLegal = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.dsCalc1 = new Legal.DataSet.dsCalc();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFilterAbn,
            this.btnFilterObj,
            this.txtFilter,
            this.btnClearFilter,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(855, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFilterAbn
            // 
            this.btnFilterAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilterAbn.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterAbn.Image")));
            this.btnFilterAbn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterAbn.Name = "btnFilterAbn";
            this.btnFilterAbn.Size = new System.Drawing.Size(23, 22);
            this.btnFilterAbn.ToolTipText = "Фильтр по абоненту";
            this.btnFilterAbn.Click += new System.EventHandler(this.btnFilterAbn_Click);
            // 
            // btnFilterObj
            // 
            this.btnFilterObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilterObj.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterObj.Image")));
            this.btnFilterObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterObj.Name = "btnFilterObj";
            this.btnFilterObj.Size = new System.Drawing.Size(23, 22);
            this.btnFilterObj.Text = "toolStripButton1";
            this.btnFilterObj.ToolTipText = "Фильтр по объекту";
            this.btnFilterObj.Click += new System.EventHandler(this.btnFilterObj_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(500, 25);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(23, 22);
            this.btnClearFilter.ToolTipText = "Очистить фильтр";
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Выгрузка в  Excel";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dgvHouse
            // 
            this.dgvHouse.AllowUserToAddRows = false;
            this.dgvHouse.AllowUserToDeleteRows = false;
            this.dgvHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouse.Location = new System.Drawing.Point(208, 28);
            this.dgvHouse.Name = "dgvHouse";
            this.dgvHouse.ReadOnly = true;
            this.dgvHouse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvHouse.RowHeadersWidth = 20;
            this.dgvHouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouse.Size = new System.Drawing.Size(647, 439);
            this.dgvHouse.TabIndex = 1;
            this.dgvHouse.DoubleClick += new System.EventHandler(this.dgvHouse_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.rbObject);
            this.groupBox1.Controls.Add(this.rbHouse);
            this.groupBox1.Controls.Add(this.cbPrv);
            this.groupBox1.Controls.Add(this.cbDNU);
            this.groupBox1.Controls.Add(this.cbLegal);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.dtBegin);
            this.groupBox1.Location = new System.Drawing.Point(0, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 444);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rbObject
            // 
            this.rbObject.AutoSize = true;
            this.rbObject.Location = new System.Drawing.Point(30, 265);
            this.rbObject.Name = "rbObject";
            this.rbObject.Size = new System.Drawing.Size(90, 17);
            this.rbObject.TabIndex = 67;
            this.rbObject.TabStop = true;
            this.rbObject.Text = "по объектам";
            this.rbObject.UseVisualStyleBackColor = true;
            // 
            // rbHouse
            // 
            this.rbHouse.AutoSize = true;
            this.rbHouse.Location = new System.Drawing.Point(30, 242);
            this.rbHouse.Name = "rbHouse";
            this.rbHouse.Size = new System.Drawing.Size(74, 17);
            this.rbHouse.TabIndex = 66;
            this.rbHouse.TabStop = true;
            this.rbHouse.Text = "по домам";
            this.rbHouse.UseVisualStyleBackColor = true;
            // 
            // cbPrv
            // 
            this.cbPrv.AutoSize = true;
            this.cbPrv.Location = new System.Drawing.Point(30, 197);
            this.cbPrv.Name = "cbPrv";
            this.cbPrv.Size = new System.Drawing.Size(71, 17);
            this.cbPrv.TabIndex = 65;
            this.cbPrv.Text = "Частный";
            this.cbPrv.UseVisualStyleBackColor = true;
            // 
            // cbDNU
            // 
            this.cbDNU.AutoSize = true;
            this.cbDNU.Location = new System.Drawing.Point(30, 163);
            this.cbDNU.Name = "cbDNU";
            this.cbDNU.Size = new System.Drawing.Size(51, 17);
            this.cbDNU.TabIndex = 64;
            this.cbDNU.Text = "ДНУ";
            this.cbDNU.UseVisualStyleBackColor = true;
            // 
            // cbLegal
            // 
            this.cbLegal.AutoSize = true;
            this.cbLegal.Location = new System.Drawing.Point(30, 129);
            this.cbLegal.Name = "cbLegal";
            this.cbLegal.Size = new System.Drawing.Size(79, 17);
            this.cbLegal.TabIndex = 63;
            this.cbLegal.Text = "Госсектор";
            this.cbLegal.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCancel.Location = new System.Drawing.Point(12, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(180, 79);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(16, 23);
            this.btnMinus.TabIndex = 62;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOK.Location = new System.Drawing.Point(12, 348);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 46;
            this.btnOK.Text = "Сформировать";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(180, 50);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(16, 23);
            this.btnPlus.TabIndex = 61;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "За период:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "по:";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(33, 80);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 60;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(33, 51);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 59;
            // 
            // dsCalc1
            // 
            this.dsCalc1.DataSetName = "dsCalc";
            this.dsCalc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormReportHouseAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHouse);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormReportHouseAll";
            this.Text = "Все дома с объектами";
            this.Load += new System.EventHandler(this.FormReportHouseAll_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFilterAbn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilterN dgvHouse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private DataSet.dsCalc dsCalc1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolStripButton btnFilterObj;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.ToolStripButton btnClearFilter;
        private System.Windows.Forms.CheckBox cbPrv;
        private System.Windows.Forms.CheckBox cbDNU;
        private System.Windows.Forms.CheckBox cbLegal;
        private System.Windows.Forms.RadioButton rbObject;
        private System.Windows.Forms.RadioButton rbHouse;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}