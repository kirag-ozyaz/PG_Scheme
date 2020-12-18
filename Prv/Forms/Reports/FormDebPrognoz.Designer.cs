namespace Prv.Forms.Reports
{
    partial class FormDebPrognoz
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
            this.components = new System.ComponentModel.Container();
            this.cBoxPeriod = new System.Windows.Forms.ComboBox();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreatePrognoz = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxKey = new System.Windows.Forms.ComboBox();
            this.buttonExel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwefPrognoz = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bsDebPrognoz = new System.Windows.Forms.BindingSource(this.components);
            this.dsRep = new Prv.DataSets.DataSetRep();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.raionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.prefixDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.kvDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.KWT = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.attributeDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateKODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRefreshSum = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelSumKWT = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwefPrognoz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDebPrognoz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxPeriod
            // 
            this.cBoxPeriod.FormatString = "MMMM yyyy";
            this.cBoxPeriod.FormattingEnabled = true;
            this.cBoxPeriod.Location = new System.Drawing.Point(65, 10);
            this.cBoxPeriod.Name = "cBoxPeriod";
            this.cBoxPeriod.Size = new System.Drawing.Size(135, 21);
            this.cBoxPeriod.TabIndex = 0;
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(280, 11);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.numericUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownMonth.TabIndex = 4;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Месяцев";
            // 
            // buttonCreatePrognoz
            // 
            this.buttonCreatePrognoz.Location = new System.Drawing.Point(350, 8);
            this.buttonCreatePrognoz.Name = "buttonCreatePrognoz";
            this.buttonCreatePrognoz.Size = new System.Drawing.Size(75, 23);
            this.buttonCreatePrognoz.TabIndex = 6;
            this.buttonCreatePrognoz.Text = "Расчитать";
            this.buttonCreatePrognoz.UseVisualStyleBackColor = true;
            this.buttonCreatePrognoz.Click += new System.EventHandler(this.buttonCreatePrognoz_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.comboBoxKey);
            this.panel2.Controls.Add(this.buttonExel);
            this.panel2.Controls.Add(this.buttonCreatePrognoz);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numericUpDownMonth);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cBoxPeriod);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 38);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxKey
            // 
            this.comboBoxKey.FormattingEnabled = true;
            this.comboBoxKey.Items.AddRange(new object[] {
            "Дорасчет по данным УЭ по месяцам.",
            "Дорасчет по данным УЭ по дням.",
            "Нет дорасчета."});
            this.comboBoxKey.Location = new System.Drawing.Point(450, 10);
            this.comboBoxKey.Name = "comboBoxKey";
            this.comboBoxKey.Size = new System.Drawing.Size(335, 21);
            this.comboBoxKey.TabIndex = 8;
            // 
            // buttonExel
            // 
            this.buttonExel.Image = global::Prv.Properties.Resources._1482423561_export_excel;
            this.buttonExel.Location = new System.Drawing.Point(897, 2);
            this.buttonExel.Name = "buttonExel";
            this.buttonExel.Size = new System.Drawing.Size(36, 34);
            this.buttonExel.TabIndex = 7;
            this.buttonExel.UseVisualStyleBackColor = true;
            this.buttonExel.Click += new System.EventHandler(this.buttonExel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Период";
            // 
            // dgwefPrognoz
            // 
            this.dgwefPrognoz.AllowUserToAddRows = false;
            this.dgwefPrognoz.AllowUserToDeleteRows = false;
            this.dgwefPrognoz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwefPrognoz.AutoGenerateColumns = false;
            this.dgwefPrognoz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwefPrognoz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.raionDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.prefixDataGridViewTextBoxColumn,
            this.kvDataGridViewTextBoxColumn,
            this.KWT,
            this.attributeDataGridViewTextBoxColumn,
            this.dateKODataGridViewTextBoxColumn});
            this.dgwefPrognoz.DataSource = this.bsDebPrognoz;
            this.dgwefPrognoz.Location = new System.Drawing.Point(-2, 36);
            this.dgwefPrognoz.Name = "dgwefPrognoz";
            this.dgwefPrognoz.ReadOnly = true;
            this.dgwefPrognoz.RowHeadersWidth = 21;
            this.dgwefPrognoz.Size = new System.Drawing.Size(936, 646);
            this.dgwefPrognoz.TabIndex = 2;
            this.dgwefPrognoz.Paint += new System.Windows.Forms.PaintEventHandler(this.dgwefPrognoz_Paint);
            // 
            // bsDebPrognoz
            // 
            this.bsDebPrognoz.DataMember = "fn_AbnDebitorkaBS_new";
            this.bsDebPrognoz.DataSource = this.dsRep;
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "DataSetRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Л.счет";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ф.И.О.";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // raionDataGridViewTextBoxColumn
            // 
            this.raionDataGridViewTextBoxColumn.DataPropertyName = "Raion";
            this.raionDataGridViewTextBoxColumn.HeaderText = "Район";
            this.raionDataGridViewTextBoxColumn.Name = "raionDataGridViewTextBoxColumn";
            this.raionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            this.houseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // prefixDataGridViewTextBoxColumn
            // 
            this.prefixDataGridViewTextBoxColumn.DataPropertyName = "Prefix";
            this.prefixDataGridViewTextBoxColumn.HeaderText = "Префикс";
            this.prefixDataGridViewTextBoxColumn.Name = "prefixDataGridViewTextBoxColumn";
            this.prefixDataGridViewTextBoxColumn.ReadOnly = true;
            this.prefixDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // kvDataGridViewTextBoxColumn
            // 
            this.kvDataGridViewTextBoxColumn.DataPropertyName = "kv";
            this.kvDataGridViewTextBoxColumn.HeaderText = "кв.";
            this.kvDataGridViewTextBoxColumn.Name = "kvDataGridViewTextBoxColumn";
            this.kvDataGridViewTextBoxColumn.ReadOnly = true;
            this.kvDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // KWT
            // 
            this.KWT.DataPropertyName = "KWT";
            this.KWT.HeaderText = "кВт";
            this.KWT.Name = "KWT";
            this.KWT.ReadOnly = true;
            this.KWT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // attributeDataGridViewTextBoxColumn
            // 
            this.attributeDataGridViewTextBoxColumn.DataPropertyName = "Attribute";
            this.attributeDataGridViewTextBoxColumn.HeaderText = "Расчет";
            this.attributeDataGridViewTextBoxColumn.Name = "attributeDataGridViewTextBoxColumn";
            this.attributeDataGridViewTextBoxColumn.ReadOnly = true;
            this.attributeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateKODataGridViewTextBoxColumn
            // 
            this.dateKODataGridViewTextBoxColumn.DataPropertyName = "DateKO";
            this.dateKODataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateKODataGridViewTextBoxColumn.Name = "dateKODataGridViewTextBoxColumn";
            this.dateKODataGridViewTextBoxColumn.ReadOnly = true;
            this.dateKODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRefreshSum,
            this.toolStripLabelSumKWT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 685);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonRefreshSum
            // 
            this.toolStripButtonRefreshSum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonRefreshSum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefreshSum.Image = global::Prv.Properties.Resources.Refresh;
            this.toolStripButtonRefreshSum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefreshSum.Name = "toolStripButtonRefreshSum";
            this.toolStripButtonRefreshSum.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefreshSum.Text = "Refresh";
            this.toolStripButtonRefreshSum.Visible = false;
            this.toolStripButtonRefreshSum.Click += new System.EventHandler(this.toolStripButtonRefreshSum_Click);
            // 
            // toolStripLabelSumKWT
            // 
            this.toolStripLabelSumKWT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelSumKWT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabelSumKWT.Name = "toolStripLabelSumKWT";
            this.toolStripLabelSumKWT.Size = new System.Drawing.Size(0, 22);
            // 
            // FormDebPrognoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 710);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgwefPrognoz);
            this.Controls.Add(this.panel2);
            this.Name = "FormDebPrognoz";
            this.Text = "Прогноз";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwefPrognoz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDebPrognoz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxPeriod;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreatePrognoz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgwefPrognoz;
        private System.Windows.Forms.BindingSource bsDebPrognoz;
        private DataSets.DataSetRep dsRep;
        private System.Windows.Forms.Button buttonExel;
        private System.Windows.Forms.ComboBox comboBoxKey;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raionDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn streetDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn houseDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn prefixDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn kvDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn KWT;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn attributeDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dateKODataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefreshSum;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSumKWT;

    }
}