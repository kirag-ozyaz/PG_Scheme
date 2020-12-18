namespace Legal.Forms.Object
{
    partial class FormReportPower
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
            System.Windows.Forms.Button btnWord;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCalc1 = new Legal.DataSet.dsCalc();
            this.btnReportPower = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minPower = new System.Windows.Forms.NumericUpDown();
            this.maxPower = new System.Windows.Forms.NumericUpDown();
            this.dgvTotal = new System.Windows.Forms.DataGridView();
            this.voltageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerSetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedPowerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWord
            // 
            btnWord.Location = new System.Drawing.Point(39, 319);
            btnWord.Name = "btnWord";
            btnWord.Size = new System.Drawing.Size(131, 23);
            btnWord.TabIndex = 110;
            btnWord.Text = "экспорт в Word";
            btnWord.UseVisualStyleBackColor = true;
            btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(176, 64);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(16, 23);
            this.btnMinus.TabIndex = 96;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(176, 35);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(16, 23);
            this.btnPlus.TabIndex = 95;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "За период:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "по:";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(39, 63);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 94;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(39, 34);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 93;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "tG_ReportPower_Total";
            this.bindingSource2.DataSource = this.dsCalc1;
            // 
            // dsCalc1
            // 
            this.dsCalc1.DataSetName = "dsCalc";
            this.dsCalc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReportPower
            // 
            this.btnReportPower.Location = new System.Drawing.Point(39, 269);
            this.btnReportPower.Name = "btnReportPower";
            this.btnReportPower.Size = new System.Drawing.Size(131, 23);
            this.btnReportPower.TabIndex = 99;
            this.btnReportPower.Text = "Сформировать";
            this.btnReportPower.UseVisualStyleBackColor = true;
            this.btnReportPower.Click += new System.EventHandler(this.btnReportPower_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(39, 476);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 23);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Диапазон максимальной мощности:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "минимум:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "максимум:";
            // 
            // minPower
            // 
            this.minPower.Location = new System.Drawing.Point(82, 147);
            this.minPower.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minPower.Name = "minPower";
            this.minPower.Size = new System.Drawing.Size(88, 20);
            this.minPower.TabIndex = 108;
            // 
            // maxPower
            // 
            this.maxPower.Location = new System.Drawing.Point(82, 180);
            this.maxPower.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxPower.Name = "maxPower";
            this.maxPower.Size = new System.Drawing.Size(88, 20);
            this.maxPower.TabIndex = 109;
            // 
            // dgvTotal
            // 
            this.dgvTotal.AllowUserToAddRows = false;
            this.dgvTotal.AllowUserToDeleteRows = false;
            this.dgvTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTotal.AutoGenerateColumns = false;
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voltageDataGridViewTextBoxColumn1,
            this.powerSetDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn,
            this.reservedPowerDataGridViewTextBoxColumn1});
            this.dgvTotal.DataSource = this.bindingSource2;
            this.dgvTotal.Location = new System.Drawing.Point(211, 1);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            this.dgvTotal.RowHeadersWidth = 5;
            this.dgvTotal.Size = new System.Drawing.Size(600, 532);
            this.dgvTotal.TabIndex = 1;
            // 
            // voltageDataGridViewTextBoxColumn1
            // 
            this.voltageDataGridViewTextBoxColumn1.DataPropertyName = "Voltage";
            this.voltageDataGridViewTextBoxColumn1.HeaderText = "Уровень напряжения";
            this.voltageDataGridViewTextBoxColumn1.Name = "voltageDataGridViewTextBoxColumn1";
            this.voltageDataGridViewTextBoxColumn1.ReadOnly = true;
            this.voltageDataGridViewTextBoxColumn1.Width = 150;
            // 
            // powerSetDataGridViewTextBoxColumn1
            // 
            this.powerSetDataGridViewTextBoxColumn1.DataPropertyName = "PowerSet";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.powerSetDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.powerSetDataGridViewTextBoxColumn1.HeaderText = "Мощность максимальная";
            this.powerSetDataGridViewTextBoxColumn1.Name = "powerSetDataGridViewTextBoxColumn1";
            this.powerSetDataGridViewTextBoxColumn1.ReadOnly = true;
            this.powerSetDataGridViewTextBoxColumn1.Width = 170;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Объем";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservedPowerDataGridViewTextBoxColumn1
            // 
            this.reservedPowerDataGridViewTextBoxColumn1.DataPropertyName = "ReservedPower";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.reservedPowerDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.reservedPowerDataGridViewTextBoxColumn1.HeaderText = "Мощность резервируемая";
            this.reservedPowerDataGridViewTextBoxColumn1.Name = "reservedPowerDataGridViewTextBoxColumn1";
            this.reservedPowerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.reservedPowerDataGridViewTextBoxColumn1.Width = 170;
            // 
            // FormReportPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 533);
            this.Controls.Add(this.dgvTotal);
            this.Controls.Add(btnWord);
            this.Controls.Add(this.maxPower);
            this.Controls.Add(this.minPower);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReportPower);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtBegin);
            this.Name = "FormReportPower";
            this.Text = "Отчет по резервируемой мощновти";
            this.Load += new System.EventHandler(this.FormReportPower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Button btnReportPower;
        private System.Windows.Forms.Button btnCancel;
        private DataSet.dsCalc dsCalc1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown minPower;
        private System.Windows.Forms.NumericUpDown maxPower;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridView dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerSetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservedPowerDataGridViewTextBoxColumn1;
    }
}