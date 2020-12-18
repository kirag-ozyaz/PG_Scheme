namespace Legal.Forms.Calculat
{
    partial class FormReportCorrect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCalc1 = new Legal.DataSet.dsCalc();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.numabn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numfact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dif1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dif2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numabn,
            this.name,
            this.dtPayDataGridViewTextBoxColumn,
            this.numfact,
            this.datefact,
            this.q1,
            this.s1,
            this.n1,
            this.t1,
            this.numcor,
            this.datecor,
            this.q2,
            this.s2,
            this.n2,
            this.t2,
            this.dif1,
            this.dif2});
            this.dgv.DataSource = this.bindingSource1;
            this.dgv.Location = new System.Drawing.Point(218, -1);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 10;
            this.dgv.Size = new System.Drawing.Size(677, 459);
            this.dgv.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vG_ReportCorrectFact";
            this.bindingSource1.DataSource = this.dsCalc1;
            // 
            // dsCalc1
            // 
            this.dsCalc1.DataSetName = "dsCalc";
            this.dsCalc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(186, 62);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(16, 23);
            this.btnMinus.TabIndex = 62;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(186, 33);
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
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "За период:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "по:";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(39, 63);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 60;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(39, 34);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 59;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(61, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOK.Location = new System.Drawing.Point(61, 372);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 63;
            this.btnOK.Text = "Сформировать";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // numabn
            // 
            this.numabn.DataPropertyName = "CodeAbonent";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.numabn.DefaultCellStyle = dataGridViewCellStyle1;
            this.numabn.FillWeight = 75F;
            this.numabn.HeaderText = "№дог";
            this.numabn.Name = "numabn";
            this.numabn.ReadOnly = true;
            this.numabn.Width = 65;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Потребитель";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // dtPayDataGridViewTextBoxColumn
            // 
            this.dtPayDataGridViewTextBoxColumn.DataPropertyName = "dtPay";
            this.dtPayDataGridViewTextBoxColumn.HeaderText = "dtPay";
            this.dtPayDataGridViewTextBoxColumn.Name = "dtPayDataGridViewTextBoxColumn";
            this.dtPayDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtPayDataGridViewTextBoxColumn.Visible = false;
            // 
            // numfact
            // 
            this.numfact.DataPropertyName = "Number1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.numfact.DefaultCellStyle = dataGridViewCellStyle2;
            this.numfact.HeaderText = "№факт";
            this.numfact.Name = "numfact";
            this.numfact.ReadOnly = true;
            this.numfact.Width = 65;
            // 
            // datefact
            // 
            this.datefact.DataPropertyName = "Date1";
            this.datefact.FillWeight = 75F;
            this.datefact.HeaderText = "Дата";
            this.datefact.Name = "datefact";
            this.datefact.ReadOnly = true;
            // 
            // q1
            // 
            this.q1.DataPropertyName = "SumQuantity1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.q1.DefaultCellStyle = dataGridViewCellStyle3;
            this.q1.HeaderText = "Количество";
            this.q1.Name = "q1";
            this.q1.ReadOnly = true;
            // 
            // s1
            // 
            this.s1.DataPropertyName = "SumRealiz1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.s1.DefaultCellStyle = dataGridViewCellStyle4;
            this.s1.HeaderText = "Сумма";
            this.s1.Name = "s1";
            this.s1.ReadOnly = true;
            // 
            // n1
            // 
            this.n1.DataPropertyName = "SumNalog1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.n1.DefaultCellStyle = dataGridViewCellStyle5;
            this.n1.HeaderText = "Налог";
            this.n1.Name = "n1";
            this.n1.ReadOnly = true;
            // 
            // t1
            // 
            this.t1.DataPropertyName = "SumTotal1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.t1.DefaultCellStyle = dataGridViewCellStyle6;
            this.t1.HeaderText = "Всего";
            this.t1.Name = "t1";
            this.t1.ReadOnly = true;
            // 
            // numcor
            // 
            this.numcor.DataPropertyName = "Number2";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.numcor.DefaultCellStyle = dataGridViewCellStyle7;
            this.numcor.HeaderText = "№кор";
            this.numcor.Name = "numcor";
            this.numcor.ReadOnly = true;
            this.numcor.Width = 65;
            // 
            // datecor
            // 
            this.datecor.DataPropertyName = "Date2";
            this.datecor.FillWeight = 75F;
            this.datecor.HeaderText = "Дата";
            this.datecor.Name = "datecor";
            this.datecor.ReadOnly = true;
            // 
            // q2
            // 
            this.q2.DataPropertyName = "SumQuantity2";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.q2.DefaultCellStyle = dataGridViewCellStyle8;
            this.q2.HeaderText = "Количество";
            this.q2.Name = "q2";
            this.q2.ReadOnly = true;
            // 
            // s2
            // 
            this.s2.DataPropertyName = "SumRealiz2";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.s2.DefaultCellStyle = dataGridViewCellStyle9;
            this.s2.HeaderText = "Сумма";
            this.s2.Name = "s2";
            this.s2.ReadOnly = true;
            // 
            // n2
            // 
            this.n2.DataPropertyName = "SumNalog2";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.n2.DefaultCellStyle = dataGridViewCellStyle10;
            this.n2.HeaderText = "Налог";
            this.n2.Name = "n2";
            this.n2.ReadOnly = true;
            // 
            // t2
            // 
            this.t2.DataPropertyName = "SumTotal2";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.t2.DefaultCellStyle = dataGridViewCellStyle11;
            this.t2.HeaderText = "Всего";
            this.t2.Name = "t2";
            this.t2.ReadOnly = true;
            // 
            // dif1
            // 
            this.dif1.DataPropertyName = "DifQuantity";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = null;
            this.dif1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dif1.HeaderText = "Колич_разность";
            this.dif1.Name = "dif1";
            this.dif1.ReadOnly = true;
            // 
            // dif2
            // 
            this.dif2.DataPropertyName = "DifSum";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.dif2.DefaultCellStyle = dataGridViewCellStyle13;
            this.dif2.HeaderText = "Сумма_Разность";
            this.dif2.Name = "dif2";
            this.dif2.ReadOnly = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(61, 324);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(95, 23);
            this.btnExcel.TabIndex = 65;
            this.btnExcel.Text = "Экспорт";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FormReportCorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(892, 456);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtBegin);
            this.Controls.Add(this.dgv);
            this.Name = "FormReportCorrect";
            this.Text = "Отчет по корректировкам";
            this.Load += new System.EventHandler(this.FormReportCorrect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private DataSet.dsCalc dsCalc1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numabn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numfact;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefact;
        private System.Windows.Forms.DataGridViewTextBoxColumn q1;
        private System.Windows.Forms.DataGridViewTextBoxColumn s1;
        private System.Windows.Forms.DataGridViewTextBoxColumn n1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcor;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecor;
        private System.Windows.Forms.DataGridViewTextBoxColumn q2;
        private System.Windows.Forms.DataGridViewTextBoxColumn s2;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dif1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dif2;
        private System.Windows.Forms.Button btnExcel;
    }
}